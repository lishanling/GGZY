using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaCarbonQuotaSellAnnoController:BaseController
    {
        /// <summary>
        /// 读取DEA_CARBON_QUOTA_SELL_ANNO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaCarbonQuotaSellAnnos(DEA_CARBON_QUOTA_SELL_ANNO model, SearchCondition condition)
        {
            var result = Fw.DeaCarbonQuotaSellAnnoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_CARBON_QUOTA_SELL_ANNO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaCarbonQuotaSellAnno(decimal M_ID)
        
        {
            var result = Fw.DeaCarbonQuotaSellAnnoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_CARBON_QUOTA_SELL_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaCarbonQuotaSellAnno(DEA_CARBON_QUOTA_SELL_ANNO model)
        {
            var result = Fw.DeaCarbonQuotaSellAnnoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_CARBON_QUOTA_SELL_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaCarbonQuotaSellAnno(DEA_CARBON_QUOTA_SELL_ANNO model)
        {
            var result = Fw.DeaCarbonQuotaSellAnnoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_CARBON_QUOTA_SELL_ANNO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaCarbonQuotaSellAnno(string ids)
        {
            var result = Fw.DeaCarbonQuotaSellAnnoService.Delete(ids);
            return JResult(result); 
        }
    }
}