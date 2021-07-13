using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSocialCreditInfoController:BaseController
    {
        /// <summary>
        /// 读取SOCIAL_CREDIT_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSocialCreditInfos(SOCIAL_CREDIT_INFO model, SearchCondition condition)
        {
            var result = Fw.SocialCreditInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SOCIAL_CREDIT_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSocialCreditInfo(decimal M_ID)
        
        {
            var result = Fw.SocialCreditInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SOCIAL_CREDIT_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSocialCreditInfo(SOCIAL_CREDIT_INFO model)
        {
            var result = Fw.SocialCreditInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SOCIAL_CREDIT_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSocialCreditInfo(SOCIAL_CREDIT_INFO model)
        {
            var result = Fw.SocialCreditInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SOCIAL_CREDIT_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSocialCreditInfo(string ids)
        {
            var result = Fw.SocialCreditInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}