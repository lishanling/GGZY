using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class DeaCarbonQuotaSellResultService : BaseServiceT<DEA_CARBON_QUOTA_SELL_RESULT>
    {
        #region 接口实现
        
		public List<DEA_CARBON_QUOTA_SELL_RESULT> FindList(DEA_CARBON_QUOTA_SELL_RESULT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<DEA_CARBON_QUOTA_SELL_RESULT> PageList(DEA_CARBON_QUOTA_SELL_RESULT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, DEA_CARBON_QUOTA_SELL_RESULT._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.M_ID == M_ID);
			
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
        public GeneralResult Edit(DEA_CARBON_QUOTA_SELL_RESULT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is DEA_CARBON_QUOTA_SELL_RESULT entity)
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
		entity.CA_QUOTA_NAME=model.CA_QUOTA_NAME;
		entity.CA_QUOTA_CODE=model.CA_QUOTA_CODE;
		entity.IN_BUY_KIND=model.IN_BUY_KIND;
		entity.CA_BUYER_NAME=model.CA_BUYER_NAME;
		entity.CA_BUYER_CODE=model.CA_BUYER_CODE;
		entity.CA_BUYER_TYPE=model.CA_BUYER_TYPE;
		entity.BUYER_IDTYPE=model.BUYER_IDTYPE;
		entity.BUYER_IDCARD=model.BUYER_IDCARD;
		entity.BARGAIN_NO=model.BARGAIN_NO;
		entity.BARGAIN_PRICE=model.BARGAIN_PRICE;
		entity.BARGAIN_QTY=model.BARGAIN_QTY;
		entity.BARGAIN_VALUE=model.BARGAIN_VALUE;
		entity.BARGAIN_TIME=model.BARGAIN_TIME;
		entity.CA_QUOTA_URL=model.CA_QUOTA_URL;
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
        public GeneralResult Add(DEA_CARBON_QUOTA_SELL_RESULT model)
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
                    Delete(DEA_CARBON_QUOTA_SELL_RESULT._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<DEA_CARBON_QUOTA_SELL_RESULT> model)
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
       	protected WhereClipBuilder ConditionBuilder(DEA_CARBON_QUOTA_SELL_RESULT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.M_TM==(model.M_TM));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.NOTICE_SEND_TIME!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.NOTICE_SEND_TIME==(model.NOTICE_SEND_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODES))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.UNIFIED_DEAL_CODES.Contain(model.UNIFIED_DEAL_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.CA_QUOTA_NAME))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.CA_QUOTA_NAME.Contain(model.CA_QUOTA_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CA_QUOTA_CODE))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.CA_QUOTA_CODE.Contain(model.CA_QUOTA_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.IN_BUY_KIND))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.IN_BUY_KIND.Contain(model.IN_BUY_KIND));
				}
				if(!string.IsNullOrWhiteSpace(model.CA_BUYER_NAME))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.CA_BUYER_NAME.Contain(model.CA_BUYER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CA_BUYER_CODE))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.CA_BUYER_CODE.Contain(model.CA_BUYER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CA_BUYER_TYPE))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.CA_BUYER_TYPE.Contain(model.CA_BUYER_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BUYER_IDTYPE))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.BUYER_IDTYPE.Contain(model.BUYER_IDTYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BUYER_IDCARD))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.BUYER_IDCARD.Contain(model.BUYER_IDCARD));
				}
				if(!string.IsNullOrWhiteSpace(model.BARGAIN_NO))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.BARGAIN_NO.Contain(model.BARGAIN_NO));
				}
				if(model.BARGAIN_PRICE!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.BARGAIN_PRICE==(model.BARGAIN_PRICE));
				}
				if(model.BARGAIN_QTY!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.BARGAIN_QTY==(model.BARGAIN_QTY));
				}
				if(model.BARGAIN_VALUE!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.BARGAIN_VALUE==(model.BARGAIN_VALUE));
				}
				if(model.BARGAIN_TIME!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.BARGAIN_TIME==(model.BARGAIN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.CA_QUOTA_URL))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.CA_QUOTA_URL.Contain(model.CA_QUOTA_URL));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(DEA_CARBON_QUOTA_SELL_RESULT._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}