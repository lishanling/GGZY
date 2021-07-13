using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TPushzpLogService : BaseServiceT<T_PUSHZP_LOG>
    {
        #region 接口实现
        
		public List<T_PUSHZP_LOG> FindList(T_PUSHZP_LOG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_PUSHZP_LOG> PageList(T_PUSHZP_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_PUSHZP_LOG._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_PUSHZP_LOG._.ID == ID);
			
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
        public GeneralResult Edit(T_PUSHZP_LOG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_PUSHZP_LOG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.M_ZPID=model.M_ZPID;
		entity.RETURN_MSG=model.RETURN_MSG;
		entity.OPER_BY=model.OPER_BY;
		entity.OPER_TM=model.OPER_TM;
		entity.IP=model.IP;
		entity.ANN_ID=model.ANN_ID;
		entity.TYPE=model.TYPE;
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
        public GeneralResult Add(T_PUSHZP_LOG model)
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
                    Delete(T_PUSHZP_LOG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_PUSHZP_LOG> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_PUSHZP_LOG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_PUSHZP_LOG._.ID==(model.ID));
				}
				if(model.M_ZPID!=null)
				{
				  condition.And(T_PUSHZP_LOG._.M_ZPID==(model.M_ZPID));
				}
				if(!string.IsNullOrWhiteSpace(model.RETURN_MSG))
				{
				  condition.And(T_PUSHZP_LOG._.RETURN_MSG.Contain(model.RETURN_MSG));
				}
				if(model.OPER_BY!=null)
				{
				  condition.And(T_PUSHZP_LOG._.OPER_BY==(model.OPER_BY));
				}
				if(model.OPER_TM!=null)
				{
				  condition.And(T_PUSHZP_LOG._.OPER_TM==(model.OPER_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.IP))
				{
				  condition.And(T_PUSHZP_LOG._.IP.Contain(model.IP));
				}
				if(model.ANN_ID!=null)
				{
				  condition.And(T_PUSHZP_LOG._.ANN_ID==(model.ANN_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPE))
				{
				  condition.And(T_PUSHZP_LOG._.TYPE.Contain(model.TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(T_PUSHZP_LOG._.REMARK.Contain(model.REMARK));
				}
		return condition;
	}
        #endregion
    }
}