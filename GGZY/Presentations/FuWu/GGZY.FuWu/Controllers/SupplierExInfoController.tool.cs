using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSupplierExInfoController:BaseController
    {
        /// <summary>
        /// 读取SUPPLIER_EX_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSupplierExInfos(SUPPLIER_EX_INFO model, SearchCondition condition)
        {
            var result = Fw.SupplierExInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SUPPLIER_EX_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSupplierExInfo(decimal M_ID)
        
        {
            var result = Fw.SupplierExInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SUPPLIER_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSupplierExInfo(SUPPLIER_EX_INFO model)
        {
            var result = Fw.SupplierExInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SUPPLIER_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSupplierExInfo(SUPPLIER_EX_INFO model)
        {
            var result = Fw.SupplierExInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SUPPLIER_EX_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSupplierExInfo(string ids)
        {
            var result = Fw.SupplierExInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}