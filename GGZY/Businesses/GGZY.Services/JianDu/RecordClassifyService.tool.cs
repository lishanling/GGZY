using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class RecordClassifyService : BaseServiceT<RECORD_CLASSIFY>
    {
        #region 接口实现
        
		public List<RECORD_CLASSIFY> FindList(RECORD_CLASSIFY model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<RECORD_CLASSIFY> PageList(RECORD_CLASSIFY model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, RECORD_CLASSIFY._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="RECORD_ID">备案主表ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? RECORD_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(RECORD_CLASSIFY._.RECORD_ID == RECORD_ID);
			
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
        public GeneralResult Edit(RECORD_CLASSIFY model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.RECORD_ID);
	
	if(viewResult.Success  && viewResult.Data is RECORD_CLASSIFY entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.RECORD_ID=model.RECORD_ID;
		entity.TENDER_TYPE=model.TENDER_TYPE;
		entity.CONTROL_PRICE=model.CONTROL_PRICE;
		entity.CONTROL_UNIT=model.CONTROL_UNIT;
		entity.CONTROL_CURRENCY_CODE=model.CONTROL_CURRENCY_CODE;
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
		entity.DOC_GET_END_TIME=model.DOC_GET_END_TIME;
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
		entity.SCOPE_CONTRACT_RISK=model.SCOPE_CONTRACT_RISK;
		entity.CONTRACT_PRICE=model.CONTRACT_PRICE;
		entity.ADVANCE_CHARGE=model.ADVANCE_CHARGE;
		entity.PERCENT_PROGERESS=model.PERCENT_PROGERESS;
		entity.DEFECT_LIABILITY_PERIOD=model.DEFECT_LIABILITY_PERIOD;
		entity.QUALITY_MARGIN_AMOUNT=model.QUALITY_MARGIN_AMOUNT;
		entity.IS_POSTPONE=model.IS_POSTPONE;
		entity.DEADLINE_BIDDING2=model.DEADLINE_BIDDING2;
		entity.POST_OPEN_TIME=model.POST_OPEN_TIME;
		entity.POST_OPEN_ADDRESS=model.POST_OPEN_ADDRESS;
		entity.CLARIFY_TITLE=model.CLARIFY_TITLE;
		entity.CLARIFY_CONTENT=model.CLARIFY_CONTENT;
		entity.CREATE_TM=model.CREATE_TM;
		entity.CREATOR=model.CREATOR;
		entity.CLARIFY_END_TIME=model.CLARIFY_END_TIME;
		entity.DEPOSIT_END_TIME=model.DEPOSIT_END_TIME;
		entity.QUANTITIES_DRAW_UNIT=model.QUANTITIES_DRAW_UNIT;
		entity.QUANTITIES_AUDIT_UNIT=model.QUANTITIES_AUDIT_UNIT;
		entity.CONTROL_PRICE_DRAW_UNIT=model.CONTROL_PRICE_DRAW_UNIT;
		entity.CONTROL_PRICE_AUDIT_UNIT=model.CONTROL_PRICE_AUDIT_UNIT;
		entity.PERFORM_UNIT=model.PERFORM_UNIT;
		entity.PERFORM_CURRENCY_CODE=model.PERFORM_CURRENCY_CODE;
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
        public GeneralResult Add(RECORD_CLASSIFY model)
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
                    Delete(RECORD_CLASSIFY._.RECORD_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<RECORD_CLASSIFY> model)
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
       	protected WhereClipBuilder ConditionBuilder(RECORD_CLASSIFY model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(RECORD_CLASSIFY._.ID==(model.ID));
				}
				if(model.RECORD_ID!=null)
				{
				  condition.And(RECORD_CLASSIFY._.RECORD_ID==(model.RECORD_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_TYPE))
				{
				  condition.And(RECORD_CLASSIFY._.TENDER_TYPE.Contain(model.TENDER_TYPE));
				}
				if(model.CONTROL_PRICE!=null)
				{
				  condition.And(RECORD_CLASSIFY._.CONTROL_PRICE==(model.CONTROL_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTROL_UNIT))
				{
				  condition.And(RECORD_CLASSIFY._.CONTROL_UNIT.Contain(model.CONTROL_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTROL_CURRENCY_CODE))
				{
				  condition.And(RECORD_CLASSIFY._.CONTROL_CURRENCY_CODE.Contain(model.CONTROL_CURRENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_CONTENT))
				{
				  condition.And(RECORD_CLASSIFY._.TENDER_CONTENT.Contain(model.TENDER_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.ENTERPRISE_QUALIFI_BASIC))
				{
				  condition.And(RECORD_CLASSIFY._.ENTERPRISE_QUALIFI_BASIC.Contain(model.ENTERPRISE_QUALIFI_BASIC));
				}
				if(!string.IsNullOrWhiteSpace(model.REGISTER_CON_BASIC))
				{
				  condition.And(RECORD_CLASSIFY._.REGISTER_CON_BASIC.Contain(model.REGISTER_CON_BASIC));
				}
				if(!string.IsNullOrWhiteSpace(model.SIMILAR_PROJECT_BASIC))
				{
				  condition.And(RECORD_CLASSIFY._.SIMILAR_PROJECT_BASIC.Contain(model.SIMILAR_PROJECT_BASIC));
				}
				if(model.ALL_LIMITE_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY._.ALL_LIMITE_TIME==(model.ALL_LIMITE_TIME));
				}
				if(model.QUOTA_LIMIT_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY._.QUOTA_LIMIT_TIME==(model.QUOTA_LIMIT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_QUALIFI_REQUIRE))
				{
				  condition.And(RECORD_CLASSIFY._.BIDDER_QUALIFI_REQUIRE.Contain(model.BIDDER_QUALIFI_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGISTER_CON_REQUIRE))
				{
				  condition.And(RECORD_CLASSIFY._.REGISTER_CON_REQUIRE.Contain(model.REGISTER_CON_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.SYNDICATED_FLAG))
				{
				  condition.And(RECORD_CLASSIFY._.SYNDICATED_FLAG.Contain(model.SYNDICATED_FLAG));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_COMPREHENSIVE_SCORE))
				{
				  condition.And(RECORD_CLASSIFY._.IS_COMPREHENSIVE_SCORE.Contain(model.IS_COMPREHENSIVE_SCORE));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPE_PERFORM_REQUIRE))
				{
				  condition.And(RECORD_CLASSIFY._.TYPE_PERFORM_REQUIRE.Contain(model.TYPE_PERFORM_REQUIRE));
				}
				if(model.MARGIN_AMOUNT!=null)
				{
				  condition.And(RECORD_CLASSIFY._.MARGIN_AMOUNT==(model.MARGIN_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_UNIT))
				{
				  condition.And(RECORD_CLASSIFY._.MARGIN_UNIT.Contain(model.MARGIN_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_CURRENCY_CODE))
				{
				  condition.And(RECORD_CLASSIFY._.MARGIN_CURRENCY_CODE.Contain(model.MARGIN_CURRENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_DOC_GET_METHOD))
				{
				  condition.And(RECORD_CLASSIFY._.TENDER_DOC_GET_METHOD.Contain(model.TENDER_DOC_GET_METHOD));
				}
				if(model.DOC_GET_START_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY._.DOC_GET_START_TIME==(model.DOC_GET_START_TIME));
				}
				if(model.DOC_GET_END_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY._.DOC_GET_END_TIME==(model.DOC_GET_END_TIME));
				}
				if(model.BID_DOC_REFER_END_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY._.BID_DOC_REFER_END_TIME==(model.BID_DOC_REFER_END_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_DOC_REFER_METHOD))
				{
				  condition.And(RECORD_CLASSIFY._.BID_DOC_REFER_METHOD.Contain(model.BID_DOC_REFER_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_NOTICE))
				{
				  condition.And(RECORD_CLASSIFY._.TENDER_NOTICE.Contain(model.TENDER_NOTICE));
				}
				if(model.DEADLINE_BIDDING!=null)
				{
				  condition.And(RECORD_CLASSIFY._.DEADLINE_BIDDING==(model.DEADLINE_BIDDING));
				}
				if(model.BID_OPEN_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY._.BID_OPEN_TIME==(model.BID_OPEN_TIME));
				}
				if(model.PERFORM_PRICE!=null)
				{
				  condition.And(RECORD_CLASSIFY._.PERFORM_PRICE==(model.PERFORM_PRICE));
				}
				if(model.CONTRACT_SIGN_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY._.CONTRACT_SIGN_TIME==(model.CONTRACT_SIGN_TIME));
				}
				if(model.ALL_EXPERT_NUM!=null)
				{
				  condition.And(RECORD_CLASSIFY._.ALL_EXPERT_NUM==(model.ALL_EXPERT_NUM));
				}
				if(model.EXPERT_NUM!=null)
				{
				  condition.And(RECORD_CLASSIFY._.EXPERT_NUM==(model.EXPERT_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATING_METHOD))
				{
				  condition.And(RECORD_CLASSIFY._.EVALUATING_METHOD.Contain(model.EVALUATING_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.SCOPE_CONTRACT_RISK))
				{
				  condition.And(RECORD_CLASSIFY._.SCOPE_CONTRACT_RISK.Contain(model.SCOPE_CONTRACT_RISK));
				}
				if(model.CONTRACT_PRICE!=null)
				{
				  condition.And(RECORD_CLASSIFY._.CONTRACT_PRICE==(model.CONTRACT_PRICE));
				}
				if(model.ADVANCE_CHARGE!=null)
				{
				  condition.And(RECORD_CLASSIFY._.ADVANCE_CHARGE==(model.ADVANCE_CHARGE));
				}
				if(model.PERCENT_PROGERESS!=null)
				{
				  condition.And(RECORD_CLASSIFY._.PERCENT_PROGERESS==(model.PERCENT_PROGERESS));
				}
				if(model.DEFECT_LIABILITY_PERIOD!=null)
				{
				  condition.And(RECORD_CLASSIFY._.DEFECT_LIABILITY_PERIOD==(model.DEFECT_LIABILITY_PERIOD));
				}
				if(model.QUALITY_MARGIN_AMOUNT!=null)
				{
				  condition.And(RECORD_CLASSIFY._.QUALITY_MARGIN_AMOUNT==(model.QUALITY_MARGIN_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_POSTPONE))
				{
				  condition.And(RECORD_CLASSIFY._.IS_POSTPONE.Contain(model.IS_POSTPONE));
				}
				if(model.DEADLINE_BIDDING2!=null)
				{
				  condition.And(RECORD_CLASSIFY._.DEADLINE_BIDDING2==(model.DEADLINE_BIDDING2));
				}
				if(model.POST_OPEN_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY._.POST_OPEN_TIME==(model.POST_OPEN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.POST_OPEN_ADDRESS))
				{
				  condition.And(RECORD_CLASSIFY._.POST_OPEN_ADDRESS.Contain(model.POST_OPEN_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.CLARIFY_TITLE))
				{
				  condition.And(RECORD_CLASSIFY._.CLARIFY_TITLE.Contain(model.CLARIFY_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.CLARIFY_CONTENT))
				{
				  condition.And(RECORD_CLASSIFY._.CLARIFY_CONTENT.Contain(model.CLARIFY_CONTENT));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(RECORD_CLASSIFY._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.CREATOR!=null)
				{
				  condition.And(RECORD_CLASSIFY._.CREATOR==(model.CREATOR));
				}
				if(model.CLARIFY_END_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY._.CLARIFY_END_TIME==(model.CLARIFY_END_TIME));
				}
				if(model.DEPOSIT_END_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY._.DEPOSIT_END_TIME==(model.DEPOSIT_END_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.QUANTITIES_DRAW_UNIT))
				{
				  condition.And(RECORD_CLASSIFY._.QUANTITIES_DRAW_UNIT.Contain(model.QUANTITIES_DRAW_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.QUANTITIES_AUDIT_UNIT))
				{
				  condition.And(RECORD_CLASSIFY._.QUANTITIES_AUDIT_UNIT.Contain(model.QUANTITIES_AUDIT_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTROL_PRICE_DRAW_UNIT))
				{
				  condition.And(RECORD_CLASSIFY._.CONTROL_PRICE_DRAW_UNIT.Contain(model.CONTROL_PRICE_DRAW_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTROL_PRICE_AUDIT_UNIT))
				{
				  condition.And(RECORD_CLASSIFY._.CONTROL_PRICE_AUDIT_UNIT.Contain(model.CONTROL_PRICE_AUDIT_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORM_UNIT))
				{
				  condition.And(RECORD_CLASSIFY._.PERFORM_UNIT.Contain(model.PERFORM_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORM_CURRENCY_CODE))
				{
				  condition.And(RECORD_CLASSIFY._.PERFORM_CURRENCY_CODE.Contain(model.PERFORM_CURRENCY_CODE));
				}
		return condition;
	}
        #endregion
    }
}