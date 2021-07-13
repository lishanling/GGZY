using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TMacService : BaseServiceT<T_MAC>
    {
        #region 接口实现

        public List<T_MAC> FindList(T_MAC model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_MAC> PageList(T_MAC model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, T_MAC._.MID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="MID"></param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string MID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(T_MAC._.MID == MID);

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
        public GeneralResult Edit(T_MAC model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.MID);

                if (viewResult.Success && viewResult.Data is T_MAC entity)
                {
                    entity.Attach();
                    entity.MID = model.MID;
                    entity.INFO_ID = model.INFO_ID;
                    entity.CPU_ID = model.CPU_ID;
                    entity.HDISK = model.HDISK;
                    entity.BIDDER_NAME = model.BIDDER_NAME;
                    entity.MAC = model.MAC;
                    entity.BIDDER_ORG_CODE = model.BIDDER_ORG_CODE;
                    entity.TI = model.TI;
                    entity.SOURCETYPE = model.SOURCETYPE;
                    entity.UPDATETIME = model.UPDATETIME;
                    entity.TENDER_PROJECT_CODE = model.TENDER_PROJECT_CODE;
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
        public GeneralResult Add(T_MAC model)
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
                    Delete(T_MAC._.MID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_MAC> model)
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
        protected WhereClipBuilder ConditionBuilder(T_MAC model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.MID))
            {
                condition.And(T_MAC._.MID.Contain(model.MID));
            }
            if (model.INFO_ID != null)
            {
                condition.And(T_MAC._.INFO_ID == (model.INFO_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.CPU_ID))
            {
                condition.And(T_MAC._.CPU_ID.Contain(model.CPU_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.HDISK))
            {
                condition.And(T_MAC._.HDISK.Contain(model.HDISK));
            }
            if (!string.IsNullOrWhiteSpace(model.BIDDER_NAME))
            {
                condition.And(T_MAC._.BIDDER_NAME.Contain(model.BIDDER_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.MAC))
            {
                condition.And(T_MAC._.MAC.Contain(model.MAC));
            }
            if (!string.IsNullOrWhiteSpace(model.BIDDER_ORG_CODE))
            {
                condition.And(T_MAC._.BIDDER_ORG_CODE.Contain(model.BIDDER_ORG_CODE));
            }
            if (model.TI != null)
            {
                condition.And(T_MAC._.TI == (model.TI));
            }
            if (model.SOURCETYPE != null)
            {
                condition.And(T_MAC._.SOURCETYPE == (model.SOURCETYPE));
            }
            if (model.UPDATETIME != null)
            {
                condition.And(T_MAC._.UPDATETIME == (model.UPDATETIME));
            }
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
            {
                condition.And(T_MAC._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
            }
            return condition;
        }
        #endregion
    }
}