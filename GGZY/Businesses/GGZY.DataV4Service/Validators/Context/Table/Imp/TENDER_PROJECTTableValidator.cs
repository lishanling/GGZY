using System.Data;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;
using GGZY.DataV4Service.Validators.Context.Field.Imp;

namespace GGZY.DataV4Service.Validators.Context.Table.Imp
{
    public class TENDER_PROJECTTableValidator :AbstractTableValidator
    {
        public override string GetName()
        {
            return "TENDER_PROJECT";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            //招标项目表，如为自行招标，则招标代理有关字段不必填，库表中为必填，设为-，上报时替换为空
            if ("2".Equals(dtContext.GetStringValue("TENDER_ORGANIZE_FORM")))
            {
                if (string.IsNullOrEmpty(dtContext.GetStringValue("TENDER_AGENCY_NAME")) 
                    || string.IsNullOrEmpty(dtContext.GetStringValue("TENDER_AGENCY_CODE_TYPE")) 
                    || string.IsNullOrEmpty(dtContext.GetStringValue("TENDER_AGENCY_CODE")))
                {
                    ThrowHelper.ThrowIfTure(true, "非自行招标，招标代理机构名称、代码、类别为必填项");
                }
                var fieldValidator = new DomainMatchDataValidator
                {
                    Field = "TENDER_AGENCY_CODE_TYPE",
                    Type = "2001",
                    DataConfig = DataConfig
                };
                fieldValidator.Validate(dtTitle, dtContext);

            }

            //若为专用数据集数据，并已启用2.0，则不允许上传到通用数据集
            string TenderType = ",A01,A02,A03,A06,A07,G01,G02,G03,G06,G07,";
            if (TenderType.Contains("," + dtContext.GetStringValue("TENDER_PROJECT_TYPE") + ","))
            {
                ThrowHelper.ThrowIfTure(true, "专用数据请往专用数据集上报数据");

            }




        }
    }
}