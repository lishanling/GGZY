using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TAttachmentService : BaseServiceT<T_ATTACHMENT>
    {
        #region 接口实现
        
		public List<T_ATTACHMENT> FindList(T_ATTACHMENT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_ATTACHMENT> PageList(T_ATTACHMENT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_ATTACHMENT._.ID.Desc).ToBootstrapTableList(count);

            
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
			var condition=new WhereClipBuilder();
			condition.And(T_ATTACHMENT._.ID == ID);
			
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
        public GeneralResult Edit(T_ATTACHMENT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_ATTACHMENT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.SYSTEM_NO=model.SYSTEM_NO;
		entity.TB_NAME=model.TB_NAME;
		entity.ATTACHMENT_SET_CODE=model.ATTACHMENT_SET_CODE;
		entity.ATTACHMENT_COUNT=model.ATTACHMENT_COUNT;
		entity.ATTACHMENT_NAME=model.ATTACHMENT_NAME;
		entity.ATTACHMENT_TYPE=model.ATTACHMENT_TYPE;
		entity.ATTACHMENT_FILE_NAME=model.ATTACHMENT_FILE_NAME;
		entity.URL=model.URL;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.SAVE_FILE_NAME=model.SAVE_FILE_NAME;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.CREATE_BY=model.CREATE_BY;
		entity.TB_ID=model.TB_ID;
		entity.ORDER_BY=model.ORDER_BY;
		entity.REMARK=model.REMARK;
		entity.FILE_NAME=model.FILE_NAME;
		entity.GUID=model.GUID;
		entity.MD5=model.MD5;
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
        public GeneralResult Add(T_ATTACHMENT model)
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
                    Delete(T_ATTACHMENT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_ATTACHMENT> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_ATTACHMENT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_ATTACHMENT._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.SYSTEM_NO))
				{
				  condition.And(T_ATTACHMENT._.SYSTEM_NO.Contain(model.SYSTEM_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.TB_NAME))
				{
				  condition.And(T_ATTACHMENT._.TB_NAME.Contain(model.TB_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTACHMENT_SET_CODE))
				{
				  condition.And(T_ATTACHMENT._.ATTACHMENT_SET_CODE.Contain(model.ATTACHMENT_SET_CODE));
				}
				if(model.ATTACHMENT_COUNT!=null)
				{
				  condition.And(T_ATTACHMENT._.ATTACHMENT_COUNT==(model.ATTACHMENT_COUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTACHMENT_NAME))
				{
				  condition.And(T_ATTACHMENT._.ATTACHMENT_NAME.Contain(model.ATTACHMENT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTACHMENT_TYPE))
				{
				  condition.And(T_ATTACHMENT._.ATTACHMENT_TYPE.Contain(model.ATTACHMENT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTACHMENT_FILE_NAME))
				{
				  condition.And(T_ATTACHMENT._.ATTACHMENT_FILE_NAME.Contain(model.ATTACHMENT_FILE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(T_ATTACHMENT._.URL.Contain(model.URL));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_ATTACHMENT._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.SAVE_FILE_NAME))
				{
				  condition.And(T_ATTACHMENT._.SAVE_FILE_NAME.Contain(model.SAVE_FILE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(T_ATTACHMENT._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(T_ATTACHMENT._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.CREATE_BY))
				{
				  condition.And(T_ATTACHMENT._.CREATE_BY.Contain(model.CREATE_BY));
				}
				if(model.TB_ID!=null)
				{
				  condition.And(T_ATTACHMENT._.TB_ID==(model.TB_ID));
				}
				if(model.ORDER_BY!=null)
				{
				  condition.And(T_ATTACHMENT._.ORDER_BY==(model.ORDER_BY));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(T_ATTACHMENT._.REMARK.Contain(model.REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.FILE_NAME))
				{
				  condition.And(T_ATTACHMENT._.FILE_NAME.Contain(model.FILE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.GUID))
				{
				  condition.And(T_ATTACHMENT._.GUID.Contain(model.GUID));
				}
				if(!string.IsNullOrWhiteSpace(model.MD5))
				{
				  condition.And(T_ATTACHMENT._.MD5.Contain(model.MD5));
				}
		return condition;
	}
        #endregion
    }
}