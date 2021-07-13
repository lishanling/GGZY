using System.Data;
using GGZY.DataV4Service.Extend;
using GGZY.DataV4Service.Validators.Context.Field.Imp;

namespace GGZY.DataV4Service.Validators.Context.Table.Imp
{
    public class TENDER_AGENCY_CODE_TYPE_TableValidator : AbstractTableValidator
    {
        public override string GetName()
        {
            return "TENDER_AGENCY_CODE_TYPE";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            if ("2".Equals(dtContext.GetStringValue("TENDER_ORGANIZE_FORM")))
            {
                var fieldValidtor = new DomainMatchDataValidator()
                {
                    DataConfig = DataConfig,
                    Field = "TENDER_AGENCY_CODE_TYPE",
                    Type = "2001"
                };
                fieldValidtor.Validate(dtTitle, dtContext);
            }
        }
    }
}