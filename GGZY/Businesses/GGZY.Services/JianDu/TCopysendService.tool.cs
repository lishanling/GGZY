using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TCopysendService : BaseServiceT<T_COPYSEND>
    {
        #region 接口实现

        public List<T_COPYSEND> FindList(T_COPYSEND model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_COPYSEND> PageList(T_COPYSEND model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, T_COPYSEND._.CS_TIME.Desc).ToBootstrapTableList(count);


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
            condition.And(T_COPYSEND._.ID == ID);

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
        public GeneralResult Edit(T_COPYSEND model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is T_COPYSEND entity)
                {
                    entity.Attach();
                    entity.CS_TIME = model.CS_TIME;
                    entity.CS_CONTENT = model.CS_CONTENT;
                    entity.CS_NAME = model.CS_NAME;
                    entity.CS_ID = model.CS_ID;
                    entity.ID = model.ID;
                    entity.CS_PUNISH_ID = model.CS_PUNISH_ID;
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
        public GeneralResult Add(T_COPYSEND model)
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
                    Delete(T_COPYSEND._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_COPYSEND> model)
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
        protected WhereClipBuilder ConditionBuilder(T_COPYSEND model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.CS_TIME != null)
            {
                condition.And(T_COPYSEND._.CS_TIME == (model.CS_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.CS_CONTENT))
            {
                condition.And(T_COPYSEND._.CS_CONTENT.Contain(model.CS_CONTENT));
            }
            if (!string.IsNullOrWhiteSpace(model.CS_NAME))
            {
                condition.And(T_COPYSEND._.CS_NAME.Contain(model.CS_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.CS_ID))
            {
                condition.And(T_COPYSEND._.CS_ID.Contain(model.CS_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.ID))
            {
                condition.And(T_COPYSEND._.ID.Contain(model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.CS_PUNISH_ID))
            {
                condition.And(T_COPYSEND._.CS_PUNISH_ID.Contain(model.CS_PUNISH_ID));
            }
            return condition;
        }
        #endregion
    }
}