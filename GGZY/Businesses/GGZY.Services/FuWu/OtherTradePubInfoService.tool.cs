using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class OtherTradePubInfoService : BaseServiceT<OTHER_TRADE_PUB_INFO>
    {
        #region 接口实现
        
		public List<OTHER_TRADE_PUB_INFO> FindList(OTHER_TRADE_PUB_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<OTHER_TRADE_PUB_INFO> PageList(OTHER_TRADE_PUB_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, OTHER_TRADE_PUB_INFO._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(OTHER_TRADE_PUB_INFO._.M_ID == M_ID);
			
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
        public GeneralResult Edit(OTHER_TRADE_PUB_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is OTHER_TRADE_PUB_INFO entity)
	{		
		entity.Attach();
		entity.PROJECT_NAME=model.PROJECT_NAME;
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.PUBLISHING_TIME=model.PUBLISHING_TIME;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.ANNOUNCEMENT_TITLE=model.ANNOUNCEMENT_TITLE;
		entity.ANNOUNCEMENT_CONNECT=model.ANNOUNCEMENT_CONNECT;
		entity.URL=model.URL;
		entity.CLASSIFY_CODE=model.CLASSIFY_CODE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_ATT_TRANSACTION_NOTICE=model.M_ATT_TRANSACTION_NOTICE;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_VERSION=model.M_VERSION;
		entity.REGION_CODE=model.REGION_CODE;
		entity.TRA_PLACE_CODE=model.TRA_PLACE_CODE;
		entity.TRA_AGENCY_NAME=model.TRA_AGENCY_NAME;
		entity.TRA_AGENCY_CODE=model.TRA_AGENCY_CODE;
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
        public GeneralResult Add(OTHER_TRADE_PUB_INFO model)
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
                    Delete(OTHER_TRADE_PUB_INFO._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<OTHER_TRADE_PUB_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(OTHER_TRADE_PUB_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.PROJECT_NAME.Contain(model.PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(model.PUBLISHING_TIME!=null)
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.PUBLISHING_TIME==(model.PUBLISHING_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ANNOUNCEMENT_TITLE))
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.ANNOUNCEMENT_TITLE.Contain(model.ANNOUNCEMENT_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.ANNOUNCEMENT_CONNECT))
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.ANNOUNCEMENT_CONNECT.Contain(model.ANNOUNCEMENT_CONNECT));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.CLASSIFY_CODE))
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.CLASSIFY_CODE.Contain(model.CLASSIFY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TRANSACTION_NOTICE))
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.M_ATT_TRANSACTION_NOTICE.Contain(model.M_ATT_TRANSACTION_NOTICE));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.M_VERSION.Contain(model.M_VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_PLACE_CODE))
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.TRA_PLACE_CODE.Contain(model.TRA_PLACE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_AGENCY_NAME))
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.TRA_AGENCY_NAME.Contain(model.TRA_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_AGENCY_CODE))
				{
				  condition.And(OTHER_TRADE_PUB_INFO._.TRA_AGENCY_CODE.Contain(model.TRA_AGENCY_CODE));
				}
		return condition;
	}
        #endregion
    }
}