using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Extensions;
using GGZYJD.DbEntity;
using Newtonsoft.Json;


namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 实体类PT_ZXTS。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class PtZxtsModel
    {
        private string _COMPLAINT_TYPE_TEXT;
        private string _STATE_TEXT;
        private string _SIGN_STATE_TEXT;
        private string _ACCEPT_STATE_TEXT;
        private string _HANDLE_STATE_TEXT;
        private string _TENDER_CLASS_TEXT;
        public PtZxtsModel() { }
        public int? IS_OVERTIME { get; set; }
        /// <summary>
        /// 查询类型
        /// </summary>
        public string SearchType { get; set; }

        #region 查询类型

        /// <summary>
        /// 待办
        /// </summary>
        public bool DaiBan => string.Compare(SearchType, "DB", StringComparison.CurrentCultureIgnoreCase) == 0;
        /// <summary>
        /// 在办
        /// </summary>
        public bool ZaiBan => string.Compare(SearchType, "ZB", StringComparison.CurrentCultureIgnoreCase) == 0;
        /// <summary>
        /// 已办
        /// </summary>
        public bool YiBan => string.Compare(SearchType, "YB", StringComparison.CurrentCultureIgnoreCase) == 0;
        /// <summary>
        /// 待签收
        /// </summary>
        public bool DaiQianShou => string.Compare(SearchType, "DQS", StringComparison.CurrentCultureIgnoreCase) == 0;
        /// <summary>
        /// 待受理
        /// </summary>
        public bool DaiShouLi => string.Compare(SearchType, "DSL", StringComparison.CurrentCultureIgnoreCase) == 0;
        /// <summary>
        /// 待处理
        /// </summary>
        public bool DaiChuLi => string.Compare(SearchType, "DCL", StringComparison.CurrentCultureIgnoreCase) == 0;
        /// <summary>
        /// 即将到到期未处理
        /// 投诉待处理时距离最后处理时间≤7天的在该标签下显示
        /// </summary>
        public bool JiJiangDaoQiWeiChuLi => string.Compare(SearchType, "JJDQWCL", StringComparison.CurrentCultureIgnoreCase) == 0;
        /// <summary>
        /// 投诉人申请撤诉
        /// 
        /// </summary>
        public bool TouSuRenShenQingCheSu => string.Compare(SearchType, "TSRSQCS", StringComparison.CurrentCultureIgnoreCase) == 0;

        #endregion

        #region 招标人信息
        /// <summary>
        /// 代理机构
        /// </summary>
        public decimal? DLJG_UID { get; set; }
        /// <summary>
        /// 代理机构名称
        /// </summary>
        public string DLJG_NAME { get; set; }
        /// <summary>
        /// 建设单位
        /// </summary>
        public decimal? JSDW_UID { get; set; }
        /// <summary>
        /// 建设单位名称
        /// </summary>
        public string JSDW_NAME { get; set; }

        #endregion
        #region 字典匹配
        /// <summary>
        /// TYPE == "1" ? "线上" : "线下"
        /// </summary>
        public string TYPE_TEXT => TYPE == "1" ? "线上" : "线下";
        public string IS_DELAY_TEXT => IS_DELAY == "1" ? "已延期" : "未延期";

        public string COMPLAINT_LEGAL_ISWT_TEXT => COMPLAINT_LEGAL_ISWT == 1 ? "是" : "否";
        public string COMPLAINT_ISAGENCY_TEXT => COMPLAINT_ISAGENCY == "1" ? "是" : "否";

        public string IS_OVERTIME_TEXT { get; set; }

        public string STATE_TEXT
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_STATE_TEXT))
                {
                    switch (STATE)
                    {
                        case "-1":
                            _STATE_TEXT = "暂存(线下)"; ;
                            break;
                        case "0":
                            _STATE_TEXT = "待处理(线下)";
                            break;
                    }
                }
                return _STATE_TEXT;
            }
            set => _STATE_TEXT = value;
        }

        public string HANDLE_JL_TEXT { get; set; }

        public string SIGN_STATE_TEXT
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_SIGN_STATE_TEXT))
                {
                    _SIGN_STATE_TEXT = "未签收";
                }

                if (TYPE == "2")
                {
                    _SIGN_STATE_TEXT = "已签收";
                }
                return _SIGN_STATE_TEXT;
            }
            set => _SIGN_STATE_TEXT = value;
        }

        public string ACCEPT_STATE_TEXT
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_ACCEPT_STATE_TEXT))
                {
                    _ACCEPT_STATE_TEXT = "未受理";
                }
                if (TYPE == "2")
                {
                    _ACCEPT_STATE_TEXT = "已受理";
                }
                return _ACCEPT_STATE_TEXT;
            }
            set => _ACCEPT_STATE_TEXT = value;
        }

        public string HANDLE_STATE_TEXT
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_HANDLE_STATE_TEXT))
                {
                    _HANDLE_STATE_TEXT = "未处理";// string.IsNullOrWhiteSpace(HANDLE_STATE) ? "未处理" : "已处理";
                }
                return _HANDLE_STATE_TEXT;
            }
            set => _HANDLE_STATE_TEXT = value;
        }

        /// <summary>
        /// COMPLAINT_TYPE 1法人 2自然人
        /// </summary>
        public string COMPLAINT_TYPE_TEXT
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_COMPLAINT_TYPE_TEXT))
                {
                    _COMPLAINT_TYPE_TEXT = COMPLAINT_TYPE == "1" ? "法人" : "自然人";
                }
                return _COMPLAINT_TYPE_TEXT;
            }
            set => _COMPLAINT_TYPE_TEXT = value;
        }

        public string COMPLAINT_SX_TEXT { get; set; }

        public string TENDER_CLASS_TEXT
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_TENDER_CLASS_TEXT))
                {
                    _TENDER_CLASS_TEXT = TENDER_CLASS_TEXT_83;
                }
                if (string.IsNullOrWhiteSpace(_TENDER_CLASS_TEXT))
                {
                    _TENDER_CLASS_TEXT = TENDER_CLASS_TEXT_85;
                }
                return _TENDER_CLASS_TEXT;
            }
            set => _TENDER_CLASS_TEXT = value;
        }

        [JsonIgnore]
        public string TENDER_CLASS_TEXT_83 { get; set; }
        [JsonIgnore]
        public string TENDER_CLASS_TEXT_85 { get; set; }
        public string ACCEPT_DEPID_TEXT { get; set; }
        public string ACCEPT_UID_TEXT { get; set; }
        public string SIGN_UID_TEXT { get; set; }

        public string COMPLAINT_ROLE_TEXT { get; set; }
        public string RECORDER_UNAME { get; set; }
        #endregion


        public List<string> Button { get; set; }
        /// <summary>
        /// 被投诉人
        /// </summary>
        public List<PtZxtsBtsrModel> BTSR { get; set; }

        public List<PtZxtsLogModel> Logs { get; set; }

        public List<LabelValueModel> Processes { get; set; }

        public int? WorkDay { get; set; }
        /// <summary>
        /// 招标项目归属地，关联TENDER_PROJECT获取
        /// </summary>
        public string REGION_CODE { get; set; }
        /// <summary>
        /// 招标项目类型，关联TENDER_PROJECT获取
        /// </summary>
        public string TENDER_PROJECT_TYPE { get; set; }

        #region 附件

        public List<UploadResData> HANDLE_JDS_ATTACHMENT { get; set; }
        public List<UploadResData> ACCEPT_TZS_ATTACHMENT { get; set; }
        public List<UploadResData> DELAY_SMS_ATTACHMENT { get; set; }
        public List<UploadResData> REVOKE_YJS_ATTACHMENT { get; set; }
        public List<UploadResData> YYZM_AIDS_ATTACHMENT { get; set; }
        public List<UploadResData> ZMCL_AIDS_ATTACHMENT { get; set; }
        public List<UploadResData> FR_SFZ_AIDS_ATTACHMENT { get; set; }
        public List<UploadResData> WTR_SFZ_AIDS_ATTACHMENT { get; set; }
        public List<UploadResData> SQWTS_AIDS_ATTACHMENT { get; set; }
        public List<UploadResData> WTDLHT_AIDS_ATTACHMENT { get; set; }
        public List<UploadResData> AGENCY_CODE_AIDS_ATTACHMENT { get; set; }
        public List<UploadResData> AGENCY_SFZ_AIDS2_ATTACHMENT { get; set; }
        public List<UploadResData> SFZ_AIDS_ATTACHMENT { get; set; }
        public List<UploadResData> OTHER_AIDS_ATTACHMENT { get; set; }
        public List<UploadResData> TSS_AIDS_ATTACHMENT { get; set; }

        public List<SYS_ATTACHMENT> ATTACHMENTS { get; set; }
        /// <summary>
        /// 设置附件
        /// </summary>
        public void SetAids()
        {
            ATTACHMENTS = new List<SYS_ATTACHMENT>();
            if (HANDLE_JDS_ATTACHMENT != null && HANDLE_JDS_ATTACHMENT.Any())
            {
                HANDLE_JDS = string.Join(",", HANDLE_JDS_ATTACHMENT.Select(c => c.Id));
                ATTACHMENTS.AddRange(HANDLE_JDS_ATTACHMENT.Select(c => c.JdSysAttachment()));
            }
            if (ACCEPT_TZS_ATTACHMENT != null && ACCEPT_TZS_ATTACHMENT.Any())
            {
                ACCEPT_TZS = string.Join(",", ACCEPT_TZS_ATTACHMENT.Select(c => c.Id));
                ATTACHMENTS.AddRange(ACCEPT_TZS_ATTACHMENT.Select(c => c.JdSysAttachment()));
            }
            if (DELAY_SMS_ATTACHMENT != null && DELAY_SMS_ATTACHMENT.Any())
            {
                DELAY_SMS = string.Join(",", DELAY_SMS_ATTACHMENT.Select(c => c.Id));
                ATTACHMENTS.AddRange(DELAY_SMS_ATTACHMENT.Select(c => c.JdSysAttachment()));
            }
            if (REVOKE_YJS_ATTACHMENT != null && REVOKE_YJS_ATTACHMENT.Any())
            {
                REVOKE_YJS = string.Join(",", REVOKE_YJS_ATTACHMENT.Select(c => c.Id));
                ATTACHMENTS.AddRange(REVOKE_YJS_ATTACHMENT.Select(c => c.JdSysAttachment()));
            }
            if (YYZM_AIDS_ATTACHMENT != null && YYZM_AIDS_ATTACHMENT.Any())
            {
                YYZM_AIDS = string.Join(",", YYZM_AIDS_ATTACHMENT.Select(c => c.Id));
                ATTACHMENTS.AddRange(YYZM_AIDS_ATTACHMENT.Select(c => c.JdSysAttachment()));
            }
            if (ZMCL_AIDS_ATTACHMENT != null && ZMCL_AIDS_ATTACHMENT.Any())
            {
                ZMCL_AIDS = string.Join(",", ZMCL_AIDS_ATTACHMENT.Select(c => c.Id));
                ATTACHMENTS.AddRange(ZMCL_AIDS_ATTACHMENT.Select(c => c.JdSysAttachment()));
            }
            if (FR_SFZ_AIDS_ATTACHMENT != null && FR_SFZ_AIDS_ATTACHMENT.Any())
            {
                FR_SFZ_AIDS = string.Join(",", FR_SFZ_AIDS_ATTACHMENT.Select(c => c.Id));
                ATTACHMENTS.AddRange(FR_SFZ_AIDS_ATTACHMENT.Select(c => c.JdSysAttachment()));
            }
            if (WTR_SFZ_AIDS_ATTACHMENT != null && WTR_SFZ_AIDS_ATTACHMENT.Any())
            {
                WTR_SFZ_AIDS = string.Join(",", WTR_SFZ_AIDS_ATTACHMENT.Select(c => c.Id));
                ATTACHMENTS.AddRange(WTR_SFZ_AIDS_ATTACHMENT.Select(c => c.JdSysAttachment()));
            }
            if (SQWTS_AIDS_ATTACHMENT != null && SQWTS_AIDS_ATTACHMENT.Any())
            {
                SQWTS_AIDS = string.Join(",", SQWTS_AIDS_ATTACHMENT.Select(c => c.Id));
                ATTACHMENTS.AddRange(SQWTS_AIDS_ATTACHMENT.Select(c => c.JdSysAttachment()));
            }
            if (WTDLHT_AIDS_ATTACHMENT != null && WTDLHT_AIDS_ATTACHMENT.Any())
            {
                WTDLHT_AIDS = string.Join(",", WTDLHT_AIDS_ATTACHMENT.Select(c => c.Id));
                ATTACHMENTS.AddRange(WTDLHT_AIDS_ATTACHMENT.Select(c => c.JdSysAttachment()));
            }
            if (AGENCY_CODE_AIDS_ATTACHMENT != null && AGENCY_CODE_AIDS_ATTACHMENT.Any())
            {
                AGENCY_CODE_AIDS = string.Join(",", AGENCY_CODE_AIDS_ATTACHMENT.Select(c => c.Id));
                ATTACHMENTS.AddRange(AGENCY_CODE_AIDS_ATTACHMENT.Select(c => c.JdSysAttachment()));
            }
            if (AGENCY_SFZ_AIDS2_ATTACHMENT != null && AGENCY_SFZ_AIDS2_ATTACHMENT.Any())
            {
                AGENCY_SFZ_AIDS2 = string.Join(",", AGENCY_SFZ_AIDS2_ATTACHMENT.Select(c => c.Id));
                ATTACHMENTS.AddRange(AGENCY_SFZ_AIDS2_ATTACHMENT.Select(c => c.JdSysAttachment()));
            }
            if (SFZ_AIDS_ATTACHMENT != null && SFZ_AIDS_ATTACHMENT.Any())
            {
                SFZ_AIDS = string.Join(",", SFZ_AIDS_ATTACHMENT.Select(c => c.Id));
                ATTACHMENTS.AddRange(SFZ_AIDS_ATTACHMENT.Select(c => c.JdSysAttachment()));
            }
            if (OTHER_AIDS_ATTACHMENT != null && OTHER_AIDS_ATTACHMENT.Any())
            {
                OTHER_AIDS = string.Join(",", OTHER_AIDS_ATTACHMENT.Select(c => c.Id));
                ATTACHMENTS.AddRange(OTHER_AIDS_ATTACHMENT.Select(c => c.JdSysAttachment()));
            }
            if (TSS_AIDS_ATTACHMENT != null && TSS_AIDS_ATTACHMENT.Any())
            {
                TSS_AIDS = string.Join(",", TSS_AIDS_ATTACHMENT.Select(c => c.Id));
                ATTACHMENTS.AddRange(TSS_AIDS_ATTACHMENT.Select(c => c.JdSysAttachment()));
            }
        }
        #endregion

        #region Method

        public WhereClipBuilder ConditionBuilder(SearchCondition search = null)
        {
            WhereClipBuilder condition = new WhereClipBuilder();

            #region MyRegion
            if (this.ID != null)
            {
                condition.And(PT_ZXTS._.ID == (this.ID));
            }
            if (!string.IsNullOrWhiteSpace(this.CODE))
            {
                condition.And(PT_ZXTS._.CODE.Contain(this.CODE));
            }
            if (!string.IsNullOrWhiteSpace(this.TYPE))
            {
                condition.And(PT_ZXTS._.TYPE == (this.TYPE));
            }
            if (!string.IsNullOrWhiteSpace(this.STATE))
            {
                condition.And(PT_ZXTS._.STATE == (this.STATE));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_TYPE))
            {
                condition.And(PT_ZXTS._.COMPLAINT_TYPE.Contain(this.COMPLAINT_TYPE));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_NAME))
            {
                condition.And(PT_ZXTS._.COMPLAINT_NAME.Contain(this.COMPLAINT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_CODE))
            {
                condition.And(PT_ZXTS._.COMPLAINT_CODE.Contain(this.COMPLAINT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_DNAME))
            {
                condition.And(PT_ZXTS._.COMPLAINT_DNAME.Contain(this.COMPLAINT_DNAME));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_ADRESS))
            {
                condition.And(PT_ZXTS._.COMPLAINT_ADRESS.Contain(this.COMPLAINT_ADRESS));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_ZW))
            {
                condition.And(PT_ZXTS._.COMPLAINT_ZW.Contain(this.COMPLAINT_ZW));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_FAX))
            {
                condition.And(PT_ZXTS._.COMPLAINT_FAX.Contain(this.COMPLAINT_FAX));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_PC))
            {
                condition.And(PT_ZXTS._.COMPLAINT_PC.Contain(this.COMPLAINT_PC));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_CONTACT))
            {
                condition.And(PT_ZXTS._.COMPLAINT_CONTACT.Contain(this.COMPLAINT_CONTACT));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_PHONE))
            {
                condition.And(PT_ZXTS._.COMPLAINT_PHONE.Contain(this.COMPLAINT_PHONE));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_EMAIL))
            {
                condition.And(PT_ZXTS._.COMPLAINT_EMAIL.Contain(this.COMPLAINT_EMAIL));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_CONTACT_IDCARD))
            {
                condition.And(PT_ZXTS._.COMPLAINT_CONTACT_IDCARD.Contain(this.COMPLAINT_CONTACT_IDCARD));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_CONTACT_PHONE))
            {
                condition.And(PT_ZXTS._.COMPLAINT_CONTACT_PHONE.Contain(this.COMPLAINT_CONTACT_PHONE));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_CONTACT_EMAIL))
            {
                condition.And(PT_ZXTS._.COMPLAINT_CONTACT_EMAIL.Contain(this.COMPLAINT_CONTACT_EMAIL));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_LEGAL))
            {
                condition.And(PT_ZXTS._.COMPLAINT_LEGAL.Contain(this.COMPLAINT_LEGAL));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_LEGAL_IDCARD))
            {
                condition.And(PT_ZXTS._.COMPLAINT_LEGAL_IDCARD.Contain(this.COMPLAINT_LEGAL_IDCARD));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_LEGAL_PHONE))
            {
                condition.And(PT_ZXTS._.COMPLAINT_LEGAL_PHONE.Contain(this.COMPLAINT_LEGAL_PHONE));
            }
            if (this.COMPLAINT_LEGAL_ISWT != null)
            {
                condition.And(PT_ZXTS._.COMPLAINT_LEGAL_ISWT == (this.COMPLAINT_LEGAL_ISWT));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_BWTR))
            {
                condition.And(PT_ZXTS._.COMPLAINT_BWTR.Contain(this.COMPLAINT_BWTR));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_BWTR_IDCARD))
            {
                condition.And(PT_ZXTS._.COMPLAINT_BWTR_IDCARD.Contain(this.COMPLAINT_BWTR_IDCARD));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_BWTR_BMZW))
            {
                condition.And(PT_ZXTS._.COMPLAINT_BWTR_BMZW.Contain(this.COMPLAINT_BWTR_BMZW));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_BWTR_PHONE))
            {
                condition.And(PT_ZXTS._.COMPLAINT_BWTR_PHONE.Contain(this.COMPLAINT_BWTR_PHONE));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_ISAGENCY))
            {
                condition.And(PT_ZXTS._.COMPLAINT_ISAGENCY.Contain(this.COMPLAINT_ISAGENCY));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_AGENCY))
            {
                condition.And(PT_ZXTS._.COMPLAINT_AGENCY.Contain(this.COMPLAINT_AGENCY));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_AGENCY_CODE))
            {
                condition.And(PT_ZXTS._.COMPLAINT_AGENCY_CODE.Contain(this.COMPLAINT_AGENCY_CODE));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_AGENCY_FAX))
            {
                condition.And(PT_ZXTS._.COMPLAINT_AGENCY_FAX.Contain(this.COMPLAINT_AGENCY_FAX));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_AGENCY_PC))
            {
                condition.And(PT_ZXTS._.COMPLAINT_AGENCY_PC.Contain(this.COMPLAINT_AGENCY_PC));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_AGENCY_LXR))
            {
                condition.And(PT_ZXTS._.COMPLAINT_AGENCY_LXR.Contain(this.COMPLAINT_AGENCY_LXR));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_AGENCY_PHONE))
            {
                condition.And(PT_ZXTS._.COMPLAINT_AGENCY_PHONE.Contain(this.COMPLAINT_AGENCY_PHONE));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_AGENCY_ADRESS))
            {
                condition.And(PT_ZXTS._.COMPLAINT_AGENCY_ADRESS.Contain(this.COMPLAINT_AGENCY_ADRESS));
            }
            if (!string.IsNullOrWhiteSpace(this.TENDER_PROJECT_CODE))
            {
                condition.And(PT_ZXTS._.TENDER_PROJECT_CODE.Contain(this.TENDER_PROJECT_CODE));
            }
            if (!string.IsNullOrWhiteSpace(this.TENDER_PROJECT_NAME))
            {
                condition.And(PT_ZXTS._.TENDER_PROJECT_NAME.Contain(this.TENDER_PROJECT_NAME));
            }
            if (!string.IsNullOrWhiteSpace(this.TENDER_CLASS))
            {
                condition.And(PT_ZXTS._.TENDER_CLASS.Contain(this.TENDER_CLASS));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_SX))
            {
                condition.And(PT_ZXTS._.COMPLAINT_SX.Contain(this.COMPLAINT_SX));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_TITLE))
            {
                condition.And(PT_ZXTS._.COMPLAINT_TITLE.Contain(this.COMPLAINT_TITLE));
            }
            if (!string.IsNullOrWhiteSpace(this.TSS_AIDS))
            {
                condition.And(PT_ZXTS._.TSS_AIDS.Contain(this.TSS_AIDS));
            }
            if (!string.IsNullOrWhiteSpace(this.YYZM_AIDS))
            {
                condition.And(PT_ZXTS._.YYZM_AIDS.Contain(this.YYZM_AIDS));
            }
            if (!string.IsNullOrWhiteSpace(this.ZMCL_AIDS))
            {
                condition.And(PT_ZXTS._.ZMCL_AIDS.Contain(this.ZMCL_AIDS));
            }
            if (!string.IsNullOrWhiteSpace(this.OTHER_AIDS))
            {
                condition.And(PT_ZXTS._.OTHER_AIDS.Contain(this.OTHER_AIDS));
            }
            if (!string.IsNullOrWhiteSpace(this.FR_SFZ_AIDS))
            {
                condition.And(PT_ZXTS._.FR_SFZ_AIDS.Contain(this.FR_SFZ_AIDS));
            }
            if (!string.IsNullOrWhiteSpace(this.WTR_SFZ_AIDS))
            {
                condition.And(PT_ZXTS._.WTR_SFZ_AIDS.Contain(this.WTR_SFZ_AIDS));
            }
            if (!string.IsNullOrWhiteSpace(this.SQWTS_AIDS))
            {
                condition.And(PT_ZXTS._.SQWTS_AIDS.Contain(this.SQWTS_AIDS));
            }
            if (!string.IsNullOrWhiteSpace(this.WTDLHT_AIDS))
            {
                condition.And(PT_ZXTS._.WTDLHT_AIDS.Contain(this.WTDLHT_AIDS));
            }
            if (!string.IsNullOrWhiteSpace(this.AGENCY_CODE_AIDS))
            {
                condition.And(PT_ZXTS._.AGENCY_CODE_AIDS.Contain(this.AGENCY_CODE_AIDS));
            }
            if (!string.IsNullOrWhiteSpace(this.AGENCY_SFZ_AIDS2))
            {
                condition.And(PT_ZXTS._.AGENCY_SFZ_AIDS2.Contain(this.AGENCY_SFZ_AIDS2));
            }
            if (!string.IsNullOrWhiteSpace(this.SFZ_AIDS))
            {
                condition.And(PT_ZXTS._.SFZ_AIDS.Contain(this.SFZ_AIDS));
            }
            if (this.CREATE_TM != null)
            {
                condition.And(PT_ZXTS._.CREATE_TM == (this.CREATE_TM));
            }
            if (!string.IsNullOrWhiteSpace(this.ACCEPT_DEPID))
            {
                condition.And(PT_ZXTS._.ACCEPT_DEPID.Contain(this.ACCEPT_DEPID));
            }
            if (!string.IsNullOrWhiteSpace(this.SIGN_STATE))
            {
                condition.And(PT_ZXTS._.SIGN_STATE.Contain(this.SIGN_STATE));
            }
            if (this.SIGN_UID != null)
            {
                condition.And(PT_ZXTS._.SIGN_UID == (this.SIGN_UID));
            }
            if (this.SIGN_TM != null)
            {
                condition.And(PT_ZXTS._.SIGN_TM == (this.SIGN_TM));
            }
            if (!string.IsNullOrWhiteSpace(this.SIGN_REMARK))
            {
                condition.And(PT_ZXTS._.SIGN_REMARK.Contain(this.SIGN_REMARK));
            }
            if (!string.IsNullOrWhiteSpace(this.ACCEPT_STATE))
            {
                condition.And(PT_ZXTS._.ACCEPT_STATE.Contain(this.ACCEPT_STATE));
            }
            if (this.ACCEPT_UID != null)
            {
                condition.And(PT_ZXTS._.ACCEPT_UID == (this.ACCEPT_UID));
            }
            if (this.ACCEPT_TM != null)
            {
                condition.And(PT_ZXTS._.ACCEPT_TM == (this.ACCEPT_TM));
            }
            if (!string.IsNullOrWhiteSpace(this.ACCEPT_REMARK))
            {
                condition.And(PT_ZXTS._.ACCEPT_REMARK.Contain(this.ACCEPT_REMARK));
            }
            if (!string.IsNullOrWhiteSpace(this.ACCEPT_AIDS))
            {
                condition.And(PT_ZXTS._.ACCEPT_AIDS.Contain(this.ACCEPT_AIDS));
            }
            if (!string.IsNullOrWhiteSpace(this.SCCZWT))
            {
                condition.And(PT_ZXTS._.SCCZWT.Contain(this.SCCZWT));
            }
            if (!string.IsNullOrWhiteSpace(this.ACCEPT_TZS))
            {
                condition.And(PT_ZXTS._.ACCEPT_TZS.Contain(this.ACCEPT_TZS));
            }
            if (!string.IsNullOrWhiteSpace(this.HANDLE_STATE))
            {
                condition.And(PT_ZXTS._.HANDLE_STATE.Contain(this.HANDLE_STATE));
            }
            if (this.HANDLE_UID != null)
            {
                condition.And(PT_ZXTS._.HANDLE_UID == (this.HANDLE_UID));
            }
            if (this.HANDLE_TM != null)
            {
                condition.And(PT_ZXTS._.HANDLE_TM == (this.HANDLE_TM));
            }
            if (!string.IsNullOrWhiteSpace(this.HANDLE_JL))
            {
                condition.And(PT_ZXTS._.HANDLE_JL.Contain(this.HANDLE_JL));
            }
            if (!string.IsNullOrWhiteSpace(this.HANDLE_REMARK))
            {
                condition.And(PT_ZXTS._.HANDLE_REMARK.Contain(this.HANDLE_REMARK));
            }
            if (!string.IsNullOrWhiteSpace(this.HANDLE_AIDS))
            {
                condition.And(PT_ZXTS._.HANDLE_AIDS.Contain(this.HANDLE_AIDS));
            }
            if (!string.IsNullOrWhiteSpace(this.HANDLE_JDS))
            {
                condition.And(PT_ZXTS._.HANDLE_JDS.Contain(this.HANDLE_JDS));
            }
            if (!string.IsNullOrWhiteSpace(this.IS_DELAY))
            {
                condition.And(PT_ZXTS._.IS_DELAY.Nvl(0) == (this.IS_DELAY));
            }
            if (this.DELAY_UID != null)
            {
                condition.And(PT_ZXTS._.DELAY_UID == (this.DELAY_UID));
            }
            if (!string.IsNullOrWhiteSpace(this.DELAY_REMARK))
            {
                condition.And(PT_ZXTS._.DELAY_REMARK.Contain(this.DELAY_REMARK));
            }
            if (!string.IsNullOrWhiteSpace(this.DELAY_AIDS))
            {
                condition.And(PT_ZXTS._.DELAY_AIDS.Contain(this.DELAY_AIDS));
            }
            if (this.DELAY_TM != null)
            {
                condition.And(PT_ZXTS._.DELAY_TM == (this.DELAY_TM));
            }

            if (this.OVER_TM != null)
            {
                condition.And(PT_ZXTS._.OVER_TM == (this.OVER_TM));
            }
            if (this.DATA_TIMESTAMP != null)
            {
                condition.And(PT_ZXTS._.DATA_TIMESTAMP == (this.DATA_TIMESTAMP));
            }
            if (!string.IsNullOrWhiteSpace(this.SIGN_AIDS))
            {
                condition.And(PT_ZXTS._.SIGN_AIDS.Contain(this.SIGN_AIDS));
            }
            if (!string.IsNullOrWhiteSpace(this.DELAY_SMS))
            {
                condition.And(PT_ZXTS._.DELAY_SMS.Contain(this.DELAY_SMS));
            }
            if (!string.IsNullOrWhiteSpace(this.REVOKE_YJS))
            {
                condition.And(PT_ZXTS._.REVOKE_YJS.Contain(this.REVOKE_YJS));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_ROLE))
            {
                condition.And(PT_ZXTS._.COMPLAINT_ROLE.Contain(this.COMPLAINT_ROLE));
            }
            if (this.CREATE_UID != null)
            {
                condition.And(PT_ZXTS._.CREATE_UID == (this.CREATE_UID));
            }
            if (!string.IsNullOrWhiteSpace(this.CREATE_DEPID))
            {
                condition.And(PT_ZXTS._.CREATE_DEPID.Contain(this.CREATE_DEPID));
            }
            if (!string.IsNullOrWhiteSpace(this.COMPLAINT_CONTENT))
            {
                condition.And(PT_ZXTS._.COMPLAINT_CONTENT.Contain(this.COMPLAINT_CONTENT));
            }


            if (this.IS_OVERTIME.HasValue)
            {
                if (this.IS_OVERTIME == 1)//已过期
                {
                    condition.And(PT_ZXTS._.OVER_TM.IsNotNull() && "OVER_TM<SYSDATE");
                }
                else
                {
                    condition.And(PT_ZXTS._.OVER_TM.IsNull() || "OVER_TM>=SYSDATE");
                }
            }
            #endregion

            #region 查询条件

            if (search != null)
            {
                if (!string.IsNullOrWhiteSpace(search.KeyWord))
                {
                    condition.And(PT_ZXTS._.CODE.Contain(search.KeyWord)//投诉编号
                                  || PT_ZXTS._.COMPLAINT_DNAME.Contain(search.KeyWord)//投诉人单位
                                  || PT_ZXTS._.COMPLAINT_NAME.Contain(search.KeyWord)//投诉人
                                  || PT_ZXTS._.COMPLAINT_TITLE.Contain(search.KeyWord)//投诉标题
                                  || PT_ZXTS._.TENDER_PROJECT_NAME.Contain(search.KeyWord)//招标项目名称
                    );
                }

                if (search.BeginTime.HasValue)
                {
                    condition.And(PT_ZXTS._.CREATE_TM >= search.BeginTime);
                }

                if (search.EndTime.HasValue)
                {
                    condition.And(PT_ZXTS._.CREATE_TM <= search.EndTime);
                }
            }


            #endregion
            return condition;
        }

        #endregion

    }

    public partial class PtZxtsCountModel
    {
        [JsonProperty("label")]
        public string Label { get; set; }
        [JsonProperty("count")]
        public string Count { get; set; }
        [JsonIgnore]
        public string SearchType { get; set; }

        [JsonProperty("parameter")]
        public object Parameter => new { SearchType };


    }
}