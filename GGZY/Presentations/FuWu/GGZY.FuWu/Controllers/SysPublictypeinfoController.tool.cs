using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysPublictypeinfoController:BaseController
    {
        /// <summary>
        /// 读取SYS_PUBLICTYPEINFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysPublictypeinfos(SYS_PUBLICTYPEINFO model, SearchCondition condition)
        {
            var result = Fw.SysPublictypeinfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_PUBLICTYPEINFO明细
        /// </summary>
      /// <param name="PTIID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysPublictypeinfo(decimal PTIID)
        
        {
            var result = Fw.SysPublictypeinfoService.ViewByPk(PTIID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_PUBLICTYPEINFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysPublictypeinfo(SYS_PUBLICTYPEINFO model)
        {
            var result = Fw.SysPublictypeinfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_PUBLICTYPEINFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysPublictypeinfo(SYS_PUBLICTYPEINFO model)
        {
            var result = Fw.SysPublictypeinfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_PUBLICTYPEINFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysPublictypeinfo(string ids)
        {
            var result = Fw.SysPublictypeinfoService.Delete(ids);
            return JResult(result); 
        }
    }
}