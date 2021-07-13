using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TRpStTreeNodeService : BaseServiceT<T_RP_ST_TREE_NODE>
    {
        #region 接口实现
        
		public List<T_RP_ST_TREE_NODE> FindList(T_RP_ST_TREE_NODE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_RP_ST_TREE_NODE> PageList(T_RP_ST_TREE_NODE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_RP_ST_TREE_NODE._.ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_RP_ST_TREE_NODE._.ID == ID);
			
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
        public GeneralResult Edit(T_RP_ST_TREE_NODE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_RP_ST_TREE_NODE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TREE_CODE=model.TREE_CODE;
		entity.NAME=model.NAME;
		entity.P_CODE=model.P_CODE;
		entity.STCD=model.STCD;
		entity.ORDER_ID=model.ORDER_ID;
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
        public GeneralResult Add(T_RP_ST_TREE_NODE model)
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
                    Delete(T_RP_ST_TREE_NODE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_RP_ST_TREE_NODE> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_RP_ST_TREE_NODE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_RP_ST_TREE_NODE._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TREE_CODE))
				{
				  condition.And(T_RP_ST_TREE_NODE._.TREE_CODE.Contain(model.TREE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(T_RP_ST_TREE_NODE._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.P_CODE))
				{
				  condition.And(T_RP_ST_TREE_NODE._.P_CODE.Contain(model.P_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.STCD))
				{
				  condition.And(T_RP_ST_TREE_NODE._.STCD.Contain(model.STCD));
				}
				if(model.ORDER_ID!=null)
				{
				  condition.And(T_RP_ST_TREE_NODE._.ORDER_ID==(model.ORDER_ID));
				}
		return condition;
	}
        #endregion
    }
}