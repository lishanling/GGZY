using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace GGZY.Core.Models
{
    public class GeneralAuthRule
    {

        /// <summary>
        /// 角色菜单ID
        /// </summary>
        [JsonProperty("rule_id")]
        public string RULE_ID { get; set; }
        /// <summary>
        /// 角色id
        /// </summary>
        [JsonProperty("group_id")]
        public string GROUP_ID { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("remark")]
        public string REMARK { get; set; }
        /// <summary>
        /// 权限类型 insert,delete,update,select等 用逗号隔开
        /// </summary>
        [JsonProperty("power")]
        public string POWER { get; set; }
        /// <summary>
        /// 所属模块,参数的值是不固定的，可根据模块需求决定
        /// </summary>
        [JsonProperty("module")]
        public string MODULE { get; set; }
        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("name")]
        public string NAME { get; set; }

        /// <summary>
        /// 对应菜单编号集合，表示该规则下的角色请求接口后是否记录操作。逗号分割
        /// </summary>
        [JsonProperty("LOG_AUTH_ARRAY")]
        public List<string> LOG_AUTH { get; set; }
        /// <summary>
        /// 对应菜单编号集合，表示该规则下的角色所拥有的菜单操作权。逗号分割
        /// </summary>
        [JsonProperty("MENU_AUTH_ARRAY")]
        public List<string> MENU_AUTH { get; set; }

        /// <summary>
        /// 规则排序值
        /// </summary>
        [JsonProperty("sort")]
        public decimal? SORT { get; set; }



        [JsonProperty("LOG_AUTH")]
        public string LOG_AUTH_STR
        {
            get
            {
                if (LOG_AUTH != null && LOG_AUTH.Any())
                {
                    return string.Join(",", LOG_AUTH);
                }
                return String.Empty;
            }
        }


        [JsonProperty("MENU_AUTH")]
        public string MENU_AUTH_STR
        {
            get
            {
                if (MENU_AUTH != null && MENU_AUTH.Any())
                {
                    return string.Join(",", MENU_AUTH);
                }
                return String.Empty;
            }
        }
    }
}