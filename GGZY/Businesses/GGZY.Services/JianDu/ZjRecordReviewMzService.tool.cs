using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ZjRecordReviewMzService : BaseServiceT<ZJ_RECORD_REVIEW_MZ>
    {
        #region 接口实现
        
		public List<ZJ_RECORD_REVIEW_MZ> FindList(ZJ_RECORD_REVIEW_MZ model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJ_RECORD_REVIEW_MZ> PageList(ZJ_RECORD_REVIEW_MZ model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJ_RECORD_REVIEW_MZ._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(ZJ_RECORD_REVIEW_MZ._.M_ID == M_ID);
			
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
        public GeneralResult Edit(ZJ_RECORD_REVIEW_MZ model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is ZJ_RECORD_REVIEW_MZ entity)
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
		entity.TENDER_TYPE=model.TENDER_TYPE;
		entity.CONTROL_PRICE=model.CONTROL_PRICE;
		entity.CONTROL_CURRENCY_CODE=model.CONTROL_CURRENCY_CODE;
		entity.CONTROL_PRICE_UNIT=model.CONTROL_PRICE_UNIT;
		entity.TENDER_CONTENT=model.TENDER_CONTENT;
		entity.ENTERPRISE_QUALIFI_BASIC=model.ENTERPRISE_QUALIFI_BASIC;
		entity.REGISTER_CON_BASIC=model.REGISTER_CON_BASIC;
		entity.SIMILAR_PROJECT_BASIC=model.SIMILAR_PROJECT_BASIC;
		entity.ALL_LIMITE_TIME=model.ALL_LIMITE_TIME;
		entity.QUOTA_LIMIT_TIME=model.QUOTA_LIMIT_TIME;
		entity.BIDDER_QUALIFI_REQUIRE=model.BIDDER_QUALIFI_REQUIRE;
		entity.REGISTER_CON_REQUIRE=model.REGISTER_CON_REQUIRE;
		entity.SYNDICATED_FLAG=model.SYNDICATED_FLAG;
		entity.IS_COMPREHENSIVE_SCORE=model.IS_COMPREHENSIVE_SCORE;
		entity.TYPE_PERFORM_REQUIRE=model.TYPE_PERFORM_REQUIRE;
		entity.MARGIN_AMOUNT=model.MARGIN_AMOUNT;
		entity.MARGIN_UNIT=model.MARGIN_UNIT;
		entity.MARGIN_CURRENCY_CODE=model.MARGIN_CURRENCY_CODE;
		entity.TENDER_DOC_GET_METHOD=model.TENDER_DOC_GET_METHOD;
		entity.DOC_GET_START_TIME=model.DOC_GET_START_TIME;
		entity.BID_DOC_REFER_END_TIME=model.BID_DOC_REFER_END_TIME;
		entity.BID_DOC_REFER_METHOD=model.BID_DOC_REFER_METHOD;
		entity.TENDER_NOTICE=model.TENDER_NOTICE;
		entity.DEADLINE_BIDDING=model.DEADLINE_BIDDING;
		entity.BID_OPEN_TIME=model.BID_OPEN_TIME;
		entity.PERFORM_PRICE=model.PERFORM_PRICE;
		entity.CONTRACT_SIGN_TIME=model.CONTRACT_SIGN_TIME;
		entity.ALL_EXPERT_NUM=model.ALL_EXPERT_NUM;
		entity.EXPERT_NUM=model.EXPERT_NUM;
		entity.EVALUATING_METHOD=model.EVALUATING_METHOD;
		entity.QUANTITIES_DRAW_UNIT=model.QUANTITIES_DRAW_UNIT;
		entity.QUANTITIES_AUDIT_UNIT=model.QUANTITIES_AUDIT_UNIT;
		entity.CONTROL_PRICE_DRAW_UNIT=model.CONTROL_PRICE_DRAW_UNIT;
		entity.CONTROL_PRICE_AUDIT_UNIT=model.CONTROL_PRICE_AUDIT_UNIT;
		entity.PERFORM_UNIT=model.PERFORM_UNIT;
		entity.PERFORM_CURRENCY_CODE=model.PERFORM_CURRENCY_CODE;
		entity.SUBMIT_TIME=model.SUBMIT_TIME;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
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
        public GeneralResult Add(ZJ_RECORD_REVIEW_MZ model)
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
                    Delete(ZJ_RECORD_REVIEW_MZ._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJ_RECORD_REVIEW_MZ> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJ_RECORD_REVIEW_MZ model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.M_TM==(model.M_TM));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.REPROT_CODE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.REPROT_CODE.Contain(model.REPROT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_TYPE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.TENDER_TYPE.Contain(model.TENDER_TYPE));
				}
				if(model.CONTROL_PRICE!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.CONTROL_PRICE==(model.CONTROL_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTROL_CURRENCY_CODE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.CONTROL_CURRENCY_CODE.Contain(model.CONTROL_CURRENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTROL_PRICE_UNIT))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.CONTROL_PRICE_UNIT.Contain(model.CONTROL_PRICE_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_CONTENT))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.TENDER_CONTENT.Contain(model.TENDER_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.ENTERPRISE_QUALIFI_BASIC))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.ENTERPRISE_QUALIFI_BASIC.Contain(model.ENTERPRISE_QUALIFI_BASIC));
				}
				if(!string.IsNullOrWhiteSpace(model.REGISTER_CON_BASIC))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.REGISTER_CON_BASIC.Contain(model.REGISTER_CON_BASIC));
				}
				if(!string.IsNullOrWhiteSpace(model.SIMILAR_PROJECT_BASIC))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.SIMILAR_PROJECT_BASIC.Contain(model.SIMILAR_PROJECT_BASIC));
				}
				if(model.ALL_LIMITE_TIME!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.ALL_LIMITE_TIME==(model.ALL_LIMITE_TIME));
				}
				if(model.QUOTA_LIMIT_TIME!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.QUOTA_LIMIT_TIME==(model.QUOTA_LIMIT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_QUALIFI_REQUIRE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.BIDDER_QUALIFI_REQUIRE.Contain(model.BIDDER_QUALIFI_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGISTER_CON_REQUIRE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.REGISTER_CON_REQUIRE.Contain(model.REGISTER_CON_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.SYNDICATED_FLAG))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.SYNDICATED_FLAG.Contain(model.SYNDICATED_FLAG));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_COMPREHENSIVE_SCORE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.IS_COMPREHENSIVE_SCORE.Contain(model.IS_COMPREHENSIVE_SCORE));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPE_PERFORM_REQUIRE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.TYPE_PERFORM_REQUIRE.Contain(model.TYPE_PERFORM_REQUIRE));
				}
				if(model.MARGIN_AMOUNT!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.MARGIN_AMOUNT==(model.MARGIN_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_UNIT))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.MARGIN_UNIT.Contain(model.MARGIN_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_CURRENCY_CODE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.MARGIN_CURRENCY_CODE.Contain(model.MARGIN_CURRENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_DOC_GET_METHOD))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.TENDER_DOC_GET_METHOD.Contain(model.TENDER_DOC_GET_METHOD));
				}
				if(model.DOC_GET_START_TIME!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.DOC_GET_START_TIME==(model.DOC_GET_START_TIME));
				}
				if(model.BID_DOC_REFER_END_TIME!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.BID_DOC_REFER_END_TIME==(model.BID_DOC_REFER_END_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_DOC_REFER_METHOD))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.BID_DOC_REFER_METHOD.Contain(model.BID_DOC_REFER_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_NOTICE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.TENDER_NOTICE.Contain(model.TENDER_NOTICE));
				}
				if(model.DEADLINE_BIDDING!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.DEADLINE_BIDDING==(model.DEADLINE_BIDDING));
				}
				if(model.BID_OPEN_TIME!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.BID_OPEN_TIME==(model.BID_OPEN_TIME));
				}
				if(model.PERFORM_PRICE!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.PERFORM_PRICE==(model.PERFORM_PRICE));
				}
				if(model.CONTRACT_SIGN_TIME!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.CONTRACT_SIGN_TIME==(model.CONTRACT_SIGN_TIME));
				}
				if(model.ALL_EXPERT_NUM!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.ALL_EXPERT_NUM==(model.ALL_EXPERT_NUM));
				}
				if(model.EXPERT_NUM!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.EXPERT_NUM==(model.EXPERT_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATING_METHOD))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.EVALUATING_METHOD.Contain(model.EVALUATING_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.QUANTITIES_DRAW_UNIT))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.QUANTITIES_DRAW_UNIT.Contain(model.QUANTITIES_DRAW_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.QUANTITIES_AUDIT_UNIT))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.QUANTITIES_AUDIT_UNIT.Contain(model.QUANTITIES_AUDIT_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTROL_PRICE_DRAW_UNIT))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.CONTROL_PRICE_DRAW_UNIT.Contain(model.CONTROL_PRICE_DRAW_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTROL_PRICE_AUDIT_UNIT))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.CONTROL_PRICE_AUDIT_UNIT.Contain(model.CONTROL_PRICE_AUDIT_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORM_UNIT))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.PERFORM_UNIT.Contain(model.PERFORM_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORM_CURRENCY_CODE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.PERFORM_CURRENCY_CODE.Contain(model.PERFORM_CURRENCY_CODE));
				}
				if(model.SUBMIT_TIME!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.SUBMIT_TIME==(model.SUBMIT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(ZJ_RECORD_REVIEW_MZ._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}