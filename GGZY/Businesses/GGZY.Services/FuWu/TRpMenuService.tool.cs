using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TRpMenuService : BaseServiceT<T_RP_MENU>
    {
        #region 接口实现
        
		public List<T_RP_MENU> FindList(T_RP_MENU model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_RP_MENU> PageList(T_RP_MENU model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_RP_MENU._.MENU_CODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="MENU_CODE"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string MENU_CODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_RP_MENU._.MENU_CODE == MENU_CODE);
			
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
        public GeneralResult Edit(T_RP_MENU model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.MENU_CODE);
	
	if(viewResult.Success  && viewResult.Data is T_RP_MENU entity)
	{		
		entity.Attach();
		entity.MENU_CODE=model.MENU_CODE;
		entity.P_CODE=model.P_CODE;
		entity.NAME=model.NAME;
		entity.ORDER_ID=model.ORDER_ID;
		entity.CREATE_BY=model.CREATE_BY;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.SYS_CODE=model.SYS_CODE;
		entity.IS_VISIBLE=model.IS_VISIBLE;
		entity.URL=model.URL;
		entity.RP_CODE=model.RP_CODE;
		entity.IS_DEFAULT=model.IS_DEFAULT;
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
        public GeneralResult Add(T_RP_MENU model)
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
                    Delete(T_RP_MENU._.MENU_CODE.SelectIn(idArr));
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
        public GeneralResult Import(List<T_RP_MENU> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_RP_MENU model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.MENU_CODE))
				{
				  condition.And(T_RP_MENU._.MENU_CODE.Contain(model.MENU_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.P_CODE))
				{
				  condition.And(T_RP_MENU._.P_CODE.Contain(model.P_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(T_RP_MENU._.NAME.Contain(model.NAME));
				}
				if(model.ORDER_ID!=null)
				{
				  condition.And(T_RP_MENU._.ORDER_ID==(model.ORDER_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.CREATE_BY))
				{
				  condition.And(T_RP_MENU._.CREATE_BY.Contain(model.CREATE_BY));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_RP_MENU._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.SYS_CODE))
				{
				  condition.And(T_RP_MENU._.SYS_CODE.Contain(model.SYS_CODE));
				}
				if(model.IS_VISIBLE!=null)
				{
				  condition.And(T_RP_MENU._.IS_VISIBLE==(model.IS_VISIBLE));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(T_RP_MENU._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.RP_CODE))
				{
				  condition.And(T_RP_MENU._.RP_CODE.Contain(model.RP_CODE));
				}
				if(model.IS_DEFAULT!=null)
				{
				  condition.And(T_RP_MENU._.IS_DEFAULT==(model.IS_DEFAULT));
				}
		return condition;
	}
        #endregion
    }
}