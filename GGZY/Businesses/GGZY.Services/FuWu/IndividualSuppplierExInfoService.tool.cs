using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class IndividualSuppplierExInfoService : BaseServiceT<INDIVIDUAL_SUPPPLIER_EX_INFO>
    {
        #region 接口实现
        
		public List<INDIVIDUAL_SUPPPLIER_EX_INFO> FindList(INDIVIDUAL_SUPPPLIER_EX_INFO model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<INDIVIDUAL_SUPPPLIER_EX_INFO> PageList(INDIVIDUAL_SUPPPLIER_EX_INFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, INDIVIDUAL_SUPPPLIER_EX_INFO._.LEGAL_CODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="LEGAL_CODE">主体代码</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string LEGAL_CODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(INDIVIDUAL_SUPPPLIER_EX_INFO._.LEGAL_CODE == LEGAL_CODE);
			
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
        public GeneralResult Edit(INDIVIDUAL_SUPPPLIER_EX_INFO model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.LEGAL_CODE);
	
	if(viewResult.Success  && viewResult.Data is INDIVIDUAL_SUPPPLIER_EX_INFO entity)
	{		
		entity.Attach();
		entity.LEGAL_CODE=model.LEGAL_CODE;
		entity.CUSTOM_DEFINITION_DATAITEM=model.CUSTOM_DEFINITION_DATAITEM;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
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
        public GeneralResult Add(INDIVIDUAL_SUPPPLIER_EX_INFO model)
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
                    Delete(INDIVIDUAL_SUPPPLIER_EX_INFO._.LEGAL_CODE.SelectIn(idArr));
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
        public GeneralResult Import(List<INDIVIDUAL_SUPPPLIER_EX_INFO> model)
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
       	protected WhereClipBuilder ConditionBuilder(INDIVIDUAL_SUPPPLIER_EX_INFO model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.LEGAL_CODE))
				{
				  condition.And(INDIVIDUAL_SUPPPLIER_EX_INFO._.LEGAL_CODE.Contain(model.LEGAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CUSTOM_DEFINITION_DATAITEM))
				{
				  condition.And(INDIVIDUAL_SUPPPLIER_EX_INFO._.CUSTOM_DEFINITION_DATAITEM.Contain(model.CUSTOM_DEFINITION_DATAITEM));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(INDIVIDUAL_SUPPPLIER_EX_INFO._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(INDIVIDUAL_SUPPPLIER_EX_INFO._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(INDIVIDUAL_SUPPPLIER_EX_INFO._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
		return condition;
	}
        #endregion
    }
}