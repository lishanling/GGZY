using System.Collections.Generic;

namespace GGZY.Core.Helper
{
    public static class DictionaryHelper
    {
        public static TV GetValue<TK, TV>(this Dictionary<TK, TV> dict, TK key)
        {
            if (dict.ContainsKey(key))
            {
                return dict[key];
            }
            return default(TV);
        }

        public static string GetStringValue<TK, TV>(this Dictionary<TK, TV> dict, TK key, string defaultValue = "")
        {
            if (dict.ContainsKey(key))
            {
                return dict[key].ToString();
            }
            return defaultValue;
        }
    }
}