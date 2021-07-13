using System.Data;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Title
{
    public class DataEnValidator : AbstractTitleValidator
    {
        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            
            var dataEn = ValidateNullValue(dtTitle, Constant.DATA_EN);

            ThrowHelper.ThrowIfTure(!DataConfig.DataName.Equals(dataEn), "DATA_EN与DATA_NO不匹配");
        }
    }
}