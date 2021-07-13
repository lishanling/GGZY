using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
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
            var result = Jd.TMessageService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_MESSAGE明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTMessage(decimal ID)
        
        {
            var result = Jd.TMessageService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_MESSAGE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTMessage(T_MESSAGE model)
        {
            var result = Jd.TMessageService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_MESSAGE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTMessage(T_MESSAGE model)
        {
            var result = Jd.TMessageService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_MESSAGE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTMessage(string ids)
        {
            var result = Jd.TMessageService.Delete(ids);
            return JResult(result); 
        }
    }
}