using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTSsoInfoSqController:BaseController
    {
        /// <summary>
        /// 读取T_SSO_INFO_SQ列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTSsoInfoSqs(T_SSO_INFO_SQ model, SearchCondition condition)
        {
            var result = Fw.TSsoInfoSqService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_SSO_INFO_SQ明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTSsoInfoSq(decimal ID)
        
        {
            var result = Fw.TSsoInfoSqService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_SSO_INFO_SQ信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTSsoInfoSq(T_SSO_INFO_SQ model)
        {
            var result = Fw.TSsoInfoSqService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_SSO_INFO_SQ信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTSsoInfoSq(T_SSO_INFO_SQ model)
        {
            var result = Fw.TSsoInfoSqService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_SSO_INFO_SQ信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTSsoInfoSq(string ids)
        {
            var result = Fw.TSsoInfoSqService.Delete(ids);
            return JResult(result); 
        }
    }
}