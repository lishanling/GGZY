using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class BhSendClaimFormService : BaseServiceT<BH_SEND_CLAIM_FORM>
    {
        #region 接口实现
        
		public List<BH_SEND_CLAIM_FORM> FindList(BH_SEND_CLAIM_FORM model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<BH_SEND_CLAIM_FORM> PageList(BH_SEND_CLAIM_FORM model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, BH_SEND_CLAIM_FORM._.M_ID.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="M_ID">自增长ID</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(decimal? M_ID)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(BH_SEND_CLAIM_FORM._.M_ID == M_ID);
			
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
        public GeneralResult Edit(BH_SEND_CLAIM_FORM model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.M_ID);
	
	if(viewResult.Success  && viewResult.Data is BH_SEND_CLAIM_FORM entity)
	{		
		entity.Attach();
		entity.M_ID=model.M_ID;
		entity.M_DATA_KEY=model.M_DATA_KEY;
		entity.ORDER_ID=model.ORDER_ID;
		entity.APPROVAL_CODE=model.APPROVAL_CODE;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.TENDER_PROJECT_NAME=model.TENDER_PROJECT_NAME;
		entity.SECTION_CODE=model.SECTION_CODE;
		entity.SECTION_NAME=model.SECTION_NAME;
		entity.CONTRACT_RECKON_PRICE=model.CONTRACT_RECKON_PRICE;
		entity.TENDERER=model.TENDERER;
		entity.TENDERER_CREDIT_CODE=model.TENDERER_CREDIT_CODE;
		entity.TENDERER_BANK_CODE=model.TENDERER_BANK_CODE;
		entity.TENDERER_BANK_OPENBANK=model.TENDERER_BANK_OPENBANK;
		entity.CITY_CODE=model.CITY_CODE;
		entity.TENDER_PROJECT_TYPE=model.TENDER_PROJECT_TYPE;
		entity.BID_OPEN_TIME=model.BID_OPEN_TIME;
		entity.SERVICE_BEGIN_TIME=model.SERVICE_BEGIN_TIME;
		entity.SERVICE_END_TIME=model.SERVICE_END_TIME;
		entity.BID_BOND=model.BID_BOND;
		entity.AMOUNT=model.AMOUNT;
		entity.RATE=model.RATE;
		entity.GUARANTOR_NAME=model.GUARANTOR_NAME;
		entity.GUARANTOR_CREDIT_CODE=model.GUARANTOR_CREDIT_CODE;
		entity.GUARANTOR_CONTACT_NAME=model.GUARANTOR_CONTACT_NAME;
		entity.GUARANTOR_CONTACT_TEL=model.GUARANTOR_CONTACT_TEL;
		entity.BIDDER_NAME=model.BIDDER_NAME;
		entity.BIDDER_CREDIT_CODE=model.BIDDER_CREDIT_CODE;
		entity.BIDDER_CONTACT_NAME=model.BIDDER_CONTACT_NAME;
		entity.BIDDER_CONTACT_TEL=model.BIDDER_CONTACT_TEL;
		entity.BIDDER_ADDRESS=model.BIDDER_ADDRESS;
		entity.BIDDER_TAXPAYER_CODE=model.BIDDER_TAXPAYER_CODE;
		entity.LEGAL_PERSON_NAME=model.LEGAL_PERSON_NAME;
		entity.LEGAL_PERSON_TEL=model.LEGAL_PERSON_TEL;
		entity.CLAIM_NAME=model.CLAIM_NAME;
		entity.CLAIM_CREDIT_CODE=model.CLAIM_CREDIT_CODE;
		entity.CLAIM_TEL=model.CLAIM_TEL;
		entity.CLAIM_EMAIL=model.CLAIM_EMAIL;
		entity.CLAIM_AMOUNT=model.CLAIM_AMOUNT;
		entity.CLAIM_REASON=model.CLAIM_REASON;
		entity.GUARANTEE_NO=model.GUARANTEE_NO;
		entity.BIDDER_EAMIL=model.BIDDER_EAMIL;
		entity.LEGAL_PERSON_IDCARD=model.LEGAL_PERSON_IDCARD;
		entity.CLIAM_ATTACHMENT_URL=model.CLIAM_ATTACHMENT_URL;
		entity.CLIAM_ATTACHMENT_MD5=model.CLIAM_ATTACHMENT_MD5;
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
        public GeneralResult Add(BH_SEND_CLAIM_FORM model)
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
                    Delete(BH_SEND_CLAIM_FORM._.M_ID.SelectIn(idArr));
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
        public GeneralResult Import(List<BH_SEND_CLAIM_FORM> model)
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
       	protected WhereClipBuilder ConditionBuilder(BH_SEND_CLAIM_FORM model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
#pragma warning disable CS0472 // 由于“int”类型的值永不等于“int?”类型的 "null"，该表达式的结果始终为“true”
				if(model.M_ID!=null)
#pragma warning restore CS0472 // 由于“int”类型的值永不等于“int?”类型的 "null"，该表达式的结果始终为“true”
				{
				  condition.And(BH_SEND_CLAIM_FORM._.M_ID==(model.M_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.M_DATA_KEY))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.M_DATA_KEY.Contain(model.M_DATA_KEY));
				}
				if(!string.IsNullOrWhiteSpace(model.ORDER_ID))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.ORDER_ID.Contain(model.ORDER_ID));
				}
				if(!string.IsNullOrWhiteSpace(model.APPROVAL_CODE))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.APPROVAL_CODE.Contain(model.APPROVAL_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.SECTION_CODE))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.SECTION_CODE.Contain(model.SECTION_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.SECTION_NAME))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.SECTION_NAME.Contain(model.SECTION_NAME));
				}
#pragma warning disable CS0472 // 由于“decimal”类型的值永不等于“decimal?”类型的 "null"，该表达式的结果始终为“true”
				if(model.CONTRACT_RECKON_PRICE!=null)
#pragma warning restore CS0472 // 由于“decimal”类型的值永不等于“decimal?”类型的 "null"，该表达式的结果始终为“true”
				{
				  condition.And(BH_SEND_CLAIM_FORM._.CONTRACT_RECKON_PRICE==(model.CONTRACT_RECKON_PRICE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.TENDERER.Contain(model.TENDERER));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_CREDIT_CODE))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.TENDERER_CREDIT_CODE.Contain(model.TENDERER_CREDIT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_BANK_CODE))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.TENDERER_BANK_CODE.Contain(model.TENDERER_BANK_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERER_BANK_OPENBANK))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.TENDERER_BANK_OPENBANK.Contain(model.TENDERER_BANK_OPENBANK));
				}
				if(!string.IsNullOrWhiteSpace(model.CITY_CODE))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.CITY_CODE.Contain(model.CITY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_TYPE))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.TENDER_PROJECT_TYPE.Contain(model.TENDER_PROJECT_TYPE));
				}
				if(model.BID_OPEN_TIME!=null)
				{
				  condition.And(BH_SEND_CLAIM_FORM._.BID_OPEN_TIME==(model.BID_OPEN_TIME));
				}
				if(model.SERVICE_BEGIN_TIME!=null)
				{
				  condition.And(BH_SEND_CLAIM_FORM._.SERVICE_BEGIN_TIME==(model.SERVICE_BEGIN_TIME));
				}
				if(model.SERVICE_END_TIME!=null)
				{
				  condition.And(BH_SEND_CLAIM_FORM._.SERVICE_END_TIME==(model.SERVICE_END_TIME));
				}
#pragma warning disable CS0472 // 由于“decimal”类型的值永不等于“decimal?”类型的 "null"，该表达式的结果始终为“true”
				if(model.BID_BOND!=null)
#pragma warning restore CS0472 // 由于“decimal”类型的值永不等于“decimal?”类型的 "null"，该表达式的结果始终为“true”
				{
				  condition.And(BH_SEND_CLAIM_FORM._.BID_BOND==(model.BID_BOND));
				}
#pragma warning disable CS0472 // 由于“decimal”类型的值永不等于“decimal?”类型的 "null"，该表达式的结果始终为“true”
				if(model.AMOUNT!=null)
#pragma warning restore CS0472 // 由于“decimal”类型的值永不等于“decimal?”类型的 "null"，该表达式的结果始终为“true”
				{
				  condition.And(BH_SEND_CLAIM_FORM._.AMOUNT==(model.AMOUNT));
				}
#pragma warning disable CS0472 // 由于“decimal”类型的值永不等于“decimal?”类型的 "null"，该表达式的结果始终为“true”
				if(model.RATE!=null)
#pragma warning restore CS0472 // 由于“decimal”类型的值永不等于“decimal?”类型的 "null"，该表达式的结果始终为“true”
				{
				  condition.And(BH_SEND_CLAIM_FORM._.RATE==(model.RATE));
				}
				if(!string.IsNullOrWhiteSpace(model.GUARANTOR_NAME))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.GUARANTOR_NAME.Contain(model.GUARANTOR_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.GUARANTOR_CREDIT_CODE))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.GUARANTOR_CREDIT_CODE.Contain(model.GUARANTOR_CREDIT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.GUARANTOR_CONTACT_NAME))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.GUARANTOR_CONTACT_NAME.Contain(model.GUARANTOR_CONTACT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.GUARANTOR_CONTACT_TEL))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.GUARANTOR_CONTACT_TEL.Contain(model.GUARANTOR_CONTACT_TEL));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_NAME))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.BIDDER_NAME.Contain(model.BIDDER_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_CREDIT_CODE))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.BIDDER_CREDIT_CODE.Contain(model.BIDDER_CREDIT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_CONTACT_NAME))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.BIDDER_CONTACT_NAME.Contain(model.BIDDER_CONTACT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_CONTACT_TEL))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.BIDDER_CONTACT_TEL.Contain(model.BIDDER_CONTACT_TEL));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_ADDRESS))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.BIDDER_ADDRESS.Contain(model.BIDDER_ADDRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_TAXPAYER_CODE))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.BIDDER_TAXPAYER_CODE.Contain(model.BIDDER_TAXPAYER_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_PERSON_NAME))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.LEGAL_PERSON_NAME.Contain(model.LEGAL_PERSON_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_PERSON_TEL))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.LEGAL_PERSON_TEL.Contain(model.LEGAL_PERSON_TEL));
				}
				if(!string.IsNullOrWhiteSpace(model.CLAIM_NAME))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.CLAIM_NAME.Contain(model.CLAIM_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.CLAIM_CREDIT_CODE))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.CLAIM_CREDIT_CODE.Contain(model.CLAIM_CREDIT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.CLAIM_TEL))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.CLAIM_TEL.Contain(model.CLAIM_TEL));
				}
				if(!string.IsNullOrWhiteSpace(model.CLAIM_EMAIL))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.CLAIM_EMAIL.Contain(model.CLAIM_EMAIL));
				}
#pragma warning disable CS0472 // 由于“decimal”类型的值永不等于“decimal?”类型的 "null"，该表达式的结果始终为“true”
				if(model.CLAIM_AMOUNT!=null)
#pragma warning restore CS0472 // 由于“decimal”类型的值永不等于“decimal?”类型的 "null"，该表达式的结果始终为“true”
				{
				  condition.And(BH_SEND_CLAIM_FORM._.CLAIM_AMOUNT==(model.CLAIM_AMOUNT));
				}
				if(!string.IsNullOrWhiteSpace(model.CLAIM_REASON))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.CLAIM_REASON.Contain(model.CLAIM_REASON));
				}
				if(!string.IsNullOrWhiteSpace(model.GUARANTEE_NO))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.GUARANTEE_NO.Contain(model.GUARANTEE_NO));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDER_EAMIL))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.BIDDER_EAMIL.Contain(model.BIDDER_EAMIL));
				}
				if(!string.IsNullOrWhiteSpace(model.LEGAL_PERSON_IDCARD))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.LEGAL_PERSON_IDCARD.Contain(model.LEGAL_PERSON_IDCARD));
				}
				if(!string.IsNullOrWhiteSpace(model.CLIAM_ATTACHMENT_URL))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.CLIAM_ATTACHMENT_URL.Contain(model.CLIAM_ATTACHMENT_URL));
				}
				if(!string.IsNullOrWhiteSpace(model.CLIAM_ATTACHMENT_MD5))
				{
				  condition.And(BH_SEND_CLAIM_FORM._.CLIAM_ATTACHMENT_MD5.Contain(model.CLIAM_ATTACHMENT_MD5));
				}
		return condition;
	}
        #endregion
    }
}