using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class RecordCreditDeductionService : BaseServiceT<RECORD_CREDIT_DEDUCTION>
    {
        #region 接口实现
        
		public List<RECORD_CREDIT_DEDUCTION> FindList(RECORD_CREDIT_DEDUCTION model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<RECORD_CREDIT_DEDUCTION> PageList(RECORD_CREDIT_DEDUCTION model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, RECORD_CREDIT_DEDUCTION._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(RECORD_CREDIT_DEDUCTION._.ID == ID);
			
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
        public GeneralResult Edit(RECORD_CREDIT_DEDUCTION model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is RECORD_CREDIT_DEDUCTION entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.REVIEW_ID=model.REVIEW_ID;
		entity.REVIEW_CODE=model.REVIEW_CODE;
		entity.EXIST_PROBLEM=model.EXIST_PROBLEM;
		entity.EXAMIN_OPINION=model.EXAMIN_OPINION;
		entity.PROBLEM_ATTRIBUTE=model.PROBLEM_ATTRIBUTE;
		entity.IS_ADJUST=model.IS_ADJUST;
		entity.CREATE_TM=model.CREATE_TM;
		entity.CREATOR=model.CREATOR;
		entity.BEFORE_IS_DOUBLE=model.BEFORE_IS_DOUBLE;
		entity.AFTER_IS_DOUBLE=model.AFTER_IS_DOUBLE;
		entity.BEFORE_CREDIT_NUM=model.BEFORE_CREDIT_NUM;
		entity.AFTER_CREDIT_NUM=model.AFTER_CREDIT_NUM;
		entity.VERSION=model.VERSION;
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
        public GeneralResult Add(RECORD_CREDIT_DEDUCTION model)
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
                    Delete(RECORD_CREDIT_DEDUCTION._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<RECORD_CREDIT_DEDUCTION> model)
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
       	protected WhereClipBuilder ConditionBuilder(RECORD_CREDIT_DEDUCTION model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(RECORD_CREDIT_DEDUCTION._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.REVIEW_ID))
				{
				  condition.And(RECORD_CREDIT_DEDUCTION._.REVIEW_ID.Contain(model.REVIEW_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.REVIEW_CODE))
				{
				  condition.And(RECORD_CREDIT_DEDUCTION._.REVIEW_CODE.Contain(model.REVIEW_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXIST_PROBLEM))
				{
				  condition.And(RECORD_CREDIT_DEDUCTION._.EXIST_PROBLEM.Contain(model.EXIST_PROBLEM));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMIN_OPINION))
				{
				  condition.And(RECORD_CREDIT_DEDUCTION._.EXAMIN_OPINION.Contain(model.EXAMIN_OPINION));
				}
				if(!string.IsNullOrWhiteSpace(model.PROBLEM_ATTRIBUTE))
				{
				  condition.And(RECORD_CREDIT_DEDUCTION._.PROBLEM_ATTRIBUTE.Contain(model.PROBLEM_ATTRIBUTE));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_ADJUST))
				{
				  condition.And(RECORD_CREDIT_DEDUCTION._.IS_ADJUST.Contain(model.IS_ADJUST));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(RECORD_CREDIT_DEDUCTION._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.CREATOR!=null)
				{
				  condition.And(RECORD_CREDIT_DEDUCTION._.CREATOR==(model.CREATOR));
				}
				if(!string.IsNullOrWhiteSpace(model.BEFORE_IS_DOUBLE))
				{
				  condition.And(RECORD_CREDIT_DEDUCTION._.BEFORE_IS_DOUBLE.Contain(model.BEFORE_IS_DOUBLE));
				}
				if(!string.IsNullOrWhiteSpace(model.AFTER_IS_DOUBLE))
				{
				  condition.And(RECORD_CREDIT_DEDUCTION._.AFTER_IS_DOUBLE.Contain(model.AFTER_IS_DOUBLE));
				}
				if(!string.IsNullOrWhiteSpace(model.BEFORE_CREDIT_NUM))
				{
				  condition.And(RECORD_CREDIT_DEDUCTION._.BEFORE_CREDIT_NUM.Contain(model.BEFORE_CREDIT_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.AFTER_CREDIT_NUM))
				{
				  condition.And(RECORD_CREDIT_DEDUCTION._.AFTER_CREDIT_NUM.Contain(model.AFTER_CREDIT_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.VERSION))
				{
				  condition.And(RECORD_CREDIT_DEDUCTION._.VERSION.Contain(model.VERSION));
				}
		return condition;
	}
        #endregion
    }
}