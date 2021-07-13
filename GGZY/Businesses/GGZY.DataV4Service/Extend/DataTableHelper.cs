using System;
using System.Collections.Generic;
using System.Data;

namespace GGZY.DataV4Service.Extend
{
    public static class DataTableHelper
    {
        public static string GetStringValue(this DataTable table, string key,string defaultValue = "")
        {
            if (table.Rows.Count == 1)
            {
                if (table.Columns.Contains(key))
                {
                    var value = table.Rows[0][key];
                    if (value != null)
                    {
                        return value.ToString().Trim();
                    }
                }
                
            }
            return defaultValue;
        }

        public static int GetIntValue(this DataTable table, string key, int defaultValue = 0)
        {
            var str = table.GetStringValue(key);
            int value;
            if (int.TryParse(str, out value))
            {
                return value;
            }
            return defaultValue;
        }

        public static double GetDoubleValue(this DataTable table, string key, double defaultValue = 0)
        {
            var str = table.GetStringValue(key);
            double value;
            if (double.TryParse(str, out value))
            {
                return value;
            }
            return defaultValue;
        }
        public static List<Dictionary<string,object>> ToDictionary(this DataTable table)
        {
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
            foreach (DataRow dr in table.Rows)
            {
                var dic = new Dictionary<string, object>();
                foreach (DataColumn item in table.Columns)
                {
                    if(dr[item.ColumnName] is decimal && dr[item.ColumnName].ToString() == Convert.ToInt32(dr[item.ColumnName]).ToString())
                    {
                        dic.Add(item.ColumnName, Convert.ToInt32(dr[item.ColumnName]));
                        continue;
                    }
                    if(dr[item.ColumnName] is DateTime)
                    {
                        dic.Add(item.ColumnName, Convert.ToDateTime(dr[item.ColumnName]).ToString("yyyy-MM-dd HH:mm:ss"));
                        continue;
                    }
                    dic.Add(item.ColumnName, dr[item.ColumnName]);
                }
                list.Add(dic);
            }
            return list;
        }
//        public static bool ContainKey(this DataTable table, string key)
//        {
//            return table.Columns.Contains(key);
//           
//        }


    }
}