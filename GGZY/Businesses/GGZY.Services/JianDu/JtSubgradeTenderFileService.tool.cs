using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JtSubgradeTenderFileService : BaseServiceT<JT_SUBGRADE_TENDER_FILE>
    {
        #region 接口实现
        
		public List<JT_SUBGRADE_TENDER_FILE> FindList(JT_SUBGRADE_TENDER_FILE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JT_SUBGRADE_TENDER_FILE> PageList(JT_SUBGRADE_TENDER_FILE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JT_SUBGRADE_TENDER_FILE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(JT_SUBGRADE_TENDER_FILE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(JT_SUBGRADE_TENDER_FILE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is JT_SUBGRADE_TENDER_FILE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.LIMITE_ALL_TIME=model.LIMITE_ALL_TIME;
		entity.DEFECT_LIABILITY_PERIOD1=model.DEFECT_LIABILITY_PERIOD1;
		entity.BID_SECTION=model.BID_SECTION;
		entity.BID_SECTION_GROUP=model.BID_SECTION_GROUP;
		entity.TENDERER_BID_SECTION=model.TENDERER_BID_SECTION;
		entity.TENDERER_BID_SECTION_GROUP=model.TENDERER_BID_SECTION_GROUP;
		entity.CONTRACT_SEGMENT=model.CONTRACT_SEGMENT;
		entity.TENDER_NUMBER=model.TENDER_NUMBER;
		entity.OTHER_MATTERS=model.OTHER_MATTERS;
		entity.RECONNAISSANCE=model.RECONNAISSANCE;
		entity.RECONNAISSANCE_TIME=model.RECONNAISSANCE_TIME;
		entity.RECONNAISSANCE_ADDRESS=model.RECONNAISSANCE_ADDRESS;
		entity.PREPARATORY_MEETING=model.PREPARATORY_MEETING;
		entity.PREPARATORY_MEETING_TIME=model.PREPARATORY_MEETING_TIME;
		entity.PREPARATORY_MEETING_ADDRESS=model.PREPARATORY_MEETING_ADDRESS;
		entity.VEHICLE=model.VEHICLE;
		entity.MEDIA1=model.MEDIA1;
		entity.MEDIA2=model.MEDIA2;
		entity.OTHER=model.OTHER;
		entity.FUND_IMPLEMENTATION=model.FUND_IMPLEMENTATION;
		entity.BEGIN_ALL_DATE=model.BEGIN_ALL_DATE;
		entity.END_DATE=model.END_DATE;
		entity.SECURITY_TARGET=model.SECURITY_TARGET;
		entity.MARGIN_TIME=model.MARGIN_TIME;
		entity.MARGIN_NAME=model.MARGIN_NAME;
		entity.MARGIN_NUMBER=model.MARGIN_NUMBER;
		entity.MARGIN_BANK=model.MARGIN_BANK;
		entity.PROJECT_YEAR_REQUIRED_TIME=model.PROJECT_YEAR_REQUIRED_TIME;
		entity.LITIGATION_YEAR_REQUIRED_TIME=model.LITIGATION_YEAR_REQUIRED_TIME;
		entity.SUPERVISE_DEPT_NAME=model.SUPERVISE_DEPT_NAME;
		entity.SUPERVISE_DEPT_TELE=model.SUPERVISE_DEPT_TELE;
		entity.SUPERVISE_DEPT_ADDRESS=model.SUPERVISE_DEPT_ADDRESS;
		entity.SUPERVISE_DEPT_ZIP_CODE=model.SUPERVISE_DEPT_ZIP_CODE;
		entity.ALL_EXPERT_NUM=model.ALL_EXPERT_NUM;
		entity.TENDERER_NUM=model.TENDERER_NUM;
		entity.EXPERT_NUM=model.EXPERT_NUM;
		entity.MINIMUM_QUALIFICATIONS=model.MINIMUM_QUALIFICATIONS;
		entity.FINANCIAL_REQUIRE=model.FINANCIAL_REQUIRE;
		entity.ACHIEVEMENT_REQUIRE=model.ACHIEVEMENT_REQUIRE;
		entity.REPUTATION_REQUIRE=model.REPUTATION_REQUIRE;
		entity.WIN_CANDIDATE_NUM=model.WIN_CANDIDATE_NUM;
		entity.EVALUATING_METHOD_STANDARD=model.EVALUATING_METHOD_STANDARD;
		entity.SUBC_NAME=model.SUBC_NAME;
		entity.SUBC_NAME_ADDRESS=model.SUBC_NAME_ADDRESS;
		entity.SUBC_ZIP_CODE=model.SUBC_ZIP_CODE;
		entity.MATERIAL=model.MATERIAL;
		entity.CONTRACT_CLAUSE=model.CONTRACT_CLAUSE;
		entity.DISPUTE_RESOLUTION=model.DISPUTE_RESOLUTION;
		entity.ARBITRATION_COMMISSION=model.ARBITRATION_COMMISSION;
		entity.DOCUMENT_CHARGES=model.DOCUMENT_CHARGES;
		entity.MINIMUM_LIMIT=model.MINIMUM_LIMIT;
		entity.BILL_OF_QUANTITIES=model.BILL_OF_QUANTITIES;
		entity.DRAWING=model.DRAWING;
		entity.TECHNOLOGY_STANDARD=model.TECHNOLOGY_STANDARD;
		entity.SUPPLY_TECHNICAL_STANDARD=model.SUPPLY_TECHNICAL_STANDARD;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.PROJECT_START=model.PROJECT_START;
		entity.MILEAGE_START=model.MILEAGE_START;
		entity.PROJECT_END=model.PROJECT_END;
		entity.MILEAGE_END=model.MILEAGE_END;
		entity.SPAN=model.SPAN;
		entity.CONTRACT_SECTION=model.CONTRACT_SECTION;
		entity.CONTRACT_NAME_OR_NUM=model.CONTRACT_NAME_OR_NUM;
		entity.THIS_CONTRACT_SECTION=model.THIS_CONTRACT_SECTION;
		entity.PERIOD_SERVICE=model.PERIOD_SERVICE;
		entity.SEEDTIME=model.SEEDTIME;
		entity.CONSTRUCTION_TIME=model.CONSTRUCTION_TIME;
		entity.DEFECT_LIABILITY_PERIOD=model.DEFECT_LIABILITY_PERIOD;
		entity.CONST_MANAGEMENT=model.CONST_MANAGEMENT;
		entity.SUPERVISE_DEPT_PHONE=model.SUPERVISE_DEPT_PHONE;
		entity.SUPERVISE_DEPT_FAX=model.SUPERVISE_DEPT_FAX;
		entity.PROJECT_DESCRIPTION=model.PROJECT_DESCRIPTION;
		entity.MAIN_ENGINEER_QUANTITY_LIST=model.MAIN_ENGINEER_QUANTITY_LIST;
		entity.SKETCH_MAP=model.SKETCH_MAP;
		entity.PERIOD_SERVICE_TIME=model.PERIOD_SERVICE_TIME;
		entity.QUALIFICATION_REQUIRE=model.QUALIFICATION_REQUIRE;
		entity.VEHICLE_REQUIRE=model.VEHICLE_REQUIRE;
		entity.PROJECT_APPROVAL=model.PROJECT_APPROVAL;
		entity.FULLY_FUNDED=model.FULLY_FUNDED;
		entity.BID_SECTION_NAME=model.BID_SECTION_NAME;
		entity.SUPER_MIN_REQUIRE=model.SUPER_MIN_REQUIRE;
		entity.SUPERVISION_STANDARD=model.SUPERVISION_STANDARD;
		entity.ENGINEERING_SPECIFICATIONS=model.ENGINEERING_SPECIFICATIONS;
		entity.TECHNICAL_SPECIFICATIONS=model.TECHNICAL_SPECIFICATIONS;
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
        public GeneralResult Add(JT_SUBGRADE_TENDER_FILE model)
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
                    Delete(JT_SUBGRADE_TENDER_FILE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JT_SUBGRADE_TENDER_FILE> model)
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
       	protected WhereClipBuilder ConditionBuilder(JT_SUBGRADE_TENDER_FILE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(model.LIMITE_ALL_TIME!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.LIMITE_ALL_TIME==(model.LIMITE_ALL_TIME));
				}
				if(model.DEFECT_LIABILITY_PERIOD1!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.DEFECT_LIABILITY_PERIOD1==(model.DEFECT_LIABILITY_PERIOD1));
				}
				if(model.BID_SECTION!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.BID_SECTION==(model.BID_SECTION));
				}
				if(model.BID_SECTION_GROUP!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.BID_SECTION_GROUP==(model.BID_SECTION_GROUP));
				}
				if(model.TENDERER_BID_SECTION!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.TENDERER_BID_SECTION==(model.TENDERER_BID_SECTION));
				}
				if(model.TENDERER_BID_SECTION_GROUP!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.TENDERER_BID_SECTION_GROUP==(model.TENDERER_BID_SECTION_GROUP));
				}
				if(model.CONTRACT_SEGMENT!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.CONTRACT_SEGMENT==(model.CONTRACT_SEGMENT));
				}
				if(model.TENDER_NUMBER!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.TENDER_NUMBER==(model.TENDER_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_MATTERS))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.OTHER_MATTERS.Contain(model.OTHER_MATTERS));
				}
				if(!string.IsNullOrWhiteSpace(model.RECONNAISSANCE))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.RECONNAISSANCE.Contain(model.RECONNAISSANCE));
				}
				if(model.RECONNAISSANCE_TIME!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.RECONNAISSANCE_TIME==(model.RECONNAISSANCE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.RECONNAISSANCE_ADDRESS))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.RECONNAISSANCE_ADDRESS.Contain(model.RECONNAISSANCE_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.PREPARATORY_MEETING))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.PREPARATORY_MEETING.Contain(model.PREPARATORY_MEETING));
				}
				if(model.PREPARATORY_MEETING_TIME!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.PREPARATORY_MEETING_TIME==(model.PREPARATORY_MEETING_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PREPARATORY_MEETING_ADDRESS))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.PREPARATORY_MEETING_ADDRESS.Contain(model.PREPARATORY_MEETING_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.VEHICLE))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.VEHICLE.Contain(model.VEHICLE));
				}
				if(!string.IsNullOrWhiteSpace(model.MEDIA1))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.MEDIA1.Contain(model.MEDIA1));
				}
				if(!string.IsNullOrWhiteSpace(model.MEDIA2))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.MEDIA2.Contain(model.MEDIA2));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.OTHER.Contain(model.OTHER));
				}
				if(!string.IsNullOrWhiteSpace(model.FUND_IMPLEMENTATION))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.FUND_IMPLEMENTATION.Contain(model.FUND_IMPLEMENTATION));
				}
				if(model.BEGIN_ALL_DATE!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.BEGIN_ALL_DATE==(model.BEGIN_ALL_DATE));
				}
				if(model.END_DATE!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.END_DATE==(model.END_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.SECURITY_TARGET))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.SECURITY_TARGET.Contain(model.SECURITY_TARGET));
				}
				if(model.MARGIN_TIME!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.MARGIN_TIME==(model.MARGIN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.MARGIN_NAME.Contain(model.MARGIN_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.MARGIN_NUMBER.Contain(model.MARGIN_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.MARGIN_BANK.Contain(model.MARGIN_BANK));
				}
				if(model.PROJECT_YEAR_REQUIRED_TIME!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.PROJECT_YEAR_REQUIRED_TIME==(model.PROJECT_YEAR_REQUIRED_TIME));
				}
				if(model.LITIGATION_YEAR_REQUIRED_TIME!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.LITIGATION_YEAR_REQUIRED_TIME==(model.LITIGATION_YEAR_REQUIRED_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.SUPERVISE_DEPT_NAME.Contain(model.SUPERVISE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_TELE))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.SUPERVISE_DEPT_TELE.Contain(model.SUPERVISE_DEPT_TELE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ADDRESS))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.SUPERVISE_DEPT_ADDRESS.Contain(model.SUPERVISE_DEPT_ADDRESS));
				}
				if(model.SUPERVISE_DEPT_ZIP_CODE!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.SUPERVISE_DEPT_ZIP_CODE==(model.SUPERVISE_DEPT_ZIP_CODE));
				}
				if(model.ALL_EXPERT_NUM!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.ALL_EXPERT_NUM==(model.ALL_EXPERT_NUM));
				}
				if(model.TENDERER_NUM!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.TENDERER_NUM==(model.TENDERER_NUM));
				}
				if(model.EXPERT_NUM!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.EXPERT_NUM==(model.EXPERT_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.MINIMUM_QUALIFICATIONS))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.MINIMUM_QUALIFICATIONS.Contain(model.MINIMUM_QUALIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.FINANCIAL_REQUIRE))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.FINANCIAL_REQUIRE.Contain(model.FINANCIAL_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.ACHIEVEMENT_REQUIRE))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.ACHIEVEMENT_REQUIRE.Contain(model.ACHIEVEMENT_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.REPUTATION_REQUIRE))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.REPUTATION_REQUIRE.Contain(model.REPUTATION_REQUIRE));
				}
				if(model.WIN_CANDIDATE_NUM!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.WIN_CANDIDATE_NUM==(model.WIN_CANDIDATE_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATING_METHOD_STANDARD))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.EVALUATING_METHOD_STANDARD.Contain(model.EVALUATING_METHOD_STANDARD));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBC_NAME))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.SUBC_NAME.Contain(model.SUBC_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUBC_NAME_ADDRESS))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.SUBC_NAME_ADDRESS.Contain(model.SUBC_NAME_ADDRESS));
				}
				if(model.SUBC_ZIP_CODE!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.SUBC_ZIP_CODE==(model.SUBC_ZIP_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.MATERIAL))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.MATERIAL.Contain(model.MATERIAL));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_CLAUSE))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.CONTRACT_CLAUSE.Contain(model.CONTRACT_CLAUSE));
				}
				if(!string.IsNullOrWhiteSpace(model.DISPUTE_RESOLUTION))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.DISPUTE_RESOLUTION.Contain(model.DISPUTE_RESOLUTION));
				}
				if(!string.IsNullOrWhiteSpace(model.ARBITRATION_COMMISSION))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.ARBITRATION_COMMISSION.Contain(model.ARBITRATION_COMMISSION));
				}
				if(model.DOCUMENT_CHARGES!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.DOCUMENT_CHARGES==(model.DOCUMENT_CHARGES));
				}
				if(model.MINIMUM_LIMIT!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.MINIMUM_LIMIT==(model.MINIMUM_LIMIT));
				}
				if(!string.IsNullOrWhiteSpace(model.BILL_OF_QUANTITIES))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.BILL_OF_QUANTITIES.Contain(model.BILL_OF_QUANTITIES));
				}
				if(!string.IsNullOrWhiteSpace(model.DRAWING))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.DRAWING.Contain(model.DRAWING));
				}
				if(!string.IsNullOrWhiteSpace(model.TECHNOLOGY_STANDARD))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.TECHNOLOGY_STANDARD.Contain(model.TECHNOLOGY_STANDARD));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPPLY_TECHNICAL_STANDARD))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.SUPPLY_TECHNICAL_STANDARD.Contain(model.SUPPLY_TECHNICAL_STANDARD));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.M_ID!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.M_TM==(model.M_TM));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_START))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.PROJECT_START.Contain(model.PROJECT_START));
				}
				if(!string.IsNullOrWhiteSpace(model.MILEAGE_START))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.MILEAGE_START.Contain(model.MILEAGE_START));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_END))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.PROJECT_END.Contain(model.PROJECT_END));
				}
				if(!string.IsNullOrWhiteSpace(model.MILEAGE_END))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.MILEAGE_END.Contain(model.MILEAGE_END));
				}
				if(model.SPAN!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.SPAN==(model.SPAN));
				}
				if(model.CONTRACT_SECTION!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.CONTRACT_SECTION==(model.CONTRACT_SECTION));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_NAME_OR_NUM))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.CONTRACT_NAME_OR_NUM.Contain(model.CONTRACT_NAME_OR_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.THIS_CONTRACT_SECTION))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.THIS_CONTRACT_SECTION.Contain(model.THIS_CONTRACT_SECTION));
				}
				if(model.PERIOD_SERVICE!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.PERIOD_SERVICE==(model.PERIOD_SERVICE));
				}
				if(model.SEEDTIME!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.SEEDTIME==(model.SEEDTIME));
				}
				if(model.CONSTRUCTION_TIME!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.CONSTRUCTION_TIME==(model.CONSTRUCTION_TIME));
				}
				if(model.DEFECT_LIABILITY_PERIOD!=null)
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.DEFECT_LIABILITY_PERIOD==(model.DEFECT_LIABILITY_PERIOD));
				}
				if(!string.IsNullOrWhiteSpace(model.CONST_MANAGEMENT))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.CONST_MANAGEMENT.Contain(model.CONST_MANAGEMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_PHONE))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.SUPERVISE_DEPT_PHONE.Contain(model.SUPERVISE_DEPT_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_FAX))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.SUPERVISE_DEPT_FAX.Contain(model.SUPERVISE_DEPT_FAX));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_DESCRIPTION))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.PROJECT_DESCRIPTION.Contain(model.PROJECT_DESCRIPTION));
				}
				if(!string.IsNullOrWhiteSpace(model.MAIN_ENGINEER_QUANTITY_LIST))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.MAIN_ENGINEER_QUANTITY_LIST.Contain(model.MAIN_ENGINEER_QUANTITY_LIST));
				}
				if(!string.IsNullOrWhiteSpace(model.SKETCH_MAP))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.SKETCH_MAP.Contain(model.SKETCH_MAP));
				}
				if(!string.IsNullOrWhiteSpace(model.PERIOD_SERVICE_TIME))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.PERIOD_SERVICE_TIME.Contain(model.PERIOD_SERVICE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.QUALIFICATION_REQUIRE))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.QUALIFICATION_REQUIRE.Contain(model.QUALIFICATION_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.VEHICLE_REQUIRE))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.VEHICLE_REQUIRE.Contain(model.VEHICLE_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_APPROVAL))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.PROJECT_APPROVAL.Contain(model.PROJECT_APPROVAL));
				}
				if(!string.IsNullOrWhiteSpace(model.FULLY_FUNDED))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.FULLY_FUNDED.Contain(model.FULLY_FUNDED));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_NAME))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.BID_SECTION_NAME.Contain(model.BID_SECTION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPER_MIN_REQUIRE))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.SUPER_MIN_REQUIRE.Contain(model.SUPER_MIN_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISION_STANDARD))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.SUPERVISION_STANDARD.Contain(model.SUPERVISION_STANDARD));
				}
				if(!string.IsNullOrWhiteSpace(model.ENGINEERING_SPECIFICATIONS))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.ENGINEERING_SPECIFICATIONS.Contain(model.ENGINEERING_SPECIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.TECHNICAL_SPECIFICATIONS))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.TECHNICAL_SPECIFICATIONS.Contain(model.TECHNICAL_SPECIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(JT_SUBGRADE_TENDER_FILE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}