using System;
using System.Collections.Generic;
using System.Dynamic;
using GGZY.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GGZY.Services.Infrastructure.Model
{
    /// <summary>
    /// 服务平台门户-交易信息-业务类型|信息类型|行业类型
    /// </summary>
    public partial class FwPortalTradeInfoType: SelectModel
    {
        public FwPortalTradeInfoType() : base()
        {

        }
        public FwPortalTradeInfoType(string value, string label):base(value,label)
        {
          
        }
        public List<LabelValueModel> GGTYPE { get; set; }

    }
}

/*
 *
        #region 自定义扩展



        private IDictionary<string, object> dynamicDictionaryData;

        IDictionary<string, object> _DynamicDictionaryData
        {
            get
            {
                if (dynamicDictionaryData == null)
                {
                    dynamicDictionaryData = new Dictionary<string, object>();
                }

                if (dynamicDictionaryData.Count == 0)
                {
                    var props = this.GetType().GetProperties();
                    foreach (var prop in props)
                    {
                        dynamicDictionaryData.Add(prop.Name, prop.GetValue(this, null));
                    }
                }
                return dynamicDictionaryData;
            }
            set { dynamicDictionaryData = value; }
        }
        public override bool TrySetMember(System.Dynamic.SetMemberBinder binder, object value)
        {
            _DynamicDictionaryData[binder.Name] = value;
            return true;
        }
        public override bool TryGetMember(System.Dynamic.GetMemberBinder binder, out object result)
        {
            return _DynamicDictionaryData.TryGetValue(binder.Name, out result);
        }

        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return _DynamicDictionaryData.Keys;
        }
        #endregion

 *
 */
