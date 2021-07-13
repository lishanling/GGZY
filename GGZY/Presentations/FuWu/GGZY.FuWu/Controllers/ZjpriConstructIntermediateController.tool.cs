using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdZjpriConstructIntermediateController:BaseController
    {
        /// <summary>
        /// 读取ZJPRI_CONSTRUCT_INTERMEDIATE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadZjpriConstructIntermediates(ZJPRI_CONSTRUCT_INTERMEDIATE model, SearchCondition condition)
        {
            var result = Fw.ZjpriConstructIntermediateService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ZJPRI_CONSTRUCT_INTERMEDIATE明细
        /// </summary>
      /// <param name="TITLEPERSONID">职称人员ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadZjpriConstructIntermediate(decimal TITLEPERSONID)
        
        {
            var result = Fw.ZjpriConstructIntermediateService.ViewByPk(TITLEPERSONID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ZJPRI_CONSTRUCT_INTERMEDIATE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateZjpriConstructIntermediate(ZJPRI_CONSTRUCT_INTERMEDIATE model)
        {
            var result = Fw.ZjpriConstructIntermediateService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ZJPRI_CONSTRUCT_INTERMEDIATE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateZjpriConstructIntermediate(ZJPRI_CONSTRUCT_INTERMEDIATE model)
        {
            var result = Fw.ZjpriConstructIntermediateService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ZJPRI_CONSTRUCT_INTERMEDIATE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteZjpriConstructIntermediate(string ids)
        {
            var result = Fw.ZjpriConstructIntermediateService.Delete(ids);
            return JResult(result); 
        }
    }
}