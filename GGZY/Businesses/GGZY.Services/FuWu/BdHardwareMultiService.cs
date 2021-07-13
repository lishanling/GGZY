using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.Violation
{
    public partial class BdHardwareMultiService : BaseServiceT<BD_HARDWARE_MULTI>
    {
        #region 接口实现

        public List<BD_HARDWARE_MULTI> FindList(BD_HARDWARE_MULTI model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BD_HARDWARE_MULTI> PageList(BD_HARDWARE_MULTI model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, BD_HARDWARE_MULTI._.ID.Desc).ToBootstrapTableList(count);


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
            condition.And(BD_HARDWARE_MULTI._.ID == ID);

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
        public GeneralResult Edit(BD_HARDWARE_MULTI model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is BD_HARDWARE_MULTI entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.CPU_ID = model.CPU_ID;
                    entity.MAC_ADDRESS = model.MAC_ADDRESS;
                    entity.HARD_DISK_SERIAL_NUMBER = model.HARD_DISK_SERIAL_NUMBER;
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
        public GeneralResult Add(BD_HARDWARE_MULTI model)
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
                    Delete(BD_HARDWARE_MULTI._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BD_HARDWARE_MULTI> model)
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
        protected WhereClipBuilder ConditionBuilder(BD_HARDWARE_MULTI model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(BD_HARDWARE_MULTI._.ID == (model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.CPU_ID))
            {
                condition.And(BD_HARDWARE_MULTI._.CPU_ID.Contain(model.CPU_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.MAC_ADDRESS))
            {
                condition.And(BD_HARDWARE_MULTI._.MAC_ADDRESS.Contain(model.MAC_ADDRESS));
            }
            if (!string.IsNullOrWhiteSpace(model.HARD_DISK_SERIAL_NUMBER))
            {
                condition.And(BD_HARDWARE_MULTI._.HARD_DISK_SERIAL_NUMBER.Contain(model.HARD_DISK_SERIAL_NUMBER));
            }
            return condition;
        }
        #endregion
    }
}