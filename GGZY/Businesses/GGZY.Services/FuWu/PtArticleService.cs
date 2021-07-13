using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Infrastructure.Helper;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class PtArticleService
    {
        
        /// <summary>
        /// 首页轮播
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<PT_ARTICLE> GetRotationData(int n=6)
        {
            return FindList(
                PT_ARTICLE._.STATE == 1
                && PT_ARTICLE._.IMG_NEWS == 1
                && PT_ARTICLE._.TYPE.In(11, 12, 13)
                && PT_ARTICLE._.IMG_AID.IsNotNull(),
                PT_ARTICLE._.TM.Desc && PT_ARTICLE._.ID.Desc).Take(n).ToList<PT_ARTICLE>();
            //var list = Cache.Get<List<PT_ARTICLE>>($"{ConfigHelper.APP_KEY_GGZYFW}:PT:ARTICLE:ROTATION", ConfigHelper.AppSettings.FW_PT_ARTICLE_CACHE_MINITE, () =>
            //{
               
            //});
            //return list;
        }
        /// <summary>
        /// 读取文章明细，并标记阅读数量
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        public GeneralResult ArticleDetail(string mid)
        {
            var id = mid.DesDecrypt();
            var r = ViewByPk(id.ToNullableDecimal());
            if (r.Success && r.Data is PT_ARTICLE entity)
            {
                entity.Attach();
                entity.READ_NUM = entity.READ_NUM + 1 ?? 0;
                Update(entity);
            }

            return r;
        }

        public BootstrapTableResult<PT_ARTICLE> PageList(PT_ARTICLE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            if (search.BeginTime.HasValue)
            {
                condition.And(PT_ARTICLE._.TM >= search.BeginTime.Value);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(PT_ARTICLE._.TM <= search.EndTime.Value);
            }

            var count = Count(condition);
            var pageList = PageList(condition, search, PT_ARTICLE._.TM.Desc).ToBootstrapTableList(count);


            return pageList;
        }

     

        public PageTableResult PageTableByTypeTxt(PT_ARTICLE model, SearchCondition search, PT_ATYPE atype)
        {
            model.STATE = "1";
            var condition = ConditionBuilder(model);
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                condition.And(PT_ARTICLE._.TITLE.Contain(search.KeyWord));
            }
            if (search.BeginTime.HasValue)
            {
                condition.And(PT_ARTICLE._.TM >= search.BeginTime.Value);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(PT_ARTICLE._.TM <= search.EndTime.Value);
            }

            //if (!string.IsNullOrWhiteSpace(search.KeyWord))
            //{
            //    condition.And(PT_ARTICLE._.TITLE.Contain(search.KeyWord));
            //}

            var count = FromWhere(condition.ToWhereClip())
                .InnerJoin<PT_ATYPE>(PT_ATYPE._.TEXT == atype.TEXT && PT_ATYPE._.ID == PT_ARTICLE._.TYPE)
                .Count();
            return FromWhere(condition.ToWhereClip())
                .InnerJoin<PT_ATYPE>(PT_ATYPE._.TEXT == atype.TEXT && PT_ATYPE._.ID == PT_ARTICLE._.TYPE)
                .Page(search.PageSize, search.PageNo)
                .OrderBy(PT_ARTICLE._.TM.Desc).Select(PT_ARTICLE._.All)
                .ToList()
                .ToPageTableResult(search, count, c =>
                {
                    var n = new 
                    {
                        ID = c.ID.DesEncrypt(),
                        TITLE = c.TITLE,
                        TYPE = c.TYPE,
                        TM = c.TM,
                        CONTENTS = ""
                    };
                    return n;
                });
        }

        /// <summary>
        /// 文章全文检索
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public object NewsKeywordSearch(SearchCondition search)
        {
            var condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                condition.And(PT_ARTICLE._.TITLE.Contain(search.KeyWord));
            }
            if (search.BeginTime.HasValue)
            {
                condition.And(PT_ARTICLE._.TM >= search.BeginTime.Value);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(PT_ARTICLE._.TM <= search.EndTime.Value);
            }
            var count = Count(condition);
            var articles = FromWhere(condition.ToWhereClip())
                .Select(
                    PT_ARTICLE._.ID,
                    PT_ARTICLE._.TITLE,
                    PT_ARTICLE._.TM
                    //,new Field("'NEWS'").As("Kind")
                )
                .Page(search.PageSize,search.PageNo)
                .OrderBy(PT_ARTICLE._.TM.Desc)
                .ToList<PT_ARTICLE>().ToPageTableResult(search, count,c=>new
                {
                    Id=c.ID.ToString().DesEncrypt(),
                    Title=c.TITLE,
                    Tm=c.TM,
                    Kind="NEWS",
                });
            //var articles = PageList(condition, search, PT_ARTICLE._.TM.Desc)
            //    .Select(c => new { Id = c.ID, Title = c.TITLE, Tm=c.TM, Kind = "NEWS" })
            //    .ToDataTable(search,count);
            return articles;
        }

        #region Utils
        protected WhereClipBuilder ConditionBuilder(PT_ARTICLE model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(PT_ARTICLE._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.TITLE))
            {
                condition.And(PT_ARTICLE._.TITLE.Contain(model.TITLE));
            }
            if (!string.IsNullOrWhiteSpace(model.TITLE_SHORT))
            {
                condition.And(PT_ARTICLE._.TITLE_SHORT.Contain(model.TITLE_SHORT));
            }
            if (!string.IsNullOrWhiteSpace(model.SOURCES))
            {
                condition.And(PT_ARTICLE._.SOURCES.Contain(model.SOURCES));
            }
            if (!string.IsNullOrWhiteSpace(model.WRITER))
            {
                condition.And(PT_ARTICLE._.WRITER.Contain(model.WRITER));
            }
            if (model.U_ID != null)
            {
                condition.And(PT_ARTICLE._.U_ID == (model.U_ID));
            }
            //if(!string.IsNullOrWhiteSpace(model.TYPE))
            //{
            //  condition.And(PT_ARTICLE._.TYPE.Contain(model.TYPE));
            //}
            if (!string.IsNullOrWhiteSpace(model.TYPE))
            {
                if (model.TYPE.Contains(","))
                {
                    var types = model.TYPE.Split(',').Where(c => !string.IsNullOrWhiteSpace(c)).Distinct().ToList();
                    condition.And(PT_ARTICLE._.TYPE.In(types));
                }
                else
                {
                    condition.And(PT_ARTICLE._.TYPE == (model.TYPE));
                }

            }
            if (model.IMG_AID != null)
            {
                condition.And(PT_ARTICLE._.IMG_AID == (model.IMG_AID));
            }
            if (!string.IsNullOrWhiteSpace(model.CONTENTS_SHORT))
            {
                condition.And(PT_ARTICLE._.CONTENTS_SHORT.Contain(model.CONTENTS_SHORT));
            }
            if (model.TM != null)
            {
                condition.And(PT_ARTICLE._.TM == (model.TM));
            }
            if (model.READ_NUM != null)
            {
                condition.And(PT_ARTICLE._.READ_NUM == (model.READ_NUM));
            }
            if (!string.IsNullOrWhiteSpace(model.STATE))
            {
                condition.And(PT_ARTICLE._.STATE.Contain(model.STATE));
            }
            if (model.ISTOP != null)
            {
                condition.And(PT_ARTICLE._.ISTOP == (model.ISTOP));
            }
            if (!string.IsNullOrWhiteSpace(model.FLAGS))
            {
                condition.And(PT_ARTICLE._.FLAGS.Contain(model.FLAGS));
            }
            if (model.ORDERID != null)
            {
                condition.And(PT_ARTICLE._.ORDERID == (model.ORDERID));
            }
            if (model.REMOTE != null)
            {
                condition.And(PT_ARTICLE._.REMOTE == (model.REMOTE));
            }
            if (model.AUTOLITPIC != null)
            {
                condition.And(PT_ARTICLE._.AUTOLITPIC == (model.AUTOLITPIC));
            }
            if (model.CREATE_TM != null)
            {
                condition.And(PT_ARTICLE._.CREATE_TM == (model.CREATE_TM));
            }
            if (model.IMG_NEWS != null)
            {
                condition.And(PT_ARTICLE._.IMG_NEWS == (model.IMG_NEWS));
            }
            if (model.IS_IMPORT != null)
            {
                condition.And(PT_ARTICLE._.IS_IMPORT == (model.IS_IMPORT));
            }
            if (model.IS_REPLY != null)
            {
                condition.And(PT_ARTICLE._.IS_REPLY == (model.IS_REPLY));
            }
            if (!string.IsNullOrWhiteSpace(model.CONTENTS))
            {
                condition.And(PT_ARTICLE._.CONTENTS.Contain(model.CONTENTS));
            }
            return condition;
        }
        #endregion
    }
}