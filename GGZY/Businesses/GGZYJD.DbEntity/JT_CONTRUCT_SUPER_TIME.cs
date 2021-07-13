using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JT_CONTRUCT_SUPER_TIME。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JT_CONTRUCT_SUPER_TIME")]
    [Serializable]
    public partial class JT_CONTRUCT_SUPER_TIME : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _CONSTRUCTION_SECTION;
		private decimal? _CONTRACT_PRE_SERVICE;
		private decimal? _CONSTRUCT_STAGE_TIME;
		private decimal? _SUPERVISION_PERIOD;
		private decimal? _DEFECT_PERIOD_DUTY;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_TM;
		private DateTime? _DATA_TIMESTAMP;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;
		private string _IS_SUPERVISION_PERIOD;

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
		/// 标段（包）编号（监理合同段）
		/// </summary>
		public string BID_SECTION_CODE
		{
			get{ return _BID_SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODE, _BID_SECTION_CODE, value);
				this._BID_SECTION_CODE = value;
			}
		}
		/// <summary>
		/// 施工合同段
		/// </summary>
		public string CONSTRUCTION_SECTION
		{
			get{ return _CONSTRUCTION_SECTION; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCTION_SECTION, _CONSTRUCTION_SECTION, value);
				this._CONSTRUCTION_SECTION = value;
			}
		}
		/// <summary>
		/// 施工准备阶段监理服务期
		/// </summary>
		public decimal? CONTRACT_PRE_SERVICE
		{
			get{ return _CONTRACT_PRE_SERVICE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_PRE_SERVICE, _CONTRACT_PRE_SERVICE, value);
				this._CONTRACT_PRE_SERVICE = value;
			}
		}
		/// <summary>
		/// 施工阶段
		/// </summary>
		public decimal? CONSTRUCT_STAGE_TIME
		{
			get{ return _CONSTRUCT_STAGE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCT_STAGE_TIME, _CONSTRUCT_STAGE_TIME, value);
				this._CONSTRUCT_STAGE_TIME = value;
			}
		}
		/// <summary>
		/// 交工验收监理服务期
		/// </summary>
		public decimal? SUPERVISION_PERIOD
		{
			get{ return _SUPERVISION_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISION_PERIOD, _SUPERVISION_PERIOD, value);
				this._SUPERVISION_PERIOD = value;
			}
		}
		/// <summary>
		/// 缺陷责任期阶段监理服务期
		/// </summary>
		public decimal? DEFECT_PERIOD_DUTY
		{
			get{ return _DEFECT_PERIOD_DUTY; }
			set
			{
				this.OnPropertyValueChange(_.DEFECT_PERIOD_DUTY, _DEFECT_PERIOD_DUTY, value);
				this._DEFECT_PERIOD_DUTY = value;
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
		/// 是否设置交工验收监理服务期
		/// </summary>
		public string IS_SUPERVISION_PERIOD
		{
			get{ return _IS_SUPERVISION_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.IS_SUPERVISION_PERIOD, _IS_SUPERVISION_PERIOD, value);
				this._IS_SUPERVISION_PERIOD = value;
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
				_.CONSTRUCTION_SECTION,
				_.CONTRACT_PRE_SERVICE,
				_.CONSTRUCT_STAGE_TIME,
				_.SUPERVISION_PERIOD,
				_.DEFECT_PERIOD_DUTY,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_TM,
				_.DATA_TIMESTAMP,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
				_.IS_SUPERVISION_PERIOD,
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
				this._CONSTRUCTION_SECTION,
				this._CONTRACT_PRE_SERVICE,
				this._CONSTRUCT_STAGE_TIME,
				this._SUPERVISION_PERIOD,
				this._DEFECT_PERIOD_DUTY,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_TM,
				this._DATA_TIMESTAMP,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._M_VERSION,
				this._IS_SUPERVISION_PERIOD,
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
			public readonly static Field All = new Field("*", "JT_CONTRUCT_SUPER_TIME");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JT_CONTRUCT_SUPER_TIME", "招标项目编号");
            /// <summary>
			/// 标段（包）编号（监理合同段）
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "JT_CONTRUCT_SUPER_TIME", "标段（包）编号（监理合同段）");
            /// <summary>
			/// 施工合同段
			/// </summary>
			public readonly static Field CONSTRUCTION_SECTION = new Field("CONSTRUCTION_SECTION", "JT_CONTRUCT_SUPER_TIME", "施工合同段");
            /// <summary>
			/// 施工准备阶段监理服务期
			/// </summary>
			public readonly static Field CONTRACT_PRE_SERVICE = new Field("CONTRACT_PRE_SERVICE", "JT_CONTRUCT_SUPER_TIME", "施工准备阶段监理服务期");
            /// <summary>
			/// 施工阶段
			/// </summary>
			public readonly static Field CONSTRUCT_STAGE_TIME = new Field("CONSTRUCT_STAGE_TIME", "JT_CONTRUCT_SUPER_TIME", "施工阶段");
            /// <summary>
			/// 交工验收监理服务期
			/// </summary>
			public readonly static Field SUPERVISION_PERIOD = new Field("SUPERVISION_PERIOD", "JT_CONTRUCT_SUPER_TIME", "交工验收监理服务期");
            /// <summary>
			/// 缺陷责任期阶段监理服务期
			/// </summary>
			public readonly static Field DEFECT_PERIOD_DUTY = new Field("DEFECT_PERIOD_DUTY", "JT_CONTRUCT_SUPER_TIME", "缺陷责任期阶段监理服务期");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "JT_CONTRUCT_SUPER_TIME", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "JT_CONTRUCT_SUPER_TIME", "公共服务平台标识码");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "JT_CONTRUCT_SUPER_TIME", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "JT_CONTRUCT_SUPER_TIME", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "JT_CONTRUCT_SUPER_TIME", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "JT_CONTRUCT_SUPER_TIME", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "JT_CONTRUCT_SUPER_TIME", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "JT_CONTRUCT_SUPER_TIME", "M_TM");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JT_CONTRUCT_SUPER_TIME", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "JT_CONTRUCT_SUPER_TIME", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "JT_CONTRUCT_SUPER_TIME", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "JT_CONTRUCT_SUPER_TIME", "");
            /// <summary>
			/// 是否设置交工验收监理服务期
			/// </summary>
			public readonly static Field IS_SUPERVISION_PERIOD = new Field("IS_SUPERVISION_PERIOD", "JT_CONTRUCT_SUPER_TIME", "是否设置交工验收监理服务期");
        }
        #endregion
	}
}