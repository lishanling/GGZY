using System.Collections.Generic;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public partial class TSuperviseResultLogModel
    {
        protected Dictionary<string, string> DICTIONARY => new Dictionary<string, string>()
        {
            {"1",nameof(T_AFC_PROJECT) },
            {"2",nameof(T_AFC_PROJECT) },
            {"3",nameof(PT_ZXTS) },
            {"4",nameof(T_AFC_PROJECT) },
        };
        public string MODULE_TYPE { get; set; }




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