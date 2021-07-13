using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdRecordHandleResultController:BaseController
    {
        /// <summary>
        /// 读取RECORD_HANDLE_RESULT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadRecordHandleResults(RECORD_HANDLE_RESULT model, SearchCondition condition)
        {
            var result = Jd.RecordHandleResultService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取RECORD_HANDLE_RESULT明细
        /// </summary>
      /// <param name="RECORD_ID">备案主表ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadRecordHandleResult(decimal RECORD_ID)
        
        {
            var result = Jd.RecordHandleResultService.ViewByPk(RECORD_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建RECORD_HANDLE_RESULT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateRecordHandleResult(RECORD_HANDLE_RESULT model)
        {
            var result = Jd.RecordHandleResultService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新RECORD_HANDLE_RESULT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateRecordHandleResult(RECORD_HANDLE_RESULT model)
        {
            var result = Jd.RecordHandleResultService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除RECORD_HANDLE_RESULT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteRecordHandleResult(string ids)
        {
            var result = Jd.RecordHandleResultService.Delete(ids);
            return JResult(result); 
        }
    }
}