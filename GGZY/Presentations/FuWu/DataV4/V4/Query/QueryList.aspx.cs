using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GGZY.DataV4Service.Extend;

namespace DataV4.V4.Query
{
    public partial class QueryList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submit_OnServerClick(object sender, EventArgs e)
        {
            string tb = this.tablename.Value.ToClearSql();
            string sys = this.system_no.Value.ToClearSql();
            string type = this.type.Value.ToClearSql();
            GGZY.DataV4Service.Db.DAO dao = type == "1" ? GGZY.DataV4Service.Db.DAO.GGFW : GGZY.DataV4Service.Db.DAO.XZJD;

            string col = type == "1" ? "m_key" : "data_key";

            string sql = $"select * from (select a.*,rownum rn from {tb} a where m_data_source = '{sys}' and M_VERSION = 'V4' order by m_tm desc) where rn <= 100";

            try
            {
                DataSet dt = dao.GetDataSet(sql);
                if (dt != null && dt.Tables[0].Rows.Count > 0)
                {
                    result.InnerHtml = DatatableToHtml(dt.Tables[0]);
                }
                else
                {
                    result.InnerHtml = "查无数据";
                }
            }
#pragma warning disable CS0168 // 声明了变量“exception”，但从未使用过
            catch (Exception exception)
#pragma warning restore CS0168 // 声明了变量“exception”，但从未使用过
            {
                result.InnerHtml = "查无数据";
            }
        }
        public static string DatatableToHtml(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            List<string> cols = new List<string>();
            sb.Append("<table border='1 cellspacing='0' cellpadding='0'><tr>");
            sb.Append("<td>DATA_KEY</td>");

            foreach (DataColumn column in dt.Columns)
            {
                if (!column.ColumnName.Contains("M_") && !(column.ColumnName.Contains("DATA_KEY")))
                {
                    sb.Append("<td>" + column.ColumnName + "</td>");
                    cols.Add(column.ColumnName);
                }
            }
            sb.Append("</tr>");

            foreach (DataRow row in dt.Rows)
            {
                sb.Append("<tr>");
                if (dt.Columns.Contains("M_KEY"))
                {
                    sb.Append("<td>" + row["M_KEY"] + "</td>");
                }
                else
                {
                    sb.Append("<td>" + row["DATA_KEY"] + "</td>");
                }

                foreach (var col in cols)
                {
                    sb.Append("<td>" + row[col] + "</td>");
                }

                sb.Append("</tr>");
            }

            sb.Append("</table>");
            return sb.ToString();
        }
    }
}