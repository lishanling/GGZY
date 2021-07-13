using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdRecordClassifyController:BaseController
    {
        /// <summary>
        /// 读取RECORD_CLASSIFY列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadRecordClassifys(RECORD_CLASSIFY model, SearchCondition condition)
        {
            var result = Jd.RecordClassifyService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取RECORD_CLASSIFY明细
        /// </summary>
      /// <param name="RECORD_ID">备案主表ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadRecordClassify(decimal RECORD_ID)
        
        {
            var result = Jd.RecordClassifyService.ViewByPk(RECORD_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建RECORD_CLASSIFY信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateRecordClassify(RECORD_CLASSIFY model)
        {
            var result = Jd.RecordClassifyService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新RECORD_CLASSIFY信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateRecordClassify(RECORD_CLASSIFY model)
        {
            var result = Jd.RecordClassifyService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除RECORD_CLASSIFY信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteRecordClassify(string ids)
        {
            var result = Jd.RecordClassifyService.Delete(ids);
            return JResult(result); 
        }
    }
}