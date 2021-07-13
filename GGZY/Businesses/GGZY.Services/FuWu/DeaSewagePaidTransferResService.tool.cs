﻿using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class DeaSewagePaidTransferResService : BaseServiceT<DEA_SEWAGE_PAID_TRANSFER_RES>
    {
        #region 接口实现
        
		public List<DEA_SEWAGE_PAID_TRANSFER_RES> FindList(DEA_SEWAGE_PAID_TRANSFER_RES model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<DEA_SEWAGE_PAID_TRANSFER_RES> PageList(DEA_SEWAGE_PAID_TRANSFER_RES model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, DEA_SEWAGE_PAID_TRANSFER_RES._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.M_ID == M_ID);
			
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
        public GeneralResult Edit(DEA_SEWAGE_PAID_TRANSFER_RES model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is DEA_SEWAGE_PAID_TRANSFER_RES entity)
	{		
		entity.Attach();
		entity.M_ID=model.M_ID;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_CREATOR=model.M_CREATOR;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.NOTICE_NAME=model.NOTICE_NAME;
		entity.NOTICE_SEND_TIME=model.NOTICE_SEND_TIME;
		entity.UNIFIED_DEAL_CODES=model.UNIFIED_DEAL_CODES;
		entity.SELL_COMM_NAME=model.SELL_COMM_NAME;
		entity.SELL_ORG_CODE=model.SELL_ORG_CODE;
		entity.BARGAIN_TOTAL_VOLUME=model.BARGAIN_TOTAL_VOLUME;
		entity.BARGAIN_TIME=model.BARGAIN_TIME;
		entity.NOTICE_CONTENT=model.NOTICE_CONTENT;
		entity.URL=model.URL;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
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
        public GeneralResult Add(DEA_SEWAGE_PAID_TRANSFER_RES model)
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
                    Delete(DEA_SEWAGE_PAID_TRANSFER_RES._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<DEA_SEWAGE_PAID_TRANSFER_RES> model)
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
       	protected WhereClipBuilder ConditionBuilder(DEA_SEWAGE_PAID_TRANSFER_RES model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.M_TM==(model.M_TM));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_NAME))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.NOTICE_NAME.Contain(model.NOTICE_NAME));
				}
				if(model.NOTICE_SEND_TIME!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.NOTICE_SEND_TIME==(model.NOTICE_SEND_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODES))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.UNIFIED_DEAL_CODES.Contain(model.UNIFIED_DEAL_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.SELL_COMM_NAME))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.SELL_COMM_NAME.Contain(model.SELL_COMM_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SELL_ORG_CODE))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.SELL_ORG_CODE.Contain(model.SELL_ORG_CODE));
				}
				if(model.BARGAIN_TOTAL_VOLUME!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.BARGAIN_TOTAL_VOLUME==(model.BARGAIN_TOTAL_VOLUME));
				}
				if(model.BARGAIN_TIME!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.BARGAIN_TIME==(model.BARGAIN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_CONTENT))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.NOTICE_CONTENT.Contain(model.NOTICE_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_RES._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}