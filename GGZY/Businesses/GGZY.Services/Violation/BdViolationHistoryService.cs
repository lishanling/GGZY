using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.FuWu
{
    public partial class BdViolationHistoryService : BaseServiceT<BD_VIOLATION_HISTORY>
    {
        #region 接口实现

        public List<BD_VIOLATION_HISTORY> FindList(BD_VIOLATION_HISTORY model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BD_VIOLATION_HISTORY> PageList(BD_VIOLATION_HISTORY model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, BD_VIOLATION_HISTORY._.ID.Desc).ToBootstrapTableList(count);


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
            condition.And(BD_VIOLATION_HISTORY._.ID == ID);

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
        public GeneralResult Edit(BD_VIOLATION_HISTORY model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is BD_VIOLATION_HISTORY entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.RECORD_ID = model.RECORD_ID;
                    entity.SOURCE_FIELD = model.SOURCE_FIELD;
                    entity.SOURCE_VALUE = model.SOURCE_VALUE;
                    entity.TARGET_FIELD = model.TARGET_FIELD;
                    entity.TARGET_VALUE = model.TARGET_VALUE;
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
        public GeneralResult Add(BD_VIOLATION_HISTORY model)
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
                    Delete(BD_VIOLATION_HISTORY._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BD_VIOLATION_HISTORY> model)
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
        protected WhereClipBuilder ConditionBuilder(BD_VIOLATION_HISTORY model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.ID))
            {
                condition.And(BD_VIOLATION_HISTORY._.ID.Contain(model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.RECORD_ID))
            {
                condition.And(BD_VIOLATION_HISTORY._.RECORD_ID.Contain(model.RECORD_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.SOURCE_FIELD))
            {
                condition.And(BD_VIOLATION_HISTORY._.SOURCE_FIELD.Contain(model.SOURCE_FIELD));
            }
            if (!string.IsNullOrWhiteSpace(model.SOURCE_VALUE))
            {
                condition.And(BD_VIOLATION_HISTORY._.SOURCE_VALUE.Contain(model.SOURCE_VALUE));
            }
            if (!string.IsNullOrWhiteSpace(model.TARGET_FIELD))
            {
                condition.And(BD_VIOLATION_HISTORY._.TARGET_FIELD.Contain(model.TARGET_FIELD));
            }
            if (!string.IsNullOrWhiteSpace(model.TARGET_VALUE))
            {
                condition.And(BD_VIOLATION_HISTORY._.TARGET_VALUE.Contain(model.TARGET_VALUE));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(BD_VIOLATION_HISTORY._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (model.IS_DELETE != null)
            {
                condition.And(BD_VIOLATION_HISTORY._.IS_DELETE == (model.IS_DELETE));
            }
            return condition;
        }
        #endregion
    }

}
