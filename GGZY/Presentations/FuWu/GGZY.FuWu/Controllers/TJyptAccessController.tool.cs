using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTJyptAccessController:BaseController
    {
        /// <summary>
        /// 读取T_JYPT_ACCESS列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTJyptAccesss(T_JYPT_ACCESS model, SearchCondition condition)
        {
            var result = Fw.TJyptAccessService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_JYPT_ACCESS明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTJyptAccess(decimal ID)
        
        {
            var result = Fw.TJyptAccessService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_JYPT_ACCESS信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTJyptAccess(T_JYPT_ACCESS model)
        {
            var result = Fw.TJyptAccessService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_JYPT_ACCESS信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTJyptAccess(T_JYPT_ACCESS model)
        {
            var result = Fw.TJyptAccessService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_JYPT_ACCESS信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTJyptAccess(string ids)
        {
            var result = Fw.TJyptAccessService.Delete(ids);
            return JResult(result); 
        }
    }
}