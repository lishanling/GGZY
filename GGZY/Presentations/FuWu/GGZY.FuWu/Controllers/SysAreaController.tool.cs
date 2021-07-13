using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysAreaController:BaseController
    {
        /// <summary>
        /// 读取SYS_AREA列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysAreas(SYS_AREA model, SearchCondition condition)
        {
            var result = Fw.SysAreaService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_AREA明细
        /// </summary>
      /// <param name="AREACODE"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysArea(string AREACODE)
        
        {
            var result = Fw.SysAreaService.ViewByPk(AREACODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_AREA信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysArea(SYS_AREA model)
        {
            var result = Fw.SysAreaService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_AREA信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysArea(SYS_AREA model)
        {
            var result = Fw.SysAreaService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_AREA信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysArea(string ids)
        {
            var result = Fw.SysAreaService.Delete(ids);
            return JResult(result); 
        }
    }
}