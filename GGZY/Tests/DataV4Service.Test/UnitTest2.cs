using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using GGZY.DataV4Service.Db;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataV4Service.Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            string sql = "select table_name from user_tab_columns where column_name = 'M_KEY'";
            DataSet dt = DAO.XZJD.GetDataSet(sql);
            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                string tablename = row[0].ToString();
                if (tablename.StartsWith("ZJ_") || tablename.StartsWith("SL_") || tablename.StartsWith("JT_") ||
                    tablename.StartsWith("YG_") || tablename.StartsWith("XX_") || tablename.StartsWith("GY_"))
                {
                    sb.AppendLine($"alter table {tablename} rename column M_KEY TO DATA_KEY;");
                }
            }
            Console.WriteLine(sb.ToString());

        }
        [TestMethod]
        public void TestMethod2()
        {
            string sql = "select table_name from user_tab_columns where column_name = 'IS_DELETE'";
            string sql1 = "select table_name from user_tables";
            DataSet dt = DAO.XZJD.GetDataSet(sql);
            List<string> notTable = new List<string>();
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                string tableName = row[0].ToString();
                if (!notTable.Contains(tableName))
                {
                    notTable.Add(tableName);
                }
            }
            DataSet dt1 = DAO.XZJD.GetDataSet(sql1);
            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in dt1.Tables[0].Rows)
            {
                string tablename = row[0].ToString();
                if (!notTable.Contains(tablename))
                {
                    sb.AppendLine($"ALTER TABLE {tablename} ADD IS_DELETE NUMBER(1) DEFAULT 0;");
                    sb.AppendLine($"comment on column {tablename}.IS_DELETE is '是否删除';");
                }
            }
            StreamWriter sr = new StreamWriter("D:\\行政监督平台新增逻辑删除字段.txt");
            sr.Write(sb.ToString());
            sr.Flush();
            sr.Close();
            Console.WriteLine(sb.ToString());
        }

        [TestMethod]
        public void TestMethod3()
        {
            StreamReader sr = new StreamReader("D:\\WORK\\代码1\\福建省电子监管系统二期\\GGZY\\Presentations\\FuWu\\DataV4\\SQL\\行政监督平台新增逻辑删除字段.txt");
            string data = sr.ReadToEnd().Replace("\r\n", "");
            sr.Close();
            List<string> list = data.Split(';').ToList();
            StringBuilder sb = new StringBuilder();
            foreach (string s in list)
            {
                if (!string.IsNullOrWhiteSpace(s) && s.Contains("ALTER TABLE"))
                {
                    string ss = s.TrimStart(' ');
                    string tablename = ss.Split(' ')[2];
                    sb.AppendLine($"ALTER TABLE {tablename} DROP COLUMN IS_DELETE;");
                }
            }
            StreamWriter sw = new StreamWriter("D:\\行政监督平台删除逻辑删除字段.txt");
            sw.Write(sb.ToString());
            sw.Flush();
            sw.Close();
            Console.WriteLine(sb.ToString());
        }
    }
}
