using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ReviewInstanceService : BaseServiceT<REVIEW_INSTANCE>
    {
        #region 接口实现
        
		public List<REVIEW_INSTANCE> FindList(REVIEW_INSTANCE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<REVIEW_INSTANCE> PageList(REVIEW_INSTANCE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, REVIEW_INSTANCE._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(REVIEW_INSTANCE._.ID == ID);
			
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
        public GeneralResult Edit(REVIEW_INSTANCE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is REVIEW_INSTANCE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.BA_ID=model.BA_ID;
		entity.MAIN_ID=model.MAIN_ID;
		entity.NOW_NODE=model.NOW_NODE;
		entity.IS_END=model.IS_END;
		entity.CREATE_TM=model.CREATE_TM;
		entity.CREATE_BY=model.CREATE_BY;
		entity.NOW_USERS=model.NOW_USERS;
		entity.STAFF=model.STAFF;
		entity.TIMEOUT=model.TIMEOUT;
		entity.IS_BACK=model.IS_BACK;
		entity.BACK_MSG=model.BACK_MSG;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.QTR=model.QTR;
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
        public GeneralResult Add(REVIEW_INSTANCE model)
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
                    Delete(REVIEW_INSTANCE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<REVIEW_INSTANCE> model)
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
       	protected WhereClipBuilder ConditionBuilder(REVIEW_INSTANCE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(REVIEW_INSTANCE._.ID==(model.ID));
				}
				if(model.BA_ID!=null)
				{
				  condition.And(REVIEW_INSTANCE._.BA_ID==(model.BA_ID));
				}
				if(model.MAIN_ID!=null)
				{
				  condition.And(REVIEW_INSTANCE._.MAIN_ID==(model.MAIN_ID));
				}
				if(model.NOW_NODE!=null)
				{
				  condition.And(REVIEW_INSTANCE._.NOW_NODE==(model.NOW_NODE));
				}
				if(model.IS_END!=null)
				{
				  condition.And(REVIEW_INSTANCE._.IS_END==(model.IS_END));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(REVIEW_INSTANCE._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.CREATE_BY!=null)
				{
				  condition.And(REVIEW_INSTANCE._.CREATE_BY==(model.CREATE_BY));
				}
				if(!string.IsNullOrWhiteSpace(model.NOW_USERS))
				{
				  condition.And(REVIEW_INSTANCE._.NOW_USERS.Contain(model.NOW_USERS));
				}
				if(!string.IsNullOrWhiteSpace(model.STAFF))
				{
				  condition.And(REVIEW_INSTANCE._.STAFF.Contain(model.STAFF));
				}
				if(model.TIMEOUT!=null)
				{
				  condition.And(REVIEW_INSTANCE._.TIMEOUT==(model.TIMEOUT));
				}
				if(model.IS_BACK!=null)
				{
				  condition.And(REVIEW_INSTANCE._.IS_BACK==(model.IS_BACK));
				}
				if(!string.IsNullOrWhiteSpace(model.BACK_MSG))
				{
				  condition.And(REVIEW_INSTANCE._.BACK_MSG.Contain(model.BACK_MSG));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(REVIEW_INSTANCE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.QTR))
				{
				  condition.And(REVIEW_INSTANCE._.QTR.Contain(model.QTR));
				}
		return condition;
	}
        #endregion
    }
}