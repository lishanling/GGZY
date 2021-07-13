using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ProductPartTableService : BaseServiceT<PRODUCT_PART_TABLE>
    {
        #region 接口实现
        
		public List<PRODUCT_PART_TABLE> FindList(PRODUCT_PART_TABLE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PRODUCT_PART_TABLE> PageList(PRODUCT_PART_TABLE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PRODUCT_PART_TABLE._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PRODUCT_PART_TABLE._.ID == ID);
			
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
        public GeneralResult Edit(PRODUCT_PART_TABLE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PRODUCT_PART_TABLE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.SYSTEM_NAME=model.SYSTEM_NAME;
		entity.EQUIPMENT_NAME=model.EQUIPMENT_NAME;
		entity.PART_NAME=model.PART_NAME;
		entity.MODAL_SIZE=model.MODAL_SIZE;
		entity.REMARK=model.REMARK;
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
        public GeneralResult Add(PRODUCT_PART_TABLE model)
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
                    Delete(PRODUCT_PART_TABLE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PRODUCT_PART_TABLE> model)
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
       	protected WhereClipBuilder ConditionBuilder(PRODUCT_PART_TABLE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PRODUCT_PART_TABLE._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.SYSTEM_NAME))
				{
				  condition.And(PRODUCT_PART_TABLE._.SYSTEM_NAME.Contain(model.SYSTEM_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.EQUIPMENT_NAME))
				{
				  condition.And(PRODUCT_PART_TABLE._.EQUIPMENT_NAME.Contain(model.EQUIPMENT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PART_NAME))
				{
				  condition.And(PRODUCT_PART_TABLE._.PART_NAME.Contain(model.PART_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MODAL_SIZE))
				{
				  condition.And(PRODUCT_PART_TABLE._.MODAL_SIZE.Contain(model.MODAL_SIZE));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(PRODUCT_PART_TABLE._.REMARK.Contain(model.REMARK));
				}
		return condition;
	}
        #endregion
    }
}