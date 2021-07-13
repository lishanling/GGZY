using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ZjWrittenReportService : BaseServiceT<ZJ_WRITTEN_REPORT>
    {
        #region 接口实现
        
		public List<ZJ_WRITTEN_REPORT> FindList(ZJ_WRITTEN_REPORT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJ_WRITTEN_REPORT> PageList(ZJ_WRITTEN_REPORT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJ_WRITTEN_REPORT._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(ZJ_WRITTEN_REPORT._.M_ID == M_ID);
			
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
        public GeneralResult Edit(ZJ_WRITTEN_REPORT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is ZJ_WRITTEN_REPORT entity)
	{		
		entity.Attach();
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_CREATOR=model.M_CREATOR;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.REPROT_CODE=model.REPROT_CODE;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.TENDER_PROJECT_NAME=model.TENDER_PROJECT_NAME;
		entity.REVIEW_TIME=model.REVIEW_TIME;
		entity.TENDER_NOTICE_CONTENT=model.TENDER_NOTICE_CONTENT;
		entity.CONSTRUCTION_SCALE=model.CONSTRUCTION_SCALE;
		entity.BUILD_AREA=model.BUILD_AREA;
		entity.TENDER_MODE=model.TENDER_MODE;
		entity.TENDER_ORGANIZE_FORM=model.TENDER_ORGANIZE_FORM;
		entity.TENDER_AGENCY_NAME=model.TENDER_AGENCY_NAME;
		entity.TENDER_AGENCY_CODE=model.TENDER_AGENCY_CODE;
		entity.BID_OPENING_CONTENT=model.BID_OPENING_CONTENT;
		entity.BID_OPENING_DISSENT_CONTENT=model.BID_OPENING_DISSENT_CONTENT;
		entity.BID_OPENING_OTHER_CONTENT=model.BID_OPENING_OTHER_CONTENT;
		entity.EVALUATION_CONTENT=model.EVALUATION_CONTENT;
		entity.EVALUATION_STATUS=model.EVALUATION_STATUS;
		entity.EVALUATION_OTHER_CONTENT=model.EVALUATION_OTHER_CONTENT;
		entity.TENDER_PROJECT_CLASSIFY_CODE=model.TENDER_PROJECT_CLASSIFY_CODE;
		entity.WIN_BIDDER_CONFIRM=model.WIN_BIDDER_CONFIRM;
		entity.BIDDER_CANDIDATE_CONTENT=model.BIDDER_CANDIDATE_CONTENT;
		entity.BIDDER_WIN_CONTENT=model.BIDDER_WIN_CONTENT;
		entity.BIDDER_WIN_RESULT_CONTENT=model.BIDDER_WIN_RESULT_CONTENT;
		entity.WIN_NOTICE_CODE_ENTP=model.WIN_NOTICE_CODE_ENTP;
		entity.WIN_NOTICE_CODE=model.WIN_NOTICE_CODE;
		entity.WIN_BIDDER_TIME=model.WIN_BIDDER_TIME;
		entity.BID_AMOUNT=model.BID_AMOUNT;
		entity.BID_CURRENCY=model.BID_CURRENCY;
		entity.PRICE_UNIT=model.PRICE_UNIT;
		entity.WIN_BIDDER_NAME=model.WIN_BIDDER_NAME;
		entity.WIN_BIDDER_CODE=model.WIN_BIDDER_CODE;
		entity.WIN_PROVINCE_RANK=model.WIN_PROVINCE_RANK;
		entity.WIN_BIDDER_RANK=model.WIN_BIDDER_RANK;
		entity.PROJECT_LEAD=model.PROJECT_LEAD;
		entity.PROJECT_LEAD_ID=model.PROJECT_LEAD_ID;
		entity.COMPLAINT_CONTENT=model.COMPLAINT_CONTENT;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.TRADE_PLAT=model.TRADE_PLAT;
		entity.PUB_SERVICE_PLAT=model.PUB_SERVICE_PLAT;
		entity.M_VERSION=model.M_VERSION;
		entity.TENDER_DISSENT_CONTENT=model.TENDER_DISSENT_CONTENT;
		entity.M_ATT_TENDER_NOTICE=model.M_ATT_TENDER_NOTICE;
		entity.M_ATT_TENDER_FILE=model.M_ATT_TENDER_FILE;
		entity.M_ATT_BID_OPEN_DOC=model.M_ATT_BID_OPEN_DOC;
		entity.M_ATT_EVALUATION_DOC=model.M_ATT_EVALUATION_DOC;
		entity.M_ATT_WIN_CANDIDATE_DOC=model.M_ATT_WIN_CANDIDATE_DOC;
		entity.M_ATT_PUBLICITY_DOC=model.M_ATT_PUBLICITY_DOC;
		entity.M_ATT_WIN_BIDDER_DOC=model.M_ATT_WIN_BIDDER_DOC;
		entity.M_ATT_WIN_BIDDR_TENDER_FILE=model.M_ATT_WIN_BIDDR_TENDER_FILE;
		entity.M_ATT_CONTRACT_DOC=model.M_ATT_CONTRACT_DOC;
		entity.M_ATT_DISPUTE_RESPONSE_DOC=model.M_ATT_DISPUTE_RESPONSE_DOC;
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
        public GeneralResult Add(ZJ_WRITTEN_REPORT model)
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
                    Delete(ZJ_WRITTEN_REPORT._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJ_WRITTEN_REPORT> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJ_WRITTEN_REPORT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_TM==(model.M_TM));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.REPROT_CODE))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.REPROT_CODE.Contain(model.REPROT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(model.REVIEW_TIME!=null)
				{
				  condition.And(ZJ_WRITTEN_REPORT._.REVIEW_TIME==(model.REVIEW_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_NOTICE_CONTENT))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.TENDER_NOTICE_CONTENT.Contain(model.TENDER_NOTICE_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCTION_SCALE))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.CONSTRUCTION_SCALE.Contain(model.CONSTRUCTION_SCALE));
				}
				if(model.BUILD_AREA!=null)
				{
				  condition.And(ZJ_WRITTEN_REPORT._.BUILD_AREA==(model.BUILD_AREA));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_MODE))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.TENDER_MODE.Contain(model.TENDER_MODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_ORGANIZE_FORM))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.TENDER_ORGANIZE_FORM.Contain(model.TENDER_ORGANIZE_FORM));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_NAME))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.TENDER_AGENCY_NAME.Contain(model.TENDER_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_CODE))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.TENDER_AGENCY_CODE.Contain(model.TENDER_AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_OPENING_CONTENT))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.BID_OPENING_CONTENT.Contain(model.BID_OPENING_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_OPENING_DISSENT_CONTENT))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.BID_OPENING_DISSENT_CONTENT.Contain(model.BID_OPENING_DISSENT_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_OPENING_OTHER_CONTENT))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.BID_OPENING_OTHER_CONTENT.Contain(model.BID_OPENING_OTHER_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATION_CONTENT))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.EVALUATION_CONTENT.Contain(model.EVALUATION_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATION_STATUS))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.EVALUATION_STATUS.Contain(model.EVALUATION_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATION_OTHER_CONTENT))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.EVALUATION_OTHER_CONTENT.Contain(model.EVALUATION_OTHER_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CLASSIFY_CODE))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.TENDER_PROJECT_CLASSIFY_CODE.Contain(model.TENDER_PROJECT_CLASSIFY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BIDDER_CONFIRM))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.WIN_BIDDER_CONFIRM.Contain(model.WIN_BIDDER_CONFIRM));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_CANDIDATE_CONTENT))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.BIDDER_CANDIDATE_CONTENT.Contain(model.BIDDER_CANDIDATE_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_WIN_CONTENT))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.BIDDER_WIN_CONTENT.Contain(model.BIDDER_WIN_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_WIN_RESULT_CONTENT))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.BIDDER_WIN_RESULT_CONTENT.Contain(model.BIDDER_WIN_RESULT_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_NOTICE_CODE_ENTP))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.WIN_NOTICE_CODE_ENTP.Contain(model.WIN_NOTICE_CODE_ENTP));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_NOTICE_CODE))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.WIN_NOTICE_CODE.Contain(model.WIN_NOTICE_CODE));
				}
				if(model.WIN_BIDDER_TIME!=null)
				{
				  condition.And(ZJ_WRITTEN_REPORT._.WIN_BIDDER_TIME==(model.WIN_BIDDER_TIME));
				}
				if(model.BID_AMOUNT!=null)
				{
				  condition.And(ZJ_WRITTEN_REPORT._.BID_AMOUNT==(model.BID_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_CURRENCY))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.BID_CURRENCY.Contain(model.BID_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_UNIT))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.PRICE_UNIT.Contain(model.PRICE_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BIDDER_NAME))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.WIN_BIDDER_NAME.Contain(model.WIN_BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BIDDER_CODE))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.WIN_BIDDER_CODE.Contain(model.WIN_BIDDER_CODE));
				}
				if(model.WIN_PROVINCE_RANK!=null)
				{
				  condition.And(ZJ_WRITTEN_REPORT._.WIN_PROVINCE_RANK==(model.WIN_PROVINCE_RANK));
				}
				if(model.WIN_BIDDER_RANK!=null)
				{
				  condition.And(ZJ_WRITTEN_REPORT._.WIN_BIDDER_RANK==(model.WIN_BIDDER_RANK));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_LEAD))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.PROJECT_LEAD.Contain(model.PROJECT_LEAD));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_LEAD_ID))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.PROJECT_LEAD_ID.Contain(model.PROJECT_LEAD_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_CONTENT))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.COMPLAINT_CONTENT.Contain(model.COMPLAINT_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(ZJ_WRITTEN_REPORT._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_VERSION.Contain(model.M_VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_DISSENT_CONTENT))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.TENDER_DISSENT_CONTENT.Contain(model.TENDER_DISSENT_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TENDER_NOTICE))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_ATT_TENDER_NOTICE.Contain(model.M_ATT_TENDER_NOTICE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TENDER_FILE))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_ATT_TENDER_FILE.Contain(model.M_ATT_TENDER_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_BID_OPEN_DOC))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_ATT_BID_OPEN_DOC.Contain(model.M_ATT_BID_OPEN_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_EVALUATION_DOC))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_ATT_EVALUATION_DOC.Contain(model.M_ATT_EVALUATION_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_WIN_CANDIDATE_DOC))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_ATT_WIN_CANDIDATE_DOC.Contain(model.M_ATT_WIN_CANDIDATE_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PUBLICITY_DOC))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_ATT_PUBLICITY_DOC.Contain(model.M_ATT_PUBLICITY_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_WIN_BIDDER_DOC))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_ATT_WIN_BIDDER_DOC.Contain(model.M_ATT_WIN_BIDDER_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_WIN_BIDDR_TENDER_FILE))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_ATT_WIN_BIDDR_TENDER_FILE.Contain(model.M_ATT_WIN_BIDDR_TENDER_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_CONTRACT_DOC))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_ATT_CONTRACT_DOC.Contain(model.M_ATT_CONTRACT_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_DISPUTE_RESPONSE_DOC))
				{
				  condition.And(ZJ_WRITTEN_REPORT._.M_ATT_DISPUTE_RESPONSE_DOC.Contain(model.M_ATT_DISPUTE_RESPONSE_DOC));
				}
		return condition;
	}
        #endregion
    }
}