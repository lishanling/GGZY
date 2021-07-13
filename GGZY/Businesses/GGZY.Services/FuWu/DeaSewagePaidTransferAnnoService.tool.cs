using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class DeaSewagePaidTransferAnnoService : BaseServiceT<DEA_SEWAGE_PAID_TRANSFER_ANNO>
    {
        #region 接口实现
        
		public List<DEA_SEWAGE_PAID_TRANSFER_ANNO> FindList(DEA_SEWAGE_PAID_TRANSFER_ANNO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<DEA_SEWAGE_PAID_TRANSFER_ANNO> PageList(DEA_SEWAGE_PAID_TRANSFER_ANNO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, DEA_SEWAGE_PAID_TRANSFER_ANNO._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.M_ID == M_ID);
			
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
        public GeneralResult Edit(DEA_SEWAGE_PAID_TRANSFER_ANNO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is DEA_SEWAGE_PAID_TRANSFER_ANNO entity)
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
		entity.BID_NAME=model.BID_NAME;
		entity.BID_NUM=model.BID_NUM;
		entity.BID_SOURCE=model.BID_SOURCE;
		entity.POLLUTION_RIGHTS_PERIOD=model.POLLUTION_RIGHTS_PERIOD;
		entity.LISTING_PRICE=model.LISTING_PRICE;
		entity.INITIAL_EXPENSE=model.INITIAL_EXPENSE;
		entity.TRANSACTION_MODE=model.TRANSACTION_MODE;
		entity.NOTICE_START_TIME=model.NOTICE_START_TIME;
		entity.NOTICE_END_TIME=model.NOTICE_END_TIME;
		entity.TRADING_START_TIME=model.TRADING_START_TIME;
		entity.NOTICE_CONTENT=model.NOTICE_CONTENT;
		entity.BID_REGION_CODE=model.BID_REGION_CODE;
		entity.MARGIN_PAY_ACCOUNT=model.MARGIN_PAY_ACCOUNT;
		entity.MARGIN_PAY_PROPORTION=model.MARGIN_PAY_PROPORTION;
		entity.MARGIN_CURRENCY=model.MARGIN_CURRENCY;
		entity.MARGIN_RECEIVE_END_TIME=model.MARGIN_RECEIVE_END_TIME;
		entity.SELL_COMM_NAME=model.SELL_COMM_NAME;
		entity.SELL_ORG_CODE=model.SELL_ORG_CODE;
		entity.URL=model.URL;
		entity.TRADING_CENTER_NAME=model.TRADING_CENTER_NAME;
		entity.TRADING_CENTER_CODE=model.TRADING_CENTER_CODE;
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
        public GeneralResult Add(DEA_SEWAGE_PAID_TRANSFER_ANNO model)
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
                    Delete(DEA_SEWAGE_PAID_TRANSFER_ANNO._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<DEA_SEWAGE_PAID_TRANSFER_ANNO> model)
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
       	protected WhereClipBuilder ConditionBuilder(DEA_SEWAGE_PAID_TRANSFER_ANNO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.M_TM==(model.M_TM));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_NAME))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.NOTICE_NAME.Contain(model.NOTICE_NAME));
				}
				if(model.NOTICE_SEND_TIME!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.NOTICE_SEND_TIME==(model.NOTICE_SEND_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODES))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.UNIFIED_DEAL_CODES.Contain(model.UNIFIED_DEAL_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_NAME))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.BID_NAME.Contain(model.BID_NAME));
				}
				if(model.BID_NUM!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.BID_NUM==(model.BID_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SOURCE))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.BID_SOURCE.Contain(model.BID_SOURCE));
				}
				if(model.POLLUTION_RIGHTS_PERIOD!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.POLLUTION_RIGHTS_PERIOD==(model.POLLUTION_RIGHTS_PERIOD));
				}
				if(model.LISTING_PRICE!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.LISTING_PRICE==(model.LISTING_PRICE));
				}
				if(model.INITIAL_EXPENSE!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.INITIAL_EXPENSE==(model.INITIAL_EXPENSE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRANSACTION_MODE))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.TRANSACTION_MODE.Contain(model.TRANSACTION_MODE));
				}
				if(model.NOTICE_START_TIME!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.NOTICE_START_TIME==(model.NOTICE_START_TIME));
				}
				if(model.NOTICE_END_TIME!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.NOTICE_END_TIME==(model.NOTICE_END_TIME));
				}
				if(model.TRADING_START_TIME!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.TRADING_START_TIME==(model.TRADING_START_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_CONTENT))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.NOTICE_CONTENT.Contain(model.NOTICE_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_REGION_CODE))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.BID_REGION_CODE.Contain(model.BID_REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_PAY_ACCOUNT))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.MARGIN_PAY_ACCOUNT.Contain(model.MARGIN_PAY_ACCOUNT));
				}
				if(model.MARGIN_PAY_PROPORTION!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.MARGIN_PAY_PROPORTION==(model.MARGIN_PAY_PROPORTION));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_CURRENCY))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.MARGIN_CURRENCY.Contain(model.MARGIN_CURRENCY));
				}
				if(model.MARGIN_RECEIVE_END_TIME!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.MARGIN_RECEIVE_END_TIME==(model.MARGIN_RECEIVE_END_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.SELL_COMM_NAME))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.SELL_COMM_NAME.Contain(model.SELL_COMM_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SELL_ORG_CODE))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.SELL_ORG_CODE.Contain(model.SELL_ORG_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADING_CENTER_NAME))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.TRADING_CENTER_NAME.Contain(model.TRADING_CENTER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADING_CENTER_CODE))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.TRADING_CENTER_CODE.Contain(model.TRADING_CENTER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(DEA_SEWAGE_PAID_TRANSFER_ANNO._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}