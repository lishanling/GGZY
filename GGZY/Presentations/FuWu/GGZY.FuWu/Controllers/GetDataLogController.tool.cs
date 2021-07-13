using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdGetDataLogController:BaseController
    {
        /// <summary>
        /// 读取GET_DATA_LOG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadGetDataLogs(GET_DATA_LOG model, SearchCondition condition)
        {
            var result = Fw.GetDataLogService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取GET_DATA_LOG明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadGetDataLog(string ID)
        
        {
            var result = Fw.GetDataLogService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建GET_DATA_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateGetDataLog(GET_DATA_LOG model)
        {
            var result = Fw.GetDataLogService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新GET_DATA_LOG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateGetDataLog(GET_DATA_LOG model)
        {
            var result = Fw.GetDataLogService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除GET_DATA_LOG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteGetDataLog(string ids)
        {
            var result = Fw.GetDataLogService.Delete(ids);
            return JResult(result); 
        }
    }
}