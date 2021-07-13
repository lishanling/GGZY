using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTheEelRowController:BaseController
    {
        /// <summary>
        /// 读取THE_EEL_ROW列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTheEelRows(THE_EEL_ROW model, SearchCondition condition)
        {
            var result = Fw.TheEelRowService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取THE_EEL_ROW明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTheEelRow(decimal ID)
        
        {
            var result = Fw.TheEelRowService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建THE_EEL_ROW信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTheEelRow(THE_EEL_ROW model)
        {
            var result = Fw.TheEelRowService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新THE_EEL_ROW信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTheEelRow(THE_EEL_ROW model)
        {
            var result = Fw.TheEelRowService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除THE_EEL_ROW信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTheEelRow(string ids)
        {
            var result = Fw.TheEelRowService.Delete(ids);
            return JResult(result); 
        }
    }
}