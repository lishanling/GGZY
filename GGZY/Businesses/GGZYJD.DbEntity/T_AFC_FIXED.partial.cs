using System;
using System.Data;
using Dos.ORM;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_AFC_FIXED。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class T_AFC_FIXED
    {
        public string Type => "FIXED";
        public string APPLY_DATE
        {
            get
            {
                string value = null;
                if (!string.IsNullOrWhiteSpace(JSON))
                {
                    try
                    {
                        var jsonModel = JObject.Parse(JSON);
                        foreach (var prop in jsonModel)
                        {
                            if (string.Compare(prop.Key, "APPLY_DATE", StringComparison.CurrentCultureIgnoreCase) == 0)
                            {
                               value = prop.Value?.ToString();
                               break;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                return value;
            }
        }
        public string TOTAL_MONEY
        {
            get
            {
                var money = string.Empty;
                if (!string.IsNullOrWhiteSpace(JSON))
                {
                    try
                    {
                        var jsonModel = JObject.Parse(JSON);
                        foreach (var prop in jsonModel)
                        {
                            if (string.Compare(prop.Key, "TOTAL_MONEY", StringComparison.CurrentCultureIgnoreCase) == 0)
                            {
                                money = prop.Value?.ToString();
                                break;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                return money;
            }
        }

        public T_AFC_FIXED_JSON JSON_MODEL
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(JSON))
                {
                    JObject json = JObject.Parse(JSON);
                    return json.ToObject<T_AFC_FIXED_JSON>();
                }

                return null;
            }
        }
    }

    public partial class T_AFC_FIXED_JSON
    {
        private string _CREATETIME;
        private string _UPDATETIME;

        public string PROJECT_CODE { get; set; }
        public string PROJECT_FUNCTION { get; set; }
        public string PROJECT_INVESTMENT_NATURE { get; set; }
        public string REPORT_CODE { get; set; }
        public string IS_MAJOR { get; set; }
        public string PLACE_CODE_NAME { get; set; }
        public string PLACE_CODE_DETAIL_NAME { get; set; }
        public string PROJECT_NATURE { get; set; }
        public string HOUSE_PROJECT_NATURE { get; set; }
        public string HOUSE_PROJECT_TYPE { get; set; }
        public string DIVISION_CODE { get; set; }
        public string FOREIGN_ABROAD_FLAG { get; set; }
        public string PROJECT_NAME { get; set; }
        public string PROJECT_TYPE { get; set; }
        public string VALIDITY_FLAG { get; set; }
        public string START_YEAR { get; set; }
        public string END_YEAR { get; set; }
        public string TOTAL_MONEY { get; set; }
        public string TOTAL_MONEY_EXPLAIN { get; set; }
        public string PLACE_CODE { get; set; }
        public string INDUSTRY { get; set; }
        public string THE_INDUSTRY { get; set; }
        public string SCALE_CONTENT { get; set; }
        public string APPLY_DATE { get; set; }

        public string CREATETIME
        {
            get => _CREATETIME?.Replace("T", " ");
            set => _CREATETIME = value;
        }

        public string PERMIT_ITEM_CODE { get; set; }
        public string DIVISION_CODE_NAME { get; set; }
        public string IS_COUNTRY_SECURITY { get; set; }
        public string SECURITY_APPROVAL_NUMBER { get; set; }
        public string INVESTMENT_MODE { get; set; }
        public string TOTAL_MONEY_DOLLAR { get; set; }
        public string TOTAL_MONEY_DOLLAR_RATE { get; set; }
        public string PROJECT_CAPITAL_MONEY { get; set; }
        public string PROJECT_CAPITAL_MONEY_DOLLAR { get; set; }
        public string PROJECT_CAPITAL_MONEY_RATE { get; set; }
        public string INDUSTRIAL_POLICY_TYPE { get; set; }
        public string INDUSTRIAL_POLICY { get; set; }
        public string OTHER_INVESTMENT_APPLY_INFO { get; set; }
        public string TRANSACTION_BOTH_INFO { get; set; }

        public string UPDATETIME
        {
            get => _UPDATETIME?.Replace("T", " ");
            set => _UPDATETIME = value;
        }

        public string MERGER_PLAN { get; set; }
        public string MERGER_MANAGEMENT_MODE_SCOPE { get; set; }
        public string GET_LAND_MODE { get; set; }
        public string BUILT_AREA { get; set; }
        public string IS_ADD_DEVICE { get; set; }
        public string IMPORT_DEVICE_NUMBER_MONEY { get; set; }
        public string PROJECT_SITE { get; set; }
        public string CHINA_TOTAL_MONEY { get; set; }

    }
}

#region JSON
/*
 *
 {
	"PROJECT_CODE": "2020-350582-17-03-033330",
	"PROJECT_FUNCTION": "999",
	"PROJECT_INVESTMENT_NATURE": "100",
	"REPORT_CODE": "3505822005120113",
	"IS_MAJOR": "0",
	"PLACE_CODE_NAME": "福建省泉州市晋江市",
	"PLACE_CODE_DETAIL_NAME": "福建省泉州市晋江市",
	"PROJECT_NATURE": "0",
	"HOUSE_PROJECT_NATURE": "099",
	"HOUSE_PROJECT_TYPE": "01",
	"DIVISION_CODE": "350582",
	"FOREIGN_ABROAD_FLAG": "0",
	"PROJECT_NAME": "年产PP改性颗粒4800吨、熔喷布1200吨（不属于新建7万吨/年以下聚丙烯（连续法及间歇法））",
	"PROJECT_TYPE": "A00003",
	"VALIDITY_FLAG": "1",
	"START_YEAR": "2020",
	"END_YEAR": "2020",
	"TOTAL_MONEY": "300",
	"TOTAL_MONEY_EXPLAIN": "",
	"PLACE_CODE": "350582",
	"INDUSTRY": "1789",
	"THE_INDUSTRY": "A0001110",
	"SCALE_CONTENT": "无新基建，利用已有厂房，主要建筑面积1500(平方米) ，年产聚丙烯颗粒4800吨、熔喷布1200吨。设置3台熔喷布生产线设备、4台熔喷布设备、5台3T的冷却塔、4台空压机等设备",
	"APPLY_DATE": "2020-05-12 12:01:15.0",
	"CREATETIME": "2020-05-11T16:29:25",
	"PERMIT_ITEM_CODE": "768560507FK00501",
	"DIVISION_CODE_NAME": "福建省泉州市晋江市",
	"IS_COUNTRY_SECURITY": "",
	"SECURITY_APPROVAL_NUMBER": "",
	"INVESTMENT_MODE": "",
	"TOTAL_MONEY_DOLLAR": "",
	"TOTAL_MONEY_DOLLAR_RATE": "",
	"PROJECT_CAPITAL_MONEY": "",
	"PROJECT_CAPITAL_MONEY_DOLLAR": "",
	"PROJECT_CAPITAL_MONEY_RATE": "",
	"INDUSTRIAL_POLICY_TYPE": "",
	"INDUSTRIAL_POLICY": "",
	"OTHER_INVESTMENT_APPLY_INFO": "",
	"TRANSACTION_BOTH_INFO": "",
	"UPDATETIME": "2020-05-12T12:01:15",
	"MERGER_PLAN": "",
	"MERGER_MANAGEMENT_MODE_SCOPE": "",
	"GET_LAND_MODE": "",
	"BUILT_AREA": "",
	"IS_ADD_DEVICE": "",
	"IMPORT_DEVICE_NUMBER_MONEY": "",
	"PROJECT_SITE": "",
	"CHINA_TOTAL_MONEY": ""
}
 *
 */
#endregion

