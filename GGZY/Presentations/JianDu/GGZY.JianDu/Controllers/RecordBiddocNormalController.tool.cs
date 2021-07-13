using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdRecordBiddocNormalController:BaseController
    {
        /// <summary>
        /// 读取RECORD_BIDDOC_NORMAL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadRecordBiddocNormals(RECORD_BIDDOC_NORMAL model, SearchCondition condition)
        {
            var result = Jd.RecordBiddocNormalService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取RECORD_BIDDOC_NORMAL明细
        /// </summary>
      /// <param name="RECORD_ID">备案主表ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadRecordBiddocNormal(decimal RECORD_ID)
        
        {
            var result = Jd.RecordBiddocNormalService.ViewByPk(RECORD_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建RECORD_BIDDOC_NORMAL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateRecordBiddocNormal(RECORD_BIDDOC_NORMAL model)
        {
            var result = Jd.RecordBiddocNormalService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新RECORD_BIDDOC_NORMAL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateRecordBiddocNormal(RECORD_BIDDOC_NORMAL model)
        {
            var result = Jd.RecordBiddocNormalService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除RECORD_BIDDOC_NORMAL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteRecordBiddocNormal(string ids)
        {
            var result = Jd.RecordBiddocNormalService.Delete(ids);
            return JResult(result); 
        }
    }
}