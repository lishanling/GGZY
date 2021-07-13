﻿using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class YdpbEvalRoomService : BaseServiceT<YDPB_EVAL_ROOM>
    {
        #region 接口实现

        public List<YDPB_EVAL_ROOM> FindList(YDPB_EVAL_ROOM model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<YDPB_EVAL_ROOM> PageList(YDPB_EVAL_ROOM model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, YDPB_EVAL_ROOM._.ID.Desc).ToBootstrapTableList(count);


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
            condition.And(YDPB_EVAL_ROOM._.ID == ID);

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
        public GeneralResult Edit(YDPB_EVAL_ROOM model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is YDPB_EVAL_ROOM entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.AREA_CODE = model.AREA_CODE;
                    entity.CENTER_NAME = model.CENTER_NAME;
                    entity.EVAL_ROOM_NAME = model.EVAL_ROOM_NAME;
                    entity.EVAL_ROOM_ADDR = model.EVAL_ROOM_ADDR;
                    entity.EVAL_METHOD = model.EVAL_METHOD;
                    entity.SEATS_COUNT = model.SEATS_COUNT;
                    entity.CAMERA_COUNT = model.CAMERA_COUNT;
                    entity.ENABLED = model.ENABLED;
                    entity.STATE = model.STATE;
                    entity.CREATOR_ID = model.CREATOR_ID;
                    entity.CREATOR = model.CREATOR;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    entity.DATA_TIMESTAMP = model.DATA_TIMESTAMP;
                    entity.IS_DELETE = model.IS_DELETE;
                    entity.REMARK = model.REMARK;
                    entity.AVAILABLE_SEATS_COUNT = model.AVAILABLE_SEATS_COUNT;
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
        public GeneralResult Add(YDPB_EVAL_ROOM model)
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
                    Delete(YDPB_EVAL_ROOM._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<YDPB_EVAL_ROOM> model)
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
        protected WhereClipBuilder ConditionBuilder(YDPB_EVAL_ROOM model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(YDPB_EVAL_ROOM._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.AREA_CODE))
            {
                condition.And(YDPB_EVAL_ROOM._.AREA_CODE.Contain(model.AREA_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.CENTER_NAME))
            {
                condition.And(YDPB_EVAL_ROOM._.CENTER_NAME.Contain(model.CENTER_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.EVAL_ROOM_NAME))
            {
                condition.And(YDPB_EVAL_ROOM._.EVAL_ROOM_NAME.Contain(model.EVAL_ROOM_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.EVAL_ROOM_ADDR))
            {
                condition.And(YDPB_EVAL_ROOM._.EVAL_ROOM_ADDR.Contain(model.EVAL_ROOM_ADDR));
            }
            if (model.EVAL_METHOD != null)
            {
                condition.And(YDPB_EVAL_ROOM._.EVAL_METHOD == (model.EVAL_METHOD));
            }
            if (model.SEATS_COUNT != null)
            {
                condition.And(YDPB_EVAL_ROOM._.SEATS_COUNT == (model.SEATS_COUNT));
            }
            if (model.CAMERA_COUNT != null)
            {
                condition.And(YDPB_EVAL_ROOM._.CAMERA_COUNT == (model.CAMERA_COUNT));
            }
            if (model.ENABLED != null)
            {
                condition.And(YDPB_EVAL_ROOM._.ENABLED == (model.ENABLED));
            }
            if (model.STATE != null)
            {
                condition.And(YDPB_EVAL_ROOM._.STATE == (model.STATE));
            }
            if (model.CREATOR_ID != null)
            {
                condition.And(YDPB_EVAL_ROOM._.CREATOR_ID == (model.CREATOR_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.CREATOR))
            {
                condition.And(YDPB_EVAL_ROOM._.CREATOR.Contain(model.CREATOR));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(YDPB_EVAL_ROOM._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (model.DATA_TIMESTAMP != null)
            {
                condition.And(YDPB_EVAL_ROOM._.DATA_TIMESTAMP == (model.DATA_TIMESTAMP));
            }
            if (model.IS_DELETE != null)
            {
                condition.And(YDPB_EVAL_ROOM._.IS_DELETE == (model.IS_DELETE));
            }
            if (!string.IsNullOrWhiteSpace(model.REMARK))
            {
                condition.And(YDPB_EVAL_ROOM._.REMARK.Contain(model.REMARK));
            }
            if (model.AVAILABLE_SEATS_COUNT != null)
            {
                condition.And(YDPB_EVAL_ROOM._.AVAILABLE_SEATS_COUNT == (model.AVAILABLE_SEATS_COUNT));
            }
            return condition;
        }
        #endregion
    }
}