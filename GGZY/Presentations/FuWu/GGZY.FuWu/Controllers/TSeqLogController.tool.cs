using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTSeqLogController:BaseController
    {
        /// <summary>
        /// 读取T_SEQ_LOG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTSeqLogs(T_SEQ_LOG model, SearchCondition condition)
        {
            var result = Fw.TSeqLogService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_SEQ_LOG明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTSeqLog(decimal ID)
        
        {
            var result = Fw.TSeqLogService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_SEQ_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTSeqLog(T_SEQ_LOG model)
        {
            var result = Fw.TSeqLogService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_SEQ_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTSeqLog(T_SEQ_LOG model)
        {
            var result = Fw.TSeqLogService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_SEQ_LOG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTSeqLog(string ids)
        {
            var result = Fw.TSeqLogService.Delete(ids);
            return JResult(result); 
        }
    }
}