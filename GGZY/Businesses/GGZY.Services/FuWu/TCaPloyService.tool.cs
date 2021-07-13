using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TCaPloyService : BaseServiceT<T_CA_PLOY>
    {
        #region 接口实现
        
		public List<T_CA_PLOY> FindList(T_CA_PLOY model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_CA_PLOY> PageList(T_CA_PLOY model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_CA_PLOY._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_CA_PLOY._.ID == ID);
			
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
        public GeneralResult Edit(T_CA_PLOY model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_CA_PLOY entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.CA_ID=model.CA_ID;
		entity.ATTRIBUTES_NAME=model.ATTRIBUTES_NAME;
		entity.ZSX_TYPE=model.ZSX_TYPE;
		entity.ZSX=model.ZSX;
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
        public GeneralResult Add(T_CA_PLOY model)
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
                    Delete(T_CA_PLOY._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_CA_PLOY> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_CA_PLOY model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_CA_PLOY._.ID==(model.ID));
				}
				if(model.CA_ID!=null)
				{
				  condition.And(T_CA_PLOY._.CA_ID==(model.CA_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTRIBUTES_NAME))
				{
				  condition.And(T_CA_PLOY._.ATTRIBUTES_NAME.Contain(model.ATTRIBUTES_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ZSX_TYPE))
				{
				  condition.And(T_CA_PLOY._.ZSX_TYPE.Contain(model.ZSX_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.ZSX))
				{
				  condition.And(T_CA_PLOY._.ZSX.Contain(model.ZSX));
				}
		return condition;
	}
        #endregion
    }
}