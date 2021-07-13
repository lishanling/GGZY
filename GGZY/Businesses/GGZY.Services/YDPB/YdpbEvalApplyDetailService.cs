using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class YdpbEvalApplyDetailService : BaseServiceT<YDPB_EVAL_APPLY_DETAIL>
    {
        #region 接口实现

        public List<YDPB_EVAL_APPLY_DETAIL> FindList(YDPB_EVAL_APPLY_DETAIL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<YDPB_EVAL_APPLY_DETAIL> PageList(YDPB_EVAL_APPLY_DETAIL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, YDPB_EVAL_APPLY_DETAIL._.ID.Desc).ToBootstrapTableList(count);


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
            condition.And(YDPB_EVAL_APPLY_DETAIL._.ID == ID);

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
        public GeneralResult Edit(YDPB_EVAL_APPLY_DETAIL model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is YDPB_EVAL_APPLY_DETAIL entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.AREA_CODE = model.AREA_CODE;
                    entity.CENTER_NAME = model.CENTER_NAME;
                    entity.EXPERT_COUNT = model.EXPERT_COUNT;
                    entity.IS_MAIN = model.IS_MAIN;
                    entity.STATUS = model.STATUS;
                    entity.REMARK = model.REMARK;
                    entity.APPLY_ID = model.APPLY_ID;
                    entity.CREATOR_ID = model.CREATOR_ID;
                    entity.CREATOR = model.CREATOR;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    entity.DATA_TIMESTAMP = model.DATA_TIMESTAMP;
                    entity.IS_DELETE = model.IS_DELETE;
                    entity.FID = model.FID;
                    entity.IS_EVAL_EXPERT = model.IS_EVAL_EXPERT;
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
        public GeneralResult Add(YDPB_EVAL_APPLY_DETAIL model)
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
                    Delete(YDPB_EVAL_APPLY_DETAIL._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<YDPB_EVAL_APPLY_DETAIL> model)
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
        protected WhereClipBuilder ConditionBuilder(YDPB_EVAL_APPLY_DETAIL model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(YDPB_EVAL_APPLY_DETAIL._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.AREA_CODE))
            {
                condition.And(YDPB_EVAL_APPLY_DETAIL._.AREA_CODE.Contain(model.AREA_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.CENTER_NAME))
            {
                condition.And(YDPB_EVAL_APPLY_DETAIL._.CENTER_NAME.Contain(model.CENTER_NAME));
            }
            if (model.EXPERT_COUNT != null)
            {
                condition.And(YDPB_EVAL_APPLY_DETAIL._.EXPERT_COUNT == (model.EXPERT_COUNT));
            }
            if (model.IS_MAIN != null)
            {
                condition.And(YDPB_EVAL_APPLY_DETAIL._.IS_MAIN == (model.IS_MAIN));
            }
            if (model.STATUS != null)
            {
                condition.And(YDPB_EVAL_APPLY_DETAIL._.STATUS == (model.STATUS));
            }
            if (!string.IsNullOrWhiteSpace(model.REMARK))
            {
                condition.And(YDPB_EVAL_APPLY_DETAIL._.REMARK.Contain(model.REMARK));
            }
            if (model.APPLY_ID != null)
            {
                condition.And(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == (model.APPLY_ID));
            }
            if (model.CREATOR_ID != null)
            {
                condition.And(YDPB_EVAL_APPLY_DETAIL._.CREATOR_ID == (model.CREATOR_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.CREATOR))
            {
                condition.And(YDPB_EVAL_APPLY_DETAIL._.CREATOR.Contain(model.CREATOR));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(YDPB_EVAL_APPLY_DETAIL._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (model.DATA_TIMESTAMP != null)
            {
                condition.And(YDPB_EVAL_APPLY_DETAIL._.DATA_TIMESTAMP == (model.DATA_TIMESTAMP));
            }
            if (model.IS_DELETE != null)
            {
                condition.And(YDPB_EVAL_APPLY_DETAIL._.IS_DELETE == (model.IS_DELETE));
            }
            if (model.FID != null)
            {
                condition.And(YDPB_EVAL_APPLY_DETAIL._.FID == (model.FID));
            }
            if (model.IS_EVAL_EXPERT != null)
            {
                condition.And(YDPB_EVAL_APPLY_DETAIL._.IS_EVAL_EXPERT == (model.IS_EVAL_EXPERT));
            }
            return condition;
        }
        #endregion
    }
}