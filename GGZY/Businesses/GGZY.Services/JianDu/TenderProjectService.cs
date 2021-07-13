using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using Aspose.Words;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.Extensions;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TenderProjectService : BaseServiceT<TENDER_PROJECT>
    {
        /// <summary>
        /// 更新招标项目信息
        /// </summary>
        /// <param name="tender_project"></param>
        /// <returns></returns>
        public GeneralResult Save(TENDER_PROJECT tender_project)
        {
            var result = new GeneralResult();
            var oldEntity = FirstOrNull(TENDER_PROJECT._.M_ID == tender_project.M_ID);
            if (null == oldEntity)
            {
                result.SetFail("招标项信息不存在或已删除");
                return result;
            }
            var now = ServicesFactory.GGZYJD.CommonService.GetDBDateTime();
            var model_tender_project = new TENDER_PROJECT(tender_project);
            model_tender_project.M_ID = oldEntity.M_ID;
            model_tender_project.UNIFIED_DEAL_CODE = oldEntity.UNIFIED_DEAL_CODE;
            model_tender_project.M_CREATOR = oldEntity.M_CREATOR;
            model_tender_project.DATA_TIMESTAMP = now;
            model_tender_project.M_CREATE_TM = now;
            model_tender_project.TENDER_PROJECT_CODE = oldEntity.TENDER_PROJECT_CODE;
            model_tender_project.RTYPE = oldEntity.RTYPE; //Jd.TenderProjectService.GetRType(model_tender_project.TENDER_PROJECT_TYPE, model_tender_project.TENDER_PROJECT_CLASSIFY_CODE);
            model_tender_project.CONSTRUCTION_ID = oldEntity.CONSTRUCTION_ID;
            bool isUpdate = Update(model_tender_project) > 0;
            if (!isUpdate)
            {
                result.SetFail("更新失败");
                return result;
            }
            result.SetSuccess();
            return result;
        }

        /// <summary>
        /// 生成招标项目编号
        /// </summary>
        /// <param name="PROJECT_CODE">项目编号</param>
        public string Generate_TENDER_PROJECT_CODE(string PROJECT_CODE)
        {
            string sqlStr = string.Format("select NVL(max(to_number(substr(TENDER_PROJECT_CODE,20))),0)+1 as MAXSEQ from TENDER_PROJECT t where TENDER_PROJECT_CODE like '{0}%'", PROJECT_CODE);
            string SEQNO = FromSql(sqlStr).ToScalar<string>().PadLeft(3, '0');
            return String.Concat(PROJECT_CODE, SEQNO);
        }
        /// <summary>
        /// 生成项目编号，每天从1开始重新计数。返回格式：yyMMdd0001,yyMMdd0002
        /// </summary>
        /// <param name="now">当前时间，为空则读取数据库当前时间</param>
        /// <returns>返回格式：yyMMdd0001,yyMMdd0002</returns>
        public string Generate_PROJECT_CODE_SEQ(DateTime? now = null, DbTrans tran = null)
        {
            if (null == now)
            {
                now = ServicesFactory.GGZYJD.CommonService.GetDBDateTime();
            }
            var model = ServicesFactory.GGZYJD.TSeqService.FirstOrNull(T_SEQ._.TYPE == "1");
            if (null == model)
            {
                model = new T_SEQ();
                model.NAME = "项目编号序列";
                model.TYPE = "1";
                model.SEQ_NUM = 1;
                model.TM = now;
                model.REMARK = "用户项目编号生成";
                ServicesFactory.GGZYJD.TSeqService.Add(model, tran);
                return model.SEQ_NUM.Value.ToString().PadLeft(4, '0');
            }
            if (model.TM.Value.Date != now.Value.Date)
            {
                model.SEQ_NUM += 1;
            }
            else
            {
                model.TM = now;
                model.SEQ_NUM = 1;
                ServicesFactory.GGZYJD.TSeqService.Update(model, tran);
            }
            return String.Concat(now.Value.ToString("yyMMdd"), model.SEQ_NUM.Value.ToString().PadLeft(4, '0'));
        }
        /// <summary>
        /// 站点选择插件（招标项目）
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult PageTable(TENDER_PROJECT model, SearchCondition search)
        {
            var condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
            {
                condition.And(TENDER_PROJECT._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
            {
                condition.And(TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDERER_NAME))
            {
                condition.And(TENDER_PROJECT._.TENDERER_NAME.Contain(model.TENDERER_NAME));
            }

            if (!string.IsNullOrWhiteSpace(search.KeyWord))//闽政通 只有一个查询条件 使用关键字
            {
                condition.And(TENDER_PROJECT._.TENDER_PROJECT_CODE.Contain(search.KeyWord)
                || TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(search.KeyWord)
                || TENDER_PROJECT._.TENDERER_NAME.Contain(search.KeyWord));
            }
            var tb = FromWhere().InnerJoin<RECORD_REVIEW>(
                    RECORD_REVIEW._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE
                    && RECORD_REVIEW._.REVIEW_TYPE == TENDER_PROJECT._.RTYPE.OracleConcat("101"))
                .GroupBy(TENDER_PROJECT._.M_ID).Select(TENDER_PROJECT._.M_ID);
            //condition.And(TENDER_PROJECT._.M_ID.SubQueryIn(

            //    ));
            var query = FromWhere(condition.ToWhereClip())
                .InnerJoinTmp<RECORD_REVIEW>(tb, RECORD_REVIEW._.M_ID == TENDER_PROJECT._.M_ID);

            //.InnerJoin<RECORD_REVIEW>((RECORD_REVIEW._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE
            //                           || RECORD_REVIEW._.REVIEW_TYPE == TENDER_PROJECT._.RTYPE.OracleConcat("101"))&& RECORD_REVIEW._.REVIEW_STATUS.In(5,6)
            //                         );
            var count = query.Count();
            var pageList = query
                .LeftJoin<SYS_AREA_QUANGUO>(TENDER_PROJECT._.REGION_CODE == SYS_AREA_QUANGUO._.AREACODE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "1000" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_MODE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "2002" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == TENDER_PROJECT._.RECORD_DEPID)
                .LeftJoin<SECTION>(SECTION._.TENDER_PROJECT_CODE == TENDER_PROJECT._.TENDER_PROJECT_CODE)
                .OrderBy(TENDER_PROJECT._.M_ID)
                .Page(search.PageSize, search.PageNo)
                .Select(
                    TENDER_PROJECT._.M_ID,
                    TENDER_PROJECT._.TENDER_PROJECT_CODE,
                    TENDER_PROJECT._.TENDER_PROJECT_NAME,
                    TENDER_PROJECT._.TENDERER_NAME,
                    TENDER_PROJECT._.TENDERER_CONTRACT,
                    SYS_AREA_QUANGUO._.AREANAME,
                    TENDER_PROJECT._.TENDER_MODE,
                    SYS_DIC._.TEXT.As("TENDER_MODE_TEXT"),
                    TENDER_PROJECT._.TENDER_PROJECT_TYPE,
                    new Field("TEXT", "SYS_DIC2").As("TENDER_PROJECT_TYPE_TEXT"),
                    T_USER_DEPARTMENT._.DNAME.As("ACCEPT_DEPID_TEXT"),
                    TENDER_PROJECT._.RECORD_DEPID.As("ACCEPT_DEPID"),
                    SECTION._.TENDER_PROJECT_CLASSIFY_CODE.As("TENDER_CLASS"),
                    TENDER_PROJECT._.DATA_TIMESTAMP
                ).ToList<object>()
                .ToPageTableResult(search, count);
            return pageList;

        }
        /// <summary>
        /// 招标项目管理页面列表-注册用户
        /// </summary>
        /// <param name="tender_project"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult List(TENDER_PROJECT tender_project, SearchCondition search)
        {
            var conditionTenderProject = new WhereClipBuilder();
            if (!String.IsNullOrWhiteSpace(tender_project.TENDER_PROJECT_NAME))
            {
                conditionTenderProject.And(TENDER_PROJECT._.TENDER_PROJECT_NAME.Like(tender_project.TENDER_PROJECT_NAME));
            }
            if (!String.IsNullOrWhiteSpace(tender_project.TENDER_PROJECT_CODE))
            {
                conditionTenderProject.And(TENDER_PROJECT._.TENDER_PROJECT_CODE == tender_project.TENDER_PROJECT_CODE);
            }
            if (!String.IsNullOrWhiteSpace(tender_project.CONSTRUCTION_ID))
            {
                conditionTenderProject.And(TENDER_PROJECT._.CONSTRUCTION_ID == tender_project.CONSTRUCTION_ID);
            }
            if (!String.IsNullOrWhiteSpace(tender_project.TENDER_PROJECT_TYPE))
            {
                conditionTenderProject.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == tender_project.TENDER_PROJECT_TYPE);
            }
            conditionTenderProject.And(TENDER_PROJECT._.M_CREATOR == JdUser?.ID);
            var query = FromWhere(conditionTenderProject.ToWhereClip());
            var count = query.Count();
            var datas = query
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "1000" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_MODE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "2002" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == TENDER_PROJECT._.RECORD_DEPID)
                .OrderBy(TENDER_PROJECT._.M_ID.Desc)
                .Page(search.PageSize, search.PageNo)
                .Select(
                    TENDER_PROJECT._.M_ID,
                    TENDER_PROJECT._.PROJECT_CODE,
                    TENDER_PROJECT._.TENDER_PROJECT_CODE,
                    TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1,
                    TENDER_PROJECT._.TENDER_PROJECT_NAME,
                    TENDER_PROJECT._.OWNER_NAME,
                    TENDER_PROJECT._.TENDER_AGENCY_CODE,
                    TENDER_PROJECT._.TENDER_AGENCY_NAME,
                    TENDER_PROJECT._.TENDER_PROJECT_TYPE,
                    TENDER_PROJECT._.TENDER_MODE,
                    TENDER_PROJECT._.PLATFORM_CODE,
                    TENDER_PROJECT._.UNIFIED_DEAL_CODE,
                    TENDER_PROJECT._.CONSTRUCTION_ID,
                    TENDER_PROJECT._.M_CREATE_TM,
                    new Field("(select count(1) from TB_FAVORITE where project_id = TENDER_PROJECT.TENDER_PROJECT_CODE and u_id=" + JdUser?.ID + ")").As("IS_SC"),
                    new Field("(select count(1) from RECORD_REVIEW where TENDER_PROJECT_CODE = TENDER_PROJECT.TENDER_PROJECT_CODE)").As("IS_BA"),
                    SYS_DIC._.TEXT.As("TENDER_MODE_TEXT"),
                    new Field("TEXT", "SYS_DIC2").As("TENDER_PROJECT_TYPE_TEXT"),
                    TENDER_PROJECT._.RECORD_DEPID,
                    TENDER_PROJECT._.TENDERER_NAME,
                    TENDER_PROJECT._.TENDERER_CONTRACT,
                    TENDER_PROJECT._.TENDERER_PHONE,
                    TENDER_PROJECT._.TENDER_AGENT_CONTRACT,
                    TENDER_PROJECT._.TENDER_AGENT_PHONE,
                    T_USER_DEPARTMENT._.JGBM
                ).ToList<dynamic>();

            var tender_project_codes = datas.Any() ? String.Join(",", datas.Select(t => t.TENDER_PROJECT_CODE).ToList()) : "";
            var processes = GetRecordReviewProcess(tender_project_codes);
            var pageList = datas.Select(t => new
            {
                M_ID = t.M_ID,
                PROJECT_CODE = t.PROJECT_CODE,
                TENDER_PROJECT_CODE = t.TENDER_PROJECT_CODE,
                TENDER_PROJECT_CODE_OLD1 = t.TENDER_PROJECT_CODE_OLD1,
                TENDER_PROJECT_NAME = t.TENDER_PROJECT_NAME,
                OWNER_NAME = t.OWNER_NAME,
                TENDER_AGENCY_CODE = t.TENDER_AGENCY_CODE,
                TENDER_AGENCY_NAME = t.TENDER_AGENCY_NAME,
                TENDER_PROJECT_TYPE = t.TENDER_PROJECT_TYPE,
                TENDER_MODE = t.TENDER_MODE,
                PLATFORM_CODE = t.PLATFORM_CODE,
                UNIFIED_DEAL_CODE = t.UNIFIED_DEAL_CODE,
                CONSTRUCTION_ID = t.CONSTRUCTION_ID,
                M_CREATE_TM = t.M_CREATE_TM,
                IS_SC = t.IS_SC,
                IS_BA = t.IS_BA,
                TENDER_MODE_TEXT = t.TENDER_MODE_TEXT,
                TENDER_PROJECT_TYPE_TEXT = t.TENDER_PROJECT_TYPE_TEXT,
                RECORD_DEPID = t.RECORD_DEPID,
                TENDERER_NAME = t.TENDERER_NAME,
                TENDERER_CONTRACT = t.TENDERER_CONTRACT,
                TENDERER_PHONE = t.TENDERER_PHONE,
                TENDER_AGENT_CONTRACT = t.TENDER_AGENT_CONTRACT,
                TENDER_AGENT_PHONE = t.TENDER_AGENT_PHONE,
                JGBM = t.JGBM,
                BUTTONS = GetButtons(processes, t.TENDER_PROJECT_CODE),
                PROCESS = processes.Any() ? processes.Where(w => w.TENDER_PROJECT_CODE == t.TENDER_PROJECT_CODE)
                    .Select(p => new
                    {
                        p.TEXT,
                        p.VALUE,
                        LABEL = p.PROCESS_STATUS == 2 ? "未通过，需整改" : "",
                        p.PROCESS_STATUS
                    }).ToList<dynamic>() : new List<dynamic>()
            }).ToPageTableResult(search, count);
            return pageList;
        }
        /// <summary>
        /// 招标项目管理页面列表-注册用户-获取可操作按钮
        /// </summary>
        /// <param name="process"></param>
        /// <returns></returns>
        public List<string> GetButtons(IEnumerable<dynamic> process, string TENDER_PROJECT_CODE)
        {
            List<string> Buttons = new List<string>();
            Buttons.Add("RECORD_REVIEW");
            if (!process.Where(w => w.TENDER_PROJECT_CODE == TENDER_PROJECT_CODE && w.PROCESS_STATUS > 0).Any())
            {
                Buttons.Add("DELETE");
            }
            if (process.Where(w => w.PROCESS_STATUS == 2 && w.TENDER_PROJECT_CODE == TENDER_PROJECT_CODE).Any())
            {
                Buttons.Add("RECTIFICATION");
            }
            return Buttons;
        }

        /// <summary>
        /// 招标项目管理页面-TAB选项卡-行业主管审核列表
        /// </summary>
        /// <returns></returns>
        public GeneralResult TabCollection()
        {
            GeneralResult r = new GeneralResult();

            var rtype = JdUser?.UserDepartment?.JGBM;



            //住建
            if (rtype == "MZ" || rtype == "MT")
            {
                List<dynamic> datas = new List<dynamic>();
                List<string> node_names = FromWhere<REVIEW_NODE>()
                    .InnerJoin<REVIEW_DEPCONFIG>(REVIEW_DEPCONFIG._.NODE_ID == REVIEW_NODE._.ID ||
                    REVIEW_DEPCONFIG._.NODE_ID == REVIEW_NODE._.OPER_USE_NODE)
                    .Where(REVIEW_DEPCONFIG._.USER_ID == JdUser?.ID)
                    .Select(REVIEW_NODE._.NODE_NAME).Distinct()
                    .ToList<string>();
                var order_node = new List<string>() { "接收", "初审", "复审", "签发", "发出意见书" };


                datas.Add(new { text = "全部", count = 0, parameter = new { } });

                foreach (var node_name in order_node)
                {
                    if (!node_names.Contains(node_name))
                    {
                        continue;
                    }

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT COUNT(1) AS COUNT FROM");
                    sb.AppendLine("(SELECT ROW_NUMBER() OVER(PARTITION BY TENDER_PROJECT.TENDER_PROJECT_CODE ORDER BY RECORD_REVIEW.REVIEW_CODE) RNN");
                    sb.AppendLine("  FROM REVIEW_INSTANCE");
                    sb.AppendLine(" INNER JOIN REVIEW_NODE");
                    sb.AppendLine("    ON REVIEW_INSTANCE.NOW_NODE = REVIEW_NODE.ID");
                    sb.AppendLine("   AND REVIEW_INSTANCE.IS_END =0");
                    sb.AppendLine("   AND REVIEW_INSTANCE.MAIN_ID = REVIEW_NODE.MAIN_ID");
                    sb.AppendLine(" INNER JOIN RECORD_REVIEW");
                    sb.AppendLine("    ON RECORD_REVIEW.ID = REVIEW_INSTANCE.BA_ID");
                    sb.AppendLine("   AND RECORD_REVIEW.REVIEW_STATUS != '0' AND (SUBSTR(RECORD_REVIEW.REVIEW_TYPE,0,2) ='MZ' OR SUBSTR(RECORD_REVIEW.REVIEW_TYPE,0,2) ='MT')");
                    sb.AppendLine(" INNER JOIN TENDER_PROJECT");
                    sb.AppendLine("    ON TENDER_PROJECT.TENDER_PROJECT_CODE = REVIEW_INSTANCE.TENDER_PROJECT_CODE");
                    sb.AppendLine("  WHERE NODE_NAME=:NODE_NAME");
                    sb.AppendLine("   AND TENDER_PROJECT.RECORD_DEPID =" + JdUser?.UserDepartment?.DEPID + ")T");
                    sb.AppendLine("WHERE T.RNN =1");

                    var count = FromSql(sb.ToString()).AddInParameter(":NODE_NAME", DbType.String, node_name).ToScalar<int>();
                    datas.Add(new { text = "待" + node_name, count = count, parameter = new { node_name = node_name } });
                    //dic.Add(node_name, new { count = count, parameter = new { node_name = "待" + node_name } });
                }
                r.SetSuccess(datas);
                return r;
            }

            var OTHERIDS = String.IsNullOrEmpty(JdUser.UserDepartment.OTHERIDS) ? "-1" : JdUser.UserDepartment.OTHERIDS;
            //待签收
            StringBuilder sbNosign = new StringBuilder();
            sbNosign.AppendLine("select count(1) count_NoSign from( SELECT 1 ");
            sbNosign.AppendLine("  FROM RECORD_REVIEW a");
            sbNosign.AppendLine(" INNER JOIN TENDER_PROJECT b");
            sbNosign.AppendLine("    ON a.TENDER_PROJECT_CODE = b.TENDER_PROJECT_CODE");
            sbNosign.AppendLine("    AND (b.RECORD_DEPID = " + JdUser.DEPARTID + " OR b.RECORD_DEPID IN(" + OTHERIDS + ") )");
            sbNosign.AppendLine(" where REVIEW_TYPE NOT LIKE 'MZ%'");
            sbNosign.AppendLine("   and REVIEW_TYPE NOT LIKE 'MT%'");
            sbNosign.AppendLine("   and REVIEW_STATUS <> '0'");
            sbNosign.AppendLine("   and substr(REVIEW_TYPE, 3, 3) IN('101','104')");
            sbNosign.AppendLine("   and nvl(is_sign, 0) = 0 group by a.TENDER_PROJECT_CODE)");

            var count_NoSign = FromSql(sbNosign.ToString()).ToScalar<int>();


            //待审查

            StringBuilder sbWaitingAudit = new StringBuilder();
            sbWaitingAudit.AppendLine("SELECT count(1) as Count_WaitingAudit");
            sbWaitingAudit.AppendLine("  FROM RECORD_REVIEW a");
            sbWaitingAudit.AppendLine(" INNER JOIN TENDER_PROJECT b");
            sbWaitingAudit.AppendLine("    ON a.TENDER_PROJECT_CODE = b.TENDER_PROJECT_CODE");
            sbWaitingAudit.AppendLine("    AND (b.RECORD_DEPID = " + JdUser.DEPARTID + " OR b.RECORD_DEPID IN(" + OTHERIDS + ") )");
            sbWaitingAudit.AppendLine(" where REVIEW_TYPE NOT LIKE 'MZ%'");
            sbWaitingAudit.AppendLine("   and REVIEW_TYPE NOT LIKE 'MT%'");
            sbWaitingAudit.AppendLine("   and REVIEW_STATUS <> '0'");
            //招标备案，签收后即为待审查
            sbWaitingAudit.AppendLine("   and (substr(a.REVIEW_TYPE, 3, 3) = '101'");
            sbWaitingAudit.AppendLine("   and a.REVIEW_STATUS = 1");
            sbWaitingAudit.AppendLine("   and nvl(a.is_sign, 0) = 1)");
            //澄清修改备案，已提交即为待审查
            sbWaitingAudit.AppendLine("   or (substr(a.REVIEW_TYPE, 3, 3) ='102'");
            sbWaitingAudit.AppendLine("   and a.REVIEW_STATUS = 1)");
            var Count_WaitingAudit = FromSql(sbWaitingAudit.ToString()).ToScalar<int>();

            var data = new List<dynamic>() {
                new { text ="全部",  count = 0 ,parameter = new { } },
                new { text ="待签收",count = count_NoSign,parameter =new {REVIEW_STATUS=1,IS_SIGN =0} },
                new { text ="待审查",count = Count_WaitingAudit,parameter =new {REVIEW_STATUS =1,IS_SIGN =1 } }
            };
            r.SetSuccess(data);
            return r;
        }

        /// <summary>
        /// 招标项目管理页面列表-行业主管审核列表
        /// </summary>
        /// <param name="tender_project"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult Collection(string TENDER_PROJECT_NAME, string TENDER_PROJECT_CODE,
            string REVIEW_TYPE, int? REVIEW_STATUS, int? Is_Sign, int? Is_SignUP,
            int? REVIEW_ASCRIPTION,
            DateTime? dt1, DateTime? dt2, SearchCondition search)
        {

            var condition = new WhereClipBuilder();
            if (!String.IsNullOrWhiteSpace(TENDER_PROJECT_NAME))
            {
                condition.And(TENDER_PROJECT._.TENDER_PROJECT_NAME.Like(TENDER_PROJECT_NAME));
            }
            if (!String.IsNullOrWhiteSpace(TENDER_PROJECT_CODE))
            {
                condition.And(TENDER_PROJECT._.TENDER_PROJECT_CODE == TENDER_PROJECT_CODE);
            }

            StringBuilder sbTable = new StringBuilder();
            sbTable.AppendLine("(SELECT TENDER_PROJECT_CODE, MAX(COMMIT_TIME) COMMIT_TIME,CREATOR,");
            sbTable.AppendLine(" MAX(CASE WHEN SUBSTR(REVIEW_TYPE, 3, 3) = '101' THEN 1  ELSE 0 END) AS IS_GET_DATA FROM RECORD_REVIEW");
            sbTable.AppendLine(" WHERE RECORD_REVIEW.REVIEW_STATUS <> '0'");
            sbTable.AppendLine(" AND RECORD_REVIEW.REVIEW_TYPE NOT LIKE 'MZ%' AND RECORD_REVIEW.REVIEW_TYPE NOT LIKE 'MT%'");
            if (!String.IsNullOrWhiteSpace(REVIEW_TYPE))
            {
                sbTable.AppendLine(" AND INSTR(RECORD_REVIEW.REVIEW_TYPE,'" + REVIEW_TYPE.Substring(2, 3) + "') > 0");
            }
            if (Is_Sign == 0)
            {
                sbTable.AppendLine(" AND RECORD_REVIEW.IS_SIGN =" + Is_Sign + " AND substr(RECORD_REVIEW.REVIEW_TYPE,3,3)  NOT IN('102','103','105')");
            }
            if (REVIEW_STATUS == 1 && Is_Sign == 1)
            {
                sbTable.AppendLine(" AND ((RECORD_REVIEW.REVIEW_STATUS = " + REVIEW_STATUS + " AND NVL(RECORD_REVIEW.IS_SIGN,0)=1 AND substr(RECORD_REVIEW.REVIEW_TYPE,3,3)  ='101')");
                sbTable.AppendLine(" OR (RECORD_REVIEW.REVIEW_STATUS = " + REVIEW_STATUS + " AND substr(RECORD_REVIEW.REVIEW_TYPE,3,3)  ='102'))");
            }
            if (REVIEW_ASCRIPTION.HasValue && REVIEW_ASCRIPTION.Value > 0)
            {
                sbTable.AppendLine(" AND (RECORD_REVIEW.SIGN_PERSON =" + JdUser?.ID?.ToString() + " OR RECORD_REVIEW.REVIEW_PERSON=" + JdUser?.ID?.ToString() + ")");
            }
            //排除住建
            sbTable.AppendLine(" AND RECORD_REVIEW.REVIEW_TYPE NOT LIKE 'MZ%' and RECORD_REVIEW.REVIEW_TYPE NOT LIKE 'MT%'");


            sbTable.AppendLine(" GROUP BY TENDER_PROJECT_CODE, CREATOR) RECORD_REVIEW");

            var conditionDEPT = new WhereClipBuilder();
            conditionDEPT.And(TENDER_PROJECT._.RECORD_DEPID == JdUser.DEPARTID);
            if (!String.IsNullOrWhiteSpace(JdUser.UserDepartment.OTHERIDS))
            {
                var OTHERIDS = JdUser.UserDepartment.OTHERIDS.Split(',').Select(t => Convert.ToInt32(t)).ToList<int>();
                conditionDEPT.Or(TENDER_PROJECT._.RECORD_DEPID.In(OTHERIDS));
            }
            var query = FromTable(sbTable.ToString())
                .InnerJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE
                && conditionDEPT.ToWhereClip())
                .Where(condition.ToWhereClip());


            var count = query.Count();
            var datas = query
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "1000" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_MODE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "2002" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == TENDER_PROJECT._.RECORD_DEPID)
                .OrderBy(new Field("COMMIT_TIME").Desc)
                .Page(search.PageSize, search.PageNo)
                .Select(
                    TENDER_PROJECT._.M_ID,
                    TENDER_PROJECT._.PROJECT_CODE,
                    TENDER_PROJECT._.TENDER_PROJECT_CODE,
                    TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1,
                    TENDER_PROJECT._.TENDER_PROJECT_NAME,
                    TENDER_PROJECT._.OWNER_NAME,
                    TENDER_PROJECT._.TENDER_AGENCY_CODE,
                    TENDER_PROJECT._.TENDER_AGENCY_NAME,
                    TENDER_PROJECT._.TENDER_PROJECT_TYPE,
                    TENDER_PROJECT._.TENDER_MODE,
                    TENDER_PROJECT._.PLATFORM_CODE,
                    TENDER_PROJECT._.UNIFIED_DEAL_CODE,
                    TENDER_PROJECT._.CONSTRUCTION_ID,
                    TENDER_PROJECT._.M_CREATE_TM,
                    TENDER_PROJECT._.RTYPE,
                    new Field("(select count(1) from TB_FAVORITE where project_id = TENDER_PROJECT.TENDER_PROJECT_CODE and u_id=" + JdUser?.ID + ")").As("IS_SC"),
                    new Field("(select count(1) from RECORD_REVIEW where TENDER_PROJECT_CODE = TENDER_PROJECT.TENDER_PROJECT_CODE)").As("IS_BA"),
                    SYS_DIC._.TEXT.As("TENDER_MODE_TEXT"),
                    new Field("TEXT", "SYS_DIC2").As("TENDER_PROJECT_TYPE_TEXT"),
                    TENDER_PROJECT._.RECORD_DEPID,
                    TENDER_PROJECT._.TENDERER_NAME,
                    TENDER_PROJECT._.TENDERER_CONTRACT,
                    TENDER_PROJECT._.TENDERER_PHONE,
                    TENDER_PROJECT._.TENDER_AGENT_CONTRACT,
                    TENDER_PROJECT._.TENDER_AGENT_PHONE,
                    T_USER_DEPARTMENT._.DNAME,
                    T_USER_DEPARTMENT._.JGBM
                ).ToList<dynamic>();

            var tender_project_code_list = datas.Select(t => (string)t.TENDER_PROJECT_CODE).ToList();
            var collection_child = datas.Any() ? Collection_Child(tender_project_code_list) : new List<dynamic>();
            var pageList = datas.Select(t => new
            {
                M_ID = t.M_ID,
                PROJECT_CODE = t.PROJECT_CODE,
                TENDER_PROJECT_CODE = t.TENDER_PROJECT_CODE,
                TENDER_PROJECT_CODE_OLD1 = t.TENDER_PROJECT_CODE_OLD1,
                TENDER_PROJECT_NAME = t.TENDER_PROJECT_NAME,
                OWNER_NAME = t.OWNER_NAME,
                TENDER_AGENCY_CODE = t.TENDER_AGENCY_CODE,
                TENDER_AGENCY_NAME = t.TENDER_AGENCY_NAME,
                TENDER_PROJECT_TYPE = t.TENDER_PROJECT_TYPE,
                TENDER_MODE = t.TENDER_MODE,
                PLATFORM_CODE = t.PLATFORM_CODE,
                UNIFIED_DEAL_CODE = t.UNIFIED_DEAL_CODE,
                CONSTRUCTION_ID = t.CONSTRUCTION_ID,
                M_CREATE_TM = t.M_CREATE_TM,
                IS_SC = t.IS_SC,
                IS_BA = t.IS_BA,
                TENDER_MODE_TEXT = t.TENDER_MODE_TEXT,
                TENDER_PROJECT_TYPE_TEXT = t.TENDER_PROJECT_TYPE_TEXT,
                RECORD_DEPID = t.RECORD_DEPID,
                RECORD_DEPNAME = t.DNAME,
                TENDERER_NAME = t.TENDERER_NAME,
                TENDERER_CONTRACT = t.TENDERER_CONTRACT,
                TENDERER_PHONE = t.TENDERER_PHONE,
                TENDER_AGENT_CONTRACT = t.TENDER_AGENT_CONTRACT,
                TENDER_AGENT_PHONE = t.TENDER_AGENT_PHONE,
                JGBM = t.JGBM,
                RTYPE = t.RTYPE,
                PROCESS = GetProcess(collection_child, t.TENDER_PROJECT_CODE, t.RECORD_DEPID, REVIEW_TYPE, REVIEW_ASCRIPTION)
            }).ToPageTableResult(search, count);
            return pageList;
        }

        /// <summary>
        /// 住建备案列表
        /// </summary>
        /// <param name="TENDER_PROJECT_NAME"></param>
        /// <param name="TENDER_PROJECT_CODE"></param>
        /// <param name="REVIEW_TYPE"></param>
        /// <param name="REVIEW_STATUS"></param>
        /// <param name="Is_Sign"></param>
        /// <param name="Is_SignUP"></param>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <param name="search"></param>
        /// <param name="node_name"></param>
        /// <returns></returns>
        public PageTableResult Collection_ZJ(string TENDER_PROJECT_NAME, string TENDER_PROJECT_CODE,
            string REVIEW_TYPE, int? REVIEW_STATUS, int? Is_Sign, int? Is_SignUP, int? REVIEW_ASCRIPTION,
            DateTime? dt1, DateTime? dt2, SearchCondition search, string node_name)
        {
            var condition = new WhereClipBuilder();
            condition.And(new Field("RNN", "T") == 1);
            if (!String.IsNullOrWhiteSpace(TENDER_PROJECT_NAME))
            {
                condition.And(new Field("TENDER_PROJECT_NAME").Like(TENDER_PROJECT_NAME));
            }
            if (!String.IsNullOrWhiteSpace(TENDER_PROJECT_CODE))
            {
                condition.And(new Field("TENDER_PROJECT_CODE") == TENDER_PROJECT_CODE);
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(SELECT TENDER_PROJECT.M_ID,TENDER_PROJECT.TENDER_PROJECT_NAME,");
            sb.AppendLine("       TENDER_PROJECT.TENDER_PROJECT_CODE,");
            sb.AppendLine("       TENDER_PROJECT.TENDERER_NAME,");
            sb.AppendLine("       TENDER_PROJECT.TENDERER_CONTRACT,");
            sb.AppendLine("       TENDER_PROJECT.TENDER_AGENCY_CODE,");
            sb.AppendLine("       TENDER_PROJECT.TENDER_AGENCY_NAME,");
            sb.AppendLine("       TENDER_PROJECT.TENDER_PROJECT_TYPE,");
            sb.AppendLine("       TENDER_PROJECT.TENDER_PROJECT_CODE_OLD1,");
            sb.AppendLine("       TENDER_PROJECT.RTYPE,");
            sb.AppendLine("       TENDER_PROJECT.TENDER_MODE,");
            sb.AppendLine("       TENDER_PROJECT.PLATFORM_CODE,");
            sb.AppendLine("       TENDER_PROJECT.UNIFIED_DEAL_CODE,");
            sb.AppendLine("       TENDER_PROJECT.CONSTRUCTION_ID,");
            sb.AppendLine("       TENDER_PROJECT.M_CREATE_TM,");
            sb.AppendLine("       REVIEW_INSTANCE.CREATE_TM as REVIEW_NEW_TIME,");
            sb.AppendLine("       (select count(1) from TB_FAVORITE where project_id = TENDER_PROJECT.TENDER_PROJECT_CODE and u_id = " + JdUser?.ID + ") IS_SC,");
            sb.AppendLine("       (select count(1) from RECORD_REVIEW where TENDER_PROJECT_CODE = TENDER_PROJECT.TENDER_PROJECT_CODE)IS_BA,");
            sb.AppendLine("       SYS_DIC.TEXT TENDER_MODE_TEXT,");
            sb.AppendLine("       SYS_DIC2.TEXT TENDER_PROJECT_TYPE_TEXT,");
            sb.AppendLine("       TENDER_PROJECT.RECORD_DEPID,");
            sb.AppendLine("       TENDER_PROJECT.TENDERER_PHONE,");
            sb.AppendLine("       TENDER_PROJECT.TENDER_AGENT_CONTRACT,");
            sb.AppendLine("       TENDER_PROJECT.TENDER_AGENT_PHONE,");
            sb.AppendLine("       T_USER_DEPARTMENT.JGBM,");
            sb.AppendLine("       REVIEW_NODE.NODE_NAME,");
            sb.AppendLine("       RECORD_REVIEW.REVIEW_TYPE,");
            sb.AppendLine("       RECORD_REVIEW.REVIEW_STATUS,");
            sb.AppendLine("       T_USER_DEPARTMENT.DNAME,");
            sb.AppendLine("       RECORD_REVIEW.REVIEW_CODE,");
            sb.AppendLine("       ROW_NUMBER() OVER(PARTITION BY TENDER_PROJECT.TENDER_PROJECT_CODE ORDER BY RECORD_REVIEW.REVIEW_CODE) RNN");
            sb.AppendLine("  FROM REVIEW_INSTANCE");
            sb.AppendLine(" INNER JOIN REVIEW_NODE");
            sb.AppendLine("    ON REVIEW_INSTANCE.NOW_NODE = REVIEW_NODE.ID");
            //sb.AppendLine("   AND REVIEW_INSTANCE.IS_END =0");
            sb.AppendLine("   AND REVIEW_INSTANCE.MAIN_ID = REVIEW_NODE.MAIN_ID");
            sb.AppendLine(" INNER JOIN RECORD_REVIEW");
            sb.AppendLine("    ON RECORD_REVIEW.ID = REVIEW_INSTANCE.BA_ID");
            sb.AppendLine("   AND RECORD_REVIEW.REVIEW_STATUS != '0' AND (SUBSTR(RECORD_REVIEW.REVIEW_TYPE,0,2) ='MZ' OR SUBSTR(RECORD_REVIEW.REVIEW_TYPE,0,2) ='MT')");
            if (!String.IsNullOrEmpty(REVIEW_TYPE))
            {
                sb.AppendLine(" AND RECORD_REVIEW.REVIEW_TYPE LIKE '%" + REVIEW_TYPE.Substring(2, REVIEW_TYPE.Length - 2) + "%'");
            }
            sb.AppendLine(" INNER JOIN TENDER_PROJECT");
            sb.AppendLine("    ON TENDER_PROJECT.TENDER_PROJECT_CODE = REVIEW_INSTANCE.TENDER_PROJECT_CODE");
            sb.AppendLine("    AND TENDER_PROJECT.RECORD_DEPID =" + JdUser?.UserDepartment?.DEPID);
            sb.AppendLine("  LEFT JOIN SYS_DIC ");
            sb.AppendLine("    ON  SYS_DIC.TYPE ='1000' AND SYS_DIC.VALUE=TENDER_PROJECT.TENDER_MODE");
            sb.AppendLine("  LEFT JOIN SYS_DIC SYS_DIC2 ");
            sb.AppendLine("    ON  SYS_DIC2.TYPE ='2002' AND SYS_DIC2.VALUE=TENDER_PROJECT.TENDER_PROJECT_TYPE");
            sb.AppendLine("  LEFT JOIN T_USER_DEPARTMENT ");
            sb.AppendLine("    ON T_USER_DEPARTMENT.DEPID = TENDER_PROJECT.RECORD_DEPID");
            sb.AppendLine(" WHERE 1=1 ");
            if (!String.IsNullOrWhiteSpace(node_name))
            {
                sb.AppendLine(" AND NODE_NAME = '" + node_name + "'");
                sb.AppendLine("   AND REVIEW_INSTANCE.IS_END =0");
            }
            if (REVIEW_ASCRIPTION.HasValue && REVIEW_ASCRIPTION.Value == 1)
            {
                sb.AppendLine(" AND " + JdUser.ID.ToString() + " in (SELECT * FROM TABLE(SPLIT(REVIEW_INSTANCE.NOW_USERS)))");
            }
            sb.AppendLine(")T");


            var query = FromTable(sb.ToString());
            var count = query.Where(condition.ToWhereClip()).Count();

            var datas = query
                .Where(condition.ToWhereClip())
                .OrderBy(new Field("REVIEW_NEW_TIME").Desc)
                .Page(search.PageSize, search.PageNo).ToList<dynamic>();
            var tender_project_code_list = datas.Select(t => (string)t.TENDER_PROJECT_CODE).ToList();
            var collection_child = datas.Any() ? Collection_Child_ZJ(tender_project_code_list) : new List<dynamic>();
            var pageList = datas.Select(t => new
            {
                M_ID = t.M_ID,
                TENDER_PROJECT_CODE = t.TENDER_PROJECT_CODE,
                TENDER_PROJECT_CODE_OLD1 = t.TENDER_PROJECT_CODE_OLD1,
                TENDER_PROJECT_NAME = t.TENDER_PROJECT_NAME,
                TENDER_AGENCY_CODE = t.TENDER_AGENCY_CODE,
                TENDER_AGENCY_NAME = t.TENDER_AGENCY_NAME,
                TENDER_PROJECT_TYPE = t.TENDER_PROJECT_TYPE,
                TENDER_MODE = t.TENDER_MODE,
                PLATFORM_CODE = t.PLATFORM_CODE,
                UNIFIED_DEAL_CODE = t.UNIFIED_DEAL_CODE,
                CONSTRUCTION_ID = t.CONSTRUCTION_ID,
                M_CREATE_TM = t.M_CREATE_TM,
                IS_SC = t.IS_SC,
                IS_BA = t.IS_BA,
                RTYPE = t.RTYPE,
                TENDER_MODE_TEXT = t.TENDER_MODE_TEXT,
                TENDER_PROJECT_TYPE_TEXT = t.TENDER_PROJECT_TYPE_TEXT,
                RECORD_DEPID = t.RECORD_DEPID,
                RECORD_DEPNAME = t.DNAME,
                TENDERER_NAME = t.TENDERER_NAME,
                TENDERER_CONTRACT = t.TENDERER_CONTRACT,
                TENDERER_PHONE = t.TENDERER_PHONE,
                TENDER_AGENT_CONTRACT = t.TENDER_AGENT_CONTRACT,
                TENDER_AGENT_PHONE = t.TENDER_AGENT_PHONE,
                JGBM = t.JGBM,
                PROCESS = GetProcess(collection_child, t.TENDER_PROJECT_CODE, t.RECORD_DEPID, REVIEW_TYPE, REVIEW_ASCRIPTION)
            }).ToPageTableResult(search, count);
            return pageList;
        }

        public IEnumerable<dynamic> GetProcess(List<dynamic> collection, string tender_project_code, string RECORD_DEPID, string review_type
            , int? REVIEW_ASCRIPTION)
        {
            if (!collection.Any())
            {
                return new List<dynamic>();
            }
            var datas = collection.Where(w => w.TENDER_PROJECT_CODE == tender_project_code);
            if (REVIEW_ASCRIPTION.HasValue && REVIEW_ASCRIPTION.Value == 1)
            {
                datas = datas.Where(w => null != w.NOW_USERS_ID && ("," + w.NOW_USERS_ID.ToString() + ",").Contains("," + JdUser.ID?.ToString() + ","));
            }
            if (!datas.Any())
            {
                return new List<dynamic>();
            }

            var rtype = datas.FirstOrDefault().REVIEW_TYPE.Substring(0, 2);
            if ("MZ".Equals(rtype) || "MT".Equals(rtype))
            {
                var data = datas.GroupBy(g => new { g.REVIEW_TYPE, g.REVIEW_TYPE_TEXT });
                if (!String.IsNullOrEmpty(review_type))
                {
                    data = data.Where(w => w.Key.REVIEW_TYPE.Contains(review_type.Substring(2, 3)));
                }
                var result = data.Select(p => new
                {
                    TEXT = p.Key.REVIEW_TYPE_TEXT,
                    VALUE = p.Key.REVIEW_TYPE,
                    REVIEW_COUNT = p.Where(w2 => w2.RECORD_ID != null).Count(),
                    data = p.Where(w2 => w2.RECORD_ID != null).Select(t2 => new
                    {
                        REVIEW_CODE = t2.REVIEW_CODE,
                        RECORD_ID = t2.RECORD_ID,
                        TYPE = t2.TYPE,
                        REVIEW_TYPE = t2.REVIEW_TYPE,
                        REVIEW_TYPE_TEXT = t2.REVIEW_TYPE_TEXT,
                        COMMIT_TIME = (t2.TYPE == "103") ? t2.REVIEW_COMMIT_TIME : t2.COMMIT_TIME,
                        REVIEW_STATUS = t2.REVIEW_STATUS,
                        REVIEW_STATUS_TEXT = (t2.TYPE == "103") ? "" : t2.IS_END == 1 ? "已" + t2.NODE_NAME.ToString() : "待" + t2.NODE_NAME.ToString(),
                        IS_SIGN = (t2.TYPE == "103") ? null : t2.IS_SIGN,
                        SIGN_PERSON = t2.IS_END == 1 ? "" : t2.NOW_USERS,
                        SIGN_TIME = t2.SIGN_TIME,
                        REVIEW_TIME = (t2.TYPE == "103") ? "" : t2.IS_END == 1 ? t2.REVIEW_TIME : "",
                        TENDER_PROJECT_CODE = t2.TENDER_PROJECT_CODE,
                        RECORD_DEPID = RECORD_DEPID,
                        OPERATE_TEXT = (t2.TYPE == "103") ? "详情" : ("," + t2.NOW_USERS_ID + ",").ToString().Contains("," + JdUser.ID + ",") ? "审查" : "详情"
                    })
                     .OrderByDescending(od => od.COMMIT_TIME)
                }).OrderBy(od2 => od2.VALUE);
                return result;
            }
            if (true)
            {
                var data = datas.GroupBy(g => new { g.REVIEW_TYPE, g.REVIEW_TYPE_TEXT });
                if (!String.IsNullOrEmpty(review_type))
                {
                    data = data.Where(w => w.Key.REVIEW_TYPE.Contains(review_type.Substring(2, 3)));
                }

                var result = data.Select(p => new
                {
                    TEXT = p.Key.REVIEW_TYPE_TEXT,
                    VALUE = p.Key.REVIEW_TYPE,
                    REVIEW_COUNT = p.Where(w2 => w2.RECORD_ID != null).Count(),
                    data = p.Where(w2 => w2.RECORD_ID != null).Select(t2 => new
                    {
                        RECORD_ID = t2.RECORD_ID,
                        REVIEW_CODE = t2.REVIEW_CODE,
                        TYPE = t2.TYPE,
                        REVIEW_TYPE = t2.REVIEW_TYPE,
                        REVIEW_TYPE_TEXT = t2.REVIEW_TYPE_TEXT,
                        COMMIT_TIME = t2.COMMIT_TIME,
                        REVIEW_STATUS = t2.REVIEW_STATUS,
                        REVIEW_STATUS_TEXT = GET_REVIEW_STATUS_TEXT_SL(t2.TYPE.ToString(), t2.REVIEW_STATUS.ToString(), t2.IS_SIGN),
                        IS_SIGN = (t2.TYPE == "102" || t2.TYPE == "103" || t2.TYPE == "105") ? null : t2.IS_SIGN,
                        SIGN_PERSON = t2.SIGN_PERSON,
                        SIGN_TIME = t2.SIGN_TIME,
                        REVIEW_TIME = t2.REVIEW_TIME,
                        TENDER_PROJECT_CODE = t2.TENDER_PROJECT_CODE,
                        RECORD_DEPID = RECORD_DEPID,
                        OPERATE_TEXT = GET_OPERATE_TEXT(t2)
                    })
                    .OrderByDescending(od => od.COMMIT_TIME)
                }).OrderBy(od2 => od2.VALUE);
                return result;
            }

        }
        /// <summary>
        /// 水利备案列表各种坑爹状态文字显示
        /// </summary>
        /// <param name="type"></param>
        /// <param name="reviewstatus"></param>
        /// <param name="issign"></param>
        /// <returns></returns>
        protected string GET_REVIEW_STATUS_TEXT_SL(string type, string reviewstatus, decimal? issign)
        {
            if ((new List<string>() { "103", "104", "105" }).Contains(type))
            {
                return "";
            }
            if (issign.HasValue && issign == 1 && reviewstatus == "1")
            {
                return "未提意见";
            }
            if (issign.HasValue && issign == 0 && reviewstatus == "1")
            {
                return "待签收";
            }
            return ((EnumOperation)Convert.ToInt32(reviewstatus)).DisplayEnumDescription();
        }

        /// <summary>
        /// 获取非住建行业列表的子列表操作栏操作按钮显示名称
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        protected string GET_OPERATE_TEXT(dynamic dic)
        {
            if (dic.TYPE == "103" || dic.TYPE == "105")
            {
                return "详情";
            }
            if (dic.TYPE == "102")
            {
                return "审查";
            }
            if (null != dic.IS_SIGN && dic.IS_SIGN.ToString() == "0")
            {
                return "签收";
            }
            if (dic.REVIEW_STATUS.ToString() == "1" && dic.TYPE != "104")
            {
                return "审查";
            }
            return "详情";
        }

        /// <summary>
        /// 招标项目管理页面列表 获取每个项目下的备案列表
        /// </summary>
        /// <param name="tender_project_codes"></param>
        /// <returns></returns>
        protected List<dynamic> Collection_Child(List<string> tender_project_codes)
        {
            var data = FromWhere<SYS_DIC>()
                 .InnerJoin<TENDER_PROJECT>(SYS_DIC._.TYPE == "3021"
                 && SYS_DIC._.VALUE1 == new Field("nvl(TENDER_PROJECT.rtype, 'MC')")
                 && TENDER_PROJECT._.TENDER_PROJECT_CODE.In(tender_project_codes))
                 .LeftJoin<RECORD_REVIEW>(RECORD_REVIEW._.REVIEW_STATUS != "0"
                 && RECORD_REVIEW._.REVIEW_TYPE == SYS_DIC._.VALUE
                 && TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                 .LeftJoin<T_USER>(T_USER._.ID == RECORD_REVIEW._.SIGN_PERSON)
                .Select(
                    RECORD_REVIEW._.REVIEW_STATUS,
                    RECORD_REVIEW._.ID.As("RECORD_ID"),
                    SYS_DIC._.VALUE.As("REVIEW_TYPE"),
                    new Field("substr(REVIEW_TYPE, 3, 3)").As("TYPE"),
                    RECORD_REVIEW._.REVIEW_CODE,
                    SYS_DIC._.TEXT.As("REVIEW_TYPE_TEXT"),
                    RECORD_REVIEW._.COMMIT_TIME,
                    RECORD_REVIEW._.REVIEW_STATUS,
                    RECORD_REVIEW._.SIGN_TIME,
                    RECORD_REVIEW._.REVIEW_TIME,
                    RECORD_REVIEW._.IS_SIGN,
                    new Field("REVIEW_PERSON").As("NOW_USERS_ID"),
                    RECORD_REVIEW._.SIGN_PERSON.As("SIGN_PERSON_ID"),
                    T_USER._.MANAGE_NAME.As("SIGN_PERSON"),
                    TENDER_PROJECT._.TENDER_PROJECT_CODE
                ).ToList<dynamic>();
            return data;
        }

        protected List<dynamic> Collection_Child_ZJ(List<string> tender_project_codes)
        {
            var codes = String.Join(",", tender_project_codes.Select(t => "'" + t + "'").ToList());
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT SYS_DIC.TEXT AS REVIEW_TYPE_TEXT,SYS_DIC.VALUE AS REVIEW_TYPE,");
            sb.AppendLine("TENDER_PROJECT.TENDER_PROJECT_CODE,T1.*");
            sb.AppendLine("  FROM SYS_DIC");
            sb.AppendLine(" INNER JOIN TENDER_PROJECT");
            sb.AppendLine("    ON NVL(TENDER_PROJECT.RTYPE, 'MC') = SYS_DIC.VALUE1");
            sb.AppendLine("  LEFT JOIN (SELECT *");
            sb.AppendLine("               FROM (SELECT RECORD_REVIEW.ID AS RECORD_ID,");
            sb.AppendLine("                            TENDER_PROJECT.TENDER_PROJECT_CODE AS TENDER_PROJECT_CODE1,");
            sb.AppendLine("                            TENDER_PROJECT.RTYPE,");
            sb.AppendLine("                            RECORD_REVIEW.IS_SIGN,");
            sb.AppendLine("                            RECORD_REVIEW.SIGN_TIME,");
            sb.AppendLine("                            RECORD_REVIEW.REVIEW_CODE,");
            sb.AppendLine("                            RECORD_REVIEW.REVIEW_TYPE AS REVIEW_TYPE1,");
            sb.AppendLine("                            RECORD_REVIEW.REVIEW_STATUS,");
            sb.AppendLine("                            SUBSTR(REVIEW_TYPE, 3, 3) AS TYPE,");
            sb.AppendLine("                            RECORD_REVIEW.COMMIT_TIME AS REVIEW_COMMIT_TIME,");
            sb.AppendLine("                            REVIEW_INSTANCE.CREATE_TM AS COMMIT_TIME,");
            sb.AppendLine("                            REVIEW_INSTANCE.IS_END,");
            sb.AppendLine("                            NVL(REVIEW_INSTANCE.NOW_USERS,'') AS NOW_USERS_ID,");
            sb.AppendLine("                            (SELECT LISTAGG(MANAGE_NAME, ',') WITHIN GROUP(ORDER BY ID) USER_NAME");
            sb.AppendLine("                             FROM T_USER");
            sb.AppendLine("                                 WHERE ID IN");
            sb.AppendLine("                                     (SELECT *");
            sb.AppendLine("                                         FROM TABLE(SPLIT(REVIEW_INSTANCE.NOW_USERS)))) NOW_USERS,");
            sb.AppendLine("                            REVIEW_NODE.NODE_NAME,");
            sb.AppendLine("                            REVIEW_LOG.OPERNAME,");
            sb.AppendLine("                            REVIEW_LOG.OPER_TM AS REVIEW_TIME,");
            sb.AppendLine("                            T_USER.MANAGE_NAME AS SIGN_PERSON,");
            sb.AppendLine("                            T_USER_DEPARTMENT.DNAME,");
            sb.AppendLine("                            ROW_NUMBER() OVER(PARTITION BY RECORD_REVIEW.ID ORDER BY NVL(REVIEW_INSTANCE.ID,RECORD_REVIEW.ID) DESC) RN");
            sb.AppendLine("                       FROM TENDER_PROJECT");
            sb.AppendLine("                       LEFT JOIN RECORD_REVIEW");
            sb.AppendLine("                         ON RECORD_REVIEW.TENDER_PROJECT_CODE = TENDER_PROJECT.TENDER_PROJECT_CODE");
            sb.AppendLine("                        AND RECORD_REVIEW.REVIEW_STATUS != '0'");
            sb.AppendLine("                        AND (TENDER_PROJECT.RTYPE = 'MZ' OR");
            sb.AppendLine("                            TENDER_PROJECT.RTYPE = 'MT')");
            sb.AppendLine("                       LEFT JOIN REVIEW_INSTANCE");
            sb.AppendLine("                         ON RECORD_REVIEW.ID = REVIEW_INSTANCE.BA_ID");
            sb.AppendLine("                       LEFT JOIN REVIEW_NODE");
            sb.AppendLine("                         ON REVIEW_INSTANCE.NOW_NODE = REVIEW_NODE.ID");
            sb.AppendLine("                        AND REVIEW_INSTANCE.MAIN_ID = REVIEW_NODE.MAIN_ID");
            sb.AppendLine("                       LEFT JOIN REVIEW_LOG");
            sb.AppendLine("                         ON REVIEW_LOG.SL_ID = REVIEW_INSTANCE.ID");
            sb.AppendLine("                       LEFT JOIN T_USER");
            sb.AppendLine("                         ON T_USER.ID = REVIEW_LOG.USER_ID");
            sb.AppendLine("                       LEFT JOIN T_USER_DEPARTMENT");
            sb.AppendLine("                         ON T_USER_DEPARTMENT.DEPID =");
            sb.AppendLine("                            TENDER_PROJECT.RECORD_DEPID");
            sb.AppendLine("                        AND TENDER_PROJECT.RECORD_DEPID = " + JdUser?.DEPARTID + ") T");
            sb.AppendLine("              WHERE T.RN = 1) T1");
            sb.AppendLine("    ON T1.RTYPE = SYS_DIC.VALUE1");
            sb.AppendLine("   AND T1.REVIEW_TYPE1 = SYS_DIC.VALUE");
            sb.AppendLine("   AND TENDER_PROJECT.TENDER_PROJECT_CODE = T1.TENDER_PROJECT_CODE1");
            sb.AppendLine(" WHERE SYS_DIC.TYPE = '3021'");
            sb.AppendLine("   AND TENDER_PROJECT.TENDER_PROJECT_CODE IN (" + codes + ")");
            sb.AppendLine(" ORDER BY SYS_DIC.ORDER_ID");


            var data = FromSql(sb.ToString()).ToList<dynamic>();
            return data;
        }

        /// <summary>
        /// 根据招标项目编号获取备案进度,并统计每个节点的备案数据数量
        /// </summary>
        /// <param name="tender_project_code">招标项目编号，多个招标项目编号使用英文状态下的逗号隔开(,)</param>
        /// <returns></returns>
        protected IEnumerable<dynamic> GetRecordReviewProcessCount(string tender_project_codes)
        {
            /*
             PROCESS_STATUS 值说明
             0 暂存，未提交，
             1 已提交，流程审批中
             2 审批不通过
             4 审批通过
             */
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select dv.tender_project_code,");
            sb.AppendLine("       dv.value,");
            sb.AppendLine("       dv.text,");
            sb.AppendLine("       nvl(v.review_count,0) as review_count");
            sb.AppendLine("  from (select tp.tender_project_code,");
            sb.AppendLine("               d.value,");
            sb.AppendLine("               d.text,");
            sb.AppendLine("               d.value1,");
            sb.AppendLine("               min(d.order_id) as order_id");
            sb.AppendLine("          from sys_dic d");
            sb.AppendLine("         inner join TENDER_PROJECT tp");
            sb.AppendLine("            on d.value1 = nvl(tp.rtype, 'MC')");
            sb.AppendLine("         where d.type = '3021'");
            sb.AppendLine("           and exists");
            sb.AppendLine("         (select 1");
            sb.AppendLine("                  from (select column_value as tender_project_code");
            sb.AppendLine("                          from table(split('" + tender_project_codes + "', ','))) tin");
            sb.AppendLine("                 where tp.tender_project_code = tin.tender_project_code)");
            sb.AppendLine("         group by d.value, d.text, d.value1, tp.tender_project_code) dv");
            sb.AppendLine("  left join (select TENDER_PROJECT_CODE,");
            sb.AppendLine("                    REVIEW_TYPE,");
            sb.AppendLine("                    rtype,");
            sb.AppendLine("                    count(1) as review_count");
            sb.AppendLine("               from (select t.TENDER_PROJECT_CODE,");
            sb.AppendLine("                            r.REVIEW_TYPE,");
            sb.AppendLine("                            nvl(t.rtype, 'MC') as RTYPE");
            sb.AppendLine("                       from TENDER_PROJECT t");
            sb.AppendLine("                      inner join RECORD_REVIEW r");
            sb.AppendLine("                         on (t.TENDER_PROJECT_CODE = r.TENDER_PROJECT_CODE and");
            sb.AppendLine("                             r.REVIEW_STATUS <> '0' and");
            sb.AppendLine("                            exists (select 1");
            sb.AppendLine("                                      from (select column_value as tender_project_code");
            sb.AppendLine("                                              from table(split('" + tender_project_codes + "', ','))) tin");
            sb.AppendLine("                                     where r.tender_project_code =");
            sb.AppendLine("                                           tin.tender_project_code)))");
            sb.AppendLine("              group by TENDER_PROJECT_CODE, REVIEW_TYPE, rtype) v");
            sb.AppendLine("   ON dv.value = v.review_type");
            sb.AppendLine("   AND dv.TENDER_PROJECT_CODE = v.TENDER_PROJECT_CODE");
            sb.AppendLine(" order by order_id");


            var data = FromSql(sb.ToString()).ToList<dynamic>();
            return data;

        }

        /// <summary>
        /// 根据招标项目编号获取备案进度
        /// </summary>
        /// <param name="tender_project_code">招标项目编号，多个招标项目编号使用英文状态下的逗号隔开(,)</param>
        /// <returns></returns>
        public IEnumerable<RecordReviewProcessResponseModel> GetRecordReviewProcess(string tender_project_codes)
        {
            /*
             PROCESS_STATUS 值说明
             0 暂存，未提交，
             1 已提交，流程审批中
             2 审批不通过
             4 审批通过
             */
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select dv.tender_project_code,");
            sb.AppendLine("       dv.value,");
            sb.AppendLine("       dv.text,");
            sb.AppendLine("       nvl(v.review_status, 0) as PROCESS_STATUS");
            sb.AppendLine("  from (select tp.tender_project_code,");
            sb.AppendLine("               d.value,");
            sb.AppendLine("               d.text,");
            sb.AppendLine("               d.value1,");
            sb.AppendLine("               min(d.order_id) as order_id");
            sb.AppendLine("          from sys_dic d");
            sb.AppendLine("         inner join TENDER_PROJECT tp");
            sb.AppendLine("            on d.value1 = nvl(tp.rtype, 'MC')");
            sb.AppendLine("         where d.type = '3021'");
            sb.AppendLine("           and exists");
            sb.AppendLine("         (select 1");
            sb.AppendLine("                  from (select column_value as tender_project_code");
            sb.AppendLine("                          from table(split('" + tender_project_codes + "', ','))) tin");
            sb.AppendLine("                 where tp.tender_project_code = tin.tender_project_code)");
            sb.AppendLine("         group by d.value, d.text, d.value1, tp.tender_project_code) dv");
            sb.AppendLine("  left join (select TENDER_PROJECT_CODE,");
            sb.AppendLine("                    REVIEW_TYPE,");
            sb.AppendLine("                    rtype,");
            sb.AppendLine("                    max(review_status) as review_status");
            sb.AppendLine("               from (select t.TENDER_PROJECT_CODE,");
            sb.AppendLine("                            r.REVIEW_TYPE,");
            sb.AppendLine("                            nvl(t.rtype, 'MC') as RTYPE,");
            sb.AppendLine("                            case");
            sb.AppendLine("                              when to_number(r.review_status) = 5 then 4");
            sb.AppendLine("                              when to_number(r.review_status) in (2, 3, 6) then 2");
            sb.AppendLine("                              when to_number(r.review_status) = 0 then 0");
            sb.AppendLine("                              else 1");
            sb.AppendLine("                            end as review_status");
            sb.AppendLine("                       from TENDER_PROJECT t");
            sb.AppendLine("                      inner join RECORD_REVIEW r");
            sb.AppendLine("                         on (t.TENDER_PROJECT_CODE = r.TENDER_PROJECT_CODE and");
            sb.AppendLine("                            exists (select 1");
            sb.AppendLine("                                      from (select column_value as tender_project_code");
            sb.AppendLine("                                              from table(split('" + tender_project_codes + "', ','))) tin");
            sb.AppendLine("                                     where r.tender_project_code =");
            sb.AppendLine("                                           tin.tender_project_code)))");
            sb.AppendLine("              group by TENDER_PROJECT_CODE, REVIEW_TYPE, rtype) v");
            sb.AppendLine("   ON dv.value = v.review_type");
            sb.AppendLine("   AND dv.TENDER_PROJECT_CODE = v.TENDER_PROJECT_CODE");
            sb.AppendLine(" order by order_id");


            var data = FromSql(sb.ToString()).ToList<RecordReviewProcessResponseModel>();
            return data;

        }
        /// <summary>
        /// 根据招标项目名称/招标项目代码，判断招标项目是否已存在
        /// </summary>
        /// <param name="tender_project_name">招标项目名称</param>
        /// <param name="tender_project_code">招标项目代码</param>
        /// <returns></returns>
        public bool CheckIsExists(string tender_project_name, string tender_project_code)
        {
            var condition = new WhereClipBuilder();
            condition.And(TENDER_PROJECT._.TENDER_PROJECT_CODE == tender_project_code || TENDER_PROJECT._.TENDER_PROJECT_NAME == tender_project_name);
            condition.And(!TENDER_PROJECT._.TENDER_PROJECT_CODE.IsNull() && !TENDER_PROJECT._.TENDER_PROJECT_NAME.IsNull());
            return Count(condition) > 0;
        }


        /// <summary>
        /// 获取备案类型
        /// </summary>
        /// <param name="type">招标项目类型</param>
        /// <param name="classify">标段（包）分类</param>
        public string GetRType(string type, string classify)
        {

            string rType = "MC";//历史原因，早期通用类型
            if (type != null && type.Length >= 3) type = type.Trim().Substring(0, 3);
            if (classify != null && classify.Length >= 3) classify = classify.Trim().Substring(0, 3);
            if (classify == null) classify = "";

            var condition = new WhereClipBuilder();
            condition.And(SYS_DIC._.TYPE == "3021"
                && SYS_DIC._.VALUE2.IsNotNull()
                && SYS_DIC._.ORDER_ID == 1
                );
            var datas = Jd.SysDicService.FromWhere(condition.ToWhereClip()).GroupBy(SYS_DIC._.VALUE1, SYS_DIC._.VALUE2, SYS_DIC._.VALUE3).Select(
                    SYS_DIC._.VALUE1,
                    SYS_DIC._.VALUE2,
                    SYS_DIC._.VALUE3
                ).ToList<SYS_DIC>();

            //先判断招标项目类型Tender_Project_Type
            foreach (var data in datas)
            {
                if (data.VALUE2.Split(',').Contains(type))
                {
                    rType = data.VALUE1;
                    break;
                }
            }

            //住建类型再判断是否施工，非施工则都返回MT通用类型
            if (rType == "MZ" || rType == "MT")
            {
                rType = "MT";
                foreach (var data in datas)
                {
                    if (!String.IsNullOrWhiteSpace(data.VALUE3) && data.VALUE3 == classify)
                    {
                        rType = data.VALUE1;
                        break;
                    }
                }
            }
            return rType;
            /*
            Dictionary<string, Dictionary<string, string>> dicConfig = new Dictionary<string, Dictionary<string, string>>();
            foreach (var data in datas)
            {
                var list = new List<SYS_DIC>();
                string key = "other";

                if (String.IsNullOrWhiteSpace(data.VALUE2))
                {
                    key = "other";
                    list = datas.Where(w => String.IsNullOrWhiteSpace(w.VALUE2)).ToList();
                }
                else
                {
                    key = "," + data.VALUE2.Trim(',') + ",";
                    list = datas.Where(w => w.VALUE2 == data.VALUE2.Trim(',')).ToList();
                }
                if (dicConfig.Keys.Contains(key)) continue;

                Dictionary<string, string> dicClassify = new Dictionary<string, string>();
                foreach (var item in list)
                {
                    string key2 = "other";
                    if (String.IsNullOrWhiteSpace(item.VALUE3))
                        key2 = "other";
                    else
                        key2 = "," + item.VALUE3.Trim(',') + ",";
                    dicClassify.Add(key2, item.VALUE1);
                }
                dicConfig.Add(key, dicClassify);
            }

            //先判断"招标项目类型"
            string typeKey = "other";
            foreach (KeyValuePair<string, Dictionary<string, string>> config in dicConfig)
            {
                if (config.Key.IndexOf("," + type + ",") < 0) continue;
                typeKey = config.Key;
                break;
            }

            //再判断"标段（包）分类"
            Dictionary<string, string> classifyList = dicConfig[typeKey];
            string classifyKey = "other";
            foreach (KeyValuePair<string, string> config in classifyList)
            {
                if (config.Key.IndexOf("," + classify + ",") < 0) continue;
                classifyKey = config.Key;
                break;
            }

            rType = classifyList[classifyKey];
            return rType;
            */
        }


        /// <summary>
		/// 删除
		/// </summary>
		/// <param name="tender_project_code"></param>
		/// <returns></returns>
		public GeneralResult Delete(string tender_project_code = "")
        {
            GeneralResult result = new GeneralResult();
            try
            {
                var isReview = FromWhere<TENDER_PROJECT>()
                    .InnerJoin<RECORD_REVIEW>(TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                    .Where(TENDER_PROJECT._.TENDER_PROJECT_CODE == tender_project_code
                    && RECORD_REVIEW._.REVIEW_STATUS != "0")
                    .Count() > 0;
                if (isReview)
                {
                    result.SetFail("禁止删除：已提交备案");
                    return result;
                }
                var rows = Jd.TenderProjectService.Delete(TENDER_PROJECT._.TENDER_PROJECT_CODE == tender_project_code);
                if (rows > 0)
                {
                    result.SetSuccess();
                    return result;
                }
                result.SetFail("记录不存在或已被删除");
                return result;
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }

        public GeneralResult TenderProjectInfo(string jdTenderProjectCode, string fwTenderProjectCode)
        {
            var r = new GeneralResult();
            if (!string.IsNullOrWhiteSpace(jdTenderProjectCode))
            {
                var jdTenderProject = FirstOrNull(TENDER_PROJECT._.TENDER_PROJECT_CODE == jdTenderProjectCode);
                if (jdTenderProject != null)
                {
                    var reviewCount =
                        Jd.RecordReviewService.Count(RECORD_REVIEW._.TENDER_PROJECT_CODE ==
                                                     jdTenderProject.TENDER_PROJECT_CODE && RECORD_REVIEW._.REVIEW_STATUS != 0);
                    var superviseDeptName =
                        Jd.TUserDepartmentService.FirstOrNull(
                            T_USER_DEPARTMENT._.DEPID == jdTenderProject?.RECORD_DEPID)?.DNAME;
                    r.SetSuccess(new
                    {
                        jdTenderProject.TENDER_PROJECT_NAME,
                        jdTenderProject.TENDER_PROJECT_CODE,
                        jdTenderProject.TENDERER_NAME,
                        jdTenderProject.TENDERER_CONTRACT,
                        jdTenderProject.TENDER_AGENCY_NAME,
                        jdTenderProject.TENDER_AGENCY_CODE,
                        Buttons = reviewCount == 0 && jdTenderProject.M_CREATOR == JdUser?.ID ? new List<string> { "SAVE" } : null,
                        jdTenderProject.RTYPE,
                        SUPERVISE_DEPT_NAME = superviseDeptName
                    });
                }
                else
                {
                    r.SetFail("未找到对应的招标项目信息");
                }
            }
            else if (!string.IsNullOrWhiteSpace(fwTenderProjectCode))
            {
                var fwTenderProject =
                    Fw.TenderProjectService.FirstOrNull(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE ==
                                                        fwTenderProjectCode);

                if (fwTenderProject != null)
                {
                    var jdTenderProject = FirstOrNull(TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == fwTenderProjectCode);
                    var buttons = new List<string>();
                    if (jdTenderProject != null)
                    {
                        var reviewCount =
                            Jd.RecordReviewService.Count(RECORD_REVIEW._.TENDER_PROJECT_CODE ==
                                                         jdTenderProject.TENDER_PROJECT_CODE && RECORD_REVIEW._.REVIEW_STATUS != 0);
                        if (reviewCount == 0 && jdTenderProject.M_CREATOR == JdUser?.ID)
                        {
                            buttons.Add("SAVE");
                        }
                    }
                    r.SetSuccess(new
                    {
                        TENDER_PROJECT_NAME = jdTenderProject?.TENDER_PROJECT_NAME ?? fwTenderProject.TENDER_PROJECT_NAME,
                        TENDER_PROJECT_CODE = jdTenderProject?.TENDER_PROJECT_CODE ?? fwTenderProject.TENDER_PROJECT_CODE,
                        TENDERER_NAME = jdTenderProject?.TENDERER_NAME ?? fwTenderProject.TENDERER_NAME,
                        jdTenderProject?.TENDERER_CONTRACT,//fwTenderProject.TENDERER_CONTRACT,
                        TENDER_AGENCY_NAME = jdTenderProject?.TENDER_AGENCY_NAME ?? fwTenderProject.TENDER_AGENCY_NAME,
                        TENDER_AGENCY_CODE = jdTenderProject?.TENDER_AGENCY_CODE ?? fwTenderProject.TENDER_AGENCY_CODE,
                        Buttons = buttons,
                        RTYPE=jdTenderProject?.RTYPE,
                        fwTenderProject.SUPERVISE_DEPT_NAME
                    });
                }
                else
                {
                    r.SetFail("未找到对应的招标项目信息");
                }
            }
            else
            {
                r.SetFailEx("参数错误", $"jdTenderProjectCode、fwTenderProjectCode至少一个要有值");
            }

            return r;
        }

        #region 项目详情接口需要用到

        /// <summary>
        /// 通过服务平台TENDER_PROJECT_CODE获取监督平台对应的TENDER_PROJECT信息
        /// </summary>
        /// <param name="fwTenderProjectCode">服务平台TENDER_PROJECT_CODE</param>
        /// <returns></returns>
        public GeneralResult<TENDER_PROJECT> GetJdTenderProjectFwTpCode(string fwTenderProjectCode)
        {
            var r = new GeneralResult<TENDER_PROJECT>();
            var entities = GetJdTenderProjectsFwTpCodes(fwTenderProjectCode);
            if (entities == null || !entities.Any())
            {
                r.SetFail("未找到对应的招标项目名称");
            }
            else
            {
                r.SetSuccessT(entities.FirstOrDefault());
            }
            return r;
        }
        /// <summary>
        /// 通过服务平台TENDER_PROJECT_CODE获取监督平台对应的TENDER_PROJECT信息
        /// </summary>
        /// <param name="fwTenderProjectCode">服务平台TENDER_PROJECT_CODE</param>
        /// <returns></returns>
        public List<TENDER_PROJECT> GetJdTenderProjectsFwTpCodes(params string[] fwTenderProjectCode)
        {
            var entities = FindList(TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1.In(fwTenderProjectCode));
            return entities;
        }
        #endregion
    }
}