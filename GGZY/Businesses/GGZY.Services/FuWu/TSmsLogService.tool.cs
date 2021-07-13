using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TSmsLogService : BaseServiceT<T_SMS_LOG>
    {
        #region 接口实现
        
		public List<T_SMS_LOG> FindList(T_SMS_LOG model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_SMS_LOG> PageList(T_SMS_LOG model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_SMS_LOG._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_SMS_LOG._.ID == ID);
			
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
        public GeneralResult Edit(T_SMS_LOG model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_SMS_LOG entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.SYSNAME=model.SYSNAME;
		entity.TEL_PHONE=model.TEL_PHONE;
		entity.SMS_CONTENT=model.SMS_CONTENT;
		entity.STATUS=model.STATUS;
		entity.SEND_TM=model.SEND_TM;
		entity.SMS_PLATFORM=model.SMS_PLATFORM;
		entity.RESPONSE_TEXT=model.RESPONSE_TEXT;
		entity.OPER_BY=model.OPER_BY;
		entity.IP=model.IP;
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
        public GeneralResult Add(T_SMS_LOG model)
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
                    Delete(T_SMS_LOG._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_SMS_LOG> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_SMS_LOG model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_SMS_LOG._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.SYSNAME))
				{
				  condition.And(T_SMS_LOG._.SYSNAME.Contain(model.SYSNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TEL_PHONE))
				{
				  condition.And(T_SMS_LOG._.TEL_PHONE.Contain(model.TEL_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.SMS_CONTENT))
				{
				  condition.And(T_SMS_LOG._.SMS_CONTENT.Contain(model.SMS_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.STATUS))
				{
				  condition.And(T_SMS_LOG._.STATUS.Contain(model.STATUS));
				}
				if(model.SEND_TM!=null)
				{
				  condition.And(T_SMS_LOG._.SEND_TM==(model.SEND_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.SMS_PLATFORM))
				{
				  condition.And(T_SMS_LOG._.SMS_PLATFORM.Contain(model.SMS_PLATFORM));
				}
				if(!string.IsNullOrWhiteSpace(model.RESPONSE_TEXT))
				{
				  condition.And(T_SMS_LOG._.RESPONSE_TEXT.Contain(model.RESPONSE_TEXT));
				}
				if(model.OPER_BY!=null)
				{
				  condition.And(T_SMS_LOG._.OPER_BY==(model.OPER_BY));
				}
				if(!string.IsNullOrWhiteSpace(model.IP))
				{
				  condition.And(T_SMS_LOG._.IP.Contain(model.IP));
				}
		return condition;
	}
        #endregion
    }
}