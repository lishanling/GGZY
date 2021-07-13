using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTenderFileClariModiController:BaseController
    {
        /// <summary>
        /// 读取TENDER_FILE_CLARI_MODI列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTenderFileClariModis(TENDER_FILE_CLARI_MODI model, SearchCondition condition)
        {
            var result = Fw.TenderFileClariModiService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TENDER_FILE_CLARI_MODI明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTenderFileClariModi(decimal M_ID)
        
        {
            var result = Fw.TenderFileClariModiService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TENDER_FILE_CLARI_MODI信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTenderFileClariModi(TENDER_FILE_CLARI_MODI model)
        {
            var result = Fw.TenderFileClariModiService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TENDER_FILE_CLARI_MODI信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTenderFileClariModi(TENDER_FILE_CLARI_MODI model)
        {
            var result = Fw.TenderFileClariModiService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TENDER_FILE_CLARI_MODI信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTenderFileClariModi(string ids)
        {
            var result = Fw.TenderFileClariModiService.Delete(ids);
            return JResult(result); 
        }
    }
}