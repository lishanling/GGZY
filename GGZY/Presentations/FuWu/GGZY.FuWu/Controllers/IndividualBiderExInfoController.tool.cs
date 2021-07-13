using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdIndividualBiderExInfoController:BaseController
    {
        /// <summary>
        /// 读取INDIVIDUAL_BIDER_EX_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadIndividualBiderExInfos(INDIVIDUAL_BIDER_EX_INFO model, SearchCondition condition)
        {
            var result = Fw.IndividualBiderExInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取INDIVIDUAL_BIDER_EX_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadIndividualBiderExInfo(decimal M_ID)
        
        {
            var result = Fw.IndividualBiderExInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建INDIVIDUAL_BIDER_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateIndividualBiderExInfo(INDIVIDUAL_BIDER_EX_INFO model)
        {
            var result = Fw.IndividualBiderExInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新INDIVIDUAL_BIDER_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateIndividualBiderExInfo(INDIVIDUAL_BIDER_EX_INFO model)
        {
            var result = Fw.IndividualBiderExInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除INDIVIDUAL_BIDER_EX_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteIndividualBiderExInfo(string ids)
        {
            var result = Fw.IndividualBiderExInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}