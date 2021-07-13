using System;
using System.Linq;
using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.Framework.Controllers
{
    /// <summary>
    /// 文章
    /// </summary>
    [AllowAnonymous]
    public class ArticleController : BaseController
    {
        /// <summary>
        /// 首页轮播
        /// </summary>
        /// <param name="n">数量，默认6</param>
        /// <param name="pType">平台 jd fw</param>
        /// <returns></returns>
        public ActionResult RotationData(int n = 6, string pType = "fw")
        {
            if (pType.IndexOf("fw", StringComparison.CurrentCultureIgnoreCase) > -1)
            {
                var rotationArticles = Fw.PtArticleService.GetRotationData(n);
                var ls = rotationArticles.Select(c => new
                {
                    ID=c.ID.DesEncrypt(),
                    c.TITLE,
                    c.TYPE,
                    c.TM,
                    c.IMG_AID,
                    //c.CONTENTS,
                    //ImgUrl =Url.Action("GetFile","Home",new{fid=c.IMG_AID}),
                    ImgUrl =CommonAttachmentBuilder(c.IMG_AID)
                }).ToList();
                return JResult(ls);
            }
            else
            {
                var rotationArticles = Jd.PtArticleService.GetRotationData(n);
                var ls = rotationArticles.Select(c => new
                {
                    ID = c.ID.DesEncrypt(),
                    c.TITLE,
                    c.TYPE,
                    c.TM,
                    c.IMG_AID,
                    //c.CONTENTS,
                    ImgUrl =CommonAttachmentBuilder(c.IMG_AID,"Jd")
                }).ToList();
                return JResult(ls);

            }
        }
        /// <summary>
        /// 通知公告1073|接口规范 1071|行业动态-行政监督动态(列表) 1001|新闻中心1002|常见问题926
        /// </summary>
        /// <param name="model">数量，默认6</param>
        /// <param name="search">数量，默认6</param>
        /// <param name="pType">平台 jd fw</param>
        /// <returns></returns>
        public ActionResult PageList(PT_ARTICLE model, SearchCondition search, string pType = "fw")
        {
            PageTableResult pageList;
            if (pType.IndexOf("fw", StringComparison.CurrentCultureIgnoreCase) > -1)
            {
                var fwEntity = model.ConvertTo<GGZYFW.DbEntity.PT_ARTICLE>();
                pageList = Fw.PtArticleService.PageList(fwEntity, search).ToDataTableResult(search, c =>
                {
                    var n = new
                    {
                        ID = c.ID.DesEncrypt(),
                        TITLE = c.TITLE,
                        TYPE = c.TYPE,
                        TM = c.TM,
                        CONTENTS = c.CONTENTS
                    };
                    return n;
                });
            }
            else
            {
                pageList = Jd.PtArticleService.PageDataTable(model, search);
            }
            return JResult(pageList);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <param name="atype"></param>
        /// <param name="pType"></param>
        /// <returns></returns>
        public ActionResult PageTable(PT_ARTICLE model, SearchCondition search,PT_ATYPE atype, string pType = "fw")
        {
            PageTableResult pageList;
            if (pType.IndexOf("fw", StringComparison.CurrentCultureIgnoreCase) > -1)
            {
                var fwEntity = model.ConvertTo<GGZYFW.DbEntity.PT_ARTICLE>();
                var fwType = atype.ConvertTo<GGZYFW.DbEntity.PT_ATYPE>();
                pageList = Fw.PtArticleService.PageTableByTypeTxt(fwEntity, search, fwType);
            }
            else
            {
                pageList = Jd.PtArticleService.PageTableByTypeTxt(model, search, atype);

            }
            return JResult(pageList);
        }

        /// <summary>
        /// 文章详情
        /// </summary>
        /// <param name="id"></param>
        /// <param name="search"></param>
        /// <param name="pType">平台 jd fw</param>
        /// <returns></returns>
        public ActionResult Detail(string id, SearchCondition search, string pType = "fw")
        {
            var obj = pType.IndexOf("fw", StringComparison.CurrentCultureIgnoreCase) > -1 ?
                Fw.PtArticleService.ArticleDetail(id)
                : Jd.PtArticleService.ArticleDetail(id);
            return JResult(obj);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <param name="pType">平台 jd fw</param>
        /// <returns></returns>
        public ActionResult ArticleType(PT_ATYPE model, SearchCondition search, string pType = "fw")
        {
            var r = Jd.PtAtypeService.ArticleType(model, search);
            return JResult(r);
        }
    }
}