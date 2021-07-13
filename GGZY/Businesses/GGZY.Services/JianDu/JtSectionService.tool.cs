using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JtSectionService : BaseServiceT<JT_SECTION>
    {
        #region 接口实现
        
		public List<JT_SECTION> FindList(JT_SECTION model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JT_SECTION> PageList(JT_SECTION model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JT_SECTION._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID">数据自增长ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(JT_SECTION._.M_ID == M_ID);
			
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
        public GeneralResult Edit(JT_SECTION model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is JT_SECTION entity)
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
		entity.BID_LIMITE_TIME=model.BID_LIMITE_TIME;
		entity.BID_LIMITE_TIME_UNIT=model.BID_LIMITE_TIME_UNIT;
		entity.CREATE_TIME=model.CREATE_TIME;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.CONSTRUCTION_CONTRACT=model.CONSTRUCTION_CONTRACT;
		entity.SUPERVISION_CONTENT=model.SUPERVISION_CONTENT;
		entity.BID_SECTION_GROUP=model.BID_SECTION_GROUP;
		entity.MILEAGE_STAKE=model.MILEAGE_STAKE;
		entity.REMARK=model.REMARK;
		entity.MAIN_PROJECT_CONTENTS=model.MAIN_PROJECT_CONTENTS;
		entity.CONTRACT_SCOPE_BEGIN=model.CONTRACT_SCOPE_BEGIN;
		entity.CONTRACT_SCOPE_END=model.CONTRACT_SCOPE_END;
		entity.SUB_CENTER_NUMBER=model.SUB_CENTER_NUMBER;
		entity.TOLL_GATE_NUMBER=model.TOLL_GATE_NUMBER;
		entity.COMMU_STATION_NUMBER=model.COMMU_STATION_NUMBER;
		entity.TUNNEL_NUMBER=model.TUNNEL_NUMBER;
		entity.M_ID=model.M_ID;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.DATA_KEY=model.DATA_KEY;
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
		entity.M_ATT_PUBLICITY_DOC_SIGN=model.M_ATT_PUBLICITY_DOC_SIGN;
		entity.M_ATT_WIN_BID_NOTICE_SIGN=model.M_ATT_WIN_BID_NOTICE_SIGN;
		entity.M_ATT_FILE_EX_TDOC_SIGN=model.M_ATT_FILE_EX_TDOC_SIGN;
		entity.LENGTH=model.LENGTH;
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
        public GeneralResult Add(JT_SECTION model)
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
                    Delete(JT_SECTION._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JT_SECTION> model)
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
       	protected WhereClipBuilder ConditionBuilder(JT_SECTION model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(JT_SECTION._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODE))
				{
				  condition.And(JT_SECTION._.BID_SECTION_CODE.Contain(model.BID_SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_NAME))
				{
				  condition.And(JT_SECTION._.BID_SECTION_NAME.Contain(model.BID_SECTION_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODE))
				{
				  condition.And(JT_SECTION._.UNIFIED_DEAL_CODE.Contain(model.UNIFIED_DEAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CONTENT))
				{
				  condition.And(JT_SECTION._.BID_SECTION_CONTENT.Contain(model.BID_SECTION_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CLASSIFY_CODE))
				{
				  condition.And(JT_SECTION._.TENDER_PROJECT_CLASSIFY_CODE.Contain(model.TENDER_PROJECT_CLASSIFY_CODE));
				}
				if(model.CONTRACT_RECKON_PRICE!=null)
				{
				  condition.And(JT_SECTION._.CONTRACT_RECKON_PRICE==(model.CONTRACT_RECKON_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.CURRENCY_CODE))
				{
				  condition.And(JT_SECTION._.CURRENCY_CODE.Contain(model.CURRENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PRICE_UNIT))
				{
				  condition.And(JT_SECTION._.PRICE_UNIT.Contain(model.PRICE_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_QUALIFICATION))
				{
				  condition.And(JT_SECTION._.BID_QUALIFICATION.Contain(model.BID_QUALIFICATION));
				}
				if(model.BEGIN_DATE!=null)
				{
				  condition.And(JT_SECTION._.BEGIN_DATE==(model.BEGIN_DATE));
				}
				if(model.LIMITE_TIME!=null)
				{
				  condition.And(JT_SECTION._.LIMITE_TIME==(model.LIMITE_TIME));
				}
				if(model.BID_LIMITE_TIME!=null)
				{
				  condition.And(JT_SECTION._.BID_LIMITE_TIME==(model.BID_LIMITE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_LIMITE_TIME_UNIT))
				{
				  condition.And(JT_SECTION._.BID_LIMITE_TIME_UNIT.Contain(model.BID_LIMITE_TIME_UNIT));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(JT_SECTION._.CREATE_TIME==(model.CREATE_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(JT_SECTION._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(JT_SECTION._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CONSTRUCTION_CONTRACT))
				{
				  condition.And(JT_SECTION._.CONSTRUCTION_CONTRACT.Contain(model.CONSTRUCTION_CONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISION_CONTENT))
				{
				  condition.And(JT_SECTION._.SUPERVISION_CONTENT.Contain(model.SUPERVISION_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_GROUP))
				{
				  condition.And(JT_SECTION._.BID_SECTION_GROUP.Contain(model.BID_SECTION_GROUP));
				}
				if(!string.IsNullOrWhiteSpace(model.MILEAGE_STAKE))
				{
				  condition.And(JT_SECTION._.MILEAGE_STAKE.Contain(model.MILEAGE_STAKE));
				}
				if(!string.IsNullOrWhiteSpace(model.REMARK))
				{
				  condition.And(JT_SECTION._.REMARK.Contain(model.REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.MAIN_PROJECT_CONTENTS))
				{
				  condition.And(JT_SECTION._.MAIN_PROJECT_CONTENTS.Contain(model.MAIN_PROJECT_CONTENTS));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_SCOPE_BEGIN))
				{
				  condition.And(JT_SECTION._.CONTRACT_SCOPE_BEGIN.Contain(model.CONTRACT_SCOPE_BEGIN));
				}
				if(!string.IsNullOrWhiteSpace(model.CONTRACT_SCOPE_END))
				{
				  condition.And(JT_SECTION._.CONTRACT_SCOPE_END.Contain(model.CONTRACT_SCOPE_END));
				}
				if(model.SUB_CENTER_NUMBER!=null)
				{
				  condition.And(JT_SECTION._.SUB_CENTER_NUMBER==(model.SUB_CENTER_NUMBER));
				}
				if(model.TOLL_GATE_NUMBER!=null)
				{
				  condition.And(JT_SECTION._.TOLL_GATE_NUMBER==(model.TOLL_GATE_NUMBER));
				}
				if(model.COMMU_STATION_NUMBER!=null)
				{
				  condition.And(JT_SECTION._.COMMU_STATION_NUMBER==(model.COMMU_STATION_NUMBER));
				}
				if(model.TUNNEL_NUMBER!=null)
				{
				  condition.And(JT_SECTION._.TUNNEL_NUMBER==(model.TUNNEL_NUMBER));
				}
				if(model.M_ID!=null)
				{
				  condition.And(JT_SECTION._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(JT_SECTION._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(JT_SECTION._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(JT_SECTION._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(JT_SECTION._.M_TM==(model.M_TM));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JT_SECTION._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(JT_SECTION._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TENDER_FILE))
				{
				  condition.And(JT_SECTION._.M_ATT_TENDER_FILE.Contain(model.M_ATT_TENDER_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TENDER_FILE_ATTACHS))
				{
				  condition.And(JT_SECTION._.M_ATT_TENDER_FILE_ATTACHS.Contain(model.M_ATT_TENDER_FILE_ATTACHS));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TENDER_NOTICE))
				{
				  condition.And(JT_SECTION._.M_ATT_TENDER_NOTICE.Contain(model.M_ATT_TENDER_NOTICE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TENDER_AGENT_CONTRACT))
				{
				  condition.And(JT_SECTION._.M_ATT_TENDER_AGENT_CONTRACT.Contain(model.M_ATT_TENDER_AGENT_CONTRACT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_FILE_EX_TDOC))
				{
				  condition.And(JT_SECTION._.M_ATT_FILE_EX_TDOC.Contain(model.M_ATT_FILE_EX_TDOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_INVITE_DOC))
				{
				  condition.And(JT_SECTION._.M_ATT_INVITE_DOC.Contain(model.M_ATT_INVITE_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PUBLICITY_DOC))
				{
				  condition.And(JT_SECTION._.M_ATT_PUBLICITY_DOC.Contain(model.M_ATT_PUBLICITY_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_WIN_BID_NOTICE))
				{
				  condition.And(JT_SECTION._.M_ATT_WIN_BID_NOTICE.Contain(model.M_ATT_WIN_BID_NOTICE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_DISSENT_DOC))
				{
				  condition.And(JT_SECTION._.M_ATT_DISSENT_DOC.Contain(model.M_ATT_DISSENT_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_CONTRACT_DOC))
				{
				  condition.And(JT_SECTION._.M_ATT_CONTRACT_DOC.Contain(model.M_ATT_CONTRACT_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_QUALIFICATION_DOC))
				{
				  condition.And(JT_SECTION._.M_ATT_QUALIFICATION_DOC.Contain(model.M_ATT_QUALIFICATION_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_PUBLICITY_DOC_SIGN))
				{
				  condition.And(JT_SECTION._.M_ATT_PUBLICITY_DOC_SIGN.Contain(model.M_ATT_PUBLICITY_DOC_SIGN));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_WIN_BID_NOTICE_SIGN))
				{
				  condition.And(JT_SECTION._.M_ATT_WIN_BID_NOTICE_SIGN.Contain(model.M_ATT_WIN_BID_NOTICE_SIGN));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_FILE_EX_TDOC_SIGN))
				{
				  condition.And(JT_SECTION._.M_ATT_FILE_EX_TDOC_SIGN.Contain(model.M_ATT_FILE_EX_TDOC_SIGN));
				}
				if(!string.IsNullOrWhiteSpace(model.LENGTH))
				{
				  condition.And(JT_SECTION._.LENGTH.Contain(model.LENGTH));
				}
				if(model.BID_ECTION_NUM!=null)
				{
				  condition.And(JT_SECTION._.BID_ECTION_NUM==(model.BID_ECTION_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_TENDER_MODE))
				{
				  condition.And(JT_SECTION._.BID_TENDER_MODE.Contain(model.BID_TENDER_MODE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(JT_SECTION._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRA_PLACE_CODE))
				{
				  condition.And(JT_SECTION._.TRA_PLACE_CODE.Contain(model.TRA_PLACE_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(JT_SECTION._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(JT_SECTION._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(JT_SECTION._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}