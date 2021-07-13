using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TSsoInfoSqService : BaseServiceT<T_SSO_INFO_SQ>
    {
        #region 接口实现
        
		public List<T_SSO_INFO_SQ> FindList(T_SSO_INFO_SQ model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_SSO_INFO_SQ> PageList(T_SSO_INFO_SQ model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_SSO_INFO_SQ._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(T_SSO_INFO_SQ._.ID == ID);
			
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
        public GeneralResult Edit(T_SSO_INFO_SQ model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_SSO_INFO_SQ entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.REDIRECT_URI=model.REDIRECT_URI;
		entity.LOGOUT_URL=model.LOGOUT_URL;
		entity.NAME=model.NAME;
		entity.CITY_NAME=model.CITY_NAME;
		entity.EMAIL=model.EMAIL;
		entity.CONTACT_PERSON=model.CONTACT_PERSON;
		entity.PHONE_NO=model.PHONE_NO;
		entity.CLIENT_ID=model.CLIENT_ID;
		entity.CLIENT_SECRET=model.CLIENT_SECRET;
		entity.STATUS=model.STATUS;
		entity.REMARK=model.REMARK;
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
        public GeneralResult Add(T_SSO_INFO_SQ model)
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
                    Delete(T_SSO_INFO_SQ._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_SSO_INFO_SQ> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_SSO_INFO_SQ model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_SSO_INFO_SQ._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.REDIRECT_URI))
				{
				  condition.And(T_SSO_INFO_SQ._.REDIRECT_URI.Contain(model.REDIRECT_URI));
				}
				if(!string.IsNullOrWhiteSpace(model.LOGOUT_URL))
				{
				  condition.And(T_SSO_INFO_SQ._.LOGOUT_URL.Contain(model.LOGOUT_URL));
				}
				if(!string.IsNullOrWhiteSpace(model.NAME))
				{
				  condition.And(T_SSO_INFO_SQ._.NAME.Contain(model.NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CITY_NAME))
				{
				  condition.And(T_SSO_INFO_SQ._.CITY_NAME.Contain(model.CITY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.EMAIL))
				{
				  condition.And(T_SSO_INFO_SQ._.EMAIL.Contain(model.EMAIL));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTACT_PERSON))
				{
				  condition.And(T_SSO_INFO_SQ._.CONTACT_PERSON.Contain(model.CONTACT_PERSON));
				}
				if(!string.IsNullOrWhiteSpace(model.PHONE_NO))
				{
				  condition.And(T_SSO_INFO_SQ._.PHONE_NO.Contain(model.PHONE_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.CLIENT_ID))
				{
				  condition.And(T_SSO_INFO_SQ._.CLIENT_ID.Contain(model.CLIENT_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.CLIENT_SECRET))
				{
				  condition.And(T_SSO_INFO_SQ._.CLIENT_SECRET.Contain(model.CLIENT_SECRET));
				}
				if(model.STATUS!=null)
				{
				  condition.And(T_SSO_INFO_SQ._.STATUS==(model.STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(T_SSO_INFO_SQ._.REMARK.Contain(model.REMARK));
				}
		return condition;
	}
        #endregion
    }
}