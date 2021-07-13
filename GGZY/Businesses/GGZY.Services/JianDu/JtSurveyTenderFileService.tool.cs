using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JtSurveyTenderFileService : BaseServiceT<JT_SURVEY_TENDER_FILE>
    {
        #region 接口实现
        
		public List<JT_SURVEY_TENDER_FILE> FindList(JT_SURVEY_TENDER_FILE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JT_SURVEY_TENDER_FILE> PageList(JT_SURVEY_TENDER_FILE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JT_SURVEY_TENDER_FILE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(JT_SURVEY_TENDER_FILE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(JT_SURVEY_TENDER_FILE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is JT_SURVEY_TENDER_FILE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.FUND_IMPLEMENTATION=model.FUND_IMPLEMENTATION;
		entity.QUALITY_REQUIRE=model.QUALITY_REQUIRE;
		entity.SUR_DES_TYPE=model.SUR_DES_TYPE;
		entity.LIMITE_ALL_TIME=model.LIMITE_ALL_TIME;
		entity.PROJECT_PROFILE=model.PROJECT_PROFILE;
		entity.TOTAL_SECTION_NUMBER=model.TOTAL_SECTION_NUMBER;
		entity.TENDERER_SECTION_NUMBER=model.TENDERER_SECTION_NUMBER;
		entity.RECONNAISSANCE_CYCLE=model.RECONNAISSANCE_CYCLE;
		entity.SURVEY_TENDER_CONTENT=model.SURVEY_TENDER_CONTENT;
		entity.DESIGN_TENDER_CONTENT=model.DESIGN_TENDER_CONTENT;
		entity.NUMBER_UNIONS=model.NUMBER_UNIONS;
		entity.TRADING_CENTER_NAME=model.TRADING_CENTER_NAME;
		entity.MINIMUM_QUALIFICATIONS=model.MINIMUM_QUALIFICATIONS;
		entity.FINANCIAL_REQUIRE=model.FINANCIAL_REQUIRE;
		entity.ACHIEVEMENT_REQUIRE=model.ACHIEVEMENT_REQUIRE;
		entity.REPUTATION_REQUIRE=model.REPUTATION_REQUIRE;
		entity.OTHER_REQUIRE=model.OTHER_REQUIRE;
		entity.MANAGE_TECHNOLOGY_REQUIRE=model.MANAGE_TECHNOLOGY_REQUIRE;
		entity.SUBMIT_DESIGN_DAYS=model.SUBMIT_DESIGN_DAYS;
		entity.MODIFY_DESIGN_DAYS=model.MODIFY_DESIGN_DAYS;
		entity.SUBMIT_CONSTRUCT_DAYS=model.SUBMIT_CONSTRUCT_DAYS;
		entity.MODIFY_CONSTRUCT_DAYS=model.MODIFY_CONSTRUCT_DAYS;
		entity.DESIGN_PERFORMANCE=model.DESIGN_PERFORMANCE;
		entity.MANAGER_QUALIFICAT_TITLE=model.MANAGER_QUALIFICAT_TITLE;
		entity.MARGIN_NAME1=model.MARGIN_NAME1;
		entity.MARGIN_NUMBER1=model.MARGIN_NUMBER1;
		entity.MARGIN_BANK1=model.MARGIN_BANK1;
		entity.MARGIN_NAME2=model.MARGIN_NAME2;
		entity.MARGIN_NUMBER2=model.MARGIN_NUMBER2;
		entity.MARGIN_BANK2=model.MARGIN_BANK2;
		entity.MARGIN_NAME3=model.MARGIN_NAME3;
		entity.MARGIN_NUMBER3=model.MARGIN_NUMBER3;
		entity.MARGIN_BANK3=model.MARGIN_BANK3;
		entity.TENDERER_BANK=model.TENDERER_BANK;
		entity.TENDERER_ACCOUNT=model.TENDERER_ACCOUNT;
		entity.TENDER_AGENCY_BANK=model.TENDER_AGENCY_BANK;
		entity.TENDER_AGENCY_ACCOUNT=model.TENDER_AGENCY_ACCOUNT;
		entity.SUBCONTRACT=model.SUBCONTRACT;
		entity.SUBCONTRACT_CONTENT_REQUIRE=model.SUBCONTRACT_CONTENT_REQUIRE;
		entity.SUB_QUALIFI_REQUIRE=model.SUB_QUALIFI_REQUIRE;
		entity.QUESTION_TIME=model.QUESTION_TIME;
		entity.TENDER_NOTICE_TIME=model.TENDER_NOTICE_TIME;
		entity.BIDDER_NOTICE_TIME=model.BIDDER_NOTICE_TIME;
		entity.ALL_EXPERT_NUM=model.ALL_EXPERT_NUM;
		entity.TENDERER_NUM=model.TENDERER_NUM;
		entity.EXPERT_NUM=model.EXPERT_NUM;
		entity.EVALUATING_METHOD=model.EVALUATING_METHOD;
		entity.EXPERT_DETERMIN_BIDDER=model.EXPERT_DETERMIN_BIDDER;
		entity.IS_PERFORM_PRICE=model.IS_PERFORM_PRICE;
		entity.PERFORM_PRICE=model.PERFORM_PRICE;
		entity.PERFORMANCE_BOND_FORM=model.PERFORMANCE_BOND_FORM;
		entity.SUPERVISE_DEPT_NAME1=model.SUPERVISE_DEPT_NAME1;
		entity.SUPERVISE_DEPT_PHONE1=model.SUPERVISE_DEPT_PHONE1;
		entity.SUPERVISE_ADDRESS1=model.SUPERVISE_ADDRESS1;
		entity.SUPERVISE_FAX1=model.SUPERVISE_FAX1;
		entity.SUPERVISE_ZIP_CODE1=model.SUPERVISE_ZIP_CODE1;
		entity.SUPERVISE_DEPT_NAME2=model.SUPERVISE_DEPT_NAME2;
		entity.SUPERVISE_DEPT_PHONE2=model.SUPERVISE_DEPT_PHONE2;
		entity.SUPERVISE_ADDRESS2=model.SUPERVISE_ADDRESS2;
		entity.SUPERVISE_FAX2=model.SUPERVISE_FAX2;
		entity.SUPERVISE_ZIP_CODE2=model.SUPERVISE_ZIP_CODE2;
		entity.ACCEPTING_INSTITUTION=model.ACCEPTING_INSTITUTION;
		entity.COMPLAINT_ADDRESS=model.COMPLAINT_ADDRESS;
		entity.COMPLAINTS_HOTLINE=model.COMPLAINTS_HOTLINE;
		entity.COMPLAINT_POST_CODE=model.COMPLAINT_POST_CODE;
		entity.OTHER_REQUIREMENTS=model.OTHER_REQUIREMENTS;
		entity.BONUS_CONTENT=model.BONUS_CONTENT;
		entity.CHANGE=model.CHANGE;
		entity.DEFINITION=model.DEFINITION;
		entity.EMPLOYER_DUTY=model.EMPLOYER_DUTY;
		entity.DESIGNER_DUTY=model.DESIGNER_DUTY;
		entity.SUBMISSION_RESULTS=model.SUBMISSION_RESULTS;
		entity.BREACH_CONTRACT=model.BREACH_CONTRACT;
		entity.PAYMENT=model.PAYMENT;
		entity.OTHER_CONVENTIONS=model.OTHER_CONVENTIONS;
		entity.SUPPLY_ITEM=model.SUPPLY_ITEM;
		entity.BASIC_DATA=model.BASIC_DATA;
		entity.TECHNICAL_REQUIRE=model.TECHNICAL_REQUIRE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
		entity.SUPERVISOR_DAYS=model.SUPERVISOR_DAYS;
		entity.SUPER_SIMILAR_PROJECT=model.SUPER_SIMILAR_PROJECT;
		entity.GENERAL_QUAL_LEVEL=model.GENERAL_QUAL_LEVEL;
		entity.GENERAL_TECH_TITLE=model.GENERAL_TECH_TITLE;
		entity.SUPERVISION_SERVICE_STAGE=model.SUPERVISION_SERVICE_STAGE;
		entity.SCOPE_SUPER_WORK=model.SCOPE_SUPER_WORK;
		entity.FINANCIAL_REQUIRE_YEAR=model.FINANCIAL_REQUIRE_YEAR;
		entity.SIMILAR_PROJECT_YEAR=model.SIMILAR_PROJECT_YEAR;
		entity.LITIGATION_YEAR=model.LITIGATION_YEAR;
		entity.PERFORM_TYPE=model.PERFORM_TYPE;
		entity.PERFORM_CONTENT1=model.PERFORM_CONTENT1;
		entity.PERFORM_CONTENT2=model.PERFORM_CONTENT2;
		entity.SUPERVISE_DEPT_ADDRESS1=model.SUPERVISE_DEPT_ADDRESS1;
		entity.SUPERVISE_DEPT_FAX1=model.SUPERVISE_DEPT_FAX1;
		entity.SUPERVISE_DEPT_ZIP_CODE1=model.SUPERVISE_DEPT_ZIP_CODE1;
		entity.SUPERVISE_DEPT_ADDRESS2=model.SUPERVISE_DEPT_ADDRESS2;
		entity.SUPERVISE_DEPT_FAX2=model.SUPERVISE_DEPT_FAX2;
		entity.SUPERVISE_DEPT_ZIP_CODE2=model.SUPERVISE_DEPT_ZIP_CODE2;
		entity.GENERAL_CONTRACT=model.GENERAL_CONTRACT;
		entity.SUPERVISION_SERVICE=model.SUPERVISION_SERVICE;
		entity.CONTRACT_OPERATION=model.CONTRACT_OPERATION;
		entity.MEASUREMENT_PAYMENT=model.MEASUREMENT_PAYMENT;
		entity.DISPUTE_RESOLUTION=model.DISPUTE_RESOLUTION;
		entity.SERVICE_CHARGE=model.SERVICE_CHARGE;
		entity.DRAWING=model.DRAWING;
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
        public GeneralResult Add(JT_SURVEY_TENDER_FILE model)
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
                    Delete(JT_SURVEY_TENDER_FILE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JT_SURVEY_TENDER_FILE> model)
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
       	protected WhereClipBuilder ConditionBuilder(JT_SURVEY_TENDER_FILE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.FUND_IMPLEMENTATION))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.FUND_IMPLEMENTATION.Contain(model.FUND_IMPLEMENTATION));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALITY_REQUIRE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.QUALITY_REQUIRE.Contain(model.QUALITY_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUR_DES_TYPE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUR_DES_TYPE.Contain(model.SUR_DES_TYPE));
				}
				if(model.LIMITE_ALL_TIME!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.LIMITE_ALL_TIME==(model.LIMITE_ALL_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_PROFILE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.PROJECT_PROFILE.Contain(model.PROJECT_PROFILE));
				}
				if(model.TOTAL_SECTION_NUMBER!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.TOTAL_SECTION_NUMBER==(model.TOTAL_SECTION_NUMBER));
				}
				if(model.TENDERER_SECTION_NUMBER!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.TENDERER_SECTION_NUMBER==(model.TENDERER_SECTION_NUMBER));
				}
				if(model.RECONNAISSANCE_CYCLE!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.RECONNAISSANCE_CYCLE==(model.RECONNAISSANCE_CYCLE));
				}
				if(!string.IsNullOrWhiteSpace(model.SURVEY_TENDER_CONTENT))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SURVEY_TENDER_CONTENT.Contain(model.SURVEY_TENDER_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.DESIGN_TENDER_CONTENT))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.DESIGN_TENDER_CONTENT.Contain(model.DESIGN_TENDER_CONTENT));
				}
				if(model.NUMBER_UNIONS!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.NUMBER_UNIONS==(model.NUMBER_UNIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADING_CENTER_NAME))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.TRADING_CENTER_NAME.Contain(model.TRADING_CENTER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MINIMUM_QUALIFICATIONS))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.MINIMUM_QUALIFICATIONS.Contain(model.MINIMUM_QUALIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.FINANCIAL_REQUIRE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.FINANCIAL_REQUIRE.Contain(model.FINANCIAL_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHIEVEMENT_REQUIRE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.ACHIEVEMENT_REQUIRE.Contain(model.ACHIEVEMENT_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.REPUTATION_REQUIRE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.REPUTATION_REQUIRE.Contain(model.REPUTATION_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_REQUIRE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.OTHER_REQUIRE.Contain(model.OTHER_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.MANAGE_TECHNOLOGY_REQUIRE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.MANAGE_TECHNOLOGY_REQUIRE.Contain(model.MANAGE_TECHNOLOGY_REQUIRE));
				}
				if(model.SUBMIT_DESIGN_DAYS!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUBMIT_DESIGN_DAYS==(model.SUBMIT_DESIGN_DAYS));
				}
				if(model.MODIFY_DESIGN_DAYS!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.MODIFY_DESIGN_DAYS==(model.MODIFY_DESIGN_DAYS));
				}
				if(model.SUBMIT_CONSTRUCT_DAYS!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUBMIT_CONSTRUCT_DAYS==(model.SUBMIT_CONSTRUCT_DAYS));
				}
				if(model.MODIFY_CONSTRUCT_DAYS!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.MODIFY_CONSTRUCT_DAYS==(model.MODIFY_CONSTRUCT_DAYS));
				}
				if(!string.IsNullOrWhiteSpace(model.DESIGN_PERFORMANCE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.DESIGN_PERFORMANCE.Contain(model.DESIGN_PERFORMANCE));
				}
				if(!string.IsNullOrWhiteSpace(model.MANAGER_QUALIFICAT_TITLE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.MANAGER_QUALIFICAT_TITLE.Contain(model.MANAGER_QUALIFICAT_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME1))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.MARGIN_NAME1.Contain(model.MARGIN_NAME1));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER1))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.MARGIN_NUMBER1.Contain(model.MARGIN_NUMBER1));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK1))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.MARGIN_BANK1.Contain(model.MARGIN_BANK1));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME2))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.MARGIN_NAME2.Contain(model.MARGIN_NAME2));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER2))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.MARGIN_NUMBER2.Contain(model.MARGIN_NUMBER2));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK2))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.MARGIN_BANK2.Contain(model.MARGIN_BANK2));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME3))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.MARGIN_NAME3.Contain(model.MARGIN_NAME3));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER3))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.MARGIN_NUMBER3.Contain(model.MARGIN_NUMBER3));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK3))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.MARGIN_BANK3.Contain(model.MARGIN_BANK3));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_BANK))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.TENDERER_BANK.Contain(model.TENDERER_BANK));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_ACCOUNT))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.TENDERER_ACCOUNT.Contain(model.TENDERER_ACCOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_BANK))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.TENDER_AGENCY_BANK.Contain(model.TENDER_AGENCY_BANK));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_ACCOUNT))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.TENDER_AGENCY_ACCOUNT.Contain(model.TENDER_AGENCY_ACCOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBCONTRACT))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUBCONTRACT.Contain(model.SUBCONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBCONTRACT_CONTENT_REQUIRE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUBCONTRACT_CONTENT_REQUIRE.Contain(model.SUBCONTRACT_CONTENT_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUB_QUALIFI_REQUIRE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUB_QUALIFI_REQUIRE.Contain(model.SUB_QUALIFI_REQUIRE));
				}
				if(model.QUESTION_TIME!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.QUESTION_TIME==(model.QUESTION_TIME));
				}
				if(model.TENDER_NOTICE_TIME!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.TENDER_NOTICE_TIME==(model.TENDER_NOTICE_TIME));
				}
				if(model.BIDDER_NOTICE_TIME!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.BIDDER_NOTICE_TIME==(model.BIDDER_NOTICE_TIME));
				}
				if(model.ALL_EXPERT_NUM!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.ALL_EXPERT_NUM==(model.ALL_EXPERT_NUM));
				}
				if(model.TENDERER_NUM!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.TENDERER_NUM==(model.TENDERER_NUM));
				}
				if(model.EXPERT_NUM!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.EXPERT_NUM==(model.EXPERT_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATING_METHOD))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.EVALUATING_METHOD.Contain(model.EVALUATING_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_DETERMIN_BIDDER))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.EXPERT_DETERMIN_BIDDER.Contain(model.EXPERT_DETERMIN_BIDDER));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_PERFORM_PRICE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.IS_PERFORM_PRICE.Contain(model.IS_PERFORM_PRICE));
				}
				if(model.PERFORM_PRICE!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.PERFORM_PRICE==(model.PERFORM_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORMANCE_BOND_FORM))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.PERFORMANCE_BOND_FORM.Contain(model.PERFORMANCE_BOND_FORM));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME1))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISE_DEPT_NAME1.Contain(model.SUPERVISE_DEPT_NAME1));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_PHONE1))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISE_DEPT_PHONE1.Contain(model.SUPERVISE_DEPT_PHONE1));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_ADDRESS1))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISE_ADDRESS1.Contain(model.SUPERVISE_ADDRESS1));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_FAX1))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISE_FAX1.Contain(model.SUPERVISE_FAX1));
				}
				if(model.SUPERVISE_ZIP_CODE1!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISE_ZIP_CODE1==(model.SUPERVISE_ZIP_CODE1));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME2))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISE_DEPT_NAME2.Contain(model.SUPERVISE_DEPT_NAME2));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_PHONE2))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISE_DEPT_PHONE2.Contain(model.SUPERVISE_DEPT_PHONE2));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_ADDRESS2))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISE_ADDRESS2.Contain(model.SUPERVISE_ADDRESS2));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_FAX2))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISE_FAX2.Contain(model.SUPERVISE_FAX2));
				}
				if(model.SUPERVISE_ZIP_CODE2!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISE_ZIP_CODE2==(model.SUPERVISE_ZIP_CODE2));
				}
				if(!string.IsNullOrWhiteSpace(model.ACCEPTING_INSTITUTION))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.ACCEPTING_INSTITUTION.Contain(model.ACCEPTING_INSTITUTION));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_ADDRESS))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.COMPLAINT_ADDRESS.Contain(model.COMPLAINT_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINTS_HOTLINE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.COMPLAINTS_HOTLINE.Contain(model.COMPLAINTS_HOTLINE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_POST_CODE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.COMPLAINT_POST_CODE.Contain(model.COMPLAINT_POST_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_REQUIREMENTS))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.OTHER_REQUIREMENTS.Contain(model.OTHER_REQUIREMENTS));
				}
				if(!string.IsNullOrWhiteSpace(model.BONUS_CONTENT))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.BONUS_CONTENT.Contain(model.BONUS_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.CHANGE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.CHANGE.Contain(model.CHANGE));
				}
				if(!string.IsNullOrWhiteSpace(model.DEFINITION))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.DEFINITION.Contain(model.DEFINITION));
				}
				if(!string.IsNullOrWhiteSpace(model.EMPLOYER_DUTY))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.EMPLOYER_DUTY.Contain(model.EMPLOYER_DUTY));
				}
				if(!string.IsNullOrWhiteSpace(model.DESIGNER_DUTY))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.DESIGNER_DUTY.Contain(model.DESIGNER_DUTY));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBMISSION_RESULTS))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUBMISSION_RESULTS.Contain(model.SUBMISSION_RESULTS));
				}
				if(!string.IsNullOrWhiteSpace(model.BREACH_CONTRACT))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.BREACH_CONTRACT.Contain(model.BREACH_CONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.PAYMENT))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.PAYMENT.Contain(model.PAYMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_CONVENTIONS))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.OTHER_CONVENTIONS.Contain(model.OTHER_CONVENTIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPPLY_ITEM))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPPLY_ITEM.Contain(model.SUPPLY_ITEM));
				}
				if(!string.IsNullOrWhiteSpace(model.BASIC_DATA))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.BASIC_DATA.Contain(model.BASIC_DATA));
				}
				if(!string.IsNullOrWhiteSpace(model.TECHNICAL_REQUIRE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.TECHNICAL_REQUIRE.Contain(model.TECHNICAL_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.M_TM==(model.M_TM));
				}
				if(model.SUPERVISOR_DAYS!=null)
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISOR_DAYS==(model.SUPERVISOR_DAYS));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPER_SIMILAR_PROJECT))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPER_SIMILAR_PROJECT.Contain(model.SUPER_SIMILAR_PROJECT));
				}
				if(!string.IsNullOrWhiteSpace(model.GENERAL_QUAL_LEVEL))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.GENERAL_QUAL_LEVEL.Contain(model.GENERAL_QUAL_LEVEL));
				}
				if(!string.IsNullOrWhiteSpace(model.GENERAL_TECH_TITLE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.GENERAL_TECH_TITLE.Contain(model.GENERAL_TECH_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISION_SERVICE_STAGE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISION_SERVICE_STAGE.Contain(model.SUPERVISION_SERVICE_STAGE));
				}
				if(!string.IsNullOrWhiteSpace(model.SCOPE_SUPER_WORK))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SCOPE_SUPER_WORK.Contain(model.SCOPE_SUPER_WORK));
				}
				if(!string.IsNullOrWhiteSpace(model.FINANCIAL_REQUIRE_YEAR))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.FINANCIAL_REQUIRE_YEAR.Contain(model.FINANCIAL_REQUIRE_YEAR));
				}
				if(!string.IsNullOrWhiteSpace(model.SIMILAR_PROJECT_YEAR))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SIMILAR_PROJECT_YEAR.Contain(model.SIMILAR_PROJECT_YEAR));
				}
				if(!string.IsNullOrWhiteSpace(model.LITIGATION_YEAR))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.LITIGATION_YEAR.Contain(model.LITIGATION_YEAR));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORM_TYPE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.PERFORM_TYPE.Contain(model.PERFORM_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORM_CONTENT1))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.PERFORM_CONTENT1.Contain(model.PERFORM_CONTENT1));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORM_CONTENT2))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.PERFORM_CONTENT2.Contain(model.PERFORM_CONTENT2));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ADDRESS1))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISE_DEPT_ADDRESS1.Contain(model.SUPERVISE_DEPT_ADDRESS1));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_FAX1))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISE_DEPT_FAX1.Contain(model.SUPERVISE_DEPT_FAX1));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ZIP_CODE1))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISE_DEPT_ZIP_CODE1.Contain(model.SUPERVISE_DEPT_ZIP_CODE1));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ADDRESS2))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISE_DEPT_ADDRESS2.Contain(model.SUPERVISE_DEPT_ADDRESS2));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_FAX2))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISE_DEPT_FAX2.Contain(model.SUPERVISE_DEPT_FAX2));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ZIP_CODE2))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISE_DEPT_ZIP_CODE2.Contain(model.SUPERVISE_DEPT_ZIP_CODE2));
				}
				if(!string.IsNullOrWhiteSpace(model.GENERAL_CONTRACT))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.GENERAL_CONTRACT.Contain(model.GENERAL_CONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISION_SERVICE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SUPERVISION_SERVICE.Contain(model.SUPERVISION_SERVICE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_OPERATION))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.CONTRACT_OPERATION.Contain(model.CONTRACT_OPERATION));
				}
				if(!string.IsNullOrWhiteSpace(model.MEASUREMENT_PAYMENT))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.MEASUREMENT_PAYMENT.Contain(model.MEASUREMENT_PAYMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.DISPUTE_RESOLUTION))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.DISPUTE_RESOLUTION.Contain(model.DISPUTE_RESOLUTION));
				}
				if(!string.IsNullOrWhiteSpace(model.SERVICE_CHARGE))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.SERVICE_CHARGE.Contain(model.SERVICE_CHARGE));
				}
				if(!string.IsNullOrWhiteSpace(model.DRAWING))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.DRAWING.Contain(model.DRAWING));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(JT_SURVEY_TENDER_FILE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}