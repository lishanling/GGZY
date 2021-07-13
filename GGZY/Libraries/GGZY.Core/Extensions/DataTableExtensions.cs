using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace GGZY.Core.Extensions
{
    public static class DataTableExtensions
    {
        public static List<T> ToList<T>(this DataTable dt) //where T : class
        {
            if (dt == null) return null;
            Type t = typeof(T);
            PropertyInfo[] propertyInfo = t.GetProperties();
            List<T> list = new List<T>();
            foreach (DataRow item in dt.Rows)
            {
                T obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo s in propertyInfo)
                {
                    var typeName = s.Name;
                    if (s.CanWrite&&dt.Columns.Contains(typeName)&& item[typeName] !=DBNull.Value)
                    {
                        object value = item[typeName];
                        if (s.PropertyType == typeof(string))
                        {
                            s.SetValue(obj, value.ToString(), null);
                        }
                        else
                        {
                            s.SetValue(obj, value, null);
                        }
                    }
                }
                list.Add(obj);
            }
            return list;
        }
    }
}