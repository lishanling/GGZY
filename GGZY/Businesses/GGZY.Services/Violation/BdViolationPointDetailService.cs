using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BdViolationPointDetailService : BaseServiceT<BD_VIOLATION_POINT_DETAIL>
    {
        #region 接口实现

        public List<BD_VIOLATION_POINT_DETAIL> FindList(BD_VIOLATION_POINT_DETAIL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BD_VIOLATION_POINT_DETAIL> PageList(BD_VIOLATION_POINT_DETAIL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, BD_VIOLATION_POINT_DETAIL._.ID.Desc).ToBootstrapTableList(count);


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
            condition.And(BD_VIOLATION_POINT_DETAIL._.ID == ID);

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
        public GeneralResult Edit(BD_VIOLATION_POINT_DETAIL model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is BD_VIOLATION_POINT_DETAIL entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.NAME = model.NAME;
                    entity.CODE = model.CODE;
                    entity.DESCRIPTION = model.DESCRIPTION;
                    entity.RULE_DESCRIPTION = model.RULE_DESCRIPTION;
                    entity.RESULT_MSG = model.RESULT_MSG;
                    entity.SCORE = model.SCORE;
                    entity.POINT_TYPE = model.POINT_TYPE;
                    entity.CHECK_EXPRESSION = model.CHECK_EXPRESSION;
                    entity.RESULT_EXPRESSION = model.RESULT_EXPRESSION;
                    entity.CHECK_TIME = model.CHECK_TIME;
                    entity.SORT = model.SORT;
                    entity.IS_ENABLE = model.IS_ENABLE;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    entity.IS_DELETE = model.IS_DELETE;
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
        public GeneralResult Add(BD_VIOLATION_POINT_DETAIL model)
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
                    Delete(BD_VIOLATION_POINT_DETAIL._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BD_VIOLATION_POINT_DETAIL> model)
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
        protected WhereClipBuilder ConditionBuilder(BD_VIOLATION_POINT_DETAIL model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(BD_VIOLATION_POINT_DETAIL._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.NAME))
            {
                condition.And(BD_VIOLATION_POINT_DETAIL._.NAME.Contain(model.NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.CODE))
            {
                condition.And(BD_VIOLATION_POINT_DETAIL._.CODE.Contain(model.CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.DESCRIPTION))
            {
                condition.And(BD_VIOLATION_POINT_DETAIL._.DESCRIPTION.Contain(model.DESCRIPTION));
            }
            if (!string.IsNullOrWhiteSpace(model.RULE_DESCRIPTION))
            {
                condition.And(BD_VIOLATION_POINT_DETAIL._.RULE_DESCRIPTION.Contain(model.RULE_DESCRIPTION));
            }
            if (!string.IsNullOrWhiteSpace(model.RESULT_MSG))
            {
                condition.And(BD_VIOLATION_POINT_DETAIL._.RESULT_MSG.Contain(model.RESULT_MSG));
            }
            if (model.SCORE != null)
            {
                condition.And(BD_VIOLATION_POINT_DETAIL._.SCORE == (model.SCORE));
            }
            if (model.POINT_TYPE != null)
            {
                condition.And(BD_VIOLATION_POINT_DETAIL._.POINT_TYPE == (model.POINT_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.CHECK_EXPRESSION))
            {
                condition.And(BD_VIOLATION_POINT_DETAIL._.CHECK_EXPRESSION.Contain(model.CHECK_EXPRESSION));
            }
            if (!string.IsNullOrWhiteSpace(model.RESULT_EXPRESSION))
            {
                condition.And(BD_VIOLATION_POINT_DETAIL._.RESULT_EXPRESSION.Contain(model.RESULT_EXPRESSION));
            }
            if (model.CHECK_TIME != null)
            {
                condition.And(BD_VIOLATION_POINT_DETAIL._.CHECK_TIME == (model.CHECK_TIME));
            }
            if (model.SORT != null)
            {
                condition.And(BD_VIOLATION_POINT_DETAIL._.SORT == (model.SORT));
            }
            if (model.IS_ENABLE != null)
            {
                condition.And(BD_VIOLATION_POINT_DETAIL._.IS_ENABLE == (model.IS_ENABLE));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(BD_VIOLATION_POINT_DETAIL._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (model.IS_DELETE != null)
            {
                condition.And(BD_VIOLATION_POINT_DETAIL._.IS_DELETE == (model.IS_DELETE));
            }
            return condition;
        }
        #endregion
    }
}