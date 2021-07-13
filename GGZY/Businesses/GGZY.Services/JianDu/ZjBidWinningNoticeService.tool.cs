using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ZjBidWinningNoticeService : BaseServiceT<ZJ_BID_WINNING_NOTICE>
    {
        #region 接口实现
        
		public List<ZJ_BID_WINNING_NOTICE> FindList(ZJ_BID_WINNING_NOTICE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJ_BID_WINNING_NOTICE> PageList(ZJ_BID_WINNING_NOTICE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJ_BID_WINNING_NOTICE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(ZJ_BID_WINNING_NOTICE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(ZJ_BID_WINNING_NOTICE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is ZJ_BID_WINNING_NOTICE entity)
	{		
		entity.Attach();
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_CREATOR=model.M_CREATOR;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.REPROT_CODE=model.REPROT_CODE;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.TENDER_PROJECT_NAME=model.TENDER_PROJECT_NAME;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.WIN_NOTICE_CODE_ENTP=model.WIN_NOTICE_CODE_ENTP;
		entity.WIN_NOTICE_CODE=model.WIN_NOTICE_CODE;
		entity.WIN_BIDDER_NAME=model.WIN_BIDDER_NAME;
		entity.WIN_BIDDER_CODE=model.WIN_BIDDER_CODE;
		entity.BID_TIME=model.BID_TIME;
		entity.TENDER_NOTICE_CONTENT=model.TENDER_NOTICE_CONTENT;
		entity.TIME_LIMIT=model.TIME_LIMIT;
		entity.BID_AMOUNT=model.BID_AMOUNT;
		entity.BID_CURRENCY=model.BID_CURRENCY;
		entity.PRICE_UNIT=model.PRICE_UNIT;
		entity.CONSTRUCTION_QUALITY=model.CONSTRUCTION_QUALITY;
		entity.PROJECT_LEAD=model.PROJECT_LEAD;
		entity.PROJECT_LEAD_ID=model.PROJECT_LEAD_ID;
		entity.PROJECT_LEAD_CERTITY_NO=model.PROJECT_LEAD_CERTITY_NO;
		entity.WIN_NOTICE_CONTENT=model.WIN_NOTICE_CONTENT;
		entity.WIN_NOTICE_SEND_TIME=model.WIN_NOTICE_SEND_TIME;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
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
        public GeneralResult Add(ZJ_BID_WINNING_NOTICE model)
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
                    Delete(ZJ_BID_WINNING_NOTICE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJ_BID_WINNING_NOTICE> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJ_BID_WINNING_NOTICE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.M_TM==(model.M_TM));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.REPROT_CODE))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.REPROT_CODE.Contain(model.REPROT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_NOTICE_CODE_ENTP))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.WIN_NOTICE_CODE_ENTP.Contain(model.WIN_NOTICE_CODE_ENTP));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_NOTICE_CODE))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.WIN_NOTICE_CODE.Contain(model.WIN_NOTICE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BIDDER_NAME))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.WIN_BIDDER_NAME.Contain(model.WIN_BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BIDDER_CODE))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.WIN_BIDDER_CODE.Contain(model.WIN_BIDDER_CODE));
				}
				if(model.BID_TIME!=null)
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.BID_TIME==(model.BID_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_NOTICE_CONTENT))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.TENDER_NOTICE_CONTENT.Contain(model.TENDER_NOTICE_CONTENT));
				}
				if(model.TIME_LIMIT!=null)
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.TIME_LIMIT==(model.TIME_LIMIT));
				}
				if(model.BID_AMOUNT!=null)
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.BID_AMOUNT==(model.BID_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_CURRENCY))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.BID_CURRENCY.Contain(model.BID_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_UNIT))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.PRICE_UNIT.Contain(model.PRICE_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCTION_QUALITY))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.CONSTRUCTION_QUALITY.Contain(model.CONSTRUCTION_QUALITY));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_LEAD))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.PROJECT_LEAD.Contain(model.PROJECT_LEAD));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_LEAD_ID))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.PROJECT_LEAD_ID.Contain(model.PROJECT_LEAD_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_LEAD_CERTITY_NO))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.PROJECT_LEAD_CERTITY_NO.Contain(model.PROJECT_LEAD_CERTITY_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_NOTICE_CONTENT))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.WIN_NOTICE_CONTENT.Contain(model.WIN_NOTICE_CONTENT));
				}
				if(model.WIN_NOTICE_SEND_TIME!=null)
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.WIN_NOTICE_SEND_TIME==(model.WIN_NOTICE_SEND_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(ZJ_BID_WINNING_NOTICE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}