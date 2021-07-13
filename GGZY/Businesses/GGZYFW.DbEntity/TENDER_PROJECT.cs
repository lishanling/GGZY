using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TENDER_PROJECT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TENDER_PROJECT")]
    [Serializable]
    public partial class TENDER_PROJECT : FwEntity
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
		private string _TENDER_AGENCY_NAME;
		private string _TENDER_AGENCY_CODE_TYPE;
		private string _TENDER_AGENCY_CODE;
		private string _TENDER_AGENCY_ROLE;
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
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_CREATOR;
		private decimal? _M_ID;
		private string _M_ATT_PROJECT_REG;
		private string _M_ATT_AGENT_COMMIT;
		private string _M_ATT_OTHER_FILE;
		private string _M_ATT_PROJECT_REG_APPROVE;
		private string _M_ATT_TENDER_AGENT_CONTRACT;
		private string _TENDER_PROJECT_CODE_OLD1;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _TENDER_SELF_CODE;
		private string _ISUNION;
		private string _REPORT_DUTY;
		private string _M_ATT_COR_AUTHORITY_FILE;
		private string _M_ATT_FUND_SOURCE_CERTIFY_FILE;
		private DateTime? _OTHER_UPDATE_TIME;
		private string _IS_TO_LAW;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;
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
		/// 
		/// </summary>
		public string M_KEY
		{
			get{ return _M_KEY; }
			set
			{
				this.OnPropertyValueChange(_.M_KEY, _M_KEY, value);
				this._M_KEY = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
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
		/// 创建人
		/// </summary>
		public decimal? M_CREATOR
		{
			get{ return _M_CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATOR, _M_CREATOR, value);
				this._M_CREATOR = value;
			}
		}
		/// <summary>
		/// 
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
		/// 招标项目编号旧的编码 各个代理机构自己的编码
		/// </summary>
		public string TENDER_PROJECT_CODE_OLD1
		{
			get{ return _TENDER_PROJECT_CODE_OLD1; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE_OLD1, _TENDER_PROJECT_CODE_OLD1, value);
				this._TENDER_PROJECT_CODE_OLD1 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_IS_HISTORY
		{
			get{ return _M_IS_HISTORY; }
			set
			{
				this.OnPropertyValueChange(_.M_IS_HISTORY, _M_IS_HISTORY, value);
				this._M_IS_HISTORY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_CREATEBY
		{
			get{ return _M_CREATEBY; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATEBY, _M_CREATEBY, value);
				this._M_CREATEBY = value;
			}
		}
		/// <summary>
		/// 
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
		/// 招标单位自行编码的招标项目编码
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
				_.TENDER_AGENCY_NAME,
				_.TENDER_AGENCY_CODE_TYPE,
				_.TENDER_AGENCY_CODE,
				_.TENDER_AGENCY_ROLE,
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
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_CREATOR,
				_.M_ID,
				_.M_ATT_PROJECT_REG,
				_.M_ATT_AGENT_COMMIT,
				_.M_ATT_OTHER_FILE,
				_.M_ATT_PROJECT_REG_APPROVE,
				_.M_ATT_TENDER_AGENT_CONTRACT,
				_.TENDER_PROJECT_CODE_OLD1,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.TENDER_SELF_CODE,
				_.ISUNION,
				_.REPORT_DUTY,
				_.M_ATT_COR_AUTHORITY_FILE,
				_.M_ATT_FUND_SOURCE_CERTIFY_FILE,
				_.OTHER_UPDATE_TIME,
				_.IS_TO_LAW,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
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
				this._TENDER_AGENCY_NAME,
				this._TENDER_AGENCY_CODE_TYPE,
				this._TENDER_AGENCY_CODE,
				this._TENDER_AGENCY_ROLE,
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
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_CREATOR,
				this._M_ID,
				this._M_ATT_PROJECT_REG,
				this._M_ATT_AGENT_COMMIT,
				this._M_ATT_OTHER_FILE,
				this._M_ATT_PROJECT_REG_APPROVE,
				this._M_ATT_TENDER_AGENT_CONTRACT,
				this._TENDER_PROJECT_CODE_OLD1,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._TENDER_SELF_CODE,
				this._ISUNION,
				this._REPORT_DUTY,
				this._M_ATT_COR_AUTHORITY_FILE,
				this._M_ATT_FUND_SOURCE_CERTIFY_FILE,
				this._OTHER_UPDATE_TIME,
				this._IS_TO_LAW,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._M_VERSION,
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
			public readonly static Field All = new Field("*", "TENDER_PROJECT");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "TENDER_PROJECT", "项目编号");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "TENDER_PROJECT", "招标项目编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "TENDER_PROJECT", "统一交易标识码");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "TENDER_PROJECT", "招标项目名称");
            /// <summary>
			/// 招标项目类型
			/// </summary>
			public readonly static Field TENDER_PROJECT_TYPE = new Field("TENDER_PROJECT_TYPE", "TENDER_PROJECT", "招标项目类型");
            /// <summary>
			/// 招标项目所在行政区域代码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "TENDER_PROJECT", "招标项目所在行政区域代码");
            /// <summary>
			/// 招标内容与范围及招标方案说明
			/// </summary>
			public readonly static Field TENDER_CONTENT = new Field("TENDER_CONTENT", "TENDER_PROJECT",DbType.AnsiString, null, "招标内容与范围及招标方案说明");
            /// <summary>
			/// 项目业主名称
			/// </summary>
			public readonly static Field OWNER_NAME = new Field("OWNER_NAME", "TENDER_PROJECT", "项目业主名称");
            /// <summary>
			/// 招标人名称
			/// </summary>
			public readonly static Field TENDERER_NAME = new Field("TENDERER_NAME", "TENDER_PROJECT", "招标人名称");
            /// <summary>
			/// 招标人类别
			/// </summary>
			public readonly static Field TENDERER_CODE_TYPE = new Field("TENDERER_CODE_TYPE", "TENDER_PROJECT", "招标人类别");
            /// <summary>
			/// 招标人代码
			/// </summary>
			public readonly static Field TENDERER_CODE = new Field("TENDERER_CODE", "TENDER_PROJECT", "招标人代码");
            /// <summary>
			/// 招标人角色
			/// </summary>
			public readonly static Field TENDERER_ROLE = new Field("TENDERER_ROLE", "TENDER_PROJECT", "招标人角色");
            /// <summary>
			/// 招标代理机构名称
			/// </summary>
			public readonly static Field TENDER_AGENCY_NAME = new Field("TENDER_AGENCY_NAME", "TENDER_PROJECT", "招标代理机构名称");
            /// <summary>
			/// 招标代理机构类别
			/// </summary>
			public readonly static Field TENDER_AGENCY_CODE_TYPE = new Field("TENDER_AGENCY_CODE_TYPE", "TENDER_PROJECT", "招标代理机构类别");
            /// <summary>
			/// 招标代理机构代码
			/// </summary>
			public readonly static Field TENDER_AGENCY_CODE = new Field("TENDER_AGENCY_CODE", "TENDER_PROJECT", "招标代理机构代码");
            /// <summary>
			/// 招标代理机构角色
			/// </summary>
			public readonly static Field TENDER_AGENCY_ROLE = new Field("TENDER_AGENCY_ROLE", "TENDER_PROJECT", "招标代理机构角色");
            /// <summary>
			/// 招标方式
			/// </summary>
			public readonly static Field TENDER_MODE = new Field("TENDER_MODE", "TENDER_PROJECT", "招标方式");
            /// <summary>
			/// 招标组织形式
			/// </summary>
			public readonly static Field TENDER_ORGANIZE_FORM = new Field("TENDER_ORGANIZE_FORM", "TENDER_PROJECT", "招标组织形式");
            /// <summary>
			/// 招标项目建立时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "TENDER_PROJECT", "招标项目建立时间");
            /// <summary>
			/// 监督部门名称
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME = new Field("SUPERVISE_DEPT_NAME", "TENDER_PROJECT", "监督部门名称");
            /// <summary>
			/// 监督部门代码
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_CODE = new Field("SUPERVISE_DEPT_CODE", "TENDER_PROJECT", "监督部门代码");
            /// <summary>
			/// 审核部门名称
			/// </summary>
			public readonly static Field APPROVE_DEPT_NAME = new Field("APPROVE_DEPT_NAME", "TENDER_PROJECT", "审核部门名称");
            /// <summary>
			/// 审核部门代码
			/// </summary>
			public readonly static Field APPROVE_DEPT_CODE = new Field("APPROVE_DEPT_CODE", "TENDER_PROJECT", "审核部门代码");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "TENDER_PROJECT", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "TENDER_PROJECT", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "TENDER_PROJECT", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "TENDER_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "TENDER_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "TENDER_PROJECT", "");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "TENDER_PROJECT", "创建人");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "TENDER_PROJECT", "");
            /// <summary>
			/// 公共资源交易入场登记表
			/// </summary>
			public readonly static Field M_ATT_PROJECT_REG = new Field("M_ATT_PROJECT_REG", "TENDER_PROJECT", "公共资源交易入场登记表");
            /// <summary>
			/// 招标代理机构承诺书
			/// </summary>
			public readonly static Field M_ATT_AGENT_COMMIT = new Field("M_ATT_AGENT_COMMIT", "TENDER_PROJECT", "招标代理机构承诺书");
            /// <summary>
			/// 其他招标代理机构认为需要上传的文件资料
			/// </summary>
			public readonly static Field M_ATT_OTHER_FILE = new Field("M_ATT_OTHER_FILE", "TENDER_PROJECT", "其他招标代理机构认为需要上传的文件资料");
            /// <summary>
			/// 入场登记表中由行政主管部门明确入场意见
			/// </summary>
			public readonly static Field M_ATT_PROJECT_REG_APPROVE = new Field("M_ATT_PROJECT_REG_APPROVE", "TENDER_PROJECT", "入场登记表中由行政主管部门明确入场意见");
            /// <summary>
			/// 招标代理合同
			/// </summary>
			public readonly static Field M_ATT_TENDER_AGENT_CONTRACT = new Field("M_ATT_TENDER_AGENT_CONTRACT", "TENDER_PROJECT", "招标代理合同");
            /// <summary>
			/// 招标项目编号旧的编码 各个代理机构自己的编码
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE_OLD1 = new Field("TENDER_PROJECT_CODE_OLD1", "TENDER_PROJECT", "招标项目编号旧的编码 各个代理机构自己的编码");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "TENDER_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "TENDER_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "TENDER_PROJECT", "");
            /// <summary>
			/// 招标单位自行编码的招标项目编码
			/// </summary>
			public readonly static Field TENDER_SELF_CODE = new Field("TENDER_SELF_CODE", "TENDER_PROJECT", "招标单位自行编码的招标项目编码");
            /// <summary>
			/// 是否联合招标
			/// </summary>
			public readonly static Field ISUNION = new Field("ISUNION", "TENDER_PROJECT", "是否联合招标");
            /// <summary>
			/// 申报责任人
			/// </summary>
			public readonly static Field REPORT_DUTY = new Field("REPORT_DUTY", "TENDER_PROJECT", "申报责任人");
            /// <summary>
			/// 主要负责人的授权书
			/// </summary>
			public readonly static Field M_ATT_COR_AUTHORITY_FILE = new Field("M_ATT_COR_AUTHORITY_FILE", "TENDER_PROJECT", "主要负责人的授权书");
            /// <summary>
			/// 资金来源落实证明文件
			/// </summary>
			public readonly static Field M_ATT_FUND_SOURCE_CERTIFY_FILE = new Field("M_ATT_FUND_SOURCE_CERTIFY_FILE", "TENDER_PROJECT", "资金来源落实证明文件");
            /// <summary>
			/// 相同的招标项目编号的其他表的更新时，更新该时间
			/// </summary>
			public readonly static Field OTHER_UPDATE_TIME = new Field("OTHER_UPDATE_TIME", "TENDER_PROJECT", "相同的招标项目编号的其他表的更新时，更新该时间");
            /// <summary>
			/// 是否依法必须招标
			/// </summary>
			public readonly static Field IS_TO_LAW = new Field("IS_TO_LAW", "TENDER_PROJECT", "是否依法必须招标");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "TENDER_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "TENDER_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "TENDER_PROJECT", "");
            /// <summary>
			/// 招标人企业注册所在地
			/// </summary>
			public readonly static Field TENDERER_REGION_CODE = new Field("TENDERER_REGION_CODE", "TENDER_PROJECT", "招标人企业注册所在地");
            /// <summary>
			/// 招标人企业性质
			/// </summary>
			public readonly static Field TENDERER_PROPERTY = new Field("TENDERER_PROPERTY", "TENDER_PROJECT", "招标人企业性质");
            /// <summary>
			/// 招标代理机构企业注册所在地
			/// </summary>
			public readonly static Field TENDER_AGENCY_REGION_CODE = new Field("TENDER_AGENCY_REGION_CODE", "TENDER_PROJECT", "招标代理机构企业注册所在地");
            /// <summary>
			/// 招标代理机构企业性质
			/// </summary>
			public readonly static Field TENDER_AGENCY_PROPERTY = new Field("TENDER_AGENCY_PROPERTY", "TENDER_PROJECT", "招标代理机构企业性质");
            /// <summary>
			/// 信息录入人员
			/// </summary>
			public readonly static Field OPERATION_NAME = new Field("OPERATION_NAME", "TENDER_PROJECT", "信息录入人员");
            /// <summary>
			/// 交易系统编号
			/// </summary>
			public readonly static Field TRADE_SYSTEM_NO = new Field("TRADE_SYSTEM_NO", "TENDER_PROJECT", "交易系统编号");
            /// <summary>
			/// 交易系统平台使用费
			/// </summary>
			public readonly static Field TRADE_SYSTEM_FEE = new Field("TRADE_SYSTEM_FEE", "TENDER_PROJECT", "交易系统平台使用费");
        }
        #endregion
	}
}