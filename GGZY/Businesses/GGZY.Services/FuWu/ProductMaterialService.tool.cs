using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ProductMaterialService : BaseServiceT<PRODUCT_MATERIAL>
    {
        #region 接口实现
        
		public List<PRODUCT_MATERIAL> FindList(PRODUCT_MATERIAL model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PRODUCT_MATERIAL> PageList(PRODUCT_MATERIAL model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PRODUCT_MATERIAL._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PRODUCT_MATERIAL._.ID == ID);
			
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
        public GeneralResult Edit(PRODUCT_MATERIAL model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PRODUCT_MATERIAL entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.PRODUCT_TYPE=model.PRODUCT_TYPE;
		entity.CLASSIFY_CODE=model.CLASSIFY_CODE;
		entity.PRODUCT_CODE=model.PRODUCT_CODE;
		entity.IS_SYS_PRODUCT=model.IS_SYS_PRODUCT;
		entity.PRODUCT_NAME=model.PRODUCT_NAME;
		entity.PRODUCT_LEVEL=model.PRODUCT_LEVEL;
		entity.UNIT=model.UNIT;
		entity.MFR_PRICE=model.MFR_PRICE;
		entity.MFR_OFFER_EXPLAIN=model.MFR_OFFER_EXPLAIN;
		entity.OFFER_DATE=model.OFFER_DATE;
		entity.BRAND=model.BRAND;
		entity.ORIGIN=model.ORIGIN;
		entity.PRODUCT_SP_ATTR=model.PRODUCT_SP_ATTR;
		entity.TECH_FEATURES=model.TECH_FEATURES;
		entity.TECH_PERF_INDI=model.TECH_PERF_INDI;
		entity.PRODUCT_DESC=model.PRODUCT_DESC;
		entity.SUPPLY_CYC=model.SUPPLY_CYC;
		entity.PRODUCT_PERF=model.PRODUCT_PERF;
		entity.USING=model.USING;
		entity.PACKAGING=model.PACKAGING;
		entity.DES_AND_INSTALL=model.DES_AND_INSTALL;
		entity.AFTER_SALES_SRV=model.AFTER_SALES_SRV;
		entity.CAPACITY=model.CAPACITY;
		entity.CAPACITY_UNIT=model.CAPACITY_UNIT;
		entity.INV_NUM=model.INV_NUM;
		entity.INV_UNIT=model.INV_UNIT;
		entity.PRODUCT_IMG=model.PRODUCT_IMG;
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
        public GeneralResult Add(PRODUCT_MATERIAL model)
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
                    Delete(PRODUCT_MATERIAL._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PRODUCT_MATERIAL> model)
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
       	protected WhereClipBuilder ConditionBuilder(PRODUCT_MATERIAL model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PRODUCT_MATERIAL._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_TYPE))
				{
				  condition.And(PRODUCT_MATERIAL._.PRODUCT_TYPE.Contain(model.PRODUCT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.CLASSIFY_CODE))
				{
				  condition.And(PRODUCT_MATERIAL._.CLASSIFY_CODE.Contain(model.CLASSIFY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_CODE))
				{
				  condition.And(PRODUCT_MATERIAL._.PRODUCT_CODE.Contain(model.PRODUCT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_SYS_PRODUCT))
				{
				  condition.And(PRODUCT_MATERIAL._.IS_SYS_PRODUCT.Contain(model.IS_SYS_PRODUCT));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_NAME))
				{
				  condition.And(PRODUCT_MATERIAL._.PRODUCT_NAME.Contain(model.PRODUCT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_LEVEL))
				{
				  condition.And(PRODUCT_MATERIAL._.PRODUCT_LEVEL.Contain(model.PRODUCT_LEVEL));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIT))
				{
				  condition.And(PRODUCT_MATERIAL._.UNIT.Contain(model.UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.MFR_PRICE))
				{
				  condition.And(PRODUCT_MATERIAL._.MFR_PRICE.Contain(model.MFR_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.MFR_OFFER_EXPLAIN))
				{
				  condition.And(PRODUCT_MATERIAL._.MFR_OFFER_EXPLAIN.Contain(model.MFR_OFFER_EXPLAIN));
				}
				if(model.OFFER_DATE!=null)
				{
				  condition.And(PRODUCT_MATERIAL._.OFFER_DATE==(model.OFFER_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.BRAND))
				{
				  condition.And(PRODUCT_MATERIAL._.BRAND.Contain(model.BRAND));
				}
				if(!string.IsNullOrWhiteSpace(model.ORIGIN))
				{
				  condition.And(PRODUCT_MATERIAL._.ORIGIN.Contain(model.ORIGIN));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_SP_ATTR))
				{
				  condition.And(PRODUCT_MATERIAL._.PRODUCT_SP_ATTR.Contain(model.PRODUCT_SP_ATTR));
				}
				if(!string.IsNullOrWhiteSpace(model.TECH_FEATURES))
				{
				  condition.And(PRODUCT_MATERIAL._.TECH_FEATURES.Contain(model.TECH_FEATURES));
				}
				if(!string.IsNullOrWhiteSpace(model.TECH_PERF_INDI))
				{
				  condition.And(PRODUCT_MATERIAL._.TECH_PERF_INDI.Contain(model.TECH_PERF_INDI));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_DESC))
				{
				  condition.And(PRODUCT_MATERIAL._.PRODUCT_DESC.Contain(model.PRODUCT_DESC));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPPLY_CYC))
				{
				  condition.And(PRODUCT_MATERIAL._.SUPPLY_CYC.Contain(model.SUPPLY_CYC));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_PERF))
				{
				  condition.And(PRODUCT_MATERIAL._.PRODUCT_PERF.Contain(model.PRODUCT_PERF));
				}
				if(!string.IsNullOrWhiteSpace(model.USING))
				{
				  condition.And(PRODUCT_MATERIAL._.USING.Contain(model.USING));
				}
				if(!string.IsNullOrWhiteSpace(model.PACKAGING))
				{
				  condition.And(PRODUCT_MATERIAL._.PACKAGING.Contain(model.PACKAGING));
				}
				if(!string.IsNullOrWhiteSpace(model.DES_AND_INSTALL))
				{
				  condition.And(PRODUCT_MATERIAL._.DES_AND_INSTALL.Contain(model.DES_AND_INSTALL));
				}
				if(!string.IsNullOrWhiteSpace(model.AFTER_SALES_SRV))
				{
				  condition.And(PRODUCT_MATERIAL._.AFTER_SALES_SRV.Contain(model.AFTER_SALES_SRV));
				}
				if(!string.IsNullOrWhiteSpace(model.CAPACITY))
				{
				  condition.And(PRODUCT_MATERIAL._.CAPACITY.Contain(model.CAPACITY));
				}
				if(!string.IsNullOrWhiteSpace(model.CAPACITY_UNIT))
				{
				  condition.And(PRODUCT_MATERIAL._.CAPACITY_UNIT.Contain(model.CAPACITY_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.INV_NUM))
				{
				  condition.And(PRODUCT_MATERIAL._.INV_NUM.Contain(model.INV_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.INV_UNIT))
				{
				  condition.And(PRODUCT_MATERIAL._.INV_UNIT.Contain(model.INV_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_IMG))
				{
				  condition.And(PRODUCT_MATERIAL._.PRODUCT_IMG.Contain(model.PRODUCT_IMG));
				}
		return condition;
	}
        #endregion
    }
}