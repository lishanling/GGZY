using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTheEelRowResultController:BaseController
    {
        /// <summary>
        /// 读取THE_EEL_ROW_RESULT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTheEelRowResults(THE_EEL_ROW_RESULT model, SearchCondition condition)
        {
            var result = Fw.TheEelRowResultService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取THE_EEL_ROW_RESULT明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTheEelRowResult(decimal ID)
        
        {
            var result = Fw.TheEelRowResultService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建THE_EEL_ROW_RESULT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTheEelRowResult(THE_EEL_ROW_RESULT model)
        {
            var result = Fw.TheEelRowResultService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新THE_EEL_ROW_RESULT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTheEelRowResult(THE_EEL_ROW_RESULT model)
        {
            var result = Fw.TheEelRowResultService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除THE_EEL_ROW_RESULT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTheEelRowResult(string ids)
        {
            var result = Fw.TheEelRowResultService.Delete(ids);
            return JResult(result); 
        }
    }
}