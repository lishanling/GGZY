using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class PurchaseProjectService : BaseServiceT<PURCHASE_PROJECT>
    {
        #region 接口实现
        
		public List<PURCHASE_PROJECT> FindList(PURCHASE_PROJECT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PURCHASE_PROJECT> PageList(PURCHASE_PROJECT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PURCHASE_PROJECT._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PURCHASE_PROJECT._.M_ID == M_ID);
			
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
        public GeneralResult Edit(PURCHASE_PROJECT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is PURCHASE_PROJECT entity)
	{		
		entity.Attach();
		entity.PURCHASE_PROJECT_CODE=model.PURCHASE_PROJECT_CODE;
		entity.PURCHASE_PROJECT_NAME=model.PURCHASE_PROJECT_NAME;
		entity.INVEST_PROJECT_CODE=model.INVEST_PROJECT_CODE;
		entity.TENDER_PROJECT_TYPE=model.TENDER_PROJECT_TYPE;
		entity.PURCHASER_NAME=model.PURCHASER_NAME;
		entity.PURCHASER_CODE=model.PURCHASER_CODE;
		entity.PURCHASER_ROLE=model.PURCHASER_ROLE;
		entity.PROGRAM_BUDGET=model.PROGRAM_BUDGET;
		entity.BUDGET_CURRENCY=model.BUDGET_CURRENCY;
		entity.UNIT_BUDGET=model.UNIT_BUDGET;
		entity.IS_PROJECT=model.IS_PROJECT;
		entity.PURCHASER_MODE=model.PURCHASER_MODE;
		entity.PURCHASER_CONTENT=model.PURCHASER_CONTENT;
		entity.PURCHASER_ORGANIZE_FORM=model.PURCHASER_ORGANIZE_FORM;
		entity.PURCHASER_AGENCY_NAME=model.PURCHASER_AGENCY_NAME;
		entity.PURCHASER_AGENCY_CODE=model.PURCHASER_AGENCY_CODE;
		entity.PURCHASER_AGENCY_ROLE=model.PURCHASER_AGENCY_ROLE;
		entity.PURCHASER_AGENCY_CONNECTOR=model.PURCHASER_AGENCY_CONNECTOR;
		entity.PURCHASER_AGENCY_INFORMATION=model.PURCHASER_AGENCY_INFORMATION;
		entity.PURCHASE_SECTION_CODE=model.PURCHASE_SECTION_CODE;
		entity.PURCHASE_SECTION_NAME=model.PURCHASE_SECTION_NAME;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.M_ID=model.M_ID;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.REGION_CODE=model.REGION_CODE;
		entity.RELATE_CODE=model.RELATE_CODE;
		entity.PRICE_FORM_CODE=model.PRICE_FORM_CODE;
		entity.OTHER_PROGRAM_BUDGET=model.OTHER_PROGRAM_BUDGET;
		entity.TRA_PLACE_CODE=model.TRA_PLACE_CODE;
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
        public GeneralResult Add(PURCHASE_PROJECT model)
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
                    Delete(PURCHASE_PROJECT._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PURCHASE_PROJECT> model)
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
       	protected WhereClipBuilder ConditionBuilder(PURCHASE_PROJECT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_PROJECT_CODE))
				{
				  condition.And(PURCHASE_PROJECT._.PURCHASE_PROJECT_CODE.Contain(model.PURCHASE_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_PROJECT_NAME))
				{
				  condition.And(PURCHASE_PROJECT._.PURCHASE_PROJECT_NAME.Contain(model.PURCHASE_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.INVEST_PROJECT_CODE))
				{
				  condition.And(PURCHASE_PROJECT._.INVEST_PROJECT_CODE.Contain(model.INVEST_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
				{
				  condition.And(PURCHASE_PROJECT._.TENDER_PROJECT_TYPE.Contain(model.TENDER_PROJECT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASER_NAME))
				{
				  condition.And(PURCHASE_PROJECT._.PURCHASER_NAME.Contain(model.PURCHASER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASER_CODE))
				{
				  condition.And(PURCHASE_PROJECT._.PURCHASER_CODE.Contain(model.PURCHASER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASER_ROLE))
				{
				  condition.And(PURCHASE_PROJECT._.PURCHASER_ROLE.Contain(model.PURCHASER_ROLE));
				}
				if(model.PROGRAM_BUDGET!=null)
				{
				  condition.And(PURCHASE_PROJECT._.PROGRAM_BUDGET==(model.PROGRAM_BUDGET));
				}
				if(!string.IsNullOrWhiteSpace(model.BUDGET_CURRENCY))
				{
				  condition.And(PURCHASE_PROJECT._.BUDGET_CURRENCY.Contain(model.BUDGET_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIT_BUDGET))
				{
				  condition.And(PURCHASE_PROJECT._.UNIT_BUDGET.Contain(model.UNIT_BUDGET));
				}
				if(model.IS_PROJECT!=null)
				{
				  condition.And(PURCHASE_PROJECT._.IS_PROJECT==(model.IS_PROJECT));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASER_MODE))
				{
				  condition.And(PURCHASE_PROJECT._.PURCHASER_MODE.Contain(model.PURCHASER_MODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASER_CONTENT))
				{
				  condition.And(PURCHASE_PROJECT._.PURCHASER_CONTENT.Contain(model.PURCHASER_CONTENT));
				}
				if(model.PURCHASER_ORGANIZE_FORM!=null)
				{
				  condition.And(PURCHASE_PROJECT._.PURCHASER_ORGANIZE_FORM==(model.PURCHASER_ORGANIZE_FORM));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASER_AGENCY_NAME))
				{
				  condition.And(PURCHASE_PROJECT._.PURCHASER_AGENCY_NAME.Contain(model.PURCHASER_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASER_AGENCY_CODE))
				{
				  condition.And(PURCHASE_PROJECT._.PURCHASER_AGENCY_CODE.Contain(model.PURCHASER_AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASER_AGENCY_ROLE))
				{
				  condition.And(PURCHASE_PROJECT._.PURCHASER_AGENCY_ROLE.Contain(model.PURCHASER_AGENCY_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASER_AGENCY_CONNECTOR))
				{
				  condition.And(PURCHASE_PROJECT._.PURCHASER_AGENCY_CONNECTOR.Contain(model.PURCHASER_AGENCY_CONNECTOR));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASER_AGENCY_INFORMATION))
				{
				  condition.And(PURCHASE_PROJECT._.PURCHASER_AGENCY_INFORMATION.Contain(model.PURCHASER_AGENCY_INFORMATION));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_SECTION_CODE))
				{
				  condition.And(PURCHASE_PROJECT._.PURCHASE_SECTION_CODE.Contain(model.PURCHASE_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_SECTION_NAME))
				{
				  condition.And(PURCHASE_PROJECT._.PURCHASE_SECTION_NAME.Contain(model.PURCHASE_SECTION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(PURCHASE_PROJECT._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(PURCHASE_PROJECT._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(PURCHASE_PROJECT._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(PURCHASE_PROJECT._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(PURCHASE_PROJECT._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(PURCHASE_PROJECT._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(PURCHASE_PROJECT._.M_TM==(model.M_TM));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(PURCHASE_PROJECT._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(model.M_ID!=null)
				{
				  condition.And(PURCHASE_PROJECT._.M_ID==(model.M_ID));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(PURCHASE_PROJECT._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(PURCHASE_PROJECT._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(PURCHASE_PROJECT._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(PURCHASE_PROJECT._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.RELATE_CODE))
				{
				  condition.And(PURCHASE_PROJECT._.RELATE_CODE.Contain(model.RELATE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_FORM_CODE))
				{
				  condition.And(PURCHASE_PROJECT._.PRICE_FORM_CODE.Contain(model.PRICE_FORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_PROGRAM_BUDGET))
				{
				  condition.And(PURCHASE_PROJECT._.OTHER_PROGRAM_BUDGET.Contain(model.OTHER_PROGRAM_BUDGET));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_PLACE_CODE))
				{
				  condition.And(PURCHASE_PROJECT._.TRA_PLACE_CODE.Contain(model.TRA_PLACE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(PURCHASE_PROJECT._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}