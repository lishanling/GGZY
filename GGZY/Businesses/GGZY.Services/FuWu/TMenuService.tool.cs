using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TMenuService : BaseServiceT<T_MENU>
    {
        #region 接口实现
        
		public List<T_MENU> FindList(T_MENU model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_MENU> PageList(T_MENU model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_MENU._.MENUID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="MENUID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? MENUID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_MENU._.MENUID == MENUID);
			
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
        public GeneralResult Edit(T_MENU model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.MENUID);
	
	if(viewResult.Success  && viewResult.Data is T_MENU entity)
	{		
		entity.Attach();
		entity.MENUID=model.MENUID;
		entity.PARENTID=model.PARENTID;
		entity.MNAME=model.MNAME;
		entity.ORDERID=model.ORDERID;
		entity.NAVIGATEURI=model.NAVIGATEURI;
		entity.COMMANDPATH=model.COMMANDPATH;
		entity.COMMANDCLASS=model.COMMANDCLASS;
		entity.IMAGEPATH=model.IMAGEPATH;
		entity.ISDEFAULT=model.ISDEFAULT;
		entity.ISEANBLED=model.ISEANBLED;
		entity.ISURL=model.ISURL;
		entity.ARGS=model.ARGS;
		entity.ISDISPLAY=model.ISDISPLAY;
		entity.OPTYPES=model.OPTYPES;
		entity.NHEIGHT=model.NHEIGHT;
		entity.NWIDTH=model.NWIDTH;
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
        public GeneralResult Add(T_MENU model)
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
                    Delete(T_MENU._.MENUID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_MENU> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_MENU model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.MENUID!=null)
				{
				  condition.And(T_MENU._.MENUID==(model.MENUID));
				}
				if(model.PARENTID!=null)
				{
				  condition.And(T_MENU._.PARENTID==(model.PARENTID));
				}
				if(!string.IsNullOrWhiteSpace(model.MNAME))
				{
				  condition.And(T_MENU._.MNAME.Contain(model.MNAME));
				}
				if(model.ORDERID!=null)
				{
				  condition.And(T_MENU._.ORDERID==(model.ORDERID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAVIGATEURI))
				{
				  condition.And(T_MENU._.NAVIGATEURI.Contain(model.NAVIGATEURI));
				}
				if(!string.IsNullOrWhiteSpace(model.COMMANDPATH))
				{
				  condition.And(T_MENU._.COMMANDPATH.Contain(model.COMMANDPATH));
				}
				if(!string.IsNullOrWhiteSpace(model.COMMANDCLASS))
				{
				  condition.And(T_MENU._.COMMANDCLASS.Contain(model.COMMANDCLASS));
				}
				if(!string.IsNullOrWhiteSpace(model.IMAGEPATH))
				{
				  condition.And(T_MENU._.IMAGEPATH.Contain(model.IMAGEPATH));
				}
				if(model.ISDEFAULT!=null)
				{
				  condition.And(T_MENU._.ISDEFAULT==(model.ISDEFAULT));
				}
				if(model.ISEANBLED!=null)
				{
				  condition.And(T_MENU._.ISEANBLED==(model.ISEANBLED));
				}
				if(model.ISURL!=null)
				{
				  condition.And(T_MENU._.ISURL==(model.ISURL));
				}
				if(!string.IsNullOrWhiteSpace(model.ARGS))
				{
				  condition.And(T_MENU._.ARGS.Contain(model.ARGS));
				}
				if(model.ISDISPLAY!=null)
				{
				  condition.And(T_MENU._.ISDISPLAY==(model.ISDISPLAY));
				}
				if(!string.IsNullOrWhiteSpace(model.OPTYPES))
				{
				  condition.And(T_MENU._.OPTYPES.Contain(model.OPTYPES));
				}
				if(model.NHEIGHT!=null)
				{
				  condition.And(T_MENU._.NHEIGHT==(model.NHEIGHT));
				}
				if(model.NWIDTH!=null)
				{
				  condition.And(T_MENU._.NWIDTH==(model.NWIDTH));
				}
		return condition;
	}
        #endregion
    }
}