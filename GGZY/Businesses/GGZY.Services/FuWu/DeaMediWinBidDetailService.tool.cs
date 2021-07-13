using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class DeaMediWinBidDetailService : BaseServiceT<DEA_MEDI_WIN_BID_DETAIL>
    {
        #region 接口实现
        
		public List<DEA_MEDI_WIN_BID_DETAIL> FindList(DEA_MEDI_WIN_BID_DETAIL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<DEA_MEDI_WIN_BID_DETAIL> PageList(DEA_MEDI_WIN_BID_DETAIL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, DEA_MEDI_WIN_BID_DETAIL._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(DEA_MEDI_WIN_BID_DETAIL._.M_ID == M_ID);
			
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
        public GeneralResult Edit(DEA_MEDI_WIN_BID_DETAIL model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is DEA_MEDI_WIN_BID_DETAIL entity)
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
		entity.DRUGFACTOR=model.DRUGFACTOR;
		entity.DRUGUNIT=model.DRUGUNIT;
		entity.DRUGMATERIAL=model.DRUGMATERIAL;
		entity.APPROVALNUM=model.APPROVALNUM;
		entity.FACTORYNAME=model.FACTORYNAME;
		entity.FACTORYID=model.FACTORYID;
		entity.FACTORY_ORGCODE=model.FACTORY_ORGCODE;
		entity.BIDDER_ID=model.BIDDER_ID;
		entity.BIDDER_NAME=model.BIDDER_NAME;
		entity.BIDDER_CODE=model.BIDDER_CODE;
		entity.PREPRICE_BID=model.PREPRICE_BID;
		entity.PRICE_BID=model.PRICE_BID;
		entity.PRICE_RETAIL=model.PRICE_RETAIL;
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
        public GeneralResult Add(DEA_MEDI_WIN_BID_DETAIL model)
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
                    Delete(DEA_MEDI_WIN_BID_DETAIL._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<DEA_MEDI_WIN_BID_DETAIL> model)
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
       	protected WhereClipBuilder ConditionBuilder(DEA_MEDI_WIN_BID_DETAIL model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.M_TM==(model.M_TM));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJNAME))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.PROJNAME.Contain(model.PROJNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGGROUP))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.DRUGGROUP.Contain(model.DRUGGROUP));
				}
				if(!string.IsNullOrWhiteSpace(model.CATAID))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.CATAID.Contain(model.CATAID));
				}
				if(!string.IsNullOrWhiteSpace(model.CATANAME))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.CATANAME.Contain(model.CATANAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGNUM))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.DRUGNUM.Contain(model.DRUGNUM));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGCATA))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.DRUGCATA.Contain(model.DRUGCATA));
				}
				if(!string.IsNullOrWhiteSpace(model.YPID))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.YPID.Contain(model.YPID));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGID))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.DRUGID.Contain(model.DRUGID));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGNAME))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.DRUGNAME.Contain(model.DRUGNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGFORM))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.DRUGFORM.Contain(model.DRUGFORM));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGSPEC))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.DRUGSPEC.Contain(model.DRUGSPEC));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGPREUNIT))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.DRUGPREUNIT.Contain(model.DRUGPREUNIT));
				}
				if(model.DRUGFACTOR!=null)
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.DRUGFACTOR==(model.DRUGFACTOR));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGUNIT))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.DRUGUNIT.Contain(model.DRUGUNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.DRUGMATERIAL))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.DRUGMATERIAL.Contain(model.DRUGMATERIAL));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVALNUM))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.APPROVALNUM.Contain(model.APPROVALNUM));
				}
				if(!string.IsNullOrWhiteSpace(model.FACTORYNAME))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.FACTORYNAME.Contain(model.FACTORYNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.FACTORYID))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.FACTORYID.Contain(model.FACTORYID));
				}
				if(!string.IsNullOrWhiteSpace(model.FACTORY_ORGCODE))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.FACTORY_ORGCODE.Contain(model.FACTORY_ORGCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_ID))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.BIDDER_ID.Contain(model.BIDDER_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_NAME))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.BIDDER_NAME.Contain(model.BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_CODE))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.BIDDER_CODE.Contain(model.BIDDER_CODE));
				}
				if(model.PREPRICE_BID!=null)
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.PREPRICE_BID==(model.PREPRICE_BID));
				}
				if(model.PRICE_BID!=null)
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.PRICE_BID==(model.PRICE_BID));
				}
				if(model.PRICE_RETAIL!=null)
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.PRICE_RETAIL==(model.PRICE_RETAIL));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(DEA_MEDI_WIN_BID_DETAIL._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}