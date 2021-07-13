using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SysLogService : BaseServiceT<SYS_LOG>
    {
        #region 接口实现
        
		public List<SYS_LOG> FindList(SYS_LOG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SYS_LOG> PageList(SYS_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SYS_LOG._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(SYS_LOG._.ID == ID);
			
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
        public GeneralResult Edit(SYS_LOG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is SYS_LOG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.NOTETYPE=model.NOTETYPE;
		entity.FUNCTIONMODEL=model.FUNCTIONMODEL;
		entity.MENUID=model.MENUID;
		entity.LCONTENT=model.LCONTENT;
		entity.IP=model.IP;
		entity.CREATEUSERID=model.CREATEUSERID;
		entity.CREATETIME=model.CREATETIME;
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
        public GeneralResult Add(SYS_LOG model)
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
                    Delete(SYS_LOG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SYS_LOG> model)
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
       	protected WhereClipBuilder ConditionBuilder(SYS_LOG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(SYS_LOG._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTETYPE))
				{
				  condition.And(SYS_LOG._.NOTETYPE.Contain(model.NOTETYPE));
				}
				if(model.FUNCTIONMODEL!=null)
				{
				  condition.And(SYS_LOG._.FUNCTIONMODEL==(model.FUNCTIONMODEL));
				}
				if(model.MENUID!=null)
				{
				  condition.And(SYS_LOG._.MENUID==(model.MENUID));
				}
				if(!string.IsNullOrWhiteSpace(model.LCONTENT))
				{
				  condition.And(SYS_LOG._.LCONTENT.Contain(model.LCONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.IP))
				{
				  condition.And(SYS_LOG._.IP.Contain(model.IP));
				}
				if(model.CREATEUSERID!=null)
				{
				  condition.And(SYS_LOG._.CREATEUSERID==(model.CREATEUSERID));
				}
				if(model.CREATETIME!=null)
				{
				  condition.And(SYS_LOG._.CREATETIME==(model.CREATETIME));
				}
		return condition;
	}
        #endregion
    }
}