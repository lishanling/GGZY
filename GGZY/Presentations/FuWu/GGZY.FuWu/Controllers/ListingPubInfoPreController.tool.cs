using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdListingPubInfoPreController:BaseController
    {
        /// <summary>
        /// 读取LISTING_PUB_INFO_PRE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadListingPubInfoPres(LISTING_PUB_INFO_PRE model, SearchCondition condition)
        {
            var result = Fw.ListingPubInfoPreService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取LISTING_PUB_INFO_PRE明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadListingPubInfoPre(decimal M_ID)
        
        {
            var result = Fw.ListingPubInfoPreService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建LISTING_PUB_INFO_PRE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateListingPubInfoPre(LISTING_PUB_INFO_PRE model)
        {
            var result = Fw.ListingPubInfoPreService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新LISTING_PUB_INFO_PRE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateListingPubInfoPre(LISTING_PUB_INFO_PRE model)
        {
            var result = Fw.ListingPubInfoPreService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除LISTING_PUB_INFO_PRE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteListingPubInfoPre(string ids)
        {
            var result = Fw.ListingPubInfoPreService.Delete(ids);
            return JResult(result); 
        }
    }
}