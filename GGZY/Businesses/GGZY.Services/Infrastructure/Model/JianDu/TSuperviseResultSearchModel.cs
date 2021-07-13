using System.Collections.Generic;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public class TSuperviseResultSearchModel:SearchCondition
    {
        public string MODULE_TYPE { get; set; }
        public string PROJECT_NAME { get; set; }
        public string CODE { get; set; }
        public string REGION_CODE { get; set; }
        public string PROJECT_TYPE { get; set; }
        public string STATUS { get; set; }
        public string DEPID { get; set; }
        /// <summary>
        /// 监察名称
        /// </summary>
        public string SUPERVISE_NAME { get; set; }
        /// <summary>
        /// 监察类型
        /// </summary>
        public string SUPERVISE_TYPE { get; set; }

        protected Dictionary<string,string> DICTIONARY=>new Dictionary<string, string>()
        {
            {"1",nameof(T_AFC_PROJECT) },
            {"2",nameof(RECORD_REVIEW) },
            {"3",nameof(PT_ZXTS) },
            {"4",nameof(GGZYFW.DbEntity.WARN_RESULT) },
        };

        public string ENTITY_TYPE_NAME { get; set; }
     

        public GeneralResult Validate()
        {
            var r = new GeneralResult();
            if (!DICTIONARY.ContainsKey(MODULE_TYPE))
            {
                r.SetFail("参数错误:MODULE_TYPE");
            }
            else
            {
                ENTITY_TYPE_NAME = DICTIONARY[MODULE_TYPE];
                r.SetSuccess();
            }
            return r;
        }
    }
}