using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TUploadErrorService : BaseServiceT<T_UPLOAD_ERROR>
    {
        #region 接口实现
        
		public List<T_UPLOAD_ERROR> FindList(T_UPLOAD_ERROR model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_UPLOAD_ERROR> PageList(T_UPLOAD_ERROR model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_UPLOAD_ERROR._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_UPLOAD_ERROR._.ID == ID);
			
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
        public GeneralResult Edit(T_UPLOAD_ERROR model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_UPLOAD_ERROR entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.SYS_CODE=model.SYS_CODE;
		entity.DATA_KEY=model.DATA_KEY;
		entity.TB_NAME=model.TB_NAME;
		entity.CHECK_ONE=model.CHECK_ONE;
		entity.CHECK_TWO=model.CHECK_TWO;
		entity.CHECK_ALL=model.CHECK_ALL;
		entity.SAVE_TIME=model.SAVE_TIME;
		entity.REMARK=model.REMARK;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.IS_HISTORY=model.IS_HISTORY;
		entity.START_TIME=model.START_TIME;
		entity.END_TIME=model.END_TIME;
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
        public GeneralResult Add(T_UPLOAD_ERROR model)
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
                    Delete(T_UPLOAD_ERROR._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_UPLOAD_ERROR> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_UPLOAD_ERROR model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_UPLOAD_ERROR._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.SYS_CODE))
				{
				  condition.And(T_UPLOAD_ERROR._.SYS_CODE.Contain(model.SYS_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(T_UPLOAD_ERROR._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.TB_NAME))
				{
				  condition.And(T_UPLOAD_ERROR._.TB_NAME.Contain(model.TB_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CHECK_ONE))
				{
				  condition.And(T_UPLOAD_ERROR._.CHECK_ONE.Contain(model.CHECK_ONE));
				}
				if(!string.IsNullOrWhiteSpace(model.CHECK_TWO))
				{
				  condition.And(T_UPLOAD_ERROR._.CHECK_TWO.Contain(model.CHECK_TWO));
				}
				if(!string.IsNullOrWhiteSpace(model.CHECK_ALL))
				{
				  condition.And(T_UPLOAD_ERROR._.CHECK_ALL.Contain(model.CHECK_ALL));
				}
				if(model.SAVE_TIME!=null)
				{
				  condition.And(T_UPLOAD_ERROR._.SAVE_TIME==(model.SAVE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(T_UPLOAD_ERROR._.REMARK.Contain(model.REMARK));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_UPLOAD_ERROR._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(model.IS_HISTORY!=null)
				{
				  condition.And(T_UPLOAD_ERROR._.IS_HISTORY==(model.IS_HISTORY));
				}
				if(model.START_TIME!=null)
				{
				  condition.And(T_UPLOAD_ERROR._.START_TIME==(model.START_TIME));
				}
				if(model.END_TIME!=null)
				{
				  condition.And(T_UPLOAD_ERROR._.END_TIME==(model.END_TIME));
				}
		return condition;
	}
        #endregion
    }
}