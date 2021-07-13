using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TUploadOkLogService : BaseServiceT<T_UPLOAD_OK_LOG>
    {
        #region 接口实现
        
		public List<T_UPLOAD_OK_LOG> FindList(T_UPLOAD_OK_LOG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_UPLOAD_OK_LOG> PageList(T_UPLOAD_OK_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_UPLOAD_OK_LOG._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_UPLOAD_OK_LOG._.ID == ID);
			
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
        public GeneralResult Edit(T_UPLOAD_OK_LOG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_UPLOAD_OK_LOG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.TB_NAME=model.TB_NAME;
		entity.DATA_PATH=model.DATA_PATH;
		entity.IS_FILE=model.IS_FILE;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.UPLOAD_STATUS=model.UPLOAD_STATUS;
		entity.UPLOAD_TIME=model.UPLOAD_TIME;
		entity.IS_DATA_UPLOAD=model.IS_DATA_UPLOAD;
		entity.IS_FILE_UPLOAD=model.IS_FILE_UPLOAD;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.SEND_RES=model.SEND_RES;
		entity.TYPE=model.TYPE;
		entity.TB_MID=model.TB_MID;
		entity.OPTYPE=model.OPTYPE;
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
        public GeneralResult Add(T_UPLOAD_OK_LOG model)
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
                    Delete(T_UPLOAD_OK_LOG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_UPLOAD_OK_LOG> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_UPLOAD_OK_LOG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_UPLOAD_OK_LOG._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(T_UPLOAD_OK_LOG._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.TB_NAME))
				{
				  condition.And(T_UPLOAD_OK_LOG._.TB_NAME.Contain(model.TB_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_PATH))
				{
				  condition.And(T_UPLOAD_OK_LOG._.DATA_PATH.Contain(model.DATA_PATH));
				}
				if(model.IS_FILE!=null)
				{
				  condition.And(T_UPLOAD_OK_LOG._.IS_FILE==(model.IS_FILE));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_UPLOAD_OK_LOG._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(model.UPLOAD_STATUS!=null)
				{
				  condition.And(T_UPLOAD_OK_LOG._.UPLOAD_STATUS==(model.UPLOAD_STATUS));
				}
				if(model.UPLOAD_TIME!=null)
				{
				  condition.And(T_UPLOAD_OK_LOG._.UPLOAD_TIME==(model.UPLOAD_TIME));
				}
				if(model.IS_DATA_UPLOAD!=null)
				{
				  condition.And(T_UPLOAD_OK_LOG._.IS_DATA_UPLOAD==(model.IS_DATA_UPLOAD));
				}
				if(model.IS_FILE_UPLOAD!=null)
				{
				  condition.And(T_UPLOAD_OK_LOG._.IS_FILE_UPLOAD==(model.IS_FILE_UPLOAD));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(T_UPLOAD_OK_LOG._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.SEND_RES))
				{
				  condition.And(T_UPLOAD_OK_LOG._.SEND_RES.Contain(model.SEND_RES));
				}
				if(model.TYPE!=null)
				{
				  condition.And(T_UPLOAD_OK_LOG._.TYPE==(model.TYPE));
				}
				if(model.TB_MID!=null)
				{
				  condition.And(T_UPLOAD_OK_LOG._.TB_MID==(model.TB_MID));
				}
				if(model.OPTYPE!=null)
				{
				  condition.And(T_UPLOAD_OK_LOG._.OPTYPE==(model.OPTYPE));
				}
		return condition;
	}
        #endregion
    }
}