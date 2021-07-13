using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdEcaPcaxController:BaseController
    {
        /// <summary>
        /// 读取ECA_PCAX列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadEcaPcaxs(ECA_PCAX model, SearchCondition condition)
        {
            var result = Fw.EcaPcaxService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ECA_PCAX明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadEcaPcax(decimal ID)
        
        {
            var result = Fw.EcaPcaxService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ECA_PCAX信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateEcaPcax(ECA_PCAX model)
        {
            var result = Fw.EcaPcaxService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ECA_PCAX信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateEcaPcax(ECA_PCAX model)
        {
            var result = Fw.EcaPcaxService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ECA_PCAX信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteEcaPcax(string ids)
        {
            var result = Fw.EcaPcaxService.Delete(ids);
            return JResult(result); 
        }
    }
}