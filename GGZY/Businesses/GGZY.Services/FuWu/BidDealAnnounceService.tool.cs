using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BidDealAnnounceService : BaseServiceT<BID_DEAL_ANNOUNCE>
    {
        #region 接口实现
        
		public List<BID_DEAL_ANNOUNCE> FindList(BID_DEAL_ANNOUNCE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BID_DEAL_ANNOUNCE> PageList(BID_DEAL_ANNOUNCE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, BID_DEAL_ANNOUNCE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(BID_DEAL_ANNOUNCE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(BID_DEAL_ANNOUNCE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is BID_DEAL_ANNOUNCE entity)
	{		
		entity.Attach();
		entity.PURCHASE_PROJECT_CODE=model.PURCHASE_PROJECT_CODE;
		entity.PURCHASE_PROJECT_NAME=model.PURCHASE_PROJECT_NAME;
		entity.PURCHASE_SECTION_CODE=model.PURCHASE_SECTION_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.WIN_BID_BULLETIN_TITLE=model.WIN_BID_BULLETIN_TITLE;
		entity.WIN_BID_BULLETIN_CONTENT=model.WIN_BID_BULLETIN_CONTENT;
		entity.WIN_BID_BULLETIN_START_TIME=model.WIN_BID_BULLETIN_START_TIME;
		entity.URL=model.URL;
		entity.WINNINGBIDDER_NAME=model.WINNINGBIDDER_NAME;
		entity.WINNINGBIDDER_CODE=model.WINNINGBIDDER_CODE;
		entity.WIN_BID_PRICE=model.WIN_BID_PRICE;
		entity.CURRENCY_CODE=model.CURRENCY_CODE;
		entity.PRICE_UNIT=model.PRICE_UNIT;
		entity.CREATOR=model.CREATOR;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_ATT_WIN_BID_NOTICE=model.M_ATT_WIN_BID_NOTICE;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.REGION_CODE=model.REGION_CODE;
		entity.TRA_PLACE_CODE=model.TRA_PLACE_CODE;
		entity.PURCHASER_AGENCY_NAME=model.PURCHASER_AGENCY_NAME;
		entity.PURCHASER_AGENCY_CODE=model.PURCHASER_AGENCY_CODE;
		entity.WINNINGBIDDER_TYPE=model.WINNINGBIDDER_TYPE;
		entity.PRICE_FORM_CODE=model.PRICE_FORM_CODE;
		entity.WIN_BID_RATE=model.WIN_BID_RATE;
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
        public GeneralResult Add(BID_DEAL_ANNOUNCE model)
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
                    Delete(BID_DEAL_ANNOUNCE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BID_DEAL_ANNOUNCE> model)
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
       	protected WhereClipBuilder ConditionBuilder(BID_DEAL_ANNOUNCE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_PROJECT_CODE))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.PURCHASE_PROJECT_CODE.Contain(model.PURCHASE_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_PROJECT_NAME))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.PURCHASE_PROJECT_NAME.Contain(model.PURCHASE_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASE_SECTION_CODE))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.PURCHASE_SECTION_CODE.Contain(model.PURCHASE_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BID_BULLETIN_TITLE))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.WIN_BID_BULLETIN_TITLE.Contain(model.WIN_BID_BULLETIN_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BID_BULLETIN_CONTENT))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.WIN_BID_BULLETIN_CONTENT.Contain(model.WIN_BID_BULLETIN_CONTENT));
				}
				if(model.WIN_BID_BULLETIN_START_TIME!=null)
				{
				  condition.And(BID_DEAL_ANNOUNCE._.WIN_BID_BULLETIN_START_TIME==(model.WIN_BID_BULLETIN_START_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.WINNINGBIDDER_NAME))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.WINNINGBIDDER_NAME.Contain(model.WINNINGBIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.WINNINGBIDDER_CODE))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.WINNINGBIDDER_CODE.Contain(model.WINNINGBIDDER_CODE));
				}
				if(model.WIN_BID_PRICE!=null)
				{
				  condition.And(BID_DEAL_ANNOUNCE._.WIN_BID_PRICE==(model.WIN_BID_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.CURRENCY_CODE))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.CURRENCY_CODE.Contain(model.CURRENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_UNIT))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.PRICE_UNIT.Contain(model.PRICE_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.CREATOR))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.CREATOR.Contain(model.CREATOR));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(BID_DEAL_ANNOUNCE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(BID_DEAL_ANNOUNCE._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(BID_DEAL_ANNOUNCE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_WIN_BID_NOTICE))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.M_ATT_WIN_BID_NOTICE.Contain(model.M_ATT_WIN_BID_NOTICE));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(BID_DEAL_ANNOUNCE._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(BID_DEAL_ANNOUNCE._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(BID_DEAL_ANNOUNCE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_PLACE_CODE))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.TRA_PLACE_CODE.Contain(model.TRA_PLACE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASER_AGENCY_NAME))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.PURCHASER_AGENCY_NAME.Contain(model.PURCHASER_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PURCHASER_AGENCY_CODE))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.PURCHASER_AGENCY_CODE.Contain(model.PURCHASER_AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.WINNINGBIDDER_TYPE))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.WINNINGBIDDER_TYPE.Contain(model.WINNINGBIDDER_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_FORM_CODE))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.PRICE_FORM_CODE.Contain(model.PRICE_FORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BID_RATE))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.WIN_BID_RATE.Contain(model.WIN_BID_RATE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(BID_DEAL_ANNOUNCE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}