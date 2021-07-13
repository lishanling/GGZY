using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TcpSystemService : BaseServiceT<TCP_SYSTEM>
    {
        #region 接口实现
        
		public List<TCP_SYSTEM> FindList(TCP_SYSTEM model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TCP_SYSTEM> PageList(TCP_SYSTEM model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, TCP_SYSTEM._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(TCP_SYSTEM._.ID == ID);
			
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
        public GeneralResult Edit(TCP_SYSTEM model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is TCP_SYSTEM entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.C_CODE=model.C_CODE;
		entity.APP_CATEGORY=model.APP_CATEGORY;
		entity.V_NUMBER=model.V_NUMBER;
		entity.V_DATE=model.V_DATE;
		entity.D_NUMBER=model.D_NUMBER;
		entity.BU_CODE=model.BU_CODE;
		entity.BU_BANK_NUMBER=model.BU_BANK_NUMBER;
		entity.APPLY_DATE=model.APPLY_DATE;
		entity.PAYER_ID=model.PAYER_ID;
		entity.PAYER=model.PAYER;
		entity.PAYER_BANK_NUMBER=model.PAYER_BANK_NUMBER;
		entity.PAYER_BANK_LNUMBER=model.PAYER_BANK_LNUMBER;
		entity.PAYER_DE_BANK=model.PAYER_DE_BANK;
		entity.PAYEE_ID=model.PAYEE_ID;
		entity.PAYEE=model.PAYEE;
		entity.PAYEE_AN=model.PAYEE_AN;
		entity.PAYEE_DE_BANK=model.PAYEE_DE_BANK;
		entity.PAYEE_BANK_LNUMBER=model.PAYEE_BANK_LNUMBER;
		entity.LOGINP_ID=model.LOGINP_ID;
		entity.LOGINP=model.LOGINP;
		entity.LOGIN_DATE=model.LOGIN_DATE;
		entity.AUDITOR_ID=model.AUDITOR_ID;
		entity.AUDITOR=model.AUDITOR;
		entity.A_DATE=model.A_DATE;
		entity.CONFIRMP_ID=model.CONFIRMP_ID;
		entity.CONFIRMP=model.CONFIRMP;
		entity.CONFIRM_DATE=model.CONFIRM_DATE;
		entity.SETTLEP_ID=model.SETTLEP_ID;
		entity.SETTLEP=model.SETTLEP;
		entity.SETTLE_DATE=model.SETTLE_DATE;
		entity.APP_TYPE=model.APP_TYPE;
		entity.STATUS=model.STATUS;
		entity.M_TM=model.M_TM;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.DATA_KEY=model.DATA_KEY;
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
        public GeneralResult Add(TCP_SYSTEM model)
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
                    Delete(TCP_SYSTEM._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<TCP_SYSTEM> model)
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
       	protected WhereClipBuilder ConditionBuilder(TCP_SYSTEM model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(TCP_SYSTEM._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.C_CODE))
				{
				  condition.And(TCP_SYSTEM._.C_CODE.Contain(model.C_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.APP_CATEGORY))
				{
				  condition.And(TCP_SYSTEM._.APP_CATEGORY.Contain(model.APP_CATEGORY));
				}
				if(!string.IsNullOrWhiteSpace(model.V_NUMBER))
				{
				  condition.And(TCP_SYSTEM._.V_NUMBER.Contain(model.V_NUMBER));
				}
				if(model.V_DATE!=null)
				{
				  condition.And(TCP_SYSTEM._.V_DATE==(model.V_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.D_NUMBER))
				{
				  condition.And(TCP_SYSTEM._.D_NUMBER.Contain(model.D_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.BU_CODE))
				{
				  condition.And(TCP_SYSTEM._.BU_CODE.Contain(model.BU_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BU_BANK_NUMBER))
				{
				  condition.And(TCP_SYSTEM._.BU_BANK_NUMBER.Contain(model.BU_BANK_NUMBER));
				}
				if(model.APPLY_DATE!=null)
				{
				  condition.And(TCP_SYSTEM._.APPLY_DATE==(model.APPLY_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.PAYER_ID))
				{
				  condition.And(TCP_SYSTEM._.PAYER_ID.Contain(model.PAYER_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.PAYER))
				{
				  condition.And(TCP_SYSTEM._.PAYER.Contain(model.PAYER));
				}
				if(!string.IsNullOrWhiteSpace(model.PAYER_BANK_NUMBER))
				{
				  condition.And(TCP_SYSTEM._.PAYER_BANK_NUMBER.Contain(model.PAYER_BANK_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.PAYER_BANK_LNUMBER))
				{
				  condition.And(TCP_SYSTEM._.PAYER_BANK_LNUMBER.Contain(model.PAYER_BANK_LNUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.PAYER_DE_BANK))
				{
				  condition.And(TCP_SYSTEM._.PAYER_DE_BANK.Contain(model.PAYER_DE_BANK));
				}
				if(!string.IsNullOrWhiteSpace(model.PAYEE_ID))
				{
				  condition.And(TCP_SYSTEM._.PAYEE_ID.Contain(model.PAYEE_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.PAYEE))
				{
				  condition.And(TCP_SYSTEM._.PAYEE.Contain(model.PAYEE));
				}
				if(!string.IsNullOrWhiteSpace(model.PAYEE_AN))
				{
				  condition.And(TCP_SYSTEM._.PAYEE_AN.Contain(model.PAYEE_AN));
				}
				if(!string.IsNullOrWhiteSpace(model.PAYEE_DE_BANK))
				{
				  condition.And(TCP_SYSTEM._.PAYEE_DE_BANK.Contain(model.PAYEE_DE_BANK));
				}
				if(!string.IsNullOrWhiteSpace(model.PAYEE_BANK_LNUMBER))
				{
				  condition.And(TCP_SYSTEM._.PAYEE_BANK_LNUMBER.Contain(model.PAYEE_BANK_LNUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.LOGINP_ID))
				{
				  condition.And(TCP_SYSTEM._.LOGINP_ID.Contain(model.LOGINP_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.LOGINP))
				{
				  condition.And(TCP_SYSTEM._.LOGINP.Contain(model.LOGINP));
				}
				if(model.LOGIN_DATE!=null)
				{
				  condition.And(TCP_SYSTEM._.LOGIN_DATE==(model.LOGIN_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.AUDITOR_ID))
				{
				  condition.And(TCP_SYSTEM._.AUDITOR_ID.Contain(model.AUDITOR_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.AUDITOR))
				{
				  condition.And(TCP_SYSTEM._.AUDITOR.Contain(model.AUDITOR));
				}
				if(model.A_DATE!=null)
				{
				  condition.And(TCP_SYSTEM._.A_DATE==(model.A_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONFIRMP_ID))
				{
				  condition.And(TCP_SYSTEM._.CONFIRMP_ID.Contain(model.CONFIRMP_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.CONFIRMP))
				{
				  condition.And(TCP_SYSTEM._.CONFIRMP.Contain(model.CONFIRMP));
				}
				if(model.CONFIRM_DATE!=null)
				{
				  condition.And(TCP_SYSTEM._.CONFIRM_DATE==(model.CONFIRM_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.SETTLEP_ID))
				{
				  condition.And(TCP_SYSTEM._.SETTLEP_ID.Contain(model.SETTLEP_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.SETTLEP))
				{
				  condition.And(TCP_SYSTEM._.SETTLEP.Contain(model.SETTLEP));
				}
				if(model.SETTLE_DATE!=null)
				{
				  condition.And(TCP_SYSTEM._.SETTLE_DATE==(model.SETTLE_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.APP_TYPE))
				{
				  condition.And(TCP_SYSTEM._.APP_TYPE.Contain(model.APP_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.STATUS))
				{
				  condition.And(TCP_SYSTEM._.STATUS.Contain(model.STATUS));
				}
				if(model.M_TM!=null)
				{
				  condition.And(TCP_SYSTEM._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(TCP_SYSTEM._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(TCP_SYSTEM._.DATA_KEY.Contain(model.DATA_KEY));
				}
		return condition;
	}
        #endregion
    }
}