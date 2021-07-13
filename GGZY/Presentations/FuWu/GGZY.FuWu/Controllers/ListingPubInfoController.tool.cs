using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdListingPubInfoController:BaseController
    {
        /// <summary>
        /// 读取LISTING_PUB_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadListingPubInfos(LISTING_PUB_INFO model, SearchCondition condition)
        {
            var result = Fw.ListingPubInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取LISTING_PUB_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadListingPubInfo(decimal M_ID)
        
        {
            var result = Fw.ListingPubInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建LISTING_PUB_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateListingPubInfo(LISTING_PUB_INFO model)
        {
            var result = Fw.ListingPubInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新LISTING_PUB_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateListingPubInfo(LISTING_PUB_INFO model)
        {
            var result = Fw.ListingPubInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除LISTING_PUB_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteListingPubInfo(string ids)
        {
            var result = Fw.ListingPubInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}