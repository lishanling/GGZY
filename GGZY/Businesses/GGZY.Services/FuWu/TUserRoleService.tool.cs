﻿using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TUserroleService : BaseServiceT<T_USERROLE>
    {
        #region 接口实现
        
		public List<T_USERROLE> FindList(T_USERROLE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_USERROLE> PageList(T_USERROLE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_USERROLE._.ROLEID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ROLEID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ROLEID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_USERROLE._.ROLEID == ROLEID);
			
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
        public GeneralResult Edit(T_USERROLE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ROLEID);
	
	if(viewResult.Success  && viewResult.Data is T_USERROLE entity)
	{		
		entity.Attach();
		entity.ROLEID=model.ROLEID;
		entity.RNAME=model.RNAME;
		entity.RDESC=model.RDESC;
		entity.RINHERIT=model.RINHERIT;
		entity.ORDERID=model.ORDERID;
		entity.CREATEID=model.CREATEID;
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
        public GeneralResult Add(T_USERROLE model)
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
                    Delete(T_USERROLE._.ROLEID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_USERROLE> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_USERROLE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ROLEID!=null)
				{
				  condition.And(T_USERROLE._.ROLEID==(model.ROLEID));
				}
				if(!string.IsNullOrWhiteSpace(model.RNAME))
				{
				  condition.And(T_USERROLE._.RNAME.Contain(model.RNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.RDESC))
				{
				  condition.And(T_USERROLE._.RDESC.Contain(model.RDESC));
				}
				if(!string.IsNullOrWhiteSpace(model.RINHERIT))
				{
				  condition.And(T_USERROLE._.RINHERIT.Contain(model.RINHERIT));
				}
				if(model.ORDERID!=null)
				{
				  condition.And(T_USERROLE._.ORDERID==(model.ORDERID));
				}
				if(model.CREATEID!=null)
				{
				  condition.And(T_USERROLE._.CREATEID==(model.CREATEID));
				}
		return condition;
	}
        #endregion
    }
}