using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdCainfoController:BaseController
    {
        /// <summary>
        /// 读取CAINFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadCainfos(CAINFO model, SearchCondition condition)
        {
            var result = Fw.CainfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取CAINFO明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadCainfo(decimal ID)
        
        {
            var result = Fw.CainfoService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建CAINFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateCainfo(CAINFO model)
        {
            var result = Fw.CainfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新CAINFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateCainfo(CAINFO model)
        {
            var result = Fw.CainfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除CAINFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteCainfo(string ids)
        {
            var result = Fw.CainfoService.Delete(ids);
            return JResult(result); 
        }
    }
}