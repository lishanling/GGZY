using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class StockTradeResultInfoService : BaseServiceT<STOCK_TRADE_RESULT_INFO>
    {
        #region 接口实现
        
		public List<STOCK_TRADE_RESULT_INFO> FindList(STOCK_TRADE_RESULT_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<STOCK_TRADE_RESULT_INFO> PageList(STOCK_TRADE_RESULT_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, STOCK_TRADE_RESULT_INFO._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(STOCK_TRADE_RESULT_INFO._.M_ID == M_ID);
			
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
        public GeneralResult Edit(STOCK_TRADE_RESULT_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is STOCK_TRADE_RESULT_INFO entity)
	{		
		entity.Attach();
		entity.PROJECT_NAME=model.PROJECT_NAME;
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.EXCHANGE_TYPE=model.EXCHANGE_TYPE;
		entity.SELLER_NAME=model.SELLER_NAME;
		entity.SELLER_CODE=model.SELLER_CODE;
		entity.SELLER_TYPE=model.SELLER_TYPE;
		entity.SELLER_ROLE=model.SELLER_ROLE;
		entity.OBJECT_EVALUATE_VALUE=model.OBJECT_EVALUATE_VALUE;
		entity.TRADE_VALUE=model.TRADE_VALUE;
		entity.TRADE_DATE=model.TRADE_DATE;
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
		entity.M_ACTUAL_TM=model.M_ACTUAL_TM;
		entity.M_IS_INSTALMENT=model.M_IS_INSTALMENT;
		entity.M_DOWN_PAY=model.M_DOWN_PAY;
		entity.M_DOWN_UNIT=model.M_DOWN_UNIT;
		entity.M_ATTACHMENT=model.M_ATTACHMENT;
		entity.M_PRE_ID=model.M_PRE_ID;
		entity.BID_CODE=model.BID_CODE;
		entity.BID_NAME=model.BID_NAME;
		entity.REGION_CODE=model.REGION_CODE;
		entity.TRA_PLACE_CODE=model.TRA_PLACE_CODE;
		entity.TRA_AGENCY_NAME=model.TRA_AGENCY_NAME;
		entity.TRA_AGENCY_CODE=model.TRA_AGENCY_CODE;
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
        public GeneralResult Add(STOCK_TRADE_RESULT_INFO model)
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
                    Delete(STOCK_TRADE_RESULT_INFO._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<STOCK_TRADE_RESULT_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(STOCK_TRADE_RESULT_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.PROJECT_NAME.Contain(model.PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXCHANGE_TYPE))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.EXCHANGE_TYPE.Contain(model.EXCHANGE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SELLER_NAME))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.SELLER_NAME.Contain(model.SELLER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SELLER_CODE))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.SELLER_CODE.Contain(model.SELLER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.SELLER_TYPE))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.SELLER_TYPE.Contain(model.SELLER_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SELLER_ROLE))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.SELLER_ROLE.Contain(model.SELLER_ROLE));
				}
				if(model.OBJECT_EVALUATE_VALUE!=null)
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.OBJECT_EVALUATE_VALUE==(model.OBJECT_EVALUATE_VALUE));
				}
				if(model.TRADE_VALUE!=null)
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.TRADE_VALUE==(model.TRADE_VALUE));
				}
				if(model.TRADE_DATE!=null)
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.TRADE_DATE==(model.TRADE_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_URL))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.PROJECT_URL.Contain(model.PROJECT_URL));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.CURRENCY_CODE))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.CURRENCY_CODE.Contain(model.CURRENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_UNIT))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.PRICE_UNIT.Contain(model.PRICE_UNIT));
				}
				if(model.M_ID!=null)
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.M_ID==(model.M_ID));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_ACTUAL_TM!=null)
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.M_ACTUAL_TM==(model.M_ACTUAL_TM));
				}
				if(model.M_IS_INSTALMENT!=null)
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.M_IS_INSTALMENT==(model.M_IS_INSTALMENT));
				}
				if(model.M_DOWN_PAY!=null)
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.M_DOWN_PAY==(model.M_DOWN_PAY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DOWN_UNIT))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.M_DOWN_UNIT.Contain(model.M_DOWN_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATTACHMENT))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.M_ATTACHMENT.Contain(model.M_ATTACHMENT));
				}
				if(model.M_PRE_ID!=null)
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.M_PRE_ID==(model.M_PRE_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_CODE))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.BID_CODE.Contain(model.BID_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_NAME))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.BID_NAME.Contain(model.BID_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_PLACE_CODE))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.TRA_PLACE_CODE.Contain(model.TRA_PLACE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_AGENCY_NAME))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.TRA_AGENCY_NAME.Contain(model.TRA_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_AGENCY_CODE))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.TRA_AGENCY_CODE.Contain(model.TRA_AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(STOCK_TRADE_RESULT_INFO._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}