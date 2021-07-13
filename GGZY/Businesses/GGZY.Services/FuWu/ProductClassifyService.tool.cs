using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ProductClassifyService : BaseServiceT<PRODUCT_CLASSIFY>
    {
        #region 接口实现
        
		public List<PRODUCT_CLASSIFY> FindList(PRODUCT_CLASSIFY model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PRODUCT_CLASSIFY> PageList(PRODUCT_CLASSIFY model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PRODUCT_CLASSIFY._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PRODUCT_CLASSIFY._.ID == ID);
			
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
        public GeneralResult Edit(PRODUCT_CLASSIFY model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PRODUCT_CLASSIFY entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.PRODUCT_FL_CODE=model.PRODUCT_FL_CODE;
		entity.PRODUCT_FL_NAME=model.PRODUCT_FL_NAME;
		entity.MATERIAL_TYPE=model.MATERIAL_TYPE;
		entity.PRODUCT_TYPE=model.PRODUCT_TYPE;
		entity.FL_JMPN=model.FL_JMPN;
		entity.FL_UNIT=model.FL_UNIT;
		entity.AUDIT_DATA=model.AUDIT_DATA;
		entity.AUDIT_HINT=model.AUDIT_HINT;
		entity.STOCKING_STANDARD=model.STOCKING_STANDARD;
		entity.PRODUCT_PRICE_EXPLAIN=model.PRODUCT_PRICE_EXPLAIN;
		entity.CO_REQID_QSMSG=model.CO_REQID_QSMSG;
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
        public GeneralResult Add(PRODUCT_CLASSIFY model)
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
                    Delete(PRODUCT_CLASSIFY._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PRODUCT_CLASSIFY> model)
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
       	protected WhereClipBuilder ConditionBuilder(PRODUCT_CLASSIFY model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PRODUCT_CLASSIFY._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_FL_CODE))
				{
				  condition.And(PRODUCT_CLASSIFY._.PRODUCT_FL_CODE.Contain(model.PRODUCT_FL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_FL_NAME))
				{
				  condition.And(PRODUCT_CLASSIFY._.PRODUCT_FL_NAME.Contain(model.PRODUCT_FL_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MATERIAL_TYPE))
				{
				  condition.And(PRODUCT_CLASSIFY._.MATERIAL_TYPE.Contain(model.MATERIAL_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_TYPE))
				{
				  condition.And(PRODUCT_CLASSIFY._.PRODUCT_TYPE.Contain(model.PRODUCT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.FL_JMPN))
				{
				  condition.And(PRODUCT_CLASSIFY._.FL_JMPN.Contain(model.FL_JMPN));
				}
				if(!string.IsNullOrWhiteSpace(model.FL_UNIT))
				{
				  condition.And(PRODUCT_CLASSIFY._.FL_UNIT.Contain(model.FL_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.AUDIT_DATA))
				{
				  condition.And(PRODUCT_CLASSIFY._.AUDIT_DATA.Contain(model.AUDIT_DATA));
				}
				if(!string.IsNullOrWhiteSpace(model.AUDIT_HINT))
				{
				  condition.And(PRODUCT_CLASSIFY._.AUDIT_HINT.Contain(model.AUDIT_HINT));
				}
				if(!string.IsNullOrWhiteSpace(model.STOCKING_STANDARD))
				{
				  condition.And(PRODUCT_CLASSIFY._.STOCKING_STANDARD.Contain(model.STOCKING_STANDARD));
				}
				if(!string.IsNullOrWhiteSpace(model.PRODUCT_PRICE_EXPLAIN))
				{
				  condition.And(PRODUCT_CLASSIFY._.PRODUCT_PRICE_EXPLAIN.Contain(model.PRODUCT_PRICE_EXPLAIN));
				}
				if(!string.IsNullOrWhiteSpace(model.CO_REQID_QSMSG))
				{
				  condition.And(PRODUCT_CLASSIFY._.CO_REQID_QSMSG.Contain(model.CO_REQID_QSMSG));
				}
		return condition;
	}
        #endregion
    }
}