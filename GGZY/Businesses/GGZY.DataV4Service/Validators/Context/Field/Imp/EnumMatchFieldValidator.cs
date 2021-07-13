using System.Collections.Generic;
using System.Data;
using System.Linq;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Field.Imp
{
    public class EnumMatchFieldValidator: AbstractFieldValidator
    {
        public string EnumType { get; set; }

        public override string GetName()
        {
            return "EnumMatch";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            if (IfNotNull(dtTitle, dtContext))
            {
                var enumDict = _domainDict.GetValue(EnumType);
                if (enumDict != null)
                {
                    var value = dtContext.GetStringValue(Field);
                    ThrowHelper.ThrowIfTure(!enumDict.ContainsKey(value),$"[{Field}]值不在范围内");
                }
            }
        }

        private static Dictionary<string, Dictionary<string, string>> _domainDict = 
            new Dictionary<string, Dictionary<string, string>>
            {
                {"PRICE_UNIT",new Dictionary<string, string>
                {
                    {"0","元" },
                    {"1","万元" }
                } },
                {"RELATE_CODE",new Dictionary<string, string>
                {
                    {"0","非固定资产类项目" },
                    {"1","固定资产类项目" }
                } },
                {"TRUE_OR_FALSE",new Dictionary<string, string>
                {
                    {"0","否" },
                    {"1","是" }
                } },
                {"CQ_TRUE_OR_FALSE",new Dictionary<string, string>
                {
                    {"F","否" },
                    {"T","是" }
                } },
                {"PRICE_FORM_CODE",new Dictionary<string, string>
                {
                    {"1","金额" },
                    {"2","费率/比率/优惠率/合格率等" },
                    {"3","单价" },
                    {"9","其他形式" }
                } },
                {"EXCEPITON_TYPE",new Dictionary<string, string>
                {
                    {"1","流标" },
                    {"2","终止开标" },
                    {"3","公告撤销" },
                    {"9","其他" }
                } }
            };

        public override string MockCorrectValue(string value)
        {
            var enumDict = _domainDict.GetValue(EnumType);
            if (enumDict != null)
            {
                return enumDict.FirstOrDefault().Key;
            }
            return "0";
        }
    }
}