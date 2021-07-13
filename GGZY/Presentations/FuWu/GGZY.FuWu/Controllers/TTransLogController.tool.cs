using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTTransLogController:BaseController
    {
        /// <summary>
        /// 读取T_TRANS_LOG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTTransLogs(T_TRANS_LOG model, SearchCondition condition)
        {
            var result = Fw.TTransLogService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_TRANS_LOG明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTTransLog(decimal ID)
        
        {
            var result = Fw.TTransLogService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_TRANS_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTTransLog(T_TRANS_LOG model)
        {
            var result = Fw.TTransLogService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_TRANS_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTTransLog(T_TRANS_LOG model)
        {
            var result = Fw.TTransLogService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_TRANS_LOG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTTransLog(string ids)
        {
            var result = Fw.TTransLogService.Delete(ids);
            return JResult(result); 
        }
    }
}