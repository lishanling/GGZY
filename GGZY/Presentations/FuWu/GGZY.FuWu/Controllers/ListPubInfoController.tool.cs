using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdListPubInfoController:BaseController
    {
        /// <summary>
        /// 读取LIST_PUB_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadListPubInfos(LIST_PUB_INFO model, SearchCondition condition)
        {
            var result = Fw.ListPubInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取LIST_PUB_INFO明细
        /// </summary>
      /// <param name="PROJECT_CODE">项目编号</param>
      /// <param name="SELLER_CODE">转让方代码</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadListPubInfo(string PROJECT_CODE,string SELLER_CODE)
        
        {
            var result = Fw.ListPubInfoService.ViewByPk(PROJECT_CODE,SELLER_CODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建LIST_PUB_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateListPubInfo(LIST_PUB_INFO model)
        {
            var result = Fw.ListPubInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新LIST_PUB_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateListPubInfo(LIST_PUB_INFO model)
        {
            var result = Fw.ListPubInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除LIST_PUB_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteListPubInfo(string ids)
        {
            var result = Fw.ListPubInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}