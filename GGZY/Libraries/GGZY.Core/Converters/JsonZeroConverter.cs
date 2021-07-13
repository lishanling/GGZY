using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Core.Converters
{
    /// <summary>
    /// 整数值序列化去除.0处理
    /// </summary>
    public class JsonZeroConverter: JsonConverter
    {
 
        private void dumpNumArray<T>(JsonWriter writer, T[] array)
        {
            foreach (T n in array)
            {
                var s = n.ToString();
                //此處可考慮改用string.format("{0:#0.####}")[小數後方#數目依最大小數位數決定]
                //感謝網友vencin提供建議
                if (s.EndsWith(".0"))
                    writer.WriteRawValue(s.Substring(0, s.Length - 2));
                else if (s.Contains("."))
                    writer.WriteRawValue(s.TrimEnd('0').TrimEnd('.'));
                else
                    writer.WriteRawValue(s);
            }
        }
        private void dumpDecimal<T>(JsonWriter writer, T decimalValue)
        {
            var s = decimalValue.ToString();
            //此處可考慮改用string.format("{0:#0.####}")[小數後方#數目依最大小數位數決定]
            //感謝網友vencin提供建議
            if (s.EndsWith(".0"))
                writer.WriteRawValue(s.Substring(0, s.Length - 2));
            else if (s.Contains("."))
                writer.WriteRawValue(s.TrimEnd('0').TrimEnd('.'));
            else
                writer.WriteRawValue(s);
        }
        public override void WriteJson(JsonWriter writer, object value,
            JsonSerializer serializer)
        {

            Type t = value.GetType();
            if (t == decimalType)
                dumpDecimal<decimal>(writer, (decimal)value);
            else if (t == decimalWithNullType)
                dumpDecimal<decimal?>(writer, (decimal?)value);
            else if (t == dblArrayType)
            {
                writer.WriteStartArray();
                dumpNumArray<double>(writer, (double[])value);
                writer.WriteEndArray();
            }
            else if (t == decArrayType)
            {
                writer.WriteStartArray();
                dumpNumArray<decimal>(writer, (decimal[])value);
                writer.WriteEndArray();
            }
            else
                throw new NotImplementedException();
           
        }

        private Type dblArrayType = typeof(double[]);
        private Type decArrayType = typeof(decimal[]);
        private Type decimalType = typeof(decimal);
        private Type decimalWithNullType = typeof(decimal?);

        public override bool CanConvert(Type objectType)
        {
            if (objectType == dblArrayType || objectType == decArrayType || objectType == decimalWithNullType || objectType == decimalType)
                return true;
            return false;
        }

        public override bool CanRead
        {
            get { return false; }
        }

        public override object ReadJson(JsonReader reader, Type objectType,
            object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

    }
}