using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTMessageController:BaseController
    {
        /// <summary>
        /// 读取T_MESSAGE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTMessages(T_MESSAGE model, SearchCondition condition)
        {
            var result = Fw.TMessageService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_MESSAGE明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTMessage(decimal ID)
        
        {
            var result = Fw.TMessageService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_MESSAGE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTMessage(T_MESSAGE model)
        {
            var result = Fw.TMessageService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_MESSAGE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTMessage(T_MESSAGE model)
        {
            var result = Fw.TMessageService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_MESSAGE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTMessage(string ids)
        {
            var result = Fw.TMessageService.Delete(ids);
            return JResult(result); 
        }
    }
}