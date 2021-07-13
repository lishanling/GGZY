using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类ZJ_EVALUATION_REPORT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_EVALUATION_REPORT")]
    [Serializable]
    public partial class ZJ_EVALUATION_REPORT : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _UNIFIED_DEAL_CODE;
		private DateTime? _SUBMIT_TIME;
		private DateTime? _END_TIME;
		private string _EVALUATION_RESULT;
		private string _EVALUATING_TYPE;
		private string _IS_SET_SIMILAR_PER;
		private decimal? _CONTROL_PRICE;
		private decimal? _BID_EVALUATION_PRICE;
		private decimal? _K_DOWN_NUM;
		private string _IS_SET_SIMILAR_PLUS;
		private string _BIDD_STANDARD_PRICE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_TM;
		private DateTime? _M_CREATE_TM;
		private string _NOTICE_NAME;
		private string _EVALUATION_CONTENT;
		private string _URL;
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
		/// 评标报告提交时间
		/// </summary>
		public DateTime? SUBMIT_TIME
		{
			get{ return _SUBMIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SUBMIT_TIME, _SUBMIT_TIME, value);
				this._SUBMIT_TIME = value;
			}
		}
		/// <summary>
		/// 评标结束时间
		/// </summary>
		public DateTime? END_TIME
		{
			get{ return _END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.END_TIME, _END_TIME, value);
				this._END_TIME = value;
			}
		}
		/// <summary>
		/// 评标结果
		/// </summary>
		public string EVALUATION_RESULT
		{
			get{ return _EVALUATION_RESULT; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATION_RESULT, _EVALUATION_RESULT, value);
				this._EVALUATION_RESULT = value;
			}
		}
		/// <summary>
		/// 评标办法类型
		/// </summary>
		public string EVALUATING_TYPE
		{
			get{ return _EVALUATING_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATING_TYPE, _EVALUATING_TYPE, value);
				this._EVALUATING_TYPE = value;
			}
		}
		/// <summary>
		/// 是否设置类似业绩作为资格条件
		/// </summary>
		public string IS_SET_SIMILAR_PER
		{
			get{ return _IS_SET_SIMILAR_PER; }
			set
			{
				this.OnPropertyValueChange(_.IS_SET_SIMILAR_PER, _IS_SET_SIMILAR_PER, value);
				this._IS_SET_SIMILAR_PER = value;
			}
		}
		/// <summary>
		/// 招标控制价
		/// </summary>
		public decimal? CONTROL_PRICE
		{
			get{ return _CONTROL_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.CONTROL_PRICE, _CONTROL_PRICE, value);
				this._CONTROL_PRICE = value;
			}
		}
		/// <summary>
		/// 评标基准价
		/// </summary>
		public decimal? BID_EVALUATION_PRICE
		{
			get{ return _BID_EVALUATION_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.BID_EVALUATION_PRICE, _BID_EVALUATION_PRICE, value);
				this._BID_EVALUATION_PRICE = value;
			}
		}
		/// <summary>
		/// 下降幅度K值
		/// </summary>
		public decimal? K_DOWN_NUM
		{
			get{ return _K_DOWN_NUM; }
			set
			{
				this.OnPropertyValueChange(_.K_DOWN_NUM, _K_DOWN_NUM, value);
				this._K_DOWN_NUM = value;
			}
		}
		/// <summary>
		/// 是否设置类似业绩作为加分条件
		/// </summary>
		public string IS_SET_SIMILAR_PLUS
		{
			get{ return _IS_SET_SIMILAR_PLUS; }
			set
			{
				this.OnPropertyValueChange(_.IS_SET_SIMILAR_PLUS, _IS_SET_SIMILAR_PLUS, value);
				this._IS_SET_SIMILAR_PLUS = value;
			}
		}
		/// <summary>
		/// 评标基准价公式
		/// </summary>
		public string BIDD_STANDARD_PRICE
		{
			get{ return _BIDD_STANDARD_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.BIDD_STANDARD_PRICE, _BIDD_STANDARD_PRICE, value);
				this._BIDD_STANDARD_PRICE = value;
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
		/// 评标报告标题
		/// </summary>
		public string NOTICE_NAME
		{
			get{ return _NOTICE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_NAME, _NOTICE_NAME, value);
				this._NOTICE_NAME = value;
			}
		}
		/// <summary>
		/// 评标报告正文
		/// </summary>
		public string EVALUATION_CONTENT
		{
			get{ return _EVALUATION_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATION_CONTENT, _EVALUATION_CONTENT, value);
				this._EVALUATION_CONTENT = value;
			}
		}
		/// <summary>
		/// 报告源URL
		/// </summary>
		public string URL
		{
			get{ return _URL; }
			set
			{
				this.OnPropertyValueChange(_.URL, _URL, value);
				this._URL = value;
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
				_.BID_SECTION_CODE,
				_.UNIFIED_DEAL_CODE,
				_.SUBMIT_TIME,
				_.END_TIME,
				_.EVALUATION_RESULT,
				_.EVALUATING_TYPE,
				_.IS_SET_SIMILAR_PER,
				_.CONTROL_PRICE,
				_.BID_EVALUATION_PRICE,
				_.K_DOWN_NUM,
				_.IS_SET_SIMILAR_PLUS,
				_.BIDD_STANDARD_PRICE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_TM,
				_.M_CREATE_TM,
				_.NOTICE_NAME,
				_.EVALUATION_CONTENT,
				_.URL,
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
				this._UNIFIED_DEAL_CODE,
				this._SUBMIT_TIME,
				this._END_TIME,
				this._EVALUATION_RESULT,
				this._EVALUATING_TYPE,
				this._IS_SET_SIMILAR_PER,
				this._CONTROL_PRICE,
				this._BID_EVALUATION_PRICE,
				this._K_DOWN_NUM,
				this._IS_SET_SIMILAR_PLUS,
				this._BIDD_STANDARD_PRICE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_TM,
				this._M_CREATE_TM,
				this._NOTICE_NAME,
				this._EVALUATION_CONTENT,
				this._URL,
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
			public readonly static Field All = new Field("*", "ZJ_EVALUATION_REPORT");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "ZJ_EVALUATION_REPORT", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "ZJ_EVALUATION_REPORT", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "ZJ_EVALUATION_REPORT", "统一交易标识码");
            /// <summary>
			/// 评标报告提交时间
			/// </summary>
			public readonly static Field SUBMIT_TIME = new Field("SUBMIT_TIME", "ZJ_EVALUATION_REPORT", "评标报告提交时间");
            /// <summary>
			/// 评标结束时间
			/// </summary>
			public readonly static Field END_TIME = new Field("END_TIME", "ZJ_EVALUATION_REPORT", "评标结束时间");
            /// <summary>
			/// 评标结果
			/// </summary>
			public readonly static Field EVALUATION_RESULT = new Field("EVALUATION_RESULT", "ZJ_EVALUATION_REPORT", "评标结果");
            /// <summary>
			/// 评标办法类型
			/// </summary>
			public readonly static Field EVALUATING_TYPE = new Field("EVALUATING_TYPE", "ZJ_EVALUATION_REPORT", "评标办法类型");
            /// <summary>
			/// 是否设置类似业绩作为资格条件
			/// </summary>
			public readonly static Field IS_SET_SIMILAR_PER = new Field("IS_SET_SIMILAR_PER", "ZJ_EVALUATION_REPORT", "是否设置类似业绩作为资格条件");
            /// <summary>
			/// 招标控制价
			/// </summary>
			public readonly static Field CONTROL_PRICE = new Field("CONTROL_PRICE", "ZJ_EVALUATION_REPORT", "招标控制价");
            /// <summary>
			/// 评标基准价
			/// </summary>
			public readonly static Field BID_EVALUATION_PRICE = new Field("BID_EVALUATION_PRICE", "ZJ_EVALUATION_REPORT", "评标基准价");
            /// <summary>
			/// 下降幅度K值
			/// </summary>
			public readonly static Field K_DOWN_NUM = new Field("K_DOWN_NUM", "ZJ_EVALUATION_REPORT", "下降幅度K值");
            /// <summary>
			/// 是否设置类似业绩作为加分条件
			/// </summary>
			public readonly static Field IS_SET_SIMILAR_PLUS = new Field("IS_SET_SIMILAR_PLUS", "ZJ_EVALUATION_REPORT", "是否设置类似业绩作为加分条件");
            /// <summary>
			/// 评标基准价公式
			/// </summary>
			public readonly static Field BIDD_STANDARD_PRICE = new Field("BIDD_STANDARD_PRICE", "ZJ_EVALUATION_REPORT", "评标基准价公式");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "ZJ_EVALUATION_REPORT", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ZJ_EVALUATION_REPORT", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ZJ_EVALUATION_REPORT", "数据时间戳");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_EVALUATION_REPORT", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "ZJ_EVALUATION_REPORT", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ZJ_EVALUATION_REPORT", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "ZJ_EVALUATION_REPORT", "M_CREATEBY");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "ZJ_EVALUATION_REPORT", "M_TM");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "ZJ_EVALUATION_REPORT", "M_CREATE_TM");
            /// <summary>
			/// 评标报告标题
			/// </summary>
			public readonly static Field NOTICE_NAME = new Field("NOTICE_NAME", "ZJ_EVALUATION_REPORT", "评标报告标题");
            /// <summary>
			/// 评标报告正文
			/// </summary>
			public readonly static Field EVALUATION_CONTENT = new Field("EVALUATION_CONTENT", "ZJ_EVALUATION_REPORT",DbType.AnsiString, null, "评标报告正文");
            /// <summary>
			/// 报告源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "ZJ_EVALUATION_REPORT", "报告源URL");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "ZJ_EVALUATION_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "ZJ_EVALUATION_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "ZJ_EVALUATION_REPORT", "");
        }
        #endregion
	}
}