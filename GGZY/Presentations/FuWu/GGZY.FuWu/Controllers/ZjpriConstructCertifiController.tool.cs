using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdZjpriConstructCertifiController:BaseController
    {
        /// <summary>
        /// 读取ZJPRI_CONSTRUCT_CERTIFI列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadZjpriConstructCertifis(ZJPRI_CONSTRUCT_CERTIFI model, SearchCondition condition)
        {
            var result = Fw.ZjpriConstructCertifiService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ZJPRI_CONSTRUCT_CERTIFI明细
        /// </summary>
      /// <param name="QUALIFYCERTIFICATEID">资质证书ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadZjpriConstructCertifi(decimal QUALIFYCERTIFICATEID)
        
        {
            var result = Fw.ZjpriConstructCertifiService.ViewByPk(QUALIFYCERTIFICATEID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ZJPRI_CONSTRUCT_CERTIFI信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateZjpriConstructCertifi(ZJPRI_CONSTRUCT_CERTIFI model)
        {
            var result = Fw.ZjpriConstructCertifiService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ZJPRI_CONSTRUCT_CERTIFI信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateZjpriConstructCertifi(ZJPRI_CONSTRUCT_CERTIFI model)
        {
            var result = Fw.ZjpriConstructCertifiService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ZJPRI_CONSTRUCT_CERTIFI信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteZjpriConstructCertifi(string ids)
        {
            var result = Fw.ZjpriConstructCertifiService.Delete(ids);
            return JResult(result); 
        }
    }
}