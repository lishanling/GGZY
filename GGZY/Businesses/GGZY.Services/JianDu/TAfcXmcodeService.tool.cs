using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TAfcXmcodeService :BaseServiceT<T_AFC_XMCODE>
    {
        #region 接口实现

        public List<T_AFC_XMCODE> FindList(T_AFC_XMCODE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_AFC_XMCODE> PageList(T_AFC_XMCODE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, T_AFC_XMCODE._.GUID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="GUID">唯一标识</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string GUID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(T_AFC_XMCODE._.GUID == GUID);

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
        public GeneralResult Edit(T_AFC_XMCODE model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.GUID);

                if (viewResult.Success && viewResult.Data is T_AFC_XMCODE entity)
                {
                    entity.Attach();
                    entity.GUID = model.GUID;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    entity.TZ_CODE = model.TZ_CODE;
                    entity.CODE = model.CODE;
                    entity.PROJECT_NAME = model.PROJECT_NAME;
                    entity.JSON = model.JSON;
                    entity.SOURCE = model.SOURCE;
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
        public GeneralResult Add(T_AFC_XMCODE model)
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
                    Delete(T_AFC_XMCODE._.GUID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_AFC_XMCODE> model)
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
        protected WhereClipBuilder ConditionBuilder(T_AFC_XMCODE model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.GUID))
            {
                condition.And(T_AFC_XMCODE._.GUID.Contain(model.GUID));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(T_AFC_XMCODE._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.TZ_CODE))
            {
                condition.And(T_AFC_XMCODE._.TZ_CODE.Contain(model.TZ_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.CODE))
            {
                condition.And(T_AFC_XMCODE._.CODE.Contain(model.CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
            {
                condition.And(T_AFC_XMCODE._.PROJECT_NAME.Contain(model.PROJECT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.JSON))
            {
                condition.And(T_AFC_XMCODE._.JSON.Contain(model.JSON));
            }
            if (!string.IsNullOrWhiteSpace(model.SOURCE))
            {
                condition.And(T_AFC_XMCODE._.SOURCE.Contain(model.SOURCE));
            }
            if (model.MODIFYTIME.HasValue)
            {
                condition.And(T_AFC_XMCODE._.MODIFYTIME==(model.SOURCE));
            }
            return condition;
        }
        #endregion
    }
}