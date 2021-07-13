using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdSysDicController:BaseController
    {
        /// <summary>
        /// 读取SYS_DIC列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysDics(SYS_DIC model, SearchCondition condition)
        {
            var result = Fw.SysDicService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_DIC明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadSysDic(decimal ID)
        
        {
            var result = Fw.SysDicService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_DIC信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysDic(SYS_DIC model)
        {
            var result = Fw.SysDicService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_DIC信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysDic(SYS_DIC model)
        {
            var result = Fw.SysDicService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_DIC信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysDic(string ids)
        {
            var result = Fw.SysDicService.Delete(ids);
            return JResult(result); 
        }
    }
}