using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TTjAlltbUploadService : BaseServiceT<T_TJ_ALLTB_UPLOAD>
    {
        #region 接口实现
        
		public List<T_TJ_ALLTB_UPLOAD> FindList(T_TJ_ALLTB_UPLOAD model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_TJ_ALLTB_UPLOAD> PageList(T_TJ_ALLTB_UPLOAD model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_TJ_ALLTB_UPLOAD._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			var condition=new WhereClipBuilder();
			condition.And(T_TJ_ALLTB_UPLOAD._.ID == ID);
			
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
        public GeneralResult Edit(T_TJ_ALLTB_UPLOAD model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_TJ_ALLTB_UPLOAD entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.M_KEY=model.M_KEY;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_TABLE=model.M_TABLE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.UPLOAD_ID=model.UPLOAD_ID;
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
        public GeneralResult Add(T_TJ_ALLTB_UPLOAD model)
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
                    Delete(T_TJ_ALLTB_UPLOAD._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_TJ_ALLTB_UPLOAD> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_TJ_ALLTB_UPLOAD model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_TJ_ALLTB_UPLOAD._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(T_TJ_ALLTB_UPLOAD._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(T_TJ_ALLTB_UPLOAD._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(T_TJ_ALLTB_UPLOAD._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(T_TJ_ALLTB_UPLOAD._.M_KEY.Contain(model.M_KEY));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(T_TJ_ALLTB_UPLOAD._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_TABLE))
				{
				  condition.And(T_TJ_ALLTB_UPLOAD._.M_TABLE.Contain(model.M_TABLE));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(T_TJ_ALLTB_UPLOAD._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.UPLOAD_ID!=null)
				{
				  condition.And(T_TJ_ALLTB_UPLOAD._.UPLOAD_ID==(model.UPLOAD_ID));
				}
		return condition;
	}
        #endregion
    }
}