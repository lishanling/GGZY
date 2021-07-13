using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdTenderProjectController:BaseController
    {
        /// <summary>
        /// 读取TENDER_PROJECT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTenderProjects(TENDER_PROJECT model, SearchCondition condition)
        {
            var result = Jd.TenderProjectService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TENDER_PROJECT明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTenderProject(decimal M_ID)
        
        {
            var result = Jd.TenderProjectService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TENDER_PROJECT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTenderProject(TENDER_PROJECT model)
        {
            var result = Jd.TenderProjectService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TENDER_PROJECT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTenderProject(TENDER_PROJECT model)
        {
            var result = Jd.TenderProjectService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TENDER_PROJECT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTenderProject(string ids)
        {
            var result = Jd.TenderProjectService.Delete(ids);
            return JResult(result); 
        }
    }
}