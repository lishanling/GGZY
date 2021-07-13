using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdBhJiekouUserController:BaseController
    {
        /// <summary>
        /// 读取BH_JIEKOU_USER列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadBhJiekouUsers(BH_JIEKOU_USER model, SearchCondition condition)
        {
            var result = Fw.BhJiekouUserService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取BH_JIEKOU_USER明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadBhJiekouUser(decimal ID)
        
        {
            var result = Fw.BhJiekouUserService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建BH_JIEKOU_USER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateBhJiekouUser(BH_JIEKOU_USER model)
        {
            var result = Fw.BhJiekouUserService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新BH_JIEKOU_USER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateBhJiekouUser(BH_JIEKOU_USER model)
        {
            var result = Fw.BhJiekouUserService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除BH_JIEKOU_USER信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteBhJiekouUser(string ids)
        {
            var result = Fw.BhJiekouUserService.Delete(ids);
            return JResult(result); 
        }
    }
}