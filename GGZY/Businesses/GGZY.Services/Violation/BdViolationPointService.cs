using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BdViolationPointService : BaseServiceT<BD_VIOLATION_POINT>
    {
        #region 接口实现

        public List<BD_VIOLATION_POINT> FindList(BD_VIOLATION_POINT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BD_VIOLATION_POINT> PageList(BD_VIOLATION_POINT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, BD_VIOLATION_POINT._.ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(decimal? ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(BD_VIOLATION_POINT._.ID == ID);

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
        public GeneralResult Edit(BD_VIOLATION_POINT model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is BD_VIOLATION_POINT entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.CATEGORY_NAME = model.CATEGORY_NAME;
                    entity.CATEGORY_CODE = model.CATEGORY_CODE;
                    entity.PARENT_ID = model.PARENT_ID;
                    entity.TENDER_PROJECT_TYPE = model.TENDER_PROJECT_TYPE;
                    entity.IS_ENABLE = model.IS_ENABLE;
                    entity.IS_DELETE = model.IS_DELETE;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    //Update(entity);
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
        public GeneralResult Add(BD_VIOLATION_POINT model)
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
                    Delete(BD_VIOLATION_POINT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BD_VIOLATION_POINT> model)
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
        protected WhereClipBuilder ConditionBuilder(BD_VIOLATION_POINT model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(BD_VIOLATION_POINT._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.CATEGORY_NAME))
            {
                condition.And(BD_VIOLATION_POINT._.CATEGORY_NAME.Contain(model.CATEGORY_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.CATEGORY_CODE))
            {
                condition.And(BD_VIOLATION_POINT._.CATEGORY_CODE.Contain(model.CATEGORY_CODE));
            }
            if (model.PARENT_ID != null)
            {
                condition.And(BD_VIOLATION_POINT._.PARENT_ID == (model.PARENT_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition.And(BD_VIOLATION_POINT._.TENDER_PROJECT_TYPE.Contain(model.TENDER_PROJECT_TYPE));
            }
            if (model.IS_ENABLE != null)
            {
                condition.And(BD_VIOLATION_POINT._.IS_ENABLE == (model.IS_ENABLE));
            }
            if (model.IS_DELETE != null)
            {
                condition.And(BD_VIOLATION_POINT._.IS_DELETE == (model.IS_DELETE));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(BD_VIOLATION_POINT._.CREATE_TIME == (model.CREATE_TIME));
            }
            return condition;
        }
        #endregion
    }
}