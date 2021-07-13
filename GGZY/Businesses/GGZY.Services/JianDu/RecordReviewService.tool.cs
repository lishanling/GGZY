using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class RecordReviewService : BaseServiceT<RECORD_REVIEW>
    {
        #region 接口实现
        
		public List<RECORD_REVIEW> FindList(RECORD_REVIEW model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<RECORD_REVIEW> PageList(RECORD_REVIEW model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, RECORD_REVIEW._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(RECORD_REVIEW._.ID == ID);
			
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
        public GeneralResult Edit(RECORD_REVIEW model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is RECORD_REVIEW entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.REVIEW_CODE=model.REVIEW_CODE;
		entity.REVIEW_TYPE=model.REVIEW_TYPE;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.COMMIT_TIME=model.COMMIT_TIME;
		entity.REVIEW_STATUS=model.REVIEW_STATUS;
		entity.SIGN_TIME=model.SIGN_TIME;
		entity.SIGN_PERSON=model.SIGN_PERSON;
		entity.SIGN_COMMENT=model.SIGN_COMMENT;
		entity.REVIEW_TIME=model.REVIEW_TIME;
		entity.REVIEW_PERSON=model.REVIEW_PERSON;
		entity.REVIEW_COMMENT=model.REVIEW_COMMENT;
		entity.IS_ADJUST=model.IS_ADJUST;
		entity.ADJUST_TIME=model.ADJUST_TIME;
		entity.AMENDMENT_OPINION=model.AMENDMENT_OPINION;
		entity.CREATE_TM=model.CREATE_TM;
		entity.CREATOR=model.CREATOR;
		entity.AUDIT_UNIT=model.AUDIT_UNIT;
		entity.IS_SIGN=model.IS_SIGN;
		entity.ADJUST_PERSON=model.ADJUST_PERSON;
		entity.IS_SUBMIT_AGAIN=model.IS_SUBMIT_AGAIN;
		entity.IS_GET_DATA=model.IS_GET_DATA;
		entity.SIGN_OVER_TM=model.SIGN_OVER_TM;
		entity.OVER_TM=model.OVER_TM;
		entity.GET_SYSTEM_NO=model.GET_SYSTEM_NO;
		entity.GET_DATA_TIME=model.GET_DATA_TIME;
		entity.M_ID=model.M_ID;
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
        public GeneralResult Add(RECORD_REVIEW model)
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
                    Delete(RECORD_REVIEW._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<RECORD_REVIEW> model)
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
       	protected WhereClipBuilder ConditionBuilder(RECORD_REVIEW model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(RECORD_REVIEW._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.REVIEW_CODE))
				{
				  condition.And(RECORD_REVIEW._.REVIEW_CODE.Contain(model.REVIEW_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.REVIEW_TYPE))
				{
				  condition.And(RECORD_REVIEW._.REVIEW_TYPE.Contain(model.REVIEW_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(RECORD_REVIEW._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(model.COMMIT_TIME!=null)
				{
				  condition.And(RECORD_REVIEW._.COMMIT_TIME==(model.COMMIT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.REVIEW_STATUS))
				{
				  condition.And(RECORD_REVIEW._.REVIEW_STATUS.Contain(model.REVIEW_STATUS));
				}
				if(model.SIGN_TIME!=null)
				{
				  condition.And(RECORD_REVIEW._.SIGN_TIME==(model.SIGN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.SIGN_PERSON))
				{
				  condition.And(RECORD_REVIEW._.SIGN_PERSON.Contain(model.SIGN_PERSON));
				}
				if(!string.IsNullOrWhiteSpace(model.SIGN_COMMENT))
				{
				  condition.And(RECORD_REVIEW._.SIGN_COMMENT.Contain(model.SIGN_COMMENT));
				}
				if(model.REVIEW_TIME!=null)
				{
				  condition.And(RECORD_REVIEW._.REVIEW_TIME==(model.REVIEW_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.REVIEW_PERSON))
				{
				  condition.And(RECORD_REVIEW._.REVIEW_PERSON.Contain(model.REVIEW_PERSON));
				}
				if(!string.IsNullOrWhiteSpace(model.REVIEW_COMMENT))
				{
				  condition.And(RECORD_REVIEW._.REVIEW_COMMENT.Contain(model.REVIEW_COMMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_ADJUST))
				{
				  condition.And(RECORD_REVIEW._.IS_ADJUST.Contain(model.IS_ADJUST));
				}
				if(model.ADJUST_TIME!=null)
				{
				  condition.And(RECORD_REVIEW._.ADJUST_TIME==(model.ADJUST_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.AMENDMENT_OPINION))
				{
				  condition.And(RECORD_REVIEW._.AMENDMENT_OPINION.Contain(model.AMENDMENT_OPINION));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(RECORD_REVIEW._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.CREATOR!=null)
				{
				  condition.And(RECORD_REVIEW._.CREATOR==(model.CREATOR));
				}
				if(!string.IsNullOrWhiteSpace(model.AUDIT_UNIT))
				{
				  condition.And(RECORD_REVIEW._.AUDIT_UNIT.Contain(model.AUDIT_UNIT));
				}
				if(model.IS_SIGN!=null)
				{
				  condition.And(RECORD_REVIEW._.IS_SIGN==(model.IS_SIGN));
				}
				if(!string.IsNullOrWhiteSpace(model.ADJUST_PERSON))
				{
				  condition.And(RECORD_REVIEW._.ADJUST_PERSON.Contain(model.ADJUST_PERSON));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_SUBMIT_AGAIN))
				{
				  condition.And(RECORD_REVIEW._.IS_SUBMIT_AGAIN.Contain(model.IS_SUBMIT_AGAIN));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_GET_DATA))
				{
				  condition.And(RECORD_REVIEW._.IS_GET_DATA.Contain(model.IS_GET_DATA));
				}
				if(model.SIGN_OVER_TM!=null)
				{
				  condition.And(RECORD_REVIEW._.SIGN_OVER_TM==(model.SIGN_OVER_TM));
				}
				if(model.OVER_TM!=null)
				{
				  condition.And(RECORD_REVIEW._.OVER_TM==(model.OVER_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.GET_SYSTEM_NO))
				{
				  condition.And(RECORD_REVIEW._.GET_SYSTEM_NO.Contain(model.GET_SYSTEM_NO));
				}
				if(model.GET_DATA_TIME!=null)
				{
				  condition.And(RECORD_REVIEW._.GET_DATA_TIME==(model.GET_DATA_TIME));
				}
				if(model.M_ID!=null)
				{
				  condition.And(RECORD_REVIEW._.M_ID==(model.M_ID));
				}
		return condition;
	}
        #endregion
    }
}