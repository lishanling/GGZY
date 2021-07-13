using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTAskanswerController:BaseController
    {
        /// <summary>
        /// 读取T_ASKANSWER列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTAskanswers(T_ASKANSWER model, SearchCondition condition)
        {
            var result = Fw.TAskanswerService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_ASKANSWER明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTAskanswer(decimal ID)
        
        {
            var result = Fw.TAskanswerService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_ASKANSWER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTAskanswer(T_ASKANSWER model)
        {
            var result = Fw.TAskanswerService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_ASKANSWER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTAskanswer(T_ASKANSWER model)
        {
            var result = Fw.TAskanswerService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_ASKANSWER信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTAskanswer(string ids)
        {
            var result = Fw.TAskanswerService.Delete(ids);
            return JResult(result); 
        }
    }
}