using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdZjpriGoodBehaviorController:BaseController
    {
        /// <summary>
        /// 读取ZJPRI_GOOD_BEHAVIOR列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadZjpriGoodBehaviors(ZJPRI_GOOD_BEHAVIOR model, SearchCondition condition)
        {
            var result = Fw.ZjpriGoodBehaviorService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ZJPRI_GOOD_BEHAVIOR明细
        /// </summary>
      /// <param name="UK_ID">唯一标识码</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadZjpriGoodBehavior(string UK_ID)
        
        {
            var result = Fw.ZjpriGoodBehaviorService.ViewByPk(UK_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ZJPRI_GOOD_BEHAVIOR信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateZjpriGoodBehavior(ZJPRI_GOOD_BEHAVIOR model)
        {
            var result = Fw.ZjpriGoodBehaviorService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ZJPRI_GOOD_BEHAVIOR信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateZjpriGoodBehavior(ZJPRI_GOOD_BEHAVIOR model)
        {
            var result = Fw.ZjpriGoodBehaviorService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ZJPRI_GOOD_BEHAVIOR信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteZjpriGoodBehavior(string ids)
        {
            var result = Fw.ZjpriGoodBehaviorService.Delete(ids);
            return JResult(result); 
        }
    }
}