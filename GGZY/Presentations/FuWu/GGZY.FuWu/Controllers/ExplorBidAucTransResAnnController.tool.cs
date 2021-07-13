using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdExplorBidAucTransResAnnController:BaseController
    {
        /// <summary>
        /// 读取EXPLOR_BID_AUC_TRANS_RES_ANN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadExplorBidAucTransResAnns(EXPLOR_BID_AUC_TRANS_RES_ANN model, SearchCondition condition)
        {
            var result = Fw.ExplorBidAucTransResAnnService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取EXPLOR_BID_AUC_TRANS_RES_ANN明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadExplorBidAucTransResAnn(decimal M_ID)
        
        {
            var result = Fw.ExplorBidAucTransResAnnService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建EXPLOR_BID_AUC_TRANS_RES_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateExplorBidAucTransResAnn(EXPLOR_BID_AUC_TRANS_RES_ANN model)
        {
            var result = Fw.ExplorBidAucTransResAnnService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新EXPLOR_BID_AUC_TRANS_RES_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateExplorBidAucTransResAnn(EXPLOR_BID_AUC_TRANS_RES_ANN model)
        {
            var result = Fw.ExplorBidAucTransResAnnService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除EXPLOR_BID_AUC_TRANS_RES_ANN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteExplorBidAucTransResAnn(string ids)
        {
            var result = Fw.ExplorBidAucTransResAnnService.Delete(ids);
            return JResult(result); 
        }
    }
}