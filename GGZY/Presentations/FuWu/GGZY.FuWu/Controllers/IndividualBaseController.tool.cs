using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdIndividualBaseController:BaseController
    {
        /// <summary>
        /// 读取INDIVIDUAL_BASE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadIndividualBases(INDIVIDUAL_BASE model, SearchCondition condition)
        {
            var result = Fw.IndividualBaseService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取INDIVIDUAL_BASE明细
        /// </summary>
      /// <param name="M_ID">主键ID 自增</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadIndividualBase(decimal M_ID)
        
        {
            var result = Fw.IndividualBaseService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建INDIVIDUAL_BASE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateIndividualBase(INDIVIDUAL_BASE model)
        {
            var result = Fw.IndividualBaseService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新INDIVIDUAL_BASE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateIndividualBase(INDIVIDUAL_BASE model)
        {
            var result = Fw.IndividualBaseService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除INDIVIDUAL_BASE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteIndividualBase(string ids)
        {
            var result = Fw.IndividualBaseService.Delete(ids);
            return JResult(result); 
        }
    }
}