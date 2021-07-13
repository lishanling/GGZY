using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdContractPerformanceController:BaseController
    {
        /// <summary>
        /// 读取CONTRACT_PERFORMANCE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadContractPerformances(CONTRACT_PERFORMANCE model, SearchCondition condition)
        {
            var result = Fw.ContractPerformanceService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取CONTRACT_PERFORMANCE明细
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadContractPerformance(decimal M_ID)
        
        {
            var result = Fw.ContractPerformanceService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建CONTRACT_PERFORMANCE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateContractPerformance(CONTRACT_PERFORMANCE model)
        {
            var result = Fw.ContractPerformanceService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新CONTRACT_PERFORMANCE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateContractPerformance(CONTRACT_PERFORMANCE model)
        {
            var result = Fw.ContractPerformanceService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除CONTRACT_PERFORMANCE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteContractPerformance(string ids)
        {
            var result = Fw.ContractPerformanceService.Delete(ids);
            return JResult(result); 
        }
    }
}