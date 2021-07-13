using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTheEelSetAndAuthController:BaseController
    {
        /// <summary>
        /// 读取THE_EEL_SET_AND_AUTH列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTheEelSetAndAuths(THE_EEL_SET_AND_AUTH model, SearchCondition condition)
        {
            var result = Fw.TheEelSetAndAuthService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取THE_EEL_SET_AND_AUTH明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTheEelSetAndAuth(decimal ID)
        
        {
            var result = Fw.TheEelSetAndAuthService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建THE_EEL_SET_AND_AUTH信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTheEelSetAndAuth(THE_EEL_SET_AND_AUTH model)
        {
            var result = Fw.TheEelSetAndAuthService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新THE_EEL_SET_AND_AUTH信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTheEelSetAndAuth(THE_EEL_SET_AND_AUTH model)
        {
            var result = Fw.TheEelSetAndAuthService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除THE_EEL_SET_AND_AUTH信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTheEelSetAndAuth(string ids)
        {
            var result = Fw.TheEelSetAndAuthService.Delete(ids);
            return JResult(result); 
        }
    }
}