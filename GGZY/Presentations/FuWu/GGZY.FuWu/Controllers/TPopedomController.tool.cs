using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTPopedomController:BaseController
    {
        /// <summary>
        /// 读取T_POPEDOM列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTPopedoms(T_POPEDOM model, SearchCondition condition)
        {
            var result = Fw.TPopedomService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_POPEDOM明细
        /// </summary>
      /// <param name="POPID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTPopedom(decimal POPID)
        
        {
            var result = Fw.TPopedomService.ViewByPk(POPID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_POPEDOM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTPopedom(T_POPEDOM model)
        {
            var result = Fw.TPopedomService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_POPEDOM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTPopedom(T_POPEDOM model)
        {
            var result = Fw.TPopedomService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_POPEDOM信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTPopedom(string ids)
        {
            var result = Fw.TPopedomService.Delete(ids);
            return JResult(result); 
        }
    }
}