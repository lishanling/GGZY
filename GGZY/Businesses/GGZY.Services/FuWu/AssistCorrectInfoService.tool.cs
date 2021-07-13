using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class AssistCorrectInfoService : BaseServiceT<ASSIST_CORRECT_INFO>
    {
        #region 接口实现

        public List<ASSIST_CORRECT_INFO> FindList(ASSIST_CORRECT_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ASSIST_CORRECT_INFO> PageList(ASSIST_CORRECT_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, ASSIST_CORRECT_INFO._.ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID">id</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(ASSIST_CORRECT_INFO._.ID == ID);

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
        public GeneralResult Edit(ASSIST_CORRECT_INFO model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is ASSIST_CORRECT_INFO entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.TENDER_PROJECT_CODE = model.TENDER_PROJECT_CODE;
                    entity.BID_SECTION_CODE = model.BID_SECTION_CODE;
                    entity.TENDER_PROJECT_MID = model.TENDER_PROJECT_MID;
                    entity.SECTION_MID = model.SECTION_MID;
                    entity.FILE_MID = model.FILE_MID;
                    entity.WIN_MID = model.WIN_MID;
                    entity.OLD_SECTION_AMOUNT = model.OLD_SECTION_AMOUNT;
                    entity.OLD_WIN_AMOUNT = model.OLD_WIN_AMOUNT;
                    entity.OLD_EVAL_METHOD = model.OLD_EVAL_METHOD;
                    entity.NEW_SECTION_AMOUNT = model.NEW_SECTION_AMOUNT;
                    entity.NEW_WIN_AMOUNT = model.NEW_WIN_AMOUNT;
                    entity.NEW_EVAL_METHOD = model.NEW_EVAL_METHOD;
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
        public GeneralResult Add(ASSIST_CORRECT_INFO model)
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
                    Delete(ASSIST_CORRECT_INFO._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ASSIST_CORRECT_INFO> model)
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
        protected WhereClipBuilder ConditionBuilder(ASSIST_CORRECT_INFO model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.ID))
            {
                condition.And(ASSIST_CORRECT_INFO._.ID.Contain(model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
            {
                condition.And(ASSIST_CORRECT_INFO._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
            {
                condition.And(ASSIST_CORRECT_INFO._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
            }
            if (model.TENDER_PROJECT_MID != null)
            {
                condition.And(ASSIST_CORRECT_INFO._.TENDER_PROJECT_MID == (model.TENDER_PROJECT_MID));
            }
            if (model.SECTION_MID != null)
            {
                condition.And(ASSIST_CORRECT_INFO._.SECTION_MID == (model.SECTION_MID));
            }
            if (model.FILE_MID != null)
            {
                condition.And(ASSIST_CORRECT_INFO._.FILE_MID == (model.FILE_MID));
            }
            if (model.WIN_MID != null)
            {
                condition.And(ASSIST_CORRECT_INFO._.WIN_MID == (model.WIN_MID));
            }
            if (model.OLD_SECTION_AMOUNT != null)
            {
                condition.And(ASSIST_CORRECT_INFO._.OLD_SECTION_AMOUNT == (model.OLD_SECTION_AMOUNT));
            }
            if (model.OLD_WIN_AMOUNT != null)
            {
                condition.And(ASSIST_CORRECT_INFO._.OLD_WIN_AMOUNT == (model.OLD_WIN_AMOUNT));
            }
            if (!string.IsNullOrWhiteSpace(model.OLD_EVAL_METHOD))
            {
                condition.And(ASSIST_CORRECT_INFO._.OLD_EVAL_METHOD.Contain(model.OLD_EVAL_METHOD));
            }
            if (model.NEW_SECTION_AMOUNT != null)
            {
                condition.And(ASSIST_CORRECT_INFO._.NEW_SECTION_AMOUNT == (model.NEW_SECTION_AMOUNT));
            }
            if (model.NEW_WIN_AMOUNT != null)
            {
                condition.And(ASSIST_CORRECT_INFO._.NEW_WIN_AMOUNT == (model.NEW_WIN_AMOUNT));
            }
            if (!string.IsNullOrWhiteSpace(model.NEW_EVAL_METHOD))
            {
                condition.And(ASSIST_CORRECT_INFO._.NEW_EVAL_METHOD.Contain(model.NEW_EVAL_METHOD));
            }
            return condition;
        }
        #endregion
    }
}