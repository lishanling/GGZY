using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace GGZY.Core.Utils
{
    public class XmlUtils
    {
        /// <summary>
        /// XML序列化
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string Serialize(object data)
        {
            using (XmlUtf8Writer sw = new XmlUtf8Writer())
            {
                XmlSerializer xz = new XmlSerializer(data.GetType());
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add(String.Empty, String.Empty);
                xz.Serialize(sw, data, ns);
                var s = sw.ToString();
                return s;
            }
        }

        public static void Serialize(object data,string path)
        {
            using (FileStream ms = new FileStream(path, FileMode.Create))
            {
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true,
                    IndentChars = "    ",
                    NewLineChars = "\r\n",
                    Encoding = Encoding.UTF8,
                    //OmitXmlDeclaration = true, // 不生成声明头
                };
                using (XmlWriter xmlWriter = XmlWriter.Create(ms, settings))
                {
                    XmlSerializer xz = new XmlSerializer(data.GetType());
                    // 强制指定命名空间，覆盖默认的命名空间
                    XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    xz.Serialize(xmlWriter, data, namespaces);
                    xmlWriter.Close();
                };
            }
        }

        /// <summary>
        /// XML序列化
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
#pragma warning disable CS1573 // 参数“type”在“XmlUtils.SerializeObject(object, Type)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        public static string SerializeObject(object data, Type type)
#pragma warning restore CS1573 // 参数“type”在“XmlUtils.SerializeObject(object, Type)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        {
            using (XmlUtf8Writer sw = new XmlUtf8Writer())
            {
                XmlSerializer xz = new XmlSerializer(type);
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add(String.Empty, String.Empty);
                xz.Serialize(sw, data, ns);
                var s = sw.ToString();
                return s;
            }
        }
        /// <summary>
        /// XML反序列化
        /// </summary>
        /// <typeparam name="T">反序列化对象类型</typeparam>
        /// <param name="xmlPath">XML文件路径</param>
        /// <returns></returns>
        public static T Deserialize<T>(string xmlPath) where T : class
        {
            try
            {

                using (FileStream fs = new FileStream(xmlPath, FileMode.Open))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(T));
                    var obj = xs.Deserialize(fs);
                    var r = obj as T;
                    return r;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private static Regex regex = new Regex("<(\\w+?)[ >]", RegexOptions.Compiled);
        //private static Dictionary<string, XmlSerializer> parsers = new Dictionary<string, XmlSerializer>();
        /// <summary>
        /// XML反序列化 字符串
        /// </summary>
        /// <typeparam name="T">反序列化对象类型</typeparam>
        /// <param name="xmlPath">XML文件路径</param>
        /// <returns></returns>
        public static T DeserializeStr<T>(string xmlPath) where T : class
        {
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(xmlPath)))
            {
                string rootTagName = GetRootElement(xmlPath);
                XmlAttributes rootAttrs = new XmlAttributes { XmlRoot = new XmlRootAttribute(rootTagName) };
                XmlAttributeOverrides attrOvrs = new XmlAttributeOverrides();
                attrOvrs.Add(typeof(T), rootAttrs);

                XmlSerializer serializer = new XmlSerializer(typeof(T), attrOvrs); //new XmlSerializer(typeof(T));
                var obj = serializer.Deserialize(ms) as T;
                return obj;
            }
            //using (FileStream fs = new FileStream(xmlPath, FileMode.Open))
            //{
            //    XmlSerializer xs = new XmlSerializer(typeof(T));
            //    var obj = xs.Deserialize(fs) as T;
            //    return obj;
            //}
        }

        /// <summary>
        /// 获取XML响应的根节点名称
        /// </summary>
        private static string GetRootElement(string body)
        {
            Match match = regex.Match(body);
            if (match.Success)
            {
                return match.Groups[1].ToString();
            }
            else
            {
                return string.Empty;
                //throw new JdException("Invalid XML response format!");
            }
        }
    }

    public class XmlUtf8Writer : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}