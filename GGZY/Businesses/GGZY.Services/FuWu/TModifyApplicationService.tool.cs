using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TModifyApplicationService : BaseServiceT<T_MODIFY_APPLICATION>
    {
        #region 接口实现

        public List<T_MODIFY_APPLICATION> FindList(T_MODIFY_APPLICATION model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_MODIFY_APPLICATION> PageList(T_MODIFY_APPLICATION model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, T_MODIFY_APPLICATION._.GUID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="GUID">主键id</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string GUID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(T_MODIFY_APPLICATION._.GUID == GUID);

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
        public GeneralResult Edit(T_MODIFY_APPLICATION model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.GUID);

                if (viewResult.Success && viewResult.Data is T_MODIFY_APPLICATION entity)
                {
                    entity.Attach();
                    entity.GUID = model.GUID;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    entity.CREATOR = model.CREATOR;
                    entity.MODIFY_TYPE = model.MODIFY_TYPE;
                    entity.BACK_TABLE = model.BACK_TABLE;
                    entity.REVIEW_TIME = model.REVIEW_TIME;
                    entity.REVIEW_USER_ID = model.REVIEW_USER_ID;
                    entity.TENDER_PROJECT_CODE = model.TENDER_PROJECT_CODE;
                    entity.REVIEW_CODE = model.REVIEW_CODE;
                    entity.ATTACHMENT_ID = model.ATTACHMENT_ID;
                    entity.REPORT_CODE = model.REPORT_CODE;
                    entity.TABLE_ID = model.TABLE_ID;
                    entity.REVIEW_STATUS = model.REVIEW_STATUS;
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
        public GeneralResult Add(T_MODIFY_APPLICATION model)
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
                    Delete(T_MODIFY_APPLICATION._.GUID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_MODIFY_APPLICATION> model)
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
        protected WhereClipBuilder ConditionBuilder(T_MODIFY_APPLICATION model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.GUID))
            {
                condition.And(T_MODIFY_APPLICATION._.GUID.Contain(model.GUID));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(T_MODIFY_APPLICATION._.CREATE_TIME == (model.CREATE_TIME));
            }
#pragma warning disable CS0472 // 由于“int”类型的值永不等于“int?”类型的 "null"，该表达式的结果始终为“true”
            if (model.CREATOR != null)
#pragma warning restore CS0472 // 由于“int”类型的值永不等于“int?”类型的 "null"，该表达式的结果始终为“true”
            {
                condition.And(T_MODIFY_APPLICATION._.CREATOR == (model.CREATOR));
            }
            if (!string.IsNullOrWhiteSpace(model.MODIFY_TYPE))
            {
                condition.And(T_MODIFY_APPLICATION._.MODIFY_TYPE.Contain(model.MODIFY_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.BACK_TABLE))
            {
                condition.And(T_MODIFY_APPLICATION._.BACK_TABLE.Contain(model.BACK_TABLE));
            }
            if (model.REVIEW_TIME != null)
            {
                condition.And(T_MODIFY_APPLICATION._.REVIEW_TIME == (model.REVIEW_TIME));
            }
#pragma warning disable CS0472 // 由于“int”类型的值永不等于“int?”类型的 "null"，该表达式的结果始终为“true”
            if (model.REVIEW_USER_ID != null)
#pragma warning restore CS0472 // 由于“int”类型的值永不等于“int?”类型的 "null"，该表达式的结果始终为“true”
            {
                condition.And(T_MODIFY_APPLICATION._.REVIEW_USER_ID == (model.REVIEW_USER_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
            {
                condition.And(T_MODIFY_APPLICATION._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.REVIEW_CODE))
            {
                condition.And(T_MODIFY_APPLICATION._.REVIEW_CODE.Contain(model.REVIEW_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.ATTACHMENT_ID))
            {
                condition.And(T_MODIFY_APPLICATION._.ATTACHMENT_ID.Contain(model.ATTACHMENT_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.REPORT_CODE))
            {
                condition.And(T_MODIFY_APPLICATION._.REPORT_CODE.Contain(model.REPORT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.TABLE_ID))
            {
                condition.And(T_MODIFY_APPLICATION._.TABLE_ID.Contain(model.TABLE_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.REVIEW_STATUS))
            {
                condition.And(T_MODIFY_APPLICATION._.REVIEW_STATUS.Contain(model.REVIEW_STATUS));
            }
            return condition;
        }
        #endregion
    }
}