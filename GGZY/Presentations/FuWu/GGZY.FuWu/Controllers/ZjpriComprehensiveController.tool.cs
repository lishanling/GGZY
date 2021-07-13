using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdZjpriComprehensiveController:BaseController
    {
        /// <summary>
        /// 读取ZJPRI_COMPREHENSIVE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadZjpriComprehensives(ZJPRI_COMPREHENSIVE model, SearchCondition condition)
        {
            var result = Fw.ZjpriComprehensiveService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ZJPRI_COMPREHENSIVE明细
        /// </summary>
      /// <param name="DK_ID">唯一标识码</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadZjpriComprehensive(string DK_ID)
        
        {
            var result = Fw.ZjpriComprehensiveService.ViewByPk(DK_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ZJPRI_COMPREHENSIVE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateZjpriComprehensive(ZJPRI_COMPREHENSIVE model)
        {
            var result = Fw.ZjpriComprehensiveService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ZJPRI_COMPREHENSIVE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateZjpriComprehensive(ZJPRI_COMPREHENSIVE model)
        {
            var result = Fw.ZjpriComprehensiveService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ZJPRI_COMPREHENSIVE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteZjpriComprehensive(string ids)
        {
            var result = Fw.ZjpriComprehensiveService.Delete(ids);
            return JResult(result); 
        }
    }
}