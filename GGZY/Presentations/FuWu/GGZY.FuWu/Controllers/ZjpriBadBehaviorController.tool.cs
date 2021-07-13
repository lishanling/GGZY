using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdZjpriBadBehaviorController:BaseController
    {
        /// <summary>
        /// 读取ZJPRI_BAD_BEHAVIOR列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadZjpriBadBehaviors(ZJPRI_BAD_BEHAVIOR model, SearchCondition condition)
        {
            var result = Fw.ZjpriBadBehaviorService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ZJPRI_BAD_BEHAVIOR明细
        /// </summary>
      /// <param name="UK_ID">唯一标识码</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadZjpriBadBehavior(string UK_ID)
        
        {
            var result = Fw.ZjpriBadBehaviorService.ViewByPk(UK_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ZJPRI_BAD_BEHAVIOR信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateZjpriBadBehavior(ZJPRI_BAD_BEHAVIOR model)
        {
            var result = Fw.ZjpriBadBehaviorService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ZJPRI_BAD_BEHAVIOR信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateZjpriBadBehavior(ZJPRI_BAD_BEHAVIOR model)
        {
            var result = Fw.ZjpriBadBehaviorService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ZJPRI_BAD_BEHAVIOR信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteZjpriBadBehavior(string ids)
        {
            var result = Fw.ZjpriBadBehaviorService.Delete(ids);
            return JResult(result); 
        }
    }
}