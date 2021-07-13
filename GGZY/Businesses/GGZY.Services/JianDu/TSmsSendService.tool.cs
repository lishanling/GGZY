using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TSmsSendService : BaseServiceT<T_SMS_SEND>
    {
        #region 接口实现
        
		public List<T_SMS_SEND> FindList(T_SMS_SEND model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_SMS_SEND> PageList(T_SMS_SEND model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_SMS_SEND._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_SMS_SEND._.ID == ID);
			
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
        public GeneralResult Edit(T_SMS_SEND model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_SMS_SEND entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.MODULE_NAME=model.MODULE_NAME;
		entity.TEL_PHONE=model.TEL_PHONE;
		entity.SMS_CONTENT=model.SMS_CONTENT;
		entity.STATUS=model.STATUS;
		entity.YJ_SEND_TM=model.YJ_SEND_TM;
		entity.SEND_TM=model.SEND_TM;
		entity.SMS_PLATFORM=model.SMS_PLATFORM;
		entity.RESPONSE_TEXT=model.RESPONSE_TEXT;
		entity.OPER_BY=model.OPER_BY;
		entity.RETRY=model.RETRY;
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
        public GeneralResult Add(T_SMS_SEND model)
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
                    Delete(T_SMS_SEND._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_SMS_SEND> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_SMS_SEND model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_SMS_SEND._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.MODULE_NAME))
				{
				  condition.And(T_SMS_SEND._.MODULE_NAME.Contain(model.MODULE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TEL_PHONE))
				{
				  condition.And(T_SMS_SEND._.TEL_PHONE.Contain(model.TEL_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.SMS_CONTENT))
				{
				  condition.And(T_SMS_SEND._.SMS_CONTENT.Contain(model.SMS_CONTENT));
				}
				if(model.STATUS!=null)
				{
				  condition.And(T_SMS_SEND._.STATUS==(model.STATUS));
				}
				if(model.YJ_SEND_TM!=null)
				{
				  condition.And(T_SMS_SEND._.YJ_SEND_TM==(model.YJ_SEND_TM));
				}
				if(model.SEND_TM!=null)
				{
				  condition.And(T_SMS_SEND._.SEND_TM==(model.SEND_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.SMS_PLATFORM))
				{
				  condition.And(T_SMS_SEND._.SMS_PLATFORM.Contain(model.SMS_PLATFORM));
				}
				if(!string.IsNullOrWhiteSpace(model.RESPONSE_TEXT))
				{
				  condition.And(T_SMS_SEND._.RESPONSE_TEXT.Contain(model.RESPONSE_TEXT));
				}
				if(model.OPER_BY!=null)
				{
				  condition.And(T_SMS_SEND._.OPER_BY==(model.OPER_BY));
				}
				if(model.RETRY!=null)
				{
				  condition.And(T_SMS_SEND._.RETRY==(model.RETRY));
				}
		return condition;
	}
        #endregion
    }
}