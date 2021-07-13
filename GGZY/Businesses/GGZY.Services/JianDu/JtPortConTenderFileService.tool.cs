using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JtPortConTenderFileService : BaseServiceT<JT_PORT_CON_TENDER_FILE>
    {
        #region 接口实现
        
		public List<JT_PORT_CON_TENDER_FILE> FindList(JT_PORT_CON_TENDER_FILE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JT_PORT_CON_TENDER_FILE> PageList(JT_PORT_CON_TENDER_FILE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JT_PORT_CON_TENDER_FILE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(JT_PORT_CON_TENDER_FILE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(JT_PORT_CON_TENDER_FILE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is JT_PORT_CON_TENDER_FILE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.TOTAL_SECTION_NUMBER=model.TOTAL_SECTION_NUMBER;
		entity.TENDERER_SECTION_NUMBER=model.TENDERER_SECTION_NUMBER;
		entity.LIMITE_ALL_TIME=model.LIMITE_ALL_TIME;
		entity.MANAGER_QUAL_LEVEL=model.MANAGER_QUAL_LEVEL;
		entity.MANAGER_TECH_TITLE=model.MANAGER_TECH_TITLE;
		entity.CHARGE_TECH_TITLE=model.CHARGE_TECH_TITLE;
		entity.CONSTRUCTION_PERFORMANCE=model.CONSTRUCTION_PERFORMANCE;
		entity.MARGIN_NAME1=model.MARGIN_NAME1;
		entity.MARGIN_NUMBER1=model.MARGIN_NUMBER1;
		entity.MARGIN_BANK1=model.MARGIN_BANK1;
		entity.MARGIN_NAME2=model.MARGIN_NAME2;
		entity.MARGIN_NUMBER2=model.MARGIN_NUMBER2;
		entity.MARGIN_BANK2=model.MARGIN_BANK2;
		entity.MARGIN_NAME3=model.MARGIN_NAME3;
		entity.MARGIN_NUMBER3=model.MARGIN_NUMBER3;
		entity.MARGIN_BANK3=model.MARGIN_BANK3;
		entity.NOTICE_MEDIA4=model.NOTICE_MEDIA4;
		entity.FUND_IMPLEMENTATION=model.FUND_IMPLEMENTATION;
		entity.BEGIN_ALL_DATE=model.BEGIN_ALL_DATE;
		entity.END_DATE=model.END_DATE;
		entity.IMPORTANT_LIMITE_TIME=model.IMPORTANT_LIMITE_TIME;
		entity.QUESTION_TIME=model.QUESTION_TIME;
		entity.TENDER_NOTICE_TIME=model.TENDER_NOTICE_TIME;
		entity.SUBCONTRACT=model.SUBCONTRACT;
		entity.SUBCONTRACT_CONTENT_REQUIRE=model.SUBCONTRACT_CONTENT_REQUIRE;
		entity.SUB_QUALIFI_REQUIRE=model.SUB_QUALIFI_REQUIRE;
		entity.BIDDER_NOTICE_TIME=model.BIDDER_NOTICE_TIME;
		entity.TRADING_CENTER_NAME=model.TRADING_CENTER_NAME;
		entity.FINANCIAL_REQUIRE_BEGIN=model.FINANCIAL_REQUIRE_BEGIN;
		entity.FINANCIAL_REQUIRE_END=model.FINANCIAL_REQUIRE_END;
		entity.SIMILAR_PROJECT_REQUIRE_BEGIN=model.SIMILAR_PROJECT_REQUIRE_BEGIN;
		entity.SIMILAR_PROJECT_REQUIRE_END=model.SIMILAR_PROJECT_REQUIRE_END;
		entity.LITIGATION_REQUIRE_BEGIN=model.LITIGATION_REQUIRE_BEGIN;
		entity.LITIGATION_REQUIRE_END=model.LITIGATION_REQUIRE_END;
		entity.ALTERNATIVE_TENDER_SCHEME=model.ALTERNATIVE_TENDER_SCHEME;
		entity.ALL_EXPERT_NUM=model.ALL_EXPERT_NUM;
		entity.TENDERER_NUM=model.TENDERER_NUM;
		entity.EXPERT_NUM=model.EXPERT_NUM;
		entity.EXPERT_DETERMIN_BIDDER=model.EXPERT_DETERMIN_BIDDER;
		entity.PERFORM_PRICE_TYPE=model.PERFORM_PRICE_TYPE;
		entity.PERFORM_PRICE=model.PERFORM_PRICE;
		entity.SUPERVISE_DEPT_NAME1=model.SUPERVISE_DEPT_NAME1;
		entity.SUPERVISE_DEPT_PHONE1=model.SUPERVISE_DEPT_PHONE1;
		entity.SUPERVISE_DEPT_ADDRESS1=model.SUPERVISE_DEPT_ADDRESS1;
		entity.SUPERVISE_DEPT_FAX1=model.SUPERVISE_DEPT_FAX1;
		entity.SUPERVISE_DEPT_ZIP_CODE1=model.SUPERVISE_DEPT_ZIP_CODE1;
		entity.SUPERVISE_DEPT_NAME2=model.SUPERVISE_DEPT_NAME2;
		entity.SUPERVISE_DEPT_PHONE2=model.SUPERVISE_DEPT_PHONE2;
		entity.SUPERVISE_DEPT_ADDRESS2=model.SUPERVISE_DEPT_ADDRESS2;
		entity.SUPERVISE_DEPT_FAX2=model.SUPERVISE_DEPT_FAX2;
		entity.SUPERVISE_DEPT_ZIP_CODE2=model.SUPERVISE_DEPT_ZIP_CODE2;
		entity.OTHER_REQUIREMENTS=model.OTHER_REQUIREMENTS;
		entity.MINIMUM_QUALIFICATIONS=model.MINIMUM_QUALIFICATIONS;
		entity.FINANCIAL_REQUIRE=model.FINANCIAL_REQUIRE;
		entity.ACHIEVEMENT_REQUIRE=model.ACHIEVEMENT_REQUIRE;
		entity.REPUTATION_REQUIRE=model.REPUTATION_REQUIRE;
		entity.QUALIFICATION_REQUIRE=model.QUALIFICATION_REQUIRE;
		entity.OTHER_REQUIRE=model.OTHER_REQUIRE;
		entity.MANAGE_TECHNOLOGY_REQUIRE=model.MANAGE_TECHNOLOGY_REQUIRE;
		entity.DEALING_UNIT=model.DEALING_UNIT;
		entity.COMPLAINT_ADDRESS=model.COMPLAINT_ADDRESS;
		entity.COMPLAINT_PHONE=model.COMPLAINT_PHONE;
		entity.COMPLAINT_POSTCODE=model.COMPLAINT_POSTCODE;
		entity.CHANGE=model.CHANGE;
		entity.GENERAL_CONTRACT=model.GENERAL_CONTRACT;
		entity.EMPLOYER_DUTY=model.EMPLOYER_DUTY;
		entity.SUPERVISOR=model.SUPERVISOR;
		entity.CONTRACTOR=model.CONTRACTOR;
		entity.CONSTRUCT_EQUIP_TEMP_FACIL=model.CONSTRUCT_EQUIP_TEMP_FACIL;
		entity.TRANSPORTATION=model.TRANSPORTATION;
		entity.SURVEYING=model.SURVEYING;
		entity.SAFE_SECURITY_ENVIRON_PRO=model.SAFE_SECURITY_ENVIRON_PRO;
		entity.SCHEDULE=model.SCHEDULE;
		entity.COMMENCEMENT_COMPLETION=model.COMMENCEMENT_COMPLETION;
		entity.SUSPENSION_OF_WORKS=model.SUSPENSION_OF_WORKS;
		entity.PROJECT_QUALITY=model.PROJECT_QUALITY;
		entity.TEST_INSPECTION=model.TEST_INSPECTION;
		entity.MODIFICATION=model.MODIFICATION;
		entity.PRICE_REGULATION=model.PRICE_REGULATION;
		entity.MEASUREMENT_PAYMENT=model.MEASUREMENT_PAYMENT;
		entity.COMPLETION_ACCEPTANCE=model.COMPLETION_ACCEPTANCE;
		entity.LIABILITY_DEFECTS_WARRANTY=model.LIABILITY_DEFECTS_WARRANTY;
		entity.FORCE_MAJEURE=model.FORCE_MAJEURE;
		entity.BREACH_CONTRACT=model.BREACH_CONTRACT;
		entity.OTHER_CONVENTIONS=model.OTHER_CONVENTIONS;
		entity.SUPPLY_ITEM=model.SUPPLY_ITEM;
		entity.BILL_OF_QUANTITIES=model.BILL_OF_QUANTITIES;
		entity.DRAWING=model.DRAWING;
		entity.TECHNICAL_STANDARD_REQUIRE=model.TECHNICAL_STANDARD_REQUIRE;
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
        public GeneralResult Add(JT_PORT_CON_TENDER_FILE model)
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
                    Delete(JT_PORT_CON_TENDER_FILE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JT_PORT_CON_TENDER_FILE> model)
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
       	protected WhereClipBuilder ConditionBuilder(JT_PORT_CON_TENDER_FILE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(model.TOTAL_SECTION_NUMBER!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.TOTAL_SECTION_NUMBER==(model.TOTAL_SECTION_NUMBER));
				}
				if(model.TENDERER_SECTION_NUMBER!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.TENDERER_SECTION_NUMBER==(model.TENDERER_SECTION_NUMBER));
				}
				if(model.LIMITE_ALL_TIME!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.LIMITE_ALL_TIME==(model.LIMITE_ALL_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MANAGER_QUAL_LEVEL))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.MANAGER_QUAL_LEVEL.Contain(model.MANAGER_QUAL_LEVEL));
				}
				if(!string.IsNullOrWhiteSpace(model.MANAGER_TECH_TITLE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.MANAGER_TECH_TITLE.Contain(model.MANAGER_TECH_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.CHARGE_TECH_TITLE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.CHARGE_TECH_TITLE.Contain(model.CHARGE_TECH_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCTION_PERFORMANCE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.CONSTRUCTION_PERFORMANCE.Contain(model.CONSTRUCTION_PERFORMANCE));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME1))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.MARGIN_NAME1.Contain(model.MARGIN_NAME1));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER1))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.MARGIN_NUMBER1.Contain(model.MARGIN_NUMBER1));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK1))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.MARGIN_BANK1.Contain(model.MARGIN_BANK1));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME2))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.MARGIN_NAME2.Contain(model.MARGIN_NAME2));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER2))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.MARGIN_NUMBER2.Contain(model.MARGIN_NUMBER2));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK2))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.MARGIN_BANK2.Contain(model.MARGIN_BANK2));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME3))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.MARGIN_NAME3.Contain(model.MARGIN_NAME3));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER3))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.MARGIN_NUMBER3.Contain(model.MARGIN_NUMBER3));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK3))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.MARGIN_BANK3.Contain(model.MARGIN_BANK3));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_MEDIA4))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.NOTICE_MEDIA4.Contain(model.NOTICE_MEDIA4));
				}
				if(!string.IsNullOrWhiteSpace(model.FUND_IMPLEMENTATION))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.FUND_IMPLEMENTATION.Contain(model.FUND_IMPLEMENTATION));
				}
				if(model.BEGIN_ALL_DATE!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.BEGIN_ALL_DATE==(model.BEGIN_ALL_DATE));
				}
				if(model.END_DATE!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.END_DATE==(model.END_DATE));
				}
				if(model.IMPORTANT_LIMITE_TIME!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.IMPORTANT_LIMITE_TIME==(model.IMPORTANT_LIMITE_TIME));
				}
				if(model.QUESTION_TIME!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.QUESTION_TIME==(model.QUESTION_TIME));
				}
				if(model.TENDER_NOTICE_TIME!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.TENDER_NOTICE_TIME==(model.TENDER_NOTICE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBCONTRACT))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SUBCONTRACT.Contain(model.SUBCONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBCONTRACT_CONTENT_REQUIRE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SUBCONTRACT_CONTENT_REQUIRE.Contain(model.SUBCONTRACT_CONTENT_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUB_QUALIFI_REQUIRE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SUB_QUALIFI_REQUIRE.Contain(model.SUB_QUALIFI_REQUIRE));
				}
				if(model.BIDDER_NOTICE_TIME!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.BIDDER_NOTICE_TIME==(model.BIDDER_NOTICE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADING_CENTER_NAME))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.TRADING_CENTER_NAME.Contain(model.TRADING_CENTER_NAME));
				}
				if(model.FINANCIAL_REQUIRE_BEGIN!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.FINANCIAL_REQUIRE_BEGIN==(model.FINANCIAL_REQUIRE_BEGIN));
				}
				if(model.FINANCIAL_REQUIRE_END!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.FINANCIAL_REQUIRE_END==(model.FINANCIAL_REQUIRE_END));
				}
				if(model.SIMILAR_PROJECT_REQUIRE_BEGIN!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SIMILAR_PROJECT_REQUIRE_BEGIN==(model.SIMILAR_PROJECT_REQUIRE_BEGIN));
				}
				if(model.SIMILAR_PROJECT_REQUIRE_END!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SIMILAR_PROJECT_REQUIRE_END==(model.SIMILAR_PROJECT_REQUIRE_END));
				}
				if(model.LITIGATION_REQUIRE_BEGIN!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.LITIGATION_REQUIRE_BEGIN==(model.LITIGATION_REQUIRE_BEGIN));
				}
				if(model.LITIGATION_REQUIRE_END!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.LITIGATION_REQUIRE_END==(model.LITIGATION_REQUIRE_END));
				}
				if(!string.IsNullOrWhiteSpace(model.ALTERNATIVE_TENDER_SCHEME))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.ALTERNATIVE_TENDER_SCHEME.Contain(model.ALTERNATIVE_TENDER_SCHEME));
				}
				if(model.ALL_EXPERT_NUM!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.ALL_EXPERT_NUM==(model.ALL_EXPERT_NUM));
				}
				if(model.TENDERER_NUM!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.TENDERER_NUM==(model.TENDERER_NUM));
				}
				if(model.EXPERT_NUM!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.EXPERT_NUM==(model.EXPERT_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_DETERMIN_BIDDER))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.EXPERT_DETERMIN_BIDDER.Contain(model.EXPERT_DETERMIN_BIDDER));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORM_PRICE_TYPE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.PERFORM_PRICE_TYPE.Contain(model.PERFORM_PRICE_TYPE));
				}
				if(model.PERFORM_PRICE!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.PERFORM_PRICE==(model.PERFORM_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME1))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SUPERVISE_DEPT_NAME1.Contain(model.SUPERVISE_DEPT_NAME1));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_PHONE1))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SUPERVISE_DEPT_PHONE1.Contain(model.SUPERVISE_DEPT_PHONE1));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ADDRESS1))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SUPERVISE_DEPT_ADDRESS1.Contain(model.SUPERVISE_DEPT_ADDRESS1));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_FAX1))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SUPERVISE_DEPT_FAX1.Contain(model.SUPERVISE_DEPT_FAX1));
				}
				if(model.SUPERVISE_DEPT_ZIP_CODE1!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SUPERVISE_DEPT_ZIP_CODE1==(model.SUPERVISE_DEPT_ZIP_CODE1));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME2))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SUPERVISE_DEPT_NAME2.Contain(model.SUPERVISE_DEPT_NAME2));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_PHONE2))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SUPERVISE_DEPT_PHONE2.Contain(model.SUPERVISE_DEPT_PHONE2));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ADDRESS2))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SUPERVISE_DEPT_ADDRESS2.Contain(model.SUPERVISE_DEPT_ADDRESS2));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_FAX2))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SUPERVISE_DEPT_FAX2.Contain(model.SUPERVISE_DEPT_FAX2));
				}
				if(model.SUPERVISE_DEPT_ZIP_CODE2!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SUPERVISE_DEPT_ZIP_CODE2==(model.SUPERVISE_DEPT_ZIP_CODE2));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_REQUIREMENTS))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.OTHER_REQUIREMENTS.Contain(model.OTHER_REQUIREMENTS));
				}
				if(!string.IsNullOrWhiteSpace(model.MINIMUM_QUALIFICATIONS))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.MINIMUM_QUALIFICATIONS.Contain(model.MINIMUM_QUALIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.FINANCIAL_REQUIRE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.FINANCIAL_REQUIRE.Contain(model.FINANCIAL_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHIEVEMENT_REQUIRE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.ACHIEVEMENT_REQUIRE.Contain(model.ACHIEVEMENT_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.REPUTATION_REQUIRE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.REPUTATION_REQUIRE.Contain(model.REPUTATION_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALIFICATION_REQUIRE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.QUALIFICATION_REQUIRE.Contain(model.QUALIFICATION_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_REQUIRE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.OTHER_REQUIRE.Contain(model.OTHER_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.MANAGE_TECHNOLOGY_REQUIRE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.MANAGE_TECHNOLOGY_REQUIRE.Contain(model.MANAGE_TECHNOLOGY_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.DEALING_UNIT))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.DEALING_UNIT.Contain(model.DEALING_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_ADDRESS))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.COMPLAINT_ADDRESS.Contain(model.COMPLAINT_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_PHONE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.COMPLAINT_PHONE.Contain(model.COMPLAINT_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_POSTCODE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.COMPLAINT_POSTCODE.Contain(model.COMPLAINT_POSTCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CHANGE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.CHANGE.Contain(model.CHANGE));
				}
				if(!string.IsNullOrWhiteSpace(model.GENERAL_CONTRACT))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.GENERAL_CONTRACT.Contain(model.GENERAL_CONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.EMPLOYER_DUTY))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.EMPLOYER_DUTY.Contain(model.EMPLOYER_DUTY));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISOR))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SUPERVISOR.Contain(model.SUPERVISOR));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACTOR))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.CONTRACTOR.Contain(model.CONTRACTOR));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCT_EQUIP_TEMP_FACIL))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.CONSTRUCT_EQUIP_TEMP_FACIL.Contain(model.CONSTRUCT_EQUIP_TEMP_FACIL));
				}
				if(!string.IsNullOrWhiteSpace(model.TRANSPORTATION))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.TRANSPORTATION.Contain(model.TRANSPORTATION));
				}
				if(!string.IsNullOrWhiteSpace(model.SURVEYING))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SURVEYING.Contain(model.SURVEYING));
				}
				if(!string.IsNullOrWhiteSpace(model.SAFE_SECURITY_ENVIRON_PRO))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SAFE_SECURITY_ENVIRON_PRO.Contain(model.SAFE_SECURITY_ENVIRON_PRO));
				}
				if(!string.IsNullOrWhiteSpace(model.SCHEDULE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SCHEDULE.Contain(model.SCHEDULE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMMENCEMENT_COMPLETION))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.COMMENCEMENT_COMPLETION.Contain(model.COMMENCEMENT_COMPLETION));
				}
				if(!string.IsNullOrWhiteSpace(model.SUSPENSION_OF_WORKS))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SUSPENSION_OF_WORKS.Contain(model.SUSPENSION_OF_WORKS));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_QUALITY))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.PROJECT_QUALITY.Contain(model.PROJECT_QUALITY));
				}
				if(!string.IsNullOrWhiteSpace(model.TEST_INSPECTION))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.TEST_INSPECTION.Contain(model.TEST_INSPECTION));
				}
				if(!string.IsNullOrWhiteSpace(model.MODIFICATION))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.MODIFICATION.Contain(model.MODIFICATION));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_REGULATION))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.PRICE_REGULATION.Contain(model.PRICE_REGULATION));
				}
				if(!string.IsNullOrWhiteSpace(model.MEASUREMENT_PAYMENT))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.MEASUREMENT_PAYMENT.Contain(model.MEASUREMENT_PAYMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLETION_ACCEPTANCE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.COMPLETION_ACCEPTANCE.Contain(model.COMPLETION_ACCEPTANCE));
				}
				if(!string.IsNullOrWhiteSpace(model.LIABILITY_DEFECTS_WARRANTY))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.LIABILITY_DEFECTS_WARRANTY.Contain(model.LIABILITY_DEFECTS_WARRANTY));
				}
				if(!string.IsNullOrWhiteSpace(model.FORCE_MAJEURE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.FORCE_MAJEURE.Contain(model.FORCE_MAJEURE));
				}
				if(!string.IsNullOrWhiteSpace(model.BREACH_CONTRACT))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.BREACH_CONTRACT.Contain(model.BREACH_CONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_CONVENTIONS))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.OTHER_CONVENTIONS.Contain(model.OTHER_CONVENTIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPPLY_ITEM))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.SUPPLY_ITEM.Contain(model.SUPPLY_ITEM));
				}
				if(!string.IsNullOrWhiteSpace(model.BILL_OF_QUANTITIES))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.BILL_OF_QUANTITIES.Contain(model.BILL_OF_QUANTITIES));
				}
				if(!string.IsNullOrWhiteSpace(model.DRAWING))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.DRAWING.Contain(model.DRAWING));
				}
				if(!string.IsNullOrWhiteSpace(model.TECHNICAL_STANDARD_REQUIRE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.TECHNICAL_STANDARD_REQUIRE.Contain(model.TECHNICAL_STANDARD_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.M_ID!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.M_TM==(model.M_TM));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(JT_PORT_CON_TENDER_FILE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}