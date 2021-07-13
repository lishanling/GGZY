using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类SECTION。(属性说明自动提取数据库字段的描述信息)
	/// 通过DBLINK链接到服务平台
	/// </summary>
	[Table("SECTION", "DZJYPT")]
	[Serializable]
	public partial class DBLINK_DZJYPT_SECTION : Entity
	{
		#region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _BID_SECTION_NAME;
		private string _UNIFIED_DEAL_CODE;
		private string _BID_SECTION_CONTENT;
		private string _TENDER_PROJECT_CLASSIFY_CODE;
		private decimal? _CONTRACT_RECKON_PRICE;
		private string _CURRENCY_CODE;
		private string _PRICE_UNIT;
		private string _BID_QUALIFICATION;
		private DateTime? _BEGIN_DATE;
		private decimal? _LIMITE_TIME;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private DateTime? _CREATE_TIME;
		private decimal? _M_ID;
		private string _M_ATT_TENDER_FILE;
		private string _M_ATT_TENDER_FILE_ATTACHS;
		private string _M_ATT_TENDER_NOTICE;
		private string _M_ATT_TENDER_AGENT_CONTRACT;
		private string _M_ATT_FILE_EX_TDOC;
		private string _M_ATT_INVITE_DOC;
		private string _M_ATT_PUBLICITY_DOC;
		private string _M_ATT_WIN_BID_NOTICE;
		private string _M_ATT_DISSENT_DOC;
		private string _M_ATT_CONTRACT_DOC;
		private string _M_ATT_QUALIFICATION_DOC;
		private decimal? _M_CREATOR;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _M_MONEY_UPDATE;
		private string _M_ATT_PUBLICITY_DOC_SIGN;
		private string _M_ATT_WIN_BID_NOTICE_SIGN;
		private string _M_ATT_FILE_EX_TDOC_SIGN;
		private decimal? _BID_ECTION_NUM;
		private string _BID_TENDER_MODE;
		private string _REGION_CODE;
		private string _TRA_PLACE_CODE;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;

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
		/// 标段（包）编号
		/// </summary>
		public string BID_SECTION_CODE
		{
			get { return _BID_SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODE, _BID_SECTION_CODE, value);
				this._BID_SECTION_CODE = value;
			}
		}
		/// <summary>
		/// 标段（包）名称
		/// </summary>
		public string BID_SECTION_NAME
		{
			get { return _BID_SECTION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_NAME, _BID_SECTION_NAME, value);
				this._BID_SECTION_NAME = value;
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
		/// 标段（包）内容
		/// </summary>
		public string BID_SECTION_CONTENT
		{
			get { return _BID_SECTION_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CONTENT, _BID_SECTION_CONTENT, value);
				this._BID_SECTION_CONTENT = value;
			}
		}
		/// <summary>
		/// 标段（包）分类代码
		/// </summary>
		public string TENDER_PROJECT_CLASSIFY_CODE
		{
			get { return _TENDER_PROJECT_CLASSIFY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CLASSIFY_CODE, _TENDER_PROJECT_CLASSIFY_CODE, value);
				this._TENDER_PROJECT_CLASSIFY_CODE = value;
			}
		}
		/// <summary>
		/// 标段合同估算价
		/// </summary>
		public decimal? CONTRACT_RECKON_PRICE
		{
			get { return _CONTRACT_RECKON_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_RECKON_PRICE, _CONTRACT_RECKON_PRICE, value);
				this._CONTRACT_RECKON_PRICE = value;
			}
		}
		/// <summary>
		/// 标段合同估算价币种代码
		/// </summary>
		public string CURRENCY_CODE
		{
			get { return _CURRENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CURRENCY_CODE, _CURRENCY_CODE, value);
				this._CURRENCY_CODE = value;
			}
		}
		/// <summary>
		/// 标段合同估算价单位
		/// </summary>
		public string PRICE_UNIT
		{
			get { return _PRICE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_UNIT, _PRICE_UNIT, value);
				this._PRICE_UNIT = value;
			}
		}
		/// <summary>
		/// 投标人资格条件
		/// </summary>
		public string BID_QUALIFICATION
		{
			get { return _BID_QUALIFICATION; }
			set
			{
				this.OnPropertyValueChange(_.BID_QUALIFICATION, _BID_QUALIFICATION, value);
				this._BID_QUALIFICATION = value;
			}
		}
		/// <summary>
		/// 计划开工日期
		/// </summary>
		public DateTime? BEGIN_DATE
		{
			get { return _BEGIN_DATE; }
			set
			{
				this.OnPropertyValueChange(_.BEGIN_DATE, _BEGIN_DATE, value);
				this._BEGIN_DATE = value;
			}
		}
		/// <summary>
		/// 工期
		/// </summary>
		public decimal? LIMITE_TIME
		{
			get { return _LIMITE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.LIMITE_TIME, _LIMITE_TIME, value);
				this._LIMITE_TIME = value;
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
		/// 
		/// </summary>
		public string M_KEY
		{
			get { return _M_KEY; }
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
			get { return _M_DATA_SOURCE; }
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
			get { return _M_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_TM, _M_TM, value);
				this._M_TM = value;
			}
		}
		/// <summary>
		/// 建立时间
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
		/// 招标文件
		/// </summary>
		public string M_ATT_TENDER_FILE
		{
			get { return _M_ATT_TENDER_FILE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_TENDER_FILE, _M_ATT_TENDER_FILE, value);
				this._M_ATT_TENDER_FILE = value;
			}
		}
		/// <summary>
		/// 招标文件附件
		/// </summary>
		public string M_ATT_TENDER_FILE_ATTACHS
		{
			get { return _M_ATT_TENDER_FILE_ATTACHS; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_TENDER_FILE_ATTACHS, _M_ATT_TENDER_FILE_ATTACHS, value);
				this._M_ATT_TENDER_FILE_ATTACHS = value;
			}
		}
		/// <summary>
		/// 招标公告
		/// </summary>
		public string M_ATT_TENDER_NOTICE
		{
			get { return _M_ATT_TENDER_NOTICE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_TENDER_NOTICE, _M_ATT_TENDER_NOTICE, value);
				this._M_ATT_TENDER_NOTICE = value;
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
		/// 加盖电子印章的澄清、答疑及补充PDF电子文件
		/// </summary>
		public string M_ATT_FILE_EX_TDOC
		{
			get { return _M_ATT_FILE_EX_TDOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_FILE_EX_TDOC, _M_ATT_FILE_EX_TDOC, value);
				this._M_ATT_FILE_EX_TDOC = value;
			}
		}
		/// <summary>
		/// 投标邀请书
		/// </summary>
		public string M_ATT_INVITE_DOC
		{
			get { return _M_ATT_INVITE_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_INVITE_DOC, _M_ATT_INVITE_DOC, value);
				this._M_ATT_INVITE_DOC = value;
			}
		}
		/// <summary>
		/// 中标候选人公示PDF文件（招标人或其代理机构盖章并由项目负责人签名或者电子签名）
		/// </summary>
		public string M_ATT_PUBLICITY_DOC
		{
			get { return _M_ATT_PUBLICITY_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_PUBLICITY_DOC, _M_ATT_PUBLICITY_DOC, value);
				this._M_ATT_PUBLICITY_DOC = value;
			}
		}
		/// <summary>
		/// 中标结果公示PDF文件（招标人或其代理机构盖章并由项目负责人签名或者电子签名）
		/// </summary>
		public string M_ATT_WIN_BID_NOTICE
		{
			get { return _M_ATT_WIN_BID_NOTICE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_WIN_BID_NOTICE, _M_ATT_WIN_BID_NOTICE, value);
				this._M_ATT_WIN_BID_NOTICE = value;
			}
		}
		/// <summary>
		/// 异议/投诉
		/// </summary>
		public string M_ATT_DISSENT_DOC
		{
			get { return _M_ATT_DISSENT_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_DISSENT_DOC, _M_ATT_DISSENT_DOC, value);
				this._M_ATT_DISSENT_DOC = value;
			}
		}
		/// <summary>
		/// 合同
		/// </summary>
		public string M_ATT_CONTRACT_DOC
		{
			get { return _M_ATT_CONTRACT_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_CONTRACT_DOC, _M_ATT_CONTRACT_DOC, value);
				this._M_ATT_CONTRACT_DOC = value;
			}
		}
		/// <summary>
		/// 资格预审文件
		/// </summary>
		public string M_ATT_QUALIFICATION_DOC
		{
			get { return _M_ATT_QUALIFICATION_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_QUALIFICATION_DOC, _M_ATT_QUALIFICATION_DOC, value);
				this._M_ATT_QUALIFICATION_DOC = value;
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
		/// 
		/// </summary>
		public decimal? M_IS_HISTORY
		{
			get { return _M_IS_HISTORY; }
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
			get { return _M_CREATEBY; }
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
			get { return _M_CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATE_TM, _M_CREATE_TM, value);
				this._M_CREATE_TM = value;
			}
		}
		/// <summary>
		/// 标注金额单位是否被更新过，1表示更新过
		/// </summary>
		public string M_MONEY_UPDATE
		{
			get { return _M_MONEY_UPDATE; }
			set
			{
				this.OnPropertyValueChange(_.M_MONEY_UPDATE, _M_MONEY_UPDATE, value);
				this._M_MONEY_UPDATE = value;
			}
		}
		/// <summary>
		/// 中标候选人公示电子签章文件（招标人或其代理机构盖章并由项目负责人签名或者电子签名）
		/// </summary>
		public string M_ATT_PUBLICITY_DOC_SIGN
		{
			get { return _M_ATT_PUBLICITY_DOC_SIGN; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_PUBLICITY_DOC_SIGN, _M_ATT_PUBLICITY_DOC_SIGN, value);
				this._M_ATT_PUBLICITY_DOC_SIGN = value;
			}
		}
		/// <summary>
		/// 中标结果公示电子签章文件（招标人或其代理机构盖章并由项目负责人签名或者电子签名）
		/// </summary>
		public string M_ATT_WIN_BID_NOTICE_SIGN
		{
			get { return _M_ATT_WIN_BID_NOTICE_SIGN; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_WIN_BID_NOTICE_SIGN, _M_ATT_WIN_BID_NOTICE_SIGN, value);
				this._M_ATT_WIN_BID_NOTICE_SIGN = value;
			}
		}
		/// <summary>
		/// 加盖电子印章的澄清、答疑及补充电子签章文件（招标人或其代理机构盖章并由项目负责人签名或者电子签名）
		/// </summary>
		public string M_ATT_FILE_EX_TDOC_SIGN
		{
			get { return _M_ATT_FILE_EX_TDOC_SIGN; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_FILE_EX_TDOC_SIGN, _M_ATT_FILE_EX_TDOC_SIGN, value);
				this._M_ATT_FILE_EX_TDOC_SIGN = value;
			}
		}
		/// <summary>
		/// 标段（包）招标次数
		/// </summary>
		public decimal? BID_ECTION_NUM
		{
			get { return _BID_ECTION_NUM; }
			set
			{
				this.OnPropertyValueChange(_.BID_ECTION_NUM, _BID_ECTION_NUM, value);
				this._BID_ECTION_NUM = value;
			}
		}
		/// <summary>
		/// 标段（包）招标方式
		/// </summary>
		public string BID_TENDER_MODE
		{
			get { return _BID_TENDER_MODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_TENDER_MODE, _BID_TENDER_MODE, value);
				this._BID_TENDER_MODE = value;
			}
		}
		/// <summary>
		/// 标段（包）所在行政区域代码
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
		/// 交易发生行政区域代码
		/// </summary>
		public string TRA_PLACE_CODE
		{
			get { return _TRA_PLACE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TRA_PLACE_CODE, _TRA_PLACE_CODE, value);
				this._TRA_PLACE_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRADE_PLAT
		{
			get { return _TRADE_PLAT; }
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
			get { return _PUB_SERVICE_PLAT; }
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
			get { return _M_VERSION; }
			set
			{
				this.OnPropertyValueChange(_.M_VERSION, _M_VERSION, value);
				this._M_VERSION = value;
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
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.BID_SECTION_NAME,
				_.UNIFIED_DEAL_CODE,
				_.BID_SECTION_CONTENT,
				_.TENDER_PROJECT_CLASSIFY_CODE,
				_.CONTRACT_RECKON_PRICE,
				_.CURRENCY_CODE,
				_.PRICE_UNIT,
				_.BID_QUALIFICATION,
				_.BEGIN_DATE,
				_.LIMITE_TIME,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.CREATE_TIME,
				_.M_ID,
				_.M_ATT_TENDER_FILE,
				_.M_ATT_TENDER_FILE_ATTACHS,
				_.M_ATT_TENDER_NOTICE,
				_.M_ATT_TENDER_AGENT_CONTRACT,
				_.M_ATT_FILE_EX_TDOC,
				_.M_ATT_INVITE_DOC,
				_.M_ATT_PUBLICITY_DOC,
				_.M_ATT_WIN_BID_NOTICE,
				_.M_ATT_DISSENT_DOC,
				_.M_ATT_CONTRACT_DOC,
				_.M_ATT_QUALIFICATION_DOC,
				_.M_CREATOR,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_MONEY_UPDATE,
				_.M_ATT_PUBLICITY_DOC_SIGN,
				_.M_ATT_WIN_BID_NOTICE_SIGN,
				_.M_ATT_FILE_EX_TDOC_SIGN,
				_.BID_ECTION_NUM,
				_.BID_TENDER_MODE,
				_.REGION_CODE,
				_.TRA_PLACE_CODE,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._BID_SECTION_NAME,
				this._UNIFIED_DEAL_CODE,
				this._BID_SECTION_CONTENT,
				this._TENDER_PROJECT_CLASSIFY_CODE,
				this._CONTRACT_RECKON_PRICE,
				this._CURRENCY_CODE,
				this._PRICE_UNIT,
				this._BID_QUALIFICATION,
				this._BEGIN_DATE,
				this._LIMITE_TIME,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._CREATE_TIME,
				this._M_ID,
				this._M_ATT_TENDER_FILE,
				this._M_ATT_TENDER_FILE_ATTACHS,
				this._M_ATT_TENDER_NOTICE,
				this._M_ATT_TENDER_AGENT_CONTRACT,
				this._M_ATT_FILE_EX_TDOC,
				this._M_ATT_INVITE_DOC,
				this._M_ATT_PUBLICITY_DOC,
				this._M_ATT_WIN_BID_NOTICE,
				this._M_ATT_DISSENT_DOC,
				this._M_ATT_CONTRACT_DOC,
				this._M_ATT_QUALIFICATION_DOC,
				this._M_CREATOR,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_MONEY_UPDATE,
				this._M_ATT_PUBLICITY_DOC_SIGN,
				this._M_ATT_WIN_BID_NOTICE_SIGN,
				this._M_ATT_FILE_EX_TDOC_SIGN,
				this._BID_ECTION_NUM,
				this._BID_TENDER_MODE,
				this._REGION_CODE,
				this._TRA_PLACE_CODE,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._M_VERSION,
			};
		}
		#endregion

		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public partial class _
		{
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*", "SECTION");
			/// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "SECTION", "招标项目编号");
			/// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "SECTION", "标段（包）编号");
			/// <summary>
			/// 标段（包）名称
			/// </summary>
			public readonly static Field BID_SECTION_NAME = new Field("BID_SECTION_NAME", "SECTION", "标段（包）名称");
			/// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "SECTION", "统一交易标识码");
			/// <summary>
			/// 标段（包）内容
			/// </summary>
			public readonly static Field BID_SECTION_CONTENT = new Field("BID_SECTION_CONTENT", "SECTION", DbType.AnsiString, null, "标段（包）内容");
			/// <summary>
			/// 标段（包）分类代码
			/// </summary>
			public readonly static Field TENDER_PROJECT_CLASSIFY_CODE = new Field("TENDER_PROJECT_CLASSIFY_CODE", "SECTION", "标段（包）分类代码");
			/// <summary>
			/// 标段合同估算价
			/// </summary>
			public readonly static Field CONTRACT_RECKON_PRICE = new Field("CONTRACT_RECKON_PRICE", "SECTION", "标段合同估算价");
			/// <summary>
			/// 标段合同估算价币种代码
			/// </summary>
			public readonly static Field CURRENCY_CODE = new Field("CURRENCY_CODE", "SECTION", "标段合同估算价币种代码");
			/// <summary>
			/// 标段合同估算价单位
			/// </summary>
			public readonly static Field PRICE_UNIT = new Field("PRICE_UNIT", "SECTION", "标段合同估算价单位");
			/// <summary>
			/// 投标人资格条件
			/// </summary>
			public readonly static Field BID_QUALIFICATION = new Field("BID_QUALIFICATION", "SECTION", DbType.AnsiString, null, "投标人资格条件");
			/// <summary>
			/// 计划开工日期
			/// </summary>
			public readonly static Field BEGIN_DATE = new Field("BEGIN_DATE", "SECTION", "计划开工日期");
			/// <summary>
			/// 工期
			/// </summary>
			public readonly static Field LIMITE_TIME = new Field("LIMITE_TIME", "SECTION", "工期");
			/// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "SECTION", "交易系统标识码");
			/// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "SECTION", "公共服务平台标识码");
			/// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "SECTION", "数据时间戳");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "SECTION", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "SECTION", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "SECTION", "");
			/// <summary>
			/// 建立时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "SECTION", "建立时间");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "SECTION", "");
			/// <summary>
			/// 招标文件
			/// </summary>
			public readonly static Field M_ATT_TENDER_FILE = new Field("M_ATT_TENDER_FILE", "SECTION", "招标文件");
			/// <summary>
			/// 招标文件附件
			/// </summary>
			public readonly static Field M_ATT_TENDER_FILE_ATTACHS = new Field("M_ATT_TENDER_FILE_ATTACHS", "SECTION", "招标文件附件");
			/// <summary>
			/// 招标公告
			/// </summary>
			public readonly static Field M_ATT_TENDER_NOTICE = new Field("M_ATT_TENDER_NOTICE", "SECTION", "招标公告");
			/// <summary>
			/// 招标代理合同
			/// </summary>
			public readonly static Field M_ATT_TENDER_AGENT_CONTRACT = new Field("M_ATT_TENDER_AGENT_CONTRACT", "SECTION", "招标代理合同");
			/// <summary>
			/// 加盖电子印章的澄清、答疑及补充PDF电子文件
			/// </summary>
			public readonly static Field M_ATT_FILE_EX_TDOC = new Field("M_ATT_FILE_EX_TDOC", "SECTION", "加盖电子印章的澄清、答疑及补充PDF电子文件");
			/// <summary>
			/// 投标邀请书
			/// </summary>
			public readonly static Field M_ATT_INVITE_DOC = new Field("M_ATT_INVITE_DOC", "SECTION", "投标邀请书");
			/// <summary>
			/// 中标候选人公示PDF文件（招标人或其代理机构盖章并由项目负责人签名或者电子签名）
			/// </summary>
			public readonly static Field M_ATT_PUBLICITY_DOC = new Field("M_ATT_PUBLICITY_DOC", "SECTION", "中标候选人公示PDF文件（招标人或其代理机构盖章并由项目负责人签名或者电子签名）");
			/// <summary>
			/// 中标结果公示PDF文件（招标人或其代理机构盖章并由项目负责人签名或者电子签名）
			/// </summary>
			public readonly static Field M_ATT_WIN_BID_NOTICE = new Field("M_ATT_WIN_BID_NOTICE", "SECTION", "中标结果公示PDF文件（招标人或其代理机构盖章并由项目负责人签名或者电子签名）");
			/// <summary>
			/// 异议/投诉
			/// </summary>
			public readonly static Field M_ATT_DISSENT_DOC = new Field("M_ATT_DISSENT_DOC", "SECTION", "异议/投诉");
			/// <summary>
			/// 合同
			/// </summary>
			public readonly static Field M_ATT_CONTRACT_DOC = new Field("M_ATT_CONTRACT_DOC", "SECTION", "合同");
			/// <summary>
			/// 资格预审文件
			/// </summary>
			public readonly static Field M_ATT_QUALIFICATION_DOC = new Field("M_ATT_QUALIFICATION_DOC", "SECTION", "资格预审文件");
			/// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "SECTION", "创建人");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "SECTION", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "SECTION", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "SECTION", "");
			/// <summary>
			/// 标注金额单位是否被更新过，1表示更新过
			/// </summary>
			public readonly static Field M_MONEY_UPDATE = new Field("M_MONEY_UPDATE", "SECTION", "标注金额单位是否被更新过，1表示更新过");
			/// <summary>
			/// 中标候选人公示电子签章文件（招标人或其代理机构盖章并由项目负责人签名或者电子签名）
			/// </summary>
			public readonly static Field M_ATT_PUBLICITY_DOC_SIGN = new Field("M_ATT_PUBLICITY_DOC_SIGN", "SECTION", "中标候选人公示电子签章文件（招标人或其代理机构盖章并由项目负责人签名或者电子签名）");
			/// <summary>
			/// 中标结果公示电子签章文件（招标人或其代理机构盖章并由项目负责人签名或者电子签名）
			/// </summary>
			public readonly static Field M_ATT_WIN_BID_NOTICE_SIGN = new Field("M_ATT_WIN_BID_NOTICE_SIGN", "SECTION", "中标结果公示电子签章文件（招标人或其代理机构盖章并由项目负责人签名或者电子签名）");
			/// <summary>
			/// 加盖电子印章的澄清、答疑及补充电子签章文件（招标人或其代理机构盖章并由项目负责人签名或者电子签名）
			/// </summary>
			public readonly static Field M_ATT_FILE_EX_TDOC_SIGN = new Field("M_ATT_FILE_EX_TDOC_SIGN", "SECTION", "加盖电子印章的澄清、答疑及补充电子签章文件（招标人或其代理机构盖章并由项目负责人签名或者电子签名）");
			/// <summary>
			/// 标段（包）招标次数
			/// </summary>
			public readonly static Field BID_ECTION_NUM = new Field("BID_ECTION_NUM", "SECTION", "标段（包）招标次数");
			/// <summary>
			/// 标段（包）招标方式
			/// </summary>
			public readonly static Field BID_TENDER_MODE = new Field("BID_TENDER_MODE", "SECTION", "标段（包）招标方式");
			/// <summary>
			/// 标段（包）所在行政区域代码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "SECTION", "标段（包）所在行政区域代码");
			/// <summary>
			/// 交易发生行政区域代码
			/// </summary>
			public readonly static Field TRA_PLACE_CODE = new Field("TRA_PLACE_CODE", "SECTION", "交易发生行政区域代码");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "SECTION", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "SECTION", "");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "SECTION", "");
		}
		#endregion
	}
}