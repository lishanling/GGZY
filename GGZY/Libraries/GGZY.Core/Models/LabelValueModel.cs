using System.Collections.Generic;
using GGZY.Core.Extensions;
using Newtonsoft.Json;

namespace GGZY.Core.Models
{
    public class LabelValueModel:LabelValueModel<string>
    {
        
    }

    public class LabelValueModel<V>
    {
        private string _ID;
        private string _LABEL;
        private string _NAME;

        [JsonProperty("id")]
        public string Id
        {
            get
            {
                //if (string.IsNullOrWhiteSpace(_ID))
                //{
                //    _ID = Value.DesEncrypt();
                //}

                return _ID;
            }
            set => _ID = value;
        }
        [JsonProperty("label")]
        public string Label
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_LABEL))
                {
                    _LABEL = Value?.ToString();
                }

                return _LABEL;
            }
            set => _LABEL = value;
        }
        [JsonProperty("value")]
        public V Value { get; set; }

        [JsonProperty("name")]
        public string Name
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_NAME))
                {
                    _NAME = _LABEL;
                }
                return _NAME;
            }
            set => _NAME = value;
        }
    }


}