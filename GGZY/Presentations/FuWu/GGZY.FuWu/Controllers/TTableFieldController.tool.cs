using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTTableFieldController:BaseController
    {
        /// <summary>
        /// 读取T_TABLE_FIELD列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTTableFields(T_TABLE_FIELD model, SearchCondition condition)
        {
            var result = Fw.TTableFieldService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_TABLE_FIELD明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTTableField(decimal ID)
        
        {
            var result = Fw.TTableFieldService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_TABLE_FIELD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTTableField(T_TABLE_FIELD model)
        {
            var result = Fw.TTableFieldService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_TABLE_FIELD信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTTableField(T_TABLE_FIELD model)
        {
            var result = Fw.TTableFieldService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_TABLE_FIELD信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTTableField(string ids)
        {
            var result = Fw.TTableFieldService.Delete(ids);
            return JResult(result); 
        }
    }
}