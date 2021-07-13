using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ExpertCreditRecordService : BaseServiceT<EXPERT_CREDIT_RECORD>
    {
        #region 接口实现
        
		public List<EXPERT_CREDIT_RECORD> FindList(EXPERT_CREDIT_RECORD model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<EXPERT_CREDIT_RECORD> PageList(EXPERT_CREDIT_RECORD model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, EXPERT_CREDIT_RECORD._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(EXPERT_CREDIT_RECORD._.M_ID == M_ID);
			
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
        public GeneralResult Edit(EXPERT_CREDIT_RECORD model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is EXPERT_CREDIT_RECORD entity)
	{		
		entity.Attach();
		entity.ID_CARD=model.ID_CARD;
		entity.REWARD_PUNISHMENT_TYPE=model.REWARD_PUNISHMENT_TYPE;
		entity.TENDER_PROJECT_NAME=model.TENDER_PROJECT_NAME;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_NAME=model.BID_SECTION_NAME;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.APPROVE_DEPT_NAME=model.APPROVE_DEPT_NAME;
		entity.APPROVE_DEPT_CODE=model.APPROVE_DEPT_CODE;
		entity.VIOLATING_BASIS=model.VIOLATING_BASIS;
		entity.VIOLATING_RESULT=model.VIOLATING_RESULT;
		entity.PULISH_DATE=model.PULISH_DATE;
		entity.CONFINED_ACTION=model.CONFINED_ACTION;
		entity.START_DATE=model.START_DATE;
		entity.END_DATE=model.END_DATE;
		entity.OPERATOR=model.OPERATOR;
		entity.OPERATE_DATE=model.OPERATE_DATE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_ATT_CREDIT_RECORD_DOC=model.M_ATT_CREDIT_RECORD_DOC;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
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
        public GeneralResult Add(EXPERT_CREDIT_RECORD model)
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
                    Delete(EXPERT_CREDIT_RECORD._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<EXPERT_CREDIT_RECORD> model)
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
       	protected WhereClipBuilder ConditionBuilder(EXPERT_CREDIT_RECORD model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ID_CARD))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.ID_CARD.Contain(model.ID_CARD));
				}
				if(!string.IsNullOrWhiteSpace(model.REWARD_PUNISHMENT_TYPE))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.REWARD_PUNISHMENT_TYPE.Contain(model.REWARD_PUNISHMENT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_NAME))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.BID_SECTION_NAME.Contain(model.BID_SECTION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVE_DEPT_NAME))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.APPROVE_DEPT_NAME.Contain(model.APPROVE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVE_DEPT_CODE))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.APPROVE_DEPT_CODE.Contain(model.APPROVE_DEPT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.VIOLATING_BASIS))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.VIOLATING_BASIS.Contain(model.VIOLATING_BASIS));
				}
				if(!string.IsNullOrWhiteSpace(model.VIOLATING_RESULT))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.VIOLATING_RESULT.Contain(model.VIOLATING_RESULT));
				}
				if(model.PULISH_DATE!=null)
				{
				  condition.And(EXPERT_CREDIT_RECORD._.PULISH_DATE==(model.PULISH_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONFINED_ACTION))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.CONFINED_ACTION.Contain(model.CONFINED_ACTION));
				}
				if(model.START_DATE!=null)
				{
				  condition.And(EXPERT_CREDIT_RECORD._.START_DATE==(model.START_DATE));
				}
				if(model.END_DATE!=null)
				{
				  condition.And(EXPERT_CREDIT_RECORD._.END_DATE==(model.END_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.OPERATOR))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.OPERATOR.Contain(model.OPERATOR));
				}
				if(model.OPERATE_DATE!=null)
				{
				  condition.And(EXPERT_CREDIT_RECORD._.OPERATE_DATE==(model.OPERATE_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(EXPERT_CREDIT_RECORD._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(EXPERT_CREDIT_RECORD._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(EXPERT_CREDIT_RECORD._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_CREDIT_RECORD_DOC))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.M_ATT_CREDIT_RECORD_DOC.Contain(model.M_ATT_CREDIT_RECORD_DOC));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(EXPERT_CREDIT_RECORD._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(EXPERT_CREDIT_RECORD._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(EXPERT_CREDIT_RECORD._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(EXPERT_CREDIT_RECORD._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}