using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TZtBiddercontractService : BaseServiceT<T_ZT_BIDDERCONTRACT>
    {
        #region 接口实现
        
		public List<T_ZT_BIDDERCONTRACT> FindList(T_ZT_BIDDERCONTRACT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_ZT_BIDDERCONTRACT> PageList(T_ZT_BIDDERCONTRACT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_ZT_BIDDERCONTRACT._.BIDDERNO.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="BIDDERNO">主体代码</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string BIDDERNO)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_ZT_BIDDERCONTRACT._.BIDDERNO == BIDDERNO);
			
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
        public GeneralResult Edit(T_ZT_BIDDERCONTRACT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.BIDDERNO);
	
	if(viewResult.Success  && viewResult.Data is T_ZT_BIDDERCONTRACT entity)
	{		
		entity.Attach();
		entity.BIDDERNO=model.BIDDERNO;
		entity.SECTIONNO=model.SECTIONNO;
		entity.SECTIONNAME=model.SECTIONNAME;
		entity.TENDERNO=model.TENDERNO;
		entity.TENDERNAME=model.TENDERNAME;
		entity.BIDAMOUNT=model.BIDAMOUNT;
		entity.CONTRACTAMOUNT=model.CONTRACTAMOUNT;
		entity.CURRENCY=model.CURRENCY;
		entity.MONEYUNIT=model.MONEYUNIT;
		entity.CONTRACTSIGNDATE=model.CONTRACTSIGNDATE;
		entity.DATASOURCECODE=model.DATASOURCECODE;
		entity.DATATIMESTAMP=model.DATATIMESTAMP;
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
        public GeneralResult Add(T_ZT_BIDDERCONTRACT model)
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
                    Delete(T_ZT_BIDDERCONTRACT._.BIDDERNO.SelectIn(idArr));
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
        public GeneralResult Import(List<T_ZT_BIDDERCONTRACT> model)
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
       	protected WhereClipBuilder ConditionBuilder(T_ZT_BIDDERCONTRACT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.BIDDERNO))
				{
				  condition.And(T_ZT_BIDDERCONTRACT._.BIDDERNO.Contain(model.BIDDERNO));
				}
				if(!string.IsNullOrWhiteSpace(model.SECTIONNO))
				{
				  condition.And(T_ZT_BIDDERCONTRACT._.SECTIONNO.Contain(model.SECTIONNO));
				}
				if(!string.IsNullOrWhiteSpace(model.SECTIONNAME))
				{
				  condition.And(T_ZT_BIDDERCONTRACT._.SECTIONNAME.Contain(model.SECTIONNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERNO))
				{
				  condition.And(T_ZT_BIDDERCONTRACT._.TENDERNO.Contain(model.TENDERNO));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERNAME))
				{
				  condition.And(T_ZT_BIDDERCONTRACT._.TENDERNAME.Contain(model.TENDERNAME));
				}
				if(model.BIDAMOUNT!=null)
				{
				  condition.And(T_ZT_BIDDERCONTRACT._.BIDAMOUNT==(model.BIDAMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACTAMOUNT))
				{
				  condition.And(T_ZT_BIDDERCONTRACT._.CONTRACTAMOUNT.Contain(model.CONTRACTAMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.CURRENCY))
				{
				  condition.And(T_ZT_BIDDERCONTRACT._.CURRENCY.Contain(model.CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.MONEYUNIT))
				{
				  condition.And(T_ZT_BIDDERCONTRACT._.MONEYUNIT.Contain(model.MONEYUNIT));
				}
				if(model.CONTRACTSIGNDATE!=null)
				{
				  condition.And(T_ZT_BIDDERCONTRACT._.CONTRACTSIGNDATE==(model.CONTRACTSIGNDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.DATASOURCECODE))
				{
				  condition.And(T_ZT_BIDDERCONTRACT._.DATASOURCECODE.Contain(model.DATASOURCECODE));
				}
				if(model.DATATIMESTAMP!=null)
				{
				  condition.And(T_ZT_BIDDERCONTRACT._.DATATIMESTAMP==(model.DATATIMESTAMP));
				}
		return condition;
	}
        #endregion
    }
}