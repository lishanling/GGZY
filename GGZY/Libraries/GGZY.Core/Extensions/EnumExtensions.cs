using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web.UI;

namespace GGZY.Core.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// 动态获取枚举值的名称
        /// </summary>
        /// <param name="sources">枚举数组</param>
        /// <returns></returns>
        public static List<string> GetName(this List<Enum> sources)
        {
            if(null == sources || !sources.Any())
            {
                return new List<string>();
            }
            List<string> names = new List<string>();
            foreach(var source in sources)
            {
                Type sourceType = source.GetType();
                string sourceName = Enum.GetName(sourceType, source);
                names.Add(sourceName);
            }
            return names;
        }

        /// <summary>
        /// 动态获取枚举值的名称
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string GetName(this Enum source)
        {
            Type sourceType = source.GetType();
            string sourceName = Enum.GetName(sourceType, source);
            return sourceName;
        }
        private static T GetCustomAttribute<T>(Enum source) where T : System.Attribute
        {
            Type sourceType = source.GetType();
            string sourceName = Enum.GetName(sourceType, source);
            FieldInfo field = sourceType.GetField(sourceName);
            object[] attributes = field.GetCustomAttributes(typeof(T), false);
            return attributes.OfType<T>().FirstOrDefault();
        }

        /// <summary>
        /// 获取枚举值的属性说明
        /// </summary>
        /// <param name="source"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static string Description(this Enum source,string propertyName="Name")
        {
            try
            {
                var attribute = GetCustomAttribute<DisplayAttribute>(source);
                string property;
                switch (propertyName)
                {
                    case "Description":
                        property = attribute.Description;
                        break;
                    case "GroupName":
                        property = attribute.GroupName;
                        break;
                    case "ShortName":
                        property = attribute.ShortName;
                        break;
                    case "Order":
                        property = attribute.Order.ToString();
                        break;
                    case "Prompt":
                        property = attribute.Prompt;
                        break;
                    default:
                        property = attribute.Name;
                        break;

                }
                return property;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return source.ToString();
            }
        }

        public static string ShortName(this Enum source, string propertyName = "ShortName")
        {
            return source.Description(propertyName);
        }
        public static string GroupName(this Enum source, string propertyName = "GroupName")
        {
            return source.Description(propertyName);
        }
        /// <summary>
        /// 有 Description 则返回Description,否则返回Name
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string DisplayEnumDescription(this Enum source)
        {
            Type enumType = source.GetType();
            DescriptionAttribute[] EnumAttributes = (DescriptionAttribute[])(enumType.GetField(Enum.GetName(enumType, source))).GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (EnumAttributes.Length > 0)
            {
                return EnumAttributes[0].Description;
            }
            return source.GetName();
        }
    }
}