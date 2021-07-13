using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class MakPerService : BaseServiceT<MAK_PER>
    {
        #region 接口实现
        
		public List<MAK_PER> FindList(MAK_PER model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<MAK_PER> PageList(MAK_PER model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, MAK_PER._.ID.Desc).ToBootstrapTableList(count);

            
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
			condition.And(MAK_PER._.ID == ID);
			
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
        public GeneralResult Edit(MAK_PER model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is MAK_PER entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.BID_BUR_ASS=model.BID_BUR_ASS;
		entity.BID_NUM=model.BID_NUM;
		entity.BID_NAME=model.BID_NAME;
		entity.TENDER_CODE=model.TENDER_CODE;
		entity.TENDER_NAME=model.TENDER_NAME;
		entity.WIN_BID_MONEY=model.WIN_BID_MONEY;
		entity.CONTRACT=model.CONTRACT;
		entity.CONTRACT_SET=model.CONTRACT_SET;
		entity.CONTRACT_PER=model.CONTRACT_PER;
		entity.ACTUAL=model.ACTUAL;
		entity.AMOUNT_CODE=model.AMOUNT_CODE;
		entity.CURRENCY_UNIT=model.CURRENCY_UNIT;
		entity.CONTRACT_TIME=model.CONTRACT_TIME;
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
        public GeneralResult Add(MAK_PER model)
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
                    Delete(MAK_PER._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<MAK_PER> model)
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
       	protected WhereClipBuilder ConditionBuilder(MAK_PER model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(MAK_PER._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_BUR_ASS))
				{
				  condition.And(MAK_PER._.BID_BUR_ASS.Contain(model.BID_BUR_ASS));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_NUM))
				{
				  condition.And(MAK_PER._.BID_NUM.Contain(model.BID_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_NAME))
				{
				  condition.And(MAK_PER._.BID_NAME.Contain(model.BID_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_CODE))
				{
				  condition.And(MAK_PER._.TENDER_CODE.Contain(model.TENDER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_NAME))
				{
				  condition.And(MAK_PER._.TENDER_NAME.Contain(model.TENDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.WIN_BID_MONEY))
				{
				  condition.And(MAK_PER._.WIN_BID_MONEY.Contain(model.WIN_BID_MONEY));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT))
				{
				  condition.And(MAK_PER._.CONTRACT.Contain(model.CONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_SET))
				{
				  condition.And(MAK_PER._.CONTRACT_SET.Contain(model.CONTRACT_SET));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_PER))
				{
				  condition.And(MAK_PER._.CONTRACT_PER.Contain(model.CONTRACT_PER));
				}
				if(!string.IsNullOrWhiteSpace(model.ACTUAL))
				{
				  condition.And(MAK_PER._.ACTUAL.Contain(model.ACTUAL));
				}
				if(!string.IsNullOrWhiteSpace(model.AMOUNT_CODE))
				{
				  condition.And(MAK_PER._.AMOUNT_CODE.Contain(model.AMOUNT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CURRENCY_UNIT))
				{
				  condition.And(MAK_PER._.CURRENCY_UNIT.Contain(model.CURRENCY_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_TIME))
				{
				  condition.And(MAK_PER._.CONTRACT_TIME.Contain(model.CONTRACT_TIME));
				}
		return condition;
	}
        #endregion
    }
}