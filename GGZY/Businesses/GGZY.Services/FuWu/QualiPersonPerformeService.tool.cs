using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class QualiPersonPerformeService : BaseServiceT<QUALI_PERSON_PERFORME>
    {
        #region 接口实现
        
		public List<QUALI_PERSON_PERFORME> FindList(QUALI_PERSON_PERFORME model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<QUALI_PERSON_PERFORME> PageList(QUALI_PERSON_PERFORME model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, QUALI_PERSON_PERFORME._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(QUALI_PERSON_PERFORME._.M_ID == M_ID);
			
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
        public GeneralResult Edit(QUALI_PERSON_PERFORME model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is QUALI_PERSON_PERFORME entity)
	{		
		entity.Attach();
		entity.ID_CARD_NO=model.ID_CARD_NO;
		entity.ID_CARD_TYPE=model.ID_CARD_TYPE;
		entity.SECTION_NO=model.SECTION_NO;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.SECTION_NAME=model.SECTION_NAME;
		entity.BID_SECTION_NAME=model.BID_SECTION_NAME;
		entity.OWNER_NO=model.OWNER_NO;
		entity.OWNER_NAME=model.OWNER_NAME;
		entity.CONTRACT_AMOUNT=model.CONTRACT_AMOUNT;
		entity.TRADE_TYPE=model.TRADE_TYPE;
		entity.SETTLE_AMOUNT=model.SETTLE_AMOUNT;
		entity.CURRENCY=model.CURRENCY;
		entity.MONEY_UNIT=model.MONEY_UNIT;
		entity.CONTRACT_SIGN_DATE=model.CONTRACT_SIGN_DATE;
		entity.CONTRACT_FINISH_DATE=model.CONTRACT_FINISH_DATE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_F_ID=model.M_F_ID;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_VERSION=model.M_VERSION;
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
        public GeneralResult Add(QUALI_PERSON_PERFORME model)
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
                    Delete(QUALI_PERSON_PERFORME._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<QUALI_PERSON_PERFORME> model)
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
       	protected WhereClipBuilder ConditionBuilder(QUALI_PERSON_PERFORME model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ID_CARD_NO))
				{
				  condition.And(QUALI_PERSON_PERFORME._.ID_CARD_NO.Contain(model.ID_CARD_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD_TYPE))
				{
				  condition.And(QUALI_PERSON_PERFORME._.ID_CARD_TYPE.Contain(model.ID_CARD_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.SECTION_NO))
				{
				  condition.And(QUALI_PERSON_PERFORME._.SECTION_NO.Contain(model.SECTION_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(QUALI_PERSON_PERFORME._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.SECTION_NAME))
				{
				  condition.And(QUALI_PERSON_PERFORME._.SECTION_NAME.Contain(model.SECTION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_NAME))
				{
				  condition.And(QUALI_PERSON_PERFORME._.BID_SECTION_NAME.Contain(model.BID_SECTION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.OWNER_NO))
				{
				  condition.And(QUALI_PERSON_PERFORME._.OWNER_NO.Contain(model.OWNER_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.OWNER_NAME))
				{
				  condition.And(QUALI_PERSON_PERFORME._.OWNER_NAME.Contain(model.OWNER_NAME));
				}
				if(model.CONTRACT_AMOUNT!=null)
				{
				  condition.And(QUALI_PERSON_PERFORME._.CONTRACT_AMOUNT==(model.CONTRACT_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_TYPE))
				{
				  condition.And(QUALI_PERSON_PERFORME._.TRADE_TYPE.Contain(model.TRADE_TYPE));
				}
				if(model.SETTLE_AMOUNT!=null)
				{
				  condition.And(QUALI_PERSON_PERFORME._.SETTLE_AMOUNT==(model.SETTLE_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.CURRENCY))
				{
				  condition.And(QUALI_PERSON_PERFORME._.CURRENCY.Contain(model.CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.MONEY_UNIT))
				{
				  condition.And(QUALI_PERSON_PERFORME._.MONEY_UNIT.Contain(model.MONEY_UNIT));
				}
				if(model.CONTRACT_SIGN_DATE!=null)
				{
				  condition.And(QUALI_PERSON_PERFORME._.CONTRACT_SIGN_DATE==(model.CONTRACT_SIGN_DATE));
				}
				if(model.CONTRACT_FINISH_DATE!=null)
				{
				  condition.And(QUALI_PERSON_PERFORME._.CONTRACT_FINISH_DATE==(model.CONTRACT_FINISH_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(QUALI_PERSON_PERFORME._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(QUALI_PERSON_PERFORME._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(QUALI_PERSON_PERFORME._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(QUALI_PERSON_PERFORME._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(QUALI_PERSON_PERFORME._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(QUALI_PERSON_PERFORME._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(QUALI_PERSON_PERFORME._.M_ID==(model.M_ID));
				}
				if(model.M_F_ID!=null)
				{
				  condition.And(QUALI_PERSON_PERFORME._.M_F_ID==(model.M_F_ID));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(QUALI_PERSON_PERFORME._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(QUALI_PERSON_PERFORME._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(QUALI_PERSON_PERFORME._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(QUALI_PERSON_PERFORME._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}