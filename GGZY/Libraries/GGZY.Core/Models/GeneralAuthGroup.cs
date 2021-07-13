using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace GGZY.Core.Models
{
    public class GeneralAuthGroup
    {
        [JsonProperty("group_id")]
        public string GROUP_ID { get; set; }
        [JsonProperty("name")]
        public string NAME { get; set; }
        [JsonProperty("description")]
        public string DESCRIPTION { get; set; }
        [JsonProperty("sort")]
        public decimal? SORT { get; set; }
        [JsonProperty("status")]
        public decimal? STATUS { get; set; }
        [JsonProperty("is_delete")]
        public decimal? IS_DELETE { get; set; }

        [JsonIgnore]
        public string GROUP_ID_STR => GROUP_ID?.Replace("[", "").Replace("]", "");

        public List<string> GROUP_ID_LIST => GROUP_ID_STR?.Split(',').ToList();


        #region MyRegion

        /// <summary>
        /// 对应菜单编号集合，表示该规则下的角色请求接口后是否记录操作。逗号分割
        /// </summary>
        public List<string> LOG_AUTH_ARRAY { get; set; }
        /// <summary>
        /// 对应菜单编号集合，表示该规则下的角色所拥有的菜单操作权。逗号分割
        /// </summary>
        public List<string> MENU_AUTH_ARRAY { get; set; }



        #endregion
    }
}