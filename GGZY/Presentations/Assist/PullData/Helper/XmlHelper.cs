using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using PullData.Model;

namespace PullData.Helper
{
    public static class XmlHelper
    {
        /// <summary>
        /// xml转字典，联合惩戒专用
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static Dictionary<string, string> FromXmlToDict(string xml)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            XmlDocument xd = new XmlDocument();
            xd.LoadXml(xml);
            XmlNode resultNode = xd.SelectSingleNode("Result");
            foreach (XmlNode node in resultNode.ChildNodes)
            {
                string key = node.Name;
                string value = node.InnerText;
                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, value);
                }
            }

            return dict;
        }

        public static T DeSerialize<T>(string xml, Encoding encoding)
        {
            try
            {
                var mySerializer = new XmlSerializer(typeof(T));
                using (var ms = new MemoryStream(encoding.GetBytes(xml)))
                {
                    using (var sr = new StreamReader(ms, encoding))
                    {
                        return (T)mySerializer.Deserialize(sr);
                    }
                }
            }
#pragma warning disable CS0168 // 声明了变量“e”，但从未使用过
            catch (Exception e)
#pragma warning restore CS0168 // 声明了变量“e”，但从未使用过
            {
                return default(T);
            }

        }
        public static string Serialize<T>(T obj, Encoding encoding)
        {
            try
            {

                if (obj == null)
                    throw new ArgumentNullException("obj");

                var ser = new XmlSerializer(obj.GetType());
                using (var ms = new MemoryStream())
                {
                    using (var writer = new XmlTextWriter(ms, encoding))
                    {
                        writer.Formatting = Formatting.Indented;
                        ser.Serialize(writer, obj);
                    }
                    var xml = encoding.GetString(ms.ToArray());
                    xml = xml.Replace("xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"", "");
                    xml = xml.Replace("xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"", "");
                    xml = Regex.Replace(xml, @"\s{2}", "");
                    xml = Regex.Replace(xml, @"\s{1}/>", "/>");
                    return xml;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 返回的xml转实体类
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static PoorCreditResult XmlToResult(string xml)
        {
            PoorCreditResult result = new PoorCreditResult();
            //层层解析
            XmlDocument xd = new XmlDocument();
            xd.LoadXml(xml);
            XmlNode re = xd.SelectSingleNode("Result");
            result.Code = xd.SelectSingleNode("/Result/Code")?.InnerText;
            result.Message = xd.SelectSingleNode("/Result/Message")?.InnerText;
            result.Ticket = xd.SelectSingleNode("/Result/Content/GeneralCheckResult/Ticket")?.InnerText;
            var backlists = xd.SelectSingleNode("/Result/Content/GeneralCheckResult/Blacklists");
            List<Blacklist> blackList = new List<Blacklist>();
            if (backlists != null)
            {
                foreach (XmlNode node in backlists.SelectNodes("Blacklist"))
                {
                    string id = node.SelectSingleNode("ID")?.InnerText;
                    string name = node.SelectSingleNode("Name")?.InnerText;
                    string category = node.SelectSingleNode("Category")?.InnerText;
                    Blacklist bl = new Blacklist()
                    {
                        ID = id,
                        Name = name,
                        Category = category
                    };
                    var policies = node.SelectSingleNode("Policies");
                    List<Policy> policyList = new List<Policy>();
                    if (policies != null)
                    {

                        foreach (XmlNode policy in policies.SelectNodes("Policy"))
                        {
                            string policyname = policy.SelectSingleNode("Name")?.InnerText;
                            Policy policyModel = new Policy()
                            {
                                Name = policyname
                            };
                            List<Category> cateList = new List<Category>();
                            XmlNode bizCategories = policy.SelectSingleNode("BizCategories");
                            if (bizCategories != null)
                            {
                                foreach (XmlNode categoryNode in bizCategories.SelectNodes("Category"))
                                {
                                    string cateName = categoryNode.SelectSingleNode("Name")?.InnerText;
                                    Category cateModel = new Category()
                                    {
                                        Name = cateName
                                    };
                                    XmlNode measures = categoryNode.SelectSingleNode("Measures");
                                    if (measures != null)
                                    {
                                        List<Measure> measureList = new List<Measure>();
                                        foreach (XmlNode measureNode in measures.SelectNodes("Measure"))
                                        {
                                            Measure measure = new Measure()
                                            {
                                                Type = measureNode.SelectSingleNode("Type")?.InnerText,
                                                Description = measureNode.SelectSingleNode("Description")?.InnerText
                                            };
                                            measureList.Add(measure);
                                        }

                                        cateModel.Measures = measureList;
                                    }
                                    cateList.Add(cateModel);
                                }
                            }

                            policyModel.Categorys = cateList;
                            policyList.Add(policyModel);
                        }
                    }

                    bl.Policies = policyList;
                    blackList.Add(bl);
                }

                result.Balcklists = blackList;
            }
            //根据内容生成备忘录内容和限制的行为内容
            StringBuilder NameSb = new StringBuilder();
            StringBuilder memoSb = new StringBuilder();
            StringBuilder ContentSb = new StringBuilder();
            foreach (Blacklist balcklist in blackList)
            {
                NameSb.AppendLine(balcklist.Name + ";");
                foreach (var po in balcklist.Policies)
                {
                    memoSb.AppendLine(po.Name + ";");
                    foreach (var poCategory in po.Categorys)
                    {
                        foreach (var poCategoryMeasure in poCategory.Measures)
                        {
                            ContentSb.AppendLine($"({poCategoryMeasure.Type}){poCategoryMeasure.Description};");
                        }
                    }
                }
            }

            result.Content = ContentSb.ToString();
            result.NameList = NameSb.ToString();
            result.Memo = memoSb.ToString();

            return result;
        }
    }
}
