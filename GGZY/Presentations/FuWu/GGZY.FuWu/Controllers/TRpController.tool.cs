using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTRpController:BaseController
    {
        /// <summary>
        /// 读取T_RP列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTRps(T_RP model, SearchCondition condition)
        {
            var result = Fw.TRpService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_RP明细
        /// </summary>
      /// <param name="RP_CODE"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTRp(string RP_CODE)
        
        {
            var result = Fw.TRpService.ViewByPk(RP_CODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_RP信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTRp(T_RP model)
        {
            var result = Fw.TRpService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_RP信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTRp(T_RP model)
        {
            var result = Fw.TRpService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_RP信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTRp(string ids)
        {
            var result = Fw.TRpService.Delete(ids);
            return JResult(result); 
        }
    }
}