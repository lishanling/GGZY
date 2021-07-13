using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SectionService : BaseServiceT<SECTION>
    {
        #region 接口实现
        
		public List<SECTION> FindList(SECTION model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<SECTION> PageList(SECTION model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, SECTION._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(SECTION._.M_ID == M_ID);
			
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
        public GeneralResult Edit(SECTION model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is SECTION entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODE=model.BID_SECTION_CODE;
		entity.BID_SECTION_NAME=model.BID_SECTION_NAME;
		entity.UNIFIED_DEAL_CODE=model.UNIFIED_DEAL_CODE;
		entity.BID_SECTION_CONTENT=model.BID_SECTION_CONTENT;
		entity.TENDER_PROJECT_CLASSIFY_CODE=model.TENDER_PROJECT_CLASSIFY_CODE;
		entity.CONTRACT_RECKON_PRICE=model.CONTRACT_RECKON_PRICE;
		entity.CURRENCY_CODE=model.CURRENCY_CODE;
		entity.PRICE_UNIT=model.PRICE_UNIT;
		entity.BID_QUALIFICATION=model.BID_QUALIFICATION;
		entity.BEGIN_DATE=model.BEGIN_DATE;
		entity.LIMITE_TIME=model.LIMITE_TIME;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.M_ID=model.M_ID;
		entity.M_ATT_TENDER_FILE=model.M_ATT_TENDER_FILE;
		entity.M_ATT_TENDER_FILE_ATTACHS=model.M_ATT_TENDER_FILE_ATTACHS;
		entity.M_ATT_TENDER_NOTICE=model.M_ATT_TENDER_NOTICE;
		entity.M_ATT_TENDER_AGENT_CONTRACT=model.M_ATT_TENDER_AGENT_CONTRACT;
		entity.M_ATT_FILE_EX_TDOC=model.M_ATT_FILE_EX_TDOC;
		entity.M_ATT_INVITE_DOC=model.M_ATT_INVITE_DOC;
		entity.M_ATT_PUBLICITY_DOC=model.M_ATT_PUBLICITY_DOC;
		entity.M_ATT_WIN_BID_NOTICE=model.M_ATT_WIN_BID_NOTICE;
		entity.M_ATT_DISSENT_DOC=model.M_ATT_DISSENT_DOC;
		entity.M_ATT_CONTRACT_DOC=model.M_ATT_CONTRACT_DOC;
		entity.M_ATT_QUALIFICATION_DOC=model.M_ATT_QUALIFICATION_DOC;
		entity.M_CREATOR=model.M_CREATOR;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_MONEY_UPDATE=model.M_MONEY_UPDATE;
		entity.M_ATT_PUBLICITY_DOC_SIGN=model.M_ATT_PUBLICITY_DOC_SIGN;
		entity.M_ATT_WIN_BID_NOTICE_SIGN=model.M_ATT_WIN_BID_NOTICE_SIGN;
		entity.M_ATT_FILE_EX_TDOC_SIGN=model.M_ATT_FILE_EX_TDOC_SIGN;
		entity.BID_ECTION_NUM=model.BID_ECTION_NUM;
		entity.BID_TENDER_MODE=model.BID_TENDER_MODE;
		entity.REGION_CODE=model.REGION_CODE;
		entity.TRA_PLACE_CODE=model.TRA_PLACE_CODE;
		entity.TRADE_PLAT=model.TRADE_PLAT;
		entity.PUB_SERVICE_PLAT=model.PUB_SERVICE_PLAT;
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
        public GeneralResult Add(SECTION model)
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
                    Delete(SECTION._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<SECTION> model)
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
       	protected WhereClipBuilder ConditionBuilder(SECTION model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(SECTION._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(SECTION._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_NAME))
				{
				  condition.And(SECTION._.BID_SECTION_NAME.Contain(model.BID_SECTION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(SECTION._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CONTENT))
				{
				  condition.And(SECTION._.BID_SECTION_CONTENT.Contain(model.BID_SECTION_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CLASSIFY_CODE))
				{
				  condition.And(SECTION._.TENDER_PROJECT_CLASSIFY_CODE.Contain(model.TENDER_PROJECT_CLASSIFY_CODE));
				}
				if(model.CONTRACT_RECKON_PRICE!=null)
				{
				  condition.And(SECTION._.CONTRACT_RECKON_PRICE==(model.CONTRACT_RECKON_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.CURRENCY_CODE))
				{
				  condition.And(SECTION._.CURRENCY_CODE.Contain(model.CURRENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_UNIT))
				{
				  condition.And(SECTION._.PRICE_UNIT.Contain(model.PRICE_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_QUALIFICATION))
				{
				  condition.And(SECTION._.BID_QUALIFICATION.Contain(model.BID_QUALIFICATION));
				}
				if(model.BEGIN_DATE!=null)
				{
				  condition.And(SECTION._.BEGIN_DATE==(model.BEGIN_DATE));
				}
				if(model.LIMITE_TIME!=null)
				{
				  condition.And(SECTION._.LIMITE_TIME==(model.LIMITE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(SECTION._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(SECTION._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(SECTION._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(SECTION._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(SECTION._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(SECTION._.M_TM==(model.M_TM));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(SECTION._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(model.M_ID!=null)
				{
				  condition.And(SECTION._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TENDER_FILE))
				{
				  condition.And(SECTION._.M_ATT_TENDER_FILE.Contain(model.M_ATT_TENDER_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TENDER_FILE_ATTACHS))
				{
				  condition.And(SECTION._.M_ATT_TENDER_FILE_ATTACHS.Contain(model.M_ATT_TENDER_FILE_ATTACHS));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TENDER_NOTICE))
				{
				  condition.And(SECTION._.M_ATT_TENDER_NOTICE.Contain(model.M_ATT_TENDER_NOTICE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TENDER_AGENT_CONTRACT))
				{
				  condition.And(SECTION._.M_ATT_TENDER_AGENT_CONTRACT.Contain(model.M_ATT_TENDER_AGENT_CONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_FILE_EX_TDOC))
				{
				  condition.And(SECTION._.M_ATT_FILE_EX_TDOC.Contain(model.M_ATT_FILE_EX_TDOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_INVITE_DOC))
				{
				  condition.And(SECTION._.M_ATT_INVITE_DOC.Contain(model.M_ATT_INVITE_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PUBLICITY_DOC))
				{
				  condition.And(SECTION._.M_ATT_PUBLICITY_DOC.Contain(model.M_ATT_PUBLICITY_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_WIN_BID_NOTICE))
				{
				  condition.And(SECTION._.M_ATT_WIN_BID_NOTICE.Contain(model.M_ATT_WIN_BID_NOTICE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_DISSENT_DOC))
				{
				  condition.And(SECTION._.M_ATT_DISSENT_DOC.Contain(model.M_ATT_DISSENT_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_CONTRACT_DOC))
				{
				  condition.And(SECTION._.M_ATT_CONTRACT_DOC.Contain(model.M_ATT_CONTRACT_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_QUALIFICATION_DOC))
				{
				  condition.And(SECTION._.M_ATT_QUALIFICATION_DOC.Contain(model.M_ATT_QUALIFICATION_DOC));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(SECTION._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(SECTION._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(SECTION._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(SECTION._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_MONEY_UPDATE))
				{
				  condition.And(SECTION._.M_MONEY_UPDATE.Contain(model.M_MONEY_UPDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PUBLICITY_DOC_SIGN))
				{
				  condition.And(SECTION._.M_ATT_PUBLICITY_DOC_SIGN.Contain(model.M_ATT_PUBLICITY_DOC_SIGN));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_WIN_BID_NOTICE_SIGN))
				{
				  condition.And(SECTION._.M_ATT_WIN_BID_NOTICE_SIGN.Contain(model.M_ATT_WIN_BID_NOTICE_SIGN));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_FILE_EX_TDOC_SIGN))
				{
				  condition.And(SECTION._.M_ATT_FILE_EX_TDOC_SIGN.Contain(model.M_ATT_FILE_EX_TDOC_SIGN));
				}
				if(model.BID_ECTION_NUM!=null)
				{
				  condition.And(SECTION._.BID_ECTION_NUM==(model.BID_ECTION_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_TENDER_MODE))
				{
				  condition.And(SECTION._.BID_TENDER_MODE.Contain(model.BID_TENDER_MODE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(SECTION._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_PLACE_CODE))
				{
				  condition.And(SECTION._.TRA_PLACE_CODE.Contain(model.TRA_PLACE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(SECTION._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(SECTION._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(SECTION._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}