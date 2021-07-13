using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_AFC_XMCODE_RECORD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class T_AFC_XMCODE_RECORD
    {
        /// <summary>
        /// 
        /// </summary>
        public string Type => "XMCODE";

        /// <summary>
        /// 项目类型
        /// </summary>
        public string PROJECT_TYPE_NAME
        {
            get
            {
                var txt = String.Empty;
                switch (PROJECTTYPE)
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

        public string PROJECT_ATTRIBUTE_NAME
        {
            get
            {
                var txt = String.Empty;
                switch (PROJECTATTRIBUTES)
                {
                    case "A00001":
                        txt = "民间固定资产投资项目";
                        break;
                    case "A00002":
                        txt = "国有控股项目";
                        break;
                    case "A00003":
                        txt = "其他项目";
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
                switch (THEINDUSTRY)
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