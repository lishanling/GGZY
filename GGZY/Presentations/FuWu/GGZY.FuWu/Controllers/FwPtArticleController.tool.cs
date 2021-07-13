using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class FwPtArticleController : BaseController
    {
        /// <summary>
        /// 读取PT_ARTICLE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPtArticles(PT_ARTICLE model, SearchCondition condition)
        {
            var result = Fw.PtArticleService.PageList(model, condition);
            return JResult(result);
        }
        /// <summary>
        /// 读取PT_ARTICLE明细
        /// </summary>
        /// <param name="ID">编号</param>
        /// <returns></returns>
        /// <returns></returns>
        public ActionResult ReadPtArticle(decimal ID)
        {
            var result = Fw.PtArticleService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PT_ARTICLE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePtArticle(PT_ARTICLE model)
        {
            var result = Fw.PtArticleService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PT_ARTICLE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePtArticle(PT_ARTICLE model)
        {
            var result = Fw.PtArticleService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PT_ARTICLE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePtArticle(string ids)
        {
            
            var result = Fw.PtArticleService.Delete(ids);
            return JResult(result);
        }
    }
}