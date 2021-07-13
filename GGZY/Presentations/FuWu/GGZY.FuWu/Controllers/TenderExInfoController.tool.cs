using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTenderExInfoController:BaseController
    {
        /// <summary>
        /// 读取TENDER_EX_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTenderExInfos(TENDER_EX_INFO model, SearchCondition condition)
        {
            var result = Fw.TenderExInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TENDER_EX_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTenderExInfo(decimal M_ID)
        
        {
            var result = Fw.TenderExInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TENDER_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTenderExInfo(TENDER_EX_INFO model)
        {
            var result = Fw.TenderExInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TENDER_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTenderExInfo(TENDER_EX_INFO model)
        {
            var result = Fw.TenderExInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TENDER_EX_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTenderExInfo(string ids)
        {
            var result = Fw.TenderExInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}