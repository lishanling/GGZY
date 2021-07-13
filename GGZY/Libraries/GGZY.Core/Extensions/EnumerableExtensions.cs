using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace GGZY.Core.Extensions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// List 转DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(this IEnumerable<T> collection)
        {
            var dt = new DataTable(typeof(T).Name);
            var props = typeof(T).GetProperties();
            bool noRowNum = props.All(c => c.Name != "RN");
            if (noRowNum)
            {
                dt.Columns.Add(new DataColumn("RN", typeof(int)));
            }
            dt.Columns.AddRange(props.Select(c =>
            {
                Type colType = c.PropertyType;
                if (colType.IsGenericType && colType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    colType = colType.GetGenericArguments()[0];
                }

                return new DataColumn(c.Name, colType);
            }).ToArray());
            var enumerable = collection?.ToList();
            if (enumerable != null&&enumerable.Any())
            {
                for (int i = 0; i < enumerable.Count(); i++)
                {
                    ArrayList tempList = new ArrayList();
                    if (noRowNum)
                    {
                        tempList.Add(i + 1);
                    }
                    foreach (PropertyInfo pi in props)
                    {
                        object obj = pi.GetValue(enumerable.ElementAt(i), null);
                        tempList.Add(obj);
                    }
                    object[] array = tempList.ToArray();
                    dt.LoadDataRow(array, true);
                }
            }
            return dt;
        }
    }
}