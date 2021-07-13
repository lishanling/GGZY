using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTSsoInfoController:BaseController
    {
        /// <summary>
        /// 读取T_SSO_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTSsoInfos(T_SSO_INFO model, SearchCondition condition)
        {
            var result = Fw.TSsoInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_SSO_INFO明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTSsoInfo(decimal ID)
        
        {
            var result = Fw.TSsoInfoService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_SSO_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTSsoInfo(T_SSO_INFO model)
        {
            var result = Fw.TSsoInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_SSO_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTSsoInfo(T_SSO_INFO model)
        {
            var result = Fw.TSsoInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_SSO_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTSsoInfo(string ids)
        {
            var result = Fw.TSsoInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}