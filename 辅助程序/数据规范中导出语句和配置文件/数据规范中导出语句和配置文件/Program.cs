using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Aspose.Cells;
using Aspose.Words;
using Aspose.Words.Tables;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Cmp;
using Cell = Aspose.Cells.Cell;
using Row = Aspose.Cells.Row;

namespace 数据规范中导出语句和配置文件
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("测试一下");
            Console.ReadLine();*/
            /*List<Tuple<string, string, string>> docList = new List<Tuple<string, string, string>>()
            {
               new Tuple<string, string, string>( @"C:\Users\86155\Desktop\4.0\code\数据规范4.0-通用.xlsx","数据规范4.0-通用SQL语句.txt",""),
               new Tuple<string, string, string>( @"C:\Users\86155\Desktop\4.0\code\数据规范4.0-其他三个行业.xlsx","数据规范4.0-工业SQL语句.txt",""),
               new Tuple<string, string, string>( @"C:\Users\86155\Desktop\4.0\code\数据规范4.0-其他三个行业.xlsx","数据规范4.0-渔港SQL语句.txt","95"),
               new Tuple<string, string, string>( @"C:\Users\86155\Desktop\4.0\code\数据规范4.0-其他三个行业.xlsx","数据规范4.0-信息SQL语句.txt","96"),
               new Tuple<string, string, string>( @"C:\Users\86155\Desktop\4.0\code\数据规范4.0-住建新增.xlsx","数据规范4.0-住建SQL语句.txt",""),
               new Tuple<string, string, string>( @"C:\Users\86155\Desktop\4.0\code\数据规范4.0-水利新增.xlsx","数据规范4.0-水利SQL语句.txt",""),
               new Tuple<string, string, string>( @"C:\Users\86155\Desktop\4.0\code\数据规范4.0-交通新增.xlsx","数据规范4.0-交通SQL语句.txt","")
            };*/
            /*foreach (var tuple in docList)
            {
                GetSql(tuple);
            }*/
            /*List<Tuple<string, string, string>> docList = new List<Tuple<string, string, string>>()
            {
                new Tuple<string, string, string>( @"C:\Users\86155\Desktop\4.0\code\数据规范4.0-通用.xlsx","通用",""),
                new Tuple<string, string, string>( @"C:\Users\86155\Desktop\4.0\code\数据规范4.0-其他三个行业.xlsx","工业",""),
                new Tuple<string, string, string>( @"C:\Users\86155\Desktop\4.0\code\数据规范4.0-其他三个行业.xlsx","渔港","95"),
                new Tuple<string, string, string>( @"C:\Users\86155\Desktop\4.0\code\数据规范4.0-其他三个行业.xlsx","信息","96"),
                new Tuple<string, string, string>( @"C:\Users\86155\Desktop\4.0\code\数据规范4.0-住建新增.xlsx","住建",""),
                new Tuple<string, string, string>( @"C:\Users\86155\Desktop\4.0\code\数据规范4.0-水利新增.xlsx","水利",""),
                new Tuple<string, string, string>( @"C:\Users\86155\Desktop\4.0\code\数据规范4.0-交通新增.xlsx","交通","")
            };
            foreach (var tuple in docList)
            {
                GetConfig(tuple);
            }*/
            //GetConfigByCommon();
            GetBiaoHouSql();
        }
        public static void GetBiaoHouSql()
        {
            string docUrl = @"C:\Users\86155\Desktop\4.0\code\数据规范4.0-标后数据.xlsx";
            string saveUrl = "数据规范4.0-标后数据SQL语句.txt";
            Workbook doc = new Workbook(docUrl);
            List<Tuple<string, string, string>> configDict = new List<Tuple<string, string, string>>()
            {
                new Tuple<string, string, string>("10001","BHXX_CONTRACT_MEMBER","合同项目组成员"),
                new Tuple<string, string, string>("10002","BHXX_PERFORMANCE_CONDITION","履约情况"),
                new Tuple<string, string, string>("10003","BHXX_PERFORMANCE_MEMBER","实际履约项目组成员"),
                new Tuple<string, string, string>("10004","BHXX_CONSTRUCT_PERMITS","施工许可信息"),
                new Tuple<string, string, string>("10005","BHXX_CONSTRUCT_ALTER","施工许可变更信息"),
                new Tuple<string, string, string>("10006","BHXX_SCENE_MANAGER_INFO","施工现场管理人员信息表"),
                new Tuple<string, string, string>("10007","BHXX_SCENE_SUPERVISOR_INFO","施工现场工程监理人员信息表"),
                new Tuple<string, string, string>("10008","BHXX_COMPLETE_ACCEPT","竣工验收信息"),
                new Tuple<string, string, string>("10009","BHXX_COMPLETE_ACCEPT_REVIEW","竣工验收备案信息"),

            };
            StringBuilder resultSb = new StringBuilder();
            //遍历表格中的sheet
            foreach (Worksheet docWorksheet in doc.Worksheets)
            {
                var cells = docWorksheet.Cells;
                string no = docWorksheet.Name;
                string cnName = configDict.First(e => e.Item1 == no).Item3;
                string enName = configDict.First(e => e.Item1 == no).Item2;
                //只创建通用新增的表
                if (saveUrl == "数据规范4.0-通用SQL语句.txt" && !no.StartsWith("9"))
                {
                    continue;
                }
                StringBuilder sqlSb = new StringBuilder();
                StringBuilder commentSb = new StringBuilder();
                sqlSb.AppendLine("--创建表");
                sqlSb.AppendLine($@"CREATE TABLE {enName}
(
M_ID NUMBER PRIMARY KEY,
m_key                          VARCHAR2(50),
m_data_source                  VARCHAR2(50),
m_tm                           DATE,
M_VERSION VARCHAR2(3),");
                commentSb.AppendLine("--创建注释");
                commentSb.AppendLine($"comment on table {enName} is '{cnName}'; ");
                for (int i = 0; i < cells.Rows.Count; i++)
                {
                    if (cells.Rows[i][0].Value == null)
                    {
                        continue;
                    }
                    //获取各个列的值
                    List<string> colsValue = new List<string>();
                    for (int j = 0; j < 11; j++)
                    {
                        if (cells.Rows[i][j].Value != null && !string.IsNullOrEmpty(cells.Rows[i][j].Value.ToString()))
                        {
                            colsValue.Add(cells.Rows[i][j].Value.ToString());
                        }
                    }

                    if (colsValue.Count < 5)
                    {
                        continue;
                    }
                    string colCnName = colsValue[0];
                    string colEnName = colsValue[1];
                    string type = colsValue[3];
                    string dataType = "";
                    string length = "";
                    type = type.ToLower();
                    if (type.Contains("ul"))
                    {
                        dataType = "CLOB";
                    }
                    else if (type.Contains("yyyymmddhhmmss"))
                    {
                        dataType = "DATE";
                    }
                    else if (type.Contains("c..") || type.Contains("c."))
                    {
                        length = type.Substring(type.LastIndexOf(".") + 1, type.Length - type.LastIndexOf(".") - 1);
                        dataType = "VARCHAR2(" + length + ")";
                    }
                    else if (type.Contains("c"))
                    {
                        length = type.Substring(type.LastIndexOf("c") + 1, type.Length - type.LastIndexOf("c") - 1);
                        dataType = "VARCHAR2(" + length + ")";
                    }
                    else if (type.Contains("n..") || type.Contains("n."))
                    {
                        length = type.Substring(type.LastIndexOf(".") + 1, type.Length - type.LastIndexOf(".") - 1);
                        dataType = "NUMBER";
                    }
                    else if (type.Contains("n"))
                    {
                        length = type.Substring(type.LastIndexOf("n") + 1, type.Length - type.LastIndexOf("n") - 1);
                        dataType = "NUMBER";
                    }
                    else
                    {
                        dataType = "（未找到数据类型)";
                    }

                    sqlSb.AppendLine($"{colEnName}   {dataType},");
                    commentSb.AppendLine($"comment on column {enName}.{colEnName} is '{colCnName}'; ");
                }

                sqlSb = sqlSb.Remove(sqlSb.Length - 3, 3);//去掉最后的逗号
                sqlSb.AppendLine("\n);");

                string seq_name = "";
                if (enName.Length <= 30)
                {
                    seq_name = "seq_" + enName;
                }
                else
                {
                    seq_name = "seq_" + enName + "（超过30个字符）";
                }
                string seqSql = $@" --创建序列
create sequence {seq_name}
minvalue 1
maxvalue 999999999
start with 1
increment by 1
nocache
order;";
                resultSb.Append(sqlSb);
                resultSb.Append(commentSb);
                resultSb.AppendLine(seqSql);
                resultSb.AppendLine();//空两行
                resultSb.AppendLine();
            }
            //写入文件
            StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + saveUrl);
            sw.Write(resultSb);
            sw.Flush(); 
            sw.Close();
        }

        public static void GetDict()
        {
            Workbook doc = new Workbook(@"C:\Users\86155\Desktop\4.0\接口规范4.0.xlsx");

            List<Tuple<string, string, string>> result = new List<Tuple<string, string, string>>();
            foreach (var sheet in doc.Worksheets)
            {
                var cells = sheet.Cells;
                for (int i = 1; i < cells.Rows.Count; i++)
                {
                    result.Add(new Tuple<string, string, string>(cells.Rows[i][0].Value.ToString(), cells.Rows[i][1].Value.ToString(), cells.Rows[i][2].Value.ToString()));
                }
            }

            string json = JsonConvert.SerializeObject(result);
            //写入文件
            StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "dict.json");
            sw.Write(json);
            sw.Flush();
            sw.Close();
        }

        public static void GetConfigByCommon()
        {
            DirectoryInfo folder = new DirectoryInfo(@"C:\Users\86155\Desktop\数据上报配置文件\通用");
            List<DataConfig> list = new List<DataConfig>();
            foreach (FileInfo file in folder.GetFiles())
            {
                StreamReader sr = new StreamReader(file.Open(FileMode.Open));
                string configData = sr.ReadToEnd();
                DataConfig dc = JsonConvert.DeserializeObject<DataConfig>(configData);
                list.Add(dc);
            }
            //输出到住建
            list = list.OrderBy(e => e.DataNo).ToList();
            int i = 9399;
            Dictionary<string, string> map = new Dictionary<string, string>()
            {
                {"500","9400" },
                {"501","9401" },
                {"502","9402" },
                {"503","9403" },
                {"504","9404" },
                {"505","9407" },
                {"506","9424" },
                {"507","9414" },
                {"508","9426" },
                {"509","9431" },
                {"510","9430" },
                {"511","9432" },
                {"512","9438" },
                {"513","9433" },
                {"514","9410" },
                {"515","9411" },
                {"516","9412" },
                {"517","9435" },
                {"519","9418" },
                {"522","9439" },
                {"523","9420" },
                {"9001","9405" },
                {"9002","9406" },
                {"9004","9408" },
                {"9005","9409" },
                {"9006","9413" },
                {"9007","9415" },
                {"9008","9416" },
                {"9009","9417" },
                {"9010","9419" },
                {"9011","9421" },
                {"9012","9422" },
                {"9013","9423" },
                {"9014","9425" },
                {"9015","9427" },
                {"9016","9428" },
                {"9017","9429" },
                {"9018","9434" },
                {"9019","9436" },
                {"9020","9437" },
            };
            foreach (var dataConfig in list)
            {
                if (dataConfig.DataNo == "9003" || dataConfig.DataNo == "520" || dataConfig.DataNo == "521")
                {
                    continue;
                }
                i++;
                dataConfig.IsZXSJ = true;
                dataConfig.GgfwDataNo = dataConfig.DataNo;
                dataConfig.DataNo = map[dataConfig.DataNo].Replace("94","96");
                dataConfig.DataName = "GY_" + dataConfig.DataName;
                StreamWriter sw = new StreamWriter($@"C:\Users\86155\Desktop\数据上报配置文件\信息\{dataConfig.DataNo}.json");
                JsonSerializerSettings setting = new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    Formatting = Formatting.Indented,
                };
                string str = JsonConvert.SerializeObject(dataConfig, setting);
                sw.Write(str);
                sw.Flush();
                sw.Close();
            }

        }

        public static void GetConfig(Tuple<string, string, string> docInfo)
        {
            string docUrl = docInfo.Item1;
            string saveUrl = docInfo.Item2;
            string replaceCode = docInfo.Item3;
            Workbook doc = new Workbook(docUrl);
            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "dict.json");
            string configStr = sr.ReadToEnd();
            sr.Close();
            List<Tuple<string, string, string>> configDict =
                JsonConvert.DeserializeObject<List<Tuple<string, string, string>>>(configStr);
            //遍历表格中的sheet
            List<DataConfig> result = new List<DataConfig>();
            foreach (Worksheet docWorksheet in doc.Worksheets)
            {
                var cells = docWorksheet.Cells;
                string no = docWorksheet.Name;
                if (!string.IsNullOrEmpty(replaceCode))
                    no = no.Replace("94", replaceCode);//替换为其他行业
                if (!no.StartsWith("9"))
                {
                    continue;
                }
                string cnName = configDict.First(e => e.Item1 == no).Item3;
                string enName = configDict.First(e => e.Item1 == no).Item2;
                DataConfig dc = new DataConfig()
                {
                    DataCnName = cnName,
                    DataName = enName,
                    DataNo = no
                };
                List<Field> fields = new List<Field>();
                for (int i = 0; i < cells.Rows.Count; i++)
                {
                    if (cells.Rows[i][0].Value == null)
                    {
                        continue;
                    }
                    //获取各个列的值
                    List<string> colsValue = new List<string>();
                    for (int j = 0; j < 11; j++)
                    {
                        colsValue.Add(cells.Rows[i][j].Value?.ToString() ?? "");
                    }

                    if (colsValue.Count < 6)
                    {
                        continue;
                    }
                    string colCnName = colsValue[0];
                    string colEnName = colsValue[1];
                    string type = colsValue[3];
                    string isMust = colsValue[5];
                    type = type.ToLower();
                    string dataType = "";
                    string length = "";
                    type = type.ToLower();

                    Field field = new Field()
                    {
                        CnName = colCnName,
                        Name = colEnName
                    };
                    List<Dictionary<string, object>> validates = new List<Dictionary<string, object>>();
                    if (isMust == "是")
                    {
                        validates.Add(ProDictList.NotNull);
                    }
                    if (type.Contains("ul"))
                    {
                    }
                    else if (type.Contains("yyyymmddhhmmss"))
                    {
                        validates.Add(ProDictList.DateMatch);
                    }
                    else if (type.Contains("c..") || type.Contains("c."))
                    {
                        length = type.Substring(type.LastIndexOf(".") + 1, type.Length - type.LastIndexOf(".") - 1);
                        int.TryParse(length, out int len);
                        validates.Add(ProDictList.MaxLengthMatch(len));
                    }
                    else if (type.Contains("c"))
                    {
                        length = type.Substring(type.LastIndexOf("c") + 1, type.Length - type.LastIndexOf("c") - 1);
                        int.TryParse(length, out int len);
                        validates.Add(ProDictList.FixLengthMatch(len));
                    }
                    else if (type.Contains("n..") || type.Contains("n."))
                    {
                        length = type.Substring(type.LastIndexOf(".") + 1, type.Length - type.LastIndexOf(".") - 1);
                        int.TryParse(length, out int len);
                        validates.Add(ProDictList.NumberMatch(len, 6));
                    }
                    else if (type.Contains("n"))
                    {
                        length = type.Substring(type.LastIndexOf("n") + 1, type.Length - type.LastIndexOf("n") - 1);
                        int.TryParse(length, out int len);
                        validates.Add(ProDictList.IntNumberMatch(len));
                    }
                    else
                    {
                        dataType = "（未找到数据类型)";
                    }

                    if (colEnName.ToUpper() == "TENDER_PROJECT_CODE")
                    {
                        validates.Add(ProDictList.TenderProjectCodeMatch());
                    }

                    if (colsValue[4].Contains("区划代码"))
                    {
                        validates.Add(ProDictList.AreaCodeMatch(0));
                    }

                    field.Validators = validates;
                    fields.Add(field);
                }

                dc.Fields = fields;
                result.Add(dc);
            }
            //输出文件
            foreach (var config in result)
            {
                StreamWriter sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}config\\{saveUrl}\\{config.DataNo}.json");
                JsonSerializerSettings setting = new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    Formatting = Formatting.Indented,
                };
                string str = JsonConvert.SerializeObject(config, setting);
                sw.Write(str);
                sw.Flush();
                sw.Close();
            }
        }

        public static void GetSql(Tuple<string, string, string> docInfo)
        {
            string docUrl = docInfo.Item1;
            string saveUrl = docInfo.Item2;
            string replaceCode = docInfo.Item3;
            Workbook doc = new Workbook(docUrl);
            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "dict.json");
            string configStr = sr.ReadToEnd();
            sr.Close();
            List<Tuple<string, string, string>> configDict =
                JsonConvert.DeserializeObject<List<Tuple<string, string, string>>>(configStr);
            StringBuilder resultSb = new StringBuilder();
            //遍历表格中的sheet
            foreach (Worksheet docWorksheet in doc.Worksheets)
            {
                var cells = docWorksheet.Cells;
                string no = docWorksheet.Name;
                if (!string.IsNullOrEmpty(replaceCode))
                    no = no.Replace("94", replaceCode);//替换为其他行业
                string cnName = configDict.First(e => e.Item1 == no).Item3;
                string enName = configDict.First(e => e.Item1 == no).Item2;
                //只创建通用新增的表
                if (saveUrl == "数据规范4.0-通用SQL语句.txt" && !no.StartsWith("9"))
                {
                    continue;
                }
                StringBuilder sqlSb = new StringBuilder();
                StringBuilder commentSb = new StringBuilder();
                sqlSb.AppendLine("--创建表");
                sqlSb.AppendLine($@"CREATE TABLE {enName}
(
M_ID NUMBER PRIMARY KEY,
m_key                          VARCHAR2(50),
m_data_source                  VARCHAR2(50),
m_tm                           DATE,
M_VERSION VARCHAR2(3),");
                commentSb.AppendLine("--创建注释");
                commentSb.AppendLine($"comment on table {enName} is '{cnName}'; ");
                for (int i = 0; i < cells.Rows.Count; i++)
                {
                    if (cells.Rows[i][0].Value == null)
                    {
                        continue;
                    }
                    //获取各个列的值
                    List<string> colsValue = new List<string>();
                    for (int j = 0; j < 11; j++)
                    {
                        if (cells.Rows[i][j].Value != null && !string.IsNullOrEmpty(cells.Rows[i][j].Value.ToString()))
                        {
                            colsValue.Add(cells.Rows[i][j].Value.ToString());
                        }
                    }

                    if (colsValue.Count < 5)
                    {
                        continue;
                    }
                    string colCnName = colsValue[0];
                    string colEnName = colsValue[1];
                    string type = colsValue[3];
                    string dataType = "";
                    string length = "";
                    type = type.ToLower();
                    if (type.Contains("ul"))
                    {
                        dataType = "CLOB";
                    }
                    else if (type.Contains("yyyymmddhhmmss"))
                    {
                        dataType = "DATE";
                    }
                    else if (type.Contains("c..") || type.Contains("c."))
                    {
                        length = type.Substring(type.LastIndexOf(".") + 1, type.Length - type.LastIndexOf(".") - 1);
                        dataType = "VARCHAR2(" + length + ")";
                    }
                    else if (type.Contains("c"))
                    {
                        length = type.Substring(type.LastIndexOf("c") + 1, type.Length - type.LastIndexOf("c") - 1);
                        dataType = "VARCHAR2(" + length + ")";
                    }
                    else if (type.Contains("n..") || type.Contains("n."))
                    {
                        length = type.Substring(type.LastIndexOf(".") + 1, type.Length - type.LastIndexOf(".") - 1);
                        dataType = "NUMBER";
                    }
                    else if (type.Contains("n"))
                    {
                        length = type.Substring(type.LastIndexOf("n") + 1, type.Length - type.LastIndexOf("n") - 1);
                        dataType = "NUMBER";
                    }
                    else
                    {
                        dataType = "（未找到数据类型)";
                    }

                    sqlSb.AppendLine($"{colEnName}   {dataType},");
                    commentSb.AppendLine($"comment on column {enName}.{colEnName} is '{colCnName}'; ");
                }

                sqlSb = sqlSb.Remove(sqlSb.Length - 3, 3);//去掉最后的逗号
                sqlSb.AppendLine("\n);");

                string seq_name = "";
                if (enName.Length <= 25)
                {
                    seq_name = "seq_" + enName;
                }
                else
                {
                    seq_name = "seq_" + enName + "（超过30个字符）";
                }
                string seqSql = $@" --创建序列
create sequence {seq_name}
minvalue 1
maxvalue 999999999
start with 1
increment by 1
nocache
order;";
                resultSb.Append(sqlSb);
                resultSb.Append(commentSb);
                resultSb.AppendLine(seqSql);
                resultSb.AppendLine();//空两行
                resultSb.AppendLine();
            }
            //写入文件
            StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + saveUrl);
            sw.Write(resultSb);
            sw.Flush();
            sw.Close();
        }
    }
}
