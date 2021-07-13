using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TSsoAuthorizationService : BaseServiceT<T_SSO_AUTHORIZATION>
    {
        #region 接口实现
        
		public List<T_SSO_AUTHORIZATION> FindList(T_SSO_AUTHORIZATION model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_SSO_AUTHORIZATION> PageList(T_SSO_AUTHORIZATION model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_SSO_AUTHORIZATION._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_SSO_AUTHORIZATION._.ID == ID);
			
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
        public GeneralResult Edit(T_SSO_AUTHORIZATION model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_SSO_AUTHORIZATION entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.ACCESS_TOKEN=model.ACCESS_TOKEN;
		entity.CLIENT_ID=model.CLIENT_ID;
		entity.USER_ID=model.USER_ID;
		entity.SCOPE=model.SCOPE;
		entity.CREATE_TM=model.CREATE_TM;
		entity.EXPIRAT_TM=model.EXPIRAT_TM;
		entity.REMARK=model.REMARK;
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
        public GeneralResult Add(T_SSO_AUTHORIZATION model)
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
                    Delete(T_SSO_AUTHORIZATION._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_SSO_AUTHORIZATION> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_SSO_AUTHORIZATION model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_SSO_AUTHORIZATION._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.ACCESS_TOKEN))
				{
				  condition.And(T_SSO_AUTHORIZATION._.ACCESS_TOKEN.Contain(model.ACCESS_TOKEN));
				}
				if(!string.IsNullOrWhiteSpace(model.CLIENT_ID))
				{
				  condition.And(T_SSO_AUTHORIZATION._.CLIENT_ID.Contain(model.CLIENT_ID));
				}
				if(model.USER_ID!=null)
				{
				  condition.And(T_SSO_AUTHORIZATION._.USER_ID==(model.USER_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.SCOPE))
				{
				  condition.And(T_SSO_AUTHORIZATION._.SCOPE.Contain(model.SCOPE));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(T_SSO_AUTHORIZATION._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.EXPIRAT_TM!=null)
				{
				  condition.And(T_SSO_AUTHORIZATION._.EXPIRAT_TM==(model.EXPIRAT_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(T_SSO_AUTHORIZATION._.REMARK.Contain(model.REMARK));
				}
		return condition;
	}
        #endregion
    }
}