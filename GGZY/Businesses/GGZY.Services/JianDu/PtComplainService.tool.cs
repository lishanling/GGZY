using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class PtComplainService : BaseServiceT<PT_COMPLAIN>
    {
        #region 接口实现

        public List<PT_COMPLAIN> FindList(PT_COMPLAIN model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PT_COMPLAIN> PageList(PT_COMPLAIN model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, PT_COMPLAIN._.TM.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public GeneralResult ViewByPk(decimal? ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(PT_COMPLAIN._.ID == ID);

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
        public GeneralResult Edit(PT_COMPLAIN model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is PT_COMPLAIN entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.TITLE = model.TITLE;
                    entity.TYPE = model.TYPE;
                    entity.SOURCES = model.SOURCES;
                    entity.TM = model.TM;
                    entity.USER_ID = model.USER_ID;
                    entity.CONTENTS = model.CONTENTS;
                    entity.AIDS = model.AIDS;
                    entity.CREATE_TM = model.CREATE_TM;
                    entity.TS_ID = model.TS_ID;
                    entity.IS_PUBLIC = model.IS_PUBLIC;
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
        public GeneralResult Add(PT_COMPLAIN model)
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
                    Delete(PT_COMPLAIN._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PT_COMPLAIN> model)
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
        protected WhereClipBuilder ConditionBuilder(PT_COMPLAIN model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(PT_COMPLAIN._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.TITLE))
            {
                condition.And(PT_COMPLAIN._.TITLE.Contain(model.TITLE));
            }
            if (!string.IsNullOrWhiteSpace(model.TYPE))
            {
                if (model.TYPE.Contains(","))
                {
                    var types = model.TYPE.Split(',').Where(c => !string.IsNullOrWhiteSpace(c)).ToList();
                    condition.And(PT_COMPLAIN._.TYPE.In(types));
                }
                else
                {
                    condition.And(PT_COMPLAIN._.TYPE.Contain(model.TYPE));
                }

            }
            if (!string.IsNullOrWhiteSpace(model.SOURCES))
            {
                condition.And(PT_COMPLAIN._.SOURCES.Contain(model.SOURCES));
            }
            if (model.TM != null)
            {
                condition.And(PT_COMPLAIN._.TM == (model.TM));
            }
            if (model.USER_ID != null)
            {
                condition.And(PT_COMPLAIN._.USER_ID == (model.USER_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.CONTENTS))
            {
                condition.And(PT_COMPLAIN._.CONTENTS.Contain(model.CONTENTS));
            }
            if (!string.IsNullOrWhiteSpace(model.AIDS))
            {
                condition.And(PT_COMPLAIN._.AIDS.Contain(model.AIDS));
            }
            if (model.CREATE_TM != null)
            {
                condition.And(PT_COMPLAIN._.CREATE_TM == (model.CREATE_TM));
            }
            if (model.TS_ID != null)
            {
                condition.And(PT_COMPLAIN._.TS_ID == (model.TS_ID));
            }
            if (model.IS_PUBLIC != null)
            {
                condition.And(PT_COMPLAIN._.IS_PUBLIC == (model.IS_PUBLIC));
            }
            return condition;
        }
        #endregion
    }
}