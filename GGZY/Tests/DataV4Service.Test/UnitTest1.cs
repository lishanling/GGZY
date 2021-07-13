using System;
using System.Data;
using System.IO;
using GGZY.DataV4Service;
using GGZY.DataV4Service.Db;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataV4Service.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*string key = "CBzxJp6a";        //密钥
            string platcode = "7201";        //交易平台编码*/
            /*string key = "UxI83Gjb";        //密钥
            string platcode = "7100";        //交易平台编码*/
            string key = "W5pn.9B.";        //密钥
            string platcode = "0001";        //交易平台编码
            /*string key = "YI3m9d..";        //密钥
            string platcode = "0502";        //交易平台编码*/
            /*string key = "MP93.u#r";        //密钥
            string platcode = "0104";        //交易平台编码*/
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string text = platcode + DateTime.Now.ToString("yyyyMMddHHmmss") + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(platcode, "MD5");
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string Token = DESEncrypt.Encode(text, key);


            
            StreamReader sr = new StreamReader("d:\\testtext\\招标公告.txt");
            string data = sr.ReadToEnd();
            sr.Close();

            string validData = "<?xml version='1.0' encoding='utf-8'?><DATA><TOKEN>" + Token + "</TOKEN><SYSTEM_NO>" + platcode + "</SYSTEM_NO></DATA>";

            //            DataService ds = new DataService();
            //            string result = ds.UploadData_G(validData, data);


            var result = DataManager.UploadData(validData, data, "V4");
            Console.WriteLine(result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string sql = "select * from user_tab_columns where Table_Name = 'SECTION' order by column_name";
            DataSet dt = DAO.GGFW.GetDataSet(sql);
        }
    }
}
