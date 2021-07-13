using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_AFC_SECONDARY_PROJECT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class T_AFC_SECONDARY_PROJECT
    {
        /// <summary>
        /// 
        /// </summary>
        public string Type => "SECONDARY";

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

        public string PROJECT_ATTRIBUTE_NAME
        {
            get
            {
                var txt = String.Empty;
                switch (PROJECT_ATTRIBUTES)
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

    }
}