using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class PerformanceInfoService : BaseServiceT<PERFORMANCE_INFO>
    {
        #region 接口实现
        
		public List<PERFORMANCE_INFO> FindList(PERFORMANCE_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PERFORMANCE_INFO> PageList(PERFORMANCE_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PERFORMANCE_INFO._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PERFORMANCE_INFO._.M_ID == M_ID);
			
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
        public GeneralResult Edit(PERFORMANCE_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is PERFORMANCE_INFO entity)
	{		
		entity.Attach();
		entity.BODY_CODE=model.BODY_CODE;
		entity.BODY_NAME=model.BODY_NAME;
		entity.BODY_TYPE=model.BODY_TYPE;
		entity.BODY_ROLE=model.BODY_ROLE;
		entity.TENDER_PROJECT_NAME=model.TENDER_PROJECT_NAME;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.BID_SECTION_NAME=model.BID_SECTION_NAME;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.CONTRACT_AMOUNT=model.CONTRACT_AMOUNT;
		entity.CONTRACT_CURRENCY=model.CONTRACT_CURRENCY;
		entity.CONTRACT_CURRENCYUNIT=model.CONTRACT_CURRENCYUNIT;
		entity.CONTRACT_PERIOD=model.CONTRACT_PERIOD;
		entity.CONTRACT_SIGNING_TIME=model.CONTRACT_SIGNING_TIME;
		entity.QUALITY_STANDARDS=model.QUALITY_STANDARDS;
		entity.SAFETY_STANDARDS=model.SAFETY_STANDARDS;
		entity.ENVIRONMENT_STANDARDS=model.ENVIRONMENT_STANDARDS;
		entity.CONSTRUCTION_PERIOD=model.CONSTRUCTION_PERIOD;
		entity.CONTRACT_SETTLEMENT_AMOUNT=model.CONTRACT_SETTLEMENT_AMOUNT;
		entity.CONTRACT_FINISH_TIME=model.CONTRACT_FINISH_TIME;
		entity.PERFORMANCE_SUBMITTED_TIME=model.PERFORMANCE_SUBMITTED_TIME;
		entity.GOVERNMENT=model.GOVERNMENT;
		entity.DOCUMENT_CODE=model.DOCUMENT_CODE;
		entity.SCOPE=model.SCOPE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_ATT_PERFORMANCE_DOC=model.M_ATT_PERFORMANCE_DOC;
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
        public GeneralResult Add(PERFORMANCE_INFO model)
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
                    Delete(PERFORMANCE_INFO._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PERFORMANCE_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(PERFORMANCE_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.BODY_CODE))
				{
				  condition.And(PERFORMANCE_INFO._.BODY_CODE.Contain(model.BODY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_NAME))
				{
				  condition.And(PERFORMANCE_INFO._.BODY_NAME.Contain(model.BODY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_TYPE))
				{
				  condition.And(PERFORMANCE_INFO._.BODY_TYPE.Contain(model.BODY_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_ROLE))
				{
				  condition.And(PERFORMANCE_INFO._.BODY_ROLE.Contain(model.BODY_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(PERFORMANCE_INFO._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(PERFORMANCE_INFO._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(PERFORMANCE_INFO._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_NAME))
				{
				  condition.And(PERFORMANCE_INFO._.BID_SECTION_NAME.Contain(model.BID_SECTION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(PERFORMANCE_INFO._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(model.CONTRACT_AMOUNT!=null)
				{
				  condition.And(PERFORMANCE_INFO._.CONTRACT_AMOUNT==(model.CONTRACT_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_CURRENCY))
				{
				  condition.And(PERFORMANCE_INFO._.CONTRACT_CURRENCY.Contain(model.CONTRACT_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_CURRENCYUNIT))
				{
				  condition.And(PERFORMANCE_INFO._.CONTRACT_CURRENCYUNIT.Contain(model.CONTRACT_CURRENCYUNIT));
				}
				if(model.CONTRACT_PERIOD!=null)
				{
				  condition.And(PERFORMANCE_INFO._.CONTRACT_PERIOD==(model.CONTRACT_PERIOD));
				}
				if(model.CONTRACT_SIGNING_TIME!=null)
				{
				  condition.And(PERFORMANCE_INFO._.CONTRACT_SIGNING_TIME==(model.CONTRACT_SIGNING_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALITY_STANDARDS))
				{
				  condition.And(PERFORMANCE_INFO._.QUALITY_STANDARDS.Contain(model.QUALITY_STANDARDS));
				}
				if(!string.IsNullOrWhiteSpace(model.SAFETY_STANDARDS))
				{
				  condition.And(PERFORMANCE_INFO._.SAFETY_STANDARDS.Contain(model.SAFETY_STANDARDS));
				}
				if(!string.IsNullOrWhiteSpace(model.ENVIRONMENT_STANDARDS))
				{
				  condition.And(PERFORMANCE_INFO._.ENVIRONMENT_STANDARDS.Contain(model.ENVIRONMENT_STANDARDS));
				}
				if(model.CONSTRUCTION_PERIOD!=null)
				{
				  condition.And(PERFORMANCE_INFO._.CONSTRUCTION_PERIOD==(model.CONSTRUCTION_PERIOD));
				}
				if(model.CONTRACT_SETTLEMENT_AMOUNT!=null)
				{
				  condition.And(PERFORMANCE_INFO._.CONTRACT_SETTLEMENT_AMOUNT==(model.CONTRACT_SETTLEMENT_AMOUNT));
				}
				if(model.CONTRACT_FINISH_TIME!=null)
				{
				  condition.And(PERFORMANCE_INFO._.CONTRACT_FINISH_TIME==(model.CONTRACT_FINISH_TIME));
				}
				if(model.PERFORMANCE_SUBMITTED_TIME!=null)
				{
				  condition.And(PERFORMANCE_INFO._.PERFORMANCE_SUBMITTED_TIME==(model.PERFORMANCE_SUBMITTED_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.GOVERNMENT))
				{
				  condition.And(PERFORMANCE_INFO._.GOVERNMENT.Contain(model.GOVERNMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.DOCUMENT_CODE))
				{
				  condition.And(PERFORMANCE_INFO._.DOCUMENT_CODE.Contain(model.DOCUMENT_CODE));
				}
				if(model.SCOPE!=null)
				{
				  condition.And(PERFORMANCE_INFO._.SCOPE==(model.SCOPE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(PERFORMANCE_INFO._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(PERFORMANCE_INFO._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(PERFORMANCE_INFO._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(PERFORMANCE_INFO._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(PERFORMANCE_INFO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(PERFORMANCE_INFO._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(PERFORMANCE_INFO._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PERFORMANCE_DOC))
				{
				  condition.And(PERFORMANCE_INFO._.M_ATT_PERFORMANCE_DOC.Contain(model.M_ATT_PERFORMANCE_DOC));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(PERFORMANCE_INFO._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(PERFORMANCE_INFO._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(PERFORMANCE_INFO._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(PERFORMANCE_INFO._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}