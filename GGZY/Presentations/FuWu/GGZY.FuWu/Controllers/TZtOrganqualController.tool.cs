using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTZtOrganqualController:BaseController
    {
        /// <summary>
        /// 读取T_ZT_ORGANQUAL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTZtOrganquals(T_ZT_ORGANQUAL model, SearchCondition condition)
        {
            var result = Fw.TZtOrganqualService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_ZT_ORGANQUAL明细
        /// </summary>
      /// <param name="ORGANNO">主体代码</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTZtOrganqual(string ORGANNO)
        
        {
            var result = Fw.TZtOrganqualService.ViewByPk(ORGANNO);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_ZT_ORGANQUAL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTZtOrganqual(T_ZT_ORGANQUAL model)
        {
            var result = Fw.TZtOrganqualService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_ZT_ORGANQUAL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTZtOrganqual(T_ZT_ORGANQUAL model)
        {
            var result = Fw.TZtOrganqualService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_ZT_ORGANQUAL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTZtOrganqual(string ids)
        {
            var result = Fw.TZtOrganqualService.Delete(ids);
            return JResult(result); 
        }
    }
}