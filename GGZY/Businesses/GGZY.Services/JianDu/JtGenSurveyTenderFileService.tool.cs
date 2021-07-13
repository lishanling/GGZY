using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JtGenSurveyTenderFileService : BaseServiceT<JT_GEN_SURVEY_TENDER_FILE>
    {
        #region 接口实现
        
		public List<JT_GEN_SURVEY_TENDER_FILE> FindList(JT_GEN_SURVEY_TENDER_FILE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JT_GEN_SURVEY_TENDER_FILE> PageList(JT_GEN_SURVEY_TENDER_FILE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JT_GEN_SURVEY_TENDER_FILE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(JT_GEN_SURVEY_TENDER_FILE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(JT_GEN_SURVEY_TENDER_FILE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is JT_GEN_SURVEY_TENDER_FILE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.LIMITE_ALL_TIME=model.LIMITE_ALL_TIME;
		entity.TECHNICAL_STANDARD=model.TECHNICAL_STANDARD;
		entity.BID_SECTION_DIVISION=model.BID_SECTION_DIVISION;
		entity.SURVEY_DESIGN_CYCLE=model.SURVEY_DESIGN_CYCLE;
		entity.SYNDICATED_NUMBER=model.SYNDICATED_NUMBER;
		entity.CONTRACT_SEGMENT=model.CONTRACT_SEGMENT;
		entity.TENDER_NUMBER=model.TENDER_NUMBER;
		entity.MARGIN_NAME=model.MARGIN_NAME;
		entity.MARGIN_NUMBER=model.MARGIN_NUMBER;
		entity.MARGIN_BANK=model.MARGIN_BANK;
		entity.MARGIN_TIME=model.MARGIN_TIME;
		entity.MEDIA1=model.MEDIA1;
		entity.MEDIA2=model.MEDIA2;
		entity.FUND_IMPLEMENTATION=model.FUND_IMPLEMENTATION;
		entity.TENDER_OTHER_CONTENT=model.TENDER_OTHER_CONTENT;
		entity.SAME_INFORMATION=model.SAME_INFORMATION;
		entity.TENDER_CONTEN_COMPONENT=model.TENDER_CONTEN_COMPONENT;
		entity.REPUTATION_TIME2=model.REPUTATION_TIME2;
		entity.REPUTATION_TIME3=model.REPUTATION_TIME3;
		entity.TENDER_CONTENT_ENCLOSURE=model.TENDER_CONTENT_ENCLOSURE;
		entity.SURVEY_DESIGN_ENCLOSURE=model.SURVEY_DESIGN_ENCLOSURE;
		entity.TENDER_OFFER_REQUIRE=model.TENDER_OFFER_REQUIRE;
		entity.EFFECTIVE_BID_FLOAT=model.EFFECTIVE_BID_FLOAT;
		entity.E1_NUMBER=model.E1_NUMBER;
		entity.E2_NUMBER=model.E2_NUMBER;
		entity.SUBC_NUMBER=model.SUBC_NUMBER;
		entity.SURVEY_REPORT=model.SURVEY_REPORT;
		entity.DESIGN_DOC=model.DESIGN_DOC;
		entity.CONSTRUCTION_PERIOD=model.CONSTRUCTION_PERIOD;
		entity.PRE_DESIGN_DAY=model.PRE_DESIGN_DAY;
		entity.CON_DRAW_DESIGN_DAY=model.CON_DRAW_DESIGN_DAY;
		entity.SUBMIT_FIRST_TEST_TIME=model.SUBMIT_FIRST_TEST_TIME;
		entity.SUBMIT_FIRST_TEST_NUMBER=model.SUBMIT_FIRST_TEST_NUMBER;
		entity.PRESENT_DESIGN_TIME=model.PRESENT_DESIGN_TIME;
		entity.PRESENT_DESIGN_NUMBER=model.PRESENT_DESIGN_NUMBER;
		entity.COMPLETE_DESIGN_TIME=model.COMPLETE_DESIGN_TIME;
		entity.SUBMIT_SURVAY_PRESENT_TIME=model.SUBMIT_SURVAY_PRESENT_TIME;
		entity.SUBMIT_SURVAY_PRESENT_NUMBER=model.SUBMIT_SURVAY_PRESENT_NUMBER;
		entity.SUBMIT_DRAW_DESIGN_TIME=model.SUBMIT_DRAW_DESIGN_TIME;
		entity.SUBMIT_DRAW_DESIGN_NUMBER=model.SUBMIT_DRAW_DESIGN_NUMBER;
		entity.COM_DRAW_DESIGN_TIME=model.COM_DRAW_DESIGN_TIME;
		entity.SUBMIT_STUDY_PRESENT_TIME=model.SUBMIT_STUDY_PRESENT_TIME;
		entity.SUBMIT_STUDY_PRESENT_NUMBER=model.SUBMIT_STUDY_PRESENT_NUMBER;
		entity.SUBMIT_FINAL_TIME=model.SUBMIT_FINAL_TIME;
		entity.SUBMIT_FINAL_NUMBER=model.SUBMIT_FINAL_NUMBER;
		entity.FINAL_SECTION_NUMBER=model.FINAL_SECTION_NUMBER;
		entity.FILE_DOCUMENT_NUMBER=model.FILE_DOCUMENT_NUMBER;
		entity.FINAL_DOCUMENT_NUMBER=model.FINAL_DOCUMENT_NUMBER;
		entity.TENDER_SECTION_NUMBER=model.TENDER_SECTION_NUMBER;
		entity.TENER_DOCUMENT_NUMBER=model.TENER_DOCUMENT_NUMBER;
		entity.SUBMIT_LAND_DECLARE_TIME=model.SUBMIT_LAND_DECLARE_TIME;
		entity.RETENT_MONEY=model.RETENT_MONEY;
		entity.DISPUTE_SOLUTION=model.DISPUTE_SOLUTION;
		entity.ENCLOSURE1=model.ENCLOSURE1;
		entity.ENCLOSURE2=model.ENCLOSURE2;
		entity.ENCLOSURE3=model.ENCLOSURE3;
		entity.CREDIT_USE_REQUIRE1=model.CREDIT_USE_REQUIRE1;
		entity.CREDIT_USE_REQUIRE2=model.CREDIT_USE_REQUIRE2;
		entity.DECRYPTION_TYPE=model.DECRYPTION_TYPE;
		entity.ACHIEVEMENT_CONDITIONS=model.ACHIEVEMENT_CONDITIONS;
		entity.QUALIFICATION_REQUIRE=model.QUALIFICATION_REQUIRE;
		entity.MINIMUM_QUALIFICATIONS=model.MINIMUM_QUALIFICATIONS;
		entity.ACHIEVEMENT_REQUIRE=model.ACHIEVEMENT_REQUIRE;
		entity.REPUTATION_REQUIRE=model.REPUTATION_REQUIRE;
		entity.OTHER_REQUIRE=model.OTHER_REQUIRE;
		entity.SUBCONTRACT=model.SUBCONTRACT;
		entity.SERIOUS_BREACH_TIME=model.SERIOUS_BREACH_TIME;
		entity.TENDER_DOC_FORM=model.TENDER_DOC_FORM;
		entity.FIXED_BID_PRICE=model.FIXED_BID_PRICE;
		entity.OPEN_BID_REQURE_CHOOSE=model.OPEN_BID_REQURE_CHOOSE;
		entity.DECRYPTION_ADDRESS=model.DECRYPTION_ADDRESS;
		entity.PROVISIONAL_SUM=model.PROVISIONAL_SUM;
		entity.BID_FIXED_UNIT_PRICE_REQURE=model.BID_FIXED_UNIT_PRICE_REQURE;
		entity.MARGIN_AMOUNT=model.MARGIN_AMOUNT;
		entity.ANNUAL_DEPOSIT=model.ANNUAL_DEPOSIT;
		entity.MARGIN_RETURN_TYPE=model.MARGIN_RETURN_TYPE;
		entity.MARGIN_RETURN_CONTENT=model.MARGIN_RETURN_CONTENT;
		entity.COPY_NUM=model.COPY_NUM;
		entity.BID_DOC_ENVELOPE=model.BID_DOC_ENVELOPE;
		entity.BID_OPEN_TIMES=model.BID_OPEN_TIMES;
		entity.DECRYPTION_FLOW=model.DECRYPTION_FLOW;
		entity.BID_OPEN_CONTENT=model.BID_OPEN_CONTENT;
		entity.ALL_EXPERT_NUM=model.ALL_EXPERT_NUM;
		entity.TENDERER_NUM=model.TENDERER_NUM;
		entity.EXPERT_NUM=model.EXPERT_NUM;
		entity.EXPERT_EXTRACT=model.EXPERT_EXTRACT;
		entity.CANDIDATE_PERIOD=model.CANDIDATE_PERIOD;
		entity.RESULTS_PERIOD=model.RESULTS_PERIOD;
		entity.TECH_DOC_REVIEW_TYPE=model.TECH_DOC_REVIEW_TYPE;
		entity.CANDIDATE_NUMBER=model.CANDIDATE_NUMBER;
		entity.PERFORM_PRICE=model.PERFORM_PRICE;
		entity.PERFORM_PRICE_TIME=model.PERFORM_PRICE_TIME;
		entity.SIGN_CONTRACT_TIME=model.SIGN_CONTRACT_TIME;
		entity.SUPERVISE_DEPT_NAME=model.SUPERVISE_DEPT_NAME;
		entity.SUPERVISE_DEPT_PHONE=model.SUPERVISE_DEPT_PHONE;
		entity.SUPERVISE_DEPT_ADDRESS=model.SUPERVISE_DEPT_ADDRESS;
		entity.SUPERVISE_DEPT_ZIP_CODE=model.SUPERVISE_DEPT_ZIP_CODE;
		entity.SUPERVISE_DEPT_FAX=model.SUPERVISE_DEPT_FAX;
		entity.TECH_REQUIRE=model.TECH_REQUIRE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
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
        public GeneralResult Add(JT_GEN_SURVEY_TENDER_FILE model)
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
                    Delete(JT_GEN_SURVEY_TENDER_FILE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JT_GEN_SURVEY_TENDER_FILE> model)
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
       	protected WhereClipBuilder ConditionBuilder(JT_GEN_SURVEY_TENDER_FILE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(model.LIMITE_ALL_TIME!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.LIMITE_ALL_TIME==(model.LIMITE_ALL_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TECHNICAL_STANDARD))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.TECHNICAL_STANDARD.Contain(model.TECHNICAL_STANDARD));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_DIVISION))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.BID_SECTION_DIVISION.Contain(model.BID_SECTION_DIVISION));
				}
				if(!string.IsNullOrWhiteSpace(model.SURVEY_DESIGN_CYCLE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SURVEY_DESIGN_CYCLE.Contain(model.SURVEY_DESIGN_CYCLE));
				}
				if(model.SYNDICATED_NUMBER!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SYNDICATED_NUMBER==(model.SYNDICATED_NUMBER));
				}
				if(model.CONTRACT_SEGMENT!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.CONTRACT_SEGMENT==(model.CONTRACT_SEGMENT));
				}
				if(model.TENDER_NUMBER!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.TENDER_NUMBER==(model.TENDER_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.MARGIN_NAME.Contain(model.MARGIN_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.MARGIN_NUMBER.Contain(model.MARGIN_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.MARGIN_BANK.Contain(model.MARGIN_BANK));
				}
				if(model.MARGIN_TIME!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.MARGIN_TIME==(model.MARGIN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MEDIA1))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.MEDIA1.Contain(model.MEDIA1));
				}
				if(!string.IsNullOrWhiteSpace(model.MEDIA2))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.MEDIA2.Contain(model.MEDIA2));
				}
				if(!string.IsNullOrWhiteSpace(model.FUND_IMPLEMENTATION))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.FUND_IMPLEMENTATION.Contain(model.FUND_IMPLEMENTATION));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_OTHER_CONTENT))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.TENDER_OTHER_CONTENT.Contain(model.TENDER_OTHER_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.SAME_INFORMATION))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SAME_INFORMATION.Contain(model.SAME_INFORMATION));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_CONTEN_COMPONENT))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.TENDER_CONTEN_COMPONENT.Contain(model.TENDER_CONTEN_COMPONENT));
				}
				if(model.REPUTATION_TIME2!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.REPUTATION_TIME2==(model.REPUTATION_TIME2));
				}
				if(model.REPUTATION_TIME3!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.REPUTATION_TIME3==(model.REPUTATION_TIME3));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_CONTENT_ENCLOSURE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.TENDER_CONTENT_ENCLOSURE.Contain(model.TENDER_CONTENT_ENCLOSURE));
				}
				if(!string.IsNullOrWhiteSpace(model.SURVEY_DESIGN_ENCLOSURE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SURVEY_DESIGN_ENCLOSURE.Contain(model.SURVEY_DESIGN_ENCLOSURE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_OFFER_REQUIRE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.TENDER_OFFER_REQUIRE.Contain(model.TENDER_OFFER_REQUIRE));
				}
				if(model.EFFECTIVE_BID_FLOAT!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.EFFECTIVE_BID_FLOAT==(model.EFFECTIVE_BID_FLOAT));
				}
				if(model.E1_NUMBER!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.E1_NUMBER==(model.E1_NUMBER));
				}
				if(model.E2_NUMBER!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.E2_NUMBER==(model.E2_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBC_NUMBER))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUBC_NUMBER.Contain(model.SUBC_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.SURVEY_REPORT))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SURVEY_REPORT.Contain(model.SURVEY_REPORT));
				}
				if(!string.IsNullOrWhiteSpace(model.DESIGN_DOC))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.DESIGN_DOC.Contain(model.DESIGN_DOC));
				}
				if(model.CONSTRUCTION_PERIOD!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.CONSTRUCTION_PERIOD==(model.CONSTRUCTION_PERIOD));
				}
				if(model.PRE_DESIGN_DAY!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.PRE_DESIGN_DAY==(model.PRE_DESIGN_DAY));
				}
				if(model.CON_DRAW_DESIGN_DAY!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.CON_DRAW_DESIGN_DAY==(model.CON_DRAW_DESIGN_DAY));
				}
				if(model.SUBMIT_FIRST_TEST_TIME!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUBMIT_FIRST_TEST_TIME==(model.SUBMIT_FIRST_TEST_TIME));
				}
				if(model.SUBMIT_FIRST_TEST_NUMBER!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUBMIT_FIRST_TEST_NUMBER==(model.SUBMIT_FIRST_TEST_NUMBER));
				}
				if(model.PRESENT_DESIGN_TIME!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.PRESENT_DESIGN_TIME==(model.PRESENT_DESIGN_TIME));
				}
				if(model.PRESENT_DESIGN_NUMBER!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.PRESENT_DESIGN_NUMBER==(model.PRESENT_DESIGN_NUMBER));
				}
				if(model.COMPLETE_DESIGN_TIME!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.COMPLETE_DESIGN_TIME==(model.COMPLETE_DESIGN_TIME));
				}
				if(model.SUBMIT_SURVAY_PRESENT_TIME!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUBMIT_SURVAY_PRESENT_TIME==(model.SUBMIT_SURVAY_PRESENT_TIME));
				}
				if(model.SUBMIT_SURVAY_PRESENT_NUMBER!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUBMIT_SURVAY_PRESENT_NUMBER==(model.SUBMIT_SURVAY_PRESENT_NUMBER));
				}
				if(model.SUBMIT_DRAW_DESIGN_TIME!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUBMIT_DRAW_DESIGN_TIME==(model.SUBMIT_DRAW_DESIGN_TIME));
				}
				if(model.SUBMIT_DRAW_DESIGN_NUMBER!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUBMIT_DRAW_DESIGN_NUMBER==(model.SUBMIT_DRAW_DESIGN_NUMBER));
				}
				if(model.COM_DRAW_DESIGN_TIME!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.COM_DRAW_DESIGN_TIME==(model.COM_DRAW_DESIGN_TIME));
				}
				if(model.SUBMIT_STUDY_PRESENT_TIME!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUBMIT_STUDY_PRESENT_TIME==(model.SUBMIT_STUDY_PRESENT_TIME));
				}
				if(model.SUBMIT_STUDY_PRESENT_NUMBER!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUBMIT_STUDY_PRESENT_NUMBER==(model.SUBMIT_STUDY_PRESENT_NUMBER));
				}
				if(model.SUBMIT_FINAL_TIME!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUBMIT_FINAL_TIME==(model.SUBMIT_FINAL_TIME));
				}
				if(model.SUBMIT_FINAL_NUMBER!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUBMIT_FINAL_NUMBER==(model.SUBMIT_FINAL_NUMBER));
				}
				if(model.FINAL_SECTION_NUMBER!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.FINAL_SECTION_NUMBER==(model.FINAL_SECTION_NUMBER));
				}
				if(model.FILE_DOCUMENT_NUMBER!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.FILE_DOCUMENT_NUMBER==(model.FILE_DOCUMENT_NUMBER));
				}
				if(model.FINAL_DOCUMENT_NUMBER!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.FINAL_DOCUMENT_NUMBER==(model.FINAL_DOCUMENT_NUMBER));
				}
				if(model.TENDER_SECTION_NUMBER!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.TENDER_SECTION_NUMBER==(model.TENDER_SECTION_NUMBER));
				}
				if(model.TENER_DOCUMENT_NUMBER!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.TENER_DOCUMENT_NUMBER==(model.TENER_DOCUMENT_NUMBER));
				}
				if(model.SUBMIT_LAND_DECLARE_TIME!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUBMIT_LAND_DECLARE_TIME==(model.SUBMIT_LAND_DECLARE_TIME));
				}
				if(model.RETENT_MONEY!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.RETENT_MONEY==(model.RETENT_MONEY));
				}
				if(!string.IsNullOrWhiteSpace(model.DISPUTE_SOLUTION))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.DISPUTE_SOLUTION.Contain(model.DISPUTE_SOLUTION));
				}
				if(!string.IsNullOrWhiteSpace(model.ENCLOSURE1))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.ENCLOSURE1.Contain(model.ENCLOSURE1));
				}
				if(!string.IsNullOrWhiteSpace(model.ENCLOSURE2))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.ENCLOSURE2.Contain(model.ENCLOSURE2));
				}
				if(!string.IsNullOrWhiteSpace(model.ENCLOSURE3))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.ENCLOSURE3.Contain(model.ENCLOSURE3));
				}
				if(!string.IsNullOrWhiteSpace(model.CREDIT_USE_REQUIRE1))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.CREDIT_USE_REQUIRE1.Contain(model.CREDIT_USE_REQUIRE1));
				}
				if(!string.IsNullOrWhiteSpace(model.CREDIT_USE_REQUIRE2))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.CREDIT_USE_REQUIRE2.Contain(model.CREDIT_USE_REQUIRE2));
				}
				if(!string.IsNullOrWhiteSpace(model.DECRYPTION_TYPE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.DECRYPTION_TYPE.Contain(model.DECRYPTION_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHIEVEMENT_CONDITIONS))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.ACHIEVEMENT_CONDITIONS.Contain(model.ACHIEVEMENT_CONDITIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALIFICATION_REQUIRE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.QUALIFICATION_REQUIRE.Contain(model.QUALIFICATION_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.MINIMUM_QUALIFICATIONS))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.MINIMUM_QUALIFICATIONS.Contain(model.MINIMUM_QUALIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHIEVEMENT_REQUIRE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.ACHIEVEMENT_REQUIRE.Contain(model.ACHIEVEMENT_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.REPUTATION_REQUIRE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.REPUTATION_REQUIRE.Contain(model.REPUTATION_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_REQUIRE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.OTHER_REQUIRE.Contain(model.OTHER_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBCONTRACT))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUBCONTRACT.Contain(model.SUBCONTRACT));
				}
				if(model.SERIOUS_BREACH_TIME!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SERIOUS_BREACH_TIME==(model.SERIOUS_BREACH_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_DOC_FORM))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.TENDER_DOC_FORM.Contain(model.TENDER_DOC_FORM));
				}
				if(model.FIXED_BID_PRICE!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.FIXED_BID_PRICE==(model.FIXED_BID_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.OPEN_BID_REQURE_CHOOSE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.OPEN_BID_REQURE_CHOOSE.Contain(model.OPEN_BID_REQURE_CHOOSE));
				}
				if(!string.IsNullOrWhiteSpace(model.DECRYPTION_ADDRESS))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.DECRYPTION_ADDRESS.Contain(model.DECRYPTION_ADDRESS));
				}
				if(model.PROVISIONAL_SUM!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.PROVISIONAL_SUM==(model.PROVISIONAL_SUM));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_FIXED_UNIT_PRICE_REQURE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.BID_FIXED_UNIT_PRICE_REQURE.Contain(model.BID_FIXED_UNIT_PRICE_REQURE));
				}
				if(model.MARGIN_AMOUNT!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.MARGIN_AMOUNT==(model.MARGIN_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.ANNUAL_DEPOSIT))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.ANNUAL_DEPOSIT.Contain(model.ANNUAL_DEPOSIT));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_RETURN_TYPE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.MARGIN_RETURN_TYPE.Contain(model.MARGIN_RETURN_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_RETURN_CONTENT))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.MARGIN_RETURN_CONTENT.Contain(model.MARGIN_RETURN_CONTENT));
				}
				if(model.COPY_NUM!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.COPY_NUM==(model.COPY_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_DOC_ENVELOPE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.BID_DOC_ENVELOPE.Contain(model.BID_DOC_ENVELOPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_OPEN_TIMES))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.BID_OPEN_TIMES.Contain(model.BID_OPEN_TIMES));
				}
				if(!string.IsNullOrWhiteSpace(model.DECRYPTION_FLOW))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.DECRYPTION_FLOW.Contain(model.DECRYPTION_FLOW));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_OPEN_CONTENT))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.BID_OPEN_CONTENT.Contain(model.BID_OPEN_CONTENT));
				}
				if(model.ALL_EXPERT_NUM!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.ALL_EXPERT_NUM==(model.ALL_EXPERT_NUM));
				}
				if(model.TENDERER_NUM!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.TENDERER_NUM==(model.TENDERER_NUM));
				}
				if(model.EXPERT_NUM!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.EXPERT_NUM==(model.EXPERT_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_EXTRACT))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.EXPERT_EXTRACT.Contain(model.EXPERT_EXTRACT));
				}
				if(model.CANDIDATE_PERIOD!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.CANDIDATE_PERIOD==(model.CANDIDATE_PERIOD));
				}
				if(model.RESULTS_PERIOD!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.RESULTS_PERIOD==(model.RESULTS_PERIOD));
				}
				if(!string.IsNullOrWhiteSpace(model.TECH_DOC_REVIEW_TYPE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.TECH_DOC_REVIEW_TYPE.Contain(model.TECH_DOC_REVIEW_TYPE));
				}
				if(model.CANDIDATE_NUMBER!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.CANDIDATE_NUMBER==(model.CANDIDATE_NUMBER));
				}
				if(model.PERFORM_PRICE!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.PERFORM_PRICE==(model.PERFORM_PRICE));
				}
				if(model.PERFORM_PRICE_TIME!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.PERFORM_PRICE_TIME==(model.PERFORM_PRICE_TIME));
				}
				if(model.SIGN_CONTRACT_TIME!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SIGN_CONTRACT_TIME==(model.SIGN_CONTRACT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUPERVISE_DEPT_NAME.Contain(model.SUPERVISE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_PHONE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUPERVISE_DEPT_PHONE.Contain(model.SUPERVISE_DEPT_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ADDRESS))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUPERVISE_DEPT_ADDRESS.Contain(model.SUPERVISE_DEPT_ADDRESS));
				}
				if(model.SUPERVISE_DEPT_ZIP_CODE!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUPERVISE_DEPT_ZIP_CODE==(model.SUPERVISE_DEPT_ZIP_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_FAX))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.SUPERVISE_DEPT_FAX.Contain(model.SUPERVISE_DEPT_FAX));
				}
				if(!string.IsNullOrWhiteSpace(model.TECH_REQUIRE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.TECH_REQUIRE.Contain(model.TECH_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.M_ID!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.M_TM==(model.M_TM));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(JT_GEN_SURVEY_TENDER_FILE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}