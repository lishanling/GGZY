using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TUploadService : BaseServiceT<T_UPLOAD>
    {
        #region 接口实现
        
		public List<T_UPLOAD> FindList(T_UPLOAD model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_UPLOAD> PageList(T_UPLOAD model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_UPLOAD._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_UPLOAD._.ID == ID);
			
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
        public GeneralResult Edit(T_UPLOAD model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_UPLOAD entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.TB_NAME=model.TB_NAME;
		entity.SEND_DATE=model.SEND_DATE;
		entity.SEND_CONTENT=model.SEND_CONTENT;
		entity.RES_CONTENT=model.RES_CONTENT;
		entity.IS_FILE=model.IS_FILE;
		entity.FILE_IS_UPLOAD=model.FILE_IS_UPLOAD;
		entity.DATA_IS_UPLOAD=model.DATA_IS_UPLOAD;
		entity.IS_SENDED=model.IS_SENDED;
		entity.PRE_STATUS=model.PRE_STATUS;
		entity.NOW_STATUS=model.NOW_STATUS;
		entity.IS_HISTORY=model.IS_HISTORY;
		entity.ERROR_INFO=model.ERROR_INFO;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.UPDATE_TIME=model.UPDATE_TIME;
		entity.LAST_SEND_TIME=model.LAST_SEND_TIME;
		entity.CREATE_TIME=model.CREATE_TIME;
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
        public GeneralResult Add(T_UPLOAD model)
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
                    Delete(T_UPLOAD._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_UPLOAD> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_UPLOAD model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_UPLOAD._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(T_UPLOAD._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.TB_NAME))
				{
				  condition.And(T_UPLOAD._.TB_NAME.Contain(model.TB_NAME));
				}
				if(model.SEND_DATE!=null)
				{
				  condition.And(T_UPLOAD._.SEND_DATE==(model.SEND_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.SEND_CONTENT))
				{
				  condition.And(T_UPLOAD._.SEND_CONTENT.Contain(model.SEND_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.RES_CONTENT))
				{
				  condition.And(T_UPLOAD._.RES_CONTENT.Contain(model.RES_CONTENT));
				}
				if(model.IS_FILE!=null)
				{
				  condition.And(T_UPLOAD._.IS_FILE==(model.IS_FILE));
				}
				if(model.FILE_IS_UPLOAD!=null)
				{
				  condition.And(T_UPLOAD._.FILE_IS_UPLOAD==(model.FILE_IS_UPLOAD));
				}
				if(model.DATA_IS_UPLOAD!=null)
				{
				  condition.And(T_UPLOAD._.DATA_IS_UPLOAD==(model.DATA_IS_UPLOAD));
				}
				if(model.IS_SENDED!=null)
				{
				  condition.And(T_UPLOAD._.IS_SENDED==(model.IS_SENDED));
				}
				if(model.PRE_STATUS!=null)
				{
				  condition.And(T_UPLOAD._.PRE_STATUS==(model.PRE_STATUS));
				}
				if(model.NOW_STATUS!=null)
				{
				  condition.And(T_UPLOAD._.NOW_STATUS==(model.NOW_STATUS));
				}
				if(model.IS_HISTORY!=null)
				{
				  condition.And(T_UPLOAD._.IS_HISTORY==(model.IS_HISTORY));
				}
				if(!string.IsNullOrWhiteSpace(model.ERROR_INFO))
				{
				  condition.And(T_UPLOAD._.ERROR_INFO.Contain(model.ERROR_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(T_UPLOAD._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.UPDATE_TIME!=null)
				{
				  condition.And(T_UPLOAD._.UPDATE_TIME==(model.UPDATE_TIME));
				}
				if(model.LAST_SEND_TIME!=null)
				{
				  condition.And(T_UPLOAD._.LAST_SEND_TIME==(model.LAST_SEND_TIME));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_UPLOAD._.CREATE_TIME==(model.CREATE_TIME));
				}
		return condition;
	}
        #endregion
    }
}