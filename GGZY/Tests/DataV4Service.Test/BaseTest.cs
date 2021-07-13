using System;
using System.Collections.Generic;
using System.IO;
using GGZY.DataV4Service;
using GGZY.DataV4Service.Extend;
using Newtonsoft.Json;

namespace DataV4Service.Test
{
    public class BaseTest
    {
        public BaseTest()
        {
            //            System.Configuration.ConfigurationManager.AppSettings["DBConfig"] =
            //                "Config/SqlMap_ORACLE.config";
            //            System.Configuration.ConfigurationManager.AppSettings["DBATYPE"] = "ORACLE";

        }
        protected string Version = "V3";
        private string GetValidData()
        {
            string key = "518BrH3y";        //密钥
            string platcode = "9120";        //交易平台编码
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string text = platcode + DateTime.Now.ToString("yyyyMMddHHmmss") + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(platcode, "MD5");
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string Token = DESEncrypt.Encode(text, key);
            string validData = "<?xml version='1.0' encoding='utf-8'?><DATA><TOKEN>" + Token + "</TOKEN><SYSTEM_NO>" + platcode + "</SYSTEM_NO></DATA>";
            return validData;
        }

        protected string GetData(string dataName, string fileName)
        {
            var filePath = $"{AppDomain.CurrentDomain.BaseDirectory}\\UploadData\\{dataName}\\{fileName}.txt";
            var data = File.ReadAllText(filePath);
            return data;

        }

        protected Tuple<string, string> GetUploadResult(string data)
        {
            var validData = GetValidData();
            var result = DataManager.UploadData(validData, data, Version);
            var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
            return new Tuple<string, string>(dict.GetStringValue("STATUS"),
                dict.GetStringValue("MSG"));
        }

        protected string SetTitleValue(string data, string key, string value)
        {
            return SetNodeValue(data, "TITLE", key, value);
        }

        protected string SetContentValue(string data, string key, string value)
        {
            return SetNodeValue(data, "CONTEXT", key, value);
        }

        private string SetNodeValue(string data, string table, string key, string value)
        {
            var dts = XmlHelper.ToDataSetByString(data);
            var dt = dts.Tables[table];
            dt.Rows[0][key] = value;
            var newData = XmlHelper.DataSetToXML(dts);
            return newData;
        }




    }
}