using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysAreaQuanguoController:BaseController
    {
        /// <summary>
        /// 读取SYS_AREA_QUANGUO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysAreaQuanguos(SYS_AREA_QUANGUO model, SearchCondition condition)
        {
            var result = Fw.SysAreaQuanguoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_AREA_QUANGUO明细
        /// </summary>
      /// <param name="AREACODE"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysAreaQuanguo(string AREACODE)
        
        {
            var result = Fw.SysAreaQuanguoService.ViewByPk(AREACODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_AREA_QUANGUO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysAreaQuanguo(SYS_AREA_QUANGUO model)
        {
            var result = Fw.SysAreaQuanguoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_AREA_QUANGUO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysAreaQuanguo(SYS_AREA_QUANGUO model)
        {
            var result = Fw.SysAreaQuanguoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_AREA_QUANGUO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysAreaQuanguo(string ids)
        {
            var result = Fw.SysAreaQuanguoService.Delete(ids);
            return JResult(result); 
        }
    }
}