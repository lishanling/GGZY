using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdBidWorkControlController:BaseController
    {
        /// <summary>
        /// 读取BID_WORK_CONTROL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadBidWorkControls(BID_WORK_CONTROL model, SearchCondition condition)
        {
            var result = Fw.BidWorkControlService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取BID_WORK_CONTROL明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadBidWorkControl(decimal ID)
        
        {
            var result = Fw.BidWorkControlService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建BID_WORK_CONTROL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateBidWorkControl(BID_WORK_CONTROL model)
        {
            var result = Fw.BidWorkControlService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新BID_WORK_CONTROL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateBidWorkControl(BID_WORK_CONTROL model)
        {
            var result = Fw.BidWorkControlService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除BID_WORK_CONTROL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteBidWorkControl(string ids)
        {
            var result = Fw.BidWorkControlService.Delete(ids);
            return JResult(result); 
        }
    }
}