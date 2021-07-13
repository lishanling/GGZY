using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class WarnExpressionDetailService : BaseServiceT<WARN_EXPRESSION_DETAIL>
    {
        #region 接口实现

        public List<WARN_EXPRESSION_DETAIL> FindList(WARN_EXPRESSION_DETAIL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<WARN_EXPRESSION_DETAIL> PageList(WARN_EXPRESSION_DETAIL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, WARN_EXPRESSION_DETAIL._.M_ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="M_ID">M_ID</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(decimal? M_ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(WARN_EXPRESSION_DETAIL._.M_ID == M_ID);

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
        public GeneralResult Edit(WARN_EXPRESSION_DETAIL model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.M_ID);

                if (viewResult.Success && viewResult.Data is WARN_EXPRESSION_DETAIL entity)
                {
                    entity.Attach();
                    entity.M_ID = model.M_ID;
                    entity.PARENT_M_ID = model.PARENT_M_ID;
                    entity.SP_NAME = model.SP_NAME;
                    entity.MAIN_TABLE = model.MAIN_TABLE;
                    entity.MAIN_FIELD = model.MAIN_FIELD;
                    entity.EXPRESSION_TYPE = model.EXPRESSION_TYPE;
                    entity.TARGET_TABLE = model.TARGET_TABLE;
                    entity.TARGET_FIELD = model.TARGET_FIELD;
                    entity.CONST_NUMBER = model.CONST_NUMBER;
                    entity.CONST_STRING = model.CONST_STRING;
                    entity.EXECUTE_SQL = model.EXECUTE_SQL;
                    entity.ISDELETE = model.ISDELETE;
                    entity.DELETE_TIME = model.DELETE_TIME;
                    entity.CREAT_TIME = model.CREAT_TIME;
                    entity.LIMIT_DAY = model.LIMIT_DAY;
                    entity.LIMIT_DAY_UNIT = model.LIMIT_DAY_UNIT;
                    entity.CHECK_TIME = model.CHECK_TIME;
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
        public GeneralResult Add(WARN_EXPRESSION_DETAIL model)
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
                    Delete(WARN_EXPRESSION_DETAIL._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<WARN_EXPRESSION_DETAIL> model)
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
        protected WhereClipBuilder ConditionBuilder(WARN_EXPRESSION_DETAIL model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.M_ID != null)
            {
                condition.And(WARN_EXPRESSION_DETAIL._.M_ID == (model.M_ID));
            }
            if (model.PARENT_M_ID != null)
            {
                condition.And(WARN_EXPRESSION_DETAIL._.PARENT_M_ID == (model.PARENT_M_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.SP_NAME))
            {
                condition.And(WARN_EXPRESSION_DETAIL._.SP_NAME.Contain(model.SP_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.MAIN_TABLE))
            {
                condition.And(WARN_EXPRESSION_DETAIL._.MAIN_TABLE.Contain(model.MAIN_TABLE));
            }
            if (!string.IsNullOrWhiteSpace(model.MAIN_FIELD))
            {
                condition.And(WARN_EXPRESSION_DETAIL._.MAIN_FIELD.Contain(model.MAIN_FIELD));
            }
            if (!string.IsNullOrWhiteSpace(model.EXPRESSION_TYPE))
            {
                condition.And(WARN_EXPRESSION_DETAIL._.EXPRESSION_TYPE.Contain(model.EXPRESSION_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.TARGET_TABLE))
            {
                condition.And(WARN_EXPRESSION_DETAIL._.TARGET_TABLE.Contain(model.TARGET_TABLE));
            }
            if (!string.IsNullOrWhiteSpace(model.TARGET_FIELD))
            {
                condition.And(WARN_EXPRESSION_DETAIL._.TARGET_FIELD.Contain(model.TARGET_FIELD));
            }
            if (!string.IsNullOrWhiteSpace(model.CONST_NUMBER))
            {
                condition.And(WARN_EXPRESSION_DETAIL._.CONST_NUMBER.Contain(model.CONST_NUMBER));
            }
            if (!string.IsNullOrWhiteSpace(model.CONST_STRING))
            {
                condition.And(WARN_EXPRESSION_DETAIL._.CONST_STRING.Contain(model.CONST_STRING));
            }
            if (!string.IsNullOrWhiteSpace(model.EXECUTE_SQL))
            {
                condition.And(WARN_EXPRESSION_DETAIL._.EXECUTE_SQL.Contain(model.EXECUTE_SQL));
            }
            if (model.ISDELETE != null)
            {
                condition.And(WARN_EXPRESSION_DETAIL._.ISDELETE == (model.ISDELETE));
            }
            if (model.DELETE_TIME != null)
            {
                condition.And(WARN_EXPRESSION_DETAIL._.DELETE_TIME == (model.DELETE_TIME));
            }
            if (model.CREAT_TIME != null)
            {
                condition.And(WARN_EXPRESSION_DETAIL._.CREAT_TIME == (model.CREAT_TIME));
            }
            if (model.LIMIT_DAY != null)
            {
                condition.And(WARN_EXPRESSION_DETAIL._.LIMIT_DAY == (model.LIMIT_DAY));
            }
            if (model.LIMIT_DAY_UNIT != null)
            {
                condition.And(WARN_EXPRESSION_DETAIL._.LIMIT_DAY_UNIT == (model.LIMIT_DAY_UNIT));
            }
            if (model.CHECK_TIME != null)
            {
                condition.And(WARN_EXPRESSION_DETAIL._.CHECK_TIME == (model.CHECK_TIME));
            }
            return condition;
        }
        #endregion
    }
}