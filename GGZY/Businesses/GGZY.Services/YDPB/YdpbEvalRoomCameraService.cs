using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class YdpbEvalRoomCameraService : BaseServiceT<YDPB_EVAL_ROOM_CAMERA>
    {
        #region 接口实现

        public List<YDPB_EVAL_ROOM_CAMERA> FindList(YDPB_EVAL_ROOM_CAMERA model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<YDPB_EVAL_ROOM_CAMERA> PageList(YDPB_EVAL_ROOM_CAMERA model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, YDPB_EVAL_ROOM_CAMERA._.ID.Desc).ToBootstrapTableList(count);


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
            condition.And(YDPB_EVAL_ROOM_CAMERA._.ID == ID);

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
        public GeneralResult Edit(YDPB_EVAL_ROOM_CAMERA model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is YDPB_EVAL_ROOM_CAMERA entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.CAMERA_NAME = model.CAMERA_NAME;
                    entity.URL = model.URL;
                    entity.EVAL_ROOM_ID = model.EVAL_ROOM_ID;
                    entity.STATE = model.STATE;
                    entity.CREATOR_ID = model.CREATOR_ID;
                    entity.CREATOR = model.CREATOR;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    entity.DATA_TIMESTAMP = model.DATA_TIMESTAMP;
                    entity.IS_DELETE = model.IS_DELETE;
                    entity.REMARK = model.REMARK;
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
        public GeneralResult Add(YDPB_EVAL_ROOM_CAMERA model)
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
                    Delete(YDPB_EVAL_ROOM_CAMERA._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<YDPB_EVAL_ROOM_CAMERA> model)
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
        protected WhereClipBuilder ConditionBuilder(YDPB_EVAL_ROOM_CAMERA model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(YDPB_EVAL_ROOM_CAMERA._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.CAMERA_NAME))
            {
                condition.And(YDPB_EVAL_ROOM_CAMERA._.CAMERA_NAME.Contain(model.CAMERA_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.URL))
            {
                condition.And(YDPB_EVAL_ROOM_CAMERA._.URL.Contain(model.URL));
            }
            if (model.EVAL_ROOM_ID != null)
            {
                condition.And(YDPB_EVAL_ROOM_CAMERA._.EVAL_ROOM_ID == (model.EVAL_ROOM_ID));
            }
            if (model.STATE != null)
            {
                condition.And(YDPB_EVAL_ROOM_CAMERA._.STATE == (model.STATE));
            }
            if (model.CREATOR_ID != null)
            {
                condition.And(YDPB_EVAL_ROOM_CAMERA._.CREATOR_ID == (model.CREATOR_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.CREATOR))
            {
                condition.And(YDPB_EVAL_ROOM_CAMERA._.CREATOR.Contain(model.CREATOR));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(YDPB_EVAL_ROOM_CAMERA._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (model.DATA_TIMESTAMP != null)
            {
                condition.And(YDPB_EVAL_ROOM_CAMERA._.DATA_TIMESTAMP == (model.DATA_TIMESTAMP));
            }
            if (model.IS_DELETE != null)
            {
                condition.And(YDPB_EVAL_ROOM_CAMERA._.IS_DELETE == (model.IS_DELETE));
            }
            if (!string.IsNullOrWhiteSpace(model.REMARK))
            {
                condition.And(YDPB_EVAL_ROOM_CAMERA._.REMARK.Contain(model.REMARK));
            }
            return condition;
        }
        #endregion
    }
}