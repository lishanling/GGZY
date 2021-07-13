using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTFrBaseController:BaseController
    {
        /// <summary>
        /// 读取T_FR_BASE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTFrBases(T_FR_BASE model, SearchCondition condition)
        {
            var result = Fw.TFrBaseService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_FR_BASE明细
        /// </summary>
      /// <param name="ORGANNO">法人机构代码</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTFrBase(string ORGANNO)
        
        {
            var result = Fw.TFrBaseService.ViewByPk(ORGANNO);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_FR_BASE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTFrBase(T_FR_BASE model)
        {
            var result = Fw.TFrBaseService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_FR_BASE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTFrBase(T_FR_BASE model)
        {
            var result = Fw.TFrBaseService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_FR_BASE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTFrBase(string ids)
        {
            var result = Fw.TFrBaseService.Delete(ids);
            return JResult(result); 
        }
    }
}