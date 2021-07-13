using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TBaseTradeCenterService : BaseServiceT<T_BASE_TRADE_CENTER>
    {
        #region 接口实现
        
		public List<T_BASE_TRADE_CENTER> FindList(T_BASE_TRADE_CENTER model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_BASE_TRADE_CENTER> PageList(T_BASE_TRADE_CENTER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_BASE_TRADE_CENTER._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_BASE_TRADE_CENTER._.ID == ID);
			
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
        public GeneralResult Edit(T_BASE_TRADE_CENTER model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_BASE_TRADE_CENTER entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.NAME=model.NAME;
		entity.LINK=model.LINK;
		entity.AREACODE=model.AREACODE;
		entity.X=model.X;
		entity.Y=model.Y;
		entity.ORDER_BY=model.ORDER_BY;
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
        public GeneralResult Add(T_BASE_TRADE_CENTER model)
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
                    Delete(T_BASE_TRADE_CENTER._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_BASE_TRADE_CENTER> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_BASE_TRADE_CENTER model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_BASE_TRADE_CENTER._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(T_BASE_TRADE_CENTER._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.LINK))
				{
				  condition.And(T_BASE_TRADE_CENTER._.LINK.Contain(model.LINK));
				}
				if(!string.IsNullOrWhiteSpace(model.AREACODE))
				{
				  condition.And(T_BASE_TRADE_CENTER._.AREACODE.Contain(model.AREACODE));
				}
				if(model.X!=null)
				{
				  condition.And(T_BASE_TRADE_CENTER._.X==(model.X));
				}
				if(model.Y!=null)
				{
				  condition.And(T_BASE_TRADE_CENTER._.Y==(model.Y));
				}
				if(model.ORDER_BY!=null)
				{
				  condition.And(T_BASE_TRADE_CENTER._.ORDER_BY==(model.ORDER_BY));
				}
		return condition;
	}
        #endregion
    }
}