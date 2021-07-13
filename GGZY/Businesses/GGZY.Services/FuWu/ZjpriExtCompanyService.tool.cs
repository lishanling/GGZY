using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ZjpriExtCompanyService : BaseServiceT<ZJPRI_EXT_COMPANY>
    {
        #region 接口实现
        
		public List<ZJPRI_EXT_COMPANY> FindList(ZJPRI_EXT_COMPANY model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<ZJPRI_EXT_COMPANY> PageList(ZJPRI_EXT_COMPANY model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, ZJPRI_EXT_COMPANY._.ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(ZJPRI_EXT_COMPANY._.ID == ID);
			
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
        public GeneralResult Edit(ZJPRI_EXT_COMPANY model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is ZJPRI_EXT_COMPANY entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.VERSION=model.VERSION;
		entity.DATA_SOURCE=model.DATA_SOURCE;
		entity.FILES=model.FILES;
		entity.LEGAL_NAME=model.LEGAL_NAME;
		entity.LEGAL_OLD_NAME=model.LEGAL_OLD_NAME;
		entity.LEGAL_CODE=model.LEGAL_CODE;
		entity.CREDIT_RATE=model.CREDIT_RATE;
		entity.BASIC_BANK=model.BASIC_BANK;
		entity.BASIC_BRANCH_BANK=model.BASIC_BRANCH_BANK;
		entity.BASIC_ACCOUNT_NO=model.BASIC_ACCOUNT_NO;
		entity.BASIC_ACCOUNT_NAME=model.BASIC_ACCOUNT_NAME;
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
        public GeneralResult Add(ZJPRI_EXT_COMPANY model)
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
                    Delete(ZJPRI_EXT_COMPANY._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<ZJPRI_EXT_COMPANY> model)
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
       	protected WhereClipBuilder ConditionBuilder(ZJPRI_EXT_COMPANY model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ID))
				{
				  condition.And(ZJPRI_EXT_COMPANY._.ID.Contain(model.ID));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(ZJPRI_EXT_COMPANY._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.VERSION))
				{
				  condition.And(ZJPRI_EXT_COMPANY._.VERSION.Contain(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(ZJPRI_EXT_COMPANY._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.FILES))
				{
				  condition.And(ZJPRI_EXT_COMPANY._.FILES.Contain(model.FILES));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_NAME))
				{
				  condition.And(ZJPRI_EXT_COMPANY._.LEGAL_NAME.Contain(model.LEGAL_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_OLD_NAME))
				{
				  condition.And(ZJPRI_EXT_COMPANY._.LEGAL_OLD_NAME.Contain(model.LEGAL_OLD_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_CODE))
				{
				  condition.And(ZJPRI_EXT_COMPANY._.LEGAL_CODE.Contain(model.LEGAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CREDIT_RATE))
				{
				  condition.And(ZJPRI_EXT_COMPANY._.CREDIT_RATE.Contain(model.CREDIT_RATE));
				}
				if(!string.IsNullOrWhiteSpace(model.BASIC_BANK))
				{
				  condition.And(ZJPRI_EXT_COMPANY._.BASIC_BANK.Contain(model.BASIC_BANK));
				}
				if(!string.IsNullOrWhiteSpace(model.BASIC_BRANCH_BANK))
				{
				  condition.And(ZJPRI_EXT_COMPANY._.BASIC_BRANCH_BANK.Contain(model.BASIC_BRANCH_BANK));
				}
				if(!string.IsNullOrWhiteSpace(model.BASIC_ACCOUNT_NO))
				{
				  condition.And(ZJPRI_EXT_COMPANY._.BASIC_ACCOUNT_NO.Contain(model.BASIC_ACCOUNT_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.BASIC_ACCOUNT_NAME))
				{
				  condition.And(ZJPRI_EXT_COMPANY._.BASIC_ACCOUNT_NAME.Contain(model.BASIC_ACCOUNT_NAME));
				}
		return condition;
	}
        #endregion
    }
}