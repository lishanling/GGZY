using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTenderProjectGdController:BaseController
    {
        /// <summary>
        /// 读取TENDER_PROJECT_GD列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTenderProjectGds(TENDER_PROJECT_GD model, SearchCondition condition)
        {
            var result = Fw.TenderProjectGdService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TENDER_PROJECT_GD明细
        /// </summary>
      /// <param name="CODE"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTenderProjectGd(string CODE)
        
        {
            var result = Fw.TenderProjectGdService.ViewByPk(CODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建TENDER_PROJECT_GD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTenderProjectGd(TENDER_PROJECT_GD model)
        {
            var result = Fw.TenderProjectGdService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TENDER_PROJECT_GD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTenderProjectGd(TENDER_PROJECT_GD model)
        {
            var result = Fw.TenderProjectGdService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TENDER_PROJECT_GD信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTenderProjectGd(string ids)
        {
            var result = Fw.TenderProjectGdService.Delete(ids);
            return JResult(result); 
        }
    }
}