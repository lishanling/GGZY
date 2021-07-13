using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class LegalPersonBaseService : BaseServiceT<LEGAL_PERSON_BASE>
    {
        #region 接口实现
        
		public List<LEGAL_PERSON_BASE> FindList(LEGAL_PERSON_BASE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<LEGAL_PERSON_BASE> PageList(LEGAL_PERSON_BASE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, LEGAL_PERSON_BASE._.M_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(LEGAL_PERSON_BASE._.M_ID == M_ID);
			
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
        public GeneralResult Edit(LEGAL_PERSON_BASE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is LEGAL_PERSON_BASE entity)
	{		
		entity.Attach();
		entity.LEGAL_NAME=model.LEGAL_NAME;
		entity.BIDDER_CODE_TYPE=model.BIDDER_CODE_TYPE;
		entity.LEGAL_CODE=model.LEGAL_CODE;
		entity.LEGAL_ROLE=model.LEGAL_ROLE;
		entity.LICENSE_NO=model.LICENSE_NO;
		entity.LICENSE_END_DATE=model.LICENSE_END_DATE;
		entity.TAX_CERT_NO=model.TAX_CERT_NO;
		entity.TAX_CERT_END_DATE=model.TAX_CERT_END_DATE;
		entity.LOCAL_TAX_CERT_NO=model.LOCAL_TAX_CERT_NO;
		entity.LOCAL_TAX_CERT_END_DATE=model.LOCAL_TAX_CERT_END_DATE;
		entity.ORGAN_NO=model.ORGAN_NO;
		entity.ORGAN_CERT_END_DATE=model.ORGAN_CERT_END_DATE;
		entity.LEGAL_REPRESENT=model.LEGAL_REPRESENT;
		entity.LEGAL_TYPE=model.LEGAL_TYPE;
		entity.REPRESENT_PHONE=model.REPRESENT_PHONE;
		entity.LEGAL_INDUSTRY=model.LEGAL_INDUSTRY;
		entity.CREDIT_RATE=model.CREDIT_RATE;
		entity.COUNTRY_REGION=model.COUNTRY_REGION;
		entity.LEGAL_UNIT_ADDRESS=model.LEGAL_UNIT_ADDRESS;
		entity.REGION_CODE=model.REGION_CODE;
		entity.REGISTER_PROVINCE=model.REGISTER_PROVINCE;
		entity.REGISTER_CITY=model.REGISTER_CITY;
		entity.BASIC_BANK=model.BASIC_BANK;
		entity.BASIC_BRANCH_BANK=model.BASIC_BRANCH_BANK;
		entity.BASIC_ACCOUNT_NO=model.BASIC_ACCOUNT_NO;
		entity.BASIC_ACCOUNT_NAME=model.BASIC_ACCOUNT_NAME;
		entity.REG_CAPITAL=model.REG_CAPITAL;
		entity.REG_CAP_CURRENCY=model.REG_CAP_CURRENCY;
		entity.REG_UNIT=model.REG_UNIT;
		entity.LEGAL_CONTACT=model.LEGAL_CONTACT;
		entity.LEGAL_CONTACT_PHONE=model.LEGAL_CONTACT_PHONE;
		entity.LEGAL_CONTACT_ADDRESS=model.LEGAL_CONTACT_ADDRESS;
		entity.LEGAL_WEB=model.LEGAL_WEB;
		entity.LEGAL_ZIP_CODE=model.LEGAL_ZIP_CODE;
		entity.LEGAL_EMAIL=model.LEGAL_EMAIL;
		entity.LEGAL_STATUS=model.LEGAL_STATUS;
		entity.PLATFORM_CODE=model.PLATFORM_CODE;
		entity.PUB_SERVICE_PLAT_CODE=model.PUB_SERVICE_PLAT_CODE;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.M_KEY=model.M_KEY;
		entity.M_DATA_SOURCE=model.M_DATA_SOURCE;
		entity.M_TM=model.M_TM;
		entity.M_ID=model.M_ID;
		entity.M_USER_ID=model.M_USER_ID;
		entity.M_ATT_LICENSE_CERT_DOC=model.M_ATT_LICENSE_CERT_DOC;
		entity.M_ATT_ORGAN_CERT_DOC=model.M_ATT_ORGAN_CERT_DOC;
		entity.M_ATT_TAX_CERT_DOC=model.M_ATT_TAX_CERT_DOC;
		entity.M_ATT_BASE_ACCOUNT_DOC=model.M_ATT_BASE_ACCOUNT_DOC;
		entity.M_ATT_QUAL_CART_DOC=model.M_ATT_QUAL_CART_DOC;
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
        public GeneralResult Add(LEGAL_PERSON_BASE model)
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
                    Delete(LEGAL_PERSON_BASE._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<LEGAL_PERSON_BASE> model)
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
       	protected WhereClipBuilder ConditionBuilder(LEGAL_PERSON_BASE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.LEGAL_NAME))
				{
				  condition.And(LEGAL_PERSON_BASE._.LEGAL_NAME.Contain(model.LEGAL_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_CODE_TYPE))
				{
				  condition.And(LEGAL_PERSON_BASE._.BIDDER_CODE_TYPE.Contain(model.BIDDER_CODE_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_CODE))
				{
				  condition.And(LEGAL_PERSON_BASE._.LEGAL_CODE.Contain(model.LEGAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_ROLE))
				{
				  condition.And(LEGAL_PERSON_BASE._.LEGAL_ROLE.Contain(model.LEGAL_ROLE));
				}
				if(!string.IsNullOrWhiteSpace(model.LICENSE_NO))
				{
				  condition.And(LEGAL_PERSON_BASE._.LICENSE_NO.Contain(model.LICENSE_NO));
				}
				if(model.LICENSE_END_DATE!=null)
				{
				  condition.And(LEGAL_PERSON_BASE._.LICENSE_END_DATE==(model.LICENSE_END_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.TAX_CERT_NO))
				{
				  condition.And(LEGAL_PERSON_BASE._.TAX_CERT_NO.Contain(model.TAX_CERT_NO));
				}
				if(model.TAX_CERT_END_DATE!=null)
				{
				  condition.And(LEGAL_PERSON_BASE._.TAX_CERT_END_DATE==(model.TAX_CERT_END_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.LOCAL_TAX_CERT_NO))
				{
				  condition.And(LEGAL_PERSON_BASE._.LOCAL_TAX_CERT_NO.Contain(model.LOCAL_TAX_CERT_NO));
				}
				if(model.LOCAL_TAX_CERT_END_DATE!=null)
				{
				  condition.And(LEGAL_PERSON_BASE._.LOCAL_TAX_CERT_END_DATE==(model.LOCAL_TAX_CERT_END_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.ORGAN_NO))
				{
				  condition.And(LEGAL_PERSON_BASE._.ORGAN_NO.Contain(model.ORGAN_NO));
				}
				if(model.ORGAN_CERT_END_DATE!=null)
				{
				  condition.And(LEGAL_PERSON_BASE._.ORGAN_CERT_END_DATE==(model.ORGAN_CERT_END_DATE));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_REPRESENT))
				{
				  condition.And(LEGAL_PERSON_BASE._.LEGAL_REPRESENT.Contain(model.LEGAL_REPRESENT));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_TYPE))
				{
				  condition.And(LEGAL_PERSON_BASE._.LEGAL_TYPE.Contain(model.LEGAL_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.REPRESENT_PHONE))
				{
				  condition.And(LEGAL_PERSON_BASE._.REPRESENT_PHONE.Contain(model.REPRESENT_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_INDUSTRY))
				{
				  condition.And(LEGAL_PERSON_BASE._.LEGAL_INDUSTRY.Contain(model.LEGAL_INDUSTRY));
				}
				if(!string.IsNullOrWhiteSpace(model.CREDIT_RATE))
				{
				  condition.And(LEGAL_PERSON_BASE._.CREDIT_RATE.Contain(model.CREDIT_RATE));
				}
				if(!string.IsNullOrWhiteSpace(model.COUNTRY_REGION))
				{
				  condition.And(LEGAL_PERSON_BASE._.COUNTRY_REGION.Contain(model.COUNTRY_REGION));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_UNIT_ADDRESS))
				{
				  condition.And(LEGAL_PERSON_BASE._.LEGAL_UNIT_ADDRESS.Contain(model.LEGAL_UNIT_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.REGION_CODE))
				{
				  condition.And(LEGAL_PERSON_BASE._.REGION_CODE.Contain(model.REGION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGISTER_PROVINCE))
				{
				  condition.And(LEGAL_PERSON_BASE._.REGISTER_PROVINCE.Contain(model.REGISTER_PROVINCE));
				}
				if(!string.IsNullOrWhiteSpace(model.REGISTER_CITY))
				{
				  condition.And(LEGAL_PERSON_BASE._.REGISTER_CITY.Contain(model.REGISTER_CITY));
				}
				if(!string.IsNullOrWhiteSpace(model.BASIC_BANK))
				{
				  condition.And(LEGAL_PERSON_BASE._.BASIC_BANK.Contain(model.BASIC_BANK));
				}
				if(!string.IsNullOrWhiteSpace(model.BASIC_BRANCH_BANK))
				{
				  condition.And(LEGAL_PERSON_BASE._.BASIC_BRANCH_BANK.Contain(model.BASIC_BRANCH_BANK));
				}
				if(!string.IsNullOrWhiteSpace(model.BASIC_ACCOUNT_NO))
				{
				  condition.And(LEGAL_PERSON_BASE._.BASIC_ACCOUNT_NO.Contain(model.BASIC_ACCOUNT_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.BASIC_ACCOUNT_NAME))
				{
				  condition.And(LEGAL_PERSON_BASE._.BASIC_ACCOUNT_NAME.Contain(model.BASIC_ACCOUNT_NAME));
				}
				if(model.REG_CAPITAL!=null)
				{
				  condition.And(LEGAL_PERSON_BASE._.REG_CAPITAL==(model.REG_CAPITAL));
				}
				if(!string.IsNullOrWhiteSpace(model.REG_CAP_CURRENCY))
				{
				  condition.And(LEGAL_PERSON_BASE._.REG_CAP_CURRENCY.Contain(model.REG_CAP_CURRENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.REG_UNIT))
				{
				  condition.And(LEGAL_PERSON_BASE._.REG_UNIT.Contain(model.REG_UNIT));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_CONTACT))
				{
				  condition.And(LEGAL_PERSON_BASE._.LEGAL_CONTACT.Contain(model.LEGAL_CONTACT));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_CONTACT_PHONE))
				{
				  condition.And(LEGAL_PERSON_BASE._.LEGAL_CONTACT_PHONE.Contain(model.LEGAL_CONTACT_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_CONTACT_ADDRESS))
				{
				  condition.And(LEGAL_PERSON_BASE._.LEGAL_CONTACT_ADDRESS.Contain(model.LEGAL_CONTACT_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_WEB))
				{
				  condition.And(LEGAL_PERSON_BASE._.LEGAL_WEB.Contain(model.LEGAL_WEB));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_ZIP_CODE))
				{
				  condition.And(LEGAL_PERSON_BASE._.LEGAL_ZIP_CODE.Contain(model.LEGAL_ZIP_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_EMAIL))
				{
				  condition.And(LEGAL_PERSON_BASE._.LEGAL_EMAIL.Contain(model.LEGAL_EMAIL));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_STATUS))
				{
				  condition.And(LEGAL_PERSON_BASE._.LEGAL_STATUS.Contain(model.LEGAL_STATUS));
				}
				if(!string.IsNullOrWhiteSpace(model.PLATFORM_CODE))
				{
				  condition.And(LEGAL_PERSON_BASE._.PLATFORM_CODE.Contain(model.PLATFORM_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.PUB_SERVICE_PLAT_CODE))
				{
				  condition.And(LEGAL_PERSON_BASE._.PUB_SERVICE_PLAT_CODE.Contain(model.PUB_SERVICE_PLAT_CODE));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(LEGAL_PERSON_BASE._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.M_KEY))
				{
				  condition.And(LEGAL_PERSON_BASE._.M_KEY.Contain(model.M_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_SOURCE))
				{
				  condition.And(LEGAL_PERSON_BASE._.M_DATA_SOURCE.Contain(model.M_DATA_SOURCE));
				}
				if(model.M_TM!=null)
				{
				  condition.And(LEGAL_PERSON_BASE._.M_TM==(model.M_TM));
				}
				if(model.M_ID!=null)
				{
				  condition.And(LEGAL_PERSON_BASE._.M_ID==(model.M_ID));
				}
				if(model.M_USER_ID!=null)
				{
				  condition.And(LEGAL_PERSON_BASE._.M_USER_ID==(model.M_USER_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_LICENSE_CERT_DOC))
				{
				  condition.And(LEGAL_PERSON_BASE._.M_ATT_LICENSE_CERT_DOC.Contain(model.M_ATT_LICENSE_CERT_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_ORGAN_CERT_DOC))
				{
				  condition.And(LEGAL_PERSON_BASE._.M_ATT_ORGAN_CERT_DOC.Contain(model.M_ATT_ORGAN_CERT_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_TAX_CERT_DOC))
				{
				  condition.And(LEGAL_PERSON_BASE._.M_ATT_TAX_CERT_DOC.Contain(model.M_ATT_TAX_CERT_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_BASE_ACCOUNT_DOC))
				{
				  condition.And(LEGAL_PERSON_BASE._.M_ATT_BASE_ACCOUNT_DOC.Contain(model.M_ATT_BASE_ACCOUNT_DOC));
				}
				if(!string.IsNullOrWhiteSpace(model.M_ATT_QUAL_CART_DOC))
				{
				  condition.And(LEGAL_PERSON_BASE._.M_ATT_QUAL_CART_DOC.Contain(model.M_ATT_QUAL_CART_DOC));
				}
				if(model.M_IS_HISTORY!=null)
				{
				  condition.And(LEGAL_PERSON_BASE._.M_IS_HISTORY==(model.M_IS_HISTORY));
				}
				if(model.M_CREATEBY!=null)
				{
				  condition.And(LEGAL_PERSON_BASE._.M_CREATEBY==(model.M_CREATEBY));
				}
				if(model.M_CREATE_TM!=null)
				{
				  condition.And(LEGAL_PERSON_BASE._.M_CREATE_TM==(model.M_CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.M_VERSION))
				{
				  condition.And(LEGAL_PERSON_BASE._.M_VERSION.Contain(model.M_VERSION));
				}
		return condition;
	}
        #endregion
    }
}