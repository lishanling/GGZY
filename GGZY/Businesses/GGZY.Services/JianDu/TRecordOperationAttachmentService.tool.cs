using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TRecordOperationAttachmentService : BaseServiceT<T_RECORD_OPERATION_ATTACHMENT>
    {
        #region 接口实现
        
		public List<T_RECORD_OPERATION_ATTACHMENT> FindList(T_RECORD_OPERATION_ATTACHMENT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_RECORD_OPERATION_ATTACHMENT> PageList(T_RECORD_OPERATION_ATTACHMENT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_RECORD_OPERATION_ATTACHMENT._.ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID">附件表id</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_RECORD_OPERATION_ATTACHMENT._.ID == ID);
			
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
        public GeneralResult Edit(T_RECORD_OPERATION_ATTACHMENT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_RECORD_OPERATION_ATTACHMENT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.GUIDS=model.GUIDS;
		entity.RECORD_ID=model.RECORD_ID;
		entity.REMARK=model.REMARK;
		entity.ATTFILE_TYPECODE=model.ATTFILE_TYPECODE;
		entity.ATTFILE_TYPENAME=model.ATTFILE_TYPENAME;
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
        public GeneralResult Add(T_RECORD_OPERATION_ATTACHMENT model)
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
                List<string>idArr=new List<string>();
                foreach (var id in ids)
                {
                    idArr.AddRange(id.Split(','));
                }
				
                if (idArr.Any())
                {
                    Delete(T_RECORD_OPERATION_ATTACHMENT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_RECORD_OPERATION_ATTACHMENT> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_RECORD_OPERATION_ATTACHMENT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_RECORD_OPERATION_ATTACHMENT._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.GUIDS))
				{
				  condition.And(T_RECORD_OPERATION_ATTACHMENT._.GUIDS.Contain(model.GUIDS));
				}
				if(model.RECORD_ID!=null)
				{
				  condition.And(T_RECORD_OPERATION_ATTACHMENT._.RECORD_ID==(model.RECORD_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(T_RECORD_OPERATION_ATTACHMENT._.REMARK.Contain(model.REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTFILE_TYPECODE))
				{
				  condition.And(T_RECORD_OPERATION_ATTACHMENT._.ATTFILE_TYPECODE.Contain(model.ATTFILE_TYPECODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTFILE_TYPENAME))
				{
				  condition.And(T_RECORD_OPERATION_ATTACHMENT._.ATTFILE_TYPENAME.Contain(model.ATTFILE_TYPENAME));
				}
		return condition;
	}
        #endregion
    }
}