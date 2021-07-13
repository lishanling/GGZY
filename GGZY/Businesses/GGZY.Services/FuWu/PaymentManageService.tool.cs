using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class PaymentManageService : BaseServiceT<PAYMENT_MANAGE>
    {
        #region 接口实现
        
		public List<PAYMENT_MANAGE> FindList(PAYMENT_MANAGE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PAYMENT_MANAGE> PageList(PAYMENT_MANAGE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PAYMENT_MANAGE._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PAYMENT_MANAGE._.ID == ID);
			
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
        public GeneralResult Edit(PAYMENT_MANAGE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PAYMENT_MANAGE entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.LOT_NUM=model.LOT_NUM;
		entity.TITLE_NAME=model.TITLE_NAME;
		entity.BIDDER_NAME=model.BIDDER_NAME;
		entity.BID_CODE=model.BID_CODE;
		entity.BID_BOND=model.BID_BOND;
		entity.PREPAYMENT_PAYMENT=model.PREPAYMENT_PAYMENT;
		entity.PREPAID_RETURN=model.PREPAID_RETURN;
		entity.TRANSACTION_SERVICE=model.TRANSACTION_SERVICE;
		entity.CONTRACT_PRICE=model.CONTRACT_PRICE;
		entity.PAY_FORM=model.PAY_FORM;
		entity.RECEPTION_TIME=model.RECEPTION_TIME;
		entity.ARRIVAL_TIME=model.ARRIVAL_TIME;
		entity.MONEY=model.MONEY;
		entity.CURRENCY=model.CURRENCY;
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
        public GeneralResult Add(PAYMENT_MANAGE model)
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
                    Delete(PAYMENT_MANAGE._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PAYMENT_MANAGE> model)
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
       	protected WhereClipBuilder ConditionBuilder(PAYMENT_MANAGE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PAYMENT_MANAGE._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.LOT_NUM))
				{
				  condition.And(PAYMENT_MANAGE._.LOT_NUM.Contain(model.LOT_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.TITLE_NAME))
				{
				  condition.And(PAYMENT_MANAGE._.TITLE_NAME.Contain(model.TITLE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_NAME))
				{
				  condition.And(PAYMENT_MANAGE._.BIDDER_NAME.Contain(model.BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_CODE))
				{
				  condition.And(PAYMENT_MANAGE._.BID_CODE.Contain(model.BID_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_BOND))
				{
				  condition.And(PAYMENT_MANAGE._.BID_BOND.Contain(model.BID_BOND));
				}
				if(!string.IsNullOrWhiteSpace(model.PREPAYMENT_PAYMENT))
				{
				  condition.And(PAYMENT_MANAGE._.PREPAYMENT_PAYMENT.Contain(model.PREPAYMENT_PAYMENT));
				}
				if(!string.IsNullOrWhiteSpace(model.PREPAID_RETURN))
				{
				  condition.And(PAYMENT_MANAGE._.PREPAID_RETURN.Contain(model.PREPAID_RETURN));
				}
				if(!string.IsNullOrWhiteSpace(model.TRANSACTION_SERVICE))
				{
				  condition.And(PAYMENT_MANAGE._.TRANSACTION_SERVICE.Contain(model.TRANSACTION_SERVICE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_PRICE))
				{
				  condition.And(PAYMENT_MANAGE._.CONTRACT_PRICE.Contain(model.CONTRACT_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.PAY_FORM))
				{
				  condition.And(PAYMENT_MANAGE._.PAY_FORM.Contain(model.PAY_FORM));
				}
				if(model.RECEPTION_TIME!=null)
				{
				  condition.And(PAYMENT_MANAGE._.RECEPTION_TIME==(model.RECEPTION_TIME));
				}
				if(model.ARRIVAL_TIME!=null)
				{
				  condition.And(PAYMENT_MANAGE._.ARRIVAL_TIME==(model.ARRIVAL_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.MONEY))
				{
				  condition.And(PAYMENT_MANAGE._.MONEY.Contain(model.MONEY));
				}
				if(!string.IsNullOrWhiteSpace(model.CURRENCY))
				{
				  condition.And(PAYMENT_MANAGE._.CURRENCY.Contain(model.CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIT))
				{
				  condition.And(PAYMENT_MANAGE._.UNIT.Contain(model.UNIT));
				}
		return condition;
	}
        #endregion
    }
}