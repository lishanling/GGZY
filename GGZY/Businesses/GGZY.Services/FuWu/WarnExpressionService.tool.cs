using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class WarnExpressionService : BaseServiceT<WARN_EXPRESSION>
    {
        #region 接口实现

        public List<WARN_EXPRESSION> FindList(WARN_EXPRESSION model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<WARN_EXPRESSION> PageList(WARN_EXPRESSION model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, WARN_EXPRESSION._.M_ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="M_ID">唯一标识</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(decimal? M_ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(WARN_EXPRESSION._.M_ID == M_ID);

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
        public GeneralResult Edit(WARN_EXPRESSION model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.M_ID);

                if (viewResult.Success && viewResult.Data is WARN_EXPRESSION entity)
                {
                    entity.Attach();
                    entity.M_ID = model.M_ID;
                    entity.SP_NAME = model.SP_NAME;
                    entity.SP_NODE_NAME = model.SP_NODE_NAME;
                    entity.SP_FLOW_NAME = model.SP_FLOW_NAME;
                    entity.SP_TYPE = model.SP_TYPE;
                    entity.SP_WAY = model.SP_WAY;
                    entity.SP_POINT_RULE = model.SP_POINT_RULE;
                    entity.SP_POINT_TYPE = model.SP_POINT_TYPE;
                    entity.SP_STATUS = model.SP_STATUS;
                    entity.ISDELETE = model.ISDELETE;
                    entity.SQL = model.SQL;
                    entity.DELETE_TIME = model.DELETE_TIME;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    entity.DEPARTMENT_CODE = model.DEPARTMENT_CODE;
                    entity.SP_NODE_NAME_EN = model.SP_NODE_NAME_EN;
                    entity.SP_MENU_NAME_EN = model.SP_MENU_NAME_EN;
                    entity.ORDERBY = model.ORDERBY;
                    entity.REMARK = model.REMARK;
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
        public GeneralResult Add(WARN_EXPRESSION model)
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
                    Delete(WARN_EXPRESSION._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<WARN_EXPRESSION> model)
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
        protected WhereClipBuilder ConditionBuilder(WARN_EXPRESSION model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.M_ID != null)
            {
                condition.And(WARN_EXPRESSION._.M_ID == (model.M_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.SP_NAME))
            {
                condition.And(WARN_EXPRESSION._.SP_NAME.Contain(model.SP_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.SP_NODE_NAME))
            {
                condition.And(WARN_EXPRESSION._.SP_NODE_NAME.Contain(model.SP_NODE_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.SP_FLOW_NAME))
            {
                condition.And(WARN_EXPRESSION._.SP_FLOW_NAME.Contain(model.SP_FLOW_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.SP_TYPE))
            {
                condition.And(WARN_EXPRESSION._.SP_TYPE.Contain(model.SP_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.SP_WAY))
            {
                condition.And(WARN_EXPRESSION._.SP_WAY.Contain(model.SP_WAY));
            }
            if (!string.IsNullOrWhiteSpace(model.SP_POINT_RULE))
            {
                condition.And(WARN_EXPRESSION._.SP_POINT_RULE.Contain(model.SP_POINT_RULE));
            }
            if (!string.IsNullOrWhiteSpace(model.SP_POINT_TYPE))
            {
                condition.And(WARN_EXPRESSION._.SP_POINT_TYPE.Contain(model.SP_POINT_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.SP_STATUS))
            {
                condition.And(WARN_EXPRESSION._.SP_STATUS.Contain(model.SP_STATUS));
            }
            if (model.ISDELETE != null)
            {
                condition.And(WARN_EXPRESSION._.ISDELETE == (model.ISDELETE));
            }
            if (!string.IsNullOrWhiteSpace(model.SQL))
            {
                condition.And(WARN_EXPRESSION._.SQL.Contain(model.SQL));
            }
            if (model.DELETE_TIME != null)
            {
                condition.And(WARN_EXPRESSION._.DELETE_TIME == (model.DELETE_TIME));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(WARN_EXPRESSION._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.DEPARTMENT_CODE))
            {
                condition.And(WARN_EXPRESSION._.DEPARTMENT_CODE.Contain(model.DEPARTMENT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.SP_NODE_NAME_EN))
            {
                condition.And(WARN_EXPRESSION._.SP_NODE_NAME_EN.Contain(model.SP_NODE_NAME_EN));
            }
            if (!string.IsNullOrWhiteSpace(model.SP_MENU_NAME_EN))
            {
                condition.And(WARN_EXPRESSION._.SP_MENU_NAME_EN.Contain(model.SP_MENU_NAME_EN));
            }
            if (model.ORDERBY != null)
            {
                condition.And(WARN_EXPRESSION._.ORDERBY == (model.ORDERBY));
            }
            if (!string.IsNullOrWhiteSpace(model.REMARK))
            {
                condition.And(WARN_EXPRESSION._.REMARK.Contain(model.REMARK));
            }
            return condition;
        }
        #endregion
    }
}