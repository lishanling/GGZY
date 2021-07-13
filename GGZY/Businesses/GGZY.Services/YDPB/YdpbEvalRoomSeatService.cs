using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class YdpbEvalRoomSeatService : BaseServiceT<YDPB_EVAL_ROOM_SEAT>
    {
        #region 接口实现

        public List<YDPB_EVAL_ROOM_SEAT> FindList(YDPB_EVAL_ROOM_SEAT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<YDPB_EVAL_ROOM_SEAT> PageList(YDPB_EVAL_ROOM_SEAT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, YDPB_EVAL_ROOM_SEAT._.ID.Desc).ToBootstrapTableList(count);


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
            condition.And(YDPB_EVAL_ROOM_SEAT._.ID == ID && YDPB_EVAL_ROOM_SEAT._.IS_DELETE ==0);

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
        public GeneralResult Edit(YDPB_EVAL_ROOM_SEAT model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is YDPB_EVAL_ROOM_SEAT entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.SEAT_NUMBER = model.SEAT_NUMBER;
                    entity.STATE = model.STATE;
                    entity.PC_STATE = model.PC_STATE;
                    entity.NETWORK_STATE = model.NETWORK_STATE;
                    entity.MIC_STATE = model.MIC_STATE;
                    entity.SPEEKER_STATE = model.SPEEKER_STATE;
                    entity.REMARK = model.REMARK;
                    entity.FID = model.FID;
                    entity.CAMERA_STATE = model.CAMERA_STATE;
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
        public GeneralResult Add(YDPB_EVAL_ROOM_SEAT model)
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
                    Delete(YDPB_EVAL_ROOM_SEAT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<YDPB_EVAL_ROOM_SEAT> model)
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
        protected WhereClipBuilder ConditionBuilder(YDPB_EVAL_ROOM_SEAT model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(YDPB_EVAL_ROOM_SEAT._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.SEAT_NUMBER))
            {
                condition.And(YDPB_EVAL_ROOM_SEAT._.SEAT_NUMBER.Contain(model.SEAT_NUMBER));
            }
            if (model.STATE != null)
            {
                condition.And(YDPB_EVAL_ROOM_SEAT._.STATE == (model.STATE));
            }
            if (model.PC_STATE != null)
            {
                condition.And(YDPB_EVAL_ROOM_SEAT._.PC_STATE == (model.PC_STATE));
            }
            if (model.NETWORK_STATE != null)
            {
                condition.And(YDPB_EVAL_ROOM_SEAT._.NETWORK_STATE == (model.NETWORK_STATE));
            }
            if (model.MIC_STATE != null)
            {
                condition.And(YDPB_EVAL_ROOM_SEAT._.MIC_STATE == (model.MIC_STATE));
            }
            if (model.SPEEKER_STATE != null)
            {
                condition.And(YDPB_EVAL_ROOM_SEAT._.SPEEKER_STATE == (model.SPEEKER_STATE));
            }
            if (!string.IsNullOrWhiteSpace(model.REMARK))
            {
                condition.And(YDPB_EVAL_ROOM_SEAT._.REMARK.Contain(model.REMARK));
            }
            if (model.FID != null)
            {
                condition.And(YDPB_EVAL_ROOM_SEAT._.FID == (model.FID));
            }
            if (model.CAMERA_STATE != null)
            {
                condition.And(YDPB_EVAL_ROOM_SEAT._.CAMERA_STATE == (model.CAMERA_STATE));
            }
            if (model.CREATOR_ID != null)
            {
                condition.And(YDPB_EVAL_ROOM_SEAT._.CREATOR_ID == (model.CREATOR_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.CREATOR))
            {
                condition.And(YDPB_EVAL_ROOM_SEAT._.CREATOR.Contain(model.CREATOR));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(YDPB_EVAL_ROOM_SEAT._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (model.DATA_TIMESTAMP != null)
            {
                condition.And(YDPB_EVAL_ROOM_SEAT._.DATA_TIMESTAMP == (model.DATA_TIMESTAMP));
            }
            if (model.IS_DELETE != null)
            {
                condition.And(YDPB_EVAL_ROOM_SEAT._.IS_DELETE == (model.IS_DELETE));
            }
            return condition;
        }
        #endregion
    }
}