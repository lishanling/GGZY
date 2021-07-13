using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class RecordClassifyNormalService : BaseServiceT<RECORD_CLASSIFY_NORMAL>
    {
        #region 接口实现
        
		public List<RECORD_CLASSIFY_NORMAL> FindList(RECORD_CLASSIFY_NORMAL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<RECORD_CLASSIFY_NORMAL> PageList(RECORD_CLASSIFY_NORMAL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, RECORD_CLASSIFY_NORMAL._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(RECORD_CLASSIFY_NORMAL._.RECORD_ID == RECORD_ID);
			
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
        public GeneralResult Edit(RECORD_CLASSIFY_NORMAL model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.RECORD_ID);
	
	if(viewResult.Success  && viewResult.Data is RECORD_CLASSIFY_NORMAL entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.RECORD_ID=model.RECORD_ID;
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
		entity.IS_POSTPONE=model.IS_POSTPONE;
		entity.DEADLINE_BIDDING2=model.DEADLINE_BIDDING2;
		entity.POST_OPEN_TIME=model.POST_OPEN_TIME;
		entity.POST_OPEN_ADDRESS=model.POST_OPEN_ADDRESS;
		entity.CLARIFY_END_TIME=model.CLARIFY_END_TIME;
		entity.DEPOSIT_END_TIME=model.DEPOSIT_END_TIME;
		entity.CLARIFY_TITLE=model.CLARIFY_TITLE;
		entity.CLARIFY_CONTENT=model.CLARIFY_CONTENT;
		entity.CREATE_TM=model.CREATE_TM;
		entity.CREATOR=model.CREATOR;
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
        public GeneralResult Add(RECORD_CLASSIFY_NORMAL model)
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
                    Delete(RECORD_CLASSIFY_NORMAL._.RECORD_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<RECORD_CLASSIFY_NORMAL> model)
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
       	protected WhereClipBuilder ConditionBuilder(RECORD_CLASSIFY_NORMAL model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.ID==(model.ID));
				}
				if(model.RECORD_ID!=null)
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.RECORD_ID==(model.RECORD_ID));
				}
				if(model.TENDER_DOC_GET_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.TENDER_DOC_GET_TIME==(model.TENDER_DOC_GET_TIME));
				}
				if(model.DOC_GET_END_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.DOC_GET_END_TIME==(model.DOC_GET_END_TIME));
				}
				if(model.BID_DOC_REFER_END_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.BID_DOC_REFER_END_TIME==(model.BID_DOC_REFER_END_TIME));
				}
				if(model.BID_OPEN_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.BID_OPEN_TIME==(model.BID_OPEN_TIME));
				}
				if(model.DOC_PRICE!=null)
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.DOC_PRICE==(model.DOC_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.DOC_PRICE_CURRENCY))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.DOC_PRICE_CURRENCY.Contain(model.DOC_PRICE_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.DOC_PRICE_UNIT))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.DOC_PRICE_UNIT.Contain(model.DOC_PRICE_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.SYNDICATED_FLAG))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.SYNDICATED_FLAG.Contain(model.SYNDICATED_FLAG));
				}
				if(!string.IsNullOrWhiteSpace(model.SYNDICATED_REQUIRE))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.SYNDICATED_REQUIRE.Contain(model.SYNDICATED_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.SIMILAR_PROJECT_BASIC))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.SIMILAR_PROJECT_BASIC.Contain(model.SIMILAR_PROJECT_BASIC));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_QUALIFICATION))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.BID_QUALIFICATION.Contain(model.BID_QUALIFICATION));
				}
				if(model.VALID_PERIOD!=null)
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.VALID_PERIOD==(model.VALID_PERIOD));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_DOC_REFER_METHOD))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.BID_DOC_REFER_METHOD.Contain(model.BID_DOC_REFER_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_PAY_TYPE))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.MARGIN_PAY_TYPE.Contain(model.MARGIN_PAY_TYPE));
				}
				if(model.MARGIN_AMOUNT!=null)
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.MARGIN_AMOUNT==(model.MARGIN_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_UNIT))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.MARGIN_UNIT.Contain(model.MARGIN_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_CURRENCY_CODE))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.MARGIN_CURRENCY_CODE.Contain(model.MARGIN_CURRENCY_CODE));
				}
				if(model.CONTROL_PRICE!=null)
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.CONTROL_PRICE==(model.CONTROL_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTROL_UNIT))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.CONTROL_UNIT.Contain(model.CONTROL_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTROL_CURRENCY_CODE))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.CONTROL_CURRENCY_CODE.Contain(model.CONTROL_CURRENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATING_METHOD))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.EVALUATING_METHOD.Contain(model.EVALUATING_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_OPEN_PLACE))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.BID_OPEN_PLACE.Contain(model.BID_OPEN_PLACE));
				}
				if(model.CLARIFY_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.CLARIFY_TIME==(model.CLARIFY_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_NOTICE))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.TENDER_NOTICE.Contain(model.TENDER_NOTICE));
				}
				if(!string.IsNullOrWhiteSpace(model.QUAL_TYPE))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.QUAL_TYPE.Contain(model.QUAL_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_POSTPONE))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.IS_POSTPONE.Contain(model.IS_POSTPONE));
				}
				if(model.DEADLINE_BIDDING2!=null)
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.DEADLINE_BIDDING2==(model.DEADLINE_BIDDING2));
				}
				if(model.POST_OPEN_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.POST_OPEN_TIME==(model.POST_OPEN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.POST_OPEN_ADDRESS))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.POST_OPEN_ADDRESS.Contain(model.POST_OPEN_ADDRESS));
				}
				if(model.CLARIFY_END_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.CLARIFY_END_TIME==(model.CLARIFY_END_TIME));
				}
				if(model.DEPOSIT_END_TIME!=null)
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.DEPOSIT_END_TIME==(model.DEPOSIT_END_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.CLARIFY_TITLE))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.CLARIFY_TITLE.Contain(model.CLARIFY_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.CLARIFY_CONTENT))
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.CLARIFY_CONTENT.Contain(model.CLARIFY_CONTENT));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.CREATOR!=null)
				{
				  condition.And(RECORD_CLASSIFY_NORMAL._.CREATOR==(model.CREATOR));
				}
		return condition;
	}
        #endregion
    }
}