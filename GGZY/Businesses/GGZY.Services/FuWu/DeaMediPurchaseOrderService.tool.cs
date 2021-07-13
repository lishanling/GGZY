using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class DeaMediPurchaseOrderService : BaseServiceT<DEA_MEDI_PURCHASE_ORDER>
    {
        #region 接口实现
        
		public List<DEA_MEDI_PURCHASE_ORDER> FindList(DEA_MEDI_PURCHASE_ORDER model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<DEA_MEDI_PURCHASE_ORDER> PageList(DEA_MEDI_PURCHASE_ORDER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, DEA_MEDI_PURCHASE_ORDER._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(DEA_MEDI_PURCHASE_ORDER._.M_ID == M_ID);
			
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
        public GeneralResult Edit(DEA_MEDI_PURCHASE_ORDER model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is DEA_MEDI_PURCHASE_ORDER entity)
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
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.PROJNAME=model.PROJNAME;
		entity.DRUGGROUP=model.DRUGGROUP;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.ORDERDETAILID=model.ORDERDETAILID;
		entity.ORDERNAME=model.ORDERNAME;
		entity.HOSPNAME=model.HOSPNAME;
		entity.ORGCODE=model.ORGCODE;
		entity.ORGID=model.ORGID;
		entity.PURPRICE=model.PURPRICE;
		entity.ORDTIME=model.ORDTIME;
		entity.PURSTATUS=model.PURSTATUS;
		entity.BID_CURRENCY=model.BID_CURRENCY;
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
        public GeneralResult Add(DEA_MEDI_PURCHASE_ORDER model)
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
                    Delete(DEA_MEDI_PURCHASE_ORDER._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<DEA_MEDI_PURCHASE_ORDER> model)
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
       	protected WhereClipBuilder ConditionBuilder(DEA_MEDI_PURCHASE_ORDER model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.M_TM==(model.M_TM));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJNAME))
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.PROJNAME.Contain(model.PROJNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGGROUP))
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.DRUGGROUP.Contain(model.DRUGGROUP));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ORDERDETAILID))
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.ORDERDETAILID.Contain(model.ORDERDETAILID));
				}
				if(!string.IsNullOrWhiteSpace(model.ORDERNAME))
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.ORDERNAME.Contain(model.ORDERNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.HOSPNAME))
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.HOSPNAME.Contain(model.HOSPNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ORGCODE))
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.ORGCODE.Contain(model.ORGCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ORGID))
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.ORGID.Contain(model.ORGID));
				}
				if(model.PURPRICE!=null)
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.PURPRICE==(model.PURPRICE));
				}
				if(model.ORDTIME!=null)
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.ORDTIME==(model.ORDTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PURSTATUS))
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.PURSTATUS.Contain(model.PURSTATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_CURRENCY))
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.BID_CURRENCY.Contain(model.BID_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(DEA_MEDI_PURCHASE_ORDER._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}