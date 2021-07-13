using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdProExtDetRecController:BaseController
    {
        /// <summary>
        /// 读取PRO_EXT_DET_REC列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadProExtDetRecs(PRO_EXT_DET_REC model, SearchCondition condition)
        {
            var result = Fw.ProExtDetRecService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PRO_EXT_DET_REC明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadProExtDetRec(decimal ID)
        
        {
            var result = Fw.ProExtDetRecService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PRO_EXT_DET_REC信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateProExtDetRec(PRO_EXT_DET_REC model)
        {
            var result = Fw.ProExtDetRecService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PRO_EXT_DET_REC信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateProExtDetRec(PRO_EXT_DET_REC model)
        {
            var result = Fw.ProExtDetRecService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PRO_EXT_DET_REC信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteProExtDetRec(string ids)
        {
            var result = Fw.ProExtDetRecService.Delete(ids);
            return JResult(result); 
        }
    }
}