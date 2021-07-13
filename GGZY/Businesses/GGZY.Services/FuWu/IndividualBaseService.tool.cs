using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class IndividualBaseService : BaseServiceT<INDIVIDUAL_BASE>
    {
        #region 接口实现
        
		public List<INDIVIDUAL_BASE> FindList(INDIVIDUAL_BASE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<INDIVIDUAL_BASE> PageList(INDIVIDUAL_BASE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, INDIVIDUAL_BASE._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID">主键ID 自增</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(INDIVIDUAL_BASE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(INDIVIDUAL_BASE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is INDIVIDUAL_BASE entity)
	{		
		entity.Attach();
		entity.ID_CARD_TYPE=model.ID_CARD_TYPE;
		entity.ID_CARD=model.ID_CARD;
		entity.ID_CARD_END_DATE=model.ID_CARD_END_DATE;
		entity.PERSON_NAME=model.PERSON_NAME;
		entity.CONTACT=model.CONTACT;
		entity.BANK_ACCOUNT=model.BANK_ACCOUNT;
		entity.BANK_NAME=model.BANK_NAME;
		entity.ZIP_CODE=model.ZIP_CODE;
		entity.ADDRESS=model.ADDRESS;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_USER_ID=model.M_USER_ID;
		entity.M_ATT_ID_CARD_DOC=model.M_ATT_ID_CARD_DOC;
		entity.M_ATT_ACCOUNT_DOC=model.M_ATT_ACCOUNT_DOC;
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
        public GeneralResult Add(INDIVIDUAL_BASE model)
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
                    Delete(INDIVIDUAL_BASE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<INDIVIDUAL_BASE> model)
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
       	protected WhereClipBuilder ConditionBuilder(INDIVIDUAL_BASE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.ID_CARD_TYPE))
				{
				  condition.And(INDIVIDUAL_BASE._.ID_CARD_TYPE.Contain(model.ID_CARD_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.ID_CARD))
				{
				  condition.And(INDIVIDUAL_BASE._.ID_CARD.Contain(model.ID_CARD));
				}
				if(model.ID_CARD_END_DATE!=null)
				{
				  condition.And(INDIVIDUAL_BASE._.ID_CARD_END_DATE==(model.ID_CARD_END_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.PERSON_NAME))
				{
				  condition.And(INDIVIDUAL_BASE._.PERSON_NAME.Contain(model.PERSON_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTACT))
				{
				  condition.And(INDIVIDUAL_BASE._.CONTACT.Contain(model.CONTACT));
				}
				if(!string.IsNullOrWhiteSpace(model.BANK_ACCOUNT))
				{
				  condition.And(INDIVIDUAL_BASE._.BANK_ACCOUNT.Contain(model.BANK_ACCOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.BANK_NAME))
				{
				  condition.And(INDIVIDUAL_BASE._.BANK_NAME.Contain(model.BANK_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.ZIP_CODE))
				{
				  condition.And(INDIVIDUAL_BASE._.ZIP_CODE.Contain(model.ZIP_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ADDRESS))
				{
				  condition.And(INDIVIDUAL_BASE._.ADDRESS.Contain(model.ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(INDIVIDUAL_BASE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(INDIVIDUAL_BASE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(INDIVIDUAL_BASE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(INDIVIDUAL_BASE._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(INDIVIDUAL_BASE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(INDIVIDUAL_BASE._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(INDIVIDUAL_BASE._.M_ID==(model.M_ID));
				}
				if(model.M_USER_ID!=null)
				{
				  condition.And(INDIVIDUAL_BASE._.M_USER_ID==(model.M_USER_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_ID_CARD_DOC))
				{
				  condition.And(INDIVIDUAL_BASE._.M_ATT_ID_CARD_DOC.Contain(model.M_ATT_ID_CARD_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_ACCOUNT_DOC))
				{
				  condition.And(INDIVIDUAL_BASE._.M_ATT_ACCOUNT_DOC.Contain(model.M_ATT_ACCOUNT_DOC));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(INDIVIDUAL_BASE._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(INDIVIDUAL_BASE._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(INDIVIDUAL_BASE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(INDIVIDUAL_BASE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}