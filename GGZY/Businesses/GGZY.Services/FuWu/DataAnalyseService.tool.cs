using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class DataAnalyseService : BaseServiceT<DATA_ANALYSE>
    {
        #region 接口实现
        
		public List<DATA_ANALYSE> FindList(DATA_ANALYSE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<DATA_ANALYSE> PageList(DATA_ANALYSE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, DATA_ANALYSE._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(DATA_ANALYSE._.ID == ID);
			
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
        public GeneralResult Edit(DATA_ANALYSE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is DATA_ANALYSE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.DATA_ANALYSE_NAME=model.DATA_ANALYSE_NAME;
		entity.IS_ENABLE=model.IS_ENABLE;
		entity.ADD_PEOPLE=model.ADD_PEOPLE;
		entity.ADD_TIME=model.ADD_TIME;
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
        public GeneralResult Add(DATA_ANALYSE model)
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
                    Delete(DATA_ANALYSE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<DATA_ANALYSE> model)
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
       	protected WhereClipBuilder ConditionBuilder(DATA_ANALYSE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(DATA_ANALYSE._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_ANALYSE_NAME))
				{
				  condition.And(DATA_ANALYSE._.DATA_ANALYSE_NAME.Contain(model.DATA_ANALYSE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_ENABLE))
				{
				  condition.And(DATA_ANALYSE._.IS_ENABLE.Contain(model.IS_ENABLE));
				}
				if(!string.IsNullOrWhiteSpace(model.ADD_PEOPLE))
				{
				  condition.And(DATA_ANALYSE._.ADD_PEOPLE.Contain(model.ADD_PEOPLE));
				}
				if(model.ADD_TIME!=null)
				{
				  condition.And(DATA_ANALYSE._.ADD_TIME==(model.ADD_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(DATA_ANALYSE._.REMARK.Contain(model.REMARK));
				}
		return condition;
	}
        #endregion
    }
}