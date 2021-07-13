using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TPunishService : BaseServiceT<T_PUNISH>
    {
        #region 接口实现

        public List<T_PUNISH> FindList(T_PUNISH model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_PUNISH> PageList(T_PUNISH model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, T_PUNISH._.ID.Desc).ToBootstrapTableList(count);


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
            condition.And(T_PUNISH._.ID == ID);

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
        public GeneralResult Edit(T_PUNISH model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is T_PUNISH entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.PUNISH_CONTENT = model.PUNISH_CONTENT;
                    entity.TENDER_PROJECT_CODE = model.TENDER_PROJECT_CODE;
                    entity.PUNISH_TIME = model.PUNISH_TIME;
                    entity.USE_OPERATOR = model.USE_OPERATOR;
                    entity.PUNISH_ID = model.PUNISH_ID;
                    entity.PUNISH_TITLE = model.PUNISH_TITLE;
                    entity.PUNISH_CODE = model.PUNISH_CODE;
                    entity.PUNISH_FILE = model.PUNISH_FILE;
                    entity.TENDER_PROJECT_TYPE = model.TENDER_PROJECT_TYPE;
                    entity.REGION_CODE = model.REGION_CODE;
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
        public GeneralResult Add(T_PUNISH model)
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
                    Delete(T_PUNISH._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_PUNISH> model)
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
        protected WhereClipBuilder ConditionBuilder(T_PUNISH model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.ID))
            {
                condition.And(T_PUNISH._.ID.Contain(model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.PUNISH_CONTENT))
            {
                condition.And(T_PUNISH._.PUNISH_CONTENT.Contain(model.PUNISH_CONTENT));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
            {
                condition.And(T_PUNISH._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
            }
            if (model.PUNISH_TIME != null)
            {
                condition.And(T_PUNISH._.PUNISH_TIME == (model.PUNISH_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.USE_OPERATOR))
            {
                condition.And(T_PUNISH._.USE_OPERATOR.Contain(model.USE_OPERATOR));
            }
            if (!string.IsNullOrWhiteSpace(model.PUNISH_ID))
            {
                condition.And(T_PUNISH._.PUNISH_ID.Contain(model.PUNISH_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.PUNISH_TITLE))
            {
                condition.And(T_PUNISH._.PUNISH_TITLE.Contain(model.PUNISH_TITLE));
            }
            if (!string.IsNullOrWhiteSpace(model.PUNISH_CODE))
            {
                condition.And(T_PUNISH._.PUNISH_CODE.Contain(model.PUNISH_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.PUNISH_FILE))
            {
                condition.And(T_PUNISH._.PUNISH_FILE.Contain(model.PUNISH_FILE));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition.And(T_PUNISH._.TENDER_PROJECT_TYPE.Contain(model.TENDER_PROJECT_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition.And(T_PUNISH._.REGION_CODE.Contain(model.REGION_CODE));
            }
            return condition;
        }
        #endregion
    }
}