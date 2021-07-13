using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class RecordAttachmentService : BaseServiceT<RECORD_ATTACHMENT>
    {
        #region 接口实现

        public List<RECORD_ATTACHMENT> FindList(RECORD_ATTACHMENT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<RECORD_ATTACHMENT> PageList(RECORD_ATTACHMENT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            var pageList = PageList(condition, search, RECORD_ATTACHMENT._.ID.Desc).ToBootstrapTableList(count);


            return pageList;
        }


        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID">附件ID</param>
        /// <returns></returns>
        public GeneralResult ViewByPk(decimal? ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(RECORD_ATTACHMENT._.ID == ID);

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
        public GeneralResult Edit(RECORD_ATTACHMENT model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is RECORD_ATTACHMENT entity)
                {
                    entity.Attach();
                    entity.ID = model.ID;
                    entity.RECORD_ID = model.RECORD_ID;
                    entity.ATTFILE_TYPECODE = model.ATTFILE_TYPECODE;
                    entity.GUIDS = model.GUIDS;
                    entity.DESCRIPTION = model.DESCRIPTION;
                    entity.IS_INTACT = model.IS_INTACT;
                    entity.MATERIAL_OPINION = model.MATERIAL_OPINION;
                    entity.REMARK = model.REMARK;
                    entity.IS_READ_ONLY = model.IS_READ_ONLY;
                    entity.ATTFILE_TYPENAME = model.ATTFILE_TYPENAME;
                    entity.BID_SECTION_CODE = model.BID_SECTION_CODE;
                    entity.CATEGORY = model.CATEGORY;
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
        public GeneralResult Add(RECORD_ATTACHMENT model)
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
                    Delete(RECORD_ATTACHMENT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<RECORD_ATTACHMENT> model)
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
        protected WhereClipBuilder ConditionBuilder(RECORD_ATTACHMENT model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (model.ID != null)
            {
                condition.And(RECORD_ATTACHMENT._.ID == (model.ID));
            }
            if (model.RECORD_ID != null)
            {
                condition.And(RECORD_ATTACHMENT._.RECORD_ID == (model.RECORD_ID));
            }
            if (!string.IsNullOrWhiteSpace(model.ATTFILE_TYPECODE))
            {
                condition.And(RECORD_ATTACHMENT._.ATTFILE_TYPECODE.Contain(model.ATTFILE_TYPECODE));
            }
            if (!string.IsNullOrWhiteSpace(model.GUIDS))
            {
                condition.And(RECORD_ATTACHMENT._.GUIDS.Contain(model.GUIDS));
            }
            if (!string.IsNullOrWhiteSpace(model.DESCRIPTION))
            {
                condition.And(RECORD_ATTACHMENT._.DESCRIPTION.Contain(model.DESCRIPTION));
            }
            if (!string.IsNullOrWhiteSpace(model.IS_INTACT))
            {
                condition.And(RECORD_ATTACHMENT._.IS_INTACT.Contain(model.IS_INTACT));
            }
            if (!string.IsNullOrWhiteSpace(model.MATERIAL_OPINION))
            {
                condition.And(RECORD_ATTACHMENT._.MATERIAL_OPINION.Contain(model.MATERIAL_OPINION));
            }
            if (!string.IsNullOrWhiteSpace(model.REMARK))
            {
                condition.And(RECORD_ATTACHMENT._.REMARK.Contain(model.REMARK));
            }
            if (model.IS_READ_ONLY != null)
            {
                condition.And(RECORD_ATTACHMENT._.IS_READ_ONLY == (model.IS_READ_ONLY));
            }
            if (!string.IsNullOrWhiteSpace(model.ATTFILE_TYPENAME))
            {
                condition.And(RECORD_ATTACHMENT._.ATTFILE_TYPENAME.Contain(model.ATTFILE_TYPENAME));
            }
            if (!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
            {
                condition.And(RECORD_ATTACHMENT._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
            }
            if (model.CATEGORY != null)
            {
                condition.And(RECORD_ATTACHMENT._.CATEGORY == (model.CATEGORY));
            }
            return condition;
        }
        #endregion
    }
}