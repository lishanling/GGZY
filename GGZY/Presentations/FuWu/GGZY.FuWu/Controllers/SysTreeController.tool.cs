using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysTreeController:BaseController
    {
        /// <summary>
        /// 读取SYS_TREE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysTrees(SYS_TREE model, SearchCondition condition)
        {
            var result = Fw.SysTreeService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_TREE明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysTree(decimal ID)
        
        {
            var result = Fw.SysTreeService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_TREE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysTree(SYS_TREE model)
        {
            var result = Fw.SysTreeService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_TREE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysTree(SYS_TREE model)
        {
            var result = Fw.SysTreeService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_TREE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysTree(string ids)
        {
            var result = Fw.SysTreeService.Delete(ids);
            return JResult(result); 
        }
    }
}