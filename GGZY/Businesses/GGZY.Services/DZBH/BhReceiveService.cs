using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;
using GGZY.Core.Helper;
using GGZY.Core.Log;
using GGZY.Services.Base;
using GGZYFW.DbEntity;
using Newtonsoft.Json;

namespace GGZY.Services.DZBH
{
    public class BhReceiveService<T> where T : class
    {
        private string _validation;
        private string _data;
        private string _systemNo;
        private string _dataKey;
        private Dictionary<string, object> _validationTable;
        private Dictionary<string, object> _dataSet;
        private T _instance;
        /// <summary>
        /// 数据接收服务
        /// </summary>
        /// <param name="validation">验证xml</param>
        /// <param name="data">数据xml</param>
        public BhReceiveService(string validation, string data)
        {
            Logger.Debug($"验证信息：{validation},数据信息{data}");
            this._data = data;
            this._validation = validation;
            this._validationTable = JsonConvert.DeserializeObject<Dictionary<string, object>>(validation);
            this._dataSet = JsonConvert.DeserializeObject<Dictionary<string, object>>(data);
        }
        public void Run()
        {
            this.ValidateToken();
            this.ValidateContext();
            this._instance = GetInstance();
        }
        /// <summary>
        /// 返回示例
        /// </summary>
        public T instance
        {
            get { return _instance; }
        }

        public string DataKey
        {
            get { return _dataKey; }
        }
        /// <summary>
        /// 获取实体信息
        /// </summary>
        /// <returns></returns>
        protected T GetInstance()
        {
            Dictionary<string, object> dt =
                JsonConvert.DeserializeObject<Dictionary<string, object>>(_dataSet["DATA"].ToString());
            ThrowHelper.ThrowIfTure(dt == null || dt.Count == 0, "解析失败");
            T instance = System.Activator.CreateInstance<T>();
            foreach (PropertyInfo p in instance.GetType().GetProperties())
            {
                if (dt.ContainsKey(p.Name))
                {
                    if (!p.CanWrite) continue;
                    var value = dt[p.Name];
                    if (value != null && !string.IsNullOrEmpty(value.ToString()))
                    {
                        switch (p.PropertyType.FullName)
                        {
                            case "System.String":
                                p.SetValue(instance, value.ToString(), null);
                                break;
                            case "System.Decimal":
                            case "System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                                p.SetValue(instance, decimal.Parse(value.ToString()), null);
                                break;
                            case "System.Int32":
                            case "System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                                p.SetValue(instance, int.Parse(value.ToString()), null);
                                break;
                            case "System.Double":
                            case "System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                                p.SetValue(instance, double.Parse(value.ToString()), null);
                                break;
                            case "System.DateTime":
                            case "System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                                p.SetValue(instance, DateTime.ParseExact(value.ToString(), "yyyyMMddHHmmss", System.Globalization.CultureInfo.CurrentCulture), null);
                                break;
                            default:
                                p.SetValue(instance, value, null);
                                break;
                        }
                    }
                }
                //赋值M_DATA_KEY
                else if (p.Name.Equals("M_DATA_KEY"))
                {
                    p.SetValue(instance, _dataKey, null);
                }
                //赋值SYSTEM_NO
                else if (p.Name.Equals("SYSTEM_NO"))
                {
                    p.SetValue(instance, _systemNo, null);
                }
                else
                {
                    p.SetValue(instance, null, null);
                }
            }
            return instance;
        }

        /// <summary>
        /// 验证token
        /// </summary>
        /// <returns></returns>
        protected void ValidateToken()
        {
            ThrowHelper.ThrowIfTure(string.IsNullOrEmpty(_data) || string.IsNullOrEmpty(_validation), "data和validation均不能为空");
            string token = _validationTable["TOKEN"].ToString();
            string timeStr = _validationTable["TIME"].ToString();
            _systemNo = _validationTable["SYSTEM_NO"].ToString();
            _dataKey = _dataSet["DATA_KEY"].ToString();
            DateTime time = DateTime.ParseExact(timeStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.CurrentCulture);
            DateTime now = DateTime.Now;
            //判断时间是否过期
            ThrowHelper.ThrowIfTure((now - time).TotalMinutes > 10, "token已过期");

            //验证token
            List<BH_JIEKOU_USER> bjuList = DbContext.Fw.From<BH_JIEKOU_USER>()
                .Where(BH_JIEKOU_USER._.SYSTEM_NO == _systemNo).ToList();
            ThrowHelper.ThrowIfTure(!bjuList.Any(), "SYSTEMNO不存在");
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string validateStr = _systemNo + timeStr + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(_data, "MD5");
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            Logger.Debug(validateStr);
            var thistoken = TokenHelper.CreateToken(validateStr, bjuList.First().SECRET);
            Logger.Debug(thistoken);
            ThrowHelper.ThrowIfTure(token != thistoken, "token验证失败");

            //验证validation和data的systemno是否一致
            string data_systemno = _dataSet["SYSTEM_NO"].ToString();
            ThrowHelper.ThrowIfTure(data_systemno != _systemNo, "验证文件和数据文件的系统编码不一致");
        }
        /// <summary>
        /// 验证数据内容
        /// </summary>
        protected void ValidateContext()
        {
            Dictionary<string, object> dt =
                JsonConvert.DeserializeObject<Dictionary<string, object>>(_dataSet["DATA"].ToString());
            foreach (var p in typeof(T).GetProperties())
            {
                foreach (var o in p.GetCustomAttributes(true))
                {
                    if (o is BaseMatchAttributes attr)
                    {
                        ThrowHelper.ThrowIfTure(attr.Match(dt[p.Name].ToString(), p.Name), attr.errorMsg);
                    }
                }
            }
        }
    }
}
