using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TTpNodeService : BaseServiceT<T_TP_NODE>
    {
        #region 接口实现
        
		public List<T_TP_NODE> FindList(T_TP_NODE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_TP_NODE> PageList(T_TP_NODE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_TP_NODE._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_TP_NODE._.ID == ID);
			
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
        public GeneralResult Edit(T_TP_NODE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_TP_NODE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.NAME=model.NAME;
		entity.CODE=model.CODE;
		entity.TACHE_CODE=model.TACHE_CODE;
		entity.REMARK=model.REMARK;
		entity.ORDER_ID=model.ORDER_ID;
		entity.CREATE_TM=model.CREATE_TM;
		entity.MUTEX_NODE=model.MUTEX_NODE;
		entity.CPN_CODE=model.CPN_CODE;
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
        public GeneralResult Add(T_TP_NODE model)
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
                    Delete(T_TP_NODE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_TP_NODE> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_TP_NODE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_TP_NODE._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(T_TP_NODE._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(T_TP_NODE._.CODE.Contain(model.CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TACHE_CODE))
				{
				  condition.And(T_TP_NODE._.TACHE_CODE.Contain(model.TACHE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(T_TP_NODE._.REMARK.Contain(model.REMARK));
				}
				if(model.ORDER_ID!=null)
				{
				  condition.And(T_TP_NODE._.ORDER_ID==(model.ORDER_ID));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(T_TP_NODE._.CREATE_TM==(model.CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.MUTEX_NODE))
				{
				  condition.And(T_TP_NODE._.MUTEX_NODE.Contain(model.MUTEX_NODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CPN_CODE))
				{
				  condition.And(T_TP_NODE._.CPN_CODE.Contain(model.CPN_CODE));
				}
		return condition;
	}
        #endregion
    }
}