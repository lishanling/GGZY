using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdZjpriEmployeesInfoController:BaseController
    {
        /// <summary>
        /// 读取ZJPRI_EMPLOYEES_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadZjpriEmployeesInfos(ZJPRI_EMPLOYEES_INFO model, SearchCondition condition)
        {
            var result = Fw.ZjpriEmployeesInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ZJPRI_EMPLOYEES_INFO明细
        /// </summary>
      /// <param name="PERSONID">人员ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadZjpriEmployeesInfo(decimal PERSONID)
        
        {
            var result = Fw.ZjpriEmployeesInfoService.ViewByPk(PERSONID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ZJPRI_EMPLOYEES_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateZjpriEmployeesInfo(ZJPRI_EMPLOYEES_INFO model)
        {
            var result = Fw.ZjpriEmployeesInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ZJPRI_EMPLOYEES_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateZjpriEmployeesInfo(ZJPRI_EMPLOYEES_INFO model)
        {
            var result = Fw.ZjpriEmployeesInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ZJPRI_EMPLOYEES_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteZjpriEmployeesInfo(string ids)
        {
            var result = Fw.ZjpriEmployeesInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}