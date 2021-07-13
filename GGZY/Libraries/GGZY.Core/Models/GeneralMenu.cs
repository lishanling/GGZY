using System;
using System.Data;
using Newtonsoft.Json;


namespace GGZY.Core.Models
{
    /// <summary>
    /// 实体类GeneralMenu。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class GeneralMenu
    {

        private decimal? _lEVEL;


        /// <summary>
        /// 菜单编号
        /// </summary>
        [JsonProperty("menu_id")]
        public string MENU_ID { get; set; }

        /// <summary>
        /// 菜单上级编号
        /// </summary>
        [JsonProperty("parent_id")]
        public string PARENT_ID { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        [JsonProperty("name")]
        public string NAME { get; set; }
        /// <summary>
        /// 菜单别名
        /// </summary>
        [JsonProperty("alias")]
        public string ALIAS { get; set; }
        /// <summary>
        /// 菜单图标(样式图标)
        /// </summary>
        [JsonProperty("icon")]
        public string ICON { get; set; }
        /// <summary>
        /// 菜单备注
        /// </summary>
        [JsonProperty("remark")]
        public string REMARK { get; set; }
        /// <summary>
        /// 所属模块
        /// </summary>
        [JsonProperty("module")]
        public string MODULE { get; set; }
        /// <summary>
        /// 链接类型 0=模块 1=外链
        /// </summary>
        [JsonProperty("type")]
        public decimal? TYPE { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        [JsonProperty("url")]
        public string URL { get; set; }
        /// <summary>
        /// 链接参数
        /// </summary>
        [JsonProperty("params")]
        public string PARAMS { get; set; }

        /// <summary>
        /// 打开方式 _self _blank
        /// </summary>
        [JsonProperty("target")]
        public string TARGET { get; set; }
        /// <summary>
        /// 是否属于导航菜单 0=否 1=是
        /// </summary>
        [JsonProperty("is_navi")]
        public decimal? IS_NAVI { get; set; }
        /// <summary>
        /// 菜单排序值
        /// </summary>
        [JsonProperty("sort")]
        public decimal? SORT { get; set; }
        /// <summary>
        /// 菜单状态 0=禁用 1=启用
        /// </summary>
        [JsonProperty("status")]
        public decimal? STATUS { get; set; }
        /// <summary>
        /// 该菜单的层级深度
        /// </summary>
        [JsonProperty("level")]
        public decimal? LEVEL { get => _lEVEL; set => _lEVEL = value; }
        [JsonIgnore]
        public decimal? MENU_LEVEL { get => _lEVEL; set => _lEVEL = value; }
        /// <summary>
        /// 该菜单下子级菜单数的合计
        /// </summary>
        [JsonProperty("children_total")]
        public decimal? CHILDREN_TOTAL { get; set; }
        /// <summary>
        /// 是否展示
        /// </summary>
        [JsonProperty("isshow")]
        public decimal? ISSHOW { get; set; }

        [JsonIgnore]
        public bool IsGGZYFW
        {
            get
            {
                return !string.IsNullOrWhiteSpace(MODULE) &&
                       MODULE.IndexOf("ggzyfw", StringComparison.CurrentCultureIgnoreCase) > -1;
            }
        }
    }
}