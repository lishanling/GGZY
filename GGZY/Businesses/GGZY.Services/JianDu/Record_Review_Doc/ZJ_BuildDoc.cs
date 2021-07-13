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
    public abstract class ZJ_BuildDoc:BaseServiceT<RECORD_ATTACHMENT>
    {
        public string TempDocName;
        protected int RecordId;
        protected string ReviewType;
        protected DataTable BasicDt;
        protected DataTable AttDt;
        protected DataTable PlobDt;
        public ZJ_BuildDoc(int RECORD_ID, string REVIEW_TYPE, string VERSION)
        {
            RecordId = RECORD_ID;
            ReviewType = REVIEW_TYPE;
            BasicDt = GetBasicData(RecordId);
            AttDt = GetAtt(RecordId);
            PlobDt = GetProblem(RecordId, VERSION);
        }
        public abstract Hashtable ReplaceWord(string guid = "");

        #region 获取数据
        /// <summary>
        /// 备案主表ID获取基础信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public DataTable GetBasicData(int ID)
        {
            decimal? DEPID = JdUser?.DEPARTID;

            StringBuilder sbSql = new StringBuilder();
            sbSql.AppendLine("SELECT A.COMMIT_TIME,");
            sbSql.AppendLine("       A.SIGN_TIME,");
            sbSql.AppendLine("       A.IS_SIGN,");
            sbSql.AppendLine("       A.REVIEW_STATUS,");
            sbSql.AppendLine("       SIGN_COMMENT,");
            sbSql.AppendLine("       A.REVIEW_TIME,");
            sbSql.AppendLine("       A.REVIEW_CODE,");
            sbSql.AppendLine("       A.ADJUST_TIME,");
            sbSql.AppendLine("       NVL(A.AMENDMENT_OPINION,A.REVIEW_COMMENT) AS REVIEW_COMMENT,");
            sbSql.AppendLine("       A.AMENDMENT_OPINION,");
            sbSql.AppendLine("       B.TENDER_PROJECT_CODE_OLD1 AS TENDER_PROJECT_CODE,");
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
            sbSql.AppendLine("    ON C.DEPID = "+DEPID);
            sbSql.AppendLine("  LEFT JOIN PROJECT E");
            sbSql.AppendLine("    ON E.PROJECT_CODE = B.PROJECT_CODE");
            sbSql.AppendLine(" WHERE A.ID = "+ ID);


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
            DataTable dtAtt = FromSql("SELECT IS_INTACT,ATTFILE_TYPECODE FROM RECORD_ATTACHMENT WHERE RECORD_ID=" + ID).ToDataTable();
            return dtAtt;
        }

        /// <summary>
        /// 备案主表ID获取信用分扣分情况
        /// 信用分扣分部分目前只有住建含有（20180203）
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public DataTable GetProblem(int ID, string VERSION)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.AppendLine("SELECT EXIST_PROBLEM,");
            sbSql.AppendLine("       EXAMIN_OPINION,");
            sbSql.AppendLine("       b.text as PROBLEM_ATTRIBUTE,");
            sbSql.AppendLine("       CASE A.BEFORE_IS_DOUBLE");
            sbSql.AppendLine("         WHEN '0' THEN");
            sbSql.AppendLine("          A.BEFORE_CREDIT_NUM");
            sbSql.AppendLine("         WHEN '1' THEN");
            sbSql.AppendLine("          TO_CHAR(A.BEFORE_CREDIT_NUM) || '(加倍)'");
            sbSql.AppendLine("       END BEFORE_CREDIT_NUM,");
            sbSql.AppendLine("       CASE A.AFTER_IS_DOUBLE");
            sbSql.AppendLine("         WHEN '0' THEN");
            sbSql.AppendLine("          A.AFTER_CREDIT_NUM");
            sbSql.AppendLine("         WHEN '1' THEN");
            sbSql.AppendLine("          TO_CHAR(A.AFTER_CREDIT_NUM) || '(加倍)'");
            sbSql.AppendLine("       END AFTER_CREDIT_NUM,");
            sbSql.AppendLine("       A.IS_ADJUST");
            sbSql.AppendLine("  FROM RECORD_CREDIT_DEDUCTION a");
            sbSql.AppendLine(" INNER JOIN SYS_DIC b");
            sbSql.AppendLine("    ON a.PROBLEM_ATTRIBUTE = b.VALUE");
            sbSql.AppendLine("   AND TYPE = '3029'");
            sbSql.AppendLine(" INNER JOIN RECORD_REVIEW C");
            sbSql.AppendLine("    ON A.REVIEW_ID = C.ID");
            sbSql.AppendLine(" WHERE A.REVIEW_ID = "+ID);
            // 版本号未真正起到作用
            //sbSql.AppendLine("   AND A.VERSION = "+VERSION);

            DataTable dtProblem = FromSql(sbSql.ToString()).ToDataTable();
            return dtProblem;
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

        #region 获取信用分扣分情况并替换
        protected void FullTemplateDate(AsposeWord word)
        {
            #region 获取标题所在的行
            Aspose.Words.Tables.Cell titleCell = word.GetFirstCellByText("{ID}");//获取标题所在单元格
            //if (titleCell == null) return;
            int titleRowSapn = word.GetRowSpan(titleCell);//获取单元格跨行数
            int titleRowIndex = word.GetRowIndex(titleCell.ParentRow);//标题行是在父excel的哪行
            word.ReplaceText(titleCell.ParentRow.Range, @"\{ID\}", "");
            #endregion

            int rowSapn = titleRowSapn;//获取单元格跨行数
            int rowIndex = titleRowIndex + 1;//替换数据的模板行{xxx}所属行数
            Aspose.Words.Tables.Table cellTable = titleCell.ParentRow.ParentTable;

            //复制行到新表格中（复制模板）
            Aspose.Words.Tables.Table tb = word.CopyRowToTable(cellTable, rowIndex, rowSapn);
            word.RemoveRows(cellTable, rowIndex, rowSapn);//移除复制完后的模板、移除{}配置行

            //没有数据 移除表格标题
            if (PlobDt.Rows.Count == 0)
            {
                Aspose.Words.Tables.Cell headCell = cellTable.Rows[titleRowIndex].Cells[0];
                Aspose.Words.Node text = headCell.FirstParagraph.Runs[0].Clone(true);
                word.RemoveRows(cellTable, rowIndex, titleRowSapn);//移除最后一行
                word.RemoveRows(cellTable, titleRowIndex, titleRowSapn);//移除表格标题
                word.ReplaceText(@"\{REVIEW_COMMENT\}", BasicDt.Rows[0]["REVIEW_COMMENT"].ToString());
            }
            else
            {
                word.RemoveRows(cellTable, titleRowIndex - 1, titleRowSapn);//移除审查通过的那行
            }

            for (int i = 0; i < PlobDt.Rows.Count; i++)
            {
                DataRow row = PlobDt.Rows[i];
                Aspose.Words.Tables.Table tb_row = (Aspose.Words.Tables.Table)tb.Clone(true);
                foreach (DataColumn col in PlobDt.Columns)
                {
                    switch (col.ColumnName)
                    {
                        case "AFTER_CREDIT_NUM":
                            if (row["AFTER_CREDIT_NUM"].ToString() != null)
                            {
                                word.ReplaceText(tb_row.Range, @"\{CREDIT_NUM\}", row["AFTER_CREDIT_NUM"].ToString());
                            }
                            break;
                        case "BEFORE_CREDIT_NUM":
                            if (row["BEFORE_CREDIT_NUM"].ToString() != "" && row["AFTER_CREDIT_NUM"].ToString() == "")
                            {
                                word.ReplaceText(tb_row.Range, @"\{CREDIT_NUM\}", row["BEFORE_CREDIT_NUM"].ToString());
                            }
                            break;
                        default:
                            word.ReplaceText(tb_row.Range, @"\{" + col.ColumnName.ToUpper() + @"\}", row[col.ColumnName].ToString());
                            break;
                    }
                }
                word.ReplaceText(@"\{REVIEW_COMMENT\}", "");
                word.ReplaceText(tb_row.Range, @"\{INDEX\}", (i + 1).ToString());
                foreach (Aspose.Words.Tables.Row tmpRow in tb_row.Rows)//填充替换之后的行到原来表格
                {
                    cellTable.InsertAfter(tmpRow.Clone(true), cellTable.Rows[rowIndex - 2]);
                    rowIndex++;
                }
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
            string Url =  "/BaAtt/" + DateTime.Now.ToString("yyyyMM") + "/" + guid + ".pdf";
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
            string SaveName = TempDocName + "_[" + DateTime.Now.ToString("yyyyMM") + "]" + BasicDt.Rows[0]["TENDER_PROJECT_TYPE"].ToString() + BasicDt.Rows[0]["RECORD_DEPID"].ToString() + RandKey;
            return SaveName;
        }
        #endregion
    }
}
