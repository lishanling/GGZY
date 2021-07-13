using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TAccessDataService : BaseServiceT<T_ACCESS_DATA>
    {
        #region 接口实现
        
		public List<T_ACCESS_DATA> FindList(T_ACCESS_DATA model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_ACCESS_DATA> PageList(T_ACCESS_DATA model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_ACCESS_DATA._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_ACCESS_DATA._.ID == ID);
			
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
        public GeneralResult Edit(T_ACCESS_DATA model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_ACCESS_DATA entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.PROJECT_ID=model.PROJECT_ID;
		entity.DEP_ID=model.DEP_ID;
		entity.USER_ID=model.USER_ID;
		entity.EXPIRE_TM=model.EXPIRE_TM;
		entity.CREATE_UID=model.CREATE_UID;
		entity.CREATE_TM=model.CREATE_TM;
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
        public GeneralResult Add(T_ACCESS_DATA model)
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
                    Delete(T_ACCESS_DATA._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_ACCESS_DATA> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_ACCESS_DATA model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_ACCESS_DATA._.ID==(model.ID));
				}
				if(model.PROJECT_ID!=null)
				{
				  condition.And(T_ACCESS_DATA._.PROJECT_ID==(model.PROJECT_ID));
				}
				if(model.DEP_ID!=null)
				{
				  condition.And(T_ACCESS_DATA._.DEP_ID==(model.DEP_ID));
				}
				if(model.USER_ID!=null)
				{
				  condition.And(T_ACCESS_DATA._.USER_ID==(model.USER_ID));
				}
				if(model.EXPIRE_TM!=null)
				{
				  condition.And(T_ACCESS_DATA._.EXPIRE_TM==(model.EXPIRE_TM));
				}
				if(model.CREATE_UID!=null)
				{
				  condition.And(T_ACCESS_DATA._.CREATE_UID==(model.CREATE_UID));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(T_ACCESS_DATA._.CREATE_TM==(model.CREATE_TM));
				}
		return condition;
	}
        #endregion
    }
}