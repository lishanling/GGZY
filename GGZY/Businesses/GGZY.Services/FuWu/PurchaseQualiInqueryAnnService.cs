using System.Data;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class PurchaseQualiInqueryAnnService 
    {
        public PURCHASE_QUALI_INQUERY_ANN FindPurchaseQualiInqueryAnnByProjectCode(string projectCode)
        {
            return FirstOrNull(PURCHASE_QUALI_INQUERY_ANN._.PURCHASE_PROJECT_CODE == projectCode);
        }
    }
}