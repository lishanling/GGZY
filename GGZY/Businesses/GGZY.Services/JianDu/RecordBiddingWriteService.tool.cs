using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class RecordBiddingWriteService : BaseServiceT<RECORD_BIDDING_WRITE>
    {
        #region 接口实现
        
		public List<RECORD_BIDDING_WRITE> FindList(RECORD_BIDDING_WRITE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<RECORD_BIDDING_WRITE> PageList(RECORD_BIDDING_WRITE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, RECORD_BIDDING_WRITE._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="RECORD_ID">备案主表ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? RECORD_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(RECORD_BIDDING_WRITE._.RECORD_ID == RECORD_ID);
			
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
        public GeneralResult Edit(RECORD_BIDDING_WRITE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.RECORD_ID);
	
	if(viewResult.Success  && viewResult.Data is RECORD_BIDDING_WRITE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.RECORD_ID=model.RECORD_ID;
		entity.TENDER_PROJECT_NAME=model.TENDER_PROJECT_NAME;
		entity.CONSTRUCT_CODE=model.CONSTRUCT_CODE;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.TENDER_CONTENT=model.TENDER_CONTENT;
		entity.SCALE_CONSTRUCT=model.SCALE_CONSTRUCT;
		entity.MEASURE_AREA=model.MEASURE_AREA;
		entity.TENDER_MODE=model.TENDER_MODE;
		entity.TENDER_ORGANIZE_FORM=model.TENDER_ORGANIZE_FORM;
		entity.TENDER_AGENCY_NAME=model.TENDER_AGENCY_NAME;
		entity.TENDER_AGENCY_CODE=model.TENDER_AGENCY_CODE;
		entity.TENDER_PROJECT_TYPE=model.TENDER_PROJECT_TYPE;
		entity.BID_OPEN_RECORD=model.BID_OPEN_RECORD;
		entity.BID_DISSENT_OPEN_RECORD=model.BID_DISSENT_OPEN_RECORD;
		entity.OTHER_OPEN_RECORD=model.OTHER_OPEN_RECORD;
		entity.BID_EVALUATE_COMMITTEE=model.BID_EVALUATE_COMMITTEE;
		entity.BID_EVALUATE_INFO=model.BID_EVALUATE_INFO;
		entity.OTHER_EVALUATE_RECORD=model.OTHER_EVALUATE_RECORD;
		entity.WIN_BIDDER_WAY=model.WIN_BIDDER_WAY;
		entity.CANDIDATE_PUBLIC=model.CANDIDATE_PUBLIC;
		entity.WIN_BIDDER_PUBLIC=model.WIN_BIDDER_PUBLIC;
		entity.WIN_BID_INFO=model.WIN_BID_INFO;
		entity.ENTERPRISE_NOTICE_CODE=model.ENTERPRISE_NOTICE_CODE;
		entity.DEPARTMENT_NOTICE_CODE=model.DEPARTMENT_NOTICE_CODE;
		entity.WIN_BID_DATE=model.WIN_BID_DATE;
		entity.BID_AMOUNT=model.BID_AMOUNT;
		entity.WIN_BIDDER_NAME=model.WIN_BIDDER_NAME;
		entity.WIN_BIDDER_CODE=model.WIN_BIDDER_CODE;
		entity.PROJECT_LEADER_NAME=model.PROJECT_LEADER_NAME;
		entity.PROJECT_LEADER_CODE=model.PROJECT_LEADER_CODE;
		entity.BID_EVALUATION_HANDLE=model.BID_EVALUATION_HANDLE;
		entity.COMPLAINT_HANDLE=model.COMPLAINT_HANDLE;
		entity.CREATE_TM=model.CREATE_TM;
		entity.CREATOR=model.CREATOR;
		entity.TENDER_PROJECT_CODE_OLD1=model.TENDER_PROJECT_CODE_OLD1;
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
        public GeneralResult Add(RECORD_BIDDING_WRITE model)
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
                    Delete(RECORD_BIDDING_WRITE._.RECORD_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<RECORD_BIDDING_WRITE> model)
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
       	protected WhereClipBuilder ConditionBuilder(RECORD_BIDDING_WRITE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(RECORD_BIDDING_WRITE._.ID==(model.ID));
				}
				if(model.RECORD_ID!=null)
				{
				  condition.And(RECORD_BIDDING_WRITE._.RECORD_ID==(model.RECORD_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(RECORD_BIDDING_WRITE._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCT_CODE))
				{
				  condition.And(RECORD_BIDDING_WRITE._.CONSTRUCT_CODE.Contain(model.CONSTRUCT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(RECORD_BIDDING_WRITE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_CONTENT))
				{
				  condition.And(RECORD_BIDDING_WRITE._.TENDER_CONTENT.Contain(model.TENDER_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.SCALE_CONSTRUCT))
				{
				  condition.And(RECORD_BIDDING_WRITE._.SCALE_CONSTRUCT.Contain(model.SCALE_CONSTRUCT));
				}
				if(model.MEASURE_AREA!=null)
				{
				  condition.And(RECORD_BIDDING_WRITE._.MEASURE_AREA==(model.MEASURE_AREA));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_MODE))
				{
				  condition.And(RECORD_BIDDING_WRITE._.TENDER_MODE.Contain(model.TENDER_MODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_ORGANIZE_FORM))
				{
				  condition.And(RECORD_BIDDING_WRITE._.TENDER_ORGANIZE_FORM.Contain(model.TENDER_ORGANIZE_FORM));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_NAME))
				{
				  condition.And(RECORD_BIDDING_WRITE._.TENDER_AGENCY_NAME.Contain(model.TENDER_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_CODE))
				{
				  condition.And(RECORD_BIDDING_WRITE._.TENDER_AGENCY_CODE.Contain(model.TENDER_AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
				{
				  condition.And(RECORD_BIDDING_WRITE._.TENDER_PROJECT_TYPE.Contain(model.TENDER_PROJECT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_OPEN_RECORD))
				{
				  condition.And(RECORD_BIDDING_WRITE._.BID_OPEN_RECORD.Contain(model.BID_OPEN_RECORD));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_DISSENT_OPEN_RECORD))
				{
				  condition.And(RECORD_BIDDING_WRITE._.BID_DISSENT_OPEN_RECORD.Contain(model.BID_DISSENT_OPEN_RECORD));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_OPEN_RECORD))
				{
				  condition.And(RECORD_BIDDING_WRITE._.OTHER_OPEN_RECORD.Contain(model.OTHER_OPEN_RECORD));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_EVALUATE_COMMITTEE))
				{
				  condition.And(RECORD_BIDDING_WRITE._.BID_EVALUATE_COMMITTEE.Contain(model.BID_EVALUATE_COMMITTEE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_EVALUATE_INFO))
				{
				  condition.And(RECORD_BIDDING_WRITE._.BID_EVALUATE_INFO.Contain(model.BID_EVALUATE_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_EVALUATE_RECORD))
				{
				  condition.And(RECORD_BIDDING_WRITE._.OTHER_EVALUATE_RECORD.Contain(model.OTHER_EVALUATE_RECORD));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BIDDER_WAY))
				{
				  condition.And(RECORD_BIDDING_WRITE._.WIN_BIDDER_WAY.Contain(model.WIN_BIDDER_WAY));
				}
				if(!string.IsNullOrWhiteSpace(model.CANDIDATE_PUBLIC))
				{
				  condition.And(RECORD_BIDDING_WRITE._.CANDIDATE_PUBLIC.Contain(model.CANDIDATE_PUBLIC));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BIDDER_PUBLIC))
				{
				  condition.And(RECORD_BIDDING_WRITE._.WIN_BIDDER_PUBLIC.Contain(model.WIN_BIDDER_PUBLIC));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BID_INFO))
				{
				  condition.And(RECORD_BIDDING_WRITE._.WIN_BID_INFO.Contain(model.WIN_BID_INFO));
				}
				if(!string.IsNullOrWhiteSpace(model.ENTERPRISE_NOTICE_CODE))
				{
				  condition.And(RECORD_BIDDING_WRITE._.ENTERPRISE_NOTICE_CODE.Contain(model.ENTERPRISE_NOTICE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.DEPARTMENT_NOTICE_CODE))
				{
				  condition.And(RECORD_BIDDING_WRITE._.DEPARTMENT_NOTICE_CODE.Contain(model.DEPARTMENT_NOTICE_CODE));
				}
				if(model.WIN_BID_DATE!=null)
				{
				  condition.And(RECORD_BIDDING_WRITE._.WIN_BID_DATE==(model.WIN_BID_DATE));
				}
				if(model.BID_AMOUNT!=null)
				{
				  condition.And(RECORD_BIDDING_WRITE._.BID_AMOUNT==(model.BID_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BIDDER_NAME))
				{
				  condition.And(RECORD_BIDDING_WRITE._.WIN_BIDDER_NAME.Contain(model.WIN_BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BIDDER_CODE))
				{
				  condition.And(RECORD_BIDDING_WRITE._.WIN_BIDDER_CODE.Contain(model.WIN_BIDDER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_LEADER_NAME))
				{
				  condition.And(RECORD_BIDDING_WRITE._.PROJECT_LEADER_NAME.Contain(model.PROJECT_LEADER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_LEADER_CODE))
				{
				  condition.And(RECORD_BIDDING_WRITE._.PROJECT_LEADER_CODE.Contain(model.PROJECT_LEADER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_EVALUATION_HANDLE))
				{
				  condition.And(RECORD_BIDDING_WRITE._.BID_EVALUATION_HANDLE.Contain(model.BID_EVALUATION_HANDLE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_HANDLE))
				{
				  condition.And(RECORD_BIDDING_WRITE._.COMPLAINT_HANDLE.Contain(model.COMPLAINT_HANDLE));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(RECORD_BIDDING_WRITE._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.CREATOR!=null)
				{
				  condition.And(RECORD_BIDDING_WRITE._.CREATOR==(model.CREATOR));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE_OLD1))
				{
				  condition.And(RECORD_BIDDING_WRITE._.TENDER_PROJECT_CODE_OLD1.Contain(model.TENDER_PROJECT_CODE_OLD1));
				}
		return condition;
	}
        #endregion
    }
}