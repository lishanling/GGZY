using System.Data;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Table.Imp
{
    public class TAX_CERT_NO_TableValidator : AbstractTableValidator
    {
        public override string GetName()
        {
            return "TAX_CERT_NO";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            var TAX_CERT_NO = dtContext.GetStringValue("TAX_CERT_NO");
            var TAX_CERT_END_DATE = dtContext.GetStringValue("TAX_CERT_END_DATE");

            var LOCAL_TAX_CERT_NO = dtContext.GetStringValue("LOCAL_TAX_CERT_NO");
            var LOCAL_TAX_CERT_END_DATE = dtContext.GetStringValue("LOCAL_TAX_CERT_END_DATE");

            if (string.IsNullOrEmpty(TAX_CERT_NO) || string.IsNullOrEmpty(TAX_CERT_END_DATE))
            {
                if (string.IsNullOrEmpty(LOCAL_TAX_CERT_NO) || string.IsNullOrEmpty(LOCAL_TAX_CERT_END_DATE))
                {
                    ThrowHelper.ThrowIfTure(true, "国税和地税税务登记证相关信息必填一个");
                }
            }
        }
    }
}