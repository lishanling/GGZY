using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTZtTransfereeController:BaseController
    {
        /// <summary>
        /// 读取T_ZT_TRANSFEREE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTZtTransferees(T_ZT_TRANSFEREE model, SearchCondition condition)
        {
            var result = Fw.TZtTransfereeService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_ZT_TRANSFEREE明细
        /// </summary>
      /// <param name="LEGALCODE">主体代码</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTZtTransferee(string LEGALCODE)
        
        {
            var result = Fw.TZtTransfereeService.ViewByPk(LEGALCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_ZT_TRANSFEREE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTZtTransferee(T_ZT_TRANSFEREE model)
        {
            var result = Fw.TZtTransfereeService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_ZT_TRANSFEREE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTZtTransferee(T_ZT_TRANSFEREE model)
        {
            var result = Fw.TZtTransfereeService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_ZT_TRANSFEREE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTZtTransferee(string ids)
        {
            var result = Fw.TZtTransfereeService.Delete(ids);
            return JResult(result); 
        }
    }
}