using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SlConstructBidocRequireService : BaseServiceT<SL_CONSTRUCT_BIDOC_REQUIRE>
    {
        #region 接口实现
        
		public List<SL_CONSTRUCT_BIDOC_REQUIRE> FindList(SL_CONSTRUCT_BIDOC_REQUIRE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SL_CONSTRUCT_BIDOC_REQUIRE> PageList(SL_CONSTRUCT_BIDOC_REQUIRE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SL_CONSTRUCT_BIDOC_REQUIRE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(SL_CONSTRUCT_BIDOC_REQUIRE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is SL_CONSTRUCT_BIDOC_REQUIRE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.PROJECT_SCALE_MONEY=model.PROJECT_SCALE_MONEY;
		entity.ALL_LIMIT_ITME=model.ALL_LIMIT_ITME;
		entity.PRICE_UNIT=model.PRICE_UNIT;
		entity.BID_SECTION=model.BID_SECTION;
		entity.QUALITY_REQUIRE=model.QUALITY_REQUIRE;
		entity.BIDDER_NAME=model.BIDDER_NAME;
		entity.SITE_MANAGEMENT_ORGANIZATION=model.SITE_MANAGEMENT_ORGANIZATION;
		entity.DESIGNER=model.DESIGNER;
		entity.SUPERVISOR=model.SUPERVISOR;
		entity.PROJECT_AGENCY_NAME=model.PROJECT_AGENCY_NAME;
		entity.END_DATE=model.END_DATE;
		entity.MARGIN_AMOUNT_DIFFERENCE=model.MARGIN_AMOUNT_DIFFERENCE;
		entity.SOCIAL_SECURITY_MONTH=model.SOCIAL_SECURITY_MONTH;
		entity.SOCIAL_SECURITY_TIME=model.SOCIAL_SECURITY_TIME;
		entity.IS_RECONNAISSANCE=model.IS_RECONNAISSANCE;
		entity.RECONNAISSANCE_TIME=model.RECONNAISSANCE_TIME;
		entity.RECONNAISSANCE_ADDRESS=model.RECONNAISSANCE_ADDRESS;
		entity.IS_PREPARATORY_MEETING=model.IS_PREPARATORY_MEETING;
		entity.PREPARATORY_MEETING_TIME=model.PREPARATORY_MEETING_TIME;
		entity.PREPARATORY_MEETING_ADDRESS=model.PREPARATORY_MEETING_ADDRESS;
		entity.IS_SUBCONTRACT=model.IS_SUBCONTRACT;
		entity.SUBCONTRACT_CONTENT_REQUIRE=model.SUBCONTRACT_CONTENT_REQUIRE;
		entity.SUBCONTRACT_MONEY_REQUIRE=model.SUBCONTRACT_MONEY_REQUIRE;
		entity.THIRD_QUAL_REQUIRE=model.THIRD_QUAL_REQUIRE;
		entity.DEVIATE_PROCESSING_METHOD=model.DEVIATE_PROCESSING_METHOD;
		entity.VEHICLE=model.VEHICLE;
		entity.MARGIN_NAME=model.MARGIN_NAME;
		entity.MARGINNUMBER=model.MARGINNUMBER;
		entity.MARGIN_BANK=model.MARGIN_BANK;
		entity.BID_DOC_NUM=model.BID_DOC_NUM;
		entity.BID_DOC_OTHER_REQUIRE=model.BID_DOC_OTHER_REQUIRE;
		entity.WIN_CANDIDATE_NUM=model.WIN_CANDIDATE_NUM;
		entity.PERFORM_PRICE=model.PERFORM_PRICE;
		entity.PERFORM_PRICE_TYPE=model.PERFORM_PRICE_TYPE;
		entity.SIMILAR_PROJECT=model.SIMILAR_PROJECT;
		entity.MANAGER_TECH_TITLE=model.MANAGER_TECH_TITLE;
		entity.MANAGER_QUAL_TYPE=model.MANAGER_QUAL_TYPE;
		entity.MANAGER_QUAL_LEVEL=model.MANAGER_QUAL_LEVEL;
		entity.ACHIEVEMENT=model.ACHIEVEMENT;
		entity.NOTICE_MEDIA_OTHER=model.NOTICE_MEDIA_OTHER;
		entity.ACHIEVEMENT_REQUIRE_CONTENT=model.ACHIEVEMENT_REQUIRE_CONTENT;
		entity.FINANCIAL_REQUIRE_CONTENT=model.FINANCIAL_REQUIRE_CONTENT;
		entity.REPUTATION_REQUIRE_CONTENT=model.REPUTATION_REQUIRE_CONTENT;
		entity.REGION_CODE=model.REGION_CODE;
		entity.NOT_EXCEED_PERCENTILE=model.NOT_EXCEED_PERCENTILE;
		entity.DEVIATE_PERCENTILE=model.DEVIATE_PERCENTILE;
		entity.VALID_PERIOD_NOT_EXCEEDING=model.VALID_PERIOD_NOT_EXCEEDING;
		entity.OTHER_REQUIRE=model.OTHER_REQUIRE;
		entity.EXPERT_NUM=model.EXPERT_NUM;
		entity.TENDERER_NUM=model.TENDERER_NUM;
		entity.BUSINESS_EXPERT_NUM=model.BUSINESS_EXPERT_NUM;
		entity.TECHNICIAN_EXPERT_NUM=model.TECHNICIAN_EXPERT_NUM;
		entity.K_BEGIN_NUM=model.K_BEGIN_NUM;
		entity.K_END_NUM=model.K_END_NUM;
		entity.TECHNICAL_DOC_RESPON_REVIEW=model.TECHNICAL_DOC_RESPON_REVIEW;
		entity.CONSTRUCTION_DESIGN_REVIEW=model.CONSTRUCTION_DESIGN_REVIEW;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
		entity.IMPORTANT_LIMITE_TIME=model.IMPORTANT_LIMITE_TIME;
		entity.TRADE_PLAT=model.TRADE_PLAT;
		entity.PUB_SERVICE_PLAT=model.PUB_SERVICE_PLAT;
		entity.M_VERSION=model.M_VERSION;
		entity.MARGIN_NUMBER=model.MARGIN_NUMBER;
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
        public GeneralResult Add(SL_CONSTRUCT_BIDOC_REQUIRE model)
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
                    Delete(SL_CONSTRUCT_BIDOC_REQUIRE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SL_CONSTRUCT_BIDOC_REQUIRE> model)
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
       	protected WhereClipBuilder ConditionBuilder(SL_CONSTRUCT_BIDOC_REQUIRE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(model.PROJECT_SCALE_MONEY!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.PROJECT_SCALE_MONEY==(model.PROJECT_SCALE_MONEY));
				}
				if(model.ALL_LIMIT_ITME!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.ALL_LIMIT_ITME==(model.ALL_LIMIT_ITME));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_UNIT))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.PRICE_UNIT.Contain(model.PRICE_UNIT));
				}
				if(model.BID_SECTION!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.BID_SECTION==(model.BID_SECTION));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALITY_REQUIRE))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.QUALITY_REQUIRE.Contain(model.QUALITY_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_NAME))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.BIDDER_NAME.Contain(model.BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SITE_MANAGEMENT_ORGANIZATION))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.SITE_MANAGEMENT_ORGANIZATION.Contain(model.SITE_MANAGEMENT_ORGANIZATION));
				}
				if(!string.IsNullOrWhiteSpace(model.DESIGNER))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.DESIGNER.Contain(model.DESIGNER));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISOR))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.SUPERVISOR.Contain(model.SUPERVISOR));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_AGENCY_NAME))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.PROJECT_AGENCY_NAME.Contain(model.PROJECT_AGENCY_NAME));
				}
				if(model.END_DATE!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.END_DATE==(model.END_DATE));
				}
				if(model.MARGIN_AMOUNT_DIFFERENCE!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.MARGIN_AMOUNT_DIFFERENCE==(model.MARGIN_AMOUNT_DIFFERENCE));
				}
				if(model.SOCIAL_SECURITY_MONTH!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.SOCIAL_SECURITY_MONTH==(model.SOCIAL_SECURITY_MONTH));
				}
				if(model.SOCIAL_SECURITY_TIME!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.SOCIAL_SECURITY_TIME==(model.SOCIAL_SECURITY_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_RECONNAISSANCE))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.IS_RECONNAISSANCE.Contain(model.IS_RECONNAISSANCE));
				}
				if(model.RECONNAISSANCE_TIME!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.RECONNAISSANCE_TIME==(model.RECONNAISSANCE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.RECONNAISSANCE_ADDRESS))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.RECONNAISSANCE_ADDRESS.Contain(model.RECONNAISSANCE_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_PREPARATORY_MEETING))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.IS_PREPARATORY_MEETING.Contain(model.IS_PREPARATORY_MEETING));
				}
				if(model.PREPARATORY_MEETING_TIME!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.PREPARATORY_MEETING_TIME==(model.PREPARATORY_MEETING_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PREPARATORY_MEETING_ADDRESS))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.PREPARATORY_MEETING_ADDRESS.Contain(model.PREPARATORY_MEETING_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_SUBCONTRACT))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.IS_SUBCONTRACT.Contain(model.IS_SUBCONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBCONTRACT_CONTENT_REQUIRE))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.SUBCONTRACT_CONTENT_REQUIRE.Contain(model.SUBCONTRACT_CONTENT_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBCONTRACT_MONEY_REQUIRE))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.SUBCONTRACT_MONEY_REQUIRE.Contain(model.SUBCONTRACT_MONEY_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.THIRD_QUAL_REQUIRE))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.THIRD_QUAL_REQUIRE.Contain(model.THIRD_QUAL_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.DEVIATE_PROCESSING_METHOD))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.DEVIATE_PROCESSING_METHOD.Contain(model.DEVIATE_PROCESSING_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.VEHICLE))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.VEHICLE.Contain(model.VEHICLE));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.MARGIN_NAME.Contain(model.MARGIN_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGINNUMBER))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.MARGINNUMBER.Contain(model.MARGINNUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.MARGIN_BANK.Contain(model.MARGIN_BANK));
				}
				if(model.BID_DOC_NUM!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.BID_DOC_NUM==(model.BID_DOC_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_DOC_OTHER_REQUIRE))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.BID_DOC_OTHER_REQUIRE.Contain(model.BID_DOC_OTHER_REQUIRE));
				}
				if(model.WIN_CANDIDATE_NUM!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.WIN_CANDIDATE_NUM==(model.WIN_CANDIDATE_NUM));
				}
				if(model.PERFORM_PRICE!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.PERFORM_PRICE==(model.PERFORM_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORM_PRICE_TYPE))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.PERFORM_PRICE_TYPE.Contain(model.PERFORM_PRICE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SIMILAR_PROJECT))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.SIMILAR_PROJECT.Contain(model.SIMILAR_PROJECT));
				}
				if(!string.IsNullOrWhiteSpace(model.MANAGER_TECH_TITLE))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.MANAGER_TECH_TITLE.Contain(model.MANAGER_TECH_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.MANAGER_QUAL_TYPE))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.MANAGER_QUAL_TYPE.Contain(model.MANAGER_QUAL_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.MANAGER_QUAL_LEVEL))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.MANAGER_QUAL_LEVEL.Contain(model.MANAGER_QUAL_LEVEL));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHIEVEMENT))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.ACHIEVEMENT.Contain(model.ACHIEVEMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_MEDIA_OTHER))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.NOTICE_MEDIA_OTHER.Contain(model.NOTICE_MEDIA_OTHER));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHIEVEMENT_REQUIRE_CONTENT))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.ACHIEVEMENT_REQUIRE_CONTENT.Contain(model.ACHIEVEMENT_REQUIRE_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.FINANCIAL_REQUIRE_CONTENT))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.FINANCIAL_REQUIRE_CONTENT.Contain(model.FINANCIAL_REQUIRE_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.REPUTATION_REQUIRE_CONTENT))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.REPUTATION_REQUIRE_CONTENT.Contain(model.REPUTATION_REQUIRE_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(model.NOT_EXCEED_PERCENTILE!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.NOT_EXCEED_PERCENTILE==(model.NOT_EXCEED_PERCENTILE));
				}
				if(model.DEVIATE_PERCENTILE!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.DEVIATE_PERCENTILE==(model.DEVIATE_PERCENTILE));
				}
				if(model.VALID_PERIOD_NOT_EXCEEDING!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.VALID_PERIOD_NOT_EXCEEDING==(model.VALID_PERIOD_NOT_EXCEEDING));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_REQUIRE))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.OTHER_REQUIRE.Contain(model.OTHER_REQUIRE));
				}
				if(model.EXPERT_NUM!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.EXPERT_NUM==(model.EXPERT_NUM));
				}
				if(model.TENDERER_NUM!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.TENDERER_NUM==(model.TENDERER_NUM));
				}
				if(model.BUSINESS_EXPERT_NUM!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.BUSINESS_EXPERT_NUM==(model.BUSINESS_EXPERT_NUM));
				}
				if(model.TECHNICIAN_EXPERT_NUM!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.TECHNICIAN_EXPERT_NUM==(model.TECHNICIAN_EXPERT_NUM));
				}
				if(model.K_BEGIN_NUM!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.K_BEGIN_NUM==(model.K_BEGIN_NUM));
				}
				if(model.K_END_NUM!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.K_END_NUM==(model.K_END_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.TECHNICAL_DOC_RESPON_REVIEW))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.TECHNICAL_DOC_RESPON_REVIEW.Contain(model.TECHNICAL_DOC_RESPON_REVIEW));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCTION_DESIGN_REVIEW))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.CONSTRUCTION_DESIGN_REVIEW.Contain(model.CONSTRUCTION_DESIGN_REVIEW));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.IMPORTANT_LIMITE_TIME))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.IMPORTANT_LIMITE_TIME.Contain(model.IMPORTANT_LIMITE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.M_VERSION.Contain(model.M_VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER))
				{
				  condition.And(SL_CONSTRUCT_BIDOC_REQUIRE._.MARGIN_NUMBER.Contain(model.MARGIN_NUMBER));
				}
		return condition;
	}
        #endregion
    }
}