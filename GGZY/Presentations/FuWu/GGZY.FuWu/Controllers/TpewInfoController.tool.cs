using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTpewInfoController:BaseController
    {
        /// <summary>
        /// 读取TPEW_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTpewInfos(TPEW_INFO model, SearchCondition condition)
        {
            var result = Fw.TpewInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TPEW_INFO明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTpewInfo(decimal ID)
        
        {
            var result = Fw.TpewInfoService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TPEW_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTpewInfo(TPEW_INFO model)
        {
            var result = Fw.TpewInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TPEW_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTpewInfo(TPEW_INFO model)
        {
            var result = Fw.TpewInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TPEW_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTpewInfo(string ids)
        {
            var result = Fw.TpewInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}