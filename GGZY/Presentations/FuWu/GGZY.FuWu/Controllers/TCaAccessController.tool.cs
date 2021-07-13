using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTCaAccessController:BaseController
    {
        /// <summary>
        /// 读取T_CA_ACCESS列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTCaAccesss(T_CA_ACCESS model, SearchCondition condition)
        {
            var result = Fw.TCaAccessService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_CA_ACCESS明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTCaAccess(decimal ID)
        
        {
            var result = Fw.TCaAccessService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_CA_ACCESS信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTCaAccess(T_CA_ACCESS model)
        {
            var result = Fw.TCaAccessService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_CA_ACCESS信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTCaAccess(T_CA_ACCESS model)
        {
            var result = Fw.TCaAccessService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_CA_ACCESS信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTCaAccess(string ids)
        {
            var result = Fw.TCaAccessService.Delete(ids);
            return JResult(result); 
        }
    }
}