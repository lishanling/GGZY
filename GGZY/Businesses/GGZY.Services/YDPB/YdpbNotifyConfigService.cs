using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class YdpbNotifyConfigService : BaseServiceT<YDPB_NOTIFY_CONFIG>
    {
        #region 接口实现

        public List<YDPB_NOTIFY_CONFIG> FindList(YDPB_NOTIFY_CONFIG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<YDPB_NOTIFY_CONFIG> PageList(YDPB_NOTIFY_CONFIG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, YDPB_NOTIFY_CONFIG._.ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID">主键</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(YDPB_NOTIFY_CONFIG._.ID == ID);

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
        public GeneralResult Edit(YDPB_NOTIFY_CONFIG model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is YDPB_NOTIFY_CONFIG entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.AREA_CODE = model.AREA_CODE;
                    entity.UNIT_NAME = model.UNIT_NAME;
                    entity.SYSTEM_NO = model.SYSTEM_NO;
                    entity.INTERFACE_CODE = model.INTERFACE_CODE;
                    entity.INTERFACE_NAME = model.INTERFACE_NAME;
                    entity.URL = model.URL;
                    entity.CREATE_TIME = model.CREATE_TIME;
                    entity.DATA_TIMESTAMP = model.DATA_TIMESTAMP;
                    entity.IS_DELETE = model.IS_DELETE;
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
        public GeneralResult Add(YDPB_NOTIFY_CONFIG model)
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
                    Delete(YDPB_NOTIFY_CONFIG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<YDPB_NOTIFY_CONFIG> model)
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
        protected WhereClipBuilder ConditionBuilder(YDPB_NOTIFY_CONFIG model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.ID))
            {
                condition.And(YDPB_NOTIFY_CONFIG._.ID.Contain(model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.AREA_CODE))
            {
                condition.And(YDPB_NOTIFY_CONFIG._.AREA_CODE.Contain(model.AREA_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.UNIT_NAME))
            {
                condition.And(YDPB_NOTIFY_CONFIG._.UNIT_NAME.Contain(model.UNIT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.SYSTEM_NO))
            {
                condition.And(YDPB_NOTIFY_CONFIG._.SYSTEM_NO.Contain(model.SYSTEM_NO));
            }
            if (!string.IsNullOrWhiteSpace(model.INTERFACE_CODE))
            {
                condition.And(YDPB_NOTIFY_CONFIG._.INTERFACE_CODE.Contain(model.INTERFACE_CODE));
            }
            if (!string.IsNullOrWhiteSpace(model.INTERFACE_NAME))
            {
                condition.And(YDPB_NOTIFY_CONFIG._.INTERFACE_NAME.Contain(model.INTERFACE_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.URL))
            {
                condition.And(YDPB_NOTIFY_CONFIG._.URL.Contain(model.URL));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(YDPB_NOTIFY_CONFIG._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (model.DATA_TIMESTAMP != null)
            {
                condition.And(YDPB_NOTIFY_CONFIG._.DATA_TIMESTAMP == (model.DATA_TIMESTAMP));
            }
            if (model.IS_DELETE != null)
            {
                condition.And(YDPB_NOTIFY_CONFIG._.IS_DELETE == (model.IS_DELETE));
            }
            return condition;
        }
        #endregion
    }
}