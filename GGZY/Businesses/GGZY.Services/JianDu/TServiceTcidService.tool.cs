using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TServiceTcidService : BaseServiceT<T_SERVICE_TCID>
    {
        #region 接口实现
        
		public List<T_SERVICE_TCID> FindList(T_SERVICE_TCID model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_SERVICE_TCID> PageList(T_SERVICE_TCID model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_SERVICE_TCID._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_SERVICE_TCID._.ID == ID);
			
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
        public GeneralResult Edit(T_SERVICE_TCID model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_SERVICE_TCID entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.CODE=model.CODE;
		entity.MODULE=model.MODULE;
		entity.NAME=model.NAME;
		entity.METHOD=model.METHOD;
		entity.FREQUEN=model.FREQUEN;
		entity.PRIORITY=model.PRIORITY;
		entity.USER_BY=model.USER_BY;
		entity.REMARK=model.REMARK;
		entity.IS_FIN=model.IS_FIN;
		entity.OPERATE_TIME=model.OPERATE_TIME;
		entity.OPERATE_BY=model.OPERATE_BY;
		entity.TCID=model.TCID;
		entity.TYPE=model.TYPE;
		entity.SYSCODE=model.SYSCODE;
		entity.GGFWTCID=model.GGFWTCID;
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
        public GeneralResult Add(T_SERVICE_TCID model)
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
                    Delete(T_SERVICE_TCID._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_SERVICE_TCID> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_SERVICE_TCID model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_SERVICE_TCID._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(T_SERVICE_TCID._.CODE.Contain(model.CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.MODULE))
				{
				  condition.And(T_SERVICE_TCID._.MODULE.Contain(model.MODULE));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(T_SERVICE_TCID._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.METHOD))
				{
				  condition.And(T_SERVICE_TCID._.METHOD.Contain(model.METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.FREQUEN))
				{
				  condition.And(T_SERVICE_TCID._.FREQUEN.Contain(model.FREQUEN));
				}
				if(!string.IsNullOrWhiteSpace(model.PRIORITY))
				{
				  condition.And(T_SERVICE_TCID._.PRIORITY.Contain(model.PRIORITY));
				}
				if(!string.IsNullOrWhiteSpace(model.USER_BY))
				{
				  condition.And(T_SERVICE_TCID._.USER_BY.Contain(model.USER_BY));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(T_SERVICE_TCID._.REMARK.Contain(model.REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_FIN))
				{
				  condition.And(T_SERVICE_TCID._.IS_FIN.Contain(model.IS_FIN));
				}
				if(model.OPERATE_TIME!=null)
				{
				  condition.And(T_SERVICE_TCID._.OPERATE_TIME==(model.OPERATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.OPERATE_BY))
				{
				  condition.And(T_SERVICE_TCID._.OPERATE_BY.Contain(model.OPERATE_BY));
				}
				if(!string.IsNullOrWhiteSpace(model.TCID))
				{
				  condition.And(T_SERVICE_TCID._.TCID.Contain(model.TCID));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPE))
				{
				  condition.And(T_SERVICE_TCID._.TYPE.Contain(model.TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SYSCODE))
				{
				  condition.And(T_SERVICE_TCID._.SYSCODE.Contain(model.SYSCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.GGFWTCID))
				{
				  condition.And(T_SERVICE_TCID._.GGFWTCID.Contain(model.GGFWTCID));
				}
		return condition;
	}
        #endregion
    }
}