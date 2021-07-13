using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using Dos.ORM;
using GGZY.Core.Helper;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;
using TzCodeService;

namespace GGZY.Services.JianDu
{
    public partial class RecordCreditDeductionService
    {
        /// <summary>
        /// 获取信用分-问题属性列表
        /// </summary>
        /// <returns></returns>
        public GeneralResult GetProgramAttributes()
        {
            var r = new  GeneralResult();
            var data = Jd.SysDicService.FindList(SYS_DIC._.TYPE == "3029")
                .Select(c=> new {
                    id = c.ID?.ToString(),
                    label = c.TEXT,
                    value = c.VALUE,
                    score = c.VALUE1
                });
            r.SetSuccess(data);
            return r;
        }
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="search">搜索条件</param>
        /// <returns></returns>
        public GeneralResult GetCreditList(CreditSearchModel search)
        {
            var r = new GeneralResult();
            //判断没有时间区间不让查
            if (DateTime.MinValue.Equals(search.BeginTM) || DateTime.MinValue.Equals(search.EndTM))
            {
                r.SetFail("请设置时间区间");
                return r;
            }

            StringBuilder sbsql = new StringBuilder();
            List<DbParameter> parameters = new List<DbParameter>();
            sbsql.Append(@"WITH BASE_TB AS (
           SELECT A.ID,
                  ',' || WM_CONCAT(C.PROBLEM_ATTRIBUTE) || ',' AS  PROBLEM_ATTRIBUTE,
                  SUM(CASE WHEN C.IS_ADJUST = '1' THEN C.AFTER_CREDIT_NUM ELSE C.BEFORE_CREDIT_NUM END) AS SCORE,
                  MAX(CASE WHEN C.IS_ADJUST = '1' THEN C.AFTER_IS_DOUBLE ELSE C.BEFORE_IS_DOUBLE END) AS IS_DOUBLE,
                  (CASE WHEN A.IS_ADJUST = '1' THEN A.ADJUST_TIME ELSE A.REVIEW_TIME END) TM
             FROM RECORD_REVIEW A
                  INNER JOIN TENDER_PROJECT B ON A.TENDER_PROJECT_CODE = B.TENDER_PROJECT_CODE
                  INNER JOIN RECORD_CREDIT_DEDUCTION C ON A.ID = C.REVIEW_ID
            WHERE A.CREATOR=:CREATOR AND A.REVIEW_STATUS IN ('5','6','9') ");
            parameters.Add(new OracleParameter(":CREATOR", JdUser.ID));
            if (!string.IsNullOrWhiteSpace(search.SearchKey))
            {
                sbsql.Append(" AND (B.TENDER_PROJECT_CODE LIKE '%'||:SearchKey||'%' OR B.TENDER_PROJECT_NAME LIKE '%'||:SearchKey||'%')");
                parameters.Add(new OracleParameter(":SearchKey", search.SearchKey));
            }
            if (!DateTime.MinValue.Equals(search.BeginTM))
            {
                sbsql.Append(" AND (CASE WHEN A.IS_ADJUST = '1' THEN A.ADJUST_TIME ELSE A.REVIEW_TIME END) >= :BeginTM");
                parameters.Add(new OracleParameter(":BeginTM", search.BeginTM));
            }
            if (!DateTime.MinValue.Equals(search.EndTM))
            {
                sbsql.Append(" AND (CASE WHEN A.IS_ADJUST = '1' THEN A.ADJUST_TIME ELSE A.REVIEW_TIME END) <= :EndTM");
                parameters.Add(new OracleParameter(":EndTM", search.EndTM));
            }
            if (!string.IsNullOrWhiteSpace(search.REVIEW_TYPE))
            {
                sbsql.Append(" AND A.REVIEW_TYPE = :REVIEW_TYPE");
                parameters.Add(new OracleParameter(":REVIEW_TYPE", search.REVIEW_TYPE));
            }

            sbsql.Append(@"  GROUP BY A.ID,(CASE WHEN A.IS_ADJUST = '1' THEN A.ADJUST_TIME ELSE A.REVIEW_TIME END) 
        )
        SELECT * 
        FROM (SELECT ROW_NUMBER() OVER(ORDER BY B.TM DESC) AS RN,
                     A.ID,
                     A.REVIEW_CODE,
                     C.TENDER_PROJECT_CODE,
                     C.TENDER_PROJECT_CODE_OLD1,
                     C.TENDER_PROJECT_NAME,
                     D.TEXT AS REVIEW_TYPE,
                     E.DNAME,
                     A.IS_ADJUST,
                     B.SCORE,
                     B.IS_DOUBLE,
                     TO_CHAR(B.TM,'yyyy.MM.dd hh24:mi') AS TM,
                     A.REVIEW_TYPE REVIEW_TYPE_EN
                FROM RECORD_REVIEW A
                     INNER JOIN BASE_TB B ON A.ID=B.ID
                     INNER JOIN TENDER_PROJECT C ON A.TENDER_PROJECT_CODE = C.TENDER_PROJECT_CODE
                     LEFT JOIN (SELECT TEXT,VALUE FROM SYS_DIC WHERE TYPE=3021) D ON A.REVIEW_TYPE=D.VALUE
                     LEFT JOIN T_USER_DEPARTMENT E ON C.RECORD_DEPID=E.DEPID
               WHERE 1=1 AND B.SCORE>0");
            if (!string.IsNullOrWhiteSpace(search.PROBLEM_ATTRIBUTE))
            {
                sbsql.Append(" AND B.PROBLEM_ATTRIBUTE LIKE '%,'||:PROBLEM_ATTRIBUTE||',%'");
                parameters.Add(new OracleParameter(":PROBLEM_ATTRIBUTE", search.PROBLEM_ATTRIBUTE));
            }

            sbsql.Append(@" ) TB 
        WHERE RN BETWEEN :pagesize*(:pageno-1)+1 AND :pagesize*:pageno");
            parameters.Add(new OracleParameter() { DbType = DbType.Decimal, ParameterName = ":pagesize", Value = search.PageSize });
            parameters.Add(new OracleParameter { DbType = DbType.Decimal, ParameterName = ":pageno", Value = search.PageNo });

            StringBuilder countSb = new StringBuilder();
            List<DbParameter> countParameters = new List<DbParameter>();
            countSb.Append(@"WITH BASE_TB AS (
           SELECT A.ID,
                  ',' || WM_CONCAT(C.PROBLEM_ATTRIBUTE) || ',' AS  PROBLEM_ATTRIBUTE,
                  SUM(CASE WHEN C.IS_ADJUST = '1' THEN C.AFTER_CREDIT_NUM ELSE C.BEFORE_CREDIT_NUM END) AS SCORE
             FROM RECORD_REVIEW A
                  INNER JOIN TENDER_PROJECT B ON A.TENDER_PROJECT_CODE = B.TENDER_PROJECT_CODE
                  INNER JOIN RECORD_CREDIT_DEDUCTION C ON A.ID = C.REVIEW_ID
            WHERE A.CREATOR=:CREATOR AND A.REVIEW_STATUS IN ('5','6','9')  ");
            countParameters.Add(new OracleParameter(":CREATOR", JdUser.ID));
            if (!string.IsNullOrWhiteSpace(search.SearchKey))
            {
                countSb.Append(" AND (B.TENDER_PROJECT_CODE LIKE '%'||:SearchKey||'%' OR B.TENDER_PROJECT_NAME LIKE '%'||:SearchKey||'%')");
                countParameters.Add(new OracleParameter(":SearchKey", search.SearchKey));
            }
            if (!DateTime.MinValue.Equals(search.BeginTM))
            {
                countSb.Append(" AND (CASE WHEN A.IS_ADJUST = '1' THEN A.ADJUST_TIME ELSE A.REVIEW_TIME END) >= :BeginTM");
                countParameters.Add(new OracleParameter(":BeginTM", search.BeginTM));
            }
            if (!DateTime.MinValue.Equals(search.EndTM))
            {
                countSb.Append(" AND (CASE WHEN A.IS_ADJUST = '1' THEN A.ADJUST_TIME ELSE A.REVIEW_TIME END) <= :EndTM");
                countParameters.Add(new OracleParameter(":EndTM", search.EndTM));
            }
            if (!string.IsNullOrWhiteSpace(search.REVIEW_TYPE))
            {
                countSb.Append(" AND A.REVIEW_TYPE = :REVIEW_TYPE");
                countParameters.Add(new OracleParameter(":REVIEW_TYPE", search.REVIEW_TYPE));
            }

            countSb.Append(@" GROUP BY A.ID
        )
        SELECT COUNT(1) AS COUNT,
               NVL(SUM(B.SCORE),0) AS SUM
          FROM RECORD_REVIEW A
               INNER JOIN BASE_TB B ON A.ID=B.ID
         WHERE 1=1 AND B.SCORE>0");
            if (!string.IsNullOrWhiteSpace(search.PROBLEM_ATTRIBUTE))
            {
                countSb.Append(" AND B.PROBLEM_ATTRIBUTE LIKE '%,'||:PROBLEM_ATTRIBUTE||',%'");
                countParameters.Add(new OracleParameter(":PROBLEM_ATTRIBUTE", search.PROBLEM_ATTRIBUTE));
            }

            var dt = FromSql(sbsql.ToString()).AddParameter(parameters.ToArray()).ToDataTable().ToDictionary();
            var countDt = FromSql(countSb.ToString()).AddParameter(countParameters.ToArray()).ToDataTable();
            int count = countDt.Rows[0]["COUNT"].ToString().ToInt();
            int sum = countDt.Rows[0]["SUM"].ToString().ToInt();
            var result = new
            {
                list = dt,
                Count = count,
                Sum = sum
            };

            r.SetSuccess(result);
            return r;
        }
        /// <summary>
        /// 展开明细
        /// </summary>
        /// <param name="REVIEW_ID">备案id</param>
        /// <returns></returns>
        public GeneralResult GetCreditDetailList(string REVIEW_ID)
        {
            var r = new GeneralResult();
            string sql = @"SELECT ROW_NUMBER() OVER(ORDER BY A.CREATE_TM) AS RN,
              A.EXIST_PROBLEM,
              A.EXAMIN_OPINION,
              B.TEXT AS PROBLEM_ATTRIBUTE_TEXT,
              A.PROBLEM_ATTRIBUTE,
              A.BEFORE_CREDIT_NUM,
              A.BEFORE_IS_DOUBLE,
              A.IS_ADJUST,
              A.AFTER_CREDIT_NUM,
              A.AFTER_IS_DOUBLE
         FROM RECORD_CREDIT_DEDUCTION A
              LEFT JOIN (SELECT TEXT,VALUE FROM SYS_DIC WHERE TYPE=3029) B ON A.PROBLEM_ATTRIBUTE=B.VALUE
        WHERE A.REVIEW_ID=:REVIEW_ID";
            var dt = FromSql(sql).AddInParameter(":REVIEW_ID", DbType.String, REVIEW_ID).ToDataTable().ToDictionary();

            r.SetSuccess(dt);
            return r;
        }
        /// <summary>
        /// 扣分详情页
        /// </summary>
        /// <param name="code">备案编号</param>
        /// <returns></returns>
        public GeneralResult GetDetail(string code)
        {
            var r = new GeneralResult();
            string titleSql = @" SELECT A.ID,
                   A.REVIEW_CODE,
                   B.TENDER_PROJECT_CODE,
                   B.TENDER_PROJECT_NAME,
                   C.MANAGE_NAME,
                   D.TEXT AS REVIEW_TYPE,
                   (CASE WHEN A.IS_ADJUST = '1' THEN A.ADJUST_TIME ELSE A.REVIEW_TIME END) TM
              FROM RECORD_REVIEW A
                   INNER JOIN TENDER_PROJECT B ON A.TENDER_PROJECT_CODE = B.TENDER_PROJECT_CODE
                   LEFT JOIN T_USER C ON A.REVIEW_PERSON = C.ID
                   LEFT JOIN (SELECT TEXT,VALUE FROM SYS_DIC WHERE TYPE=3021) D ON A.REVIEW_TYPE=D.VALUE
             WHERE A.REVIEW_CODE=:CODE";
            var titleDt = FromSql(titleSql).AddInParameter(":CODE", DbType.String, code).ToDataTable().ToDictionary();
            string recordSql = @"SELECT A.ID,
                   A.REVIEW_CODE,
                   B.TENDER_PROJECT_CODE,
                   B.TENDER_PROJECT_NAME,
                   B.SUPERVISE_DEPT_NAME,
                   B.SUPERVISE_DEPT_CODE,
                   D.TEXT AS REVIEW_TYPE,
                   A.COMMIT_TIME,
                   A.SIGN_TIME,
                   B.TENDERER_NAME,
                   B.TENDER_AGENCY_NAME,
                   A.REVIEW_TIME,
                   A.REVIEW_STATUS,
                   A.REVIEW_COMMENT,
                   (SELECT SUM(BEFORE_CREDIT_NUM) FROM RECORD_CREDIT_DEDUCTION WHERE REVIEW_ID=A.ID) AS BEFORE_CREDIT_NUM,
                   (CASE WHEN A.IS_ADJUST = '1' THEN '是' ELSE '否' END) AS IS_ADJUST,
                   A.ADJUST_TIME,
                   (SELECT SUM(CASE WHEN IS_ADJUST = '1' THEN AFTER_CREDIT_NUM ELSE BEFORE_CREDIT_NUM END) FROM RECORD_CREDIT_DEDUCTION WHERE REVIEW_ID=A.ID) AS AFTER_CREDIT_NUM
              FROM RECORD_REVIEW A
                   INNER JOIN TENDER_PROJECT B ON A.TENDER_PROJECT_CODE = B.TENDER_PROJECT_CODE
                   LEFT JOIN T_USER_DEPARTMENT C ON B.RECORD_DEPID=C.DEPID
                   LEFT JOIN (SELECT TEXT,VALUE FROM SYS_DIC WHERE TYPE=3021) D ON A.REVIEW_TYPE=D.VALUE
             WHERE A.REVIEW_CODE=:CODE";
            var recordDt = FromSql(recordSql).AddInParameter(":CODE", DbType.String, code).ToDataTable().ToDictionary();

            if (recordDt.Count > 0)
            {
                Dictionary<string, object> data = recordDt[0];
                int id = data["ID"].ToString().ToInt();
                string status = data["REVIEW_STATUS"].ToString();
                string reviewTM = Convert.ToDateTime(data["REVIEW_TIME"]).ToString("yyyy-MM-dd HH:mm:ss");

                recordSql = "SELECT ATTACHMENT_ID FROM OPERTION_RECORD WHERE RECORD_ID=:id AND OPERATION_BEHAVIOR=:status AND OPERATION_TIME=:reviewTM";
                DataTable guidDt = FromSql(recordSql).AddInParameter(":id", DbType.String, id)
                    .AddInParameter(":status", DbType.String, status)
                    .AddInParameter(":reviewTM", DbType.DateTime, reviewTM)
                    .ToDataTable();
                string guid = guidDt.Rows.Count > 0 ? guidDt.Rows[0][0].ToString() : "";
                //获取附件
                if (!string.IsNullOrEmpty(guid))
                {
                    data["AttList"] = GetAIDS(guid);
                }
                else
                {
                    data["AttList"] = new List<Dictionary<string, object>>();
                }
                if (data["ADJUST_TIME"] != null && !(data["ADJUST_TIME"] is DBNull))
                {
                    string tzTM = Convert.ToDateTime(data["ADJUST_TIME"]).ToString("yyyy-MM-dd HH:mm:ss");
                    recordSql =
                        "SELECT ATTACHMENT_ID FROM OPERTION_RECORD WHERE RECORD_ID=:id AND OPERATION_BEHAVIOR=9 AND OPERATION_TIME=:tzTM";
                    guidDt = FromSql(recordSql).AddInParameter(":id", DbType.String, id)
                        .AddInParameter(":tzTM", DbType.DateTime, tzTM)
                        .ToDataTable();
                    guid = guidDt.Rows.Count > 0 ? guidDt.Rows[0][0].ToString() : "";
                    if (!string.IsNullOrEmpty(guid))
                    {
                        (data["AttList"] as List<Dictionary<string, object>>)?.AddRange(GetAIDS(guid));
                    }

                }
            }
            string detailSql = @"SELECT ROW_NUMBER() OVER(ORDER BY A.CREATE_TM) AS RN,
                   A.EXIST_PROBLEM,
                   A.EXAMIN_OPINION,
                   B.TEXT AS PROBLEM_ATTRIBUTE_TEXT,
                   A.PROBLEM_ATTRIBUTE,
                   A.BEFORE_CREDIT_NUM,
                   A.BEFORE_IS_DOUBLE,
                   (CASE WHEN A.IS_ADJUST = '1' THEN '是' ELSE '否' END) AS IS_ADJUST,
                   A.AFTER_CREDIT_NUM,
                   A.AFTER_IS_DOUBLE
              FROM RECORD_CREDIT_DEDUCTION A
                   LEFT JOIN (SELECT TEXT,VALUE FROM SYS_DIC WHERE TYPE=3029) B ON A.PROBLEM_ATTRIBUTE=B.VALUE
             WHERE A.REVIEW_CODE=:CODE";
            var detailDt = FromSql(detailSql).AddInParameter(":CODE", DbType.String, code).ToDataTable().ToDictionary();

            string tzSql = @"SELECT ROW_NUMBER() OVER(ORDER BY A.OPERATION_TIME) AS RN,
                   A.OPERATION_TIME AS TM,
                   A.REVIEW_OPINION
              FROM OPERTION_RECORD A
                   INNER JOIN RECORD_REVIEW B ON A.RECORD_ID=B.ID
             WHERE A.OPERATION_BEHAVIOR=9 AND B.REVIEW_CODE=:CODE";
            var tzDt = FromSql(tzSql).AddInParameter(":CODE", DbType.String, code).ToDataTable().ToDictionary();

            var result = new
            {
                titleDt,
                recordDt,
                detailDt,
                tzDt
            };
            r.SetSuccess(result);
            return r;

        }

        /// <summary>
        /// 附件格式转换
        /// </summary>
        private List<Dictionary<string, object>> GetAIDS(string aids)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            if (string.IsNullOrEmpty(aids)) return result;

            string[] guidArray = aids.ToString().Trim().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            string guids = "";
            foreach (string guid in guidArray) guids += "'" + guid.ToClearSql() + "',";
            if (string.IsNullOrEmpty(guids)) return result;
            return FromSql("SELECT GUID, FILETILE||FILETYPE AS NAME FROM SYS_ATTACHMENT WHERE GUID IN (" +
                                   guids.TrimEnd(',') + ") ORDER BY AID").ToDataTable().ToDictionary();
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="datas">扣息信息</param>
        /// <returns></returns>
        public GeneralResult CreateOrSave(List<RECORD_CREDIT_DEDUCTION> datas,int REVIEW_ID)
        {
            var r = new GeneralResult();

            if(null == datas)
            {
                datas = new List<RECORD_CREDIT_DEDUCTION>();
            }

            var condition = new WhereClipBuilder();
            condition.And(RECORD_CREDIT_DEDUCTION._.REVIEW_ID == REVIEW_ID);
            if (datas.Any())
            {
                condition.And(RECORD_CREDIT_DEDUCTION._.ID.NotIn(datas.Select(t => t.ID).ToList()));
            }
            var db = GetDbSession();
            using (var tran = db.BeginTransaction())
            {
                try
                {
                    tran.Delete<RECORD_CREDIT_DEDUCTION>(condition.ToWhereClip());
                    foreach (var data in datas)
                    {
                        
                        if (!data.ID.HasValue || data.ID ==0)
                        {
                            data.ID = 0;
                            data.VERSION = "1";
                            tran.Insert<RECORD_CREDIT_DEDUCTION>(data);
                            continue;
                        }
                        data.IS_ADJUST = "1";
                        data.VERSION = (Convert.ToInt32(data.VERSION) + 1).ToString();
                        tran.Update<RECORD_CREDIT_DEDUCTION>(data);
                    }
                    tran.Commit();
                    r.SetSuccess();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    var requestid = Guid.NewGuid().ToString();
                    LoggerR.Error("logid:" + requestid + ",扣分信息保存失败:" + ex.Message
                        + Logger.GetRequestMessage(HttpContext.Current), ex);
                    r.SetException("扣分信息保存失败:" + ex.Message + "logid:" + requestid, ex);
                    
                }
            }
            return r;
        }

        /// <summary>
        /// 备案审核模块 信用分扣分结果查询
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public GeneralResult AuditSearch(SearchCondition search,decimal? RECORD_DEPID,decimal? CREATOR,string REVIEW_TYPE,string PROBLEM_ATTRIBUTE,
            DateTime? BeginTime,DateTime? EndTime,string TENDER_PROJECT_TYPE)
        {
            var r = new GeneralResult();

            List<OracleParameter> parameters = new List<OracleParameter>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT ROW_NUMBER() OVER(ORDER BY (CASE WHEN A.IS_ADJUST = '1' THEN A.ADJUST_TIME ELSE A.REVIEW_TIME END) DESC) AS RN,");
            sb.AppendLine("                     B.TENDER_PROJECT_NAME,");
            sb.AppendLine("                     D.TEXT AS REVIEW_TYPE,");
            sb.AppendLine("                     E.DNAME, B.RECORD_DEPID,");
            sb.AppendLine("                     F.TEXT AS PROBLEM_ATTRIBUTE,");
            sb.AppendLine("                     (CASE WHEN C.IS_ADJUST = '1' THEN C.AFTER_CREDIT_NUM ELSE C.BEFORE_CREDIT_NUM END) AS SCORE,");
            sb.AppendLine("                     (CASE WHEN C.IS_ADJUST = '1' THEN C.AFTER_IS_DOUBLE ELSE C.BEFORE_IS_DOUBLE END) AS IS_DOUBLE,");
            sb.AppendLine("                     TO_CHAR((CASE WHEN A.IS_ADJUST = '1' THEN A.ADJUST_TIME ELSE A.REVIEW_TIME END),'yyyy.MM.dd hh24:mi') AS TM");
            sb.AppendLine("                FROM RECORD_REVIEW A");
            sb.AppendLine("                     INNER JOIN TENDER_PROJECT B ON A.TENDER_PROJECT_CODE = B.TENDER_PROJECT_CODE");
            sb.AppendLine("                     INNER JOIN RECORD_CREDIT_DEDUCTION C ON A.ID = C.REVIEW_ID");
            sb.AppendLine("                     LEFT JOIN (SELECT TEXT,VALUE FROM SYS_DIC WHERE TYPE=3021) D ON A.REVIEW_TYPE=D.VALUE");
            sb.AppendLine("                     LEFT JOIN T_USER_DEPARTMENT E ON B.RECORD_DEPID=E.DEPID");
            sb.AppendLine("                     LEFT JOIN (SELECT TEXT,VALUE FROM SYS_DIC WHERE TYPE=3029) F ON C.PROBLEM_ATTRIBUTE=F.VALUE");
            sb.AppendLine("                     LEFT JOIN (SELECT TEXT,VALUE FROM SYS_DIC WHERE TYPE=2002) G ON B.TENDER_PROJECT_TYPE=G.VALUE");
            sb.AppendLine("               WHERE  A.REVIEW_STATUS IN ('5','6','9')");
            if(CREATOR.HasValue)
            {
                sb.AppendLine(" AND A.CREATOR=:CREATOR ");
                parameters.Add(new OracleParameter(":CREATOR",CREATOR));
            }
            if(RECORD_DEPID.HasValue)
            {
                sb.AppendLine(" AND B.RECORD_DEPID = :RECORD_DEPID");
                parameters.Add(new OracleParameter(":RECORD_DEPID", RECORD_DEPID));
            }
            if(! String.IsNullOrEmpty(REVIEW_TYPE))
            {
                sb.AppendLine("  AND A.REVIEW_TYPE = :REVIEW_TYPE");
                parameters.Add(new OracleParameter(":REVIEW_TYPE", REVIEW_TYPE));
            }
            if(! String.IsNullOrEmpty(PROBLEM_ATTRIBUTE))
            {
                sb.AppendLine(" AND  C.PROBLEM_ATTRIBUTE = :PROBLEM_ATTRIBUTE");
                parameters.Add(new OracleParameter(":PROBLEM_ATTRIBUTE", PROBLEM_ATTRIBUTE));
            }
            if(BeginTime.HasValue)
            {
                sb.AppendLine(" AND (CASE WHEN A.IS_ADJUST = '1' THEN A.ADJUST_TIME ELSE A.REVIEW_TIME END) >= :BeginTime");
                parameters.Add(new OracleParameter(":BeginTime", BeginTime.Value.Date));
            }
            if (EndTime.HasValue)
            {
                sb.AppendLine(" AND (CASE WHEN A.IS_ADJUST = '1' THEN A.ADJUST_TIME ELSE A.REVIEW_TIME END) <= :EndTime");
                parameters.Add(new OracleParameter(":EndTime", EndTime.Value.Date.AddDays(1).AddMilliseconds(-1)));
            }
            if(! String.IsNullOrEmpty(TENDER_PROJECT_TYPE))
            {
                sb.AppendLine(" AND B.TENDER_PROJECT_TYPE=:TENDER_PROJECT_TYPE ");
                parameters.Add(new OracleParameter(":TENDER_PROJECT_TYPE", TENDER_PROJECT_TYPE));
            }
            int count = 0;
            var datas = FromSqlByPage(sb.ToString(), search.PageNo, search.PageSize, " RN", parameters, out count).ToDataTable();
            r.SetSuccess(new {
                PageNo = search.PageNo,
                PageSize = search.PageSize,
                Total = count,
                PageTotal =Convert.ToInt32(Math.Ceiling(count * 1.0/search.PageSize)),
                Table = datas
            });
            return r;
        }
        /// <summary>
        /// 根据备案人ID获取备案部门信息
        /// </summary>
        /// <param name="CREATOR"></param>
        /// <returns></returns>
        public GeneralResult GetDeptList(decimal CREATOR)
        {
            var sb = new StringBuilder();
            sb.AppendLine("SELECT distinct E.DNAME TEXT, B.RECORD_DEPID VALUE");
            sb.AppendLine("  FROM RECORD_REVIEW A");
            sb.AppendLine(" INNER JOIN TENDER_PROJECT B");
            sb.AppendLine("    ON A.TENDER_PROJECT_CODE = B.TENDER_PROJECT_CODE");
            sb.AppendLine(" INNER JOIN RECORD_CREDIT_DEDUCTION C");
            sb.AppendLine("    ON A.ID = C.REVIEW_ID");
            sb.AppendLine("  LEFT JOIN (SELECT TEXT, VALUE FROM SYS_DIC WHERE TYPE = 3021) D");
            sb.AppendLine("    ON A.REVIEW_TYPE = D.VALUE");
            sb.AppendLine("  LEFT JOIN T_USER_DEPARTMENT E");
            sb.AppendLine("    ON B.RECORD_DEPID = E.DEPID");
            sb.AppendLine(" WHERE A.CREATOR = :CREATOR");
            sb.AppendLine("   AND A.REVIEW_STATUS IN ('5', '6', '9')");
            sb.AppendLine("  AND NVL(E.DNAME,'null') !='null'");

            var query = FromSql(sb.ToString());
            query.AddInParameter(":CREATOR",DbType.Int32, CREATOR);
            var data = query.ToDataTable() ;
            var r = new GeneralResult();
            r.SetSuccess(data);
            return r;
        }
    }
}