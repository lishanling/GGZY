﻿using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TTpTacheService : BaseServiceT<T_TP_TACHE>
    {
        #region 接口实现
        
		public List<T_TP_TACHE> FindList(T_TP_TACHE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_TP_TACHE> PageList(T_TP_TACHE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_TP_TACHE._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_TP_TACHE._.ID == ID);
			
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
        public GeneralResult Edit(T_TP_TACHE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_TP_TACHE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.NAME=model.NAME;
		entity.CODE=model.CODE;
		entity.TP_CODE=model.TP_CODE;
		entity.REMARK=model.REMARK;
		entity.ORDER_ID=model.ORDER_ID;
		entity.CREATE_TM=model.CREATE_TM;
		entity.CPN_CODE=model.CPN_CODE;
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
        public GeneralResult Add(T_TP_TACHE model)
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
                    Delete(T_TP_TACHE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_TP_TACHE> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_TP_TACHE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_TP_TACHE._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(T_TP_TACHE._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(T_TP_TACHE._.CODE.Contain(model.CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TP_CODE))
				{
				  condition.And(T_TP_TACHE._.TP_CODE.Contain(model.TP_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(T_TP_TACHE._.REMARK.Contain(model.REMARK));
				}
				if(model.ORDER_ID!=null)
				{
				  condition.And(T_TP_TACHE._.ORDER_ID==(model.ORDER_ID));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(T_TP_TACHE._.CREATE_TM==(model.CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.CPN_CODE))
				{
				  condition.And(T_TP_TACHE._.CPN_CODE.Contain(model.CPN_CODE));
				}
		return condition;
	}
        #endregion
    }
}