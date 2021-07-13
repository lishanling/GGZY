using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JtOrdMainTenderFileService : BaseServiceT<JT_ORD_MAIN_TENDER_FILE>
    {
        #region 接口实现
        
		public List<JT_ORD_MAIN_TENDER_FILE> FindList(JT_ORD_MAIN_TENDER_FILE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JT_ORD_MAIN_TENDER_FILE> PageList(JT_ORD_MAIN_TENDER_FILE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JT_ORD_MAIN_TENDER_FILE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(JT_ORD_MAIN_TENDER_FILE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(JT_ORD_MAIN_TENDER_FILE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is JT_ORD_MAIN_TENDER_FILE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.LIMITE_ALL_TIME=model.LIMITE_ALL_TIME;
		entity.DEFECT_LIABILITY_PERIOD=model.DEFECT_LIABILITY_PERIOD;
		entity.BEGIN_ALL_DATE=model.BEGIN_ALL_DATE;
		entity.END_DATE=model.END_DATE;
		entity.LIMITE_TIME_UNIT=model.LIMITE_TIME_UNIT;
		entity.SYNDICATED_NUMBER=model.SYNDICATED_NUMBER;
		entity.OPEN_BID_REQURE_CHOOSE=model.OPEN_BID_REQURE_CHOOSE;
		entity.OPEN_BID_REQURE_CERT=model.OPEN_BID_REQURE_CERT;
		entity.FINANCE_YEAR=model.FINANCE_YEAR;
		entity.REPUTATION_TIME1=model.REPUTATION_TIME1;
		entity.REPUTATION_TIME2=model.REPUTATION_TIME2;
		entity.MANAGER_TITLE=model.MANAGER_TITLE;
		entity.MANAGER_TITLE_LEVEL=model.MANAGER_TITLE_LEVEL;
		entity.MANAGER_AGE=model.MANAGER_AGE;
		entity.CONSTRUCTOR_MAJOR=model.CONSTRUCTOR_MAJOR;
		entity.CONSTRUCTOR_MAJOR_LEVEL=model.CONSTRUCTOR_MAJOR_LEVEL;
		entity.TECH_TITLE=model.TECH_TITLE;
		entity.TECH_TITLE_LEVEL=model.TECH_TITLE_LEVEL;
		entity.TECH_AGE=model.TECH_AGE;
		entity.SECURITY_SELECTION_NUM=model.SECURITY_SELECTION_NUM;
		entity.SECURITY_SELECTION_AGE=model.SECURITY_SELECTION_AGE;
		entity.MATERIAL_PRICE_ADJUSTED=model.MATERIAL_PRICE_ADJUSTED;
		entity.CONTR_SUPPLE_CLAUSE=model.CONTR_SUPPLE_CLAUSE;
		entity.STANDARD_REQUIRE=model.STANDARD_REQUIRE;
		entity.ENGINEER_QUALITY_REQUIRE=model.ENGINEER_QUALITY_REQUIRE;
		entity.PROVI_SUM=model.PROVI_SUM;
		entity.BASE_PRICE_CITY=model.BASE_PRICE_CITY;
		entity.RELEASE_PRICE_CITY=model.RELEASE_PRICE_CITY;
		entity.NO_RELEASE_PRICE_CITY=model.NO_RELEASE_PRICE_CITY;
		entity.ADVANCE_AMOUNT_CONTENT=model.ADVANCE_AMOUNT_CONTENT;
		entity.PROJECT_RISKS_NAME=model.PROJECT_RISKS_NAME;
		entity.PROJECT_RISKS_APPOINT=model.PROJECT_RISKS_APPOINT;
		entity.LIABILITY_RISKS_NAME=model.LIABILITY_RISKS_NAME;
		entity.LIABILITY_RISKS_APPOINT=model.LIABILITY_RISKS_APPOINT;
		entity.LIQUIDATED_DAMAGES1=model.LIQUIDATED_DAMAGES1;
		entity.LIQUIDATED_DAMAGES2=model.LIQUIDATED_DAMAGES2;
		entity.LIQUIDATED_DAMAGES3=model.LIQUIDATED_DAMAGES3;
		entity.LIQUIDATED_DAMAGES4=model.LIQUIDATED_DAMAGES4;
		entity.LIQUIDATED_DAMAGES5=model.LIQUIDATED_DAMAGES5;
		entity.LIQUIDATED_DAMAGES6=model.LIQUIDATED_DAMAGES6;
		entity.LIQUIDATED_DAMAGES7=model.LIQUIDATED_DAMAGES7;
		entity.LIQUIDATED_DAMAGES8=model.LIQUIDATED_DAMAGES8;
		entity.KEY_CONST_EQUIPMENT=model.KEY_CONST_EQUIPMENT;
		entity.KEY_EQUIPMENT_AMOUNT=model.KEY_EQUIPMENT_AMOUNT;
		entity.OTHER_EQUIPMENT_AMOUNT=model.OTHER_EQUIPMENT_AMOUNT;
		entity.IF_CONSTRUCTOR=model.IF_CONSTRUCTOR;
		entity.ENCLOSURE1=model.ENCLOSURE1;
		entity.ENCLOSURE2=model.ENCLOSURE2;
		entity.ENCLOSURE3=model.ENCLOSURE3;
		entity.FUND_IMPLEMENTATION=model.FUND_IMPLEMENTATION;
		entity.TOTAL_SECTION_NUMBER=model.TOTAL_SECTION_NUMBER;
		entity.TENDERER_BID_SECTION=model.TENDERER_BID_SECTION;
		entity.TENDER_NUMBER=model.TENDER_NUMBER;
		entity.MARGIN_NAME=model.MARGIN_NAME;
		entity.MARGIN_NUMBER=model.MARGIN_NUMBER;
		entity.MARGIN_BANK=model.MARGIN_BANK;
		entity.MARGIN_TIME=model.MARGIN_TIME;
		entity.MEDIA1=model.MEDIA1;
		entity.MEDIA2=model.MEDIA2;
		entity.SUPERVISE_DEPT_NAME=model.SUPERVISE_DEPT_NAME;
		entity.SUPERVISE_DEPT_PHONE=model.SUPERVISE_DEPT_PHONE;
		entity.SUPERVISE_DEPT_ADDRESS=model.SUPERVISE_DEPT_ADDRESS;
		entity.SUPERVISE_DEPT_ZIP_CODE=model.SUPERVISE_DEPT_ZIP_CODE;
		entity.QUALITY_REQUIRE1=model.QUALITY_REQUIRE1;
		entity.QUALITY_REQUIRE2=model.QUALITY_REQUIRE2;
		entity.SECURITY_SELECTION=model.SECURITY_SELECTION;
		entity.SOCIAL_SECURITY_REQUIRE=model.SOCIAL_SECURITY_REQUIRE;
		entity.SUBCONTRACT=model.SUBCONTRACT;
		entity.MODIFICATION_TIME=model.MODIFICATION_TIME;
		entity.INTEREST_MODE=model.INTEREST_MODE;
		entity.INTEREST_REQUIRE=model.INTEREST_REQUIRE;
		entity.ANNUAL_DEPOSIT_REQUIRE=model.ANNUAL_DEPOSIT_REQUIRE;
		entity.BRIBERY_RECORD_YEAR=model.BRIBERY_RECORD_YEAR;
		entity.LITIGATION_REQUIRE=model.LITIGATION_REQUIRE;
		entity.COPY_NUMBER=model.COPY_NUMBER;
		entity.TENDER_OFFER_REQUIRE=model.TENDER_OFFER_REQUIRE;
		entity.ALL_EXPERT_NUM=model.ALL_EXPERT_NUM;
		entity.TENDERER_NUM=model.TENDERER_NUM;
		entity.EXPERT_NUM=model.EXPERT_NUM;
		entity.EXPERT_LIBRARY=model.EXPERT_LIBRARY;
		entity.WINNING_BIDDER_NUMBER=model.WINNING_BIDDER_NUMBER;
		entity.BOND_PRICE=model.BOND_PRICE;
		entity.SIGN_CONTRACT_TIME=model.SIGN_CONTRACT_TIME;
		entity.MINIMUM_QUALIFICATIONS=model.MINIMUM_QUALIFICATIONS;
		entity.FINANCIAL_REQUIRE=model.FINANCIAL_REQUIRE;
		entity.ACHIEVEMENT_REQUIRE=model.ACHIEVEMENT_REQUIRE;
		entity.REPUTATION_REQUIRE=model.REPUTATION_REQUIRE;
		entity.QUALIFICATION_REQUIRE=model.QUALIFICATION_REQUIRE;
		entity.OTHER_QUALIFICATION_REQUIRE=model.OTHER_QUALIFICATION_REQUIRE;
		entity.EQUIPMENT_REQUIRE=model.EQUIPMENT_REQUIRE;
		entity.EVALUATING_METHOD_STANDARD=model.EVALUATING_METHOD_STANDARD;
		entity.E1_SCORE=model.E1_SCORE;
		entity.E2_SCORE=model.E2_SCORE;
		entity.CREDIT_REQUIRE=model.CREDIT_REQUIRE;
		entity.DISPUTE_DEAL_METHOD=model.DISPUTE_DEAL_METHOD;
		entity.ARB_COMMISSION_NAME=model.ARB_COMMISSION_NAME;
		entity.SUBC_NAME=model.SUBC_NAME;
		entity.SUBC_NAME_ADDRESS=model.SUBC_NAME_ADDRESS;
		entity.SUBC_ZIP_CODE=model.SUBC_ZIP_CODE;
		entity.DEFECT_LIABILITY_PERIOD1=model.DEFECT_LIABILITY_PERIOD1;
		entity.DRAWING_MODIFICATION=model.DRAWING_MODIFICATION;
		entity.PROVIDE_MATERIALS=model.PROVIDE_MATERIALS;
		entity.MATERIAL_REGULATION=model.MATERIAL_REGULATION;
		entity.SUPPLY_EQUIPMENT=model.SUPPLY_EQUIPMENT;
		entity.EQUIPMEN_REGULATION=model.EQUIPMEN_REGULATION;
		entity.DATA_PERIOD=model.DATA_PERIOD;
		entity.APPROVAL_PERIOD=model.APPROVAL_PERIOD;
		entity.DELAY_PENALTY=model.DELAY_PENALTY;
		entity.PENALTY_QUOTA=model.PENALTY_QUOTA;
		entity.COMPLETION_BONUS=model.COMPLETION_BONUS;
		entity.BONUS_LIMIT=model.BONUS_LIMIT;
		entity.COST_SAVING=model.COST_SAVING;
		entity.INCREASE_INCOME=model.INCREASE_INCOME;
		entity.ADVANCE_AMOUNT=model.ADVANCE_AMOUNT;
		entity.MATERIAL=model.MATERIAL;
		entity.DOCUMENT_CHARGES=model.DOCUMENT_CHARGES;
		entity.SUBMIT_REQUISITION=model.SUBMIT_REQUISITION;
		entity.MONTHLY_PAYMENT=model.MONTHLY_PAYMENT;
		entity.QUALITY_MARGIN_LIMIT=model.QUALITY_MARGIN_LIMIT;
		entity.PAYMENT_APPLICATION=model.PAYMENT_APPLICATION;
		entity.APPLICATION_NUM=model.APPLICATION_NUM;
		entity.COMPLETION_DATA=model.COMPLETION_DATA;
		entity.CONSTRUCTION_PERIOD_OPERATION=model.CONSTRUCTION_PERIOD_OPERATION;
		entity.OPERATING_REGULATIONS=model.OPERATING_REGULATIONS;
		entity.TEST_RUN=model.TEST_RUN;
		entity.TEST_RUN_REGULATIONS=model.TEST_RUN_REGULATIONS;
		entity.DEFECTS_LIABILITY_PERIOD=model.DEFECTS_LIABILITY_PERIOD;
		entity.PREMIUM_RATE1=model.PREMIUM_RATE1;
		entity.MINIMUM_INSURANCE_AMOUNT=model.MINIMUM_INSURANCE_AMOUNT;
		entity.PREMIUM_RATE2=model.PREMIUM_RATE2;
		entity.BILL_OF_QUANTITIES=model.BILL_OF_QUANTITIES;
		entity.DRAWING=model.DRAWING;
		entity.TECHNICAL_SPECIFICATIONS=model.TECHNICAL_SPECIFICATIONS;
		entity.SUPPLY_TECHNICAL_STANDARD=model.SUPPLY_TECHNICAL_STANDARD;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
		entity.MINIMUM_LIMIT=model.MINIMUM_LIMIT;
		entity.CONTRACT_SEGMENT=model.CONTRACT_SEGMENT;
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
        public GeneralResult Add(JT_ORD_MAIN_TENDER_FILE model)
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
                    Delete(JT_ORD_MAIN_TENDER_FILE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JT_ORD_MAIN_TENDER_FILE> model)
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
       	protected WhereClipBuilder ConditionBuilder(JT_ORD_MAIN_TENDER_FILE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(model.LIMITE_ALL_TIME!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.LIMITE_ALL_TIME==(model.LIMITE_ALL_TIME));
				}
				if(model.DEFECT_LIABILITY_PERIOD!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.DEFECT_LIABILITY_PERIOD==(model.DEFECT_LIABILITY_PERIOD));
				}
				if(model.BEGIN_ALL_DATE!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.BEGIN_ALL_DATE==(model.BEGIN_ALL_DATE));
				}
				if(model.END_DATE!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.END_DATE==(model.END_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.LIMITE_TIME_UNIT))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.LIMITE_TIME_UNIT.Contain(model.LIMITE_TIME_UNIT));
				}
				if(model.SYNDICATED_NUMBER!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.SYNDICATED_NUMBER==(model.SYNDICATED_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.OPEN_BID_REQURE_CHOOSE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.OPEN_BID_REQURE_CHOOSE.Contain(model.OPEN_BID_REQURE_CHOOSE));
				}
				if(!string.IsNullOrWhiteSpace(model.OPEN_BID_REQURE_CERT))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.OPEN_BID_REQURE_CERT.Contain(model.OPEN_BID_REQURE_CERT));
				}
				if(!string.IsNullOrWhiteSpace(model.FINANCE_YEAR))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.FINANCE_YEAR.Contain(model.FINANCE_YEAR));
				}
				if(model.REPUTATION_TIME1!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.REPUTATION_TIME1==(model.REPUTATION_TIME1));
				}
				if(model.REPUTATION_TIME2!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.REPUTATION_TIME2==(model.REPUTATION_TIME2));
				}
				if(!string.IsNullOrWhiteSpace(model.MANAGER_TITLE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.MANAGER_TITLE.Contain(model.MANAGER_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.MANAGER_TITLE_LEVEL))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.MANAGER_TITLE_LEVEL.Contain(model.MANAGER_TITLE_LEVEL));
				}
				if(model.MANAGER_AGE!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.MANAGER_AGE==(model.MANAGER_AGE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCTOR_MAJOR))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.CONSTRUCTOR_MAJOR.Contain(model.CONSTRUCTOR_MAJOR));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCTOR_MAJOR_LEVEL))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.CONSTRUCTOR_MAJOR_LEVEL.Contain(model.CONSTRUCTOR_MAJOR_LEVEL));
				}
				if(!string.IsNullOrWhiteSpace(model.TECH_TITLE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.TECH_TITLE.Contain(model.TECH_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.TECH_TITLE_LEVEL))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.TECH_TITLE_LEVEL.Contain(model.TECH_TITLE_LEVEL));
				}
				if(model.TECH_AGE!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.TECH_AGE==(model.TECH_AGE));
				}
				if(model.SECURITY_SELECTION_NUM!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.SECURITY_SELECTION_NUM==(model.SECURITY_SELECTION_NUM));
				}
				if(model.SECURITY_SELECTION_AGE!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.SECURITY_SELECTION_AGE==(model.SECURITY_SELECTION_AGE));
				}
				if(!string.IsNullOrWhiteSpace(model.MATERIAL_PRICE_ADJUSTED))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.MATERIAL_PRICE_ADJUSTED.Contain(model.MATERIAL_PRICE_ADJUSTED));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTR_SUPPLE_CLAUSE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.CONTR_SUPPLE_CLAUSE.Contain(model.CONTR_SUPPLE_CLAUSE));
				}
				if(!string.IsNullOrWhiteSpace(model.STANDARD_REQUIRE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.STANDARD_REQUIRE.Contain(model.STANDARD_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.ENGINEER_QUALITY_REQUIRE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.ENGINEER_QUALITY_REQUIRE.Contain(model.ENGINEER_QUALITY_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROVI_SUM))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.PROVI_SUM.Contain(model.PROVI_SUM));
				}
				if(!string.IsNullOrWhiteSpace(model.BASE_PRICE_CITY))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.BASE_PRICE_CITY.Contain(model.BASE_PRICE_CITY));
				}
				if(!string.IsNullOrWhiteSpace(model.RELEASE_PRICE_CITY))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.RELEASE_PRICE_CITY.Contain(model.RELEASE_PRICE_CITY));
				}
				if(!string.IsNullOrWhiteSpace(model.NO_RELEASE_PRICE_CITY))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.NO_RELEASE_PRICE_CITY.Contain(model.NO_RELEASE_PRICE_CITY));
				}
				if(!string.IsNullOrWhiteSpace(model.ADVANCE_AMOUNT_CONTENT))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.ADVANCE_AMOUNT_CONTENT.Contain(model.ADVANCE_AMOUNT_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_RISKS_NAME))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.PROJECT_RISKS_NAME.Contain(model.PROJECT_RISKS_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_RISKS_APPOINT))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.PROJECT_RISKS_APPOINT.Contain(model.PROJECT_RISKS_APPOINT));
				}
				if(!string.IsNullOrWhiteSpace(model.LIABILITY_RISKS_NAME))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.LIABILITY_RISKS_NAME.Contain(model.LIABILITY_RISKS_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.LIABILITY_RISKS_APPOINT))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.LIABILITY_RISKS_APPOINT.Contain(model.LIABILITY_RISKS_APPOINT));
				}
				if(model.LIQUIDATED_DAMAGES1!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.LIQUIDATED_DAMAGES1==(model.LIQUIDATED_DAMAGES1));
				}
				if(model.LIQUIDATED_DAMAGES2!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.LIQUIDATED_DAMAGES2==(model.LIQUIDATED_DAMAGES2));
				}
				if(model.LIQUIDATED_DAMAGES3!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.LIQUIDATED_DAMAGES3==(model.LIQUIDATED_DAMAGES3));
				}
				if(model.LIQUIDATED_DAMAGES4!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.LIQUIDATED_DAMAGES4==(model.LIQUIDATED_DAMAGES4));
				}
				if(model.LIQUIDATED_DAMAGES5!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.LIQUIDATED_DAMAGES5==(model.LIQUIDATED_DAMAGES5));
				}
				if(model.LIQUIDATED_DAMAGES6!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.LIQUIDATED_DAMAGES6==(model.LIQUIDATED_DAMAGES6));
				}
				if(model.LIQUIDATED_DAMAGES7!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.LIQUIDATED_DAMAGES7==(model.LIQUIDATED_DAMAGES7));
				}
				if(model.LIQUIDATED_DAMAGES8!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.LIQUIDATED_DAMAGES8==(model.LIQUIDATED_DAMAGES8));
				}
				if(!string.IsNullOrWhiteSpace(model.KEY_CONST_EQUIPMENT))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.KEY_CONST_EQUIPMENT.Contain(model.KEY_CONST_EQUIPMENT));
				}
				if(model.KEY_EQUIPMENT_AMOUNT!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.KEY_EQUIPMENT_AMOUNT==(model.KEY_EQUIPMENT_AMOUNT));
				}
				if(model.OTHER_EQUIPMENT_AMOUNT!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.OTHER_EQUIPMENT_AMOUNT==(model.OTHER_EQUIPMENT_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.IF_CONSTRUCTOR))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.IF_CONSTRUCTOR.Contain(model.IF_CONSTRUCTOR));
				}
				if(!string.IsNullOrWhiteSpace(model.ENCLOSURE1))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.ENCLOSURE1.Contain(model.ENCLOSURE1));
				}
				if(!string.IsNullOrWhiteSpace(model.ENCLOSURE2))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.ENCLOSURE2.Contain(model.ENCLOSURE2));
				}
				if(!string.IsNullOrWhiteSpace(model.ENCLOSURE3))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.ENCLOSURE3.Contain(model.ENCLOSURE3));
				}
				if(!string.IsNullOrWhiteSpace(model.FUND_IMPLEMENTATION))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.FUND_IMPLEMENTATION.Contain(model.FUND_IMPLEMENTATION));
				}
				if(model.TOTAL_SECTION_NUMBER!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.TOTAL_SECTION_NUMBER==(model.TOTAL_SECTION_NUMBER));
				}
				if(model.TENDERER_BID_SECTION!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.TENDERER_BID_SECTION==(model.TENDERER_BID_SECTION));
				}
				if(model.TENDER_NUMBER!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.TENDER_NUMBER==(model.TENDER_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.MARGIN_NAME.Contain(model.MARGIN_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.MARGIN_NUMBER.Contain(model.MARGIN_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.MARGIN_BANK.Contain(model.MARGIN_BANK));
				}
				if(model.MARGIN_TIME!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.MARGIN_TIME==(model.MARGIN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MEDIA1))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.MEDIA1.Contain(model.MEDIA1));
				}
				if(!string.IsNullOrWhiteSpace(model.MEDIA2))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.MEDIA2.Contain(model.MEDIA2));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.SUPERVISE_DEPT_NAME.Contain(model.SUPERVISE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_PHONE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.SUPERVISE_DEPT_PHONE.Contain(model.SUPERVISE_DEPT_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ADDRESS))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.SUPERVISE_DEPT_ADDRESS.Contain(model.SUPERVISE_DEPT_ADDRESS));
				}
				if(model.SUPERVISE_DEPT_ZIP_CODE!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.SUPERVISE_DEPT_ZIP_CODE==(model.SUPERVISE_DEPT_ZIP_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALITY_REQUIRE1))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.QUALITY_REQUIRE1.Contain(model.QUALITY_REQUIRE1));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALITY_REQUIRE2))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.QUALITY_REQUIRE2.Contain(model.QUALITY_REQUIRE2));
				}
				if(!string.IsNullOrWhiteSpace(model.SECURITY_SELECTION))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.SECURITY_SELECTION.Contain(model.SECURITY_SELECTION));
				}
				if(!string.IsNullOrWhiteSpace(model.SOCIAL_SECURITY_REQUIRE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.SOCIAL_SECURITY_REQUIRE.Contain(model.SOCIAL_SECURITY_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBCONTRACT))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.SUBCONTRACT.Contain(model.SUBCONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.MODIFICATION_TIME))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.MODIFICATION_TIME.Contain(model.MODIFICATION_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.INTEREST_MODE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.INTEREST_MODE.Contain(model.INTEREST_MODE));
				}
				if(!string.IsNullOrWhiteSpace(model.INTEREST_REQUIRE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.INTEREST_REQUIRE.Contain(model.INTEREST_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.ANNUAL_DEPOSIT_REQUIRE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.ANNUAL_DEPOSIT_REQUIRE.Contain(model.ANNUAL_DEPOSIT_REQUIRE));
				}
				if(model.BRIBERY_RECORD_YEAR!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.BRIBERY_RECORD_YEAR==(model.BRIBERY_RECORD_YEAR));
				}
				if(model.LITIGATION_REQUIRE!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.LITIGATION_REQUIRE==(model.LITIGATION_REQUIRE));
				}
				if(model.COPY_NUMBER!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.COPY_NUMBER==(model.COPY_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_OFFER_REQUIRE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.TENDER_OFFER_REQUIRE.Contain(model.TENDER_OFFER_REQUIRE));
				}
				if(model.ALL_EXPERT_NUM!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.ALL_EXPERT_NUM==(model.ALL_EXPERT_NUM));
				}
				if(model.TENDERER_NUM!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.TENDERER_NUM==(model.TENDERER_NUM));
				}
				if(model.EXPERT_NUM!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.EXPERT_NUM==(model.EXPERT_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_LIBRARY))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.EXPERT_LIBRARY.Contain(model.EXPERT_LIBRARY));
				}
				if(model.WINNING_BIDDER_NUMBER!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.WINNING_BIDDER_NUMBER==(model.WINNING_BIDDER_NUMBER));
				}
				if(model.BOND_PRICE!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.BOND_PRICE==(model.BOND_PRICE));
				}
				if(model.SIGN_CONTRACT_TIME!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.SIGN_CONTRACT_TIME==(model.SIGN_CONTRACT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MINIMUM_QUALIFICATIONS))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.MINIMUM_QUALIFICATIONS.Contain(model.MINIMUM_QUALIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.FINANCIAL_REQUIRE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.FINANCIAL_REQUIRE.Contain(model.FINANCIAL_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHIEVEMENT_REQUIRE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.ACHIEVEMENT_REQUIRE.Contain(model.ACHIEVEMENT_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.REPUTATION_REQUIRE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.REPUTATION_REQUIRE.Contain(model.REPUTATION_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALIFICATION_REQUIRE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.QUALIFICATION_REQUIRE.Contain(model.QUALIFICATION_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_QUALIFICATION_REQUIRE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.OTHER_QUALIFICATION_REQUIRE.Contain(model.OTHER_QUALIFICATION_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.EQUIPMENT_REQUIRE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.EQUIPMENT_REQUIRE.Contain(model.EQUIPMENT_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATING_METHOD_STANDARD))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.EVALUATING_METHOD_STANDARD.Contain(model.EVALUATING_METHOD_STANDARD));
				}
				if(model.E1_SCORE!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.E1_SCORE==(model.E1_SCORE));
				}
				if(model.E2_SCORE!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.E2_SCORE==(model.E2_SCORE));
				}
				if(!string.IsNullOrWhiteSpace(model.CREDIT_REQUIRE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.CREDIT_REQUIRE.Contain(model.CREDIT_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.DISPUTE_DEAL_METHOD))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.DISPUTE_DEAL_METHOD.Contain(model.DISPUTE_DEAL_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.ARB_COMMISSION_NAME))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.ARB_COMMISSION_NAME.Contain(model.ARB_COMMISSION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBC_NAME))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.SUBC_NAME.Contain(model.SUBC_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBC_NAME_ADDRESS))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.SUBC_NAME_ADDRESS.Contain(model.SUBC_NAME_ADDRESS));
				}
				if(model.SUBC_ZIP_CODE!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.SUBC_ZIP_CODE==(model.SUBC_ZIP_CODE));
				}
				if(model.DEFECT_LIABILITY_PERIOD1!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.DEFECT_LIABILITY_PERIOD1==(model.DEFECT_LIABILITY_PERIOD1));
				}
				if(model.DRAWING_MODIFICATION!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.DRAWING_MODIFICATION==(model.DRAWING_MODIFICATION));
				}
				if(!string.IsNullOrWhiteSpace(model.PROVIDE_MATERIALS))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.PROVIDE_MATERIALS.Contain(model.PROVIDE_MATERIALS));
				}
				if(!string.IsNullOrWhiteSpace(model.MATERIAL_REGULATION))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.MATERIAL_REGULATION.Contain(model.MATERIAL_REGULATION));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPPLY_EQUIPMENT))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.SUPPLY_EQUIPMENT.Contain(model.SUPPLY_EQUIPMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.EQUIPMEN_REGULATION))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.EQUIPMEN_REGULATION.Contain(model.EQUIPMEN_REGULATION));
				}
				if(model.DATA_PERIOD!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.DATA_PERIOD==(model.DATA_PERIOD));
				}
				if(model.APPROVAL_PERIOD!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.APPROVAL_PERIOD==(model.APPROVAL_PERIOD));
				}
				if(model.DELAY_PENALTY!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.DELAY_PENALTY==(model.DELAY_PENALTY));
				}
				if(model.PENALTY_QUOTA!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.PENALTY_QUOTA==(model.PENALTY_QUOTA));
				}
				if(model.COMPLETION_BONUS!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.COMPLETION_BONUS==(model.COMPLETION_BONUS));
				}
				if(model.BONUS_LIMIT!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.BONUS_LIMIT==(model.BONUS_LIMIT));
				}
				if(model.COST_SAVING!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.COST_SAVING==(model.COST_SAVING));
				}
				if(model.INCREASE_INCOME!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.INCREASE_INCOME==(model.INCREASE_INCOME));
				}
				if(model.ADVANCE_AMOUNT!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.ADVANCE_AMOUNT==(model.ADVANCE_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.MATERIAL))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.MATERIAL.Contain(model.MATERIAL));
				}
				if(model.DOCUMENT_CHARGES!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.DOCUMENT_CHARGES==(model.DOCUMENT_CHARGES));
				}
				if(model.SUBMIT_REQUISITION!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.SUBMIT_REQUISITION==(model.SUBMIT_REQUISITION));
				}
				if(model.MONTHLY_PAYMENT!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.MONTHLY_PAYMENT==(model.MONTHLY_PAYMENT));
				}
				if(model.QUALITY_MARGIN_LIMIT!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.QUALITY_MARGIN_LIMIT==(model.QUALITY_MARGIN_LIMIT));
				}
				if(model.PAYMENT_APPLICATION!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.PAYMENT_APPLICATION==(model.PAYMENT_APPLICATION));
				}
				if(model.APPLICATION_NUM!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.APPLICATION_NUM==(model.APPLICATION_NUM));
				}
				if(model.COMPLETION_DATA!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.COMPLETION_DATA==(model.COMPLETION_DATA));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCTION_PERIOD_OPERATION))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.CONSTRUCTION_PERIOD_OPERATION.Contain(model.CONSTRUCTION_PERIOD_OPERATION));
				}
				if(!string.IsNullOrWhiteSpace(model.OPERATING_REGULATIONS))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.OPERATING_REGULATIONS.Contain(model.OPERATING_REGULATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.TEST_RUN))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.TEST_RUN.Contain(model.TEST_RUN));
				}
				if(!string.IsNullOrWhiteSpace(model.TEST_RUN_REGULATIONS))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.TEST_RUN_REGULATIONS.Contain(model.TEST_RUN_REGULATIONS));
				}
				if(model.DEFECTS_LIABILITY_PERIOD!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.DEFECTS_LIABILITY_PERIOD==(model.DEFECTS_LIABILITY_PERIOD));
				}
				if(model.PREMIUM_RATE1!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.PREMIUM_RATE1==(model.PREMIUM_RATE1));
				}
				if(model.MINIMUM_INSURANCE_AMOUNT!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.MINIMUM_INSURANCE_AMOUNT==(model.MINIMUM_INSURANCE_AMOUNT));
				}
				if(model.PREMIUM_RATE2!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.PREMIUM_RATE2==(model.PREMIUM_RATE2));
				}
				if(!string.IsNullOrWhiteSpace(model.BILL_OF_QUANTITIES))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.BILL_OF_QUANTITIES.Contain(model.BILL_OF_QUANTITIES));
				}
				if(!string.IsNullOrWhiteSpace(model.DRAWING))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.DRAWING.Contain(model.DRAWING));
				}
				if(!string.IsNullOrWhiteSpace(model.TECHNICAL_SPECIFICATIONS))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.TECHNICAL_SPECIFICATIONS.Contain(model.TECHNICAL_SPECIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPPLY_TECHNICAL_STANDARD))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.SUPPLY_TECHNICAL_STANDARD.Contain(model.SUPPLY_TECHNICAL_STANDARD));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.MINIMUM_LIMIT))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.MINIMUM_LIMIT.Contain(model.MINIMUM_LIMIT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_SEGMENT))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.CONTRACT_SEGMENT.Contain(model.CONTRACT_SEGMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(JT_ORD_MAIN_TENDER_FILE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}