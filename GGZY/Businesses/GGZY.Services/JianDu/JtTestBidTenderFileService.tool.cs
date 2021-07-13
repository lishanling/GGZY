using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class JtTestBidTenderFileService : BaseServiceT<JT_TEST_BID_TENDER_FILE>
    {
        #region 接口实现
        
		public List<JT_TEST_BID_TENDER_FILE> FindList(JT_TEST_BID_TENDER_FILE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<JT_TEST_BID_TENDER_FILE> PageList(JT_TEST_BID_TENDER_FILE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, JT_TEST_BID_TENDER_FILE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(JT_TEST_BID_TENDER_FILE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(JT_TEST_BID_TENDER_FILE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is JT_TEST_BID_TENDER_FILE entity)
	{		
		entity.Attach();
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.BID_SECTION_CODES=model.BID_SECTION_CODES;
		entity.LIMITE_ALL_TIME=model.LIMITE_ALL_TIME;
		entity.PERIOD_SERVICE=model.PERIOD_SERVICE;
		entity.TOTAL_SECTION_NUMBER=model.TOTAL_SECTION_NUMBER;
		entity.TENDERER_SECTION_NUMBER=model.TENDERER_SECTION_NUMBER;
		entity.DETECT_PARAMETER=model.DETECT_PARAMETER;
		entity.CHARGE_QUAL_LEVEL=model.CHARGE_QUAL_LEVEL;
		entity.CHARGE_TECH_TITLE=model.CHARGE_TECH_TITLE;
		entity.TRADING_CENTER_NAME=model.TRADING_CENTER_NAME;
		entity.MARGIN_NAME1=model.MARGIN_NAME1;
		entity.MARGIN_NUMBER1=model.MARGIN_NUMBER1;
		entity.MARGIN_BANK1=model.MARGIN_BANK1;
		entity.MARGIN_NAME2=model.MARGIN_NAME2;
		entity.MARGIN_NUMBER2=model.MARGIN_NUMBER2;
		entity.MARGIN_BANK2=model.MARGIN_BANK2;
		entity.MARGIN_NAME3=model.MARGIN_NAME3;
		entity.MARGIN_NUMBER3=model.MARGIN_NUMBER3;
		entity.MARGIN_BANK3=model.MARGIN_BANK3;
		entity.NOTICE_MEDIA4=model.NOTICE_MEDIA4;
		entity.WORK_RANGE=model.WORK_RANGE;
		entity.MINIMUM_QUALIFICATIONS=model.MINIMUM_QUALIFICATIONS;
		entity.FINANCIAL_REQUIRE=model.FINANCIAL_REQUIRE;
		entity.REPUTATION_REQUIRE=model.REPUTATION_REQUIRE;
		entity.OTHER_REQUIRE=model.OTHER_REQUIRE;
		entity.BIDDER_NOTICE_TIME=model.BIDDER_NOTICE_TIME;
		entity.FINANCIAL_REQUIRE_BEGIN=model.FINANCIAL_REQUIRE_BEGIN;
		entity.FINANCIAL_REQUIRE_END=model.FINANCIAL_REQUIRE_END;
		entity.LITIGATION_BEGIN=model.LITIGATION_BEGIN;
		entity.LITIGATION_END=model.LITIGATION_END;
		entity.ALL_EXPERT_NUM=model.ALL_EXPERT_NUM;
		entity.TENDERER_NUM=model.TENDERER_NUM;
		entity.EXPERT_NUM=model.EXPERT_NUM;
		entity.EXPERT_DETERMIN_BIDDER=model.EXPERT_DETERMIN_BIDDER;
		entity.PERFORM_TYPE=model.PERFORM_TYPE;
		entity.PERFORM_PRICE=model.PERFORM_PRICE;
		entity.SUPERVISE_DEPT_NAME1=model.SUPERVISE_DEPT_NAME1;
		entity.SUPERVISE_DEPT_ADDRESS1=model.SUPERVISE_DEPT_ADDRESS1;
		entity.SUPERVISE_DEPT_PHONE1=model.SUPERVISE_DEPT_PHONE1;
		entity.SUPERVISE_DEPT_FAX1=model.SUPERVISE_DEPT_FAX1;
		entity.SUPERVISE_DEPT_ZIP_CODE1=model.SUPERVISE_DEPT_ZIP_CODE1;
		entity.SUPERVISE_DEPT_NAME2=model.SUPERVISE_DEPT_NAME2;
		entity.SUPERVISE_DEPT_ADDRESS2=model.SUPERVISE_DEPT_ADDRESS2;
		entity.SUPERVISE_DEPT_PHONE2=model.SUPERVISE_DEPT_PHONE2;
		entity.SUPERVISE_DEPT_FAX2=model.SUPERVISE_DEPT_FAX2;
		entity.SUPERVISE_DEPT_ZIP_CODE2=model.SUPERVISE_DEPT_ZIP_CODE2;
		entity.OTHER_REQUIREMENTS=model.OTHER_REQUIREMENTS;
		entity.SERVICE_CHARGE_QUOTATION=model.SERVICE_CHARGE_QUOTATION;
		entity.DRAWING_DATA=model.DRAWING_DATA;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_ID=model.M_ID;
		entity.DATA_KEY=model.DATA_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_CREATEBY=model.M_CREATEBY;
		entity.M_CREATE_TM=model.M_CREATE_TM;
		entity.M_TM=model.M_TM;
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
        public GeneralResult Add(JT_TEST_BID_TENDER_FILE model)
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
                    Delete(JT_TEST_BID_TENDER_FILE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<JT_TEST_BID_TENDER_FILE> model)
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
       	protected WhereClipBuilder ConditionBuilder(JT_TEST_BID_TENDER_FILE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BID_SECTION_CODES))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.BID_SECTION_CODES.Contain(model.BID_SECTION_CODES));
				}
				if(model.LIMITE_ALL_TIME!=null)
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.LIMITE_ALL_TIME==(model.LIMITE_ALL_TIME));
				}
				if(model.PERIOD_SERVICE!=null)
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.PERIOD_SERVICE==(model.PERIOD_SERVICE));
				}
				if(model.TOTAL_SECTION_NUMBER!=null)
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.TOTAL_SECTION_NUMBER==(model.TOTAL_SECTION_NUMBER));
				}
				if(model.TENDERER_SECTION_NUMBER!=null)
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.TENDERER_SECTION_NUMBER==(model.TENDERER_SECTION_NUMBER));
				}
				if(!string.IsNullOrWhiteSpace(model.DETECT_PARAMETER))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.DETECT_PARAMETER.Contain(model.DETECT_PARAMETER));
				}
				if(!string.IsNullOrWhiteSpace(model.CHARGE_QUAL_LEVEL))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.CHARGE_QUAL_LEVEL.Contain(model.CHARGE_QUAL_LEVEL));
				}
				if(!string.IsNullOrWhiteSpace(model.CHARGE_TECH_TITLE))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.CHARGE_TECH_TITLE.Contain(model.CHARGE_TECH_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADING_CENTER_NAME))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.TRADING_CENTER_NAME.Contain(model.TRADING_CENTER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME1))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.MARGIN_NAME1.Contain(model.MARGIN_NAME1));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER1))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.MARGIN_NUMBER1.Contain(model.MARGIN_NUMBER1));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK1))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.MARGIN_BANK1.Contain(model.MARGIN_BANK1));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME2))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.MARGIN_NAME2.Contain(model.MARGIN_NAME2));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER2))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.MARGIN_NUMBER2.Contain(model.MARGIN_NUMBER2));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK2))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.MARGIN_BANK2.Contain(model.MARGIN_BANK2));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NAME3))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.MARGIN_NAME3.Contain(model.MARGIN_NAME3));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_NUMBER3))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.MARGIN_NUMBER3.Contain(model.MARGIN_NUMBER3));
				}
				if(!string.IsNullOrWhiteSpace(model.MARGIN_BANK3))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.MARGIN_BANK3.Contain(model.MARGIN_BANK3));
				}
				if(!string.IsNullOrWhiteSpace(model.NOTICE_MEDIA4))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.NOTICE_MEDIA4.Contain(model.NOTICE_MEDIA4));
				}
				if(!string.IsNullOrWhiteSpace(model.WORK_RANGE))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.WORK_RANGE.Contain(model.WORK_RANGE));
				}
				if(!string.IsNullOrWhiteSpace(model.MINIMUM_QUALIFICATIONS))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.MINIMUM_QUALIFICATIONS.Contain(model.MINIMUM_QUALIFICATIONS));
				}
				if(!string.IsNullOrWhiteSpace(model.FINANCIAL_REQUIRE))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.FINANCIAL_REQUIRE.Contain(model.FINANCIAL_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.REPUTATION_REQUIRE))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.REPUTATION_REQUIRE.Contain(model.REPUTATION_REQUIRE));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_REQUIRE))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.OTHER_REQUIRE.Contain(model.OTHER_REQUIRE));
				}
				if(model.BIDDER_NOTICE_TIME!=null)
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.BIDDER_NOTICE_TIME==(model.BIDDER_NOTICE_TIME));
				}
				if(model.FINANCIAL_REQUIRE_BEGIN!=null)
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.FINANCIAL_REQUIRE_BEGIN==(model.FINANCIAL_REQUIRE_BEGIN));
				}
				if(model.FINANCIAL_REQUIRE_END!=null)
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.FINANCIAL_REQUIRE_END==(model.FINANCIAL_REQUIRE_END));
				}
				if(model.LITIGATION_BEGIN!=null)
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.LITIGATION_BEGIN==(model.LITIGATION_BEGIN));
				}
				if(model.LITIGATION_END!=null)
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.LITIGATION_END==(model.LITIGATION_END));
				}
				if(model.ALL_EXPERT_NUM!=null)
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.ALL_EXPERT_NUM==(model.ALL_EXPERT_NUM));
				}
				if(model.TENDERER_NUM!=null)
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.TENDERER_NUM==(model.TENDERER_NUM));
				}
				if(model.EXPERT_NUM!=null)
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.EXPERT_NUM==(model.EXPERT_NUM));
				}
				if(!string.IsNullOrWhiteSpace(model.EXPERT_DETERMIN_BIDDER))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.EXPERT_DETERMIN_BIDDER.Contain(model.EXPERT_DETERMIN_BIDDER));
				}
				if(!string.IsNullOrWhiteSpace(model.PERFORM_TYPE))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.PERFORM_TYPE.Contain(model.PERFORM_TYPE));
				}
				if(model.PERFORM_PRICE!=null)
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.PERFORM_PRICE==(model.PERFORM_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME1))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.SUPERVISE_DEPT_NAME1.Contain(model.SUPERVISE_DEPT_NAME1));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ADDRESS1))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.SUPERVISE_DEPT_ADDRESS1.Contain(model.SUPERVISE_DEPT_ADDRESS1));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_PHONE1))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.SUPERVISE_DEPT_PHONE1.Contain(model.SUPERVISE_DEPT_PHONE1));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_FAX1))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.SUPERVISE_DEPT_FAX1.Contain(model.SUPERVISE_DEPT_FAX1));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ZIP_CODE1))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.SUPERVISE_DEPT_ZIP_CODE1.Contain(model.SUPERVISE_DEPT_ZIP_CODE1));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_NAME2))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.SUPERVISE_DEPT_NAME2.Contain(model.SUPERVISE_DEPT_NAME2));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ADDRESS2))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.SUPERVISE_DEPT_ADDRESS2.Contain(model.SUPERVISE_DEPT_ADDRESS2));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_PHONE2))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.SUPERVISE_DEPT_PHONE2.Contain(model.SUPERVISE_DEPT_PHONE2));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_FAX2))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.SUPERVISE_DEPT_FAX2.Contain(model.SUPERVISE_DEPT_FAX2));
				}
				if(!string.IsNullOrWhiteSpace(model.SUPERVISE_DEPT_ZIP_CODE2))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.SUPERVISE_DEPT_ZIP_CODE2.Contain(model.SUPERVISE_DEPT_ZIP_CODE2));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_REQUIREMENTS))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.OTHER_REQUIREMENTS.Contain(model.OTHER_REQUIREMENTS));
				}
				if(!string.IsNullOrWhiteSpace(model.SERVICE_CHARGE_QUOTATION))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.SERVICE_CHARGE_QUOTATION.Contain(model.SERVICE_CHARGE_QUOTATION));
				}
				if(!string.IsNullOrWhiteSpace(model.DRAWING_DATA))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.DRAWING_DATA.Contain(model.DRAWING_DATA));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(model.M_ID!=null)
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_KEY))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.DATA_KEY.Contain(model.DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(!string.IsNullOrWhiteSpace(model.M_CREATEBY))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.M_CREATEBY.Contain(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(model.M_TM!=null)
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.M_TM==(model.M_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.TRADE_PLAT))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.TRADE_PLAT.Contain(model.TRADE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.PUB_SERVICE_PLAT.Contain(model.PUB_SERVICE_PLAT));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(JT_TEST_BID_TENDER_FILE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}