using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTableFliedController:BaseController
    {
        /// <summary>
        /// 读取TABLE_FLIED列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTableFlieds(TABLE_FLIED model, SearchCondition condition)
        {
            var result = Fw.TableFliedService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TABLE_FLIED明细
        /// </summary>
      /// <param name="CODE">编码</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTableFlied(decimal CODE)
        
        {
            var result = Fw.TableFliedService.ViewByPk(CODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建TABLE_FLIED信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTableFlied(TABLE_FLIED model)
        {
            var result = Fw.TableFliedService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TABLE_FLIED信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTableFlied(TABLE_FLIED model)
        {
            var result = Fw.TableFliedService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TABLE_FLIED信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTableFlied(string ids)
        {
            var result = Fw.TableFliedService.Delete(ids);
            return JResult(result); 
        }
    }
}