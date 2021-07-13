using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TTpColumnsService : BaseServiceT<T_TP_COLUMNS>
    {
        #region 接口实现
        
		public List<T_TP_COLUMNS> FindList(T_TP_COLUMNS model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_TP_COLUMNS> PageList(T_TP_COLUMNS model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_TP_COLUMNS._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_TP_COLUMNS._.ID == ID);
			
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
        public GeneralResult Edit(T_TP_COLUMNS model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_TP_COLUMNS entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.CODE=model.CODE;
		entity.COLUMN_CODE=model.COLUMN_CODE;
		entity.COLUMN_NAME=model.COLUMN_NAME;
		entity.FIELD_TYPE=model.FIELD_TYPE;
		entity.ORDER_ID=model.ORDER_ID;
		entity.CREATE_TM=model.CREATE_TM;
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
        public GeneralResult Add(T_TP_COLUMNS model)
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
                    Delete(T_TP_COLUMNS._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_TP_COLUMNS> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_TP_COLUMNS model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_TP_COLUMNS._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(T_TP_COLUMNS._.CODE.Contain(model.CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.COLUMN_CODE))
				{
				  condition.And(T_TP_COLUMNS._.COLUMN_CODE.Contain(model.COLUMN_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.COLUMN_NAME))
				{
				  condition.And(T_TP_COLUMNS._.COLUMN_NAME.Contain(model.COLUMN_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.FIELD_TYPE))
				{
				  condition.And(T_TP_COLUMNS._.FIELD_TYPE.Contain(model.FIELD_TYPE));
				}
				if(model.ORDER_ID!=null)
				{
				  condition.And(T_TP_COLUMNS._.ORDER_ID==(model.ORDER_ID));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(T_TP_COLUMNS._.CREATE_TM==(model.CREATE_TM));
				}
		return condition;
	}
        #endregion
    }
}