using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTSysMessageController:BaseController
    {
        /// <summary>
        /// 读取T_SYS_MESSAGE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTSysMessages(T_SYS_MESSAGE model, SearchCondition condition)
        {
            var result = Fw.TSysMessageService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_SYS_MESSAGE明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTSysMessage(decimal ID)
        
        {
            var result = Fw.TSysMessageService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_SYS_MESSAGE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTSysMessage(T_SYS_MESSAGE model)
        {
            var result = Fw.TSysMessageService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_SYS_MESSAGE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTSysMessage(T_SYS_MESSAGE model)
        {
            var result = Fw.TSysMessageService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_SYS_MESSAGE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTSysMessage(string ids)
        {
            var result = Fw.TSysMessageService.Delete(ids);
            return JResult(result); 
        }
    }
}