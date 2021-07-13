using System;
using System.Globalization;
using GGZY.Core.Extensions;
using Newtonsoft.Json;

namespace GGZY.Core.Infrastructure
{
    /// <summary>
    /// Decimal 序列化去掉.0
    /// </summary>
    public class DecimalConverter:JsonConverter
    {
        /// <summary>
        /// 格式化类型 如 #.## 0.##
        /// </summary>
        public string DecimalFormat { get; set; }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null)
            {
                var stringValue = value.ToString();
                var valueType = value.GetType();
                if (valueType == typeof(decimal?)|| valueType == typeof(decimal))
                {
                    if (!string.IsNullOrWhiteSpace(DecimalFormat))
                    {
                        var d = Convert.ToDecimal(stringValue);
                        writer.WriteRawValue(d.ToString(DecimalFormat));
                    }
                    else
                    {
                        writer.WriteRawValue(stringValue.EndsWith(".0")
                            ? stringValue.Substring(0, stringValue.Length - 2)
                            : stringValue);
                    }
                }
                else
                {
                    // writer.WriteRawValue(valueType.Serializer());
                    throw new NotImplementedException();
                }
            }
            else
            {
                throw new NotImplementedException();
            }
            //
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (objectType == typeof(decimal) || objectType == typeof(decimal?))
            {
                return existingValue?.ToString().ToNullableDecimal();
            }
           
            //base.ReadJson(reader, objectType, existingValue, serializer);
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(decimal) || objectType == typeof(decimal?))
            {
                return true;
            }
            return false;
            //throw new NotImplementedException();
        }
    }
}