using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class QualiInqueryClariService : BaseServiceT<QUALI_INQUERY_CLARI>
    {
        #region 接口实现
        
		public List<QUALI_INQUERY_CLARI> FindList(QUALI_INQUERY_CLARI model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<QUALI_INQUERY_CLARI> PageList(QUALI_INQUERY_CLARI model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, QUALI_INQUERY_CLARI._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(QUALI_INQUERY_CLARI._.M_ID == M_ID);
			
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
        public GeneralResult Edit(QUALI_INQUERY_CLARI model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is QUALI_INQUERY_CLARI entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.UNIFIED_DEAL_CODES=model.UNIFIED_DEAL_CODES;
		entity.DOC_CODE=model.DOC_CODE;
		entity.APPLICANT_QUALIFICATIONS=model.APPLICANT_QUALIFICATIONS;
		entity.APPLICATION_VALID_TIME=model.APPLICATION_VALID_TIME;
		entity.DOC_SUBMIT_END_TIME=model.DOC_SUBMIT_END_TIME;
		entity.DOC_SUBMIT_METHOD=model.DOC_SUBMIT_METHOD;
		entity.DOC_OPEN_TIME=model.DOC_OPEN_TIME;
		entity.DOC_OPEN_METHOD=model.DOC_OPEN_METHOD;
		entity.EVALUATION_METHOD=model.EVALUATION_METHOD;
		entity.CLARIFY_CONTENT=model.CLARIFY_CONTENT;
		entity.SUBMIT_TIME=model.SUBMIT_TIME;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.DOC_NAME=model.DOC_NAME;
		entity.URL=model.URL;
		entity.M_ID=model.M_ID;
		entity.M_CREATOR=model.M_CREATOR;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.IS_POSTPONE=model.IS_POSTPONE;
		entity.POST_OPEN_TIME=model.POST_OPEN_TIME;
		entity.POST_OPEN_ADDRESS=model.POST_OPEN_ADDRESS;
		entity.BID_OPEN_METHOD=model.BID_OPEN_METHOD;
		entity.QUAL_TYPE=model.QUAL_TYPE;
		entity.TENDER_CLARIFY_CONTENT=model.TENDER_CLARIFY_CONTENT;
		entity.TENDER_SUBMIT_TIME=model.TENDER_SUBMIT_TIME;
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
        public GeneralResult Add(QUALI_INQUERY_CLARI model)
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
                    Delete(QUALI_INQUERY_CLARI._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<QUALI_INQUERY_CLARI> model)
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
       	protected WhereClipBuilder ConditionBuilder(QUALI_INQUERY_CLARI model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(QUALI_INQUERY_CLARI._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(QUALI_INQUERY_CLARI._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODES))
				{
				  condition.And(QUALI_INQUERY_CLARI._.UNIFIED_DEAL_CODES.Contain(model.UNIFIED_DEAL_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.DOC_CODE))
				{
				  condition.And(QUALI_INQUERY_CLARI._.DOC_CODE.Contain(model.DOC_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.APPLICANT_QUALIFICATIONS))
				{
				  condition.And(QUALI_INQUERY_CLARI._.APPLICANT_QUALIFICATIONS.Contain(model.APPLICANT_QUALIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.APPLICATION_VALID_TIME))
				{
				  condition.And(QUALI_INQUERY_CLARI._.APPLICATION_VALID_TIME.Contain(model.APPLICATION_VALID_TIME));
				}
				if(model.DOC_SUBMIT_END_TIME!=null)
				{
				  condition.And(QUALI_INQUERY_CLARI._.DOC_SUBMIT_END_TIME==(model.DOC_SUBMIT_END_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.DOC_SUBMIT_METHOD))
				{
				  condition.And(QUALI_INQUERY_CLARI._.DOC_SUBMIT_METHOD.Contain(model.DOC_SUBMIT_METHOD));
				}
				if(model.DOC_OPEN_TIME!=null)
				{
				  condition.And(QUALI_INQUERY_CLARI._.DOC_OPEN_TIME==(model.DOC_OPEN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.DOC_OPEN_METHOD))
				{
				  condition.And(QUALI_INQUERY_CLARI._.DOC_OPEN_METHOD.Contain(model.DOC_OPEN_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATION_METHOD))
				{
				  condition.And(QUALI_INQUERY_CLARI._.EVALUATION_METHOD.Contain(model.EVALUATION_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.CLARIFY_CONTENT))
				{
				  condition.And(QUALI_INQUERY_CLARI._.CLARIFY_CONTENT.Contain(model.CLARIFY_CONTENT));
				}
				if(model.SUBMIT_TIME!=null)
				{
				  condition.And(QUALI_INQUERY_CLARI._.SUBMIT_TIME==(model.SUBMIT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(QUALI_INQUERY_CLARI._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(QUALI_INQUERY_CLARI._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(QUALI_INQUERY_CLARI._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(QUALI_INQUERY_CLARI._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(QUALI_INQUERY_CLARI._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(QUALI_INQUERY_CLARI._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.DOC_NAME))
				{
				  condition.And(QUALI_INQUERY_CLARI._.DOC_NAME.Contain(model.DOC_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(QUALI_INQUERY_CLARI._.URL.Contain(model.URL));
				}
				if(model.M_ID!=null)
				{
				  condition.And(QUALI_INQUERY_CLARI._.M_ID==(model.M_ID));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(QUALI_INQUERY_CLARI._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(QUALI_INQUERY_CLARI._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(QUALI_INQUERY_CLARI._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(QUALI_INQUERY_CLARI._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_POSTPONE))
				{
				  condition.And(QUALI_INQUERY_CLARI._.IS_POSTPONE.Contain(model.IS_POSTPONE));
				}
				if(model.POST_OPEN_TIME!=null)
				{
				  condition.And(QUALI_INQUERY_CLARI._.POST_OPEN_TIME==(model.POST_OPEN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.POST_OPEN_ADDRESS))
				{
				  condition.And(QUALI_INQUERY_CLARI._.POST_OPEN_ADDRESS.Contain(model.POST_OPEN_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_OPEN_METHOD))
				{
				  condition.And(QUALI_INQUERY_CLARI._.BID_OPEN_METHOD.Contain(model.BID_OPEN_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.QUAL_TYPE))
				{
				  condition.And(QUALI_INQUERY_CLARI._.QUAL_TYPE.Contain(model.QUAL_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_CLARIFY_CONTENT))
				{
				  condition.And(QUALI_INQUERY_CLARI._.TENDER_CLARIFY_CONTENT.Contain(model.TENDER_CLARIFY_CONTENT));
				}
				if(model.TENDER_SUBMIT_TIME!=null)
				{
				  condition.And(QUALI_INQUERY_CLARI._.TENDER_SUBMIT_TIME==(model.TENDER_SUBMIT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(QUALI_INQUERY_CLARI._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(QUALI_INQUERY_CLARI._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(QUALI_INQUERY_CLARI._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}