using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTSwPublishController:BaseController
    {
        /// <summary>
        /// 读取T_SW_PUBLISH列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTSwPublishs(T_SW_PUBLISH model, SearchCondition condition)
        {
            var result = Fw.TSwPublishService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_SW_PUBLISH明细
        /// </summary>
      /// <param name="PROJECT_NO">项目编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTSwPublish(string PROJECT_NO)
        
        {
            var result = Fw.TSwPublishService.ViewByPk(PROJECT_NO);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_SW_PUBLISH信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTSwPublish(T_SW_PUBLISH model)
        {
            var result = Fw.TSwPublishService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_SW_PUBLISH信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTSwPublish(T_SW_PUBLISH model)
        {
            var result = Fw.TSwPublishService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_SW_PUBLISH信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTSwPublish(string ids)
        {
            var result = Fw.TSwPublishService.Delete(ids);
            return JResult(result); 
        }
    }
}