using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class OpertionRecordService : BaseServiceT<OPERTION_RECORD>
    {
        #region 接口实现

        public List<OPERTION_RECORD> FindList(OPERTION_RECORD model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<OPERTION_RECORD> PageList(OPERTION_RECORD model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, OPERTION_RECORD._.CREATE_TM.Desc).ToBootstrapTableList(count);


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
            condition.And(OPERTION_RECORD._.ID == ID);

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
        public GeneralResult Edit(OPERTION_RECORD model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is OPERTION_RECORD entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.RECORD_ID = model.RECORD_ID;
                    entity.DEPID = model.DEPID;
                    entity.OPERATION_PERSON = model.OPERATION_PERSON;
                    entity.OPERATION_TIME = model.OPERATION_TIME;
                    entity.OPERATION_BEHAVIOR = model.OPERATION_BEHAVIOR;
                    entity.REVIEW_OPINION = model.REVIEW_OPINION;
                    entity.ATTACHMENT_ID = model.ATTACHMENT_ID;
                    entity.CREATE_TM = model.CREATE_TM;
                    entity.CREATOR = model.CREATOR;
                    entity.VERSION = model.VERSION;
                    entity.INSTANCE_ID = model.INSTANCE_ID;
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
        public GeneralResult Add(OPERTION_RECORD model)
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
                    Delete(OPERTION_RECORD._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<OPERTION_RECORD> model)
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
        protected WhereClipBuilder ConditionBuilder(OPERTION_RECORD model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(OPERTION_RECORD._.ID == (model.ID));
            }
            if (model.RECORD_ID != null)
            {
                condition.And(OPERTION_RECORD._.RECORD_ID == (model.RECORD_ID));
            }
            if (model.DEPID != null)
            {
                condition.And(OPERTION_RECORD._.DEPID == (model.DEPID));
            }
            if (model.OPERATION_PERSON != null)
            {
                condition.And(OPERTION_RECORD._.OPERATION_PERSON == (model.OPERATION_PERSON));
            }
            if (model.OPERATION_TIME != null)
            {
                condition.And(OPERTION_RECORD._.OPERATION_TIME == (model.OPERATION_TIME));
            }
            if (model.OPERATION_BEHAVIOR != null)
            {
                condition.And(OPERTION_RECORD._.OPERATION_BEHAVIOR == (model.OPERATION_BEHAVIOR));
            }
            if (!string.IsNullOrWhiteSpace(model.REVIEW_OPINION))
            {
                condition.And(OPERTION_RECORD._.REVIEW_OPINION.Contain(model.REVIEW_OPINION));
            }
            if (!string.IsNullOrWhiteSpace(model.ATTACHMENT_ID))
            {
                condition.And(OPERTION_RECORD._.ATTACHMENT_ID.Contain(model.ATTACHMENT_ID));
            }
            if (model.CREATE_TM != null)
            {
                condition.And(OPERTION_RECORD._.CREATE_TM == (model.CREATE_TM));
            }
            if (model.CREATOR != null)
            {
                condition.And(OPERTION_RECORD._.CREATOR == (model.CREATOR));
            }
            if (!string.IsNullOrWhiteSpace(model.VERSION))
            {
                condition.And(OPERTION_RECORD._.VERSION.Contain(model.VERSION));
            }
            if (model.INSTANCE_ID != null)
            {
                condition.And(OPERTION_RECORD._.INSTANCE_ID == (model.INSTANCE_ID));
            }
            return condition;
        }
        #endregion
    }
}