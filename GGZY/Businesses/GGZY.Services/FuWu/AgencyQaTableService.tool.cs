using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class AgencyQaTableService : BaseServiceT<AGENCY_QA_TABLE>
    {
        #region 接口实现

        public List<AGENCY_QA_TABLE> FindList(AGENCY_QA_TABLE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<AGENCY_QA_TABLE> PageList(AGENCY_QA_TABLE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var orderBy = AGENCY_QA_TABLE._.ID.Desc;
            Field order= model.GetFields().FirstOrDefault(c => c.Name == search.Sort)?? AGENCY_QA_TABLE._.ID;
          

            var pageList = PageList(condition, search, orderBy).ToBootstrapTableList(count);


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
            condition.And(AGENCY_QA_TABLE._.ID == ID);

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
        public GeneralResult Edit(AGENCY_QA_TABLE model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is AGENCY_QA_TABLE entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.PRO_CODE = model.PRO_CODE;
                    entity.QS_TITLE = model.QS_TITLE;
                    entity.TEN_TITLE = model.TEN_TITLE;
                    entity.QS_CONTENT = model.QS_CONTENT;
                    entity.QS_DATE = model.QS_DATE;
                    entity.TEN_PERSON = model.TEN_PERSON;
                    entity.TEN_AGENCY = model.TEN_AGENCY;
                    entity.REMARK = model.REMARK;
                    entity.AGENCY_CODE = model.AGENCY_CODE;
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
        public GeneralResult Add(AGENCY_QA_TABLE model)
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
                    Delete(AGENCY_QA_TABLE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<AGENCY_QA_TABLE> model)
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
        protected WhereClipBuilder ConditionBuilder(AGENCY_QA_TABLE model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(AGENCY_QA_TABLE._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.PRO_CODE))
            {
                condition.And(AGENCY_QA_TABLE._.PRO_CODE.Contain(model.PRO_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.QS_TITLE))
            {
                condition.And(AGENCY_QA_TABLE._.QS_TITLE.Contain(model.QS_TITLE));
            }
            if (!string.IsNullOrWhiteSpace(model.TEN_TITLE))
            {
                condition.And(AGENCY_QA_TABLE._.TEN_TITLE.Contain(model.TEN_TITLE));
            }
            if (!string.IsNullOrWhiteSpace(model.QS_CONTENT))
            {
                condition.And(AGENCY_QA_TABLE._.QS_CONTENT.Contain(model.QS_CONTENT));
            }
            if (model.QS_DATE != null)
            {
                condition.And(AGENCY_QA_TABLE._.QS_DATE == (model.QS_DATE));
            }
            if (!string.IsNullOrWhiteSpace(model.TEN_PERSON))
            {
                condition.And(AGENCY_QA_TABLE._.TEN_PERSON.Contain(model.TEN_PERSON));
            }
            if (!string.IsNullOrWhiteSpace(model.TEN_AGENCY))
            {
                condition.And(AGENCY_QA_TABLE._.TEN_AGENCY.Contain(model.TEN_AGENCY));
            }
            if (!string.IsNullOrWhiteSpace(model.REMARK))
            {
                condition.And(AGENCY_QA_TABLE._.REMARK.Contain(model.REMARK));
            }
            if (!string.IsNullOrWhiteSpace(model.AGENCY_CODE))
            {
                condition.And(AGENCY_QA_TABLE._.AGENCY_CODE.Contain(model.AGENCY_CODE));
            }
            return condition;
        }
        #endregion
    }
}