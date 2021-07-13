﻿using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ExplorBidAuctionTransAnnService : BaseServiceT<EXPLOR_BID_AUCTION_TRANS_ANN>
    {
        #region 接口实现
        
		public List<EXPLOR_BID_AUCTION_TRANS_ANN> FindList(EXPLOR_BID_AUCTION_TRANS_ANN model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<EXPLOR_BID_AUCTION_TRANS_ANN> PageList(EXPLOR_BID_AUCTION_TRANS_ANN model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, EXPLOR_BID_AUCTION_TRANS_ANN._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.M_ID == M_ID);
			
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
        public GeneralResult Edit(EXPLOR_BID_AUCTION_TRANS_ANN model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is EXPLOR_BID_AUCTION_TRANS_ANN entity)
	{		
		entity.Attach();
		entity.NA_APP_NAME=model.NA_APP_NAME;
		entity.PUBLISHING_TIME=model.PUBLISHING_TIME;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.INVEST_PROJECT_CODE=model.INVEST_PROJECT_CODE;
		entity.URL=model.URL;
		entity.IN_BUY_KIND=model.IN_BUY_KIND;
		entity.IN_MINE_COME=model.IN_MINE_COME;
		entity.QT_PLAN_YEARS=model.QT_PLAN_YEARS;
		entity.QT_TOTAL_AREA=model.QT_TOTAL_AREA;
		entity.NA_GEOGRAPHY_POSITION=model.NA_GEOGRAPHY_POSITION;
		entity.NA_AREA_COORDINATE=model.NA_AREA_COORDINATE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_ATT_EXPLOR_TRANSFER_ANNOUCE=model.M_ATT_EXPLOR_TRANSFER_ANNOUCE;
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
        public GeneralResult Add(EXPLOR_BID_AUCTION_TRANS_ANN model)
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
                    Delete(EXPLOR_BID_AUCTION_TRANS_ANN._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<EXPLOR_BID_AUCTION_TRANS_ANN> model)
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
       	protected WhereClipBuilder ConditionBuilder(EXPLOR_BID_AUCTION_TRANS_ANN model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.NA_APP_NAME))
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.NA_APP_NAME.Contain(model.NA_APP_NAME));
				}
				if(model.PUBLISHING_TIME!=null)
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.PUBLISHING_TIME==(model.PUBLISHING_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.INVEST_PROJECT_CODE))
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.INVEST_PROJECT_CODE.Contain(model.INVEST_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.URL.Contain(model.URL));
				}
				if(model.IN_BUY_KIND!=null)
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.IN_BUY_KIND==(model.IN_BUY_KIND));
				}
				if(model.IN_MINE_COME!=null)
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.IN_MINE_COME==(model.IN_MINE_COME));
				}
				if(model.QT_PLAN_YEARS!=null)
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.QT_PLAN_YEARS==(model.QT_PLAN_YEARS));
				}
				if(model.QT_TOTAL_AREA!=null)
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.QT_TOTAL_AREA==(model.QT_TOTAL_AREA));
				}
				if(!string.IsNullOrWhiteSpace(model.NA_GEOGRAPHY_POSITION))
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.NA_GEOGRAPHY_POSITION.Contain(model.NA_GEOGRAPHY_POSITION));
				}
				if(!string.IsNullOrWhiteSpace(model.NA_AREA_COORDINATE))
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.NA_AREA_COORDINATE.Contain(model.NA_AREA_COORDINATE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_EXPLOR_TRANSFER_ANNOUCE))
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.M_ATT_EXPLOR_TRANSFER_ANNOUCE.Contain(model.M_ATT_EXPLOR_TRANSFER_ANNOUCE));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_PLACE_CODE))
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.TRA_PLACE_CODE.Contain(model.TRA_PLACE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_AGENCY_NAME))
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.TRA_AGENCY_NAME.Contain(model.TRA_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_AGENCY_CODE))
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.TRA_AGENCY_CODE.Contain(model.TRA_AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(EXPLOR_BID_AUCTION_TRANS_ANN._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}