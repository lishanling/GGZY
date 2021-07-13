﻿using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TSsoInfoService : BaseServiceT<T_SSO_INFO>
    {
        #region 接口实现
        
		public List<T_SSO_INFO> FindList(T_SSO_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_SSO_INFO> PageList(T_SSO_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_SSO_INFO._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_SSO_INFO._.ID == ID);
			
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
        public GeneralResult Edit(T_SSO_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_SSO_INFO entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.REDIRECT_URI=model.REDIRECT_URI;
		entity.LOGOUT_URL=model.LOGOUT_URL;
		entity.NAME=model.NAME;
		entity.CLIENT_ID=model.CLIENT_ID;
		entity.CLIENT_SECRET=model.CLIENT_SECRET;
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
        public GeneralResult Add(T_SSO_INFO model)
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
                    Delete(T_SSO_INFO._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_SSO_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_SSO_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_SSO_INFO._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.REDIRECT_URI))
				{
				  condition.And(T_SSO_INFO._.REDIRECT_URI.Contain(model.REDIRECT_URI));
				}
				if(!string.IsNullOrWhiteSpace(model.LOGOUT_URL))
				{
				  condition.And(T_SSO_INFO._.LOGOUT_URL.Contain(model.LOGOUT_URL));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(T_SSO_INFO._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CLIENT_ID))
				{
				  condition.And(T_SSO_INFO._.CLIENT_ID.Contain(model.CLIENT_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.CLIENT_SECRET))
				{
				  condition.And(T_SSO_INFO._.CLIENT_SECRET.Contain(model.CLIENT_SECRET));
				}
		return condition;
	}
        #endregion
    }
}