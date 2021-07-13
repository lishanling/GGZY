using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ZjBidEvaluationExpertService : BaseServiceT<ZJ_BID_EVALUATION_EXPERT>
    {
        #region 接口实现
        
		public List<ZJ_BID_EVALUATION_EXPERT> FindList(ZJ_BID_EVALUATION_EXPERT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJ_BID_EVALUATION_EXPERT> PageList(ZJ_BID_EVALUATION_EXPERT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJ_BID_EVALUATION_EXPERT._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(ZJ_BID_EVALUATION_EXPERT._.M_ID == M_ID);
			
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
        public GeneralResult Edit(ZJ_BID_EVALUATION_EXPERT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is ZJ_BID_EVALUATION_EXPERT entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.EXPERT_TYPE=model.EXPERT_TYPE;
		entity.EXPERT_NAME=model.EXPERT_NAME;
		entity.ID_CARD=model.ID_CARD;
		entity.ID_CARD_TYPE=model.ID_CARD_TYPE;
		entity.EXPERT_CHECK_IN_TIME=model.EXPERT_CHECK_IN_TIME;
		entity.IS_CHAIR_MAN=model.IS_CHAIR_MAN;
		entity.IS_INVALID_SCORE=model.IS_INVALID_SCORE;
		entity.IS_TENDER_AGENT=model.IS_TENDER_AGENT;
		entity.IS_ECONOMICAL_EXPERT=model.IS_ECONOMICAL_EXPERT;
		entity.IS_TECHNOLOGICAL_EXPERT=model.IS_TECHNOLOGICAL_EXPERT;
		entity.SCORE=model.SCORE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_TM=model.M_TM;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_ATT_QUALIFI_EXAMINATION_DOC=model.M_ATT_QUALIFI_EXAMINATION_DOC;
		entity.M_ATT_TECHNICAL_REVIEW_DOC=model.M_ATT_TECHNICAL_REVIEW_DOC;
		entity.M_ATT_BUS_PRE_REVIEW_DOC=model.M_ATT_BUS_PRE_REVIEW_DOC;
		entity.M_ATT_BUS_DETAILED_REVIEW_DOC=model.M_ATT_BUS_DETAILED_REVIEW_DOC;
		entity.M_ATT_CREDIT_REVIEW_DOC=model.M_ATT_CREDIT_REVIEW_DOC;
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
        public GeneralResult Add(ZJ_BID_EVALUATION_EXPERT model)
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
                    Delete(ZJ_BID_EVALUATION_EXPERT._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJ_BID_EVALUATION_EXPERT> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJ_BID_EVALUATION_EXPERT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_TYPE))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.EXPERT_TYPE.Contain(model.EXPERT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_NAME))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.EXPERT_NAME.Contain(model.EXPERT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.ID_CARD.Contain(model.ID_CARD));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD_TYPE))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.ID_CARD_TYPE.Contain(model.ID_CARD_TYPE));
				}
				if(model.EXPERT_CHECK_IN_TIME!=null)
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.EXPERT_CHECK_IN_TIME==(model.EXPERT_CHECK_IN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_CHAIR_MAN))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.IS_CHAIR_MAN.Contain(model.IS_CHAIR_MAN));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_INVALID_SCORE))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.IS_INVALID_SCORE.Contain(model.IS_INVALID_SCORE));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_TENDER_AGENT))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.IS_TENDER_AGENT.Contain(model.IS_TENDER_AGENT));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_ECONOMICAL_EXPERT))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.IS_ECONOMICAL_EXPERT.Contain(model.IS_ECONOMICAL_EXPERT));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_TECHNOLOGICAL_EXPERT))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.IS_TECHNOLOGICAL_EXPERT.Contain(model.IS_TECHNOLOGICAL_EXPERT));
				}
				if(!string.IsNullOrWhiteSpace(model.SCORE))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.SCORE.Contain(model.SCORE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_TM!=null)
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.M_TM==(model.M_TM));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_QUALIFI_EXAMINATION_DOC))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.M_ATT_QUALIFI_EXAMINATION_DOC.Contain(model.M_ATT_QUALIFI_EXAMINATION_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TECHNICAL_REVIEW_DOC))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.M_ATT_TECHNICAL_REVIEW_DOC.Contain(model.M_ATT_TECHNICAL_REVIEW_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_BUS_PRE_REVIEW_DOC))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.M_ATT_BUS_PRE_REVIEW_DOC.Contain(model.M_ATT_BUS_PRE_REVIEW_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_BUS_DETAILED_REVIEW_DOC))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.M_ATT_BUS_DETAILED_REVIEW_DOC.Contain(model.M_ATT_BUS_DETAILED_REVIEW_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_CREDIT_REVIEW_DOC))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.M_ATT_CREDIT_REVIEW_DOC.Contain(model.M_ATT_CREDIT_REVIEW_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(ZJ_BID_EVALUATION_EXPERT._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}