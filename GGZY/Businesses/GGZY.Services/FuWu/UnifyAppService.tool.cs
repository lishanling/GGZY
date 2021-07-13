using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class UnifyAppService : BaseServiceT<UNIFY_APP>
    {
        #region 接口实现

        public List<UNIFY_APP> FindList(UNIFY_APP model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<UNIFY_APP> PageList(UNIFY_APP model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, UNIFY_APP._.MGUID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="MGUID">主键</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string MGUID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(UNIFY_APP._.MGUID == MGUID);

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
        public GeneralResult Edit(UNIFY_APP model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.MGUID);

                if (viewResult.Success && viewResult.Data is UNIFY_APP entity)
                {
                    entity.Attach();
                    entity.MGUID = model.MGUID;
                    entity.APPKEY = model.APPKEY;
                    entity.APPNAME = model.APPNAME;
                    entity.APPICON = model.APPICON;
                    entity.SORT = model.SORT;
                    entity.HOSTURL = model.HOSTURL;
                    entity.APPTYPE = model.APPTYPE;
                    entity.CREATEDBY = model.CREATEDBY;
                    entity.CREATEDTIME = model.CREATEDTIME;
                    entity.UPDATEDBY = model.UPDATEDBY;
                    entity.UPDATEDTIME = model.UPDATEDTIME;
                    entity.SSOURL = model.SSOURL;
                    entity.OAUTHURL = model.OAUTHURL;
                    Update(entity);
                    result.SetSuccess(entity);
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
        public GeneralResult Add(UNIFY_APP model)
        {
            var result = new GeneralResult();
            try
            {
                Insert(model);
                result.SetSuccess(model);
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
                    Delete(UNIFY_APP._.MGUID.SelectIn(idArr));
                    result.SetSuccess(ids);
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

        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Import(List<UNIFY_APP> model)
        {
            GeneralResult result = new GeneralResult();
            try
            {

                result.SetSuccess(model);
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }


        #endregion

        #region Utils
        protected WhereClipBuilder ConditionBuilder(UNIFY_APP model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.MGUID))
            {
                condition.And(UNIFY_APP._.MGUID.Contain(model.MGUID));
            }
            if (!string.IsNullOrWhiteSpace(model.APPKEY))
            {
                condition.And(UNIFY_APP._.APPKEY.Contain(model.APPKEY));
            }
            if (!string.IsNullOrWhiteSpace(model.APPNAME))
            {
                condition.And(UNIFY_APP._.APPNAME.Contain(model.APPNAME));
            }
            if (!string.IsNullOrWhiteSpace(model.APPICON))
            {
                condition.And(UNIFY_APP._.APPICON.Contain(model.APPICON));
            }
            if (model.SORT != null)
            {
                condition.And(UNIFY_APP._.SORT == (model.SORT));
            }
            if (!string.IsNullOrWhiteSpace(model.HOSTURL))
            {
                condition.And(UNIFY_APP._.HOSTURL.Contain(model.HOSTURL));
            }
            if (!string.IsNullOrWhiteSpace(model.APPTYPE))
            {
                condition.And(UNIFY_APP._.APPTYPE.Contain(model.APPTYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.CREATEDBY))
            {
                condition.And(UNIFY_APP._.CREATEDBY.Contain(model.CREATEDBY));
            }
            if (model.CREATEDTIME != null)
            {
                condition.And(UNIFY_APP._.CREATEDTIME == (model.CREATEDTIME));
            }
            if (!string.IsNullOrWhiteSpace(model.UPDATEDBY))
            {
                condition.And(UNIFY_APP._.UPDATEDBY.Contain(model.UPDATEDBY));
            }
            if (model.UPDATEDTIME != null)
            {
                condition.And(UNIFY_APP._.UPDATEDTIME == (model.UPDATEDTIME));
            }
            if (!string.IsNullOrWhiteSpace(model.SSOURL))
            {
                condition.And(UNIFY_APP._.SSOURL.Contain(model.SSOURL));
            }
            if (!string.IsNullOrWhiteSpace(model.OAUTHURL))
            {
                condition.And(UNIFY_APP._.OAUTHURL.Contain(model.OAUTHURL));
            }
            return condition;
        }
        #endregion
    }
}