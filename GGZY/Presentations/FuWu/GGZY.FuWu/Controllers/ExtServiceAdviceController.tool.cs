using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdExtServiceAdviceController:BaseController
    {
        /// <summary>
        /// 读取EXT_SERVICE_ADVICE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadExtServiceAdvices(EXT_SERVICE_ADVICE model, SearchCondition condition)
        {
            var result = Fw.ExtServiceAdviceService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取EXT_SERVICE_ADVICE明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadExtServiceAdvice(decimal ID)
        
        {
            var result = Fw.ExtServiceAdviceService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建EXT_SERVICE_ADVICE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateExtServiceAdvice(EXT_SERVICE_ADVICE model)
        {
            var result = Fw.ExtServiceAdviceService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新EXT_SERVICE_ADVICE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateExtServiceAdvice(EXT_SERVICE_ADVICE model)
        {
            var result = Fw.ExtServiceAdviceService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除EXT_SERVICE_ADVICE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteExtServiceAdvice(string ids)
        {
            var result = Fw.ExtServiceAdviceService.Delete(ids);
            return JResult(result); 
        }
    }
}