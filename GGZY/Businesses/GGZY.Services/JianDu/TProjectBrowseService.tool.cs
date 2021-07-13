using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TProjectBrowseService : BaseServiceT<T_PROJECT_BROWSE>
    {
        #region 接口实现
        
		public List<T_PROJECT_BROWSE> FindList(T_PROJECT_BROWSE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_PROJECT_BROWSE> PageList(T_PROJECT_BROWSE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_PROJECT_BROWSE._.PROJECT_CODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="PROJECT_CODE">项目编号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string PROJECT_CODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_PROJECT_BROWSE._.PROJECT_CODE == PROJECT_CODE);
			
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
        public GeneralResult Edit(T_PROJECT_BROWSE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.PROJECT_CODE);
	
	if(viewResult.Success  && viewResult.Data is T_PROJECT_BROWSE entity)
	{		
		entity.Attach();
		entity.PROJECT_CODE=model.PROJECT_CODE;
		entity.PROJECT_NAME=model.PROJECT_NAME;
		entity.BROWSE_NUM=model.BROWSE_NUM;
		entity.PROJECT_CATEGORY=model.PROJECT_CATEGORY;
		entity.CREATE_TIME=model.CREATE_TIME;
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
        public GeneralResult Add(T_PROJECT_BROWSE model)
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
                    Delete(T_PROJECT_BROWSE._.PROJECT_CODE.SelectIn(idArr));
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
        public GeneralResult Import(List<T_PROJECT_BROWSE> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_PROJECT_BROWSE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CODE))
				{
				  condition.And(T_PROJECT_BROWSE._.PROJECT_CODE.Contain(model.PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_NAME))
				{
				  condition.And(T_PROJECT_BROWSE._.PROJECT_NAME.Contain(model.PROJECT_NAME));
				}
				if(model.BROWSE_NUM!=null)
				{
				  condition.And(T_PROJECT_BROWSE._.BROWSE_NUM==(model.BROWSE_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_CATEGORY))
				{
				  condition.And(T_PROJECT_BROWSE._.PROJECT_CATEGORY.Contain(model.PROJECT_CATEGORY));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_PROJECT_BROWSE._.CREATE_TIME==(model.CREATE_TIME));
				}
		return condition;
	}
        #endregion
    }
}