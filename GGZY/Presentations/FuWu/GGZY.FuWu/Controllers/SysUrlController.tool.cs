using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysUrlController:BaseController
    {
        /// <summary>
        /// 读取SYS_URL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysUrls(SYS_URL model, SearchCondition condition)
        {
            var result = Fw.SysUrlService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_URL明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysUrl(decimal ID)
        
        {
            var result = Fw.SysUrlService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_URL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysUrl(SYS_URL model)
        {
            var result = Fw.SysUrlService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_URL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysUrl(SYS_URL model)
        {
            var result = Fw.SysUrlService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_URL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysUrl(string ids)
        {
            var result = Fw.SysUrlService.Delete(ids);
            return JResult(result); 
        }
    }
}