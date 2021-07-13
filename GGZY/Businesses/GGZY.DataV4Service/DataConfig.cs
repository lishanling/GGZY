using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using GGZY.DataV4Service.Db;
using Newtonsoft.Json;
using GGZY.DataV4Service.Dto;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;
using GGZY.DataV4Service.Logger;
using GGZY.DataV4Service.Validators;
using GGZY.DataV4Service.Validators.Context.Field;
using GGZY.DataV4Service.Validators.Context.Field.Imp;
using GGZY.DataV4Service.Validators.Context.Table;

namespace GGZY.DataV4Service
{
    public class DataField
    {
        public string Name { get; set; }
        public string CnName { get; set; }
        public List<ValidatorDictionary> Validators { get; set; }

    }
    public class DataConfig
    {
        public string Version { get; set; }
        public string DataNo { get; set; }

        /// <summary>
        /// 数据英文名，与DATA_NO匹配
        /// </summary>
        public string DataName { get; set; }

        /// <summary>
        /// 数据中文名
        /// </summary>
        public string DataCnName { get; set; }

        /// <summary>
        /// 对应的数据库表名
        /// 表名有长度的限制，有些数据的表名和数据库不同
        /// </summary>
        public string TableName
        {
            get
            {
                var tableDict = new Dictionary<string, string>
                {
                    {"DEA_SEWAGE_PAID_TRANSFER_RESULT", "DEA_SEWAGE_PAID_TRANSFER_RES"}
                };
                return tableDict.GetStringValue(DataName, DataName);
            }
        }

        public bool IsSaveGGFW()
        {
            return IsZXSJ && !string.IsNullOrEmpty(GgfwDataNo);
        }

        /// <summary>
        /// 是否专项数据
        /// </summary>
        public bool IsZXSJ { get; set; }

        public string GgfwDataNo { get; set; }

        public DataConfig GgfwDataConfig { get; set; }


        public DAO Dao { get; set; }

        public string M_KEY_Field
        {
            get { return IsZXSJ ? Constant.DATA_KEY : Constant.M_KEY; }
        }
        /// <summary>
        /// 数据的字段验证器列表
        /// </summary>
        public List<DataField> Fields { get; set; }

        /// <summary>
        /// 数据表验证器列表
        /// </summary>
        public List<ValidatorDictionary> Validators { get; set; }
        public List<string> RepeatCols { get; set; }

        public DataConfig()
        {
            Fields = new List<DataField>();
            Validators = new List<ValidatorDictionary>();
            RepeatCols = new List<string>();
        }

        public void Validate(DataTable dtTitle, DataTable dtContext)
        {
            var dataType = dtTitle.GetIntValue(Constant.DATA_TYPE);
            if (dataType == 3) return;

            //先验证数据字段
            foreach (var field in Fields)
            {
                foreach (var fieldValidator in field.Validators)
                {
                    var validator = fieldValidator.Validator;
                    validator?.Validate(dtTitle, dtContext);
                }
            }
            foreach (var tableValidator in Validators)
            {
                tableValidator.Validator?.Validate(dtTitle, dtContext);
            }


        }
        /// <summary>
        /// 根据配置文件中的重复数据验证字段判断数据是否重复
        /// </summary>
        /// <param name="dtContext"></param>
        public void ValidateRepeat(DataTable dtContext)
        {
            if (RepeatCols != null && RepeatCols.Count > 0)
            {
                List<string> cols = new List<string>();
                foreach (string col in this.RepeatCols)
                {
                    cols.Add($"{col} = '{dtContext.GetStringValue(col)}'");
                }

                string sql = $"SELECT {M_KEY_Field} FROM {this.DataName} WHERE {string.Join(" AND ", cols)} and {M_KEY_Field} is not null";
                DataTable dt = this.Dao.GetDataSet(sql).Tables[0];
                string tip = dt.Rows.Count > 0 ? dt.Rows[0][0].ToString() : "";
                ThrowHelper.ThrowIfTure(dt.Rows.Count > 0, $"[{DataName}]存在重复数据，重复DATA_KEY:{tip}，请确认！");
            }
        }
        /// <summary>
        /// 只验证值域，用于专项数据获取通用的配置文件验证
        /// </summary>
        /// <param name="dtTitle"></param>
        /// <param name="dtContext"></param>
        public void ValidateDoMainOnly(DataTable dtTitle, DataTable dtContext)
        {
            var dataType = dtTitle.GetIntValue(Constant.DATA_TYPE);
            if (dataType == 3) return;

            //验证值域和枚举数据字段
            foreach (var field in Fields)
            {
                foreach (var fieldValidator in field.Validators)
                {
                    var validator = fieldValidator.Validator;
                    if (validator != null && ("DomainMatch".Equals(validator.GetName()) ||
                                             "EnumMatch".Equals(validator.GetName())))
                    {
                        validator.Validate(dtTitle, dtContext);
                    }
                }
            }
        }

        public void SaveData_Param(DataTable dtTitle, DataTable dtContext, Dictionary<string, string> fileDict, string version, string tableName, string systemNo, DAO dao)
        {
            var columnList = GetTableColumns(tableName, dao);
            var dataType = dtTitle.GetIntValue("DATA_TYPE");
            var dataKey = dtTitle.GetStringValue(Constant.DATA_KEY);
            List<OracleParameter> listParam = null;
            List<Dictionary<string, object>> dicBacks = new List<Dictionary<string, object>>();
            string databack = "";
            string executeSql = "";
            string plateFormCode = dtContext != null && dtContext.Rows.Count > 0 ? dtContext.Rows[0]["PLATFORM_CODE"].ToString() : "";


            if (dataType == 1)
            {
                //insert
                var insertSql = GetInsertSql_Param(columnList, dtTitle, dtContext, fileDict, version, tableName, dao, out listParam);
                executeSql = insertSql;

                //先按参数长度倒序，避免替换时，前缀相同参数处理错误，如 Tender_Name,Tender_Name_Code
                listParam.OrderByDescending(od => od.ParameterName.Length).ToList().ForEach(p =>
                {
                    switch (p.OracleType)
                    {
                        case OracleType.Char:
                        case OracleType.LongVarChar:
                        case OracleType.NChar:
                        case OracleType.VarChar:
                        case OracleType.NVarChar:
                        case OracleType.DateTime:
                        case OracleType.Clob:
                        case OracleType.NClob:
                            executeSql = executeSql.Replace(p.ParameterName, "'" + p.Value.ToString().Replace("'", "''") + "'");
                            break;
                        default:
                            executeSql = executeSql.Replace(p.ParameterName, p.Value.ToString());
                            break;
                    }
                });
                StrongLogger.Debug(systemNo, dataKey, $"添加数据，insertSql:" + executeSql);

                executeSql = executeSql.Replace("&", "chr(38)");
                StrongLogger.Debug(systemNo, dataKey, $"{dataKey}数据开始插入");
                var result = dao.ExecuteSql(insertSql, listParam.ToArray());
                StrongLogger.Debug(systemNo, dataKey, $"{dataKey}数据插入成功");
                ThrowHelper.ThrowIfTure(result == 0, "数据库插入失败");
            }
            else if (dataType == 2)
            {
                //update
                var updateSql = GetUpdateSql_Param(columnList, dtTitle, dtContext, fileDict, tableName, out listParam);
                executeSql = updateSql;
                StrongLogger.Debug(systemNo, dataKey, $"更新数据，updateSql:{updateSql}");

                //先按参数长度倒序，避免替换时，前缀相同参数处理错误，如 Tender_Name,Tender_Name_Code
                listParam.OrderByDescending(od => od.ParameterName.Length).ToList().ForEach(p =>
                {
                    switch (p.OracleType)
                    {
                        case OracleType.Char:
                        case OracleType.LongVarChar:
                        case OracleType.NChar:
                        case OracleType.VarChar:
                        case OracleType.NVarChar:
                        case OracleType.DateTime:
                        case OracleType.Clob:
                        case OracleType.NClob:
                            executeSql = executeSql.Replace(p.ParameterName, "'" + p.Value.ToString().Replace("'", "''") + "'");
                            break;
                        default:
                            executeSql = executeSql.Replace(p.ParameterName, p.Value.ToString());
                            break;
                    }
                });

                var databackSql = $"select * from {tableName} where {M_KEY_Field}='{dtTitle.GetStringValue(Constant.DATA_KEY)}'";
                var dtBack = dao.GetDataSet(databackSql).Tables[0];
                if (null != dtBack)
                {
                    databack = JsonConvert.SerializeObject(dtBack);
                    dicBacks = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(databack);
                }
                var result = dao.ExecuteSql(updateSql, listParam.ToArray());
                ThrowHelper.ThrowIfTure(result == 0, "数据库更新失败");
            }
            else if (dataType == 3)
            {
                //ThrowHelper.ThrowIfTure(true, "目前接口已无法删除，请联系公共服务平台工作人员");
                //delete
                var deleteSql = $"delete from {tableName} where {M_KEY_Field}='{dtTitle.GetStringValue(Constant.DATA_KEY)}'";
                executeSql = deleteSql;
                StrongLogger.Debug(systemNo, dataKey, $"删除数据，deleteSql:{deleteSql}");
                var databackSql = $"select * from {tableName} where {M_KEY_Field}='{dtTitle.GetStringValue(Constant.DATA_KEY)}'";
                var dtBack = dao.GetDataSet(databackSql).Tables[0];
                if (null != dtBack)
                {
                    databack = JsonConvert.SerializeObject(dtBack);
                    dicBacks = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(databack);
                }

                var result = dao.ExecSql(deleteSql);
                ThrowHelper.ThrowIfTure(result == false, "数据库删除失败");
                //                result = dao.ExecSql("UPDATE T_TRANS_LOG SET PREPAREDELETE=1 WHERE M_KEY='" +
                //                                dtTitle.GetStringValue(Constant.DATA_KEY) + "'");
                //                ThrowHelper.ThrowIfTure(result == false, "[T_TRANS_LOG]更新失败");
            }
            StrongLogger.Debug(systemNo, dataKey, $"{dataKey}远程日志开始");
            RemoteLog(dataKey, plateFormCode, tableName, dataType, dtContext != null ? dtContext.GetStringValue("TENDER_PROJECT_CODE") : "", executeSql, dicBacks);
            StrongLogger.Debug(systemNo, dataKey, $"{dataKey}远程日志结束");
            if (dataType != 3)
            {
                if (IsZXSJ)
                {
                    var tenderSql = "";
                    var type = tableName.Substring(0, 2);
                    var projectList = new List<string> { "ZJ_PROJECT", "SL_PROJECT", "JT_PROJECT" };
                    if (projectList.Contains(tableName))
                    {
                        //相同的招标项目编号相关联的项目表的更新时间OTHER_UPDATE_TIME
                        tenderSql = "UPDATE " + type + "_TENDER_PROJECT SET OTHER_UPDATE_TIME=TO_DATE('"
                                    + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-mm-dd HH24:mi:ss') " +
                                    "WHERE PROJECT_CODE='" + dtContext.GetStringValue("PROJECT_CODE") + "'";
                    }
                    else
                    {
                        //相同的招标项目编号相关联的其他表新增时，更新招标项目表的更新时间OTHER_UPDATE_TIME
                        tenderSql = "UPDATE " + type + "_TENDER_PROJECT SET OTHER_UPDATE_TIME=TO_DATE('"
                                    + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-mm-dd HH24:mi:ss') " +
                                    "WHERE TENDER_PROJECT_CODE='" + dtContext.GetStringValue("TENDER_PROJECT_CODE") + "'";
                    }
                    StrongLogger.Debug(systemNo, dataKey, $"更新招标项目，tenderSql:{tenderSql}");
                    var result = dao.ExecSql(tenderSql);
                }
                else
                {
                    var tenderSql = "";
                    var projectList = new List<string> { "PROJECT" };
                    if (projectList.Contains(tableName))
                    {
                        //相同的招标项目编号相关联的项目表的更新时间OTHER_UPDATE_TIME
                        tenderSql = "UPDATE TENDER_PROJECT SET OTHER_UPDATE_TIME=TO_DATE('"
                                    + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-mm-dd HH24:mi:ss') " +
                                    "WHERE PROJECT_CODE='" + dtContext.GetStringValue("PROJECT_CODE") + "'";
                    }
                    else
                    {
                        //相同的招标项目编号相关联的其他表新增时，更新招标项目表的更新时间OTHER_UPDATE_TIME
                        tenderSql = "UPDATE TENDER_PROJECT SET OTHER_UPDATE_TIME=TO_DATE('"
                                    + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-mm-dd HH24:mi:ss') " +
                                    "WHERE TENDER_PROJECT_CODE='" + dtContext.GetStringValue("TENDER_PROJECT_CODE") + "'";
                    }
                    StrongLogger.Debug(systemNo, dataKey, $"更新招标项目，tenderSql:{tenderSql}");
                    var result = dao.ExecSql(tenderSql);
                }

                DoAfterSaveData(dtTitle, dtContext);
            }
        }
        protected static string logServer = System.Configuration.ConfigurationManager.AppSettings["LogServer"];
        protected static string LogAppid = System.Configuration.ConfigurationManager.AppSettings["LogAppid"];
        /// <summary>
        /// 远程日志记录
        /// </summary>
        public void RemoteLog(string requestid, string plateFormCode, string tableName, int dataType, string PROJECT_CODE, string ExecuteSql, List<Dictionary<string, object>> DataBack)
        {
            try
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("plateform_Code", plateFormCode);
                dic.Add("projectCode", PROJECT_CODE);
                dic.Add("executeSql", ExecuteSql);
                dic.Add("dataType", dataType);
                switch (dataType)
                {
                    case 1:
                        dic.Add("dataTypeDesc", "增加");
                        break;
                    case 2:
                        dic.Add("dataTypeDesc", "修改");
                        dic.Add("dataBackup", DataBack);
                        break;
                    case 3:
                        dic.Add("dataTypeDesc", "删除");
                        dic.Add("dataBackup", DataBack);
                        break;
                }

                dic.Add("timestamp", DateTime.Now);
                /*try
                {
                    dic.Add("ip", WebUtil.ClientIP);
                    dic.Add("port", WebUtil.Port);
                }
                catch (Exception ex)
                {
                    StrongLogger.Error(requestid, requestid, "提交日志数据失败,获取客户端端口号失败:" + ex.Message, ex);
                }*/


                /*                var entity = new Dictionary<string, object>();
                                entity.Add("requestid", requestid);
                                entity.Add("appid", LogAppid);
                                entity.Add("level", "INFO");
                                entity.Add("data", dic);*/
                QueueLogRecord.Instance.Enqueue(requestid, "1", dic, null);
                //try
                //{
                //PostData(logServer, JsonConvert.SerializeObject(entity), requestid, PROJECT_CODE);
                //var dicResult = JsonConvert.DeserializeObject<Dictionary<string, object>>(result);
                //ThrowHelper.ThrowIfTure(Convert.ToBoolean(dicResult["result"]) == false, "日志信息上报失败，日志系统返回:" + result);
            }
            catch (Exception ex)
            {
                StrongLogger.Error(requestid, requestid, "提交日志数据失败", ex);
            }
        }
        public void DoAfterSaveData(DataTable dtTitle, DataTable dtContext)
        {
            //执行额外的更新操作
            foreach (var tableValidator in Validators)
            {
                //为了减少代码，直接使用数据表验证器执行后续更新数据的操作
                var validator = tableValidator.Validator as AbstractTableValidator;
                validator?.DoAfterSaveData(dtTitle, dtContext);
            }


        }

        /// <summary>以Post数据的方式获取网页内容
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postString"></param>
        /// <param name="EncodeCode">编码</param>
        /// <param name="appkey">head中对应的appkey的值</param> 
        /// <returns></returns>
        public static void PostData(string url, string postString, string requestid, string projectno)
        {
            /*WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            byte[] postData = Encoding.UTF8.GetBytes(postString);//编码，尤其是汉字，事先要看下抓取网页的编码方式  
            webClient.Headers.Add("Content-Type", "application/json");//采取POST方式必须加的header，如果改为GET方式的话就去掉这句话即可  
            var responseData = webClient.UploadData(url, "POST", postData);//得到返回字符流 
            var result = Encoding.UTF8.GetString(responseData);*/
            var t = Task.Factory.StartNew(() =>
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                byte[] postData = Encoding.UTF8.GetBytes(postString);//编码，尤其是汉字，事先要看下抓取网页的编码方式  
                webClient.Headers.Add("Content-Type", "application/json");//采取POST方式必须加的header，如果改为GET方式的话就去掉这句话即可  
                var responseData = webClient.UploadData(url, "POST", postData);//得到返回字符流 
                var result = Encoding.UTF8.GetString(responseData);
                //Thread.Sleep(100);
            });
            t.Start();
        }
        public void ChangeT_UPLOAD(string M_KEY, string opType)
        {
            //更新T_UPLOAD表状态
            string sql = "select * from T_UPLOAD where DATA_KEY='" + M_KEY.ToClearSql() + "'";
            DataTable dt = DAO.GGFW.GetDataSet(sql).Tables[0];
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                string PRE_STATUS = (dr["PRE_STATUS"] ?? "").ToString().Trim();
                if (PRE_STATUS == "")
                {
                    PRE_STATUS = "1";
                }
                string NOW_STATUS = "";

                #region 修改 NOW_STATUS 值
                if (PRE_STATUS == "1")
                {
                    //上次上报状态为  添加操作
                    if (opType == "1" || opType == "2")
                    {
                        //添加与修改 都将标记为 修改
                        NOW_STATUS = "2";
                    }
                    else if (opType == "3")
                    {
                        NOW_STATUS = "3";
                    }
                }
                else if (PRE_STATUS == "2")
                {
                    //上次上报状态为  修改操作
                    if (opType == "1" || opType == "2")
                    {
                        //添加与修改 都将标记为 修改
                        NOW_STATUS = "2";
                    }
                    else if (opType == "3")
                    {
                        NOW_STATUS = "3";
                    }
                }
                else if (PRE_STATUS == "3")
                {
                    //上次上报状态为  删除操作
                    if (opType == "1" || opType == "2")
                    {
                        //添加与修改 都将标记为 新增
                        NOW_STATUS = "1";
                    }
                    else if (opType == "3")
                    {
                        NOW_STATUS = "3";
                    }
                }
                #endregion

                sql = "UPDATE T_UPLOAD SET NOW_STATUS='" + NOW_STATUS + "',IS_SENDED='0',UPDATE_TIME=sysdate where DATA_KEY='" + M_KEY.ToClearSql() + "'";

                DAO.GGFW.ExecSql(sql);
            }

        }
        private List<TableColumn> GetTableColumns(string tableName, DAO dao)
        {
            //获取表格所有字段以及字段类型
            var sql = $"select * from user_tab_columns where Table_Name = '{tableName}' " +
                      "order by column_name";
            var columnDt = dao.GetDataSet(sql).Tables[0];
            var list = new List<TableColumn>();
            for (var i = 0; i < columnDt.Rows.Count; i++)
            {
                var row = columnDt.Rows[i];
                var colName = row["COLUMN_NAME"].ToString();
                var colType = row["DATA_TYPE"].ToString();
                list.Add(new TableColumn
                {
                    ColName = colName,
                    ColType = colType
                });
            }
            return list;
        }

        private string GetInsertSql_Param(List<TableColumn> columnList, DataTable dtTitle, DataTable dtContext,
            Dictionary<string, string> fileDict, string version, string tableName, DAO dao, out List<OracleParameter> listParm)
        {
            //M_CREATOR,M_CREATEBY,M_CREATE_TM 字段不处理
            listParm = new List<OracleParameter>();
            foreach (var tableColumn in columnList)
            {
                if ("M_ID".Equals(tableColumn.ColName) || "ID".Equals(tableColumn.ColName))
                {
                    var seqDict = new Dictionary<string, string>
                    {
                        {"EXPLOR_BID_AUCTION_TRANS_ANN","EX_BID_AUCT_TRANS_ANN" },
                        {"MINING_BID_AUCTION_TRANS_ANN","MIN_BID_AUCT_TRANS_ANN" },
                        {"EXPLOR_BID_AUC_TRANS_RES_ANN","EX_BID_AUC_TRANS_RES_ANN" },
                        {"MINING_BID_AUC_TRANS_RES_ANN","MIN_BID_AUC_TRANS_RES_ANN" },
                        {"INDIVIDUAL_SUPPLIER_EX_INFO","INDIVIDUAL_SUPPLIER_EX_IN" },
                        {"INDIVIDUAL_ASSIGNEE_EX_INFO","INDIVIDUAL_ASSIGNEE_EX_IN" },
                        {"DEA_SEWAGE_PAID_TRANSFER_ANNO","DEA_SEWAGE_PAID_TRANS_ANNO" },
                        {"DEA_SEWAGE_PAID_TRANSFER_RES","DEA_SEWAGE_PAID_TRANS_RES" },
                        {"DEA_CARBON_QUOTA_SELL_RESULT","DEA_CARBON_QUOTA_SELL_RES" },
                        {"DEA_MEDI_OTHER_PURCHASE_ANNO","DEA_OTHER_PURCHASE_ANN" },
                        {"DEA_MEDI_NEGO_PURCHASE_DETAIL","DEA_NEGO_PURCHASE_DETAIL" },
                        {"DEA_MEDI_NEGO_PURCHASE_LIST","DEA_NEGO_PURCHASE_LIST" },
                        {"DEA_MEDI_NEGO_PURCHASE_ANNO","DEA_NEGO_PURCHASE_ANNO" },
                        {"DEA_MEDI_FIXED_PURCHASE_DETAIL","DEA_FIXED_PURCHASE_DETAIL" },
                        {"DEA_MEDI_FIXED_PURCHASE_LIST","DEA_FIXED_PURCHASE_LIST" },
                        {"DEA_MEDI_FIXED_PURCHASE_ANNO","DEA_FIXED_PURCHASE_ANNO" },
                        {"DEA_MEDI_NET_PURCHASE_DETAIL","DEA_NET_PURCHASE_DETAIL" },
                        {"ZJ_TENDER_FILE_BUYYER_INFO","ZJ_TENDER_FILE_BUYYER" },
                        {"SL_TENDER_FILE_BUYYER_INFO","SL_TENDER_FILE_BUYYER" },
                        {"JT_TENDER_FILE_BUYYER_INFO","JT_TENDER_FILE_BUYYER" },
                        {"YG_TENDER_FILE_BUYYER_INFO","YG_TENDER_FILE_BUYYER" },
                        {"GT_TENDER_FILE_BUYYER_INFO","GY_TENDER_FILE_BUYYER" },
                        {"XX_TENDER_FILE_BUYYER_INFO","XX_TENDER_FILE_BUYYER" },
                        {"ZJ_EVALUATION_SCORE_DETAIL","ZJ_EVALUATION_SCORE" },
                        {"SL_EVALUATION_SCORE_DETAIL","SL_EVALUATION_SCORE" },
                        {"JT_EVALUATION_SCORE_DETAIL","JT_EVALUATION_SCORE" },
                        {"YG_EVALUATION_SCORE_DETAIL","YG_EVALUATION_SCORE" },
                        {"GY_EVALUATION_SCORE_DETAIL","GY_EVALUATION_SCORE" },
                        {"XX_EVALUATION_SCORE_DETAIL","XX_EVALUATION_SCORE" },
                        {"XX_TENDER_ABNORMITY_REPORT","XX_TENDER_ABNORMITY" },
                        {"YG_TENDER_ABNORMITY_REPORT","YG_TENDER_ABNORMITY" },
                        {"GY_TENDER_ABNORMITY_REPORT","GY_TENDER_ABNORMITY" },
                    };
                    var seqName = "seq_" + seqDict.GetStringValue(tableName, tableName);
                    var mId = Convert.ToInt32(dao.GetSingle("select " + seqName + ".nextval from dual"));
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, mId));
                }
                else if ("M_TM".Equals(tableColumn.ColName))
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, DateTime.Now));
                }
                else if ("M_CREATE_TM".Equals(tableColumn.ColName))
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, DateTime.Now));
                }
                else if ("M_CREATEBY".Equals(tableColumn.ColName))
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, -1));
                }
                else if ("M_CREATOR".Equals(tableColumn.ColName))
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, DBNull.Value));
                }
                else if ("M_IS_HISTORY".Equals(tableColumn.ColName))
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, dtTitle.GetIntValue(Constant.ROUTE_WAY)));
                }
                else if ("M_VERSION".Equals(tableColumn.ColName))
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, version));
                }
                //招标公告的m_status 默认为2,如果是第三方默认为1需要协会审核，目前72开头的为第三方交易平台
                else if ("M_STATUS".Equals(tableColumn.ColName))
                {
                    string m_status = "2";
                    m_status = dtTitle.GetStringValue("SYSTEM_NO").StartsWith("72") ? "1" : CheckRecordReviewStatus(dtTitle, dtContext);
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, m_status));
                }
                else if ("M_ZPID".Equals(tableColumn.ColName))
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, DBNull.Value));
                }
                else if (M_KEY_Field.Equals(tableColumn.ColName))
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, dtTitle.GetStringValue(Constant.DATA_KEY)));
                }
                else if ("M_DATA_SOURCE".Equals(tableColumn.ColName))
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, dtTitle.GetStringValue(Constant.DATA_KEY).Substring(0, 4)));
                }
                else if ("DATA_TIMESTAMP".Equals(tableColumn.ColName))
                {
                    var dt = DateTimeHelper.ToDateTime(dtContext.GetStringValue(tableColumn.ColName), "yyyyMMddHHmmss");
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, dt));
                }
                else if (fileDict.ContainsKey(tableColumn.ColName))
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, fileDict.GetValue(tableColumn.ColName)));
                }
                else if ("VARCHAR2".Equals(tableColumn.ColType))
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, dtContext.GetStringValue(tableColumn.ColName)));
                }
                else if ("NUMBER".Equals(tableColumn.ColType))
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, dtContext.GetDoubleValue(tableColumn.ColName)));
                }
                else if ("DATE".Equals(tableColumn.ColType))
                {
                    var datetime = DateTime.MinValue;
                    var dataField = Fields.SingleOrDefault(e => e.Name.Equals(tableColumn.ColName));
                    var validators = dataField?.Validators;
                    var fieldValidator = validators?.SingleOrDefault(
                        e => e.GetStringValue("ValidatorName").Equals("DateMatch"));
                    if (fieldValidator?.Validator is DateMatchFieldValidator dateValidator)
                    {
                        datetime = DateTimeHelper.ToDateTime(dtContext.GetStringValue(tableColumn.ColName), dateValidator.Format);
                    }
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, datetime));
                }
                else if ("CLOB".Equals(tableColumn.ColType))
                {
                    var colbValue = dtContext.GetStringValue(tableColumn.ColName);
                    OracleParameter param = new OracleParameter(":" + tableColumn.ColName, OracleType.Clob);
                    param.Value = colbValue;
                    listParm.Add(param);
                }
                else
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, dtContext.GetStringValue(tableColumn.ColName)));
                }
            }
            var sql = $"insert into {tableName}({string.Join(",", columnList.Select(e => e.ColName))})" +
                      $"values({string.Join(",", columnList.Select(e => ":" + e.ColName))})";
            return sql;
        }

        private string CheckRecordReviewStatus(DataTable dtTitle, DataTable dtContext)
        {
            string m_status = "2";
            string tenderProjectCode = dtContext.GetStringValue("TENDER_PROJECT_CODE");
            string dataEn = dtTitle.GetStringValue("DATA_EN").Substring(0, 3);
            string dataNo = dtTitle.GetStringValue("DATA_NO");
            //不是招标公告的表跳过
            if (!"803,833,863,9403,9503,9603".Contains(dataNo))
            {
                return m_status;
            }
            string TenderType = "";
            switch (dataEn)
            {
                case "ZJ_":
                case "SL_":
                case "JT_":
                case "YG_":
                case "GY_":
                case "XX_":
                    TenderType = dataEn;
                    break;
            }

            if (!string.IsNullOrEmpty(TenderType))
            {
                string sqlCode = $"select tender_record_code from {TenderType}tender_project where tender_project_code = '{tenderProjectCode}'";
                var dt = DAO.XZJD.GetDataSet(sqlCode).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    string code = dt.Rows[0][0].ToString();
                    //获取备案状态
                    if (code != "A999999999999999")
                    {
                        sqlCode = $"select REVIEW_STATUS from record_review where review_code = '{code}'";
                        dt = DAO.XZJD.GetDataSet(sqlCode).Tables[0];
                        if (dt.Rows.Count > 0)
                        {
                            //获取状态的中文描述
                            string status = dt.Rows[0][0].ToString();
                            if ("ZJ_,XX_,GY_,YG_".Contains(TenderType))
                            {
                                if (!"4,5,6".Contains(status))
                                {
                                    m_status = "9";
                                }

                            }
                            if ("SL_,JT_".Contains(TenderType))
                            {
                                if (!"5".Contains(status))
                                {
                                    m_status = "9";
                                }
                            }
                        }
                    }
                }
            }

            return m_status;
        }

        private string GetUpdateSql_Param(List<TableColumn> columnList, DataTable dtTitle, DataTable dtContext,
           Dictionary<string, string> fileDict, string tableName, out List<OracleParameter> listParm)
        {
            //M_TM,M_CREATOR,M_IS_HISTORY,M_CREATEBY,M_CREATE_TM 字段 什么意思
            var cannotModifyColumnList = new List<string> { "ID","M_ID", "M_TM", "M_VERSION", M_KEY_Field,
                "M_CREATEBY","M_DATA_SOURCE","M_CREATE_TM","M_STATUS","M_USER_ID"};

            listParm = new List<OracleParameter>();
            List<string> valueList = new List<string>();
            foreach (var tableColumn in columnList)
            {
                if (cannotModifyColumnList.Contains(tableColumn.ColName))
                {
                    continue;
                }

                if (!(dtContext.Columns.Contains(tableColumn.ColName) || dtTitle.Columns.Contains(tableColumn.ColName) || fileDict.ContainsKey(tableColumn.ColName)))
                {
                    continue;
                }
                valueList.Add($"{tableColumn.ColName} = :{tableColumn.ColName}");
                if ("DATA_TIMESTAMP".Equals(tableColumn.ColName))
                {
                    var dt = DateTimeHelper.ToDateTime(dtContext.GetStringValue(tableColumn.ColName), "yyyyMMddHHmmss");
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, dt));
                }
                else if ("M_IS_HISTORY".Equals(tableColumn.ColName))
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, dtTitle.GetIntValue(Constant.ROUTE_WAY)));
                }
                //招标公告的m_status 默认为2,如果是第三方默认为1需要协会审核，目前72开头的为第三方交易平台
                else if ("M_STATUS".Equals(tableColumn.ColName))
                {
                    listParm.Add(dtTitle.GetStringValue("SYSTEM_NO").StartsWith("72")
                        ? new OracleParameter(":" + tableColumn.ColName, "1")
                        : new OracleParameter(":" + tableColumn.ColName, "2"));
                }
                else if (fileDict.ContainsKey(tableColumn.ColName))
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, fileDict.GetValue(tableColumn.ColName)));

                }
                else if ("VARCHAR2".Equals(tableColumn.ColType))
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, dtContext.GetStringValue(tableColumn.ColName)));
                }
                else if ("NUMBER".Equals(tableColumn.ColType))
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, dtContext.GetDoubleValue(tableColumn.ColName)));
                }
                else if ("DATE".Equals(tableColumn.ColType))
                {
                    var datetime = DateTime.MinValue;
                    var dataField = Fields.SingleOrDefault(e => e.Name.Equals(tableColumn.ColName));
                    var validators = dataField?.Validators;
                    var fieldValidator = validators?.SingleOrDefault(
                        e => e.GetStringValue("ValidatorName").Equals("DateMatch"));
                    if (fieldValidator?.Validator is DateMatchFieldValidator dateValidator)
                    {
                        datetime = DateTimeHelper.ToDateTime(dtContext.GetStringValue(tableColumn.ColName), dateValidator.Format);
                    }
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, datetime));
                }
                else if ("CLOB".Equals(tableColumn.ColType))
                {
                    var colbValue = dtContext.GetStringValue(tableColumn.ColName);
                    OracleParameter param = new OracleParameter(":" + tableColumn.ColName, OracleType.Clob);
                    param.Value = colbValue;
                    listParm.Add(param);
                }
                else
                {
                    listParm.Add(new OracleParameter(":" + tableColumn.ColName, dtContext.GetStringValue(tableColumn.ColName)));
                }
            }
            var sql = $"update {tableName} set " + $"{string.Join(",", valueList)} where {M_KEY_Field} = '{dtTitle.GetStringValue(Constant.DATA_KEY)}'";
            return sql;
        }
        private void Init()
        {
            foreach (var field in Fields)
            {
                foreach (var fieldValidtor in field.Validators)
                {
                    var validatorName = fieldValidtor.GetStringValue("ValidatorName");
                    var validatorType = DataValidatorManager.GetDataValidateType(validatorName);
                    if (validatorType != null)
                    {
                        var json = JsonConvert.SerializeObject(fieldValidtor);
                        var validator = JsonConvert.DeserializeObject(json, validatorType) as AbstractFieldValidator;
                        validator.Field = field.Name;
                        validator.DataConfig = this;
                        fieldValidtor.Validator = validator;
                    }
                }
            }
            foreach (var tableValidator in Validators)
            {
                var validatorName = tableValidator.GetStringValue("ValidatorName");
                var validatorType = DataValidatorManager.GetDataValidateType(validatorName);
                if (validatorType != null)
                {
                    var json = JsonConvert.SerializeObject(tableValidator);
                    var validator = JsonConvert.DeserializeObject(json, validatorType) as AbstractTableValidator;
                    validator.DataConfig = this;
                    tableValidator.Validator = validator;
                }
            }
            Dao = IsZXSJ ? DAO.XZJD : DAO.GGFW;

        }

        private static readonly Dictionary<string, DataConfig> _dataConfigDict
            = new Dictionary<string, DataConfig>();

        public static DataConfig GetDataConfig(string dataNo, string version)
        {
            if (!_dataConfigDict.ContainsKey(dataNo))
            {
                var configPath =
                    $"{AppDomain.CurrentDomain.BaseDirectory}\\Config\\DataConfig\\{version}\\{dataNo}.json";

                ThrowHelper.ThrowIfTure(!File.Exists(configPath), $"未知的DATA_NO[{dataNo}]");

                var text = File.ReadAllText(configPath);
                var dataConfig = JsonConvert.DeserializeObject<DataConfig>(text);
                dataConfig.DataNo = dataNo;
                dataConfig.Version = version;
                dataConfig.Init();
                if (dataConfig.IsSaveGGFW())
                {
                    dataConfig.GgfwDataConfig = GetDataConfig(dataConfig.GgfwDataNo, version);
                }
                _dataConfigDict[dataNo] = dataConfig;
            }
            return _dataConfigDict.GetValue(dataNo);
        }

        public static void UpdateDataConfig(string dataNo, string content, string version)
        {
            var configPath =
                $"{AppDomain.CurrentDomain.BaseDirectory}\\Config\\DataConfig\\{version}\\{dataNo}.json";
            var backupPath =
                $"{AppDomain.CurrentDomain.BaseDirectory}\\Config\\DataConfig\\{version}\\backup\\{dataNo}-{DateTime.Now:yyyyMMddHHmmss}.json";
            if (File.Exists(configPath))
            {
                File.Copy(configPath, backupPath);
                File.WriteAllText(configPath, content);
                if (_dataConfigDict.ContainsKey(dataNo))
                {
                    _dataConfigDict.Remove(dataNo);
                }
                GetDataConfig(dataNo, version);
            }

        }

        public static List<string> GetSpecialTenderProjectCodeList()
        {
            var list = new List<string>();
            var tpPath =
                $"{AppDomain.CurrentDomain.BaseDirectory}\\Config\\DataConfig\\tpc.json";
            if (File.Exists(tpPath))
            {
                var text = File.ReadAllText(tpPath);
                list = JsonConvert.DeserializeObject<List<string>>(text);
            }
            return list;
        }

        public static void UpdateSpecialTenderProjectCodeList(string content)
        {
            var tpPath =
                $"{AppDomain.CurrentDomain.BaseDirectory}\\Config\\DataConfig\\tpc.json";
            File.WriteAllText(tpPath, content);
        }

    }
}