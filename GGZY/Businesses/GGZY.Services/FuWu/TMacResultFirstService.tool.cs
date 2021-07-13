using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TMacResultFirstService : BaseServiceT<T_MAC_RESULT_FIRST>
    {
        #region 接口实现

        public List<T_MAC_RESULT_FIRST> FindList(T_MAC_RESULT_FIRST model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_MAC_RESULT_FIRST> PageList(T_MAC_RESULT_FIRST model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, T_MAC_RESULT_FIRST._.FID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="FID"></param>
        /// <returns></returns>
        public GeneralResult ViewByPk(string FID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(T_MAC_RESULT_FIRST._.FID == FID);

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
        public GeneralResult Edit(T_MAC_RESULT_FIRST model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.FID);

                if (viewResult.Success && viewResult.Data is T_MAC_RESULT_FIRST entity)
                {
                    entity.Attach();
                    entity.FID = model.FID;
                    entity.CPU_ID = model.CPU_ID;
                    entity.HDISK = model.HDISK;
                    entity.MAC = model.MAC;
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
        public GeneralResult Add(T_MAC_RESULT_FIRST model)
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
                    Delete(T_MAC_RESULT_FIRST._.FID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_MAC_RESULT_FIRST> model)
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
        protected WhereClipBuilder ConditionBuilder(T_MAC_RESULT_FIRST model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.FID))
            {
                condition.And(T_MAC_RESULT_FIRST._.FID.Contain(model.FID));
            }
            if (!string.IsNullOrWhiteSpace(model.CPU_ID))
            {
                condition.And(T_MAC_RESULT_FIRST._.CPU_ID.Contain(model.CPU_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.HDISK))
            {
                condition.And(T_MAC_RESULT_FIRST._.HDISK.Contain(model.HDISK));
            }
            if (!string.IsNullOrWhiteSpace(model.MAC))
            {
                condition.And(T_MAC_RESULT_FIRST._.MAC.Contain(model.MAC));
            }
            if (model.PCOUNT != null)
            {
                condition.And(T_MAC_RESULT_FIRST._.PCOUNT == (model.PCOUNT));
            }
            if (model.LASTTIME != null)
            {
                condition.And(T_MAC_RESULT_FIRST._.LASTTIME == (model.LASTTIME));
            }
            if (model.UPDATETIME != null)
            {
                condition.And(T_MAC_RESULT_FIRST._.UPDATETIME == (model.UPDATETIME));
            }
            return condition;
        }
        #endregion
    }
}