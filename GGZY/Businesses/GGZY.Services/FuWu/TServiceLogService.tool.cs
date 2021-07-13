using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TServiceLogService : BaseServiceT<T_SERVICE_LOG>
    {
        #region 接口实现
        
		public List<T_SERVICE_LOG> FindList(T_SERVICE_LOG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_SERVICE_LOG> PageList(T_SERVICE_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_SERVICE_LOG._.TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="TM">时间</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(DateTime? TM)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_SERVICE_LOG._.TM == TM);
			
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
        public GeneralResult Edit(T_SERVICE_LOG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.TM);
	
	if(viewResult.Success  && viewResult.Data is T_SERVICE_LOG entity)
	{		
		entity.Attach();
		entity.TM=model.TM;
		entity.RES=model.RES;
		entity.SYSTEMCODE=model.SYSTEMCODE;
		entity.TABLENAME=model.TABLENAME;
		entity.ID=model.ID;
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
        public GeneralResult Add(T_SERVICE_LOG model)
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
                    Delete(T_SERVICE_LOG._.TM.SelectIn(idArr));
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
        public GeneralResult Import(List<T_SERVICE_LOG> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_SERVICE_LOG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.TM!=null)
				{
				  condition.And(T_SERVICE_LOG._.TM==(model.TM));
				}
				if(!string.IsNullOrWhiteSpace(model.RES))
				{
				  condition.And(T_SERVICE_LOG._.RES.Contain(model.RES));
				}
				if(!string.IsNullOrWhiteSpace(model.SYSTEMCODE))
				{
				  condition.And(T_SERVICE_LOG._.SYSTEMCODE.Contain(model.SYSTEMCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TABLENAME))
				{
				  condition.And(T_SERVICE_LOG._.TABLENAME.Contain(model.TABLENAME));
				}
				if(model.ID!=null)
				{
				  condition.And(T_SERVICE_LOG._.ID==(model.ID));
				}
		return condition;
	}
        #endregion
    }
}