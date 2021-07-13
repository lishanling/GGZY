using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TRpDbconfigService : BaseServiceT<T_RP_DBCONFIG>
    {
        #region 接口实现
        
		public List<T_RP_DBCONFIG> FindList(T_RP_DBCONFIG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_RP_DBCONFIG> PageList(T_RP_DBCONFIG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_RP_DBCONFIG._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_RP_DBCONFIG._.ID == ID);
			
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
        public GeneralResult Edit(T_RP_DBCONFIG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_RP_DBCONFIG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.NAME=model.NAME;
		entity.DB_CODE=model.DB_CODE;
		entity.DB_CONFIG=model.DB_CONFIG;
		entity.DB_TYPE=model.DB_TYPE;
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
        public GeneralResult Add(T_RP_DBCONFIG model)
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
                    Delete(T_RP_DBCONFIG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_RP_DBCONFIG> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_RP_DBCONFIG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_RP_DBCONFIG._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(T_RP_DBCONFIG._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DB_CODE))
				{
				  condition.And(T_RP_DBCONFIG._.DB_CODE.Contain(model.DB_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.DB_CONFIG))
				{
				  condition.And(T_RP_DBCONFIG._.DB_CONFIG.Contain(model.DB_CONFIG));
				}
				if(!string.IsNullOrWhiteSpace(model.DB_TYPE))
				{
				  condition.And(T_RP_DBCONFIG._.DB_TYPE.Contain(model.DB_TYPE));
				}
		return condition;
	}
        #endregion
    }
}