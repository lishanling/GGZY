using System.Data;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Table.Imp
{
    public class INVEST_PROJECT_CODE_TableValidator : AbstractTableValidator
    {
        public override string GetName()
        {
            return "INVEST_PROJECT_CODE";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            if ("1".Equals(dtContext.GetStringValue("RELATE_CODE")))
            {
                ValidateNullValue(dtContext, "INVEST_PROJECT_CODE", "项目类别关联代码填1时，投资项目统一代码为必填项");
            }
        }
    }
}