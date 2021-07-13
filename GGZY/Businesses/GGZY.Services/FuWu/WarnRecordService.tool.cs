using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class WarnRecordService : BaseServiceT<WARN_RECORD>
    {
        #region 接口实现

        public List<WARN_RECORD> FindList(WARN_RECORD model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<WARN_RECORD> PageList(WARN_RECORD model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, WARN_RECORD._.M_ID.Desc).ToBootstrapTableList(count);


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
            condition.And(WARN_RECORD._.M_ID == M_ID);

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
        public GeneralResult Edit(WARN_RECORD model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.M_ID);

                if (viewResult.Success && viewResult.Data is WARN_RECORD entity)
                {
                    entity.Attach();
                    entity.M_ID = model.M_ID;
                    entity.SP_RESULT_ID = model.SP_RESULT_ID;
                    entity.OPERATOR = model.OPERATOR;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    entity.CONTENT = model.CONTENT;
                    entity.OPERATE_TYPE = model.OPERATE_TYPE;
                    entity.REMARK = model.REMARK;
                    entity.WARN_NUMBER = model.WARN_NUMBER;
                    entity.INFO_ACCEPT_TELPHONE = model.INFO_ACCEPT_TELPHONE;
                    entity.ISDELETE = model.ISDELETE;
                    entity.INFO_ACCEPT_TELPHONE1 = model.INFO_ACCEPT_TELPHONE1;
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
        public GeneralResult Add(WARN_RECORD model)
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
                    Delete(WARN_RECORD._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<WARN_RECORD> model)
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
        protected WhereClipBuilder ConditionBuilder(WARN_RECORD model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.M_ID))
            {
                condition.And(WARN_RECORD._.M_ID.Contain(model.M_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.SP_RESULT_ID))
            {
                condition.And(WARN_RECORD._.SP_RESULT_ID.Contain(model.SP_RESULT_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.OPERATOR))
            {
                condition.And(WARN_RECORD._.OPERATOR.Contain(model.OPERATOR));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(WARN_RECORD._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (!string.IsNullOrWhiteSpace(model.CONTENT))
            {
                condition.And(WARN_RECORD._.CONTENT.Contain(model.CONTENT));
            }
            if (!string.IsNullOrWhiteSpace(model.OPERATE_TYPE))
            {
                condition.And(WARN_RECORD._.OPERATE_TYPE.Contain(model.OPERATE_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(model.REMARK))
            {
                condition.And(WARN_RECORD._.REMARK.Contain(model.REMARK));
            }
            if (!string.IsNullOrWhiteSpace(model.WARN_NUMBER))
            {
                condition.And(WARN_RECORD._.WARN_NUMBER.Contain(model.WARN_NUMBER));
            }
            if (!string.IsNullOrWhiteSpace(model.INFO_ACCEPT_TELPHONE))
            {
                condition.And(WARN_RECORD._.INFO_ACCEPT_TELPHONE.Contain(model.INFO_ACCEPT_TELPHONE));
            }
            if (model.ISDELETE != null)
            {
                condition.And(WARN_RECORD._.ISDELETE == (model.ISDELETE));
            }
            if (!string.IsNullOrWhiteSpace(model.INFO_ACCEPT_TELPHONE1))
            {
                condition.And(WARN_RECORD._.INFO_ACCEPT_TELPHONE1.Contain(model.INFO_ACCEPT_TELPHONE1));
            }
            return condition;
        }
        #endregion
    }
}