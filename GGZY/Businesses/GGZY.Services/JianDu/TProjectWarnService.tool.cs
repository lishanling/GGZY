using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TProjectWarnService : BaseServiceT<T_PROJECT_WARN>
    {
        #region 接口实现
        
		public List<T_PROJECT_WARN> FindList(T_PROJECT_WARN model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_PROJECT_WARN> PageList(T_PROJECT_WARN model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_PROJECT_WARN._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_PROJECT_WARN._.ID == ID);
			
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
        public GeneralResult Edit(T_PROJECT_WARN model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_PROJECT_WARN entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.CODE=model.CODE;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.STATUS=model.STATUS;
		entity.MPIDS=model.MPIDS;
		entity.CONTENT=model.CONTENT;
		entity.SP_UID=model.SP_UID;
		entity.SP_YJ=model.SP_YJ;
		entity.SP_TM=model.SP_TM;
		entity.CREATE_UID=model.CREATE_UID;
		entity.CREATE_TM=model.CREATE_TM;
		entity.JS_PNOS=model.JS_PNOS;
		entity.IS_SENDMSG=model.IS_SENDMSG;
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
        public GeneralResult Add(T_PROJECT_WARN model)
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
                    Delete(T_PROJECT_WARN._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_PROJECT_WARN> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_PROJECT_WARN model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_PROJECT_WARN._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(T_PROJECT_WARN._.CODE.Contain(model.CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(T_PROJECT_WARN._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.STATUS))
				{
				  condition.And(T_PROJECT_WARN._.STATUS.Contain(model.STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.MPIDS))
				{
				  condition.And(T_PROJECT_WARN._.MPIDS.Contain(model.MPIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTENT))
				{
				  condition.And(T_PROJECT_WARN._.CONTENT.Contain(model.CONTENT));
				}
				if(model.SP_UID!=null)
				{
				  condition.And(T_PROJECT_WARN._.SP_UID==(model.SP_UID));
				}
				if(!string.IsNullOrWhiteSpace(model.SP_YJ))
				{
				  condition.And(T_PROJECT_WARN._.SP_YJ.Contain(model.SP_YJ));
				}
				if(model.SP_TM!=null)
				{
				  condition.And(T_PROJECT_WARN._.SP_TM==(model.SP_TM));
				}
				if(model.CREATE_UID!=null)
				{
				  condition.And(T_PROJECT_WARN._.CREATE_UID==(model.CREATE_UID));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(T_PROJECT_WARN._.CREATE_TM==(model.CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.JS_PNOS))
				{
				  condition.And(T_PROJECT_WARN._.JS_PNOS.Contain(model.JS_PNOS));
				}
				if(model.IS_SENDMSG!=null)
				{
				  condition.And(T_PROJECT_WARN._.IS_SENDMSG==(model.IS_SENDMSG));
				}
		return condition;
	}
        #endregion
    }
}