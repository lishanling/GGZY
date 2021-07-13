using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPerformanceInfoController:BaseController
    {
        /// <summary>
        /// 读取PERFORMANCE_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPerformanceInfos(PERFORMANCE_INFO model, SearchCondition condition)
        {
            var result = Fw.PerformanceInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PERFORMANCE_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPerformanceInfo(decimal M_ID)
        
        {
            var result = Fw.PerformanceInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PERFORMANCE_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePerformanceInfo(PERFORMANCE_INFO model)
        {
            var result = Fw.PerformanceInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PERFORMANCE_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePerformanceInfo(PERFORMANCE_INFO model)
        {
            var result = Fw.PerformanceInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PERFORMANCE_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePerformanceInfo(string ids)
        {
            var result = Fw.PerformanceInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}