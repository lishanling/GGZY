using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ReviewDepconfigService : BaseServiceT<REVIEW_DEPCONFIG>
    {
        #region 接口实现
        
		public List<REVIEW_DEPCONFIG> FindList(REVIEW_DEPCONFIG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<REVIEW_DEPCONFIG> PageList(REVIEW_DEPCONFIG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, REVIEW_DEPCONFIG._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(REVIEW_DEPCONFIG._.ID == ID);
			
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
        public GeneralResult Edit(REVIEW_DEPCONFIG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is REVIEW_DEPCONFIG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.NODE_ID=model.NODE_ID;
		entity.DEP_ID=model.DEP_ID;
		entity.USER_ID=model.USER_ID;
		entity.IS_MAIN=model.IS_MAIN;
		entity.IS_SELECT=model.IS_SELECT;
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
        public GeneralResult Add(REVIEW_DEPCONFIG model)
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
                    Delete(REVIEW_DEPCONFIG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<REVIEW_DEPCONFIG> model)
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
       	protected WhereClipBuilder ConditionBuilder(REVIEW_DEPCONFIG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(REVIEW_DEPCONFIG._.ID==(model.ID));
				}
				if(model.NODE_ID!=null)
				{
				  condition.And(REVIEW_DEPCONFIG._.NODE_ID==(model.NODE_ID));
				}
				if(model.DEP_ID!=null)
				{
				  condition.And(REVIEW_DEPCONFIG._.DEP_ID==(model.DEP_ID));
				}
				if(model.USER_ID!=null)
				{
				  condition.And(REVIEW_DEPCONFIG._.USER_ID==(model.USER_ID));
				}
				if(model.IS_MAIN!=null)
				{
				  condition.And(REVIEW_DEPCONFIG._.IS_MAIN==(model.IS_MAIN));
				}
				if(model.IS_SELECT!=null)
				{
				  condition.And(REVIEW_DEPCONFIG._.IS_SELECT==(model.IS_SELECT));
				}
		return condition;
	}
        #endregion
    }
}