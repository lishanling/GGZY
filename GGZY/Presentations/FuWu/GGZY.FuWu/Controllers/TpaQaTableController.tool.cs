using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTpaQaTableController:BaseController
    {
        /// <summary>
        /// 读取TPA_QA_TABLE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTpaQaTables(TPA_QA_TABLE model, SearchCondition condition)
        {
            var result = Fw.TpaQaTableService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TPA_QA_TABLE明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTpaQaTable(decimal ID)
        
        {
            var result = Fw.TpaQaTableService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TPA_QA_TABLE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTpaQaTable(TPA_QA_TABLE model)
        {
            var result = Fw.TpaQaTableService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TPA_QA_TABLE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTpaQaTable(TPA_QA_TABLE model)
        {
            var result = Fw.TpaQaTableService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TPA_QA_TABLE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTpaQaTable(string ids)
        {
            var result = Fw.TpaQaTableService.Delete(ids);
            return JResult(result); 
        }
    }
}