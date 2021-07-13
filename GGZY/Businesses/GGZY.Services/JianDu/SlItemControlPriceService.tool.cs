using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SlItemControlPriceService : BaseServiceT<SL_ITEM_CONTROL_PRICE>
    {
        #region 接口实现
        
		public List<SL_ITEM_CONTROL_PRICE> FindList(SL_ITEM_CONTROL_PRICE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SL_ITEM_CONTROL_PRICE> PageList(SL_ITEM_CONTROL_PRICE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SL_ITEM_CONTROL_PRICE._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID">数据自增长ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(SL_ITEM_CONTROL_PRICE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(SL_ITEM_CONTROL_PRICE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is SL_ITEM_CONTROL_PRICE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.PROJECT_NUMBER=model.PROJECT_NUMBER;
		entity.PROJECT_LIST_NAME=model.PROJECT_LIST_NAME;
		entity.UNIT=model.UNIT;
		entity.QUANTITIES=model.QUANTITIES;
		entity.UNIVALENT=model.UNIVALENT;
		entity.UNIVALENT_PRICE_UNIT=model.UNIVALENT_PRICE_UNIT;
		entity.TOTLE=model.TOTLE;
		entity.TOTLE_PRICE_UNIT=model.TOTLE_PRICE_UNIT;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
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
        public GeneralResult Add(SL_ITEM_CONTROL_PRICE model)
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
                    Delete(SL_ITEM_CONTROL_PRICE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SL_ITEM_CONTROL_PRICE> model)
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
       	protected WhereClipBuilder ConditionBuilder(SL_ITEM_CONTROL_PRICE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NUMBER))
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.PROJECT_NUMBER.Contain(model.PROJECT_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_LIST_NAME))
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.PROJECT_LIST_NAME.Contain(model.PROJECT_LIST_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIT))
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.UNIT.Contain(model.UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.QUANTITIES))
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.QUANTITIES.Contain(model.QUANTITIES));
				}
				if(model.UNIVALENT!=null)
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.UNIVALENT==(model.UNIVALENT));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIVALENT_PRICE_UNIT))
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.UNIVALENT_PRICE_UNIT.Contain(model.UNIVALENT_PRICE_UNIT));
				}
				if(model.TOTLE!=null)
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.TOTLE==(model.TOTLE));
				}
				if(!string.IsNullOrWhiteSpace(model.TOTLE_PRICE_UNIT))
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.TOTLE_PRICE_UNIT.Contain(model.TOTLE_PRICE_UNIT));
				}
				if(model.M_ID!=null)
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(SL_ITEM_CONTROL_PRICE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}