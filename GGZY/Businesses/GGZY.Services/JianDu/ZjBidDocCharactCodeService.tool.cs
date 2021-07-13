using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ZjBidDocCharactCodeService : BaseServiceT<ZJ_BID_DOC_CHARACT_CODE>
    {
        #region 接口实现
        
		public List<ZJ_BID_DOC_CHARACT_CODE> FindList(ZJ_BID_DOC_CHARACT_CODE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJ_BID_DOC_CHARACT_CODE> PageList(ZJ_BID_DOC_CHARACT_CODE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJ_BID_DOC_CHARACT_CODE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(ZJ_BID_DOC_CHARACT_CODE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(ZJ_BID_DOC_CHARACT_CODE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is ZJ_BID_DOC_CHARACT_CODE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.UNIFIED_DEAL_CODES=model.UNIFIED_DEAL_CODES;
		entity.BIDDER_NAME=model.BIDDER_NAME;
		entity.BIDDER_CODE_TYPE=model.BIDDER_CODE_TYPE;
		entity.BIDDER_ORG_CODE=model.BIDDER_ORG_CODE;
		entity.BIDDER_ROLE=model.BIDDER_ROLE;
		entity.BID_DOCUMENT_NAME=model.BID_DOCUMENT_NAME;
		entity.BID_DOCUMENT_SIDE=model.BID_DOCUMENT_SIDE;
		entity.BID_DOCUMENT_MD5=model.BID_DOCUMENT_MD5;
		entity.TENDER_DOC_SUBMITTIME=model.TENDER_DOC_SUBMITTIME;
		entity.CPU_ID=model.CPU_ID;
		entity.HARD_DISK_SERIAL_NUMBER=model.HARD_DISK_SERIAL_NUMBER;
		entity.MEMORY_SERIAL_NUMBER=model.MEMORY_SERIAL_NUMBER;
		entity.NET_ID=model.NET_ID;
		entity.MAC_ADDRESS=model.MAC_ADDRESS;
		entity.TENDER_DOCUMENTS_URL=model.TENDER_DOCUMENTS_URL;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_TM=model.M_TM;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.VALUATION_XML=model.VALUATION_XML;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.MAKE_TOOL_XML=model.MAKE_TOOL_XML;
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
        public GeneralResult Add(ZJ_BID_DOC_CHARACT_CODE model)
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
                    Delete(ZJ_BID_DOC_CHARACT_CODE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJ_BID_DOC_CHARACT_CODE> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJ_BID_DOC_CHARACT_CODE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODES))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.UNIFIED_DEAL_CODES.Contain(model.UNIFIED_DEAL_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_NAME))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.BIDDER_NAME.Contain(model.BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_CODE_TYPE))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.BIDDER_CODE_TYPE.Contain(model.BIDDER_CODE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_ORG_CODE))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.BIDDER_ORG_CODE.Contain(model.BIDDER_ORG_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_ROLE))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.BIDDER_ROLE.Contain(model.BIDDER_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_DOCUMENT_NAME))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.BID_DOCUMENT_NAME.Contain(model.BID_DOCUMENT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_DOCUMENT_SIDE))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.BID_DOCUMENT_SIDE.Contain(model.BID_DOCUMENT_SIDE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_DOCUMENT_MD5))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.BID_DOCUMENT_MD5.Contain(model.BID_DOCUMENT_MD5));
				}
				if(model.TENDER_DOC_SUBMITTIME!=null)
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.TENDER_DOC_SUBMITTIME==(model.TENDER_DOC_SUBMITTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.CPU_ID))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.CPU_ID.Contain(model.CPU_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.HARD_DISK_SERIAL_NUMBER))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.HARD_DISK_SERIAL_NUMBER.Contain(model.HARD_DISK_SERIAL_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.MEMORY_SERIAL_NUMBER))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.MEMORY_SERIAL_NUMBER.Contain(model.MEMORY_SERIAL_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.NET_ID))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.NET_ID.Contain(model.NET_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.MAC_ADDRESS))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.MAC_ADDRESS.Contain(model.MAC_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_DOCUMENTS_URL))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.TENDER_DOCUMENTS_URL.Contain(model.TENDER_DOCUMENTS_URL));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_TM!=null)
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.M_TM==(model.M_TM));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.VALUATION_XML))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.VALUATION_XML.Contain(model.VALUATION_XML));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.MAKE_TOOL_XML))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.MAKE_TOOL_XML.Contain(model.MAKE_TOOL_XML));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(ZJ_BID_DOC_CHARACT_CODE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}