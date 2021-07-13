using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdMiningBidAucTransResAnnController:BaseController
    {
        /// <summary>
        /// 读取MINING_BID_AUC_TRANS_RES_ANN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadMiningBidAucTransResAnns(MINING_BID_AUC_TRANS_RES_ANN model, SearchCondition condition)
        {
            var result = Fw.MiningBidAucTransResAnnService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取MINING_BID_AUC_TRANS_RES_ANN明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadMiningBidAucTransResAnn(decimal M_ID)
        
        {
            var result = Fw.MiningBidAucTransResAnnService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建MINING_BID_AUC_TRANS_RES_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateMiningBidAucTransResAnn(MINING_BID_AUC_TRANS_RES_ANN model)
        {
            var result = Fw.MiningBidAucTransResAnnService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新MINING_BID_AUC_TRANS_RES_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateMiningBidAucTransResAnn(MINING_BID_AUC_TRANS_RES_ANN model)
        {
            var result = Fw.MiningBidAucTransResAnnService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除MINING_BID_AUC_TRANS_RES_ANN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteMiningBidAucTransResAnn(string ids)
        {
            var result = Fw.MiningBidAucTransResAnnService.Delete(ids);
            return JResult(result); 
        }
    }
}