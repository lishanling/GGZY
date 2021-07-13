using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TenderListService : BaseServiceT<TENDER_LIST>
    {
        #region 接口实现
        
		public List<TENDER_LIST> FindList(TENDER_LIST model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TENDER_LIST> PageList(TENDER_LIST model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, TENDER_LIST._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(TENDER_LIST._.M_ID == M_ID);
			
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
        public GeneralResult Edit(TENDER_LIST model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is TENDER_LIST entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.BIDDER_NAME=model.BIDDER_NAME;
		entity.BIDDER_CODE_TYPE=model.BIDDER_CODE_TYPE;
		entity.BIDDER_ORG_CODE=model.BIDDER_ORG_CODE;
		entity.BIDDER_ROLE=model.BIDDER_ROLE;
		entity.BID_MANAGER=model.BID_MANAGER;
		entity.BID_DOC_DOWNLOAD_TIME=model.BID_DOC_DOWNLOAD_TIME;
		entity.MARGIN_PAY_FORM=model.MARGIN_PAY_FORM;
		entity.MARGIN_RECEIVE_TIME=model.MARGIN_RECEIVE_TIME;
		entity.UNION_ENTERPRISE_NAME=model.UNION_ENTERPRISE_NAME;
		entity.UNION_ORGAN_SET_CODE=model.UNION_ORGAN_SET_CODE;
		entity.UNION_CONTACT_NAME=model.UNION_CONTACT_NAME;
		entity.UNION_CONTACT_PHONE=model.UNION_CONTACT_PHONE;
		entity.BIDDER_INFO_VERSION=model.BIDDER_INFO_VERSION;
		entity.BID_PRICE=model.BID_PRICE;
		entity.PRICE_CURRENCY=model.PRICE_CURRENCY;
		entity.PRICE_UNIT=model.PRICE_UNIT;
		entity.TIME_LIMIT=model.TIME_LIMIT;
		entity.CHECKIN_TIME=model.CHECKIN_TIME;
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
		entity.M_MONEY_UPDATE=model.M_MONEY_UPDATE;
		entity.TEST1=model.TEST1;
		entity.TEST2=model.TEST2;
		entity.PM_CODE=model.PM_CODE;
		entity.PM_CERTIFICATES=model.PM_CERTIFICATES;
		entity.IS_LOST=model.IS_LOST;
		entity.PRICE_FORM_CODE=model.PRICE_FORM_CODE;
		entity.OTHER_BID_PRICE=model.OTHER_BID_PRICE;
		entity.TRADE_PLAT=model.TRADE_PLAT;
		entity.PUB_SERVICE_PLAT=model.PUB_SERVICE_PLAT;
		entity.M_VERSION=model.M_VERSION;
		entity.IS_COMMIT_MARGIN=model.IS_COMMIT_MARGIN;
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
        public GeneralResult Add(TENDER_LIST model)
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
                    Delete(TENDER_LIST._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<TENDER_LIST> model)
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
       	protected WhereClipBuilder ConditionBuilder(TENDER_LIST model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(TENDER_LIST._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(TENDER_LIST._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(TENDER_LIST._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_NAME))
				{
				  condition.And(TENDER_LIST._.BIDDER_NAME.Contain(model.BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_CODE_TYPE))
				{
				  condition.And(TENDER_LIST._.BIDDER_CODE_TYPE.Contain(model.BIDDER_CODE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_ORG_CODE))
				{
				  condition.And(TENDER_LIST._.BIDDER_ORG_CODE.Contain(model.BIDDER_ORG_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_ROLE))
				{
				  condition.And(TENDER_LIST._.BIDDER_ROLE.Contain(model.BIDDER_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_MANAGER))
				{
				  condition.And(TENDER_LIST._.BID_MANAGER.Contain(model.BID_MANAGER));
				}
				if(model.BID_DOC_DOWNLOAD_TIME!=null)
				{
				  condition.And(TENDER_LIST._.BID_DOC_DOWNLOAD_TIME==(model.BID_DOC_DOWNLOAD_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_PAY_FORM))
				{
				  condition.And(TENDER_LIST._.MARGIN_PAY_FORM.Contain(model.MARGIN_PAY_FORM));
				}
				if(model.MARGIN_RECEIVE_TIME!=null)
				{
				  condition.And(TENDER_LIST._.MARGIN_RECEIVE_TIME==(model.MARGIN_RECEIVE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNION_ENTERPRISE_NAME))
				{
				  condition.And(TENDER_LIST._.UNION_ENTERPRISE_NAME.Contain(model.UNION_ENTERPRISE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNION_ORGAN_SET_CODE))
				{
				  condition.And(TENDER_LIST._.UNION_ORGAN_SET_CODE.Contain(model.UNION_ORGAN_SET_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNION_CONTACT_NAME))
				{
				  condition.And(TENDER_LIST._.UNION_CONTACT_NAME.Contain(model.UNION_CONTACT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNION_CONTACT_PHONE))
				{
				  condition.And(TENDER_LIST._.UNION_CONTACT_PHONE.Contain(model.UNION_CONTACT_PHONE));
				}
				if(model.BIDDER_INFO_VERSION!=null)
				{
				  condition.And(TENDER_LIST._.BIDDER_INFO_VERSION==(model.BIDDER_INFO_VERSION));
				}
				if(model.BID_PRICE!=null)
				{
				  condition.And(TENDER_LIST._.BID_PRICE==(model.BID_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_CURRENCY))
				{
				  condition.And(TENDER_LIST._.PRICE_CURRENCY.Contain(model.PRICE_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_UNIT))
				{
				  condition.And(TENDER_LIST._.PRICE_UNIT.Contain(model.PRICE_UNIT));
				}
				if(model.TIME_LIMIT!=null)
				{
				  condition.And(TENDER_LIST._.TIME_LIMIT==(model.TIME_LIMIT));
				}
				if(model.CHECKIN_TIME!=null)
				{
				  condition.And(TENDER_LIST._.CHECKIN_TIME==(model.CHECKIN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(TENDER_LIST._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(TENDER_LIST._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(TENDER_LIST._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(TENDER_LIST._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(TENDER_LIST._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(TENDER_LIST._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(TENDER_LIST._.M_ID==(model.M_ID));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(TENDER_LIST._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(TENDER_LIST._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(TENDER_LIST._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(TENDER_LIST._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_MONEY_UPDATE))
				{
				  condition.And(TENDER_LIST._.M_MONEY_UPDATE.Contain(model.M_MONEY_UPDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.TEST1))
				{
				  condition.And(TENDER_LIST._.TEST1.Contain(model.TEST1));
				}
				if(!string.IsNullOrWhiteSpace(model.TEST2))
				{
				  condition.And(TENDER_LIST._.TEST2.Contain(model.TEST2));
				}
				if(!string.IsNullOrWhiteSpace(model.PM_CODE))
				{
				  condition.And(TENDER_LIST._.PM_CODE.Contain(model.PM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PM_CERTIFICATES))
				{
				  condition.And(TENDER_LIST._.PM_CERTIFICATES.Contain(model.PM_CERTIFICATES));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_LOST))
				{
				  condition.And(TENDER_LIST._.IS_LOST.Contain(model.IS_LOST));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_FORM_CODE))
				{
				  condition.And(TENDER_LIST._.PRICE_FORM_CODE.Contain(model.PRICE_FORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_BID_PRICE))
				{
				  condition.And(TENDER_LIST._.OTHER_BID_PRICE.Contain(model.OTHER_BID_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(TENDER_LIST._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(TENDER_LIST._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(TENDER_LIST._.M_VERSION.Contain(model.M_VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_COMMIT_MARGIN))
				{
				  condition.And(TENDER_LIST._.IS_COMMIT_MARGIN.Contain(model.IS_COMMIT_MARGIN));
				}
		return condition;
	}
        #endregion
    }
}