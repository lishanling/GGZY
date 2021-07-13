using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTFindpwdController:BaseController
    {
        /// <summary>
        /// 读取T_FINDPWD列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTFindpwds(T_FINDPWD model, SearchCondition condition)
        {
            var result = Fw.TFindpwdService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_FINDPWD明细
        /// </summary>
      /// <param name="GUID">主键，36位guid</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTFindpwd(Guid GUID)
        
        {
            var result = Fw.TFindpwdService.ViewByPk(GUID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_FINDPWD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTFindpwd(T_FINDPWD model)
        {
            var result = Fw.TFindpwdService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_FINDPWD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTFindpwd(T_FINDPWD model)
        {
            var result = Fw.TFindpwdService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_FINDPWD信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTFindpwd(string ids)
        {
            var result = Fw.TFindpwdService.Delete(ids);
            return JResult(result); 
        }
    }
}