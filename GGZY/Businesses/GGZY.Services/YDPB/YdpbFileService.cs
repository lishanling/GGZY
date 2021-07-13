using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class YdpbFileService : BaseServiceT<YDPB_FILE>
    {
        #region 接口实现

        public List<YDPB_FILE> FindList(YDPB_FILE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<YDPB_FILE> PageList(YDPB_FILE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, YDPB_FILE._.FILE_ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="FILE_ID">主键</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(decimal? FILE_ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(YDPB_FILE._.FILE_ID == FILE_ID);

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
        public GeneralResult Edit(YDPB_FILE model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.FILE_ID);

                if (viewResult.Success && viewResult.Data is YDPB_FILE entity)
                {
                    entity.Attach();
                    entity.FILE_ID = model.FILE_ID;
                    entity.FID = model.FID;
                    entity.F_TABLE = model.F_TABLE;
                    entity.ID = model.ID;
                    entity.CATEGORY = model.CATEGORY;
                    entity.NAME = model.NAME;
                    entity.URL = model.URL;
                    entity.MD5 = model.MD5;
                    entity.CREATOR_ID = model.CREATOR_ID;
                    entity.CREATOR = model.CREATOR;
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
        public GeneralResult Add(YDPB_FILE model)
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
                    Delete(YDPB_FILE._.FILE_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<YDPB_FILE> model)
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
        protected WhereClipBuilder ConditionBuilder(YDPB_FILE model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.FILE_ID != null)
            {
                condition.And(YDPB_FILE._.FILE_ID == (model.FILE_ID));
            }
            if (model.FID != null)
            {
                condition.And(YDPB_FILE._.FID == (model.FID));
            }
            if (!string.IsNullOrWhiteSpace(model.F_TABLE))
            {
                condition.And(YDPB_FILE._.F_TABLE.Contain(model.F_TABLE));
            }
            if (!string.IsNullOrWhiteSpace(model.ID))
            {
                condition.And(YDPB_FILE._.ID.Contain(model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.CATEGORY))
            {
                condition.And(YDPB_FILE._.CATEGORY.Contain(model.CATEGORY));
            }
            if (!string.IsNullOrWhiteSpace(model.NAME))
            {
                condition.And(YDPB_FILE._.NAME.Contain(model.NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.URL))
            {
                condition.And(YDPB_FILE._.URL.Contain(model.URL));
            }
            if (!string.IsNullOrWhiteSpace(model.MD5))
            {
                condition.And(YDPB_FILE._.MD5.Contain(model.MD5));
            }
            if (model.CREATOR_ID != null)
            {
                condition.And(YDPB_FILE._.CREATOR_ID == (model.CREATOR_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.CREATOR))
            {
                condition.And(YDPB_FILE._.CREATOR.Contain(model.CREATOR));
            }
            if (model.CREATE_TIME != null)
            {
                condition.And(YDPB_FILE._.CREATE_TIME == (model.CREATE_TIME));
            }
            if (model.DATA_TIMESTAMP != null)
            {
                condition.And(YDPB_FILE._.DATA_TIMESTAMP == (model.DATA_TIMESTAMP));
            }
            if (model.IS_DELETE != null)
            {
                condition.And(YDPB_FILE._.IS_DELETE == (model.IS_DELETE));
            }
            return condition;
        }
        #endregion
    }
}