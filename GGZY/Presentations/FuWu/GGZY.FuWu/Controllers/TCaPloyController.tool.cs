using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTCaPloyController:BaseController
    {
        /// <summary>
        /// 读取T_CA_PLOY列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTCaPloys(T_CA_PLOY model, SearchCondition condition)
        {
            var result = Fw.TCaPloyService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_CA_PLOY明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTCaPloy(decimal ID)
        
        {
            var result = Fw.TCaPloyService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_CA_PLOY信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTCaPloy(T_CA_PLOY model)
        {
            var result = Fw.TCaPloyService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_CA_PLOY信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTCaPloy(T_CA_PLOY model)
        {
            var result = Fw.TCaPloyService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_CA_PLOY信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTCaPloy(string ids)
        {
            var result = Fw.TCaPloyService.Delete(ids);
            return JResult(result); 
        }
    }
}