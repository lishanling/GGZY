using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdProExResultController:BaseController
    {
        /// <summary>
        /// 读取PRO_EX_RESULT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadProExResults(PRO_EX_RESULT model, SearchCondition condition)
        {
            var result = Fw.ProExResultService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PRO_EX_RESULT明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadProExResult(decimal ID)
        
        {
            var result = Fw.ProExResultService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PRO_EX_RESULT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateProExResult(PRO_EX_RESULT model)
        {
            var result = Fw.ProExResultService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PRO_EX_RESULT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateProExResult(PRO_EX_RESULT model)
        {
            var result = Fw.ProExResultService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PRO_EX_RESULT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteProExResult(string ids)
        {
            var result = Fw.ProExResultService.Delete(ids);
            return JResult(result); 
        }
    }
}