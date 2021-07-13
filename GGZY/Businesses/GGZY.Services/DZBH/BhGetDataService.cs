using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.Core.Helper;
using GGZY.Core.Log;
using GGZY.Services.Base;
using GGZY.Services.DZBH;
using GGZYFW.DbEntity;
using Newtonsoft.Json;

namespace GGZY.Services.DZBH
{
    public class BhGetDataService
    {
        private string _validation;
        private string _data;
        private string _systemNo;
        private string _dataKey;
        private string _logType;
        private Dictionary<string, object> _validationTable;
        private Dictionary<string, object> _dataSet;
        private Dictionary<string, object> _dataRes;

        public Dictionary<string, object> data => _dataRes;

        public BhGetDataService(string validation, string data, string logType)
        {
            this._data = data;
            this._validation = validation;
            this._logType = logType;
            this._validationTable = JsonConvert.DeserializeObject<Dictionary<string, object>>(validation);
            this._dataSet = JsonConvert.DeserializeObject<Dictionary<string, object>>(data);
            _dataRes = JsonConvert.DeserializeObject<Dictionary<string, object>>(_dataSet["DATA"].ToString());
        }
        public void Run()
        {
            Logger.Info($"验证信息：{_validation},数据信息{_data}");
            this.AddLog();
            this.ValidateToken();
        }
        /// <summary>
        /// 验证token
        /// </summary>
        /// <returns></returns>
        protected void ValidateToken()
        {
            string token = _validationTable["TOKEN"].ToString();
            string timeStr = _validationTable["TIME"].ToString();
            DateTime time = DateTime.ParseExact(timeStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.CurrentCulture);
            DateTime now = DateTime.Now;
            //判断时间是否过期
            ThrowHelper.ThrowIfTure((now - time).TotalMinutes > 5, "token已过期");
            //验证token
            List<BH_JIEKOU_USER> bjuList = DbContext.Fw.From<BH_JIEKOU_USER>()
                .Where(BH_JIEKOU_USER._.SYSTEM_NO == _systemNo).ToList();
            ThrowHelper.ThrowIfTure(!bjuList.Any(), "SYSTEMNO不存在");
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string md5 = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(_data, "MD5");
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string validateStr = _systemNo + timeStr + md5;
            string tokenVaidate = TokenHelper.CreateToken(validateStr, bjuList.First().SECRET);
            Logger.Debug($"MD5(data):{md5},验证内容：{validateStr},密钥：{bjuList.First().SECRET}，生成的token:{tokenVaidate}");
            ThrowHelper.ThrowIfTure(token != tokenVaidate, "token验证失败");
            //验证validation和data的systemno是否一致
            string data_systemno = _dataSet["SYSTEM_NO"].ToString();
            ThrowHelper.ThrowIfTure(data_systemno != _systemNo, "验证文件和数据文件的系统编码不一致");
        }
        /// <summary>
        /// 记录请求日志
        /// </summary>
        protected void AddLog()
        {
            _systemNo = _validationTable["SYSTEM_NO"].ToString();
            _dataKey = _dataSet["DATA_KEY"].ToString();
            BH_JIEKOU_LOG bl = new BH_JIEKOU_LOG()
            {
                GUID = Guid.NewGuid().ToString(),
                CREATE_TIME = DateTime.Now,
                DATA_KEY = _dataKey,
                SYSTEM_NO = _systemNo,
                LOGTYPE = _logType
            };
            DbContext.Fw.Insert(bl);

        }
    }
}
