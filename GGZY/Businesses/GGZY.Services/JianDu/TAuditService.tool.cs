using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TAuditService : BaseServiceT<T_AUDIT>
    {
        #region 接口实现
        
		public List<T_AUDIT> FindList(T_AUDIT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_AUDIT> PageList(T_AUDIT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_AUDIT._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_AUDIT._.ID == ID);
			
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
        public GeneralResult Edit(T_AUDIT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_AUDIT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TCID=model.TCID;
		entity.CREATE_BY=model.CREATE_BY;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.OPER_TYPE=model.OPER_TYPE;
		entity.ADD_TYPE=model.ADD_TYPE;
		entity.KEY1=model.KEY1;
		entity.KEY2=model.KEY2;
		entity.KEY5=model.KEY5;
		entity.KEY4=model.KEY4;
		entity.KEY3=model.KEY3;
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
        public GeneralResult Add(T_AUDIT model)
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
                    Delete(T_AUDIT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_AUDIT> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_AUDIT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_AUDIT._.ID==(model.ID));
				}
				if(model.TCID!=null)
				{
				  condition.And(T_AUDIT._.TCID==(model.TCID));
				}
				if(model.CREATE_BY!=null)
				{
				  condition.And(T_AUDIT._.CREATE_BY==(model.CREATE_BY));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_AUDIT._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(model.OPER_TYPE!=null)
				{
				  condition.And(T_AUDIT._.OPER_TYPE==(model.OPER_TYPE));
				}
				if(model.ADD_TYPE!=null)
				{
				  condition.And(T_AUDIT._.ADD_TYPE==(model.ADD_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.KEY1))
				{
				  condition.And(T_AUDIT._.KEY1.Contain(model.KEY1));
				}
				if(!string.IsNullOrWhiteSpace(model.KEY2))
				{
				  condition.And(T_AUDIT._.KEY2.Contain(model.KEY2));
				}
				if(!string.IsNullOrWhiteSpace(model.KEY5))
				{
				  condition.And(T_AUDIT._.KEY5.Contain(model.KEY5));
				}
				if(!string.IsNullOrWhiteSpace(model.KEY4))
				{
				  condition.And(T_AUDIT._.KEY4.Contain(model.KEY4));
				}
				if(!string.IsNullOrWhiteSpace(model.KEY3))
				{
				  condition.And(T_AUDIT._.KEY3.Contain(model.KEY3));
				}
		return condition;
	}
        #endregion
    }
}