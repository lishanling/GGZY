using System;
using System.Linq;
using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZY.Services.Infrastructure.Helper;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Portal.Controllers
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
        /// <returns></returns>
        public ActionResult RotationData(int n = 6)
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
                ImgUrl = CommonAttachmentBuilder(c.IMG_AID, "Jd")
            }).ToList();
            return JResult(ls);
        }
        /// <summary>
        /// 通知公告1073|接口规范 1071|行业动态-行政监督动态(列表) 1001|新闻中心1002|常见问题926
        /// </summary>
        /// <param name="model">数量，默认6</param>
        /// <param name="search">数量，默认6</param>
        /// <param name="pType">平台 jd fw</param>
        /// <returns></returns>
        public ActionResult PageList(PT_ARTICLE model, SearchCondition search,string pType)
        {
            PageTableResult pageList=null;
            if (string.Compare(pType, "fw", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                var fwModel = model.ConvertTo<GGZYFW.DbEntity.PT_ARTICLE>();
                pageList = Fw.PtArticleService.PageList(fwModel, search).ToPageTableResult(search, c =>
                {
                    var n = new
                    {
                        ID = c.ID.DesEncrypt(),
                        TITLE = c.TITLE,
                        TYPE = c.TYPE,
                        TM = c.TM,
                        CONTENTS = c.CONTENTS,
                        c.SOURCES
                    };
                    return n;
                });
            }
            else
            {
                var cacheKey = $"{ConfigHelper.APP_KEY_GGZYJD}:ARTICLE:PAGELIST:{model.TYPE}:{search.PageSize}";
                if (search.PageSize < 10&& Cache.IsSet(cacheKey))
                {
                    pageList = Cache.Get<PageTableResult>(cacheKey);
                }

                if (pageList == null)
                {
                    pageList = Jd.PtArticleService.PageDataTable(model, search);
                }

                if (search.PageSize < 10 && !Cache.IsSet(cacheKey))
                {
                    Cache.Set(cacheKey, pageList, 10);
                }
               
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
        public ActionResult PageTable(PT_ARTICLE model, SearchCondition search,PT_ATYPE atype)
        {
            PageTableResult pageList = Jd.PtArticleService.PageTableByTypeTxt(model, search, atype);
            return JResult(pageList);
        }

        /// <summary>
        /// 文章详情
        /// </summary>
        /// <param name="id"></param>
        /// <param name="search"></param>
        /// <param name="pType">平台 jd fw</param>
        /// <returns></returns>
        public ActionResult Detail(string id, SearchCondition search, string pType)
        {
            GeneralResult obj;
            if (string.Compare(pType, "fw", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                obj = Fw.PtArticleService.ArticleDetail(id);
            }
            else
            {
                obj = Jd.PtArticleService.ArticleDetail(id);
            }

            return JResult(obj);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <param name="pType">平台 jd fw</param>
        /// <returns></returns>
        public ActionResult ArticleType(PT_ATYPE model, SearchCondition search, string pType)
        {
            var r = Jd.PtAtypeService.ArticleType(model, search);
            return JResult(r);
        }
    }
}