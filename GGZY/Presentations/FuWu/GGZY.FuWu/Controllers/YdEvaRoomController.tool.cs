using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdYdEvaRoomController:BaseController
    {
        /// <summary>
        /// 读取YD_EVA_ROOM列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadYdEvaRooms(YD_EVA_ROOM model, SearchCondition condition)
        {
            var result = Fw.YdEvaRoomService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取YD_EVA_ROOM明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadYdEvaRoom(decimal ID)
        
        {
            var result = Fw.YdEvaRoomService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建YD_EVA_ROOM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateYdEvaRoom(YD_EVA_ROOM model)
        {
            var result = Fw.YdEvaRoomService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新YD_EVA_ROOM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateYdEvaRoom(YD_EVA_ROOM model)
        {
            var result = Fw.YdEvaRoomService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除YD_EVA_ROOM信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteYdEvaRoom(string ids)
        {
            var result = Fw.YdEvaRoomService.Delete(ids);
            return JResult(result); 
        }
    }
}