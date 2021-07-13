using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDeaMediChangeAnnoController:BaseController
    {
        /// <summary>
        /// 读取DEA_MEDI_CHANGE_ANNO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDeaMediChangeAnnos(DEA_MEDI_CHANGE_ANNO model, SearchCondition condition)
        {
            var result = Fw.DeaMediChangeAnnoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DEA_MEDI_CHANGE_ANNO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDeaMediChangeAnno(decimal M_ID)
        
        {
            var result = Fw.DeaMediChangeAnnoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DEA_MEDI_CHANGE_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDeaMediChangeAnno(DEA_MEDI_CHANGE_ANNO model)
        {
            var result = Fw.DeaMediChangeAnnoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DEA_MEDI_CHANGE_ANNO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDeaMediChangeAnno(DEA_MEDI_CHANGE_ANNO model)
        {
            var result = Fw.DeaMediChangeAnnoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DEA_MEDI_CHANGE_ANNO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDeaMediChangeAnno(string ids)
        {
            var result = Fw.DeaMediChangeAnnoService.Delete(ids);
            return JResult(result); 
        }
    }
}