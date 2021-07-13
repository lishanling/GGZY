using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class VYdpbApplyAllService : BaseServiceT<V_YDPB_APPLY_ALL>
    {
        #region 接口实现

        public List<V_YDPB_APPLY_ALL> FindList(V_YDPB_APPLY_ALL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<V_YDPB_APPLY_ALL> PageList(V_YDPB_APPLY_ALL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, V_YDPB_APPLY_ALL._.ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public GeneralResult ViewByPk(decimal? ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(V_YDPB_APPLY_ALL._.ID == ID);

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
        public GeneralResult Edit(V_YDPB_APPLY_ALL model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is V_YDPB_APPLY_ALL entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.SERIES_NUMBER = model.SERIES_NUMBER;
                    entity.APPLY_TYPE = model.APPLY_TYPE;
                    entity.APPLY_STEP = model.APPLY_STEP;
                    entity.STATE = model.STATE;
                    entity.STATUS = model.STATUS;
                    entity.BID_EVAL_START_TIME = model.BID_EVAL_START_TIME;
                    entity.BID_EVAL_END_TIME = model.BID_EVAL_END_TIME;
                    entity.CENTER_NAME = model.CENTER_NAME;
                    entity.FLAG = model.FLAG;
                    entity.CREATOR_ID = model.CREATOR_ID;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    entity.EXPERT_COUNT = model.EXPERT_COUNT;
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
        public GeneralResult Add(V_YDPB_APPLY_ALL model)
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
                    Delete(V_YDPB_APPLY_ALL._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<V_YDPB_APPLY_ALL> model)
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
        protected WhereClipBuilder ConditionBuilder(V_YDPB_APPLY_ALL model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(V_YDPB_APPLY_ALL._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.SERIES_NUMBER))
            {
                condition.And(V_YDPB_APPLY_ALL._.SERIES_NUMBER.Contain(model.SERIES_NUMBER));
            }
            if (model.APPLY_TYPE != null)
            {
                condition.And(V_YDPB_APPLY_ALL._.APPLY_TYPE == (model.APPLY_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.APPLY_STEP))
            {
                condition.And(V_YDPB_APPLY_ALL._.APPLY_STEP.Contain(model.APPLY_STEP));
            }
            if (model.STATE != null)
            {
                condition.And(V_YDPB_APPLY_ALL._.STATE == (model.STATE));
            }
            if (model.STATUS != null)
            {
                condition.And(V_YDPB_APPLY_ALL._.STATUS == (model.STATUS));
            }
            if (model.BID_EVAL_START_TIME != null)
            {
                condition.And(V_YDPB_APPLY_ALL._.BID_EVAL_START_TIME == (model.BID_EVAL_START_TIME));
            }
            if (model.BID_EVAL_END_TIME != null)
            {
                condition.And(V_YDPB_APPLY_ALL._.BID_EVAL_END_TIME == (model.BID_EVAL_END_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.CENTER_NAME))
            {
                condition.And(V_YDPB_APPLY_ALL._.CENTER_NAME.Contain(model.CENTER_NAME));
            }
            if (model.FLAG != null)
            {
                condition.And(V_YDPB_APPLY_ALL._.FLAG == (model.FLAG));
            }
            if (model.CREATOR_ID != null)
            {
                condition.And(V_YDPB_APPLY_ALL._.CREATOR_ID == (model.CREATOR_ID));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(V_YDPB_APPLY_ALL._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (model.EXPERT_COUNT != null)
            {
                condition.And(V_YDPB_APPLY_ALL._.EXPERT_COUNT == (model.EXPERT_COUNT));
            }
            return condition;
        }
        #endregion
    }
}