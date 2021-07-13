﻿using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类SL_TENDER_PROJECT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SL_TENDER_PROJECT")]
    [Serializable]
    public partial class SL_TENDER_PROJECT : JdEntity
    {
        #region Model
		private string _PROJECT_CODE;
		private string _TENDER_PROJECT_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _TENDER_PROJECT_NAME;
		private string _TENDER_PROJECT_TYPE;
		private string _REGION_CODE;
		private string _TENDER_CONTENT;
		private string _OWNER_NAME;
		private string _TENDERER_NAME;
		private string _TENDERER_CODE_TYPE;
		private string _TENDERER_CODE;
		private string _TENDERER_ROLE;
		private string _TENDERER_CORPORATE_IDENTITY;
		private string _TENDERER_LEGAL_UNIT_ADDRESS;
		private string _TENDERER_LEGAL_ZIP_CODE;
		private string _TENDERER_LEGAL_CONTACT;
		private string _TENDERER_LEGAL_OFFICE_PHONE;
		private string _TENDERER_LEGAL_FAX;
		private string _TENDERER_LEGAL_EMAIL;
		private string _TENDER_AGENCY_NAME;
		private string _TENDER_AGENCY_CODE_TYPE;
		private string _TENDER_AGENCY_CODE;
		private string _TENDER_AGENCY_ROLE;
		private string _TENDERER_AGENCY_IDENTITY;
		private string _TENDER_AGENCY_ADDRESS;
		private string _TENDER_AGENCY_LEGAL_ZIP_CODE;
		private string _TENDER_AGENCY_LEGAL_CONTACT;
		private string _TENDER_AGENCY_CONTACT_PHONE;
		private string _TENDER_AGENCY_LEGAL_FAX;
		private string _TENDER_AGENCY_LEGAL_EMAIL;
		private string _TENDER_MODE;
		private string _TENDER_ORGANIZE_FORM;
		private DateTime? _CREATE_TIME;
		private string _SUPERVISE_DEPT_NAME;
		private string _SUPERVISE_DEPT_CODE;
		private string _APPROVE_DEPT_NAME;
		private string _APPROVE_DEPT_CODE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_TM;
		private DateTime? _OTHER_UPDATE_TIME;
		private string _TENDER_SELF_CODE;
		private string _M_ATT_PROJECT_REG;
		private string _M_ATT_AGENT_COMMIT;
		private string _M_ATT_OTHER_FILE;
		private string _M_ATT_PROJECT_REG_APPROVE;
		private string _M_ATT_TENDER_AGENT_CONTRACT;
		private string _M_ATT_COR_AUTHORITY_FILE;
		private string _M_ATT_FUND_SOURCE_CERTIFY_FILE;
		private string _IS_TO_LAW;
		private string _ISUNION;
		private string _REPORT_DUTY;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;
		private string _TENDER_RECORD_CODE;
		private string _TENDERER_REGION_CODE;
		private string _TENDERER_PROPERTY;
		private string _TENDER_AGENCY_REGION_CODE;
		private string _TENDER_AGENCY_PROPERTY;
		private string _OPERATION_NAME;
		private string _TRADE_SYSTEM_NO;
		private decimal? _TRADE_SYSTEM_FEE;

		/// <summary>
		/// 项目编号
		/// </summary>
		public string PROJECT_CODE
		{
			get{ return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
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
		/// 统一交易标识码
		/// </summary>
		public string UNIFIED_DEAL_CODE
		{
			get{ return _UNIFIED_DEAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.UNIFIED_DEAL_CODE, _UNIFIED_DEAL_CODE, value);
				this._UNIFIED_DEAL_CODE = value;
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
		/// 招标项目类型
		/// </summary>
		public string TENDER_PROJECT_TYPE
		{
			get{ return _TENDER_PROJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_TYPE, _TENDER_PROJECT_TYPE, value);
				this._TENDER_PROJECT_TYPE = value;
			}
		}
		/// <summary>
		/// 招标项目所在行政区域代码
		/// </summary>
		public string REGION_CODE
		{
			get{ return _REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REGION_CODE, _REGION_CODE, value);
				this._REGION_CODE = value;
			}
		}
		/// <summary>
		/// 招标内容与范围及招标方案说明
		/// </summary>
		public string TENDER_CONTENT
		{
			get{ return _TENDER_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_CONTENT, _TENDER_CONTENT, value);
				this._TENDER_CONTENT = value;
			}
		}
		/// <summary>
		/// 项目业主名称
		/// </summary>
		public string OWNER_NAME
		{
			get{ return _OWNER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.OWNER_NAME, _OWNER_NAME, value);
				this._OWNER_NAME = value;
			}
		}
		/// <summary>
		/// 招标人名称
		/// </summary>
		public string TENDERER_NAME
		{
			get{ return _TENDERER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_NAME, _TENDERER_NAME, value);
				this._TENDERER_NAME = value;
			}
		}
		/// <summary>
		/// 招标人类别
		/// </summary>
		public string TENDERER_CODE_TYPE
		{
			get{ return _TENDERER_CODE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_CODE_TYPE, _TENDERER_CODE_TYPE, value);
				this._TENDERER_CODE_TYPE = value;
			}
		}
		/// <summary>
		/// 招标人代码
		/// </summary>
		public string TENDERER_CODE
		{
			get{ return _TENDERER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_CODE, _TENDERER_CODE, value);
				this._TENDERER_CODE = value;
			}
		}
		/// <summary>
		/// 招标人角色
		/// </summary>
		public string TENDERER_ROLE
		{
			get{ return _TENDERER_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_ROLE, _TENDERER_ROLE, value);
				this._TENDERER_ROLE = value;
			}
		}
		/// <summary>
		/// 招标人企业标识
		/// </summary>
		public string TENDERER_CORPORATE_IDENTITY
		{
			get{ return _TENDERER_CORPORATE_IDENTITY; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_CORPORATE_IDENTITY, _TENDERER_CORPORATE_IDENTITY, value);
				this._TENDERER_CORPORATE_IDENTITY = value;
			}
		}
		/// <summary>
		/// 招标人地址
		/// </summary>
		public string TENDERER_LEGAL_UNIT_ADDRESS
		{
			get{ return _TENDERER_LEGAL_UNIT_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_LEGAL_UNIT_ADDRESS, _TENDERER_LEGAL_UNIT_ADDRESS, value);
				this._TENDERER_LEGAL_UNIT_ADDRESS = value;
			}
		}
		/// <summary>
		/// 招标人邮编
		/// </summary>
		public string TENDERER_LEGAL_ZIP_CODE
		{
			get{ return _TENDERER_LEGAL_ZIP_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_LEGAL_ZIP_CODE, _TENDERER_LEGAL_ZIP_CODE, value);
				this._TENDERER_LEGAL_ZIP_CODE = value;
			}
		}
		/// <summary>
		/// 招标联系人
		/// </summary>
		public string TENDERER_LEGAL_CONTACT
		{
			get{ return _TENDERER_LEGAL_CONTACT; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_LEGAL_CONTACT, _TENDERER_LEGAL_CONTACT, value);
				this._TENDERER_LEGAL_CONTACT = value;
			}
		}
		/// <summary>
		/// 招标人联系电话
		/// </summary>
		public string TENDERER_LEGAL_OFFICE_PHONE
		{
			get{ return _TENDERER_LEGAL_OFFICE_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_LEGAL_OFFICE_PHONE, _TENDERER_LEGAL_OFFICE_PHONE, value);
				this._TENDERER_LEGAL_OFFICE_PHONE = value;
			}
		}
		/// <summary>
		/// 招标人传真
		/// </summary>
		public string TENDERER_LEGAL_FAX
		{
			get{ return _TENDERER_LEGAL_FAX; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_LEGAL_FAX, _TENDERER_LEGAL_FAX, value);
				this._TENDERER_LEGAL_FAX = value;
			}
		}
		/// <summary>
		/// 招标人电子邮箱
		/// </summary>
		public string TENDERER_LEGAL_EMAIL
		{
			get{ return _TENDERER_LEGAL_EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_LEGAL_EMAIL, _TENDERER_LEGAL_EMAIL, value);
				this._TENDERER_LEGAL_EMAIL = value;
			}
		}
		/// <summary>
		/// 招标代理机构名称
		/// </summary>
		public string TENDER_AGENCY_NAME
		{
			get{ return _TENDER_AGENCY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_NAME, _TENDER_AGENCY_NAME, value);
				this._TENDER_AGENCY_NAME = value;
			}
		}
		/// <summary>
		/// 招标代理机构类别
		/// </summary>
		public string TENDER_AGENCY_CODE_TYPE
		{
			get{ return _TENDER_AGENCY_CODE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_CODE_TYPE, _TENDER_AGENCY_CODE_TYPE, value);
				this._TENDER_AGENCY_CODE_TYPE = value;
			}
		}
		/// <summary>
		/// 招标代理机构代码
		/// </summary>
		public string TENDER_AGENCY_CODE
		{
			get{ return _TENDER_AGENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_CODE, _TENDER_AGENCY_CODE, value);
				this._TENDER_AGENCY_CODE = value;
			}
		}
		/// <summary>
		/// 招标代理机构角色
		/// </summary>
		public string TENDER_AGENCY_ROLE
		{
			get{ return _TENDER_AGENCY_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_ROLE, _TENDER_AGENCY_ROLE, value);
				this._TENDER_AGENCY_ROLE = value;
			}
		}
		/// <summary>
		/// 招标人代理机构企业标识
		/// </summary>
		public string TENDERER_AGENCY_IDENTITY
		{
			get{ return _TENDERER_AGENCY_IDENTITY; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_AGENCY_IDENTITY, _TENDERER_AGENCY_IDENTITY, value);
				this._TENDERER_AGENCY_IDENTITY = value;
			}
		}
		/// <summary>
		/// 招标代理机构地址
		/// </summary>
		public string TENDER_AGENCY_ADDRESS
		{
			get{ return _TENDER_AGENCY_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_ADDRESS, _TENDER_AGENCY_ADDRESS, value);
				this._TENDER_AGENCY_ADDRESS = value;
			}
		}
		/// <summary>
		/// 招标代理机构邮编
		/// </summary>
		public string TENDER_AGENCY_LEGAL_ZIP_CODE
		{
			get{ return _TENDER_AGENCY_LEGAL_ZIP_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_LEGAL_ZIP_CODE, _TENDER_AGENCY_LEGAL_ZIP_CODE, value);
				this._TENDER_AGENCY_LEGAL_ZIP_CODE = value;
			}
		}
		/// <summary>
		/// 招标代理机构联系人
		/// </summary>
		public string TENDER_AGENCY_LEGAL_CONTACT
		{
			get{ return _TENDER_AGENCY_LEGAL_CONTACT; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_LEGAL_CONTACT, _TENDER_AGENCY_LEGAL_CONTACT, value);
				this._TENDER_AGENCY_LEGAL_CONTACT = value;
			}
		}
		/// <summary>
		/// 招标代理机构电话
		/// </summary>
		public string TENDER_AGENCY_CONTACT_PHONE
		{
			get{ return _TENDER_AGENCY_CONTACT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_CONTACT_PHONE, _TENDER_AGENCY_CONTACT_PHONE, value);
				this._TENDER_AGENCY_CONTACT_PHONE = value;
			}
		}
		/// <summary>
		/// 招标代理机构传真
		/// </summary>
		public string TENDER_AGENCY_LEGAL_FAX
		{
			get{ return _TENDER_AGENCY_LEGAL_FAX; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_LEGAL_FAX, _TENDER_AGENCY_LEGAL_FAX, value);
				this._TENDER_AGENCY_LEGAL_FAX = value;
			}
		}
		/// <summary>
		/// 招标人代理机构电子邮箱
		/// </summary>
		public string TENDER_AGENCY_LEGAL_EMAIL
		{
			get{ return _TENDER_AGENCY_LEGAL_EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_LEGAL_EMAIL, _TENDER_AGENCY_LEGAL_EMAIL, value);
				this._TENDER_AGENCY_LEGAL_EMAIL = value;
			}
		}
		/// <summary>
		/// 招标方式
		/// </summary>
		public string TENDER_MODE
		{
			get{ return _TENDER_MODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_MODE, _TENDER_MODE, value);
				this._TENDER_MODE = value;
			}
		}
		/// <summary>
		/// 招标组织形式
		/// </summary>
		public string TENDER_ORGANIZE_FORM
		{
			get{ return _TENDER_ORGANIZE_FORM; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_ORGANIZE_FORM, _TENDER_ORGANIZE_FORM, value);
				this._TENDER_ORGANIZE_FORM = value;
			}
		}
		/// <summary>
		/// 招标项目建立时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 监督部门名称
		/// </summary>
		public string SUPERVISE_DEPT_NAME
		{
			get{ return _SUPERVISE_DEPT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_NAME, _SUPERVISE_DEPT_NAME, value);
				this._SUPERVISE_DEPT_NAME = value;
			}
		}
		/// <summary>
		/// 监督部门代码
		/// </summary>
		public string SUPERVISE_DEPT_CODE
		{
			get{ return _SUPERVISE_DEPT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_CODE, _SUPERVISE_DEPT_CODE, value);
				this._SUPERVISE_DEPT_CODE = value;
			}
		}
		/// <summary>
		/// 审核部门名称
		/// </summary>
		public string APPROVE_DEPT_NAME
		{
			get{ return _APPROVE_DEPT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.APPROVE_DEPT_NAME, _APPROVE_DEPT_NAME, value);
				this._APPROVE_DEPT_NAME = value;
			}
		}
		/// <summary>
		/// 审核部门代码
		/// </summary>
		public string APPROVE_DEPT_CODE
		{
			get{ return _APPROVE_DEPT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.APPROVE_DEPT_CODE, _APPROVE_DEPT_CODE, value);
				this._APPROVE_DEPT_CODE = value;
			}
		}
		/// <summary>
		/// 交易系统标识码
		/// </summary>
		public string PLATFORM_CODE
		{
			get{ return _PLATFORM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORM_CODE, _PLATFORM_CODE, value);
				this._PLATFORM_CODE = value;
			}
		}
		/// <summary>
		/// 公共服务平台标识码
		/// </summary>
		public string PUB_SERVICE_PLAT_CODE
		{
			get{ return _PUB_SERVICE_PLAT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PUB_SERVICE_PLAT_CODE, _PUB_SERVICE_PLAT_CODE, value);
				this._PUB_SERVICE_PLAT_CODE = value;
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
		/// 数据自增长ID
		/// </summary>
		public decimal? M_ID
		{
			get{ return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
			}
		}
		/// <summary>
		/// 数据DATA_KEY
		/// </summary>
		public string DATA_KEY
		{
			get{ return _DATA_KEY; }
			set
			{
				this.OnPropertyValueChange(_.DATA_KEY, _DATA_KEY, value);
				this._DATA_KEY = value;
			}
		}
		/// <summary>
		/// 数据来源
		/// </summary>
		public string M_DATA_SOURCE
		{
			get{ return _M_DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_SOURCE, _M_DATA_SOURCE, value);
				this._M_DATA_SOURCE = value;
			}
		}
		/// <summary>
		/// M_CREATEBY
		/// </summary>
		public string M_CREATEBY
		{
			get{ return _M_CREATEBY; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATEBY, _M_CREATEBY, value);
				this._M_CREATEBY = value;
			}
		}
		/// <summary>
		/// M_CREATE_TM
		/// </summary>
		public DateTime? M_CREATE_TM
		{
			get{ return _M_CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATE_TM, _M_CREATE_TM, value);
				this._M_CREATE_TM = value;
			}
		}
		/// <summary>
		/// M_TM
		/// </summary>
		public DateTime? M_TM
		{
			get{ return _M_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_TM, _M_TM, value);
				this._M_TM = value;
			}
		}
		/// <summary>
		/// 相同的招标项目编号的其他表的更新时，更新该时间
		/// </summary>
		public DateTime? OTHER_UPDATE_TIME
		{
			get{ return _OTHER_UPDATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_UPDATE_TIME, _OTHER_UPDATE_TIME, value);
				this._OTHER_UPDATE_TIME = value;
			}
		}
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TENDER_SELF_CODE
		{
			get{ return _TENDER_SELF_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_SELF_CODE, _TENDER_SELF_CODE, value);
				this._TENDER_SELF_CODE = value;
			}
		}
		/// <summary>
		/// 公共资源交易入场登记表
		/// </summary>
		public string M_ATT_PROJECT_REG
		{
			get{ return _M_ATT_PROJECT_REG; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_PROJECT_REG, _M_ATT_PROJECT_REG, value);
				this._M_ATT_PROJECT_REG = value;
			}
		}
		/// <summary>
		/// 招标代理机构承诺书
		/// </summary>
		public string M_ATT_AGENT_COMMIT
		{
			get{ return _M_ATT_AGENT_COMMIT; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_AGENT_COMMIT, _M_ATT_AGENT_COMMIT, value);
				this._M_ATT_AGENT_COMMIT = value;
			}
		}
		/// <summary>
		/// 其他招标代理机构认为需要上传的文件资料
		/// </summary>
		public string M_ATT_OTHER_FILE
		{
			get{ return _M_ATT_OTHER_FILE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_OTHER_FILE, _M_ATT_OTHER_FILE, value);
				this._M_ATT_OTHER_FILE = value;
			}
		}
		/// <summary>
		/// 入场登记表中由行政主管部门明确入场意见
		/// </summary>
		public string M_ATT_PROJECT_REG_APPROVE
		{
			get{ return _M_ATT_PROJECT_REG_APPROVE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_PROJECT_REG_APPROVE, _M_ATT_PROJECT_REG_APPROVE, value);
				this._M_ATT_PROJECT_REG_APPROVE = value;
			}
		}
		/// <summary>
		/// 招标代理合同
		/// </summary>
		public string M_ATT_TENDER_AGENT_CONTRACT
		{
			get{ return _M_ATT_TENDER_AGENT_CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_TENDER_AGENT_CONTRACT, _M_ATT_TENDER_AGENT_CONTRACT, value);
				this._M_ATT_TENDER_AGENT_CONTRACT = value;
			}
		}
		/// <summary>
		/// 主要负责人的授权书
		/// </summary>
		public string M_ATT_COR_AUTHORITY_FILE
		{
			get{ return _M_ATT_COR_AUTHORITY_FILE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_COR_AUTHORITY_FILE, _M_ATT_COR_AUTHORITY_FILE, value);
				this._M_ATT_COR_AUTHORITY_FILE = value;
			}
		}
		/// <summary>
		/// 资金来源落实证明文件
		/// </summary>
		public string M_ATT_FUND_SOURCE_CERTIFY_FILE
		{
			get{ return _M_ATT_FUND_SOURCE_CERTIFY_FILE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_FUND_SOURCE_CERTIFY_FILE, _M_ATT_FUND_SOURCE_CERTIFY_FILE, value);
				this._M_ATT_FUND_SOURCE_CERTIFY_FILE = value;
			}
		}
		/// <summary>
		/// 是否依法必须招标
		/// </summary>
		public string IS_TO_LAW
		{
			get{ return _IS_TO_LAW; }
			set
			{
				this.OnPropertyValueChange(_.IS_TO_LAW, _IS_TO_LAW, value);
				this._IS_TO_LAW = value;
			}
		}
		/// <summary>
		/// 是否联合招标
		/// </summary>
		public string ISUNION
		{
			get{ return _ISUNION; }
			set
			{
				this.OnPropertyValueChange(_.ISUNION, _ISUNION, value);
				this._ISUNION = value;
			}
		}
		/// <summary>
		/// 申报责任人
		/// </summary>
		public string REPORT_DUTY
		{
			get{ return _REPORT_DUTY; }
			set
			{
				this.OnPropertyValueChange(_.REPORT_DUTY, _REPORT_DUTY, value);
				this._REPORT_DUTY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRADE_PLAT
		{
			get{ return _TRADE_PLAT; }
			set
			{
				this.OnPropertyValueChange(_.TRADE_PLAT, _TRADE_PLAT, value);
				this._TRADE_PLAT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PUB_SERVICE_PLAT
		{
			get{ return _PUB_SERVICE_PLAT; }
			set
			{
				this.OnPropertyValueChange(_.PUB_SERVICE_PLAT, _PUB_SERVICE_PLAT, value);
				this._PUB_SERVICE_PLAT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_VERSION
		{
			get{ return _M_VERSION; }
			set
			{
				this.OnPropertyValueChange(_.M_VERSION, _M_VERSION, value);
				this._M_VERSION = value;
			}
		}
		/// <summary>
		/// 招标文件备案编号
		/// </summary>
		public string TENDER_RECORD_CODE
		{
			get{ return _TENDER_RECORD_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_RECORD_CODE, _TENDER_RECORD_CODE, value);
				this._TENDER_RECORD_CODE = value;
			}
		}
		/// <summary>
		/// 招标人企业注册所在地
		/// </summary>
		public string TENDERER_REGION_CODE
		{
			get{ return _TENDERER_REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_REGION_CODE, _TENDERER_REGION_CODE, value);
				this._TENDERER_REGION_CODE = value;
			}
		}
		/// <summary>
		/// 招标人企业性质
		/// </summary>
		public string TENDERER_PROPERTY
		{
			get{ return _TENDERER_PROPERTY; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_PROPERTY, _TENDERER_PROPERTY, value);
				this._TENDERER_PROPERTY = value;
			}
		}
		/// <summary>
		/// 招标代理机构企业注册所在地
		/// </summary>
		public string TENDER_AGENCY_REGION_CODE
		{
			get{ return _TENDER_AGENCY_REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_REGION_CODE, _TENDER_AGENCY_REGION_CODE, value);
				this._TENDER_AGENCY_REGION_CODE = value;
			}
		}
		/// <summary>
		/// 招标代理机构企业性质
		/// </summary>
		public string TENDER_AGENCY_PROPERTY
		{
			get{ return _TENDER_AGENCY_PROPERTY; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_PROPERTY, _TENDER_AGENCY_PROPERTY, value);
				this._TENDER_AGENCY_PROPERTY = value;
			}
		}
		/// <summary>
		/// 信息录入人员
		/// </summary>
		public string OPERATION_NAME
		{
			get{ return _OPERATION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.OPERATION_NAME, _OPERATION_NAME, value);
				this._OPERATION_NAME = value;
			}
		}
		/// <summary>
		/// 交易系统编号
		/// </summary>
		public string TRADE_SYSTEM_NO
		{
			get{ return _TRADE_SYSTEM_NO; }
			set
			{
				this.OnPropertyValueChange(_.TRADE_SYSTEM_NO, _TRADE_SYSTEM_NO, value);
				this._TRADE_SYSTEM_NO = value;
			}
		}
		/// <summary>
		/// 交易系统平台使用费
		/// </summary>
		public decimal? TRADE_SYSTEM_FEE
		{
			get{ return _TRADE_SYSTEM_FEE; }
			set
			{
				this.OnPropertyValueChange(_.TRADE_SYSTEM_FEE, _TRADE_SYSTEM_FEE, value);
				this._TRADE_SYSTEM_FEE = value;
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
				_.M_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.PROJECT_CODE,
				_.TENDER_PROJECT_CODE,
				_.UNIFIED_DEAL_CODE,
				_.TENDER_PROJECT_NAME,
				_.TENDER_PROJECT_TYPE,
				_.REGION_CODE,
				_.TENDER_CONTENT,
				_.OWNER_NAME,
				_.TENDERER_NAME,
				_.TENDERER_CODE_TYPE,
				_.TENDERER_CODE,
				_.TENDERER_ROLE,
				_.TENDERER_CORPORATE_IDENTITY,
				_.TENDERER_LEGAL_UNIT_ADDRESS,
				_.TENDERER_LEGAL_ZIP_CODE,
				_.TENDERER_LEGAL_CONTACT,
				_.TENDERER_LEGAL_OFFICE_PHONE,
				_.TENDERER_LEGAL_FAX,
				_.TENDERER_LEGAL_EMAIL,
				_.TENDER_AGENCY_NAME,
				_.TENDER_AGENCY_CODE_TYPE,
				_.TENDER_AGENCY_CODE,
				_.TENDER_AGENCY_ROLE,
				_.TENDERER_AGENCY_IDENTITY,
				_.TENDER_AGENCY_ADDRESS,
				_.TENDER_AGENCY_LEGAL_ZIP_CODE,
				_.TENDER_AGENCY_LEGAL_CONTACT,
				_.TENDER_AGENCY_CONTACT_PHONE,
				_.TENDER_AGENCY_LEGAL_FAX,
				_.TENDER_AGENCY_LEGAL_EMAIL,
				_.TENDER_MODE,
				_.TENDER_ORGANIZE_FORM,
				_.CREATE_TIME,
				_.SUPERVISE_DEPT_NAME,
				_.SUPERVISE_DEPT_CODE,
				_.APPROVE_DEPT_NAME,
				_.APPROVE_DEPT_CODE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_TM,
				_.OTHER_UPDATE_TIME,
				_.TENDER_SELF_CODE,
				_.M_ATT_PROJECT_REG,
				_.M_ATT_AGENT_COMMIT,
				_.M_ATT_OTHER_FILE,
				_.M_ATT_PROJECT_REG_APPROVE,
				_.M_ATT_TENDER_AGENT_CONTRACT,
				_.M_ATT_COR_AUTHORITY_FILE,
				_.M_ATT_FUND_SOURCE_CERTIFY_FILE,
				_.IS_TO_LAW,
				_.ISUNION,
				_.REPORT_DUTY,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
				_.TENDER_RECORD_CODE,
				_.TENDERER_REGION_CODE,
				_.TENDERER_PROPERTY,
				_.TENDER_AGENCY_REGION_CODE,
				_.TENDER_AGENCY_PROPERTY,
				_.OPERATION_NAME,
				_.TRADE_SYSTEM_NO,
				_.TRADE_SYSTEM_FEE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PROJECT_CODE,
				this._TENDER_PROJECT_CODE,
				this._UNIFIED_DEAL_CODE,
				this._TENDER_PROJECT_NAME,
				this._TENDER_PROJECT_TYPE,
				this._REGION_CODE,
				this._TENDER_CONTENT,
				this._OWNER_NAME,
				this._TENDERER_NAME,
				this._TENDERER_CODE_TYPE,
				this._TENDERER_CODE,
				this._TENDERER_ROLE,
				this._TENDERER_CORPORATE_IDENTITY,
				this._TENDERER_LEGAL_UNIT_ADDRESS,
				this._TENDERER_LEGAL_ZIP_CODE,
				this._TENDERER_LEGAL_CONTACT,
				this._TENDERER_LEGAL_OFFICE_PHONE,
				this._TENDERER_LEGAL_FAX,
				this._TENDERER_LEGAL_EMAIL,
				this._TENDER_AGENCY_NAME,
				this._TENDER_AGENCY_CODE_TYPE,
				this._TENDER_AGENCY_CODE,
				this._TENDER_AGENCY_ROLE,
				this._TENDERER_AGENCY_IDENTITY,
				this._TENDER_AGENCY_ADDRESS,
				this._TENDER_AGENCY_LEGAL_ZIP_CODE,
				this._TENDER_AGENCY_LEGAL_CONTACT,
				this._TENDER_AGENCY_CONTACT_PHONE,
				this._TENDER_AGENCY_LEGAL_FAX,
				this._TENDER_AGENCY_LEGAL_EMAIL,
				this._TENDER_MODE,
				this._TENDER_ORGANIZE_FORM,
				this._CREATE_TIME,
				this._SUPERVISE_DEPT_NAME,
				this._SUPERVISE_DEPT_CODE,
				this._APPROVE_DEPT_NAME,
				this._APPROVE_DEPT_CODE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_TM,
				this._OTHER_UPDATE_TIME,
				this._TENDER_SELF_CODE,
				this._M_ATT_PROJECT_REG,
				this._M_ATT_AGENT_COMMIT,
				this._M_ATT_OTHER_FILE,
				this._M_ATT_PROJECT_REG_APPROVE,
				this._M_ATT_TENDER_AGENT_CONTRACT,
				this._M_ATT_COR_AUTHORITY_FILE,
				this._M_ATT_FUND_SOURCE_CERTIFY_FILE,
				this._IS_TO_LAW,
				this._ISUNION,
				this._REPORT_DUTY,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._M_VERSION,
				this._TENDER_RECORD_CODE,
				this._TENDERER_REGION_CODE,
				this._TENDERER_PROPERTY,
				this._TENDER_AGENCY_REGION_CODE,
				this._TENDER_AGENCY_PROPERTY,
				this._OPERATION_NAME,
				this._TRADE_SYSTEM_NO,
				this._TRADE_SYSTEM_FEE,
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
			public readonly static Field All = new Field("*", "SL_TENDER_PROJECT");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "SL_TENDER_PROJECT", "项目编号");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "SL_TENDER_PROJECT", "招标项目编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "SL_TENDER_PROJECT", "统一交易标识码");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "SL_TENDER_PROJECT", "招标项目名称");
            /// <summary>
			/// 招标项目类型
			/// </summary>
			public readonly static Field TENDER_PROJECT_TYPE = new Field("TENDER_PROJECT_TYPE", "SL_TENDER_PROJECT", "招标项目类型");
            /// <summary>
			/// 招标项目所在行政区域代码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "SL_TENDER_PROJECT", "招标项目所在行政区域代码");
            /// <summary>
			/// 招标内容与范围及招标方案说明
			/// </summary>
			public readonly static Field TENDER_CONTENT = new Field("TENDER_CONTENT", "SL_TENDER_PROJECT",DbType.AnsiString, null, "招标内容与范围及招标方案说明");
            /// <summary>
			/// 项目业主名称
			/// </summary>
			public readonly static Field OWNER_NAME = new Field("OWNER_NAME", "SL_TENDER_PROJECT", "项目业主名称");
            /// <summary>
			/// 招标人名称
			/// </summary>
			public readonly static Field TENDERER_NAME = new Field("TENDERER_NAME", "SL_TENDER_PROJECT", "招标人名称");
            /// <summary>
			/// 招标人类别
			/// </summary>
			public readonly static Field TENDERER_CODE_TYPE = new Field("TENDERER_CODE_TYPE", "SL_TENDER_PROJECT", "招标人类别");
            /// <summary>
			/// 招标人代码
			/// </summary>
			public readonly static Field TENDERER_CODE = new Field("TENDERER_CODE", "SL_TENDER_PROJECT", "招标人代码");
            /// <summary>
			/// 招标人角色
			/// </summary>
			public readonly static Field TENDERER_ROLE = new Field("TENDERER_ROLE", "SL_TENDER_PROJECT", "招标人角色");
            /// <summary>
			/// 招标人企业标识
			/// </summary>
			public readonly static Field TENDERER_CORPORATE_IDENTITY = new Field("TENDERER_CORPORATE_IDENTITY", "SL_TENDER_PROJECT", "招标人企业标识");
            /// <summary>
			/// 招标人地址
			/// </summary>
			public readonly static Field TENDERER_LEGAL_UNIT_ADDRESS = new Field("TENDERER_LEGAL_UNIT_ADDRESS", "SL_TENDER_PROJECT", "招标人地址");
            /// <summary>
			/// 招标人邮编
			/// </summary>
			public readonly static Field TENDERER_LEGAL_ZIP_CODE = new Field("TENDERER_LEGAL_ZIP_CODE", "SL_TENDER_PROJECT", "招标人邮编");
            /// <summary>
			/// 招标联系人
			/// </summary>
			public readonly static Field TENDERER_LEGAL_CONTACT = new Field("TENDERER_LEGAL_CONTACT", "SL_TENDER_PROJECT", "招标联系人");
            /// <summary>
			/// 招标人联系电话
			/// </summary>
			public readonly static Field TENDERER_LEGAL_OFFICE_PHONE = new Field("TENDERER_LEGAL_OFFICE_PHONE", "SL_TENDER_PROJECT", "招标人联系电话");
            /// <summary>
			/// 招标人传真
			/// </summary>
			public readonly static Field TENDERER_LEGAL_FAX = new Field("TENDERER_LEGAL_FAX", "SL_TENDER_PROJECT", "招标人传真");
            /// <summary>
			/// 招标人电子邮箱
			/// </summary>
			public readonly static Field TENDERER_LEGAL_EMAIL = new Field("TENDERER_LEGAL_EMAIL", "SL_TENDER_PROJECT", "招标人电子邮箱");
            /// <summary>
			/// 招标代理机构名称
			/// </summary>
			public readonly static Field TENDER_AGENCY_NAME = new Field("TENDER_AGENCY_NAME", "SL_TENDER_PROJECT", "招标代理机构名称");
            /// <summary>
			/// 招标代理机构类别
			/// </summary>
			public readonly static Field TENDER_AGENCY_CODE_TYPE = new Field("TENDER_AGENCY_CODE_TYPE", "SL_TENDER_PROJECT", "招标代理机构类别");
            /// <summary>
			/// 招标代理机构代码
			/// </summary>
			public readonly static Field TENDER_AGENCY_CODE = new Field("TENDER_AGENCY_CODE", "SL_TENDER_PROJECT", "招标代理机构代码");
            /// <summary>
			/// 招标代理机构角色
			/// </summary>
			public readonly static Field TENDER_AGENCY_ROLE = new Field("TENDER_AGENCY_ROLE", "SL_TENDER_PROJECT", "招标代理机构角色");
            /// <summary>
			/// 招标人代理机构企业标识
			/// </summary>
			public readonly static Field TENDERER_AGENCY_IDENTITY = new Field("TENDERER_AGENCY_IDENTITY", "SL_TENDER_PROJECT", "招标人代理机构企业标识");
            /// <summary>
			/// 招标代理机构地址
			/// </summary>
			public readonly static Field TENDER_AGENCY_ADDRESS = new Field("TENDER_AGENCY_ADDRESS", "SL_TENDER_PROJECT", "招标代理机构地址");
            /// <summary>
			/// 招标代理机构邮编
			/// </summary>
			public readonly static Field TENDER_AGENCY_LEGAL_ZIP_CODE = new Field("TENDER_AGENCY_LEGAL_ZIP_CODE", "SL_TENDER_PROJECT", "招标代理机构邮编");
            /// <summary>
			/// 招标代理机构联系人
			/// </summary>
			public readonly static Field TENDER_AGENCY_LEGAL_CONTACT = new Field("TENDER_AGENCY_LEGAL_CONTACT", "SL_TENDER_PROJECT", "招标代理机构联系人");
            /// <summary>
			/// 招标代理机构电话
			/// </summary>
			public readonly static Field TENDER_AGENCY_CONTACT_PHONE = new Field("TENDER_AGENCY_CONTACT_PHONE", "SL_TENDER_PROJECT", "招标代理机构电话");
            /// <summary>
			/// 招标代理机构传真
			/// </summary>
			public readonly static Field TENDER_AGENCY_LEGAL_FAX = new Field("TENDER_AGENCY_LEGAL_FAX", "SL_TENDER_PROJECT", "招标代理机构传真");
            /// <summary>
			/// 招标人代理机构电子邮箱
			/// </summary>
			public readonly static Field TENDER_AGENCY_LEGAL_EMAIL = new Field("TENDER_AGENCY_LEGAL_EMAIL", "SL_TENDER_PROJECT", "招标人代理机构电子邮箱");
            /// <summary>
			/// 招标方式
			/// </summary>
			public readonly static Field TENDER_MODE = new Field("TENDER_MODE", "SL_TENDER_PROJECT", "招标方式");
            /// <summary>
			/// 招标组织形式
			/// </summary>
			public readonly static Field TENDER_ORGANIZE_FORM = new Field("TENDER_ORGANIZE_FORM", "SL_TENDER_PROJECT", "招标组织形式");
            /// <summary>
			/// 招标项目建立时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "SL_TENDER_PROJECT", "招标项目建立时间");
            /// <summary>
			/// 监督部门名称
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME = new Field("SUPERVISE_DEPT_NAME", "SL_TENDER_PROJECT", "监督部门名称");
            /// <summary>
			/// 监督部门代码
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_CODE = new Field("SUPERVISE_DEPT_CODE", "SL_TENDER_PROJECT", "监督部门代码");
            /// <summary>
			/// 审核部门名称
			/// </summary>
			public readonly static Field APPROVE_DEPT_NAME = new Field("APPROVE_DEPT_NAME", "SL_TENDER_PROJECT", "审核部门名称");
            /// <summary>
			/// 审核部门代码
			/// </summary>
			public readonly static Field APPROVE_DEPT_CODE = new Field("APPROVE_DEPT_CODE", "SL_TENDER_PROJECT", "审核部门代码");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "SL_TENDER_PROJECT", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "SL_TENDER_PROJECT", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "SL_TENDER_PROJECT", "数据时间戳");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "SL_TENDER_PROJECT", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "SL_TENDER_PROJECT", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "SL_TENDER_PROJECT", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "SL_TENDER_PROJECT", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "SL_TENDER_PROJECT", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "SL_TENDER_PROJECT", "M_TM");
            /// <summary>
			/// 相同的招标项目编号的其他表的更新时，更新该时间
			/// </summary>
			public readonly static Field OTHER_UPDATE_TIME = new Field("OTHER_UPDATE_TIME", "SL_TENDER_PROJECT", "相同的招标项目编号的其他表的更新时，更新该时间");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_SELF_CODE = new Field("TENDER_SELF_CODE", "SL_TENDER_PROJECT", "招标项目编号");
            /// <summary>
			/// 公共资源交易入场登记表
			/// </summary>
			public readonly static Field M_ATT_PROJECT_REG = new Field("M_ATT_PROJECT_REG", "SL_TENDER_PROJECT", "公共资源交易入场登记表");
            /// <summary>
			/// 招标代理机构承诺书
			/// </summary>
			public readonly static Field M_ATT_AGENT_COMMIT = new Field("M_ATT_AGENT_COMMIT", "SL_TENDER_PROJECT", "招标代理机构承诺书");
            /// <summary>
			/// 其他招标代理机构认为需要上传的文件资料
			/// </summary>
			public readonly static Field M_ATT_OTHER_FILE = new Field("M_ATT_OTHER_FILE", "SL_TENDER_PROJECT", "其他招标代理机构认为需要上传的文件资料");
            /// <summary>
			/// 入场登记表中由行政主管部门明确入场意见
			/// </summary>
			public readonly static Field M_ATT_PROJECT_REG_APPROVE = new Field("M_ATT_PROJECT_REG_APPROVE", "SL_TENDER_PROJECT", "入场登记表中由行政主管部门明确入场意见");
            /// <summary>
			/// 招标代理合同
			/// </summary>
			public readonly static Field M_ATT_TENDER_AGENT_CONTRACT = new Field("M_ATT_TENDER_AGENT_CONTRACT", "SL_TENDER_PROJECT", "招标代理合同");
            /// <summary>
			/// 主要负责人的授权书
			/// </summary>
			public readonly static Field M_ATT_COR_AUTHORITY_FILE = new Field("M_ATT_COR_AUTHORITY_FILE", "SL_TENDER_PROJECT", "主要负责人的授权书");
            /// <summary>
			/// 资金来源落实证明文件
			/// </summary>
			public readonly static Field M_ATT_FUND_SOURCE_CERTIFY_FILE = new Field("M_ATT_FUND_SOURCE_CERTIFY_FILE", "SL_TENDER_PROJECT", "资金来源落实证明文件");
            /// <summary>
			/// 是否依法必须招标
			/// </summary>
			public readonly static Field IS_TO_LAW = new Field("IS_TO_LAW", "SL_TENDER_PROJECT", "是否依法必须招标");
            /// <summary>
			/// 是否联合招标
			/// </summary>
			public readonly static Field ISUNION = new Field("ISUNION", "SL_TENDER_PROJECT", "是否联合招标");
            /// <summary>
			/// 申报责任人
			/// </summary>
			public readonly static Field REPORT_DUTY = new Field("REPORT_DUTY", "SL_TENDER_PROJECT", "申报责任人");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "SL_TENDER_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "SL_TENDER_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "SL_TENDER_PROJECT", "");
            /// <summary>
			/// 招标文件备案编号
			/// </summary>
			public readonly static Field TENDER_RECORD_CODE = new Field("TENDER_RECORD_CODE", "SL_TENDER_PROJECT", "招标文件备案编号");
            /// <summary>
			/// 招标人企业注册所在地
			/// </summary>
			public readonly static Field TENDERER_REGION_CODE = new Field("TENDERER_REGION_CODE", "SL_TENDER_PROJECT", "招标人企业注册所在地");
            /// <summary>
			/// 招标人企业性质
			/// </summary>
			public readonly static Field TENDERER_PROPERTY = new Field("TENDERER_PROPERTY", "SL_TENDER_PROJECT", "招标人企业性质");
            /// <summary>
			/// 招标代理机构企业注册所在地
			/// </summary>
			public readonly static Field TENDER_AGENCY_REGION_CODE = new Field("TENDER_AGENCY_REGION_CODE", "SL_TENDER_PROJECT", "招标代理机构企业注册所在地");
            /// <summary>
			/// 招标代理机构企业性质
			/// </summary>
			public readonly static Field TENDER_AGENCY_PROPERTY = new Field("TENDER_AGENCY_PROPERTY", "SL_TENDER_PROJECT", "招标代理机构企业性质");
            /// <summary>
			/// 信息录入人员
			/// </summary>
			public readonly static Field OPERATION_NAME = new Field("OPERATION_NAME", "SL_TENDER_PROJECT", "信息录入人员");
            /// <summary>
			/// 交易系统编号
			/// </summary>
			public readonly static Field TRADE_SYSTEM_NO = new Field("TRADE_SYSTEM_NO", "SL_TENDER_PROJECT", "交易系统编号");
            /// <summary>
			/// 交易系统平台使用费
			/// </summary>
			public readonly static Field TRADE_SYSTEM_FEE = new Field("TRADE_SYSTEM_FEE", "SL_TENDER_PROJECT", "交易系统平台使用费");
        }
        #endregion
	}
}