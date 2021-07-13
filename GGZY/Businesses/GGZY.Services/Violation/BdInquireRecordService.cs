using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BdInquireRecordService : BaseServiceT<BD_INQUIRE_RECORD>
    {
        #region 接口实现

        public List<BD_INQUIRE_RECORD> FindList(BD_INQUIRE_RECORD model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BD_INQUIRE_RECORD> PageList(BD_INQUIRE_RECORD model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, BD_INQUIRE_RECORD._.ID.Desc).ToBootstrapTableList(count);


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
            condition.And(BD_INQUIRE_RECORD._.ID == ID);

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
        public GeneralResult Edit(BD_INQUIRE_RECORD model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is BD_INQUIRE_RECORD entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.VIOLATION_RECORD_ID = model.VIOLATION_RECORD_ID;
                    entity.STATE = model.STATE;
                    entity.DESCRIPTION = model.DESCRIPTION;
                    entity.GUIDS = model.GUIDS;
                    entity.OPERATION_USER = model.OPERATION_USER;
                    entity.OPERATION_DEPT = model.OPERATION_DEPT;
                    entity.OPERATION_TIME = model.OPERATION_TIME;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    entity.IS_DELETE = model.IS_DELETE;
                    entity.POINT_TYPE = model.POINT_TYPE;
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
        public GeneralResult Add(BD_INQUIRE_RECORD model)
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
                    Delete(BD_INQUIRE_RECORD._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BD_INQUIRE_RECORD> model)
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
        protected WhereClipBuilder ConditionBuilder(BD_INQUIRE_RECORD model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.ID))
            {
                condition.And(BD_INQUIRE_RECORD._.ID.Contain(model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.VIOLATION_RECORD_ID))
            {
                condition.And(BD_INQUIRE_RECORD._.VIOLATION_RECORD_ID.Contain(model.VIOLATION_RECORD_ID));
            }
            if (model.STATE != null)
            {
                condition.And(BD_INQUIRE_RECORD._.STATE == (model.STATE));
            }
            if (!string.IsNullOrWhiteSpace(model.DESCRIPTION))
            {
                condition.And(BD_INQUIRE_RECORD._.DESCRIPTION.Contain(model.DESCRIPTION));
            }
            if (!string.IsNullOrWhiteSpace(model.GUIDS))
            {
                condition.And(BD_INQUIRE_RECORD._.GUIDS.Contain(model.GUIDS));
            }
            if (model.OPERATION_USER != null)
            {
                condition.And(BD_INQUIRE_RECORD._.OPERATION_USER == (model.OPERATION_USER));
            }
            if (model.OPERATION_DEPT != null)
            {
                condition.And(BD_INQUIRE_RECORD._.OPERATION_DEPT == (model.OPERATION_DEPT));
            }
            if (model.OPERATION_TIME != null)
            {
                condition.And(BD_INQUIRE_RECORD._.OPERATION_TIME == (model.OPERATION_TIME));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(BD_INQUIRE_RECORD._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (model.IS_DELETE != null)
            {
                condition.And(BD_INQUIRE_RECORD._.IS_DELETE == (model.IS_DELETE));
            }
            if (model.POINT_TYPE != null)
            {
                condition.And(BD_INQUIRE_RECORD._.POINT_TYPE == (model.POINT_TYPE));
            }
            return condition;
        }
        #endregion
    }
}