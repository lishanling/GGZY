using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TTimelinessCountService : BaseServiceT<T_TIMELINESS_COUNT>
    {
        #region 接口实现
        
		public List<T_TIMELINESS_COUNT> FindList(T_TIMELINESS_COUNT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_TIMELINESS_COUNT> PageList(T_TIMELINESS_COUNT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_TIMELINESS_COUNT._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_TIMELINESS_COUNT._.ID == ID);
			
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
        public GeneralResult Edit(T_TIMELINESS_COUNT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_TIMELINESS_COUNT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.COUNT_TIME=model.COUNT_TIME;
		entity.INSERT_TIME=model.INSERT_TIME;
		entity.BEFORE_SEVEN=model.BEFORE_SEVEN;
		entity.BEFORE_FOUR=model.BEFORE_FOUR;
		entity.BEFORE_THREE=model.BEFORE_THREE;
		entity.TODAY_COUNT=model.TODAY_COUNT;
		entity.AFTER_THREE=model.AFTER_THREE;
		entity.AFTER_FOUR=model.AFTER_FOUR;
		entity.AFTER_SEVEN=model.AFTER_SEVEN;
		entity.M_MODULE=model.M_MODULE;
		entity.M_TABLE_CN_NAME=model.M_TABLE_CN_NAME;
		entity.M_TABLE_EN_NAME=model.M_TABLE_EN_NAME;
		entity.SYS_CODE=model.SYS_CODE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
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
        public GeneralResult Add(T_TIMELINESS_COUNT model)
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
                    Delete(T_TIMELINESS_COUNT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_TIMELINESS_COUNT> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_TIMELINESS_COUNT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_TIMELINESS_COUNT._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(T_TIMELINESS_COUNT._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.COUNT_TIME!=null)
				{
				  condition.And(T_TIMELINESS_COUNT._.COUNT_TIME==(model.COUNT_TIME));
				}
				if(model.INSERT_TIME!=null)
				{
				  condition.And(T_TIMELINESS_COUNT._.INSERT_TIME==(model.INSERT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BEFORE_SEVEN))
				{
				  condition.And(T_TIMELINESS_COUNT._.BEFORE_SEVEN.Contain(model.BEFORE_SEVEN));
				}
				if(!string.IsNullOrWhiteSpace(model.BEFORE_FOUR))
				{
				  condition.And(T_TIMELINESS_COUNT._.BEFORE_FOUR.Contain(model.BEFORE_FOUR));
				}
				if(!string.IsNullOrWhiteSpace(model.BEFORE_THREE))
				{
				  condition.And(T_TIMELINESS_COUNT._.BEFORE_THREE.Contain(model.BEFORE_THREE));
				}
				if(!string.IsNullOrWhiteSpace(model.TODAY_COUNT))
				{
				  condition.And(T_TIMELINESS_COUNT._.TODAY_COUNT.Contain(model.TODAY_COUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.AFTER_THREE))
				{
				  condition.And(T_TIMELINESS_COUNT._.AFTER_THREE.Contain(model.AFTER_THREE));
				}
				if(!string.IsNullOrWhiteSpace(model.AFTER_FOUR))
				{
				  condition.And(T_TIMELINESS_COUNT._.AFTER_FOUR.Contain(model.AFTER_FOUR));
				}
				if(!string.IsNullOrWhiteSpace(model.AFTER_SEVEN))
				{
				  condition.And(T_TIMELINESS_COUNT._.AFTER_SEVEN.Contain(model.AFTER_SEVEN));
				}
				if(!string.IsNullOrWhiteSpace(model.M_MODULE))
				{
				  condition.And(T_TIMELINESS_COUNT._.M_MODULE.Contain(model.M_MODULE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_TABLE_CN_NAME))
				{
				  condition.And(T_TIMELINESS_COUNT._.M_TABLE_CN_NAME.Contain(model.M_TABLE_CN_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.M_TABLE_EN_NAME))
				{
				  condition.And(T_TIMELINESS_COUNT._.M_TABLE_EN_NAME.Contain(model.M_TABLE_EN_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SYS_CODE))
				{
				  condition.And(T_TIMELINESS_COUNT._.SYS_CODE.Contain(model.SYS_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(T_TIMELINESS_COUNT._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
		return condition;
	}
        #endregion
    }
}