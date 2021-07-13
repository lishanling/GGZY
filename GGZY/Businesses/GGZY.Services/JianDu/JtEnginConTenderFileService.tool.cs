using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JtEnginConTenderFileService : BaseServiceT<JT_ENGIN_CON_TENDER_FILE>
    {
        #region 接口实现
        
		public List<JT_ENGIN_CON_TENDER_FILE> FindList(JT_ENGIN_CON_TENDER_FILE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JT_ENGIN_CON_TENDER_FILE> PageList(JT_ENGIN_CON_TENDER_FILE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JT_ENGIN_CON_TENDER_FILE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(JT_ENGIN_CON_TENDER_FILE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(JT_ENGIN_CON_TENDER_FILE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is JT_ENGIN_CON_TENDER_FILE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.LIMITE_ALL_TIME=model.LIMITE_ALL_TIME;
		entity.TOTAL_CONTRACT_SECTION=model.TOTAL_CONTRACT_SECTION;
		entity.CONTRACT_SECTION=model.CONTRACT_SECTION;
		entity.CONTRACT_SECTION_NUMBER=model.CONTRACT_SECTION_NUMBER;
		entity.ACHIEVEMENT=model.ACHIEVEMENT;
		entity.OTHER_MATTERS=model.OTHER_MATTERS;
		entity.MEDIA1=model.MEDIA1;
		entity.MEDIA2=model.MEDIA2;
		entity.FUND_IMPLEMENTATION=model.FUND_IMPLEMENTATION;
		entity.BEGIN_ALL_DATE=model.BEGIN_ALL_DATE;
		entity.END_DATE=model.END_DATE;
		entity.PROJECT_QUALITY_TARGET=model.PROJECT_QUALITY_TARGET;
		entity.BID_SAFETY_OBJECTIVES=model.BID_SAFETY_OBJECTIVES;
		entity.MINIMUM_QUALIFICATIONS=model.MINIMUM_QUALIFICATIONS;
		entity.FINANCIAL_REQUIRE=model.FINANCIAL_REQUIRE;
		entity.ACHIEVEMENT_REQUIRE=model.ACHIEVEMENT_REQUIRE;
		entity.REPUTATION_REQUIRE=model.REPUTATION_REQUIRE;
		entity.TENDER_DOC_OTHER=model.TENDER_DOC_OTHER;
		entity.MARGIN_TIME=model.MARGIN_TIME;
		entity.MARGIN_NAME=model.MARGIN_NAME;
		entity.MARGIN_NUMBER=model.MARGIN_NUMBER;
		entity.MARGIN_BANK=model.MARGIN_BANK;
		entity.PROJECT_YEAR_REQUIRED=model.PROJECT_YEAR_REQUIRED;
		entity.LITIGATION_YEAR_REQUIRED=model.LITIGATION_YEAR_REQUIRED;
		entity.ALL_EXPERT_NUM=model.ALL_EXPERT_NUM;
		entity.TENDERER_NUM=model.TENDERER_NUM;
		entity.EXPERT_NUM=model.EXPERT_NUM;
		entity.PERFORM_PRICE_TYPE=model.PERFORM_PRICE_TYPE;
		entity.SUPERVISE_DEPT_NAME=model.SUPERVISE_DEPT_NAME;
		entity.SUPERVISE_DEPT_TELE=model.SUPERVISE_DEPT_TELE;
		entity.SUPERVISE_DEPT_ADDRESS=model.SUPERVISE_DEPT_ADDRESS;
		entity.SUPERVISE_DEPT_FAX=model.SUPERVISE_DEPT_FAX;
		entity.SUPERVISE_DEPT_ZIP_CODE=model.SUPERVISE_DEPT_ZIP_CODE;
		entity.WIN_CANDIDATE_NUM=model.WIN_CANDIDATE_NUM;
		entity.OTHER_CONTENT=model.OTHER_CONTENT;
		entity.EVALUATING_METHOD_STANDARD=model.EVALUATING_METHOD_STANDARD;
		entity.SUBC_NAME=model.SUBC_NAME;
		entity.SUBC_NAME_ADDRESS=model.SUBC_NAME_ADDRESS;
		entity.SUBC_ZIP_CODE=model.SUBC_ZIP_CODE;
		entity.SUPERVISOR=model.SUPERVISOR;
		entity.SUPERVISOR_ADDRESS=model.SUPERVISOR_ADDRESS;
		entity.SUPERVISOR_ZIP_CODE=model.SUPERVISOR_ZIP_CODE;
		entity.DEFECT_LIABILITY_PERIOD1=model.DEFECT_LIABILITY_PERIOD1;
		entity.DRAWING_MODIFICATION=model.DRAWING_MODIFICATION;
		entity.DATA_PERIOD=model.DATA_PERIOD;
		entity.APPROVAL_PERIOD=model.APPROVAL_PERIOD;
		entity.DELAY_PENALTY=model.DELAY_PENALTY;
		entity.SUBMIT_REQUISITION=model.SUBMIT_REQUISITION;
		entity.MONTHLY_PAYMENT=model.MONTHLY_PAYMENT;
		entity.PAYMENT_APPLICATION=model.PAYMENT_APPLICATION;
		entity.APPLICATION_NUM=model.APPLICATION_NUM;
		entity.COMPLETION_DATA=model.COMPLETION_DATA;
		entity.CONSTRUCTION_PERIOD_OPERATION=model.CONSTRUCTION_PERIOD_OPERATION;
		entity.OPERATING_REGULATIONS=model.OPERATING_REGULATIONS;
		entity.DISPUTE_RESOLUTION=model.DISPUTE_RESOLUTION;
		entity.ARBITRATION_COMMISSION=model.ARBITRATION_COMMISSION;
		entity.PUBLISH_WEBSITE=model.PUBLISH_WEBSITE;
		entity.PROVICE_NETWORKING=model.PROVICE_NETWORKING;
		entity.CONTRACT_CLAUSE=model.CONTRACT_CLAUSE;
		entity.BILL_OF_QUANTITIES=model.BILL_OF_QUANTITIES;
		entity.DRAWING=model.DRAWING;
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
        public GeneralResult Add(JT_ENGIN_CON_TENDER_FILE model)
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
                    Delete(JT_ENGIN_CON_TENDER_FILE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JT_ENGIN_CON_TENDER_FILE> model)
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
       	protected WhereClipBuilder ConditionBuilder(JT_ENGIN_CON_TENDER_FILE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(model.LIMITE_ALL_TIME!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.LIMITE_ALL_TIME==(model.LIMITE_ALL_TIME));
				}
				if(model.TOTAL_CONTRACT_SECTION!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.TOTAL_CONTRACT_SECTION==(model.TOTAL_CONTRACT_SECTION));
				}
				if(model.CONTRACT_SECTION!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.CONTRACT_SECTION==(model.CONTRACT_SECTION));
				}
				if(model.CONTRACT_SECTION_NUMBER!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.CONTRACT_SECTION_NUMBER==(model.CONTRACT_SECTION_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHIEVEMENT))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.ACHIEVEMENT.Contain(model.ACHIEVEMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_MATTERS))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.OTHER_MATTERS.Contain(model.OTHER_MATTERS));
				}
				if(!string.IsNullOrWhiteSpace(model.MEDIA1))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.MEDIA1.Contain(model.MEDIA1));
				}
				if(!string.IsNullOrWhiteSpace(model.MEDIA2))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.MEDIA2.Contain(model.MEDIA2));
				}
				if(!string.IsNullOrWhiteSpace(model.FUND_IMPLEMENTATION))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.FUND_IMPLEMENTATION.Contain(model.FUND_IMPLEMENTATION));
				}
				if(model.BEGIN_ALL_DATE!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.BEGIN_ALL_DATE==(model.BEGIN_ALL_DATE));
				}
				if(model.END_DATE!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.END_DATE==(model.END_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_QUALITY_TARGET))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.PROJECT_QUALITY_TARGET.Contain(model.PROJECT_QUALITY_TARGET));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SAFETY_OBJECTIVES))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.BID_SAFETY_OBJECTIVES.Contain(model.BID_SAFETY_OBJECTIVES));
				}
				if(!string.IsNullOrWhiteSpace(model.MINIMUM_QUALIFICATIONS))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.MINIMUM_QUALIFICATIONS.Contain(model.MINIMUM_QUALIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.FINANCIAL_REQUIRE))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.FINANCIAL_REQUIRE.Contain(model.FINANCIAL_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHIEVEMENT_REQUIRE))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.ACHIEVEMENT_REQUIRE.Contain(model.ACHIEVEMENT_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.REPUTATION_REQUIRE))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.REPUTATION_REQUIRE.Contain(model.REPUTATION_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_DOC_OTHER))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.TENDER_DOC_OTHER.Contain(model.TENDER_DOC_OTHER));
				}
				if(model.MARGIN_TIME!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.MARGIN_TIME==(model.MARGIN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.MARGIN_NAME.Contain(model.MARGIN_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.MARGIN_NUMBER.Contain(model.MARGIN_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.MARGIN_BANK.Contain(model.MARGIN_BANK));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_YEAR_REQUIRED))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.PROJECT_YEAR_REQUIRED.Contain(model.PROJECT_YEAR_REQUIRED));
				}
				if(!string.IsNullOrWhiteSpace(model.LITIGATION_YEAR_REQUIRED))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.LITIGATION_YEAR_REQUIRED.Contain(model.LITIGATION_YEAR_REQUIRED));
				}
				if(model.ALL_EXPERT_NUM!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.ALL_EXPERT_NUM==(model.ALL_EXPERT_NUM));
				}
				if(model.TENDERER_NUM!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.TENDERER_NUM==(model.TENDERER_NUM));
				}
				if(model.EXPERT_NUM!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.EXPERT_NUM==(model.EXPERT_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORM_PRICE_TYPE))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.PERFORM_PRICE_TYPE.Contain(model.PERFORM_PRICE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.SUPERVISE_DEPT_NAME.Contain(model.SUPERVISE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_TELE))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.SUPERVISE_DEPT_TELE.Contain(model.SUPERVISE_DEPT_TELE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ADDRESS))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.SUPERVISE_DEPT_ADDRESS.Contain(model.SUPERVISE_DEPT_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_FAX))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.SUPERVISE_DEPT_FAX.Contain(model.SUPERVISE_DEPT_FAX));
				}
				if(model.SUPERVISE_DEPT_ZIP_CODE!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.SUPERVISE_DEPT_ZIP_CODE==(model.SUPERVISE_DEPT_ZIP_CODE));
				}
				if(model.WIN_CANDIDATE_NUM!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.WIN_CANDIDATE_NUM==(model.WIN_CANDIDATE_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_CONTENT))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.OTHER_CONTENT.Contain(model.OTHER_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATING_METHOD_STANDARD))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.EVALUATING_METHOD_STANDARD.Contain(model.EVALUATING_METHOD_STANDARD));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBC_NAME))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.SUBC_NAME.Contain(model.SUBC_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBC_NAME_ADDRESS))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.SUBC_NAME_ADDRESS.Contain(model.SUBC_NAME_ADDRESS));
				}
				if(model.SUBC_ZIP_CODE!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.SUBC_ZIP_CODE==(model.SUBC_ZIP_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISOR))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.SUPERVISOR.Contain(model.SUPERVISOR));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISOR_ADDRESS))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.SUPERVISOR_ADDRESS.Contain(model.SUPERVISOR_ADDRESS));
				}
				if(model.SUPERVISOR_ZIP_CODE!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.SUPERVISOR_ZIP_CODE==(model.SUPERVISOR_ZIP_CODE));
				}
				if(model.DEFECT_LIABILITY_PERIOD1!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.DEFECT_LIABILITY_PERIOD1==(model.DEFECT_LIABILITY_PERIOD1));
				}
				if(model.DRAWING_MODIFICATION!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.DRAWING_MODIFICATION==(model.DRAWING_MODIFICATION));
				}
				if(model.DATA_PERIOD!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.DATA_PERIOD==(model.DATA_PERIOD));
				}
				if(model.APPROVAL_PERIOD!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.APPROVAL_PERIOD==(model.APPROVAL_PERIOD));
				}
				if(model.DELAY_PENALTY!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.DELAY_PENALTY==(model.DELAY_PENALTY));
				}
				if(model.SUBMIT_REQUISITION!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.SUBMIT_REQUISITION==(model.SUBMIT_REQUISITION));
				}
				if(model.MONTHLY_PAYMENT!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.MONTHLY_PAYMENT==(model.MONTHLY_PAYMENT));
				}
				if(model.PAYMENT_APPLICATION!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.PAYMENT_APPLICATION==(model.PAYMENT_APPLICATION));
				}
				if(model.APPLICATION_NUM!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.APPLICATION_NUM==(model.APPLICATION_NUM));
				}
				if(model.COMPLETION_DATA!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.COMPLETION_DATA==(model.COMPLETION_DATA));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCTION_PERIOD_OPERATION))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.CONSTRUCTION_PERIOD_OPERATION.Contain(model.CONSTRUCTION_PERIOD_OPERATION));
				}
				if(!string.IsNullOrWhiteSpace(model.OPERATING_REGULATIONS))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.OPERATING_REGULATIONS.Contain(model.OPERATING_REGULATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.DISPUTE_RESOLUTION))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.DISPUTE_RESOLUTION.Contain(model.DISPUTE_RESOLUTION));
				}
				if(!string.IsNullOrWhiteSpace(model.ARBITRATION_COMMISSION))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.ARBITRATION_COMMISSION.Contain(model.ARBITRATION_COMMISSION));
				}
				if(!string.IsNullOrWhiteSpace(model.PUBLISH_WEBSITE))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.PUBLISH_WEBSITE.Contain(model.PUBLISH_WEBSITE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROVICE_NETWORKING))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.PROVICE_NETWORKING.Contain(model.PROVICE_NETWORKING));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_CLAUSE))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.CONTRACT_CLAUSE.Contain(model.CONTRACT_CLAUSE));
				}
				if(!string.IsNullOrWhiteSpace(model.BILL_OF_QUANTITIES))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.BILL_OF_QUANTITIES.Contain(model.BILL_OF_QUANTITIES));
				}
				if(!string.IsNullOrWhiteSpace(model.DRAWING))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.DRAWING.Contain(model.DRAWING));
				}
				if(!string.IsNullOrWhiteSpace(model.TECHNICAL_SPECIFICATIONS))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.TECHNICAL_SPECIFICATIONS.Contain(model.TECHNICAL_SPECIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(JT_ENGIN_CON_TENDER_FILE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}