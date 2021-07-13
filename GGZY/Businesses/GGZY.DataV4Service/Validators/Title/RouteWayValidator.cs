using System.Data;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Title
{
    public class RouteWayValidator:AbstractTitleValidator
    {
        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            var dataType = dtTitle.GetIntValue("DATA_TYPE");
            if (dataType == 1)
            {
                ValidateNullValue(dtTitle, "ROUTE_WAY");
            }
        }
    }
}