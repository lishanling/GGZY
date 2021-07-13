using System;
using System.Collections.Generic;
using System.Dynamic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GGZY.Services.Infrastructure.Model
{
    public partial class SelectModel//: DynamicObject
    {
        public SelectModel(string value,string label)
        {
            Value = value;
            Label = label;
            Children = new List<SelectModel>();
        }
        public SelectModel():this(String.Empty,String.Empty)
        {
           
        }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("label")]

        public string Label { get; set; }
        [JsonProperty("children")]
        public List<SelectModel> Children { get; set; }

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
