using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdZjpriConstructKeypersonController:BaseController
    {
        /// <summary>
        /// 读取ZJPRI_CONSTRUCT_KEYPERSON列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadZjpriConstructKeypersons(ZJPRI_CONSTRUCT_KEYPERSON model, SearchCondition condition)
        {
            var result = Fw.ZjpriConstructKeypersonService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ZJPRI_CONSTRUCT_KEYPERSON明细
        /// </summary>
      /// <param name="MAINPERSONID">主要人员ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadZjpriConstructKeyperson(decimal MAINPERSONID)
        
        {
            var result = Fw.ZjpriConstructKeypersonService.ViewByPk(MAINPERSONID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ZJPRI_CONSTRUCT_KEYPERSON信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateZjpriConstructKeyperson(ZJPRI_CONSTRUCT_KEYPERSON model)
        {
            var result = Fw.ZjpriConstructKeypersonService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ZJPRI_CONSTRUCT_KEYPERSON信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateZjpriConstructKeyperson(ZJPRI_CONSTRUCT_KEYPERSON model)
        {
            var result = Fw.ZjpriConstructKeypersonService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ZJPRI_CONSTRUCT_KEYPERSON信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteZjpriConstructKeyperson(string ids)
        {
            var result = Fw.ZjpriConstructKeypersonService.Delete(ids);
            return JResult(result); 
        }
    }
}