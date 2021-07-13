using System;
using System.Collections.Generic;
using System.Data;

namespace GGZY.Core.Helper
{
    public static class DataTableHelper
    {
        public static string GetStringValue(this DataTable table, string key, string defaultValue = "")
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
        public static List<Dictionary<string, object>> ToDictionary(this DataTable table)
        {
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
            foreach (DataRow dr in table.Rows)
            {
                var dic = new Dictionary<string, object>();
                foreach (DataColumn item in table.Columns)
                {
                    if (dr[item.ColumnName] is decimal && dr[item.ColumnName].ToString() == Convert.ToDecimal(dr[item.ColumnName]).ToString())
                    {
                        dic.Add(item.ColumnName, Convert.ToDecimal(dr[item.ColumnName]));
                        continue;
                    }
                    if (dr[item.ColumnName] is DateTime)
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

        /// <summary>
        /// datatable脱敏
        /// </summary>
        /// <param name="dt">源datatable</param>
        /// <param name="cols">需要脱敏的字段列表</param>
        /// <returns></returns>
        public static DataTable DtDesensitization(this DataTable dt, params string[] cols)
        {
            foreach (DataRow row in dt.Rows)
            {
                foreach (var col in cols)
                {
                    if (row.Table.Columns.Contains(col))
                    {
                        row[col] = Desensitization(row[col].ToString());
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// 脱敏处理
        /// </summary>
        /// <param name="result">源字符串</param>
        /// <param name="num">中间打星号的数量</param>
        /// <returns></returns>
        public static string Desensitization(string result, int num = 0)
        {
            if (result.Length == 2)
            {
                result = result.Substring(0, 1) + "*";
            }
            else if (result.Length == 3)
            {
                result = result.Substring(0, 1) + "*" + result.Substring(2, 1);
            }
            else if (result.Length == 18)
            {
                result = result.Substring(0, 3) + "***********" + result.Substring(14, 4);
            }
            else if (result.Length >= 4)
            {
                int length = result.Length;
                if (num + 3 >= length)
                {
                    result = result.Substring(0, 3).PadRight(length - 3, '*');
                }
                else
                {
                    result = result.Substring(0, 3).PadRight(num, '*') + result.Substring(num + 3, length - num - 3);
                }

            }

            return result;
        }
        //        public static bool ContainKey(this DataTable table, string key)
        //        {
        //            return table.Columns.Contains(key);
        //           
        //        }


    }
}