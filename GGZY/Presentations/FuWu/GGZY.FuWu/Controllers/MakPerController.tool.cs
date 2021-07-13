using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdMakPerController:BaseController
    {
        /// <summary>
        /// 读取MAK_PER列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadMakPers(MAK_PER model, SearchCondition condition)
        {
            var result = Fw.MakPerService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取MAK_PER明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadMakPer(decimal ID)
        
        {
            var result = Fw.MakPerService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建MAK_PER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateMakPer(MAK_PER model)
        {
            var result = Fw.MakPerService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新MAK_PER信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateMakPer(MAK_PER model)
        {
            var result = Fw.MakPerService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除MAK_PER信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteMakPer(string ids)
        {
            var result = Fw.MakPerService.Delete(ids);
            return JResult(result); 
        }
    }
}