using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BidEvaluationExpertDelService : BaseServiceT<BID_EVALUATION_EXPERT_DEL>
    {
        #region 接口实现
        
		public List<BID_EVALUATION_EXPERT_DEL> FindList(BID_EVALUATION_EXPERT_DEL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BID_EVALUATION_EXPERT_DEL> PageList(BID_EVALUATION_EXPERT_DEL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, BID_EVALUATION_EXPERT_DEL._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(BID_EVALUATION_EXPERT_DEL._.M_ID == M_ID);
			
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
        public GeneralResult Edit(BID_EVALUATION_EXPERT_DEL model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is BID_EVALUATION_EXPERT_DEL entity)
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
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_CREATOR=model.M_CREATOR;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_DEL_TM=model.M_DEL_TM;
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
        public GeneralResult Add(BID_EVALUATION_EXPERT_DEL model)
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
                    Delete(BID_EVALUATION_EXPERT_DEL._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BID_EVALUATION_EXPERT_DEL> model)
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
       	protected WhereClipBuilder ConditionBuilder(BID_EVALUATION_EXPERT_DEL model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_TYPE))
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.EXPERT_TYPE.Contain(model.EXPERT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_NAME))
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.EXPERT_NAME.Contain(model.EXPERT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD))
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.ID_CARD.Contain(model.ID_CARD));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD_TYPE))
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.ID_CARD_TYPE.Contain(model.ID_CARD_TYPE));
				}
				if(model.EXPERT_CHECK_IN_TIME!=null)
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.EXPERT_CHECK_IN_TIME==(model.EXPERT_CHECK_IN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_CHAIR_MAN))
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.IS_CHAIR_MAN.Contain(model.IS_CHAIR_MAN));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.M_ID==(model.M_ID));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_DEL_TM!=null)
				{
				  condition.And(BID_EVALUATION_EXPERT_DEL._.M_DEL_TM==(model.M_DEL_TM));
				}
		return condition;
	}
        #endregion
    }
}