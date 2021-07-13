using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TUserExtendService : BaseServiceT<T_USER_EXTEND>
    {
        #region 接口实现
        
		public List<T_USER_EXTEND> FindList(T_USER_EXTEND model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_USER_EXTEND> PageList(T_USER_EXTEND model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_USER_EXTEND._.ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID">主键ID 自增</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_USER_EXTEND._.ID == ID);
			
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
        public GeneralResult Edit(T_USER_EXTEND model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is T_USER_EXTEND entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.U_ID=model.U_ID;
		entity.DEP_NAME=model.DEP_NAME;
		entity.DEP_KIND=model.DEP_KIND;
		entity.CODE_TYPE=model.CODE_TYPE;
		entity.UNIFIED_CREDIT_CODE=model.UNIFIED_CREDIT_CODE;
		entity.ORGAN_CODE=model.ORGAN_CODE;
		entity.PROV_CODE=model.PROV_CODE;
		entity.CITY_CODE=model.CITY_CODE;
		entity.COUNTY_CODE=model.COUNTY_CODE;
		entity.POSTAL_CODE=model.POSTAL_CODE;
		entity.ADDRESS=model.ADDRESS;
		entity.CONTACTS=model.CONTACTS;
		entity.CONTACTS_PHONE=model.CONTACTS_PHONE;
		entity.AIDS_UCC=model.AIDS_UCC;
		entity.AIDS_OC=model.AIDS_OC;
		entity.ACCOUNT_TYPE=model.ACCOUNT_TYPE;
		entity.IDCARD=model.IDCARD;
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
        public GeneralResult Add(T_USER_EXTEND model)
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
                    Delete(T_USER_EXTEND._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<T_USER_EXTEND> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_USER_EXTEND model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(T_USER_EXTEND._.ID==(model.ID));
				}
				if(model.U_ID!=null)
				{
				  condition.And(T_USER_EXTEND._.U_ID==(model.U_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DEP_NAME))
				{
				  condition.And(T_USER_EXTEND._.DEP_NAME.Contain(model.DEP_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.DEP_KIND))
				{
				  condition.And(T_USER_EXTEND._.DEP_KIND.Contain(model.DEP_KIND));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE_TYPE))
				{
				  condition.And(T_USER_EXTEND._.CODE_TYPE.Contain(model.CODE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_CREDIT_CODE))
				{
				  condition.And(T_USER_EXTEND._.UNIFIED_CREDIT_CODE.Contain(model.UNIFIED_CREDIT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ORGAN_CODE))
				{
				  condition.And(T_USER_EXTEND._.ORGAN_CODE.Contain(model.ORGAN_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PROV_CODE))
				{
				  condition.And(T_USER_EXTEND._.PROV_CODE.Contain(model.PROV_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CITY_CODE))
				{
				  condition.And(T_USER_EXTEND._.CITY_CODE.Contain(model.CITY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.COUNTY_CODE))
				{
				  condition.And(T_USER_EXTEND._.COUNTY_CODE.Contain(model.COUNTY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.POSTAL_CODE))
				{
				  condition.And(T_USER_EXTEND._.POSTAL_CODE.Contain(model.POSTAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ADDRESS))
				{
				  condition.And(T_USER_EXTEND._.ADDRESS.Contain(model.ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTACTS))
				{
				  condition.And(T_USER_EXTEND._.CONTACTS.Contain(model.CONTACTS));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTACTS_PHONE))
				{
				  condition.And(T_USER_EXTEND._.CONTACTS_PHONE.Contain(model.CONTACTS_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.AIDS_UCC))
				{
				  condition.And(T_USER_EXTEND._.AIDS_UCC.Contain(model.AIDS_UCC));
				}
				if(!string.IsNullOrWhiteSpace(model.AIDS_OC))
				{
				  condition.And(T_USER_EXTEND._.AIDS_OC.Contain(model.AIDS_OC));
				}
				if(!string.IsNullOrWhiteSpace(model.ACCOUNT_TYPE))
				{
				  condition.And(T_USER_EXTEND._.ACCOUNT_TYPE.Contain(model.ACCOUNT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.IDCARD))
				{
				  condition.And(T_USER_EXTEND._.IDCARD.Contain(model.IDCARD));
				}
		return condition;
	}
        #endregion
    }
}