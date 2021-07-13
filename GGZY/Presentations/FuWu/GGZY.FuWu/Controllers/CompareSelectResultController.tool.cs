using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdCompareSelectResultController:BaseController
    {
        /// <summary>
        /// 读取COMPARE_SELECT_RESULT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadCompareSelectResults(COMPARE_SELECT_RESULT model, SearchCondition condition)
        {
            var result = Fw.CompareSelectResultService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取COMPARE_SELECT_RESULT明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadCompareSelectResult(decimal M_ID)
        
        {
            var result = Fw.CompareSelectResultService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建COMPARE_SELECT_RESULT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateCompareSelectResult(COMPARE_SELECT_RESULT model)
        {
            var result = Fw.CompareSelectResultService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新COMPARE_SELECT_RESULT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateCompareSelectResult(COMPARE_SELECT_RESULT model)
        {
            var result = Fw.CompareSelectResultService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除COMPARE_SELECT_RESULT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteCompareSelectResult(string ids)
        {
            var result = Fw.CompareSelectResultService.Delete(ids);
            return JResult(result); 
        }
    }
}