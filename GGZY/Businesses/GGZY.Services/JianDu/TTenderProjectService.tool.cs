using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TTenderProjectService : BaseServiceT<T_TENDER_PROJECT>
    {
        #region 接口实现
        
		public List<T_TENDER_PROJECT> FindList(T_TENDER_PROJECT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_TENDER_PROJECT> PageList(T_TENDER_PROJECT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_TENDER_PROJECT._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_TENDER_PROJECT._.ID == ID);
			
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
        public GeneralResult Edit(T_TENDER_PROJECT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_TENDER_PROJECT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.TENDER_PROJECT_NAME=model.TENDER_PROJECT_NAME;
		entity.TENDER_PROJECT_TYPE=model.TENDER_PROJECT_TYPE;
		entity.REGION_CODE=model.REGION_CODE;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.ISCREATE=model.ISCREATE;
		entity.T_TM=model.T_TM;
		entity.OWNER_NAME=model.OWNER_NAME;
		entity.SUPERVISE_DEPT_NAME=model.SUPERVISE_DEPT_NAME;
		entity.SUPERVISE_DEPT_CODE=model.SUPERVISE_DEPT_CODE;
		entity.PLATFORM_NAME=model.PLATFORM_NAME;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.BROWSE_NUM=model.BROWSE_NUM;
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
        public GeneralResult Add(T_TENDER_PROJECT model)
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
                    Delete(T_TENDER_PROJECT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_TENDER_PROJECT> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_TENDER_PROJECT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_TENDER_PROJECT._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(T_TENDER_PROJECT._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(T_TENDER_PROJECT._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(T_TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
				{
				  condition.And(T_TENDER_PROJECT._.TENDER_PROJECT_TYPE.Contain(model.TENDER_PROJECT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(T_TENDER_PROJECT._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_TENDER_PROJECT._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(model.ISCREATE!=null)
				{
				  condition.And(T_TENDER_PROJECT._.ISCREATE==(model.ISCREATE));
				}
				if(model.T_TM!=null)
				{
				  condition.And(T_TENDER_PROJECT._.T_TM==(model.T_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.OWNER_NAME))
				{
				  condition.And(T_TENDER_PROJECT._.OWNER_NAME.Contain(model.OWNER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME))
				{
				  condition.And(T_TENDER_PROJECT._.SUPERVISE_DEPT_NAME.Contain(model.SUPERVISE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_CODE))
				{
				  condition.And(T_TENDER_PROJECT._.SUPERVISE_DEPT_CODE.Contain(model.SUPERVISE_DEPT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_NAME))
				{
				  condition.And(T_TENDER_PROJECT._.PLATFORM_NAME.Contain(model.PLATFORM_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(T_TENDER_PROJECT._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(model.BROWSE_NUM!=null)
				{
				  condition.And(T_TENDER_PROJECT._.BROWSE_NUM==(model.BROWSE_NUM));
				}
		return condition;
	}
        #endregion
    }
}