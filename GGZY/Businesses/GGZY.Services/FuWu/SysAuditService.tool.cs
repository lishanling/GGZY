using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SysAuditService : BaseServiceT<SYS_AUDIT>
    {
        #region 接口实现
        
		public List<SYS_AUDIT> FindList(SYS_AUDIT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SYS_AUDIT> PageList(SYS_AUDIT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SYS_AUDIT._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(SYS_AUDIT._.ID == ID);
			
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
        public GeneralResult Edit(SYS_AUDIT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is SYS_AUDIT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.TCID=model.TCID;
		entity.OPERATE_TYPE=model.OPERATE_TYPE;
		entity.IS_SUCCESS=model.IS_SUCCESS;
		entity.CREATE_USERID=model.CREATE_USERID;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.LCONTENT=model.LCONTENT;
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
        public GeneralResult Add(SYS_AUDIT model)
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
                    Delete(SYS_AUDIT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SYS_AUDIT> model)
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
       	protected WhereClipBuilder ConditionBuilder(SYS_AUDIT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(SYS_AUDIT._.ID==(model.ID));
				}
				if(model.TCID!=null)
				{
				  condition.And(SYS_AUDIT._.TCID==(model.TCID));
				}
				if(!string.IsNullOrWhiteSpace(model.OPERATE_TYPE))
				{
				  condition.And(SYS_AUDIT._.OPERATE_TYPE.Contain(model.OPERATE_TYPE));
				}
				if(model.IS_SUCCESS!=null)
				{
				  condition.And(SYS_AUDIT._.IS_SUCCESS==(model.IS_SUCCESS));
				}
				if(model.CREATE_USERID!=null)
				{
				  condition.And(SYS_AUDIT._.CREATE_USERID==(model.CREATE_USERID));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(SYS_AUDIT._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.LCONTENT))
				{
				  condition.And(SYS_AUDIT._.LCONTENT.Contain(model.LCONTENT));
				}
		return condition;
	}
        #endregion
    }
}