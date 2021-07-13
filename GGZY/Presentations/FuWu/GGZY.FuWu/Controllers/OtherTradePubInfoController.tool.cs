using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdOtherTradePubInfoController:BaseController
    {
        /// <summary>
        /// 读取OTHER_TRADE_PUB_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadOtherTradePubInfos(OTHER_TRADE_PUB_INFO model, SearchCondition condition)
        {
            var result = Fw.OtherTradePubInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取OTHER_TRADE_PUB_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadOtherTradePubInfo(decimal M_ID)
        
        {
            var result = Fw.OtherTradePubInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建OTHER_TRADE_PUB_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateOtherTradePubInfo(OTHER_TRADE_PUB_INFO model)
        {
            var result = Fw.OtherTradePubInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新OTHER_TRADE_PUB_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateOtherTradePubInfo(OTHER_TRADE_PUB_INFO model)
        {
            var result = Fw.OtherTradePubInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除OTHER_TRADE_PUB_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteOtherTradePubInfo(string ids)
        {
            var result = Fw.OtherTradePubInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}