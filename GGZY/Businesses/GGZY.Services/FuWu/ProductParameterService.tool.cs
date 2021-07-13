using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ProductParameterService : BaseServiceT<PRODUCT_PARAMETER>
    {
        #region 接口实现
        
		public List<PRODUCT_PARAMETER> FindList(PRODUCT_PARAMETER model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PRODUCT_PARAMETER> PageList(PRODUCT_PARAMETER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PRODUCT_PARAMETER._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PRODUCT_PARAMETER._.ID == ID);
			
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
        public GeneralResult Edit(PRODUCT_PARAMETER model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PRODUCT_PARAMETER entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.PARAMETER_NAME=model.PARAMETER_NAME;
		entity.FILL_WAY=model.FILL_WAY;
		entity.UNIT=model.UNIT;
		entity.IS_SELECTION=model.IS_SELECTION;
		entity.IS_REQ=model.IS_REQ;
		entity.VALUE_TYPE=model.VALUE_TYPE;
		entity.PARAMETER_VALUE_LIST=model.PARAMETER_VALUE_LIST;
		entity.IS_FIX_SELLECTION=model.IS_FIX_SELLECTION;
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
        public GeneralResult Add(PRODUCT_PARAMETER model)
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
                    Delete(PRODUCT_PARAMETER._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PRODUCT_PARAMETER> model)
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
       	protected WhereClipBuilder ConditionBuilder(PRODUCT_PARAMETER model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PRODUCT_PARAMETER._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.PARAMETER_NAME))
				{
				  condition.And(PRODUCT_PARAMETER._.PARAMETER_NAME.Contain(model.PARAMETER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.FILL_WAY))
				{
				  condition.And(PRODUCT_PARAMETER._.FILL_WAY.Contain(model.FILL_WAY));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIT))
				{
				  condition.And(PRODUCT_PARAMETER._.UNIT.Contain(model.UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_SELECTION))
				{
				  condition.And(PRODUCT_PARAMETER._.IS_SELECTION.Contain(model.IS_SELECTION));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_REQ))
				{
				  condition.And(PRODUCT_PARAMETER._.IS_REQ.Contain(model.IS_REQ));
				}
				if(!string.IsNullOrWhiteSpace(model.VALUE_TYPE))
				{
				  condition.And(PRODUCT_PARAMETER._.VALUE_TYPE.Contain(model.VALUE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.PARAMETER_VALUE_LIST))
				{
				  condition.And(PRODUCT_PARAMETER._.PARAMETER_VALUE_LIST.Contain(model.PARAMETER_VALUE_LIST));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_FIX_SELLECTION))
				{
				  condition.And(PRODUCT_PARAMETER._.IS_FIX_SELLECTION.Contain(model.IS_FIX_SELLECTION));
				}
		return condition;
	}
        #endregion
    }
}