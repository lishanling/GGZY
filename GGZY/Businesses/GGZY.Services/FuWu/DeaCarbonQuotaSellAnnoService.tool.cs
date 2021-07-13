using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class DeaCarbonQuotaSellAnnoService : BaseServiceT<DEA_CARBON_QUOTA_SELL_ANNO>
    {
        #region 接口实现
        
		public List<DEA_CARBON_QUOTA_SELL_ANNO> FindList(DEA_CARBON_QUOTA_SELL_ANNO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<DEA_CARBON_QUOTA_SELL_ANNO> PageList(DEA_CARBON_QUOTA_SELL_ANNO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, DEA_CARBON_QUOTA_SELL_ANNO._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.M_ID == M_ID);
			
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
        public GeneralResult Edit(DEA_CARBON_QUOTA_SELL_ANNO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is DEA_CARBON_QUOTA_SELL_ANNO entity)
	{		
		entity.Attach();
		entity.M_ID=model.M_ID;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_CREATOR=model.M_CREATOR;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.NOTICE_SEND_TIME=model.NOTICE_SEND_TIME;
		entity.UNIFIED_DEAL_CODES=model.UNIFIED_DEAL_CODES;
		entity.INDUSTRY_CODE=model.INDUSTRY_CODE;
		entity.CA_QUOTA_NAME=model.CA_QUOTA_NAME;
		entity.CA_QUOTA_CODE=model.CA_QUOTA_CODE;
		entity.CA_QUOTA_BEGINDATE=model.CA_QUOTA_BEGINDATE;
		entity.CA_QUOTA_ENDDATE=model.CA_QUOTA_ENDDATE;
		entity.IN_BUY_KIND=model.IN_BUY_KIND;
		entity.CA_QUOTA_QTY=model.CA_QUOTA_QTY;
		entity.CA_QUOTA_PRICE=model.CA_QUOTA_PRICE;
		entity.TRADING_BEGINTIME=model.TRADING_BEGINTIME;
		entity.TRADING_ENDTIME=model.TRADING_ENDTIME;
		entity.SALE_COMM_TYPE=model.SALE_COMM_TYPE;
		entity.SALE_COMM_RATE=model.SALE_COMM_RATE;
		entity.BUY_COMM_TYPE=model.BUY_COMM_TYPE;
		entity.BUY_COMM_RATE=model.BUY_COMM_RATE;
		entity.TRADING_NOTICE=model.TRADING_NOTICE;
		entity.MARGIN_PAY=model.MARGIN_PAY;
		entity.MARGIN_PAY_ACCOUNT=model.MARGIN_PAY_ACCOUNT;
		entity.ANNOUNCEMENT_CONNECT=model.ANNOUNCEMENT_CONNECT;
		entity.SELL_COMM_NAME=model.SELL_COMM_NAME;
		entity.SELL_ORG_CODE=model.SELL_ORG_CODE;
		entity.TENDERER_CONTACTOR=model.TENDERER_CONTACTOR;
		entity.TENDERER_PHONE_NUMBER=model.TENDERER_PHONE_NUMBER;
		entity.URL=model.URL;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
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
        public GeneralResult Add(DEA_CARBON_QUOTA_SELL_ANNO model)
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
                    Delete(DEA_CARBON_QUOTA_SELL_ANNO._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<DEA_CARBON_QUOTA_SELL_ANNO> model)
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
       	protected WhereClipBuilder ConditionBuilder(DEA_CARBON_QUOTA_SELL_ANNO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.M_TM==(model.M_TM));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.NOTICE_SEND_TIME!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.NOTICE_SEND_TIME==(model.NOTICE_SEND_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODES))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.UNIFIED_DEAL_CODES.Contain(model.UNIFIED_DEAL_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.INDUSTRY_CODE))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.INDUSTRY_CODE.Contain(model.INDUSTRY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CA_QUOTA_NAME))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.CA_QUOTA_NAME.Contain(model.CA_QUOTA_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CA_QUOTA_CODE))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.CA_QUOTA_CODE.Contain(model.CA_QUOTA_CODE));
				}
				if(model.CA_QUOTA_BEGINDATE!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.CA_QUOTA_BEGINDATE==(model.CA_QUOTA_BEGINDATE));
				}
				if(model.CA_QUOTA_ENDDATE!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.CA_QUOTA_ENDDATE==(model.CA_QUOTA_ENDDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.IN_BUY_KIND))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.IN_BUY_KIND.Contain(model.IN_BUY_KIND));
				}
				if(model.CA_QUOTA_QTY!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.CA_QUOTA_QTY==(model.CA_QUOTA_QTY));
				}
				if(model.CA_QUOTA_PRICE!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.CA_QUOTA_PRICE==(model.CA_QUOTA_PRICE));
				}
				if(model.TRADING_BEGINTIME!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.TRADING_BEGINTIME==(model.TRADING_BEGINTIME));
				}
				if(model.TRADING_ENDTIME!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.TRADING_ENDTIME==(model.TRADING_ENDTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.SALE_COMM_TYPE))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.SALE_COMM_TYPE.Contain(model.SALE_COMM_TYPE));
				}
				if(model.SALE_COMM_RATE!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.SALE_COMM_RATE==(model.SALE_COMM_RATE));
				}
				if(!string.IsNullOrWhiteSpace(model.BUY_COMM_TYPE))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.BUY_COMM_TYPE.Contain(model.BUY_COMM_TYPE));
				}
				if(model.BUY_COMM_RATE!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.BUY_COMM_RATE==(model.BUY_COMM_RATE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADING_NOTICE))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.TRADING_NOTICE.Contain(model.TRADING_NOTICE));
				}
				if(model.MARGIN_PAY!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.MARGIN_PAY==(model.MARGIN_PAY));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_PAY_ACCOUNT))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.MARGIN_PAY_ACCOUNT.Contain(model.MARGIN_PAY_ACCOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.ANNOUNCEMENT_CONNECT))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.ANNOUNCEMENT_CONNECT.Contain(model.ANNOUNCEMENT_CONNECT));
				}
				if(!string.IsNullOrWhiteSpace(model.SELL_COMM_NAME))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.SELL_COMM_NAME.Contain(model.SELL_COMM_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SELL_ORG_CODE))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.SELL_ORG_CODE.Contain(model.SELL_ORG_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_CONTACTOR))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.TENDERER_CONTACTOR.Contain(model.TENDERER_CONTACTOR));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_PHONE_NUMBER))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.TENDERER_PHONE_NUMBER.Contain(model.TENDERER_PHONE_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_ANNO._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}