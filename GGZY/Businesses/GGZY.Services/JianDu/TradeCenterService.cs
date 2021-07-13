using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TradeCenterService : BaseServiceT<TRADE_CENTER>
    {
        #region 接口实现

        public List<TRADE_CENTER> FindList(TRADE_CENTER model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TRADE_CENTER> PageList(TRADE_CENTER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, TRADE_CENTER._.ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }
        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(decimal? ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(TRADE_CENTER._.ID == ID);

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
        public GeneralResult Edit(TRADE_CENTER model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is TRADE_CENTER entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.AREA_CODE = model.AREA_CODE;
                    entity.UNIT_NAME = model.UNIT_NAME;
                    entity.SYSTEM_NO = model.SYSTEM_NO;
                    entity.PRIVATE_KEY = model.PRIVATE_KEY;
                    entity.ADDRESS = model.ADDRESS;
                    entity.CONTACT_NAME = model.CONTACT_NAME;
                    entity.CONTACT_PHONE = model.CONTACT_PHONE;
                    entity.CONTACT_TEL = model.CONTACT_TEL;
                    entity.CREATOR_ID = model.CREATOR_ID;
                    entity.CREATOR = model.CREATOR;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    entity.DATA_TIMESTAMP = model.DATA_TIMESTAMP;
                    entity.IS_DELETE = model.IS_DELETE;
                    entity.NOTIFY_URL = model.NOTIFY_URL;
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
        public GeneralResult Add(TRADE_CENTER model)
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
                    Delete(TRADE_CENTER._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<TRADE_CENTER> model)
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
        protected WhereClipBuilder ConditionBuilder(TRADE_CENTER model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(TRADE_CENTER._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.AREA_CODE))
            {
                condition.And(TRADE_CENTER._.AREA_CODE.Contain(model.AREA_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.UNIT_NAME))
            {
                condition.And(TRADE_CENTER._.UNIT_NAME.Contain(model.UNIT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.SYSTEM_NO))
            {
                condition.And(TRADE_CENTER._.SYSTEM_NO.Contain(model.SYSTEM_NO));
            }
            if (!string.IsNullOrWhiteSpace(model.PRIVATE_KEY))
            {
                condition.And(TRADE_CENTER._.PRIVATE_KEY.Contain(model.PRIVATE_KEY));
            }
            if (!string.IsNullOrWhiteSpace(model.ADDRESS))
            {
                condition.And(TRADE_CENTER._.ADDRESS.Contain(model.ADDRESS));
            }
            if (!string.IsNullOrWhiteSpace(model.CONTACT_NAME))
            {
                condition.And(TRADE_CENTER._.CONTACT_NAME.Contain(model.CONTACT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.CONTACT_PHONE))
            {
                condition.And(TRADE_CENTER._.CONTACT_PHONE.Contain(model.CONTACT_PHONE));
            }
            if (!string.IsNullOrWhiteSpace(model.CONTACT_TEL))
            {
                condition.And(TRADE_CENTER._.CONTACT_TEL.Contain(model.CONTACT_TEL));
            }
            if (model.CREATOR_ID != null)
            {
                condition.And(TRADE_CENTER._.CREATOR_ID == (model.CREATOR_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.CREATOR))
            {
                condition.And(TRADE_CENTER._.CREATOR.Contain(model.CREATOR));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(TRADE_CENTER._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (model.DATA_TIMESTAMP != null)
            {
                condition.And(TRADE_CENTER._.DATA_TIMESTAMP == (model.DATA_TIMESTAMP));
            }
            if (model.IS_DELETE != null)
            {
                condition.And(TRADE_CENTER._.IS_DELETE == (model.IS_DELETE));
            }
            if (!string.IsNullOrWhiteSpace(model.NOTIFY_URL))
            {
                condition.And(TRADE_CENTER._.NOTIFY_URL.Contain(model.NOTIFY_URL));
            }
            return condition;
        }
        #endregion
    }
}