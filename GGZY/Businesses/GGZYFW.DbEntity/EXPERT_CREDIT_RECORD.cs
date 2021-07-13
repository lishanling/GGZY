using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类EXPERT_CREDIT_RECORD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("EXPERT_CREDIT_RECORD")]
    [Serializable]
    public partial class EXPERT_CREDIT_RECORD : FwEntity
    {
        #region Model
		private string _ID_CARD;
		private string _REWARD_PUNISHMENT_TYPE;
		private string _TENDER_PROJECT_NAME;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_NAME;
		private string _BID_SECTION_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _APPROVE_DEPT_NAME;
		private string _APPROVE_DEPT_CODE;
		private string _VIOLATING_BASIS;
		private string _VIOLATING_RESULT;
		private DateTime? _PULISH_DATE;
		private string _CONFINED_ACTION;
		private DateTime? _START_DATE;
		private DateTime? _END_DATE;
		private string _OPERATOR;
		private DateTime? _OPERATE_DATE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private string _M_ATT_CREDIT_RECORD_DOC;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _M_VERSION;

		/// <summary>
		/// 专家身份证件号码
		/// </summary>
		public string ID_CARD
		{
			get{ return _ID_CARD; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD, _ID_CARD, value);
				this._ID_CARD = value;
			}
		}
		/// <summary>
		/// 奖惩类型
		/// </summary>
		public string REWARD_PUNISHMENT_TYPE
		{
			get{ return _REWARD_PUNISHMENT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.REWARD_PUNISHMENT_TYPE, _REWARD_PUNISHMENT_TYPE, value);
				this._REWARD_PUNISHMENT_TYPE = value;
			}
		}
		/// <summary>
		/// 招标项目（采购项目）名称
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
		/// 招标项目（采购项目）编号
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
		/// 标段（包）名称
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
		/// 标段（包）编号
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
		/// 监督部门名称
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
		/// 监督部门代码
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
		/// 处罚依据
		/// </summary>
		public string VIOLATING_BASIS
		{
			get{ return _VIOLATING_BASIS; }
			set
			{
				this.OnPropertyValueChange(_.VIOLATING_BASIS, _VIOLATING_BASIS, value);
				this._VIOLATING_BASIS = value;
			}
		}
		/// <summary>
		/// 处罚结果
		/// </summary>
		public string VIOLATING_RESULT
		{
			get{ return _VIOLATING_RESULT; }
			set
			{
				this.OnPropertyValueChange(_.VIOLATING_RESULT, _VIOLATING_RESULT, value);
				this._VIOLATING_RESULT = value;
			}
		}
		/// <summary>
		/// 发布日期
		/// </summary>
		public DateTime? PULISH_DATE
		{
			get{ return _PULISH_DATE; }
			set
			{
				this.OnPropertyValueChange(_.PULISH_DATE, _PULISH_DATE, value);
				this._PULISH_DATE = value;
			}
		}
		/// <summary>
		/// 限制的行为
		/// </summary>
		public string CONFINED_ACTION
		{
			get{ return _CONFINED_ACTION; }
			set
			{
				this.OnPropertyValueChange(_.CONFINED_ACTION, _CONFINED_ACTION, value);
				this._CONFINED_ACTION = value;
			}
		}
		/// <summary>
		/// 限制行为开始时间
		/// </summary>
		public DateTime? START_DATE
		{
			get{ return _START_DATE; }
			set
			{
				this.OnPropertyValueChange(_.START_DATE, _START_DATE, value);
				this._START_DATE = value;
			}
		}
		/// <summary>
		/// 限制行为结束时间
		/// </summary>
		public DateTime? END_DATE
		{
			get{ return _END_DATE; }
			set
			{
				this.OnPropertyValueChange(_.END_DATE, _END_DATE, value);
				this._END_DATE = value;
			}
		}
		/// <summary>
		/// 发布人
		/// </summary>
		public string OPERATOR
		{
			get{ return _OPERATOR; }
			set
			{
				this.OnPropertyValueChange(_.OPERATOR, _OPERATOR, value);
				this._OPERATOR = value;
			}
		}
		/// <summary>
		/// 发布时间
		/// </summary>
		public DateTime? OPERATE_DATE
		{
			get{ return _OPERATE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.OPERATE_DATE, _OPERATE_DATE, value);
				this._OPERATE_DATE = value;
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
		/// 专家信用记录证明文件扫描件
		/// </summary>
		public string M_ATT_CREDIT_RECORD_DOC
		{
			get{ return _M_ATT_CREDIT_RECORD_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_CREDIT_RECORD_DOC, _M_ATT_CREDIT_RECORD_DOC, value);
				this._M_ATT_CREDIT_RECORD_DOC = value;
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
				_.ID_CARD,
				_.REWARD_PUNISHMENT_TYPE,
				_.TENDER_PROJECT_NAME,
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_NAME,
				_.BID_SECTION_CODE,
				_.UNIFIED_DEAL_CODE,
				_.APPROVE_DEPT_NAME,
				_.APPROVE_DEPT_CODE,
				_.VIOLATING_BASIS,
				_.VIOLATING_RESULT,
				_.PULISH_DATE,
				_.CONFINED_ACTION,
				_.START_DATE,
				_.END_DATE,
				_.OPERATOR,
				_.OPERATE_DATE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
				_.M_ATT_CREDIT_RECORD_DOC,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID_CARD,
				this._REWARD_PUNISHMENT_TYPE,
				this._TENDER_PROJECT_NAME,
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_NAME,
				this._BID_SECTION_CODE,
				this._UNIFIED_DEAL_CODE,
				this._APPROVE_DEPT_NAME,
				this._APPROVE_DEPT_CODE,
				this._VIOLATING_BASIS,
				this._VIOLATING_RESULT,
				this._PULISH_DATE,
				this._CONFINED_ACTION,
				this._START_DATE,
				this._END_DATE,
				this._OPERATOR,
				this._OPERATE_DATE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
				this._M_ATT_CREDIT_RECORD_DOC,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
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
			public readonly static Field All = new Field("*", "EXPERT_CREDIT_RECORD");
            /// <summary>
			/// 专家身份证件号码
			/// </summary>
			public readonly static Field ID_CARD = new Field("ID_CARD", "EXPERT_CREDIT_RECORD", "专家身份证件号码");
            /// <summary>
			/// 奖惩类型
			/// </summary>
			public readonly static Field REWARD_PUNISHMENT_TYPE = new Field("REWARD_PUNISHMENT_TYPE", "EXPERT_CREDIT_RECORD", "奖惩类型");
            /// <summary>
			/// 招标项目（采购项目）名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "EXPERT_CREDIT_RECORD", "招标项目（采购项目）名称");
            /// <summary>
			/// 招标项目（采购项目）编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "EXPERT_CREDIT_RECORD", "招标项目（采购项目）编号");
            /// <summary>
			/// 标段（包）名称
			/// </summary>
			public readonly static Field BID_SECTION_NAME = new Field("BID_SECTION_NAME", "EXPERT_CREDIT_RECORD", "标段（包）名称");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "EXPERT_CREDIT_RECORD", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "EXPERT_CREDIT_RECORD", "统一交易标识码");
            /// <summary>
			/// 监督部门名称
			/// </summary>
			public readonly static Field APPROVE_DEPT_NAME = new Field("APPROVE_DEPT_NAME", "EXPERT_CREDIT_RECORD", "监督部门名称");
            /// <summary>
			/// 监督部门代码
			/// </summary>
			public readonly static Field APPROVE_DEPT_CODE = new Field("APPROVE_DEPT_CODE", "EXPERT_CREDIT_RECORD", "监督部门代码");
            /// <summary>
			/// 处罚依据
			/// </summary>
			public readonly static Field VIOLATING_BASIS = new Field("VIOLATING_BASIS", "EXPERT_CREDIT_RECORD",DbType.AnsiString, null, "处罚依据");
            /// <summary>
			/// 处罚结果
			/// </summary>
			public readonly static Field VIOLATING_RESULT = new Field("VIOLATING_RESULT", "EXPERT_CREDIT_RECORD",DbType.AnsiString, null, "处罚结果");
            /// <summary>
			/// 发布日期
			/// </summary>
			public readonly static Field PULISH_DATE = new Field("PULISH_DATE", "EXPERT_CREDIT_RECORD", "发布日期");
            /// <summary>
			/// 限制的行为
			/// </summary>
			public readonly static Field CONFINED_ACTION = new Field("CONFINED_ACTION", "EXPERT_CREDIT_RECORD", "限制的行为");
            /// <summary>
			/// 限制行为开始时间
			/// </summary>
			public readonly static Field START_DATE = new Field("START_DATE", "EXPERT_CREDIT_RECORD", "限制行为开始时间");
            /// <summary>
			/// 限制行为结束时间
			/// </summary>
			public readonly static Field END_DATE = new Field("END_DATE", "EXPERT_CREDIT_RECORD", "限制行为结束时间");
            /// <summary>
			/// 发布人
			/// </summary>
			public readonly static Field OPERATOR = new Field("OPERATOR", "EXPERT_CREDIT_RECORD", "发布人");
            /// <summary>
			/// 发布时间
			/// </summary>
			public readonly static Field OPERATE_DATE = new Field("OPERATE_DATE", "EXPERT_CREDIT_RECORD", "发布时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "EXPERT_CREDIT_RECORD", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "EXPERT_CREDIT_RECORD", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "EXPERT_CREDIT_RECORD", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "EXPERT_CREDIT_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "EXPERT_CREDIT_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "EXPERT_CREDIT_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "EXPERT_CREDIT_RECORD", "");
            /// <summary>
			/// 专家信用记录证明文件扫描件
			/// </summary>
			public readonly static Field M_ATT_CREDIT_RECORD_DOC = new Field("M_ATT_CREDIT_RECORD_DOC", "EXPERT_CREDIT_RECORD", "专家信用记录证明文件扫描件");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "EXPERT_CREDIT_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "EXPERT_CREDIT_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "EXPERT_CREDIT_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "EXPERT_CREDIT_RECORD", "");
        }
        #endregion
	}
}