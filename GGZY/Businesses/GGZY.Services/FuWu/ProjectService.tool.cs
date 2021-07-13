using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ProjectService : BaseServiceT<PROJECT>
    {
        #region 接口实现
        
		public List<PROJECT> FindList(PROJECT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PROJECT> PageList(PROJECT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PROJECT._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PROJECT._.M_ID == M_ID);
			
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
        public GeneralResult Edit(PROJECT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is PROJECT entity)
	{		
		entity.Attach();
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.PROJECT_NAME=model.PROJECT_NAME;
		entity.REGION_CODE=model.REGION_CODE;
		entity.INVEST_PROJECT_CODE=model.INVEST_PROJECT_CODE;
		entity.ADDRESS=model.ADDRESS;
		entity.LEGAL_PERSON=model.LEGAL_PERSON;
		entity.INDUSTRIES_TYPE=model.INDUSTRIES_TYPE;
		entity.FUND_SOURCE=model.FUND_SOURCE;
		entity.CONTRIBUTION_SCALE=model.CONTRIBUTION_SCALE;
		entity.PROJECT_SCALE=model.PROJECT_SCALE;
		entity.CONTACTOR=model.CONTACTOR;
		entity.CONTACT_INFORMATION=model.CONTACT_INFORMATION;
		entity.APPROVAL_NAME=model.APPROVAL_NAME;
		entity.APPROVAL_NUMBER=model.APPROVAL_NUMBER;
		entity.APPROVAL_AUTHORITY=model.APPROVAL_AUTHORITY;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_PROJECT_APPROVAL_FILE=model.M_PROJECT_APPROVAL_FILE;
		entity.M_PROJECT_TYPE=model.M_PROJECT_TYPE;
		entity.M_JYCS=model.M_JYCS;
		entity.M_ISFR=model.M_ISFR;
		entity.M_ID=model.M_ID;
		entity.M_ATT_PROJECT_APPROVAL_FILE=model.M_ATT_PROJECT_APPROVAL_FILE;
		entity.M_CREATOR=model.M_CREATOR;
		entity.M_ATT_LICENSE_FILE=model.M_ATT_LICENSE_FILE;
		entity.M_REMARK=model.M_REMARK;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.RELATE_CODE=model.RELATE_CODE;
		entity.CLASS_VER_CODE=model.CLASS_VER_CODE;
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
        public GeneralResult Add(PROJECT model)
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
                    Delete(PROJECT._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PROJECT> model)
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
       	protected WhereClipBuilder ConditionBuilder(PROJECT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(PROJECT._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
				{
				  condition.And(PROJECT._.PROJECT_NAME.Contain(model.PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(PROJECT._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.INVEST_PROJECT_CODE))
				{
				  condition.And(PROJECT._.INVEST_PROJECT_CODE.Contain(model.INVEST_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ADDRESS))
				{
				  condition.And(PROJECT._.ADDRESS.Contain(model.ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_PERSON))
				{
				  condition.And(PROJECT._.LEGAL_PERSON.Contain(model.LEGAL_PERSON));
				}
				if(!string.IsNullOrWhiteSpace(model.INDUSTRIES_TYPE))
				{
				  condition.And(PROJECT._.INDUSTRIES_TYPE.Contain(model.INDUSTRIES_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.FUND_SOURCE))
				{
				  condition.And(PROJECT._.FUND_SOURCE.Contain(model.FUND_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRIBUTION_SCALE))
				{
				  condition.And(PROJECT._.CONTRIBUTION_SCALE.Contain(model.CONTRIBUTION_SCALE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_SCALE))
				{
				  condition.And(PROJECT._.PROJECT_SCALE.Contain(model.PROJECT_SCALE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTACTOR))
				{
				  condition.And(PROJECT._.CONTACTOR.Contain(model.CONTACTOR));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTACT_INFORMATION))
				{
				  condition.And(PROJECT._.CONTACT_INFORMATION.Contain(model.CONTACT_INFORMATION));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVAL_NAME))
				{
				  condition.And(PROJECT._.APPROVAL_NAME.Contain(model.APPROVAL_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVAL_NUMBER))
				{
				  condition.And(PROJECT._.APPROVAL_NUMBER.Contain(model.APPROVAL_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVAL_AUTHORITY))
				{
				  condition.And(PROJECT._.APPROVAL_AUTHORITY.Contain(model.APPROVAL_AUTHORITY));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(PROJECT._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(PROJECT._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(PROJECT._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(PROJECT._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(PROJECT._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(PROJECT._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(PROJECT._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_PROJECT_APPROVAL_FILE))
				{
				  condition.And(PROJECT._.M_PROJECT_APPROVAL_FILE.Contain(model.M_PROJECT_APPROVAL_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_PROJECT_TYPE))
				{
				  condition.And(PROJECT._.M_PROJECT_TYPE.Contain(model.M_PROJECT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_JYCS))
				{
				  condition.And(PROJECT._.M_JYCS.Contain(model.M_JYCS));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ISFR))
				{
				  condition.And(PROJECT._.M_ISFR.Contain(model.M_ISFR));
				}
				if(model.M_ID!=null)
				{
				  condition.And(PROJECT._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PROJECT_APPROVAL_FILE))
				{
				  condition.And(PROJECT._.M_ATT_PROJECT_APPROVAL_FILE.Contain(model.M_ATT_PROJECT_APPROVAL_FILE));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(PROJECT._.M_CREATOR==(model.M_CREATOR));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_LICENSE_FILE))
				{
				  condition.And(PROJECT._.M_ATT_LICENSE_FILE.Contain(model.M_ATT_LICENSE_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_REMARK))
				{
				  condition.And(PROJECT._.M_REMARK.Contain(model.M_REMARK));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(PROJECT._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(PROJECT._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(PROJECT._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.RELATE_CODE))
				{
				  condition.And(PROJECT._.RELATE_CODE.Contain(model.RELATE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CLASS_VER_CODE))
				{
				  condition.And(PROJECT._.CLASS_VER_CODE.Contain(model.CLASS_VER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(PROJECT._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(PROJECT._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(PROJECT._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}