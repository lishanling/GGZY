using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class PurchaseContractService : BaseServiceT<PURCHASE_CONTRACT>
    {
        #region 接口实现
        
		public List<PURCHASE_CONTRACT> FindList(PURCHASE_CONTRACT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PURCHASE_CONTRACT> PageList(PURCHASE_CONTRACT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PURCHASE_CONTRACT._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PURCHASE_CONTRACT._.M_ID == M_ID);
			
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
        public GeneralResult Edit(PURCHASE_CONTRACT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is PURCHASE_CONTRACT entity)
	{		
		entity.Attach();
		entity.PURCHASE_PROJECT_CODE=model.PURCHASE_PROJECT_CODE;
		entity.PURCHASE_PROJECT_NAME=model.PURCHASE_PROJECT_NAME;
		entity.PURCHASE_SECTION_CODE=model.PURCHASE_SECTION_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.PURCHASER_NAME=model.PURCHASER_NAME;
		entity.PURCHASER_CODE=model.PURCHASER_CODE;
		entity.LEGAL_ROLE=model.LEGAL_ROLE;
		entity.SUPPLIER_NAME=model.SUPPLIER_NAME;
		entity.SUPPLIER_CODE=model.SUPPLIER_CODE;
		entity.CONTRACT_AMOUNT=model.CONTRACT_AMOUNT;
		entity.CURRENCY_CODE=model.CURRENCY_CODE;
		entity.PRICE_UNIT=model.PRICE_UNIT;
		entity.CONTRACT_TERM=model.CONTRACT_TERM;
		entity.SIGNING_TIME=model.SIGNING_TIME;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.CONTRACT_NAME=model.CONTRACT_NAME;
		entity.URL=model.URL;
		entity.M_ID=model.M_ID;
		entity.M_ATT_CONTRACT=model.M_ATT_CONTRACT;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.PRICE_FORM_CODE=model.PRICE_FORM_CODE;
		entity.WIN_BID_RATE=model.WIN_BID_RATE;
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
        public GeneralResult Add(PURCHASE_CONTRACT model)
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
                    Delete(PURCHASE_CONTRACT._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PURCHASE_CONTRACT> model)
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
       	protected WhereClipBuilder ConditionBuilder(PURCHASE_CONTRACT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_PROJECT_CODE))
				{
				  condition.And(PURCHASE_CONTRACT._.PURCHASE_PROJECT_CODE.Contain(model.PURCHASE_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_PROJECT_NAME))
				{
				  condition.And(PURCHASE_CONTRACT._.PURCHASE_PROJECT_NAME.Contain(model.PURCHASE_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_SECTION_CODE))
				{
				  condition.And(PURCHASE_CONTRACT._.PURCHASE_SECTION_CODE.Contain(model.PURCHASE_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(PURCHASE_CONTRACT._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASER_NAME))
				{
				  condition.And(PURCHASE_CONTRACT._.PURCHASER_NAME.Contain(model.PURCHASER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASER_CODE))
				{
				  condition.And(PURCHASE_CONTRACT._.PURCHASER_CODE.Contain(model.PURCHASER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_ROLE))
				{
				  condition.And(PURCHASE_CONTRACT._.LEGAL_ROLE.Contain(model.LEGAL_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPPLIER_NAME))
				{
				  condition.And(PURCHASE_CONTRACT._.SUPPLIER_NAME.Contain(model.SUPPLIER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPPLIER_CODE))
				{
				  condition.And(PURCHASE_CONTRACT._.SUPPLIER_CODE.Contain(model.SUPPLIER_CODE));
				}
				if(model.CONTRACT_AMOUNT!=null)
				{
				  condition.And(PURCHASE_CONTRACT._.CONTRACT_AMOUNT==(model.CONTRACT_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.CURRENCY_CODE))
				{
				  condition.And(PURCHASE_CONTRACT._.CURRENCY_CODE.Contain(model.CURRENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_UNIT))
				{
				  condition.And(PURCHASE_CONTRACT._.PRICE_UNIT.Contain(model.PRICE_UNIT));
				}
				if(model.CONTRACT_TERM!=null)
				{
				  condition.And(PURCHASE_CONTRACT._.CONTRACT_TERM==(model.CONTRACT_TERM));
				}
				if(model.SIGNING_TIME!=null)
				{
				  condition.And(PURCHASE_CONTRACT._.SIGNING_TIME==(model.SIGNING_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(PURCHASE_CONTRACT._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(PURCHASE_CONTRACT._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(PURCHASE_CONTRACT._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(PURCHASE_CONTRACT._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(PURCHASE_CONTRACT._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(PURCHASE_CONTRACT._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_NAME))
				{
				  condition.And(PURCHASE_CONTRACT._.CONTRACT_NAME.Contain(model.CONTRACT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(PURCHASE_CONTRACT._.URL.Contain(model.URL));
				}
				if(model.M_ID!=null)
				{
				  condition.And(PURCHASE_CONTRACT._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_CONTRACT))
				{
				  condition.And(PURCHASE_CONTRACT._.M_ATT_CONTRACT.Contain(model.M_ATT_CONTRACT));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(PURCHASE_CONTRACT._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(PURCHASE_CONTRACT._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(PURCHASE_CONTRACT._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_FORM_CODE))
				{
				  condition.And(PURCHASE_CONTRACT._.PRICE_FORM_CODE.Contain(model.PRICE_FORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BID_RATE))
				{
				  condition.And(PURCHASE_CONTRACT._.WIN_BID_RATE.Contain(model.WIN_BID_RATE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(PURCHASE_CONTRACT._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}