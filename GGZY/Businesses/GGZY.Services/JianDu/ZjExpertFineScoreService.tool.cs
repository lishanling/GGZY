using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ZjExpertFineScoreService : BaseServiceT<ZJ_EXPERT_FINE_SCORE>
    {
        #region 接口实现
        
		public List<ZJ_EXPERT_FINE_SCORE> FindList(ZJ_EXPERT_FINE_SCORE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJ_EXPERT_FINE_SCORE> PageList(ZJ_EXPERT_FINE_SCORE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJ_EXPERT_FINE_SCORE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(ZJ_EXPERT_FINE_SCORE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(ZJ_EXPERT_FINE_SCORE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is ZJ_EXPERT_FINE_SCORE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.BEGIN_TIME=model.BEGIN_TIME;
		entity.END_TIME=model.END_TIME;
		entity.EXPERT_ID_CARD=model.EXPERT_ID_CARD;
		entity.BIDDER_NAME=model.BIDDER_NAME;
		entity.BIDDER_ORG_CODE=model.BIDDER_ORG_CODE;
		entity.BIDDER_CREDIT_CODE=model.BIDDER_CREDIT_CODE;
		entity.EVALUATION_TECH_ITEM_NAME=model.EVALUATION_TECH_ITEM_NAME;
		entity.EVALUATION_TECH_ITEM_SCORE=model.EVALUATION_TECH_ITEM_SCORE;
		entity.EVALUATION_TECH_ITEM_WEIGHT=model.EVALUATION_TECH_ITEM_WEIGHT;
		entity.EVALUATION_BIDDER_SCORE=model.EVALUATION_BIDDER_SCORE;
		entity.REASON_SUB_REVIEW=model.REASON_SUB_REVIEW;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_TM=model.M_TM;
		entity.M_CREATE_TM=model.M_CREATE_TM;
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
        public GeneralResult Add(ZJ_EXPERT_FINE_SCORE model)
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
                    Delete(ZJ_EXPERT_FINE_SCORE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJ_EXPERT_FINE_SCORE> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJ_EXPERT_FINE_SCORE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(model.BEGIN_TIME!=null)
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.BEGIN_TIME==(model.BEGIN_TIME));
				}
				if(model.END_TIME!=null)
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.END_TIME==(model.END_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_ID_CARD))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.EXPERT_ID_CARD.Contain(model.EXPERT_ID_CARD));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_NAME))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.BIDDER_NAME.Contain(model.BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_ORG_CODE))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.BIDDER_ORG_CODE.Contain(model.BIDDER_ORG_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_CREDIT_CODE))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.BIDDER_CREDIT_CODE.Contain(model.BIDDER_CREDIT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATION_TECH_ITEM_NAME))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.EVALUATION_TECH_ITEM_NAME.Contain(model.EVALUATION_TECH_ITEM_NAME));
				}
				if(model.EVALUATION_TECH_ITEM_SCORE!=null)
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.EVALUATION_TECH_ITEM_SCORE==(model.EVALUATION_TECH_ITEM_SCORE));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATION_TECH_ITEM_WEIGHT))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.EVALUATION_TECH_ITEM_WEIGHT.Contain(model.EVALUATION_TECH_ITEM_WEIGHT));
				}
				if(model.EVALUATION_BIDDER_SCORE!=null)
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.EVALUATION_BIDDER_SCORE==(model.EVALUATION_BIDDER_SCORE));
				}
				if(!string.IsNullOrWhiteSpace(model.REASON_SUB_REVIEW))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.REASON_SUB_REVIEW.Contain(model.REASON_SUB_REVIEW));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_TM!=null)
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.M_TM==(model.M_TM));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(ZJ_EXPERT_FINE_SCORE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}