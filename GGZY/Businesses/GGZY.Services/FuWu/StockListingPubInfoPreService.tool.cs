using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class StockListingPubInfoPreService : BaseServiceT<STOCK_LISTING_PUB_INFO_PRE>
    {
        #region 接口实现
        
		public List<STOCK_LISTING_PUB_INFO_PRE> FindList(STOCK_LISTING_PUB_INFO_PRE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<STOCK_LISTING_PUB_INFO_PRE> PageList(STOCK_LISTING_PUB_INFO_PRE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, STOCK_LISTING_PUB_INFO_PRE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(STOCK_LISTING_PUB_INFO_PRE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(STOCK_LISTING_PUB_INFO_PRE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is STOCK_LISTING_PUB_INFO_PRE entity)
	{		
		entity.Attach();
		entity.PROJECT_NAME=model.PROJECT_NAME;
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.PROJECT_CLASSIFY_CODE=model.PROJECT_CLASSIFY_CODE;
		entity.SELLER_NAME=model.SELLER_NAME;
		entity.SELLER_TYPE=model.SELLER_TYPE;
		entity.SELLER_CODE=model.SELLER_CODE;
		entity.SELLER_ROLE=model.SELLER_ROLE;
		entity.AUTHORIZE_UNIT=model.AUTHORIZE_UNIT;
		entity.TOTAL_PERCENT=model.TOTAL_PERCENT;
		entity.PROJECT_PRICE=model.PROJECT_PRICE;
		entity.PUBLISH_DURATION=model.PUBLISH_DURATION;
		entity.PUBLISH_DATE=model.PUBLISH_DATE;
		entity.POST_PONE=model.POST_PONE;
		entity.PRE_EXCHANGE_TYPE=model.PRE_EXCHANGE_TYPE;
		entity.MANAGEMENT_INTENT=model.MANAGEMENT_INTENT;
		entity.GIVEUP_PRIORITY=model.GIVEUP_PRIORITY;
		entity.IMPORTANT_INFO=model.IMPORTANT_INFO;
		entity.BUYER_POSTULATE=model.BUYER_POSTULATE;
		entity.OTHER_CONDITIONS=model.OTHER_CONDITIONS;
		entity.PROJECT_URL=model.PROJECT_URL;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.CURRENCY_CODE=model.CURRENCY_CODE;
		entity.PRICE_UNIT=model.PRICE_UNIT;
		entity.M_ID=model.M_ID;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_GET_TM=model.M_GET_TM;
		entity.M_TRANSFER_RESULT=model.M_TRANSFER_RESULT;
		entity.M_ZONE=model.M_ZONE;
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
        public GeneralResult Add(STOCK_LISTING_PUB_INFO_PRE model)
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
                    Delete(STOCK_LISTING_PUB_INFO_PRE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<STOCK_LISTING_PUB_INFO_PRE> model)
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
       	protected WhereClipBuilder ConditionBuilder(STOCK_LISTING_PUB_INFO_PRE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.PROJECT_NAME.Contain(model.PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CLASSIFY_CODE))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.PROJECT_CLASSIFY_CODE.Contain(model.PROJECT_CLASSIFY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.SELLER_NAME))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.SELLER_NAME.Contain(model.SELLER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SELLER_TYPE))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.SELLER_TYPE.Contain(model.SELLER_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SELLER_CODE))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.SELLER_CODE.Contain(model.SELLER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.SELLER_ROLE))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.SELLER_ROLE.Contain(model.SELLER_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.AUTHORIZE_UNIT))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.AUTHORIZE_UNIT.Contain(model.AUTHORIZE_UNIT));
				}
				if(model.TOTAL_PERCENT!=null)
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.TOTAL_PERCENT==(model.TOTAL_PERCENT));
				}
				if(model.PROJECT_PRICE!=null)
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.PROJECT_PRICE==(model.PROJECT_PRICE));
				}
				if(model.PUBLISH_DURATION!=null)
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.PUBLISH_DURATION==(model.PUBLISH_DURATION));
				}
				if(model.PUBLISH_DATE!=null)
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.PUBLISH_DATE==(model.PUBLISH_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.POST_PONE))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.POST_PONE.Contain(model.POST_PONE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRE_EXCHANGE_TYPE))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.PRE_EXCHANGE_TYPE.Contain(model.PRE_EXCHANGE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.MANAGEMENT_INTENT))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.MANAGEMENT_INTENT.Contain(model.MANAGEMENT_INTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.GIVEUP_PRIORITY))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.GIVEUP_PRIORITY.Contain(model.GIVEUP_PRIORITY));
				}
				if(!string.IsNullOrWhiteSpace(model.IMPORTANT_INFO))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.IMPORTANT_INFO.Contain(model.IMPORTANT_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.BUYER_POSTULATE))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.BUYER_POSTULATE.Contain(model.BUYER_POSTULATE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_CONDITIONS))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.OTHER_CONDITIONS.Contain(model.OTHER_CONDITIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_URL))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.PROJECT_URL.Contain(model.PROJECT_URL));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.CURRENCY_CODE))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.CURRENCY_CODE.Contain(model.CURRENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_UNIT))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.PRICE_UNIT.Contain(model.PRICE_UNIT));
				}
				if(model.M_ID!=null)
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.M_ID==(model.M_ID));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_GET_TM!=null)
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.M_GET_TM==(model.M_GET_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_TRANSFER_RESULT))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.M_TRANSFER_RESULT.Contain(model.M_TRANSFER_RESULT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ZONE))
				{
				  condition.And(STOCK_LISTING_PUB_INFO_PRE._.M_ZONE.Contain(model.M_ZONE));
				}
		return condition;
	}
        #endregion
    }
}