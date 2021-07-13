using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class VYdpbRoomSeatService : BaseServiceT<V_YDPB_ROOM_SEAT>
    {
        #region 接口实现

        public List<V_YDPB_ROOM_SEAT> FindList(V_YDPB_ROOM_SEAT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<V_YDPB_ROOM_SEAT> PageList(V_YDPB_ROOM_SEAT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, V_YDPB_ROOM_SEAT._.SEATID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="SEATID"></param>
        /// <returns></returns>
        public GeneralResult ViewByPk(decimal? SEATID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(V_YDPB_ROOM_SEAT._.SEATID == SEATID);

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
        public GeneralResult Edit(V_YDPB_ROOM_SEAT model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.SEATID);

                if (viewResult.Success && viewResult.Data is V_YDPB_ROOM_SEAT entity)
                {
                    entity.Attach();
                    entity.SEATID = model.SEATID;
                    entity.APPLY_ID = model.APPLY_ID;
                    entity.AREA_CODE = model.AREA_CODE;
                    entity.CENTER_NAME = model.CENTER_NAME;
                    entity.ROOMID = model.ROOMID;
                    entity.EVAL_ROOM_NAME = model.EVAL_ROOM_NAME;
                    entity.SEAT_NUMBER = model.SEAT_NUMBER;
                    entity.START_TIME = model.START_TIME;
                    entity.END_TIME = model.END_TIME;
                    entity.EVAL_DATE = model.EVAL_DATE;
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
        public GeneralResult Add(V_YDPB_ROOM_SEAT model)
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
                    Delete(V_YDPB_ROOM_SEAT._.SEATID.SelectIn(idArr));
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
        public GeneralResult Import(List<V_YDPB_ROOM_SEAT> model)
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
        protected WhereClipBuilder ConditionBuilder(V_YDPB_ROOM_SEAT model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.SEATID != null)
            {
                condition.And(V_YDPB_ROOM_SEAT._.SEATID == (model.SEATID));
            }
            if (model.APPLY_ID != null)
            {
                condition.And(V_YDPB_ROOM_SEAT._.APPLY_ID == (model.APPLY_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.AREA_CODE))
            {
                condition.And(V_YDPB_ROOM_SEAT._.AREA_CODE.Contain(model.AREA_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.CENTER_NAME))
            {
                condition.And(V_YDPB_ROOM_SEAT._.CENTER_NAME.Contain(model.CENTER_NAME));
            }
            if (model.ROOMID != null)
            {
                condition.And(V_YDPB_ROOM_SEAT._.ROOMID == (model.ROOMID));
            }
            if (!string.IsNullOrWhiteSpace(model.EVAL_ROOM_NAME))
            {
                condition.And(V_YDPB_ROOM_SEAT._.EVAL_ROOM_NAME.Contain(model.EVAL_ROOM_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.SEAT_NUMBER))
            {
                condition.And(V_YDPB_ROOM_SEAT._.SEAT_NUMBER.Contain(model.SEAT_NUMBER));
            }
            if (model.START_TIME != null)
            {
                condition.And(V_YDPB_ROOM_SEAT._.START_TIME == (model.START_TIME));
            }
            if (model.END_TIME != null)
            {
                condition.And(V_YDPB_ROOM_SEAT._.END_TIME == (model.END_TIME));
            }
            if (model.EVAL_DATE != null)
            {
                condition.And(V_YDPB_ROOM_SEAT._.EVAL_DATE == (model.EVAL_DATE));
            }
            return condition;
        }
        #endregion
    }
}