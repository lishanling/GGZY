using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TUserService : BaseServiceT<T_USER>
    {
        #region 接口实现
        
		public List<T_USER> FindList(T_USER model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_USER> PageList(T_USER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_USER._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_USER._.ID == ID);
			
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
        public GeneralResult Edit(T_USER model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_USER entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.USERNAME=model.USERNAME;
		entity.PASSWORD=model.PASSWORD;
		entity.EMAIL=model.EMAIL;
		entity.TYPE=model.TYPE;
		entity.CA_CODE=model.CA_CODE;
		entity.REG_TM=model.REG_TM;
		entity.API_CODE=model.API_CODE;
		entity.API_KEY=model.API_KEY;
		entity.ROLEIDS=model.ROLEIDS;
		entity.SESSION_ID=model.SESSION_ID;
		entity.P_ID=model.P_ID;
		entity.GENDER=model.GENDER;
		entity.IS_ENABLE=model.IS_ENABLE;
		entity.COMPANY_CODE=model.COMPANY_CODE;
		entity.MANAGE_NAME=model.MANAGE_NAME;
		entity.AREACODE=model.AREACODE;
		entity.ZP_FAX=model.ZP_FAX;
		entity.ZP_UNIT=model.ZP_UNIT;
		entity.ZP_ADDRESS=model.ZP_ADDRESS;
		entity.ZP_ID=model.ZP_ID;
		entity.ZP_PHONE=model.ZP_PHONE;
		entity.CHECK_CODE=model.CHECK_CODE;
		entity.IS_CHECK_PHONE=model.IS_CHECK_PHONE;
		entity.EFECTIVE_TIME=model.EFECTIVE_TIME;
		entity.IS_AUDIT=model.IS_AUDIT;
		entity.AUDIT_BY=model.AUDIT_BY;
		entity.AUDIT_TM=model.AUDIT_TM;
		entity.AAAA=model.AAAA;
		entity.CA_INFO=model.CA_INFO;
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
        public GeneralResult Add(T_USER model)
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
                    Delete(T_USER._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_USER> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_USER model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_USER._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.USERNAME))
				{
				  condition.And(T_USER._.USERNAME.Contain(model.USERNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.PASSWORD))
				{
				  condition.And(T_USER._.PASSWORD.Contain(model.PASSWORD));
				}
				if(!string.IsNullOrWhiteSpace(model.EMAIL))
				{
				  condition.And(T_USER._.EMAIL.Contain(model.EMAIL));
				}
				if(model.TYPE!=null)
				{
				  condition.And(T_USER._.TYPE==(model.TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.CA_CODE))
				{
				  condition.And(T_USER._.CA_CODE.Contain(model.CA_CODE));
				}
				if(model.REG_TM!=null)
				{
				  condition.And(T_USER._.REG_TM==(model.REG_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.API_CODE))
				{
				  condition.And(T_USER._.API_CODE.Contain(model.API_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.API_KEY))
				{
				  condition.And(T_USER._.API_KEY.Contain(model.API_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.ROLEIDS))
				{
				  condition.And(T_USER._.ROLEIDS.Contain(model.ROLEIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.SESSION_ID))
				{
				  condition.And(T_USER._.SESSION_ID.Contain(model.SESSION_ID));
				}
				if(model.P_ID!=null)
				{
				  condition.And(T_USER._.P_ID==(model.P_ID));
				}
				if(model.GENDER!=null)
				{
				  condition.And(T_USER._.GENDER==(model.GENDER));
				}
				if(model.IS_ENABLE!=null)
				{
				  condition.And(T_USER._.IS_ENABLE==(model.IS_ENABLE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPANY_CODE))
				{
				  condition.And(T_USER._.COMPANY_CODE.Contain(model.COMPANY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.MANAGE_NAME))
				{
				  condition.And(T_USER._.MANAGE_NAME.Contain(model.MANAGE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.AREACODE))
				{
				  condition.And(T_USER._.AREACODE.Contain(model.AREACODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_FAX))
				{
				  condition.And(T_USER._.ZP_FAX.Contain(model.ZP_FAX));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_UNIT))
				{
				  condition.And(T_USER._.ZP_UNIT.Contain(model.ZP_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_ADDRESS))
				{
				  condition.And(T_USER._.ZP_ADDRESS.Contain(model.ZP_ADDRESS));
				}
				if(model.ZP_ID!=null)
				{
				  condition.And(T_USER._.ZP_ID==(model.ZP_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.ZP_PHONE))
				{
				  condition.And(T_USER._.ZP_PHONE.Contain(model.ZP_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.CHECK_CODE))
				{
				  condition.And(T_USER._.CHECK_CODE.Contain(model.CHECK_CODE));
				}
				if(model.IS_CHECK_PHONE!=null)
				{
				  condition.And(T_USER._.IS_CHECK_PHONE==(model.IS_CHECK_PHONE));
				}
				if(model.EFECTIVE_TIME!=null)
				{
				  condition.And(T_USER._.EFECTIVE_TIME==(model.EFECTIVE_TIME));
				}
				if(model.IS_AUDIT!=null)
				{
				  condition.And(T_USER._.IS_AUDIT==(model.IS_AUDIT));
				}
				if(model.AUDIT_BY!=null)
				{
				  condition.And(T_USER._.AUDIT_BY==(model.AUDIT_BY));
				}
				if(model.AUDIT_TM!=null)
				{
				  condition.And(T_USER._.AUDIT_TM==(model.AUDIT_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.AAAA))
				{
				  condition.And(T_USER._.AAAA.Contain(model.AAAA));
				}
				if(!string.IsNullOrWhiteSpace(model.CA_INFO))
				{
				  condition.And(T_USER._.CA_INFO.Contain(model.CA_INFO));
				}
		return condition;
	}
        #endregion
    }
}