using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class DeaMediNetPurchaseDetailService : BaseServiceT<DEA_MEDI_NET_PURCHASE_DETAIL>
    {
        #region 接口实现
        
		public List<DEA_MEDI_NET_PURCHASE_DETAIL> FindList(DEA_MEDI_NET_PURCHASE_DETAIL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<DEA_MEDI_NET_PURCHASE_DETAIL> PageList(DEA_MEDI_NET_PURCHASE_DETAIL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, DEA_MEDI_NET_PURCHASE_DETAIL._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.M_ID == M_ID);
			
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
        public GeneralResult Edit(DEA_MEDI_NET_PURCHASE_DETAIL model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is DEA_MEDI_NET_PURCHASE_DETAIL entity)
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
		entity.CATAID=model.CATAID;
		entity.CATANAME=model.CATANAME;
		entity.DRUGNUM=model.DRUGNUM;
		entity.DRUGCATA=model.DRUGCATA;
		entity.YPID=model.YPID;
		entity.DRUGID=model.DRUGID;
		entity.DRUGNAME=model.DRUGNAME;
		entity.DRUGFORM=model.DRUGFORM;
		entity.DRUGSPEC=model.DRUGSPEC;
		entity.DRUGPREUNIT=model.DRUGPREUNIT;
		entity.FACTORYNAME=model.FACTORYNAME;
		entity.FACTORYID=model.FACTORYID;
		entity.FACTORY_ORGCODE=model.FACTORY_ORGCODE;
		entity.COMPANY_ID_GW=model.COMPANY_ID_GW;
		entity.COMPANY_NAME_GW=model.COMPANY_NAME_GW;
		entity.COMPANY_CODE_GW=model.COMPANY_CODE_GW;
		entity.PRICE_GW=model.PRICE_GW;
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
        public GeneralResult Add(DEA_MEDI_NET_PURCHASE_DETAIL model)
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
                    Delete(DEA_MEDI_NET_PURCHASE_DETAIL._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<DEA_MEDI_NET_PURCHASE_DETAIL> model)
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
       	protected WhereClipBuilder ConditionBuilder(DEA_MEDI_NET_PURCHASE_DETAIL model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.M_TM==(model.M_TM));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJNAME))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.PROJNAME.Contain(model.PROJNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGGROUP))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.DRUGGROUP.Contain(model.DRUGGROUP));
				}
				if(!string.IsNullOrWhiteSpace(model.CATAID))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.CATAID.Contain(model.CATAID));
				}
				if(!string.IsNullOrWhiteSpace(model.CATANAME))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.CATANAME.Contain(model.CATANAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGNUM))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.DRUGNUM.Contain(model.DRUGNUM));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGCATA))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.DRUGCATA.Contain(model.DRUGCATA));
				}
				if(!string.IsNullOrWhiteSpace(model.YPID))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.YPID.Contain(model.YPID));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGID))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.DRUGID.Contain(model.DRUGID));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGNAME))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.DRUGNAME.Contain(model.DRUGNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGFORM))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.DRUGFORM.Contain(model.DRUGFORM));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGSPEC))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.DRUGSPEC.Contain(model.DRUGSPEC));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGPREUNIT))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.DRUGPREUNIT.Contain(model.DRUGPREUNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.FACTORYNAME))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.FACTORYNAME.Contain(model.FACTORYNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.FACTORYID))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.FACTORYID.Contain(model.FACTORYID));
				}
				if(!string.IsNullOrWhiteSpace(model.FACTORY_ORGCODE))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.FACTORY_ORGCODE.Contain(model.FACTORY_ORGCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANY_ID_GW))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.COMPANY_ID_GW.Contain(model.COMPANY_ID_GW));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANY_NAME_GW))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.COMPANY_NAME_GW.Contain(model.COMPANY_NAME_GW));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANY_CODE_GW))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.COMPANY_CODE_GW.Contain(model.COMPANY_CODE_GW));
				}
				if(model.PRICE_GW!=null)
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.PRICE_GW==(model.PRICE_GW));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(DEA_MEDI_NET_PURCHASE_DETAIL._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}