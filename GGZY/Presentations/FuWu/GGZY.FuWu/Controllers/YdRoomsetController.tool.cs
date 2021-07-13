using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdYdRoomsetController:BaseController
    {
        /// <summary>
        /// 读取YD_ROOMSET列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadYdRoomsets(YD_ROOMSET model, SearchCondition condition)
        {
            var result = Fw.YdRoomsetService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取YD_ROOMSET明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadYdRoomset(decimal ID)
        
        {
            var result = Fw.YdRoomsetService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建YD_ROOMSET信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateYdRoomset(YD_ROOMSET model)
        {
            var result = Fw.YdRoomsetService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新YD_ROOMSET信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateYdRoomset(YD_ROOMSET model)
        {
            var result = Fw.YdRoomsetService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除YD_ROOMSET信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteYdRoomset(string ids)
        {
            var result = Fw.YdRoomsetService.Delete(ids);
            return JResult(result); 
        }
    }
}