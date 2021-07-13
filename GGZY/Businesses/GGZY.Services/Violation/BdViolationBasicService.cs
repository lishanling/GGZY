using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BdViolationBasicService : BaseServiceT<BD_VIOLATION_BASIC>
    {
        #region 接口实现

        public List<BD_VIOLATION_BASIC> FindList(BD_VIOLATION_BASIC model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BD_VIOLATION_BASIC> PageList(BD_VIOLATION_BASIC model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, BD_VIOLATION_BASIC._.ID.Desc).ToBootstrapTableList(count);


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
            condition.And(BD_VIOLATION_BASIC._.ID == ID);

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
        public GeneralResult Edit(BD_VIOLATION_BASIC model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is BD_VIOLATION_BASIC entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.NAME = model.NAME;
                    entity.CODE = model.CODE;
                    entity.SCORE = model.SCORE;
                    entity.REMARK = model.REMARK;
                    entity.RECORD_TYPE = model.RECORD_TYPE;
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
        public GeneralResult Add(BD_VIOLATION_BASIC model)
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
                    Delete(BD_VIOLATION_BASIC._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BD_VIOLATION_BASIC> model)
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
        protected WhereClipBuilder ConditionBuilder(BD_VIOLATION_BASIC model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.ID))
            {
                condition.And(BD_VIOLATION_BASIC._.ID.Contain(model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.NAME))
            {
                condition.And(BD_VIOLATION_BASIC._.NAME.Contain(model.NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.CODE))
            {
                condition.And(BD_VIOLATION_BASIC._.CODE.Contain(model.CODE));
            }
            if (model.SCORE != null)
            {
                condition.And(BD_VIOLATION_BASIC._.SCORE == (model.SCORE));
            }
            if (!string.IsNullOrWhiteSpace(model.REMARK))
            {
                condition.And(BD_VIOLATION_BASIC._.REMARK.Contain(model.REMARK));
            }
            if (model.RECORD_TYPE != null)
            {
                condition.And(BD_VIOLATION_BASIC._.RECORD_TYPE == (model.RECORD_TYPE));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(BD_VIOLATION_BASIC._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (model.IS_DELETE != null)
            {
                condition.And(BD_VIOLATION_BASIC._.IS_DELETE == (model.IS_DELETE));
            }
            return condition;
        }
        #endregion
    }
}