using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class PaymentAuditService : BaseServiceT<PAYMENT_AUDIT>
    {
        #region 接口实现
        
		public List<PAYMENT_AUDIT> FindList(PAYMENT_AUDIT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PAYMENT_AUDIT> PageList(PAYMENT_AUDIT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PAYMENT_AUDIT._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PAYMENT_AUDIT._.ID == ID);
			
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
        public GeneralResult Edit(PAYMENT_AUDIT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PAYMENT_AUDIT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.BID_BOND=model.BID_BOND;
		entity.PREPAYMENTS=model.PREPAYMENTS;
		entity.SERVICE_FEE=model.SERVICE_FEE;
		entity.FINANCIAL_AUDIT=model.FINANCIAL_AUDIT;
		entity.MARGIN=model.MARGIN;
		entity.PAYMENT_FORM=model.PAYMENT_FORM;
		entity.PAY_TIME=model.PAY_TIME;
		entity.MONEY=model.MONEY;
		entity.UNIT=model.UNIT;
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
        public GeneralResult Add(PAYMENT_AUDIT model)
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
                    Delete(PAYMENT_AUDIT._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PAYMENT_AUDIT> model)
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
       	protected WhereClipBuilder ConditionBuilder(PAYMENT_AUDIT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PAYMENT_AUDIT._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_BOND))
				{
				  condition.And(PAYMENT_AUDIT._.BID_BOND.Contain(model.BID_BOND));
				}
				if(!string.IsNullOrWhiteSpace(model.PREPAYMENTS))
				{
				  condition.And(PAYMENT_AUDIT._.PREPAYMENTS.Contain(model.PREPAYMENTS));
				}
				if(!string.IsNullOrWhiteSpace(model.SERVICE_FEE))
				{
				  condition.And(PAYMENT_AUDIT._.SERVICE_FEE.Contain(model.SERVICE_FEE));
				}
				if(!string.IsNullOrWhiteSpace(model.FINANCIAL_AUDIT))
				{
				  condition.And(PAYMENT_AUDIT._.FINANCIAL_AUDIT.Contain(model.FINANCIAL_AUDIT));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN))
				{
				  condition.And(PAYMENT_AUDIT._.MARGIN.Contain(model.MARGIN));
				}
				if(!string.IsNullOrWhiteSpace(model.PAYMENT_FORM))
				{
				  condition.And(PAYMENT_AUDIT._.PAYMENT_FORM.Contain(model.PAYMENT_FORM));
				}
				if(model.PAY_TIME!=null)
				{
				  condition.And(PAYMENT_AUDIT._.PAY_TIME==(model.PAY_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MONEY))
				{
				  condition.And(PAYMENT_AUDIT._.MONEY.Contain(model.MONEY));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIT))
				{
				  condition.And(PAYMENT_AUDIT._.UNIT.Contain(model.UNIT));
				}
		return condition;
	}
        #endregion
    }
}