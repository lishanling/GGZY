using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class PtZxtsService : BaseServiceT<PT_ZXTS>
    {
        #region 接口实现
        
		public List<PT_ZXTS> FindList(PT_ZXTS model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<PT_ZXTS> PageList(PT_ZXTS model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, PT_ZXTS._.CREATE_TM.Desc).ToBootstrapTableList(count);

            
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
			condition.And(PT_ZXTS._.ID == ID);
			
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
        public GeneralResult Edit(PT_ZXTS model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.ID);
	
	if(viewResult.Success  && viewResult.Data is PT_ZXTS entity)
	{		
		entity.Attach();
		entity.ID=model.ID;
		entity.CODE=model.CODE;
		entity.TYPE=model.TYPE;
		entity.STATE=model.STATE;
		entity.COMPLAINT_TYPE=model.COMPLAINT_TYPE;
		entity.COMPLAINT_NAME=model.COMPLAINT_NAME;
		entity.COMPLAINT_CODE=model.COMPLAINT_CODE;
		entity.COMPLAINT_DNAME=model.COMPLAINT_DNAME;
		entity.COMPLAINT_ADRESS=model.COMPLAINT_ADRESS;
		entity.COMPLAINT_ZW=model.COMPLAINT_ZW;
		entity.COMPLAINT_FAX=model.COMPLAINT_FAX;
		entity.COMPLAINT_PC=model.COMPLAINT_PC;
		entity.COMPLAINT_CONTACT=model.COMPLAINT_CONTACT;
		entity.COMPLAINT_PHONE=model.COMPLAINT_PHONE;
		entity.COMPLAINT_EMAIL=model.COMPLAINT_EMAIL;
		entity.COMPLAINT_CONTACT_IDCARD=model.COMPLAINT_CONTACT_IDCARD;
		entity.COMPLAINT_CONTACT_PHONE=model.COMPLAINT_CONTACT_PHONE;
		entity.COMPLAINT_CONTACT_EMAIL=model.COMPLAINT_CONTACT_EMAIL;
		entity.COMPLAINT_LEGAL=model.COMPLAINT_LEGAL;
		entity.COMPLAINT_LEGAL_IDCARD=model.COMPLAINT_LEGAL_IDCARD;
		entity.COMPLAINT_LEGAL_PHONE=model.COMPLAINT_LEGAL_PHONE;
		entity.COMPLAINT_LEGAL_ISWT=model.COMPLAINT_LEGAL_ISWT;
		entity.COMPLAINT_BWTR=model.COMPLAINT_BWTR;
		entity.COMPLAINT_BWTR_IDCARD=model.COMPLAINT_BWTR_IDCARD;
		entity.COMPLAINT_BWTR_BMZW=model.COMPLAINT_BWTR_BMZW;
		entity.COMPLAINT_BWTR_PHONE=model.COMPLAINT_BWTR_PHONE;
		entity.COMPLAINT_ISAGENCY=model.COMPLAINT_ISAGENCY;
		entity.COMPLAINT_AGENCY=model.COMPLAINT_AGENCY;
		entity.COMPLAINT_AGENCY_CODE=model.COMPLAINT_AGENCY_CODE;
		entity.COMPLAINT_AGENCY_FAX=model.COMPLAINT_AGENCY_FAX;
		entity.COMPLAINT_AGENCY_PC=model.COMPLAINT_AGENCY_PC;
		entity.COMPLAINT_AGENCY_LXR=model.COMPLAINT_AGENCY_LXR;
		entity.COMPLAINT_AGENCY_PHONE=model.COMPLAINT_AGENCY_PHONE;
		entity.COMPLAINT_AGENCY_ADRESS=model.COMPLAINT_AGENCY_ADRESS;
		entity.TENDER_PROJECT_CODE=model.TENDER_PROJECT_CODE;
		entity.TENDER_PROJECT_NAME=model.TENDER_PROJECT_NAME;
		entity.TENDER_CLASS=model.TENDER_CLASS;
		entity.COMPLAINT_SX=model.COMPLAINT_SX;
		entity.COMPLAINT_TITLE=model.COMPLAINT_TITLE;
		entity.TSS_AIDS=model.TSS_AIDS;
		entity.YYZM_AIDS=model.YYZM_AIDS;
		entity.ZMCL_AIDS=model.ZMCL_AIDS;
		entity.OTHER_AIDS=model.OTHER_AIDS;
		entity.FR_SFZ_AIDS=model.FR_SFZ_AIDS;
		entity.WTR_SFZ_AIDS=model.WTR_SFZ_AIDS;
		entity.SQWTS_AIDS=model.SQWTS_AIDS;
		entity.WTDLHT_AIDS=model.WTDLHT_AIDS;
		entity.AGENCY_CODE_AIDS=model.AGENCY_CODE_AIDS;
		entity.AGENCY_SFZ_AIDS2=model.AGENCY_SFZ_AIDS2;
		entity.SFZ_AIDS=model.SFZ_AIDS;
		entity.CREATE_TM=model.CREATE_TM;
		entity.ACCEPT_DEPID=model.ACCEPT_DEPID;
		entity.SIGN_STATE=model.SIGN_STATE;
		entity.SIGN_UID=model.SIGN_UID;
		entity.SIGN_TM=model.SIGN_TM;
		entity.SIGN_REMARK=model.SIGN_REMARK;
		entity.ACCEPT_STATE=model.ACCEPT_STATE;
		entity.ACCEPT_UID=model.ACCEPT_UID;
		entity.ACCEPT_TM=model.ACCEPT_TM;
		entity.ACCEPT_REMARK=model.ACCEPT_REMARK;
		entity.ACCEPT_AIDS=model.ACCEPT_AIDS;
		entity.SCCZWT=model.SCCZWT;
		entity.ACCEPT_TZS=model.ACCEPT_TZS;
		entity.HANDLE_STATE=model.HANDLE_STATE;
		entity.HANDLE_UID=model.HANDLE_UID;
		entity.HANDLE_TM=model.HANDLE_TM;
		entity.HANDLE_JL=model.HANDLE_JL;
		entity.HANDLE_REMARK=model.HANDLE_REMARK;
		entity.HANDLE_AIDS=model.HANDLE_AIDS;
		entity.HANDLE_JDS=model.HANDLE_JDS;
		entity.IS_DELAY=model.IS_DELAY;
		entity.DELAY_UID=model.DELAY_UID;
		entity.DELAY_REMARK=model.DELAY_REMARK;
		entity.DELAY_AIDS=model.DELAY_AIDS;
		entity.DELAY_TM=model.DELAY_TM;
		entity.OVER_TM=model.OVER_TM;
		entity.DATA_TIMESTAMP=model.DATA_TIMESTAMP;
		entity.SIGN_AIDS=model.SIGN_AIDS;
		entity.DELAY_SMS=model.DELAY_SMS;
		entity.REVOKE_YJS=model.REVOKE_YJS;
		entity.COMPLAINT_ROLE=model.COMPLAINT_ROLE;
		entity.CREATE_UID=model.CREATE_UID;
		entity.CREATE_DEPID=model.CREATE_DEPID;
		entity.COMPLAINT_CONTENT=model.COMPLAINT_CONTENT;
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
        public GeneralResult Add(PT_ZXTS model)
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
                    Delete(PT_ZXTS._.ID.SelectIn(idArr));
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
        public GeneralResult Import(List<PT_ZXTS> model)
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
       	protected WhereClipBuilder ConditionBuilder(PT_ZXTS model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(model.ID!=null)
				{
				  condition.And(PT_ZXTS._.ID==(model.ID));
				}
				if(!string.IsNullOrWhiteSpace(model.CODE))
				{
				  condition.And(PT_ZXTS._.CODE.Contain(model.CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TYPE))
				{
				  condition.And(PT_ZXTS._.TYPE.Contain(model.TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.STATE))
				{
				  condition.And(PT_ZXTS._.STATE.Contain(model.STATE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_TYPE))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_TYPE.Contain(model.COMPLAINT_TYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_NAME))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_NAME.Contain(model.COMPLAINT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_CODE))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_CODE.Contain(model.COMPLAINT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_DNAME))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_DNAME.Contain(model.COMPLAINT_DNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_ADRESS))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_ADRESS.Contain(model.COMPLAINT_ADRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_ZW))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_ZW.Contain(model.COMPLAINT_ZW));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_FAX))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_FAX.Contain(model.COMPLAINT_FAX));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_PC))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_PC.Contain(model.COMPLAINT_PC));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_CONTACT))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_CONTACT.Contain(model.COMPLAINT_CONTACT));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_PHONE))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_PHONE.Contain(model.COMPLAINT_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_EMAIL))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_EMAIL.Contain(model.COMPLAINT_EMAIL));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_CONTACT_IDCARD))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_CONTACT_IDCARD.Contain(model.COMPLAINT_CONTACT_IDCARD));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_CONTACT_PHONE))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_CONTACT_PHONE.Contain(model.COMPLAINT_CONTACT_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_CONTACT_EMAIL))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_CONTACT_EMAIL.Contain(model.COMPLAINT_CONTACT_EMAIL));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_LEGAL))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_LEGAL.Contain(model.COMPLAINT_LEGAL));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_LEGAL_IDCARD))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_LEGAL_IDCARD.Contain(model.COMPLAINT_LEGAL_IDCARD));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_LEGAL_PHONE))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_LEGAL_PHONE.Contain(model.COMPLAINT_LEGAL_PHONE));
				}
				if(model.COMPLAINT_LEGAL_ISWT!=null)
				{
				  condition.And(PT_ZXTS._.COMPLAINT_LEGAL_ISWT==(model.COMPLAINT_LEGAL_ISWT));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_BWTR))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_BWTR.Contain(model.COMPLAINT_BWTR));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_BWTR_IDCARD))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_BWTR_IDCARD.Contain(model.COMPLAINT_BWTR_IDCARD));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_BWTR_BMZW))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_BWTR_BMZW.Contain(model.COMPLAINT_BWTR_BMZW));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_BWTR_PHONE))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_BWTR_PHONE.Contain(model.COMPLAINT_BWTR_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_ISAGENCY))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_ISAGENCY.Contain(model.COMPLAINT_ISAGENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_AGENCY))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_AGENCY.Contain(model.COMPLAINT_AGENCY));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_AGENCY_CODE))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_AGENCY_CODE.Contain(model.COMPLAINT_AGENCY_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_AGENCY_FAX))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_AGENCY_FAX.Contain(model.COMPLAINT_AGENCY_FAX));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_AGENCY_PC))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_AGENCY_PC.Contain(model.COMPLAINT_AGENCY_PC));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_AGENCY_LXR))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_AGENCY_LXR.Contain(model.COMPLAINT_AGENCY_LXR));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_AGENCY_PHONE))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_AGENCY_PHONE.Contain(model.COMPLAINT_AGENCY_PHONE));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_AGENCY_ADRESS))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_AGENCY_ADRESS.Contain(model.COMPLAINT_AGENCY_ADRESS));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
				{
				  condition.And(PT_ZXTS._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
				{
				  condition.And(PT_ZXTS._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDER_CLASS))
				{
				  condition.And(PT_ZXTS._.TENDER_CLASS.Contain(model.TENDER_CLASS));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_SX))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_SX.Contain(model.COMPLAINT_SX));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_TITLE))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_TITLE.Contain(model.COMPLAINT_TITLE));
				}
				if(!string.IsNullOrWhiteSpace(model.TSS_AIDS))
				{
				  condition.And(PT_ZXTS._.TSS_AIDS.Contain(model.TSS_AIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.YYZM_AIDS))
				{
				  condition.And(PT_ZXTS._.YYZM_AIDS.Contain(model.YYZM_AIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.ZMCL_AIDS))
				{
				  condition.And(PT_ZXTS._.ZMCL_AIDS.Contain(model.ZMCL_AIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.OTHER_AIDS))
				{
				  condition.And(PT_ZXTS._.OTHER_AIDS.Contain(model.OTHER_AIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.FR_SFZ_AIDS))
				{
				  condition.And(PT_ZXTS._.FR_SFZ_AIDS.Contain(model.FR_SFZ_AIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.WTR_SFZ_AIDS))
				{
				  condition.And(PT_ZXTS._.WTR_SFZ_AIDS.Contain(model.WTR_SFZ_AIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.SQWTS_AIDS))
				{
				  condition.And(PT_ZXTS._.SQWTS_AIDS.Contain(model.SQWTS_AIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.WTDLHT_AIDS))
				{
				  condition.And(PT_ZXTS._.WTDLHT_AIDS.Contain(model.WTDLHT_AIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.AGENCY_CODE_AIDS))
				{
				  condition.And(PT_ZXTS._.AGENCY_CODE_AIDS.Contain(model.AGENCY_CODE_AIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.AGENCY_SFZ_AIDS2))
				{
				  condition.And(PT_ZXTS._.AGENCY_SFZ_AIDS2.Contain(model.AGENCY_SFZ_AIDS2));
				}
				if(!string.IsNullOrWhiteSpace(model.SFZ_AIDS))
				{
				  condition.And(PT_ZXTS._.SFZ_AIDS.Contain(model.SFZ_AIDS));
				}
				if(model.CREATE_TM!=null)
				{
				  condition.And(PT_ZXTS._.CREATE_TM==(model.CREATE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.ACCEPT_DEPID))
				{
				  condition.And(PT_ZXTS._.ACCEPT_DEPID.Contain(model.ACCEPT_DEPID));
				}
				if(!string.IsNullOrWhiteSpace(model.SIGN_STATE))
				{
				  condition.And(PT_ZXTS._.SIGN_STATE.Contain(model.SIGN_STATE));
				}
				if(model.SIGN_UID!=null)
				{
				  condition.And(PT_ZXTS._.SIGN_UID==(model.SIGN_UID));
				}
				if(model.SIGN_TM!=null)
				{
				  condition.And(PT_ZXTS._.SIGN_TM==(model.SIGN_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.SIGN_REMARK))
				{
				  condition.And(PT_ZXTS._.SIGN_REMARK.Contain(model.SIGN_REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.ACCEPT_STATE))
				{
				  condition.And(PT_ZXTS._.ACCEPT_STATE.Contain(model.ACCEPT_STATE));
				}
				if(model.ACCEPT_UID!=null)
				{
				  condition.And(PT_ZXTS._.ACCEPT_UID==(model.ACCEPT_UID));
				}
				if(model.ACCEPT_TM!=null)
				{
				  condition.And(PT_ZXTS._.ACCEPT_TM==(model.ACCEPT_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.ACCEPT_REMARK))
				{
				  condition.And(PT_ZXTS._.ACCEPT_REMARK.Contain(model.ACCEPT_REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.ACCEPT_AIDS))
				{
				  condition.And(PT_ZXTS._.ACCEPT_AIDS.Contain(model.ACCEPT_AIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.SCCZWT))
				{
				  condition.And(PT_ZXTS._.SCCZWT.Contain(model.SCCZWT));
				}
				if(!string.IsNullOrWhiteSpace(model.ACCEPT_TZS))
				{
				  condition.And(PT_ZXTS._.ACCEPT_TZS.Contain(model.ACCEPT_TZS));
				}
				if(!string.IsNullOrWhiteSpace(model.HANDLE_STATE))
				{
				  condition.And(PT_ZXTS._.HANDLE_STATE.Contain(model.HANDLE_STATE));
				}
				if(model.HANDLE_UID!=null)
				{
				  condition.And(PT_ZXTS._.HANDLE_UID==(model.HANDLE_UID));
				}
				if(model.HANDLE_TM!=null)
				{
				  condition.And(PT_ZXTS._.HANDLE_TM==(model.HANDLE_TM));
				}
				if(!string.IsNullOrWhiteSpace(model.HANDLE_JL))
				{
				  condition.And(PT_ZXTS._.HANDLE_JL.Contain(model.HANDLE_JL));
				}
				if(!string.IsNullOrWhiteSpace(model.HANDLE_REMARK))
				{
				  condition.And(PT_ZXTS._.HANDLE_REMARK.Contain(model.HANDLE_REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.HANDLE_AIDS))
				{
				  condition.And(PT_ZXTS._.HANDLE_AIDS.Contain(model.HANDLE_AIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.HANDLE_JDS))
				{
				  condition.And(PT_ZXTS._.HANDLE_JDS.Contain(model.HANDLE_JDS));
				}
				if(!string.IsNullOrWhiteSpace(model.IS_DELAY))
				{
				  condition.And(PT_ZXTS._.IS_DELAY.Contain(model.IS_DELAY));
				}
				if(model.DELAY_UID!=null)
				{
				  condition.And(PT_ZXTS._.DELAY_UID==(model.DELAY_UID));
				}
				if(!string.IsNullOrWhiteSpace(model.DELAY_REMARK))
				{
				  condition.And(PT_ZXTS._.DELAY_REMARK.Contain(model.DELAY_REMARK));
				}
				if(!string.IsNullOrWhiteSpace(model.DELAY_AIDS))
				{
				  condition.And(PT_ZXTS._.DELAY_AIDS.Contain(model.DELAY_AIDS));
				}
				if(model.DELAY_TM!=null)
				{
				  condition.And(PT_ZXTS._.DELAY_TM==(model.DELAY_TM));
				}
				if(model.OVER_TM!=null)
				{
				  condition.And(PT_ZXTS._.OVER_TM==(model.OVER_TM));
				}
				if(model.DATA_TIMESTAMP!=null)
				{
				  condition.And(PT_ZXTS._.DATA_TIMESTAMP==(model.DATA_TIMESTAMP));
				}
				if(!string.IsNullOrWhiteSpace(model.SIGN_AIDS))
				{
				  condition.And(PT_ZXTS._.SIGN_AIDS.Contain(model.SIGN_AIDS));
				}
				if(!string.IsNullOrWhiteSpace(model.DELAY_SMS))
				{
				  condition.And(PT_ZXTS._.DELAY_SMS.Contain(model.DELAY_SMS));
				}
				if(!string.IsNullOrWhiteSpace(model.REVOKE_YJS))
				{
				  condition.And(PT_ZXTS._.REVOKE_YJS.Contain(model.REVOKE_YJS));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_ROLE))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_ROLE.Contain(model.COMPLAINT_ROLE));
				}
				if(model.CREATE_UID!=null)
				{
				  condition.And(PT_ZXTS._.CREATE_UID==(model.CREATE_UID));
				}
				if(!string.IsNullOrWhiteSpace(model.CREATE_DEPID))
				{
				  condition.And(PT_ZXTS._.CREATE_DEPID.Contain(model.CREATE_DEPID));
				}
				if(!string.IsNullOrWhiteSpace(model.COMPLAINT_CONTENT))
				{
				  condition.And(PT_ZXTS._.COMPLAINT_CONTENT.Contain(model.COMPLAINT_CONTENT));
				}
		return condition;
	}
        #endregion
    }
}