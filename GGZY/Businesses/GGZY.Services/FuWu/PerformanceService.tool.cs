using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class PerformanceService : BaseServiceT<PERFORMANCE>
    {
        #region 接口实现
        
		public List<PERFORMANCE> FindList(PERFORMANCE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PERFORMANCE> PageList(PERFORMANCE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PERFORMANCE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PERFORMANCE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(PERFORMANCE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is PERFORMANCE entity)
	{		
		entity.Attach();
		entity.M_ID=model.M_ID;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.PERFORMANCE_REPORT_NAME=model.PERFORMANCE_REPORT_NAME;
		entity.TENDERER_NAME=model.TENDERER_NAME;
		entity.TENDERER_CODE=model.TENDERER_CODE;
		entity.PERFORMANCE_PARTY_NAME=model.PERFORMANCE_PARTY_NAME;
		entity.PERFORMANCE_PARTY_CODE=model.PERFORMANCE_PARTY_CODE;
		entity.SETTLE_PRICE=model.SETTLE_PRICE;
		entity.FINISH_TIME=model.FINISH_TIME;
		entity.CONTRACT_CHANGE_CONTENT=model.CONTRACT_CHANGE_CONTENT;
		entity.ACTUALLY_PERIOD=model.ACTUALLY_PERIOD;
		entity.PERFORMANCE_CONTENT=model.PERFORMANCE_CONTENT;
		entity.REPORT_ISSUE_TIME=model.REPORT_ISSUE_TIME;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.TRADE_PLAT=model.TRADE_PLAT;
		entity.PUB_SERVICE_PLAT=model.PUB_SERVICE_PLAT;
		entity.M_VERSION=model.M_VERSION;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_CREATOR=model.M_CREATOR;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
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
        public GeneralResult Add(PERFORMANCE model)
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
                    Delete(PERFORMANCE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PERFORMANCE> model)
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
       	protected WhereClipBuilder ConditionBuilder(PERFORMANCE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(PERFORMANCE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(PERFORMANCE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(PERFORMANCE._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(PERFORMANCE._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORMANCE_REPORT_NAME))
				{
				  condition.And(PERFORMANCE._.PERFORMANCE_REPORT_NAME.Contain(model.PERFORMANCE_REPORT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_NAME))
				{
				  condition.And(PERFORMANCE._.TENDERER_NAME.Contain(model.TENDERER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_CODE))
				{
				  condition.And(PERFORMANCE._.TENDERER_CODE.Contain(model.TENDERER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORMANCE_PARTY_NAME))
				{
				  condition.And(PERFORMANCE._.PERFORMANCE_PARTY_NAME.Contain(model.PERFORMANCE_PARTY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORMANCE_PARTY_CODE))
				{
				  condition.And(PERFORMANCE._.PERFORMANCE_PARTY_CODE.Contain(model.PERFORMANCE_PARTY_CODE));
				}
				if(model.SETTLE_PRICE!=null)
				{
				  condition.And(PERFORMANCE._.SETTLE_PRICE==(model.SETTLE_PRICE));
				}
				if(model.FINISH_TIME!=null)
				{
				  condition.And(PERFORMANCE._.FINISH_TIME==(model.FINISH_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_CHANGE_CONTENT))
				{
				  condition.And(PERFORMANCE._.CONTRACT_CHANGE_CONTENT.Contain(model.CONTRACT_CHANGE_CONTENT));
				}
				if(model.ACTUALLY_PERIOD!=null)
				{
				  condition.And(PERFORMANCE._.ACTUALLY_PERIOD==(model.ACTUALLY_PERIOD));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORMANCE_CONTENT))
				{
				  condition.And(PERFORMANCE._.PERFORMANCE_CONTENT.Contain(model.PERFORMANCE_CONTENT));
				}
				if(model.REPORT_ISSUE_TIME!=null)
				{
				  condition.And(PERFORMANCE._.REPORT_ISSUE_TIME==(model.REPORT_ISSUE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(PERFORMANCE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(PERFORMANCE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(PERFORMANCE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(PERFORMANCE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(PERFORMANCE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(PERFORMANCE._.M_VERSION.Contain(model.M_VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(PERFORMANCE._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(PERFORMANCE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(PERFORMANCE._.M_TM==(model.M_TM));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(PERFORMANCE._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(PERFORMANCE._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(PERFORMANCE._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(PERFORMANCE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
		return condition;
	}
        #endregion
    }
}