using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdZjpriExtCompanyController:BaseController
    {
        /// <summary>
        /// 读取ZJPRI_EXT_COMPANY列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadZjpriExtCompanys(ZJPRI_EXT_COMPANY model, SearchCondition condition)
        {
            var result = Fw.ZjpriExtCompanyService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ZJPRI_EXT_COMPANY明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadZjpriExtCompany(string ID)
        
        {
            var result = Fw.ZjpriExtCompanyService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ZJPRI_EXT_COMPANY信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateZjpriExtCompany(ZJPRI_EXT_COMPANY model)
        {
            var result = Fw.ZjpriExtCompanyService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ZJPRI_EXT_COMPANY信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateZjpriExtCompany(ZJPRI_EXT_COMPANY model)
        {
            var result = Fw.ZjpriExtCompanyService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ZJPRI_EXT_COMPANY信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteZjpriExtCompany(string ids)
        {
            var result = Fw.ZjpriExtCompanyService.Delete(ids);
            return JResult(result); 
        }
    }
}