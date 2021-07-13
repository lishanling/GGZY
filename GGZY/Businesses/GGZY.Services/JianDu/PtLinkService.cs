using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Helper;
using GGZYFW.DbEntity;
using PT_LINK = GGZYJD.DbEntity.PT_LINK;

namespace GGZY.Services.JianDu
{
    public partial class PtLinkService 
    {

        #region 友情链接 

        public List<object> Link(PT_LINK model)
        {
          return  FindList(PT_LINK._.TYPE == model.TYPE, PT_LINK._.ORDERID.Asc && PT_LINK._.ID.Asc).ToList<object>();
            //var links = Cache.Get<List<object>>($"{ConfigHelper.APP_KEY_GGZYJD}:PT:LINK:{model.TYPE}",
            //    ConfigHelper.AppSettings.JD_PT_LINK_CACHE_MINITE,
            //    () => FindList(PT_LINK._.TYPE == model.TYPE, PT_LINK._.ORDERID.Asc && PT_LINK._.ID.Asc).ToList<object>());
            //return links;
        }

        protected void RemoveLinkCache(string type="")
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                Cache.RemoveByPattern($"{ConfigHelper.APP_KEY_GGZYJD}:PT:LINK");
            }
            Cache.Remove($"{ConfigHelper.APP_KEY_GGZYJD}:PT:LINK:{type}");
        }

        #endregion

        #region 友情链接CUD

        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public GeneralResult ViewByPk(decimal? ID)
        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(PT_LINK._.ID == ID);

            var dbModel = FirstOrNull(condition);
            if (dbModel == null)
            {
                result.SetFail(OBJECT_NOT_EXIST);
            }
            else
            {
                result.SetSuccess(dbModel);
            }
            return result;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Edit(PT_LINK model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is PT_LINK entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.TITLE = model.TITLE;
                    entity.ADDRESS = model.ADDRESS;
                    entity.TYPE = model.TYPE;
                    entity.TIME = model.TIME;
                    entity.ORDERID = model.ORDERID;
                    Update(entity);
                    result.SetSuccess(entity);
                    RemoveLinkCache(model.TYPE);
                }
                else
                {
                    result.SetFail(viewResult.Msg);
                }
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Add(PT_LINK model)
        {
            var result = new GeneralResult();
            try
            {
                Insert(model);
                result.SetSuccess(model);
                RemoveLinkCache(model.TYPE);
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public GeneralResult Delete(params string[] ids)
        {
            GeneralResult result = new GeneralResult();
            try
            {
                List<string> idArr = new List<string>();
                foreach (var id in ids)
                {
                    idArr.AddRange(id.Split(','));
                }

                if (idArr.Any())
                {
                    Delete(PT_LINK._.ID.SelectIn(idArr));
                    result.SetSuccess(ids);
                    RemoveLinkCache();
                }
                else
                {
                    result.SetFail($"请选择要删除的记录");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                result.SetFail(e.Message, e);
            }
            return result;
        }

        #endregion
    }
}