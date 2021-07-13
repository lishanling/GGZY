using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TAuditDetailService : BaseServiceT<T_AUDIT_DETAIL>
    {
        #region 接口实现
        
		public List<T_AUDIT_DETAIL> FindList(T_AUDIT_DETAIL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_AUDIT_DETAIL> PageList(T_AUDIT_DETAIL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_AUDIT_DETAIL._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_AUDIT_DETAIL._.ID == ID);
			
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
        public GeneralResult Edit(T_AUDIT_DETAIL model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_AUDIT_DETAIL entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.AUDIT_ID=model.AUDIT_ID;
		entity.TABLE_NAME=model.TABLE_NAME;
		entity.TABLE_FIELD=model.TABLE_FIELD;
		entity.OLD_VALUE=model.OLD_VALUE;
		entity.NEW_VALUE=model.NEW_VALUE;
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
        public GeneralResult Add(T_AUDIT_DETAIL model)
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
                    Delete(T_AUDIT_DETAIL._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_AUDIT_DETAIL> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_AUDIT_DETAIL model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_AUDIT_DETAIL._.ID==(model.ID));
				}
				if(model.AUDIT_ID!=null)
				{
				  condition.And(T_AUDIT_DETAIL._.AUDIT_ID==(model.AUDIT_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TABLE_NAME))
				{
				  condition.And(T_AUDIT_DETAIL._.TABLE_NAME.Contain(model.TABLE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TABLE_FIELD))
				{
				  condition.And(T_AUDIT_DETAIL._.TABLE_FIELD.Contain(model.TABLE_FIELD));
				}
				if(!string.IsNullOrWhiteSpace(model.OLD_VALUE))
				{
				  condition.And(T_AUDIT_DETAIL._.OLD_VALUE.Contain(model.OLD_VALUE));
				}
				if(!string.IsNullOrWhiteSpace(model.NEW_VALUE))
				{
				  condition.And(T_AUDIT_DETAIL._.NEW_VALUE.Contain(model.NEW_VALUE));
				}
		return condition;
	}
        #endregion
    }
}