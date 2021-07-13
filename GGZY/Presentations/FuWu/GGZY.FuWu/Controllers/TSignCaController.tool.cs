using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTSignCaController:BaseController
    {
        /// <summary>
        /// 读取T_SIGN_CA列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTSignCas(T_SIGN_CA model, SearchCondition condition)
        {
            var result = Fw.TSignCaService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_SIGN_CA明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTSignCa(decimal ID)
        
        {
            var result = Fw.TSignCaService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_SIGN_CA信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTSignCa(T_SIGN_CA model)
        {
            var result = Fw.TSignCaService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_SIGN_CA信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTSignCa(T_SIGN_CA model)
        {
            var result = Fw.TSignCaService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_SIGN_CA信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTSignCa(string ids)
        {
            var result = Fw.TSignCaService.Delete(ids);
            return JResult(result); 
        }
    }
}