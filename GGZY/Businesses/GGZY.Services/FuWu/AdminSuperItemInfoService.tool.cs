using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class AdminSuperItemInfoService : BaseServiceT<ADMIN_SUPER_ITEM_INFO>
    {
        #region 接口实现
        
		public List<ADMIN_SUPER_ITEM_INFO> FindList(ADMIN_SUPER_ITEM_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ADMIN_SUPER_ITEM_INFO> PageList(ADMIN_SUPER_ITEM_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ADMIN_SUPER_ITEM_INFO._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(ADMIN_SUPER_ITEM_INFO._.M_ID == M_ID);
			
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
        public GeneralResult Edit(ADMIN_SUPER_ITEM_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is ADMIN_SUPER_ITEM_INFO entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_NAME=model.TENDER_PROJECT_NAME;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.BID_SECTION_NAME=model.BID_SECTION_NAME;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.PROJECT_TYPE=model.PROJECT_TYPE;
		entity.TRADE_TYPE=model.TRADE_TYPE;
		entity.TRADE_STEP=model.TRADE_STEP;
		entity.APPROVAL_PROJECT=model.APPROVAL_PROJECT;
		entity.GOVERMENT=model.GOVERMENT;
		entity.AREA=model.AREA;
		entity.LAW=model.LAW;
		entity.IS_PAST=model.IS_PAST;
		entity.CONTENT=model.CONTENT;
		entity.SIGNATURE=model.SIGNATURE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.APPROVAL_DATE=model.APPROVAL_DATE;
		entity.M_ID=model.M_ID;
		entity.M_ATT_REGULATIONS_DOC=model.M_ATT_REGULATIONS_DOC;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
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
        public GeneralResult Add(ADMIN_SUPER_ITEM_INFO model)
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
                    Delete(ADMIN_SUPER_ITEM_INFO._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ADMIN_SUPER_ITEM_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(ADMIN_SUPER_ITEM_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_NAME))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.BID_SECTION_NAME.Contain(model.BID_SECTION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.PROJECT_TYPE.Contain(model.PROJECT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_TYPE))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.TRADE_TYPE.Contain(model.TRADE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_STEP))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.TRADE_STEP.Contain(model.TRADE_STEP));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVAL_PROJECT))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.APPROVAL_PROJECT.Contain(model.APPROVAL_PROJECT));
				}
				if(!string.IsNullOrWhiteSpace(model.GOVERMENT))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.GOVERMENT.Contain(model.GOVERMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.AREA))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.AREA.Contain(model.AREA));
				}
				if(!string.IsNullOrWhiteSpace(model.LAW))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.LAW.Contain(model.LAW));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_PAST))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.IS_PAST.Contain(model.IS_PAST));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTENT))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.CONTENT.Contain(model.CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.SIGNATURE))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.SIGNATURE.Contain(model.SIGNATURE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.M_TM==(model.M_TM));
				}
				if(model.APPROVAL_DATE!=null)
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.APPROVAL_DATE==(model.APPROVAL_DATE));
				}
				if(model.M_ID!=null)
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_REGULATIONS_DOC))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.M_ATT_REGULATIONS_DOC.Contain(model.M_ATT_REGULATIONS_DOC));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(ADMIN_SUPER_ITEM_INFO._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}