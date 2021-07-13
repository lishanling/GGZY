using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TMacResultSecondService : BaseServiceT<T_MAC_RESULT_SECOND>
    {
        #region 接口实现

        public List<T_MAC_RESULT_SECOND> FindList(T_MAC_RESULT_SECOND model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_MAC_RESULT_SECOND> PageList(T_MAC_RESULT_SECOND model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, T_MAC_RESULT_SECOND._.SEID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="SEID"></param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string SEID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(T_MAC_RESULT_SECOND._.SEID == SEID);

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
        public GeneralResult Edit(T_MAC_RESULT_SECOND model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.SEID);

                if (viewResult.Success && viewResult.Data is T_MAC_RESULT_SECOND entity)
                {
                    entity.Attach();
                    entity.SEID = model.SEID;
                    entity.BIDDER_NAME = model.BIDDER_NAME;
                    entity.BIDDER_ORG_CODE = model.BIDDER_ORG_CODE;
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
        public GeneralResult Add(T_MAC_RESULT_SECOND model)
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
                    Delete(T_MAC_RESULT_SECOND._.SEID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_MAC_RESULT_SECOND> model)
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
        protected WhereClipBuilder ConditionBuilder(T_MAC_RESULT_SECOND model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.SEID))
            {
                condition.And(T_MAC_RESULT_SECOND._.SEID.Contain(model.SEID));
            }
            if (!string.IsNullOrWhiteSpace(model.BIDDER_NAME))
            {
                condition.And(T_MAC_RESULT_SECOND._.BIDDER_NAME.Contain(model.BIDDER_NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.BIDDER_ORG_CODE))
            {
                condition.And(T_MAC_RESULT_SECOND._.BIDDER_ORG_CODE.Contain(model.BIDDER_ORG_CODE));
            }
            if (model.PCOUNT != null)
            {
                condition.And(T_MAC_RESULT_SECOND._.PCOUNT == (model.PCOUNT));
            }
            if (model.LASTTIME != null)
            {
                condition.And(T_MAC_RESULT_SECOND._.LASTTIME == (model.LASTTIME));
            }
            if (model.UPDATETIME != null)
            {
                condition.And(T_MAC_RESULT_SECOND._.UPDATETIME == (model.UPDATETIME));
            }
            return condition;
        }
        #endregion
    }
}