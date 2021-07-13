using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TPmJdinfoLogService : BaseServiceT<T_PM_JDINFO_LOG>
    {
        #region 接口实现
        
		public List<T_PM_JDINFO_LOG> FindList(T_PM_JDINFO_LOG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_PM_JDINFO_LOG> PageList(T_PM_JDINFO_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_PM_JDINFO_LOG._.TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_PM_JDINFO_LOG._.ID == ID);
			
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
        public GeneralResult Edit(T_PM_JDINFO_LOG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_PM_JDINFO_LOG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.MPID=model.MPID;
		entity.U_ID=model.U_ID;
		entity.LEVEL_TYPE_OLD=model.LEVEL_TYPE_OLD;
		entity.LEVEL_TYPE=model.LEVEL_TYPE;
		entity.REMARK=model.REMARK;
		entity.TM=model.TM;
		entity.BUSINESSID=model.BUSINESSID;
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
        public GeneralResult Add(T_PM_JDINFO_LOG model)
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
                    Delete(T_PM_JDINFO_LOG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_PM_JDINFO_LOG> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_PM_JDINFO_LOG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_PM_JDINFO_LOG._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(T_PM_JDINFO_LOG._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(model.MPID!=null)
				{
				  condition.And(T_PM_JDINFO_LOG._.MPID==(model.MPID));
				}
				if(!string.IsNullOrWhiteSpace(model.U_ID))
				{
				  condition.And(T_PM_JDINFO_LOG._.U_ID.Contain(model.U_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.LEVEL_TYPE_OLD))
				{
				  condition.And(T_PM_JDINFO_LOG._.LEVEL_TYPE_OLD.Contain(model.LEVEL_TYPE_OLD));
				}
				if(!string.IsNullOrWhiteSpace(model.LEVEL_TYPE))
				{
				  condition.And(T_PM_JDINFO_LOG._.LEVEL_TYPE.Contain(model.LEVEL_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(T_PM_JDINFO_LOG._.REMARK.Contain(model.REMARK));
				}
				if(model.TM!=null)
				{
				  condition.And(T_PM_JDINFO_LOG._.TM==(model.TM));
				}
				if(!string.IsNullOrWhiteSpace(model.BUSINESSID))
				{
				  condition.And(T_PM_JDINFO_LOG._.BUSINESSID.Contain(model.BUSINESSID));
				}
		return condition;
	}
        #endregion
    }
}