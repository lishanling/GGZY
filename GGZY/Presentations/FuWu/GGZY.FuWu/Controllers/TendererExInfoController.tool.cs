using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTendererExInfoController:BaseController
    {
        /// <summary>
        /// 读取TENDERER_EX_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTendererExInfos(TENDERER_EX_INFO model, SearchCondition condition)
        {
            var result = Fw.TendererExInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TENDERER_EX_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTendererExInfo(decimal M_ID)
        
        {
            var result = Fw.TendererExInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TENDERER_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTendererExInfo(TENDERER_EX_INFO model)
        {
            var result = Fw.TendererExInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TENDERER_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTendererExInfo(TENDERER_EX_INFO model)
        {
            var result = Fw.TendererExInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TENDERER_EX_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTendererExInfo(string ids)
        {
            var result = Fw.TendererExInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}