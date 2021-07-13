using System.Data;

namespace GGZY.DataV4Service.Validators.Title
{
    public class DataCnValidator : AbstractTitleValidator
    {
        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            ValidateNullValue(dtTitle, "DATA_CN");
        }
    }
}