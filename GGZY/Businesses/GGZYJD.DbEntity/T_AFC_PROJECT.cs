using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类T_AFC_PROJECT。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("T_AFC_PROJECT")]
	[Serializable]
	public partial class T_AFC_PROJECT : JdEntity
	{
		#region Model
		private decimal? _ID;
		private string _CODE;
		private string _TZ_CODE;
		private string _PROJECT_CODE;
		private string _PROJECT_NAME;
		private string _PROJECT_TYPE;
		private string _PROJECT_ADDRESS;
		private string _REGION_CITY;
		private string _REGION_COUNTY;
		private string _JS_DEP;
		private string _JS_LEGAL_PERSON;
		private string _JS_CODE;
		private string _JS_CODE_AIDS;
		private string _UNIT_ADDRESS;
		private string _MANAGER;
		private string _MANAGER_PHONE;
		private string _APPROVAL_NAME;
		private string _APPROVAL_AIDS;
		private string _APPROVAL_NUMBER;
		private string _APPROVAL_AUTHORITY;
		private string _GCGMJNR;
		private decimal? _TOTAL_INVEST;
		private decimal? _TOTAL_INVEST_JA;
		private string _FUND_SOURCE;
		private decimal? _CONTRIBUTION_SCALE_CZ;
		private decimal? _CONTRIBUTION_SCALE_ZC;
		private decimal? _CONTRIBUTION_SCALE_QT;
		private string _FBFS_SURVEY;
		private string _FBFS_DESIGN;
		private string _FBFS_CONSTRUCT;
		private string _FBFS_SUPERVISION;
		private string _FBFS_SBCL;
		private string _FBFS_CONTRACT;
		private string _TENDER_ORGANIZE_FORM;
		private decimal? _IS_DJZ;
		private string _REGISTER_AIDS;
		private string _OTHER_AIDS;
		private string _REMARK;
		private decimal? _U_ID;
		private string _DEP_NAME;
		private DateTime? _TM;
		private decimal? _APPROVAL_STATE;
		private decimal? _APPROVAL_UID;
		private string _APPROVAL_REMARK;
		private DateTime? _APPROVAL_TM;
		private DateTime? _DATA_TIMESTAMP;
		private string _APPROVAL_DEPID;
		private decimal? _APPROVAL_TACHE;
		private string _ZBHZYJS_AIDS;
		private string _APPROVAL_UNAME;
		private string _APPROVAL_CONTACT_INFORMATION;
		private string _KIND;
		private string _FBFS_CKSJ;
		private string _FBFS_SYJC;
		private string _FBFS_SJZX;
		private string _FBFS_OTHER;
		private string _M_DATA_SOURCE;
		private DateTime? _OVER_TM;
		private string _JSXZ;
		private string _GCYT;
		private decimal? _ISMAJOR;
		private string _CXXMINFO;
		private string _JZJNINFO;
		private string _APPROVAL_LEVEL;
		private DateTime? _APPROVAL_DATE;
		private decimal? _GOVERNMENT_INVEST_FINANCE;
		private string _APPROVAL_DEPID_BL;
		private string _CHECKPERSONNAME;
		private decimal? _CONTRIBUTION_SCALE_SB;

		/// <summary>
		/// ID
		/// </summary>
		public decimal? ID
		{
			get { return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 报建编号
		/// </summary>
		public string CODE
		{
			get { return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
			}
		}
		/// <summary>
		/// 投资项目统一代码
		/// </summary>
		public string TZ_CODE
		{
			get { return _TZ_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TZ_CODE, _TZ_CODE, value);
				this._TZ_CODE = value;
			}
		}
		/// <summary>
		/// 项目编号
		/// </summary>
		public string PROJECT_CODE
		{
			get { return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string PROJECT_NAME
		{
			get { return _PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_NAME, _PROJECT_NAME, value);
				this._PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 工程类别
		/// </summary>
		public string PROJECT_TYPE
		{
			get { return _PROJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_TYPE, _PROJECT_TYPE, value);
				this._PROJECT_TYPE = value;
			}
		}
		/// <summary>
		/// 项目地址
		/// </summary>
		public string PROJECT_ADDRESS
		{
			get { return _PROJECT_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_ADDRESS, _PROJECT_ADDRESS, value);
				this._PROJECT_ADDRESS = value;
			}
		}
		/// <summary>
		/// 项目所在市
		/// </summary>
		public string REGION_CITY
		{
			get { return _REGION_CITY; }
			set
			{
				this.OnPropertyValueChange(_.REGION_CITY, _REGION_CITY, value);
				this._REGION_CITY = value;
			}
		}
		/// <summary>
		/// 项目所在县
		/// </summary>
		public string REGION_COUNTY
		{
			get { return _REGION_COUNTY; }
			set
			{
				this.OnPropertyValueChange(_.REGION_COUNTY, _REGION_COUNTY, value);
				this._REGION_COUNTY = value;
			}
		}
		/// <summary>
		/// 建设单位
		/// </summary>
		public string JS_DEP
		{
			get { return _JS_DEP; }
			set
			{
				this.OnPropertyValueChange(_.JS_DEP, _JS_DEP, value);
				this._JS_DEP = value;
			}
		}
		/// <summary>
		/// 法定代表人
		/// </summary>
		public string JS_LEGAL_PERSON
		{
			get { return _JS_LEGAL_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.JS_LEGAL_PERSON, _JS_LEGAL_PERSON, value);
				this._JS_LEGAL_PERSON = value;
			}
		}
		/// <summary>
		/// 建设单位社会统一信用代码
		/// </summary>
		public string JS_CODE
		{
			get { return _JS_CODE; }
			set
			{
				this.OnPropertyValueChange(_.JS_CODE, _JS_CODE, value);
				this._JS_CODE = value;
			}
		}
		/// <summary>
		/// 组织机构代码证书
		/// </summary>
		public string JS_CODE_AIDS
		{
			get { return _JS_CODE_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.JS_CODE_AIDS, _JS_CODE_AIDS, value);
				this._JS_CODE_AIDS = value;
			}
		}
		/// <summary>
		/// 单位地址
		/// </summary>
		public string UNIT_ADDRESS
		{
			get { return _UNIT_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.UNIT_ADDRESS, _UNIT_ADDRESS, value);
				this._UNIT_ADDRESS = value;
			}
		}
		/// <summary>
		/// 项目负责人
		/// </summary>
		public string MANAGER
		{
			get { return _MANAGER; }
			set
			{
				this.OnPropertyValueChange(_.MANAGER, _MANAGER, value);
				this._MANAGER = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string MANAGER_PHONE
		{
			get { return _MANAGER_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.MANAGER_PHONE, _MANAGER_PHONE, value);
				this._MANAGER_PHONE = value;
			}
		}
		/// <summary>
		/// 项目立项或批准文件_文件名称
		/// </summary>
		public string APPROVAL_NAME
		{
			get { return _APPROVAL_NAME; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_NAME, _APPROVAL_NAME, value);
				this._APPROVAL_NAME = value;
			}
		}
		/// <summary>
		/// 项目立项或批准文件
		/// </summary>
		public string APPROVAL_AIDS
		{
			get { return _APPROVAL_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_AIDS, _APPROVAL_AIDS, value);
				this._APPROVAL_AIDS = value;
			}
		}
		/// <summary>
		/// 项目立项或批准文件_文号
		/// </summary>
		public string APPROVAL_NUMBER
		{
			get { return _APPROVAL_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_NUMBER, _APPROVAL_NUMBER, value);
				this._APPROVAL_NUMBER = value;
			}
		}
		/// <summary>
		/// 项目立项或批准文件_发文单位
		/// </summary>
		public string APPROVAL_AUTHORITY
		{
			get { return _APPROVAL_AUTHORITY; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_AUTHORITY, _APPROVAL_AUTHORITY, value);
				this._APPROVAL_AUTHORITY = value;
			}
		}
		/// <summary>
		/// 工程规模及内容
		/// </summary>
		public string GCGMJNR
		{
			get { return _GCGMJNR; }
			set
			{
				this.OnPropertyValueChange(_.GCGMJNR, _GCGMJNR, value);
				this._GCGMJNR = value;
			}
		}
		/// <summary>
		/// 投资总额
		/// </summary>
		public decimal? TOTAL_INVEST
		{
			get { return _TOTAL_INVEST; }
			set
			{
				this.OnPropertyValueChange(_.TOTAL_INVEST, _TOTAL_INVEST, value);
				this._TOTAL_INVEST = value;
			}
		}
		/// <summary>
		/// 投资总额-建安工程费
		/// </summary>
		public decimal? TOTAL_INVEST_JA
		{
			get { return _TOTAL_INVEST_JA; }
			set
			{
				this.OnPropertyValueChange(_.TOTAL_INVEST_JA, _TOTAL_INVEST_JA, value);
				this._TOTAL_INVEST_JA = value;
			}
		}
		/// <summary>
		/// 资金来源
		/// </summary>
		public string FUND_SOURCE
		{
			get { return _FUND_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.FUND_SOURCE, _FUND_SOURCE, value);
				this._FUND_SOURCE = value;
			}
		}
		/// <summary>
		/// 出资比例—财政
		/// </summary>
		public decimal? CONTRIBUTION_SCALE_CZ
		{
			get { return _CONTRIBUTION_SCALE_CZ; }
			set
			{
				this.OnPropertyValueChange(_.CONTRIBUTION_SCALE_CZ, _CONTRIBUTION_SCALE_CZ, value);
				this._CONTRIBUTION_SCALE_CZ = value;
			}
		}
		/// <summary>
		/// 出资比例—自筹
		/// </summary>
		public decimal? CONTRIBUTION_SCALE_ZC
		{
			get { return _CONTRIBUTION_SCALE_ZC; }
			set
			{
				this.OnPropertyValueChange(_.CONTRIBUTION_SCALE_ZC, _CONTRIBUTION_SCALE_ZC, value);
				this._CONTRIBUTION_SCALE_ZC = value;
			}
		}
		/// <summary>
		/// 出资比例—其他
		/// </summary>
		public decimal? CONTRIBUTION_SCALE_QT
		{
			get { return _CONTRIBUTION_SCALE_QT; }
			set
			{
				this.OnPropertyValueChange(_.CONTRIBUTION_SCALE_QT, _CONTRIBUTION_SCALE_QT, value);
				this._CONTRIBUTION_SCALE_QT = value;
			}
		}
		/// <summary>
		/// 发包内容及方式-勘察
		/// </summary>
		public string FBFS_SURVEY
		{
			get { return _FBFS_SURVEY; }
			set
			{
				this.OnPropertyValueChange(_.FBFS_SURVEY, _FBFS_SURVEY, value);
				this._FBFS_SURVEY = value;
			}
		}
		/// <summary>
		/// 发包内容及方式-设计
		/// </summary>
		public string FBFS_DESIGN
		{
			get { return _FBFS_DESIGN; }
			set
			{
				this.OnPropertyValueChange(_.FBFS_DESIGN, _FBFS_DESIGN, value);
				this._FBFS_DESIGN = value;
			}
		}
		/// <summary>
		/// 发包内容及方式-施工
		/// </summary>
		public string FBFS_CONSTRUCT
		{
			get { return _FBFS_CONSTRUCT; }
			set
			{
				this.OnPropertyValueChange(_.FBFS_CONSTRUCT, _FBFS_CONSTRUCT, value);
				this._FBFS_CONSTRUCT = value;
			}
		}
		/// <summary>
		/// 发包内容及方式-监理
		/// </summary>
		public string FBFS_SUPERVISION
		{
			get { return _FBFS_SUPERVISION; }
			set
			{
				this.OnPropertyValueChange(_.FBFS_SUPERVISION, _FBFS_SUPERVISION, value);
				this._FBFS_SUPERVISION = value;
			}
		}
		/// <summary>
		/// 发包内容及方式-重要设备和材料
		/// </summary>
		public string FBFS_SBCL
		{
			get { return _FBFS_SBCL; }
			set
			{
				this.OnPropertyValueChange(_.FBFS_SBCL, _FBFS_SBCL, value);
				this._FBFS_SBCL = value;
			}
		}
		/// <summary>
		/// 发包内容及方式-工程总承包
		/// </summary>
		public string FBFS_CONTRACT
		{
			get { return _FBFS_CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.FBFS_CONTRACT, _FBFS_CONTRACT, value);
				this._FBFS_CONTRACT = value;
			}
		}
		/// <summary>
		/// 招标组织形式
		/// </summary>
		public string TENDER_ORGANIZE_FORM
		{
			get { return _TENDER_ORGANIZE_FORM; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_ORGANIZE_FORM, _TENDER_ORGANIZE_FORM, value);
				this._TENDER_ORGANIZE_FORM = value;
			}
		}
		/// <summary>
		/// 是否采用代建制
		/// </summary>
		public decimal? IS_DJZ
		{
			get { return _IS_DJZ; }
			set
			{
				this.OnPropertyValueChange(_.IS_DJZ, _IS_DJZ, value);
				this._IS_DJZ = value;
			}
		}
		/// <summary>
		/// 工程项目立项登记表
		/// </summary>
		public string REGISTER_AIDS
		{
			get { return _REGISTER_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.REGISTER_AIDS, _REGISTER_AIDS, value);
				this._REGISTER_AIDS = value;
			}
		}
		/// <summary>
		/// 其他文件
		/// </summary>
		public string OTHER_AIDS
		{
			get { return _OTHER_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_AIDS, _OTHER_AIDS, value);
				this._OTHER_AIDS = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARK
		{
			get { return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
			}
		}
		/// <summary>
		/// 填报人
		/// </summary>
		public decimal? U_ID
		{
			get { return _U_ID; }
			set
			{
				this.OnPropertyValueChange(_.U_ID, _U_ID, value);
				this._U_ID = value;
			}
		}
		/// <summary>
		/// 填报单位
		/// </summary>
		public string DEP_NAME
		{
			get { return _DEP_NAME; }
			set
			{
				this.OnPropertyValueChange(_.DEP_NAME, _DEP_NAME, value);
				this._DEP_NAME = value;
			}
		}
		/// <summary>
		/// 填报日期
		/// </summary>
		public DateTime? TM
		{
			get { return _TM; }
			set
			{
				this.OnPropertyValueChange(_.TM, _TM, value);
				this._TM = value;
			}
		}
		/// <summary>
		/// 审查状态(1提交2待审批3通过4不通过5撤回6报废)
		/// </summary>
		public decimal? APPROVAL_STATE
		{
			get { return _APPROVAL_STATE; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_STATE, _APPROVAL_STATE, value);
				this._APPROVAL_STATE = value;
			}
		}
		/// <summary>
		/// 审查人员
		/// </summary>
		public decimal? APPROVAL_UID
		{
			get { return _APPROVAL_UID; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_UID, _APPROVAL_UID, value);
				this._APPROVAL_UID = value;
			}
		}
		/// <summary>
		/// 审查意见
		/// </summary>
		public string APPROVAL_REMARK
		{
			get { return _APPROVAL_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_REMARK, _APPROVAL_REMARK, value);
				this._APPROVAL_REMARK = value;
			}
		}
		/// <summary>
		/// 审查日期
		/// </summary>
		public DateTime? APPROVAL_TM
		{
			get { return _APPROVAL_TM; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_TM, _APPROVAL_TM, value);
				this._APPROVAL_TM = value;
			}
		}
		/// <summary>
		/// 数据时间戳
		/// </summary>
		public DateTime? DATA_TIMESTAMP
		{
			get { return _DATA_TIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATA_TIMESTAMP, _DATA_TIMESTAMP, value);
				this._DATA_TIMESTAMP = value;
			}
		}
		/// <summary>
		/// 审查单位
		/// </summary>
		public string APPROVAL_DEPID
		{
			get { return _APPROVAL_DEPID; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_DEPID, _APPROVAL_DEPID, value);
				this._APPROVAL_DEPID = value;
			}
		}
		/// <summary>
		/// 审查环节（1初建2变更申请3报建变更）
		/// </summary>
		public decimal? APPROVAL_TACHE
		{
			get { return _APPROVAL_TACHE; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_TACHE, _APPROVAL_TACHE, value);
				this._APPROVAL_TACHE = value;
			}
		}
		/// <summary>
		/// 招标事项核准意见书
		/// </summary>
		public string ZBHZYJS_AIDS
		{
			get { return _ZBHZYJS_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.ZBHZYJS_AIDS, _ZBHZYJS_AIDS, value);
				this._ZBHZYJS_AIDS = value;
			}
		}
		/// <summary>
		/// 审查人员-姓名
		/// </summary>
		public string APPROVAL_UNAME
		{
			get { return _APPROVAL_UNAME; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_UNAME, _APPROVAL_UNAME, value);
				this._APPROVAL_UNAME = value;
			}
		}
		/// <summary>
		/// 审查人员-联系方式
		/// </summary>
		public string APPROVAL_CONTACT_INFORMATION
		{
			get { return _APPROVAL_CONTACT_INFORMATION; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_CONTACT_INFORMATION, _APPROVAL_CONTACT_INFORMATION, value);
				this._APPROVAL_CONTACT_INFORMATION = value;
			}
		}
		/// <summary>
		/// 报建类别
		/// </summary>
		public string KIND
		{
			get { return _KIND; }
			set
			{
				this.OnPropertyValueChange(_.KIND, _KIND, value);
				this._KIND = value;
			}
		}
		/// <summary>
		/// 发包内容及方式-勘察设计
		/// </summary>
		public string FBFS_CKSJ
		{
			get { return _FBFS_CKSJ; }
			set
			{
				this.OnPropertyValueChange(_.FBFS_CKSJ, _FBFS_CKSJ, value);
				this._FBFS_CKSJ = value;
			}
		}
		/// <summary>
		/// 发包内容及方式-试验检测
		/// </summary>
		public string FBFS_SYJC
		{
			get { return _FBFS_SYJC; }
			set
			{
				this.OnPropertyValueChange(_.FBFS_SYJC, _FBFS_SYJC, value);
				this._FBFS_SYJC = value;
			}
		}
		/// <summary>
		/// 发包内容及方式-设计咨询
		/// </summary>
		public string FBFS_SJZX
		{
			get { return _FBFS_SJZX; }
			set
			{
				this.OnPropertyValueChange(_.FBFS_SJZX, _FBFS_SJZX, value);
				this._FBFS_SJZX = value;
			}
		}
		/// <summary>
		/// 发包内容及方式-其他
		/// </summary>
		public string FBFS_OTHER
		{
			get { return _FBFS_OTHER; }
			set
			{
				this.OnPropertyValueChange(_.FBFS_OTHER, _FBFS_OTHER, value);
				this._FBFS_OTHER = value;
			}
		}
		/// <summary>
		/// 数据来源
		/// </summary>
		public string M_DATA_SOURCE
		{
			get { return _M_DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_SOURCE, _M_DATA_SOURCE, value);
				this._M_DATA_SOURCE = value;
			}
		}
		/// <summary>
		/// 超时时间(最后处理时间)
		/// </summary>
		public DateTime? OVER_TM
		{
			get { return _OVER_TM; }
			set
			{
				this.OnPropertyValueChange(_.OVER_TM, _OVER_TM, value);
				this._OVER_TM = value;
			}
		}
		/// <summary>
		/// 建设性质
		/// </summary>
		public string JSXZ
		{
			get { return _JSXZ; }
			set
			{
				this.OnPropertyValueChange(_.JSXZ, _JSXZ, value);
				this._JSXZ = value;
			}
		}
		/// <summary>
		/// 工程用途
		/// </summary>
		public string GCYT
		{
			get { return _GCYT; }
			set
			{
				this.OnPropertyValueChange(_.GCYT, _GCYT, value);
				this._GCYT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISMAJOR
		{
			get { return _ISMAJOR; }
			set
			{
				this.OnPropertyValueChange(_.ISMAJOR, _ISMAJOR, value);
				this._ISMAJOR = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CXXMINFO
		{
			get { return _CXXMINFO; }
			set
			{
				this.OnPropertyValueChange(_.CXXMINFO, _CXXMINFO, value);
				this._CXXMINFO = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JZJNINFO
		{
			get { return _JZJNINFO; }
			set
			{
				this.OnPropertyValueChange(_.JZJNINFO, _JZJNINFO, value);
				this._JZJNINFO = value;
			}
		}
		/// <summary>
		/// 立项级别
		/// </summary>
		public string APPROVAL_LEVEL
		{
			get { return _APPROVAL_LEVEL; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_LEVEL, _APPROVAL_LEVEL, value);
				this._APPROVAL_LEVEL = value;
			}
		}
		/// <summary>
		/// 立项批复时间
		/// </summary>
		public DateTime? APPROVAL_DATE
		{
			get { return _APPROVAL_DATE; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_DATE, _APPROVAL_DATE, value);
				this._APPROVAL_DATE = value;
			}
		}
		/// <summary>
		/// 国有资金出资比例
		/// </summary>
		public decimal? GOVERNMENT_INVEST_FINANCE
		{
			get { return _GOVERNMENT_INVEST_FINANCE; }
			set
			{
				this.OnPropertyValueChange(_.GOVERNMENT_INVEST_FINANCE, _GOVERNMENT_INVEST_FINANCE, value);
				this._GOVERNMENT_INVEST_FINANCE = value;
			}
		}
		/// <summary>
		/// 补录提交时选择的部门，仅记录
		/// </summary>
		public string APPROVAL_DEPID_BL
		{
			get { return _APPROVAL_DEPID_BL; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_DEPID_BL, _APPROVAL_DEPID_BL, value);
				this._APPROVAL_DEPID_BL = value;
			}
		}
		/// <summary>
		/// 投资平台，信息审核人员
		/// </summary>
		public string CHECKPERSONNAME
		{
			get { return _CHECKPERSONNAME; }
			set
			{
				this.OnPropertyValueChange(_.CHECKPERSONNAME, _CHECKPERSONNAME, value);
				this._CHECKPERSONNAME = value;
			}
		}
		/// <summary>
		/// 出资比例—数办批复资金投资比例 仅“信息”行业中增加其他行业不变
		/// </summary>
		public decimal? CONTRIBUTION_SCALE_SB
		{
			get { return _CONTRIBUTION_SCALE_SB; }
			set
			{
				this.OnPropertyValueChange(_.CONTRIBUTION_SCALE_SB, _CONTRIBUTION_SCALE_SB, value);
				this._CONTRIBUTION_SCALE_SB = value;
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
				_.TZ_CODE,
				_.PROJECT_CODE,
				_.PROJECT_NAME,
				_.PROJECT_TYPE,
				_.PROJECT_ADDRESS,
				_.REGION_CITY,
				_.REGION_COUNTY,
				_.JS_DEP,
				_.JS_LEGAL_PERSON,
				_.JS_CODE,
				_.JS_CODE_AIDS,
				_.UNIT_ADDRESS,
				_.MANAGER,
				_.MANAGER_PHONE,
				_.APPROVAL_NAME,
				_.APPROVAL_AIDS,
				_.APPROVAL_NUMBER,
				_.APPROVAL_AUTHORITY,
				_.GCGMJNR,
				_.TOTAL_INVEST,
				_.TOTAL_INVEST_JA,
				_.FUND_SOURCE,
				_.CONTRIBUTION_SCALE_CZ,
				_.CONTRIBUTION_SCALE_ZC,
				_.CONTRIBUTION_SCALE_QT,
				_.FBFS_SURVEY,
				_.FBFS_DESIGN,
				_.FBFS_CONSTRUCT,
				_.FBFS_SUPERVISION,
				_.FBFS_SBCL,
				_.FBFS_CONTRACT,
				_.TENDER_ORGANIZE_FORM,
				_.IS_DJZ,
				_.REGISTER_AIDS,
				_.OTHER_AIDS,
				_.REMARK,
				_.U_ID,
				_.DEP_NAME,
				_.TM,
				_.APPROVAL_STATE,
				_.APPROVAL_UID,
				_.APPROVAL_REMARK,
				_.APPROVAL_TM,
				_.DATA_TIMESTAMP,
				_.APPROVAL_DEPID,
				_.APPROVAL_TACHE,
				_.ZBHZYJS_AIDS,
				_.APPROVAL_UNAME,
				_.APPROVAL_CONTACT_INFORMATION,
				_.KIND,
				_.FBFS_CKSJ,
				_.FBFS_SYJC,
				_.FBFS_SJZX,
				_.FBFS_OTHER,
				_.M_DATA_SOURCE,
				_.OVER_TM,
				_.JSXZ,
				_.GCYT,
				_.ISMAJOR,
				_.CXXMINFO,
				_.JZJNINFO,
				_.APPROVAL_LEVEL,
				_.APPROVAL_DATE,
				_.GOVERNMENT_INVEST_FINANCE,
				_.APPROVAL_DEPID_BL,
				_.CHECKPERSONNAME,
				_.CONTRIBUTION_SCALE_SB,
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
				this._TZ_CODE,
				this._PROJECT_CODE,
				this._PROJECT_NAME,
				this._PROJECT_TYPE,
				this._PROJECT_ADDRESS,
				this._REGION_CITY,
				this._REGION_COUNTY,
				this._JS_DEP,
				this._JS_LEGAL_PERSON,
				this._JS_CODE,
				this._JS_CODE_AIDS,
				this._UNIT_ADDRESS,
				this._MANAGER,
				this._MANAGER_PHONE,
				this._APPROVAL_NAME,
				this._APPROVAL_AIDS,
				this._APPROVAL_NUMBER,
				this._APPROVAL_AUTHORITY,
				this._GCGMJNR,
				this._TOTAL_INVEST,
				this._TOTAL_INVEST_JA,
				this._FUND_SOURCE,
				this._CONTRIBUTION_SCALE_CZ,
				this._CONTRIBUTION_SCALE_ZC,
				this._CONTRIBUTION_SCALE_QT,
				this._FBFS_SURVEY,
				this._FBFS_DESIGN,
				this._FBFS_CONSTRUCT,
				this._FBFS_SUPERVISION,
				this._FBFS_SBCL,
				this._FBFS_CONTRACT,
				this._TENDER_ORGANIZE_FORM,
				this._IS_DJZ,
				this._REGISTER_AIDS,
				this._OTHER_AIDS,
				this._REMARK,
				this._U_ID,
				this._DEP_NAME,
				this._TM,
				this._APPROVAL_STATE,
				this._APPROVAL_UID,
				this._APPROVAL_REMARK,
				this._APPROVAL_TM,
				this._DATA_TIMESTAMP,
				this._APPROVAL_DEPID,
				this._APPROVAL_TACHE,
				this._ZBHZYJS_AIDS,
				this._APPROVAL_UNAME,
				this._APPROVAL_CONTACT_INFORMATION,
				this._KIND,
				this._FBFS_CKSJ,
				this._FBFS_SYJC,
				this._FBFS_SJZX,
				this._FBFS_OTHER,
				this._M_DATA_SOURCE,
				this._OVER_TM,
				this._JSXZ,
				this._GCYT,
				this._ISMAJOR,
				this._CXXMINFO,
				this._JZJNINFO,
				this._APPROVAL_LEVEL,
				this._APPROVAL_DATE,
				this._GOVERNMENT_INVEST_FINANCE,
				this._APPROVAL_DEPID_BL,
				this._CHECKPERSONNAME,
				this._CONTRIBUTION_SCALE_SB,
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
			public readonly static Field All = new Field("*", "T_AFC_PROJECT");
			/// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_AFC_PROJECT", "ID");
			/// <summary>
			/// 报建编号
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "T_AFC_PROJECT", "报建编号");
			/// <summary>
			/// 投资项目统一代码
			/// </summary>
			public readonly static Field TZ_CODE = new Field("TZ_CODE", "T_AFC_PROJECT", "投资项目统一代码");
			/// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "T_AFC_PROJECT", "项目编号");
			/// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "T_AFC_PROJECT", "项目名称");
			/// <summary>
			/// 工程类别 63
			/// </summary>
			public readonly static Field PROJECT_TYPE = new Field("PROJECT_TYPE", "T_AFC_PROJECT", "工程类别");
			/// <summary>
			/// 项目地址
			/// </summary>
			public readonly static Field PROJECT_ADDRESS = new Field("PROJECT_ADDRESS", "T_AFC_PROJECT", "项目地址");
			/// <summary>
			/// 项目所在市
			/// </summary>
			public readonly static Field REGION_CITY = new Field("REGION_CITY", "T_AFC_PROJECT", "项目所在市");
			/// <summary>
			/// 项目所在县
			/// </summary>
			public readonly static Field REGION_COUNTY = new Field("REGION_COUNTY", "T_AFC_PROJECT", "项目所在县");
			/// <summary>
			/// 建设单位
			/// </summary>
			public readonly static Field JS_DEP = new Field("JS_DEP", "T_AFC_PROJECT", "建设单位");
			/// <summary>
			/// 法定代表人
			/// </summary>
			public readonly static Field JS_LEGAL_PERSON = new Field("JS_LEGAL_PERSON", "T_AFC_PROJECT", "法定代表人");
			/// <summary>
			/// 建设单位社会统一信用代码
			/// </summary>
			public readonly static Field JS_CODE = new Field("JS_CODE", "T_AFC_PROJECT", "建设单位社会统一信用代码");
			/// <summary>
			/// 组织机构代码证书
			/// </summary>
			public readonly static Field JS_CODE_AIDS = new Field("JS_CODE_AIDS", "T_AFC_PROJECT", "组织机构代码证书");
			/// <summary>
			/// 单位地址
			/// </summary>
			public readonly static Field UNIT_ADDRESS = new Field("UNIT_ADDRESS", "T_AFC_PROJECT", "单位地址");
			/// <summary>
			/// 项目负责人
			/// </summary>
			public readonly static Field MANAGER = new Field("MANAGER", "T_AFC_PROJECT", "项目负责人");
			/// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field MANAGER_PHONE = new Field("MANAGER_PHONE", "T_AFC_PROJECT", "联系电话");
			/// <summary>
			/// 项目立项或批准文件_文件名称
			/// </summary>
			public readonly static Field APPROVAL_NAME = new Field("APPROVAL_NAME", "T_AFC_PROJECT", "项目立项或批准文件_文件名称");
			/// <summary>
			/// 项目立项或批准文件
			/// </summary>
			public readonly static Field APPROVAL_AIDS = new Field("APPROVAL_AIDS", "T_AFC_PROJECT", "项目立项或批准文件");
			/// <summary>
			/// 项目立项或批准文件_文号
			/// </summary>
			public readonly static Field APPROVAL_NUMBER = new Field("APPROVAL_NUMBER", "T_AFC_PROJECT", "项目立项或批准文件_文号");
			/// <summary>
			/// 项目立项或批准文件_发文单位
			/// </summary>
			public readonly static Field APPROVAL_AUTHORITY = new Field("APPROVAL_AUTHORITY", "T_AFC_PROJECT", "项目立项或批准文件_发文单位");
			/// <summary>
			/// 工程规模及内容
			/// </summary>
			public readonly static Field GCGMJNR = new Field("GCGMJNR", "T_AFC_PROJECT", "工程规模及内容");
			/// <summary>
			/// 投资总额
			/// </summary>
			public readonly static Field TOTAL_INVEST = new Field("TOTAL_INVEST", "T_AFC_PROJECT", "投资总额");
			/// <summary>
			/// 投资总额-建安工程费
			/// </summary>
			public readonly static Field TOTAL_INVEST_JA = new Field("TOTAL_INVEST_JA", "T_AFC_PROJECT", "投资总额-建安工程费");
			/// <summary>
			/// 资金来源
			/// </summary>
			public readonly static Field FUND_SOURCE = new Field("FUND_SOURCE", "T_AFC_PROJECT", "资金来源");
			/// <summary>
			/// 出资比例—财政
			/// </summary>
			public readonly static Field CONTRIBUTION_SCALE_CZ = new Field("CONTRIBUTION_SCALE_CZ", "T_AFC_PROJECT", "出资比例—财政");
			/// <summary>
			/// 出资比例—自筹
			/// </summary>
			public readonly static Field CONTRIBUTION_SCALE_ZC = new Field("CONTRIBUTION_SCALE_ZC", "T_AFC_PROJECT", "出资比例—自筹");
			/// <summary>
			/// 出资比例—其他
			/// </summary>
			public readonly static Field CONTRIBUTION_SCALE_QT = new Field("CONTRIBUTION_SCALE_QT", "T_AFC_PROJECT", "出资比例—其他");
			/// <summary>
			/// 发包内容及方式-勘察
			/// </summary>
			public readonly static Field FBFS_SURVEY = new Field("FBFS_SURVEY", "T_AFC_PROJECT", "发包内容及方式-勘察");
			/// <summary>
			/// 发包内容及方式-设计
			/// </summary>
			public readonly static Field FBFS_DESIGN = new Field("FBFS_DESIGN", "T_AFC_PROJECT", "发包内容及方式-设计");
			/// <summary>
			/// 发包内容及方式-施工
			/// </summary>
			public readonly static Field FBFS_CONSTRUCT = new Field("FBFS_CONSTRUCT", "T_AFC_PROJECT", "发包内容及方式-施工");
			/// <summary>
			/// 发包内容及方式-监理
			/// </summary>
			public readonly static Field FBFS_SUPERVISION = new Field("FBFS_SUPERVISION", "T_AFC_PROJECT", "发包内容及方式-监理");
			/// <summary>
			/// 发包内容及方式-重要设备和材料
			/// </summary>
			public readonly static Field FBFS_SBCL = new Field("FBFS_SBCL", "T_AFC_PROJECT", "发包内容及方式-重要设备和材料");
			/// <summary>
			/// 发包内容及方式-工程总承包
			/// </summary>
			public readonly static Field FBFS_CONTRACT = new Field("FBFS_CONTRACT", "T_AFC_PROJECT", "发包内容及方式-工程总承包");
			/// <summary>
			/// 招标组织形式
			/// </summary>
			public readonly static Field TENDER_ORGANIZE_FORM = new Field("TENDER_ORGANIZE_FORM", "T_AFC_PROJECT", "招标组织形式");
			/// <summary>
			/// 是否采用代建制
			/// </summary>
			public readonly static Field IS_DJZ = new Field("IS_DJZ", "T_AFC_PROJECT", "是否采用代建制");
			/// <summary>
			/// 工程项目立项登记表
			/// </summary>
			public readonly static Field REGISTER_AIDS = new Field("REGISTER_AIDS", "T_AFC_PROJECT", "工程项目立项登记表");
			/// <summary>
			/// 其他文件
			/// </summary>
			public readonly static Field OTHER_AIDS = new Field("OTHER_AIDS", "T_AFC_PROJECT", "其他文件");
			/// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_AFC_PROJECT", "备注");
			/// <summary>
			/// 填报人
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "T_AFC_PROJECT", "填报人");
			/// <summary>
			/// 填报单位
			/// </summary>
			public readonly static Field DEP_NAME = new Field("DEP_NAME", "T_AFC_PROJECT", "填报单位");
			/// <summary>
			/// 填报日期
			/// </summary>
			public readonly static Field TM = new Field("TM", "T_AFC_PROJECT", "填报日期");
			/// <summary>
			/// 审查状态(1提交2待审批3通过4不通过5撤回6报废)
			/// </summary>
			public readonly static Field APPROVAL_STATE = new Field("APPROVAL_STATE", "T_AFC_PROJECT", "审查状态(1提交2待审批3通过4不通过5撤回6报废)");
			/// <summary>
			/// 审查人员
			/// </summary>
			public readonly static Field APPROVAL_UID = new Field("APPROVAL_UID", "T_AFC_PROJECT", "审查人员");
			/// <summary>
			/// 审查意见
			/// </summary>
			public readonly static Field APPROVAL_REMARK = new Field("APPROVAL_REMARK", "T_AFC_PROJECT", "审查意见");
			/// <summary>
			/// 审查日期
			/// </summary>
			public readonly static Field APPROVAL_TM = new Field("APPROVAL_TM", "T_AFC_PROJECT", "审查日期");
			/// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "T_AFC_PROJECT", "数据时间戳");
			/// <summary>
			/// 审查单位
			/// </summary>
			public readonly static Field APPROVAL_DEPID = new Field("APPROVAL_DEPID", "T_AFC_PROJECT", "审查单位");
			/// <summary>
			/// 审查环节（1初建2变更申请3报建变更）
			/// </summary>
			public readonly static Field APPROVAL_TACHE = new Field("APPROVAL_TACHE", "T_AFC_PROJECT", "审查环节（1初建2变更申请3报建变更）");
			/// <summary>
			/// 招标事项核准意见书
			/// </summary>
			public readonly static Field ZBHZYJS_AIDS = new Field("ZBHZYJS_AIDS", "T_AFC_PROJECT", "招标事项核准意见书");
			/// <summary>
			/// 审查人员-姓名
			/// </summary>
			public readonly static Field APPROVAL_UNAME = new Field("APPROVAL_UNAME", "T_AFC_PROJECT", "审查人员-姓名");
			/// <summary>
			/// 审查人员-联系方式
			/// </summary>
			public readonly static Field APPROVAL_CONTACT_INFORMATION = new Field("APPROVAL_CONTACT_INFORMATION", "T_AFC_PROJECT", "审查人员-联系方式");
			/// <summary>
			/// 报建类别 61
			/// </summary>
			public readonly static Field KIND = new Field("KIND", "T_AFC_PROJECT", "报建类别");
			/// <summary>
			/// 发包内容及方式-勘察设计
			/// </summary>
			public readonly static Field FBFS_CKSJ = new Field("FBFS_CKSJ", "T_AFC_PROJECT", "发包内容及方式-勘察设计");
			/// <summary>
			/// 发包内容及方式-试验检测
			/// </summary>
			public readonly static Field FBFS_SYJC = new Field("FBFS_SYJC", "T_AFC_PROJECT", "发包内容及方式-试验检测");
			/// <summary>
			/// 发包内容及方式-设计咨询
			/// </summary>
			public readonly static Field FBFS_SJZX = new Field("FBFS_SJZX", "T_AFC_PROJECT", "发包内容及方式-设计咨询");
			/// <summary>
			/// 发包内容及方式-其他
			/// </summary>
			public readonly static Field FBFS_OTHER = new Field("FBFS_OTHER", "T_AFC_PROJECT", "发包内容及方式-其他");
			/// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "T_AFC_PROJECT", "数据来源");
			/// <summary>
			/// 超时时间(最后处理时间)
			/// </summary>
			public readonly static Field OVER_TM = new Field("OVER_TM", "T_AFC_PROJECT", "超时时间(最后处理时间)");
			/// <summary>
			/// 建设性质
			/// </summary>
			public readonly static Field JSXZ = new Field("JSXZ", "T_AFC_PROJECT", "建设性质");
			/// <summary>
			/// 工程用途
			/// </summary>
			public readonly static Field GCYT = new Field("GCYT", "T_AFC_PROJECT", "工程用途");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ISMAJOR = new Field("ISMAJOR", "T_AFC_PROJECT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CXXMINFO = new Field("CXXMINFO", "T_AFC_PROJECT", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field JZJNINFO = new Field("JZJNINFO", "T_AFC_PROJECT", "");
			/// <summary>
			/// 立项级别
			/// </summary>
			public readonly static Field APPROVAL_LEVEL = new Field("APPROVAL_LEVEL", "T_AFC_PROJECT", "立项级别");
			/// <summary>
			/// 立项批复时间
			/// </summary>
			public readonly static Field APPROVAL_DATE = new Field("APPROVAL_DATE", "T_AFC_PROJECT", "立项批复时间");
			/// <summary>
			/// 国有资金出资比例
			/// </summary>
			public readonly static Field GOVERNMENT_INVEST_FINANCE = new Field("GOVERNMENT_INVEST_FINANCE", "T_AFC_PROJECT", "国有资金出资比例");
			/// <summary>
			/// 补录提交时选择的部门，仅记录
			/// </summary>
			public readonly static Field APPROVAL_DEPID_BL = new Field("APPROVAL_DEPID_BL", "T_AFC_PROJECT", "补录提交时选择的部门，仅记录");
			/// <summary>
			/// 投资平台，信息审核人员
			/// </summary>
			public readonly static Field CHECKPERSONNAME = new Field("CHECKPERSONNAME", "T_AFC_PROJECT", "投资平台，信息审核人员");
			/// <summary>
			/// 出资比例—数办批复资金投资比例 仅“信息”行业中增加其他行业不变
			/// </summary>
			public readonly static Field CONTRIBUTION_SCALE_SB = new Field("CONTRIBUTION_SCALE_SB", "T_AFC_PROJECT", "出资比例—数办批复资金投资比例 仅“信息”行业中增加其他行业不变");
		}
		#endregion
	}
}