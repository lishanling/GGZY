using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TRecordReviewService : BaseServiceT<T_RECORD_REVIEW>
    {
        #region 接口实现
        
		public List<T_RECORD_REVIEW> FindList(T_RECORD_REVIEW model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_RECORD_REVIEW> PageList(T_RECORD_REVIEW model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_RECORD_REVIEW._.ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_RECORD_REVIEW._.ID == ID);
			
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
        public GeneralResult Edit(T_RECORD_REVIEW model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_RECORD_REVIEW entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.REVIEW_TYPE=model.REVIEW_TYPE;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.TENDER_PROJECT_TYPE=model.TENDER_PROJECT_TYPE;
		entity.TENDER_AGENCY_CODE=model.TENDER_AGENCY_CODE;
		entity.COMMIT_TIME=model.COMMIT_TIME;
		entity.IS_REVIEW=model.IS_REVIEW;
		entity.REVIEW_TIME=model.REVIEW_TIME;
		entity.IS_PASS_REVIEW=model.IS_PASS_REVIEW;
		entity.REVIEW_COMMENT=model.REVIEW_COMMENT;
		entity.SECTION_CODE=model.SECTION_CODE;
		entity.SECTION_NAME=model.SECTION_NAME;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_ID=model.M_ID;
		entity.TENDER_PROJECT_NAME=model.TENDER_PROJECT_NAME;
		entity.TENDER_AGENCY_NAME=model.TENDER_AGENCY_NAME;
		entity.NOTICE_KEY=model.NOTICE_KEY;
		entity.AUDIT_UNIT=model.AUDIT_UNIT;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.SECTION_TYPE=model.SECTION_TYPE;
		entity.IS_VIEW=model.IS_VIEW;
		entity.REVIEW_KEY=model.REVIEW_KEY;
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
        public GeneralResult Add(T_RECORD_REVIEW model)
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
                    Delete(T_RECORD_REVIEW._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_RECORD_REVIEW> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_RECORD_REVIEW model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_RECORD_REVIEW._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.REVIEW_TYPE))
				{
				  condition.And(T_RECORD_REVIEW._.REVIEW_TYPE.Contain(model.REVIEW_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(T_RECORD_REVIEW._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
				{
				  condition.And(T_RECORD_REVIEW._.TENDER_PROJECT_TYPE.Contain(model.TENDER_PROJECT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_CODE))
				{
				  condition.And(T_RECORD_REVIEW._.TENDER_AGENCY_CODE.Contain(model.TENDER_AGENCY_CODE));
				}
				if(model.COMMIT_TIME!=null)
				{
				  condition.And(T_RECORD_REVIEW._.COMMIT_TIME==(model.COMMIT_TIME));
				}
				if(model.IS_REVIEW!=null)
				{
				  condition.And(T_RECORD_REVIEW._.IS_REVIEW==(model.IS_REVIEW));
				}
				if(model.REVIEW_TIME!=null)
				{
				  condition.And(T_RECORD_REVIEW._.REVIEW_TIME==(model.REVIEW_TIME));
				}
				if(model.IS_PASS_REVIEW!=null)
				{
				  condition.And(T_RECORD_REVIEW._.IS_PASS_REVIEW==(model.IS_PASS_REVIEW));
				}
				if(!string.IsNullOrWhiteSpace(model.REVIEW_COMMENT))
				{
				  condition.And(T_RECORD_REVIEW._.REVIEW_COMMENT.Contain(model.REVIEW_COMMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.SECTION_CODE))
				{
				  condition.And(T_RECORD_REVIEW._.SECTION_CODE.Contain(model.SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.SECTION_NAME))
				{
				  condition.And(T_RECORD_REVIEW._.SECTION_NAME.Contain(model.SECTION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(T_RECORD_REVIEW._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ID))
				{
				  condition.And(T_RECORD_REVIEW._.M_ID.Contain(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(T_RECORD_REVIEW._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_NAME))
				{
				  condition.And(T_RECORD_REVIEW._.TENDER_AGENCY_NAME.Contain(model.TENDER_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_KEY))
				{
				  condition.And(T_RECORD_REVIEW._.NOTICE_KEY.Contain(model.NOTICE_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.AUDIT_UNIT))
				{
				  condition.And(T_RECORD_REVIEW._.AUDIT_UNIT.Contain(model.AUDIT_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(T_RECORD_REVIEW._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_TM))
				{
				  condition.And(T_RECORD_REVIEW._.M_TM.Contain(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.SECTION_TYPE))
				{
				  condition.And(T_RECORD_REVIEW._.SECTION_TYPE.Contain(model.SECTION_TYPE));
				}
				if(model.IS_VIEW!=null)
				{
				  condition.And(T_RECORD_REVIEW._.IS_VIEW==(model.IS_VIEW));
				}
				if(!string.IsNullOrWhiteSpace(model.REVIEW_KEY))
				{
				  condition.And(T_RECORD_REVIEW._.REVIEW_KEY.Contain(model.REVIEW_KEY));
				}
		return condition;
	}
        #endregion
    }
}