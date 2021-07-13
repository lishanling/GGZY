using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTCertificateController:BaseController
    {
        /// <summary>
        /// 读取T_CERTIFICATE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTCertificates(T_CERTIFICATE model, SearchCondition condition)
        {
            var result = Fw.TCertificateService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_CERTIFICATE明细
        /// </summary>
      /// <param name="M_ID">M_ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTCertificate(decimal M_ID)
        
        {
            var result = Fw.TCertificateService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_CERTIFICATE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTCertificate(T_CERTIFICATE model)
        {
            var result = Fw.TCertificateService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_CERTIFICATE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTCertificate(T_CERTIFICATE model)
        {
            var result = Fw.TCertificateService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_CERTIFICATE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTCertificate(string ids)
        {
            var result = Fw.TCertificateService.Delete(ids);
            return JResult(result); 
        }
    }
}