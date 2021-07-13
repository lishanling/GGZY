using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TenderProjectService : BaseServiceT<TENDER_PROJECT>
    {
        #region 接口实现
        /// <summary>
		/// 根据招标项目名称关键字搜索，返回招标项目名称、招标项目编号、项目所属交易中心
		/// </summary>
		/// <param name="keyword"></param>
		/// <returns></returns>
		public List<dynamic> PageListNameValue(string keyword)
		{
			var condition = new WhereClipBuilder();
			condition.And(TENDER_PROJECT._.REGION_CODE.IsNotNull() && TENDER_PROJECT._.TENDER_PROJECT_TYPE.IsNotNull());
			if (!String.IsNullOrEmpty(keyword))
			{
				condition.And(TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(keyword));
			}
			var search = new SearchCondition();
			var pageList = FromWhere(condition.ToWhereClip())
				.InnerJoin<T_USER_TRADEPLATFORM>(T_USER_TRADEPLATFORM._.AREACODE == TENDER_PROJECT._.REGION_CODE)
		   .OrderBy(TENDER_PROJECT._.M_TM.Desc)
		   .Page(search.PageSize, search.PageNo)
		   .Select(TENDER_PROJECT._.TENDER_PROJECT_CODE, TENDER_PROJECT._.TENDER_PROJECT_NAME,
		   TENDER_PROJECT._.REGION_CODE, T_USER_TRADEPLATFORM._.SYSTEM_NAME)
		   .ToList<dynamic>();
			return pageList;
		}

		public List<TENDER_PROJECT> FindList(TENDER_PROJECT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TENDER_PROJECT> PageList(TENDER_PROJECT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, TENDER_PROJECT._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(TENDER_PROJECT._.M_ID == M_ID);
			
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
        public GeneralResult Edit(TENDER_PROJECT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is TENDER_PROJECT entity)
	{		
		entity.Attach();
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
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_CREATOR=model.M_CREATOR;
		entity.M_ID=model.M_ID;
		entity.M_ATT_PROJECT_REG=model.M_ATT_PROJECT_REG;
		entity.M_ATT_AGENT_COMMIT=model.M_ATT_AGENT_COMMIT;
		entity.M_ATT_OTHER_FILE=model.M_ATT_OTHER_FILE;
		entity.M_ATT_PROJECT_REG_APPROVE=model.M_ATT_PROJECT_REG_APPROVE;
		entity.M_ATT_TENDER_AGENT_CONTRACT=model.M_ATT_TENDER_AGENT_CONTRACT;
		entity.TENDER_PROJECT_CODE_OLD1=model.TENDER_PROJECT_CODE_OLD1;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.TENDER_SELF_CODE=model.TENDER_SELF_CODE;
		entity.ISUNION=model.ISUNION;
		entity.REPORT_DUTY=model.REPORT_DUTY;
		entity.M_ATT_COR_AUTHORITY_FILE=model.M_ATT_COR_AUTHORITY_FILE;
		entity.M_ATT_FUND_SOURCE_CERTIFY_FILE=model.M_ATT_FUND_SOURCE_CERTIFY_FILE;
		entity.OTHER_UPDATE_TIME=model.OTHER_UPDATE_TIME;
		entity.IS_TO_LAW=model.IS_TO_LAW;
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
        public GeneralResult Add(TENDER_PROJECT model)
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
                    Delete(TENDER_PROJECT._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<TENDER_PROJECT> model)
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
       	protected WhereClipBuilder ConditionBuilder(TENDER_PROJECT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(TENDER_PROJECT._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(TENDER_PROJECT._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(TENDER_PROJECT._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
				{
				  condition.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.Contain(model.TENDER_PROJECT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(TENDER_PROJECT._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_CONTENT))
				{
				  condition.And(TENDER_PROJECT._.TENDER_CONTENT.Contain(model.TENDER_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.OWNER_NAME))
				{
				  condition.And(TENDER_PROJECT._.OWNER_NAME.Contain(model.OWNER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_NAME))
				{
				  condition.And(TENDER_PROJECT._.TENDERER_NAME.Contain(model.TENDERER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_CODE_TYPE))
				{
				  condition.And(TENDER_PROJECT._.TENDERER_CODE_TYPE.Contain(model.TENDERER_CODE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_CODE))
				{
				  condition.And(TENDER_PROJECT._.TENDERER_CODE.Contain(model.TENDERER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_ROLE))
				{
				  condition.And(TENDER_PROJECT._.TENDERER_ROLE.Contain(model.TENDERER_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_NAME))
				{
				  condition.And(TENDER_PROJECT._.TENDER_AGENCY_NAME.Contain(model.TENDER_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_CODE_TYPE))
				{
				  condition.And(TENDER_PROJECT._.TENDER_AGENCY_CODE_TYPE.Contain(model.TENDER_AGENCY_CODE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_CODE))
				{
				  condition.And(TENDER_PROJECT._.TENDER_AGENCY_CODE.Contain(model.TENDER_AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_ROLE))
				{
				  condition.And(TENDER_PROJECT._.TENDER_AGENCY_ROLE.Contain(model.TENDER_AGENCY_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_MODE))
				{
				  condition.And(TENDER_PROJECT._.TENDER_MODE.Contain(model.TENDER_MODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_ORGANIZE_FORM))
				{
				  condition.And(TENDER_PROJECT._.TENDER_ORGANIZE_FORM.Contain(model.TENDER_ORGANIZE_FORM));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(TENDER_PROJECT._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME))
				{
				  condition.And(TENDER_PROJECT._.SUPERVISE_DEPT_NAME.Contain(model.SUPERVISE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_CODE))
				{
				  condition.And(TENDER_PROJECT._.SUPERVISE_DEPT_CODE.Contain(model.SUPERVISE_DEPT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVE_DEPT_NAME))
				{
				  condition.And(TENDER_PROJECT._.APPROVE_DEPT_NAME.Contain(model.APPROVE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVE_DEPT_CODE))
				{
				  condition.And(TENDER_PROJECT._.APPROVE_DEPT_CODE.Contain(model.APPROVE_DEPT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(TENDER_PROJECT._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(TENDER_PROJECT._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(TENDER_PROJECT._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(TENDER_PROJECT._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(TENDER_PROJECT._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(TENDER_PROJECT._.M_TM==(model.M_TM));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(TENDER_PROJECT._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_ID!=null)
				{
				  condition.And(TENDER_PROJECT._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PROJECT_REG))
				{
				  condition.And(TENDER_PROJECT._.M_ATT_PROJECT_REG.Contain(model.M_ATT_PROJECT_REG));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_AGENT_COMMIT))
				{
				  condition.And(TENDER_PROJECT._.M_ATT_AGENT_COMMIT.Contain(model.M_ATT_AGENT_COMMIT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_OTHER_FILE))
				{
				  condition.And(TENDER_PROJECT._.M_ATT_OTHER_FILE.Contain(model.M_ATT_OTHER_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PROJECT_REG_APPROVE))
				{
				  condition.And(TENDER_PROJECT._.M_ATT_PROJECT_REG_APPROVE.Contain(model.M_ATT_PROJECT_REG_APPROVE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TENDER_AGENT_CONTRACT))
				{
				  condition.And(TENDER_PROJECT._.M_ATT_TENDER_AGENT_CONTRACT.Contain(model.M_ATT_TENDER_AGENT_CONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE_OLD1))
				{
				  condition.And(TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1.Contain(model.TENDER_PROJECT_CODE_OLD1));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(TENDER_PROJECT._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(TENDER_PROJECT._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(TENDER_PROJECT._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_SELF_CODE))
				{
				  condition.And(TENDER_PROJECT._.TENDER_SELF_CODE.Contain(model.TENDER_SELF_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ISUNION))
				{
				  condition.And(TENDER_PROJECT._.ISUNION.Contain(model.ISUNION));
				}
				if(!string.IsNullOrWhiteSpace(model.REPORT_DUTY))
				{
				  condition.And(TENDER_PROJECT._.REPORT_DUTY.Contain(model.REPORT_DUTY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_COR_AUTHORITY_FILE))
				{
				  condition.And(TENDER_PROJECT._.M_ATT_COR_AUTHORITY_FILE.Contain(model.M_ATT_COR_AUTHORITY_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_FUND_SOURCE_CERTIFY_FILE))
				{
				  condition.And(TENDER_PROJECT._.M_ATT_FUND_SOURCE_CERTIFY_FILE.Contain(model.M_ATT_FUND_SOURCE_CERTIFY_FILE));
				}
				if(model.OTHER_UPDATE_TIME!=null)
				{
				  condition.And(TENDER_PROJECT._.OTHER_UPDATE_TIME==(model.OTHER_UPDATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_TO_LAW))
				{
				  condition.And(TENDER_PROJECT._.IS_TO_LAW.Contain(model.IS_TO_LAW));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(TENDER_PROJECT._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(TENDER_PROJECT._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(TENDER_PROJECT._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}