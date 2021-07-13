using System;
using System.Collections.Generic;
using System.Text;

namespace 数据规范中导出语句和配置文件
{
    public static class ProDictList
    {
        public static Dictionary<string, object> NotNull => new Dictionary<string, object>()
        {
            {"ValidatorName", "NotNull"}
        };
        public static Dictionary<string, object> UniqueValue => new Dictionary<string, object>()
        {
            {"ValidatorName", "UniqueValue"}
        };
        public static Dictionary<string, object> DateMatch => new Dictionary<string, object>()
        {
            {"ValidatorName", "DateMatch"},{"Format","yyyyMMddHHmmss"}
        };

        public static Dictionary<string, object> CannotModify => new Dictionary<string, object>()
        {
            {"ValidatorName", "CannotModify"}
        };

        public static Dictionary<string, object> FixLengthMatch(int value)
        {
            return new Dictionary<string, object>()
            {
                {"ValidatorName", "LengthMatch"},{"FixedLength",value}
            };
        }
        public static Dictionary<string, object> MaxLengthMatch(int value)
        {
            return new Dictionary<string, object>()
            {
                {"ValidatorName", "LengthMatch"},{"MaxLength",value}
            };
        }
        public static Dictionary<string, object> NumberMatch(int value1, int value2)
        {
            return new Dictionary<string, object>()
            {
                {"ValidatorName", "NumberMatch"},{"IntegerFigures",value1},{"DecimalFigures",value2}
            };
        }
        public static Dictionary<string, object> IntNumberMatch(int value1)
        {
            return new Dictionary<string, object>()
            {
                {"ValidatorName", "NumberMatch"},{"IntegerFigures",value1}
            };
        }
        public static Dictionary<string, object> AreaCodeMatch(int value)
        {
            return new Dictionary<string, object>()
            {
                {"ValidatorName", "AreaCodeMatch"},{"Begin",value}
            };
        }

        public static Dictionary<string, object> EnumMatch(string value)
        {
            return new Dictionary<string, object>()
            {
                {"ValidatorName", "EnumMatch"},{"EnumType",value}
            };
        }
        public static Dictionary<string, object> DomainMatch(string value)
        {
            return new Dictionary<string, object>()
            {
                {"ValidatorName", "DomainMatch"},{"Type",value}
            };
        }
        public static Dictionary<string, object> TenderProjectCodeMatch()
        {
            return new Dictionary<string, object>()
            {
                {"ValidatorName", "TenderProjectCodeMatch"},{"TenderProjectTableName","TENDER_PROJECT"}
            };
        }

        public static void Merge<TKey, TValue>(this IDictionary<TKey, TValue> first, IDictionary<TKey, TValue> second)
        {
            if (second == null || first == null) return;
            foreach (var item in second)
                if (!first.ContainsKey(item.Key))
                    first.Add(item.Key, item.Value);
        }

    }
}
