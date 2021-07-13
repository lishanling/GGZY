using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TSuperviseResultService : BaseServiceT<T_SUPERVISE_RESULT>
    {
        #region 接口实现

        public List<T_SUPERVISE_RESULT> FindList(T_SUPERVISE_RESULT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_SUPERVISE_RESULT> PageList(T_SUPERVISE_RESULT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, T_SUPERVISE_RESULT._.M_ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="M_ID"></param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string M_ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(T_SUPERVISE_RESULT._.M_ID == M_ID);

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
        public GeneralResult Edit(T_SUPERVISE_RESULT model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.M_ID);

                if (viewResult.Success && viewResult.Data is T_SUPERVISE_RESULT entity)
                {
                    entity.Attach();
                    entity.M_ID = model.M_ID;
                    entity.ENTITY_TYPE_NAME = model.ENTITY_TYPE_NAME;
                    entity.ENTITY_ID = model.ENTITY_ID;
                    entity.STATUS = model.STATUS;
                    entity.SUPERVISE_NAME = model.SUPERVISE_NAME;
                    entity.SUPERVISE_TYPE = model.SUPERVISE_TYPE;
                    entity.SUPERVISE_WAY = model.SUPERVISE_WAY;
                    entity.SUPERVISE_TIME = model.SUPERVISE_TIME;
                    entity.SUPERVISE_RULE = model.SUPERVISE_RULE;
                    entity.ENTITY_SUBMIT_TIME = model.ENTITY_SUBMIT_TIME;
                    entity.ENTITY_HANDLE_TIME = model.ENTITY_HANDLE_TIME;
                    entity.SUPERVISE_OP_ID = model.SUPERVISE_OP_ID;
                    entity.SUPERVISE_OP_NAME = model.SUPERVISE_OP_NAME;
                    entity.ENTITY_REGION_CODE = model.ENTITY_REGION_CODE;
                    entity.ENTITY_TENDER_PROJECT_TYPE = model.ENTITY_TENDER_PROJECT_TYPE;
                    entity.WARNING = model.WARNING;
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
        public GeneralResult Add(T_SUPERVISE_RESULT model)
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
                    Delete(T_SUPERVISE_RESULT._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_SUPERVISE_RESULT> model)
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
        protected WhereClipBuilder ConditionBuilder(T_SUPERVISE_RESULT model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.M_ID))
            {
                condition.And(T_SUPERVISE_RESULT._.M_ID.Contain(model.M_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.ENTITY_TYPE_NAME))
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_TYPE_NAME.Contain(model.ENTITY_TYPE_NAME));
            }
            if (model.ENTITY_ID != null)
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_ID == (model.ENTITY_ID));
            }
            if (model.STATUS != null)
            {
                condition.And(T_SUPERVISE_RESULT._.STATUS == (model.STATUS));
            }
            if (!string.IsNullOrWhiteSpace(model.SUPERVISE_NAME))
            {
                condition.And(T_SUPERVISE_RESULT._.SUPERVISE_NAME.Contain(model.SUPERVISE_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.SUPERVISE_TYPE))
            {
                condition.And(T_SUPERVISE_RESULT._.SUPERVISE_TYPE.Contain(model.SUPERVISE_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.SUPERVISE_WAY))
            {
                condition.And(T_SUPERVISE_RESULT._.SUPERVISE_WAY.Contain(model.SUPERVISE_WAY));
            }
            if (model.SUPERVISE_TIME != null)
            {
                condition.And(T_SUPERVISE_RESULT._.SUPERVISE_TIME == (model.SUPERVISE_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.SUPERVISE_RULE))
            {
                condition.And(T_SUPERVISE_RESULT._.SUPERVISE_RULE.Contain(model.SUPERVISE_RULE));
            }
            if (model.ENTITY_SUBMIT_TIME != null)
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_SUBMIT_TIME == (model.ENTITY_SUBMIT_TIME));
            }
            if (model.ENTITY_HANDLE_TIME != null)
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_HANDLE_TIME == (model.ENTITY_HANDLE_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.SUPERVISE_OP_ID))
            {
                condition.And(T_SUPERVISE_RESULT._.SUPERVISE_OP_ID.Contain(model.SUPERVISE_OP_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.SUPERVISE_OP_NAME))
            {
                condition.And(T_SUPERVISE_RESULT._.SUPERVISE_OP_NAME.Contain(model.SUPERVISE_OP_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.ENTITY_REGION_CODE))
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_REGION_CODE.Contain(model.ENTITY_REGION_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.ENTITY_TENDER_PROJECT_TYPE))
            {
                condition.And(T_SUPERVISE_RESULT._.ENTITY_TENDER_PROJECT_TYPE.Contain(model.ENTITY_TENDER_PROJECT_TYPE));
            }
            if (model.WARNING != null)
            {
                condition.And(T_SUPERVISE_RESULT._.WARNING == (model.WARNING));
            }
            return condition;
        }
        #endregion
    }
}