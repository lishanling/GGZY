using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTenderCandidateAnnounceController:BaseController
    {
        /// <summary>
        /// 读取TENDER_CANDIDATE_ANNOUNCE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTenderCandidateAnnounces(TENDER_CANDIDATE_ANNOUNCE model, SearchCondition condition)
        {
            var result = Fw.TenderCandidateAnnounceService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TENDER_CANDIDATE_ANNOUNCE明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTenderCandidateAnnounce(decimal M_ID)
        
        {
            var result = Fw.TenderCandidateAnnounceService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TENDER_CANDIDATE_ANNOUNCE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTenderCandidateAnnounce(TENDER_CANDIDATE_ANNOUNCE model)
        {
            var result = Fw.TenderCandidateAnnounceService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TENDER_CANDIDATE_ANNOUNCE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTenderCandidateAnnounce(TENDER_CANDIDATE_ANNOUNCE model)
        {
            var result = Fw.TenderCandidateAnnounceService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TENDER_CANDIDATE_ANNOUNCE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTenderCandidateAnnounce(string ids)
        {
            var result = Fw.TenderCandidateAnnounceService.Delete(ids);
            return JResult(result); 
        }
    }
}