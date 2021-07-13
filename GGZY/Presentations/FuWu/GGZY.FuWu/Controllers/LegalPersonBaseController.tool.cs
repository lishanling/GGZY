using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdLegalPersonBaseController:BaseController
    {
        /// <summary>
        /// 读取LEGAL_PERSON_BASE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadLegalPersonBases(LEGAL_PERSON_BASE model, SearchCondition condition)
        {
            var result = Fw.LegalPersonBaseService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取LEGAL_PERSON_BASE明细
        /// </summary>
      /// <param name="M_ID">主键ID 自增</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadLegalPersonBase(decimal M_ID)
        
        {
            var result = Fw.LegalPersonBaseService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建LEGAL_PERSON_BASE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateLegalPersonBase(LEGAL_PERSON_BASE model)
        {
            var result = Fw.LegalPersonBaseService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新LEGAL_PERSON_BASE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateLegalPersonBase(LEGAL_PERSON_BASE model)
        {
            var result = Fw.LegalPersonBaseService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除LEGAL_PERSON_BASE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteLegalPersonBase(string ids)
        {
            var result = Fw.LegalPersonBaseService.Delete(ids);
            return JResult(result); 
        }
    }
}