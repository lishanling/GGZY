using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TDishonestyExposureService : BaseServiceT<T_DISHONESTY_EXPOSURE>
    {
        #region 接口实现
        
		public List<T_DISHONESTY_EXPOSURE> FindList(T_DISHONESTY_EXPOSURE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_DISHONESTY_EXPOSURE> PageList(T_DISHONESTY_EXPOSURE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_DISHONESTY_EXPOSURE._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_DISHONESTY_EXPOSURE._.ID == ID);
			
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
        public GeneralResult Edit(T_DISHONESTY_EXPOSURE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_DISHONESTY_EXPOSURE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TITLE=model.TITLE;
		entity.COMPANY_NAME=model.COMPANY_NAME;
		entity.COMPANY_ADDRESS=model.COMPANY_ADDRESS;
		entity.DISHONESTY_CONTENT=model.DISHONESTY_CONTENT;
		entity.PUNISHMENT_RESULT=model.PUNISHMENT_RESULT;
		entity.PUNISHMENT_BASIS=model.PUNISHMENT_BASIS;
		entity.PUNISHMENT_DATE=model.PUNISHMENT_DATE;
		entity.PUNISHMENT_DEADLINE=model.PUNISHMENT_DEADLINE;
		entity.ENFORCEMENT_UNIT=model.ENFORCEMENT_UNIT;
		entity.AUDIT_STAFF=model.AUDIT_STAFF;
		entity.AUDIT_OPINION=model.AUDIT_OPINION;
		entity.ATTACHMENT=model.ATTACHMENT;
		entity.STATE=model.STATE;
		entity.COMMIT_TIME=model.COMMIT_TIME;
		entity.AUDIT_TIME=model.AUDIT_TIME;
		entity.USER_ID=model.USER_ID;
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
        public GeneralResult Add(T_DISHONESTY_EXPOSURE model)
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
                    Delete(T_DISHONESTY_EXPOSURE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_DISHONESTY_EXPOSURE> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_DISHONESTY_EXPOSURE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_DISHONESTY_EXPOSURE._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLE))
				{
				  condition.And(T_DISHONESTY_EXPOSURE._.TITLE.Contain(model.TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANY_NAME))
				{
				  condition.And(T_DISHONESTY_EXPOSURE._.COMPANY_NAME.Contain(model.COMPANY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANY_ADDRESS))
				{
				  condition.And(T_DISHONESTY_EXPOSURE._.COMPANY_ADDRESS.Contain(model.COMPANY_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.DISHONESTY_CONTENT))
				{
				  condition.And(T_DISHONESTY_EXPOSURE._.DISHONESTY_CONTENT.Contain(model.DISHONESTY_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUNISHMENT_RESULT))
				{
				  condition.And(T_DISHONESTY_EXPOSURE._.PUNISHMENT_RESULT.Contain(model.PUNISHMENT_RESULT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUNISHMENT_BASIS))
				{
				  condition.And(T_DISHONESTY_EXPOSURE._.PUNISHMENT_BASIS.Contain(model.PUNISHMENT_BASIS));
				}
				if(model.PUNISHMENT_DATE!=null)
				{
				  condition.And(T_DISHONESTY_EXPOSURE._.PUNISHMENT_DATE==(model.PUNISHMENT_DATE));
				}
				if(model.PUNISHMENT_DEADLINE!=null)
				{
				  condition.And(T_DISHONESTY_EXPOSURE._.PUNISHMENT_DEADLINE==(model.PUNISHMENT_DEADLINE));
				}
				if(!string.IsNullOrWhiteSpace(model.ENFORCEMENT_UNIT))
				{
				  condition.And(T_DISHONESTY_EXPOSURE._.ENFORCEMENT_UNIT.Contain(model.ENFORCEMENT_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.AUDIT_STAFF))
				{
				  condition.And(T_DISHONESTY_EXPOSURE._.AUDIT_STAFF.Contain(model.AUDIT_STAFF));
				}
				if(!string.IsNullOrWhiteSpace(model.AUDIT_OPINION))
				{
				  condition.And(T_DISHONESTY_EXPOSURE._.AUDIT_OPINION.Contain(model.AUDIT_OPINION));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTACHMENT))
				{
				  condition.And(T_DISHONESTY_EXPOSURE._.ATTACHMENT.Contain(model.ATTACHMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.STATE))
				{
				  condition.And(T_DISHONESTY_EXPOSURE._.STATE.Contain(model.STATE));
				}
				if(model.COMMIT_TIME!=null)
				{
				  condition.And(T_DISHONESTY_EXPOSURE._.COMMIT_TIME==(model.COMMIT_TIME));
				}
				if(model.AUDIT_TIME!=null)
				{
				  condition.And(T_DISHONESTY_EXPOSURE._.AUDIT_TIME==(model.AUDIT_TIME));
				}
				if(model.USER_ID!=null)
				{
				  condition.And(T_DISHONESTY_EXPOSURE._.USER_ID==(model.USER_ID));
				}
		return condition;
	}
        #endregion
    }
}