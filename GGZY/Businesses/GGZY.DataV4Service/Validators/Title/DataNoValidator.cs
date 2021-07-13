using System.Data;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Title
{
    public class DataNoValidator:AbstractTitleValidator
    {
        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            ValidateNullValue(dtTitle, Constant.DATA_NO);

        }
    }
}