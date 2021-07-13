using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdZjpriRegisterPersonController:BaseController
    {
        /// <summary>
        /// 读取ZJPRI_REGISTER_PERSON列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadZjpriRegisterPersons(ZJPRI_REGISTER_PERSON model, SearchCondition condition)
        {
            var result = Fw.ZjpriRegisterPersonService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ZJPRI_REGISTER_PERSON明细
        /// </summary>
      /// <param name="CERTNUM">注册证书编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadZjpriRegisterPerson(string CERTNUM)
        
        {
            var result = Fw.ZjpriRegisterPersonService.ViewByPk(CERTNUM);
            return JResult(result);
        }
        /// <summary>
        /// 创建ZJPRI_REGISTER_PERSON信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateZjpriRegisterPerson(ZJPRI_REGISTER_PERSON model)
        {
            var result = Fw.ZjpriRegisterPersonService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ZJPRI_REGISTER_PERSON信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateZjpriRegisterPerson(ZJPRI_REGISTER_PERSON model)
        {
            var result = Fw.ZjpriRegisterPersonService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ZJPRI_REGISTER_PERSON信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteZjpriRegisterPerson(string ids)
        {
            var result = Fw.ZjpriRegisterPersonService.Delete(ids);
            return JResult(result); 
        }
    }
}