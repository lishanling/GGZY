using System.Data;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Table.Imp
{
    public class TENDER_FILE_CLARI_MODITableValidator : AbstractTableValidator
    {
        public override string GetName()
        {
            return "TENDER_FILE_CLARI_MODI";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            var IS_POSTPONE = dtContext.GetStringValue("IS_POSTPONE");
            if ("1".Equals(IS_POSTPONE))
            {
                ValidateNullValue(dtContext, "POST_OPEN_TIME", "开标延期，延期后的开标时间和开标地点为必填项");
                ValidateNullValue(dtContext, "POST_OPEN_ADDRESS", "开标延期，延期后的开标时间和开标地点为必填项");

            }
        }
    }
}