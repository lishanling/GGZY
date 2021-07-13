using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ViolatingLawsRulesInfoService : BaseServiceT<VIOLATING_LAWS_RULES_INFO>
    {
        #region 接口实现
        
		public List<VIOLATING_LAWS_RULES_INFO> FindList(VIOLATING_LAWS_RULES_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<VIOLATING_LAWS_RULES_INFO> PageList(VIOLATING_LAWS_RULES_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, VIOLATING_LAWS_RULES_INFO._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(VIOLATING_LAWS_RULES_INFO._.M_ID == M_ID);
			
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
        public GeneralResult Edit(VIOLATING_LAWS_RULES_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is VIOLATING_LAWS_RULES_INFO entity)
	{		
		entity.Attach();
		entity.VIOLATING_CODE=model.VIOLATING_CODE;
		entity.VIOLATING_NAME=model.VIOLATING_NAME;
		entity.VIOLATING_TIME=model.VIOLATING_TIME;
		entity.VIOLATING_TYPE=model.VIOLATING_TYPE;
		entity.BODY_NAME=model.BODY_NAME;
		entity.BODY_TYPE=model.BODY_TYPE;
		entity.BODY_CODE=model.BODY_CODE;
		entity.BODY_ROLE=model.BODY_ROLE;
		entity.AREA=model.AREA;
		entity.REWARD_PUNISHMENT_BODY=model.REWARD_PUNISHMENT_BODY;
		entity.VIOLATING_INSTRUCTIONS=model.VIOLATING_INSTRUCTIONS;
		entity.GOVERNMENT=model.GOVERNMENT;
		entity.TENDER_PROJECT_NAME=model.TENDER_PROJECT_NAME;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.BID_SECTION_NAME=model.BID_SECTION_NAME;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.DOCUMENT_CODE=model.DOCUMENT_CODE;
		entity.PUNISHMENT_BASIS=model.PUNISHMENT_BASIS;
		entity.PUNISHMENT_RESULT=model.PUNISHMENT_RESULT;
		entity.CONFINED_ACTION=model.CONFINED_ACTION;
		entity.CONFINED_START=model.CONFINED_START;
		entity.CONFINED_END=model.CONFINED_END;
		entity.OPERATE_DATE=model.OPERATE_DATE;
		entity.SCOPE=model.SCOPE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_ATT_ILLEGAL_DOC=model.M_ATT_ILLEGAL_DOC;
		entity.M_ATT_PUNISHMENT_DOC=model.M_ATT_PUNISHMENT_DOC;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
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
        public GeneralResult Add(VIOLATING_LAWS_RULES_INFO model)
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
                    Delete(VIOLATING_LAWS_RULES_INFO._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<VIOLATING_LAWS_RULES_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(VIOLATING_LAWS_RULES_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.VIOLATING_CODE))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.VIOLATING_CODE.Contain(model.VIOLATING_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.VIOLATING_NAME))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.VIOLATING_NAME.Contain(model.VIOLATING_NAME));
				}
				if(model.VIOLATING_TIME!=null)
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.VIOLATING_TIME==(model.VIOLATING_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.VIOLATING_TYPE))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.VIOLATING_TYPE.Contain(model.VIOLATING_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_NAME))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.BODY_NAME.Contain(model.BODY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_TYPE))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.BODY_TYPE.Contain(model.BODY_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_CODE))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.BODY_CODE.Contain(model.BODY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_ROLE))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.BODY_ROLE.Contain(model.BODY_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.AREA))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.AREA.Contain(model.AREA));
				}
				if(!string.IsNullOrWhiteSpace(model.REWARD_PUNISHMENT_BODY))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.REWARD_PUNISHMENT_BODY.Contain(model.REWARD_PUNISHMENT_BODY));
				}
				if(!string.IsNullOrWhiteSpace(model.VIOLATING_INSTRUCTIONS))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.VIOLATING_INSTRUCTIONS.Contain(model.VIOLATING_INSTRUCTIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.GOVERNMENT))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.GOVERNMENT.Contain(model.GOVERNMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_NAME))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.BID_SECTION_NAME.Contain(model.BID_SECTION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.DOCUMENT_CODE))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.DOCUMENT_CODE.Contain(model.DOCUMENT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUNISHMENT_BASIS))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.PUNISHMENT_BASIS.Contain(model.PUNISHMENT_BASIS));
				}
				if(!string.IsNullOrWhiteSpace(model.PUNISHMENT_RESULT))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.PUNISHMENT_RESULT.Contain(model.PUNISHMENT_RESULT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONFINED_ACTION))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.CONFINED_ACTION.Contain(model.CONFINED_ACTION));
				}
				if(model.CONFINED_START!=null)
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.CONFINED_START==(model.CONFINED_START));
				}
				if(model.CONFINED_END!=null)
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.CONFINED_END==(model.CONFINED_END));
				}
				if(model.OPERATE_DATE!=null)
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.OPERATE_DATE==(model.OPERATE_DATE));
				}
				if(model.SCOPE!=null)
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.SCOPE==(model.SCOPE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_ILLEGAL_DOC))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.M_ATT_ILLEGAL_DOC.Contain(model.M_ATT_ILLEGAL_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PUNISHMENT_DOC))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.M_ATT_PUNISHMENT_DOC.Contain(model.M_ATT_PUNISHMENT_DOC));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(VIOLATING_LAWS_RULES_INFO._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}