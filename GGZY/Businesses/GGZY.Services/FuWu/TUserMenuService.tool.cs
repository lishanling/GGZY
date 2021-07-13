using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TUserMenuService : BaseServiceT<T_USER_MENU>
    {
        #region 接口实现
        
		public List<T_USER_MENU> FindList(T_USER_MENU model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_USER_MENU> PageList(T_USER_MENU model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_USER_MENU._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_USER_MENU._.ID == ID);
			
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
        public GeneralResult Edit(T_USER_MENU model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_USER_MENU entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.PID=model.PID;
		entity.NAME=model.NAME;
		entity.ORDER_BY=model.ORDER_BY;
		entity.URL=model.URL;
		entity.IMG=model.IMG;
		entity.IS_DEFAULT=model.IS_DEFAULT;
		entity.IS_EANBLED=model.IS_EANBLED;
		entity.ISURL=model.ISURL;
		entity.HEIGHT=model.HEIGHT;
		entity.WIDTH=model.WIDTH;
		entity.POWER_STR=model.POWER_STR;
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
        public GeneralResult Add(T_USER_MENU model)
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
                    Delete(T_USER_MENU._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_USER_MENU> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_USER_MENU model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_USER_MENU._.ID==(model.ID));
				}
				if(model.PID!=null)
				{
				  condition.And(T_USER_MENU._.PID==(model.PID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(T_USER_MENU._.NAME.Contain(model.NAME));
				}
				if(model.ORDER_BY!=null)
				{
				  condition.And(T_USER_MENU._.ORDER_BY==(model.ORDER_BY));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(T_USER_MENU._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.IMG))
				{
				  condition.And(T_USER_MENU._.IMG.Contain(model.IMG));
				}
				if(model.IS_DEFAULT!=null)
				{
				  condition.And(T_USER_MENU._.IS_DEFAULT==(model.IS_DEFAULT));
				}
				if(model.IS_EANBLED!=null)
				{
				  condition.And(T_USER_MENU._.IS_EANBLED==(model.IS_EANBLED));
				}
				if(model.ISURL!=null)
				{
				  condition.And(T_USER_MENU._.ISURL==(model.ISURL));
				}
				if(model.HEIGHT!=null)
				{
				  condition.And(T_USER_MENU._.HEIGHT==(model.HEIGHT));
				}
				if(model.WIDTH!=null)
				{
				  condition.And(T_USER_MENU._.WIDTH==(model.WIDTH));
				}
				if(!string.IsNullOrWhiteSpace(model.POWER_STR))
				{
				  condition.And(T_USER_MENU._.POWER_STR.Contain(model.POWER_STR));
				}
		return condition;
	}
        #endregion
    }
}