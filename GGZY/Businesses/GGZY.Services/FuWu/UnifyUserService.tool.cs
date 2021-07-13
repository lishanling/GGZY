using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class UnifyUserService : BaseServiceT<UNIFY_USER>
    {
        #region 接口实现

        public List<UNIFY_USER> FindList(UNIFY_USER model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<UNIFY_USER> PageList(UNIFY_USER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, UNIFY_USER._.MGUID.Desc).ToBootstrapTableList(count);


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
            condition.And(UNIFY_USER._.MGUID == MGUID);

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
        public GeneralResult Edit(UNIFY_USER model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.MGUID);

                if (viewResult.Success && viewResult.Data is UNIFY_USER entity)
                {
                    entity.Attach();
                    entity.MGUID = model.MGUID;
                    entity.NAME = model.NAME;
                    entity.PWD = model.PWD;
                    entity.TYPE = model.TYPE;
                    entity.STATE = model.STATE;
                    entity.CREATEDBY = model.CREATEDBY;
                    entity.CREATEDTIME = model.CREATEDTIME;
                    entity.UPDATEDBY = model.UPDATEDBY;
                    entity.UPDATEDTIME = model.UPDATEDTIME;
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
        public GeneralResult Add(UNIFY_USER model)
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
                    Delete(UNIFY_USER._.MGUID.SelectIn(idArr));
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
        public GeneralResult Import(List<UNIFY_USER> model)
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
        protected WhereClipBuilder ConditionBuilder(UNIFY_USER model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.MGUID))
            {
                condition.And(UNIFY_USER._.MGUID.Contain(model.MGUID));
            }
            if (!string.IsNullOrWhiteSpace(model.NAME))
            {
                condition.And(UNIFY_USER._.NAME.Contain(model.NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.PWD))
            {
                condition.And(UNIFY_USER._.PWD.Contain(model.PWD));
            }
            if (model.TYPE != null)
            {
                condition.And(UNIFY_USER._.TYPE == (model.TYPE));
            }
            if (model.STATE != null)
            {
                condition.And(UNIFY_USER._.STATE == (model.STATE));
            }
            if (!string.IsNullOrWhiteSpace(model.CREATEDBY))
            {
                condition.And(UNIFY_USER._.CREATEDBY.Contain(model.CREATEDBY));
            }
            if (model.CREATEDTIME != null)
            {
                condition.And(UNIFY_USER._.CREATEDTIME == (model.CREATEDTIME));
            }
            if (!string.IsNullOrWhiteSpace(model.UPDATEDBY))
            {
                condition.And(UNIFY_USER._.UPDATEDBY.Contain(model.UPDATEDBY));
            }
            if (model.UPDATEDTIME != null)
            {
                condition.And(UNIFY_USER._.UPDATEDTIME == (model.UPDATEDTIME));
            }
            return condition;
        }
        #endregion
    }
}