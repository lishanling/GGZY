using System.Data;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Table.Imp
{
    public class TENDER_PROJECT_TYPE_TableValidator : AbstractTableValidator
    {
        public override string GetName()
        {
            return "TENDER_PROJECT_TYPE";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            //若为专用数据集数据，并已启用2.0，则不允许上传到通用数据集
            string TenderType = ",A01,A02,A03,A06,A07,G01,G02,G03,G06,G07,";
            if (TenderType.Contains("," + dtContext.GetStringValue("TENDER_PROJECT_TYPE") + ",") && dtContext.GetStringValue("IS_TO_LAW") == "1")
            {
                ThrowHelper.ThrowIfTure(true, "专用数据请往专用数据集上报数据");

            }
        }
    }
}