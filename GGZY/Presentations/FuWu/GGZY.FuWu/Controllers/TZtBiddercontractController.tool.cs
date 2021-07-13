using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTZtBiddercontractController:BaseController
    {
        /// <summary>
        /// 读取T_ZT_BIDDERCONTRACT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTZtBiddercontracts(T_ZT_BIDDERCONTRACT model, SearchCondition condition)
        {
            var result = Fw.TZtBiddercontractService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_ZT_BIDDERCONTRACT明细
        /// </summary>
      /// <param name="BIDDERNO">主体代码</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTZtBiddercontract(string BIDDERNO)
        
        {
            var result = Fw.TZtBiddercontractService.ViewByPk(BIDDERNO);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_ZT_BIDDERCONTRACT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTZtBiddercontract(T_ZT_BIDDERCONTRACT model)
        {
            var result = Fw.TZtBiddercontractService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_ZT_BIDDERCONTRACT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTZtBiddercontract(T_ZT_BIDDERCONTRACT model)
        {
            var result = Fw.TZtBiddercontractService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_ZT_BIDDERCONTRACT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTZtBiddercontract(string ids)
        {
            var result = Fw.TZtBiddercontractService.Delete(ids);
            return JResult(result); 
        }
    }
}