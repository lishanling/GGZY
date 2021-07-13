using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TenderAnnQuaInqueryAnnService : BaseServiceT<TENDER_ANN_QUA_INQUERY_ANN>
    {
        #region 接口实现
        
		public List<TENDER_ANN_QUA_INQUERY_ANN> FindList(TENDER_ANN_QUA_INQUERY_ANN model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<TENDER_ANN_QUA_INQUERY_ANN> PageList(TENDER_ANN_QUA_INQUERY_ANN model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, TENDER_ANN_QUA_INQUERY_ANN._.M_TM.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_ID == M_ID);
			
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
        public GeneralResult Edit(TENDER_ANN_QUA_INQUERY_ANN model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is TENDER_ANN_QUA_INQUERY_ANN entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.UNIFIED_DEAL_CODES=model.UNIFIED_DEAL_CODES;
		entity.NOTICE_NAME=model.NOTICE_NAME;
		entity.NOTICE_CONTENT=model.NOTICE_CONTENT;
		entity.NOTICE_SEND_TIME=model.NOTICE_SEND_TIME;
		entity.NOTICE_MEDIA=model.NOTICE_MEDIA;
		entity.URL=model.URL;
		entity.NOTICE_NATURE=model.NOTICE_NATURE;
		entity.BULLETIN_TYPE=model.BULLETIN_TYPE;
		entity.DOC_GET_START_TIME=model.DOC_GET_START_TIME;
		entity.DOC_GET_END_TIME=model.DOC_GET_END_TIME;
		entity.TENDER_DOC_GET_METHOD=model.TENDER_DOC_GET_METHOD;
		entity.BID_DOC_REFER_END_TIME=model.BID_DOC_REFER_END_TIME;
		entity.BID_OPEN_TIME=model.BID_OPEN_TIME;
		entity.DOC_PRICE=model.DOC_PRICE;
		entity.DOC_PRICE_CURRENCY=model.DOC_PRICE_CURRENCY;
		entity.DOC_PRICE_UNIT=model.DOC_PRICE_UNIT;
		entity.BID_DOC_REFER_METHOD=model.BID_DOC_REFER_METHOD;
		entity.SYNDICATED_FLAG=model.SYNDICATED_FLAG;
		entity.BULLETIN_DUTY=model.BULLETIN_DUTY;
		entity.BULLETIN_DUTY_CODE_TYPE=model.BULLETIN_DUTY_CODE_TYPE;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_CREATOR=model.M_CREATOR;
		entity.M_BZJ_TM=model.M_BZJ_TM;
		entity.M_ZY_TM=model.M_ZY_TM;
		entity.M_ATT_TENDER_NOTICE=model.M_ATT_TENDER_NOTICE;
		entity.M_ATT_FILE_EX_TDOC=model.M_ATT_FILE_EX_TDOC;
		entity.M_ATT_DISSENT_DOC=model.M_ATT_DISSENT_DOC;
		entity.M_STATUS=model.M_STATUS;
		entity.M_REMARK=model.M_REMARK;
		entity.M_ZPID=model.M_ZPID;
		entity.M_ATT_SHCONTENT=model.M_ATT_SHCONTENT;
		entity.M_TZZE=model.M_TZZE;
		entity.M_ZN_PHONE=model.M_ZN_PHONE;
		entity.M_ZN_PERSON_NAME=model.M_ZN_PERSON_NAME;
		entity.M_ZN_PBSJ=model.M_ZN_PBSJ;
		entity.M_IS_HISTORY=model.M_IS_HISTORY;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_MONEY_UPDATE=model.M_MONEY_UPDATE;
		entity.TENDER_SELF_CODE=model.TENDER_SELF_CODE;
		entity.TENDERER_CODE=model.TENDERER_CODE;
		entity.TENDERER_NAME=model.TENDERER_NAME;
		entity.TENDERER_ADDRESS=model.TENDERER_ADDRESS;
		entity.TENDERER_CONTACTOR=model.TENDERER_CONTACTOR;
		entity.TENDERER_PHONE_NUMBER=model.TENDERER_PHONE_NUMBER;
		entity.TENDERER_EMAIL=model.TENDERER_EMAIL;
		entity.TENDER_AGENCY_CODE=model.TENDER_AGENCY_CODE;
		entity.TENDER_AGENCY_NAME=model.TENDER_AGENCY_NAME;
		entity.TENDER_AGENCY_ADDRESS=model.TENDER_AGENCY_ADDRESS;
		entity.TENDER_AGENCY_CONTACTOR=model.TENDER_AGENCY_CONTACTOR;
		entity.TENDER_AGENCY_PHONE_NUMBER=model.TENDER_AGENCY_PHONE_NUMBER;
		entity.TENDER_AGENCY_EMAIL=model.TENDER_AGENCY_EMAIL;
		entity.OTHER_CONTENT=model.OTHER_CONTENT;
		entity.M_ATT_QUAL_NOTICE_FILE=model.M_ATT_QUAL_NOTICE_FILE;
		entity.TRAD_CENTER_NAME=model.TRAD_CENTER_NAME;
		entity.M_ATT_FILE_EX_TDOC_SIGN=model.M_ATT_FILE_EX_TDOC_SIGN;
		entity.M_ATT_QUAL_NOTICE_FILE_SIGN=model.M_ATT_QUAL_NOTICE_FILE_SIGN;
		entity.M_ATT_TENDER_NOTICE_SIGN=model.M_ATT_TENDER_NOTICE_SIGN;
		entity.NOTICE_BID_NUM=model.NOTICE_BID_NUM;
		entity.IS_POSTPONE=model.IS_POSTPONE;
		entity.BID_OPEN_METHOD=model.BID_OPEN_METHOD;
		entity.QUAL_TYPE=model.QUAL_TYPE;
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
        public GeneralResult Add(TENDER_ANN_QUA_INQUERY_ANN model)
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
                    Delete(TENDER_ANN_QUA_INQUERY_ANN._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<TENDER_ANN_QUA_INQUERY_ANN> model)
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
       	protected WhereClipBuilder ConditionBuilder(TENDER_ANN_QUA_INQUERY_ANN model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.UNIFIED_DEAL_CODES))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.UNIFIED_DEAL_CODES.Contain(model.UNIFIED_DEAL_CODES));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_NAME))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_NAME.Contain(model.NOTICE_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_CONTENT))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_CONTENT.Contain(model.NOTICE_CONTENT));
				}
				if(model.NOTICE_SEND_TIME!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME==(model.NOTICE_SEND_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_MEDIA))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_MEDIA.Contain(model.NOTICE_MEDIA));
				}
				if(!string.IsNullOrWhiteSpace(model.URL))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.URL.Contain(model.URL));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_NATURE))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_NATURE.Contain(model.NOTICE_NATURE));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETIN_TYPE))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.BULLETIN_TYPE.Contain(model.BULLETIN_TYPE));
				}
				if(model.DOC_GET_START_TIME!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.DOC_GET_START_TIME==(model.DOC_GET_START_TIME));
				}
				if(model.DOC_GET_END_TIME!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.DOC_GET_END_TIME==(model.DOC_GET_END_TIME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_DOC_GET_METHOD))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_DOC_GET_METHOD.Contain(model.TENDER_DOC_GET_METHOD));
				}
				if(model.BID_DOC_REFER_END_TIME!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.BID_DOC_REFER_END_TIME==(model.BID_DOC_REFER_END_TIME));
				}
				if(model.BID_OPEN_TIME!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.BID_OPEN_TIME==(model.BID_OPEN_TIME));
				}
				if(model.DOC_PRICE!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.DOC_PRICE==(model.DOC_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.DOC_PRICE_CURRENCY))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.DOC_PRICE_CURRENCY.Contain(model.DOC_PRICE_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.DOC_PRICE_UNIT))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.DOC_PRICE_UNIT.Contain(model.DOC_PRICE_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_DOC_REFER_METHOD))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.BID_DOC_REFER_METHOD.Contain(model.BID_DOC_REFER_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.SYNDICATED_FLAG))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.SYNDICATED_FLAG.Contain(model.SYNDICATED_FLAG));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETIN_DUTY))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.BULLETIN_DUTY.Contain(model.BULLETIN_DUTY));
				}
				if(!string.IsNullOrWhiteSpace(model.BULLETIN_DUTY_CODE_TYPE))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.BULLETIN_DUTY_CODE_TYPE.Contain(model.BULLETIN_DUTY_CODE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_ID==(model.M_ID));
				}
				if(model.M_CREATOR!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_CREATOR==(model.M_CREATOR));
				}
				if(model.M_BZJ_TM!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_BZJ_TM==(model.M_BZJ_TM));
				}
				if(model.M_ZY_TM!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_ZY_TM==(model.M_ZY_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TENDER_NOTICE))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_ATT_TENDER_NOTICE.Contain(model.M_ATT_TENDER_NOTICE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_FILE_EX_TDOC))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_ATT_FILE_EX_TDOC.Contain(model.M_ATT_FILE_EX_TDOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_DISSENT_DOC))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_ATT_DISSENT_DOC.Contain(model.M_ATT_DISSENT_DOC));
				}
				if(model.M_STATUS!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_STATUS==(model.M_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.M_REMARK))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_REMARK.Contain(model.M_REMARK));
				}
				if(model.M_ZPID!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_ZPID==(model.M_ZPID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_SHCONTENT))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_ATT_SHCONTENT.Contain(model.M_ATT_SHCONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_TZZE))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_TZZE.Contain(model.M_TZZE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ZN_PHONE))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_ZN_PHONE.Contain(model.M_ZN_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ZN_PERSON_NAME))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_ZN_PERSON_NAME.Contain(model.M_ZN_PERSON_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ZN_PBSJ))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_ZN_PBSJ.Contain(model.M_ZN_PBSJ));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_MONEY_UPDATE))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_MONEY_UPDATE.Contain(model.M_MONEY_UPDATE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_SELF_CODE))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_SELF_CODE.Contain(model.TENDER_SELF_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_CODE))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.TENDERER_CODE.Contain(model.TENDERER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_NAME))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.TENDERER_NAME.Contain(model.TENDERER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_ADDRESS))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.TENDERER_ADDRESS.Contain(model.TENDERER_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_CONTACTOR))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.TENDERER_CONTACTOR.Contain(model.TENDERER_CONTACTOR));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_PHONE_NUMBER))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.TENDERER_PHONE_NUMBER.Contain(model.TENDERER_PHONE_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_EMAIL))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.TENDERER_EMAIL.Contain(model.TENDERER_EMAIL));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_CODE))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_AGENCY_CODE.Contain(model.TENDER_AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_NAME))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_AGENCY_NAME.Contain(model.TENDER_AGENCY_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_ADDRESS))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_AGENCY_ADDRESS.Contain(model.TENDER_AGENCY_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_CONTACTOR))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_AGENCY_CONTACTOR.Contain(model.TENDER_AGENCY_CONTACTOR));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_PHONE_NUMBER))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_AGENCY_PHONE_NUMBER.Contain(model.TENDER_AGENCY_PHONE_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_AGENCY_EMAIL))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.TENDER_AGENCY_EMAIL.Contain(model.TENDER_AGENCY_EMAIL));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_CONTENT))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.OTHER_CONTENT.Contain(model.OTHER_CONTENT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_QUAL_NOTICE_FILE))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_ATT_QUAL_NOTICE_FILE.Contain(model.M_ATT_QUAL_NOTICE_FILE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRAD_CENTER_NAME))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.TRAD_CENTER_NAME.Contain(model.TRAD_CENTER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_FILE_EX_TDOC_SIGN))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_ATT_FILE_EX_TDOC_SIGN.Contain(model.M_ATT_FILE_EX_TDOC_SIGN));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_QUAL_NOTICE_FILE_SIGN))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_ATT_QUAL_NOTICE_FILE_SIGN.Contain(model.M_ATT_QUAL_NOTICE_FILE_SIGN));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TENDER_NOTICE_SIGN))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_ATT_TENDER_NOTICE_SIGN.Contain(model.M_ATT_TENDER_NOTICE_SIGN));
				}
				if(model.NOTICE_BID_NUM!=null)
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_BID_NUM==(model.NOTICE_BID_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_POSTPONE))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.IS_POSTPONE.Contain(model.IS_POSTPONE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_OPEN_METHOD))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.BID_OPEN_METHOD.Contain(model.BID_OPEN_METHOD));
				}
				if(!string.IsNullOrWhiteSpace(model.QUAL_TYPE))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.QUAL_TYPE.Contain(model.QUAL_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(TENDER_ANN_QUA_INQUERY_ANN._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}