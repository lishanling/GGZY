using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDbSystemController:BaseController
    {
        /// <summary>
        /// 读取DB_SYSTEM列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDbSystems(DB_SYSTEM model, SearchCondition condition)
        {
            var result = Fw.DbSystemService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DB_SYSTEM明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDbSystem(decimal ID)
        
        {
            var result = Fw.DbSystemService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DB_SYSTEM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDbSystem(DB_SYSTEM model)
        {
            var result = Fw.DbSystemService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DB_SYSTEM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDbSystem(DB_SYSTEM model)
        {
            var result = Fw.DbSystemService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DB_SYSTEM信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDbSystem(string ids)
        {
            var result = Fw.DbSystemService.Delete(ids);
            return JResult(result); 
        }
    }
}