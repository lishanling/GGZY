using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SlLetterOfGuaranteeService : BaseServiceT<SL_LETTER_OF_GUARANTEE>
    {
        #region 接口实现
        
		public List<SL_LETTER_OF_GUARANTEE> FindList(SL_LETTER_OF_GUARANTEE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SL_LETTER_OF_GUARANTEE> PageList(SL_LETTER_OF_GUARANTEE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SL_LETTER_OF_GUARANTEE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(SL_LETTER_OF_GUARANTEE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(SL_LETTER_OF_GUARANTEE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is SL_LETTER_OF_GUARANTEE entity)
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
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.BIDDER_NAME=model.BIDDER_NAME;
		entity.BIDDER_ORG_CODE=model.BIDDER_ORG_CODE;
		entity.UNION_ENTERPRISE_NAME=model.UNION_ENTERPRISE_NAME;
		entity.UNION_ORGAN_SET_CODE=model.UNION_ORGAN_SET_CODE;
		entity.GUARANTEE_TYPE=model.GUARANTEE_TYPE;
		entity.GUARANTEE_NO=model.GUARANTEE_NO;
		entity.GUARANTEE_STATUS=model.GUARANTEE_STATUS;
		entity.BENEFICIARY=model.BENEFICIARY;
		entity.INSURER=model.INSURER;
		entity.GUARANTEE_AMOUNT=model.GUARANTEE_AMOUNT;
		entity.GUARANTEE_COST=model.GUARANTEE_COST;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.BEGIN_TIME=model.BEGIN_TIME;
		entity.END_TIME=model.END_TIME;
		entity.PAYMENT_METHOD=model.PAYMENT_METHOD;
		entity.PAYMENT_TIME=model.PAYMENT_TIME;
		entity.LETTER_TIME=model.LETTER_TIME;
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
        public GeneralResult Add(SL_LETTER_OF_GUARANTEE model)
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
                    Delete(SL_LETTER_OF_GUARANTEE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SL_LETTER_OF_GUARANTEE> model)
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
       	protected WhereClipBuilder ConditionBuilder(SL_LETTER_OF_GUARANTEE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.M_TM==(model.M_TM));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_NAME))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.BIDDER_NAME.Contain(model.BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_ORG_CODE))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.BIDDER_ORG_CODE.Contain(model.BIDDER_ORG_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNION_ENTERPRISE_NAME))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.UNION_ENTERPRISE_NAME.Contain(model.UNION_ENTERPRISE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNION_ORGAN_SET_CODE))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.UNION_ORGAN_SET_CODE.Contain(model.UNION_ORGAN_SET_CODE));
				}
				if(model.GUARANTEE_TYPE!=null)
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.GUARANTEE_TYPE==(model.GUARANTEE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.GUARANTEE_NO))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.GUARANTEE_NO.Contain(model.GUARANTEE_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.GUARANTEE_STATUS))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.GUARANTEE_STATUS.Contain(model.GUARANTEE_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.BENEFICIARY))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.BENEFICIARY.Contain(model.BENEFICIARY));
				}
				if(!string.IsNullOrWhiteSpace(model.INSURER))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.INSURER.Contain(model.INSURER));
				}
				if(model.GUARANTEE_AMOUNT!=null)
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.GUARANTEE_AMOUNT==(model.GUARANTEE_AMOUNT));
				}
				if(model.GUARANTEE_COST!=null)
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.GUARANTEE_COST==(model.GUARANTEE_COST));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(model.BEGIN_TIME!=null)
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.BEGIN_TIME==(model.BEGIN_TIME));
				}
				if(model.END_TIME!=null)
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.END_TIME==(model.END_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PAYMENT_METHOD))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.PAYMENT_METHOD.Contain(model.PAYMENT_METHOD));
				}
				if(model.PAYMENT_TIME!=null)
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.PAYMENT_TIME==(model.PAYMENT_TIME));
				}
				if(model.LETTER_TIME!=null)
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.LETTER_TIME==(model.LETTER_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(SL_LETTER_OF_GUARANTEE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}