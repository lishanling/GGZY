using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTenderProjectDelController:BaseController
    {
        /// <summary>
        /// 读取TENDER_PROJECT_DEL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTenderProjectDels(TENDER_PROJECT_DEL model, SearchCondition condition)
        {
            var result = Fw.TenderProjectDelService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TENDER_PROJECT_DEL明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTenderProjectDel(decimal ID)
        
        {
            var result = Fw.TenderProjectDelService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TENDER_PROJECT_DEL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTenderProjectDel(TENDER_PROJECT_DEL model)
        {
            var result = Fw.TenderProjectDelService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TENDER_PROJECT_DEL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTenderProjectDel(TENDER_PROJECT_DEL model)
        {
            var result = Fw.TenderProjectDelService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TENDER_PROJECT_DEL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTenderProjectDel(string ids)
        {
            var result = Fw.TenderProjectDelService.Delete(ids);
            return JResult(result); 
        }
    }
}