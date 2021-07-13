using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class PtZxtsLookIntoService : BaseServiceT<PT_ZXTS_LOOK_INTO>
    {
        #region 接口实现

        public List<PT_ZXTS_LOOK_INTO> FindList(PT_ZXTS_LOOK_INTO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PT_ZXTS_LOOK_INTO> PageList(PT_ZXTS_LOOK_INTO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, PT_ZXTS_LOOK_INTO._.ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID">主键，唯一标识</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(PT_ZXTS_LOOK_INTO._.ID == ID);

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
        public GeneralResult Edit(PT_ZXTS_LOOK_INTO model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is PT_ZXTS_LOOK_INTO entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.TS_CODE = model.TS_CODE;
                    entity.LOOK_CONTENT = model.LOOK_CONTENT;
                    entity.LOOK_AIDS = model.LOOK_AIDS;
                    entity.LOOK_TIME = model.LOOK_TIME;
                    entity.CREATEDBY = model.CREATEDBY;
                    entity.CREATEDTIME = model.CREATEDTIME;
                    entity.UPDATEDBY = model.UPDATEDBY;
                    entity.UPDATEDTIME = model.UPDATEDTIME;
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
        public GeneralResult Add(PT_ZXTS_LOOK_INTO model)
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
                    Delete(PT_ZXTS_LOOK_INTO._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PT_ZXTS_LOOK_INTO> model)
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
        protected WhereClipBuilder ConditionBuilder(PT_ZXTS_LOOK_INTO model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.ID))
            {
                condition.And(PT_ZXTS_LOOK_INTO._.ID.Contain(model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.TS_CODE))
            {
                condition.And(PT_ZXTS_LOOK_INTO._.TS_CODE.Contain(model.TS_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.LOOK_CONTENT))
            {
                condition.And(PT_ZXTS_LOOK_INTO._.LOOK_CONTENT.Contain(model.LOOK_CONTENT));
            }
            if (!string.IsNullOrWhiteSpace(model.LOOK_AIDS))
            {
                condition.And(PT_ZXTS_LOOK_INTO._.LOOK_AIDS.Contain(model.LOOK_AIDS));
            }
            if (model.LOOK_TIME != null)
            {
                condition.And(PT_ZXTS_LOOK_INTO._.LOOK_TIME == (model.LOOK_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.CREATEDBY))
            {
                condition.And(PT_ZXTS_LOOK_INTO._.CREATEDBY.Contain(model.CREATEDBY));
            }
            if (model.CREATEDTIME != null)
            {
                condition.And(PT_ZXTS_LOOK_INTO._.CREATEDTIME == (model.CREATEDTIME));
            }
            if (!string.IsNullOrWhiteSpace(model.UPDATEDBY))
            {
                condition.And(PT_ZXTS_LOOK_INTO._.UPDATEDBY.Contain(model.UPDATEDBY));
            }
            if (model.UPDATEDTIME != null)
            {
                condition.And(PT_ZXTS_LOOK_INTO._.UPDATEDTIME == (model.UPDATEDTIME));
            }
            return condition;
        }
        #endregion
    }
}