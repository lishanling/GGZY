using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BhxxCompleteAcceptService : BaseServiceT<BHXX_COMPLETE_ACCEPT>
    {
        #region 接口实现
        
		public List<BHXX_COMPLETE_ACCEPT> FindList(BHXX_COMPLETE_ACCEPT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BHXX_COMPLETE_ACCEPT> PageList(BHXX_COMPLETE_ACCEPT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, BHXX_COMPLETE_ACCEPT._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(BHXX_COMPLETE_ACCEPT._.M_ID == M_ID);
			
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
        public GeneralResult Edit(BHXX_COMPLETE_ACCEPT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is BHXX_COMPLETE_ACCEPT entity)
	{		
		entity.Attach();
		entity.M_ID=model.M_ID;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_VERSION=model.M_VERSION;
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.PROJECT_NAME=model.PROJECT_NAME;
		entity.INVEST_PROJECT_CODE=model.INVEST_PROJECT_CODE;
		entity.PROJECT_FINISH_CHECK_NUM=model.PROJECT_FINISH_CHECK_NUM;
		entity.BUILDER_LICENCE_NUM=model.BUILDER_LICENCE_NUM;
		entity.FACT_COST=model.FACT_COST;
		entity.FACT_AREA=model.FACT_AREA;
		entity.LENGTH=model.LENGTH;
		entity.SPAN=model.SPAN;
		entity.FACT_SIZE=model.FACT_SIZE;
		entity.PROJECT_STRUCTURE_TYPE_NUM=model.PROJECT_STRUCTURE_TYPE_NUM;
		entity.BEGIN_DATE=model.BEGIN_DATE;
		entity.END_DATE=model.END_DATE;
		entity.REMARK=model.REMARK;
		entity.CREATE_DATE=model.CREATE_DATE;
		entity.CHECK_DEPART_NAME=model.CHECK_DEPART_NAME;
		entity.CHECK_PERSON_NAME=model.CHECK_PERSON_NAME;
		entity.DATA_SOURCE=model.DATA_SOURCE;
		entity.DATA_LEVEL=model.DATA_LEVEL;
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
        public GeneralResult Add(BHXX_COMPLETE_ACCEPT model)
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
                    Delete(BHXX_COMPLETE_ACCEPT._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BHXX_COMPLETE_ACCEPT> model)
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
       	protected WhereClipBuilder ConditionBuilder(BHXX_COMPLETE_ACCEPT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.M_VERSION.Contain(model.M_VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.PROJECT_NAME.Contain(model.PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.INVEST_PROJECT_CODE))
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.INVEST_PROJECT_CODE.Contain(model.INVEST_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_FINISH_CHECK_NUM))
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.PROJECT_FINISH_CHECK_NUM.Contain(model.PROJECT_FINISH_CHECK_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.BUILDER_LICENCE_NUM))
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.BUILDER_LICENCE_NUM.Contain(model.BUILDER_LICENCE_NUM));
				}
				if(model.FACT_COST!=null)
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.FACT_COST==(model.FACT_COST));
				}
				if(model.FACT_AREA!=null)
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.FACT_AREA==(model.FACT_AREA));
				}
				if(model.LENGTH!=null)
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.LENGTH==(model.LENGTH));
				}
				if(model.SPAN!=null)
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.SPAN==(model.SPAN));
				}
				if(!string.IsNullOrWhiteSpace(model.FACT_SIZE))
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.FACT_SIZE.Contain(model.FACT_SIZE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_STRUCTURE_TYPE_NUM))
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.PROJECT_STRUCTURE_TYPE_NUM.Contain(model.PROJECT_STRUCTURE_TYPE_NUM));
				}
				if(model.BEGIN_DATE!=null)
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.BEGIN_DATE==(model.BEGIN_DATE));
				}
				if(model.END_DATE!=null)
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.END_DATE==(model.END_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.REMARK.Contain(model.REMARK));
				}
				if(model.CREATE_DATE!=null)
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.CREATE_DATE==(model.CREATE_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.CHECK_DEPART_NAME))
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.CHECK_DEPART_NAME.Contain(model.CHECK_DEPART_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CHECK_PERSON_NAME))
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.CHECK_PERSON_NAME.Contain(model.CHECK_PERSON_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_LEVEL))
				{
				  condition.And(BHXX_COMPLETE_ACCEPT._.DATA_LEVEL.Contain(model.DATA_LEVEL));
				}
		return condition;
	}
        #endregion
    }
}