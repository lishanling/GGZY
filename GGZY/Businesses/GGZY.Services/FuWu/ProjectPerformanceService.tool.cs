using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ProjectPerformanceService : BaseServiceT<PROJECT_PERFORMANCE>
    {
        #region 接口实现
        
		public List<PROJECT_PERFORMANCE> FindList(PROJECT_PERFORMANCE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PROJECT_PERFORMANCE> PageList(PROJECT_PERFORMANCE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PROJECT_PERFORMANCE._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PROJECT_PERFORMANCE._.ID == ID);
			
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
        public GeneralResult Edit(PROJECT_PERFORMANCE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PROJECT_PERFORMANCE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.IDENTIFICATION_NUM=model.IDENTIFICATION_NUM;
		entity.UNIT_NAME=model.UNIT_NAME;
		entity.ENTRY_NAME=model.ENTRY_NAME;
		entity.OCCURRENCE_TIME=model.OCCURRENCE_TIME;
		entity.BID_AMOUNT=model.BID_AMOUNT;
		entity.PROJECT_COMPLETION=model.PROJECT_COMPLETION;
		entity.LETTER_ACCEPTANCE=model.LETTER_ACCEPTANCE;
		entity.APPENDICES_CONTRACT=model.APPENDICES_CONTRACT;
		entity.ITEM_REPORT=model.ITEM_REPORT;
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
        public GeneralResult Add(PROJECT_PERFORMANCE model)
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
                    Delete(PROJECT_PERFORMANCE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PROJECT_PERFORMANCE> model)
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
       	protected WhereClipBuilder ConditionBuilder(PROJECT_PERFORMANCE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PROJECT_PERFORMANCE._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.IDENTIFICATION_NUM))
				{
				  condition.And(PROJECT_PERFORMANCE._.IDENTIFICATION_NUM.Contain(model.IDENTIFICATION_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIT_NAME))
				{
				  condition.And(PROJECT_PERFORMANCE._.UNIT_NAME.Contain(model.UNIT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ENTRY_NAME))
				{
				  condition.And(PROJECT_PERFORMANCE._.ENTRY_NAME.Contain(model.ENTRY_NAME));
				}
				if(model.OCCURRENCE_TIME!=null)
				{
				  condition.And(PROJECT_PERFORMANCE._.OCCURRENCE_TIME==(model.OCCURRENCE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_AMOUNT))
				{
				  condition.And(PROJECT_PERFORMANCE._.BID_AMOUNT.Contain(model.BID_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_COMPLETION))
				{
				  condition.And(PROJECT_PERFORMANCE._.PROJECT_COMPLETION.Contain(model.PROJECT_COMPLETION));
				}
				if(!string.IsNullOrWhiteSpace(model.LETTER_ACCEPTANCE))
				{
				  condition.And(PROJECT_PERFORMANCE._.LETTER_ACCEPTANCE.Contain(model.LETTER_ACCEPTANCE));
				}
				if(!string.IsNullOrWhiteSpace(model.APPENDICES_CONTRACT))
				{
				  condition.And(PROJECT_PERFORMANCE._.APPENDICES_CONTRACT.Contain(model.APPENDICES_CONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.ITEM_REPORT))
				{
				  condition.And(PROJECT_PERFORMANCE._.ITEM_REPORT.Contain(model.ITEM_REPORT));
				}
		return condition;
	}
        #endregion
    }
}