using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类RECORD_RESIDENTIAL_BIDDOC。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("RECORD_RESIDENTIAL_BIDDOC")]
    [Serializable]
    public partial class RECORD_RESIDENTIAL_BIDDOC : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _RECORD_ID;
		private string _TENDER_TYPE;
		private decimal? _CONTROL_PRICE;
		private string _CONTROL_UNIT;
		private string _CONTROL_CURRENCY_CODE;
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
		private DateTime? _DOC_GET_END_TIME;
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
		private string _SCOPE_CONTRACT_RISK;
		private decimal? _CONTRACT_PRICE;
		private decimal? _ADVANCE_CHARGE;
		private decimal? _PERCENT_PROGERESS;
		private decimal? _DEFECT_LIABILITY_PERIOD;
		private decimal? _QUALITY_MARGIN_AMOUNT;
		private DateTime? _CREATE_TM;
		private decimal? _CREATOR;
		private string _TENDER_DOCNAME;
		private string _QUANTITIES_DRAW_UNIT;
		private string _QUANTITIES_AUDIT_UNIT;
		private string _CONTROL_PRICE_DRAW_UNIT;
		private string _CONTROL_PRICE_AUDIT_UNIT;
		private string _PERFORM_UNIT;
		private string _PERFORM_CURRENCY_CODE;

		/// <summary>
		/// ID
		/// </summary>
		public decimal? ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 备案主表ID
		/// </summary>
		public decimal? RECORD_ID
		{
			get{ return _RECORD_ID; }
			set
			{
				this.OnPropertyValueChange(_.RECORD_ID, _RECORD_ID, value);
				this._RECORD_ID = value;
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
		/// 招标范围及和内容
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
		/// 投标文件递交截止时间
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
		/// 合同风险范围
		/// </summary>
		public string SCOPE_CONTRACT_RISK
		{
			get{ return _SCOPE_CONTRACT_RISK; }
			set
			{
				this.OnPropertyValueChange(_.SCOPE_CONTRACT_RISK, _SCOPE_CONTRACT_RISK, value);
				this._SCOPE_CONTRACT_RISK = value;
			}
		}
		/// <summary>
		/// 合同金额
		/// </summary>
		public decimal? CONTRACT_PRICE
		{
			get{ return _CONTRACT_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_PRICE, _CONTRACT_PRICE, value);
				this._CONTRACT_PRICE = value;
			}
		}
		/// <summary>
		/// 预付款
		/// </summary>
		public decimal? ADVANCE_CHARGE
		{
			get{ return _ADVANCE_CHARGE; }
			set
			{
				this.OnPropertyValueChange(_.ADVANCE_CHARGE, _ADVANCE_CHARGE, value);
				this._ADVANCE_CHARGE = value;
			}
		}
		/// <summary>
		/// 进度款支付比例
		/// </summary>
		public decimal? PERCENT_PROGERESS
		{
			get{ return _PERCENT_PROGERESS; }
			set
			{
				this.OnPropertyValueChange(_.PERCENT_PROGERESS, _PERCENT_PROGERESS, value);
				this._PERCENT_PROGERESS = value;
			}
		}
		/// <summary>
		/// 缺陷责任工期
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
		/// 质量保证金金额
		/// </summary>
		public decimal? QUALITY_MARGIN_AMOUNT
		{
			get{ return _QUALITY_MARGIN_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.QUALITY_MARGIN_AMOUNT, _QUALITY_MARGIN_AMOUNT, value);
				this._QUALITY_MARGIN_AMOUNT = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TM
		{
			get{ return _CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TM, _CREATE_TM, value);
				this._CREATE_TM = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public decimal? CREATOR
		{
			get{ return _CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.CREATOR, _CREATOR, value);
				this._CREATOR = value;
			}
		}
		/// <summary>
		/// 招标文件名称
		/// </summary>
		public string TENDER_DOCNAME
		{
			get{ return _TENDER_DOCNAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_DOCNAME, _TENDER_DOCNAME, value);
				this._TENDER_DOCNAME = value;
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.RECORD_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.RECORD_ID,
				_.TENDER_TYPE,
				_.CONTROL_PRICE,
				_.CONTROL_UNIT,
				_.CONTROL_CURRENCY_CODE,
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
				_.DOC_GET_END_TIME,
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
				_.SCOPE_CONTRACT_RISK,
				_.CONTRACT_PRICE,
				_.ADVANCE_CHARGE,
				_.PERCENT_PROGERESS,
				_.DEFECT_LIABILITY_PERIOD,
				_.QUALITY_MARGIN_AMOUNT,
				_.CREATE_TM,
				_.CREATOR,
				_.TENDER_DOCNAME,
				_.QUANTITIES_DRAW_UNIT,
				_.QUANTITIES_AUDIT_UNIT,
				_.CONTROL_PRICE_DRAW_UNIT,
				_.CONTROL_PRICE_AUDIT_UNIT,
				_.PERFORM_UNIT,
				_.PERFORM_CURRENCY_CODE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._RECORD_ID,
				this._TENDER_TYPE,
				this._CONTROL_PRICE,
				this._CONTROL_UNIT,
				this._CONTROL_CURRENCY_CODE,
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
				this._DOC_GET_END_TIME,
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
				this._SCOPE_CONTRACT_RISK,
				this._CONTRACT_PRICE,
				this._ADVANCE_CHARGE,
				this._PERCENT_PROGERESS,
				this._DEFECT_LIABILITY_PERIOD,
				this._QUALITY_MARGIN_AMOUNT,
				this._CREATE_TM,
				this._CREATOR,
				this._TENDER_DOCNAME,
				this._QUANTITIES_DRAW_UNIT,
				this._QUANTITIES_AUDIT_UNIT,
				this._CONTROL_PRICE_DRAW_UNIT,
				this._CONTROL_PRICE_AUDIT_UNIT,
				this._PERFORM_UNIT,
				this._PERFORM_CURRENCY_CODE,
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
			public readonly static Field All = new Field("*", "RECORD_RESIDENTIAL_BIDDOC");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "RECORD_RESIDENTIAL_BIDDOC", "ID");
            /// <summary>
			/// 备案主表ID
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "RECORD_RESIDENTIAL_BIDDOC", "备案主表ID");
            /// <summary>
			/// 招标类型
			/// </summary>
			public readonly static Field TENDER_TYPE = new Field("TENDER_TYPE", "RECORD_RESIDENTIAL_BIDDOC", "招标类型");
            /// <summary>
			/// 招标控制价
			/// </summary>
			public readonly static Field CONTROL_PRICE = new Field("CONTROL_PRICE", "RECORD_RESIDENTIAL_BIDDOC", "招标控制价");
            /// <summary>
			/// 控制价单位
			/// </summary>
			public readonly static Field CONTROL_UNIT = new Field("CONTROL_UNIT", "RECORD_RESIDENTIAL_BIDDOC", "控制价单位");
            /// <summary>
			/// 控制价币种
			/// </summary>
			public readonly static Field CONTROL_CURRENCY_CODE = new Field("CONTROL_CURRENCY_CODE", "RECORD_RESIDENTIAL_BIDDOC", "控制价币种");
            /// <summary>
			/// 招标范围及和内容
			/// </summary>
			public readonly static Field TENDER_CONTENT = new Field("TENDER_CONTENT", "RECORD_RESIDENTIAL_BIDDOC",DbType.AnsiString, null, "招标范围及和内容");
            /// <summary>
			/// 确定企业资质及等级的相关依据
			/// </summary>
			public readonly static Field ENTERPRISE_QUALIFI_BASIC = new Field("ENTERPRISE_QUALIFI_BASIC", "RECORD_RESIDENTIAL_BIDDOC",DbType.AnsiString, null, "确定企业资质及等级的相关依据");
            /// <summary>
			/// 确定注册建造师及等级的相关依据
			/// </summary>
			public readonly static Field REGISTER_CON_BASIC = new Field("REGISTER_CON_BASIC", "RECORD_RESIDENTIAL_BIDDOC",DbType.AnsiString, null, "确定注册建造师及等级的相关依据");
            /// <summary>
			/// 确定类似工程业绩的相关依据
			/// </summary>
			public readonly static Field SIMILAR_PROJECT_BASIC = new Field("SIMILAR_PROJECT_BASIC", "RECORD_RESIDENTIAL_BIDDOC",DbType.AnsiString, null, "确定类似工程业绩的相关依据");
            /// <summary>
			/// 总工期
			/// </summary>
			public readonly static Field ALL_LIMITE_TIME = new Field("ALL_LIMITE_TIME", "RECORD_RESIDENTIAL_BIDDOC", "总工期");
            /// <summary>
			/// 定额工期
			/// </summary>
			public readonly static Field QUOTA_LIMIT_TIME = new Field("QUOTA_LIMIT_TIME", "RECORD_RESIDENTIAL_BIDDOC", "定额工期");
            /// <summary>
			/// 投标人资质等级要求
			/// </summary>
			public readonly static Field BIDDER_QUALIFI_REQUIRE = new Field("BIDDER_QUALIFI_REQUIRE", "RECORD_RESIDENTIAL_BIDDOC",DbType.AnsiString, null, "投标人资质等级要求");
            /// <summary>
			/// 注册建造师等级要求
			/// </summary>
			public readonly static Field REGISTER_CON_REQUIRE = new Field("REGISTER_CON_REQUIRE", "RECORD_RESIDENTIAL_BIDDOC",DbType.AnsiString, null, "注册建造师等级要求");
            /// <summary>
			/// 是否联合体投标
			/// </summary>
			public readonly static Field SYNDICATED_FLAG = new Field("SYNDICATED_FLAG", "RECORD_RESIDENTIAL_BIDDOC", "是否联合体投标");
            /// <summary>
			/// 是否应用综合评价分值
			/// </summary>
			public readonly static Field IS_COMPREHENSIVE_SCORE = new Field("IS_COMPREHENSIVE_SCORE", "RECORD_RESIDENTIAL_BIDDOC", "是否应用综合评价分值");
            /// <summary>
			/// 类型业绩要求
			/// </summary>
			public readonly static Field TYPE_PERFORM_REQUIRE = new Field("TYPE_PERFORM_REQUIRE", "RECORD_RESIDENTIAL_BIDDOC",DbType.AnsiString, null, "类型业绩要求");
            /// <summary>
			/// 投标保证金金额
			/// </summary>
			public readonly static Field MARGIN_AMOUNT = new Field("MARGIN_AMOUNT", "RECORD_RESIDENTIAL_BIDDOC", "投标保证金金额");
            /// <summary>
			/// 投标保证金单位
			/// </summary>
			public readonly static Field MARGIN_UNIT = new Field("MARGIN_UNIT", "RECORD_RESIDENTIAL_BIDDOC", "投标保证金单位");
            /// <summary>
			/// 投标保证金币种
			/// </summary>
			public readonly static Field MARGIN_CURRENCY_CODE = new Field("MARGIN_CURRENCY_CODE", "RECORD_RESIDENTIAL_BIDDOC", "投标保证金币种");
            /// <summary>
			/// 招标文件获取方法
			/// </summary>
			public readonly static Field TENDER_DOC_GET_METHOD = new Field("TENDER_DOC_GET_METHOD", "RECORD_RESIDENTIAL_BIDDOC", "招标文件获取方法");
            /// <summary>
			/// 招标文件获取开始时间
			/// </summary>
			public readonly static Field DOC_GET_START_TIME = new Field("DOC_GET_START_TIME", "RECORD_RESIDENTIAL_BIDDOC", "招标文件获取开始时间");
            /// <summary>
			/// 招标文件获取截止时间
			/// </summary>
			public readonly static Field DOC_GET_END_TIME = new Field("DOC_GET_END_TIME", "RECORD_RESIDENTIAL_BIDDOC", "招标文件获取截止时间");
            /// <summary>
			/// 投标文件递交截止时间
			/// </summary>
			public readonly static Field BID_DOC_REFER_END_TIME = new Field("BID_DOC_REFER_END_TIME", "RECORD_RESIDENTIAL_BIDDOC", "投标文件递交截止时间");
            /// <summary>
			/// 投标文件递交方法
			/// </summary>
			public readonly static Field BID_DOC_REFER_METHOD = new Field("BID_DOC_REFER_METHOD", "RECORD_RESIDENTIAL_BIDDOC", "投标文件递交方法");
            /// <summary>
			/// 招标公告
			/// </summary>
			public readonly static Field TENDER_NOTICE = new Field("TENDER_NOTICE", "RECORD_RESIDENTIAL_BIDDOC",DbType.AnsiString, null, "招标公告");
            /// <summary>
			/// 投标截止时间
			/// </summary>
			public readonly static Field DEADLINE_BIDDING = new Field("DEADLINE_BIDDING", "RECORD_RESIDENTIAL_BIDDOC", "投标截止时间");
            /// <summary>
			/// 开标时间
			/// </summary>
			public readonly static Field BID_OPEN_TIME = new Field("BID_OPEN_TIME", "RECORD_RESIDENTIAL_BIDDOC", "开标时间");
            /// <summary>
			/// 履约担保金额
			/// </summary>
			public readonly static Field PERFORM_PRICE = new Field("PERFORM_PRICE", "RECORD_RESIDENTIAL_BIDDOC", "履约担保金额");
            /// <summary>
			/// 合同签订时间
			/// </summary>
			public readonly static Field CONTRACT_SIGN_TIME = new Field("CONTRACT_SIGN_TIME", "RECORD_RESIDENTIAL_BIDDOC", "合同签订时间");
            /// <summary>
			/// 评标委员会成员人数
			/// </summary>
			public readonly static Field ALL_EXPERT_NUM = new Field("ALL_EXPERT_NUM", "RECORD_RESIDENTIAL_BIDDOC", "评标委员会成员人数");
            /// <summary>
			/// 工程造价类专家人数（最低投标价）
			/// </summary>
			public readonly static Field EXPERT_NUM = new Field("EXPERT_NUM", "RECORD_RESIDENTIAL_BIDDOC", "工程造价类专家人数（最低投标价）");
            /// <summary>
			/// 评标办法
			/// </summary>
			public readonly static Field EVALUATING_METHOD = new Field("EVALUATING_METHOD", "RECORD_RESIDENTIAL_BIDDOC", "评标办法");
            /// <summary>
			/// 合同风险范围
			/// </summary>
			public readonly static Field SCOPE_CONTRACT_RISK = new Field("SCOPE_CONTRACT_RISK", "RECORD_RESIDENTIAL_BIDDOC",DbType.AnsiString, null, "合同风险范围");
            /// <summary>
			/// 合同金额
			/// </summary>
			public readonly static Field CONTRACT_PRICE = new Field("CONTRACT_PRICE", "RECORD_RESIDENTIAL_BIDDOC", "合同金额");
            /// <summary>
			/// 预付款
			/// </summary>
			public readonly static Field ADVANCE_CHARGE = new Field("ADVANCE_CHARGE", "RECORD_RESIDENTIAL_BIDDOC", "预付款");
            /// <summary>
			/// 进度款支付比例
			/// </summary>
			public readonly static Field PERCENT_PROGERESS = new Field("PERCENT_PROGERESS", "RECORD_RESIDENTIAL_BIDDOC", "进度款支付比例");
            /// <summary>
			/// 缺陷责任工期
			/// </summary>
			public readonly static Field DEFECT_LIABILITY_PERIOD = new Field("DEFECT_LIABILITY_PERIOD", "RECORD_RESIDENTIAL_BIDDOC", "缺陷责任工期");
            /// <summary>
			/// 质量保证金金额
			/// </summary>
			public readonly static Field QUALITY_MARGIN_AMOUNT = new Field("QUALITY_MARGIN_AMOUNT", "RECORD_RESIDENTIAL_BIDDOC", "质量保证金金额");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "RECORD_RESIDENTIAL_BIDDOC", "创建时间");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "RECORD_RESIDENTIAL_BIDDOC", "创建人");
            /// <summary>
			/// 招标文件名称
			/// </summary>
			public readonly static Field TENDER_DOCNAME = new Field("TENDER_DOCNAME", "RECORD_RESIDENTIAL_BIDDOC", "招标文件名称");
            /// <summary>
			/// 工程量清单编制单位
			/// </summary>
			public readonly static Field QUANTITIES_DRAW_UNIT = new Field("QUANTITIES_DRAW_UNIT", "RECORD_RESIDENTIAL_BIDDOC", "工程量清单编制单位");
            /// <summary>
			/// 工程量清单审查单位
			/// </summary>
			public readonly static Field QUANTITIES_AUDIT_UNIT = new Field("QUANTITIES_AUDIT_UNIT", "RECORD_RESIDENTIAL_BIDDOC", "工程量清单审查单位");
            /// <summary>
			/// 招标控制价编制单位
			/// </summary>
			public readonly static Field CONTROL_PRICE_DRAW_UNIT = new Field("CONTROL_PRICE_DRAW_UNIT", "RECORD_RESIDENTIAL_BIDDOC", "招标控制价编制单位");
            /// <summary>
			/// 招标控制价审核单位
			/// </summary>
			public readonly static Field CONTROL_PRICE_AUDIT_UNIT = new Field("CONTROL_PRICE_AUDIT_UNIT", "RECORD_RESIDENTIAL_BIDDOC", "招标控制价审核单位");
            /// <summary>
			/// 履约担保金额单位
			/// </summary>
			public readonly static Field PERFORM_UNIT = new Field("PERFORM_UNIT", "RECORD_RESIDENTIAL_BIDDOC", "履约担保金额单位");
            /// <summary>
			/// 履约担保金额币种
			/// </summary>
			public readonly static Field PERFORM_CURRENCY_CODE = new Field("PERFORM_CURRENCY_CODE", "RECORD_RESIDENTIAL_BIDDOC", "履约担保金额币种");
        }
        #endregion
	}
}