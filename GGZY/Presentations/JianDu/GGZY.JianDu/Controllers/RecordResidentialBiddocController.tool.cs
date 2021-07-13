using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdRecordResidentialBiddocController:BaseController
    {
        /// <summary>
        /// 读取RECORD_RESIDENTIAL_BIDDOC列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadRecordResidentialBiddocs(RECORD_RESIDENTIAL_BIDDOC model, SearchCondition condition)
        {
            var result = Jd.RecordResidentialBiddocService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取RECORD_RESIDENTIAL_BIDDOC明细
        /// </summary>
      /// <param name="RECORD_ID">备案主表ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadRecordResidentialBiddoc(decimal RECORD_ID)
        
        {
            var result = Jd.RecordResidentialBiddocService.ViewByPk(RECORD_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建RECORD_RESIDENTIAL_BIDDOC信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateRecordResidentialBiddoc(RECORD_RESIDENTIAL_BIDDOC model)
        {
            var result = Jd.RecordResidentialBiddocService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新RECORD_RESIDENTIAL_BIDDOC信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateRecordResidentialBiddoc(RECORD_RESIDENTIAL_BIDDOC model)
        {
            var result = Jd.RecordResidentialBiddocService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除RECORD_RESIDENTIAL_BIDDOC信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteRecordResidentialBiddoc(string ids)
        {
            var result = Jd.RecordResidentialBiddocService.Delete(ids);
            return JResult(result); 
        }
    }
}