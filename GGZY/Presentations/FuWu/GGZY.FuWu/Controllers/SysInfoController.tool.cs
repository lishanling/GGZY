using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysInfoController:BaseController
    {
        /// <summary>
        /// 读取SYS_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysInfos(SYS_INFO model, SearchCondition condition)
        {
            var result = Fw.SysInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_INFO明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysInfo(decimal ID)
        
        {
            var result = Fw.SysInfoService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysInfo(SYS_INFO model)
        {
            var result = Fw.SysInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysInfo(SYS_INFO model)
        {
            var result = Fw.SysInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysInfo(string ids)
        {
            var result = Fw.SysInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}