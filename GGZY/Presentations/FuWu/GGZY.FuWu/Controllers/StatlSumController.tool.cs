using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdStatlSumController:BaseController
    {
        /// <summary>
        /// 读取STATL_SUM列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadStatlSums(STATL_SUM model, SearchCondition condition)
        {
            var result = Fw.StatlSumService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取STATL_SUM明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadStatlSum(decimal ID)
        
        {
            var result = Fw.StatlSumService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建STATL_SUM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateStatlSum(STATL_SUM model)
        {
            var result = Fw.StatlSumService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新STATL_SUM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateStatlSum(STATL_SUM model)
        {
            var result = Fw.StatlSumService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除STATL_SUM信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteStatlSum(string ids)
        {
            var result = Fw.StatlSumService.Delete(ids);
            return JResult(result); 
        }
    }
}