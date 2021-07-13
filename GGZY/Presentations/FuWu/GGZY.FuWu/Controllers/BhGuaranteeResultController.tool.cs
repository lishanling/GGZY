using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdBhGuaranteeResultController:BaseController
    {
        /// <summary>
        /// 读取BH_GUARANTEE_RESULT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadBhGuaranteeResults(BH_GUARANTEE_RESULT model, SearchCondition condition)
        {
            var result = Fw.BhGuaranteeResultService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取BH_GUARANTEE_RESULT明细
        /// </summary>
      /// <param name="ID">自增长</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadBhGuaranteeResult(decimal ID)
        
        {
            var result = Fw.BhGuaranteeResultService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建BH_GUARANTEE_RESULT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateBhGuaranteeResult(BH_GUARANTEE_RESULT model)
        {
            var result = Fw.BhGuaranteeResultService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新BH_GUARANTEE_RESULT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateBhGuaranteeResult(BH_GUARANTEE_RESULT model)
        {
            var result = Fw.BhGuaranteeResultService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除BH_GUARANTEE_RESULT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteBhGuaranteeResult(string ids)
        {
            var result = Fw.BhGuaranteeResultService.Delete(ids);
            return JResult(result); 
        }
    }
}