using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类TENDER_PROJECT。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TENDER_PROJECT")]
	[Serializable]
	public partial class TENDER_PROJECT : JdEntity
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
		private string _TENDER_PROJECT_CODE_OLD1;
		private string _RECORD_DEPID;
		private string _CONSTRUCTION_ID;
		private decimal? _M_ID;
		private string _M_ATT_PROJECT_REG;
		private string _M_ATT_AGENT_COMMIT;
		private string _M_ATT_OTHER_FILE;
		private string _M_ATT_PROJECT_REG_APPROVE;
		private string _M_ATT_TENDER_AGENT_CONTRACT;
		private decimal? _M_CREATOR;
		private DateTime? _M_CREATE_TM;
		private string _TENDERER_CONTRACT;
		private string _TENDERER_PHONE;
		private string _TENDER_AGENT_CONTRACT;
		private string _TENDER_AGENT_PHONE;
		private string _TENDER_DOCNAME;
		private string _RTYPE;
		private string _OTHER_DEPID;
		private decimal? _M_ID_GGFW;
		private string _TENDERER_BANK_ACCOUNT;
		private string _TENDERER_BANK_OPENBANK;
		private string _TENDERER_BANK_CODE;
		private decimal? _IS_PROJECT;

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
		/// 招标项目编号
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get { return _TENDER_PROJECT_CODE; }
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
			get { return _UNIFIED_DEAL_CODE; }
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
			get { return _TENDER_PROJECT_NAME; }
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
			get { return _TENDER_PROJECT_TYPE; }
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
			get { return _REGION_CODE; }
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
			get { return _TENDER_CONTENT; }
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
			get { return _OWNER_NAME; }
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
			get { return _TENDERER_NAME; }
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
			get { return _TENDERER_CODE_TYPE; }
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
			get { return _TENDERER_CODE; }
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
			get { return _TENDERER_ROLE; }
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
			get { return _TENDER_AGENCY_NAME; }
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
			get { return _TENDER_AGENCY_CODE_TYPE; }
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
			get { return _TENDER_AGENCY_CODE; }
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
			get { return _TENDER_AGENCY_ROLE; }
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
			get { return _TENDER_MODE; }
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
			get { return _TENDER_ORGANIZE_FORM; }
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
			get { return _CREATE_TIME; }
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
			get { return _SUPERVISE_DEPT_NAME; }
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
			get { return _SUPERVISE_DEPT_CODE; }
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
			get { return _APPROVE_DEPT_NAME; }
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
			get { return _APPROVE_DEPT_CODE; }
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
			get { return _PLATFORM_CODE; }
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
			get { return _PUB_SERVICE_PLAT_CODE; }
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
			get { return _DATA_TIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATA_TIMESTAMP, _DATA_TIMESTAMP, value);
				this._DATA_TIMESTAMP = value;
			}
		}
		/// <summary>
		/// 招标项目编号旧的编码 各个代理机构自己的编码
		/// </summary>
		public string TENDER_PROJECT_CODE_OLD1
		{
			get { return _TENDER_PROJECT_CODE_OLD1; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE_OLD1, _TENDER_PROJECT_CODE_OLD1, value);
				this._TENDER_PROJECT_CODE_OLD1 = value;
			}
		}
		/// <summary>
		/// 备案部门ID
		/// </summary>
		public string RECORD_DEPID
		{
			get { return _RECORD_DEPID; }
			set
			{
				this.OnPropertyValueChange(_.RECORD_DEPID, _RECORD_DEPID, value);
				this._RECORD_DEPID = value;
			}
		}
		/// <summary>
		/// 报建编号
		/// </summary>
		public string CONSTRUCTION_ID
		{
			get { return _CONSTRUCTION_ID; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCTION_ID, _CONSTRUCTION_ID, value);
				this._CONSTRUCTION_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_ID
		{
			get { return _M_ID; }
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
			get { return _M_ATT_PROJECT_REG; }
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
			get { return _M_ATT_AGENT_COMMIT; }
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
			get { return _M_ATT_OTHER_FILE; }
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
			get { return _M_ATT_PROJECT_REG_APPROVE; }
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
			get { return _M_ATT_TENDER_AGENT_CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_TENDER_AGENT_CONTRACT, _M_ATT_TENDER_AGENT_CONTRACT, value);
				this._M_ATT_TENDER_AGENT_CONTRACT = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public decimal? M_CREATOR
		{
			get { return _M_CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATOR, _M_CREATOR, value);
				this._M_CREATOR = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? M_CREATE_TM
		{
			get { return _M_CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATE_TM, _M_CREATE_TM, value);
				this._M_CREATE_TM = value;
			}
		}
		/// <summary>
		/// 招标联系人
		/// </summary>
		public string TENDERER_CONTRACT
		{
			get { return _TENDERER_CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_CONTRACT, _TENDERER_CONTRACT, value);
				this._TENDERER_CONTRACT = value;
			}
		}
		/// <summary>
		/// 招标人联系电话
		/// </summary>
		public string TENDERER_PHONE
		{
			get { return _TENDERER_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_PHONE, _TENDERER_PHONE, value);
				this._TENDERER_PHONE = value;
			}
		}
		/// <summary>
		/// 招标代理联系人
		/// </summary>
		public string TENDER_AGENT_CONTRACT
		{
			get { return _TENDER_AGENT_CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENT_CONTRACT, _TENDER_AGENT_CONTRACT, value);
				this._TENDER_AGENT_CONTRACT = value;
			}
		}
		/// <summary>
		/// 招标代理联系电话
		/// </summary>
		public string TENDER_AGENT_PHONE
		{
			get { return _TENDER_AGENT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENT_PHONE, _TENDER_AGENT_PHONE, value);
				this._TENDER_AGENT_PHONE = value;
			}
		}
		/// <summary>
		/// 招标文件名称
		/// </summary>
		public string TENDER_DOCNAME
		{
			get { return _TENDER_DOCNAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_DOCNAME, _TENDER_DOCNAME, value);
				this._TENDER_DOCNAME = value;
			}
		}
		/// <summary>
		/// 备案类型
		/// </summary>
		public string RTYPE
		{
			get { return _RTYPE; }
			set
			{
				this.OnPropertyValueChange(_.RTYPE, _RTYPE, value);
				this._RTYPE = value;
			}
		}
		/// <summary>
		/// 抄送部门ID
		/// </summary>
		public string OTHER_DEPID
		{
			get { return _OTHER_DEPID; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_DEPID, _OTHER_DEPID, value);
				this._OTHER_DEPID = value;
			}
		}
		/// <summary>
		/// 公共平台，招标项目表M_ID
		/// </summary>
		public decimal? M_ID_GGFW
		{
			get { return _M_ID_GGFW; }
			set
			{
				this.OnPropertyValueChange(_.M_ID_GGFW, _M_ID_GGFW, value);
				this._M_ID_GGFW = value;
			}
		}
		/// <summary>
		/// 招标人银行账户名称
		/// </summary>
		public string TENDERER_BANK_ACCOUNT
		{
			get { return _TENDERER_BANK_ACCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_BANK_ACCOUNT, _TENDERER_BANK_ACCOUNT, value);
				this._TENDERER_BANK_ACCOUNT = value;
			}
		}
		/// <summary>
		/// 招标人银行开户行
		/// </summary>
		public string TENDERER_BANK_OPENBANK
		{
			get { return _TENDERER_BANK_OPENBANK; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_BANK_OPENBANK, _TENDERER_BANK_OPENBANK, value);
				this._TENDERER_BANK_OPENBANK = value;
			}
		}
		/// <summary>
		/// 招标人银行账号
		/// </summary>
		public string TENDERER_BANK_CODE
		{
			get { return _TENDERER_BANK_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_BANK_CODE, _TENDERER_BANK_CODE, value);
				this._TENDERER_BANK_CODE = value;
			}
		}
		/// <summary>
		/// 是否PPP项目
		/// </summary>
		public decimal? IS_PROJECT
		{
			get { return _IS_PROJECT; }
			set
			{
				this.OnPropertyValueChange(_.IS_PROJECT, _IS_PROJECT, value);
				this._IS_PROJECT = value;
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
				_.TENDER_PROJECT_CODE_OLD1,
				_.RECORD_DEPID,
				_.CONSTRUCTION_ID,
				_.M_ID,
				_.M_ATT_PROJECT_REG,
				_.M_ATT_AGENT_COMMIT,
				_.M_ATT_OTHER_FILE,
				_.M_ATT_PROJECT_REG_APPROVE,
				_.M_ATT_TENDER_AGENT_CONTRACT,
				_.M_CREATOR,
				_.M_CREATE_TM,
				_.TENDERER_CONTRACT,
				_.TENDERER_PHONE,
				_.TENDER_AGENT_CONTRACT,
				_.TENDER_AGENT_PHONE,
				_.TENDER_DOCNAME,
				_.RTYPE,
				_.OTHER_DEPID,
				_.M_ID_GGFW,
				_.TENDERER_BANK_ACCOUNT,
				_.TENDERER_BANK_OPENBANK,
				_.TENDERER_BANK_CODE,
				_.IS_PROJECT,
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
				this._TENDER_PROJECT_CODE_OLD1,
				this._RECORD_DEPID,
				this._CONSTRUCTION_ID,
				this._M_ID,
				this._M_ATT_PROJECT_REG,
				this._M_ATT_AGENT_COMMIT,
				this._M_ATT_OTHER_FILE,
				this._M_ATT_PROJECT_REG_APPROVE,
				this._M_ATT_TENDER_AGENT_CONTRACT,
				this._M_CREATOR,
				this._M_CREATE_TM,
				this._TENDERER_CONTRACT,
				this._TENDERER_PHONE,
				this._TENDER_AGENT_CONTRACT,
				this._TENDER_AGENT_PHONE,
				this._TENDER_DOCNAME,
				this._RTYPE,
				this._OTHER_DEPID,
				this._M_ID_GGFW,
				this._TENDERER_BANK_ACCOUNT,
				this._TENDERER_BANK_OPENBANK,
				this._TENDERER_BANK_CODE,
				this._IS_PROJECT,
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
			public readonly static Field TENDER_CONTENT = new Field("TENDER_CONTENT", "TENDER_PROJECT", DbType.AnsiString, null, "招标内容与范围及招标方案说明");
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
			/// 招标项目编号旧的编码 各个代理机构自己的编码
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE_OLD1 = new Field("TENDER_PROJECT_CODE_OLD1", "TENDER_PROJECT", "招标项目编号旧的编码 各个代理机构自己的编码");
			/// <summary>
			/// 备案部门ID
			/// </summary>
			public readonly static Field RECORD_DEPID = new Field("RECORD_DEPID", "TENDER_PROJECT", "备案部门ID");
			/// <summary>
			/// 报建编号
			/// </summary>
			public readonly static Field CONSTRUCTION_ID = new Field("CONSTRUCTION_ID", "TENDER_PROJECT", "报建编号");
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
			/// 创建人
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "TENDER_PROJECT", "创建人");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "TENDER_PROJECT", "创建时间");
			/// <summary>
			/// 招标联系人
			/// </summary>
			public readonly static Field TENDERER_CONTRACT = new Field("TENDERER_CONTRACT", "TENDER_PROJECT", "招标联系人");
			/// <summary>
			/// 招标人联系电话
			/// </summary>
			public readonly static Field TENDERER_PHONE = new Field("TENDERER_PHONE", "TENDER_PROJECT", "招标人联系电话");
			/// <summary>
			/// 招标代理联系人
			/// </summary>
			public readonly static Field TENDER_AGENT_CONTRACT = new Field("TENDER_AGENT_CONTRACT", "TENDER_PROJECT", "招标代理联系人");
			/// <summary>
			/// 招标代理联系电话
			/// </summary>
			public readonly static Field TENDER_AGENT_PHONE = new Field("TENDER_AGENT_PHONE", "TENDER_PROJECT", "招标代理联系电话");
			/// <summary>
			/// 招标文件名称
			/// </summary>
			public readonly static Field TENDER_DOCNAME = new Field("TENDER_DOCNAME", "TENDER_PROJECT", "招标文件名称");
			/// <summary>
			/// 备案类型
			/// </summary>
			public readonly static Field RTYPE = new Field("RTYPE", "TENDER_PROJECT", "备案类型");
			/// <summary>
			/// 抄送部门ID
			/// </summary>
			public readonly static Field OTHER_DEPID = new Field("OTHER_DEPID", "TENDER_PROJECT", "抄送部门ID");
			/// <summary>
			/// 公共平台，招标项目表M_ID
			/// </summary>
			public readonly static Field M_ID_GGFW = new Field("M_ID_GGFW", "TENDER_PROJECT", "公共平台，招标项目表M_ID");
			/// <summary>
			/// 招标人银行账户名称
			/// </summary>
			public readonly static Field TENDERER_BANK_ACCOUNT = new Field("TENDERER_BANK_ACCOUNT", "TENDER_PROJECT", "招标人银行账户名称");
			/// <summary>
			/// 招标人银行开户行
			/// </summary>
			public readonly static Field TENDERER_BANK_OPENBANK = new Field("TENDERER_BANK_OPENBANK", "TENDER_PROJECT", "招标人银行开户行");
			/// <summary>
			/// 招标人银行账号
			/// </summary>
			public readonly static Field TENDERER_BANK_CODE = new Field("TENDERER_BANK_CODE", "TENDER_PROJECT", "招标人银行账号");
			/// <summary>
			/// 是否PPP项目
			/// </summary>
			public readonly static Field IS_PROJECT = new Field("IS_PROJECT", "TENDER_PROJECT", "是否PPP项目");
		}
		#endregion
	}
}