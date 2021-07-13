using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTIndexshowSetController:BaseController
    {
        /// <summary>
        /// 读取T_INDEXSHOW_SET列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTIndexshowSets(T_INDEXSHOW_SET model, SearchCondition condition)
        {
            var result = Fw.TIndexshowSetService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_INDEXSHOW_SET明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTIndexshowSet(decimal ID)
        
        {
            var result = Fw.TIndexshowSetService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_INDEXSHOW_SET信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTIndexshowSet(T_INDEXSHOW_SET model)
        {
            var result = Fw.TIndexshowSetService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_INDEXSHOW_SET信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTIndexshowSet(T_INDEXSHOW_SET model)
        {
            var result = Fw.TIndexshowSetService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_INDEXSHOW_SET信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTIndexshowSet(string ids)
        {
            var result = Fw.TIndexshowSetService.Delete(ids);
            return JResult(result); 
        }
    }
}