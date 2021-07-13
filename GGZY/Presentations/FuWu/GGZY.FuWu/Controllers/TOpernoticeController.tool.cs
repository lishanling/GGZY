using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTOpernoticeController:BaseController
    {
        /// <summary>
        /// 读取T_OPERNOTICE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTOpernotices(T_OPERNOTICE model, SearchCondition condition)
        {
            var result = Fw.TOpernoticeService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_OPERNOTICE明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTOpernotice(string ID)
        
        {
            var result = Fw.TOpernoticeService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_OPERNOTICE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTOpernotice(T_OPERNOTICE model)
        {
            var result = Fw.TOpernoticeService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_OPERNOTICE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTOpernotice(T_OPERNOTICE model)
        {
            var result = Fw.TOpernoticeService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_OPERNOTICE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTOpernotice(string ids)
        {
            var result = Fw.TOpernoticeService.Delete(ids);
            return JResult(result); 
        }
    }
}