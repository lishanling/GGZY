using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class RecordReviewSuperviseService : BaseServiceT<RECORD_REVIEW_SUPERVISE>
    {
        #region 接口实现

        public List<RECORD_REVIEW_SUPERVISE> FindList(RECORD_REVIEW_SUPERVISE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<RECORD_REVIEW_SUPERVISE> PageList(RECORD_REVIEW_SUPERVISE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, RECORD_REVIEW_SUPERVISE._.M_TM.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID">主键ID</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(RECORD_REVIEW_SUPERVISE._.ID == ID);

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
        public GeneralResult Edit(RECORD_REVIEW_SUPERVISE model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is RECORD_REVIEW_SUPERVISE entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.TENDER_PROJECT_CODE = model.TENDER_PROJECT_CODE;
                    entity.TENDER_PROJECT_NAME = model.TENDER_PROJECT_NAME;
                    entity.RECORD_ID = model.RECORD_ID;
                    entity.REVIEW_CODE = model.REVIEW_CODE;
                    entity.STATUS = model.STATUS;
                    entity.SUPERVISE_TIME = model.SUPERVISE_TIME;
                    entity.SUPERVISE_TYPE = model.SUPERVISE_TYPE;
                    entity.SUPERVISE_WAY = model.SUPERVISE_WAY;
                    entity.M_TM = model.M_TM;
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
        public GeneralResult Add(RECORD_REVIEW_SUPERVISE model)
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
                    Delete(RECORD_REVIEW_SUPERVISE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<RECORD_REVIEW_SUPERVISE> model)
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
        protected WhereClipBuilder ConditionBuilder(RECORD_REVIEW_SUPERVISE model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.ID))
            {
                condition.And(RECORD_REVIEW_SUPERVISE._.ID.Contain(model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
            {
                condition.And(RECORD_REVIEW_SUPERVISE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
            {
                condition.And(RECORD_REVIEW_SUPERVISE._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
            }
            if (model.RECORD_ID != null)
            {
                condition.And(RECORD_REVIEW_SUPERVISE._.RECORD_ID == (model.RECORD_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.REVIEW_CODE))
            {
                condition.And(RECORD_REVIEW_SUPERVISE._.REVIEW_CODE.Contain(model.REVIEW_CODE));
            }
            if (model.STATUS != null)
            {
                condition.And(RECORD_REVIEW_SUPERVISE._.STATUS == (model.STATUS));
            }
            if (model.SUPERVISE_TIME != null)
            {
                condition.And(RECORD_REVIEW_SUPERVISE._.SUPERVISE_TIME == (model.SUPERVISE_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.SUPERVISE_TYPE))
            {
                condition.And(RECORD_REVIEW_SUPERVISE._.SUPERVISE_TYPE.Contain(model.SUPERVISE_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.SUPERVISE_WAY))
            {
                condition.And(RECORD_REVIEW_SUPERVISE._.SUPERVISE_WAY.Contain(model.SUPERVISE_WAY));
            }
            if (model.M_TM != null)
            {
                condition.And(RECORD_REVIEW_SUPERVISE._.M_TM == (model.M_TM));
            }
            return condition;
        }
        #endregion
    }
}