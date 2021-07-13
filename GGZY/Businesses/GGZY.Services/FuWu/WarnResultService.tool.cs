using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class WarnResultService : BaseServiceT<WARN_RESULT>
    {
        #region 接口实现

        public List<WARN_RESULT> FindList(WARN_RESULT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<WARN_RESULT> PageList(WARN_RESULT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, WARN_RESULT._.M_ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="M_ID">唯一标识</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string M_ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(WARN_RESULT._.M_ID == M_ID);

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
        public GeneralResult Edit(WARN_RESULT model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.M_ID);

                if (viewResult.Success && viewResult.Data is WARN_RESULT entity)
                {
                    entity.Attach();
                    entity.M_ID = model.M_ID;
                    entity.MAIN_M_ID = model.MAIN_M_ID;
                    entity.SUB_M_ID = model.SUB_M_ID;
                    entity.TENDER_PROJECT_CODE = model.TENDER_PROJECT_CODE;
                    entity.PROJECT_CODE = model.PROJECT_CODE;
                    entity.BID_SECTION_CODE = model.BID_SECTION_CODE;
                    entity.RESULT_STATUS = model.RESULT_STATUS;
                    entity.OPERATE_STATUS = model.OPERATE_STATUS;
                    entity.REGION_CODE = model.REGION_CODE;
                    entity.TENDER_PROJECT_TYPE = model.TENDER_PROJECT_TYPE;
                    entity.CONTENT = model.CONTENT;
                    entity.SP_TIME = model.SP_TIME;
                    entity.DATA_TIMESTAMP = model.DATA_TIMESTAMP;
                    entity.DEAL_LIMIT_TIME = model.DEAL_LIMIT_TIME;
                    entity.LAST_RECORD_TIME = model.LAST_RECORD_TIME;
                    entity.ISDELETE = model.ISDELETE;
                    entity.SP_ID = model.SP_ID;
                  
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
        public GeneralResult Add(WARN_RESULT model)
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
                    Delete(WARN_RESULT._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<WARN_RESULT> model)
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
        protected WhereClipBuilder ConditionBuilder(WARN_RESULT model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.M_ID))
            {
                condition.And(WARN_RESULT._.M_ID.Contain(model.M_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.MAIN_M_ID))
            {
                condition.And(WARN_RESULT._.MAIN_M_ID.Contain(model.MAIN_M_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.SUB_M_ID))
            {
                condition.And(WARN_RESULT._.SUB_M_ID.Contain(model.SUB_M_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
            {
                condition.And(WARN_RESULT._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
            {
                condition.And(WARN_RESULT._.PROJECT_CODE.Contain(model.PROJECT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
            {
                condition.And(WARN_RESULT._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.RESULT_STATUS))
            {
                condition.And(WARN_RESULT._.RESULT_STATUS.Contain(model.RESULT_STATUS));
            }
          if (!string.IsNullOrWhiteSpace(model.OPERATE_STATUS))
            {
                condition.And(WARN_RESULT._.OPERATE_STATUS.Contain(model.OPERATE_STATUS));
            }
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition.And(WARN_RESULT._.REGION_CODE.Contain(model.REGION_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition.And(WARN_RESULT._.TENDER_PROJECT_TYPE.Contain(model.TENDER_PROJECT_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.CONTENT))
            {
                condition.And(WARN_RESULT._.CONTENT.Contain(model.CONTENT));
            }
            if (model.SP_TIME != null)
            {
                condition.And(WARN_RESULT._.SP_TIME == (model.SP_TIME));
            }
            if (model.DATA_TIMESTAMP != null)
            {
                condition.And(WARN_RESULT._.DATA_TIMESTAMP == (model.DATA_TIMESTAMP));
            }
            if (model.DEAL_LIMIT_TIME != null)
            {
                condition.And(WARN_RESULT._.DEAL_LIMIT_TIME == (model.DEAL_LIMIT_TIME));
            }
            if (model.LAST_RECORD_TIME != null)
            {
                condition.And(WARN_RESULT._.LAST_RECORD_TIME == (model.LAST_RECORD_TIME));
            }
            if (model.ISDELETE != null)
            {
                condition.And(WARN_RESULT._.ISDELETE == (model.ISDELETE));
            }
            if (model.SP_ID != null)
            {
                condition.And(WARN_RESULT._.SP_ID == (model.SP_ID));
            }
            return condition;
        }
        #endregion
    }
}