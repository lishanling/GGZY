using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTRpDbconfigController:BaseController
    {
        /// <summary>
        /// 读取T_RP_DBCONFIG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTRpDbconfigs(T_RP_DBCONFIG model, SearchCondition condition)
        {
            var result = Fw.TRpDbconfigService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_RP_DBCONFIG明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTRpDbconfig(decimal ID)
        
        {
            var result = Fw.TRpDbconfigService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_RP_DBCONFIG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTRpDbconfig(T_RP_DBCONFIG model)
        {
            var result = Fw.TRpDbconfigService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_RP_DBCONFIG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTRpDbconfig(T_RP_DBCONFIG model)
        {
            var result = Fw.TRpDbconfigService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_RP_DBCONFIG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTRpDbconfig(string ids)
        {
            var result = Fw.TRpDbconfigService.Delete(ids);
            return JResult(result); 
        }
    }
}