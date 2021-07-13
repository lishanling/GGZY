using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ZjProjectService : BaseServiceT<ZJ_PROJECT>
    {
        #region 接口实现
        
		public List<ZJ_PROJECT> FindList(ZJ_PROJECT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJ_PROJECT> PageList(ZJ_PROJECT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJ_PROJECT._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(ZJ_PROJECT._.M_ID == M_ID);
			
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
        public GeneralResult Edit(ZJ_PROJECT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is ZJ_PROJECT entity)
	{		
		entity.Attach();
		entity.REPROT_CODE=model.REPROT_CODE;
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.PROJECT_NAME=model.PROJECT_NAME;
		entity.REGION_CODE=model.REGION_CODE;
		entity.INVEST_PROJECT_CODE=model.INVEST_PROJECT_CODE;
		entity.LEGAL_PERSON=model.LEGAL_PERSON;
		entity.LEGAL_REPRESENT=model.LEGAL_REPRESENT;
		entity.LEGAL_CREDIT_CODE=model.LEGAL_CREDIT_CODE;
		entity.LEGAL_ADDRESS=model.LEGAL_ADDRESS;
		entity.CONTACTOR=model.CONTACTOR;
		entity.CONTACT_INFORMATION=model.CONTACT_INFORMATION;
		entity.APPROVAL_NAME=model.APPROVAL_NAME;
		entity.APPROVAL_NUMBER=model.APPROVAL_NUMBER;
		entity.APPROVAL_AUTHORITY=model.APPROVAL_AUTHORITY;
		entity.PROJECT_SCALE=model.PROJECT_SCALE;
		entity.TOTLE_INVESTMENT=model.TOTLE_INVESTMENT;
		entity.CONSTRUCTION_COST=model.CONSTRUCTION_COST;
		entity.FUND_SOURCE=model.FUND_SOURCE;
		entity.GOVERNMENT_INVEST_FINANCE=model.GOVERNMENT_INVEST_FINANCE;
		entity.IS_STATE_FUND=model.IS_STATE_FUND;
		entity.NOT_STATE_FUND=model.NOT_STATE_FUND;
		entity.INVEST_CONTRACT_MODE=model.INVEST_CONTRACT_MODE;
		entity.DESIGN_CONTRACT_MODE=model.DESIGN_CONTRACT_MODE;
		entity.CONSTRUCT_CONTRACT_MODE=model.CONSTRUCT_CONTRACT_MODE;
		entity.IMPORT_EQUIP_CONTRACT_MODE=model.IMPORT_EQUIP_CONTRACT_MODE;
		entity.GENERAL_CONTRACT_MODE=model.GENERAL_CONTRACT_MODE;
		entity.TENDER_ORGANIZE_FORM=model.TENDER_ORGANIZE_FORM;
		entity.IS_AGENT_CONSTRUCT=model.IS_AGENT_CONSTRUCT;
		entity.REMARK=model.REMARK;
		entity.PROJECT_APPROVAL_FILE=model.PROJECT_APPROVAL_FILE;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
		entity.INDUSTRIES_TYPE=model.INDUSTRIES_TYPE;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.CONSTRUCT_CODE=model.CONSTRUCT_CODE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ATT_PROJECT_APPROVAL_FILE=model.M_ATT_PROJECT_APPROVAL_FILE;
		entity.ADDRESS=model.ADDRESS;
		entity.CLASS_VER_CODE=model.CLASS_VER_CODE;
		entity.RELATE_CODE=model.RELATE_CODE;
		entity.BUILDPLANNUM=model.BUILDPLANNUM;
		entity.PROJECTPLANNUM=model.PROJECTPLANNUM;
		entity.PROPERTY_NUM=model.PROPERTY_NUM;
		entity.FUNCTION_NUM=model.FUNCTION_NUM;
		entity.ISMAJOR=model.ISMAJOR;
		entity.CXXMINFO=model.CXXMINFO;
		entity.JZJNINFO=model.JZJNINFO;
		entity.TRADE_PLAT=model.TRADE_PLAT;
		entity.PUB_SERVICE_PLAT=model.PUB_SERVICE_PLAT;
		entity.M_VERSION=model.M_VERSION;
		entity.SUPERVISOR_CONTRACT_MODE=model.SUPERVISOR_CONTRACT_MODE;
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
        public GeneralResult Add(ZJ_PROJECT model)
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
                    Delete(ZJ_PROJECT._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJ_PROJECT> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJ_PROJECT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.REPROT_CODE))
				{
				  condition.And(ZJ_PROJECT._.REPROT_CODE.Contain(model.REPROT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(ZJ_PROJECT._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
				{
				  condition.And(ZJ_PROJECT._.PROJECT_NAME.Contain(model.PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(ZJ_PROJECT._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.INVEST_PROJECT_CODE))
				{
				  condition.And(ZJ_PROJECT._.INVEST_PROJECT_CODE.Contain(model.INVEST_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_PERSON))
				{
				  condition.And(ZJ_PROJECT._.LEGAL_PERSON.Contain(model.LEGAL_PERSON));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_REPRESENT))
				{
				  condition.And(ZJ_PROJECT._.LEGAL_REPRESENT.Contain(model.LEGAL_REPRESENT));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_CREDIT_CODE))
				{
				  condition.And(ZJ_PROJECT._.LEGAL_CREDIT_CODE.Contain(model.LEGAL_CREDIT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_ADDRESS))
				{
				  condition.And(ZJ_PROJECT._.LEGAL_ADDRESS.Contain(model.LEGAL_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTACTOR))
				{
				  condition.And(ZJ_PROJECT._.CONTACTOR.Contain(model.CONTACTOR));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTACT_INFORMATION))
				{
				  condition.And(ZJ_PROJECT._.CONTACT_INFORMATION.Contain(model.CONTACT_INFORMATION));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVAL_NAME))
				{
				  condition.And(ZJ_PROJECT._.APPROVAL_NAME.Contain(model.APPROVAL_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVAL_NUMBER))
				{
				  condition.And(ZJ_PROJECT._.APPROVAL_NUMBER.Contain(model.APPROVAL_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVAL_AUTHORITY))
				{
				  condition.And(ZJ_PROJECT._.APPROVAL_AUTHORITY.Contain(model.APPROVAL_AUTHORITY));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_SCALE))
				{
				  condition.And(ZJ_PROJECT._.PROJECT_SCALE.Contain(model.PROJECT_SCALE));
				}
				if(model.TOTLE_INVESTMENT!=null)
				{
				  condition.And(ZJ_PROJECT._.TOTLE_INVESTMENT==(model.TOTLE_INVESTMENT));
				}
				if(model.CONSTRUCTION_COST!=null)
				{
				  condition.And(ZJ_PROJECT._.CONSTRUCTION_COST==(model.CONSTRUCTION_COST));
				}
				if(!string.IsNullOrWhiteSpace(model.FUND_SOURCE))
				{
				  condition.And(ZJ_PROJECT._.FUND_SOURCE.Contain(model.FUND_SOURCE));
				}
				if(model.GOVERNMENT_INVEST_FINANCE!=null)
				{
				  condition.And(ZJ_PROJECT._.GOVERNMENT_INVEST_FINANCE==(model.GOVERNMENT_INVEST_FINANCE));
				}
				if(model.IS_STATE_FUND!=null)
				{
				  condition.And(ZJ_PROJECT._.IS_STATE_FUND==(model.IS_STATE_FUND));
				}
				if(model.NOT_STATE_FUND!=null)
				{
				  condition.And(ZJ_PROJECT._.NOT_STATE_FUND==(model.NOT_STATE_FUND));
				}
				if(!string.IsNullOrWhiteSpace(model.INVEST_CONTRACT_MODE))
				{
				  condition.And(ZJ_PROJECT._.INVEST_CONTRACT_MODE.Contain(model.INVEST_CONTRACT_MODE));
				}
				if(!string.IsNullOrWhiteSpace(model.DESIGN_CONTRACT_MODE))
				{
				  condition.And(ZJ_PROJECT._.DESIGN_CONTRACT_MODE.Contain(model.DESIGN_CONTRACT_MODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCT_CONTRACT_MODE))
				{
				  condition.And(ZJ_PROJECT._.CONSTRUCT_CONTRACT_MODE.Contain(model.CONSTRUCT_CONTRACT_MODE));
				}
				if(!string.IsNullOrWhiteSpace(model.IMPORT_EQUIP_CONTRACT_MODE))
				{
				  condition.And(ZJ_PROJECT._.IMPORT_EQUIP_CONTRACT_MODE.Contain(model.IMPORT_EQUIP_CONTRACT_MODE));
				}
				if(!string.IsNullOrWhiteSpace(model.GENERAL_CONTRACT_MODE))
				{
				  condition.And(ZJ_PROJECT._.GENERAL_CONTRACT_MODE.Contain(model.GENERAL_CONTRACT_MODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_ORGANIZE_FORM))
				{
				  condition.And(ZJ_PROJECT._.TENDER_ORGANIZE_FORM.Contain(model.TENDER_ORGANIZE_FORM));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_AGENT_CONSTRUCT))
				{
				  condition.And(ZJ_PROJECT._.IS_AGENT_CONSTRUCT.Contain(model.IS_AGENT_CONSTRUCT));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(ZJ_PROJECT._.REMARK.Contain(model.REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_APPROVAL_FILE))
				{
				  condition.And(ZJ_PROJECT._.PROJECT_APPROVAL_FILE.Contain(model.PROJECT_APPROVAL_FILE));
				}
				if(model.M_ID!=null)
				{
				  condition.And(ZJ_PROJECT._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(ZJ_PROJECT._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(ZJ_PROJECT._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(ZJ_PROJECT._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(ZJ_PROJECT._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(ZJ_PROJECT._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.INDUSTRIES_TYPE))
				{
				  condition.And(ZJ_PROJECT._.INDUSTRIES_TYPE.Contain(model.INDUSTRIES_TYPE));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(ZJ_PROJECT._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCT_CODE))
				{
				  condition.And(ZJ_PROJECT._.CONSTRUCT_CODE.Contain(model.CONSTRUCT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(ZJ_PROJECT._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(ZJ_PROJECT._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(ZJ_PROJECT._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PROJECT_APPROVAL_FILE))
				{
				  condition.And(ZJ_PROJECT._.M_ATT_PROJECT_APPROVAL_FILE.Contain(model.M_ATT_PROJECT_APPROVAL_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.ADDRESS))
				{
				  condition.And(ZJ_PROJECT._.ADDRESS.Contain(model.ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.CLASS_VER_CODE))
				{
				  condition.And(ZJ_PROJECT._.CLASS_VER_CODE.Contain(model.CLASS_VER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.RELATE_CODE))
				{
				  condition.And(ZJ_PROJECT._.RELATE_CODE.Contain(model.RELATE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BUILDPLANNUM))
				{
				  condition.And(ZJ_PROJECT._.BUILDPLANNUM.Contain(model.BUILDPLANNUM));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECTPLANNUM))
				{
				  condition.And(ZJ_PROJECT._.PROJECTPLANNUM.Contain(model.PROJECTPLANNUM));
				}
				if(!string.IsNullOrWhiteSpace(model.PROPERTY_NUM))
				{
				  condition.And(ZJ_PROJECT._.PROPERTY_NUM.Contain(model.PROPERTY_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.FUNCTION_NUM))
				{
				  condition.And(ZJ_PROJECT._.FUNCTION_NUM.Contain(model.FUNCTION_NUM));
				}
				if(model.ISMAJOR!=null)
				{
				  condition.And(ZJ_PROJECT._.ISMAJOR==(model.ISMAJOR));
				}
				if(!string.IsNullOrWhiteSpace(model.CXXMINFO))
				{
				  condition.And(ZJ_PROJECT._.CXXMINFO.Contain(model.CXXMINFO));
				}
				if(!string.IsNullOrWhiteSpace(model.JZJNINFO))
				{
				  condition.And(ZJ_PROJECT._.JZJNINFO.Contain(model.JZJNINFO));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(ZJ_PROJECT._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(ZJ_PROJECT._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(ZJ_PROJECT._.M_VERSION.Contain(model.M_VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISOR_CONTRACT_MODE))
				{
				  condition.And(ZJ_PROJECT._.SUPERVISOR_CONTRACT_MODE.Contain(model.SUPERVISOR_CONTRACT_MODE));
				}
		return condition;
	}
        #endregion
    }
}