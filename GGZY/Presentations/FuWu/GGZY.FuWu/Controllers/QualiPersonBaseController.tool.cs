using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdQualiPersonBaseController:BaseController
    {
        /// <summary>
        /// 读取QUALI_PERSON_BASE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadQualiPersonBases(QUALI_PERSON_BASE model, SearchCondition condition)
        {
            var result = Fw.QualiPersonBaseService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取QUALI_PERSON_BASE明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadQualiPersonBase(decimal M_ID)
        
        {
            var result = Fw.QualiPersonBaseService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建QUALI_PERSON_BASE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateQualiPersonBase(QUALI_PERSON_BASE model)
        {
            var result = Fw.QualiPersonBaseService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新QUALI_PERSON_BASE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateQualiPersonBase(QUALI_PERSON_BASE model)
        {
            var result = Fw.QualiPersonBaseService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除QUALI_PERSON_BASE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteQualiPersonBase(string ids)
        {
            var result = Fw.QualiPersonBaseService.Delete(ids);
            return JResult(result); 
        }
    }
}