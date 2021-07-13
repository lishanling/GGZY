using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class MiningBidAucTransResAnnService : BaseServiceT<MINING_BID_AUC_TRANS_RES_ANN>
    {
        #region 接口实现
        
		public List<MINING_BID_AUC_TRANS_RES_ANN> FindList(MINING_BID_AUC_TRANS_RES_ANN model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<MINING_BID_AUC_TRANS_RES_ANN> PageList(MINING_BID_AUC_TRANS_RES_ANN model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, MINING_BID_AUC_TRANS_RES_ANN._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(MINING_BID_AUC_TRANS_RES_ANN._.M_ID == M_ID);
			
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
        public GeneralResult Edit(MINING_BID_AUC_TRANS_RES_ANN model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is MINING_BID_AUC_TRANS_RES_ANN entity)
	{		
		entity.Attach();
		entity.NA_APP_NAME=model.NA_APP_NAME;
		entity.PUBLISHING_TIME=model.PUBLISHING_TIME;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.IN_BUY_KIND=model.IN_BUY_KIND;
		entity.QT_PLAN_YEARS=model.QT_PLAN_YEARS;
		entity.QT_TOTAL_AREA=model.QT_TOTAL_AREA;
		entity.NA_GEOGRAPHY_POSITION=model.NA_GEOGRAPHY_POSITION;
		entity.NA_PUBLIC_BIDDER=model.NA_PUBLIC_BIDDER;
		entity.BIDDER_TYPE=model.BIDDER_TYPE;
		entity.BIDDER_CODE=model.BIDDER_CODE;
		entity.BIDDER_ROLE=model.BIDDER_ROLE;
		entity.QT_PUBLIC_PRICE=model.QT_PUBLIC_PRICE;
		entity.NA_REG_ADDRESS=model.NA_REG_ADDRESS;
		entity.NA_TD_ADDRESS=model.NA_TD_ADDRESS;
		entity.DT_BUY_DATE=model.DT_BUY_DATE;
		entity.IN_COST_STYLE=model.IN_COST_STYLE;
		entity.DT_COST_DATE=model.DT_COST_DATE;
		entity.NA_AREA_COORDINATE=model.NA_AREA_COORDINATE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.URL=model.URL;
		entity.M_ID=model.M_ID;
		entity.M_ATT_MINING_TRANSFER_RESULT=model.M_ATT_MINING_TRANSFER_RESULT;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.REGION_CODE=model.REGION_CODE;
		entity.TRA_PLACE_CODE=model.TRA_PLACE_CODE;
		entity.TRA_AGENCY_NAME=model.TRA_AGENCY_NAME;
		entity.TRA_AGENCY_CODE=model.TRA_AGENCY_CODE;
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
        public GeneralResult Add(MINING_BID_AUC_TRANS_RES_ANN model)
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
                    Delete(MINING_BID_AUC_TRANS_RES_ANN._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<MINING_BID_AUC_TRANS_RES_ANN> model)
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
       	protected WhereClipBuilder ConditionBuilder(MINING_BID_AUC_TRANS_RES_ANN model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.NA_APP_NAME))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.NA_APP_NAME.Contain(model.NA_APP_NAME));
				}
				if(model.PUBLISHING_TIME!=null)
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.PUBLISHING_TIME==(model.PUBLISHING_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(model.IN_BUY_KIND!=null)
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.IN_BUY_KIND==(model.IN_BUY_KIND));
				}
				if(model.QT_PLAN_YEARS!=null)
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.QT_PLAN_YEARS==(model.QT_PLAN_YEARS));
				}
				if(model.QT_TOTAL_AREA!=null)
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.QT_TOTAL_AREA==(model.QT_TOTAL_AREA));
				}
				if(!string.IsNullOrWhiteSpace(model.NA_GEOGRAPHY_POSITION))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.NA_GEOGRAPHY_POSITION.Contain(model.NA_GEOGRAPHY_POSITION));
				}
				if(!string.IsNullOrWhiteSpace(model.NA_PUBLIC_BIDDER))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.NA_PUBLIC_BIDDER.Contain(model.NA_PUBLIC_BIDDER));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_TYPE))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.BIDDER_TYPE.Contain(model.BIDDER_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_CODE))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.BIDDER_CODE.Contain(model.BIDDER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_ROLE))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.BIDDER_ROLE.Contain(model.BIDDER_ROLE));
				}
				if(model.QT_PUBLIC_PRICE!=null)
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.QT_PUBLIC_PRICE==(model.QT_PUBLIC_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.NA_REG_ADDRESS))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.NA_REG_ADDRESS.Contain(model.NA_REG_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.NA_TD_ADDRESS))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.NA_TD_ADDRESS.Contain(model.NA_TD_ADDRESS));
				}
				if(model.DT_BUY_DATE!=null)
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.DT_BUY_DATE==(model.DT_BUY_DATE));
				}
				if(model.IN_COST_STYLE!=null)
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.IN_COST_STYLE==(model.IN_COST_STYLE));
				}
				if(model.DT_COST_DATE!=null)
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.DT_COST_DATE==(model.DT_COST_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.NA_AREA_COORDINATE))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.NA_AREA_COORDINATE.Contain(model.NA_AREA_COORDINATE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.URL.Contain(model.URL));
				}
				if(model.M_ID!=null)
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_MINING_TRANSFER_RESULT))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.M_ATT_MINING_TRANSFER_RESULT.Contain(model.M_ATT_MINING_TRANSFER_RESULT));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_PLACE_CODE))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.TRA_PLACE_CODE.Contain(model.TRA_PLACE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_AGENCY_NAME))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.TRA_AGENCY_NAME.Contain(model.TRA_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_AGENCY_CODE))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.TRA_AGENCY_CODE.Contain(model.TRA_AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(MINING_BID_AUC_TRANS_RES_ANN._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}