using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPtLinkController:BaseController
    {
        /// <summary>
        /// 读取PT_LINK列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPtLinks(PT_LINK model, SearchCondition condition)
        {
            var result = Fw.PtLinkService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PT_LINK明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPtLink(decimal ID)
        
        {
            var result = Fw.PtLinkService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PT_LINK信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePtLink(PT_LINK model)
        {
            var result = Fw.PtLinkService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PT_LINK信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePtLink(PT_LINK model)
        {
            var result = Fw.PtLinkService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PT_LINK信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePtLink(string ids)
        {
            var result = Fw.PtLinkService.Delete(ids);
            return JResult(result); 
        }
    }
}