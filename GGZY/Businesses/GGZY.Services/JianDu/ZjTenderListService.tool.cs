using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ZjTenderListService : BaseServiceT<ZJ_TENDER_LIST>
    {
        #region 接口实现
        
		public List<ZJ_TENDER_LIST> FindList(ZJ_TENDER_LIST model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJ_TENDER_LIST> PageList(ZJ_TENDER_LIST model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJ_TENDER_LIST._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(ZJ_TENDER_LIST._.M_ID == M_ID);
			
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
        public GeneralResult Edit(ZJ_TENDER_LIST model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is ZJ_TENDER_LIST entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.BIDDER_NAME=model.BIDDER_NAME;
		entity.BIDDER_CODE_TYPE=model.BIDDER_CODE_TYPE;
		entity.BIDDER_ORG_CODE=model.BIDDER_ORG_CODE;
		entity.BIDDER_ROLE=model.BIDDER_ROLE;
		entity.BIDDER_CREDIT_SCORE=model.BIDDER_CREDIT_SCORE;
		entity.IS_REVIEW_SHORTLISTED=model.IS_REVIEW_SHORTLISTED;
		entity.BID_MANAGER=model.BID_MANAGER;
		entity.ID_CARD=model.ID_CARD;
		entity.REGIST_CERTIFICATE=model.REGIST_CERTIFICATE;
		entity.AUTHORIZED_CLIENT=model.AUTHORIZED_CLIENT;
		entity.AUTH_ID_CARD=model.AUTH_ID_CARD;
		entity.AUTH_CONTACT_NUMBER=model.AUTH_CONTACT_NUMBER;
		entity.BID_DOC_DOWNLOAD_TIME=model.BID_DOC_DOWNLOAD_TIME;
		entity.MARGIN_PAY_FORM=model.MARGIN_PAY_FORM;
		entity.MARIN_FINANCIAL_NAME=model.MARIN_FINANCIAL_NAME;
		entity.DECRY_STATUS_DOC=model.DECRY_STATUS_DOC;
		entity.DECRY_DATE_DOC=model.DECRY_DATE_DOC;
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
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_TM=model.M_TM;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.IS_LOST=model.IS_LOST;
		entity.TRADE_PLAT=model.TRADE_PLAT;
		entity.PUB_SERVICE_PLAT=model.PUB_SERVICE_PLAT;
		entity.M_VERSION=model.M_VERSION;
		entity.IS_COMMIT_MARGIN=model.IS_COMMIT_MARGIN;
		entity.PRICE_FORM_CODE=model.PRICE_FORM_CODE;
		entity.OTHER_BID_PRICE=model.OTHER_BID_PRICE;
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
        public GeneralResult Add(ZJ_TENDER_LIST model)
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
                    Delete(ZJ_TENDER_LIST._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJ_TENDER_LIST> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJ_TENDER_LIST model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(ZJ_TENDER_LIST._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(ZJ_TENDER_LIST._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(ZJ_TENDER_LIST._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_NAME))
				{
				  condition.And(ZJ_TENDER_LIST._.BIDDER_NAME.Contain(model.BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_CODE_TYPE))
				{
				  condition.And(ZJ_TENDER_LIST._.BIDDER_CODE_TYPE.Contain(model.BIDDER_CODE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_ORG_CODE))
				{
				  condition.And(ZJ_TENDER_LIST._.BIDDER_ORG_CODE.Contain(model.BIDDER_ORG_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_ROLE))
				{
				  condition.And(ZJ_TENDER_LIST._.BIDDER_ROLE.Contain(model.BIDDER_ROLE));
				}
				if(model.BIDDER_CREDIT_SCORE!=null)
				{
				  condition.And(ZJ_TENDER_LIST._.BIDDER_CREDIT_SCORE==(model.BIDDER_CREDIT_SCORE));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_REVIEW_SHORTLISTED))
				{
				  condition.And(ZJ_TENDER_LIST._.IS_REVIEW_SHORTLISTED.Contain(model.IS_REVIEW_SHORTLISTED));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_MANAGER))
				{
				  condition.And(ZJ_TENDER_LIST._.BID_MANAGER.Contain(model.BID_MANAGER));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD))
				{
				  condition.And(ZJ_TENDER_LIST._.ID_CARD.Contain(model.ID_CARD));
				}
				if(!string.IsNullOrWhiteSpace(model.REGIST_CERTIFICATE))
				{
				  condition.And(ZJ_TENDER_LIST._.REGIST_CERTIFICATE.Contain(model.REGIST_CERTIFICATE));
				}
				if(!string.IsNullOrWhiteSpace(model.AUTHORIZED_CLIENT))
				{
				  condition.And(ZJ_TENDER_LIST._.AUTHORIZED_CLIENT.Contain(model.AUTHORIZED_CLIENT));
				}
				if(!string.IsNullOrWhiteSpace(model.AUTH_ID_CARD))
				{
				  condition.And(ZJ_TENDER_LIST._.AUTH_ID_CARD.Contain(model.AUTH_ID_CARD));
				}
				if(!string.IsNullOrWhiteSpace(model.AUTH_CONTACT_NUMBER))
				{
				  condition.And(ZJ_TENDER_LIST._.AUTH_CONTACT_NUMBER.Contain(model.AUTH_CONTACT_NUMBER));
				}
				if(model.BID_DOC_DOWNLOAD_TIME!=null)
				{
				  condition.And(ZJ_TENDER_LIST._.BID_DOC_DOWNLOAD_TIME==(model.BID_DOC_DOWNLOAD_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_PAY_FORM))
				{
				  condition.And(ZJ_TENDER_LIST._.MARGIN_PAY_FORM.Contain(model.MARGIN_PAY_FORM));
				}
				if(!string.IsNullOrWhiteSpace(model.MARIN_FINANCIAL_NAME))
				{
				  condition.And(ZJ_TENDER_LIST._.MARIN_FINANCIAL_NAME.Contain(model.MARIN_FINANCIAL_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DECRY_STATUS_DOC))
				{
				  condition.And(ZJ_TENDER_LIST._.DECRY_STATUS_DOC.Contain(model.DECRY_STATUS_DOC));
				}
				if(model.DECRY_DATE_DOC!=null)
				{
				  condition.And(ZJ_TENDER_LIST._.DECRY_DATE_DOC==(model.DECRY_DATE_DOC));
				}
				if(model.MARGIN_RECEIVE_TIME!=null)
				{
				  condition.And(ZJ_TENDER_LIST._.MARGIN_RECEIVE_TIME==(model.MARGIN_RECEIVE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNION_ENTERPRISE_NAME))
				{
				  condition.And(ZJ_TENDER_LIST._.UNION_ENTERPRISE_NAME.Contain(model.UNION_ENTERPRISE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNION_ORGAN_SET_CODE))
				{
				  condition.And(ZJ_TENDER_LIST._.UNION_ORGAN_SET_CODE.Contain(model.UNION_ORGAN_SET_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNION_CONTACT_NAME))
				{
				  condition.And(ZJ_TENDER_LIST._.UNION_CONTACT_NAME.Contain(model.UNION_CONTACT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNION_CONTACT_PHONE))
				{
				  condition.And(ZJ_TENDER_LIST._.UNION_CONTACT_PHONE.Contain(model.UNION_CONTACT_PHONE));
				}
				if(model.BIDDER_INFO_VERSION!=null)
				{
				  condition.And(ZJ_TENDER_LIST._.BIDDER_INFO_VERSION==(model.BIDDER_INFO_VERSION));
				}
				if(model.BID_PRICE!=null)
				{
				  condition.And(ZJ_TENDER_LIST._.BID_PRICE==(model.BID_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_CURRENCY))
				{
				  condition.And(ZJ_TENDER_LIST._.PRICE_CURRENCY.Contain(model.PRICE_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_UNIT))
				{
				  condition.And(ZJ_TENDER_LIST._.PRICE_UNIT.Contain(model.PRICE_UNIT));
				}
				if(model.TIME_LIMIT!=null)
				{
				  condition.And(ZJ_TENDER_LIST._.TIME_LIMIT==(model.TIME_LIMIT));
				}
				if(model.CHECKIN_TIME!=null)
				{
				  condition.And(ZJ_TENDER_LIST._.CHECKIN_TIME==(model.CHECKIN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(ZJ_TENDER_LIST._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(ZJ_TENDER_LIST._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(ZJ_TENDER_LIST._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(ZJ_TENDER_LIST._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(ZJ_TENDER_LIST._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(ZJ_TENDER_LIST._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(ZJ_TENDER_LIST._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_TM!=null)
				{
				  condition.And(ZJ_TENDER_LIST._.M_TM==(model.M_TM));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(ZJ_TENDER_LIST._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_LOST))
				{
				  condition.And(ZJ_TENDER_LIST._.IS_LOST.Contain(model.IS_LOST));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(ZJ_TENDER_LIST._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(ZJ_TENDER_LIST._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(ZJ_TENDER_LIST._.M_VERSION.Contain(model.M_VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_COMMIT_MARGIN))
				{
				  condition.And(ZJ_TENDER_LIST._.IS_COMMIT_MARGIN.Contain(model.IS_COMMIT_MARGIN));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_FORM_CODE))
				{
				  condition.And(ZJ_TENDER_LIST._.PRICE_FORM_CODE.Contain(model.PRICE_FORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_BID_PRICE))
				{
				  condition.And(ZJ_TENDER_LIST._.OTHER_BID_PRICE.Contain(model.OTHER_BID_PRICE));
				}
		return condition;
	}
        #endregion
    }
}