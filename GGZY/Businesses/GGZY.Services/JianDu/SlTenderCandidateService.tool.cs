using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SlTenderCandidateService : BaseServiceT<SL_TENDER_CANDIDATE>
    {
        #region 接口实现
        
		public List<SL_TENDER_CANDIDATE> FindList(SL_TENDER_CANDIDATE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SL_TENDER_CANDIDATE> PageList(SL_TENDER_CANDIDATE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SL_TENDER_CANDIDATE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(SL_TENDER_CANDIDATE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(SL_TENDER_CANDIDATE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is SL_TENDER_CANDIDATE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.WIN_CANDIDATE_NAME=model.WIN_CANDIDATE_NAME;
		entity.BIDDER_CODE_TYPE=model.BIDDER_CODE_TYPE;
		entity.WIN_CANDIDATE_CODE=model.WIN_CANDIDATE_CODE;
		entity.BIDDER_ROLE=model.BIDDER_ROLE;
		entity.WIN_CANDIDATE_ORDER=model.WIN_CANDIDATE_ORDER;
		entity.IS_FLOAT_RATE=model.IS_FLOAT_RATE;
		entity.EVALUATION_RESULT=model.EVALUATION_RESULT;
		entity.BID_PRICE=model.BID_PRICE;
		entity.EVALUATION_PRICE=model.EVALUATION_PRICE;
		entity.WIN_PRICE=model.WIN_PRICE;
		entity.PRICE_CURRENCY=model.PRICE_CURRENCY;
		entity.PRICE_UINT=model.PRICE_UINT;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
		entity.OTHER_BID_PRICE=model.OTHER_BID_PRICE;
		entity.QUALITY=model.QUALITY;
		entity.EVALUATION_STATUS=model.EVALUATION_STATUS;
		entity.WIN_CANDIDATE_QUALIFICATION=model.WIN_CANDIDATE_QUALIFICATION;
		entity.PRICE_FORM_CODE=model.PRICE_FORM_CODE;
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
        public GeneralResult Add(SL_TENDER_CANDIDATE model)
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
                    Delete(SL_TENDER_CANDIDATE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SL_TENDER_CANDIDATE> model)
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
       	protected WhereClipBuilder ConditionBuilder(SL_TENDER_CANDIDATE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(SL_TENDER_CANDIDATE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(SL_TENDER_CANDIDATE._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(SL_TENDER_CANDIDATE._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_CANDIDATE_NAME))
				{
				  condition.And(SL_TENDER_CANDIDATE._.WIN_CANDIDATE_NAME.Contain(model.WIN_CANDIDATE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_CODE_TYPE))
				{
				  condition.And(SL_TENDER_CANDIDATE._.BIDDER_CODE_TYPE.Contain(model.BIDDER_CODE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_CANDIDATE_CODE))
				{
				  condition.And(SL_TENDER_CANDIDATE._.WIN_CANDIDATE_CODE.Contain(model.WIN_CANDIDATE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_ROLE))
				{
				  condition.And(SL_TENDER_CANDIDATE._.BIDDER_ROLE.Contain(model.BIDDER_ROLE));
				}
				if(model.WIN_CANDIDATE_ORDER!=null)
				{
				  condition.And(SL_TENDER_CANDIDATE._.WIN_CANDIDATE_ORDER==(model.WIN_CANDIDATE_ORDER));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_FLOAT_RATE))
				{
				  condition.And(SL_TENDER_CANDIDATE._.IS_FLOAT_RATE.Contain(model.IS_FLOAT_RATE));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATION_RESULT))
				{
				  condition.And(SL_TENDER_CANDIDATE._.EVALUATION_RESULT.Contain(model.EVALUATION_RESULT));
				}
				if(model.BID_PRICE!=null)
				{
				  condition.And(SL_TENDER_CANDIDATE._.BID_PRICE==(model.BID_PRICE));
				}
				if(model.EVALUATION_PRICE!=null)
				{
				  condition.And(SL_TENDER_CANDIDATE._.EVALUATION_PRICE==(model.EVALUATION_PRICE));
				}
				if(model.WIN_PRICE!=null)
				{
				  condition.And(SL_TENDER_CANDIDATE._.WIN_PRICE==(model.WIN_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_CURRENCY))
				{
				  condition.And(SL_TENDER_CANDIDATE._.PRICE_CURRENCY.Contain(model.PRICE_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_UINT))
				{
				  condition.And(SL_TENDER_CANDIDATE._.PRICE_UINT.Contain(model.PRICE_UINT));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(SL_TENDER_CANDIDATE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(SL_TENDER_CANDIDATE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(SL_TENDER_CANDIDATE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(SL_TENDER_CANDIDATE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(SL_TENDER_CANDIDATE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(SL_TENDER_CANDIDATE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(SL_TENDER_CANDIDATE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(SL_TENDER_CANDIDATE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(SL_TENDER_CANDIDATE._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_BID_PRICE))
				{
				  condition.And(SL_TENDER_CANDIDATE._.OTHER_BID_PRICE.Contain(model.OTHER_BID_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALITY))
				{
				  condition.And(SL_TENDER_CANDIDATE._.QUALITY.Contain(model.QUALITY));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATION_STATUS))
				{
				  condition.And(SL_TENDER_CANDIDATE._.EVALUATION_STATUS.Contain(model.EVALUATION_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_CANDIDATE_QUALIFICATION))
				{
				  condition.And(SL_TENDER_CANDIDATE._.WIN_CANDIDATE_QUALIFICATION.Contain(model.WIN_CANDIDATE_QUALIFICATION));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_FORM_CODE))
				{
				  condition.And(SL_TENDER_CANDIDATE._.PRICE_FORM_CODE.Contain(model.PRICE_FORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(SL_TENDER_CANDIDATE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(SL_TENDER_CANDIDATE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(SL_TENDER_CANDIDATE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}