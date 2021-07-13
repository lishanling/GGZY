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
    public partial class T_AFC_FIXED_RECORD
    {
        public string Type => "FIXED";
        /// <summary>
        /// 项目类型
        /// </summary>
        public string PROJECT_TYPE_NAME
        {
            get
            {
                var txt = String.Empty;
                switch (PROJECT_TYPE)
                {
                    case "A00001":
                        txt = "审批";
                        break;
                    case "A00002":
                        txt = "核准";
                        break;
                    case "A00003":
                        txt = "备案";
                        break;
                    case "A00088":
                        txt = "非固定资产";
                        break;
                }

                return txt;
            }
        }

        public string THE_INDUSTRY_NAME
        {
            get
            {
                var name = string.Empty;
                switch (THE_INDUSTRY)
                {
                    case "A00001": name = "农林水利"; break;
                    case "A0000101": name = "水利"; break;
                    case "A0000102": name = "农业"; break;
                    case "A0000103": name = "林业"; break;
                    case "A0000104": name = "气象"; break;
                    case "A0000105": name = "森工"; break;
                    case "A00002": name = "交通运输"; break;
                    case "A0000201": name = "公路水路港口"; break;
                    case "A0000202": name = "铁路"; break;
                    case "A0000203": name = "民航"; break;
                    case "A0000204": name = "邮电"; break;
                    case "A00003": name = "能源"; break;
                    case "A0000301": name = "油气"; break;
                    case "A0000302": name = "煤炭"; break;
                    case "A0000303": name = "电力"; break;
                    case "A0000304": name = "生物能源"; break;
                    case "A0000305": name = "油气管网"; break;
                    case "A00004": name = "城市基础设施"; break;
                    case "A0000401": name = "城建"; break;
                    case "A0000402": name = "城市轨道交通"; break;
                    case "A00005": name = "社会事业"; break;
                    case "A0000501": name = "教育"; break;
                    case "A0000502": name = "卫生"; break;
                    case "A0000503": name = "文化"; break;
                    case "A0000504": name = "体育"; break;
                    case "A0000505": name = "广播出版"; break;
                    case "A0000506": name = "人口"; break;
                    case "A0000507": name = "民政"; break;
                    case "A0000508": name = "旅游"; break;
                    case "A00006": name = "科学"; break;
                    case "A00007": name = "公检法司"; break;
                    case "A00008": name = "高技术"; break;
                    case "A00009": name = "信息化"; break;
                    case "A00010": name = "环保"; break;
                    case "A00011": name = "工业"; break;
                    case "A0001101": name = "钢铁"; break;
                    case "A0001102": name = "有色"; break;
                    case "A0001103": name = "黄金"; break;
                    case "A0001104": name = "化工"; break;
                    case "A0001105": name = "石化"; break;
                    case "A0001106": name = "建材"; break;
                    case "A0001107": name = "机械"; break;
                    case "A0001108": name = "汽车"; break;
                    case "A0001109": name = "电子"; break;
                    case "A0001110": name = "纺织"; break;
                    case "A0001111": name = "轻工"; break;
                    case "A0001112": name = "烟草"; break;
                    case "A00012": name = "地质"; break;
                    case "A00013": name = "医药"; break;
                    case "A00014": name = "仓储物流"; break;
                    case "A0001401": name = "商业、供销、外贸"; break;
                    case "A0001402": name = "仓储物流"; break;
                    case "A0001403": name = "经贸"; break;
                    case "A00015": name = "境外投资"; break;
                    case "A00099": name = "其他"; break;

                }
                return name;
            }
        }
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

