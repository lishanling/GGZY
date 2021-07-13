using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTcpSystemController:BaseController
    {
        /// <summary>
        /// 读取TCP_SYSTEM列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTcpSystems(TCP_SYSTEM model, SearchCondition condition)
        {
            var result = Fw.TcpSystemService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TCP_SYSTEM明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTcpSystem(decimal ID)
        
        {
            var result = Fw.TcpSystemService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TCP_SYSTEM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTcpSystem(TCP_SYSTEM model)
        {
            var result = Fw.TcpSystemService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TCP_SYSTEM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTcpSystem(TCP_SYSTEM model)
        {
            var result = Fw.TcpSystemService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TCP_SYSTEM信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTcpSystem(string ids)
        {
            var result = Fw.TcpSystemService.Delete(ids);
            return JResult(result); 
        }
    }
}