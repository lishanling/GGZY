using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
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
		entity.TELPHONE=model.TELPHONE;
		entity.TOKEN=model.TOKEN;
		entity.TOKEN_EXPTIME=model.TOKEN_EXPTIME;
		entity.HY_TYPE=model.HY_TYPE;
		entity.ACODES=model.ACODES;
		entity.DEPARTID=model.DEPARTID;
		entity.CREATETIME=model.CREATETIME;
		entity.CREATEID=model.CREATEID;
		entity.PHONE=model.PHONE;
		entity.JOB=model.JOB;
		entity.WORKSTATION=model.WORKSTATION;
		entity.DEPARTMENT=model.DEPARTMENT;
		entity.ISSENDMSG=model.ISSENDMSG;
		entity.ISPUSHMSG=model.ISPUSHMSG;
		entity.OPERATION_DEPART=model.OPERATION_DEPART;
		entity.ISSENDMSG_BJ=model.ISSENDMSG_BJ;
		entity.IS_SEND_MSG=model.IS_SEND_MSG;
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
				if(!string.IsNullOrWhiteSpace(model.TELPHONE))
				{
				  condition.And(T_USER._.TELPHONE.Contain(model.TELPHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.TOKEN))
				{
				  condition.And(T_USER._.TOKEN.Contain(model.TOKEN));
				}
				if(model.TOKEN_EXPTIME!=null)
				{
				  condition.And(T_USER._.TOKEN_EXPTIME==(model.TOKEN_EXPTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.HY_TYPE))
				{
				  condition.And(T_USER._.HY_TYPE.Contain(model.HY_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.ACODES))
				{
				  condition.And(T_USER._.ACODES.Contain(model.ACODES));
				}
				if(model.DEPARTID!=null)
				{
				  condition.And(T_USER._.DEPARTID==(model.DEPARTID));
				}
				if(model.CREATETIME!=null)
				{
				  condition.And(T_USER._.CREATETIME==(model.CREATETIME));
				}
				if(model.CREATEID!=null)
				{
				  condition.And(T_USER._.CREATEID==(model.CREATEID));
				}
				if(!string.IsNullOrWhiteSpace(model.PHONE))
				{
				  condition.And(T_USER._.PHONE.Contain(model.PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.JOB))
				{
				  condition.And(T_USER._.JOB.Contain(model.JOB));
				}
				if(!string.IsNullOrWhiteSpace(model.WORKSTATION))
				{
				  condition.And(T_USER._.WORKSTATION.Contain(model.WORKSTATION));
				}
				if(!string.IsNullOrWhiteSpace(model.DEPARTMENT))
				{
				  condition.And(T_USER._.DEPARTMENT.Contain(model.DEPARTMENT));
				}
				if(model.ISSENDMSG!=null)
				{
				  condition.And(T_USER._.ISSENDMSG==(model.ISSENDMSG));
				}
				if(model.ISPUSHMSG!=null)
				{
				  condition.And(T_USER._.ISPUSHMSG==(model.ISPUSHMSG));
				}
				if(!string.IsNullOrWhiteSpace(model.OPERATION_DEPART))
				{
				  condition.And(T_USER._.OPERATION_DEPART.Contain(model.OPERATION_DEPART));
				}
				if(model.ISSENDMSG_BJ!=null)
				{
				  condition.And(T_USER._.ISSENDMSG_BJ==(model.ISSENDMSG_BJ));
				}
				if(model.IS_SEND_MSG!=null)
				{
				  condition.And(T_USER._.IS_SEND_MSG==(model.IS_SEND_MSG));
				}
		return condition;
	}
        #endregion
    }
}