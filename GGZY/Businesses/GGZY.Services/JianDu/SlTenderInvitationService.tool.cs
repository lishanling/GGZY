using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SlTenderInvitationService : BaseServiceT<SL_TENDER_INVITATION>
    {
        #region 接口实现
        
		public List<SL_TENDER_INVITATION> FindList(SL_TENDER_INVITATION model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SL_TENDER_INVITATION> PageList(SL_TENDER_INVITATION model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SL_TENDER_INVITATION._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(SL_TENDER_INVITATION._.M_ID == M_ID);
			
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
        public GeneralResult Edit(SL_TENDER_INVITATION model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is SL_TENDER_INVITATION entity)
	{		
		entity.Attach();
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.BID_QUALIFICATION=model.BID_QUALIFICATION;
		entity.BIDDER_NAME=model.BIDDER_NAME;
		entity.BIDDER_CODE_TYPE=model.BIDDER_CODE_TYPE;
		entity.BIDDER_CODE=model.BIDDER_CODE;
		entity.BIDDER_ROLE=model.BIDDER_ROLE;
		entity.TENDER_DOC_GET_TIME=model.TENDER_DOC_GET_TIME;
		entity.TENDER_DOC_GET_METHOD=model.TENDER_DOC_GET_METHOD;
		entity.BID_DOC_REFER_END_TIME=model.BID_DOC_REFER_END_TIME;
		entity.BID_DOC_REFER_METHOD=model.BID_DOC_REFER_METHOD;
		entity.BID_INVITE_END_TIME=model.BID_INVITE_END_TIME;
		entity.BID_INVITE_ISSUE_TIME=model.BID_INVITE_ISSUE_TIME;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
		entity.BID_INVITE_ISSUE_NATURE=model.BID_INVITE_ISSUE_NATURE;
		entity.DOC_GET_START_TIME=model.DOC_GET_START_TIME;
		entity.DOC_GET_END_TIME=model.DOC_GET_END_TIME;
		entity.BULLETIN_DUTY=model.BULLETIN_DUTY;
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
        public GeneralResult Add(SL_TENDER_INVITATION model)
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
                    Delete(SL_TENDER_INVITATION._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SL_TENDER_INVITATION> model)
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
       	protected WhereClipBuilder ConditionBuilder(SL_TENDER_INVITATION model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(SL_TENDER_INVITATION._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(SL_TENDER_INVITATION._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_QUALIFICATION))
				{
				  condition.And(SL_TENDER_INVITATION._.BID_QUALIFICATION.Contain(model.BID_QUALIFICATION));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_NAME))
				{
				  condition.And(SL_TENDER_INVITATION._.BIDDER_NAME.Contain(model.BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_CODE_TYPE))
				{
				  condition.And(SL_TENDER_INVITATION._.BIDDER_CODE_TYPE.Contain(model.BIDDER_CODE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_CODE))
				{
				  condition.And(SL_TENDER_INVITATION._.BIDDER_CODE.Contain(model.BIDDER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_ROLE))
				{
				  condition.And(SL_TENDER_INVITATION._.BIDDER_ROLE.Contain(model.BIDDER_ROLE));
				}
				if(model.TENDER_DOC_GET_TIME!=null)
				{
				  condition.And(SL_TENDER_INVITATION._.TENDER_DOC_GET_TIME==(model.TENDER_DOC_GET_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_DOC_GET_METHOD))
				{
				  condition.And(SL_TENDER_INVITATION._.TENDER_DOC_GET_METHOD.Contain(model.TENDER_DOC_GET_METHOD));
				}
				if(model.BID_DOC_REFER_END_TIME!=null)
				{
				  condition.And(SL_TENDER_INVITATION._.BID_DOC_REFER_END_TIME==(model.BID_DOC_REFER_END_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_DOC_REFER_METHOD))
				{
				  condition.And(SL_TENDER_INVITATION._.BID_DOC_REFER_METHOD.Contain(model.BID_DOC_REFER_METHOD));
				}
				if(model.BID_INVITE_END_TIME!=null)
				{
				  condition.And(SL_TENDER_INVITATION._.BID_INVITE_END_TIME==(model.BID_INVITE_END_TIME));
				}
				if(model.BID_INVITE_ISSUE_TIME!=null)
				{
				  condition.And(SL_TENDER_INVITATION._.BID_INVITE_ISSUE_TIME==(model.BID_INVITE_ISSUE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(SL_TENDER_INVITATION._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(SL_TENDER_INVITATION._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(SL_TENDER_INVITATION._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(SL_TENDER_INVITATION._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(SL_TENDER_INVITATION._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(SL_TENDER_INVITATION._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(SL_TENDER_INVITATION._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(SL_TENDER_INVITATION._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(SL_TENDER_INVITATION._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_INVITE_ISSUE_NATURE))
				{
				  condition.And(SL_TENDER_INVITATION._.BID_INVITE_ISSUE_NATURE.Contain(model.BID_INVITE_ISSUE_NATURE));
				}
				if(model.DOC_GET_START_TIME!=null)
				{
				  condition.And(SL_TENDER_INVITATION._.DOC_GET_START_TIME==(model.DOC_GET_START_TIME));
				}
				if(model.DOC_GET_END_TIME!=null)
				{
				  condition.And(SL_TENDER_INVITATION._.DOC_GET_END_TIME==(model.DOC_GET_END_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETIN_DUTY))
				{
				  condition.And(SL_TENDER_INVITATION._.BULLETIN_DUTY.Contain(model.BULLETIN_DUTY));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(SL_TENDER_INVITATION._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(SL_TENDER_INVITATION._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(SL_TENDER_INVITATION._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}