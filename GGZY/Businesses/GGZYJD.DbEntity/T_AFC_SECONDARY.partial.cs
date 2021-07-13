using System;
using System.Data;
using Dos.ORM;
using Newtonsoft.Json.Linq;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_AFC_SECONDARY。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class T_AFC_SECONDARY 
    {
        public string Type => "SECONDARY";
        public DateTime? APPLY_DATE
        {
            get
            {
                DateTime? value = null;
                if (!string.IsNullOrWhiteSpace(JSON))
                {
                    try
                    {
                        var jsonModel = JObject.Parse(JSON);

                        foreach (var prop in jsonModel)
                        {
                            if (string.Compare(prop.Key, "projectInfo", StringComparison.CurrentCultureIgnoreCase) == 0)
                            {
                                var jToken = (JObject)prop.Value;
                                foreach (var jTokenProp in jToken)
                                {
                                    if (string.Compare(jTokenProp.Key, "APPLY_DATE", StringComparison.CurrentCultureIgnoreCase) == 0)
                                    {
                                        var appliyDate = jTokenProp.Value?.ToString();
                                        if (!string.IsNullOrWhiteSpace(appliyDate))
                                        {
                                            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
                                            long lTime = long.Parse(appliyDate + "0000");
                                            TimeSpan toNow = new TimeSpan(lTime);
                                            value= dtStart.Add(toNow);
                                        }
                                        break;
                                    }
                                }
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
                            if (string.Compare(prop.Key, "projectInfo", StringComparison.CurrentCultureIgnoreCase) == 0)
                            {
                                var jToken = (JObject)prop.Value;
                                foreach (var jTokenProp in jToken)
                                {
                                    if (string.Compare(jTokenProp.Key, "TOTAL_MONEY", StringComparison.CurrentCultureIgnoreCase) == 0)
                                    {
                                        money = jTokenProp.Value?.ToString();
                                        break;
                                    }
                                }
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

        public T_AFC_SECONDARY_JSON JSON_MODEL
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(JSON))
                {
                    JObject json = JObject.Parse(JSON);
                    return json.ToObject<T_AFC_SECONDARY_JSON>();
                }

                return null;
            }
        }
    }

    public partial class T_AFC_SECONDARY_JSON
    {
        public string REPORT_CODE { get; set; }
        public T_AFC_SECONDARY_JSON_PROJECTINFO PROJECTINFO { get; set; }
        public T_AFC_SECONDARY_JSON_LEREPINFO LEREPINFO { get; set; }
    }

    public partial class T_AFC_SECONDARY_JSON_PROJECTINFO
    {
        public string APPLY_DATE { get; set; }
        public string AREA_CODE { get; set; }
        public string AREA_NAME { get; set; }
        public string BUILDING_AREA { get; set; }
        public string CITY_CODE { get; set; }
        public string CREATETIME { get; set; }
        public string DIVISION_CODE { get; set; }
        public string DIVISION_CODE_NAME { get; set; }
        public string END_MONTH { get; set; }
        public string END_YEAR { get; set; }
        public string FOREIGN_ABROAD_FLAG { get; set; }
        public string GOV_INVESTMENT_DIRECTION { get; set; }
        public string GOV_INVESTMENT_DIRECTION_NAME { get; set; }
        public string HOUSE_PROJECT_NATURE { get; set; }
        public string HOUSE_PROJECT_TYPE { get; set; }
        public string INDUSTRY { get; set; }
        public string INDUSTRY_NAME { get; set; }
        public string INDUSTRY_STRUCTURE { get; set; }
        public string IS_INDUSTRIAL_POLICY { get; set; }
        public string IS_MAJOR { get; set; }
        public string PLACE_CODE_DETAIL { get; set; }
        public string PLACE_CODE_DETAIL_EXTENSION { get; set; }
        public string PLACE_CODE_DETAIL_NAME { get; set; }
        public string PROJECT_ATTRIBUTES { get; set; }
        public string PROJECT_CODE { get; set; }
        public string PROJECT_FUNCTION { get; set; }
        public string PROJECT_INVESTMENT_NATURE { get; set; }
        public string PROJECT_NAME { get; set; }
        public string PROJECT_NATURE { get; set; }
        public string PROJECT_NATURE_EXTENSION { get; set; }
        public string PROJECT_TYPE { get; set; }
        public string PROVINCE_CODE { get; set; }
        public string REPORT_CODE { get; set; }
        public string SCALE_CONTENT { get; set; }
        public string START_MONTH { get; set; }
        public string START_YEAR { get; set; }
        public string THE_INDUSTRY { get; set; }
        public string THE_INDUSTRY_NAME { get; set; }
        public string TOTAL_MONEY { get; set; }
        public string UPDATETIME { get; set; }
        public string VALIDITY_FLAG { get; set; }
    }

    public partial class T_AFC_SECONDARY_JSON_LEREPINFO
    {
        public string CONTACT_CERTNO { get; set; }
        public string CONTACT_CERTTYPE { get; set; }
        public string CONTACT_EMAIL { get; set; }
        public string CONTACT_NAME { get; set; }
        public string CONTACT_PHONE { get; set; }
        public string CONTACT_TEL { get; set; }
        public string CREATETIME { get; set; }
        public string ENTERPRISE_ID { get; set; }
        public string ENTERPRISE_NAME { get; set; }
        public string LEREP_CERTNO { get; set; }
        public string LEREP_CERTTYPE { get; set; }
        public string LEREP_REPRESENTATIVE { get; set; }
        public string LEREP_REPRESENTATIVE_CERTNO { get; set; }
        public string LEREP_REPRESENTATIVE_CERTTYPE { get; set; }
        public string PROJECT_CODE { get; set; }
        public string REGISTRATION_NATURE { get; set; }
        public string UPDATETIME { get; set; }
        public string VALIDITY_FLAG { get; set; }
    }
}

#region JSON

/*
{
	"report_code": "3501222002240117",
	"projectInfo": {
		"APPLY_DATE": "1579598459000",
		"AREA_CODE": "350122",
		"AREA_NAME": "福建省福州市连江县",
		"BUILDING_AREA": "0",
		"CITY_CODE": "350100",
		"CREATETIME": "1582533857000",
		"DIVISION_CODE": "350122",
		"DIVISION_CODE_NAME": "福建省福州市连江县",
		"END_MONTH": "6",
		"END_YEAR": "2020",
		"FOREIGN_ABROAD_FLAG": "0",
		"GOV_INVESTMENT_DIRECTION": "21",
		"GOV_INVESTMENT_DIRECTION_NAME": "建筑",
		"HOUSE_PROJECT_NATURE": "099",
		"HOUSE_PROJECT_TYPE": "01",
		"INDUSTRY": "8334",
		"INDUSTRY_NAME": "普通高中教育",
		"INDUSTRY_STRUCTURE": "AU0000",
		"IS_INDUSTRIAL_POLICY": "D",
		"IS_MAJOR": "0",
		"PLACE_CODE_DETAIL": "350122",
		"PLACE_CODE_DETAIL_EXTENSION": "马鼻镇墙兜村林厝前88号",
		"PLACE_CODE_DETAIL_NAME": "福建省福州市连江县",
		"PROJECT_ATTRIBUTES": "A00003",
		"PROJECT_CODE": "2020-350122-83-88-006530",
		"PROJECT_FUNCTION": "999",
		"PROJECT_INVESTMENT_NATURE": null,
		"PROJECT_NAME": "连江尚德中学校舍及运动场地提升改造工程",
		"PROJECT_NATURE": "3",
		"PROJECT_NATURE_EXTENSION": "3",
		"PROJECT_TYPE": "A00088",
		"PROVINCE_CODE": "350000",
		"REPORT_CODE": "3501222002240117",
		"SCALE_CONTENT": "1#2#学生公寓、体育馆、室外运动场地、围墙、停车棚改造及室外硬化等",
		"START_MONTH": "2",
		"START_YEAR": "2020",
		"THE_INDUSTRY": "5011",
		"THE_INDUSTRY_NAME": "公共建筑装饰和装修",
		"TOTAL_MONEY": "795",
		"UPDATETIME": "1582533857000",
		"VALIDITY_FLAG": "1"
	},
	"lerepInfo": {
		"CONTACT_CERTNO": "350122197706144539",
		"CONTACT_CERTTYPE": "SF",
		"CONTACT_EMAIL": "875095733@qq.com",
		"CONTACT_NAME": "郭群锋",
		"CONTACT_PHONE": "13599052995",
		"CONTACT_TEL": "0591-26372004",
		"CREATETIME": "1579598459000",
		"ENTERPRISE_ID": "8bcad2a6c7c54900bfca4240a31fb61e",
		"ENTERPRISE_NAME": "福建省连江尚德中学",
		"LEREP_CERTNO": "12350122488348894M",
		"LEREP_CERTTYPE": "A05300",
		"LEREP_REPRESENTATIVE": "李新疆",
		"LEREP_REPRESENTATIVE_CERTNO": "350122197309285119",
		"LEREP_REPRESENTATIVE_CERTTYPE": "SF",
		"PROJECT_CODE": "2020-350122-83-88-006530",
		"REGISTRATION_NATURE": "A00010",
		"UPDATETIME": "1582533857000",
		"VALIDITY_FLAG": "1"
	}
}
    */

#endregion