using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TAccesstoapplicationService : BaseServiceT<T_ACCESSTOAPPLICATION>
    {
        #region 接口实现
        
		public List<T_ACCESSTOAPPLICATION> FindList(T_ACCESSTOAPPLICATION model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_ACCESSTOAPPLICATION> PageList(T_ACCESSTOAPPLICATION model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_ACCESSTOAPPLICATION._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_ACCESSTOAPPLICATION._.ID == ID);
			
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
        public GeneralResult Edit(T_ACCESSTOAPPLICATION model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_ACCESSTOAPPLICATION entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TITLE=model.TITLE;
		entity.BOROW_CONTENT=model.BOROW_CONTENT;
		entity.AUDIT_STAFF=model.AUDIT_STAFF;
		entity.AUDIT_TIME=model.AUDIT_TIME;
		entity.ATTACHMENT=model.ATTACHMENT;
		entity.STATE=model.STATE;
		entity.COMMIT_TIME=model.COMMIT_TIME;
		entity.AUDIT_OPINION=model.AUDIT_OPINION;
		entity.USER_ID=model.USER_ID;
		entity.AUDIT_DEPID=model.AUDIT_DEPID;
		entity.PROJECT_IDS=model.PROJECT_IDS;
		entity.EXPIRE_TM=model.EXPIRE_TM;
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
        public GeneralResult Add(T_ACCESSTOAPPLICATION model)
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
                    Delete(T_ACCESSTOAPPLICATION._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_ACCESSTOAPPLICATION> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_ACCESSTOAPPLICATION model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_ACCESSTOAPPLICATION._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLE))
				{
				  condition.And(T_ACCESSTOAPPLICATION._.TITLE.Contain(model.TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.BOROW_CONTENT))
				{
				  condition.And(T_ACCESSTOAPPLICATION._.BOROW_CONTENT.Contain(model.BOROW_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.AUDIT_STAFF))
				{
				  condition.And(T_ACCESSTOAPPLICATION._.AUDIT_STAFF.Contain(model.AUDIT_STAFF));
				}
				if(model.AUDIT_TIME!=null)
				{
				  condition.And(T_ACCESSTOAPPLICATION._.AUDIT_TIME==(model.AUDIT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTACHMENT))
				{
				  condition.And(T_ACCESSTOAPPLICATION._.ATTACHMENT.Contain(model.ATTACHMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.STATE))
				{
				  condition.And(T_ACCESSTOAPPLICATION._.STATE.Contain(model.STATE));
				}
				if(model.COMMIT_TIME!=null)
				{
				  condition.And(T_ACCESSTOAPPLICATION._.COMMIT_TIME==(model.COMMIT_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.AUDIT_OPINION))
				{
				  condition.And(T_ACCESSTOAPPLICATION._.AUDIT_OPINION.Contain(model.AUDIT_OPINION));
				}
				if(model.USER_ID!=null)
				{
				  condition.And(T_ACCESSTOAPPLICATION._.USER_ID==(model.USER_ID));
				}
				if(model.AUDIT_DEPID!=null)
				{
				  condition.And(T_ACCESSTOAPPLICATION._.AUDIT_DEPID==(model.AUDIT_DEPID));
				}
				if(!string.IsNullOrWhiteSpace(model.PROJECT_IDS))
				{
				  condition.And(T_ACCESSTOAPPLICATION._.PROJECT_IDS.Contain(model.PROJECT_IDS));
				}
				if(model.EXPIRE_TM!=null)
				{
				  condition.And(T_ACCESSTOAPPLICATION._.EXPIRE_TM==(model.EXPIRE_TM));
				}
		return condition;
	}
        #endregion
    }
}