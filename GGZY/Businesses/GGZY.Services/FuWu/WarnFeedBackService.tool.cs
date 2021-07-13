using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class WarnFeedbackService : BaseServiceT<WARN_FEEDBACK>
    {
        #region 接口实现

        public List<WARN_FEEDBACK> FindList(WARN_FEEDBACK model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<WARN_FEEDBACK> PageList(WARN_FEEDBACK model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, WARN_FEEDBACK._.M_ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="M_ID">唯一标识</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string M_ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(WARN_FEEDBACK._.M_ID == M_ID);

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
        public GeneralResult Edit(WARN_FEEDBACK model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.M_ID);

                if (viewResult.Success && viewResult.Data is WARN_FEEDBACK entity)
                {
                    entity.Attach();
                    entity.M_ID = model.M_ID;
                    entity.SP_RECORD_ID = model.SP_RECORD_ID;
                    entity.OPERATOR = model.OPERATOR;
                    entity.OPERATOR_ID = model.OPERATOR_ID;
                    entity.OPERATOR_UNIT = model.OPERATOR_UNIT;
                    entity.OPERATOR_UNIT_ID = model.OPERATOR_UNIT_ID;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    entity.CONTENT = model.CONTENT;
                    entity.REMARK = model.REMARK;
                    entity.ISDELETE = model.ISDELETE;
                    entity.FEEDBACK_ATTACHMENT = model.FEEDBACK_ATTACHMENT;
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
        public GeneralResult Add(WARN_FEEDBACK model)
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
                    Delete(WARN_FEEDBACK._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<WARN_FEEDBACK> model)
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
        protected WhereClipBuilder ConditionBuilder(WARN_FEEDBACK model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.M_ID))
            {
                condition.And(WARN_FEEDBACK._.M_ID.Contain(model.M_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.SP_RECORD_ID))
            {
                condition.And(WARN_FEEDBACK._.SP_RECORD_ID.Contain(model.SP_RECORD_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.OPERATOR))
            {
                condition.And(WARN_FEEDBACK._.OPERATOR.Contain(model.OPERATOR));
            }
            if (!string.IsNullOrWhiteSpace(model.OPERATOR_ID))
            {
                condition.And(WARN_FEEDBACK._.OPERATOR_ID.Contain(model.OPERATOR_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.OPERATOR_UNIT))
            {
                condition.And(WARN_FEEDBACK._.OPERATOR_UNIT.Contain(model.OPERATOR_UNIT));
            }
            if (!string.IsNullOrWhiteSpace(model.OPERATOR_UNIT_ID))
            {
                condition.And(WARN_FEEDBACK._.OPERATOR_UNIT_ID.Contain(model.OPERATOR_UNIT_ID));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(WARN_FEEDBACK._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.CONTENT))
            {
                condition.And(WARN_FEEDBACK._.CONTENT.Contain(model.CONTENT));
            }
            if (!string.IsNullOrWhiteSpace(model.REMARK))
            {
                condition.And(WARN_FEEDBACK._.REMARK.Contain(model.REMARK));
            }
            if (model.ISDELETE != null)
            {
                condition.And(WARN_FEEDBACK._.ISDELETE == (model.ISDELETE));
            }
            if (!string.IsNullOrWhiteSpace(model.FEEDBACK_ATTACHMENT))
            {
                condition.And(WARN_FEEDBACK._.FEEDBACK_ATTACHMENT.Contain(model.FEEDBACK_ATTACHMENT));
            }
            return condition;
        }
        #endregion
    }
}