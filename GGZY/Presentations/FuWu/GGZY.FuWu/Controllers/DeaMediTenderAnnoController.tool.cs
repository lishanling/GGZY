using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediTenderAnnoController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_TENDER_ANNO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediTenderAnnos(DEA_MEDI_TENDER_ANNO model, SearchCondition condition)
        {
            var result = Fw.DeaMediTenderAnnoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_TENDER_ANNO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediTenderAnno(decimal M_ID)
        
        {
            var result = Fw.DeaMediTenderAnnoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_TENDER_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediTenderAnno(DEA_MEDI_TENDER_ANNO model)
        {
            var result = Fw.DeaMediTenderAnnoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_TENDER_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediTenderAnno(DEA_MEDI_TENDER_ANNO model)
        {
            var result = Fw.DeaMediTenderAnnoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_TENDER_ANNO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediTenderAnno(string ids)
        {
            var result = Fw.DeaMediTenderAnnoService.Delete(ids);
            return JResult(result); 
        }
    }
}