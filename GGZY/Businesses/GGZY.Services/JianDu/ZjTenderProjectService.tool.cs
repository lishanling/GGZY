using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ZjTenderProjectService : BaseServiceT<ZJ_TENDER_PROJECT>
    {
        #region 接口实现
        
		public List<ZJ_TENDER_PROJECT> FindList(ZJ_TENDER_PROJECT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJ_TENDER_PROJECT> PageList(ZJ_TENDER_PROJECT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJ_TENDER_PROJECT._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(ZJ_TENDER_PROJECT._.M_ID == M_ID);
			
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
        public GeneralResult Edit(ZJ_TENDER_PROJECT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is ZJ_TENDER_PROJECT entity)
	{		
		entity.Attach();
		entity.REPROT_CODE=model.REPROT_CODE;
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.TENDER_PROJECT_NAME=model.TENDER_PROJECT_NAME;
		entity.TENDER_PROJECT_TYPE=model.TENDER_PROJECT_TYPE;
		entity.REGION_CODE=model.REGION_CODE;
		entity.TENDER_CONTENT=model.TENDER_CONTENT;
		entity.OWNER_NAME=model.OWNER_NAME;
		entity.TENDERER_NAME=model.TENDERER_NAME;
		entity.TENDERER_CODE_TYPE=model.TENDERER_CODE_TYPE;
		entity.TENDERER_CODE=model.TENDERER_CODE;
		entity.TENDERER_ROLE=model.TENDERER_ROLE;
		entity.TENDER_AGENCY_NAME=model.TENDER_AGENCY_NAME;
		entity.TENDER_AGENCY_CODE_TYPE=model.TENDER_AGENCY_CODE_TYPE;
		entity.TENDER_AGENCY_CODE=model.TENDER_AGENCY_CODE;
		entity.TENDER_AGENCY_ROLE=model.TENDER_AGENCY_ROLE;
		entity.TENDER_MODE=model.TENDER_MODE;
		entity.TENDER_ORGANIZE_FORM=model.TENDER_ORGANIZE_FORM;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.SUPERVISE_DEPT_NAME=model.SUPERVISE_DEPT_NAME;
		entity.SUPERVISE_DEPT_CODE=model.SUPERVISE_DEPT_CODE;
		entity.APPROVE_DEPT_NAME=model.APPROVE_DEPT_NAME;
		entity.APPROVE_DEPT_CODE=model.APPROVE_DEPT_CODE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_TM=model.M_TM;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.OTHER_UPDATE_TIME=model.OTHER_UPDATE_TIME;
		entity.TENDER_SELF_CODE=model.TENDER_SELF_CODE;
		entity.M_ATT_PROJECT_REG=model.M_ATT_PROJECT_REG;
		entity.M_ATT_AGENT_COMMIT=model.M_ATT_AGENT_COMMIT;
		entity.M_ATT_OTHER_FILE=model.M_ATT_OTHER_FILE;
		entity.M_ATT_PROJECT_REG_APPROVE=model.M_ATT_PROJECT_REG_APPROVE;
		entity.M_ATT_TENDER_AGENT_CONTRACT=model.M_ATT_TENDER_AGENT_CONTRACT;
		entity.M_ATT_COR_AUTHORITY_FILE=model.M_ATT_COR_AUTHORITY_FILE;
		entity.M_ATT_FUND_SOURCE_CERTIFY_FILE=model.M_ATT_FUND_SOURCE_CERTIFY_FILE;
		entity.TENDER_RECORD_CODE=model.TENDER_RECORD_CODE;
		entity.IS_TO_LAW=model.IS_TO_LAW;
		entity.ISUNION=model.ISUNION;
		entity.REPORT_DUTY=model.REPORT_DUTY;
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
        public GeneralResult Add(ZJ_TENDER_PROJECT model)
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
                    Delete(ZJ_TENDER_PROJECT._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJ_TENDER_PROJECT> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJ_TENDER_PROJECT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.REPROT_CODE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.REPROT_CODE.Contain(model.REPROT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(ZJ_TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.TENDER_PROJECT_TYPE.Contain(model.TENDER_PROJECT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_CONTENT))
				{
				  condition.And(ZJ_TENDER_PROJECT._.TENDER_CONTENT.Contain(model.TENDER_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.OWNER_NAME))
				{
				  condition.And(ZJ_TENDER_PROJECT._.OWNER_NAME.Contain(model.OWNER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_NAME))
				{
				  condition.And(ZJ_TENDER_PROJECT._.TENDERER_NAME.Contain(model.TENDERER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_CODE_TYPE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.TENDERER_CODE_TYPE.Contain(model.TENDERER_CODE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_CODE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.TENDERER_CODE.Contain(model.TENDERER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_ROLE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.TENDERER_ROLE.Contain(model.TENDERER_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_NAME))
				{
				  condition.And(ZJ_TENDER_PROJECT._.TENDER_AGENCY_NAME.Contain(model.TENDER_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_CODE_TYPE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.TENDER_AGENCY_CODE_TYPE.Contain(model.TENDER_AGENCY_CODE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_CODE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.TENDER_AGENCY_CODE.Contain(model.TENDER_AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_ROLE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.TENDER_AGENCY_ROLE.Contain(model.TENDER_AGENCY_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_MODE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.TENDER_MODE.Contain(model.TENDER_MODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_ORGANIZE_FORM))
				{
				  condition.And(ZJ_TENDER_PROJECT._.TENDER_ORGANIZE_FORM.Contain(model.TENDER_ORGANIZE_FORM));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(ZJ_TENDER_PROJECT._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME))
				{
				  condition.And(ZJ_TENDER_PROJECT._.SUPERVISE_DEPT_NAME.Contain(model.SUPERVISE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_CODE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.SUPERVISE_DEPT_CODE.Contain(model.SUPERVISE_DEPT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVE_DEPT_NAME))
				{
				  condition.And(ZJ_TENDER_PROJECT._.APPROVE_DEPT_NAME.Contain(model.APPROVE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVE_DEPT_CODE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.APPROVE_DEPT_CODE.Contain(model.APPROVE_DEPT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(ZJ_TENDER_PROJECT._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(ZJ_TENDER_PROJECT._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(ZJ_TENDER_PROJECT._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(ZJ_TENDER_PROJECT._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_TM!=null)
				{
				  condition.And(ZJ_TENDER_PROJECT._.M_TM==(model.M_TM));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(ZJ_TENDER_PROJECT._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.OTHER_UPDATE_TIME!=null)
				{
				  condition.And(ZJ_TENDER_PROJECT._.OTHER_UPDATE_TIME==(model.OTHER_UPDATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_SELF_CODE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.TENDER_SELF_CODE.Contain(model.TENDER_SELF_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PROJECT_REG))
				{
				  condition.And(ZJ_TENDER_PROJECT._.M_ATT_PROJECT_REG.Contain(model.M_ATT_PROJECT_REG));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_AGENT_COMMIT))
				{
				  condition.And(ZJ_TENDER_PROJECT._.M_ATT_AGENT_COMMIT.Contain(model.M_ATT_AGENT_COMMIT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_OTHER_FILE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.M_ATT_OTHER_FILE.Contain(model.M_ATT_OTHER_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PROJECT_REG_APPROVE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.M_ATT_PROJECT_REG_APPROVE.Contain(model.M_ATT_PROJECT_REG_APPROVE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TENDER_AGENT_CONTRACT))
				{
				  condition.And(ZJ_TENDER_PROJECT._.M_ATT_TENDER_AGENT_CONTRACT.Contain(model.M_ATT_TENDER_AGENT_CONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_COR_AUTHORITY_FILE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.M_ATT_COR_AUTHORITY_FILE.Contain(model.M_ATT_COR_AUTHORITY_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_FUND_SOURCE_CERTIFY_FILE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.M_ATT_FUND_SOURCE_CERTIFY_FILE.Contain(model.M_ATT_FUND_SOURCE_CERTIFY_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_RECORD_CODE))
				{
				  condition.And(ZJ_TENDER_PROJECT._.TENDER_RECORD_CODE.Contain(model.TENDER_RECORD_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_TO_LAW))
				{
				  condition.And(ZJ_TENDER_PROJECT._.IS_TO_LAW.Contain(model.IS_TO_LAW));
				}
				if(!string.IsNullOrWhiteSpace(model.ISUNION))
				{
				  condition.And(ZJ_TENDER_PROJECT._.ISUNION.Contain(model.ISUNION));
				}
				if(!string.IsNullOrWhiteSpace(model.REPORT_DUTY))
				{
				  condition.And(ZJ_TENDER_PROJECT._.REPORT_DUTY.Contain(model.REPORT_DUTY));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(ZJ_TENDER_PROJECT._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(ZJ_TENDER_PROJECT._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(ZJ_TENDER_PROJECT._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}