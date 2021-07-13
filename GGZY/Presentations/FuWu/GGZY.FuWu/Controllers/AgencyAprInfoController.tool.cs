using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdAgencyAprInfoController:BaseController
    {
        /// <summary>
        /// 读取AGENCY_APR_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadAgencyAprInfos(AGENCY_APR_INFO model, SearchCondition condition)
        {
            var result = Fw.AgencyAprInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取AGENCY_APR_INFO明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadAgencyAprInfo(decimal ID)
        
        {
            var result = Fw.AgencyAprInfoService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建AGENCY_APR_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateAgencyAprInfo(AGENCY_APR_INFO model)
        {
            var result = Fw.AgencyAprInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新AGENCY_APR_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateAgencyAprInfo(AGENCY_APR_INFO model)
        {
            var result = Fw.AgencyAprInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除AGENCY_APR_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteAgencyAprInfo(string ids)
        {
            var result = Fw.AgencyAprInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}