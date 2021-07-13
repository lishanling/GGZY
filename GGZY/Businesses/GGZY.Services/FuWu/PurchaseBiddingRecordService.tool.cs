using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class PurchaseBiddingRecordService : BaseServiceT<PURCHASE_BIDDING_RECORD>
    {
        #region 接口实现
        
		public List<PURCHASE_BIDDING_RECORD> FindList(PURCHASE_BIDDING_RECORD model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PURCHASE_BIDDING_RECORD> PageList(PURCHASE_BIDDING_RECORD model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PURCHASE_BIDDING_RECORD._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PURCHASE_BIDDING_RECORD._.M_ID == M_ID);
			
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
        public GeneralResult Edit(PURCHASE_BIDDING_RECORD model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is PURCHASE_BIDDING_RECORD entity)
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
		entity.PURCHASE_PROJECT_CODE=model.PURCHASE_PROJECT_CODE;
		entity.PURCHASE_SECTION_CODE=model.PURCHASE_SECTION_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.NOTICE_NAME=model.NOTICE_NAME;
		entity.BID_OPENING_ACTOR=model.BID_OPENING_ACTOR;
		entity.BID_OPENING_CONTENT=model.BID_OPENING_CONTENT;
		entity.BID_OPENING_ADDRESS=model.BID_OPENING_ADDRESS;
		entity.URL=model.URL;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.M_VERSION=model.M_VERSION;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
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
        public GeneralResult Add(PURCHASE_BIDDING_RECORD model)
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
                    Delete(PURCHASE_BIDDING_RECORD._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PURCHASE_BIDDING_RECORD> model)
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
       	protected WhereClipBuilder ConditionBuilder(PURCHASE_BIDDING_RECORD model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.M_TM==(model.M_TM));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_PROJECT_CODE))
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.PURCHASE_PROJECT_CODE.Contain(model.PURCHASE_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_SECTION_CODE))
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.PURCHASE_SECTION_CODE.Contain(model.PURCHASE_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_NAME))
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.NOTICE_NAME.Contain(model.NOTICE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_OPENING_ACTOR))
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.BID_OPENING_ACTOR.Contain(model.BID_OPENING_ACTOR));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_OPENING_CONTENT))
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.BID_OPENING_CONTENT.Contain(model.BID_OPENING_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_OPENING_ADDRESS))
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.BID_OPENING_ADDRESS.Contain(model.BID_OPENING_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.M_VERSION.Contain(model.M_VERSION));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(PURCHASE_BIDDING_RECORD._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
		return condition;
	}
        #endregion
    }
}