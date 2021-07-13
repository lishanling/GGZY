using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ProductAnalysisService : BaseServiceT<PRODUCT_ANALYSIS>
    {
        #region 接口实现
        
		public List<PRODUCT_ANALYSIS> FindList(PRODUCT_ANALYSIS model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PRODUCT_ANALYSIS> PageList(PRODUCT_ANALYSIS model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PRODUCT_ANALYSIS._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PRODUCT_ANALYSIS._.ID == ID);
			
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
        public GeneralResult Edit(PRODUCT_ANALYSIS model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PRODUCT_ANALYSIS entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.REPORT_NAME=model.REPORT_NAME;
		entity.ENABLE=model.ENABLE;
		entity.ADD_MAN=model.ADD_MAN;
		entity.ADD_TIME=model.ADD_TIME;
		entity.ASSOCIATION_TABLE=model.ASSOCIATION_TABLE;
		entity.ASSOCIATION_FIELD=model.ASSOCIATION_FIELD;
		entity.REMARKS=model.REMARKS;
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
        public GeneralResult Add(PRODUCT_ANALYSIS model)
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
                    Delete(PRODUCT_ANALYSIS._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PRODUCT_ANALYSIS> model)
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
       	protected WhereClipBuilder ConditionBuilder(PRODUCT_ANALYSIS model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PRODUCT_ANALYSIS._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.REPORT_NAME))
				{
				  condition.And(PRODUCT_ANALYSIS._.REPORT_NAME.Contain(model.REPORT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ENABLE))
				{
				  condition.And(PRODUCT_ANALYSIS._.ENABLE.Contain(model.ENABLE));
				}
				if(!string.IsNullOrWhiteSpace(model.ADD_MAN))
				{
				  condition.And(PRODUCT_ANALYSIS._.ADD_MAN.Contain(model.ADD_MAN));
				}
				if(model.ADD_TIME!=null)
				{
				  condition.And(PRODUCT_ANALYSIS._.ADD_TIME==(model.ADD_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.ASSOCIATION_TABLE))
				{
				  condition.And(PRODUCT_ANALYSIS._.ASSOCIATION_TABLE.Contain(model.ASSOCIATION_TABLE));
				}
				if(!string.IsNullOrWhiteSpace(model.ASSOCIATION_FIELD))
				{
				  condition.And(PRODUCT_ANALYSIS._.ASSOCIATION_FIELD.Contain(model.ASSOCIATION_FIELD));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARKS))
				{
				  condition.And(PRODUCT_ANALYSIS._.REMARKS.Contain(model.REMARKS));
				}
		return condition;
	}
        #endregion
    }
}