using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类ZJ_RECORD_REVIEW_MZ。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_RECORD_REVIEW_MZ")]
    [Serializable]
    public partial class ZJ_RECORD_REVIEW_MZ : JdEntity
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
		private string _TENDER_TYPE;
		private decimal? _CONTROL_PRICE;
		private string _CONTROL_CURRENCY_CODE;
		private string _CONTROL_PRICE_UNIT;
		private string _TENDER_CONTENT;
		private string _ENTERPRISE_QUALIFI_BASIC;
		private string _REGISTER_CON_BASIC;
		private string _SIMILAR_PROJECT_BASIC;
		private decimal? _ALL_LIMITE_TIME;
		private decimal? _QUOTA_LIMIT_TIME;
		private string _BIDDER_QUALIFI_REQUIRE;
		private string _REGISTER_CON_REQUIRE;
		private string _SYNDICATED_FLAG;
		private string _IS_COMPREHENSIVE_SCORE;
		private string _TYPE_PERFORM_REQUIRE;
		private decimal? _MARGIN_AMOUNT;
		private string _MARGIN_UNIT;
		private string _MARGIN_CURRENCY_CODE;
		private string _TENDER_DOC_GET_METHOD;
		private DateTime? _DOC_GET_START_TIME;
		private DateTime? _BID_DOC_REFER_END_TIME;
		private string _BID_DOC_REFER_METHOD;
		private string _TENDER_NOTICE;
		private DateTime? _DEADLINE_BIDDING;
		private DateTime? _BID_OPEN_TIME;
		private decimal? _PERFORM_PRICE;
		private DateTime? _CONTRACT_SIGN_TIME;
		private decimal? _ALL_EXPERT_NUM;
		private decimal? _EXPERT_NUM;
		private string _EVALUATING_METHOD;
		private string _QUANTITIES_DRAW_UNIT;
		private string _QUANTITIES_AUDIT_UNIT;
		private string _CONTROL_PRICE_DRAW_UNIT;
		private string _CONTROL_PRICE_AUDIT_UNIT;
		private string _PERFORM_UNIT;
		private string _PERFORM_CURRENCY_CODE;
		private DateTime? _SUBMIT_TIME;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;

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
		/// 招标类型
		/// </summary>
		public string TENDER_TYPE
		{
			get{ return _TENDER_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_TYPE, _TENDER_TYPE, value);
				this._TENDER_TYPE = value;
			}
		}
		/// <summary>
		/// 控制价（最高限价）
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
		/// 控制价币种代码
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
		/// 控制价单位
		/// </summary>
		public string CONTROL_PRICE_UNIT
		{
			get{ return _CONTROL_PRICE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.CONTROL_PRICE_UNIT, _CONTROL_PRICE_UNIT, value);
				this._CONTROL_PRICE_UNIT = value;
			}
		}
		/// <summary>
		/// 招标范围及内容
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
		/// 确定企业资质及等级的相关依据
		/// </summary>
		public string ENTERPRISE_QUALIFI_BASIC
		{
			get{ return _ENTERPRISE_QUALIFI_BASIC; }
			set
			{
				this.OnPropertyValueChange(_.ENTERPRISE_QUALIFI_BASIC, _ENTERPRISE_QUALIFI_BASIC, value);
				this._ENTERPRISE_QUALIFI_BASIC = value;
			}
		}
		/// <summary>
		/// 确定注册建造师及等级的相关依据
		/// </summary>
		public string REGISTER_CON_BASIC
		{
			get{ return _REGISTER_CON_BASIC; }
			set
			{
				this.OnPropertyValueChange(_.REGISTER_CON_BASIC, _REGISTER_CON_BASIC, value);
				this._REGISTER_CON_BASIC = value;
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
		/// 总工期
		/// </summary>
		public decimal? ALL_LIMITE_TIME
		{
			get{ return _ALL_LIMITE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.ALL_LIMITE_TIME, _ALL_LIMITE_TIME, value);
				this._ALL_LIMITE_TIME = value;
			}
		}
		/// <summary>
		/// 定额工期
		/// </summary>
		public decimal? QUOTA_LIMIT_TIME
		{
			get{ return _QUOTA_LIMIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.QUOTA_LIMIT_TIME, _QUOTA_LIMIT_TIME, value);
				this._QUOTA_LIMIT_TIME = value;
			}
		}
		/// <summary>
		/// 投标人资质等级要求
		/// </summary>
		public string BIDDER_QUALIFI_REQUIRE
		{
			get{ return _BIDDER_QUALIFI_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_QUALIFI_REQUIRE, _BIDDER_QUALIFI_REQUIRE, value);
				this._BIDDER_QUALIFI_REQUIRE = value;
			}
		}
		/// <summary>
		/// 注册建造师等级要求
		/// </summary>
		public string REGISTER_CON_REQUIRE
		{
			get{ return _REGISTER_CON_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.REGISTER_CON_REQUIRE, _REGISTER_CON_REQUIRE, value);
				this._REGISTER_CON_REQUIRE = value;
			}
		}
		/// <summary>
		/// 是否联合体投标
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
		/// 是否应用综合评价分值
		/// </summary>
		public string IS_COMPREHENSIVE_SCORE
		{
			get{ return _IS_COMPREHENSIVE_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.IS_COMPREHENSIVE_SCORE, _IS_COMPREHENSIVE_SCORE, value);
				this._IS_COMPREHENSIVE_SCORE = value;
			}
		}
		/// <summary>
		/// 类型业绩要求
		/// </summary>
		public string TYPE_PERFORM_REQUIRE
		{
			get{ return _TYPE_PERFORM_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE_PERFORM_REQUIRE, _TYPE_PERFORM_REQUIRE, value);
				this._TYPE_PERFORM_REQUIRE = value;
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
		/// 招标文件获取方法
		/// </summary>
		public string TENDER_DOC_GET_METHOD
		{
			get{ return _TENDER_DOC_GET_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_DOC_GET_METHOD, _TENDER_DOC_GET_METHOD, value);
				this._TENDER_DOC_GET_METHOD = value;
			}
		}
		/// <summary>
		/// 招标文件获取开始时间
		/// </summary>
		public DateTime? DOC_GET_START_TIME
		{
			get{ return _DOC_GET_START_TIME; }
			set
			{
				this.OnPropertyValueChange(_.DOC_GET_START_TIME, _DOC_GET_START_TIME, value);
				this._DOC_GET_START_TIME = value;
			}
		}
		/// <summary>
		/// 招标文件获取截止时间
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
		/// 招标公告
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
		/// 投标截止时间
		/// </summary>
		public DateTime? DEADLINE_BIDDING
		{
			get{ return _DEADLINE_BIDDING; }
			set
			{
				this.OnPropertyValueChange(_.DEADLINE_BIDDING, _DEADLINE_BIDDING, value);
				this._DEADLINE_BIDDING = value;
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
		/// 履约担保金额
		/// </summary>
		public decimal? PERFORM_PRICE
		{
			get{ return _PERFORM_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.PERFORM_PRICE, _PERFORM_PRICE, value);
				this._PERFORM_PRICE = value;
			}
		}
		/// <summary>
		/// 合同签订时间
		/// </summary>
		public DateTime? CONTRACT_SIGN_TIME
		{
			get{ return _CONTRACT_SIGN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_SIGN_TIME, _CONTRACT_SIGN_TIME, value);
				this._CONTRACT_SIGN_TIME = value;
			}
		}
		/// <summary>
		/// 评标委员会成员人数
		/// </summary>
		public decimal? ALL_EXPERT_NUM
		{
			get{ return _ALL_EXPERT_NUM; }
			set
			{
				this.OnPropertyValueChange(_.ALL_EXPERT_NUM, _ALL_EXPERT_NUM, value);
				this._ALL_EXPERT_NUM = value;
			}
		}
		/// <summary>
		/// 工程造价类专家人数（最低投标价）
		/// </summary>
		public decimal? EXPERT_NUM
		{
			get{ return _EXPERT_NUM; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_NUM, _EXPERT_NUM, value);
				this._EXPERT_NUM = value;
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
		/// 工程量清单编制单位
		/// </summary>
		public string QUANTITIES_DRAW_UNIT
		{
			get{ return _QUANTITIES_DRAW_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.QUANTITIES_DRAW_UNIT, _QUANTITIES_DRAW_UNIT, value);
				this._QUANTITIES_DRAW_UNIT = value;
			}
		}
		/// <summary>
		/// 工程量清单审查单位
		/// </summary>
		public string QUANTITIES_AUDIT_UNIT
		{
			get{ return _QUANTITIES_AUDIT_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.QUANTITIES_AUDIT_UNIT, _QUANTITIES_AUDIT_UNIT, value);
				this._QUANTITIES_AUDIT_UNIT = value;
			}
		}
		/// <summary>
		/// 招标控制价编制单位
		/// </summary>
		public string CONTROL_PRICE_DRAW_UNIT
		{
			get{ return _CONTROL_PRICE_DRAW_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.CONTROL_PRICE_DRAW_UNIT, _CONTROL_PRICE_DRAW_UNIT, value);
				this._CONTROL_PRICE_DRAW_UNIT = value;
			}
		}
		/// <summary>
		/// 招标控制价审核单位
		/// </summary>
		public string CONTROL_PRICE_AUDIT_UNIT
		{
			get{ return _CONTROL_PRICE_AUDIT_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.CONTROL_PRICE_AUDIT_UNIT, _CONTROL_PRICE_AUDIT_UNIT, value);
				this._CONTROL_PRICE_AUDIT_UNIT = value;
			}
		}
		/// <summary>
		/// 履约担保金额单位
		/// </summary>
		public string PERFORM_UNIT
		{
			get{ return _PERFORM_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.PERFORM_UNIT, _PERFORM_UNIT, value);
				this._PERFORM_UNIT = value;
			}
		}
		/// <summary>
		/// 履约担保金额币种
		/// </summary>
		public string PERFORM_CURRENCY_CODE
		{
			get{ return _PERFORM_CURRENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PERFORM_CURRENCY_CODE, _PERFORM_CURRENCY_CODE, value);
				this._PERFORM_CURRENCY_CODE = value;
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
				_.TENDER_TYPE,
				_.CONTROL_PRICE,
				_.CONTROL_CURRENCY_CODE,
				_.CONTROL_PRICE_UNIT,
				_.TENDER_CONTENT,
				_.ENTERPRISE_QUALIFI_BASIC,
				_.REGISTER_CON_BASIC,
				_.SIMILAR_PROJECT_BASIC,
				_.ALL_LIMITE_TIME,
				_.QUOTA_LIMIT_TIME,
				_.BIDDER_QUALIFI_REQUIRE,
				_.REGISTER_CON_REQUIRE,
				_.SYNDICATED_FLAG,
				_.IS_COMPREHENSIVE_SCORE,
				_.TYPE_PERFORM_REQUIRE,
				_.MARGIN_AMOUNT,
				_.MARGIN_UNIT,
				_.MARGIN_CURRENCY_CODE,
				_.TENDER_DOC_GET_METHOD,
				_.DOC_GET_START_TIME,
				_.BID_DOC_REFER_END_TIME,
				_.BID_DOC_REFER_METHOD,
				_.TENDER_NOTICE,
				_.DEADLINE_BIDDING,
				_.BID_OPEN_TIME,
				_.PERFORM_PRICE,
				_.CONTRACT_SIGN_TIME,
				_.ALL_EXPERT_NUM,
				_.EXPERT_NUM,
				_.EVALUATING_METHOD,
				_.QUANTITIES_DRAW_UNIT,
				_.QUANTITIES_AUDIT_UNIT,
				_.CONTROL_PRICE_DRAW_UNIT,
				_.CONTROL_PRICE_AUDIT_UNIT,
				_.PERFORM_UNIT,
				_.PERFORM_CURRENCY_CODE,
				_.SUBMIT_TIME,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
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
				this._TENDER_TYPE,
				this._CONTROL_PRICE,
				this._CONTROL_CURRENCY_CODE,
				this._CONTROL_PRICE_UNIT,
				this._TENDER_CONTENT,
				this._ENTERPRISE_QUALIFI_BASIC,
				this._REGISTER_CON_BASIC,
				this._SIMILAR_PROJECT_BASIC,
				this._ALL_LIMITE_TIME,
				this._QUOTA_LIMIT_TIME,
				this._BIDDER_QUALIFI_REQUIRE,
				this._REGISTER_CON_REQUIRE,
				this._SYNDICATED_FLAG,
				this._IS_COMPREHENSIVE_SCORE,
				this._TYPE_PERFORM_REQUIRE,
				this._MARGIN_AMOUNT,
				this._MARGIN_UNIT,
				this._MARGIN_CURRENCY_CODE,
				this._TENDER_DOC_GET_METHOD,
				this._DOC_GET_START_TIME,
				this._BID_DOC_REFER_END_TIME,
				this._BID_DOC_REFER_METHOD,
				this._TENDER_NOTICE,
				this._DEADLINE_BIDDING,
				this._BID_OPEN_TIME,
				this._PERFORM_PRICE,
				this._CONTRACT_SIGN_TIME,
				this._ALL_EXPERT_NUM,
				this._EXPERT_NUM,
				this._EVALUATING_METHOD,
				this._QUANTITIES_DRAW_UNIT,
				this._QUANTITIES_AUDIT_UNIT,
				this._CONTROL_PRICE_DRAW_UNIT,
				this._CONTROL_PRICE_AUDIT_UNIT,
				this._PERFORM_UNIT,
				this._PERFORM_CURRENCY_CODE,
				this._SUBMIT_TIME,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
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
			public readonly static Field All = new Field("*", "ZJ_RECORD_REVIEW_MZ");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_RECORD_REVIEW_MZ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "ZJ_RECORD_REVIEW_MZ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ZJ_RECORD_REVIEW_MZ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "ZJ_RECORD_REVIEW_MZ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "ZJ_RECORD_REVIEW_MZ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "ZJ_RECORD_REVIEW_MZ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "ZJ_RECORD_REVIEW_MZ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "ZJ_RECORD_REVIEW_MZ", "");
            /// <summary>
			/// 报建编号
			/// </summary>
			public readonly static Field REPROT_CODE = new Field("REPROT_CODE", "ZJ_RECORD_REVIEW_MZ", "报建编号");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "ZJ_RECORD_REVIEW_MZ", "项目编号");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "ZJ_RECORD_REVIEW_MZ", "招标项目编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "ZJ_RECORD_REVIEW_MZ", "统一交易标识码");
            /// <summary>
			/// 招标类型
			/// </summary>
			public readonly static Field TENDER_TYPE = new Field("TENDER_TYPE", "ZJ_RECORD_REVIEW_MZ", "招标类型");
            /// <summary>
			/// 控制价（最高限价）
			/// </summary>
			public readonly static Field CONTROL_PRICE = new Field("CONTROL_PRICE", "ZJ_RECORD_REVIEW_MZ", "控制价（最高限价）");
            /// <summary>
			/// 控制价币种代码
			/// </summary>
			public readonly static Field CONTROL_CURRENCY_CODE = new Field("CONTROL_CURRENCY_CODE", "ZJ_RECORD_REVIEW_MZ", "控制价币种代码");
            /// <summary>
			/// 控制价单位
			/// </summary>
			public readonly static Field CONTROL_PRICE_UNIT = new Field("CONTROL_PRICE_UNIT", "ZJ_RECORD_REVIEW_MZ", "控制价单位");
            /// <summary>
			/// 招标范围及内容
			/// </summary>
			public readonly static Field TENDER_CONTENT = new Field("TENDER_CONTENT", "ZJ_RECORD_REVIEW_MZ",DbType.AnsiString, null, "招标范围及内容");
            /// <summary>
			/// 确定企业资质及等级的相关依据
			/// </summary>
			public readonly static Field ENTERPRISE_QUALIFI_BASIC = new Field("ENTERPRISE_QUALIFI_BASIC", "ZJ_RECORD_REVIEW_MZ",DbType.AnsiString, null, "确定企业资质及等级的相关依据");
            /// <summary>
			/// 确定注册建造师及等级的相关依据
			/// </summary>
			public readonly static Field REGISTER_CON_BASIC = new Field("REGISTER_CON_BASIC", "ZJ_RECORD_REVIEW_MZ",DbType.AnsiString, null, "确定注册建造师及等级的相关依据");
            /// <summary>
			/// 确定类似工程业绩的相关依据
			/// </summary>
			public readonly static Field SIMILAR_PROJECT_BASIC = new Field("SIMILAR_PROJECT_BASIC", "ZJ_RECORD_REVIEW_MZ",DbType.AnsiString, null, "确定类似工程业绩的相关依据");
            /// <summary>
			/// 总工期
			/// </summary>
			public readonly static Field ALL_LIMITE_TIME = new Field("ALL_LIMITE_TIME", "ZJ_RECORD_REVIEW_MZ", "总工期");
            /// <summary>
			/// 定额工期
			/// </summary>
			public readonly static Field QUOTA_LIMIT_TIME = new Field("QUOTA_LIMIT_TIME", "ZJ_RECORD_REVIEW_MZ", "定额工期");
            /// <summary>
			/// 投标人资质等级要求
			/// </summary>
			public readonly static Field BIDDER_QUALIFI_REQUIRE = new Field("BIDDER_QUALIFI_REQUIRE", "ZJ_RECORD_REVIEW_MZ",DbType.AnsiString, null, "投标人资质等级要求");
            /// <summary>
			/// 注册建造师等级要求
			/// </summary>
			public readonly static Field REGISTER_CON_REQUIRE = new Field("REGISTER_CON_REQUIRE", "ZJ_RECORD_REVIEW_MZ",DbType.AnsiString, null, "注册建造师等级要求");
            /// <summary>
			/// 是否联合体投标
			/// </summary>
			public readonly static Field SYNDICATED_FLAG = new Field("SYNDICATED_FLAG", "ZJ_RECORD_REVIEW_MZ", "是否联合体投标");
            /// <summary>
			/// 是否应用综合评价分值
			/// </summary>
			public readonly static Field IS_COMPREHENSIVE_SCORE = new Field("IS_COMPREHENSIVE_SCORE", "ZJ_RECORD_REVIEW_MZ", "是否应用综合评价分值");
            /// <summary>
			/// 类型业绩要求
			/// </summary>
			public readonly static Field TYPE_PERFORM_REQUIRE = new Field("TYPE_PERFORM_REQUIRE", "ZJ_RECORD_REVIEW_MZ",DbType.AnsiString, null, "类型业绩要求");
            /// <summary>
			/// 投标保证金金额
			/// </summary>
			public readonly static Field MARGIN_AMOUNT = new Field("MARGIN_AMOUNT", "ZJ_RECORD_REVIEW_MZ", "投标保证金金额");
            /// <summary>
			/// 投标保证金单位
			/// </summary>
			public readonly static Field MARGIN_UNIT = new Field("MARGIN_UNIT", "ZJ_RECORD_REVIEW_MZ", "投标保证金单位");
            /// <summary>
			/// 投标保证金币种
			/// </summary>
			public readonly static Field MARGIN_CURRENCY_CODE = new Field("MARGIN_CURRENCY_CODE", "ZJ_RECORD_REVIEW_MZ", "投标保证金币种");
            /// <summary>
			/// 招标文件获取方法
			/// </summary>
			public readonly static Field TENDER_DOC_GET_METHOD = new Field("TENDER_DOC_GET_METHOD", "ZJ_RECORD_REVIEW_MZ", "招标文件获取方法");
            /// <summary>
			/// 招标文件获取开始时间
			/// </summary>
			public readonly static Field DOC_GET_START_TIME = new Field("DOC_GET_START_TIME", "ZJ_RECORD_REVIEW_MZ", "招标文件获取开始时间");
            /// <summary>
			/// 招标文件获取截止时间
			/// </summary>
			public readonly static Field BID_DOC_REFER_END_TIME = new Field("BID_DOC_REFER_END_TIME", "ZJ_RECORD_REVIEW_MZ", "招标文件获取截止时间");
            /// <summary>
			/// 投标文件递交方法
			/// </summary>
			public readonly static Field BID_DOC_REFER_METHOD = new Field("BID_DOC_REFER_METHOD", "ZJ_RECORD_REVIEW_MZ", "投标文件递交方法");
            /// <summary>
			/// 招标公告
			/// </summary>
			public readonly static Field TENDER_NOTICE = new Field("TENDER_NOTICE", "ZJ_RECORD_REVIEW_MZ",DbType.AnsiString, null, "招标公告");
            /// <summary>
			/// 投标截止时间
			/// </summary>
			public readonly static Field DEADLINE_BIDDING = new Field("DEADLINE_BIDDING", "ZJ_RECORD_REVIEW_MZ", "投标截止时间");
            /// <summary>
			/// 开标时间
			/// </summary>
			public readonly static Field BID_OPEN_TIME = new Field("BID_OPEN_TIME", "ZJ_RECORD_REVIEW_MZ", "开标时间");
            /// <summary>
			/// 履约担保金额
			/// </summary>
			public readonly static Field PERFORM_PRICE = new Field("PERFORM_PRICE", "ZJ_RECORD_REVIEW_MZ", "履约担保金额");
            /// <summary>
			/// 合同签订时间
			/// </summary>
			public readonly static Field CONTRACT_SIGN_TIME = new Field("CONTRACT_SIGN_TIME", "ZJ_RECORD_REVIEW_MZ", "合同签订时间");
            /// <summary>
			/// 评标委员会成员人数
			/// </summary>
			public readonly static Field ALL_EXPERT_NUM = new Field("ALL_EXPERT_NUM", "ZJ_RECORD_REVIEW_MZ", "评标委员会成员人数");
            /// <summary>
			/// 工程造价类专家人数（最低投标价）
			/// </summary>
			public readonly static Field EXPERT_NUM = new Field("EXPERT_NUM", "ZJ_RECORD_REVIEW_MZ", "工程造价类专家人数（最低投标价）");
            /// <summary>
			/// 评标办法
			/// </summary>
			public readonly static Field EVALUATING_METHOD = new Field("EVALUATING_METHOD", "ZJ_RECORD_REVIEW_MZ", "评标办法");
            /// <summary>
			/// 工程量清单编制单位
			/// </summary>
			public readonly static Field QUANTITIES_DRAW_UNIT = new Field("QUANTITIES_DRAW_UNIT", "ZJ_RECORD_REVIEW_MZ", "工程量清单编制单位");
            /// <summary>
			/// 工程量清单审查单位
			/// </summary>
			public readonly static Field QUANTITIES_AUDIT_UNIT = new Field("QUANTITIES_AUDIT_UNIT", "ZJ_RECORD_REVIEW_MZ", "工程量清单审查单位");
            /// <summary>
			/// 招标控制价编制单位
			/// </summary>
			public readonly static Field CONTROL_PRICE_DRAW_UNIT = new Field("CONTROL_PRICE_DRAW_UNIT", "ZJ_RECORD_REVIEW_MZ", "招标控制价编制单位");
            /// <summary>
			/// 招标控制价审核单位
			/// </summary>
			public readonly static Field CONTROL_PRICE_AUDIT_UNIT = new Field("CONTROL_PRICE_AUDIT_UNIT", "ZJ_RECORD_REVIEW_MZ", "招标控制价审核单位");
            /// <summary>
			/// 履约担保金额单位
			/// </summary>
			public readonly static Field PERFORM_UNIT = new Field("PERFORM_UNIT", "ZJ_RECORD_REVIEW_MZ", "履约担保金额单位");
            /// <summary>
			/// 履约担保金额币种
			/// </summary>
			public readonly static Field PERFORM_CURRENCY_CODE = new Field("PERFORM_CURRENCY_CODE", "ZJ_RECORD_REVIEW_MZ", "履约担保金额币种");
            /// <summary>
			/// 上报时间
			/// </summary>
			public readonly static Field SUBMIT_TIME = new Field("SUBMIT_TIME", "ZJ_RECORD_REVIEW_MZ", "上报时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "ZJ_RECORD_REVIEW_MZ", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ZJ_RECORD_REVIEW_MZ", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ZJ_RECORD_REVIEW_MZ", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "ZJ_RECORD_REVIEW_MZ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "ZJ_RECORD_REVIEW_MZ", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "ZJ_RECORD_REVIEW_MZ", "");
        }
        #endregion
	}
}