using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdIndividualSuppplierExInfoController:BaseController
    {
        /// <summary>
        /// 读取INDIVIDUAL_SUPPPLIER_EX_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadIndividualSuppplierExInfos(INDIVIDUAL_SUPPPLIER_EX_INFO model, SearchCondition condition)
        {
            var result = Fw.IndividualSuppplierExInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取INDIVIDUAL_SUPPPLIER_EX_INFO明细
        /// </summary>
      /// <param name="LEGAL_CODE">主体代码</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadIndividualSuppplierExInfo(string LEGAL_CODE)
        
        {
            var result = Fw.IndividualSuppplierExInfoService.ViewByPk(LEGAL_CODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建INDIVIDUAL_SUPPPLIER_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateIndividualSuppplierExInfo(INDIVIDUAL_SUPPPLIER_EX_INFO model)
        {
            var result = Fw.IndividualSuppplierExInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新INDIVIDUAL_SUPPPLIER_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateIndividualSuppplierExInfo(INDIVIDUAL_SUPPPLIER_EX_INFO model)
        {
            var result = Fw.IndividualSuppplierExInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除INDIVIDUAL_SUPPPLIER_EX_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteIndividualSuppplierExInfo(string ids)
        {
            var result = Fw.IndividualSuppplierExInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}