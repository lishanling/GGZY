using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdFhhgController:BaseController
    {
        /// <summary>
        /// 读取FHHG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadFhhgs(FHHG model, SearchCondition condition)
        {
            var result = Fw.FhhgService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取FHHG明细
        /// </summary>
      /// <param name="DD">DD</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadFhhg(string DD)
        
        {
            var result = Fw.FhhgService.ViewByPk(DD);
            return JResult(result);
        }
        /// <summary>
        /// 创建FHHG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateFhhg(FHHG model)
        {
            var result = Fw.FhhgService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新FHHG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateFhhg(FHHG model)
        {
            var result = Fw.FhhgService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除FHHG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteFhhg(string ids)
        {
            var result = Fw.FhhgService.Delete(ids);
            return JResult(result); 
        }
    }
}