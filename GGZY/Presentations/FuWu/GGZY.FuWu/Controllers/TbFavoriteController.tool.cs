using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTbFavoriteController:BaseController
    {
        /// <summary>
        /// 读取TB_FAVORITE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTbFavorites(TB_FAVORITE model, SearchCondition condition)
        {
            var result = Fw.TbFavoriteService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TB_FAVORITE明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTbFavorite(decimal ID)
        
        {
            var result = Fw.TbFavoriteService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TB_FAVORITE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTbFavorite(TB_FAVORITE model)
        {
            var result = Fw.TbFavoriteService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TB_FAVORITE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTbFavorite(TB_FAVORITE model)
        {
            var result = Fw.TbFavoriteService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TB_FAVORITE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTbFavorite(string ids)
        {
            var result = Fw.TbFavoriteService.Delete(ids);
            return JResult(result); 
        }
    }
}