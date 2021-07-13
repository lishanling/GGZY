using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using Aspose.Cells;
using GGZY.DataV4Service;
using GGZY.DataV4Service.Db;
using GGZY.DataV4Service.Extend;
using GGZY.DataV4Service.Validators.Context.Field;
using GGZY.DataV4Service.Validators.Context.Field.Imp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace DataV4Service.Test
{
    public class UploadDataMocker
    {
        private int dataKeySeq = 0;
        private int projectSeq = 0;
        private int tpSeq = 0;
        private int sectionSeq = 0;

        private string _systemNo = "8888";
        private string _platFormCode = "111111122222228888";
        private string _version = "V4";
        private Dictionary<string, string> _insertDataDict = new Dictionary<string, string>();
        private Dictionary<string, string> _updateDataDict = new Dictionary<string, string>();
        private Dictionary<string, string> _deleteDataDict = new Dictionary<string, string>();



        public string GetMockData(string datano, string opt)
        {
            var dataDict = GetMockDataDict(opt);
            if (dataDict.ContainsKey(datano))
            {
                return dataDict[datano];
            }
            return null;
        }


        public Tuple<string, string> GetUploadResult(string data)
        {
            var validData = GetValidData();
            var result = DataManager.UploadData(validData, data, _version);
            var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
            return new Tuple<string, string>(dict.GetStringValue("STATUS"),
                dict.GetStringValue("MSG"));
        }

        private string GetValidData()
        {
            string key = "12345678";        //密钥
            string platcode = _systemNo;        //交易平台编码
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string text = platcode + DateTime.Now.ToString("yyyyMMddHHmmss") + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(platcode, "MD5");
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            string Token = DESEncrypt.Encode(text, key);
            string validData = "<?xml version='1.0' encoding='utf-8'?><DATA><TOKEN>" + Token + "</TOKEN><SYSTEM_NO>" + platcode + "</SYSTEM_NO></DATA>";
            return validData;
        }

        private Dictionary<string, string> GetMockDataDict(string opt)
        {
            var dataDict = new Dictionary<string, string>();
            if ("insert".Equals(opt))
            {
                dataDict = _insertDataDict;
            }
            else if ("update".Equals(opt))
            {
                dataDict = _updateDataDict;
            }
            else if ("delete".Equals(opt))
            {
                dataDict = _deleteDataDict;
            }
            return dataDict;
        }

        public void IsSuccess(string datano, string opt)
        {
            var dataDict = GetMockDataDict(opt);
            var xml = dataDict[datano];
            var dts = XmlHelper.ToDataSetByString(xml);
            var dtTitle = dts.Tables["TITLE"];
            var dataKey = dtTitle.GetStringValue(Constant.DATA_KEY);
            var dataType = dtTitle.GetStringValue(Constant.DATA_TYPE);
            var dataConfig = DataConfig.GetDataConfig(datano, _version);

            var sql = $"select * from {dataConfig.TableName} where {dataConfig.M_KEY_Field} = '{dataKey}'";
            var ds = dataConfig.Dao.GetDataSet(sql);
            var dt = ds.Tables[0];
            var rowCount = 1;
            if ("3".Equals(dataType))
            {
                rowCount = 0;
            }
            Assert.IsTrue(dt.Rows.Count == rowCount, datano + ":" + "验证数据失败");
            if (dataConfig.IsSaveGGFW())
            {
                sql =
                    $"select * from {dataConfig.GgfwDataConfig.TableName} where {dataConfig.GgfwDataConfig.M_KEY_Field} = '{dataKey}'";
                ds = dataConfig.GgfwDataConfig.Dao.GetDataSet(sql);
                dt = ds.Tables[0];
                Assert.IsTrue(dt.Rows.Count == rowCount, datano + ":" + "验证数据失败");
            }
        }


        public void Mock2()
        {
            foreach (var dataType in DataConfigManager.GetDataTypeList())
            {
                foreach (var datano in DataConfigManager.GetDataNameList(dataType))
                {
                    DataConfig dataConfig = null;
                    try
                    {
                        dataConfig = DataConfig.GetDataConfig(datano, _version);
                    }
#pragma warning disable CS0168 // 声明了变量“ex”，但从未使用过
                    catch (Exception ex)
#pragma warning restore CS0168 // 声明了变量“ex”，但从未使用过
                    {
                        continue;
                    }
                    var sb = new StringBuilder();
                    sb.AppendLine("<DES>");
                    sb.AppendLine("<CONTEXT>");
                    foreach (var field in dataConfig.Fields)
                    {
                        if (field.Validators.Any(e => e.Validator?.GetType() == typeof(NotNullDataValidator))
                            || "100".Equals(dataConfig.DataNo) &&
                                ("TAX_CERT_NO".Equals(field.Name) || "TAX_CERT_END_DATE".Equals(field.Name)))
                        {
                            var correctValue = "";
                            foreach (var validatorDict in field.Validators)
                            {
                                var validator = validatorDict.Validator as AbstractFieldValidator;
                                if (validator != null)
                                {
                                    correctValue = validator.MockCorrectValue(correctValue);
                                }
                            }
                            if (!field.Validators.Any(e => e.Validator?.GetType() != typeof(NotNullDataValidator)))
                            //                            if(field.Validators.Count == 1)
                            {
                                var validator = new LengthMatchFieldValidator();
                                validator.MaxLength = 5000;
                                correctValue = validator.MockCorrectValue(correctValue);
                            }
                            sb.AppendLine($"<{field.Name}>{correctValue}</{field.Name}>");

                        }
                    }
                    sb.AppendLine($"<PLATFORM_CODE>{_platFormCode}</PLATFORM_CODE>");
                    sb.AppendLine("<PUB_SERVICE_PLAT_CODE>M35000007031234567</PUB_SERVICE_PLAT_CODE>");
                    sb.AppendLine("<DATA_TIMESTAMP>20190327012400</DATA_TIMESTAMP>");
                    sb.AppendLine("<TRADE_PLAT>12345678901</TRADE_PLAT>");
                    sb.AppendLine("<PUB_SERVICE_PLAT>12345678901</PUB_SERVICE_PLAT>");
                    sb.AppendLine("</CONTEXT>");

                    var titleSb = new StringBuilder();
                    titleSb.AppendLine("<TITLE>");
                    titleSb.AppendLine("<CA_KEY>88888888889999999999</CA_KEY>")
                        .AppendLine($"<DATA_CN>{dataConfig.DataCnName}</DATA_CN>")
                        .AppendLine($"<DATA_EN>{dataConfig.DataName}</DATA_EN>")
                        .AppendLine($"<DATA_KEY>{GetDataKey(datano)}</DATA_KEY>")
                        .AppendLine($"<DATA_NO>{datano}</DATA_NO>")
                        .AppendLine("<DATA_TYPE>1</DATA_TYPE>")
                        .AppendLine("<ROUTE_WAY>0</ROUTE_WAY>");
                    titleSb.AppendLine("</TITLE>");

                    sb.AppendLine(titleSb.ToString());
                    sb.AppendLine("</DES>");

                    var insertXml = sb.ToString();
                    if (!_insertDataDict.ContainsKey(datano))
                    {
                        _insertDataDict[datano] = insertXml;
                        File.WriteAllText($".\\UploadData\\{datano}_i.xml", insertXml);
                    }
                    var updateXml = insertXml.Replace("<DATA_TYPE>1</DATA_TYPE>", "<DATA_TYPE>2</DATA_TYPE>");
                    if (!_updateDataDict.ContainsKey(datano))
                    {
                        _updateDataDict[datano] = updateXml;
                        File.WriteAllText($".\\UploadData\\{datano}_u.xml", updateXml);
                    }
                    var deleteXml = titleSb.ToString().Replace("<DATA_TYPE>1</DATA_TYPE>", "<DATA_TYPE>3</DATA_TYPE>");
                    if (!_deleteDataDict.ContainsKey(datano))
                    {
                        _deleteDataDict[datano] = deleteXml;
                        File.WriteAllText($".\\UploadData\\{datano}_d.xml", deleteXml);
                    }
                }
            }
        }
        public void Mock()
        {
            MockUploadData(".\\数据规范表格\\通用.xlsx");
            MockUploadData(".\\数据规范表格\\专项.xlsx");
        }

        private void MockUploadData(string xlsFile)
        {
            var book = new Workbook(xlsFile);
            var yssheet = book.Worksheets[0];
            var yscells = yssheet.Cells;

            List<string> exitColList = new List<string>
            {
                "PLATFORM_CODE","PUB_SERVICE_PLAT_CODE","DATA_TIMESTAMP","TRADE_PLAT","PUB_SERVICE_PLAT"
            };

            //获取映射列表
            var enDict = new Dictionary<string, int>();
            var datanoList = new List<int>();
            var datano = 0;
            var tablename = "";
            var tablecnname = "";
            Dictionary<string, StringBuilder> xmlDict = null;

            for (int i = 0; i <= yscells.MaxDataRow; i++)
            {
                var a = yscells[i, 0].Value.ToString().Trim();
                var b = yscells[i, 1].Value.ToString().Trim();
                var c = yscells[i, 2].Value.ToString().Trim();
                int n = 0;
                if (int.TryParse(a, out n))
                {
                    if (xmlDict != null)
                    {
                        var sb = new StringBuilder();
                        sb.AppendLine("<DES>");
                        sb.AppendLine("<CONTEXT>");
                        sb.AppendLine(xmlDict["Context"].ToString());
                        sb.AppendLine(xmlDict["Context5"].ToString());
                        sb.AppendLine("</CONTEXT>");
                        sb.AppendLine("<TITLE>");
                        sb.AppendLine(xmlDict["Title"].ToString());
                        sb.AppendLine("</TITLE>");
                        sb.AppendLine("</DES>");

                        var tableno = xmlDict["TableNo"].ToString();
                        if (!_insertDataDict.ContainsKey(tableno))
                        {
                            _insertDataDict[tableno] = sb.ToString();
                            File.WriteAllText($".\\UploadData\\{tableno}.xml", _insertDataDict[tableno]);
                        }

                    }

                    datano = n;
                    if (datanoList.Contains(datano))
                    {
                        Console.WriteLine("datano重复，请检查");
                        return;
                    }
                    datanoList.Add(datano);
                    tablename = b;
                    tablecnname = c;
                    enDict[tablename] = datano;
                    xmlDict = new Dictionary<string, StringBuilder>();
                    xmlDict["TableNo"] = new StringBuilder(datano.ToString());
                    var titleSb = new StringBuilder();
                    titleSb.AppendLine("<CA_KEY>88888888889999999999</CA_KEY>")
                        .AppendLine($"<DATA_CN>{tablecnname}</DATA_CN>")
                        .AppendLine($"<DATA_EN>{tablename}</DATA_EN>")
                        .AppendLine($"<DATA_KEY>{GetDataKey(datano.ToString())}</DATA_KEY>")
                        .AppendLine($"<DATA_NO>{datano}</DATA_NO>")
                        .AppendLine("<DATA_TYPE>1</DATA_TYPE>")
                        .AppendLine("<ROUTE_WAY>0</ROUTE_WAY>");
                    xmlDict["Title"] = titleSb;

                    var contextSb = new StringBuilder();
                    contextSb.AppendLine($"<PLATFORM_CODE>{_platFormCode}</PLATFORM_CODE>");
                    contextSb.AppendLine("<PUB_SERVICE_PLAT_CODE>M35000007031234567</PUB_SERVICE_PLAT_CODE>");
                    contextSb.AppendLine("<DATA_TIMESTAMP>20190327012400</DATA_TIMESTAMP>");
                    contextSb.AppendLine("<TRADE_PLAT>12345678901</TRADE_PLAT>");
                    contextSb.AppendLine("<PUB_SERVICE_PLAT>12345678901</PUB_SERVICE_PLAT>");
                    xmlDict["Context5"] = contextSb;
                    xmlDict["Context"] = new StringBuilder();

                    continue;
                }

                var cnName = yscells[i, 0].Value.ToString().Trim();
                var enName = yscells[i, 1].Value.ToString().Trim();
                var type = yscells[i, 3].Value.ToString().Trim();
                var isnull = yscells[i, 5].Value.ToString().Trim();

                if (!exitColList.Contains(enName))
                {
                    xmlDict["Context"].AppendLine(createXmlNode(datano.ToString(), tablename, enName, cnName, type, isnull));
                }

            }


        }

        private Dictionary<string, string> tenderProjectDict = new Dictionary<string, string>();
        private Dictionary<string, string> projectDict = new Dictionary<string, string>();
        private Dictionary<string, string> sectionDict = new Dictionary<string, string>();

        private string createXmlNode(string tableno, string tablename, string enName, string cnName, string type, string isnull)
        {
            if ("506".Equals(tableno) && "TENDER_PROJECT_CODE".Equals(enName))
            {
#pragma warning disable CS0219 // 变量“i”已被赋值，但从未使用过它的值
                var i = 1;
#pragma warning restore CS0219 // 变量“i”已被赋值，但从未使用过它的值
            }
            string length = "";
            var type2 = type;
            type = type.ToLower();
            if ("100".Equals(tableno) && ("TAX_CERT_NO".Equals(enName) || "TAX_CERT_END_DATE".Equals(enName)))
            {
                isnull = "是";
            }
            if (isnull.Contains("是"))
            {
                var tablenonum = Convert.ToInt32(tableno);
                if (tablenonum >= 500 && tablenonum <= 523 ||
                    tablenonum >= 800 && tablenonum <= 999)
                {
                    if ("PROJECT_CODE".Equals(enName))
                    {
                        return $"<{enName}>{GetProjectCode(tablename)}</{enName}>";
                    }
                    if ("TENDER_PROJECT_CODE".Equals(enName))
                    {
                        return $"<{enName}>{GetTpCode(tablename)}</{enName}>";
                    }
                    if ("BID_SECTION_CODE".Equals(enName))
                    {
                        return $"<{enName}>{GetSectionCode(tablename)}</{enName}>";
                    }
                }

                if (enName.Equals("REGION_CODE"))
                {
                    return $"<{enName}>350000</{enName}>";
                }
                if ("502".Equals(tableno) && "TRA_PLACE_CODE".Equals(enName))
                {
                    return $"<{enName}>350000</{enName}>";
                }
                if (enName.Contains("PRICE_UNIT"))
                {
                    return $"<{enName}>0</{enName}>";
                }

                if ("504".Equals(tableno) || "804".Equals(tableno) || "834".Equals(tableno) || "864".Equals(tableno))
                {
                    if ("MARGIN_PAY_TYPE".Equals(enName))
                    {
                        return $"<{enName}>{GetTypeValue("29")}</{enName}>";
                    }
                }
                if ("100".Equals(tableno) && "LEGAL_ROLE".Equals(enName))
                {
                    return $"<{enName}>{GetTypeValue("26")}</{enName}>";
                }
                if ("112".Equals(tableno) && "QUAL_TYPE".Equals(enName))
                {
                    return $"<{enName}>{GetTypeValue("27")}</{enName}>";
                }

                if (type.Contains("ul") || type.Contains("json"))
                {
                    return $"<{enName}>{GetStrByLength(cnName.Substring(0, 1), 5000)}</{enName}>";
                }
                if (type.Contains("yyyymmdd"))
                {
                    return $"<{enName}>{DateTime.Now.ToString(type2)}</{enName}>";
                }
                if (type.Contains("c..") || type.Contains("c."))
                {
                    length = type.Substring(type.LastIndexOf(".") + 1, type.Length - type.LastIndexOf(".") - 1);

                    return $"<{enName}>{GetStrByLength(cnName.Substring(0, 1), Convert.ToInt32(length.Trim()))}</{enName}>";
                }
                if (type.Contains("c"))
                {
                    length = type.Substring(type.LastIndexOf("c") + 1, type.Length - type.LastIndexOf("c") - 1);
                    return $"<{enName}>{GetStrByLength("0", Convert.ToInt32(length.Trim()))}</{enName}>";
                }
                if (type.Contains("n..") || type.Contains("n.") || type.Contains("n．"))
                {
                    length = type.Substring(type.LastIndexOf(".") + 1, type.Length - type.LastIndexOf(".") - 1);
                    if (length.Contains(","))
                    {
                        var arrs = length.Trim().Split(',');
                        var value = GetStrByLength("8", Convert.ToInt32(arrs[0].Trim()) - Convert.ToInt32(arrs[1].Trim()))
                                + "." + GetStrByLength("6", Convert.ToInt32(arrs[1].Trim()));
                        return $"<{enName}>{value}</{enName}>";
                    }
                    else
                    {
                        var value = GetStrByLength("6", Convert.ToInt32(length.Trim()));
                        return $"<{enName}>{value}</{enName}>";
                    }
                }
                if (type.StartsWith("n"))
                {
                    length = type.Substring(type.LastIndexOf("n") + 1, type.Length - type.LastIndexOf("n") - 1);
                    if (length.Contains(","))
                    {
                        var arrs = length.Trim().Split(',');
                        var value = GetStrByLength("8", Convert.ToInt32(arrs[0].Trim()) - Convert.ToInt32(arrs[1].Trim()))
                                    + "." + GetStrByLength("6", Convert.ToInt32(arrs[1].Trim()));
                        return $"<{enName}>{value}</{enName}>";
                    }
                    else
                    {
                        var value = GetStrByLength("6", Convert.ToInt32(length.Trim()));
                        return $"<{enName}>{value}</{enName}>";
                    }
                }
                return $"<{enName}></{enName}>";
            }
            return "";

        }

        private string GetDataKey(string tableno)
        {
            dataKeySeq++;
            var buling = 7 - (tableno.Length - 3);
            return $"{_systemNo}{tableno}{DateTime.Now:ddHHmmss}{dataKeySeq.ToString().PadLeft(buling, '0')}";
        }

        private string GetStrByLength(string str, int length)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(str);
            }
            return sb.ToString();
        }

        private string GetTypeValue(string type)
        {
            var sql = "select VALUE from sys_dic where type='" + type + "'";
            var dt = DAO.GGFW.GetDataSet(sql).Tables[0];
            if (dt.Rows.Count > 0)
            {
                var value = dt.Rows[0]["VALUE"];
                if (value != null)
                {
                    return value.ToString().Trim();
                }
            }
            return "";
        }

        private string GetProjectCode(string tablename)
        {
            var codeName = "PROJECT_CODE";
            if (tablename.StartsWith("ZJ_") || tablename.StartsWith("JT_")
                || tablename.StartsWith("SL_"))
            {
                codeName = tablename.Substring(0, 3) + codeName;
            }
            if (!projectDict.ContainsKey(codeName))
            {
                projectSeq++;
                projectDict[codeName] = $"M350000{DateTime.Now:ddHHmmss}{projectSeq.ToString().PadLeft(2, '0')}";
            }
            return projectDict[codeName];
        }
        private string GetTpCode(string tablename)
        {
            var codeName = "TENDER_PROJECT_CODE";
            if (tablename.StartsWith("ZJ_") || tablename.StartsWith("JT_")
                || tablename.StartsWith("SL_"))
            {
                codeName = tablename.Substring(0, 3) + codeName;
            }
            if (!tenderProjectDict.ContainsKey(codeName))
            {
                tpSeq++;
                tenderProjectDict[codeName] = GetProjectCode(tablename) + tpSeq.ToString().PadLeft(3, '0');
            }
            return tenderProjectDict[codeName];
        }

        private string GetSectionCode(string tablename)
        {
            var codeName = "BID_SECTION_CODE";
            if (tablename.StartsWith("ZJ_") || tablename.StartsWith("JT_")
                || tablename.StartsWith("SL_"))
            {
                codeName = tablename.Substring(0, 3) + codeName;
            }
            if (!sectionDict.ContainsKey(codeName))
            {
                sectionSeq++;
                sectionDict[codeName] = GetTpCode(tablename) + sectionSeq.ToString().PadLeft(3, '0');
            }
            return sectionDict[codeName];

        }

    }
}