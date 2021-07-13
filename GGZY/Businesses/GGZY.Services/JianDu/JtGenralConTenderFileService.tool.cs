using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JtGenralConTenderFileService : BaseServiceT<JT_GENRAL_CON_TENDER_FILE>
    {
        #region 接口实现
        
		public List<JT_GENRAL_CON_TENDER_FILE> FindList(JT_GENRAL_CON_TENDER_FILE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JT_GENRAL_CON_TENDER_FILE> PageList(JT_GENRAL_CON_TENDER_FILE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JT_GENRAL_CON_TENDER_FILE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(JT_GENRAL_CON_TENDER_FILE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(JT_GENRAL_CON_TENDER_FILE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is JT_GENRAL_CON_TENDER_FILE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.LIMITE_ALL_TIME=model.LIMITE_ALL_TIME;
		entity.LIMITE_TIME_UNIT=model.LIMITE_TIME_UNIT;
		entity.FIRST_ENVELOPES_CONFIRM=model.FIRST_ENVELOPES_CONFIRM;
		entity.WIN_BID_NUMBER=model.WIN_BID_NUMBER;
		entity.QUALI_REQUIRE1=model.QUALI_REQUIRE1;
		entity.QUALI_REQUIRE2=model.QUALI_REQUIRE2;
		entity.REPUTATION_TIME1=model.REPUTATION_TIME1;
		entity.REPUTATION_TIME2=model.REPUTATION_TIME2;
		entity.MANAGER_TITLE=model.MANAGER_TITLE;
		entity.MANAGER_TITLE_LEVEL=model.MANAGER_TITLE_LEVEL;
		entity.CONSTRUCTOR_MAJOR=model.CONSTRUCTOR_MAJOR;
		entity.CONSTRUCTOR_MAJOR_LEVEL=model.CONSTRUCTOR_MAJOR_LEVEL;
		entity.MANAGER_AGE=model.MANAGER_AGE;
		entity.TECH_TITLE=model.TECH_TITLE;
		entity.TECH_TITLE_LEVEL=model.TECH_TITLE_LEVEL;
		entity.TECH_AGE=model.TECH_AGE;
		entity.DELAY_PENALTY=model.DELAY_PENALTY;
		entity.LIQUID_DAMAGE_RATE=model.LIQUID_DAMAGE_RATE;
		entity.MINIMUM_LIMIT=model.MINIMUM_LIMIT;
		entity.DEFECT_LIABILITY_PERIOD=model.DEFECT_LIABILITY_PERIOD;
		entity.BEGIN_ALL_DATE=model.BEGIN_ALL_DATE;
		entity.END_DATE=model.END_DATE;
		entity.FUND_IMPLEMENTATION=model.FUND_IMPLEMENTATION;
		entity.TOTAL_SECTION_NUMBER=model.TOTAL_SECTION_NUMBER;
		entity.TENDERER_BID_SECTION=model.TENDERER_BID_SECTION;
		entity.CONSTRUCTION_BUDGET_PRICE=model.CONSTRUCTION_BUDGET_PRICE;
		entity.CONTRACT_PRICE=model.CONTRACT_PRICE;
		entity.CONTRACT_SEGMENT=model.CONTRACT_SEGMENT;
		entity.TENDER_NUMBER=model.TENDER_NUMBER;
		entity.MARGIN_NAME=model.MARGIN_NAME;
		entity.MARGIN_NUMBER=model.MARGIN_NUMBER;
		entity.MARGIN_BANK=model.MARGIN_BANK;
		entity.MARGIN_TIME=model.MARGIN_TIME;
		entity.INTEREST_MODE=model.INTEREST_MODE;
		entity.INTEREST_CALCULATION_CYCLE=model.INTEREST_CALCULATION_CYCLE;
		entity.MONEY_RATE=model.MONEY_RATE;
		entity.MEDIA1=model.MEDIA1;
		entity.MEDIA2=model.MEDIA2;
		entity.EVALUATING_METHOD_STANDARD=model.EVALUATING_METHOD_STANDARD;
		entity.MATERIAL_PRICE_ADJUSTED=model.MATERIAL_PRICE_ADJUSTED;
		entity.BASE_PRICE_CITY=model.BASE_PRICE_CITY;
		entity.RELEASE_PRICE_CITY=model.RELEASE_PRICE_CITY;
		entity.NO_RELEASE_PRICE_CITY=model.NO_RELEASE_PRICE_CITY;
		entity.DEFECT_LIABILITY_PERIOD1=model.DEFECT_LIABILITY_PERIOD1;
		entity.OPEN_BID_REQURE_CHOOSE=model.OPEN_BID_REQURE_CHOOSE;
		entity.SUPERVISE_DEPT_NAME=model.SUPERVISE_DEPT_NAME;
		entity.SUPERVISE_DEPT_PHONE=model.SUPERVISE_DEPT_PHONE;
		entity.SUPERVISE_DEPT_ADDRESS=model.SUPERVISE_DEPT_ADDRESS;
		entity.SUPERVISE_DEPT_ZIP_CODE=model.SUPERVISE_DEPT_ZIP_CODE;
		entity.QUALITY_REQUIRE1=model.QUALITY_REQUIRE1;
		entity.QUALITY_REQUIRE2=model.QUALITY_REQUIRE2;
		entity.SYNDICATED_NUMBER=model.SYNDICATED_NUMBER;
		entity.QUESTION_TIME=model.QUESTION_TIME;
		entity.BIDDER_NOTICE_TIME=model.BIDDER_NOTICE_TIME;
		entity.SUBCONTRACT=model.SUBCONTRACT;
		entity.TENDER_NOTICE_TIME=model.TENDER_NOTICE_TIME;
		entity.MODIFICATION_TIME=model.MODIFICATION_TIME;
		entity.FINANCIAL_YEAR_REQUIRE=model.FINANCIAL_YEAR_REQUIRE;
		entity.SIMILAR_PROJECT_YEAR_REQUIRE=model.SIMILAR_PROJECT_YEAR_REQUIRE;
		entity.LITIGATION_REQUIRE=model.LITIGATION_REQUIRE;
		entity.BRIBERY_RECORD_YEAR=model.BRIBERY_RECORD_YEAR;
		entity.COPY_NUMBER=model.COPY_NUMBER;
		entity.DECRYPTION_TYPE=model.DECRYPTION_TYPE;
		entity.SEC_ENVELOPES_OPEN=model.SEC_ENVELOPES_OPEN;
		entity.ALL_EXPERT_NUM=model.ALL_EXPERT_NUM;
		entity.TENDERER_NUM=model.TENDERER_NUM;
		entity.EXPERT_NUM=model.EXPERT_NUM;
		entity.EXPERT_LIBRARY=model.EXPERT_LIBRARY;
		entity.K_NUMBER=model.K_NUMBER;
		entity.HIGHEST_PRICE_DATE=model.HIGHEST_PRICE_DATE;
		entity.LOWEST_PRICE_DATE=model.LOWEST_PRICE_DATE;
		entity.PREMIUM_RATE1=model.PREMIUM_RATE1;
		entity.PREMIUM_RATE2=model.PREMIUM_RATE2;
		entity.INSURED_AMOUNT=model.INSURED_AMOUNT;
		entity.DISPUTE_DEAL_METHOD=model.DISPUTE_DEAL_METHOD;
		entity.ARB_COMMISSION_NAME=model.ARB_COMMISSION_NAME;
		entity.MINIMUM_QUALIFICATIONS=model.MINIMUM_QUALIFICATIONS;
		entity.FINANCIAL_REQUIRE=model.FINANCIAL_REQUIRE;
		entity.ACHIEVEMENT_REQUIRE=model.ACHIEVEMENT_REQUIRE;
		entity.REPUTATION_REQUIRE=model.REPUTATION_REQUIRE;
		entity.QUALIFICATION_REQUIRE=model.QUALIFICATION_REQUIRE;
		entity.OTHER_QUALIFICATION_REQUIRE=model.OTHER_QUALIFICATION_REQUIRE;
		entity.EQUIPMENT_REQUIRE=model.EQUIPMENT_REQUIRE;
		entity.BID_EVALUATION=model.BID_EVALUATION;
		entity.CREDIT=model.CREDIT;
		entity.CREDIT_RATING_AA_YEAR=model.CREDIT_RATING_AA_YEAR;
		entity.CREDIT_RATING_A_YEAR=model.CREDIT_RATING_A_YEAR;
		entity.CREDIT_RATING_B_YEAR=model.CREDIT_RATING_B_YEAR;
		entity.CREDIT_RATING_W_YEAR=model.CREDIT_RATING_W_YEAR;
		entity.CREDIT_RATING_BW_YEAR=model.CREDIT_RATING_BW_YEAR;
		entity.CREDIT_RATING_CD_YEAR=model.CREDIT_RATING_CD_YEAR;
		entity.CREDIT_RATING_AAAW_YEAR=model.CREDIT_RATING_AAAW_YEAR;
		entity.CREDIT_RATING_AAA_YEAR=model.CREDIT_RATING_AAA_YEAR;
		entity.CHANGE=model.CHANGE;
		entity.GENERAL_CONTRACT=model.GENERAL_CONTRACT;
		entity.SUPERVISOR=model.SUPERVISOR;
		entity.CONTRACTOR=model.CONTRACTOR;
		entity.MATERIAL_PROJECT_EQUIPMENT=model.MATERIAL_PROJECT_EQUIPMENT;
		entity.CONSTRUCT_EQUIP_TEMP_FACIL=model.CONSTRUCT_EQUIP_TEMP_FACIL;
		entity.TRANSPORTATION=model.TRANSPORTATION;
		entity.SAFE_SECURITY_ENVIRON_PRO=model.SAFE_SECURITY_ENVIRON_PRO;
		entity.SCHEDULE=model.SCHEDULE;
		entity.COMMENCEMENT_COMPLETION=model.COMMENCEMENT_COMPLETION;
		entity.PROJECT_QUALITY=model.PROJECT_QUALITY;
		entity.MODIFICATION=model.MODIFICATION;
		entity.PRICE_REGULATION=model.PRICE_REGULATION;
		entity.MEASUREMENT_PAYMENT=model.MEASUREMENT_PAYMENT;
		entity.COMPLETION_ACCEPTANCE=model.COMPLETION_ACCEPTANCE;
		entity.INSURANCE=model.INSURANCE;
		entity.BREACH_CONTRACT=model.BREACH_CONTRACT;
		entity.DISPUTE_RESOLUTION=model.DISPUTE_RESOLUTION;
		entity.LAND_PROTECTION=model.LAND_PROTECTION;
		entity.DELIVERY_TIME_LIMIT=model.DELIVERY_TIME_LIMIT;
		entity.OTHER_CONVENTIONS=model.OTHER_CONVENTIONS;
		entity.SUPPLY_ITEM=model.SUPPLY_ITEM;
		entity.BILL_OF_QUANTITIES=model.BILL_OF_QUANTITIES;
		entity.DRAWING=model.DRAWING;
		entity.TECHNICAL_SPECIFICATIONS=model.TECHNICAL_SPECIFICATIONS;
		entity.SUPPLY_TECHNICAL_STANDARD=model.SUPPLY_TECHNICAL_STANDARD;
		entity.ENCLOSURE1=model.ENCLOSURE1;
		entity.ENCLOSURE2=model.ENCLOSURE2;
		entity.ENCLOSURE3=model.ENCLOSURE3;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
		entity.E1_NUMBER=model.E1_NUMBER;
		entity.E2_NUMBER=model.E2_NUMBER;
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
        public GeneralResult Add(JT_GENRAL_CON_TENDER_FILE model)
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
                    Delete(JT_GENRAL_CON_TENDER_FILE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JT_GENRAL_CON_TENDER_FILE> model)
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
       	protected WhereClipBuilder ConditionBuilder(JT_GENRAL_CON_TENDER_FILE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(model.LIMITE_ALL_TIME!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.LIMITE_ALL_TIME==(model.LIMITE_ALL_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.LIMITE_TIME_UNIT))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.LIMITE_TIME_UNIT.Contain(model.LIMITE_TIME_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.FIRST_ENVELOPES_CONFIRM))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.FIRST_ENVELOPES_CONFIRM.Contain(model.FIRST_ENVELOPES_CONFIRM));
				}
				if(model.WIN_BID_NUMBER!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.WIN_BID_NUMBER==(model.WIN_BID_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALI_REQUIRE1))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.QUALI_REQUIRE1.Contain(model.QUALI_REQUIRE1));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALI_REQUIRE2))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.QUALI_REQUIRE2.Contain(model.QUALI_REQUIRE2));
				}
				if(model.REPUTATION_TIME1!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.REPUTATION_TIME1==(model.REPUTATION_TIME1));
				}
				if(model.REPUTATION_TIME2!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.REPUTATION_TIME2==(model.REPUTATION_TIME2));
				}
				if(!string.IsNullOrWhiteSpace(model.MANAGER_TITLE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.MANAGER_TITLE.Contain(model.MANAGER_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.MANAGER_TITLE_LEVEL))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.MANAGER_TITLE_LEVEL.Contain(model.MANAGER_TITLE_LEVEL));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCTOR_MAJOR))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.CONSTRUCTOR_MAJOR.Contain(model.CONSTRUCTOR_MAJOR));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCTOR_MAJOR_LEVEL))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.CONSTRUCTOR_MAJOR_LEVEL.Contain(model.CONSTRUCTOR_MAJOR_LEVEL));
				}
				if(model.MANAGER_AGE!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.MANAGER_AGE==(model.MANAGER_AGE));
				}
				if(!string.IsNullOrWhiteSpace(model.TECH_TITLE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.TECH_TITLE.Contain(model.TECH_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.TECH_TITLE_LEVEL))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.TECH_TITLE_LEVEL.Contain(model.TECH_TITLE_LEVEL));
				}
				if(model.TECH_AGE!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.TECH_AGE==(model.TECH_AGE));
				}
				if(!string.IsNullOrWhiteSpace(model.DELAY_PENALTY))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.DELAY_PENALTY.Contain(model.DELAY_PENALTY));
				}
				if(!string.IsNullOrWhiteSpace(model.LIQUID_DAMAGE_RATE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.LIQUID_DAMAGE_RATE.Contain(model.LIQUID_DAMAGE_RATE));
				}
				if(!string.IsNullOrWhiteSpace(model.MINIMUM_LIMIT))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.MINIMUM_LIMIT.Contain(model.MINIMUM_LIMIT));
				}
				if(model.DEFECT_LIABILITY_PERIOD!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.DEFECT_LIABILITY_PERIOD==(model.DEFECT_LIABILITY_PERIOD));
				}
				if(model.BEGIN_ALL_DATE!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.BEGIN_ALL_DATE==(model.BEGIN_ALL_DATE));
				}
				if(model.END_DATE!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.END_DATE==(model.END_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.FUND_IMPLEMENTATION))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.FUND_IMPLEMENTATION.Contain(model.FUND_IMPLEMENTATION));
				}
				if(model.TOTAL_SECTION_NUMBER!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.TOTAL_SECTION_NUMBER==(model.TOTAL_SECTION_NUMBER));
				}
				if(model.TENDERER_BID_SECTION!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.TENDERER_BID_SECTION==(model.TENDERER_BID_SECTION));
				}
				if(model.CONSTRUCTION_BUDGET_PRICE!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.CONSTRUCTION_BUDGET_PRICE==(model.CONSTRUCTION_BUDGET_PRICE));
				}
				if(model.CONTRACT_PRICE!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.CONTRACT_PRICE==(model.CONTRACT_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_SEGMENT))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.CONTRACT_SEGMENT.Contain(model.CONTRACT_SEGMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_NUMBER))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.TENDER_NUMBER.Contain(model.TENDER_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.MARGIN_NAME.Contain(model.MARGIN_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.MARGIN_NUMBER.Contain(model.MARGIN_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.MARGIN_BANK.Contain(model.MARGIN_BANK));
				}
				if(model.MARGIN_TIME!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.MARGIN_TIME==(model.MARGIN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.INTEREST_MODE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.INTEREST_MODE.Contain(model.INTEREST_MODE));
				}
				if(model.INTEREST_CALCULATION_CYCLE!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.INTEREST_CALCULATION_CYCLE==(model.INTEREST_CALCULATION_CYCLE));
				}
				if(model.MONEY_RATE!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.MONEY_RATE==(model.MONEY_RATE));
				}
				if(!string.IsNullOrWhiteSpace(model.MEDIA1))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.MEDIA1.Contain(model.MEDIA1));
				}
				if(!string.IsNullOrWhiteSpace(model.MEDIA2))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.MEDIA2.Contain(model.MEDIA2));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATING_METHOD_STANDARD))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.EVALUATING_METHOD_STANDARD.Contain(model.EVALUATING_METHOD_STANDARD));
				}
				if(!string.IsNullOrWhiteSpace(model.MATERIAL_PRICE_ADJUSTED))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.MATERIAL_PRICE_ADJUSTED.Contain(model.MATERIAL_PRICE_ADJUSTED));
				}
				if(!string.IsNullOrWhiteSpace(model.BASE_PRICE_CITY))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.BASE_PRICE_CITY.Contain(model.BASE_PRICE_CITY));
				}
				if(!string.IsNullOrWhiteSpace(model.RELEASE_PRICE_CITY))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.RELEASE_PRICE_CITY.Contain(model.RELEASE_PRICE_CITY));
				}
				if(!string.IsNullOrWhiteSpace(model.NO_RELEASE_PRICE_CITY))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.NO_RELEASE_PRICE_CITY.Contain(model.NO_RELEASE_PRICE_CITY));
				}
				if(model.DEFECT_LIABILITY_PERIOD1!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.DEFECT_LIABILITY_PERIOD1==(model.DEFECT_LIABILITY_PERIOD1));
				}
				if(!string.IsNullOrWhiteSpace(model.OPEN_BID_REQURE_CHOOSE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.OPEN_BID_REQURE_CHOOSE.Contain(model.OPEN_BID_REQURE_CHOOSE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.SUPERVISE_DEPT_NAME.Contain(model.SUPERVISE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_PHONE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.SUPERVISE_DEPT_PHONE.Contain(model.SUPERVISE_DEPT_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ADDRESS))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.SUPERVISE_DEPT_ADDRESS.Contain(model.SUPERVISE_DEPT_ADDRESS));
				}
				if(model.SUPERVISE_DEPT_ZIP_CODE!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.SUPERVISE_DEPT_ZIP_CODE==(model.SUPERVISE_DEPT_ZIP_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALITY_REQUIRE1))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.QUALITY_REQUIRE1.Contain(model.QUALITY_REQUIRE1));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALITY_REQUIRE2))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.QUALITY_REQUIRE2.Contain(model.QUALITY_REQUIRE2));
				}
				if(model.SYNDICATED_NUMBER!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.SYNDICATED_NUMBER==(model.SYNDICATED_NUMBER));
				}
				if(model.QUESTION_TIME!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.QUESTION_TIME==(model.QUESTION_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_NOTICE_TIME))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.BIDDER_NOTICE_TIME.Contain(model.BIDDER_NOTICE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBCONTRACT))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.SUBCONTRACT.Contain(model.SUBCONTRACT));
				}
				if(model.TENDER_NOTICE_TIME!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.TENDER_NOTICE_TIME==(model.TENDER_NOTICE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MODIFICATION_TIME))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.MODIFICATION_TIME.Contain(model.MODIFICATION_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.FINANCIAL_YEAR_REQUIRE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.FINANCIAL_YEAR_REQUIRE.Contain(model.FINANCIAL_YEAR_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.SIMILAR_PROJECT_YEAR_REQUIRE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.SIMILAR_PROJECT_YEAR_REQUIRE.Contain(model.SIMILAR_PROJECT_YEAR_REQUIRE));
				}
				if(model.LITIGATION_REQUIRE!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.LITIGATION_REQUIRE==(model.LITIGATION_REQUIRE));
				}
				if(model.BRIBERY_RECORD_YEAR!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.BRIBERY_RECORD_YEAR==(model.BRIBERY_RECORD_YEAR));
				}
				if(model.COPY_NUMBER!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.COPY_NUMBER==(model.COPY_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.DECRYPTION_TYPE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.DECRYPTION_TYPE.Contain(model.DECRYPTION_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SEC_ENVELOPES_OPEN))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.SEC_ENVELOPES_OPEN.Contain(model.SEC_ENVELOPES_OPEN));
				}
				if(model.ALL_EXPERT_NUM!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.ALL_EXPERT_NUM==(model.ALL_EXPERT_NUM));
				}
				if(model.TENDERER_NUM!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.TENDERER_NUM==(model.TENDERER_NUM));
				}
				if(model.EXPERT_NUM!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.EXPERT_NUM==(model.EXPERT_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_LIBRARY))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.EXPERT_LIBRARY.Contain(model.EXPERT_LIBRARY));
				}
				if(!string.IsNullOrWhiteSpace(model.K_NUMBER))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.K_NUMBER.Contain(model.K_NUMBER));
				}
				if(model.HIGHEST_PRICE_DATE!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.HIGHEST_PRICE_DATE==(model.HIGHEST_PRICE_DATE));
				}
				if(model.LOWEST_PRICE_DATE!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.LOWEST_PRICE_DATE==(model.LOWEST_PRICE_DATE));
				}
				if(model.PREMIUM_RATE1!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.PREMIUM_RATE1==(model.PREMIUM_RATE1));
				}
				if(model.PREMIUM_RATE2!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.PREMIUM_RATE2==(model.PREMIUM_RATE2));
				}
				if(model.INSURED_AMOUNT!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.INSURED_AMOUNT==(model.INSURED_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.DISPUTE_DEAL_METHOD))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.DISPUTE_DEAL_METHOD.Contain(model.DISPUTE_DEAL_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.ARB_COMMISSION_NAME))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.ARB_COMMISSION_NAME.Contain(model.ARB_COMMISSION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MINIMUM_QUALIFICATIONS))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.MINIMUM_QUALIFICATIONS.Contain(model.MINIMUM_QUALIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.FINANCIAL_REQUIRE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.FINANCIAL_REQUIRE.Contain(model.FINANCIAL_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHIEVEMENT_REQUIRE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.ACHIEVEMENT_REQUIRE.Contain(model.ACHIEVEMENT_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.REPUTATION_REQUIRE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.REPUTATION_REQUIRE.Contain(model.REPUTATION_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALIFICATION_REQUIRE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.QUALIFICATION_REQUIRE.Contain(model.QUALIFICATION_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_QUALIFICATION_REQUIRE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.OTHER_QUALIFICATION_REQUIRE.Contain(model.OTHER_QUALIFICATION_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.EQUIPMENT_REQUIRE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.EQUIPMENT_REQUIRE.Contain(model.EQUIPMENT_REQUIRE));
				}
				if(model.BID_EVALUATION!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.BID_EVALUATION==(model.BID_EVALUATION));
				}
				if(model.CREDIT!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.CREDIT==(model.CREDIT));
				}
				if(model.CREDIT_RATING_AA_YEAR!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.CREDIT_RATING_AA_YEAR==(model.CREDIT_RATING_AA_YEAR));
				}
				if(model.CREDIT_RATING_A_YEAR!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.CREDIT_RATING_A_YEAR==(model.CREDIT_RATING_A_YEAR));
				}
				if(model.CREDIT_RATING_B_YEAR!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.CREDIT_RATING_B_YEAR==(model.CREDIT_RATING_B_YEAR));
				}
				if(model.CREDIT_RATING_W_YEAR!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.CREDIT_RATING_W_YEAR==(model.CREDIT_RATING_W_YEAR));
				}
				if(model.CREDIT_RATING_BW_YEAR!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.CREDIT_RATING_BW_YEAR==(model.CREDIT_RATING_BW_YEAR));
				}
				if(model.CREDIT_RATING_CD_YEAR!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.CREDIT_RATING_CD_YEAR==(model.CREDIT_RATING_CD_YEAR));
				}
				if(model.CREDIT_RATING_AAAW_YEAR!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.CREDIT_RATING_AAAW_YEAR==(model.CREDIT_RATING_AAAW_YEAR));
				}
				if(model.CREDIT_RATING_AAA_YEAR!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.CREDIT_RATING_AAA_YEAR==(model.CREDIT_RATING_AAA_YEAR));
				}
				if(!string.IsNullOrWhiteSpace(model.CHANGE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.CHANGE.Contain(model.CHANGE));
				}
				if(!string.IsNullOrWhiteSpace(model.GENERAL_CONTRACT))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.GENERAL_CONTRACT.Contain(model.GENERAL_CONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISOR))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.SUPERVISOR.Contain(model.SUPERVISOR));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACTOR))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.CONTRACTOR.Contain(model.CONTRACTOR));
				}
				if(!string.IsNullOrWhiteSpace(model.MATERIAL_PROJECT_EQUIPMENT))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.MATERIAL_PROJECT_EQUIPMENT.Contain(model.MATERIAL_PROJECT_EQUIPMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCT_EQUIP_TEMP_FACIL))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.CONSTRUCT_EQUIP_TEMP_FACIL.Contain(model.CONSTRUCT_EQUIP_TEMP_FACIL));
				}
				if(!string.IsNullOrWhiteSpace(model.TRANSPORTATION))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.TRANSPORTATION.Contain(model.TRANSPORTATION));
				}
				if(!string.IsNullOrWhiteSpace(model.SAFE_SECURITY_ENVIRON_PRO))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.SAFE_SECURITY_ENVIRON_PRO.Contain(model.SAFE_SECURITY_ENVIRON_PRO));
				}
				if(!string.IsNullOrWhiteSpace(model.SCHEDULE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.SCHEDULE.Contain(model.SCHEDULE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMMENCEMENT_COMPLETION))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.COMMENCEMENT_COMPLETION.Contain(model.COMMENCEMENT_COMPLETION));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_QUALITY))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.PROJECT_QUALITY.Contain(model.PROJECT_QUALITY));
				}
				if(!string.IsNullOrWhiteSpace(model.MODIFICATION))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.MODIFICATION.Contain(model.MODIFICATION));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_REGULATION))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.PRICE_REGULATION.Contain(model.PRICE_REGULATION));
				}
				if(!string.IsNullOrWhiteSpace(model.MEASUREMENT_PAYMENT))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.MEASUREMENT_PAYMENT.Contain(model.MEASUREMENT_PAYMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLETION_ACCEPTANCE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.COMPLETION_ACCEPTANCE.Contain(model.COMPLETION_ACCEPTANCE));
				}
				if(!string.IsNullOrWhiteSpace(model.INSURANCE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.INSURANCE.Contain(model.INSURANCE));
				}
				if(!string.IsNullOrWhiteSpace(model.BREACH_CONTRACT))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.BREACH_CONTRACT.Contain(model.BREACH_CONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.DISPUTE_RESOLUTION))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.DISPUTE_RESOLUTION.Contain(model.DISPUTE_RESOLUTION));
				}
				if(!string.IsNullOrWhiteSpace(model.LAND_PROTECTION))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.LAND_PROTECTION.Contain(model.LAND_PROTECTION));
				}
				if(!string.IsNullOrWhiteSpace(model.DELIVERY_TIME_LIMIT))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.DELIVERY_TIME_LIMIT.Contain(model.DELIVERY_TIME_LIMIT));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_CONVENTIONS))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.OTHER_CONVENTIONS.Contain(model.OTHER_CONVENTIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPPLY_ITEM))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.SUPPLY_ITEM.Contain(model.SUPPLY_ITEM));
				}
				if(!string.IsNullOrWhiteSpace(model.BILL_OF_QUANTITIES))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.BILL_OF_QUANTITIES.Contain(model.BILL_OF_QUANTITIES));
				}
				if(!string.IsNullOrWhiteSpace(model.DRAWING))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.DRAWING.Contain(model.DRAWING));
				}
				if(!string.IsNullOrWhiteSpace(model.TECHNICAL_SPECIFICATIONS))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.TECHNICAL_SPECIFICATIONS.Contain(model.TECHNICAL_SPECIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPPLY_TECHNICAL_STANDARD))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.SUPPLY_TECHNICAL_STANDARD.Contain(model.SUPPLY_TECHNICAL_STANDARD));
				}
				if(!string.IsNullOrWhiteSpace(model.ENCLOSURE1))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.ENCLOSURE1.Contain(model.ENCLOSURE1));
				}
				if(!string.IsNullOrWhiteSpace(model.ENCLOSURE2))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.ENCLOSURE2.Contain(model.ENCLOSURE2));
				}
				if(!string.IsNullOrWhiteSpace(model.ENCLOSURE3))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.ENCLOSURE3.Contain(model.ENCLOSURE3));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.E1_NUMBER))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.E1_NUMBER.Contain(model.E1_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.E2_NUMBER))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.E2_NUMBER.Contain(model.E2_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(JT_GENRAL_CON_TENDER_FILE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}