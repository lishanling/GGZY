using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class YdpbEvalExpertRecordService : BaseServiceT<YDPB_EVAL_EXPERT_RECORD>
    {
        #region 接口实现

        public List<YDPB_EVAL_EXPERT_RECORD> FindList(YDPB_EVAL_EXPERT_RECORD model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<YDPB_EVAL_EXPERT_RECORD> PageList(YDPB_EVAL_EXPERT_RECORD model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, YDPB_EVAL_EXPERT_RECORD._.ID.Desc).ToBootstrapTableList(count);


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
            condition.And(YDPB_EVAL_EXPERT_RECORD._.ID == ID);

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
        public GeneralResult Edit(YDPB_EVAL_EXPERT_RECORD model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is YDPB_EVAL_EXPERT_RECORD entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.AREA_CODE = model.AREA_CODE;
                    entity.SEAT_NUMBER = model.SEAT_NUMBER;
                    entity.EVAL_APPLY_DETAIL_ID = model.EVAL_APPLY_DETAIL_ID;
                    entity.START_TIME = model.START_TIME;
                    entity.END_TIME = model.END_TIME;
                    entity.EVAL_ROOM_NAME = model.EVAL_ROOM_NAME;
                    entity.F_RECORD_ID = model.F_RECORD_ID;
                    entity.EXPERT_NAME = model.EXPERT_NAME;
                    entity.ID_CARD = model.ID_CARD;
                    entity.ID_CARD_TYPE = model.ID_CARD_TYPE;
                    entity.CREATOR_ID = model.CREATOR_ID;
                    entity.CREATOR = model.CREATOR;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    entity.DATA_TIMESTAMP = model.DATA_TIMESTAMP;
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
        public GeneralResult Add(YDPB_EVAL_EXPERT_RECORD model)
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
                    Delete(YDPB_EVAL_EXPERT_RECORD._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<YDPB_EVAL_EXPERT_RECORD> model)
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
        protected WhereClipBuilder ConditionBuilder(YDPB_EVAL_EXPERT_RECORD model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(YDPB_EVAL_EXPERT_RECORD._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.AREA_CODE))
            {
                condition.And(YDPB_EVAL_EXPERT_RECORD._.AREA_CODE.Contain(model.AREA_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.SEAT_NUMBER))
            {
                condition.And(YDPB_EVAL_EXPERT_RECORD._.SEAT_NUMBER.Contain(model.SEAT_NUMBER));
            }
            if (model.EVAL_APPLY_DETAIL_ID != null)
            {
                condition.And(YDPB_EVAL_EXPERT_RECORD._.EVAL_APPLY_DETAIL_ID == (model.EVAL_APPLY_DETAIL_ID));
            }
            if (model.START_TIME != null)
            {
                condition.And(YDPB_EVAL_EXPERT_RECORD._.START_TIME == (model.START_TIME));
            }
            if (model.END_TIME != null)
            {
                condition.And(YDPB_EVAL_EXPERT_RECORD._.END_TIME == (model.END_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.EVAL_ROOM_NAME))
            {
                condition.And(YDPB_EVAL_EXPERT_RECORD._.EVAL_ROOM_NAME.Contain(model.EVAL_ROOM_NAME));
            }
            if (model.F_RECORD_ID != null)
            {
                condition.And(YDPB_EVAL_EXPERT_RECORD._.F_RECORD_ID == (model.F_RECORD_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.EXPERT_NAME))
            {
                condition.And(YDPB_EVAL_EXPERT_RECORD._.EXPERT_NAME.Contain(model.EXPERT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.ID_CARD))
            {
                condition.And(YDPB_EVAL_EXPERT_RECORD._.ID_CARD.Contain(model.ID_CARD));
            }
            if (!string.IsNullOrWhiteSpace(model.ID_CARD_TYPE))
            {
                condition.And(YDPB_EVAL_EXPERT_RECORD._.ID_CARD_TYPE.Contain(model.ID_CARD_TYPE));
            }
            if (model.CREATOR_ID != null)
            {
                condition.And(YDPB_EVAL_EXPERT_RECORD._.CREATOR_ID == (model.CREATOR_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.CREATOR))
            {
                condition.And(YDPB_EVAL_EXPERT_RECORD._.CREATOR.Contain(model.CREATOR));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(YDPB_EVAL_EXPERT_RECORD._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (model.DATA_TIMESTAMP != null)
            {
                condition.And(YDPB_EVAL_EXPERT_RECORD._.DATA_TIMESTAMP == (model.DATA_TIMESTAMP));
            }
            if (model.IS_DELETE != null)
            {
                condition.And(YDPB_EVAL_EXPERT_RECORD._.IS_DELETE == (model.IS_DELETE));
            }
            return condition;
        }
        #endregion
    }
}