using Dos.ORM;
using GGZY.Core.Log;
using GGZY.Services.Base;
using GGZYFW.DbEntity;
using MicroRuleEngine;
using Newtonsoft.Json;
using Quartz;
using Quartz.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GGZY.Scheduler.SupervisionService
{
    /// <summary>
    /// 监督点服务
    /// </summary>
    public class Main : GGZY.Services.Base.BaseServiceT<Dos.ORM.Entity>, IJob
    {
        DateTime LastCheckTime = new DateTime(2019, 3, 6);
        List<WARN_EXPRESSION> collection = new List<WARN_EXPRESSION>();
        public Task Execute(IJobExecutionContext context)
        {
            var action = "监督点检测服务";
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    Logger.Info(action + " 开始运行……");
                    //获取数据库时间作为时间戳
                    var timeSql = "SELECT SYSDATE FROM DUAL";
                    var CheckStartTime = FromSql(timeSql).ToScalar<DateTime>();

                    collection = Fw.WarnExpressionService.FindList(WARN_EXPRESSION._.ISDELETE == 0);
                    var sp_point_count = collection.Count;

                    var details = Fw.WarnExpressionDetailService.FindList(WARN_EXPRESSION_DETAIL._.ISDELETE == 0);

                    collection.GroupBy(g => g.SP_NAME).ToList().ForEach(e => {

                        collection.Where(w => w.SP_NAME == e.Key).ToList().ForEach(entity =>
                        {
                            Logger.Info("正在检测 " + entity.SP_NAME + ",M_ID:" + entity.M_ID);
                            var items = details.Where(w => w.PARENT_M_ID == entity.M_ID && w.EXPRESSION_TYPE != "附件").ToList();
                            if (items.Any())
                            {
                                Dictionary<string, List<TableConfig>> dicTables = new Dictionary<string, List<TableConfig>>();

                                items.ToList().ForEach(item =>
                                {
                                    BuildSqlDic(dicTables, item);
                                });
                                var dicSql = BuildSql(dicTables);
                                DataCheck(entity, dicSql, items);
                            }
                        });
                    });

                    Logger.Info(action + " 监督点个数：" + sp_point_count + ",监督规则数量：" + details.Count);
                }
                catch (Exception ex)
                {
                    Logger.Error(action + " 发生异常异常:" + ex.Message, ex);
                    while (null != ex.InnerException)
                    {
                        ex = ex.InnerException;
                        Logger.Error(action + "发生异常异常:" + ex.Message, ex);
                    }
                }
                finally
                {
                    Logger.Info(action + " 执行完毕");
                }
            });
        }

        /// <summary>
        /// 数据监督
        /// </summary>
        /// <param name="entity">监督点</param>
        /// <param name="dicSql">SQL数据字典</param>
        /// <param name="items">监督规则详情</param>
        protected void DataCheck(WARN_EXPRESSION entity, Dictionary<string, string> dicSql, List<WARN_EXPRESSION_DETAIL> items)
        {
            if (!dicSql.ContainsKey("sourceSql"))
            {
                return;
            }
            var t_name = "";
            var dtSource = new DataTable();
            try
            {
                dtSource = FromSql(dicSql["sourceSql"]).ToDataTable();
                Regex reg = new Regex(@"from\s+(?<TABLENAME>[^\s]*?)\s+", RegexOptions.IgnoreCase);
                Match m = reg.Match(dicSql["sourceSql"]);
                if (m.Success)
                {
                    t_name = m.Groups["TABLENAME"].Value;
                    dtSource.TableName = t_name;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(entity.SP_NAME + " 检测失败:" + ex.Message + ",源SQL:" + dicSql["sourceSql"], ex);
            }
            foreach (DataRow dr in dtSource.Rows)
            {
                try
                {

                    string projectCode = "";
                    string tenderProjectCode = "";
                    if (dr.Table.Columns.Contains("PROJECT_CODE") && null != dr["PROJECT_CODE"])
                    {
                        projectCode = dr["PROJECT_CODE"].ToString();
                    }
                    if (dr.Table.Columns.Contains("TENDER_PROJECT_CODE") && null != dr["TENDER_PROJECT_CODE"])
                    {
                        tenderProjectCode = dr["TENDER_PROJECT_CODE"].ToString();
                    }
                    var projectInfo = ProjectCheck(projectCode, tenderProjectCode);
                    var m_id = dr["M_ID"];
                    if (null == projectInfo)
                    {
                        Logger.Warn("项目注册信息不完整,TableName:" + dtSource.TableName + ",M_ID:" + m_id);
                        continue;
                    }
                    if (!entity.SP_POINT_TYPE.IsNullOrWhiteSpace() && !entity.SP_POINT_TYPE.Contains(projectInfo.TENDER_PROJECT_TYPE))
                    {
                        continue;
                    }
                    string tender_project_name = projectInfo.TENDER_PROJECT_NAME;
                    var sp_ids = FromSql("select TO_CHAR(SP_ID) from WARN_RESULT where isdelete=0 and TENDER_PROJECT_CODE='" + projectInfo.TENDER_PROJECT_CODE + "'")
                        .ToList<string>();

                    var checkCollection = collection.Where(w =>
                    (w.SP_POINT_TYPE.IsNullOrWhiteSpace() || w.SP_POINT_TYPE.Contains(projectInfo.TENDER_PROJECT_TYPE))
                    && !sp_ids.Contains(w.M_ID?.ToString())).ToList();
                    if (checkCollection.Any())
                    {
                        Logger.Info(tender_project_name + "\t" + tenderProjectCode + "\t正在初始化监督点.");
                        checkCollection.OrderBy(od => od.M_ID).ToList().ForEach(e =>
                        {

                            WARN_RESULT r = new WARN_RESULT();
                            r.M_ID = Guid.NewGuid().ToString().ToLower();
                            r.SP_ID = e.M_ID;
                            r.SP_TIME = null;
                            r.MAIN_M_ID = "";
                            r.LAST_RECORD_TIME = DateTime.Now;
                            r.PROJECT_CODE = projectInfo.PROJECT_CODE;
                            r.TENDER_PROJECT_CODE = projectInfo.TENDER_PROJECT_CODE;
                            r.BID_SECTION_CODE = projectInfo.BID_SECTION_CODE;
                            r.DATA_TIMESTAMP = DateTime.Now;
                            r.REGION_CODE = projectInfo.REGION_CODE;
                            r.TENDER_PROJECT_TYPE = projectInfo.TENDER_PROJECT_TYPE;
                            r.ISDELETE = 0;
                            r.RESULT_STATUS = "0";
                            Fw.WarnResultService.Add(r);
                        });
                    }

                    var result = Fw.WarnResultService.FirstOrNull(WARN_RESULT._.TENDER_PROJECT_CODE == projectInfo.TENDER_PROJECT_CODE
                        && WARN_RESULT._.SP_ID == entity.M_ID);
                    try
                    {
                        var warnDetail = items.Where(w => w.PARENT_M_ID == result.SP_ID).FirstOrDefault();

                        result.Attach();

                        result.SP_TIME = DateTime.Now;
                        result.MAIN_M_ID = null == warnDetail?.MAIN_TABLE ? m_id.ToString() : String.Concat(warnDetail.MAIN_TABLE, "$", m_id, ";");
                        result.LAST_RECORD_TIME = DateTime.Now;
                        result.DATA_TIMESTAMP = DateTime.Now;
                        result.REGION_CODE = projectInfo.REGION_CODE;
                        result.ISDELETE = 0;
                        result.RESULT_STATUS = "1";


                        WARN_RECORD record = new WARN_RECORD();
                        record.CREATE_TIME = DateTime.Now;
                        record.M_ID = Guid.NewGuid().ToString("N");
                        record.OPERATE_TYPE = "1";
                        record.OPERATOR = "系统";
                        record.SP_RESULT_ID = result.M_ID;
                        record.CONTENT = "满足监督规则";
                        record.REMARK = "";

                        if (!String.IsNullOrEmpty(entity.SQL))
                        {
                            string executeSql = entity.SQL.Replace("$code$", result.TENDER_PROJECT_CODE).Replace("$project_code$", result.PROJECT_CODE);

                            var dtPoints = FromSql(executeSql).ToDataTable();
                            var jsonStr = JsonConvert.SerializeObject(dtPoints);
                            var jsonArr = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonStr);


                            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"^\{.*\}$");
                            List<string> files = new List<string>();
                            if (jsonArr.Count > 0)
                            {
                                foreach (KeyValuePair<string, object> kvp in jsonArr[0])
                                {
                                    if (null != kvp.Value && !String.IsNullOrEmpty(kvp.Value.ToString()))
                                    {
                                        if (reg.IsMatch(kvp.Value.ToString().Trim()))
                                        {
                                            files.Add(kvp.Key);
                                        }
                                    }
                                }
                            }
                            result.CONTENT = JsonConvert.SerializeObject(jsonArr);
                        }

                        if (entity.SP_WAY == "人工监察")
                        {
                            Fw.WarnRecordService.Add(record);
                            Fw.WarnResultService.Update(result);
                            return;
                        }

                        if (!dicSql.ContainsKey("targetSql"))
                        {
                            MRE engine = new MRE();
                            MicroRuleEngine.Rule rule = null;

                            items.Where(w => w.EXPRESSION_TYPE != "附件").ToList().ForEach(item =>
                            {
                                System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"(?<=[as|AS]\s+)([^\s]*)");
                                var m = reg.Match(item.MAIN_FIELD);
                                if (m.Success)
                                {
                                    item.MAIN_FIELD = m.Value;
                                }
                                if (!String.IsNullOrEmpty(item.TARGET_FIELD))
                                {
                                    var mt = reg.Match(item.TARGET_FIELD);
                                    if (mt.Success)
                                    {
                                        item.TARGET_FIELD = mt.Value;
                                    }
                                }
                                string executeField = "";
                                if (!String.IsNullOrEmpty(item.EXECUTE_SQL))
                                {
                                    var mt = reg.Match(item.EXECUTE_SQL);
                                    if (mt.Success)
                                    {
                                        executeField = mt.Value;
                                    }
                                }

                                if (!String.IsNullOrEmpty(item.EXECUTE_SQL))
                                {
                                    var exesql = item.EXECUTE_SQL;
                                //针对复杂关联SQL处理
                                if (exesql.ToLower().Contains("{tender_project_code}"))
                                    {
                                        exesql = exesql.ToLower().Replace("{tender_project_code}", result.TENDER_PROJECT_CODE);
                                    }
                                    else
                                    {
                                        if (exesql.ToLower().Contains(" where "))
                                        {
                                            exesql += " and  TENDER_PROJECT_CODE = '" + result.TENDER_PROJECT_CODE + "'";
                                        }
                                        else
                                        {
                                            exesql += " where TENDER_PROJECT_CODE = '" + result.TENDER_PROJECT_CODE + "'";
                                        }
                                    }
                                    var dtExecute = FromSql(exesql).ToDataTable();
                                    foreach (DataRow drExecute in dtExecute.Rows)
                                    {
                                        if (null != dr[item.MAIN_FIELD] && !String.IsNullOrEmpty(dr[item.MAIN_FIELD].ToString()))
                                        {
                                            dr[item.MAIN_FIELD] = drExecute[0];
                                            break;
                                        }

                                    }
                                }

                                switch (item.EXPRESSION_TYPE)
                                {
                                    case "=":
                                        if (true)
                                        {

                                            if (!String.IsNullOrEmpty(item.CONST_STRING))
                                            {
                                                rule = DataRule.Create<string>(item.MAIN_FIELD, mreOperator.Equal, item.CONST_STRING);
                                            }
                                            if (!String.IsNullOrEmpty(item.CONST_NUMBER))
                                            {
                                                rule = DataRule.Create<decimal>(item.MAIN_FIELD, mreOperator.Equal, Convert.ToDecimal(item.CONST_NUMBER));
                                            }
                                            var func = engine.CompileRule<DataRow>(rule);
                                            if (!func(dr))
                                            {
                                                if (record.CONTENT == "满足监督规则")
                                                {
                                                    record.CONTENT = item.SP_NAME + " 未满足;";
                                                }
                                                else
                                                {
                                                    record.CONTENT += item.SP_NAME + " 未满足;";
                                                }
                                                result.RESULT_STATUS = entity.SP_STATUS;

                                                Logger.Warn(tender_project_name + "," + item.SP_NAME + " 未满足，mid:" + dr["M_ID"].ToString());
                                                return;
                                            }
                                        }
                                        return;
                                    case "required":
                                        if (null == dr[item.MAIN_FIELD] || String.IsNullOrEmpty(dr[item.MAIN_FIELD].ToString()))
                                        {
                                            if (record.CONTENT == "满足监督规则")
                                            {
                                                record.CONTENT = item.SP_NAME + " 未满足;";
                                            }
                                            else
                                            {
                                                record.CONTENT += item.SP_NAME + " 未满足;";
                                            }
                                            result.RESULT_STATUS = entity.SP_STATUS;

                                            Logger.Warn(tender_project_name + " " + item.SP_NAME + " 未满足，mid:" + dr["M_ID"].ToString());
                                        //预警
                                        return;
                                        }
                                        Logger.Info(tender_project_name + " " + item.SP_NAME + " 满足，mid:" + dr["M_ID"].ToString());
                                        break;
                                    case "contains":
                                        if (null == dr[item.MAIN_FIELD] || String.IsNullOrEmpty(dr[item.MAIN_FIELD].ToString()))
                                        {
                                            if (record.CONTENT == "满足监督规则")
                                            {
                                                record.CONTENT = item.SP_NAME + " 未满足;";
                                            }
                                            else
                                            {
                                                record.CONTENT += item.SP_NAME + " 未满足;";
                                            }
                                            result.RESULT_STATUS = entity.SP_STATUS;

                                            Logger.Warn(tender_project_name + " " + item.SP_NAME + " 未满足，mid:" + dr["M_ID"].ToString());
                                        //预警
                                        return;
                                        }
                                        if (!dr[item.MAIN_FIELD].ToString().Contains(item.CONST_STRING))
                                        {
                                            if (record.CONTENT == "满足监督规则")
                                            {
                                                record.CONTENT = item.SP_NAME + " 未满足;";
                                            }
                                            else
                                            {
                                                record.CONTENT += item.SP_NAME + " 未满足;";
                                            }
                                            result.RESULT_STATUS = entity.SP_STATUS;
                                            Logger.Warn(tender_project_name + " " + item.SP_NAME + " 未满足，mid:" + dr["M_ID"].ToString());
                                        //预警
                                        return;
                                        }
                                        Logger.Info(tender_project_name + " " + item.SP_NAME + " 满足，mid:" + dr["M_ID"].ToString());
                                        break;
                                    case "decimal =":
                                    case "decimal >=":
                                    case "decimal >":
                                    case "decimal <":
                                    case "decimal <=":
                                    case "datetime =":
                                    case "datetime >=":
                                    case "dateime >":
                                    case "datetime <":
                                    case "datetime <=":
                                        if (true)
                                        {
                                            if (!String.IsNullOrEmpty(item.CONST_NUMBER))
                                            {
                                                if (item.EXPRESSION_TYPE == "decimal =")
                                                {
                                                    rule = DataRule.Create<decimal>(item.MAIN_FIELD, mreOperator.Equal, Convert.ToDecimal(item.CONST_NUMBER));
                                                }
                                                if (item.EXPRESSION_TYPE == "decimal <=")
                                                {
                                                    rule = DataRule.Create<decimal>(item.MAIN_FIELD, mreOperator.LessThanOrEqual, Convert.ToDecimal(item.CONST_NUMBER));
                                                }
                                                if (item.EXPRESSION_TYPE == "decimal <")
                                                {
                                                    rule = DataRule.Create<decimal>(item.MAIN_FIELD, mreOperator.LessThan, Convert.ToDecimal(item.CONST_NUMBER));
                                                }
                                                if (item.EXPRESSION_TYPE == "decimal >=")
                                                {
                                                    rule = DataRule.Create<decimal>(item.MAIN_FIELD, mreOperator.GreaterThanOrEqual, Convert.ToDecimal(item.CONST_NUMBER));
                                                }
                                                if (item.EXPRESSION_TYPE == "decimal >")
                                                {
                                                    rule = DataRule.Create<decimal>(item.MAIN_FIELD, mreOperator.GreaterThan, Convert.ToDecimal(item.CONST_NUMBER));
                                                }
                                                var func = engine.CompileRule<DataRow>(rule);
                                                if (!func(dr))
                                                {
                                                    record.CONTENT += " " + item.SP_NAME + " 未满足";
                                                    result.RESULT_STATUS = entity.SP_STATUS;

                                                    Logger.Warn(tender_project_name + " " + item.SP_NAME + " 未满足条件.M_ID:" + dr["M_ID"].ToString());
                                                //预警
                                                return;
                                                }
                                                Logger.Info(tender_project_name + " " + item.SP_NAME + " 满足条件.M_ID:" + dr["M_ID"].ToString());
                                            //预警
                                            return;
                                            }

                                            if (item.MAIN_TABLE == item.TARGET_TABLE)
                                            {
                                                var dataTarget = dr[item.TARGET_FIELD].ToString();
                                                if (item.EXPRESSION_TYPE == "decimal <=")
                                                {
                                                    rule = DataRule.Create<decimal>(item.MAIN_FIELD, mreOperator.LessThanOrEqual, Convert.ToDecimal(dataTarget));
                                                }
                                                if (item.EXPRESSION_TYPE == "decimal <")
                                                {
                                                    rule = DataRule.Create<decimal>(item.MAIN_FIELD, mreOperator.LessThan, Convert.ToDecimal(dataTarget));
                                                }
                                                if (item.EXPRESSION_TYPE == "decimal >=")
                                                {
                                                    rule = DataRule.Create<decimal>(item.MAIN_FIELD, mreOperator.GreaterThanOrEqual, Convert.ToDecimal(dataTarget));
                                                }
                                                if (item.EXPRESSION_TYPE == "decimal >")
                                                {
                                                    rule = DataRule.Create<decimal>(item.MAIN_FIELD, mreOperator.GreaterThan, Convert.ToDecimal(dataTarget));
                                                }

                                                if (item.EXPRESSION_TYPE == "datetime <=")
                                                {
                                                    rule = DataRule.Create<DateTime>(item.MAIN_FIELD, mreOperator.LessThanOrEqual, Convert.ToDateTime(dataTarget));
                                                }
                                                if (item.EXPRESSION_TYPE == "datetime <")
                                                {
                                                    rule = DataRule.Create<DateTime>(item.MAIN_FIELD, mreOperator.LessThan, Convert.ToDateTime(dataTarget));
                                                }
                                                if (item.EXPRESSION_TYPE == "datetime >=")
                                                {
                                                    rule = DataRule.Create<DateTime>(item.MAIN_FIELD, mreOperator.GreaterThanOrEqual, Convert.ToDateTime(dataTarget));
                                                }
                                                if (item.EXPRESSION_TYPE == "datetime >")
                                                {
                                                    rule = DataRule.Create<DateTime>(item.MAIN_FIELD, mreOperator.GreaterThan, Convert.ToDateTime(dataTarget));
                                                }
                                                DataRule.Create<DateTime>(item.MAIN_FIELD, mreOperator.Add, dataTarget);
                                                var func = engine.CompileRule<DataRow>(rule);
                                                if (!func(dr))
                                                {
                                                    record.CONTENT += " " + item.SP_NAME + " 未满足";
                                                    result.RESULT_STATUS = entity.SP_STATUS;

                                                    Logger.Warn(tender_project_name + " " + item.SP_NAME + " 未满足，mid:" + dr["M_ID"].ToString());
                                                }
                                                Logger.Info(tender_project_name + " " + item.SP_NAME + " 满足，mid:" + dr["M_ID"].ToString());
                                            }
                                            break;
                                        }
                                }
                            });
                        }

                        if (dicSql.ContainsKey("targetSql"))
                        {


                            string sql = dicSql["targetSql"].ToString();
                            items.Where(w => w.EXPRESSION_TYPE != "附件").ToList().ForEach(item =>
                            {
                                MRE engine = new MRE();
                                MicroRuleEngine.Rule rule = null;

                                System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"(?<=[as|AS]\s+)([^\s]*)");
                                var m = reg.Match(item.MAIN_FIELD);
                                if (m.Success)
                                {
                                    item.MAIN_FIELD = m.Value;
                                }
                                if (!String.IsNullOrEmpty(item.TARGET_FIELD))
                                {
                                    var mt = reg.Match(item.TARGET_FIELD);
                                    if (mt.Success)
                                    {
                                        item.TARGET_FIELD = mt.Value;
                                    }
                                }
                                switch (item.EXPRESSION_TYPE)
                                {
                                    case "=":
                                        if (true)
                                        {
                                            if (!String.IsNullOrEmpty(item.CONST_STRING))
                                            {
                                                rule = DataRule.Create<string>(item.MAIN_FIELD, mreOperator.Equal, item.CONST_STRING);
                                                var func = engine.CompileRule<DataRow>(rule);
                                                if (!func(dr))
                                                {
                                                    if (record.CONTENT == "满足监督规则")
                                                    {
                                                        record.CONTENT = item.SP_NAME + " 未满足;";
                                                    }
                                                    else
                                                    {
                                                        record.CONTENT += item.SP_NAME + " 未满足;";
                                                    }
                                                    result.RESULT_STATUS = entity.SP_STATUS;

                                                    Logger.Warn(tender_project_name + " " + item.SP_NAME + " 未满足，mid:" + dr["M_ID"].ToString());
                                                    return;
                                                }
                                            }

                                            if (!String.IsNullOrEmpty(item.TARGET_TABLE) && !String.IsNullOrEmpty(item.TARGET_FIELD))
                                            {
                                                var dtTarget = FromSql(sql + " where TENDER_PROJECT_CODE='" + tenderProjectCode + "'")
                                                .ToDataTable();
                                                if (dtTarget.Rows.Count == 0)
                                                {
                                                    if (record.CONTENT == "满足监督规则")
                                                    {
                                                        record.CONTENT = item.SP_NAME + " 未满足;";
                                                    }
                                                    else
                                                    {
                                                        record.CONTENT += item.SP_NAME + " 未满足;";
                                                    }
                                                    result.RESULT_STATUS = entity.SP_STATUS;

                                                    Logger.Warn(tender_project_name + " " + item.SP_NAME + " 未满足，mid:" + dr["M_ID"].ToString());
                                                    return;
                                                }
                                                var isEqual = (null == dr[item.MAIN_FIELD] || null == dtTarget.Rows[0][item.TARGET_FIELD]) ? false :
                                                dr[item.MAIN_FIELD].ToString() == dtTarget.Rows[0][item.TARGET_FIELD].ToString();
                                            //rule = DataRule.Create<string>(item.MAIN_FIELD, mreOperator.Equal, dtTarget.Rows[0][item.TARGET_FIELD].ToString());
                                            //var func = engine.CompileRule<DataRow>(rule);
                                            if (!isEqual)
                                                {
                                                    if (record.CONTENT == "满足监督规则")
                                                    {
                                                        record.CONTENT = item.SP_NAME + " 未满足;";
                                                    }
                                                    else
                                                    {
                                                        record.CONTENT += item.SP_NAME + " 未满足;";
                                                    }
                                                    result.RESULT_STATUS = entity.SP_STATUS;

                                                    Logger.Warn(tender_project_name + " " + item.SP_NAME + " 未满足，mid:" + dr["M_ID"].ToString());
                                                    return;
                                                }
                                            }

                                            if (!String.IsNullOrEmpty(item.EXECUTE_SQL))
                                            {
                                                var EXECUTE_SQL = item.EXECUTE_SQL.ToUpper().Replace("{TENDER_PROJECT_CODE}", dr["TENDER_PROJECT_CODE"].ToString());
                                                var dtTarget = FromSql(EXECUTE_SQL).ToDataTable();
                                                if (dtTarget.Rows.Count == 0)
                                                {
                                                    if (record.CONTENT == "满足监督规则")
                                                    {
                                                        record.CONTENT = item.SP_NAME + " 未满足;";
                                                    }
                                                    else
                                                    {
                                                        record.CONTENT += item.SP_NAME + " 未满足;";
                                                    }
                                                    result.RESULT_STATUS = entity.SP_STATUS;

                                                    Logger.Warn(item.SP_NAME + " 未满足，mid:" + dr["M_ID"].ToString());
                                                    return;
                                                }
                                                rule = DataRule.Create<string>(item.MAIN_FIELD, mreOperator.Equal, dtTarget.Rows[0][item.TARGET_FIELD].ToString());
                                                var func = engine.CompileRule<DataRow>(rule);
                                                if (!func(dr))
                                                {
                                                    if (record.CONTENT == "满足监督规则")
                                                    {
                                                        record.CONTENT = item.SP_NAME + " 未满足;";
                                                    }
                                                    else
                                                    {
                                                        record.CONTENT += item.SP_NAME + " 未满足;";
                                                    }
                                                    result.RESULT_STATUS = entity.SP_STATUS;

                                                    Logger.Warn(item.SP_NAME + " 未满足，mid:" + dr["M_ID"].ToString());
                                                    return;
                                                }
                                            }
                                            Logger.Info(tender_project_name + " " + item.SP_NAME + " 满足，mid:" + dr["M_ID"].ToString());
                                        }
                                        break;
                                    case "decimal >=":
                                    case "decimal >":
                                    case "decimal <":
                                    case "decimal <=":
                                    case "datetime >=":
                                    case "dateime >":
                                    case "datetime <":
                                    case "datetime <=":
                                        if (true)
                                        {
                                            if (!String.IsNullOrEmpty(item.TARGET_TABLE) && !String.IsNullOrEmpty(item.TARGET_FIELD))
                                            {
                                                var dtTarget = FromSql(sql + " where TENDER_PROJECT_CODE='" + tenderProjectCode + "'")
                                                .ToDataTable();
                                                if (dtTarget.Rows.Count == 0)
                                                {
                                                    if (record.CONTENT == "满足监督规则")
                                                    {
                                                        record.CONTENT = item.SP_NAME + " 未满足;";
                                                    }
                                                    else
                                                    {
                                                        record.CONTENT += item.SP_NAME + " 未满足;";
                                                    }
                                                    result.RESULT_STATUS = entity.SP_STATUS;

                                                    Logger.Warn(tender_project_name + " " + item.SP_NAME + " 未满足，mid:" + dr["M_ID"].ToString());
                                                    return;
                                                }
                                                var dataTarget = dtTarget.Rows[0][item.TARGET_FIELD].ToString();
                                                if (item.EXPRESSION_TYPE == "decimal <=")
                                                {
                                                    rule = DataRule.Create<decimal>(item.MAIN_FIELD, mreOperator.LessThanOrEqual, Convert.ToDecimal(dataTarget));
                                                }
                                                if (item.EXPRESSION_TYPE == "decimal <")
                                                {
                                                    rule = DataRule.Create<decimal>(item.MAIN_FIELD, mreOperator.LessThan, Convert.ToDecimal(dataTarget));
                                                }
                                                if (item.EXPRESSION_TYPE == "decimal >=")
                                                {
                                                    rule = DataRule.Create<decimal>(item.MAIN_FIELD, mreOperator.GreaterThanOrEqual, Convert.ToDecimal(dataTarget));
                                                }
                                                if (item.EXPRESSION_TYPE == "decimal >")
                                                {
                                                    rule = DataRule.Create<decimal>(item.MAIN_FIELD, mreOperator.GreaterThan, Convert.ToDecimal(dataTarget));
                                                }

                                                if (item.EXPRESSION_TYPE == "datetime <=")
                                                {
                                                    rule = DataRule.Create<DateTime>(item.MAIN_FIELD, mreOperator.LessThanOrEqual, Convert.ToDateTime(dataTarget));
                                                }
                                                if (item.EXPRESSION_TYPE == "datetime <")
                                                {
                                                    rule = DataRule.Create<DateTime>(item.MAIN_FIELD, mreOperator.LessThan, Convert.ToDateTime(dataTarget));
                                                }
                                                if (item.EXPRESSION_TYPE == "datetime >=")
                                                {
                                                    rule = DataRule.Create<DateTime>(item.MAIN_FIELD, mreOperator.GreaterThanOrEqual, Convert.ToDateTime(dataTarget));
                                                }
                                                if (item.EXPRESSION_TYPE == "datetime >")
                                                {
                                                    rule = DataRule.Create<DateTime>(item.MAIN_FIELD, mreOperator.GreaterThan, Convert.ToDateTime(dataTarget));
                                                }
                                            //DataRule.Create<DateTime>(item.MAIN_FIELD, mreOperator.Add, dataTarget);
                                            var func = engine.CompileRule<DataRow>(rule);
                                            //Logger.Fatal("测试数据：" + item.SP_NAME + "，mid:" + dr["M_ID"].ToString());
                                            if (!func(dr))
                                                {
                                                    if (record.CONTENT == "满足监督规则")
                                                    {
                                                        record.CONTENT = item.SP_NAME + " 未满足;";
                                                    }
                                                    else
                                                    {
                                                        record.CONTENT += item.SP_NAME + " 未满足;";
                                                    }
                                                    result.RESULT_STATUS = entity.SP_STATUS;

                                                    Logger.Warn(tender_project_name + " " + item.SP_NAME + " 未满足，mid:" + dr["M_ID"].ToString());
                                                    return;
                                                }
                                            }
                                            Logger.Info(tender_project_name + " " + item.SP_NAME + " 满足，mid:" + dr["M_ID"].ToString());

                                        }
                                        break;
                                    default:
                                        break;
                                }
                            });
                        }

                        Fw.WarnRecordService.Add(record);
                        Fw.WarnResultService.Update(result);
                    }
                    catch (Exception ex)
                    {
                        Logger.Error(tender_project_name + "\t" + entity.SP_NAME + ",监督点id:" + entity.M_ID + " 异常.", ex);
                    }
                }
                catch(Exception exx)
                {
                    Logger.Error("监督点服务异常：" + exx.Message, exx);
                }
            }
        }


        /// <summary>
        /// 项目注册信息完整性检测
        /// </summary>
        public V_PROJECT_REGISTER ProjectCheck(string projectCode = "", string tenderProjectCode = "")
        {
            var conditon = new WhereClipBuilder();
            conditon.And(V_PROJECT_REGISTER._.M_KEY.IsNotNull());
            if (!String.IsNullOrEmpty(projectCode))
            {
                conditon.And(V_PROJECT_REGISTER._.PROJECT_CODE == projectCode);
            }
            if (!String.IsNullOrEmpty(tenderProjectCode))
            {
                conditon.And(V_PROJECT_REGISTER._.TENDER_PROJECT_CODE == tenderProjectCode);
            }
            return Fw.VProjectRegisterService.FirstOrNull(conditon.ToWhereClip());
        }

        /// <summary>
        /// 根据监督规则，提取数据表以及字段信息
        /// </summary>
        /// <param name="dicTables">数据表以及字段信息字典</param>
        /// <param name="item">监督规则详情</param>
        protected void BuildSqlDic(Dictionary<string, List<TableConfig>> dicTables, WARN_EXPRESSION_DETAIL item)
        {
            BuildSourceSqlDic(dicTables, item);
            BuildTargetSqlDic(dicTables, item);

            item.Attach();
            item.CHECK_TIME = GetDBTime();
            Fw.WarnExpressionDetailService.Update(item);
        }

        protected void BuildSourceSqlDic(Dictionary<string, List<TableConfig>> dicTables, WARN_EXPRESSION_DETAIL item)
        {
            if (String.IsNullOrEmpty(item.MAIN_TABLE) || String.IsNullOrEmpty(item.MAIN_FIELD))
            {
                return;
            }

            if (!dicTables.ContainsKey("sourceTable"))
            {
                dicTables.Add("sourceTable", new List<TableConfig>());
            }
            var sourceTable = dicTables["sourceTable"];

            if (!sourceTable.Where(w => w.TableName == item.MAIN_TABLE).Any())
            {
                if (item.MAIN_TABLE != "PROJECT")
                {
                    if (item.TARGET_TABLE == item.MAIN_TABLE)
                    {
                        sourceTable.Add(new TableConfig
                        {
                            TableName = item.MAIN_TABLE,
                            TableField = "M_ID,TENDER_PROJECT_CODE," + item.MAIN_FIELD + "," + item.TARGET_FIELD,
                            Check_Time = item.CHECK_TIME
                        });
                        return;
                    }
                    sourceTable.Add(new TableConfig
                    {
                        TableName = item.MAIN_TABLE,
                        TableField = "M_ID,TENDER_PROJECT_CODE," + item.MAIN_FIELD,
                        Check_Time = item.CHECK_TIME
                    });
                    return;
                }

                sourceTable.Add(new TableConfig
                {
                    TableName = item.MAIN_TABLE,
                    TableField = "M_ID,PROJECT_CODE," + item.MAIN_FIELD,
                    Check_Time = item.CHECK_TIME
                });
                return;
            }

            if (sourceTable.Where(w => w.TableName == item.MAIN_TABLE).First().TableField != null
                && sourceTable.Where(w => w.TableName == item.MAIN_TABLE).First().TableField.Split(new char[] { ',', '，' },
                StringSplitOptions.RemoveEmptyEntries).Contains(item.MAIN_FIELD))
            {
                var entity = sourceTable.Where(w => w.TableName == item.MAIN_TABLE).FirstOrDefault();
                entity.Check_Time = item.CHECK_TIME;
                if (item.TARGET_TABLE == item.MAIN_TABLE)
                {
                    entity.TableField += "," + item.MAIN_FIELD + "," + item.TARGET_FIELD;
                    return;
                }
                entity.TableField += "," + item.MAIN_FIELD;
            }
        }

        protected void BuildTargetSqlDic(Dictionary<string, List<TableConfig>> dicTables, WARN_EXPRESSION_DETAIL item)
        {
            if (String.IsNullOrEmpty(item.TARGET_TABLE) || String.IsNullOrEmpty(item.TARGET_FIELD))
            {
                return;
            }
            if (item.MAIN_TABLE == item.TARGET_TABLE)
            {
                return;
            }
            if (!dicTables.ContainsKey("targetTable"))
            {
                dicTables.Add("targetTable", new List<TableConfig>());
            }
            var targetTable = dicTables["targetTable"];

            if (!targetTable.Where(w => w.TableName == item.TARGET_TABLE).Any())
            {
                targetTable.Add(new TableConfig
                {
                    TableName = item.TARGET_TABLE,
                    TableField = item.TARGET_FIELD,
                    Check_Time = item.CHECK_TIME
                });
            }
        }

        /// <summary>
        /// 根据已提取的数据表以及字段，生成提取数据SQL语句
        /// </summary>
        /// <param name="dicTables">数据表以及字段信息字典</param>
        /// <returns></returns>
        protected Dictionary<string, string> BuildSql(Dictionary<string, List<TableConfig>> dicTables)
        {
            Dictionary<string, string> dicSql = new Dictionary<string, string>();
            //string strWhere = " where (sysdate- M_TM)*60*60*24 <=" + IntervalSecond.ToString();

            if (dicTables.ContainsKey("sourceTable"))
            {
                StringBuilder sb = new StringBuilder();
                var dicSource = dicTables["sourceTable"];
                foreach (var kvp in dicSource)
                {
                    string strWhere = "";
                    if (kvp.Check_Time.HasValue)
                    {
                        strWhere = " where M_TM >=to_date('" + kvp.Check_Time.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-MM-dd HH24:Mi:ss')";
                    }
                    if (dicSource.Count > 1)
                    {
                        sb.AppendLine(String.Concat("select ", kvp.TableField, " from ", kvp.TableName + " ", strWhere, ";"));
                    }
                    else
                    {
                        sb.AppendLine(String.Concat("select ", kvp.TableField, " from ", kvp.TableName + " ", strWhere));
                    }
                }
                dicSql.Add("sourceSql", sb.ToString());
            }

            if (dicTables.ContainsKey("targetTable"))
            {
                StringBuilder sb = new StringBuilder();
                var dicTarget = dicTables["targetTable"];
                foreach (var kvp in dicTarget)
                {
                    if (kvp.TableName != "T_ATTACHMENT")
                    {
                        sb.AppendLine(String.Concat("select ", kvp.TableField, " from ", kvp.TableName));
                    }
                    else
                    {
                        sb.AppendLine(String.Concat("select M_KEY  from ", kvp.TableName));
                    }
                }
                dicSql.Add("targetSql", sb.ToString());
            }
            return dicSql;
        }
    }
}
