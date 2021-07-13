using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdIndividualSupplierExInfoController:BaseController
    {
        /// <summary>
        /// 读取INDIVIDUAL_SUPPLIER_EX_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadIndividualSupplierExInfos(INDIVIDUAL_SUPPLIER_EX_INFO model, SearchCondition condition)
        {
            var result = Fw.IndividualSupplierExInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取INDIVIDUAL_SUPPLIER_EX_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadIndividualSupplierExInfo(decimal M_ID)
        
        {
            var result = Fw.IndividualSupplierExInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建INDIVIDUAL_SUPPLIER_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateIndividualSupplierExInfo(INDIVIDUAL_SUPPLIER_EX_INFO model)
        {
            var result = Fw.IndividualSupplierExInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新INDIVIDUAL_SUPPLIER_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateIndividualSupplierExInfo(INDIVIDUAL_SUPPLIER_EX_INFO model)
        {
            var result = Fw.IndividualSupplierExInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除INDIVIDUAL_SUPPLIER_EX_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteIndividualSupplierExInfo(string ids)
        {
            var result = Fw.IndividualSupplierExInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}