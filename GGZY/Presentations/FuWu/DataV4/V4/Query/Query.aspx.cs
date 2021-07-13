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
    public partial class Query : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_OnServerClick(object sender, EventArgs e)
        {
            string tb = this.tablename.Value.ToClearSql();
            string data_key = this.datakey.Value.ToClearSql();
            string type = this.type.Value.ToClearSql();
            GGZY.DataV4Service.Db.DAO dao = type == "1" ? GGZY.DataV4Service.Db.DAO.GGFW : GGZY.DataV4Service.Db.DAO.XZJD;

            string col = type == "1" ? "m_key" : "data_key";

            string sql = $"select * from {tb} where {col} = '{data_key}'";

            try
            {
                DataSet dt = dao.GetDataSet(sql);
                if (dt != null && dt.Tables[0].Rows.Count > 0)
                {
                    result.InnerHtml = CreateTable(dt, dao);
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

        private string CreateTable(DataSet dt, GGZY.DataV4Service.Db.DAO dao)
        {
            Dictionary<string, string> files = new Dictionary<string, string>();
            StringBuilder sb = new StringBuilder();
            sb.Append("<table border='1' cellspacing='0' cellpadding='0'><tr><td>列名</td><td>数据</td></tr>");
            DataRow dr = dt.Tables[0].Rows[0];
            foreach (DataColumn col in dt.Tables[0].Columns)
            {
                if (col.ColumnName.Contains("M_"))
                {
                    if (col.ColumnName == "M_KEY")
                    {
                        sb.Append("<tr><td>DATA_KEY</td><td>" + dr[col.ColumnName] + "</td></tr>");
                    }
                    if (col.ColumnName == "M_DATA_SOURCE")
                    {
                        sb.Append("<tr><td>SYSTEM_NO</td><td>" + dr[col.ColumnName] + "</td></tr>");
                    }

                    if (col.ColumnName.Contains("M_ATT"))
                    {
                        if (!string.IsNullOrEmpty(dr[col.ColumnName].ToString()))
                        {
                            if (!files.ContainsKey(col.ColumnName))
                            {
                                files.Add(col.ColumnName.Substring(6, col.ColumnName.Length - 6), dr[col.ColumnName].ToString());
                            }
                        }
                    }
                }
                else
                {
                    sb.Append("<tr><td>" + col.ColumnName + "</td><td>" + dr[col.ColumnName] + "</td></tr>");
                }
            }
            sb.Append("<tr><td colspan='2'>附件</td></tr>");
            //生成附件
            foreach (var file in files)
            {
                string sql = $"select * from t_attachment where id in ({file.Value})";
                DataSet dt1 = dao.GetDataSet(sql);
                if (dt1 != null && dt1.Tables[0].Rows.Count >= 1)
                {
                    string filepath = "";
                    foreach (DataRow dataRow in dt1.Tables[0].Rows)
                    {
                        string href = "http://" + this.Request.Url.Host + ":" + Request.Url.Port + "/file" + dataRow["ATTACHMENT_FILE_NAME"];
                        filepath +=
                            $"<a href='{href}' target='_blank'>{dataRow["ATTACHMENT_NAME"]}.{dataRow["ATTACHMENT_TYPE"]}</a>";
                    }
                    sb.Append("<tr><td>" + file.Key + "</td><td>" + filepath + "</td></tr>");
                }
            }

            sb.Append("</table>");
            return sb.ToString();

        }
    }
}