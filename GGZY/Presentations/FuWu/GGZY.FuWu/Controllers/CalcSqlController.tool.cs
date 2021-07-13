using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdCalcSqlController:BaseController
    {
        /// <summary>
        /// 读取CALC_SQL列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadCalcSqls(CALC_SQL model, SearchCondition condition)
        {
            var result = Fw.CalcSqlService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取CALC_SQL明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadCalcSql(string ID)
        
        {
            var result = Fw.CalcSqlService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建CALC_SQL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateCalcSql(CALC_SQL model)
        {
            var result = Fw.CalcSqlService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新CALC_SQL信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateCalcSql(CALC_SQL model)
        {
            var result = Fw.CalcSqlService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除CALC_SQL信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteCalcSql(string ids)
        {
            var result = Fw.CalcSqlService.Delete(ids);
            return JResult(result); 
        }
    }
}