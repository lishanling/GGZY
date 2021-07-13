using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class DealLandInfoService : BaseServiceT<DEAL_LAND_INFO>
    {
        #region 接口实现
        
		public List<DEAL_LAND_INFO> FindList(DEAL_LAND_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<DEAL_LAND_INFO> PageList(DEAL_LAND_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, DEAL_LAND_INFO._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(DEAL_LAND_INFO._.M_ID == M_ID);
			
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
        public GeneralResult Edit(DEAL_LAND_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is DEAL_LAND_INFO entity)
	{		
		entity.Attach();
		entity.DEAL_LAND_CODE=model.DEAL_LAND_CODE;
		entity.DEAL_ANNOUNCEMENT_GUID=model.DEAL_ANNOUNCEMENT_GUID;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.INVEST_PROJECT_CODE=model.INVEST_PROJECT_CODE;
		entity.LAND_PROJECT_NAME=model.LAND_PROJECT_NAME;
		entity.LAND_CODE=model.LAND_CODE;
		entity.LAND_AREA=model.LAND_AREA;
		entity.LAND_USAGE=model.LAND_USAGE;
		entity.LEND_AGE_LIMIT=model.LEND_AGE_LIMIT;
		entity.LAND_POSITION=model.LAND_POSITION;
		entity.DEAL_PRICE=model.DEAL_PRICE;
		entity.LENDING_NAME=model.LENDING_NAME;
		entity.LAND_BZ=model.LAND_BZ;
		entity.LAND_URL=model.LAND_URL;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.CURRENCY_CODE=model.CURRENCY_CODE;
		entity.PRICE_UNIT=model.PRICE_UNIT;
		entity.PUBLISHING_TIME=model.PUBLISHING_TIME;
		entity.M_ID=model.M_ID;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.RELATE_CODE=model.RELATE_CODE;
		entity.REGION_CODE=model.REGION_CODE;
		entity.TRA_PLACE_CODE=model.TRA_PLACE_CODE;
		entity.TRA_AGENCY_NAME=model.TRA_AGENCY_NAME;
		entity.TRA_AGENCY_CODE=model.TRA_AGENCY_CODE;
		entity.LENDING_TYPE=model.LENDING_TYPE;
		entity.LENDING_CODE=model.LENDING_CODE;
		entity.ANNOUNCEMENT_TITLE=model.ANNOUNCEMENT_TITLE;
		entity.ANNOUNCEMENT_CONNECT=model.ANNOUNCEMENT_CONNECT;
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
        public GeneralResult Add(DEAL_LAND_INFO model)
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
                    Delete(DEAL_LAND_INFO._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<DEAL_LAND_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(DEAL_LAND_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.DEAL_LAND_CODE))
				{
				  condition.And(DEAL_LAND_INFO._.DEAL_LAND_CODE.Contain(model.DEAL_LAND_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.DEAL_ANNOUNCEMENT_GUID))
				{
				  condition.And(DEAL_LAND_INFO._.DEAL_ANNOUNCEMENT_GUID.Contain(model.DEAL_ANNOUNCEMENT_GUID));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(DEAL_LAND_INFO._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.INVEST_PROJECT_CODE))
				{
				  condition.And(DEAL_LAND_INFO._.INVEST_PROJECT_CODE.Contain(model.INVEST_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.LAND_PROJECT_NAME))
				{
				  condition.And(DEAL_LAND_INFO._.LAND_PROJECT_NAME.Contain(model.LAND_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.LAND_CODE))
				{
				  condition.And(DEAL_LAND_INFO._.LAND_CODE.Contain(model.LAND_CODE));
				}
				if(model.LAND_AREA!=null)
				{
				  condition.And(DEAL_LAND_INFO._.LAND_AREA==(model.LAND_AREA));
				}
				if(!string.IsNullOrWhiteSpace(model.LAND_USAGE))
				{
				  condition.And(DEAL_LAND_INFO._.LAND_USAGE.Contain(model.LAND_USAGE));
				}
				if(!string.IsNullOrWhiteSpace(model.LEND_AGE_LIMIT))
				{
				  condition.And(DEAL_LAND_INFO._.LEND_AGE_LIMIT.Contain(model.LEND_AGE_LIMIT));
				}
				if(!string.IsNullOrWhiteSpace(model.LAND_POSITION))
				{
				  condition.And(DEAL_LAND_INFO._.LAND_POSITION.Contain(model.LAND_POSITION));
				}
				if(model.DEAL_PRICE!=null)
				{
				  condition.And(DEAL_LAND_INFO._.DEAL_PRICE==(model.DEAL_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.LENDING_NAME))
				{
				  condition.And(DEAL_LAND_INFO._.LENDING_NAME.Contain(model.LENDING_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.LAND_BZ))
				{
				  condition.And(DEAL_LAND_INFO._.LAND_BZ.Contain(model.LAND_BZ));
				}
				if(!string.IsNullOrWhiteSpace(model.LAND_URL))
				{
				  condition.And(DEAL_LAND_INFO._.LAND_URL.Contain(model.LAND_URL));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(DEAL_LAND_INFO._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(DEAL_LAND_INFO._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(DEAL_LAND_INFO._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(DEAL_LAND_INFO._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(DEAL_LAND_INFO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(DEAL_LAND_INFO._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.CURRENCY_CODE))
				{
				  condition.And(DEAL_LAND_INFO._.CURRENCY_CODE.Contain(model.CURRENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_UNIT))
				{
				  condition.And(DEAL_LAND_INFO._.PRICE_UNIT.Contain(model.PRICE_UNIT));
				}
				if(model.PUBLISHING_TIME!=null)
				{
				  condition.And(DEAL_LAND_INFO._.PUBLISHING_TIME==(model.PUBLISHING_TIME));
				}
				if(model.M_ID!=null)
				{
				  condition.And(DEAL_LAND_INFO._.M_ID==(model.M_ID));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(DEAL_LAND_INFO._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(DEAL_LAND_INFO._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(DEAL_LAND_INFO._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.RELATE_CODE))
				{
				  condition.And(DEAL_LAND_INFO._.RELATE_CODE.Contain(model.RELATE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(DEAL_LAND_INFO._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_PLACE_CODE))
				{
				  condition.And(DEAL_LAND_INFO._.TRA_PLACE_CODE.Contain(model.TRA_PLACE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_AGENCY_NAME))
				{
				  condition.And(DEAL_LAND_INFO._.TRA_AGENCY_NAME.Contain(model.TRA_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_AGENCY_CODE))
				{
				  condition.And(DEAL_LAND_INFO._.TRA_AGENCY_CODE.Contain(model.TRA_AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.LENDING_TYPE))
				{
				  condition.And(DEAL_LAND_INFO._.LENDING_TYPE.Contain(model.LENDING_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.LENDING_CODE))
				{
				  condition.And(DEAL_LAND_INFO._.LENDING_CODE.Contain(model.LENDING_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ANNOUNCEMENT_TITLE))
				{
				  condition.And(DEAL_LAND_INFO._.ANNOUNCEMENT_TITLE.Contain(model.ANNOUNCEMENT_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.ANNOUNCEMENT_CONNECT))
				{
				  condition.And(DEAL_LAND_INFO._.ANNOUNCEMENT_CONNECT.Contain(model.ANNOUNCEMENT_CONNECT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(DEAL_LAND_INFO._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}