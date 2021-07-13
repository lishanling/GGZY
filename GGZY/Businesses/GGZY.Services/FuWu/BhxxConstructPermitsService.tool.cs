using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BhxxConstructPermitsService : BaseServiceT<BHXX_CONSTRUCT_PERMITS>
    {
        #region 接口实现
        
		public List<BHXX_CONSTRUCT_PERMITS> FindList(BHXX_CONSTRUCT_PERMITS model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BHXX_CONSTRUCT_PERMITS> PageList(BHXX_CONSTRUCT_PERMITS model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, BHXX_CONSTRUCT_PERMITS._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(BHXX_CONSTRUCT_PERMITS._.M_ID == M_ID);
			
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
        public GeneralResult Edit(BHXX_CONSTRUCT_PERMITS model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is BHXX_CONSTRUCT_PERMITS entity)
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
		entity.BUILDER_LICENCE_NUM=model.BUILDER_LICENCE_NUM;
		entity.BUILD_PLAN_NUM=model.BUILD_PLAN_NUM;
		entity.PROJECT_PLAN_NUM=model.PROJECT_PLAN_NUM;
		entity.TENDER_NUM=model.TENDER_NUM;
		entity.CENSOR_NUM=model.CENSOR_NUM;
		entity.BARGAIN_DAYS=model.BARGAIN_DAYS;
		entity.CONTRACT_MONEY=model.CONTRACT_MONEY;
		entity.AREA=model.AREA;
		entity.LENGTH=model.LENGTH;
		entity.SPAN=model.SPAN;
		entity.PROJECT_SIZE=model.PROJECT_SIZE;
		entity.RELEASE_DATE=model.RELEASE_DATE;
		entity.TWO_DIM_CODE=model.TWO_DIM_CODE;
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
        public GeneralResult Add(BHXX_CONSTRUCT_PERMITS model)
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
                    Delete(BHXX_CONSTRUCT_PERMITS._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BHXX_CONSTRUCT_PERMITS> model)
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
       	protected WhereClipBuilder ConditionBuilder(BHXX_CONSTRUCT_PERMITS model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.M_VERSION.Contain(model.M_VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.PROJECT_NAME.Contain(model.PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.INVEST_PROJECT_CODE))
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.INVEST_PROJECT_CODE.Contain(model.INVEST_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BUILDER_LICENCE_NUM))
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.BUILDER_LICENCE_NUM.Contain(model.BUILDER_LICENCE_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.BUILD_PLAN_NUM))
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.BUILD_PLAN_NUM.Contain(model.BUILD_PLAN_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_PLAN_NUM))
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.PROJECT_PLAN_NUM.Contain(model.PROJECT_PLAN_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_NUM))
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.TENDER_NUM.Contain(model.TENDER_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.CENSOR_NUM))
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.CENSOR_NUM.Contain(model.CENSOR_NUM));
				}
				if(model.BARGAIN_DAYS!=null)
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.BARGAIN_DAYS==(model.BARGAIN_DAYS));
				}
				if(model.CONTRACT_MONEY!=null)
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.CONTRACT_MONEY==(model.CONTRACT_MONEY));
				}
				if(model.AREA!=null)
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.AREA==(model.AREA));
				}
				if(model.LENGTH!=null)
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.LENGTH==(model.LENGTH));
				}
				if(model.SPAN!=null)
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.SPAN==(model.SPAN));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_SIZE))
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.PROJECT_SIZE.Contain(model.PROJECT_SIZE));
				}
				if(model.RELEASE_DATE!=null)
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.RELEASE_DATE==(model.RELEASE_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.TWO_DIM_CODE))
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.TWO_DIM_CODE.Contain(model.TWO_DIM_CODE));
				}
				if(model.CREATE_DATE!=null)
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.CREATE_DATE==(model.CREATE_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.CHECK_DEPART_NAME))
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.CHECK_DEPART_NAME.Contain(model.CHECK_DEPART_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CHECK_PERSON_NAME))
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.CHECK_PERSON_NAME.Contain(model.CHECK_PERSON_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_LEVEL))
				{
				  condition.And(BHXX_CONSTRUCT_PERMITS._.DATA_LEVEL.Contain(model.DATA_LEVEL));
				}
		return condition;
	}
        #endregion
    }
}