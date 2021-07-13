using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class RecordContractService : BaseServiceT<RECORD_CONTRACT>
    {
        #region 接口实现
        
		public List<RECORD_CONTRACT> FindList(RECORD_CONTRACT model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<RECORD_CONTRACT> PageList(RECORD_CONTRACT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, RECORD_CONTRACT._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="RECORD_ID">备案主表ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? RECORD_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(RECORD_CONTRACT._.RECORD_ID == RECORD_ID);
			
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
        public GeneralResult Edit(RECORD_CONTRACT model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.RECORD_ID);
	
	if(viewResult.Success  && viewResult.Data is RECORD_CONTRACT entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.RECORD_ID=model.RECORD_ID;
		entity.PARTY_A=model.PARTY_A;
		entity.PARTY_A_CODE=model.PARTY_A_CODE;
		entity.PARTY_B=model.PARTY_B;
		entity.PARTY_B_CODE=model.PARTY_B_CODE;
		entity.WIN_NOTICE_TIME=model.WIN_NOTICE_TIME;
		entity.CONTRACT_TIME=model.CONTRACT_TIME;
		entity.BID_AMOUNT=model.BID_AMOUNT;
		entity.BID_AMOUNT_CURRENCY=model.BID_AMOUNT_CURRENCY;
		entity.BID_AMOUNT_UNIT=model.BID_AMOUNT_UNIT;
		entity.CONTRACT_AMOUNT=model.CONTRACT_AMOUNT;
		entity.CONTRACT_AMOUNT_CURRENCY=model.CONTRACT_AMOUNT_CURRENCY;
		entity.CONTRACT_AMOUNT_UNIT=model.CONTRACT_AMOUNT_UNIT;
		entity.CREATE_TM=model.CREATE_TM;
		entity.CREATOR=model.CREATOR;
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
        public GeneralResult Add(RECORD_CONTRACT model)
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
                    Delete(RECORD_CONTRACT._.RECORD_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<RECORD_CONTRACT> model)
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
       	protected WhereClipBuilder ConditionBuilder(RECORD_CONTRACT model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(RECORD_CONTRACT._.ID==(model.ID));
				}
				if(model.RECORD_ID!=null)
				{
				  condition.And(RECORD_CONTRACT._.RECORD_ID==(model.RECORD_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.PARTY_A))
				{
				  condition.And(RECORD_CONTRACT._.PARTY_A.Contain(model.PARTY_A));
				}
				if(!string.IsNullOrWhiteSpace(model.PARTY_A_CODE))
				{
				  condition.And(RECORD_CONTRACT._.PARTY_A_CODE.Contain(model.PARTY_A_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PARTY_B))
				{
				  condition.And(RECORD_CONTRACT._.PARTY_B.Contain(model.PARTY_B));
				}
				if(!string.IsNullOrWhiteSpace(model.PARTY_B_CODE))
				{
				  condition.And(RECORD_CONTRACT._.PARTY_B_CODE.Contain(model.PARTY_B_CODE));
				}
				if(model.WIN_NOTICE_TIME!=null)
				{
				  condition.And(RECORD_CONTRACT._.WIN_NOTICE_TIME==(model.WIN_NOTICE_TIME));
				}
				if(model.CONTRACT_TIME!=null)
				{
				  condition.And(RECORD_CONTRACT._.CONTRACT_TIME==(model.CONTRACT_TIME));
				}
				if(model.BID_AMOUNT!=null)
				{
				  condition.And(RECORD_CONTRACT._.BID_AMOUNT==(model.BID_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_AMOUNT_CURRENCY))
				{
				  condition.And(RECORD_CONTRACT._.BID_AMOUNT_CURRENCY.Contain(model.BID_AMOUNT_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_AMOUNT_UNIT))
				{
				  condition.And(RECORD_CONTRACT._.BID_AMOUNT_UNIT.Contain(model.BID_AMOUNT_UNIT));
				}
				if(model.CONTRACT_AMOUNT!=null)
				{
				  condition.And(RECORD_CONTRACT._.CONTRACT_AMOUNT==(model.CONTRACT_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_AMOUNT_CURRENCY))
				{
				  condition.And(RECORD_CONTRACT._.CONTRACT_AMOUNT_CURRENCY.Contain(model.CONTRACT_AMOUNT_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_AMOUNT_UNIT))
				{
				  condition.And(RECORD_CONTRACT._.CONTRACT_AMOUNT_UNIT.Contain(model.CONTRACT_AMOUNT_UNIT));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(RECORD_CONTRACT._.CREATE_TM==(model.CREATE_TM));
				}
				if(model.CREATOR!=null)
				{
				  condition.And(RECORD_CONTRACT._.CREATOR==(model.CREATOR));
				}
		return condition;
	}
        #endregion
    }
}