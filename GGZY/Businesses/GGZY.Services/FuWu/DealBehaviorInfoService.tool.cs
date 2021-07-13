using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class DealBehaviorInfoService : BaseServiceT<DEAL_BEHAVIOR_INFO>
    {
        #region 接口实现
        
		public List<DEAL_BEHAVIOR_INFO> FindList(DEAL_BEHAVIOR_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<DEAL_BEHAVIOR_INFO> PageList(DEAL_BEHAVIOR_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, DEAL_BEHAVIOR_INFO._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(DEAL_BEHAVIOR_INFO._.M_ID == M_ID);
			
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
        public GeneralResult Edit(DEAL_BEHAVIOR_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is DEAL_BEHAVIOR_INFO entity)
	{		
		entity.Attach();
		entity.ANNOUNCEMENT_GUID=model.ANNOUNCEMENT_GUID;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.ANNOUNCEMENT_TITLE=model.ANNOUNCEMENT_TITLE;
		entity.ANNOUNCEMENT_CONNECT=model.ANNOUNCEMENT_CONNECT;
		entity.LAND_DISTRICT=model.LAND_DISTRICT;
		entity.URL=model.URL;
		entity.END_DATE=model.END_DATE;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.PUBLISHING_TIME=model.PUBLISHING_TIME;
		entity.SUPPLY_TYPE=model.SUPPLY_TYPE;
		entity.CHANGE_TIME=model.CHANGE_TIME;
		entity.RETREAT_TIME=model.RETREAT_TIME;
		entity.ANNOUNCEMENT_UNIT=model.ANNOUNCEMENT_UNIT;
		entity.ANNOUNCEMENT_START_TIME=model.ANNOUNCEMENT_START_TIME;
		entity.ANNOUNCEMENT_DEADLINE=model.ANNOUNCEMENT_DEADLINE;
		entity.FIELD_NUM=model.FIELD_NUM;
		entity.LISTING_START_TIME=model.LISTING_START_TIME;
		entity.LISTING_DEADLINE=model.LISTING_DEADLINE;
		entity.LISTING_TYPE=model.LISTING_TYPE;
		entity.ANNOUNCEMENT_TYPE=model.ANNOUNCEMENT_TYPE;
		entity.LIAISON_UNIT=model.LIAISON_UNIT;
		entity.UNIT_ADDRESS=model.UNIT_ADDRESS;
		entity.ZIP_CODE=model.ZIP_CODE;
		entity.CONTACT_PERSON=model.CONTACT_PERSON;
		entity.CONTACT_NUMBER=model.CONTACT_NUMBER;
		entity.EMAIL=model.EMAIL;
		entity.CANCEL_REASON=model.CANCEL_REASON;
		entity.ANNOUNCEMENT_CODE=model.ANNOUNCEMENT_CODE;
		entity.ATTACHMENT_SET_CODE=model.ATTACHMENT_SET_CODE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.LAND_PROJECT_NAME=model.LAND_PROJECT_NAME;
		entity.TRA_PLACE_CODE=model.TRA_PLACE_CODE;
		entity.TRA_AGENCY_NAME=model.TRA_AGENCY_NAME;
		entity.TRA_AGENCY_CODE=model.TRA_AGENCY_CODE;
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
        public GeneralResult Add(DEAL_BEHAVIOR_INFO model)
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
                    Delete(DEAL_BEHAVIOR_INFO._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<DEAL_BEHAVIOR_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(DEAL_BEHAVIOR_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ANNOUNCEMENT_GUID))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.ANNOUNCEMENT_GUID.Contain(model.ANNOUNCEMENT_GUID));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ANNOUNCEMENT_TITLE))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.ANNOUNCEMENT_TITLE.Contain(model.ANNOUNCEMENT_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.ANNOUNCEMENT_CONNECT))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.ANNOUNCEMENT_CONNECT.Contain(model.ANNOUNCEMENT_CONNECT));
				}
				if(!string.IsNullOrWhiteSpace(model.LAND_DISTRICT))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.LAND_DISTRICT.Contain(model.LAND_DISTRICT));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.URL.Contain(model.URL));
				}
				if(model.END_DATE!=null)
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.END_DATE==(model.END_DATE));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(model.PUBLISHING_TIME!=null)
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.PUBLISHING_TIME==(model.PUBLISHING_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPPLY_TYPE))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.SUPPLY_TYPE.Contain(model.SUPPLY_TYPE));
				}
				if(model.CHANGE_TIME!=null)
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.CHANGE_TIME==(model.CHANGE_TIME));
				}
				if(model.RETREAT_TIME!=null)
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.RETREAT_TIME==(model.RETREAT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.ANNOUNCEMENT_UNIT))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.ANNOUNCEMENT_UNIT.Contain(model.ANNOUNCEMENT_UNIT));
				}
				if(model.ANNOUNCEMENT_START_TIME!=null)
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.ANNOUNCEMENT_START_TIME==(model.ANNOUNCEMENT_START_TIME));
				}
				if(model.ANNOUNCEMENT_DEADLINE!=null)
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.ANNOUNCEMENT_DEADLINE==(model.ANNOUNCEMENT_DEADLINE));
				}
				if(model.FIELD_NUM!=null)
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.FIELD_NUM==(model.FIELD_NUM));
				}
				if(model.LISTING_START_TIME!=null)
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.LISTING_START_TIME==(model.LISTING_START_TIME));
				}
				if(model.LISTING_DEADLINE!=null)
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.LISTING_DEADLINE==(model.LISTING_DEADLINE));
				}
				if(!string.IsNullOrWhiteSpace(model.LISTING_TYPE))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.LISTING_TYPE.Contain(model.LISTING_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.ANNOUNCEMENT_TYPE))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.ANNOUNCEMENT_TYPE.Contain(model.ANNOUNCEMENT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.LIAISON_UNIT))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.LIAISON_UNIT.Contain(model.LIAISON_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIT_ADDRESS))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.UNIT_ADDRESS.Contain(model.UNIT_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.ZIP_CODE))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.ZIP_CODE.Contain(model.ZIP_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTACT_PERSON))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.CONTACT_PERSON.Contain(model.CONTACT_PERSON));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTACT_NUMBER))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.CONTACT_NUMBER.Contain(model.CONTACT_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.EMAIL))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.EMAIL.Contain(model.EMAIL));
				}
				if(!string.IsNullOrWhiteSpace(model.CANCEL_REASON))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.CANCEL_REASON.Contain(model.CANCEL_REASON));
				}
				if(!string.IsNullOrWhiteSpace(model.ANNOUNCEMENT_CODE))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.ANNOUNCEMENT_CODE.Contain(model.ANNOUNCEMENT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTACHMENT_SET_CODE))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.ATTACHMENT_SET_CODE.Contain(model.ATTACHMENT_SET_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.M_ID==(model.M_ID));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.LAND_PROJECT_NAME))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.LAND_PROJECT_NAME.Contain(model.LAND_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_PLACE_CODE))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.TRA_PLACE_CODE.Contain(model.TRA_PLACE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_AGENCY_NAME))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.TRA_AGENCY_NAME.Contain(model.TRA_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_AGENCY_CODE))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.TRA_AGENCY_CODE.Contain(model.TRA_AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(DEAL_BEHAVIOR_INFO._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}