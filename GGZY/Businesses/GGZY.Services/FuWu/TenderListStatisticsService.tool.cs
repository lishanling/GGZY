using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TenderListStatisticsService : BaseServiceT<TENDER_LIST_STATISTICS>
    {
        #region 接口实现

        public List<TENDER_LIST_STATISTICS> FindList(TENDER_LIST_STATISTICS model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TENDER_LIST_STATISTICS> PageList(TENDER_LIST_STATISTICS model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, TENDER_LIST_STATISTICS._.TID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="TID"></param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string TID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(TENDER_LIST_STATISTICS._.TID == TID);

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
        public GeneralResult Edit(TENDER_LIST_STATISTICS model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.TID);

                if (viewResult.Success && viewResult.Data is TENDER_LIST_STATISTICS entity)
                {
                    entity.Attach();
                    entity.TID = model.TID;
                    entity.BID_MANAGER = model.BID_MANAGER;
                    entity.PM_CODE = model.PM_CODE;
                    entity.PCOUNT = model.PCOUNT;
                    entity.LASTTIME = model.LASTTIME;
                    entity.UPDATETIME = model.UPDATETIME;
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
        public GeneralResult Add(TENDER_LIST_STATISTICS model)
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
                    Delete(TENDER_LIST_STATISTICS._.TID.SelectIn(idArr));
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
        public GeneralResult Import(List<TENDER_LIST_STATISTICS> model)
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
        protected WhereClipBuilder ConditionBuilder(TENDER_LIST_STATISTICS model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.TID))
            {
                condition.And(TENDER_LIST_STATISTICS._.TID.Contain(model.TID));
            }
            if (!string.IsNullOrWhiteSpace(model.BID_MANAGER))
            {
                condition.And(TENDER_LIST_STATISTICS._.BID_MANAGER.Contain(model.BID_MANAGER));
            }
            if (!string.IsNullOrWhiteSpace(model.PM_CODE))
            {
                condition.And(TENDER_LIST_STATISTICS._.PM_CODE.Contain(model.PM_CODE));
            }
            if (model.PCOUNT != null)
            {
                condition.And(TENDER_LIST_STATISTICS._.PCOUNT == (model.PCOUNT));
            }
            if (model.LASTTIME != null)
            {
                condition.And(TENDER_LIST_STATISTICS._.LASTTIME == (model.LASTTIME));
            }
            if (model.UPDATETIME != null)
            {
                condition.And(TENDER_LIST_STATISTICS._.UPDATETIME == (model.UPDATETIME));
            }
            return condition;
        }
        #endregion
    }
}