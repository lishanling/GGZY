using System.Data;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Table.Imp
{
    public class BID_AMOUNT_TableValidator : AbstractTableValidator
    {
        public override string GetName()
        {
            return "BID_AMOUNT";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            //当价款形式代码（PRICE_FORM_CODE）=1 时做如上判断，PRICE_UNIT = 1时为万元，判断BID_AMOUNT是否大于30亿
            if ("1".Equals(dtContext.GetStringValue("PRICE_FORM_CODE")))
            {
                var priceScale = 1;
                var priceUnit = dtContext.GetStringValue("PRICE_UNIT");
                if ("1".Equals(priceUnit))
                {
                    priceScale = 10000;
                }
                var BID_AMOUNT = dtContext.GetDoubleValue("BID_AMOUNT") * priceScale;
                if (BID_AMOUNT > 30d * 10000 * 10000)
                {
                    //招标编号是否在配置文件中
                    var tenderProjectCode = dtContext.GetStringValue("TENDER_PROJECT_CODE");
                    var tpCodeList = DataConfig.GetSpecialTenderProjectCodeList();
                    if (!tpCodeList.Contains(tenderProjectCode))
                    {
                        ThrowHelper.ThrowIfTure(true, "中标金额超过30亿元人民币，请联系客服人员");
                    }
                }
            }

            
        }
    }
}