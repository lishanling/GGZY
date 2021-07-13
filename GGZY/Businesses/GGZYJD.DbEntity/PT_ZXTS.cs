using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类PT_ZXTS。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PT_ZXTS")]
    [Serializable]
    public partial class PT_ZXTS : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _CODE;
		private string _TYPE;
		private string _STATE;
		private string _COMPLAINT_TYPE;
		private string _COMPLAINT_NAME;
		private string _COMPLAINT_CODE;
		private string _COMPLAINT_DNAME;
		private string _COMPLAINT_ADRESS;
		private string _COMPLAINT_ZW;
		private string _COMPLAINT_FAX;
		private string _COMPLAINT_PC;
		private string _COMPLAINT_CONTACT;
		private string _COMPLAINT_PHONE;
		private string _COMPLAINT_EMAIL;
		private string _COMPLAINT_CONTACT_IDCARD;
		private string _COMPLAINT_CONTACT_PHONE;
		private string _COMPLAINT_CONTACT_EMAIL;
		private string _COMPLAINT_LEGAL;
		private string _COMPLAINT_LEGAL_IDCARD;
		private string _COMPLAINT_LEGAL_PHONE;
		private decimal? _COMPLAINT_LEGAL_ISWT;
		private string _COMPLAINT_BWTR;
		private string _COMPLAINT_BWTR_IDCARD;
		private string _COMPLAINT_BWTR_BMZW;
		private string _COMPLAINT_BWTR_PHONE;
		private string _COMPLAINT_ISAGENCY;
		private string _COMPLAINT_AGENCY;
		private string _COMPLAINT_AGENCY_CODE;
		private string _COMPLAINT_AGENCY_FAX;
		private string _COMPLAINT_AGENCY_PC;
		private string _COMPLAINT_AGENCY_LXR;
		private string _COMPLAINT_AGENCY_PHONE;
		private string _COMPLAINT_AGENCY_ADRESS;
		private string _TENDER_PROJECT_CODE;
		private string _TENDER_PROJECT_NAME;
		private string _TENDER_CLASS;
		private string _COMPLAINT_SX;
		private string _COMPLAINT_TITLE;
		private string _TSS_AIDS;
		private string _YYZM_AIDS;
		private string _ZMCL_AIDS;
		private string _OTHER_AIDS;
		private string _FR_SFZ_AIDS;
		private string _WTR_SFZ_AIDS;
		private string _SQWTS_AIDS;
		private string _WTDLHT_AIDS;
		private string _AGENCY_CODE_AIDS;
		private string _AGENCY_SFZ_AIDS2;
		private string _SFZ_AIDS;
		private DateTime? _CREATE_TM;
		private string _ACCEPT_DEPID;
		private string _SIGN_STATE;
		private decimal? _SIGN_UID;
		private DateTime? _SIGN_TM;
		private string _SIGN_REMARK;
		private string _ACCEPT_STATE;
		private decimal? _ACCEPT_UID;
		private DateTime? _ACCEPT_TM;
		private string _ACCEPT_REMARK;
		private string _ACCEPT_AIDS;
		private string _SCCZWT;
		private string _ACCEPT_TZS;
		private string _HANDLE_STATE;
		private decimal? _HANDLE_UID;
		private DateTime? _HANDLE_TM;
		private string _HANDLE_JL;
		private string _HANDLE_REMARK;
		private string _HANDLE_AIDS;
		private string _HANDLE_JDS;
		private string _IS_DELAY;
		private decimal? _DELAY_UID;
		private string _DELAY_REMARK;
		private string _DELAY_AIDS;
		private DateTime? _DELAY_TM;
		private DateTime? _OVER_TM;
		private DateTime? _DATA_TIMESTAMP;
		private string _SIGN_AIDS;
		private string _DELAY_SMS;
		private string _REVOKE_YJS;
		private string _COMPLAINT_ROLE;
		private decimal? _CREATE_UID;
		private string _CREATE_DEPID;
		private string _COMPLAINT_CONTENT;

		/// <summary>
		/// ID
		/// </summary>
		public decimal? ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 投诉编号
		/// </summary>
		public string CODE
		{
			get{ return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
			}
		}
		/// <summary>
		/// 投诉类型(1线上 2线下 type=79)
		/// </summary>
		public string TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 状态（1待签收，2待受理，3不予受理，4待处理，5已处理，6申请撤诉，7不予撤诉，8同意撤诉，9撤销 type=72）
		/// </summary>
		public string STATE
		{
			get{ return _STATE; }
			set
			{
				this.OnPropertyValueChange(_.STATE, _STATE, value);
				this._STATE = value;
			}
		}
		/// <summary>
		/// 投诉人（1法人，2自然人 type=71）
		/// </summary>
		public string COMPLAINT_TYPE
		{
			get{ return _COMPLAINT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_TYPE, _COMPLAINT_TYPE, value);
				this._COMPLAINT_TYPE = value;
			}
		}
		/// <summary>
		/// 投诉人
		/// </summary>
		public string COMPLAINT_NAME
		{
			get{ return _COMPLAINT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_NAME, _COMPLAINT_NAME, value);
				this._COMPLAINT_NAME = value;
			}
		}
		/// <summary>
		/// 投诉人代码（统一社会信用代码证/身份证号码）
		/// </summary>
		public string COMPLAINT_CODE
		{
			get{ return _COMPLAINT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_CODE, _COMPLAINT_CODE, value);
				this._COMPLAINT_CODE = value;
			}
		}
		/// <summary>
		/// 投诉人_单位
		/// </summary>
		public string COMPLAINT_DNAME
		{
			get{ return _COMPLAINT_DNAME; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_DNAME, _COMPLAINT_DNAME, value);
				this._COMPLAINT_DNAME = value;
			}
		}
		/// <summary>
		/// 投诉人_单位地址
		/// </summary>
		public string COMPLAINT_ADRESS
		{
			get{ return _COMPLAINT_ADRESS; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_ADRESS, _COMPLAINT_ADRESS, value);
				this._COMPLAINT_ADRESS = value;
			}
		}
		/// <summary>
		/// 投诉人_单位职务
		/// </summary>
		public string COMPLAINT_ZW
		{
			get{ return _COMPLAINT_ZW; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_ZW, _COMPLAINT_ZW, value);
				this._COMPLAINT_ZW = value;
			}
		}
		/// <summary>
		/// 投诉人_传真
		/// </summary>
		public string COMPLAINT_FAX
		{
			get{ return _COMPLAINT_FAX; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_FAX, _COMPLAINT_FAX, value);
				this._COMPLAINT_FAX = value;
			}
		}
		/// <summary>
		/// 投诉人_邮编
		/// </summary>
		public string COMPLAINT_PC
		{
			get{ return _COMPLAINT_PC; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_PC, _COMPLAINT_PC, value);
				this._COMPLAINT_PC = value;
			}
		}
		/// <summary>
		/// 投诉人_联系人
		/// </summary>
		public string COMPLAINT_CONTACT
		{
			get{ return _COMPLAINT_CONTACT; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_CONTACT, _COMPLAINT_CONTACT, value);
				this._COMPLAINT_CONTACT = value;
			}
		}
		/// <summary>
		/// 投诉人_手机
		/// </summary>
		public string COMPLAINT_PHONE
		{
			get{ return _COMPLAINT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_PHONE, _COMPLAINT_PHONE, value);
				this._COMPLAINT_PHONE = value;
			}
		}
		/// <summary>
		/// 投诉人_邮箱
		/// </summary>
		public string COMPLAINT_EMAIL
		{
			get{ return _COMPLAINT_EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_EMAIL, _COMPLAINT_EMAIL, value);
				this._COMPLAINT_EMAIL = value;
			}
		}
		/// <summary>
		/// 投诉人_联系人身份证号码
		/// </summary>
		public string COMPLAINT_CONTACT_IDCARD
		{
			get{ return _COMPLAINT_CONTACT_IDCARD; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_CONTACT_IDCARD, _COMPLAINT_CONTACT_IDCARD, value);
				this._COMPLAINT_CONTACT_IDCARD = value;
			}
		}
		/// <summary>
		/// 投诉人_联系电话
		/// </summary>
		public string COMPLAINT_CONTACT_PHONE
		{
			get{ return _COMPLAINT_CONTACT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_CONTACT_PHONE, _COMPLAINT_CONTACT_PHONE, value);
				this._COMPLAINT_CONTACT_PHONE = value;
			}
		}
		/// <summary>
		/// 投诉人_联系人邮箱
		/// </summary>
		public string COMPLAINT_CONTACT_EMAIL
		{
			get{ return _COMPLAINT_CONTACT_EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_CONTACT_EMAIL, _COMPLAINT_CONTACT_EMAIL, value);
				this._COMPLAINT_CONTACT_EMAIL = value;
			}
		}
		/// <summary>
		/// 投诉人_法定代表人
		/// </summary>
		public string COMPLAINT_LEGAL
		{
			get{ return _COMPLAINT_LEGAL; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_LEGAL, _COMPLAINT_LEGAL, value);
				this._COMPLAINT_LEGAL = value;
			}
		}
		/// <summary>
		/// 投诉人_法定代表人身份证
		/// </summary>
		public string COMPLAINT_LEGAL_IDCARD
		{
			get{ return _COMPLAINT_LEGAL_IDCARD; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_LEGAL_IDCARD, _COMPLAINT_LEGAL_IDCARD, value);
				this._COMPLAINT_LEGAL_IDCARD = value;
			}
		}
		/// <summary>
		/// 投诉人_法定代表人手机号码
		/// </summary>
		public string COMPLAINT_LEGAL_PHONE
		{
			get{ return _COMPLAINT_LEGAL_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_LEGAL_PHONE, _COMPLAINT_LEGAL_PHONE, value);
				this._COMPLAINT_LEGAL_PHONE = value;
			}
		}
		/// <summary>
		/// 投诉人_法人是否授权委托
		/// </summary>
		public decimal? COMPLAINT_LEGAL_ISWT
		{
			get{ return _COMPLAINT_LEGAL_ISWT; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_LEGAL_ISWT, _COMPLAINT_LEGAL_ISWT, value);
				this._COMPLAINT_LEGAL_ISWT = value;
			}
		}
		/// <summary>
		/// 投诉人_被委托人姓名
		/// </summary>
		public string COMPLAINT_BWTR
		{
			get{ return _COMPLAINT_BWTR; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_BWTR, _COMPLAINT_BWTR, value);
				this._COMPLAINT_BWTR = value;
			}
		}
		/// <summary>
		/// 投诉人_被委托人身份证号
		/// </summary>
		public string COMPLAINT_BWTR_IDCARD
		{
			get{ return _COMPLAINT_BWTR_IDCARD; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_BWTR_IDCARD, _COMPLAINT_BWTR_IDCARD, value);
				this._COMPLAINT_BWTR_IDCARD = value;
			}
		}
		/// <summary>
		/// 投诉人_被委托人所在部门与职务
		/// </summary>
		public string COMPLAINT_BWTR_BMZW
		{
			get{ return _COMPLAINT_BWTR_BMZW; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_BWTR_BMZW, _COMPLAINT_BWTR_BMZW, value);
				this._COMPLAINT_BWTR_BMZW = value;
			}
		}
		/// <summary>
		/// 投诉人_被委托人手机号
		/// </summary>
		public string COMPLAINT_BWTR_PHONE
		{
			get{ return _COMPLAINT_BWTR_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_BWTR_PHONE, _COMPLAINT_BWTR_PHONE, value);
				this._COMPLAINT_BWTR_PHONE = value;
			}
		}
		/// <summary>
		/// 投诉人_是否委托代理投诉
		/// </summary>
		public string COMPLAINT_ISAGENCY
		{
			get{ return _COMPLAINT_ISAGENCY; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_ISAGENCY, _COMPLAINT_ISAGENCY, value);
				this._COMPLAINT_ISAGENCY = value;
			}
		}
		/// <summary>
		/// 投诉人_委托代理机构
		/// </summary>
		public string COMPLAINT_AGENCY
		{
			get{ return _COMPLAINT_AGENCY; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_AGENCY, _COMPLAINT_AGENCY, value);
				this._COMPLAINT_AGENCY = value;
			}
		}
		/// <summary>
		/// 投诉人_委托代理机构统一社会信用代码证
		/// </summary>
		public string COMPLAINT_AGENCY_CODE
		{
			get{ return _COMPLAINT_AGENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_AGENCY_CODE, _COMPLAINT_AGENCY_CODE, value);
				this._COMPLAINT_AGENCY_CODE = value;
			}
		}
		/// <summary>
		/// 投诉人_委托代理机构传真
		/// </summary>
		public string COMPLAINT_AGENCY_FAX
		{
			get{ return _COMPLAINT_AGENCY_FAX; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_AGENCY_FAX, _COMPLAINT_AGENCY_FAX, value);
				this._COMPLAINT_AGENCY_FAX = value;
			}
		}
		/// <summary>
		/// 投诉人_委托代理机构邮编
		/// </summary>
		public string COMPLAINT_AGENCY_PC
		{
			get{ return _COMPLAINT_AGENCY_PC; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_AGENCY_PC, _COMPLAINT_AGENCY_PC, value);
				this._COMPLAINT_AGENCY_PC = value;
			}
		}
		/// <summary>
		/// 投诉人_委托代理机构联系人
		/// </summary>
		public string COMPLAINT_AGENCY_LXR
		{
			get{ return _COMPLAINT_AGENCY_LXR; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_AGENCY_LXR, _COMPLAINT_AGENCY_LXR, value);
				this._COMPLAINT_AGENCY_LXR = value;
			}
		}
		/// <summary>
		/// 投诉人_委托代理机构手机
		/// </summary>
		public string COMPLAINT_AGENCY_PHONE
		{
			get{ return _COMPLAINT_AGENCY_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_AGENCY_PHONE, _COMPLAINT_AGENCY_PHONE, value);
				this._COMPLAINT_AGENCY_PHONE = value;
			}
		}
		/// <summary>
		/// 投诉人_委托代理机构地址
		/// </summary>
		public string COMPLAINT_AGENCY_ADRESS
		{
			get{ return _COMPLAINT_AGENCY_ADRESS; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_AGENCY_ADRESS, _COMPLAINT_AGENCY_ADRESS, value);
				this._COMPLAINT_AGENCY_ADRESS = value;
			}
		}
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get{ return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 招标项目名称
		/// </summary>
		public string TENDER_PROJECT_NAME
		{
			get{ return _TENDER_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_NAME, _TENDER_PROJECT_NAME, value);
				this._TENDER_PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 工程类型（001勘察，002设计，003施工，004监理，005设计施工一体化，006工程总承包，007项目管理 type=83）（001勘察，002设计，003施工，004监理，005设计施工一体化，006工程总承包，007项目管理 type=83）（A01规划，A02投资策划与决策，A03勘察，A04设计，A05监理，A06工程造价，A07项目管理，A09其他工程 type=85）
		/// </summary>
		public string TENDER_CLASS
		{
			get{ return _TENDER_CLASS; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_CLASS, _TENDER_CLASS, value);
				this._TENDER_CLASS = value;
			}
		}
		/// <summary>
		/// 投诉事项（1对招标文件的投诉，2对资格预审文件的投诉，3对资格预审结果的投诉，4对评标结果的投诉，5对开标过程的投诉，6其他 type=82）
		/// </summary>
		public string COMPLAINT_SX
		{
			get{ return _COMPLAINT_SX; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_SX, _COMPLAINT_SX, value);
				this._COMPLAINT_SX = value;
			}
		}
		/// <summary>
		/// 投诉标题
		/// </summary>
		public string COMPLAINT_TITLE
		{
			get{ return _COMPLAINT_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_TITLE, _COMPLAINT_TITLE, value);
				this._COMPLAINT_TITLE = value;
			}
		}
		/// <summary>
		/// 附件_投诉书
		/// </summary>
		public string TSS_AIDS
		{
			get{ return _TSS_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.TSS_AIDS, _TSS_AIDS, value);
				this._TSS_AIDS = value;
			}
		}
		/// <summary>
		/// 附件_异议证明文件
		/// </summary>
		public string YYZM_AIDS
		{
			get{ return _YYZM_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.YYZM_AIDS, _YYZM_AIDS, value);
				this._YYZM_AIDS = value;
			}
		}
		/// <summary>
		/// 附件_有效线索和相关证明材料
		/// </summary>
		public string ZMCL_AIDS
		{
			get{ return _ZMCL_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.ZMCL_AIDS, _ZMCL_AIDS, value);
				this._ZMCL_AIDS = value;
			}
		}
		/// <summary>
		/// 附件_其他材料
		/// </summary>
		public string OTHER_AIDS
		{
			get{ return _OTHER_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_AIDS, _OTHER_AIDS, value);
				this._OTHER_AIDS = value;
			}
		}
		/// <summary>
		/// 附件_法人身份证扫描件
		/// </summary>
		public string FR_SFZ_AIDS
		{
			get{ return _FR_SFZ_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.FR_SFZ_AIDS, _FR_SFZ_AIDS, value);
				this._FR_SFZ_AIDS = value;
			}
		}
		/// <summary>
		/// 附件_被授权委托人身份扫描件
		/// </summary>
		public string WTR_SFZ_AIDS
		{
			get{ return _WTR_SFZ_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.WTR_SFZ_AIDS, _WTR_SFZ_AIDS, value);
				this._WTR_SFZ_AIDS = value;
			}
		}
		/// <summary>
		/// 附件_授权委托书
		/// </summary>
		public string SQWTS_AIDS
		{
			get{ return _SQWTS_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.SQWTS_AIDS, _SQWTS_AIDS, value);
				this._SQWTS_AIDS = value;
			}
		}
		/// <summary>
		/// 附件_委托代理合同
		/// </summary>
		public string WTDLHT_AIDS
		{
			get{ return _WTDLHT_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.WTDLHT_AIDS, _WTDLHT_AIDS, value);
				this._WTDLHT_AIDS = value;
			}
		}
		/// <summary>
		/// 附件_委托代理机构统一社会信用代码证
		/// </summary>
		public string AGENCY_CODE_AIDS
		{
			get{ return _AGENCY_CODE_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.AGENCY_CODE_AIDS, _AGENCY_CODE_AIDS, value);
				this._AGENCY_CODE_AIDS = value;
			}
		}
		/// <summary>
		/// 附件_委托代理联系人身份证扫描件
		/// </summary>
		public string AGENCY_SFZ_AIDS2
		{
			get{ return _AGENCY_SFZ_AIDS2; }
			set
			{
				this.OnPropertyValueChange(_.AGENCY_SFZ_AIDS2, _AGENCY_SFZ_AIDS2, value);
				this._AGENCY_SFZ_AIDS2 = value;
			}
		}
		/// <summary>
		/// 附件_自然人身份证扫描件
		/// </summary>
		public string SFZ_AIDS
		{
			get{ return _SFZ_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.SFZ_AIDS, _SFZ_AIDS, value);
				this._SFZ_AIDS = value;
			}
		}
		/// <summary>
		/// 填报日期
		/// </summary>
		public DateTime? CREATE_TM
		{
			get{ return _CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TM, _CREATE_TM, value);
				this._CREATE_TM = value;
			}
		}
		/// <summary>
		/// 受理部门/线下投诉部门
		/// </summary>
		public string ACCEPT_DEPID
		{
			get{ return _ACCEPT_DEPID; }
			set
			{
				this.OnPropertyValueChange(_.ACCEPT_DEPID, _ACCEPT_DEPID, value);
				this._ACCEPT_DEPID = value;
			}
		}
		/// <summary>
		/// 签收状态（1待签收2已签收3不予受理type=80）
		/// </summary>
		public string SIGN_STATE
		{
			get{ return _SIGN_STATE; }
			set
			{
				this.OnPropertyValueChange(_.SIGN_STATE, _SIGN_STATE, value);
				this._SIGN_STATE = value;
			}
		}
		/// <summary>
		/// 签收人员
		/// </summary>
		public decimal? SIGN_UID
		{
			get{ return _SIGN_UID; }
			set
			{
				this.OnPropertyValueChange(_.SIGN_UID, _SIGN_UID, value);
				this._SIGN_UID = value;
			}
		}
		/// <summary>
		/// 签收时间
		/// </summary>
		public DateTime? SIGN_TM
		{
			get{ return _SIGN_TM; }
			set
			{
				this.OnPropertyValueChange(_.SIGN_TM, _SIGN_TM, value);
				this._SIGN_TM = value;
			}
		}
		/// <summary>
		/// 签收意见
		/// </summary>
		public string SIGN_REMARK
		{
			get{ return _SIGN_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.SIGN_REMARK, _SIGN_REMARK, value);
				this._SIGN_REMARK = value;
			}
		}
		/// <summary>
		/// 受理状态（1待受理2已受理3不予受理type=73）
		/// </summary>
		public string ACCEPT_STATE
		{
			get{ return _ACCEPT_STATE; }
			set
			{
				this.OnPropertyValueChange(_.ACCEPT_STATE, _ACCEPT_STATE, value);
				this._ACCEPT_STATE = value;
			}
		}
		/// <summary>
		/// 受理人员
		/// </summary>
		public decimal? ACCEPT_UID
		{
			get{ return _ACCEPT_UID; }
			set
			{
				this.OnPropertyValueChange(_.ACCEPT_UID, _ACCEPT_UID, value);
				this._ACCEPT_UID = value;
			}
		}
		/// <summary>
		/// 受理时间
		/// </summary>
		public DateTime? ACCEPT_TM
		{
			get{ return _ACCEPT_TM; }
			set
			{
				this.OnPropertyValueChange(_.ACCEPT_TM, _ACCEPT_TM, value);
				this._ACCEPT_TM = value;
			}
		}
		/// <summary>
		/// 受理意见
		/// </summary>
		public string ACCEPT_REMARK
		{
			get{ return _ACCEPT_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.ACCEPT_REMARK, _ACCEPT_REMARK, value);
				this._ACCEPT_REMARK = value;
			}
		}
		/// <summary>
		/// 受理相关附件
		/// </summary>
		public string ACCEPT_AIDS
		{
			get{ return _ACCEPT_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.ACCEPT_AIDS, _ACCEPT_AIDS, value);
				this._ACCEPT_AIDS = value;
			}
		}
		/// <summary>
		/// 审查存在问题
		/// </summary>
		public string SCCZWT
		{
			get{ return _SCCZWT; }
			set
			{
				this.OnPropertyValueChange(_.SCCZWT, _SCCZWT, value);
				this._SCCZWT = value;
			}
		}
		/// <summary>
		/// 不予受理通知书
		/// </summary>
		public string ACCEPT_TZS
		{
			get{ return _ACCEPT_TZS; }
			set
			{
				this.OnPropertyValueChange(_.ACCEPT_TZS, _ACCEPT_TZS, value);
				this._ACCEPT_TZS = value;
			}
		}
		/// <summary>
		/// 处理状态(1待处理2已处理type=74)
		/// </summary>
		public string HANDLE_STATE
		{
			get{ return _HANDLE_STATE; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_STATE, _HANDLE_STATE, value);
				this._HANDLE_STATE = value;
			}
		}
		/// <summary>
		/// 处理人员
		/// </summary>
		public decimal? HANDLE_UID
		{
			get{ return _HANDLE_UID; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_UID, _HANDLE_UID, value);
				this._HANDLE_UID = value;
			}
		}
		/// <summary>
		/// 处理时间
		/// </summary>
		public DateTime? HANDLE_TM
		{
			get{ return _HANDLE_TM; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_TM, _HANDLE_TM, value);
				this._HANDLE_TM = value;
			}
		}
		/// <summary>
		/// 处理结论（1投诉内容属实，2投诉内容部分属实，3投诉内容不属实 type=81）
		/// </summary>
		public string HANDLE_JL
		{
			get{ return _HANDLE_JL; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_JL, _HANDLE_JL, value);
				this._HANDLE_JL = value;
			}
		}
		/// <summary>
		/// 处理意见
		/// </summary>
		public string HANDLE_REMARK
		{
			get{ return _HANDLE_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_REMARK, _HANDLE_REMARK, value);
				this._HANDLE_REMARK = value;
			}
		}
		/// <summary>
		/// 处理相关附件
		/// </summary>
		public string HANDLE_AIDS
		{
			get{ return _HANDLE_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_AIDS, _HANDLE_AIDS, value);
				this._HANDLE_AIDS = value;
			}
		}
		/// <summary>
		/// 处理决定书
		/// </summary>
		public string HANDLE_JDS
		{
			get{ return _HANDLE_JDS; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_JDS, _HANDLE_JDS, value);
				this._HANDLE_JDS = value;
			}
		}
		/// <summary>
		/// 是否延期
		/// </summary>
		public string IS_DELAY
		{
			get{ return _IS_DELAY; }
			set
			{
				this.OnPropertyValueChange(_.IS_DELAY, _IS_DELAY, value);
				this._IS_DELAY = value;
			}
		}
		/// <summary>
		/// 延期时间
		/// </summary>
		public decimal? DELAY_UID
		{
			get{ return _DELAY_UID; }
			set
			{
				this.OnPropertyValueChange(_.DELAY_UID, _DELAY_UID, value);
				this._DELAY_UID = value;
			}
		}
		/// <summary>
		/// 延期说明
		/// </summary>
		public string DELAY_REMARK
		{
			get{ return _DELAY_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.DELAY_REMARK, _DELAY_REMARK, value);
				this._DELAY_REMARK = value;
			}
		}
		/// <summary>
		/// 延期-相关附件
		/// </summary>
		public string DELAY_AIDS
		{
			get{ return _DELAY_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.DELAY_AIDS, _DELAY_AIDS, value);
				this._DELAY_AIDS = value;
			}
		}
		/// <summary>
		/// 延期时间
		/// </summary>
		public DateTime? DELAY_TM
		{
			get{ return _DELAY_TM; }
			set
			{
				this.OnPropertyValueChange(_.DELAY_TM, _DELAY_TM, value);
				this._DELAY_TM = value;
			}
		}
		/// <summary>
		/// 超时时间(最后处理时间)
		/// </summary>
		public DateTime? OVER_TM
		{
			get{ return _OVER_TM; }
			set
			{
				this.OnPropertyValueChange(_.OVER_TM, _OVER_TM, value);
				this._OVER_TM = value;
			}
		}
		/// <summary>
		/// 数据时间戳
		/// </summary>
		public DateTime? DATA_TIMESTAMP
		{
			get{ return _DATA_TIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATA_TIMESTAMP, _DATA_TIMESTAMP, value);
				this._DATA_TIMESTAMP = value;
			}
		}
		/// <summary>
		/// 签收相关附件(不予受理时添加)
		/// </summary>
		public string SIGN_AIDS
		{
			get{ return _SIGN_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.SIGN_AIDS, _SIGN_AIDS, value);
				this._SIGN_AIDS = value;
			}
		}
		/// <summary>
		/// 延期说明书
		/// </summary>
		public string DELAY_SMS
		{
			get{ return _DELAY_SMS; }
			set
			{
				this.OnPropertyValueChange(_.DELAY_SMS, _DELAY_SMS, value);
				this._DELAY_SMS = value;
			}
		}
		/// <summary>
		/// 投诉撤回意见书
		/// </summary>
		public string REVOKE_YJS
		{
			get{ return _REVOKE_YJS; }
			set
			{
				this.OnPropertyValueChange(_.REVOKE_YJS, _REVOKE_YJS, value);
				this._REVOKE_YJS = value;
			}
		}
		/// <summary>
		/// 投诉人_角色
		/// </summary>
		public string COMPLAINT_ROLE
		{
			get{ return _COMPLAINT_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_ROLE, _COMPLAINT_ROLE, value);
				this._COMPLAINT_ROLE = value;
			}
		}
		/// <summary>
		/// 投诉创建人（线下投诉）
		/// </summary>
		public decimal? CREATE_UID
		{
			get{ return _CREATE_UID; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_UID, _CREATE_UID, value);
				this._CREATE_UID = value;
			}
		}
		/// <summary>
		/// 投诉部门（线下投诉）
		/// </summary>
		public string CREATE_DEPID
		{
			get{ return _CREATE_DEPID; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_DEPID, _CREATE_DEPID, value);
				this._CREATE_DEPID = value;
			}
		}
		/// <summary>
		/// 投诉内容
		/// </summary>
		public string COMPLAINT_CONTENT
		{
			get{ return _COMPLAINT_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_CONTENT, _COMPLAINT_CONTENT, value);
				this._COMPLAINT_CONTENT = value;
			}
		}
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.CODE,
				_.TYPE,
				_.STATE,
				_.COMPLAINT_TYPE,
				_.COMPLAINT_NAME,
				_.COMPLAINT_CODE,
				_.COMPLAINT_DNAME,
				_.COMPLAINT_ADRESS,
				_.COMPLAINT_ZW,
				_.COMPLAINT_FAX,
				_.COMPLAINT_PC,
				_.COMPLAINT_CONTACT,
				_.COMPLAINT_PHONE,
				_.COMPLAINT_EMAIL,
				_.COMPLAINT_CONTACT_IDCARD,
				_.COMPLAINT_CONTACT_PHONE,
				_.COMPLAINT_CONTACT_EMAIL,
				_.COMPLAINT_LEGAL,
				_.COMPLAINT_LEGAL_IDCARD,
				_.COMPLAINT_LEGAL_PHONE,
				_.COMPLAINT_LEGAL_ISWT,
				_.COMPLAINT_BWTR,
				_.COMPLAINT_BWTR_IDCARD,
				_.COMPLAINT_BWTR_BMZW,
				_.COMPLAINT_BWTR_PHONE,
				_.COMPLAINT_ISAGENCY,
				_.COMPLAINT_AGENCY,
				_.COMPLAINT_AGENCY_CODE,
				_.COMPLAINT_AGENCY_FAX,
				_.COMPLAINT_AGENCY_PC,
				_.COMPLAINT_AGENCY_LXR,
				_.COMPLAINT_AGENCY_PHONE,
				_.COMPLAINT_AGENCY_ADRESS,
				_.TENDER_PROJECT_CODE,
				_.TENDER_PROJECT_NAME,
				_.TENDER_CLASS,
				_.COMPLAINT_SX,
				_.COMPLAINT_TITLE,
				_.TSS_AIDS,
				_.YYZM_AIDS,
				_.ZMCL_AIDS,
				_.OTHER_AIDS,
				_.FR_SFZ_AIDS,
				_.WTR_SFZ_AIDS,
				_.SQWTS_AIDS,
				_.WTDLHT_AIDS,
				_.AGENCY_CODE_AIDS,
				_.AGENCY_SFZ_AIDS2,
				_.SFZ_AIDS,
				_.CREATE_TM,
				_.ACCEPT_DEPID,
				_.SIGN_STATE,
				_.SIGN_UID,
				_.SIGN_TM,
				_.SIGN_REMARK,
				_.ACCEPT_STATE,
				_.ACCEPT_UID,
				_.ACCEPT_TM,
				_.ACCEPT_REMARK,
				_.ACCEPT_AIDS,
				_.SCCZWT,
				_.ACCEPT_TZS,
				_.HANDLE_STATE,
				_.HANDLE_UID,
				_.HANDLE_TM,
				_.HANDLE_JL,
				_.HANDLE_REMARK,
				_.HANDLE_AIDS,
				_.HANDLE_JDS,
				_.IS_DELAY,
				_.DELAY_UID,
				_.DELAY_REMARK,
				_.DELAY_AIDS,
				_.DELAY_TM,
				_.OVER_TM,
				_.DATA_TIMESTAMP,
				_.SIGN_AIDS,
				_.DELAY_SMS,
				_.REVOKE_YJS,
				_.COMPLAINT_ROLE,
				_.CREATE_UID,
				_.CREATE_DEPID,
				_.COMPLAINT_CONTENT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._CODE,
				this._TYPE,
				this._STATE,
				this._COMPLAINT_TYPE,
				this._COMPLAINT_NAME,
				this._COMPLAINT_CODE,
				this._COMPLAINT_DNAME,
				this._COMPLAINT_ADRESS,
				this._COMPLAINT_ZW,
				this._COMPLAINT_FAX,
				this._COMPLAINT_PC,
				this._COMPLAINT_CONTACT,
				this._COMPLAINT_PHONE,
				this._COMPLAINT_EMAIL,
				this._COMPLAINT_CONTACT_IDCARD,
				this._COMPLAINT_CONTACT_PHONE,
				this._COMPLAINT_CONTACT_EMAIL,
				this._COMPLAINT_LEGAL,
				this._COMPLAINT_LEGAL_IDCARD,
				this._COMPLAINT_LEGAL_PHONE,
				this._COMPLAINT_LEGAL_ISWT,
				this._COMPLAINT_BWTR,
				this._COMPLAINT_BWTR_IDCARD,
				this._COMPLAINT_BWTR_BMZW,
				this._COMPLAINT_BWTR_PHONE,
				this._COMPLAINT_ISAGENCY,
				this._COMPLAINT_AGENCY,
				this._COMPLAINT_AGENCY_CODE,
				this._COMPLAINT_AGENCY_FAX,
				this._COMPLAINT_AGENCY_PC,
				this._COMPLAINT_AGENCY_LXR,
				this._COMPLAINT_AGENCY_PHONE,
				this._COMPLAINT_AGENCY_ADRESS,
				this._TENDER_PROJECT_CODE,
				this._TENDER_PROJECT_NAME,
				this._TENDER_CLASS,
				this._COMPLAINT_SX,
				this._COMPLAINT_TITLE,
				this._TSS_AIDS,
				this._YYZM_AIDS,
				this._ZMCL_AIDS,
				this._OTHER_AIDS,
				this._FR_SFZ_AIDS,
				this._WTR_SFZ_AIDS,
				this._SQWTS_AIDS,
				this._WTDLHT_AIDS,
				this._AGENCY_CODE_AIDS,
				this._AGENCY_SFZ_AIDS2,
				this._SFZ_AIDS,
				this._CREATE_TM,
				this._ACCEPT_DEPID,
				this._SIGN_STATE,
				this._SIGN_UID,
				this._SIGN_TM,
				this._SIGN_REMARK,
				this._ACCEPT_STATE,
				this._ACCEPT_UID,
				this._ACCEPT_TM,
				this._ACCEPT_REMARK,
				this._ACCEPT_AIDS,
				this._SCCZWT,
				this._ACCEPT_TZS,
				this._HANDLE_STATE,
				this._HANDLE_UID,
				this._HANDLE_TM,
				this._HANDLE_JL,
				this._HANDLE_REMARK,
				this._HANDLE_AIDS,
				this._HANDLE_JDS,
				this._IS_DELAY,
				this._DELAY_UID,
				this._DELAY_REMARK,
				this._DELAY_AIDS,
				this._DELAY_TM,
				this._OVER_TM,
				this._DATA_TIMESTAMP,
				this._SIGN_AIDS,
				this._DELAY_SMS,
				this._REVOKE_YJS,
				this._COMPLAINT_ROLE,
				this._CREATE_UID,
				this._CREATE_DEPID,
				this._COMPLAINT_CONTENT,
			};
        }
        #endregion

		#region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*", "PT_ZXTS");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PT_ZXTS", "ID");
            /// <summary>
			/// 投诉编号
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "PT_ZXTS", "投诉编号");
            /// <summary>
			/// 投诉类型(1线上 2线下 type=79)
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "PT_ZXTS", "投诉类型(1线上 2线下 type=79)");
            /// <summary>
			/// 状态（1待签收，2待受理，3不予受理，4待处理，5已处理，6申请撤诉，7不予撤诉，8同意撤诉，9撤销 type=72）
			/// </summary>
			public readonly static Field STATE = new Field("STATE", "PT_ZXTS", "状态（1待签收，2待受理，3不予受理，4待处理，5已处理，6申请撤诉，7不予撤诉，8同意撤诉，9撤销 type=72）");
            /// <summary>
			/// 投诉人（1法人，2自然人 type=71）
			/// </summary>
			public readonly static Field COMPLAINT_TYPE = new Field("COMPLAINT_TYPE", "PT_ZXTS", "投诉人（1法人，2自然人 type=71）");
            /// <summary>
			/// 投诉人
			/// </summary>
			public readonly static Field COMPLAINT_NAME = new Field("COMPLAINT_NAME", "PT_ZXTS", "投诉人");
            /// <summary>
			/// 投诉人代码（统一社会信用代码证/身份证号码）
			/// </summary>
			public readonly static Field COMPLAINT_CODE = new Field("COMPLAINT_CODE", "PT_ZXTS", "投诉人代码（统一社会信用代码证/身份证号码）");
            /// <summary>
			/// 投诉人_单位
			/// </summary>
			public readonly static Field COMPLAINT_DNAME = new Field("COMPLAINT_DNAME", "PT_ZXTS", "投诉人_单位");
            /// <summary>
			/// 投诉人_单位地址
			/// </summary>
			public readonly static Field COMPLAINT_ADRESS = new Field("COMPLAINT_ADRESS", "PT_ZXTS", "投诉人_单位地址");
            /// <summary>
			/// 投诉人_单位职务
			/// </summary>
			public readonly static Field COMPLAINT_ZW = new Field("COMPLAINT_ZW", "PT_ZXTS", "投诉人_单位职务");
            /// <summary>
			/// 投诉人_传真
			/// </summary>
			public readonly static Field COMPLAINT_FAX = new Field("COMPLAINT_FAX", "PT_ZXTS", "投诉人_传真");
            /// <summary>
			/// 投诉人_邮编
			/// </summary>
			public readonly static Field COMPLAINT_PC = new Field("COMPLAINT_PC", "PT_ZXTS", "投诉人_邮编");
            /// <summary>
			/// 投诉人_联系人
			/// </summary>
			public readonly static Field COMPLAINT_CONTACT = new Field("COMPLAINT_CONTACT", "PT_ZXTS", "投诉人_联系人");
            /// <summary>
			/// 投诉人_手机
			/// </summary>
			public readonly static Field COMPLAINT_PHONE = new Field("COMPLAINT_PHONE", "PT_ZXTS", "投诉人_手机");
            /// <summary>
			/// 投诉人_邮箱
			/// </summary>
			public readonly static Field COMPLAINT_EMAIL = new Field("COMPLAINT_EMAIL", "PT_ZXTS", "投诉人_邮箱");
            /// <summary>
			/// 投诉人_联系人身份证号码
			/// </summary>
			public readonly static Field COMPLAINT_CONTACT_IDCARD = new Field("COMPLAINT_CONTACT_IDCARD", "PT_ZXTS", "投诉人_联系人身份证号码");
            /// <summary>
			/// 投诉人_联系电话
			/// </summary>
			public readonly static Field COMPLAINT_CONTACT_PHONE = new Field("COMPLAINT_CONTACT_PHONE", "PT_ZXTS", "投诉人_联系电话");
            /// <summary>
			/// 投诉人_联系人邮箱
			/// </summary>
			public readonly static Field COMPLAINT_CONTACT_EMAIL = new Field("COMPLAINT_CONTACT_EMAIL", "PT_ZXTS", "投诉人_联系人邮箱");
            /// <summary>
			/// 投诉人_法定代表人
			/// </summary>
			public readonly static Field COMPLAINT_LEGAL = new Field("COMPLAINT_LEGAL", "PT_ZXTS", "投诉人_法定代表人");
            /// <summary>
			/// 投诉人_法定代表人身份证
			/// </summary>
			public readonly static Field COMPLAINT_LEGAL_IDCARD = new Field("COMPLAINT_LEGAL_IDCARD", "PT_ZXTS", "投诉人_法定代表人身份证");
            /// <summary>
			/// 投诉人_法定代表人手机号码
			/// </summary>
			public readonly static Field COMPLAINT_LEGAL_PHONE = new Field("COMPLAINT_LEGAL_PHONE", "PT_ZXTS", "投诉人_法定代表人手机号码");
            /// <summary>
			/// 投诉人_法人是否授权委托
			/// </summary>
			public readonly static Field COMPLAINT_LEGAL_ISWT = new Field("COMPLAINT_LEGAL_ISWT", "PT_ZXTS", "投诉人_法人是否授权委托");
            /// <summary>
			/// 投诉人_被委托人姓名
			/// </summary>
			public readonly static Field COMPLAINT_BWTR = new Field("COMPLAINT_BWTR", "PT_ZXTS", "投诉人_被委托人姓名");
            /// <summary>
			/// 投诉人_被委托人身份证号
			/// </summary>
			public readonly static Field COMPLAINT_BWTR_IDCARD = new Field("COMPLAINT_BWTR_IDCARD", "PT_ZXTS", "投诉人_被委托人身份证号");
            /// <summary>
			/// 投诉人_被委托人所在部门与职务
			/// </summary>
			public readonly static Field COMPLAINT_BWTR_BMZW = new Field("COMPLAINT_BWTR_BMZW", "PT_ZXTS", "投诉人_被委托人所在部门与职务");
            /// <summary>
			/// 投诉人_被委托人手机号
			/// </summary>
			public readonly static Field COMPLAINT_BWTR_PHONE = new Field("COMPLAINT_BWTR_PHONE", "PT_ZXTS", "投诉人_被委托人手机号");
            /// <summary>
			/// 投诉人_是否委托代理投诉
			/// </summary>
			public readonly static Field COMPLAINT_ISAGENCY = new Field("COMPLAINT_ISAGENCY", "PT_ZXTS", "投诉人_是否委托代理投诉");
            /// <summary>
			/// 投诉人_委托代理机构
			/// </summary>
			public readonly static Field COMPLAINT_AGENCY = new Field("COMPLAINT_AGENCY", "PT_ZXTS", "投诉人_委托代理机构");
            /// <summary>
			/// 投诉人_委托代理机构统一社会信用代码证
			/// </summary>
			public readonly static Field COMPLAINT_AGENCY_CODE = new Field("COMPLAINT_AGENCY_CODE", "PT_ZXTS", "投诉人_委托代理机构统一社会信用代码证");
            /// <summary>
			/// 投诉人_委托代理机构传真
			/// </summary>
			public readonly static Field COMPLAINT_AGENCY_FAX = new Field("COMPLAINT_AGENCY_FAX", "PT_ZXTS", "投诉人_委托代理机构传真");
            /// <summary>
			/// 投诉人_委托代理机构邮编
			/// </summary>
			public readonly static Field COMPLAINT_AGENCY_PC = new Field("COMPLAINT_AGENCY_PC", "PT_ZXTS", "投诉人_委托代理机构邮编");
            /// <summary>
			/// 投诉人_委托代理机构联系人
			/// </summary>
			public readonly static Field COMPLAINT_AGENCY_LXR = new Field("COMPLAINT_AGENCY_LXR", "PT_ZXTS", "投诉人_委托代理机构联系人");
            /// <summary>
			/// 投诉人_委托代理机构手机
			/// </summary>
			public readonly static Field COMPLAINT_AGENCY_PHONE = new Field("COMPLAINT_AGENCY_PHONE", "PT_ZXTS", "投诉人_委托代理机构手机");
            /// <summary>
			/// 投诉人_委托代理机构地址
			/// </summary>
			public readonly static Field COMPLAINT_AGENCY_ADRESS = new Field("COMPLAINT_AGENCY_ADRESS", "PT_ZXTS", "投诉人_委托代理机构地址");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "PT_ZXTS", "招标项目编号");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "PT_ZXTS", "招标项目名称");
            /// <summary>
			/// 工程类型（001勘察，002设计，003施工，004监理，005设计施工一体化，006工程总承包，007项目管理 type=83）（001勘察，002设计，003施工，004监理，005设计施工一体化，006工程总承包，007项目管理 type=83）（A01规划，A02投资策划与决策，A03勘察，A04设计，A05监理，A06工程造价，A07项目管理，A09其他工程 type=85）
			/// </summary>
			public readonly static Field TENDER_CLASS = new Field("TENDER_CLASS", "PT_ZXTS", "工程类型（001勘察，002设计，003施工，004监理，005设计施工一体化，006工程总承包，007项目管理 type=83）（001勘察，002设计，003施工，004监理，005设计施工一体化，006工程总承包，007项目管理 type=83）（A01规划，A02投资策划与决策，A03勘察，A04设计，A05监理，A06工程造价，A07项目管理，A09其他工程 type=85）");
            /// <summary>
			/// 投诉事项（1对招标文件的投诉，2对资格预审文件的投诉，3对资格预审结果的投诉，4对评标结果的投诉，5对开标过程的投诉，6其他 type=82）
			/// </summary>
			public readonly static Field COMPLAINT_SX = new Field("COMPLAINT_SX", "PT_ZXTS", "投诉事项（1对招标文件的投诉，2对资格预审文件的投诉，3对资格预审结果的投诉，4对评标结果的投诉，5对开标过程的投诉，6其他 type=82）");
            /// <summary>
			/// 投诉标题
			/// </summary>
			public readonly static Field COMPLAINT_TITLE = new Field("COMPLAINT_TITLE", "PT_ZXTS", "投诉标题");
            /// <summary>
			/// 附件_投诉书
			/// </summary>
			public readonly static Field TSS_AIDS = new Field("TSS_AIDS", "PT_ZXTS", "附件_投诉书");
            /// <summary>
			/// 附件_异议证明文件
			/// </summary>
			public readonly static Field YYZM_AIDS = new Field("YYZM_AIDS", "PT_ZXTS", "附件_异议证明文件");
            /// <summary>
			/// 附件_有效线索和相关证明材料
			/// </summary>
			public readonly static Field ZMCL_AIDS = new Field("ZMCL_AIDS", "PT_ZXTS", "附件_有效线索和相关证明材料");
            /// <summary>
			/// 附件_其他材料
			/// </summary>
			public readonly static Field OTHER_AIDS = new Field("OTHER_AIDS", "PT_ZXTS", "附件_其他材料");
            /// <summary>
			/// 附件_法人身份证扫描件
			/// </summary>
			public readonly static Field FR_SFZ_AIDS = new Field("FR_SFZ_AIDS", "PT_ZXTS", "附件_法人身份证扫描件");
            /// <summary>
			/// 附件_被授权委托人身份扫描件
			/// </summary>
			public readonly static Field WTR_SFZ_AIDS = new Field("WTR_SFZ_AIDS", "PT_ZXTS", "附件_被授权委托人身份扫描件");
            /// <summary>
			/// 附件_授权委托书
			/// </summary>
			public readonly static Field SQWTS_AIDS = new Field("SQWTS_AIDS", "PT_ZXTS", "附件_授权委托书");
            /// <summary>
			/// 附件_委托代理合同
			/// </summary>
			public readonly static Field WTDLHT_AIDS = new Field("WTDLHT_AIDS", "PT_ZXTS", "附件_委托代理合同");
            /// <summary>
			/// 附件_委托代理机构统一社会信用代码证
			/// </summary>
			public readonly static Field AGENCY_CODE_AIDS = new Field("AGENCY_CODE_AIDS", "PT_ZXTS", "附件_委托代理机构统一社会信用代码证");
            /// <summary>
			/// 附件_委托代理联系人身份证扫描件
			/// </summary>
			public readonly static Field AGENCY_SFZ_AIDS2 = new Field("AGENCY_SFZ_AIDS2", "PT_ZXTS", "附件_委托代理联系人身份证扫描件");
            /// <summary>
			/// 附件_自然人身份证扫描件
			/// </summary>
			public readonly static Field SFZ_AIDS = new Field("SFZ_AIDS", "PT_ZXTS", "附件_自然人身份证扫描件");
            /// <summary>
			/// 填报日期
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "PT_ZXTS", "填报日期");
            /// <summary>
			/// 受理部门/线下投诉部门
			/// </summary>
			public readonly static Field ACCEPT_DEPID = new Field("ACCEPT_DEPID", "PT_ZXTS", "受理部门/线下投诉部门");
            /// <summary>
			/// 签收状态（1待签收2已签收3不予受理type=80）
			/// </summary>
			public readonly static Field SIGN_STATE = new Field("SIGN_STATE", "PT_ZXTS", "签收状态（1待签收2已签收3不予受理type=80）");
            /// <summary>
			/// 签收人员
			/// </summary>
			public readonly static Field SIGN_UID = new Field("SIGN_UID", "PT_ZXTS", "签收人员");
            /// <summary>
			/// 签收时间
			/// </summary>
			public readonly static Field SIGN_TM = new Field("SIGN_TM", "PT_ZXTS", "签收时间");
            /// <summary>
			/// 签收意见
			/// </summary>
			public readonly static Field SIGN_REMARK = new Field("SIGN_REMARK", "PT_ZXTS", "签收意见");
            /// <summary>
			/// 受理状态（1待受理2已受理3不予受理type=73）
			/// </summary>
			public readonly static Field ACCEPT_STATE = new Field("ACCEPT_STATE", "PT_ZXTS", "受理状态（1待受理2已受理3不予受理type=73）");
            /// <summary>
			/// 受理人员
			/// </summary>
			public readonly static Field ACCEPT_UID = new Field("ACCEPT_UID", "PT_ZXTS", "受理人员");
            /// <summary>
			/// 受理时间
			/// </summary>
			public readonly static Field ACCEPT_TM = new Field("ACCEPT_TM", "PT_ZXTS", "受理时间");
            /// <summary>
			/// 受理意见
			/// </summary>
			public readonly static Field ACCEPT_REMARK = new Field("ACCEPT_REMARK", "PT_ZXTS", "受理意见");
            /// <summary>
			/// 受理相关附件
			/// </summary>
			public readonly static Field ACCEPT_AIDS = new Field("ACCEPT_AIDS", "PT_ZXTS", "受理相关附件");
            /// <summary>
			/// 审查存在问题
			/// </summary>
			public readonly static Field SCCZWT = new Field("SCCZWT", "PT_ZXTS", "审查存在问题");
            /// <summary>
			/// 不予受理通知书
			/// </summary>
			public readonly static Field ACCEPT_TZS = new Field("ACCEPT_TZS", "PT_ZXTS", "不予受理通知书");
            /// <summary>
			/// 处理状态(1待处理2已处理type=74)
			/// </summary>
			public readonly static Field HANDLE_STATE = new Field("HANDLE_STATE", "PT_ZXTS", "处理状态(1待处理2已处理type=74)");
            /// <summary>
			/// 处理人员
			/// </summary>
			public readonly static Field HANDLE_UID = new Field("HANDLE_UID", "PT_ZXTS", "处理人员");
            /// <summary>
			/// 处理时间
			/// </summary>
			public readonly static Field HANDLE_TM = new Field("HANDLE_TM", "PT_ZXTS", "处理时间");
            /// <summary>
			/// 处理结论（1投诉内容属实，2投诉内容部分属实，3投诉内容不属实 type=81）
			/// </summary>
			public readonly static Field HANDLE_JL = new Field("HANDLE_JL", "PT_ZXTS", "处理结论（1投诉内容属实，2投诉内容部分属实，3投诉内容不属实 type=81）");
            /// <summary>
			/// 处理意见
			/// </summary>
			public readonly static Field HANDLE_REMARK = new Field("HANDLE_REMARK", "PT_ZXTS", "处理意见");
            /// <summary>
			/// 处理相关附件
			/// </summary>
			public readonly static Field HANDLE_AIDS = new Field("HANDLE_AIDS", "PT_ZXTS", "处理相关附件");
            /// <summary>
			/// 处理决定书
			/// </summary>
			public readonly static Field HANDLE_JDS = new Field("HANDLE_JDS", "PT_ZXTS", "处理决定书");
            /// <summary>
			/// 是否延期
			/// </summary>
			public readonly static Field IS_DELAY = new Field("IS_DELAY", "PT_ZXTS", "是否延期");
            /// <summary>
			/// 延期时间
			/// </summary>
			public readonly static Field DELAY_UID = new Field("DELAY_UID", "PT_ZXTS", "延期时间");
            /// <summary>
			/// 延期说明
			/// </summary>
			public readonly static Field DELAY_REMARK = new Field("DELAY_REMARK", "PT_ZXTS", "延期说明");
            /// <summary>
			/// 延期-相关附件
			/// </summary>
			public readonly static Field DELAY_AIDS = new Field("DELAY_AIDS", "PT_ZXTS", "延期-相关附件");
            /// <summary>
			/// 延期时间
			/// </summary>
			public readonly static Field DELAY_TM = new Field("DELAY_TM", "PT_ZXTS", "延期时间");
            /// <summary>
			/// 超时时间(最后处理时间)
			/// </summary>
			public readonly static Field OVER_TM = new Field("OVER_TM", "PT_ZXTS", "超时时间(最后处理时间)");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "PT_ZXTS", "数据时间戳");
            /// <summary>
			/// 签收相关附件(不予受理时添加)
			/// </summary>
			public readonly static Field SIGN_AIDS = new Field("SIGN_AIDS", "PT_ZXTS", "签收相关附件(不予受理时添加)");
            /// <summary>
			/// 延期说明书
			/// </summary>
			public readonly static Field DELAY_SMS = new Field("DELAY_SMS", "PT_ZXTS", "延期说明书");
            /// <summary>
			/// 投诉撤回意见书
			/// </summary>
			public readonly static Field REVOKE_YJS = new Field("REVOKE_YJS", "PT_ZXTS", "投诉撤回意见书");
            /// <summary>
			/// 投诉人_角色
			/// </summary>
			public readonly static Field COMPLAINT_ROLE = new Field("COMPLAINT_ROLE", "PT_ZXTS", "投诉人_角色");
            /// <summary>
			/// 投诉创建人（线下投诉）
			/// </summary>
			public readonly static Field CREATE_UID = new Field("CREATE_UID", "PT_ZXTS", "投诉创建人（线下投诉）");
            /// <summary>
			/// 投诉部门（线下投诉）
			/// </summary>
			public readonly static Field CREATE_DEPID = new Field("CREATE_DEPID", "PT_ZXTS", "投诉部门（线下投诉）");
            /// <summary>
			/// 投诉内容
			/// </summary>
			public readonly static Field COMPLAINT_CONTENT = new Field("COMPLAINT_CONTENT", "PT_ZXTS",DbType.AnsiString, null, "投诉内容");
        }
        #endregion
	}
}