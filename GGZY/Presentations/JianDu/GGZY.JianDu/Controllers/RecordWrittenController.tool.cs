using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdRecordWrittenController:BaseController
    {
        /// <summary>
        /// 读取RECORD_WRITTEN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadRecordWrittens(RECORD_WRITTEN model, SearchCondition condition)
        {
            var result = Jd.RecordWrittenService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取RECORD_WRITTEN明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadRecordWritten(decimal ID)
        
        {
            var result = Jd.RecordWrittenService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建RECORD_WRITTEN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateRecordWritten(RECORD_WRITTEN model)
        {
            var result = Jd.RecordWrittenService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新RECORD_WRITTEN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateRecordWritten(RECORD_WRITTEN model)
        {
            var result = Jd.RecordWrittenService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除RECORD_WRITTEN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteRecordWritten(string ids)
        {
            var result = Jd.RecordWrittenService.Delete(ids);
            return JResult(result); 
        }
    }
}