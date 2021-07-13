using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdZjpriEmployeesQualiController:BaseController
    {
        /// <summary>
        /// 读取ZJPRI_EMPLOYEES_QUALI列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadZjpriEmployeesQualis(ZJPRI_EMPLOYEES_QUALI model, SearchCondition condition)
        {
            var result = Fw.ZjpriEmployeesQualiService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ZJPRI_EMPLOYEES_QUALI明细
        /// </summary>
      /// <param name="CERTIFICATEID">证书ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadZjpriEmployeesQuali(decimal CERTIFICATEID)
        
        {
            var result = Fw.ZjpriEmployeesQualiService.ViewByPk(CERTIFICATEID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ZJPRI_EMPLOYEES_QUALI信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateZjpriEmployeesQuali(ZJPRI_EMPLOYEES_QUALI model)
        {
            var result = Fw.ZjpriEmployeesQualiService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ZJPRI_EMPLOYEES_QUALI信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateZjpriEmployeesQuali(ZJPRI_EMPLOYEES_QUALI model)
        {
            var result = Fw.ZjpriEmployeesQualiService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ZJPRI_EMPLOYEES_QUALI信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteZjpriEmployeesQuali(string ids)
        {
            var result = Fw.ZjpriEmployeesQualiService.Delete(ids);
            return JResult(result); 
        }
    }
}