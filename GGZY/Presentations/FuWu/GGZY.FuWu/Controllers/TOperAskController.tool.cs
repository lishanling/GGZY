using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTOperAskController:BaseController
    {
        /// <summary>
        /// 读取T_OPER_ASK列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTOperAsks(T_OPER_ASK model, SearchCondition condition)
        {
            var result = Fw.TOperAskService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_OPER_ASK明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTOperAsk(string ID)
        
        {
            var result = Fw.TOperAskService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_OPER_ASK信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTOperAsk(T_OPER_ASK model)
        {
            var result = Fw.TOperAskService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_OPER_ASK信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTOperAsk(T_OPER_ASK model)
        {
            var result = Fw.TOperAskService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_OPER_ASK信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTOperAsk(string ids)
        {
            var result = Fw.TOperAskService.Delete(ids);
            return JResult(result); 
        }
    }
}