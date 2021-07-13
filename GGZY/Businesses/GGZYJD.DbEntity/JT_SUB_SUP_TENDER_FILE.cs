using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JT_SUB_SUP_TENDER_FILE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JT_SUB_SUP_TENDER_FILE")]
    [Serializable]
    public partial class JT_SUB_SUP_TENDER_FILE : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private string _PROJECT_STARTING;
		private string _STAKE_NUMBER1;
		private string _PROJECT_ENDING;
		private string _STAKE_NUMBER2;
		private decimal? _PROJECT_LENGTH;
		private decimal? _LIMITE_ALL_TIME;
		private decimal? _TOTAL_SECTION_NUMBER;
		private string _CONTRACT_SECTION;
		private string _BID_SECTION_NAME;
		private decimal? _TENDERER_BID_SECTION;
		private decimal? _LJ_LIMITE_TIME;
		private decimal? _LM_LIMITE_TIME;
		private decimal? _PREPARE_TIME;
		private decimal? _CONSTRUCTION_TIME;
		private decimal? _DEFECT_LIABILITY_PERIOD;
		private decimal? _CONTRACT_SEGMENT;
		private decimal? _TENDER_NUMBER;
		private string _MEDIA1;
		private string _MEDIA2;
		private string _MANAGE_ORGANIZATION;
		private decimal? _SYNDICATED_NUMBER;
		private string _RECONNAISSANCE;
		private string _PREPARATORY_MEETING;
		private DateTime? _MARGIN_TIME;
		private string _MARGIN_NAME;
		private string _MARGIN_NUMBER;
		private string _MARGIN_BANK;
		private string _SUPERVISE_DEPT_NAME;
		private string _SUPERVISE_DEPT_TELE;
		private string _SUPERVISE_DEPT_ADDRESS;
		private string _EMPLOYER;
		private string _PROJECT_APPROVAL;
		private string _FUNDS_COMPOSITION;
		private string _ALL_BID_SECTION_NAME;
		private string _DRAWING;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_TM;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;

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
		/// 相关标段（包）编号
		/// </summary>
		public string BID_SECTION_CODES
		{
			get{ return _BID_SECTION_CODES; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODES, _BID_SECTION_CODES, value);
				this._BID_SECTION_CODES = value;
			}
		}
		/// <summary>
		/// 项目起点位于
		/// </summary>
		public string PROJECT_STARTING
		{
			get{ return _PROJECT_STARTING; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_STARTING, _PROJECT_STARTING, value);
				this._PROJECT_STARTING = value;
			}
		}
		/// <summary>
		/// 起点桩号
		/// </summary>
		public string STAKE_NUMBER1
		{
			get{ return _STAKE_NUMBER1; }
			set
			{
				this.OnPropertyValueChange(_.STAKE_NUMBER1, _STAKE_NUMBER1, value);
				this._STAKE_NUMBER1 = value;
			}
		}
		/// <summary>
		/// 项目终点位于
		/// </summary>
		public string PROJECT_ENDING
		{
			get{ return _PROJECT_ENDING; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_ENDING, _PROJECT_ENDING, value);
				this._PROJECT_ENDING = value;
			}
		}
		/// <summary>
		/// 终点桩号
		/// </summary>
		public string STAKE_NUMBER2
		{
			get{ return _STAKE_NUMBER2; }
			set
			{
				this.OnPropertyValueChange(_.STAKE_NUMBER2, _STAKE_NUMBER2, value);
				this._STAKE_NUMBER2 = value;
			}
		}
		/// <summary>
		/// 全长（公里）
		/// </summary>
		public decimal? PROJECT_LENGTH
		{
			get{ return _PROJECT_LENGTH; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_LENGTH, _PROJECT_LENGTH, value);
				this._PROJECT_LENGTH = value;
			}
		}
		/// <summary>
		/// 监理总服务期
		/// </summary>
		public decimal? LIMITE_ALL_TIME
		{
			get{ return _LIMITE_ALL_TIME; }
			set
			{
				this.OnPropertyValueChange(_.LIMITE_ALL_TIME, _LIMITE_ALL_TIME, value);
				this._LIMITE_ALL_TIME = value;
			}
		}
		/// <summary>
		/// 施工监理的合同段数量
		/// </summary>
		public decimal? TOTAL_SECTION_NUMBER
		{
			get{ return _TOTAL_SECTION_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.TOTAL_SECTION_NUMBER, _TOTAL_SECTION_NUMBER, value);
				this._TOTAL_SECTION_NUMBER = value;
			}
		}
		/// <summary>
		/// 监理合同段
		/// </summary>
		public string CONTRACT_SECTION
		{
			get{ return _CONTRACT_SECTION; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_SECTION, _CONTRACT_SECTION, value);
				this._CONTRACT_SECTION = value;
			}
		}
		/// <summary>
		/// 合同段名称
		/// </summary>
		public string BID_SECTION_NAME
		{
			get{ return _BID_SECTION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_NAME, _BID_SECTION_NAME, value);
				this._BID_SECTION_NAME = value;
			}
		}
		/// <summary>
		/// 本次招标合同段名称
		/// </summary>
		public decimal? TENDERER_BID_SECTION
		{
			get{ return _TENDERER_BID_SECTION; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_BID_SECTION, _TENDERER_BID_SECTION, value);
				this._TENDERER_BID_SECTION = value;
			}
		}
		/// <summary>
		/// 路基工程计划施工工期
		/// </summary>
		public decimal? LJ_LIMITE_TIME
		{
			get{ return _LJ_LIMITE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.LJ_LIMITE_TIME, _LJ_LIMITE_TIME, value);
				this._LJ_LIMITE_TIME = value;
			}
		}
		/// <summary>
		/// 路面及交通安全设施工程计划工期
		/// </summary>
		public decimal? LM_LIMITE_TIME
		{
			get{ return _LM_LIMITE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.LM_LIMITE_TIME, _LM_LIMITE_TIME, value);
				this._LM_LIMITE_TIME = value;
			}
		}
		/// <summary>
		/// 准备阶段
		/// </summary>
		public decimal? PREPARE_TIME
		{
			get{ return _PREPARE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PREPARE_TIME, _PREPARE_TIME, value);
				this._PREPARE_TIME = value;
			}
		}
		/// <summary>
		/// 施工阶段
		/// </summary>
		public decimal? CONSTRUCTION_TIME
		{
			get{ return _CONSTRUCTION_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCTION_TIME, _CONSTRUCTION_TIME, value);
				this._CONSTRUCTION_TIME = value;
			}
		}
		/// <summary>
		/// 缺陷责任期阶段
		/// </summary>
		public decimal? DEFECT_LIABILITY_PERIOD
		{
			get{ return _DEFECT_LIABILITY_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.DEFECT_LIABILITY_PERIOD, _DEFECT_LIABILITY_PERIOD, value);
				this._DEFECT_LIABILITY_PERIOD = value;
			}
		}
		/// <summary>
		/// 投标人可参加投标的监理合同段数量
		/// </summary>
		public decimal? CONTRACT_SEGMENT
		{
			get{ return _CONTRACT_SEGMENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_SEGMENT, _CONTRACT_SEGMENT, value);
				this._CONTRACT_SEGMENT = value;
			}
		}
		/// <summary>
		/// 投标人最多可中合同段数量
		/// </summary>
		public decimal? TENDER_NUMBER
		{
			get{ return _TENDER_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_NUMBER, _TENDER_NUMBER, value);
				this._TENDER_NUMBER = value;
			}
		}
		/// <summary>
		/// 其他发布媒体1
		/// </summary>
		public string MEDIA1
		{
			get{ return _MEDIA1; }
			set
			{
				this.OnPropertyValueChange(_.MEDIA1, _MEDIA1, value);
				this._MEDIA1 = value;
			}
		}
		/// <summary>
		/// 其他发布媒体2
		/// </summary>
		public string MEDIA2
		{
			get{ return _MEDIA2; }
			set
			{
				this.OnPropertyValueChange(_.MEDIA2, _MEDIA2, value);
				this._MEDIA2 = value;
			}
		}
		/// <summary>
		/// 建设单位的管理机构
		/// </summary>
		public string MANAGE_ORGANIZATION
		{
			get{ return _MANAGE_ORGANIZATION; }
			set
			{
				this.OnPropertyValueChange(_.MANAGE_ORGANIZATION, _MANAGE_ORGANIZATION, value);
				this._MANAGE_ORGANIZATION = value;
			}
		}
		/// <summary>
		/// 联合体成员数量要求
		/// </summary>
		public decimal? SYNDICATED_NUMBER
		{
			get{ return _SYNDICATED_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.SYNDICATED_NUMBER, _SYNDICATED_NUMBER, value);
				this._SYNDICATED_NUMBER = value;
			}
		}
		/// <summary>
		/// 是否组织踏勘
		/// </summary>
		public string RECONNAISSANCE
		{
			get{ return _RECONNAISSANCE; }
			set
			{
				this.OnPropertyValueChange(_.RECONNAISSANCE, _RECONNAISSANCE, value);
				this._RECONNAISSANCE = value;
			}
		}
		/// <summary>
		/// 是否召开投标预备会
		/// </summary>
		public string PREPARATORY_MEETING
		{
			get{ return _PREPARATORY_MEETING; }
			set
			{
				this.OnPropertyValueChange(_.PREPARATORY_MEETING, _PREPARATORY_MEETING, value);
				this._PREPARATORY_MEETING = value;
			}
		}
		/// <summary>
		/// 投标保证金递交截止时间
		/// </summary>
		public DateTime? MARGIN_TIME
		{
			get{ return _MARGIN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_TIME, _MARGIN_TIME, value);
				this._MARGIN_TIME = value;
			}
		}
		/// <summary>
		/// 招标人账户
		/// </summary>
		public string MARGIN_NAME
		{
			get{ return _MARGIN_NAME; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_NAME, _MARGIN_NAME, value);
				this._MARGIN_NAME = value;
			}
		}
		/// <summary>
		/// 招标人账号
		/// </summary>
		public string MARGIN_NUMBER
		{
			get{ return _MARGIN_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_NUMBER, _MARGIN_NUMBER, value);
				this._MARGIN_NUMBER = value;
			}
		}
		/// <summary>
		/// 招标人开户行
		/// </summary>
		public string MARGIN_BANK
		{
			get{ return _MARGIN_BANK; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_BANK, _MARGIN_BANK, value);
				this._MARGIN_BANK = value;
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
		/// 监督部门联系电话
		/// </summary>
		public string SUPERVISE_DEPT_TELE
		{
			get{ return _SUPERVISE_DEPT_TELE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_TELE, _SUPERVISE_DEPT_TELE, value);
				this._SUPERVISE_DEPT_TELE = value;
			}
		}
		/// <summary>
		/// 监督部门地址
		/// </summary>
		public string SUPERVISE_DEPT_ADDRESS
		{
			get{ return _SUPERVISE_DEPT_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_ADDRESS, _SUPERVISE_DEPT_ADDRESS, value);
				this._SUPERVISE_DEPT_ADDRESS = value;
			}
		}
		/// <summary>
		/// 发包人名称
		/// </summary>
		public string EMPLOYER
		{
			get{ return _EMPLOYER; }
			set
			{
				this.OnPropertyValueChange(_.EMPLOYER, _EMPLOYER, value);
				this._EMPLOYER = value;
			}
		}
		/// <summary>
		/// 立项审批情况
		/// </summary>
		public string PROJECT_APPROVAL
		{
			get{ return _PROJECT_APPROVAL; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_APPROVAL, _PROJECT_APPROVAL, value);
				this._PROJECT_APPROVAL = value;
			}
		}
		/// <summary>
		/// 资金组成及到位情况
		/// </summary>
		public string FUNDS_COMPOSITION
		{
			get{ return _FUNDS_COMPOSITION; }
			set
			{
				this.OnPropertyValueChange(_.FUNDS_COMPOSITION, _FUNDS_COMPOSITION, value);
				this._FUNDS_COMPOSITION = value;
			}
		}
		/// <summary>
		/// 施工标段
		/// </summary>
		public string ALL_BID_SECTION_NAME
		{
			get{ return _ALL_BID_SECTION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.ALL_BID_SECTION_NAME, _ALL_BID_SECTION_NAME, value);
				this._ALL_BID_SECTION_NAME = value;
			}
		}
		/// <summary>
		/// 图纸
		/// </summary>
		public string DRAWING
		{
			get{ return _DRAWING; }
			set
			{
				this.OnPropertyValueChange(_.DRAWING, _DRAWING, value);
				this._DRAWING = value;
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
				_.BID_SECTION_CODES,
				_.PROJECT_STARTING,
				_.STAKE_NUMBER1,
				_.PROJECT_ENDING,
				_.STAKE_NUMBER2,
				_.PROJECT_LENGTH,
				_.LIMITE_ALL_TIME,
				_.TOTAL_SECTION_NUMBER,
				_.CONTRACT_SECTION,
				_.BID_SECTION_NAME,
				_.TENDERER_BID_SECTION,
				_.LJ_LIMITE_TIME,
				_.LM_LIMITE_TIME,
				_.PREPARE_TIME,
				_.CONSTRUCTION_TIME,
				_.DEFECT_LIABILITY_PERIOD,
				_.CONTRACT_SEGMENT,
				_.TENDER_NUMBER,
				_.MEDIA1,
				_.MEDIA2,
				_.MANAGE_ORGANIZATION,
				_.SYNDICATED_NUMBER,
				_.RECONNAISSANCE,
				_.PREPARATORY_MEETING,
				_.MARGIN_TIME,
				_.MARGIN_NAME,
				_.MARGIN_NUMBER,
				_.MARGIN_BANK,
				_.SUPERVISE_DEPT_NAME,
				_.SUPERVISE_DEPT_TELE,
				_.SUPERVISE_DEPT_ADDRESS,
				_.EMPLOYER,
				_.PROJECT_APPROVAL,
				_.FUNDS_COMPOSITION,
				_.ALL_BID_SECTION_NAME,
				_.DRAWING,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_TM,
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
				this._BID_SECTION_CODES,
				this._PROJECT_STARTING,
				this._STAKE_NUMBER1,
				this._PROJECT_ENDING,
				this._STAKE_NUMBER2,
				this._PROJECT_LENGTH,
				this._LIMITE_ALL_TIME,
				this._TOTAL_SECTION_NUMBER,
				this._CONTRACT_SECTION,
				this._BID_SECTION_NAME,
				this._TENDERER_BID_SECTION,
				this._LJ_LIMITE_TIME,
				this._LM_LIMITE_TIME,
				this._PREPARE_TIME,
				this._CONSTRUCTION_TIME,
				this._DEFECT_LIABILITY_PERIOD,
				this._CONTRACT_SEGMENT,
				this._TENDER_NUMBER,
				this._MEDIA1,
				this._MEDIA2,
				this._MANAGE_ORGANIZATION,
				this._SYNDICATED_NUMBER,
				this._RECONNAISSANCE,
				this._PREPARATORY_MEETING,
				this._MARGIN_TIME,
				this._MARGIN_NAME,
				this._MARGIN_NUMBER,
				this._MARGIN_BANK,
				this._SUPERVISE_DEPT_NAME,
				this._SUPERVISE_DEPT_TELE,
				this._SUPERVISE_DEPT_ADDRESS,
				this._EMPLOYER,
				this._PROJECT_APPROVAL,
				this._FUNDS_COMPOSITION,
				this._ALL_BID_SECTION_NAME,
				this._DRAWING,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_TM,
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
        public class _
        {
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*", "JT_SUB_SUP_TENDER_FILE");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JT_SUB_SUP_TENDER_FILE", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "JT_SUB_SUP_TENDER_FILE",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 项目起点位于
			/// </summary>
			public readonly static Field PROJECT_STARTING = new Field("PROJECT_STARTING", "JT_SUB_SUP_TENDER_FILE", "项目起点位于");
            /// <summary>
			/// 起点桩号
			/// </summary>
			public readonly static Field STAKE_NUMBER1 = new Field("STAKE_NUMBER1", "JT_SUB_SUP_TENDER_FILE", "起点桩号");
            /// <summary>
			/// 项目终点位于
			/// </summary>
			public readonly static Field PROJECT_ENDING = new Field("PROJECT_ENDING", "JT_SUB_SUP_TENDER_FILE", "项目终点位于");
            /// <summary>
			/// 终点桩号
			/// </summary>
			public readonly static Field STAKE_NUMBER2 = new Field("STAKE_NUMBER2", "JT_SUB_SUP_TENDER_FILE", "终点桩号");
            /// <summary>
			/// 全长（公里）
			/// </summary>
			public readonly static Field PROJECT_LENGTH = new Field("PROJECT_LENGTH", "JT_SUB_SUP_TENDER_FILE", "全长（公里）");
            /// <summary>
			/// 监理总服务期
			/// </summary>
			public readonly static Field LIMITE_ALL_TIME = new Field("LIMITE_ALL_TIME", "JT_SUB_SUP_TENDER_FILE", "监理总服务期");
            /// <summary>
			/// 施工监理的合同段数量
			/// </summary>
			public readonly static Field TOTAL_SECTION_NUMBER = new Field("TOTAL_SECTION_NUMBER", "JT_SUB_SUP_TENDER_FILE", "施工监理的合同段数量");
            /// <summary>
			/// 监理合同段
			/// </summary>
			public readonly static Field CONTRACT_SECTION = new Field("CONTRACT_SECTION", "JT_SUB_SUP_TENDER_FILE", "监理合同段");
            /// <summary>
			/// 合同段名称
			/// </summary>
			public readonly static Field BID_SECTION_NAME = new Field("BID_SECTION_NAME", "JT_SUB_SUP_TENDER_FILE", "合同段名称");
            /// <summary>
			/// 本次招标合同段名称
			/// </summary>
			public readonly static Field TENDERER_BID_SECTION = new Field("TENDERER_BID_SECTION", "JT_SUB_SUP_TENDER_FILE", "本次招标合同段名称");
            /// <summary>
			/// 路基工程计划施工工期
			/// </summary>
			public readonly static Field LJ_LIMITE_TIME = new Field("LJ_LIMITE_TIME", "JT_SUB_SUP_TENDER_FILE", "路基工程计划施工工期");
            /// <summary>
			/// 路面及交通安全设施工程计划工期
			/// </summary>
			public readonly static Field LM_LIMITE_TIME = new Field("LM_LIMITE_TIME", "JT_SUB_SUP_TENDER_FILE", "路面及交通安全设施工程计划工期");
            /// <summary>
			/// 准备阶段
			/// </summary>
			public readonly static Field PREPARE_TIME = new Field("PREPARE_TIME", "JT_SUB_SUP_TENDER_FILE", "准备阶段");
            /// <summary>
			/// 施工阶段
			/// </summary>
			public readonly static Field CONSTRUCTION_TIME = new Field("CONSTRUCTION_TIME", "JT_SUB_SUP_TENDER_FILE", "施工阶段");
            /// <summary>
			/// 缺陷责任期阶段
			/// </summary>
			public readonly static Field DEFECT_LIABILITY_PERIOD = new Field("DEFECT_LIABILITY_PERIOD", "JT_SUB_SUP_TENDER_FILE", "缺陷责任期阶段");
            /// <summary>
			/// 投标人可参加投标的监理合同段数量
			/// </summary>
			public readonly static Field CONTRACT_SEGMENT = new Field("CONTRACT_SEGMENT", "JT_SUB_SUP_TENDER_FILE", "投标人可参加投标的监理合同段数量");
            /// <summary>
			/// 投标人最多可中合同段数量
			/// </summary>
			public readonly static Field TENDER_NUMBER = new Field("TENDER_NUMBER", "JT_SUB_SUP_TENDER_FILE", "投标人最多可中合同段数量");
            /// <summary>
			/// 其他发布媒体1
			/// </summary>
			public readonly static Field MEDIA1 = new Field("MEDIA1", "JT_SUB_SUP_TENDER_FILE", "其他发布媒体1");
            /// <summary>
			/// 其他发布媒体2
			/// </summary>
			public readonly static Field MEDIA2 = new Field("MEDIA2", "JT_SUB_SUP_TENDER_FILE", "其他发布媒体2");
            /// <summary>
			/// 建设单位的管理机构
			/// </summary>
			public readonly static Field MANAGE_ORGANIZATION = new Field("MANAGE_ORGANIZATION", "JT_SUB_SUP_TENDER_FILE", "建设单位的管理机构");
            /// <summary>
			/// 联合体成员数量要求
			/// </summary>
			public readonly static Field SYNDICATED_NUMBER = new Field("SYNDICATED_NUMBER", "JT_SUB_SUP_TENDER_FILE", "联合体成员数量要求");
            /// <summary>
			/// 是否组织踏勘
			/// </summary>
			public readonly static Field RECONNAISSANCE = new Field("RECONNAISSANCE", "JT_SUB_SUP_TENDER_FILE", "是否组织踏勘");
            /// <summary>
			/// 是否召开投标预备会
			/// </summary>
			public readonly static Field PREPARATORY_MEETING = new Field("PREPARATORY_MEETING", "JT_SUB_SUP_TENDER_FILE", "是否召开投标预备会");
            /// <summary>
			/// 投标保证金递交截止时间
			/// </summary>
			public readonly static Field MARGIN_TIME = new Field("MARGIN_TIME", "JT_SUB_SUP_TENDER_FILE", "投标保证金递交截止时间");
            /// <summary>
			/// 招标人账户
			/// </summary>
			public readonly static Field MARGIN_NAME = new Field("MARGIN_NAME", "JT_SUB_SUP_TENDER_FILE", "招标人账户");
            /// <summary>
			/// 招标人账号
			/// </summary>
			public readonly static Field MARGIN_NUMBER = new Field("MARGIN_NUMBER", "JT_SUB_SUP_TENDER_FILE", "招标人账号");
            /// <summary>
			/// 招标人开户行
			/// </summary>
			public readonly static Field MARGIN_BANK = new Field("MARGIN_BANK", "JT_SUB_SUP_TENDER_FILE", "招标人开户行");
            /// <summary>
			/// 监督部门名称
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME = new Field("SUPERVISE_DEPT_NAME", "JT_SUB_SUP_TENDER_FILE", "监督部门名称");
            /// <summary>
			/// 监督部门联系电话
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_TELE = new Field("SUPERVISE_DEPT_TELE", "JT_SUB_SUP_TENDER_FILE", "监督部门联系电话");
            /// <summary>
			/// 监督部门地址
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ADDRESS = new Field("SUPERVISE_DEPT_ADDRESS", "JT_SUB_SUP_TENDER_FILE", "监督部门地址");
            /// <summary>
			/// 发包人名称
			/// </summary>
			public readonly static Field EMPLOYER = new Field("EMPLOYER", "JT_SUB_SUP_TENDER_FILE", "发包人名称");
            /// <summary>
			/// 立项审批情况
			/// </summary>
			public readonly static Field PROJECT_APPROVAL = new Field("PROJECT_APPROVAL", "JT_SUB_SUP_TENDER_FILE",DbType.AnsiString, null, "立项审批情况");
            /// <summary>
			/// 资金组成及到位情况
			/// </summary>
			public readonly static Field FUNDS_COMPOSITION = new Field("FUNDS_COMPOSITION", "JT_SUB_SUP_TENDER_FILE",DbType.AnsiString, null, "资金组成及到位情况");
            /// <summary>
			/// 施工标段
			/// </summary>
			public readonly static Field ALL_BID_SECTION_NAME = new Field("ALL_BID_SECTION_NAME", "JT_SUB_SUP_TENDER_FILE",DbType.AnsiString, null, "施工标段");
            /// <summary>
			/// 图纸
			/// </summary>
			public readonly static Field DRAWING = new Field("DRAWING", "JT_SUB_SUP_TENDER_FILE", "图纸");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "JT_SUB_SUP_TENDER_FILE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "JT_SUB_SUP_TENDER_FILE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JT_SUB_SUP_TENDER_FILE", "数据时间戳");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "JT_SUB_SUP_TENDER_FILE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "JT_SUB_SUP_TENDER_FILE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "JT_SUB_SUP_TENDER_FILE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "JT_SUB_SUP_TENDER_FILE", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "JT_SUB_SUP_TENDER_FILE", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "JT_SUB_SUP_TENDER_FILE", "M_TM");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "JT_SUB_SUP_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "JT_SUB_SUP_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "JT_SUB_SUP_TENDER_FILE", "");
        }
        #endregion
	}
}