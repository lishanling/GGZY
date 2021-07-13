using System.Data;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;

namespace GGZY.DataV4Service.Validators.Context.Table.Imp
{
    public class CONTRACT_RECKON_PRICE_TableValidator : AbstractTableValidator
    {
        public override string GetName()
        {
            return "CONTRACT_RECKON_PRICE";
        }

        public override void Validate(DataTable dtTitle, DataTable dtContext)
        {
            //CONTRACT_RECKON_PRICE >30亿时需提示请联系客服人员
            var priceScale = 1;
            var priceUnit = dtContext.GetStringValue("PRICE_UNIT");
            if ("1".Equals(priceUnit))
            {
                priceScale = 10000;
            }
            var CONTRACT_RECKON_PRICE = dtContext.GetDoubleValue("CONTRACT_RECKON_PRICE") * priceScale;
            if (CONTRACT_RECKON_PRICE > 30d * 10000 * 10000)
            {
                //招标编号是否在配置文件中
                var tenderProjectCode = dtContext.GetStringValue("TENDER_PROJECT_CODE");
                var tpCodeList = DataConfig.GetSpecialTenderProjectCodeList();
                if (!tpCodeList.Contains(tenderProjectCode))
                {
                    ThrowHelper.ThrowIfTure(true, "标段合同估算价超过30亿元人民币，请联系客服人员");
                }
            }

        }
    }
}