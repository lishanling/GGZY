using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTMessageTextController:BaseController
    {
        /// <summary>
        /// 读取T_MESSAGE_TEXT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTMessageTexts(T_MESSAGE_TEXT model, SearchCondition condition)
        {
            var result = Fw.TMessageTextService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_MESSAGE_TEXT明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTMessageText(decimal ID)
        
        {
            var result = Fw.TMessageTextService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_MESSAGE_TEXT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTMessageText(T_MESSAGE_TEXT model)
        {
            var result = Fw.TMessageTextService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_MESSAGE_TEXT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTMessageText(T_MESSAGE_TEXT model)
        {
            var result = Fw.TMessageTextService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_MESSAGE_TEXT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTMessageText(string ids)
        {
            var result = Fw.TMessageTextService.Delete(ids);
            return JResult(result); 
        }
    }
}