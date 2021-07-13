using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdCorrectionItemController:BaseController
    {
        /// <summary>
        /// 读取CORRECTION_ITEM列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadCorrectionItems(CORRECTION_ITEM model, SearchCondition condition)
        {
            var result = Fw.CorrectionItemService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取CORRECTION_ITEM明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadCorrectionItem(decimal M_ID)
        
        {
            var result = Fw.CorrectionItemService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建CORRECTION_ITEM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateCorrectionItem(CORRECTION_ITEM model)
        {
            var result = Fw.CorrectionItemService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新CORRECTION_ITEM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateCorrectionItem(CORRECTION_ITEM model)
        {
            var result = Fw.CorrectionItemService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除CORRECTION_ITEM信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteCorrectionItem(string ids)
        {
            var result = Fw.CorrectionItemService.Delete(ids);
            return JResult(result); 
        }
    }
}