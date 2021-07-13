using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class VProjectRegisterService : BaseServiceT<V_PROJECT_REGISTER>
    {
        #region 接口实现

        public List<V_PROJECT_REGISTER> FindList(V_PROJECT_REGISTER model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<V_PROJECT_REGISTER> PageList(V_PROJECT_REGISTER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, V_PROJECT_REGISTER._.M_TM.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="M_KEY"></param>
        /// <returns></returns>
        public GeneralResult ViewByPk(decimal? M_KEY)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(V_PROJECT_REGISTER._.M_KEY == M_KEY);

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
        public GeneralResult Edit(V_PROJECT_REGISTER model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.M_KEY);

                if (viewResult.Success && viewResult.Data is V_PROJECT_REGISTER entity)
                {
                    entity.Attach();
                    entity.M_KEY = model.M_KEY;
                    entity.PROJECT_CODE = model.PROJECT_CODE;
                    entity.PROJECT_NAME = model.PROJECT_NAME;
                    entity.TENDER_PROJECT_CODE = model.TENDER_PROJECT_CODE;
                    entity.BID_SECTION_CODE = model.BID_SECTION_CODE;
                    entity.BID_SECTION_NAME = model.BID_SECTION_NAME;
                    entity.TENDER_PROJECT_NAME = model.TENDER_PROJECT_NAME;
                    entity.TENDER_PROJECT_TYPE = model.TENDER_PROJECT_TYPE;
                    entity.REGION_CODE = model.REGION_CODE;
                    entity.TENDER_ORGANIZE_FORM = model.TENDER_ORGANIZE_FORM;
                    entity.M_TM = model.M_TM;
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
        public GeneralResult Add(V_PROJECT_REGISTER model)
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
                    Delete(V_PROJECT_REGISTER._.M_KEY.SelectIn(idArr));
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
        public GeneralResult Import(List<V_PROJECT_REGISTER> model)
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
        protected WhereClipBuilder ConditionBuilder(V_PROJECT_REGISTER model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.M_KEY != null)
            {
                condition.And(V_PROJECT_REGISTER._.M_KEY == (model.M_KEY));
            }
            if (!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
            {
                condition.And(V_PROJECT_REGISTER._.PROJECT_CODE.Contain(model.PROJECT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
            {
                condition.And(V_PROJECT_REGISTER._.PROJECT_NAME.Contain(model.PROJECT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
            {
                condition.And(V_PROJECT_REGISTER._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
            {
                condition.And(V_PROJECT_REGISTER._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.BID_SECTION_NAME))
            {
                condition.And(V_PROJECT_REGISTER._.BID_SECTION_NAME.Contain(model.BID_SECTION_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
            {
                condition.And(V_PROJECT_REGISTER._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
            {
                condition.And(V_PROJECT_REGISTER._.TENDER_PROJECT_TYPE.Contain(model.TENDER_PROJECT_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                condition.And(V_PROJECT_REGISTER._.REGION_CODE.Contain(model.REGION_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_ORGANIZE_FORM))
            {
                condition.And(V_PROJECT_REGISTER._.TENDER_ORGANIZE_FORM.Contain(model.TENDER_ORGANIZE_FORM));
            }
            if (model.M_TM != null)
            {
                condition.And(V_PROJECT_REGISTER._.M_TM == (model.M_TM));
            }
            return condition;
        }
        #endregion
    }
}