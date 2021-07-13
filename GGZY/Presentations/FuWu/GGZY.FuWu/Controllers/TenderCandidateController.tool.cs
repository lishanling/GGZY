using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTenderCandidateController:BaseController
    {
        /// <summary>
        /// 读取TENDER_CANDIDATE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTenderCandidates(TENDER_CANDIDATE model, SearchCondition condition)
        {
            var result = Fw.TenderCandidateService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TENDER_CANDIDATE明细
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTenderCandidate(decimal M_ID)
        
        {
            var result = Fw.TenderCandidateService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TENDER_CANDIDATE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTenderCandidate(TENDER_CANDIDATE model)
        {
            var result = Fw.TenderCandidateService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TENDER_CANDIDATE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTenderCandidate(TENDER_CANDIDATE model)
        {
            var result = Fw.TenderCandidateService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TENDER_CANDIDATE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTenderCandidate(string ids)
        {
            var result = Fw.TenderCandidateService.Delete(ids);
            return JResult(result); 
        }
    }
}