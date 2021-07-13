using System.Data;

namespace GGZY.DataV4Service.Validators.Title
{
    public class CaKeyValidator : AbstractTitleValidator
    {
        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            ValidateNullValue(dtTitle, "CA_KEY");
        }
    }
}