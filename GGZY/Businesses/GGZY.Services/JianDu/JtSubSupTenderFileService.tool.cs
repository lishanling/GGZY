using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JtSubSupTenderFileService : BaseServiceT<JT_SUB_SUP_TENDER_FILE>
    {
        #region 接口实现
        
		public List<JT_SUB_SUP_TENDER_FILE> FindList(JT_SUB_SUP_TENDER_FILE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JT_SUB_SUP_TENDER_FILE> PageList(JT_SUB_SUP_TENDER_FILE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JT_SUB_SUP_TENDER_FILE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(JT_SUB_SUP_TENDER_FILE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(JT_SUB_SUP_TENDER_FILE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is JT_SUB_SUP_TENDER_FILE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.PROJECT_STARTING=model.PROJECT_STARTING;
		entity.STAKE_NUMBER1=model.STAKE_NUMBER1;
		entity.PROJECT_ENDING=model.PROJECT_ENDING;
		entity.STAKE_NUMBER2=model.STAKE_NUMBER2;
		entity.PROJECT_LENGTH=model.PROJECT_LENGTH;
		entity.LIMITE_ALL_TIME=model.LIMITE_ALL_TIME;
		entity.TOTAL_SECTION_NUMBER=model.TOTAL_SECTION_NUMBER;
		entity.CONTRACT_SECTION=model.CONTRACT_SECTION;
		entity.BID_SECTION_NAME=model.BID_SECTION_NAME;
		entity.TENDERER_BID_SECTION=model.TENDERER_BID_SECTION;
		entity.LJ_LIMITE_TIME=model.LJ_LIMITE_TIME;
		entity.LM_LIMITE_TIME=model.LM_LIMITE_TIME;
		entity.PREPARE_TIME=model.PREPARE_TIME;
		entity.CONSTRUCTION_TIME=model.CONSTRUCTION_TIME;
		entity.DEFECT_LIABILITY_PERIOD=model.DEFECT_LIABILITY_PERIOD;
		entity.CONTRACT_SEGMENT=model.CONTRACT_SEGMENT;
		entity.TENDER_NUMBER=model.TENDER_NUMBER;
		entity.MEDIA1=model.MEDIA1;
		entity.MEDIA2=model.MEDIA2;
		entity.MANAGE_ORGANIZATION=model.MANAGE_ORGANIZATION;
		entity.SYNDICATED_NUMBER=model.SYNDICATED_NUMBER;
		entity.RECONNAISSANCE=model.RECONNAISSANCE;
		entity.PREPARATORY_MEETING=model.PREPARATORY_MEETING;
		entity.MARGIN_TIME=model.MARGIN_TIME;
		entity.MARGIN_NAME=model.MARGIN_NAME;
		entity.MARGIN_NUMBER=model.MARGIN_NUMBER;
		entity.MARGIN_BANK=model.MARGIN_BANK;
		entity.SUPERVISE_DEPT_NAME=model.SUPERVISE_DEPT_NAME;
		entity.SUPERVISE_DEPT_TELE=model.SUPERVISE_DEPT_TELE;
		entity.SUPERVISE_DEPT_ADDRESS=model.SUPERVISE_DEPT_ADDRESS;
		entity.EMPLOYER=model.EMPLOYER;
		entity.PROJECT_APPROVAL=model.PROJECT_APPROVAL;
		entity.FUNDS_COMPOSITION=model.FUNDS_COMPOSITION;
		entity.ALL_BID_SECTION_NAME=model.ALL_BID_SECTION_NAME;
		entity.DRAWING=model.DRAWING;
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
        public GeneralResult Add(JT_SUB_SUP_TENDER_FILE model)
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
                    Delete(JT_SUB_SUP_TENDER_FILE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JT_SUB_SUP_TENDER_FILE> model)
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
       	protected WhereClipBuilder ConditionBuilder(JT_SUB_SUP_TENDER_FILE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_STARTING))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.PROJECT_STARTING.Contain(model.PROJECT_STARTING));
				}
				if(!string.IsNullOrWhiteSpace(model.STAKE_NUMBER1))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.STAKE_NUMBER1.Contain(model.STAKE_NUMBER1));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_ENDING))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.PROJECT_ENDING.Contain(model.PROJECT_ENDING));
				}
				if(!string.IsNullOrWhiteSpace(model.STAKE_NUMBER2))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.STAKE_NUMBER2.Contain(model.STAKE_NUMBER2));
				}
				if(model.PROJECT_LENGTH!=null)
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.PROJECT_LENGTH==(model.PROJECT_LENGTH));
				}
				if(model.LIMITE_ALL_TIME!=null)
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.LIMITE_ALL_TIME==(model.LIMITE_ALL_TIME));
				}
				if(model.TOTAL_SECTION_NUMBER!=null)
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.TOTAL_SECTION_NUMBER==(model.TOTAL_SECTION_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_SECTION))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.CONTRACT_SECTION.Contain(model.CONTRACT_SECTION));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_NAME))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.BID_SECTION_NAME.Contain(model.BID_SECTION_NAME));
				}
				if(model.TENDERER_BID_SECTION!=null)
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.TENDERER_BID_SECTION==(model.TENDERER_BID_SECTION));
				}
				if(model.LJ_LIMITE_TIME!=null)
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.LJ_LIMITE_TIME==(model.LJ_LIMITE_TIME));
				}
				if(model.LM_LIMITE_TIME!=null)
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.LM_LIMITE_TIME==(model.LM_LIMITE_TIME));
				}
				if(model.PREPARE_TIME!=null)
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.PREPARE_TIME==(model.PREPARE_TIME));
				}
				if(model.CONSTRUCTION_TIME!=null)
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.CONSTRUCTION_TIME==(model.CONSTRUCTION_TIME));
				}
				if(model.DEFECT_LIABILITY_PERIOD!=null)
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.DEFECT_LIABILITY_PERIOD==(model.DEFECT_LIABILITY_PERIOD));
				}
				if(model.CONTRACT_SEGMENT!=null)
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.CONTRACT_SEGMENT==(model.CONTRACT_SEGMENT));
				}
				if(model.TENDER_NUMBER!=null)
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.TENDER_NUMBER==(model.TENDER_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.MEDIA1))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.MEDIA1.Contain(model.MEDIA1));
				}
				if(!string.IsNullOrWhiteSpace(model.MEDIA2))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.MEDIA2.Contain(model.MEDIA2));
				}
				if(!string.IsNullOrWhiteSpace(model.MANAGE_ORGANIZATION))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.MANAGE_ORGANIZATION.Contain(model.MANAGE_ORGANIZATION));
				}
				if(model.SYNDICATED_NUMBER!=null)
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.SYNDICATED_NUMBER==(model.SYNDICATED_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.RECONNAISSANCE))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.RECONNAISSANCE.Contain(model.RECONNAISSANCE));
				}
				if(!string.IsNullOrWhiteSpace(model.PREPARATORY_MEETING))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.PREPARATORY_MEETING.Contain(model.PREPARATORY_MEETING));
				}
				if(model.MARGIN_TIME!=null)
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.MARGIN_TIME==(model.MARGIN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.MARGIN_NAME.Contain(model.MARGIN_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.MARGIN_NUMBER.Contain(model.MARGIN_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.MARGIN_BANK.Contain(model.MARGIN_BANK));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.SUPERVISE_DEPT_NAME.Contain(model.SUPERVISE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_TELE))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.SUPERVISE_DEPT_TELE.Contain(model.SUPERVISE_DEPT_TELE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ADDRESS))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.SUPERVISE_DEPT_ADDRESS.Contain(model.SUPERVISE_DEPT_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.EMPLOYER))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.EMPLOYER.Contain(model.EMPLOYER));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_APPROVAL))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.PROJECT_APPROVAL.Contain(model.PROJECT_APPROVAL));
				}
				if(!string.IsNullOrWhiteSpace(model.FUNDS_COMPOSITION))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.FUNDS_COMPOSITION.Contain(model.FUNDS_COMPOSITION));
				}
				if(!string.IsNullOrWhiteSpace(model.ALL_BID_SECTION_NAME))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.ALL_BID_SECTION_NAME.Contain(model.ALL_BID_SECTION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DRAWING))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.DRAWING.Contain(model.DRAWING));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(JT_SUB_SUP_TENDER_FILE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}