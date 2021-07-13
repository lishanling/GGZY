using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdRecordContractController:BaseController
    {
        /// <summary>
        /// 读取RECORD_CONTRACT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadRecordContracts(RECORD_CONTRACT model, SearchCondition condition)
        {
            var result = Jd.RecordContractService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取RECORD_CONTRACT明细
        /// </summary>
      /// <param name="RECORD_ID">备案主表ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadRecordContract(decimal RECORD_ID)
        
        {
            var result = Jd.RecordContractService.ViewByPk(RECORD_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建RECORD_CONTRACT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateRecordContract(RECORD_CONTRACT model)
        {
            var result = Jd.RecordContractService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新RECORD_CONTRACT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateRecordContract(RECORD_CONTRACT model)
        {
            var result = Jd.RecordContractService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除RECORD_CONTRACT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteRecordContract(string ids)
        {
            var result = Jd.RecordContractService.Delete(ids);
            return JResult(result); 
        }
    }
}