using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class CorrectionItemService 
    {
        public CORRECTION_ITEM FindCorrectionItemByProjectCode(string projectCode)
        {
            return FirstOrNull(CORRECTION_ITEM._.PURCHASE_PROJECT_CODE == projectCode);
        }
	}
}