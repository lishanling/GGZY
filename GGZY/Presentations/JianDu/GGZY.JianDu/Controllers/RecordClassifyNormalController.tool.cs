using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdRecordClassifyNormalController:BaseController
    {
        /// <summary>
        /// 读取RECORD_CLASSIFY_NORMAL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadRecordClassifyNormals(RECORD_CLASSIFY_NORMAL model, SearchCondition condition)
        {
            var result = Jd.RecordClassifyNormalService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取RECORD_CLASSIFY_NORMAL明细
        /// </summary>
      /// <param name="RECORD_ID">备案主表ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadRecordClassifyNormal(decimal RECORD_ID)
        
        {
            var result = Jd.RecordClassifyNormalService.ViewByPk(RECORD_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建RECORD_CLASSIFY_NORMAL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateRecordClassifyNormal(RECORD_CLASSIFY_NORMAL model)
        {
            var result = Jd.RecordClassifyNormalService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新RECORD_CLASSIFY_NORMAL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateRecordClassifyNormal(RECORD_CLASSIFY_NORMAL model)
        {
            var result = Jd.RecordClassifyNormalService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除RECORD_CLASSIFY_NORMAL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteRecordClassifyNormal(string ids)
        {
            var result = Jd.RecordClassifyNormalService.Delete(ids);
            return JResult(result); 
        }
    }
}