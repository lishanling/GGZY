using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ZjRecordReviewMtService : BaseServiceT<ZJ_RECORD_REVIEW_MT>
    {
        #region 接口实现
        
		public List<ZJ_RECORD_REVIEW_MT> FindList(ZJ_RECORD_REVIEW_MT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJ_RECORD_REVIEW_MT> PageList(ZJ_RECORD_REVIEW_MT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJ_RECORD_REVIEW_MT._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(ZJ_RECORD_REVIEW_MT._.M_ID == M_ID);
			
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
        public GeneralResult Edit(ZJ_RECORD_REVIEW_MT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is ZJ_RECORD_REVIEW_MT entity)
	{		
		entity.Attach();
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_CREATOR=model.M_CREATOR;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.REPROT_CODE=model.REPROT_CODE;
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.TENDER_DOC_GET_TIME=model.TENDER_DOC_GET_TIME;
		entity.DOC_GET_END_TIME=model.DOC_GET_END_TIME;
		entity.BID_DOC_REFER_END_TIME=model.BID_DOC_REFER_END_TIME;
		entity.BID_OPEN_TIME=model.BID_OPEN_TIME;
		entity.DOC_PRICE=model.DOC_PRICE;
		entity.DOC_PRICE_CURRENCY=model.DOC_PRICE_CURRENCY;
		entity.DOC_PRICE_UNIT=model.DOC_PRICE_UNIT;
		entity.SYNDICATED_FLAG=model.SYNDICATED_FLAG;
		entity.SYNDICATED_REQUIRE=model.SYNDICATED_REQUIRE;
		entity.SIMILAR_PROJECT_BASIC=model.SIMILAR_PROJECT_BASIC;
		entity.BID_QUALIFICATION=model.BID_QUALIFICATION;
		entity.VALID_PERIOD=model.VALID_PERIOD;
		entity.BID_DOC_REFER_METHOD=model.BID_DOC_REFER_METHOD;
		entity.MARGIN_PAY_TYPE=model.MARGIN_PAY_TYPE;
		entity.MARGIN_AMOUNT=model.MARGIN_AMOUNT;
		entity.MARGIN_UNIT=model.MARGIN_UNIT;
		entity.MARGIN_CURRENCY_CODE=model.MARGIN_CURRENCY_CODE;
		entity.CONTROL_PRICE=model.CONTROL_PRICE;
		entity.CONTROL_UNIT=model.CONTROL_UNIT;
		entity.CONTROL_CURRENCY_CODE=model.CONTROL_CURRENCY_CODE;
		entity.EVALUATING_METHOD=model.EVALUATING_METHOD;
		entity.BID_OPEN_PLACE=model.BID_OPEN_PLACE;
		entity.CLARIFY_TIME=model.CLARIFY_TIME;
		entity.TENDER_NOTICE=model.TENDER_NOTICE;
		entity.QUAL_TYPE=model.QUAL_TYPE;
		entity.SUBMIT_TIME=model.SUBMIT_TIME;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.TRADE_PLAT=model.TRADE_PLAT;
		entity.PUB_SERVICE_PLAT=model.PUB_SERVICE_PLAT;
		entity.M_VERSION=model.M_VERSION;
		entity.M_ATT_BILL_OF_QUANTITIES=model.M_ATT_BILL_OF_QUANTITIES;
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
        public GeneralResult Add(ZJ_RECORD_REVIEW_MT model)
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
                    Delete(ZJ_RECORD_REVIEW_MT._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJ_RECORD_REVIEW_MT> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJ_RECORD_REVIEW_MT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.M_TM==(model.M_TM));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.REPROT_CODE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.REPROT_CODE.Contain(model.REPROT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(model.TENDER_DOC_GET_TIME!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.TENDER_DOC_GET_TIME==(model.TENDER_DOC_GET_TIME));
				}
				if(model.DOC_GET_END_TIME!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.DOC_GET_END_TIME==(model.DOC_GET_END_TIME));
				}
				if(model.BID_DOC_REFER_END_TIME!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.BID_DOC_REFER_END_TIME==(model.BID_DOC_REFER_END_TIME));
				}
				if(model.BID_OPEN_TIME!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.BID_OPEN_TIME==(model.BID_OPEN_TIME));
				}
				if(model.DOC_PRICE!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.DOC_PRICE==(model.DOC_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.DOC_PRICE_CURRENCY))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.DOC_PRICE_CURRENCY.Contain(model.DOC_PRICE_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.DOC_PRICE_UNIT))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.DOC_PRICE_UNIT.Contain(model.DOC_PRICE_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.SYNDICATED_FLAG))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.SYNDICATED_FLAG.Contain(model.SYNDICATED_FLAG));
				}
				if(!string.IsNullOrWhiteSpace(model.SYNDICATED_REQUIRE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.SYNDICATED_REQUIRE.Contain(model.SYNDICATED_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.SIMILAR_PROJECT_BASIC))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.SIMILAR_PROJECT_BASIC.Contain(model.SIMILAR_PROJECT_BASIC));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_QUALIFICATION))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.BID_QUALIFICATION.Contain(model.BID_QUALIFICATION));
				}
				if(model.VALID_PERIOD!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.VALID_PERIOD==(model.VALID_PERIOD));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_DOC_REFER_METHOD))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.BID_DOC_REFER_METHOD.Contain(model.BID_DOC_REFER_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_PAY_TYPE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.MARGIN_PAY_TYPE.Contain(model.MARGIN_PAY_TYPE));
				}
				if(model.MARGIN_AMOUNT!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.MARGIN_AMOUNT==(model.MARGIN_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_UNIT))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.MARGIN_UNIT.Contain(model.MARGIN_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_CURRENCY_CODE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.MARGIN_CURRENCY_CODE.Contain(model.MARGIN_CURRENCY_CODE));
				}
				if(model.CONTROL_PRICE!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.CONTROL_PRICE==(model.CONTROL_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTROL_UNIT))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.CONTROL_UNIT.Contain(model.CONTROL_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTROL_CURRENCY_CODE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.CONTROL_CURRENCY_CODE.Contain(model.CONTROL_CURRENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATING_METHOD))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.EVALUATING_METHOD.Contain(model.EVALUATING_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_OPEN_PLACE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.BID_OPEN_PLACE.Contain(model.BID_OPEN_PLACE));
				}
				if(model.CLARIFY_TIME!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.CLARIFY_TIME==(model.CLARIFY_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_NOTICE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.TENDER_NOTICE.Contain(model.TENDER_NOTICE));
				}
				if(!string.IsNullOrWhiteSpace(model.QUAL_TYPE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.QUAL_TYPE.Contain(model.QUAL_TYPE));
				}
				if(model.SUBMIT_TIME!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.SUBMIT_TIME==(model.SUBMIT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.M_VERSION.Contain(model.M_VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_BILL_OF_QUANTITIES))
				{
				  condition.And(ZJ_RECORD_REVIEW_MT._.M_ATT_BILL_OF_QUANTITIES.Contain(model.M_ATT_BILL_OF_QUANTITIES));
				}
		return condition;
	}
        #endregion
    }
}