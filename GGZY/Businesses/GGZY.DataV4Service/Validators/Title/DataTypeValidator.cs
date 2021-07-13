using System.Data;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Title
{
    public class DataTypeValidator : AbstractTitleValidator
    {
        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            var dataType = dtTitle.GetIntValue("DATA_TYPE");
            ThrowHelper.ThrowIfTure(dataType != 1 && dataType != 2 && dataType != 3,
                "DATA_TYPE不正确");
        }
    }
}