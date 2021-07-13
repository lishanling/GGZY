using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ProductEqpService : BaseServiceT<PRODUCT_EQP>
    {
        #region 接口实现
        
		public List<PRODUCT_EQP> FindList(PRODUCT_EQP model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PRODUCT_EQP> PageList(PRODUCT_EQP model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PRODUCT_EQP._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PRODUCT_EQP._.ID == ID);
			
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
        public GeneralResult Edit(PRODUCT_EQP model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PRODUCT_EQP entity)
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
		entity.SI_GUIDE=model.SI_GUIDE;
		entity.SI_QUOTES=model.SI_QUOTES;
		entity.QUOTES_DATE=model.QUOTES_DATE;
		entity.SYS_NAME=model.SYS_NAME;
		entity.SI=model.SI;
		entity.BRAND=model.BRAND;
		entity.ORIGIN=model.ORIGIN;
		entity.PRODUCT_SP_ATTR=model.PRODUCT_SP_ATTR;
		entity.TECH_FEATURES=model.TECH_FEATURES;
		entity.TECH_PERF_INDI=model.TECH_PERF_INDI;
		entity.SYS_OVERVIEW=model.SYS_OVERVIEW;
		entity.SUPPLY_CYC=model.SUPPLY_CYC;
		entity.USING=model.USING;
		entity.DEBUG=model.DEBUG;
		entity.DES_CONTACT=model.DES_CONTACT;
		entity.INSTALL_SPVS=model.INSTALL_SPVS;
		entity.TRAIN=model.TRAIN;
		entity.PRJ_MGT=model.PRJ_MGT;
		entity.WARRANTY_SRV=model.WARRANTY_SRV;
		entity.MODIFY_TIME=model.MODIFY_TIME;
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
        public GeneralResult Add(PRODUCT_EQP model)
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
                    Delete(PRODUCT_EQP._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PRODUCT_EQP> model)
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
       	protected WhereClipBuilder ConditionBuilder(PRODUCT_EQP model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PRODUCT_EQP._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_TYPE))
				{
				  condition.And(PRODUCT_EQP._.PRODUCT_TYPE.Contain(model.PRODUCT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.CLASSIFY_CODE))
				{
				  condition.And(PRODUCT_EQP._.CLASSIFY_CODE.Contain(model.CLASSIFY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_CODE))
				{
				  condition.And(PRODUCT_EQP._.PRODUCT_CODE.Contain(model.PRODUCT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_SYS_PRODUCT))
				{
				  condition.And(PRODUCT_EQP._.IS_SYS_PRODUCT.Contain(model.IS_SYS_PRODUCT));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_NAME))
				{
				  condition.And(PRODUCT_EQP._.PRODUCT_NAME.Contain(model.PRODUCT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_LEVEL))
				{
				  condition.And(PRODUCT_EQP._.PRODUCT_LEVEL.Contain(model.PRODUCT_LEVEL));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIT))
				{
				  condition.And(PRODUCT_EQP._.UNIT.Contain(model.UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.SI_GUIDE))
				{
				  condition.And(PRODUCT_EQP._.SI_GUIDE.Contain(model.SI_GUIDE));
				}
				if(!string.IsNullOrWhiteSpace(model.SI_QUOTES))
				{
				  condition.And(PRODUCT_EQP._.SI_QUOTES.Contain(model.SI_QUOTES));
				}
				if(model.QUOTES_DATE!=null)
				{
				  condition.And(PRODUCT_EQP._.QUOTES_DATE==(model.QUOTES_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.SYS_NAME))
				{
				  condition.And(PRODUCT_EQP._.SYS_NAME.Contain(model.SYS_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SI))
				{
				  condition.And(PRODUCT_EQP._.SI.Contain(model.SI));
				}
				if(!string.IsNullOrWhiteSpace(model.BRAND))
				{
				  condition.And(PRODUCT_EQP._.BRAND.Contain(model.BRAND));
				}
				if(!string.IsNullOrWhiteSpace(model.ORIGIN))
				{
				  condition.And(PRODUCT_EQP._.ORIGIN.Contain(model.ORIGIN));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_SP_ATTR))
				{
				  condition.And(PRODUCT_EQP._.PRODUCT_SP_ATTR.Contain(model.PRODUCT_SP_ATTR));
				}
				if(!string.IsNullOrWhiteSpace(model.TECH_FEATURES))
				{
				  condition.And(PRODUCT_EQP._.TECH_FEATURES.Contain(model.TECH_FEATURES));
				}
				if(!string.IsNullOrWhiteSpace(model.TECH_PERF_INDI))
				{
				  condition.And(PRODUCT_EQP._.TECH_PERF_INDI.Contain(model.TECH_PERF_INDI));
				}
				if(!string.IsNullOrWhiteSpace(model.SYS_OVERVIEW))
				{
				  condition.And(PRODUCT_EQP._.SYS_OVERVIEW.Contain(model.SYS_OVERVIEW));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPPLY_CYC))
				{
				  condition.And(PRODUCT_EQP._.SUPPLY_CYC.Contain(model.SUPPLY_CYC));
				}
				if(!string.IsNullOrWhiteSpace(model.USING))
				{
				  condition.And(PRODUCT_EQP._.USING.Contain(model.USING));
				}
				if(!string.IsNullOrWhiteSpace(model.DEBUG))
				{
				  condition.And(PRODUCT_EQP._.DEBUG.Contain(model.DEBUG));
				}
				if(!string.IsNullOrWhiteSpace(model.DES_CONTACT))
				{
				  condition.And(PRODUCT_EQP._.DES_CONTACT.Contain(model.DES_CONTACT));
				}
				if(!string.IsNullOrWhiteSpace(model.INSTALL_SPVS))
				{
				  condition.And(PRODUCT_EQP._.INSTALL_SPVS.Contain(model.INSTALL_SPVS));
				}
				if(!string.IsNullOrWhiteSpace(model.TRAIN))
				{
				  condition.And(PRODUCT_EQP._.TRAIN.Contain(model.TRAIN));
				}
				if(!string.IsNullOrWhiteSpace(model.PRJ_MGT))
				{
				  condition.And(PRODUCT_EQP._.PRJ_MGT.Contain(model.PRJ_MGT));
				}
				if(!string.IsNullOrWhiteSpace(model.WARRANTY_SRV))
				{
				  condition.And(PRODUCT_EQP._.WARRANTY_SRV.Contain(model.WARRANTY_SRV));
				}
				if(model.MODIFY_TIME!=null)
				{
				  condition.And(PRODUCT_EQP._.MODIFY_TIME==(model.MODIFY_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_IMG))
				{
				  condition.And(PRODUCT_EQP._.PRODUCT_IMG.Contain(model.PRODUCT_IMG));
				}
		return condition;
	}
        #endregion
    }
}