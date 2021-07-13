using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class EvaluationResultsService : BaseServiceT<EVALUATION_RESULTS>
    {
        #region 接口实现
        
		public List<EVALUATION_RESULTS> FindList(EVALUATION_RESULTS model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<EVALUATION_RESULTS> PageList(EVALUATION_RESULTS model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, EVALUATION_RESULTS._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(EVALUATION_RESULTS._.ID == ID);
			
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
        public GeneralResult Edit(EVALUATION_RESULTS model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is EVALUATION_RESULTS entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.BIDDING_PROJECT=model.BIDDING_PROJECT;
		entity.MAIN_EVALUATION=model.MAIN_EVALUATION;
		entity.EVALUATION_MATERIALS=model.EVALUATION_MATERIALS;
		entity.REVIEW_RESULTS=model.REVIEW_RESULTS;
		entity.REMARKS=model.REMARKS;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.OPEN_TIME=model.OPEN_TIME;
		entity.BID_HOUXUANREN=model.BID_HOUXUANREN;
		entity.REMARK=model.REMARK;
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
        public GeneralResult Add(EVALUATION_RESULTS model)
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
                    Delete(EVALUATION_RESULTS._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<EVALUATION_RESULTS> model)
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
       	protected WhereClipBuilder ConditionBuilder(EVALUATION_RESULTS model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(EVALUATION_RESULTS._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDING_PROJECT))
				{
				  condition.And(EVALUATION_RESULTS._.BIDDING_PROJECT.Contain(model.BIDDING_PROJECT));
				}
				if(!string.IsNullOrWhiteSpace(model.MAIN_EVALUATION))
				{
				  condition.And(EVALUATION_RESULTS._.MAIN_EVALUATION.Contain(model.MAIN_EVALUATION));
				}
				if(!string.IsNullOrWhiteSpace(model.EVALUATION_MATERIALS))
				{
				  condition.And(EVALUATION_RESULTS._.EVALUATION_MATERIALS.Contain(model.EVALUATION_MATERIALS));
				}
				if(!string.IsNullOrWhiteSpace(model.REVIEW_RESULTS))
				{
				  condition.And(EVALUATION_RESULTS._.REVIEW_RESULTS.Contain(model.REVIEW_RESULTS));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARKS))
				{
				  condition.And(EVALUATION_RESULTS._.REMARKS.Contain(model.REMARKS));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(EVALUATION_RESULTS._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(model.OPEN_TIME!=null)
				{
				  condition.And(EVALUATION_RESULTS._.OPEN_TIME==(model.OPEN_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_HOUXUANREN))
				{
				  condition.And(EVALUATION_RESULTS._.BID_HOUXUANREN.Contain(model.BID_HOUXUANREN));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(EVALUATION_RESULTS._.REMARK.Contain(model.REMARK));
				}
		return condition;
	}
        #endregion
    }
}