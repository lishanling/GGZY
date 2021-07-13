using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BdViolationRecordService : BaseServiceT<BD_VIOLATION_RECORD>
    {
        #region 接口实现

        public List<BD_VIOLATION_RECORD> FindList(BD_VIOLATION_RECORD model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BD_VIOLATION_RECORD> PageList(BD_VIOLATION_RECORD model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, BD_VIOLATION_RECORD._.ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(BD_VIOLATION_RECORD._.ID == ID);

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
        public GeneralResult Edit(BD_VIOLATION_RECORD model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is BD_VIOLATION_RECORD entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.POINT_ID = model.POINT_ID;
                    entity.POINT_CODE = model.POINT_CODE;
                    entity.POINT_NAME = model.POINT_NAME;
                    entity.TENDER_PROJECT_NAME = model.TENDER_PROJECT_NAME;
                    entity.TENDER_PROJECT_CODE = model.TENDER_PROJECT_CODE;
                    entity.INDUSTRIES = model.INDUSTRIES;
                    entity.TENDER_PROJECT_TYPE = model.TENDER_PROJECT_TYPE;
                    entity.AREA_CODE = model.AREA_CODE;
                    entity.CHECK_TIME = model.CHECK_TIME;
                    entity.RESULT_MSG = model.RESULT_MSG;
                    entity.RESULT_DATA = model.RESULT_DATA;
                    entity.SCORE = model.SCORE;
                    entity.STATE = model.STATE;
                    entity.TRANSFER_STATE = model.TRANSFER_STATE;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    entity.IS_DELETE = model.IS_DELETE;
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
        public GeneralResult Add(BD_VIOLATION_RECORD model)
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
                    Delete(BD_VIOLATION_RECORD._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BD_VIOLATION_RECORD> model)
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
        protected WhereClipBuilder ConditionBuilder(BD_VIOLATION_RECORD model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.ID))
            {
                condition.And(BD_VIOLATION_RECORD._.ID.Contain(model.ID));
            }
            if (model.POINT_ID != null)
            {
                condition.And(BD_VIOLATION_RECORD._.POINT_ID == (model.POINT_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.POINT_CODE))
            {
                condition.And(BD_VIOLATION_RECORD._.POINT_CODE.Contain(model.POINT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.POINT_NAME))
            {
                condition.And(BD_VIOLATION_RECORD._.POINT_NAME.Contain(model.POINT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
            {
                condition.And(BD_VIOLATION_RECORD._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
            {
                condition.And(BD_VIOLATION_RECORD._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
            }
            if (model.INDUSTRIES != null)
            {
                condition.And(BD_VIOLATION_RECORD._.INDUSTRIES == (model.INDUSTRIES));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition.And(BD_VIOLATION_RECORD._.TENDER_PROJECT_TYPE.Contain(model.TENDER_PROJECT_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.AREA_CODE))
            {
                condition.And(BD_VIOLATION_RECORD._.AREA_CODE.Contain(model.AREA_CODE));
            }
            if (model.CHECK_TIME != null)
            {
                condition.And(BD_VIOLATION_RECORD._.CHECK_TIME == (model.CHECK_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.RESULT_MSG))
            {
                condition.And(BD_VIOLATION_RECORD._.RESULT_MSG.Contain(model.RESULT_MSG));
            }
            if (!string.IsNullOrWhiteSpace(model.RESULT_DATA))
            {
                condition.And(BD_VIOLATION_RECORD._.RESULT_DATA.Contain(model.RESULT_DATA));
            }
            if (model.SCORE != null)
            {
                condition.And(BD_VIOLATION_RECORD._.SCORE == (model.SCORE));
            }
            if (model.STATE != null)
            {
                condition.And(BD_VIOLATION_RECORD._.STATE == (model.STATE));
            }
            if (model.TRANSFER_STATE != null)
            {
                condition.And(BD_VIOLATION_RECORD._.TRANSFER_STATE == (model.TRANSFER_STATE));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(BD_VIOLATION_RECORD._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (model.IS_DELETE != null)
            {
                condition.And(BD_VIOLATION_RECORD._.IS_DELETE == (model.IS_DELETE));
            }
            return condition;
        }
        #endregion
    }
}