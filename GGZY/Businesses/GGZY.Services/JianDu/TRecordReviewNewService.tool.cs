using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TRecordReviewNewService : BaseServiceT<T_RECORD_REVIEW_NEW>
    {
        #region 接口实现
        
		public List<T_RECORD_REVIEW_NEW> FindList(T_RECORD_REVIEW_NEW model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_RECORD_REVIEW_NEW> PageList(T_RECORD_REVIEW_NEW model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_RECORD_REVIEW_NEW._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_RECORD_REVIEW_NEW._.ID == ID);
			
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
        public GeneralResult Edit(T_RECORD_REVIEW_NEW model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_RECORD_REVIEW_NEW entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.REVIEW_TYPE=model.REVIEW_TYPE;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.TENDER_AGENCY_CODE=model.TENDER_AGENCY_CODE;
		entity.COMMIT_TIME=model.COMMIT_TIME;
		entity.REVIEW_STATUS=model.REVIEW_STATUS;
		entity.REVIEW_TIME=model.REVIEW_TIME;
		entity.IS_PASS_REVIEW=model.IS_PASS_REVIEW;
		entity.REVIEW_COMMENT=model.REVIEW_COMMENT;
		entity.TENDER_PROJECT_NAME=model.TENDER_PROJECT_NAME;
		entity.TENDER_AGENCY_NAME=model.TENDER_AGENCY_NAME;
		entity.AUDIT_UNIT=model.AUDIT_UNIT;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.SECTION_TYPE=model.SECTION_TYPE;
		entity.IS_VIEW=model.IS_VIEW;
		entity.PROJECT_NAME=model.PROJECT_NAME;
		entity.REGION_CODE=model.REGION_CODE;
		entity.TENDERER_CODE=model.TENDERER_CODE;
		entity.TENDERER_NAME=model.TENDERER_NAME;
		entity.TENDER_CONTENT=model.TENDER_CONTENT;
		entity.REVIEW_ID=model.REVIEW_ID;
		entity.TENDER_MODE=model.TENDER_MODE;
		entity.TENDER_ORGANIZE_FORM=model.TENDER_ORGANIZE_FORM;
		entity.CONTRACT_NAME=model.CONTRACT_NAME;
		entity.CONTRACT_PHONE=model.CONTRACT_PHONE;
		entity.USERID=model.USERID;
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
        public GeneralResult Add(T_RECORD_REVIEW_NEW model)
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
                    Delete(T_RECORD_REVIEW_NEW._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_RECORD_REVIEW_NEW> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_RECORD_REVIEW_NEW model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_RECORD_REVIEW_NEW._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.REVIEW_TYPE))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.REVIEW_TYPE.Contain(model.REVIEW_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_CODE))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.TENDER_AGENCY_CODE.Contain(model.TENDER_AGENCY_CODE));
				}
				if(model.COMMIT_TIME!=null)
				{
				  condition.And(T_RECORD_REVIEW_NEW._.COMMIT_TIME==(model.COMMIT_TIME));
				}
				if(model.REVIEW_STATUS!=null)
				{
				  condition.And(T_RECORD_REVIEW_NEW._.REVIEW_STATUS==(model.REVIEW_STATUS));
				}
				if(model.REVIEW_TIME!=null)
				{
				  condition.And(T_RECORD_REVIEW_NEW._.REVIEW_TIME==(model.REVIEW_TIME));
				}
				if(model.IS_PASS_REVIEW!=null)
				{
				  condition.And(T_RECORD_REVIEW_NEW._.IS_PASS_REVIEW==(model.IS_PASS_REVIEW));
				}
				if(!string.IsNullOrWhiteSpace(model.REVIEW_COMMENT))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.REVIEW_COMMENT.Contain(model.REVIEW_COMMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_NAME))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.TENDER_AGENCY_NAME.Contain(model.TENDER_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.AUDIT_UNIT))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.AUDIT_UNIT.Contain(model.AUDIT_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.SECTION_TYPE))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.SECTION_TYPE.Contain(model.SECTION_TYPE));
				}
				if(model.IS_VIEW!=null)
				{
				  condition.And(T_RECORD_REVIEW_NEW._.IS_VIEW==(model.IS_VIEW));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.PROJECT_NAME.Contain(model.PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_CODE))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.TENDERER_CODE.Contain(model.TENDERER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_NAME))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.TENDERER_NAME.Contain(model.TENDERER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_CONTENT))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.TENDER_CONTENT.Contain(model.TENDER_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.REVIEW_ID))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.REVIEW_ID.Contain(model.REVIEW_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_MODE))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.TENDER_MODE.Contain(model.TENDER_MODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_ORGANIZE_FORM))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.TENDER_ORGANIZE_FORM.Contain(model.TENDER_ORGANIZE_FORM));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_NAME))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.CONTRACT_NAME.Contain(model.CONTRACT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_PHONE))
				{
				  condition.And(T_RECORD_REVIEW_NEW._.CONTRACT_PHONE.Contain(model.CONTRACT_PHONE));
				}
				if(model.USERID!=null)
				{
				  condition.And(T_RECORD_REVIEW_NEW._.USERID==(model.USERID));
				}
		return condition;
	}
        #endregion
    }
}