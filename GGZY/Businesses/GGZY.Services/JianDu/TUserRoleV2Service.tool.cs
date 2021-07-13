using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TUserRoleV2Service : BaseServiceT<T_USER_ROLE_V2>
    {

        #region 接口实现

        public List<T_USER_ROLE_V2> FindList(T_USER_ROLE_V2 model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_USER_ROLE_V2> PageList(T_USER_ROLE_V2 model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, T_USER_ROLE_V2._.GROUP_ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="GROUP_ID">角色ID</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string GROUP_ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(T_USER_ROLE_V2._.GROUP_ID == GROUP_ID);

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
        public GeneralResult Edit(T_USER_ROLE_V2 model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.GROUP_ID);

                if (viewResult.Success && viewResult.Data is T_USER_ROLE_V2 entity)
                {
                    entity.Attach();
                    entity.GROUP_ID = model.GROUP_ID;
                    entity.NAME = model.NAME;
                    entity.DESCRIPTION = model.DESCRIPTION;
                    entity.SORT = model.SORT;
                    entity.STATUS = model.STATUS;
                    entity.CREATEDBY = model.CREATEDBY;
                    entity.CREATEDTIME = model.CREATEDTIME;
                    entity.UPDATEDBY = model.UPDATEDBY;
                    entity.UPDATEDTIME = model.UPDATEDTIME;
                    entity.IS_DELETE = model.IS_DELETE;
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
        public GeneralResult Add(T_USER_ROLE_V2 model)
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
                    Delete(T_USER_ROLE_V2._.GROUP_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_USER_ROLE_V2> model)
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
        protected WhereClipBuilder ConditionBuilder(T_USER_ROLE_V2 model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.GROUP_ID))
            {
                condition.And(T_USER_ROLE_V2._.GROUP_ID.Contain(model.GROUP_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.NAME))
            {
                condition.And(T_USER_ROLE_V2._.NAME.Contain(model.NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.DESCRIPTION))
            {
                condition.And(T_USER_ROLE_V2._.DESCRIPTION.Contain(model.DESCRIPTION));
            }
            if (model.SORT != null)
            {
                condition.And(T_USER_ROLE_V2._.SORT == (model.SORT));
            }
            if (model.STATUS != null)
            {
                condition.And(T_USER_ROLE_V2._.STATUS == (model.STATUS));
            }
            if (!string.IsNullOrWhiteSpace(model.CREATEDBY))
            {
                condition.And(T_USER_ROLE_V2._.CREATEDBY.Contain(model.CREATEDBY));
            }
            if (model.CREATEDTIME != null)
            {
                condition.And(T_USER_ROLE_V2._.CREATEDTIME == (model.CREATEDTIME));
            }
            if (!string.IsNullOrWhiteSpace(model.UPDATEDBY))
            {
                condition.And(T_USER_ROLE_V2._.UPDATEDBY.Contain(model.UPDATEDBY));
            }
            if (model.UPDATEDTIME != null)
            {
                condition.And(T_USER_ROLE_V2._.UPDATEDTIME == (model.UPDATEDTIME));
            }
            if (model.IS_DELETE != null)
            {
                condition.And(T_USER_ROLE_V2._.IS_DELETE == (model.IS_DELETE));
            }
            return condition;
        }
        #endregion
    }
}