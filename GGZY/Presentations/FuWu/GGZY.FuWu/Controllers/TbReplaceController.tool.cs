using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTbReplaceController:BaseController
    {
        /// <summary>
        /// 读取TB_REPLACE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTbReplaces(TB_REPLACE model, SearchCondition condition)
        {
            var result = Fw.TbReplaceService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TB_REPLACE明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTbReplace(decimal ID)
        
        {
            var result = Fw.TbReplaceService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TB_REPLACE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTbReplace(TB_REPLACE model)
        {
            var result = Fw.TbReplaceService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TB_REPLACE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTbReplace(TB_REPLACE model)
        {
            var result = Fw.TbReplaceService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TB_REPLACE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTbReplace(string ids)
        {
            var result = Fw.TbReplaceService.Delete(ids);
            return JResult(result); 
        }
    }
}