using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class WarnTemplateService : BaseServiceT<WARN_TEMPLATE>
    {
        #region 接口实现

        public List<WARN_TEMPLATE> FindList(WARN_TEMPLATE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<WARN_TEMPLATE> PageList(WARN_TEMPLATE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, WARN_TEMPLATE._.M_ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="M_ID">唯一标识</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string M_ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(WARN_TEMPLATE._.M_ID == M_ID);

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
        public GeneralResult Edit(WARN_TEMPLATE model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.M_ID);

                if (viewResult.Success && viewResult.Data is WARN_TEMPLATE entity)
                {
                    entity.Attach();
                    entity.M_ID = model.M_ID;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    entity.CONTENT_EDIT = model.CONTENT_EDIT;
                    entity.FOUNDER_ID = model.FOUNDER_ID;
                    entity.FOUNDER_UNIT_ID = model.FOUNDER_UNIT_ID;
                    entity.READ_ONLY = model.READ_ONLY;
                    entity.TEMPLATE_TYPE = model.TEMPLATE_TYPE;
                    entity.CONTENT_TYPE = model.CONTENT_TYPE;
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
        public GeneralResult Add(WARN_TEMPLATE model)
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
                    Delete(WARN_TEMPLATE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<WARN_TEMPLATE> model)
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
        protected WhereClipBuilder ConditionBuilder(WARN_TEMPLATE model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.M_ID))
            {
                condition.And(WARN_TEMPLATE._.M_ID.Contain(model.M_ID));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(WARN_TEMPLATE._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.CONTENT_EDIT))
            {
                condition.And(WARN_TEMPLATE._.CONTENT_EDIT.Contain(model.CONTENT_EDIT));
            }
            if (!string.IsNullOrWhiteSpace(model.FOUNDER_ID))
            {
                condition.And(WARN_TEMPLATE._.FOUNDER_ID.Contain(model.FOUNDER_ID));
            }
            if (model.FOUNDER_UNIT_ID != null)
            {
                condition.And(WARN_TEMPLATE._.FOUNDER_UNIT_ID == (model.FOUNDER_UNIT_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.READ_ONLY))
            {
                condition.And(WARN_TEMPLATE._.READ_ONLY.Contain(model.READ_ONLY));
            }
            if (!string.IsNullOrWhiteSpace(model.TEMPLATE_TYPE))
            {
                condition.And(WARN_TEMPLATE._.TEMPLATE_TYPE.Contain(model.TEMPLATE_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.CONTENT_TYPE))
            {
                condition.And(WARN_TEMPLATE._.CONTENT_TYPE.Contain(model.CONTENT_TYPE));
            }
            return condition;
        }
        #endregion
    }
}