using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ZjContractPerformanceService : BaseServiceT<ZJ_CONTRACT_PERFORMANCE>
    {
        #region 接口实现
        
		public List<ZJ_CONTRACT_PERFORMANCE> FindList(ZJ_CONTRACT_PERFORMANCE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJ_CONTRACT_PERFORMANCE> PageList(ZJ_CONTRACT_PERFORMANCE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJ_CONTRACT_PERFORMANCE._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID">数据自增长ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ZJ_CONTRACT_PERFORMANCE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(ZJ_CONTRACT_PERFORMANCE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is ZJ_CONTRACT_PERFORMANCE entity)
	{		
		entity.Attach();
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.CONTRACT_RECORD_CODE=model.CONTRACT_RECORD_CODE;
		entity.CONTRACT_CODE=model.CONTRACT_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.TENDERER_NAME=model.TENDERER_NAME;
		entity.TENDER_CODE=model.TENDER_CODE;
		entity.BIDDER_NAME=model.BIDDER_NAME;
		entity.BIDDER_CODE=model.BIDDER_CODE;
		entity.CONTRACT_PRICE=model.CONTRACT_PRICE;
		entity.SETTLE_PRICE=model.SETTLE_PRICE;
		entity.PRICE_CURRENCY=model.PRICE_CURRENCY;
		entity.PRICE_UNIT=model.PRICE_UNIT;
		entity.CONTRACT_CONTENT=model.CONTRACT_CONTENT;
		entity.LIMITE_TIME=model.LIMITE_TIME;
		entity.QUALITY_REQUIRE=model.QUALITY_REQUIRE;
		entity.PERFORM_CHANGE_CONTENT=model.PERFORM_CHANGE_CONTENT;
		entity.FINISH_TIME=model.FINISH_TIME;
		entity.ACTUALLY_PERIOD=model.ACTUALLY_PERIOD;
		entity.PERFORM_INFO=model.PERFORM_INFO;
		entity.SUBMIT_TIME=model.SUBMIT_TIME;
		entity.CONTRACT_SIGN_TIME=model.CONTRACT_SIGN_TIME;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_TM=model.M_TM;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.CONTRACT_NAME=model.CONTRACT_NAME;
		entity.PRICE_FORM_CODE=model.PRICE_FORM_CODE;
		entity.OTHER_CONTRACT_PRICE=model.OTHER_CONTRACT_PRICE;
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
        public GeneralResult Add(ZJ_CONTRACT_PERFORMANCE model)
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
                    Delete(ZJ_CONTRACT_PERFORMANCE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJ_CONTRACT_PERFORMANCE> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJ_CONTRACT_PERFORMANCE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_RECORD_CODE))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.CONTRACT_RECORD_CODE.Contain(model.CONTRACT_RECORD_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_CODE))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.CONTRACT_CODE.Contain(model.CONTRACT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_NAME))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.TENDERER_NAME.Contain(model.TENDERER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_CODE))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.TENDER_CODE.Contain(model.TENDER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_NAME))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.BIDDER_NAME.Contain(model.BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_CODE))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.BIDDER_CODE.Contain(model.BIDDER_CODE));
				}
				if(model.CONTRACT_PRICE!=null)
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.CONTRACT_PRICE==(model.CONTRACT_PRICE));
				}
				if(model.SETTLE_PRICE!=null)
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.SETTLE_PRICE==(model.SETTLE_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_CURRENCY))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.PRICE_CURRENCY.Contain(model.PRICE_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_UNIT))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.PRICE_UNIT.Contain(model.PRICE_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_CONTENT))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.CONTRACT_CONTENT.Contain(model.CONTRACT_CONTENT));
				}
				if(model.LIMITE_TIME!=null)
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.LIMITE_TIME==(model.LIMITE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALITY_REQUIRE))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.QUALITY_REQUIRE.Contain(model.QUALITY_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORM_CHANGE_CONTENT))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.PERFORM_CHANGE_CONTENT.Contain(model.PERFORM_CHANGE_CONTENT));
				}
				if(model.FINISH_TIME!=null)
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.FINISH_TIME==(model.FINISH_TIME));
				}
				if(model.ACTUALLY_PERIOD!=null)
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.ACTUALLY_PERIOD==(model.ACTUALLY_PERIOD));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORM_INFO))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.PERFORM_INFO.Contain(model.PERFORM_INFO));
				}
				if(model.SUBMIT_TIME!=null)
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.SUBMIT_TIME==(model.SUBMIT_TIME));
				}
				if(model.CONTRACT_SIGN_TIME!=null)
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.CONTRACT_SIGN_TIME==(model.CONTRACT_SIGN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_TM!=null)
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.M_TM==(model.M_TM));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_NAME))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.CONTRACT_NAME.Contain(model.CONTRACT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_FORM_CODE))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.PRICE_FORM_CODE.Contain(model.PRICE_FORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_CONTRACT_PRICE))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.OTHER_CONTRACT_PRICE.Contain(model.OTHER_CONTRACT_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(ZJ_CONTRACT_PERFORMANCE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}