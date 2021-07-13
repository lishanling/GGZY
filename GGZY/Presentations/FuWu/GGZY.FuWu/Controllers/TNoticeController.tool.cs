using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTNoticeController:BaseController
    {
        /// <summary>
        /// 读取T_NOTICE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTNotices(T_NOTICE model, SearchCondition condition)
        {
            var result = Fw.TNoticeService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_NOTICE明细
        /// </summary>
      /// <param name="ID">编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTNotice(decimal ID)
        
        {
            var result = Fw.TNoticeService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_NOTICE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTNotice(T_NOTICE model)
        {
            var result = Fw.TNoticeService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_NOTICE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTNotice(T_NOTICE model)
        {
            var result = Fw.TNoticeService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_NOTICE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTNotice(string ids)
        {
            var result = Fw.TNoticeService.Delete(ids);
            return JResult(result); 
        }
    }
}