using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class CreditAssessmentService : BaseServiceT<CREDIT_ASSESSMENT>
    {
        #region 接口实现
        
		public List<CREDIT_ASSESSMENT> FindList(CREDIT_ASSESSMENT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<CREDIT_ASSESSMENT> PageList(CREDIT_ASSESSMENT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, CREDIT_ASSESSMENT._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(CREDIT_ASSESSMENT._.ID == ID);
			
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
        public GeneralResult Edit(CREDIT_ASSESSMENT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is CREDIT_ASSESSMENT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.COMPANY_NAME=model.COMPANY_NAME;
		entity.CREDIT_SITUATION=model.CREDIT_SITUATION;
		entity.CREDIT_NOTE=model.CREDIT_NOTE;
		entity.TIMES=model.TIMES;
		entity.REMARKS=model.REMARKS;
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
        public GeneralResult Add(CREDIT_ASSESSMENT model)
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
                    Delete(CREDIT_ASSESSMENT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<CREDIT_ASSESSMENT> model)
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
       	protected WhereClipBuilder ConditionBuilder(CREDIT_ASSESSMENT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(CREDIT_ASSESSMENT._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANY_NAME))
				{
				  condition.And(CREDIT_ASSESSMENT._.COMPANY_NAME.Contain(model.COMPANY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CREDIT_SITUATION))
				{
				  condition.And(CREDIT_ASSESSMENT._.CREDIT_SITUATION.Contain(model.CREDIT_SITUATION));
				}
				if(!string.IsNullOrWhiteSpace(model.CREDIT_NOTE))
				{
				  condition.And(CREDIT_ASSESSMENT._.CREDIT_NOTE.Contain(model.CREDIT_NOTE));
				}
				if(model.TIMES!=null)
				{
				  condition.And(CREDIT_ASSESSMENT._.TIMES==(model.TIMES));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARKS))
				{
				  condition.And(CREDIT_ASSESSMENT._.REMARKS.Contain(model.REMARKS));
				}
		return condition;
	}
        #endregion
    }
}