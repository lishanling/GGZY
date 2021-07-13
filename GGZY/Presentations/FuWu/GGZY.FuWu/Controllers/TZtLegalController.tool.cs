using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTZtLegalController:BaseController
    {
        /// <summary>
        /// 读取T_ZT_LEGAL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTZtLegals(T_ZT_LEGAL model, SearchCondition condition)
        {
            var result = Fw.TZtLegalService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_ZT_LEGAL明细
        /// </summary>
      /// <param name="LEGALNO">主体代码</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTZtLegal(string LEGALNO)
        
        {
            var result = Fw.TZtLegalService.ViewByPk(LEGALNO);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_ZT_LEGAL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTZtLegal(T_ZT_LEGAL model)
        {
            var result = Fw.TZtLegalService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_ZT_LEGAL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTZtLegal(T_ZT_LEGAL model)
        {
            var result = Fw.TZtLegalService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_ZT_LEGAL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTZtLegal(string ids)
        {
            var result = Fw.TZtLegalService.Delete(ids);
            return JResult(result); 
        }
    }
}