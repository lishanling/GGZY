using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdWinResultAnnoController:BaseController
    {
        /// <summary>
        /// 读取WIN_RESULT_ANNO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadWinResultAnnos(WIN_RESULT_ANNO model, SearchCondition condition)
        {
            var result = Fw.WinResultAnnoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取WIN_RESULT_ANNO明细
        /// </summary>
      /// <param name="M_ID">自增ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadWinResultAnno(decimal M_ID)
        
        {
            var result = Fw.WinResultAnnoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建WIN_RESULT_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateWinResultAnno(WIN_RESULT_ANNO model)
        {
            var result = Fw.WinResultAnnoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新WIN_RESULT_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateWinResultAnno(WIN_RESULT_ANNO model)
        {
            var result = Fw.WinResultAnnoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除WIN_RESULT_ANNO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteWinResultAnno(string ids)
        {
            var result = Fw.WinResultAnnoService.Delete(ids);
            return JResult(result); 
        }
    }
}