using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TenderCandidateAnnounceService : BaseServiceT<TENDER_CANDIDATE_ANNOUNCE>
    {
        #region 接口实现
        
		public List<TENDER_CANDIDATE_ANNOUNCE> FindList(TENDER_CANDIDATE_ANNOUNCE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TENDER_CANDIDATE_ANNOUNCE> PageList(TENDER_CANDIDATE_ANNOUNCE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, TENDER_CANDIDATE_ANNOUNCE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(TENDER_CANDIDATE_ANNOUNCE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(TENDER_CANDIDATE_ANNOUNCE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is TENDER_CANDIDATE_ANNOUNCE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.PUBLICITY_NAME=model.PUBLICITY_NAME;
		entity.PUBLICITY_CONTENT=model.PUBLICITY_CONTENT;
		entity.PUBLICITY_REFER_TIME=model.PUBLICITY_REFER_TIME;
		entity.NOTICE_MEDIA=model.NOTICE_MEDIA;
		entity.URL=model.URL;
		entity.PUBLICITY_TYPE=model.PUBLICITY_TYPE;
		entity.PUBLICITY_START_TIME=model.PUBLICITY_START_TIME;
		entity.PUBLICITY_END_TIME=model.PUBLICITY_END_TIME;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_CREATOR=model.M_CREATOR;
		entity.M_ATT_PUBLICITY_DOC=model.M_ATT_PUBLICITY_DOC;
		entity.M_STATUS=model.M_STATUS;
		entity.M_REMARK=model.M_REMARK;
		entity.M_ZPID=model.M_ZPID;
		entity.M_ZR_QUOTE=model.M_ZR_QUOTE;
		entity.M_ZR_ZUNIT=model.M_ZR_ZUNIT;
		entity.M_ZR_UNIT=model.M_ZR_UNIT;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.OBJECTION_METHOD=model.OBJECTION_METHOD;
		entity.OTHER_CONTENT=model.OTHER_CONTENT;
		entity.BULLETIN_DUTY=model.BULLETIN_DUTY;
		entity.EXAMINER_NAME=model.EXAMINER_NAME;
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
        public GeneralResult Add(TENDER_CANDIDATE_ANNOUNCE model)
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
                    Delete(TENDER_CANDIDATE_ANNOUNCE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<TENDER_CANDIDATE_ANNOUNCE> model)
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
       	protected WhereClipBuilder ConditionBuilder(TENDER_CANDIDATE_ANNOUNCE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUBLICITY_NAME))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.PUBLICITY_NAME.Contain(model.PUBLICITY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PUBLICITY_CONTENT))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.PUBLICITY_CONTENT.Contain(model.PUBLICITY_CONTENT));
				}
				if(model.PUBLICITY_REFER_TIME!=null)
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.PUBLICITY_REFER_TIME==(model.PUBLICITY_REFER_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_MEDIA))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.NOTICE_MEDIA.Contain(model.NOTICE_MEDIA));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.PUBLICITY_TYPE))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.PUBLICITY_TYPE.Contain(model.PUBLICITY_TYPE));
				}
				if(model.PUBLICITY_START_TIME!=null)
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.PUBLICITY_START_TIME==(model.PUBLICITY_START_TIME));
				}
				if(model.PUBLICITY_END_TIME!=null)
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.PUBLICITY_END_TIME==(model.PUBLICITY_END_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.M_ID==(model.M_ID));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.M_CREATOR==(model.M_CREATOR));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PUBLICITY_DOC))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.M_ATT_PUBLICITY_DOC.Contain(model.M_ATT_PUBLICITY_DOC));
				}
				if(model.M_STATUS!=null)
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.M_STATUS==(model.M_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.M_REMARK))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.M_REMARK.Contain(model.M_REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ZPID))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.M_ZPID.Contain(model.M_ZPID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ZR_QUOTE))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.M_ZR_QUOTE.Contain(model.M_ZR_QUOTE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ZR_ZUNIT))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.M_ZR_ZUNIT.Contain(model.M_ZR_ZUNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ZR_UNIT))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.M_ZR_UNIT.Contain(model.M_ZR_UNIT));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.OBJECTION_METHOD))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.OBJECTION_METHOD.Contain(model.OBJECTION_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_CONTENT))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.OTHER_CONTENT.Contain(model.OTHER_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETIN_DUTY))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.BULLETIN_DUTY.Contain(model.BULLETIN_DUTY));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINER_NAME))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.EXAMINER_NAME.Contain(model.EXAMINER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(TENDER_CANDIDATE_ANNOUNCE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}