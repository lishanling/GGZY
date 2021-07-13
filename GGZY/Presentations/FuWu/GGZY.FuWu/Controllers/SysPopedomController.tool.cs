using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysPopedomController:BaseController
    {
        /// <summary>
        /// 读取SYS_POPEDOM列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysPopedoms(SYS_POPEDOM model, SearchCondition condition)
        {
            var result = Fw.SysPopedomService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_POPEDOM明细
        /// </summary>
      /// <param name="POPID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysPopedom(decimal POPID)
        
        {
            var result = Fw.SysPopedomService.ViewByPk(POPID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_POPEDOM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysPopedom(SYS_POPEDOM model)
        {
            var result = Fw.SysPopedomService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_POPEDOM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysPopedom(SYS_POPEDOM model)
        {
            var result = Fw.SysPopedomService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_POPEDOM信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysPopedom(string ids)
        {
            var result = Fw.SysPopedomService.Delete(ids);
            return JResult(result); 
        }
    }
}