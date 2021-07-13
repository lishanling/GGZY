using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJH.DbEntity;

namespace GGZY.Services.ZBCG
{
    public partial class ZpFaqService : BaseServiceT<ZP_FAQ>
    {
        #region 接口实现

        public List<ZP_FAQ> FindList(ZP_FAQ model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZP_FAQ> PageList(ZP_FAQ model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, ZP_FAQ._.ZF_ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ZF_ID"></param>
        /// <returns></returns>
        public GeneralResult ViewByPk(decimal? ZF_ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(ZP_FAQ._.ZF_ID == ZF_ID);

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
        public GeneralResult Edit(ZP_FAQ model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ZF_ID);

                if (viewResult.Success && viewResult.Data is ZP_FAQ entity)
                {
                    entity.Attach();
                    entity.ZF_ID = model.ZF_ID;
                    entity.ZF_TITLE = model.ZF_TITLE;
                    entity.ZF_QID = model.ZF_QID;
                    entity.ZF_QNAME = model.ZF_QNAME;
                    entity.ZF_AID = model.ZF_AID;
                    entity.ZF_ANAME = model.ZF_ANAME;
                    entity.ZF_TYPE = model.ZF_TYPE;
                    entity.ZF_QTIME = model.ZF_QTIME;
                    entity.ZF_ATIME = model.ZF_ATIME;
                    entity.ZF_TID = model.ZF_TID;
                    entity.ZF_STATE = model.ZF_STATE;
                    entity.CRTIME = model.CRTIME;
                    entity.ZF_ANSWER = model.ZF_ANSWER;
                    entity.ZF_QUESTION = model.ZF_QUESTION;
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
        public GeneralResult Add(ZP_FAQ model)
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
                    Delete(ZP_FAQ._.ZF_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZP_FAQ> model)
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
        protected WhereClipBuilder ConditionBuilder(ZP_FAQ model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ZF_ID != null)
            {
                condition.And(ZP_FAQ._.ZF_ID == (model.ZF_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.ZF_TITLE))
            {
                condition.And(ZP_FAQ._.ZF_TITLE.Contain(model.ZF_TITLE));
            }
            if (!string.IsNullOrWhiteSpace(model.ZF_QID))
            {
                condition.And(ZP_FAQ._.ZF_QID.Contain(model.ZF_QID));
            }
            if (!string.IsNullOrWhiteSpace(model.ZF_QNAME))
            {
                condition.And(ZP_FAQ._.ZF_QNAME.Contain(model.ZF_QNAME));
            }
            if (!string.IsNullOrWhiteSpace(model.ZF_AID))
            {
                condition.And(ZP_FAQ._.ZF_AID.Contain(model.ZF_AID));
            }
            if (!string.IsNullOrWhiteSpace(model.ZF_ANAME))
            {
                condition.And(ZP_FAQ._.ZF_ANAME.Contain(model.ZF_ANAME));
            }
            if (!string.IsNullOrWhiteSpace(model.ZF_TYPE))
            {
                condition.And(ZP_FAQ._.ZF_TYPE.Contain(model.ZF_TYPE));
            }
            if (model.ZF_QTIME != null)
            {
                condition.And(ZP_FAQ._.ZF_QTIME == (model.ZF_QTIME));
            }
            if (model.ZF_ATIME != null)
            {
                condition.And(ZP_FAQ._.ZF_ATIME == (model.ZF_ATIME));
            }
            if (model.ZF_TID != null)
            {
                condition.And(ZP_FAQ._.ZF_TID == (model.ZF_TID));
            }
            if (!string.IsNullOrWhiteSpace(model.ZF_STATE))
            {
                condition.And(ZP_FAQ._.ZF_STATE.Contain(model.ZF_STATE));
            }
            if (model.CRTIME != null)
            {
                condition.And(ZP_FAQ._.CRTIME == (model.CRTIME));
            }
            if (!string.IsNullOrWhiteSpace(model.ZF_ANSWER))
            {
                condition.And(ZP_FAQ._.ZF_ANSWER.Contain(model.ZF_ANSWER));
            }
            if (!string.IsNullOrWhiteSpace(model.ZF_QUESTION))
            {
                condition.And(ZP_FAQ._.ZF_QUESTION.Contain(model.ZF_QUESTION));
            }
            return condition;
        }
        #endregion
    }
}