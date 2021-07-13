using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SlConstructSuperRequireService : BaseServiceT<SL_CONSTRUCT_SUPER_REQUIRE>
    {
        #region 接口实现
        
		public List<SL_CONSTRUCT_SUPER_REQUIRE> FindList(SL_CONSTRUCT_SUPER_REQUIRE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SL_CONSTRUCT_SUPER_REQUIRE> PageList(SL_CONSTRUCT_SUPER_REQUIRE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SL_CONSTRUCT_SUPER_REQUIRE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(SL_CONSTRUCT_SUPER_REQUIRE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is SL_CONSTRUCT_SUPER_REQUIRE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.PROJECT_SCALE_MONEY=model.PROJECT_SCALE_MONEY;
		entity.ALL_LIMIT_ITME=model.ALL_LIMIT_ITME;
		entity.PRICE_UNIT=model.PRICE_UNIT;
		entity.QUALITY_REQUIRE=model.QUALITY_REQUIRE;
		entity.SERVICE_TIME=model.SERVICE_TIME;
		entity.ACHIEVEMENT=model.ACHIEVEMENT;
		entity.SIMILAR_PROJECT=model.SIMILAR_PROJECT;
		entity.SIMILAR_PROJECT_TIME=model.SIMILAR_PROJECT_TIME;
		entity.SUPER_ENGINEER_REQUIRE=model.SUPER_ENGINEER_REQUIRE;
		entity.IS_RECONNAISSANCE=model.IS_RECONNAISSANCE;
		entity.RECONNAISSANCE_TIME=model.RECONNAISSANCE_TIME;
		entity.RECONNAISSANCE_ADDRESS=model.RECONNAISSANCE_ADDRESS;
		entity.IS_PREPARATORY_MEETING=model.IS_PREPARATORY_MEETING;
		entity.PREPARATORY_MEETING_TIME=model.PREPARATORY_MEETING_TIME;
		entity.PREPARATORY_MEETING_ADDRESS=model.PREPARATORY_MEETING_ADDRESS;
		entity.VEHICLE=model.VEHICLE;
		entity.NOTICE_MEDIA4=model.NOTICE_MEDIA4;
		entity.BIDDER_NAME=model.BIDDER_NAME;
		entity.CONTRACT_NAME=model.CONTRACT_NAME;
		entity.CONTRACT_CODE=model.CONTRACT_CODE;
		entity.DESIGNER=model.DESIGNER;
		entity.PROJECT_OVERVIEW=model.PROJECT_OVERVIEW;
		entity.SOCIAL_SECURITY_MONTH=model.SOCIAL_SECURITY_MONTH;
		entity.SOCIAL_SECURITY_TIME=model.SOCIAL_SECURITY_TIME;
		entity.BID_PRICE_APPOINTMENT=model.BID_PRICE_APPOINTMENT;
		entity.VALID_PERIOD_NOT_EXCEEDING=model.VALID_PERIOD_NOT_EXCEEDING;
		entity.MARGIN_AMOUNTDIFFERENCE=model.MARGIN_AMOUNTDIFFERENCE;
		entity.MARGIN_NAME=model.MARGIN_NAME;
		entity.MARGINNUMBER=model.MARGINNUMBER;
		entity.MARGIN_BANK=model.MARGIN_BANK;
		entity.MARGIN_AMOUNT=model.MARGIN_AMOUNT;
		entity.BID_DOC_NUM=model.BID_DOC_NUM;
		entity.BID_DOC_OTHER_REQUIRE=model.BID_DOC_OTHER_REQUIRE;
		entity.WIN_CANDIDATE_NUM=model.WIN_CANDIDATE_NUM;
		entity.PERFORM_PRICE=model.PERFORM_PRICE;
		entity.PERFORM_PRICE_TYPE=model.PERFORM_PRICE_TYPE;
		entity.OTHER_REQUIRE=model.OTHER_REQUIRE;
		entity.EXPERT_NUM=model.EXPERT_NUM;
		entity.K_BEGIN_NUM=model.K_BEGIN_NUM;
		entity.K_END_NUM=model.K_END_NUM;
		entity.QUALITY_CERTIFICATION_REQUIRE=model.QUALITY_CERTIFICATION_REQUIRE;
		entity.FINANCIAL_REQUIRE=model.FINANCIAL_REQUIRE;
		entity.CREDIT_REQUIRE=model.CREDIT_REQUIRE;
		entity.SUPERVISION_BASIS=model.SUPERVISION_BASIS;
		entity.CLIENT_RIGHTS=model.CLIENT_RIGHTS;
		entity.SUPERVISOR_RIGHTS=model.SUPERVISOR_RIGHTS;
		entity.CLIENT_OBLIGATIONS=model.CLIENT_OBLIGATIONS;
		entity.SUPERVISOR_OBLIGATIONS=model.SUPERVISOR_OBLIGATIONS;
		entity.SUPERVISION_SERVICE_FEE=model.SUPERVISION_SERVICE_FEE;
		entity.BREACH_RESPONSIBILITY=model.BREACH_RESPONSIBILITY;
		entity.DISPUTE_RESOLUTION=model.DISPUTE_RESOLUTION;
		entity.OTHER_CLAUSE=model.OTHER_CLAUSE;
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
		entity.MARGIN_AMOUNT_DIFFERENCE=model.MARGIN_AMOUNT_DIFFERENCE;
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
        public GeneralResult Add(SL_CONSTRUCT_SUPER_REQUIRE model)
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
                    Delete(SL_CONSTRUCT_SUPER_REQUIRE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SL_CONSTRUCT_SUPER_REQUIRE> model)
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
       	protected WhereClipBuilder ConditionBuilder(SL_CONSTRUCT_SUPER_REQUIRE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(model.PROJECT_SCALE_MONEY!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.PROJECT_SCALE_MONEY==(model.PROJECT_SCALE_MONEY));
				}
				if(model.ALL_LIMIT_ITME!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.ALL_LIMIT_ITME==(model.ALL_LIMIT_ITME));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_UNIT))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.PRICE_UNIT.Contain(model.PRICE_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALITY_REQUIRE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.QUALITY_REQUIRE.Contain(model.QUALITY_REQUIRE));
				}
				if(model.SERVICE_TIME!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.SERVICE_TIME==(model.SERVICE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHIEVEMENT))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.ACHIEVEMENT.Contain(model.ACHIEVEMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.SIMILAR_PROJECT))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.SIMILAR_PROJECT.Contain(model.SIMILAR_PROJECT));
				}
				if(model.SIMILAR_PROJECT_TIME!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.SIMILAR_PROJECT_TIME==(model.SIMILAR_PROJECT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPER_ENGINEER_REQUIRE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.SUPER_ENGINEER_REQUIRE.Contain(model.SUPER_ENGINEER_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_RECONNAISSANCE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.IS_RECONNAISSANCE.Contain(model.IS_RECONNAISSANCE));
				}
				if(model.RECONNAISSANCE_TIME!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.RECONNAISSANCE_TIME==(model.RECONNAISSANCE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.RECONNAISSANCE_ADDRESS))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.RECONNAISSANCE_ADDRESS.Contain(model.RECONNAISSANCE_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_PREPARATORY_MEETING))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.IS_PREPARATORY_MEETING.Contain(model.IS_PREPARATORY_MEETING));
				}
				if(model.PREPARATORY_MEETING_TIME!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.PREPARATORY_MEETING_TIME==(model.PREPARATORY_MEETING_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PREPARATORY_MEETING_ADDRESS))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.PREPARATORY_MEETING_ADDRESS.Contain(model.PREPARATORY_MEETING_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.VEHICLE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.VEHICLE.Contain(model.VEHICLE));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_MEDIA4))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.NOTICE_MEDIA4.Contain(model.NOTICE_MEDIA4));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_NAME))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.BIDDER_NAME.Contain(model.BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_NAME))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.CONTRACT_NAME.Contain(model.CONTRACT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_CODE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.CONTRACT_CODE.Contain(model.CONTRACT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.DESIGNER))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.DESIGNER.Contain(model.DESIGNER));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_OVERVIEW))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.PROJECT_OVERVIEW.Contain(model.PROJECT_OVERVIEW));
				}
				if(model.SOCIAL_SECURITY_MONTH!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.SOCIAL_SECURITY_MONTH==(model.SOCIAL_SECURITY_MONTH));
				}
				if(model.SOCIAL_SECURITY_TIME!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.SOCIAL_SECURITY_TIME==(model.SOCIAL_SECURITY_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_PRICE_APPOINTMENT))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.BID_PRICE_APPOINTMENT.Contain(model.BID_PRICE_APPOINTMENT));
				}
				if(model.VALID_PERIOD_NOT_EXCEEDING!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.VALID_PERIOD_NOT_EXCEEDING==(model.VALID_PERIOD_NOT_EXCEEDING));
				}
				if(model.MARGIN_AMOUNTDIFFERENCE!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.MARGIN_AMOUNTDIFFERENCE==(model.MARGIN_AMOUNTDIFFERENCE));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.MARGIN_NAME.Contain(model.MARGIN_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGINNUMBER))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.MARGINNUMBER.Contain(model.MARGINNUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.MARGIN_BANK.Contain(model.MARGIN_BANK));
				}
				if(model.MARGIN_AMOUNT!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.MARGIN_AMOUNT==(model.MARGIN_AMOUNT));
				}
				if(model.BID_DOC_NUM!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.BID_DOC_NUM==(model.BID_DOC_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_DOC_OTHER_REQUIRE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.BID_DOC_OTHER_REQUIRE.Contain(model.BID_DOC_OTHER_REQUIRE));
				}
				if(model.WIN_CANDIDATE_NUM!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.WIN_CANDIDATE_NUM==(model.WIN_CANDIDATE_NUM));
				}
				if(model.PERFORM_PRICE!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.PERFORM_PRICE==(model.PERFORM_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORM_PRICE_TYPE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.PERFORM_PRICE_TYPE.Contain(model.PERFORM_PRICE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_REQUIRE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.OTHER_REQUIRE.Contain(model.OTHER_REQUIRE));
				}
				if(model.EXPERT_NUM!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.EXPERT_NUM==(model.EXPERT_NUM));
				}
				if(model.K_BEGIN_NUM!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.K_BEGIN_NUM==(model.K_BEGIN_NUM));
				}
				if(model.K_END_NUM!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.K_END_NUM==(model.K_END_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALITY_CERTIFICATION_REQUIRE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.QUALITY_CERTIFICATION_REQUIRE.Contain(model.QUALITY_CERTIFICATION_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.FINANCIAL_REQUIRE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.FINANCIAL_REQUIRE.Contain(model.FINANCIAL_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.CREDIT_REQUIRE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.CREDIT_REQUIRE.Contain(model.CREDIT_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISION_BASIS))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.SUPERVISION_BASIS.Contain(model.SUPERVISION_BASIS));
				}
				if(!string.IsNullOrWhiteSpace(model.CLIENT_RIGHTS))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.CLIENT_RIGHTS.Contain(model.CLIENT_RIGHTS));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISOR_RIGHTS))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.SUPERVISOR_RIGHTS.Contain(model.SUPERVISOR_RIGHTS));
				}
				if(!string.IsNullOrWhiteSpace(model.CLIENT_OBLIGATIONS))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.CLIENT_OBLIGATIONS.Contain(model.CLIENT_OBLIGATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISOR_OBLIGATIONS))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.SUPERVISOR_OBLIGATIONS.Contain(model.SUPERVISOR_OBLIGATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISION_SERVICE_FEE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.SUPERVISION_SERVICE_FEE.Contain(model.SUPERVISION_SERVICE_FEE));
				}
				if(!string.IsNullOrWhiteSpace(model.BREACH_RESPONSIBILITY))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.BREACH_RESPONSIBILITY.Contain(model.BREACH_RESPONSIBILITY));
				}
				if(!string.IsNullOrWhiteSpace(model.DISPUTE_RESOLUTION))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.DISPUTE_RESOLUTION.Contain(model.DISPUTE_RESOLUTION));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_CLAUSE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.OTHER_CLAUSE.Contain(model.OTHER_CLAUSE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.IMPORTANT_LIMITE_TIME))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.IMPORTANT_LIMITE_TIME.Contain(model.IMPORTANT_LIMITE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.M_VERSION.Contain(model.M_VERSION));
				}
				if(model.MARGIN_AMOUNT_DIFFERENCE!=null)
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.MARGIN_AMOUNT_DIFFERENCE==(model.MARGIN_AMOUNT_DIFFERENCE));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER))
				{
				  condition.And(SL_CONSTRUCT_SUPER_REQUIRE._.MARGIN_NUMBER.Contain(model.MARGIN_NUMBER));
				}
		return condition;
	}
        #endregion
    }
}