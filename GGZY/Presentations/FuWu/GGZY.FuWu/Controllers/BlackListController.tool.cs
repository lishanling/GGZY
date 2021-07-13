using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdBlackListController:BaseController
    {
        /// <summary>
        /// 读取BLACK_LIST列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadBlackLists(BLACK_LIST model, SearchCondition condition)
        {
            var result = Fw.BlackListService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取BLACK_LIST明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadBlackList(decimal M_ID)
        
        {
            var result = Fw.BlackListService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建BLACK_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateBlackList(BLACK_LIST model)
        {
            var result = Fw.BlackListService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新BLACK_LIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateBlackList(BLACK_LIST model)
        {
            var result = Fw.BlackListService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除BLACK_LIST信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteBlackList(string ids)
        {
            var result = Fw.BlackListService.Delete(ids);
            return JResult(result); 
        }
    }
}