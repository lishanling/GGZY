using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Helper;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZYFW.DbEntity;
using Newtonsoft.Json;

namespace GGZY.Services.DZBH
{
    public class OfdApiService : BaseServiceT<BH_OFD_SEND_LOG>
    {
        private string _postUrl = AppSettingUtils.GetString("ofdServerUrl");
        private string _sysid = AppSettingUtils.GetString("ofdServerSysId");
        private string _unit = AppSettingUtils.GetString("ofdServerUnit");
        public bool Validate(string url)
        {
            var data = new
            {
                OFDFileUrl = url
            };

            string json = GetSendJson("BIZ.OFDVALID", data, out BH_OFD_SEND_LOG log);
            string result = new WebUtils() { ContentType = "application/json" }.DoPost(_postUrl, json);
                log.RECEIVE_JSON = result;
            Update(log);
            Dictionary<string, object> resultDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(result);
            if (resultDict.GetStringValue("RESULTCODE") == "0000") 
            {
                var resultDataDict = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(resultDict.GetStringValue("DATA"));
                if (resultDataDict[0]["certValid"].ToString().ToLower() == "true" &&
                    resultDataDict[0]["verifySign"].ToString().ToLower() == "true")
                {
                    return true;
                }
            }

            return false;
        }

        public List<Dictionary<string, object>> GetFiles(string url)
        {
            var resultDataDict = new List<Dictionary<string, object>>();
            var data = new
            {
                OFDFileUrl = url
            };

            string json = GetSendJson("BIZ.ANALYOFDATTACH", data, out BH_OFD_SEND_LOG log);
            string result = new WebUtils() { ContentType = "application/json" }.DoPost(_postUrl, json);
            log.RECEIVE_JSON = result;
            Update(log);
            Dictionary<string, object> resultDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(result);
            if (resultDict.GetStringValue("RESULTCODE") == "0000")
            {
                resultDataDict = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(resultDict.GetStringValue("DATA"));
            }

            return resultDataDict;
        }

        public string GetHtml(string url)
        {
            var data = new
            {
                OFDFileUrl = url
            };

            string json = GetSendJson("BIZ.OFDONLINEREAD", data, out BH_OFD_SEND_LOG log);
            string result = new WebUtils() { ContentType = "application/json" }.DoPost(_postUrl, json);
            log.RECEIVE_JSON = result;
            Update(log);
            Dictionary<string, object> resultDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(result);
            if (resultDict.GetStringValue("RESULTCODE") == "0000")
            {
                Dictionary<string, object> resultDict1 =
                    JsonConvert.DeserializeObject<Dictionary<string, object>>(resultDict.GetStringValue("DATA"));
                return resultDict1.GetStringValue("fileViewUrl");
            }

            return "";
        }


        private string GetSendJson(string bizcode, object data, out BH_OFD_SEND_LOG model)
        {
            model = new BH_OFD_SEND_LOG();
            DateTime now = DateTime.Now;
            //生成流水号
            int serial = Max<BH_OFD_SEND_LOG>(BH_OFD_SEND_LOG._.ID, BH_OFD_SEND_LOG._.SEND_DATE == now.Date);
            serial++;
            string transid = $"BH{now.ToString("yyyyMMdd")}{serial.ToString().PadLeft(10, '0')}";
            var sendObj = new
            {
                BIZCODE = bizcode,
                TRANSID = transid,
                TIMESTAMP = now.ToString("yyyyMMddHHmmssfff"),
                SYSID = _sysid,
                UNIT = _unit,
                DATA = data
            };
            model.CREATE_TIME = now;
            model.SEND_DATE = now.Date;
            model.SERIAL = serial;
            model.TRANSID = transid;
            model.SEND_JSON = sendObj.Serializer();
            model.ID = 0;
            model.ID = Insert(model);
            return sendObj.Serializer();
        }
    }
}
