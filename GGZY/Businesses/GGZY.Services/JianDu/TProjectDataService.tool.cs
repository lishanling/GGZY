using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TProjectDataService : BaseServiceT<T_PROJECT_DATA>
    {
        #region 接口实现
        
		public List<T_PROJECT_DATA> FindList(T_PROJECT_DATA model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_PROJECT_DATA> PageList(T_PROJECT_DATA model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_PROJECT_DATA._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_PROJECT_DATA._.ID == ID);
			
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
        public GeneralResult Edit(T_PROJECT_DATA model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_PROJECT_DATA entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.BUSINESSID=model.BUSINESSID;
		entity.TP_CODE=model.TP_CODE;
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.PROJECT_NAME=model.PROJECT_NAME;
		entity.PROJECT_TYPE=model.PROJECT_TYPE;
		entity.REGION_CODE=model.REGION_CODE;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.PLATFORM_NAME=model.PLATFORM_NAME;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.OWNER_NAME=model.OWNER_NAME;
		entity.AGENCY_NAME=model.AGENCY_NAME;
		entity.AGENCY_CODE=model.AGENCY_CODE;
		entity.SUPERVISE_DEPT_NAME=model.SUPERVISE_DEPT_NAME;
		entity.SUPERVISE_DEPT_CODE=model.SUPERVISE_DEPT_CODE;
		entity.IS_FINISH=model.IS_FINISH;
		entity.BROWSE_NUM=model.BROWSE_NUM;
		entity.T_TM=model.T_TM;
		entity.PROJECT_CATEGORY=model.PROJECT_CATEGORY;
		entity.IN_NODE=model.IN_NODE;
		entity.START_TM=model.START_TM;
		entity.ERROR_NODES=model.ERROR_NODES;
		entity.TYPE=model.TYPE;
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
        public GeneralResult Add(T_PROJECT_DATA model)
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
                    Delete(T_PROJECT_DATA._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_PROJECT_DATA> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_PROJECT_DATA model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_PROJECT_DATA._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.BUSINESSID))
				{
				  condition.And(T_PROJECT_DATA._.BUSINESSID.Contain(model.BUSINESSID));
				}
				if(!string.IsNullOrWhiteSpace(model.TP_CODE))
				{
				  condition.And(T_PROJECT_DATA._.TP_CODE.Contain(model.TP_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(T_PROJECT_DATA._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
				{
				  condition.And(T_PROJECT_DATA._.PROJECT_NAME.Contain(model.PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
				{
				  condition.And(T_PROJECT_DATA._.PROJECT_TYPE.Contain(model.PROJECT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(T_PROJECT_DATA._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_PROJECT_DATA._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_NAME))
				{
				  condition.And(T_PROJECT_DATA._.PLATFORM_NAME.Contain(model.PLATFORM_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(T_PROJECT_DATA._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.OWNER_NAME))
				{
				  condition.And(T_PROJECT_DATA._.OWNER_NAME.Contain(model.OWNER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.AGENCY_NAME))
				{
				  condition.And(T_PROJECT_DATA._.AGENCY_NAME.Contain(model.AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.AGENCY_CODE))
				{
				  condition.And(T_PROJECT_DATA._.AGENCY_CODE.Contain(model.AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME))
				{
				  condition.And(T_PROJECT_DATA._.SUPERVISE_DEPT_NAME.Contain(model.SUPERVISE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_CODE))
				{
				  condition.And(T_PROJECT_DATA._.SUPERVISE_DEPT_CODE.Contain(model.SUPERVISE_DEPT_CODE));
				}
				if(model.IS_FINISH!=null)
				{
				  condition.And(T_PROJECT_DATA._.IS_FINISH==(model.IS_FINISH));
				}
				if(model.BROWSE_NUM!=null)
				{
				  condition.And(T_PROJECT_DATA._.BROWSE_NUM==(model.BROWSE_NUM));
				}
				if(model.T_TM!=null)
				{
				  condition.And(T_PROJECT_DATA._.T_TM==(model.T_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CATEGORY))
				{
				  condition.And(T_PROJECT_DATA._.PROJECT_CATEGORY.Contain(model.PROJECT_CATEGORY));
				}
				if(!string.IsNullOrWhiteSpace(model.IN_NODE))
				{
				  condition.And(T_PROJECT_DATA._.IN_NODE.Contain(model.IN_NODE));
				}
				if(model.START_TM!=null)
				{
				  condition.And(T_PROJECT_DATA._.START_TM==(model.START_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.ERROR_NODES))
				{
				  condition.And(T_PROJECT_DATA._.ERROR_NODES.Contain(model.ERROR_NODES));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPE))
				{
				  condition.And(T_PROJECT_DATA._.TYPE.Contain(model.TYPE));
				}
		return condition;
	}
        #endregion
    }
}