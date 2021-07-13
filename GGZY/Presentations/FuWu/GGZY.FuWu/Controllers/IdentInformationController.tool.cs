using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdIdentInformationController:BaseController
    {
        /// <summary>
        /// 读取IDENT_INFORMATION列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadIdentInformations(IDENT_INFORMATION model, SearchCondition condition)
        {
            var result = Fw.IdentInformationService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取IDENT_INFORMATION明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadIdentInformation(decimal ID)
        
        {
            var result = Fw.IdentInformationService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建IDENT_INFORMATION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateIdentInformation(IDENT_INFORMATION model)
        {
            var result = Fw.IdentInformationService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新IDENT_INFORMATION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateIdentInformation(IDENT_INFORMATION model)
        {
            var result = Fw.IdentInformationService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除IDENT_INFORMATION信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteIdentInformation(string ids)
        {
            var result = Fw.IdentInformationService.Delete(ids);
            return JResult(result); 
        }
    }
}