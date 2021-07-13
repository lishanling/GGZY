using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SysUserService : BaseServiceT<SYS_USER>
    {
        #region 接口实现
        
		public List<SYS_USER> FindList(SYS_USER model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SYS_USER> PageList(SYS_USER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SYS_USER._.U_ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="U_ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? U_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(SYS_USER._.U_ID == U_ID);
			
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
        public GeneralResult Edit(SYS_USER model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.U_ID);
	
	if(viewResult.Success  && viewResult.Data is SYS_USER entity)
	{		
		entity.Attach();
		entity.U_ID=model.U_ID;
		entity.UNAME=model.UNAME;
		entity.UPWD=model.UPWD;
		entity.REALNAME=model.REALNAME;
		entity.ROLEIDS=model.ROLEIDS;
		entity.USTATUS=model.USTATUS;
		entity.DEPARTID=model.DEPARTID;
		entity.CELLPHONE=model.CELLPHONE;
		entity.TELPHONE=model.TELPHONE;
		entity.U_ADDRESS=model.U_ADDRESS;
		entity.IDCARD=model.IDCARD;
		entity.SEX=model.SEX;
		entity.UPOST=model.UPOST;
		entity.DECSP=model.DECSP;
		entity.ORDERID=model.ORDERID;
		entity.CREATEID=model.CREATEID;
		entity.CREATETIME=model.CREATETIME;
		entity.ISDELETE=model.ISDELETE;
		entity.SSBM=model.SSBM;
		entity.E_MAIL=model.E_MAIL;
		entity.SYSTEM_NO=model.SYSTEM_NO;
		entity.SESSION_KEY=model.SESSION_KEY;
		entity.REFRESH_TOKEN=model.REFRESH_TOKEN;
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
        public GeneralResult Add(SYS_USER model)
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
                    Delete(SYS_USER._.U_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SYS_USER> model)
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
       	protected WhereClipBuilder ConditionBuilder(SYS_USER model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.U_ID!=null)
				{
				  condition.And(SYS_USER._.U_ID==(model.U_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.UNAME))
				{
				  condition.And(SYS_USER._.UNAME.Contain(model.UNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.UPWD))
				{
				  condition.And(SYS_USER._.UPWD.Contain(model.UPWD));
				}
				if(!string.IsNullOrWhiteSpace(model.REALNAME))
				{
				  condition.And(SYS_USER._.REALNAME.Contain(model.REALNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ROLEIDS))
				{
				  condition.And(SYS_USER._.ROLEIDS.Contain(model.ROLEIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.USTATUS))
				{
				  condition.And(SYS_USER._.USTATUS.Contain(model.USTATUS));
				}
				if(model.DEPARTID!=null)
				{
				  condition.And(SYS_USER._.DEPARTID==(model.DEPARTID));
				}
				if(!string.IsNullOrWhiteSpace(model.CELLPHONE))
				{
				  condition.And(SYS_USER._.CELLPHONE.Contain(model.CELLPHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.TELPHONE))
				{
				  condition.And(SYS_USER._.TELPHONE.Contain(model.TELPHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.U_ADDRESS))
				{
				  condition.And(SYS_USER._.U_ADDRESS.Contain(model.U_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.IDCARD))
				{
				  condition.And(SYS_USER._.IDCARD.Contain(model.IDCARD));
				}
				if(!string.IsNullOrWhiteSpace(model.SEX))
				{
				  condition.And(SYS_USER._.SEX.Contain(model.SEX));
				}
				if(!string.IsNullOrWhiteSpace(model.UPOST))
				{
				  condition.And(SYS_USER._.UPOST.Contain(model.UPOST));
				}
				if(!string.IsNullOrWhiteSpace(model.DECSP))
				{
				  condition.And(SYS_USER._.DECSP.Contain(model.DECSP));
				}
				if(model.ORDERID!=null)
				{
				  condition.And(SYS_USER._.ORDERID==(model.ORDERID));
				}
				if(model.CREATEID!=null)
				{
				  condition.And(SYS_USER._.CREATEID==(model.CREATEID));
				}
				if(model.CREATETIME!=null)
				{
				  condition.And(SYS_USER._.CREATETIME==(model.CREATETIME));
				}
				if(model.ISDELETE!=null)
				{
				  condition.And(SYS_USER._.ISDELETE==(model.ISDELETE));
				}
				if(model.SSBM!=null)
				{
				  condition.And(SYS_USER._.SSBM==(model.SSBM));
				}
				if(!string.IsNullOrWhiteSpace(model.E_MAIL))
				{
				  condition.And(SYS_USER._.E_MAIL.Contain(model.E_MAIL));
				}
				if(!string.IsNullOrWhiteSpace(model.SYSTEM_NO))
				{
				  condition.And(SYS_USER._.SYSTEM_NO.Contain(model.SYSTEM_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.SESSION_KEY))
				{
				  condition.And(SYS_USER._.SESSION_KEY.Contain(model.SESSION_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.REFRESH_TOKEN))
				{
				  condition.And(SYS_USER._.REFRESH_TOKEN.Contain(model.REFRESH_TOKEN));
				}
		return condition;
	}
        #endregion
    }
}