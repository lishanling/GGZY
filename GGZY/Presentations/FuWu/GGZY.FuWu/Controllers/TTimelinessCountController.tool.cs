using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTTimelinessCountController:BaseController
    {
        /// <summary>
        /// 读取T_TIMELINESS_COUNT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTTimelinessCounts(T_TIMELINESS_COUNT model, SearchCondition condition)
        {
            var result = Fw.TTimelinessCountService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_TIMELINESS_COUNT明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTTimelinessCount(decimal ID)
        
        {
            var result = Fw.TTimelinessCountService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_TIMELINESS_COUNT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTTimelinessCount(T_TIMELINESS_COUNT model)
        {
            var result = Fw.TTimelinessCountService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_TIMELINESS_COUNT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTTimelinessCount(T_TIMELINESS_COUNT model)
        {
            var result = Fw.TTimelinessCountService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_TIMELINESS_COUNT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTTimelinessCount(string ids)
        {
            var result = Fw.TTimelinessCountService.Delete(ids);
            return JResult(result); 
        }
    }
}