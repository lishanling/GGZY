using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JtGenSuperTenderFileService : BaseServiceT<JT_GEN_SUPER_TENDER_FILE>
    {
        #region 接口实现
        
		public List<JT_GEN_SUPER_TENDER_FILE> FindList(JT_GEN_SUPER_TENDER_FILE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JT_GEN_SUPER_TENDER_FILE> PageList(JT_GEN_SUPER_TENDER_FILE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JT_GEN_SUPER_TENDER_FILE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(JT_GEN_SUPER_TENDER_FILE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(JT_GEN_SUPER_TENDER_FILE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is JT_GEN_SUPER_TENDER_FILE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.LIMITE_ALL_TIME=model.LIMITE_ALL_TIME;
		entity.TENDER_PROJECT_PART=model.TENDER_PROJECT_PART;
		entity.TOTAL_SECTION_NUMBER=model.TOTAL_SECTION_NUMBER;
		entity.CONTRACT_SECTION=model.CONTRACT_SECTION;
		entity.TENDERER_CONTRACT_SECTION=model.TENDERER_CONTRACT_SECTION;
		entity.SUPERVISION_PRICE_ADJUST=model.SUPERVISION_PRICE_ADJUST;
		entity.OFFICE_NUMBER1=model.OFFICE_NUMBER1;
		entity.OFFICE_NUMBER2=model.OFFICE_NUMBER2;
		entity.SUPERVISION_ORGA=model.SUPERVISION_ORGA;
		entity.MANAGE_MEASURES_CONTENT=model.MANAGE_MEASURES_CONTENT;
		entity.ACHIEVEMENT_TIME=model.ACHIEVEMENT_TIME;
		entity.ACHIEVEMENT_CONDITIONS=model.ACHIEVEMENT_CONDITIONS;
		entity.ACHI_PERSON_CONDITIONS=model.ACHI_PERSON_CONDITIONS;
		entity.CONTRACT_SEGMENT=model.CONTRACT_SEGMENT;
		entity.TENDER_NUMBER=model.TENDER_NUMBER;
		entity.TENDER_DOC_PRICE=model.TENDER_DOC_PRICE;
		entity.SYNDICATED_NUMBER=model.SYNDICATED_NUMBER;
		entity.LIMITE_TIME_UNIT=model.LIMITE_TIME_UNIT;
		entity.SET_LABORATORY=model.SET_LABORATORY;
		entity.IF_ACHIEVEMENT=model.IF_ACHIEVEMENT;
		entity.IF_ACHI_PERSON=model.IF_ACHI_PERSON;
		entity.OPEN_BID_REQURE_CHOOSE=model.OPEN_BID_REQURE_CHOOSE;
		entity.BID_OPEN_TYPE=model.BID_OPEN_TYPE;
		entity.UPPER_LOWER_LIMIT=model.UPPER_LOWER_LIMIT;
		entity.ENGINEER_TITLE=model.ENGINEER_TITLE;
		entity.ENGINEER_WORK_YEAR=model.ENGINEER_WORK_YEAR;
		entity.ENGINEER_AGE=model.ENGINEER_AGE;
		entity.TEST_DIRECTOR_MAGOR=model.TEST_DIRECTOR_MAGOR;
		entity.TEST_DIRECTOR_WORK_YEAR=model.TEST_DIRECTOR_WORK_YEAR;
		entity.TEST_DIRECTOR_AGE=model.TEST_DIRECTOR_AGE;
		entity.TEST_DIRECTOR_EXPER=model.TEST_DIRECTOR_EXPER;
		entity.OTHER_PERSON_YEAR_BEGIN=model.OTHER_PERSON_YEAR_BEGIN;
		entity.OTHER_PERSON_YEAR=model.OTHER_PERSON_YEAR;
		entity.FINANCE_YEAR1=model.FINANCE_YEAR1;
		entity.FINANCE_YEAR2=model.FINANCE_YEAR2;
		entity.FINANCE_YEAR3=model.FINANCE_YEAR3;
		entity.AVE_TURNOVER=model.AVE_TURNOVER;
		entity.REPUTATION_TIME1=model.REPUTATION_TIME1;
		entity.REPUTATION_TIME2=model.REPUTATION_TIME2;
		entity.REPUTATION_TIME4=model.REPUTATION_TIME4;
		entity.REPUTATION_LEVEL=model.REPUTATION_LEVEL;
		entity.SUBC_NAME=model.SUBC_NAME;
		entity.PROJECT_APPROVAL=model.PROJECT_APPROVAL;
		entity.FUND_PLACE=model.FUND_PLACE;
		entity.DRAWING=model.DRAWING;
		entity.ENCLOSURE1=model.ENCLOSURE1;
		entity.ENCLOSURE2=model.ENCLOSURE2;
		entity.ENCLOSURE3=model.ENCLOSURE3;
		entity.QUALIFICATION_REQUIRE=model.QUALIFICATION_REQUIRE;
		entity.REMARK=model.REMARK;
		entity.MARGIN_NAME=model.MARGIN_NAME;
		entity.MARGIN_NUMBER=model.MARGIN_NUMBER;
		entity.MARGIN_BANK=model.MARGIN_BANK;
		entity.MARGIN_TIME=model.MARGIN_TIME;
		entity.MEDIA1=model.MEDIA1;
		entity.MEDIA2=model.MEDIA2;
		entity.SECTION_DIVIDE_CONTENT=model.SECTION_DIVIDE_CONTENT;
		entity.CONST_MANAGEMENT=model.CONST_MANAGEMENT;
		entity.ANSWER_QUESTION_TIME=model.ANSWER_QUESTION_TIME;
		entity.DOC_NUMBER=model.DOC_NUMBER;
		entity.COPY_NUM=model.COPY_NUM;
		entity.BID_CONFIDENTIAL_TIME=model.BID_CONFIDENTIAL_TIME;
		entity.NOTIFICATION_TIME=model.NOTIFICATION_TIME;
		entity.MAIN_ENGINEER_QUANTITY_LIST=model.MAIN_ENGINEER_QUANTITY_LIST;
		entity.SUPERVISE_DEPT_NAME=model.SUPERVISE_DEPT_NAME;
		entity.SUPERVISE_DEPT_PHONE=model.SUPERVISE_DEPT_PHONE;
		entity.SUPERVISE_DEPT_ADDRESS=model.SUPERVISE_DEPT_ADDRESS;
		entity.SUPERVISE_DEPT_ZIP_CODE=model.SUPERVISE_DEPT_ZIP_CODE;
		entity.SUPERVISE_DEPT_FAX=model.SUPERVISE_DEPT_FAX;
		entity.QUESTION_TIME=model.QUESTION_TIME;
		entity.TENDER_NOTICE_TIME=model.TENDER_NOTICE_TIME;
		entity.BIDDER_NOTICE_TIME=model.BIDDER_NOTICE_TIME;
		entity.OTHER_REQUIREMENTS=model.OTHER_REQUIREMENTS;
		entity.PROJECT_DESCRIPTION=model.PROJECT_DESCRIPTION;
		entity.SKETCH_MAP=model.SKETCH_MAP;
		entity.PERIOD_SERVICE_TIME=model.PERIOD_SERVICE_TIME;
		entity.MINIMUM_QUALIFICATIONS=model.MINIMUM_QUALIFICATIONS;
		entity.ACHIEVEMENT_REQUIRE=model.ACHIEVEMENT_REQUIRE;
		entity.OTHER_PERSON_REQUIRE=model.OTHER_PERSON_REQUIRE;
		entity.EQUIPMENT_REQUIRE=model.EQUIPMENT_REQUIRE;
		entity.FINANCIAL_REQUIRE=model.FINANCIAL_REQUIRE;
		entity.REPUTATION_REQUIRE=model.REPUTATION_REQUIRE;
		entity.REVIEW_AAAW_YEAR=model.REVIEW_AAAW_YEAR;
		entity.AA_BID_NUMBER=model.AA_BID_NUMBER;
		entity.A_BID_NUMBER=model.A_BID_NUMBER;
		entity.SUPERVISION_STANDARD=model.SUPERVISION_STANDARD;
		entity.BOND_SUBMIT_TIME=model.BOND_SUBMIT_TIME;
		entity.PERFORM_PRICE_TIME=model.PERFORM_PRICE_TIME;
		entity.MARGIN_RETURN_TYPE=model.MARGIN_RETURN_TYPE;
		entity.PERFORM_PRICE=model.PERFORM_PRICE;
		entity.ACHIE_YEAR=model.ACHIE_YEAR;
		entity.ACHIE_YEAR_BEGIN=model.ACHIE_YEAR_BEGIN;
		entity.CHANGE=model.CHANGE;
		entity.DEFINITION_EXPLANATION=model.DEFINITION_EXPLANATION;
		entity.SUPERVISOR_OBLIGATIONS=model.SUPERVISOR_OBLIGATIONS;
		entity.EMPLOYER_DUTY=model.EMPLOYER_DUTY;
		entity.RESPONSIBILITY=model.RESPONSIBILITY;
		entity.CONTRACT_OPERATION=model.CONTRACT_OPERATION;
		entity.MEASUREMENT_PAYMENT=model.MEASUREMENT_PAYMENT;
		entity.DISPUTE_RESOLUTION=model.DISPUTE_RESOLUTION;
		entity.OTHER_CONVENTIONS=model.OTHER_CONVENTIONS;
		entity.SUPPLY_ITEM=model.SUPPLY_ITEM;
		entity.UPERVISION_STANDARD=model.UPERVISION_STANDARD;
		entity.ENGINEERING_SPECIFICATIONS=model.ENGINEERING_SPECIFICATIONS;
		entity.TECHNICAL_SPECIFICATIONS=model.TECHNICAL_SPECIFICATIONS;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
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
        public GeneralResult Add(JT_GEN_SUPER_TENDER_FILE model)
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
                    Delete(JT_GEN_SUPER_TENDER_FILE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JT_GEN_SUPER_TENDER_FILE> model)
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
       	protected WhereClipBuilder ConditionBuilder(JT_GEN_SUPER_TENDER_FILE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(model.LIMITE_ALL_TIME!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.LIMITE_ALL_TIME==(model.LIMITE_ALL_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_PART))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.TENDER_PROJECT_PART.Contain(model.TENDER_PROJECT_PART));
				}
				if(model.TOTAL_SECTION_NUMBER!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.TOTAL_SECTION_NUMBER==(model.TOTAL_SECTION_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_SECTION))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.CONTRACT_SECTION.Contain(model.CONTRACT_SECTION));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_CONTRACT_SECTION))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.TENDERER_CONTRACT_SECTION.Contain(model.TENDERER_CONTRACT_SECTION));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISION_PRICE_ADJUST))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.SUPERVISION_PRICE_ADJUST.Contain(model.SUPERVISION_PRICE_ADJUST));
				}
				if(model.OFFICE_NUMBER1!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.OFFICE_NUMBER1==(model.OFFICE_NUMBER1));
				}
				if(model.OFFICE_NUMBER2!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.OFFICE_NUMBER2==(model.OFFICE_NUMBER2));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISION_ORGA))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.SUPERVISION_ORGA.Contain(model.SUPERVISION_ORGA));
				}
				if(!string.IsNullOrWhiteSpace(model.MANAGE_MEASURES_CONTENT))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.MANAGE_MEASURES_CONTENT.Contain(model.MANAGE_MEASURES_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHIEVEMENT_TIME))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.ACHIEVEMENT_TIME.Contain(model.ACHIEVEMENT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHIEVEMENT_CONDITIONS))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.ACHIEVEMENT_CONDITIONS.Contain(model.ACHIEVEMENT_CONDITIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHI_PERSON_CONDITIONS))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.ACHI_PERSON_CONDITIONS.Contain(model.ACHI_PERSON_CONDITIONS));
				}
				if(model.CONTRACT_SEGMENT!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.CONTRACT_SEGMENT==(model.CONTRACT_SEGMENT));
				}
				if(model.TENDER_NUMBER!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.TENDER_NUMBER==(model.TENDER_NUMBER));
				}
				if(model.TENDER_DOC_PRICE!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.TENDER_DOC_PRICE==(model.TENDER_DOC_PRICE));
				}
				if(model.SYNDICATED_NUMBER!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.SYNDICATED_NUMBER==(model.SYNDICATED_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.LIMITE_TIME_UNIT))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.LIMITE_TIME_UNIT.Contain(model.LIMITE_TIME_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.SET_LABORATORY))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.SET_LABORATORY.Contain(model.SET_LABORATORY));
				}
				if(!string.IsNullOrWhiteSpace(model.IF_ACHIEVEMENT))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.IF_ACHIEVEMENT.Contain(model.IF_ACHIEVEMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.IF_ACHI_PERSON))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.IF_ACHI_PERSON.Contain(model.IF_ACHI_PERSON));
				}
				if(!string.IsNullOrWhiteSpace(model.OPEN_BID_REQURE_CHOOSE))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.OPEN_BID_REQURE_CHOOSE.Contain(model.OPEN_BID_REQURE_CHOOSE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_OPEN_TYPE))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.BID_OPEN_TYPE.Contain(model.BID_OPEN_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.UPPER_LOWER_LIMIT))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.UPPER_LOWER_LIMIT.Contain(model.UPPER_LOWER_LIMIT));
				}
				if(!string.IsNullOrWhiteSpace(model.ENGINEER_TITLE))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.ENGINEER_TITLE.Contain(model.ENGINEER_TITLE));
				}
				if(model.ENGINEER_WORK_YEAR!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.ENGINEER_WORK_YEAR==(model.ENGINEER_WORK_YEAR));
				}
				if(model.ENGINEER_AGE!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.ENGINEER_AGE==(model.ENGINEER_AGE));
				}
				if(!string.IsNullOrWhiteSpace(model.TEST_DIRECTOR_MAGOR))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.TEST_DIRECTOR_MAGOR.Contain(model.TEST_DIRECTOR_MAGOR));
				}
				if(model.TEST_DIRECTOR_WORK_YEAR!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.TEST_DIRECTOR_WORK_YEAR==(model.TEST_DIRECTOR_WORK_YEAR));
				}
				if(model.TEST_DIRECTOR_AGE!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.TEST_DIRECTOR_AGE==(model.TEST_DIRECTOR_AGE));
				}
				if(!string.IsNullOrWhiteSpace(model.TEST_DIRECTOR_EXPER))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.TEST_DIRECTOR_EXPER.Contain(model.TEST_DIRECTOR_EXPER));
				}
				if(model.OTHER_PERSON_YEAR_BEGIN!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.OTHER_PERSON_YEAR_BEGIN==(model.OTHER_PERSON_YEAR_BEGIN));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_PERSON_YEAR))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.OTHER_PERSON_YEAR.Contain(model.OTHER_PERSON_YEAR));
				}
				if(model.FINANCE_YEAR1!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.FINANCE_YEAR1==(model.FINANCE_YEAR1));
				}
				if(model.FINANCE_YEAR2!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.FINANCE_YEAR2==(model.FINANCE_YEAR2));
				}
				if(model.FINANCE_YEAR3!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.FINANCE_YEAR3==(model.FINANCE_YEAR3));
				}
				if(model.AVE_TURNOVER!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.AVE_TURNOVER==(model.AVE_TURNOVER));
				}
				if(model.REPUTATION_TIME1!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.REPUTATION_TIME1==(model.REPUTATION_TIME1));
				}
				if(model.REPUTATION_TIME2!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.REPUTATION_TIME2==(model.REPUTATION_TIME2));
				}
				if(model.REPUTATION_TIME4!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.REPUTATION_TIME4==(model.REPUTATION_TIME4));
				}
				if(model.REPUTATION_LEVEL!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.REPUTATION_LEVEL==(model.REPUTATION_LEVEL));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBC_NAME))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.SUBC_NAME.Contain(model.SUBC_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_APPROVAL))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.PROJECT_APPROVAL.Contain(model.PROJECT_APPROVAL));
				}
				if(!string.IsNullOrWhiteSpace(model.FUND_PLACE))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.FUND_PLACE.Contain(model.FUND_PLACE));
				}
				if(!string.IsNullOrWhiteSpace(model.DRAWING))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.DRAWING.Contain(model.DRAWING));
				}
				if(!string.IsNullOrWhiteSpace(model.ENCLOSURE1))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.ENCLOSURE1.Contain(model.ENCLOSURE1));
				}
				if(!string.IsNullOrWhiteSpace(model.ENCLOSURE2))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.ENCLOSURE2.Contain(model.ENCLOSURE2));
				}
				if(!string.IsNullOrWhiteSpace(model.ENCLOSURE3))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.ENCLOSURE3.Contain(model.ENCLOSURE3));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALIFICATION_REQUIRE))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.QUALIFICATION_REQUIRE.Contain(model.QUALIFICATION_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.REMARK.Contain(model.REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.MARGIN_NAME.Contain(model.MARGIN_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.MARGIN_NUMBER.Contain(model.MARGIN_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.MARGIN_BANK.Contain(model.MARGIN_BANK));
				}
				if(model.MARGIN_TIME!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.MARGIN_TIME==(model.MARGIN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MEDIA1))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.MEDIA1.Contain(model.MEDIA1));
				}
				if(!string.IsNullOrWhiteSpace(model.MEDIA2))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.MEDIA2.Contain(model.MEDIA2));
				}
				if(!string.IsNullOrWhiteSpace(model.SECTION_DIVIDE_CONTENT))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.SECTION_DIVIDE_CONTENT.Contain(model.SECTION_DIVIDE_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONST_MANAGEMENT))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.CONST_MANAGEMENT.Contain(model.CONST_MANAGEMENT));
				}
				if(model.ANSWER_QUESTION_TIME!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.ANSWER_QUESTION_TIME==(model.ANSWER_QUESTION_TIME));
				}
				if(model.DOC_NUMBER!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.DOC_NUMBER==(model.DOC_NUMBER));
				}
				if(model.COPY_NUM!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.COPY_NUM==(model.COPY_NUM));
				}
				if(model.BID_CONFIDENTIAL_TIME!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.BID_CONFIDENTIAL_TIME==(model.BID_CONFIDENTIAL_TIME));
				}
				if(model.NOTIFICATION_TIME!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.NOTIFICATION_TIME==(model.NOTIFICATION_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MAIN_ENGINEER_QUANTITY_LIST))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.MAIN_ENGINEER_QUANTITY_LIST.Contain(model.MAIN_ENGINEER_QUANTITY_LIST));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.SUPERVISE_DEPT_NAME.Contain(model.SUPERVISE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_PHONE))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.SUPERVISE_DEPT_PHONE.Contain(model.SUPERVISE_DEPT_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ADDRESS))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.SUPERVISE_DEPT_ADDRESS.Contain(model.SUPERVISE_DEPT_ADDRESS));
				}
				if(model.SUPERVISE_DEPT_ZIP_CODE!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.SUPERVISE_DEPT_ZIP_CODE==(model.SUPERVISE_DEPT_ZIP_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_FAX))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.SUPERVISE_DEPT_FAX.Contain(model.SUPERVISE_DEPT_FAX));
				}
				if(model.QUESTION_TIME!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.QUESTION_TIME==(model.QUESTION_TIME));
				}
				if(model.TENDER_NOTICE_TIME!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.TENDER_NOTICE_TIME==(model.TENDER_NOTICE_TIME));
				}
				if(model.BIDDER_NOTICE_TIME!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.BIDDER_NOTICE_TIME==(model.BIDDER_NOTICE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_REQUIREMENTS))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.OTHER_REQUIREMENTS.Contain(model.OTHER_REQUIREMENTS));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_DESCRIPTION))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.PROJECT_DESCRIPTION.Contain(model.PROJECT_DESCRIPTION));
				}
				if(!string.IsNullOrWhiteSpace(model.SKETCH_MAP))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.SKETCH_MAP.Contain(model.SKETCH_MAP));
				}
				if(!string.IsNullOrWhiteSpace(model.PERIOD_SERVICE_TIME))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.PERIOD_SERVICE_TIME.Contain(model.PERIOD_SERVICE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MINIMUM_QUALIFICATIONS))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.MINIMUM_QUALIFICATIONS.Contain(model.MINIMUM_QUALIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHIEVEMENT_REQUIRE))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.ACHIEVEMENT_REQUIRE.Contain(model.ACHIEVEMENT_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_PERSON_REQUIRE))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.OTHER_PERSON_REQUIRE.Contain(model.OTHER_PERSON_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.EQUIPMENT_REQUIRE))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.EQUIPMENT_REQUIRE.Contain(model.EQUIPMENT_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.FINANCIAL_REQUIRE))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.FINANCIAL_REQUIRE.Contain(model.FINANCIAL_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.REPUTATION_REQUIRE))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.REPUTATION_REQUIRE.Contain(model.REPUTATION_REQUIRE));
				}
				if(model.REVIEW_AAAW_YEAR!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.REVIEW_AAAW_YEAR==(model.REVIEW_AAAW_YEAR));
				}
				if(model.AA_BID_NUMBER!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.AA_BID_NUMBER==(model.AA_BID_NUMBER));
				}
				if(model.A_BID_NUMBER!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.A_BID_NUMBER==(model.A_BID_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISION_STANDARD))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.SUPERVISION_STANDARD.Contain(model.SUPERVISION_STANDARD));
				}
				if(model.BOND_SUBMIT_TIME!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.BOND_SUBMIT_TIME==(model.BOND_SUBMIT_TIME));
				}
				if(model.PERFORM_PRICE_TIME!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.PERFORM_PRICE_TIME==(model.PERFORM_PRICE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_RETURN_TYPE))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.MARGIN_RETURN_TYPE.Contain(model.MARGIN_RETURN_TYPE));
				}
				if(model.PERFORM_PRICE!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.PERFORM_PRICE==(model.PERFORM_PRICE));
				}
				if(model.ACHIE_YEAR!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.ACHIE_YEAR==(model.ACHIE_YEAR));
				}
				if(model.ACHIE_YEAR_BEGIN!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.ACHIE_YEAR_BEGIN==(model.ACHIE_YEAR_BEGIN));
				}
				if(!string.IsNullOrWhiteSpace(model.CHANGE))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.CHANGE.Contain(model.CHANGE));
				}
				if(!string.IsNullOrWhiteSpace(model.DEFINITION_EXPLANATION))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.DEFINITION_EXPLANATION.Contain(model.DEFINITION_EXPLANATION));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISOR_OBLIGATIONS))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.SUPERVISOR_OBLIGATIONS.Contain(model.SUPERVISOR_OBLIGATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.EMPLOYER_DUTY))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.EMPLOYER_DUTY.Contain(model.EMPLOYER_DUTY));
				}
				if(!string.IsNullOrWhiteSpace(model.RESPONSIBILITY))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.RESPONSIBILITY.Contain(model.RESPONSIBILITY));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_OPERATION))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.CONTRACT_OPERATION.Contain(model.CONTRACT_OPERATION));
				}
				if(!string.IsNullOrWhiteSpace(model.MEASUREMENT_PAYMENT))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.MEASUREMENT_PAYMENT.Contain(model.MEASUREMENT_PAYMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.DISPUTE_RESOLUTION))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.DISPUTE_RESOLUTION.Contain(model.DISPUTE_RESOLUTION));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_CONVENTIONS))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.OTHER_CONVENTIONS.Contain(model.OTHER_CONVENTIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPPLY_ITEM))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.SUPPLY_ITEM.Contain(model.SUPPLY_ITEM));
				}
				if(!string.IsNullOrWhiteSpace(model.UPERVISION_STANDARD))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.UPERVISION_STANDARD.Contain(model.UPERVISION_STANDARD));
				}
				if(!string.IsNullOrWhiteSpace(model.ENGINEERING_SPECIFICATIONS))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.ENGINEERING_SPECIFICATIONS.Contain(model.ENGINEERING_SPECIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.TECHNICAL_SPECIFICATIONS))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.TECHNICAL_SPECIFICATIONS.Contain(model.TECHNICAL_SPECIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(JT_GEN_SUPER_TENDER_FILE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}