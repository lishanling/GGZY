using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SlTenderFileClariModiService : BaseServiceT<SL_TENDER_FILE_CLARI_MODI>
    {
        #region 接口实现
        
		public List<SL_TENDER_FILE_CLARI_MODI> FindList(SL_TENDER_FILE_CLARI_MODI model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SL_TENDER_FILE_CLARI_MODI> PageList(SL_TENDER_FILE_CLARI_MODI model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SL_TENDER_FILE_CLARI_MODI._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(SL_TENDER_FILE_CLARI_MODI._.M_ID == M_ID);
			
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
        public GeneralResult Edit(SL_TENDER_FILE_CLARI_MODI model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is SL_TENDER_FILE_CLARI_MODI entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.UNIFIED_DEAL_CODES=model.UNIFIED_DEAL_CODES;
		entity.DOC_NO=model.DOC_NO;
		entity.DOC_NAME=model.DOC_NAME;
		entity.BID_QUALIFICATION=model.BID_QUALIFICATION;
		entity.BID_DOC_REFER_END_TIME=model.BID_DOC_REFER_END_TIME;
		entity.VALID_PERIOD=model.VALID_PERIOD;
		entity.BID_DOC_REFER_METHOD=model.BID_DOC_REFER_METHOD;
		entity.MARGIN_PAY_TYPE=model.MARGIN_PAY_TYPE;
		entity.MARGIN_AMOUNT=model.MARGIN_AMOUNT;
		entity.MARGIN_CURRENCY=model.MARGIN_CURRENCY;
		entity.MARGIN_AMOUNT_UNIT=model.MARGIN_AMOUNT_UNIT;
		entity.CONTROL_PRICE=model.CONTROL_PRICE;
		entity.CONTROL_PRICE_CURRENCY=model.CONTROL_PRICE_CURRENCY;
		entity.CONTROL_PRICE_UNIT=model.CONTROL_PRICE_UNIT;
		entity.EVALUATING_METHOD=model.EVALUATING_METHOD;
		entity.BID_OPEN_TIME=model.BID_OPEN_TIME;
		entity.BID_OPEN_PLACE=model.BID_OPEN_PLACE;
		entity.BID_OPEN_TYPE=model.BID_OPEN_TYPE;
		entity.QUAL_TYPE=model.QUAL_TYPE;
		entity.CLARIFY_TIME=model.CLARIFY_TIME;
		entity.IS_POSTPONE=model.IS_POSTPONE;
		entity.POST_OPEN_TIME=model.POST_OPEN_TIME;
		entity.POST_OPEN_ADDRESS=model.POST_OPEN_ADDRESS;
		entity.CLARIFY_CONTENT=model.CLARIFY_CONTENT;
		entity.SUBMIT_TIME=model.SUBMIT_TIME;
		entity.URL=model.URL;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.TRADE_PLATFORM_NAME=model.TRADE_PLATFORM_NAME;
		entity.TRADING_PLATFORM_ADDRESS=model.TRADING_PLATFORM_ADDRESS;
		entity.CUSTOMER_SERVICE_PHONE=model.CUSTOMER_SERVICE_PHONE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
		entity.PRICE_FORM_CODE=model.PRICE_FORM_CODE;
		entity.MARGIN_PERCENT=model.MARGIN_PERCENT;
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
        public GeneralResult Add(SL_TENDER_FILE_CLARI_MODI model)
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
                    Delete(SL_TENDER_FILE_CLARI_MODI._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SL_TENDER_FILE_CLARI_MODI> model)
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
       	protected WhereClipBuilder ConditionBuilder(SL_TENDER_FILE_CLARI_MODI model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODES))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.UNIFIED_DEAL_CODES.Contain(model.UNIFIED_DEAL_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.DOC_NO))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.DOC_NO.Contain(model.DOC_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.DOC_NAME))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.DOC_NAME.Contain(model.DOC_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_QUALIFICATION))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.BID_QUALIFICATION.Contain(model.BID_QUALIFICATION));
				}
				if(model.BID_DOC_REFER_END_TIME!=null)
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.BID_DOC_REFER_END_TIME==(model.BID_DOC_REFER_END_TIME));
				}
				if(model.VALID_PERIOD!=null)
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.VALID_PERIOD==(model.VALID_PERIOD));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_DOC_REFER_METHOD))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.BID_DOC_REFER_METHOD.Contain(model.BID_DOC_REFER_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_PAY_TYPE))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.MARGIN_PAY_TYPE.Contain(model.MARGIN_PAY_TYPE));
				}
				if(model.MARGIN_AMOUNT!=null)
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.MARGIN_AMOUNT==(model.MARGIN_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_CURRENCY))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.MARGIN_CURRENCY.Contain(model.MARGIN_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_AMOUNT_UNIT))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.MARGIN_AMOUNT_UNIT.Contain(model.MARGIN_AMOUNT_UNIT));
				}
				if(model.CONTROL_PRICE!=null)
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.CONTROL_PRICE==(model.CONTROL_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTROL_PRICE_CURRENCY))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.CONTROL_PRICE_CURRENCY.Contain(model.CONTROL_PRICE_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTROL_PRICE_UNIT))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.CONTROL_PRICE_UNIT.Contain(model.CONTROL_PRICE_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATING_METHOD))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.EVALUATING_METHOD.Contain(model.EVALUATING_METHOD));
				}
				if(model.BID_OPEN_TIME!=null)
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.BID_OPEN_TIME==(model.BID_OPEN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_OPEN_PLACE))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.BID_OPEN_PLACE.Contain(model.BID_OPEN_PLACE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_OPEN_TYPE))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.BID_OPEN_TYPE.Contain(model.BID_OPEN_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.QUAL_TYPE))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.QUAL_TYPE.Contain(model.QUAL_TYPE));
				}
				if(model.CLARIFY_TIME!=null)
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.CLARIFY_TIME==(model.CLARIFY_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_POSTPONE))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.IS_POSTPONE.Contain(model.IS_POSTPONE));
				}
				if(model.POST_OPEN_TIME!=null)
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.POST_OPEN_TIME==(model.POST_OPEN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.POST_OPEN_ADDRESS))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.POST_OPEN_ADDRESS.Contain(model.POST_OPEN_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.CLARIFY_CONTENT))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.CLARIFY_CONTENT.Contain(model.CLARIFY_CONTENT));
				}
				if(model.SUBMIT_TIME!=null)
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.SUBMIT_TIME==(model.SUBMIT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLATFORM_NAME))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.TRADE_PLATFORM_NAME.Contain(model.TRADE_PLATFORM_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADING_PLATFORM_ADDRESS))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.TRADING_PLATFORM_ADDRESS.Contain(model.TRADING_PLATFORM_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.CUSTOMER_SERVICE_PHONE))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.CUSTOMER_SERVICE_PHONE.Contain(model.CUSTOMER_SERVICE_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_FORM_CODE))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.PRICE_FORM_CODE.Contain(model.PRICE_FORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_PERCENT))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.MARGIN_PERCENT.Contain(model.MARGIN_PERCENT));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(SL_TENDER_FILE_CLARI_MODI._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}