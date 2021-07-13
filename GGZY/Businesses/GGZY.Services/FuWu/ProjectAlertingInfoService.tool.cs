using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ProjectAlertingInfoService : BaseServiceT<PROJECT_ALERTING_INFO>
    {
        #region 接口实现
        
		public List<PROJECT_ALERTING_INFO> FindList(PROJECT_ALERTING_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PROJECT_ALERTING_INFO> PageList(PROJECT_ALERTING_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PROJECT_ALERTING_INFO._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PROJECT_ALERTING_INFO._.M_ID == M_ID);
			
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
        public GeneralResult Edit(PROJECT_ALERTING_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is PROJECT_ALERTING_INFO entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_NAME=model.TENDER_PROJECT_NAME;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.BID_SECTION_NAME=model.BID_SECTION_NAME;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.PROJECT_TYPE=model.PROJECT_TYPE;
		entity.TRADE_TYPE=model.TRADE_TYPE;
		entity.BODY_NAME=model.BODY_NAME;
		entity.BODY_CODE=model.BODY_CODE;
		entity.SUPERVISOR_UNIT_NAME=model.SUPERVISOR_UNIT_NAME;
		entity.SUPERVISOR_UNIT_CODE=model.SUPERVISOR_UNIT_CODE;
		entity.SUPERVISORY_NODE=model.SUPERVISORY_NODE;
		entity.ALERT_LEVEL=model.ALERT_LEVEL;
		entity.ALERT_DATE=model.ALERT_DATE;
		entity.ALERT_INFO=model.ALERT_INFO;
		entity.HANDLED=model.HANDLED;
		entity.HANDLE_RESULT=model.HANDLE_RESULT;
		entity.PULISH_DATE=model.PULISH_DATE;
		entity.CONFINED_ACTION=model.CONFINED_ACTION;
		entity.START_DATE=model.START_DATE;
		entity.END_DATE=model.END_DATE;
		entity.OPERATOR=model.OPERATOR;
		entity.ENTER_CREDIT_PLAT=model.ENTER_CREDIT_PLAT;
		entity.SIGNATURE=model.SIGNATURE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
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
        public GeneralResult Add(PROJECT_ALERTING_INFO model)
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
                    Delete(PROJECT_ALERTING_INFO._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PROJECT_ALERTING_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(PROJECT_ALERTING_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(PROJECT_ALERTING_INFO._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(PROJECT_ALERTING_INFO._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(PROJECT_ALERTING_INFO._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_NAME))
				{
				  condition.And(PROJECT_ALERTING_INFO._.BID_SECTION_NAME.Contain(model.BID_SECTION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(PROJECT_ALERTING_INFO._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
				{
				  condition.And(PROJECT_ALERTING_INFO._.PROJECT_TYPE.Contain(model.PROJECT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_TYPE))
				{
				  condition.And(PROJECT_ALERTING_INFO._.TRADE_TYPE.Contain(model.TRADE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_NAME))
				{
				  condition.And(PROJECT_ALERTING_INFO._.BODY_NAME.Contain(model.BODY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_CODE))
				{
				  condition.And(PROJECT_ALERTING_INFO._.BODY_CODE.Contain(model.BODY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISOR_UNIT_NAME))
				{
				  condition.And(PROJECT_ALERTING_INFO._.SUPERVISOR_UNIT_NAME.Contain(model.SUPERVISOR_UNIT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISOR_UNIT_CODE))
				{
				  condition.And(PROJECT_ALERTING_INFO._.SUPERVISOR_UNIT_CODE.Contain(model.SUPERVISOR_UNIT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISORY_NODE))
				{
				  condition.And(PROJECT_ALERTING_INFO._.SUPERVISORY_NODE.Contain(model.SUPERVISORY_NODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ALERT_LEVEL))
				{
				  condition.And(PROJECT_ALERTING_INFO._.ALERT_LEVEL.Contain(model.ALERT_LEVEL));
				}
				if(model.ALERT_DATE!=null)
				{
				  condition.And(PROJECT_ALERTING_INFO._.ALERT_DATE==(model.ALERT_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.ALERT_INFO))
				{
				  condition.And(PROJECT_ALERTING_INFO._.ALERT_INFO.Contain(model.ALERT_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.HANDLED))
				{
				  condition.And(PROJECT_ALERTING_INFO._.HANDLED.Contain(model.HANDLED));
				}
				if(!string.IsNullOrWhiteSpace(model.HANDLE_RESULT))
				{
				  condition.And(PROJECT_ALERTING_INFO._.HANDLE_RESULT.Contain(model.HANDLE_RESULT));
				}
				if(model.PULISH_DATE!=null)
				{
				  condition.And(PROJECT_ALERTING_INFO._.PULISH_DATE==(model.PULISH_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONFINED_ACTION))
				{
				  condition.And(PROJECT_ALERTING_INFO._.CONFINED_ACTION.Contain(model.CONFINED_ACTION));
				}
				if(model.START_DATE!=null)
				{
				  condition.And(PROJECT_ALERTING_INFO._.START_DATE==(model.START_DATE));
				}
				if(model.END_DATE!=null)
				{
				  condition.And(PROJECT_ALERTING_INFO._.END_DATE==(model.END_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.OPERATOR))
				{
				  condition.And(PROJECT_ALERTING_INFO._.OPERATOR.Contain(model.OPERATOR));
				}
				if(!string.IsNullOrWhiteSpace(model.ENTER_CREDIT_PLAT))
				{
				  condition.And(PROJECT_ALERTING_INFO._.ENTER_CREDIT_PLAT.Contain(model.ENTER_CREDIT_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.SIGNATURE))
				{
				  condition.And(PROJECT_ALERTING_INFO._.SIGNATURE.Contain(model.SIGNATURE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(PROJECT_ALERTING_INFO._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(PROJECT_ALERTING_INFO._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(PROJECT_ALERTING_INFO._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(PROJECT_ALERTING_INFO._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(PROJECT_ALERTING_INFO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(PROJECT_ALERTING_INFO._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(PROJECT_ALERTING_INFO._.M_ID==(model.M_ID));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(PROJECT_ALERTING_INFO._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(PROJECT_ALERTING_INFO._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(PROJECT_ALERTING_INFO._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(PROJECT_ALERTING_INFO._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}