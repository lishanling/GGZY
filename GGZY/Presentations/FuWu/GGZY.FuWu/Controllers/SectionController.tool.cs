using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSectionController:BaseController
    {
        /// <summary>
        /// 读取SECTION列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSections(SECTION model, SearchCondition condition)
        {
            var result = Fw.SectionService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SECTION明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSection(decimal M_ID)
        
        {
            var result = Fw.SectionService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SECTION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSection(SECTION model)
        {
            var result = Fw.SectionService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SECTION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSection(SECTION model)
        {
            var result = Fw.SectionService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SECTION信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSection(string ids)
        {
            var result = Fw.SectionService.Delete(ids);
            return JResult(result); 
        }
    }
}