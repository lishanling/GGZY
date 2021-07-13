﻿using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TTransLogService : BaseServiceT<T_TRANS_LOG>
    {
        #region 接口实现
        
		public List<T_TRANS_LOG> FindList(T_TRANS_LOG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_TRANS_LOG> PageList(T_TRANS_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_TRANS_LOG._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_TRANS_LOG._.ID == ID);
			
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
        public GeneralResult Edit(T_TRANS_LOG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_TRANS_LOG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.TBNAME=model.TBNAME;
		entity.CREATETIME=model.CREATETIME;
		entity.ADDTIME=model.ADDTIME;
		entity.UPDATETIME=model.UPDATETIME;
		entity.DELETETIME=model.DELETETIME;
		entity.PREPAREDELETE=model.PREPAREDELETE;
		entity.TYPE=model.TYPE;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
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
        public GeneralResult Add(T_TRANS_LOG model)
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
                    Delete(T_TRANS_LOG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_TRANS_LOG> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_TRANS_LOG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_TRANS_LOG._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(T_TRANS_LOG._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(T_TRANS_LOG._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.TBNAME))
				{
				  condition.And(T_TRANS_LOG._.TBNAME.Contain(model.TBNAME));
				}
				if(model.CREATETIME!=null)
				{
				  condition.And(T_TRANS_LOG._.CREATETIME==(model.CREATETIME));
				}
				if(model.ADDTIME!=null)
				{
				  condition.And(T_TRANS_LOG._.ADDTIME==(model.ADDTIME));
				}
				if(model.UPDATETIME!=null)
				{
				  condition.And(T_TRANS_LOG._.UPDATETIME==(model.UPDATETIME));
				}
				if(model.DELETETIME!=null)
				{
				  condition.And(T_TRANS_LOG._.DELETETIME==(model.DELETETIME));
				}
				if(model.PREPAREDELETE!=null)
				{
				  condition.And(T_TRANS_LOG._.PREPAREDELETE==(model.PREPAREDELETE));
				}
				if(model.TYPE!=null)
				{
				  condition.And(T_TRANS_LOG._.TYPE==(model.TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(T_TRANS_LOG._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
		return condition;
	}
        #endregion
    }
}