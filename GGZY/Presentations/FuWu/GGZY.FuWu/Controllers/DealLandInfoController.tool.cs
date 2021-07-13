using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDealLandInfoController:BaseController
    {
        /// <summary>
        /// 读取DEAL_LAND_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDealLandInfos(DEAL_LAND_INFO model, SearchCondition condition)
        {
            var result = Fw.DealLandInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEAL_LAND_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDealLandInfo(decimal M_ID)
        
        {
            var result = Fw.DealLandInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEAL_LAND_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDealLandInfo(DEAL_LAND_INFO model)
        {
            var result = Fw.DealLandInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEAL_LAND_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDealLandInfo(DEAL_LAND_INFO model)
        {
            var result = Fw.DealLandInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEAL_LAND_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDealLandInfo(string ids)
        {
            var result = Fw.DealLandInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}