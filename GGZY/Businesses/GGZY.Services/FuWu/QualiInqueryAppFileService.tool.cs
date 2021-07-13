﻿using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class QualiInqueryAppFileService : BaseServiceT<QUALI_INQUERY_APP_FILE>
    {
        #region 接口实现
        
		public List<QUALI_INQUERY_APP_FILE> FindList(QUALI_INQUERY_APP_FILE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<QUALI_INQUERY_APP_FILE> PageList(QUALI_INQUERY_APP_FILE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, QUALI_INQUERY_APP_FILE._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(QUALI_INQUERY_APP_FILE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(QUALI_INQUERY_APP_FILE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is QUALI_INQUERY_APP_FILE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.UNIFIED_DEAL_CODES=model.UNIFIED_DEAL_CODES;
		entity.APPLICANTION_NAME=model.APPLICANTION_NAME;
		entity.APPLICANTION_CODE=model.APPLICANTION_CODE;
		entity.QUALIFICATION_ELEMENT=model.QUALIFICATION_ELEMENT;
		entity.BID_MANAGER=model.BID_MANAGER;
		entity.APPLY_SUBMIT_TIME=model.APPLY_SUBMIT_TIME;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_CREATOR=model.M_CREATOR;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.IS_POSTPONE=model.IS_POSTPONE;
		entity.POST_OPEN_TIME=model.POST_OPEN_TIME;
		entity.POST_OPEN_ADDRESS=model.POST_OPEN_ADDRESS;
		entity.BID_OPEN_METHOD=model.BID_OPEN_METHOD;
		entity.QUAL_TYPE=model.QUAL_TYPE;
		entity.TENDER_CLARIFY_CONTENT=model.TENDER_CLARIFY_CONTENT;
		entity.TENDER_SUBMIT_TIME=model.TENDER_SUBMIT_TIME;
		entity.TRADE_PLAT=model.TRADE_PLAT;
		entity.PUB_SERVICE_PLAT=model.PUB_SERVICE_PLAT;
		entity.M_VERSION=model.M_VERSION;
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
        public GeneralResult Add(QUALI_INQUERY_APP_FILE model)
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
                    Delete(QUALI_INQUERY_APP_FILE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<QUALI_INQUERY_APP_FILE> model)
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
       	protected WhereClipBuilder ConditionBuilder(QUALI_INQUERY_APP_FILE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODES))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.UNIFIED_DEAL_CODES.Contain(model.UNIFIED_DEAL_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.APPLICANTION_NAME))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.APPLICANTION_NAME.Contain(model.APPLICANTION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.APPLICANTION_CODE))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.APPLICANTION_CODE.Contain(model.APPLICANTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALIFICATION_ELEMENT))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.QUALIFICATION_ELEMENT.Contain(model.QUALIFICATION_ELEMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_MANAGER))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.BID_MANAGER.Contain(model.BID_MANAGER));
				}
				if(model.APPLY_SUBMIT_TIME!=null)
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.APPLY_SUBMIT_TIME==(model.APPLY_SUBMIT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.M_ID==(model.M_ID));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_POSTPONE))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.IS_POSTPONE.Contain(model.IS_POSTPONE));
				}
				if(model.POST_OPEN_TIME!=null)
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.POST_OPEN_TIME==(model.POST_OPEN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.POST_OPEN_ADDRESS))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.POST_OPEN_ADDRESS.Contain(model.POST_OPEN_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_OPEN_METHOD))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.BID_OPEN_METHOD.Contain(model.BID_OPEN_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.QUAL_TYPE))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.QUAL_TYPE.Contain(model.QUAL_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_CLARIFY_CONTENT))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.TENDER_CLARIFY_CONTENT.Contain(model.TENDER_CLARIFY_CONTENT));
				}
				if(model.TENDER_SUBMIT_TIME!=null)
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.TENDER_SUBMIT_TIME==(model.TENDER_SUBMIT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(QUALI_INQUERY_APP_FILE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}