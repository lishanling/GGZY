using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdAwardInfoController:BaseController
    {
        /// <summary>
        /// 读取AWARD_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadAwardInfos(AWARD_INFO model, SearchCondition condition)
        {
            var result = Fw.AwardInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取AWARD_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadAwardInfo(decimal M_ID)
        
        {
            var result = Fw.AwardInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建AWARD_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateAwardInfo(AWARD_INFO model)
        {
            var result = Fw.AwardInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新AWARD_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateAwardInfo(AWARD_INFO model)
        {
            var result = Fw.AwardInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除AWARD_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteAwardInfo(string ids)
        {
            var result = Fw.AwardInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}