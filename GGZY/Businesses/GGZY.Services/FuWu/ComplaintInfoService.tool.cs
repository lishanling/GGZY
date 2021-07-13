using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ComplaintInfoService : BaseServiceT<COMPLAINT_INFO>
    {
        #region 接口实现
        
		public List<COMPLAINT_INFO> FindList(COMPLAINT_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<COMPLAINT_INFO> PageList(COMPLAINT_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, COMPLAINT_INFO._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(COMPLAINT_INFO._.M_ID == M_ID);
			
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
        public GeneralResult Edit(COMPLAINT_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is COMPLAINT_INFO entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_NAME=model.TENDER_PROJECT_NAME;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.BID_SECTION_NAME=model.BID_SECTION_NAME;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.COMPLAINT_NAME=model.COMPLAINT_NAME;
		entity.COMPLAINT_PHONE=model.COMPLAINT_PHONE;
		entity.COMPLAINT_MAIL=model.COMPLAINT_MAIL;
		entity.COMPLAINTED_BODY_NAME=model.COMPLAINTED_BODY_NAME;
		entity.COMPLAINTED_BODY_TYPE=model.COMPLAINTED_BODY_TYPE;
		entity.COMPLAINTED_BODY_CODE=model.COMPLAINTED_BODY_CODE;
		entity.DISSENT_REASON=model.DISSENT_REASON;
		entity.COMPLAINT_CONTENT=model.COMPLAINT_CONTENT;
		entity.COMPLAINT_DATE=model.COMPLAINT_DATE;
		entity.ACCEPT_DATE=model.ACCEPT_DATE;
		entity.HANDLE_RESULT=model.HANDLE_RESULT;
		entity.HANDLE_BASIS=model.HANDLE_BASIS;
		entity.HANDLE_DATE=model.HANDLE_DATE;
		entity.CONFINED_ACTION=model.CONFINED_ACTION;
		entity.START_DATE=model.START_DATE;
		entity.END_DATE=model.END_DATE;
		entity.DEALING_UNIT=model.DEALING_UNIT;
		entity.ENTER_CREDIT_PLAT=model.ENTER_CREDIT_PLAT;
		entity.SIGNATURE=model.SIGNATURE;
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
        public GeneralResult Add(COMPLAINT_INFO model)
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
                    Delete(COMPLAINT_INFO._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<COMPLAINT_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(COMPLAINT_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(COMPLAINT_INFO._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(COMPLAINT_INFO._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(COMPLAINT_INFO._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_NAME))
				{
				  condition.And(COMPLAINT_INFO._.BID_SECTION_NAME.Contain(model.BID_SECTION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(COMPLAINT_INFO._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_NAME))
				{
				  condition.And(COMPLAINT_INFO._.COMPLAINT_NAME.Contain(model.COMPLAINT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_PHONE))
				{
				  condition.And(COMPLAINT_INFO._.COMPLAINT_PHONE.Contain(model.COMPLAINT_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_MAIL))
				{
				  condition.And(COMPLAINT_INFO._.COMPLAINT_MAIL.Contain(model.COMPLAINT_MAIL));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINTED_BODY_NAME))
				{
				  condition.And(COMPLAINT_INFO._.COMPLAINTED_BODY_NAME.Contain(model.COMPLAINTED_BODY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINTED_BODY_TYPE))
				{
				  condition.And(COMPLAINT_INFO._.COMPLAINTED_BODY_TYPE.Contain(model.COMPLAINTED_BODY_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINTED_BODY_CODE))
				{
				  condition.And(COMPLAINT_INFO._.COMPLAINTED_BODY_CODE.Contain(model.COMPLAINTED_BODY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.DISSENT_REASON))
				{
				  condition.And(COMPLAINT_INFO._.DISSENT_REASON.Contain(model.DISSENT_REASON));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_CONTENT))
				{
				  condition.And(COMPLAINT_INFO._.COMPLAINT_CONTENT.Contain(model.COMPLAINT_CONTENT));
				}
				if(model.COMPLAINT_DATE!=null)
				{
				  condition.And(COMPLAINT_INFO._.COMPLAINT_DATE==(model.COMPLAINT_DATE));
				}
				if(model.ACCEPT_DATE!=null)
				{
				  condition.And(COMPLAINT_INFO._.ACCEPT_DATE==(model.ACCEPT_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.HANDLE_RESULT))
				{
				  condition.And(COMPLAINT_INFO._.HANDLE_RESULT.Contain(model.HANDLE_RESULT));
				}
				if(!string.IsNullOrWhiteSpace(model.HANDLE_BASIS))
				{
				  condition.And(COMPLAINT_INFO._.HANDLE_BASIS.Contain(model.HANDLE_BASIS));
				}
				if(model.HANDLE_DATE!=null)
				{
				  condition.And(COMPLAINT_INFO._.HANDLE_DATE==(model.HANDLE_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONFINED_ACTION))
				{
				  condition.And(COMPLAINT_INFO._.CONFINED_ACTION.Contain(model.CONFINED_ACTION));
				}
				if(model.START_DATE!=null)
				{
				  condition.And(COMPLAINT_INFO._.START_DATE==(model.START_DATE));
				}
				if(model.END_DATE!=null)
				{
				  condition.And(COMPLAINT_INFO._.END_DATE==(model.END_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.DEALING_UNIT))
				{
				  condition.And(COMPLAINT_INFO._.DEALING_UNIT.Contain(model.DEALING_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.ENTER_CREDIT_PLAT))
				{
				  condition.And(COMPLAINT_INFO._.ENTER_CREDIT_PLAT.Contain(model.ENTER_CREDIT_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.SIGNATURE))
				{
				  condition.And(COMPLAINT_INFO._.SIGNATURE.Contain(model.SIGNATURE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(COMPLAINT_INFO._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(COMPLAINT_INFO._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(COMPLAINT_INFO._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(COMPLAINT_INFO._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(COMPLAINT_INFO._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(COMPLAINT_INFO._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(COMPLAINT_INFO._.M_ID==(model.M_ID));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(COMPLAINT_INFO._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(COMPLAINT_INFO._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(COMPLAINT_INFO._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(COMPLAINT_INFO._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}