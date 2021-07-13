using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTGqPublishController:BaseController
    {
        /// <summary>
        /// 读取T_GQ_PUBLISH列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTGqPublishs(T_GQ_PUBLISH model, SearchCondition condition)
        {
            var result = Fw.TGqPublishService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_GQ_PUBLISH明细
        /// </summary>
      /// <param name="PROJECT_NO">项目编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTGqPublish(string PROJECT_NO)
        
        {
            var result = Fw.TGqPublishService.ViewByPk(PROJECT_NO);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_GQ_PUBLISH信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTGqPublish(T_GQ_PUBLISH model)
        {
            var result = Fw.TGqPublishService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_GQ_PUBLISH信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTGqPublish(T_GQ_PUBLISH model)
        {
            var result = Fw.TGqPublishService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_GQ_PUBLISH信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTGqPublish(string ids)
        {
            var result = Fw.TGqPublishService.Delete(ids);
            return JResult(result); 
        }
    }
}