using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JtSuperTenderFileService : BaseServiceT<JT_SUPER_TENDER_FILE>
    {
        #region 接口实现
        
		public List<JT_SUPER_TENDER_FILE> FindList(JT_SUPER_TENDER_FILE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JT_SUPER_TENDER_FILE> PageList(JT_SUPER_TENDER_FILE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JT_SUPER_TENDER_FILE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(JT_SUPER_TENDER_FILE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(JT_SUPER_TENDER_FILE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is JT_SUPER_TENDER_FILE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.PROJECT_PROFILE=model.PROJECT_PROFILE;
		entity.CONTRACT_SECTION=model.CONTRACT_SECTION;
		entity.ACHIEVEMENT_CONDITIONS=model.ACHIEVEMENT_CONDITIONS;
		entity.CONTRACT_SEGMENT=model.CONTRACT_SEGMENT;
		entity.TENDER_NUMBER=model.TENDER_NUMBER;
		entity.MEDIA1=model.MEDIA1;
		entity.MEDIA2=model.MEDIA2;
		entity.FUND_IMPLEMENTATION=model.FUND_IMPLEMENTATION;
		entity.QUALITY_TARGET=model.QUALITY_TARGET;
		entity.SECURITY_TARGET=model.SECURITY_TARGET;
		entity.MINIMUM_QUALIFICATIONS=model.MINIMUM_QUALIFICATIONS;
		entity.ACHIEVEMENT_REQUIRE=model.ACHIEVEMENT_REQUIRE;
		entity.REPUTATION_REQUIRE=model.REPUTATION_REQUIRE;
		entity.LOAN_RATIO=model.LOAN_RATIO;
		entity.CAPITAL_RATIO=model.CAPITAL_RATIO;
		entity.ACHI_REQUIRE_YEAR=model.ACHI_REQUIRE_YEAR;
		entity.REPU_REQUIRE_YEAR=model.REPU_REQUIRE_YEAR;
		entity.MARGIN_TIME=model.MARGIN_TIME;
		entity.MARGIN_NAME=model.MARGIN_NAME;
		entity.MARGIN_NUMBER=model.MARGIN_NUMBER;
		entity.MARGIN_BANK=model.MARGIN_BANK;
		entity.FINANCIAL_REQUIRE_YEAR=model.FINANCIAL_REQUIRE_YEAR;
		entity.ALL_EXPERT_NUM=model.ALL_EXPERT_NUM;
		entity.TENDERER_NUM=model.TENDERER_NUM;
		entity.EXPERT_NUM=model.EXPERT_NUM;
		entity.SUPERVISE_DEPT_NAME=model.SUPERVISE_DEPT_NAME;
		entity.SUPERVISE_DEPT_TELE=model.SUPERVISE_DEPT_TELE;
		entity.SUPERVISE_DEPT_ADDRESS=model.SUPERVISE_DEPT_ADDRESS;
		entity.TECH_REQUIREMENTS=model.TECH_REQUIREMENTS;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
		entity.LIMITE_ALL_TIME=model.LIMITE_ALL_TIME;
		entity.DEFECT_LIABILITY_PERIOD1=model.DEFECT_LIABILITY_PERIOD1;
		entity.BID_SECTION=model.BID_SECTION;
		entity.TENDERER_BID_SECTION=model.TENDERER_BID_SECTION;
		entity.OTHER_MATTERS=model.OTHER_MATTERS;
		entity.OTHER=model.OTHER;
		entity.OTHER_CONTENT=model.OTHER_CONTENT;
		entity.UNIT_SELECTION=model.UNIT_SELECTION;
		entity.PROJECT_YEAR_REQUIRED_TIME=model.PROJECT_YEAR_REQUIRED_TIME;
		entity.LITIGATION_YEAR_REQUIRED_TIME=model.LITIGATION_YEAR_REQUIRED_TIME;
		entity.EVALUATING_METHOD_STANDARD=model.EVALUATING_METHOD_STANDARD;
		entity.SUPERVISE_DEPT_ZIP_CODE=model.SUPERVISE_DEPT_ZIP_CODE;
		entity.EXPERT_EXTRACT=model.EXPERT_EXTRACT;
		entity.FINANCIAL_REQUIRE=model.FINANCIAL_REQUIRE;
		entity.QUALIFICATION_REQUIRE=model.QUALIFICATION_REQUIRE;
		entity.WIN_CANDIDATE_NUM=model.WIN_CANDIDATE_NUM;
		entity.SUBC_NAME=model.SUBC_NAME;
		entity.SUBC_ADDRESS=model.SUBC_ADDRESS;
		entity.SUBC_ZIP_CODE=model.SUBC_ZIP_CODE;
		entity.CONVENTION=model.CONVENTION;
		entity.MATERIAL=model.MATERIAL;
		entity.DISPUTE_RESOLUTION=model.DISPUTE_RESOLUTION;
		entity.ARBITRATION_COMMISSION=model.ARBITRATION_COMMISSION;
		entity.DOCUMENT_CHARGES=model.DOCUMENT_CHARGES;
		entity.MINIMUM_LIMIT=model.MINIMUM_LIMIT;
		entity.BILL_OF_QUANTITIES=model.BILL_OF_QUANTITIES;
		entity.DRAWING=model.DRAWING;
		entity.TECHNICAL_SPECIFICATIONS=model.TECHNICAL_SPECIFICATIONS;
		entity.SUPPLY_TECHNICAL_STANDARD=model.SUPPLY_TECHNICAL_STANDARD;
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
        public GeneralResult Add(JT_SUPER_TENDER_FILE model)
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
                    Delete(JT_SUPER_TENDER_FILE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JT_SUPER_TENDER_FILE> model)
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
       	protected WhereClipBuilder ConditionBuilder(JT_SUPER_TENDER_FILE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_PROFILE))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.PROJECT_PROFILE.Contain(model.PROJECT_PROFILE));
				}
				if(model.CONTRACT_SECTION!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.CONTRACT_SECTION==(model.CONTRACT_SECTION));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHIEVEMENT_CONDITIONS))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.ACHIEVEMENT_CONDITIONS.Contain(model.ACHIEVEMENT_CONDITIONS));
				}
				if(model.CONTRACT_SEGMENT!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.CONTRACT_SEGMENT==(model.CONTRACT_SEGMENT));
				}
				if(model.TENDER_NUMBER!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.TENDER_NUMBER==(model.TENDER_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.MEDIA1))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.MEDIA1.Contain(model.MEDIA1));
				}
				if(!string.IsNullOrWhiteSpace(model.MEDIA2))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.MEDIA2.Contain(model.MEDIA2));
				}
				if(!string.IsNullOrWhiteSpace(model.FUND_IMPLEMENTATION))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.FUND_IMPLEMENTATION.Contain(model.FUND_IMPLEMENTATION));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALITY_TARGET))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.QUALITY_TARGET.Contain(model.QUALITY_TARGET));
				}
				if(!string.IsNullOrWhiteSpace(model.SECURITY_TARGET))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.SECURITY_TARGET.Contain(model.SECURITY_TARGET));
				}
				if(!string.IsNullOrWhiteSpace(model.MINIMUM_QUALIFICATIONS))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.MINIMUM_QUALIFICATIONS.Contain(model.MINIMUM_QUALIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHIEVEMENT_REQUIRE))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.ACHIEVEMENT_REQUIRE.Contain(model.ACHIEVEMENT_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.REPUTATION_REQUIRE))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.REPUTATION_REQUIRE.Contain(model.REPUTATION_REQUIRE));
				}
				if(model.LOAN_RATIO!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.LOAN_RATIO==(model.LOAN_RATIO));
				}
				if(model.CAPITAL_RATIO!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.CAPITAL_RATIO==(model.CAPITAL_RATIO));
				}
				if(model.ACHI_REQUIRE_YEAR!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.ACHI_REQUIRE_YEAR==(model.ACHI_REQUIRE_YEAR));
				}
				if(model.REPU_REQUIRE_YEAR!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.REPU_REQUIRE_YEAR==(model.REPU_REQUIRE_YEAR));
				}
				if(model.MARGIN_TIME!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.MARGIN_TIME==(model.MARGIN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.MARGIN_NAME.Contain(model.MARGIN_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.MARGIN_NUMBER.Contain(model.MARGIN_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.MARGIN_BANK.Contain(model.MARGIN_BANK));
				}
				if(!string.IsNullOrWhiteSpace(model.FINANCIAL_REQUIRE_YEAR))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.FINANCIAL_REQUIRE_YEAR.Contain(model.FINANCIAL_REQUIRE_YEAR));
				}
				if(model.ALL_EXPERT_NUM!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.ALL_EXPERT_NUM==(model.ALL_EXPERT_NUM));
				}
				if(model.TENDERER_NUM!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.TENDERER_NUM==(model.TENDERER_NUM));
				}
				if(model.EXPERT_NUM!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.EXPERT_NUM==(model.EXPERT_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.SUPERVISE_DEPT_NAME.Contain(model.SUPERVISE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_TELE))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.SUPERVISE_DEPT_TELE.Contain(model.SUPERVISE_DEPT_TELE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ADDRESS))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.SUPERVISE_DEPT_ADDRESS.Contain(model.SUPERVISE_DEPT_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.TECH_REQUIREMENTS))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.TECH_REQUIREMENTS.Contain(model.TECH_REQUIREMENTS));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.M_TM==(model.M_TM));
				}
				if(model.LIMITE_ALL_TIME!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.LIMITE_ALL_TIME==(model.LIMITE_ALL_TIME));
				}
				if(model.DEFECT_LIABILITY_PERIOD1!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.DEFECT_LIABILITY_PERIOD1==(model.DEFECT_LIABILITY_PERIOD1));
				}
				if(model.BID_SECTION!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.BID_SECTION==(model.BID_SECTION));
				}
				if(model.TENDERER_BID_SECTION!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.TENDERER_BID_SECTION==(model.TENDERER_BID_SECTION));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_MATTERS))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.OTHER_MATTERS.Contain(model.OTHER_MATTERS));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.OTHER.Contain(model.OTHER));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_CONTENT))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.OTHER_CONTENT.Contain(model.OTHER_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIT_SELECTION))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.UNIT_SELECTION.Contain(model.UNIT_SELECTION));
				}
				if(model.PROJECT_YEAR_REQUIRED_TIME!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.PROJECT_YEAR_REQUIRED_TIME==(model.PROJECT_YEAR_REQUIRED_TIME));
				}
				if(model.LITIGATION_YEAR_REQUIRED_TIME!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.LITIGATION_YEAR_REQUIRED_TIME==(model.LITIGATION_YEAR_REQUIRED_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATING_METHOD_STANDARD))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.EVALUATING_METHOD_STANDARD.Contain(model.EVALUATING_METHOD_STANDARD));
				}
				if(model.SUPERVISE_DEPT_ZIP_CODE!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.SUPERVISE_DEPT_ZIP_CODE==(model.SUPERVISE_DEPT_ZIP_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_EXTRACT))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.EXPERT_EXTRACT.Contain(model.EXPERT_EXTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.FINANCIAL_REQUIRE))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.FINANCIAL_REQUIRE.Contain(model.FINANCIAL_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALIFICATION_REQUIRE))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.QUALIFICATION_REQUIRE.Contain(model.QUALIFICATION_REQUIRE));
				}
				if(model.WIN_CANDIDATE_NUM!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.WIN_CANDIDATE_NUM==(model.WIN_CANDIDATE_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBC_NAME))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.SUBC_NAME.Contain(model.SUBC_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBC_ADDRESS))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.SUBC_ADDRESS.Contain(model.SUBC_ADDRESS));
				}
				if(model.SUBC_ZIP_CODE!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.SUBC_ZIP_CODE==(model.SUBC_ZIP_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONVENTION))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.CONVENTION.Contain(model.CONVENTION));
				}
				if(!string.IsNullOrWhiteSpace(model.MATERIAL))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.MATERIAL.Contain(model.MATERIAL));
				}
				if(!string.IsNullOrWhiteSpace(model.DISPUTE_RESOLUTION))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.DISPUTE_RESOLUTION.Contain(model.DISPUTE_RESOLUTION));
				}
				if(!string.IsNullOrWhiteSpace(model.ARBITRATION_COMMISSION))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.ARBITRATION_COMMISSION.Contain(model.ARBITRATION_COMMISSION));
				}
				if(model.DOCUMENT_CHARGES!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.DOCUMENT_CHARGES==(model.DOCUMENT_CHARGES));
				}
				if(model.MINIMUM_LIMIT!=null)
				{
				  condition.And(JT_SUPER_TENDER_FILE._.MINIMUM_LIMIT==(model.MINIMUM_LIMIT));
				}
				if(!string.IsNullOrWhiteSpace(model.BILL_OF_QUANTITIES))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.BILL_OF_QUANTITIES.Contain(model.BILL_OF_QUANTITIES));
				}
				if(!string.IsNullOrWhiteSpace(model.DRAWING))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.DRAWING.Contain(model.DRAWING));
				}
				if(!string.IsNullOrWhiteSpace(model.TECHNICAL_SPECIFICATIONS))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.TECHNICAL_SPECIFICATIONS.Contain(model.TECHNICAL_SPECIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPPLY_TECHNICAL_STANDARD))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.SUPPLY_TECHNICAL_STANDARD.Contain(model.SUPPLY_TECHNICAL_STANDARD));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(JT_SUPER_TENDER_FILE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}