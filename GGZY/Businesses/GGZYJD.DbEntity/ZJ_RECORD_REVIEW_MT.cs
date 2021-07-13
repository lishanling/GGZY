using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类ZJ_RECORD_REVIEW_MT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_RECORD_REVIEW_MT")]
    [Serializable]
    public partial class ZJ_RECORD_REVIEW_MT : JdEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_CREATOR;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _REPROT_CODE;
		private string _PROJECT_CODE;
		private string _TENDER_PROJECT_CODE;
		private string _UNIFIED_DEAL_CODE;
		private DateTime? _TENDER_DOC_GET_TIME;
		private DateTime? _DOC_GET_END_TIME;
		private DateTime? _BID_DOC_REFER_END_TIME;
		private DateTime? _BID_OPEN_TIME;
		private decimal? _DOC_PRICE;
		private string _DOC_PRICE_CURRENCY;
		private string _DOC_PRICE_UNIT;
		private string _SYNDICATED_FLAG;
		private string _SYNDICATED_REQUIRE;
		private string _SIMILAR_PROJECT_BASIC;
		private string _BID_QUALIFICATION;
		private decimal? _VALID_PERIOD;
		private string _BID_DOC_REFER_METHOD;
		private string _MARGIN_PAY_TYPE;
		private decimal? _MARGIN_AMOUNT;
		private string _MARGIN_UNIT;
		private string _MARGIN_CURRENCY_CODE;
		private decimal? _CONTROL_PRICE;
		private string _CONTROL_UNIT;
		private string _CONTROL_CURRENCY_CODE;
		private string _EVALUATING_METHOD;
		private string _BID_OPEN_PLACE;
		private DateTime? _CLARIFY_TIME;
		private string _TENDER_NOTICE;
		private string _QUAL_TYPE;
		private DateTime? _SUBMIT_TIME;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;
		private string _M_ATT_BILL_OF_QUANTITIES;

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
		/// 
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
		/// 报建编号
		/// </summary>
		public string REPROT_CODE
		{
			get{ return _REPROT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REPROT_CODE, _REPROT_CODE, value);
				this._REPROT_CODE = value;
			}
		}
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
		/// 招标文件/资格预审文件获取时间
		/// </summary>
		public DateTime? TENDER_DOC_GET_TIME
		{
			get{ return _TENDER_DOC_GET_TIME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_DOC_GET_TIME, _TENDER_DOC_GET_TIME, value);
				this._TENDER_DOC_GET_TIME = value;
			}
		}
		/// <summary>
		/// 招标文件/资格预审文件获取截至时间
		/// </summary>
		public DateTime? DOC_GET_END_TIME
		{
			get{ return _DOC_GET_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.DOC_GET_END_TIME, _DOC_GET_END_TIME, value);
				this._DOC_GET_END_TIME = value;
			}
		}
		/// <summary>
		/// 投标文件/资格预审申请文件递交截止时间
		/// </summary>
		public DateTime? BID_DOC_REFER_END_TIME
		{
			get{ return _BID_DOC_REFER_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_DOC_REFER_END_TIME, _BID_DOC_REFER_END_TIME, value);
				this._BID_DOC_REFER_END_TIME = value;
			}
		}
		/// <summary>
		/// 开标时间
		/// </summary>
		public DateTime? BID_OPEN_TIME
		{
			get{ return _BID_OPEN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPEN_TIME, _BID_OPEN_TIME, value);
				this._BID_OPEN_TIME = value;
			}
		}
		/// <summary>
		/// 文件售价
		/// </summary>
		public decimal? DOC_PRICE
		{
			get{ return _DOC_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.DOC_PRICE, _DOC_PRICE, value);
				this._DOC_PRICE = value;
			}
		}
		/// <summary>
		/// 文件售价币种
		/// </summary>
		public string DOC_PRICE_CURRENCY
		{
			get{ return _DOC_PRICE_CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.DOC_PRICE_CURRENCY, _DOC_PRICE_CURRENCY, value);
				this._DOC_PRICE_CURRENCY = value;
			}
		}
		/// <summary>
		/// 文件售价单位
		/// </summary>
		public string DOC_PRICE_UNIT
		{
			get{ return _DOC_PRICE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.DOC_PRICE_UNIT, _DOC_PRICE_UNIT, value);
				this._DOC_PRICE_UNIT = value;
			}
		}
		/// <summary>
		/// 是否允许联合体投标
		/// </summary>
		public string SYNDICATED_FLAG
		{
			get{ return _SYNDICATED_FLAG; }
			set
			{
				this.OnPropertyValueChange(_.SYNDICATED_FLAG, _SYNDICATED_FLAG, value);
				this._SYNDICATED_FLAG = value;
			}
		}
		/// <summary>
		/// 联合体投标要求
		/// </summary>
		public string SYNDICATED_REQUIRE
		{
			get{ return _SYNDICATED_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.SYNDICATED_REQUIRE, _SYNDICATED_REQUIRE, value);
				this._SYNDICATED_REQUIRE = value;
			}
		}
		/// <summary>
		/// 确定类似工程业绩的相关依据
		/// </summary>
		public string SIMILAR_PROJECT_BASIC
		{
			get{ return _SIMILAR_PROJECT_BASIC; }
			set
			{
				this.OnPropertyValueChange(_.SIMILAR_PROJECT_BASIC, _SIMILAR_PROJECT_BASIC, value);
				this._SIMILAR_PROJECT_BASIC = value;
			}
		}
		/// <summary>
		/// 投标资格
		/// </summary>
		public string BID_QUALIFICATION
		{
			get{ return _BID_QUALIFICATION; }
			set
			{
				this.OnPropertyValueChange(_.BID_QUALIFICATION, _BID_QUALIFICATION, value);
				this._BID_QUALIFICATION = value;
			}
		}
		/// <summary>
		/// 投标有效期
		/// </summary>
		public decimal? VALID_PERIOD
		{
			get{ return _VALID_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.VALID_PERIOD, _VALID_PERIOD, value);
				this._VALID_PERIOD = value;
			}
		}
		/// <summary>
		/// 投标文件递交方法
		/// </summary>
		public string BID_DOC_REFER_METHOD
		{
			get{ return _BID_DOC_REFER_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.BID_DOC_REFER_METHOD, _BID_DOC_REFER_METHOD, value);
				this._BID_DOC_REFER_METHOD = value;
			}
		}
		/// <summary>
		/// 投标保证金缴纳方式
		/// </summary>
		public string MARGIN_PAY_TYPE
		{
			get{ return _MARGIN_PAY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_PAY_TYPE, _MARGIN_PAY_TYPE, value);
				this._MARGIN_PAY_TYPE = value;
			}
		}
		/// <summary>
		/// 投标保证金金额
		/// </summary>
		public decimal? MARGIN_AMOUNT
		{
			get{ return _MARGIN_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_AMOUNT, _MARGIN_AMOUNT, value);
				this._MARGIN_AMOUNT = value;
			}
		}
		/// <summary>
		/// 投标保证金单位
		/// </summary>
		public string MARGIN_UNIT
		{
			get{ return _MARGIN_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_UNIT, _MARGIN_UNIT, value);
				this._MARGIN_UNIT = value;
			}
		}
		/// <summary>
		/// 投标保证金币种
		/// </summary>
		public string MARGIN_CURRENCY_CODE
		{
			get{ return _MARGIN_CURRENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_CURRENCY_CODE, _MARGIN_CURRENCY_CODE, value);
				this._MARGIN_CURRENCY_CODE = value;
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
		/// 控制价单位
		/// </summary>
		public string CONTROL_UNIT
		{
			get{ return _CONTROL_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.CONTROL_UNIT, _CONTROL_UNIT, value);
				this._CONTROL_UNIT = value;
			}
		}
		/// <summary>
		/// 控制价币种
		/// </summary>
		public string CONTROL_CURRENCY_CODE
		{
			get{ return _CONTROL_CURRENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CONTROL_CURRENCY_CODE, _CONTROL_CURRENCY_CODE, value);
				this._CONTROL_CURRENCY_CODE = value;
			}
		}
		/// <summary>
		/// 评标办法
		/// </summary>
		public string EVALUATING_METHOD
		{
			get{ return _EVALUATING_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATING_METHOD, _EVALUATING_METHOD, value);
				this._EVALUATING_METHOD = value;
			}
		}
		/// <summary>
		/// 开标地点
		/// </summary>
		public string BID_OPEN_PLACE
		{
			get{ return _BID_OPEN_PLACE; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPEN_PLACE, _BID_OPEN_PLACE, value);
				this._BID_OPEN_PLACE = value;
			}
		}
		/// <summary>
		/// 答疑澄清时间
		/// </summary>
		public DateTime? CLARIFY_TIME
		{
			get{ return _CLARIFY_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CLARIFY_TIME, _CLARIFY_TIME, value);
				this._CLARIFY_TIME = value;
			}
		}
		/// <summary>
		/// 招标公告内容
		/// </summary>
		public string TENDER_NOTICE
		{
			get{ return _TENDER_NOTICE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_NOTICE, _TENDER_NOTICE, value);
				this._TENDER_NOTICE = value;
			}
		}
		/// <summary>
		/// 资格审查方式
		/// </summary>
		public string QUAL_TYPE
		{
			get{ return _QUAL_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.QUAL_TYPE, _QUAL_TYPE, value);
				this._QUAL_TYPE = value;
			}
		}
		/// <summary>
		/// 上报时间
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
		/// 交易服务系统标识码
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
		/// 工程量清单、招标控制价及其计价软件版成果文件
		/// </summary>
		public string M_ATT_BILL_OF_QUANTITIES
		{
			get{ return _M_ATT_BILL_OF_QUANTITIES; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_BILL_OF_QUANTITIES, _M_ATT_BILL_OF_QUANTITIES, value);
				this._M_ATT_BILL_OF_QUANTITIES = value;
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
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_CREATOR,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.REPROT_CODE,
				_.PROJECT_CODE,
				_.TENDER_PROJECT_CODE,
				_.UNIFIED_DEAL_CODE,
				_.TENDER_DOC_GET_TIME,
				_.DOC_GET_END_TIME,
				_.BID_DOC_REFER_END_TIME,
				_.BID_OPEN_TIME,
				_.DOC_PRICE,
				_.DOC_PRICE_CURRENCY,
				_.DOC_PRICE_UNIT,
				_.SYNDICATED_FLAG,
				_.SYNDICATED_REQUIRE,
				_.SIMILAR_PROJECT_BASIC,
				_.BID_QUALIFICATION,
				_.VALID_PERIOD,
				_.BID_DOC_REFER_METHOD,
				_.MARGIN_PAY_TYPE,
				_.MARGIN_AMOUNT,
				_.MARGIN_UNIT,
				_.MARGIN_CURRENCY_CODE,
				_.CONTROL_PRICE,
				_.CONTROL_UNIT,
				_.CONTROL_CURRENCY_CODE,
				_.EVALUATING_METHOD,
				_.BID_OPEN_PLACE,
				_.CLARIFY_TIME,
				_.TENDER_NOTICE,
				_.QUAL_TYPE,
				_.SUBMIT_TIME,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
				_.M_ATT_BILL_OF_QUANTITIES,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_CREATOR,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._REPROT_CODE,
				this._PROJECT_CODE,
				this._TENDER_PROJECT_CODE,
				this._UNIFIED_DEAL_CODE,
				this._TENDER_DOC_GET_TIME,
				this._DOC_GET_END_TIME,
				this._BID_DOC_REFER_END_TIME,
				this._BID_OPEN_TIME,
				this._DOC_PRICE,
				this._DOC_PRICE_CURRENCY,
				this._DOC_PRICE_UNIT,
				this._SYNDICATED_FLAG,
				this._SYNDICATED_REQUIRE,
				this._SIMILAR_PROJECT_BASIC,
				this._BID_QUALIFICATION,
				this._VALID_PERIOD,
				this._BID_DOC_REFER_METHOD,
				this._MARGIN_PAY_TYPE,
				this._MARGIN_AMOUNT,
				this._MARGIN_UNIT,
				this._MARGIN_CURRENCY_CODE,
				this._CONTROL_PRICE,
				this._CONTROL_UNIT,
				this._CONTROL_CURRENCY_CODE,
				this._EVALUATING_METHOD,
				this._BID_OPEN_PLACE,
				this._CLARIFY_TIME,
				this._TENDER_NOTICE,
				this._QUAL_TYPE,
				this._SUBMIT_TIME,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._M_VERSION,
				this._M_ATT_BILL_OF_QUANTITIES,
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
			public readonly static Field All = new Field("*", "ZJ_RECORD_REVIEW_MT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_RECORD_REVIEW_MT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "ZJ_RECORD_REVIEW_MT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ZJ_RECORD_REVIEW_MT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "ZJ_RECORD_REVIEW_MT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "ZJ_RECORD_REVIEW_MT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "ZJ_RECORD_REVIEW_MT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "ZJ_RECORD_REVIEW_MT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "ZJ_RECORD_REVIEW_MT", "");
            /// <summary>
			/// 报建编号
			/// </summary>
			public readonly static Field REPROT_CODE = new Field("REPROT_CODE", "ZJ_RECORD_REVIEW_MT", "报建编号");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "ZJ_RECORD_REVIEW_MT", "项目编号");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "ZJ_RECORD_REVIEW_MT", "招标项目编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "ZJ_RECORD_REVIEW_MT", "统一交易标识码");
            /// <summary>
			/// 招标文件/资格预审文件获取时间
			/// </summary>
			public readonly static Field TENDER_DOC_GET_TIME = new Field("TENDER_DOC_GET_TIME", "ZJ_RECORD_REVIEW_MT", "招标文件/资格预审文件获取时间");
            /// <summary>
			/// 招标文件/资格预审文件获取截至时间
			/// </summary>
			public readonly static Field DOC_GET_END_TIME = new Field("DOC_GET_END_TIME", "ZJ_RECORD_REVIEW_MT", "招标文件/资格预审文件获取截至时间");
            /// <summary>
			/// 投标文件/资格预审申请文件递交截止时间
			/// </summary>
			public readonly static Field BID_DOC_REFER_END_TIME = new Field("BID_DOC_REFER_END_TIME", "ZJ_RECORD_REVIEW_MT", "投标文件/资格预审申请文件递交截止时间");
            /// <summary>
			/// 开标时间
			/// </summary>
			public readonly static Field BID_OPEN_TIME = new Field("BID_OPEN_TIME", "ZJ_RECORD_REVIEW_MT", "开标时间");
            /// <summary>
			/// 文件售价
			/// </summary>
			public readonly static Field DOC_PRICE = new Field("DOC_PRICE", "ZJ_RECORD_REVIEW_MT", "文件售价");
            /// <summary>
			/// 文件售价币种
			/// </summary>
			public readonly static Field DOC_PRICE_CURRENCY = new Field("DOC_PRICE_CURRENCY", "ZJ_RECORD_REVIEW_MT", "文件售价币种");
            /// <summary>
			/// 文件售价单位
			/// </summary>
			public readonly static Field DOC_PRICE_UNIT = new Field("DOC_PRICE_UNIT", "ZJ_RECORD_REVIEW_MT", "文件售价单位");
            /// <summary>
			/// 是否允许联合体投标
			/// </summary>
			public readonly static Field SYNDICATED_FLAG = new Field("SYNDICATED_FLAG", "ZJ_RECORD_REVIEW_MT", "是否允许联合体投标");
            /// <summary>
			/// 联合体投标要求
			/// </summary>
			public readonly static Field SYNDICATED_REQUIRE = new Field("SYNDICATED_REQUIRE", "ZJ_RECORD_REVIEW_MT",DbType.AnsiString, null, "联合体投标要求");
            /// <summary>
			/// 确定类似工程业绩的相关依据
			/// </summary>
			public readonly static Field SIMILAR_PROJECT_BASIC = new Field("SIMILAR_PROJECT_BASIC", "ZJ_RECORD_REVIEW_MT",DbType.AnsiString, null, "确定类似工程业绩的相关依据");
            /// <summary>
			/// 投标资格
			/// </summary>
			public readonly static Field BID_QUALIFICATION = new Field("BID_QUALIFICATION", "ZJ_RECORD_REVIEW_MT",DbType.AnsiString, null, "投标资格");
            /// <summary>
			/// 投标有效期
			/// </summary>
			public readonly static Field VALID_PERIOD = new Field("VALID_PERIOD", "ZJ_RECORD_REVIEW_MT", "投标有效期");
            /// <summary>
			/// 投标文件递交方法
			/// </summary>
			public readonly static Field BID_DOC_REFER_METHOD = new Field("BID_DOC_REFER_METHOD", "ZJ_RECORD_REVIEW_MT",DbType.AnsiString, null, "投标文件递交方法");
            /// <summary>
			/// 投标保证金缴纳方式
			/// </summary>
			public readonly static Field MARGIN_PAY_TYPE = new Field("MARGIN_PAY_TYPE", "ZJ_RECORD_REVIEW_MT", "投标保证金缴纳方式");
            /// <summary>
			/// 投标保证金金额
			/// </summary>
			public readonly static Field MARGIN_AMOUNT = new Field("MARGIN_AMOUNT", "ZJ_RECORD_REVIEW_MT", "投标保证金金额");
            /// <summary>
			/// 投标保证金单位
			/// </summary>
			public readonly static Field MARGIN_UNIT = new Field("MARGIN_UNIT", "ZJ_RECORD_REVIEW_MT", "投标保证金单位");
            /// <summary>
			/// 投标保证金币种
			/// </summary>
			public readonly static Field MARGIN_CURRENCY_CODE = new Field("MARGIN_CURRENCY_CODE", "ZJ_RECORD_REVIEW_MT", "投标保证金币种");
            /// <summary>
			/// 招标控制价
			/// </summary>
			public readonly static Field CONTROL_PRICE = new Field("CONTROL_PRICE", "ZJ_RECORD_REVIEW_MT", "招标控制价");
            /// <summary>
			/// 控制价单位
			/// </summary>
			public readonly static Field CONTROL_UNIT = new Field("CONTROL_UNIT", "ZJ_RECORD_REVIEW_MT", "控制价单位");
            /// <summary>
			/// 控制价币种
			/// </summary>
			public readonly static Field CONTROL_CURRENCY_CODE = new Field("CONTROL_CURRENCY_CODE", "ZJ_RECORD_REVIEW_MT", "控制价币种");
            /// <summary>
			/// 评标办法
			/// </summary>
			public readonly static Field EVALUATING_METHOD = new Field("EVALUATING_METHOD", "ZJ_RECORD_REVIEW_MT",DbType.AnsiString, null, "评标办法");
            /// <summary>
			/// 开标地点
			/// </summary>
			public readonly static Field BID_OPEN_PLACE = new Field("BID_OPEN_PLACE", "ZJ_RECORD_REVIEW_MT", "开标地点");
            /// <summary>
			/// 答疑澄清时间
			/// </summary>
			public readonly static Field CLARIFY_TIME = new Field("CLARIFY_TIME", "ZJ_RECORD_REVIEW_MT", "答疑澄清时间");
            /// <summary>
			/// 招标公告内容
			/// </summary>
			public readonly static Field TENDER_NOTICE = new Field("TENDER_NOTICE", "ZJ_RECORD_REVIEW_MT",DbType.AnsiString, null, "招标公告内容");
            /// <summary>
			/// 资格审查方式
			/// </summary>
			public readonly static Field QUAL_TYPE = new Field("QUAL_TYPE", "ZJ_RECORD_REVIEW_MT", "资格审查方式");
            /// <summary>
			/// 上报时间
			/// </summary>
			public readonly static Field SUBMIT_TIME = new Field("SUBMIT_TIME", "ZJ_RECORD_REVIEW_MT", "上报时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "ZJ_RECORD_REVIEW_MT", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ZJ_RECORD_REVIEW_MT", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ZJ_RECORD_REVIEW_MT", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "ZJ_RECORD_REVIEW_MT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "ZJ_RECORD_REVIEW_MT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "ZJ_RECORD_REVIEW_MT", "");
            /// <summary>
			/// 工程量清单、招标控制价及其计价软件版成果文件
			/// </summary>
			public readonly static Field M_ATT_BILL_OF_QUANTITIES = new Field("M_ATT_BILL_OF_QUANTITIES", "ZJ_RECORD_REVIEW_MT", "工程量清单、招标控制价及其计价软件版成果文件");
        }
        #endregion
	}
}