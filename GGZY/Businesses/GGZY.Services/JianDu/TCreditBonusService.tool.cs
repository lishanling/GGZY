using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TCreditBonusService : BaseServiceT<T_CREDIT_BONUS>
    {
        #region 接口实现
        
		public List<T_CREDIT_BONUS> FindList(T_CREDIT_BONUS model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_CREDIT_BONUS> PageList(T_CREDIT_BONUS model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_CREDIT_BONUS._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_CREDIT_BONUS._.ID == ID);
			
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
        public GeneralResult Edit(T_CREDIT_BONUS model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_CREDIT_BONUS entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TITLE=model.TITLE;
		entity.REWARD_ENTERPRISE=model.REWARD_ENTERPRISE;
		entity.REWARD_CONTENT=model.REWARD_CONTENT;
		entity.AUDIT_STAFF=model.AUDIT_STAFF;
		entity.ATDIT_TIME=model.ATDIT_TIME;
		entity.ATTACHMENT=model.ATTACHMENT;
		entity.STATE=model.STATE;
		entity.COMMIT_TIME=model.COMMIT_TIME;
		entity.AUDIT_OPINION=model.AUDIT_OPINION;
		entity.USER_ID=model.USER_ID;
		entity.BODY_CODE=model.BODY_CODE;
		entity.BODY_TYPE=model.BODY_TYPE;
		entity.BODY_ROLE=model.BODY_ROLE;
		entity.REWARD_TYPE=model.REWARD_TYPE;
		entity.REWARD_TIME=model.REWARD_TIME;
		entity.DOCUMENT_NO=model.DOCUMENT_NO;
		entity.PUBLIC_SCOPE=model.PUBLIC_SCOPE;
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
        public GeneralResult Add(T_CREDIT_BONUS model)
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
                    Delete(T_CREDIT_BONUS._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_CREDIT_BONUS> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_CREDIT_BONUS model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_CREDIT_BONUS._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLE))
				{
				  condition.And(T_CREDIT_BONUS._.TITLE.Contain(model.TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.REWARD_ENTERPRISE))
				{
				  condition.And(T_CREDIT_BONUS._.REWARD_ENTERPRISE.Contain(model.REWARD_ENTERPRISE));
				}
				if(!string.IsNullOrWhiteSpace(model.REWARD_CONTENT))
				{
				  condition.And(T_CREDIT_BONUS._.REWARD_CONTENT.Contain(model.REWARD_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.AUDIT_STAFF))
				{
				  condition.And(T_CREDIT_BONUS._.AUDIT_STAFF.Contain(model.AUDIT_STAFF));
				}
				if(model.ATDIT_TIME!=null)
				{
				  condition.And(T_CREDIT_BONUS._.ATDIT_TIME==(model.ATDIT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTACHMENT))
				{
				  condition.And(T_CREDIT_BONUS._.ATTACHMENT.Contain(model.ATTACHMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.STATE))
				{
				  condition.And(T_CREDIT_BONUS._.STATE.Contain(model.STATE));
				}
				if(model.COMMIT_TIME!=null)
				{
				  condition.And(T_CREDIT_BONUS._.COMMIT_TIME==(model.COMMIT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.AUDIT_OPINION))
				{
				  condition.And(T_CREDIT_BONUS._.AUDIT_OPINION.Contain(model.AUDIT_OPINION));
				}
				if(model.USER_ID!=null)
				{
				  condition.And(T_CREDIT_BONUS._.USER_ID==(model.USER_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_CODE))
				{
				  condition.And(T_CREDIT_BONUS._.BODY_CODE.Contain(model.BODY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_TYPE))
				{
				  condition.And(T_CREDIT_BONUS._.BODY_TYPE.Contain(model.BODY_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BODY_ROLE))
				{
				  condition.And(T_CREDIT_BONUS._.BODY_ROLE.Contain(model.BODY_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.REWARD_TYPE))
				{
				  condition.And(T_CREDIT_BONUS._.REWARD_TYPE.Contain(model.REWARD_TYPE));
				}
				if(model.REWARD_TIME!=null)
				{
				  condition.And(T_CREDIT_BONUS._.REWARD_TIME==(model.REWARD_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.DOCUMENT_NO))
				{
				  condition.And(T_CREDIT_BONUS._.DOCUMENT_NO.Contain(model.DOCUMENT_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.PUBLIC_SCOPE))
				{
				  condition.And(T_CREDIT_BONUS._.PUBLIC_SCOPE.Contain(model.PUBLIC_SCOPE));
				}
		return condition;
	}
        #endregion
    }
}