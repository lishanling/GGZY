using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class StatlSumService : BaseServiceT<STATL_SUM>
    {
        #region 接口实现
        
		public List<STATL_SUM> FindList(STATL_SUM model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<STATL_SUM> PageList(STATL_SUM model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, STATL_SUM._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(STATL_SUM._.ID == ID);
			
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
        public GeneralResult Edit(STATL_SUM model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is STATL_SUM entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.STATL_WAY_NAME=model.STATL_WAY_NAME;
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
        public GeneralResult Add(STATL_SUM model)
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
                    Delete(STATL_SUM._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<STATL_SUM> model)
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
       	protected WhereClipBuilder ConditionBuilder(STATL_SUM model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(STATL_SUM._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.STATL_WAY_NAME))
				{
				  condition.And(STATL_SUM._.STATL_WAY_NAME.Contain(model.STATL_WAY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_ENABLE))
				{
				  condition.And(STATL_SUM._.IS_ENABLE.Contain(model.IS_ENABLE));
				}
				if(!string.IsNullOrWhiteSpace(model.ADD_PEOPLE))
				{
				  condition.And(STATL_SUM._.ADD_PEOPLE.Contain(model.ADD_PEOPLE));
				}
				if(model.ADD_TIME!=null)
				{
				  condition.And(STATL_SUM._.ADD_TIME==(model.ADD_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(STATL_SUM._.REMARK.Contain(model.REMARK));
				}
		return condition;
	}
        #endregion
    }
}