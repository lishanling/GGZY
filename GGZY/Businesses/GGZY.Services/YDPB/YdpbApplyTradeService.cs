using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class VYdpbApplyTradeService : BaseServiceT<V_YDPB_APPLY_TRADE>
    {
        #region 接口实现

        public List<V_YDPB_APPLY_TRADE> FindList(V_YDPB_APPLY_TRADE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<V_YDPB_APPLY_TRADE> PageList(V_YDPB_APPLY_TRADE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, V_YDPB_APPLY_TRADE._.ID.Desc).ToBootstrapTableList(count);


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
            condition.And(V_YDPB_APPLY_TRADE._.ID == ID);

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
        public GeneralResult Edit(V_YDPB_APPLY_TRADE model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is V_YDPB_APPLY_TRADE entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.SERIES_NUMBER = model.SERIES_NUMBER;
                    entity.IS_MAIN = model.IS_MAIN;
                    entity.BID_EVAL_START_TIME = model.BID_EVAL_START_TIME;
                    entity.BID_EVAL_END_TIME = model.BID_EVAL_END_TIME;
                    entity.EXPERT_COUNT = model.EXPERT_COUNT;
                    entity.STATUS = model.STATUS;
                    entity.EVAL_STATUS = model.EVAL_STATUS;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    entity.AREA_CODE = model.AREA_CODE;
                    entity.CENTER_NAME = model.CENTER_NAME;
                    entity.FLAG = model.FLAG;
                    entity.APPLY_TYPE = model.APPLY_TYPE;
                    entity.APPLY_STATUS = model.APPLY_STATUS;
                    entity.IS_EVAL_EXPERT = model.IS_EVAL_EXPERT;
                    entity.APPLY_IS_EVAL_EXPERT = model.APPLY_IS_EVAL_EXPERT;
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
        public GeneralResult Add(V_YDPB_APPLY_TRADE model)
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
                    Delete(V_YDPB_APPLY_TRADE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<V_YDPB_APPLY_TRADE> model)
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
        protected WhereClipBuilder ConditionBuilder(V_YDPB_APPLY_TRADE model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(V_YDPB_APPLY_TRADE._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.SERIES_NUMBER))
            {
                condition.And(V_YDPB_APPLY_TRADE._.SERIES_NUMBER.Contain(model.SERIES_NUMBER));
            }
            if (model.IS_MAIN != null)
            {
                condition.And(V_YDPB_APPLY_TRADE._.IS_MAIN == (model.IS_MAIN));
            }
            if (model.BID_EVAL_START_TIME != null)
            {
                condition.And(V_YDPB_APPLY_TRADE._.BID_EVAL_START_TIME == (model.BID_EVAL_START_TIME));
            }
            if (model.BID_EVAL_END_TIME != null)
            {
                condition.And(V_YDPB_APPLY_TRADE._.BID_EVAL_END_TIME == (model.BID_EVAL_END_TIME));
            }
            if (model.EXPERT_COUNT != null)
            {
                condition.And(V_YDPB_APPLY_TRADE._.EXPERT_COUNT == (model.EXPERT_COUNT));
            }
            if (model.STATUS != null)
            {
                condition.And(V_YDPB_APPLY_TRADE._.STATUS == (model.STATUS));
            }
            if (model.EVAL_STATUS != null)
            {
                condition.And(V_YDPB_APPLY_TRADE._.EVAL_STATUS == (model.EVAL_STATUS));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(V_YDPB_APPLY_TRADE._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.AREA_CODE))
            {
                condition.And(V_YDPB_APPLY_TRADE._.AREA_CODE.Contain(model.AREA_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.CENTER_NAME))
            {
                condition.And(V_YDPB_APPLY_TRADE._.CENTER_NAME.Contain(model.CENTER_NAME));
            }
            if (model.FLAG != null)
            {
                condition.And(V_YDPB_APPLY_TRADE._.FLAG == (model.FLAG));
            }
            if (model.APPLY_TYPE != null)
            {
                condition.And(V_YDPB_APPLY_TRADE._.APPLY_TYPE == (model.APPLY_TYPE));
            }
            if (model.APPLY_STATUS != null)
            {
                condition.And(V_YDPB_APPLY_TRADE._.APPLY_STATUS == (model.APPLY_STATUS));
            }
            if (model.IS_EVAL_EXPERT != null)
            {
                condition.And(V_YDPB_APPLY_TRADE._.IS_EVAL_EXPERT == (model.IS_EVAL_EXPERT));
            }
            if (model.APPLY_IS_EVAL_EXPERT != null)
            {
                condition.And(V_YDPB_APPLY_TRADE._.APPLY_IS_EVAL_EXPERT == (model.APPLY_IS_EVAL_EXPERT));
            }
            return condition;
        }
        #endregion
    }
}