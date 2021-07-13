using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TAfcChangeService : BaseServiceT<T_AFC_CHANGE>
    {
        #region 接口实现
        
		public List<T_AFC_CHANGE> FindList(T_AFC_CHANGE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_AFC_CHANGE> PageList(T_AFC_CHANGE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_AFC_CHANGE._.TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_AFC_CHANGE._.ID == ID);
			
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
        public GeneralResult Edit(T_AFC_CHANGE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_AFC_CHANGE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.AFC_ID=model.AFC_ID;
		entity.U_ID=model.U_ID;
		entity.TM=model.TM;
		entity.REMARK=model.REMARK;
		entity.APPROVAL_UID=model.APPROVAL_UID;
		entity.APPROVAL_STATE=model.APPROVAL_STATE;
		entity.APPROVAL_REMARK=model.APPROVAL_REMARK;
		entity.APPROVAL_TM=model.APPROVAL_TM;
		entity.AIDS=model.AIDS;
		entity.APPROVAL_UNAME=model.APPROVAL_UNAME;
		entity.APPROVAL_CONTACT_INFORMATION=model.APPROVAL_CONTACT_INFORMATION;
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
        public GeneralResult Add(T_AFC_CHANGE model)
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
                    Delete(T_AFC_CHANGE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_AFC_CHANGE> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_AFC_CHANGE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_AFC_CHANGE._.ID==(model.ID));
				}
				if(model.AFC_ID!=null)
				{
				  condition.And(T_AFC_CHANGE._.AFC_ID==(model.AFC_ID));
				}
				if(model.U_ID!=null)
				{
				  condition.And(T_AFC_CHANGE._.U_ID==(model.U_ID));
				}
				if(model.TM!=null)
				{
				  condition.And(T_AFC_CHANGE._.TM==(model.TM));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(T_AFC_CHANGE._.REMARK.Contain(model.REMARK));
				}
				if(model.APPROVAL_UID!=null)
				{
				  condition.And(T_AFC_CHANGE._.APPROVAL_UID==(model.APPROVAL_UID));
				}
				if(model.APPROVAL_STATE!=null)
				{
				  condition.And(T_AFC_CHANGE._.APPROVAL_STATE==(model.APPROVAL_STATE));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVAL_REMARK))
				{
				  condition.And(T_AFC_CHANGE._.APPROVAL_REMARK.Contain(model.APPROVAL_REMARK));
				}
				if(model.APPROVAL_TM!=null)
				{
				  condition.And(T_AFC_CHANGE._.APPROVAL_TM==(model.APPROVAL_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.AIDS))
				{
				  condition.And(T_AFC_CHANGE._.AIDS.Contain(model.AIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVAL_UNAME))
				{
				  condition.And(T_AFC_CHANGE._.APPROVAL_UNAME.Contain(model.APPROVAL_UNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVAL_CONTACT_INFORMATION))
				{
				  condition.And(T_AFC_CHANGE._.APPROVAL_CONTACT_INFORMATION.Contain(model.APPROVAL_CONTACT_INFORMATION));
				}
		return condition;
	}
        #endregion
    }
}