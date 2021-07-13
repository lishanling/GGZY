using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTRpFieldController:BaseController
    {
        /// <summary>
        /// 读取T_RP_FIELD列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTRpFields(T_RP_FIELD model, SearchCondition condition)
        {
            var result = Fw.TRpFieldService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_RP_FIELD明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTRpField(decimal ID)
        
        {
            var result = Fw.TRpFieldService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_RP_FIELD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTRpField(T_RP_FIELD model)
        {
            var result = Fw.TRpFieldService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_RP_FIELD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTRpField(T_RP_FIELD model)
        {
            var result = Fw.TRpFieldService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_RP_FIELD信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTRpField(string ids)
        {
            var result = Fw.TRpFieldService.Delete(ids);
            return JResult(result); 
        }
    }
}