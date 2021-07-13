using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TenderProjectDelService : BaseServiceT<TENDER_PROJECT_DEL>
    {
        #region 接口实现
        
		public List<TENDER_PROJECT_DEL> FindList(TENDER_PROJECT_DEL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TENDER_PROJECT_DEL> PageList(TENDER_PROJECT_DEL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, TENDER_PROJECT_DEL._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(TENDER_PROJECT_DEL._.ID == ID);
			
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
        public GeneralResult Edit(TENDER_PROJECT_DEL model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is TENDER_PROJECT_DEL entity)
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
		entity.ID=model.ID;
		entity.M_DEL_USER=model.M_DEL_USER;
		entity.M_DEL_TM=model.M_DEL_TM;
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
        public GeneralResult Add(TENDER_PROJECT_DEL model)
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
                    Delete(TENDER_PROJECT_DEL._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<TENDER_PROJECT_DEL> model)
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
       	protected WhereClipBuilder ConditionBuilder(TENDER_PROJECT_DEL model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(TENDER_PROJECT_DEL._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(TENDER_PROJECT_DEL._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(TENDER_PROJECT_DEL._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(TENDER_PROJECT_DEL._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
				{
				  condition.And(TENDER_PROJECT_DEL._.TENDER_PROJECT_TYPE.Contain(model.TENDER_PROJECT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(TENDER_PROJECT_DEL._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_CONTENT))
				{
				  condition.And(TENDER_PROJECT_DEL._.TENDER_CONTENT.Contain(model.TENDER_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.OWNER_NAME))
				{
				  condition.And(TENDER_PROJECT_DEL._.OWNER_NAME.Contain(model.OWNER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_NAME))
				{
				  condition.And(TENDER_PROJECT_DEL._.TENDERER_NAME.Contain(model.TENDERER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_CODE_TYPE))
				{
				  condition.And(TENDER_PROJECT_DEL._.TENDERER_CODE_TYPE.Contain(model.TENDERER_CODE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_CODE))
				{
				  condition.And(TENDER_PROJECT_DEL._.TENDERER_CODE.Contain(model.TENDERER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_ROLE))
				{
				  condition.And(TENDER_PROJECT_DEL._.TENDERER_ROLE.Contain(model.TENDERER_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_NAME))
				{
				  condition.And(TENDER_PROJECT_DEL._.TENDER_AGENCY_NAME.Contain(model.TENDER_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_CODE_TYPE))
				{
				  condition.And(TENDER_PROJECT_DEL._.TENDER_AGENCY_CODE_TYPE.Contain(model.TENDER_AGENCY_CODE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_CODE))
				{
				  condition.And(TENDER_PROJECT_DEL._.TENDER_AGENCY_CODE.Contain(model.TENDER_AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_ROLE))
				{
				  condition.And(TENDER_PROJECT_DEL._.TENDER_AGENCY_ROLE.Contain(model.TENDER_AGENCY_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_MODE))
				{
				  condition.And(TENDER_PROJECT_DEL._.TENDER_MODE.Contain(model.TENDER_MODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_ORGANIZE_FORM))
				{
				  condition.And(TENDER_PROJECT_DEL._.TENDER_ORGANIZE_FORM.Contain(model.TENDER_ORGANIZE_FORM));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(TENDER_PROJECT_DEL._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME))
				{
				  condition.And(TENDER_PROJECT_DEL._.SUPERVISE_DEPT_NAME.Contain(model.SUPERVISE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_CODE))
				{
				  condition.And(TENDER_PROJECT_DEL._.SUPERVISE_DEPT_CODE.Contain(model.SUPERVISE_DEPT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVE_DEPT_NAME))
				{
				  condition.And(TENDER_PROJECT_DEL._.APPROVE_DEPT_NAME.Contain(model.APPROVE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVE_DEPT_CODE))
				{
				  condition.And(TENDER_PROJECT_DEL._.APPROVE_DEPT_CODE.Contain(model.APPROVE_DEPT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(TENDER_PROJECT_DEL._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(TENDER_PROJECT_DEL._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(TENDER_PROJECT_DEL._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(TENDER_PROJECT_DEL._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(TENDER_PROJECT_DEL._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(TENDER_PROJECT_DEL._.M_TM==(model.M_TM));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(TENDER_PROJECT_DEL._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_ID!=null)
				{
				  condition.And(TENDER_PROJECT_DEL._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PROJECT_REG))
				{
				  condition.And(TENDER_PROJECT_DEL._.M_ATT_PROJECT_REG.Contain(model.M_ATT_PROJECT_REG));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_AGENT_COMMIT))
				{
				  condition.And(TENDER_PROJECT_DEL._.M_ATT_AGENT_COMMIT.Contain(model.M_ATT_AGENT_COMMIT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_OTHER_FILE))
				{
				  condition.And(TENDER_PROJECT_DEL._.M_ATT_OTHER_FILE.Contain(model.M_ATT_OTHER_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PROJECT_REG_APPROVE))
				{
				  condition.And(TENDER_PROJECT_DEL._.M_ATT_PROJECT_REG_APPROVE.Contain(model.M_ATT_PROJECT_REG_APPROVE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TENDER_AGENT_CONTRACT))
				{
				  condition.And(TENDER_PROJECT_DEL._.M_ATT_TENDER_AGENT_CONTRACT.Contain(model.M_ATT_TENDER_AGENT_CONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE_OLD1))
				{
				  condition.And(TENDER_PROJECT_DEL._.TENDER_PROJECT_CODE_OLD1.Contain(model.TENDER_PROJECT_CODE_OLD1));
				}
				if(model.ID!=null)
				{
				  condition.And(TENDER_PROJECT_DEL._.ID==(model.ID));
				}
				if(model.M_DEL_USER!=null)
				{
				  condition.And(TENDER_PROJECT_DEL._.M_DEL_USER==(model.M_DEL_USER));
				}
				if(model.M_DEL_TM!=null)
				{
				  condition.And(TENDER_PROJECT_DEL._.M_DEL_TM==(model.M_DEL_TM));
				}
		return condition;
	}
        #endregion
    }
}