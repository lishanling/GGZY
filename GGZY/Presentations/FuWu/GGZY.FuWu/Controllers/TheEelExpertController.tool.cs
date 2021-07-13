using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTheEelExpertController:BaseController
    {
        /// <summary>
        /// 读取THE_EEL_EXPERT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTheEelExperts(THE_EEL_EXPERT model, SearchCondition condition)
        {
            var result = Fw.TheEelExpertService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取THE_EEL_EXPERT明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTheEelExpert(decimal ID)
        
        {
            var result = Fw.TheEelExpertService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建THE_EEL_EXPERT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTheEelExpert(THE_EEL_EXPERT model)
        {
            var result = Fw.TheEelExpertService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新THE_EEL_EXPERT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTheEelExpert(THE_EEL_EXPERT model)
        {
            var result = Fw.TheEelExpertService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除THE_EEL_EXPERT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTheEelExpert(string ids)
        {
            var result = Fw.TheEelExpertService.Delete(ids);
            return JResult(result); 
        }
    }
}