using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Helper;
using GGZYJD.DbEntity;


namespace GGZY.Services.JianDu
{
    public partial class PtArticleService
    {
        /// <summary>
        /// 闽政通小程序过渡页重要新闻
        /// </summary>
        /// <returns></returns>
        public object MztTopNews()
        {
           var r=FromWhere(PT_ARTICLE._.STATE == "1" && PT_ARTICLE._.TYPE == "1073" &&PT_ARTICLE._.IS_IMPORT=="1" && PT_ARTICLE._.SOURCES.IsNotNull())
                .OrderByDescending(PT_ARTICLE._.TM).ToFirst();
           return r;
        }
        /// <summary>
        /// 获取轮播图片数据
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<PT_ARTICLE> GetRotationData(int n = 6)
        {
            //var list = Cache.Get($"{ConfigHelper.APP_KEY_GGZYJD}:PT:ARTICLE:ROTATION:{n}", ConfigHelper.AppSettings.JD_PT_ARTICLE_CACHE_MINITE,() =>{
            var condition = ConditionBuilder(new PT_ARTICLE { STATE = "1" });
            condition.And(PT_ARTICLE._.IMG_AID.IsNotNull());
            return FromWhere(condition.ToWhereClip())
                         .OrderBy(PT_ARTICLE._.TM.Desc && PT_ARTICLE._.ID.Desc)
                         .Select(PT_ARTICLE._.ID, PT_ARTICLE._.TITLE, PT_ARTICLE._.TYPE, PT_ARTICLE._.IMG_AID, PT_ARTICLE._.TM)
                         .Top(n).ToList();
            //    });
            //return list;
        }
        public PageTableResult PageDataTable(PT_ARTICLE model, SearchCondition search)
        {
            model.STATE = "1";
            var condition = ConditionBuilder(model);
            if (search.BeginTime.HasValue)
            {
                condition.And(PT_ARTICLE._.TM >= search.BeginTime.Value);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(PT_ARTICLE._.TM <= search.EndTime.Value);
            }


            var reg = new Regex(@"(<[^>]*>)|(&nbsp;?)|(\s)", RegexOptions.IgnoreCase);
            var count = Count(condition);
            //return PageList(condition, search, PT_ARTICLE._.TM.Desc && PT_ARTICLE._.ID.Desc)
            var list = FromWhere(condition.ToWhereClip())
                .Page(search.PageSize, search.PageNo)
                .OrderBy(PT_ARTICLE._.TM.Desc && PT_ARTICLE._.ID.Desc)
                .Select(PT_ARTICLE._.ID, PT_ARTICLE._.TITLE, PT_ARTICLE._.TYPE, PT_ARTICLE._.TM, PT_ARTICLE._.CONTENTS)
                .ToList();
            var pageList = list.ToPageTableResult(search, count, c =>
              {
                  var content = reg.Replace(c.CONTENTS, "");
                    //if (model.TYPE != "1073" && model.TYPE != "1071")//通知公告(列表)1073 接口规范1071
                    //{
                    //    content = reg.Replace(c.CONTENTS, "");
                    //}
                    var n = new
                  {
                      ID = c.ID.DesEncrypt(),
                      TITLE = c.TITLE,
                      TYPE = c.TYPE,
                      TM = c.TM,
                      CONTENTS = content,
                      c.SOURCES
                  };
                  return n;
              });
            //var pageList = Cache.Get($"JD:PT:ARTICLE:TYPE_{model.TYPE}_{search.PageNo}", () =>
            //{

            //});
            return pageList;
        }
        /// <summary>
        /// 通过文字类型名称分页获取文字信息
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <param name="atype"></param>
        /// <returns></returns>
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

            if (!string.IsNullOrWhiteSpace(atype.TEXT))
            {
                if (atype.TEXT.Contains(","))
                {
                    var aTypeTxt = atype.TEXT.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    condition.And(PT_ATYPE._.TEXT.In(aTypeTxt));
                }
                else
                {
                    condition.And(PT_ATYPE._.TEXT == atype.TEXT);
                }

            }
            var query = FromWhere(condition.ToWhereClip())
                .InnerJoin<PT_ATYPE>(PT_ATYPE._.ID == PT_ARTICLE._.TYPE);
            var count = query.Count();
            var list = query
                .Page(search.PageSize, search.PageNo)
                .OrderBy(PT_ARTICLE._.TM.Desc)
                .Select(PT_ARTICLE._.ID, PT_ARTICLE._.TITLE, PT_ARTICLE._.TM)
                .ToList();
            var pageList = list
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
            return pageList;
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
            else
            {
                condition.And(PT_ARTICLE._.SOURCES.IsNotNull());
            }
            if (!string.IsNullOrWhiteSpace(model.WRITER))
            {
                condition.And(PT_ARTICLE._.WRITER.Contain(model.WRITER));
            }
            if (model.U_ID != null)
            {
                condition.And(PT_ARTICLE._.U_ID == (model.U_ID));
            }
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
            if (!string.IsNullOrWhiteSpace(model.CONTENTS_SHORT))
            {
                condition.And(PT_ARTICLE._.CONTENTS_SHORT.Contain(model.CONTENTS_SHORT));
            }
            if (!string.IsNullOrWhiteSpace(model.CONTENTS))
            {
                condition.And(PT_ARTICLE._.CONTENTS.Contain(model.CONTENTS));
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
                condition.And(PT_ARTICLE._.STATE==(model.STATE));
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
            if (!string.IsNullOrWhiteSpace(model.AIDS))
            {
                condition.And(PT_ARTICLE._.AIDS.Contain(model.AIDS));
            }
            if (!string.IsNullOrWhiteSpace(model.IMG_AID))
            {
                condition.And(PT_ARTICLE._.IMG_AID.Contain(model.IMG_AID));
            }
            return condition;
        }
        #endregion
    }
}