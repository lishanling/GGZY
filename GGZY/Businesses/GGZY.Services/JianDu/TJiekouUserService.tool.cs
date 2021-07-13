using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TJiekouUserService : BaseServiceT<T_JIEKOU_USER>
    {
        #region 接口实现
        
		public List<T_JIEKOU_USER> FindList(T_JIEKOU_USER model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_JIEKOU_USER> PageList(T_JIEKOU_USER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_JIEKOU_USER._.SYSTEM_NO.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="SYSTEM_NO"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string SYSTEM_NO)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_JIEKOU_USER._.SYSTEM_NO == SYSTEM_NO);
			
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
        public GeneralResult Edit(T_JIEKOU_USER model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.SYSTEM_NO);
	
	if(viewResult.Success  && viewResult.Data is T_JIEKOU_USER entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.USERID=model.USERID;
		entity.SYSTEM_NO=model.SYSTEM_NO;
		entity.SYSTEM_NAME=model.SYSTEM_NAME;
		entity.CONTACT_NAME=model.CONTACT_NAME;
		entity.CONTACT_TEL=model.CONTACT_TEL;
		entity.AREACODE=model.AREACODE;
		entity.SECRET_KEY=model.SECRET_KEY;
		entity.LAST_LOGINTIME=model.LAST_LOGINTIME;
		entity.SYSTEM_SIGN=model.SYSTEM_SIGN;
		entity.SUPERVISE_DEPT_NAME=model.SUPERVISE_DEPT_NAME;
		entity.SUPERVISE_DEPT_CODE=model.SUPERVISE_DEPT_CODE;
		entity.APPROVE_DEPT_NAME=model.APPROVE_DEPT_NAME;
		entity.APPROVE_DEPT_CODE=model.APPROVE_DEPT_CODE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.BULID_DEP=model.BULID_DEP;
		entity.BULID_FZR=model.BULID_FZR;
		entity.BULID_PHONE=model.BULID_PHONE;
		entity.YW_DEP=model.YW_DEP;
		entity.YW_FZR=model.YW_FZR;
		entity.YW_PHONE=model.YW_PHONE;
		entity.DOCK=model.DOCK;
		entity.DOCK_INFO=model.DOCK_INFO;
		entity.INTERFACE_STATUS=model.INTERFACE_STATUS;
		entity.REMARK=model.REMARK;
		entity.ORDER_BY=model.ORDER_BY;
		entity.UPLOAD_COUNT=model.UPLOAD_COUNT;
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
        public GeneralResult Add(T_JIEKOU_USER model)
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
                    Delete(T_JIEKOU_USER._.SYSTEM_NO.SelectIn(idArr));
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
        public GeneralResult Import(List<T_JIEKOU_USER> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_JIEKOU_USER model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_JIEKOU_USER._.ID==(model.ID));
				}
				if(model.USERID!=null)
				{
				  condition.And(T_JIEKOU_USER._.USERID==(model.USERID));
				}
				if(!string.IsNullOrWhiteSpace(model.SYSTEM_NO))
				{
				  condition.And(T_JIEKOU_USER._.SYSTEM_NO.Contain(model.SYSTEM_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.SYSTEM_NAME))
				{
				  condition.And(T_JIEKOU_USER._.SYSTEM_NAME.Contain(model.SYSTEM_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTACT_NAME))
				{
				  condition.And(T_JIEKOU_USER._.CONTACT_NAME.Contain(model.CONTACT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTACT_TEL))
				{
				  condition.And(T_JIEKOU_USER._.CONTACT_TEL.Contain(model.CONTACT_TEL));
				}
				if(!string.IsNullOrWhiteSpace(model.AREACODE))
				{
				  condition.And(T_JIEKOU_USER._.AREACODE.Contain(model.AREACODE));
				}
				if(!string.IsNullOrWhiteSpace(model.SECRET_KEY))
				{
				  condition.And(T_JIEKOU_USER._.SECRET_KEY.Contain(model.SECRET_KEY));
				}
				if(model.LAST_LOGINTIME!=null)
				{
				  condition.And(T_JIEKOU_USER._.LAST_LOGINTIME==(model.LAST_LOGINTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.SYSTEM_SIGN))
				{
				  condition.And(T_JIEKOU_USER._.SYSTEM_SIGN.Contain(model.SYSTEM_SIGN));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME))
				{
				  condition.And(T_JIEKOU_USER._.SUPERVISE_DEPT_NAME.Contain(model.SUPERVISE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_CODE))
				{
				  condition.And(T_JIEKOU_USER._.SUPERVISE_DEPT_CODE.Contain(model.SUPERVISE_DEPT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVE_DEPT_NAME))
				{
				  condition.And(T_JIEKOU_USER._.APPROVE_DEPT_NAME.Contain(model.APPROVE_DEPT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVE_DEPT_CODE))
				{
				  condition.And(T_JIEKOU_USER._.APPROVE_DEPT_CODE.Contain(model.APPROVE_DEPT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(T_JIEKOU_USER._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BULID_DEP))
				{
				  condition.And(T_JIEKOU_USER._.BULID_DEP.Contain(model.BULID_DEP));
				}
				if(!string.IsNullOrWhiteSpace(model.BULID_FZR))
				{
				  condition.And(T_JIEKOU_USER._.BULID_FZR.Contain(model.BULID_FZR));
				}
				if(!string.IsNullOrWhiteSpace(model.BULID_PHONE))
				{
				  condition.And(T_JIEKOU_USER._.BULID_PHONE.Contain(model.BULID_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.YW_DEP))
				{
				  condition.And(T_JIEKOU_USER._.YW_DEP.Contain(model.YW_DEP));
				}
				if(!string.IsNullOrWhiteSpace(model.YW_FZR))
				{
				  condition.And(T_JIEKOU_USER._.YW_FZR.Contain(model.YW_FZR));
				}
				if(!string.IsNullOrWhiteSpace(model.YW_PHONE))
				{
				  condition.And(T_JIEKOU_USER._.YW_PHONE.Contain(model.YW_PHONE));
				}
				if(model.DOCK!=null)
				{
				  condition.And(T_JIEKOU_USER._.DOCK==(model.DOCK));
				}
				if(!string.IsNullOrWhiteSpace(model.DOCK_INFO))
				{
				  condition.And(T_JIEKOU_USER._.DOCK_INFO.Contain(model.DOCK_INFO));
				}
				if(model.INTERFACE_STATUS!=null)
				{
				  condition.And(T_JIEKOU_USER._.INTERFACE_STATUS==(model.INTERFACE_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(T_JIEKOU_USER._.REMARK.Contain(model.REMARK));
				}
				if(model.ORDER_BY!=null)
				{
				  condition.And(T_JIEKOU_USER._.ORDER_BY==(model.ORDER_BY));
				}
				if(model.UPLOAD_COUNT!=null)
				{
				  condition.And(T_JIEKOU_USER._.UPLOAD_COUNT==(model.UPLOAD_COUNT));
				}
		return condition;
	}
        #endregion
    }
}