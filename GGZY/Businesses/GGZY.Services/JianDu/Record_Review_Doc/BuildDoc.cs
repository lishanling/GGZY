using GGZY.Core.Helper;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Helper;
using GGZYJD.DbEntity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.JianDu.Record_Review_Doc
{
    public abstract class BuildDoc:BaseServiceT<RECORD_ATTACHMENT>
    {
        public string TempDocName;
        private int RecordId;
        protected string ReviewType;
        protected DataTable BasicDt;
        protected DataTable AttDt;
        protected DataTable PlobDt;
        public BuildDoc(int RECORD_ID, string REVIEW_TYPE)
        {
            RecordId = RECORD_ID;
            ReviewType = REVIEW_TYPE;
            BasicDt = GetBasicData(RecordId);
            AttDt = GetAtt(RecordId);
        }
        public abstract Hashtable ReplaceWord(string guid = "");

        #region 获取数据
        /// <summary>
        /// 获取备案基础信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public DataTable GetBasicData(int ID)
        {
            decimal? DEPID = JdUser?.DEPARTID;

            StringBuilder sbSql = new StringBuilder();
            sbSql.AppendLine("SELECT A.COMMIT_TIME,A.SIGN_TIME,A.IS_SIGN,A.REVIEW_STATUS,SIGN_COMMENT,sysdate as REVIEW_TIME,A.REVIEW_CODE,");
            sbSql.AppendLine("       A.ADJUST_TIME,A.REVIEW_COMMENT,A.AMENDMENT_OPINION,");
            sbSql.AppendLine("       case");
            sbSql.AppendLine("         when nvl(B.TENDER_PROJECT_CODE_OLD1, '0') = '0' then");
            sbSql.AppendLine("          '来自交易平台'");
            sbSql.AppendLine("         else");
            sbSql.AppendLine("          B.TENDER_PROJECT_CODE_OLD1");
            sbSql.AppendLine("       end as TENDER_PROJECT_CODE,");
            sbSql.AppendLine("       B.TENDER_PROJECT_NAME,");
            sbSql.AppendLine("       B.TENDERER_NAME,");
            sbSql.AppendLine("       B.TENDER_AGENCY_NAME,");
            sbSql.AppendLine("       B.RECORD_DEPID,");
            sbSql.AppendLine("       B.TENDER_PROJECT_TYPE,");
            sbSql.AppendLine("       C.DNAME,");
            sbSql.AppendLine("       B.TENDER_DOCNAME,");
            sbSql.AppendLine("       E.CONSTRUCTION_ID");
            sbSql.AppendLine("  FROM RECORD_REVIEW A");
            sbSql.AppendLine("  LEFT JOIN TENDER_PROJECT B");
            sbSql.AppendLine("    ON A.TENDER_PROJECT_CODE = B.TENDER_PROJECT_CODE");
            sbSql.AppendLine("  LEFT JOIN T_USER_DEPARTMENT C");
            sbSql.AppendLine("    ON C.DEPID =" + DEPID);
            sbSql.AppendLine("  LEFT JOIN PROJECT E");
            sbSql.AppendLine("    ON E.PROJECT_CODE = B.PROJECT_CODE");
            sbSql.AppendLine(" WHERE A.ID =" + ID);

            DataTable dt = FromSql(sbSql.ToString()).ToDataTable();
            if (dt.Rows.Count > 0)
            {
                dt.Columns.Add("OPERNAME");
                dt.Rows[0]["OPERNAME"] = JdUser?.MANAGE_NAME;
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (dt.Columns[i].DataType.ToString() == "System.String")
                    {
                        dt.Rows[0][i] = System.Web.HttpUtility.HtmlDecode((dt.Rows[0][i].ToString()));
                    }
                }
                return dt;
            }
            return null;
        }

        /// <summary>
        /// 备案主表ID获取附件信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public DataTable GetAtt(int ID)
        {
            DataTable dtAtt = FromSql("SELECT IS_INTACT,ATTFILE_TYPECODE FROM RECORD_ATTACHMENT WHERE RECORD_ID="+ID).ToDataTable() ;
            return dtAtt;
        }
        #endregion

        #region 基础数据替换
        protected void RepBasic(AsposeWord word)
        {
            foreach (DataColumn col in BasicDt.Columns)
            {
                DataRow data = BasicDt.Rows[0];
                string key = col.ColumnName;
                string valueStr = "";
                if (!data.IsNull(col))
                {
                    if (col.DataType == typeof(DateTime))
                        valueStr = Convert.ToDateTime(data[key]).ToString("yyyy年MM月dd日");
                    else
                        valueStr = data[key].ToString().Trim();
                }
                word.ReplaceText(@"\{" + key + @"\}", valueStr);
            }
        }
        #endregion

        #region 其他方法
        /// <summary>
        /// 获取生成pdf的地址
        /// </summary>
        /// <returns></returns>
        protected string GetUrl(string guid = "")
        {
            if (string.IsNullOrWhiteSpace(guid))
            {
                guid = Guid.NewGuid().ToString("N");
            }
            string Url = "/BaAtt/" + DateTime.Now.ToString("yyyyMM") + "/" + guid + ".pdf";
            return Url;
        }


        /// <summary>
        /// 获取生成pdf的文档名称
        /// </summary>
        /// <returns></returns>
        protected string GetDocName()
        {
            Random ran = new Random();
            int RandKey = ran.Next(0001, 9999);
            string SaveName = TempDocName + "_[" + DateTime.Now.ToString("yyyyMM") + "]" + BasicDt.Rows[0]["TENDER_PROJECT_TYPE"].ToString().Substring(0, 3) + BasicDt.Rows[0]["RECORD_DEPID"].ToString() + RandKey.ToString();
            return SaveName;
        }
        #endregion
    }
}
