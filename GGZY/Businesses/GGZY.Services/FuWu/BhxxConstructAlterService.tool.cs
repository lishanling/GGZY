using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BhxxConstructAlterService : BaseServiceT<BHXX_CONSTRUCT_ALTER>
    {
        #region 接口实现
        
		public List<BHXX_CONSTRUCT_ALTER> FindList(BHXX_CONSTRUCT_ALTER model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BHXX_CONSTRUCT_ALTER> PageList(BHXX_CONSTRUCT_ALTER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, BHXX_CONSTRUCT_ALTER._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(BHXX_CONSTRUCT_ALTER._.M_ID == M_ID);
			
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
        public GeneralResult Edit(BHXX_CONSTRUCT_ALTER model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is BHXX_CONSTRUCT_ALTER entity)
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
		entity.CHANGE_ITEM=model.CHANGE_ITEM;
		entity.BEFORE_VALUE=model.BEFORE_VALUE;
		entity.AFTET_VALUE=model.AFTET_VALUE;
		entity.CREATE_DATE=model.CREATE_DATE;
		entity.CHECK_DEPART_NAME=model.CHECK_DEPART_NAME;
		entity.CHECK_PERSON_NAME=model.CHECK_PERSON_NAME;
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
        public GeneralResult Add(BHXX_CONSTRUCT_ALTER model)
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
                    Delete(BHXX_CONSTRUCT_ALTER._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BHXX_CONSTRUCT_ALTER> model)
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
       	protected WhereClipBuilder ConditionBuilder(BHXX_CONSTRUCT_ALTER model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.M_ID!=null)
				{
				  condition.And(BHXX_CONSTRUCT_ALTER._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(BHXX_CONSTRUCT_ALTER._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(BHXX_CONSTRUCT_ALTER._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(BHXX_CONSTRUCT_ALTER._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(BHXX_CONSTRUCT_ALTER._.M_VERSION.Contain(model.M_VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(BHXX_CONSTRUCT_ALTER._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
				{
				  condition.And(BHXX_CONSTRUCT_ALTER._.PROJECT_NAME.Contain(model.PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.INVEST_PROJECT_CODE))
				{
				  condition.And(BHXX_CONSTRUCT_ALTER._.INVEST_PROJECT_CODE.Contain(model.INVEST_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BUILDER_LICENCE_NUM))
				{
				  condition.And(BHXX_CONSTRUCT_ALTER._.BUILDER_LICENCE_NUM.Contain(model.BUILDER_LICENCE_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.CHANGE_ITEM))
				{
				  condition.And(BHXX_CONSTRUCT_ALTER._.CHANGE_ITEM.Contain(model.CHANGE_ITEM));
				}
				if(!string.IsNullOrWhiteSpace(model.BEFORE_VALUE))
				{
				  condition.And(BHXX_CONSTRUCT_ALTER._.BEFORE_VALUE.Contain(model.BEFORE_VALUE));
				}
				if(!string.IsNullOrWhiteSpace(model.AFTET_VALUE))
				{
				  condition.And(BHXX_CONSTRUCT_ALTER._.AFTET_VALUE.Contain(model.AFTET_VALUE));
				}
				if(model.CREATE_DATE!=null)
				{
				  condition.And(BHXX_CONSTRUCT_ALTER._.CREATE_DATE==(model.CREATE_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.CHECK_DEPART_NAME))
				{
				  condition.And(BHXX_CONSTRUCT_ALTER._.CHECK_DEPART_NAME.Contain(model.CHECK_DEPART_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CHECK_PERSON_NAME))
				{
				  condition.And(BHXX_CONSTRUCT_ALTER._.CHECK_PERSON_NAME.Contain(model.CHECK_PERSON_NAME));
				}
		return condition;
	}
        #endregion
    }
}