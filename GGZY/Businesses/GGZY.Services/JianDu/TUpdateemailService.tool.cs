using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TUpdateemailService : BaseServiceT<T_UPDATEEMAIL>
    {
        #region 接口实现
        
		public List<T_UPDATEEMAIL> FindList(T_UPDATEEMAIL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_UPDATEEMAIL> PageList(T_UPDATEEMAIL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_UPDATEEMAIL._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_UPDATEEMAIL._.ID == ID);
			
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
        public GeneralResult Edit(T_UPDATEEMAIL model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_UPDATEEMAIL entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.U_ID=model.U_ID;
		entity.CODE=model.CODE;
		entity.EMAIL_OLD=model.EMAIL_OLD;
		entity.EMAIL_NEW=model.EMAIL_NEW;
		entity.CREATE_TM=model.CREATE_TM;
		entity.IS_ENABLE=model.IS_ENABLE;
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
        public GeneralResult Add(T_UPDATEEMAIL model)
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
                    Delete(T_UPDATEEMAIL._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_UPDATEEMAIL> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_UPDATEEMAIL model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_UPDATEEMAIL._.ID==(model.ID));
				}
				if(model.U_ID!=null)
				{
				  condition.And(T_UPDATEEMAIL._.U_ID==(model.U_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(T_UPDATEEMAIL._.CODE.Contain(model.CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.EMAIL_OLD))
				{
				  condition.And(T_UPDATEEMAIL._.EMAIL_OLD.Contain(model.EMAIL_OLD));
				}
				if(!string.IsNullOrWhiteSpace(model.EMAIL_NEW))
				{
				  condition.And(T_UPDATEEMAIL._.EMAIL_NEW.Contain(model.EMAIL_NEW));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(T_UPDATEEMAIL._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.IS_ENABLE!=null)
				{
				  condition.And(T_UPDATEEMAIL._.IS_ENABLE==(model.IS_ENABLE));
				}
		return condition;
	}
        #endregion
    }
}