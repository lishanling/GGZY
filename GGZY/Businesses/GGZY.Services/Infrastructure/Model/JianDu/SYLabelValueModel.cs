using System.Collections.Generic;
using GGZY.Core.Extensions;
using Newtonsoft.Json;

namespace GGZY.Core.Models
{
    public class SYLabelValueModel : SYLabelValueModel<string>
    {

    }

    public class SYLabelValueModel<V>
    {
        private string _ID;
        private string _LABEL;

        [JsonProperty("id")]
        public string Id
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_ID))
                {
                    _ID = Value.DesEncrypt();
                }

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
        public V Value1 { get; set; }
        public V Value2 { get; set; }
    }


}