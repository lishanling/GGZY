using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ProductValueService : BaseServiceT<PRODUCT_VALUE>
    {
        #region 接口实现
        
		public List<PRODUCT_VALUE> FindList(PRODUCT_VALUE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PRODUCT_VALUE> PageList(PRODUCT_VALUE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PRODUCT_VALUE._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PRODUCT_VALUE._.ID == ID);
			
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
        public GeneralResult Edit(PRODUCT_VALUE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PRODUCT_VALUE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.SYSTEM_NAME=model.SYSTEM_NAME;
		entity.EQUIPMENT_NAME=model.EQUIPMENT_NAME;
		entity.SPECIFICATION_MODEL=model.SPECIFICATION_MODEL;
		entity.FUNCTION_REQUIRE=model.FUNCTION_REQUIRE;
		entity.MANUFACTURER=model.MANUFACTURER;
		entity.AREA=model.AREA;
		entity.COUNT=model.COUNT;
		entity.UNIT_PRICE=model.UNIT_PRICE;
		entity.EQUIPMENT_PRICE=model.EQUIPMENT_PRICE;
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
        public GeneralResult Add(PRODUCT_VALUE model)
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
                    Delete(PRODUCT_VALUE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PRODUCT_VALUE> model)
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
       	protected WhereClipBuilder ConditionBuilder(PRODUCT_VALUE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PRODUCT_VALUE._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.SYSTEM_NAME))
				{
				  condition.And(PRODUCT_VALUE._.SYSTEM_NAME.Contain(model.SYSTEM_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.EQUIPMENT_NAME))
				{
				  condition.And(PRODUCT_VALUE._.EQUIPMENT_NAME.Contain(model.EQUIPMENT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SPECIFICATION_MODEL))
				{
				  condition.And(PRODUCT_VALUE._.SPECIFICATION_MODEL.Contain(model.SPECIFICATION_MODEL));
				}
				if(!string.IsNullOrWhiteSpace(model.FUNCTION_REQUIRE))
				{
				  condition.And(PRODUCT_VALUE._.FUNCTION_REQUIRE.Contain(model.FUNCTION_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.MANUFACTURER))
				{
				  condition.And(PRODUCT_VALUE._.MANUFACTURER.Contain(model.MANUFACTURER));
				}
				if(!string.IsNullOrWhiteSpace(model.AREA))
				{
				  condition.And(PRODUCT_VALUE._.AREA.Contain(model.AREA));
				}
				if(!string.IsNullOrWhiteSpace(model.COUNT))
				{
				  condition.And(PRODUCT_VALUE._.COUNT.Contain(model.COUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIT_PRICE))
				{
				  condition.And(PRODUCT_VALUE._.UNIT_PRICE.Contain(model.UNIT_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.EQUIPMENT_PRICE))
				{
				  condition.And(PRODUCT_VALUE._.EQUIPMENT_PRICE.Contain(model.EQUIPMENT_PRICE));
				}
		return condition;
	}
        #endregion
    }
}