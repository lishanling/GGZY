using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TRpStTreeService : BaseServiceT<T_RP_ST_TREE>
    {
        #region 接口实现
        
		public List<T_RP_ST_TREE> FindList(T_RP_ST_TREE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_RP_ST_TREE> PageList(T_RP_ST_TREE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_RP_ST_TREE._.TREE_CODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="TREE_CODE"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string TREE_CODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_RP_ST_TREE._.TREE_CODE == TREE_CODE);
			
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
        public GeneralResult Edit(T_RP_ST_TREE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.TREE_CODE);
	
	if(viewResult.Success  && viewResult.Data is T_RP_ST_TREE entity)
	{		
		entity.Attach();
		entity.RP_CODE=model.RP_CODE;
		entity.TREE_CODE=model.TREE_CODE;
		entity.NAME=model.NAME;
		entity.TYPE=model.TYPE;
		entity.URL=model.URL;
		entity.ORDER_ID=model.ORDER_ID;
		entity.CREATE_BY=model.CREATE_BY;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.IS_CHECK=model.IS_CHECK;
		entity.TREE_CHECK_TYPE=model.TREE_CHECK_TYPE;
		entity.TREE_PARAM=model.TREE_PARAM;
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
        public GeneralResult Add(T_RP_ST_TREE model)
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
                    Delete(T_RP_ST_TREE._.TREE_CODE.SelectIn(idArr));
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
        public GeneralResult Import(List<T_RP_ST_TREE> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_RP_ST_TREE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.RP_CODE))
				{
				  condition.And(T_RP_ST_TREE._.RP_CODE.Contain(model.RP_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TREE_CODE))
				{
				  condition.And(T_RP_ST_TREE._.TREE_CODE.Contain(model.TREE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(T_RP_ST_TREE._.NAME.Contain(model.NAME));
				}
				if(model.TYPE!=null)
				{
				  condition.And(T_RP_ST_TREE._.TYPE==(model.TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(T_RP_ST_TREE._.URL.Contain(model.URL));
				}
				if(model.ORDER_ID!=null)
				{
				  condition.And(T_RP_ST_TREE._.ORDER_ID==(model.ORDER_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.CREATE_BY))
				{
				  condition.And(T_RP_ST_TREE._.CREATE_BY.Contain(model.CREATE_BY));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_RP_ST_TREE._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(model.IS_CHECK!=null)
				{
				  condition.And(T_RP_ST_TREE._.IS_CHECK==(model.IS_CHECK));
				}
				if(model.TREE_CHECK_TYPE!=null)
				{
				  condition.And(T_RP_ST_TREE._.TREE_CHECK_TYPE==(model.TREE_CHECK_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TREE_PARAM))
				{
				  condition.And(T_RP_ST_TREE._.TREE_PARAM.Contain(model.TREE_PARAM));
				}
		return condition;
	}
        #endregion
    }
}