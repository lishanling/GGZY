using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类RECORD_CLASSIFY_NORMAL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("RECORD_CLASSIFY_NORMAL")]
    [Serializable]
    public partial class RECORD_CLASSIFY_NORMAL : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _RECORD_ID;
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
		private string _IS_POSTPONE;
		private DateTime? _DEADLINE_BIDDING2;
		private DateTime? _POST_OPEN_TIME;
		private string _POST_OPEN_ADDRESS;
		private DateTime? _CLARIFY_END_TIME;
		private DateTime? _DEPOSIT_END_TIME;
		private string _CLARIFY_TITLE;
		private string _CLARIFY_CONTENT;
		private DateTime? _CREATE_TM;
		private decimal? _CREATOR;

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
		/// 是否延期
		/// </summary>
		public string IS_POSTPONE
		{
			get{ return _IS_POSTPONE; }
			set
			{
				this.OnPropertyValueChange(_.IS_POSTPONE, _IS_POSTPONE, value);
				this._IS_POSTPONE = value;
			}
		}
		/// <summary>
		/// 投标截止时间-澄清修改
		/// </summary>
		public DateTime? DEADLINE_BIDDING2
		{
			get{ return _DEADLINE_BIDDING2; }
			set
			{
				this.OnPropertyValueChange(_.DEADLINE_BIDDING2, _DEADLINE_BIDDING2, value);
				this._DEADLINE_BIDDING2 = value;
			}
		}
		/// <summary>
		/// 延期后开标时间
		/// </summary>
		public DateTime? POST_OPEN_TIME
		{
			get{ return _POST_OPEN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.POST_OPEN_TIME, _POST_OPEN_TIME, value);
				this._POST_OPEN_TIME = value;
			}
		}
		/// <summary>
		/// 延期后开标地点
		/// </summary>
		public string POST_OPEN_ADDRESS
		{
			get{ return _POST_OPEN_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.POST_OPEN_ADDRESS, _POST_OPEN_ADDRESS, value);
				this._POST_OPEN_ADDRESS = value;
			}
		}
		/// <summary>
		/// 澄清、修改截止时间
		/// </summary>
		public DateTime? CLARIFY_END_TIME
		{
			get{ return _CLARIFY_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CLARIFY_END_TIME, _CLARIFY_END_TIME, value);
				this._CLARIFY_END_TIME = value;
			}
		}
		/// <summary>
		/// 保证金提交截止时间
		/// </summary>
		public DateTime? DEPOSIT_END_TIME
		{
			get{ return _DEPOSIT_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.DEPOSIT_END_TIME, _DEPOSIT_END_TIME, value);
				this._DEPOSIT_END_TIME = value;
			}
		}
		/// <summary>
		/// 澄清、修改公示标题
		/// </summary>
		public string CLARIFY_TITLE
		{
			get{ return _CLARIFY_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.CLARIFY_TITLE, _CLARIFY_TITLE, value);
				this._CLARIFY_TITLE = value;
			}
		}
		/// <summary>
		/// 澄清、修改内容
		/// </summary>
		public string CLARIFY_CONTENT
		{
			get{ return _CLARIFY_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CLARIFY_CONTENT, _CLARIFY_CONTENT, value);
				this._CLARIFY_CONTENT = value;
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
				_.IS_POSTPONE,
				_.DEADLINE_BIDDING2,
				_.POST_OPEN_TIME,
				_.POST_OPEN_ADDRESS,
				_.CLARIFY_END_TIME,
				_.DEPOSIT_END_TIME,
				_.CLARIFY_TITLE,
				_.CLARIFY_CONTENT,
				_.CREATE_TM,
				_.CREATOR,
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
				this._IS_POSTPONE,
				this._DEADLINE_BIDDING2,
				this._POST_OPEN_TIME,
				this._POST_OPEN_ADDRESS,
				this._CLARIFY_END_TIME,
				this._DEPOSIT_END_TIME,
				this._CLARIFY_TITLE,
				this._CLARIFY_CONTENT,
				this._CREATE_TM,
				this._CREATOR,
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
			public readonly static Field All = new Field("*", "RECORD_CLASSIFY_NORMAL");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "RECORD_CLASSIFY_NORMAL", "ID");
            /// <summary>
			/// 备案主表ID
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "RECORD_CLASSIFY_NORMAL", "备案主表ID");
            /// <summary>
			/// 招标文件/资格预审文件获取时间
			/// </summary>
			public readonly static Field TENDER_DOC_GET_TIME = new Field("TENDER_DOC_GET_TIME", "RECORD_CLASSIFY_NORMAL", "招标文件/资格预审文件获取时间");
            /// <summary>
			/// 招标文件/资格预审文件获取截至时间
			/// </summary>
			public readonly static Field DOC_GET_END_TIME = new Field("DOC_GET_END_TIME", "RECORD_CLASSIFY_NORMAL", "招标文件/资格预审文件获取截至时间");
            /// <summary>
			/// 投标文件/资格预审申请文件递交截止时间
			/// </summary>
			public readonly static Field BID_DOC_REFER_END_TIME = new Field("BID_DOC_REFER_END_TIME", "RECORD_CLASSIFY_NORMAL", "投标文件/资格预审申请文件递交截止时间");
            /// <summary>
			/// 开标时间
			/// </summary>
			public readonly static Field BID_OPEN_TIME = new Field("BID_OPEN_TIME", "RECORD_CLASSIFY_NORMAL", "开标时间");
            /// <summary>
			/// 文件售价
			/// </summary>
			public readonly static Field DOC_PRICE = new Field("DOC_PRICE", "RECORD_CLASSIFY_NORMAL", "文件售价");
            /// <summary>
			/// 文件售价币种
			/// </summary>
			public readonly static Field DOC_PRICE_CURRENCY = new Field("DOC_PRICE_CURRENCY", "RECORD_CLASSIFY_NORMAL", "文件售价币种");
            /// <summary>
			/// 文件售价单位
			/// </summary>
			public readonly static Field DOC_PRICE_UNIT = new Field("DOC_PRICE_UNIT", "RECORD_CLASSIFY_NORMAL", "文件售价单位");
            /// <summary>
			/// 是否允许联合体投标
			/// </summary>
			public readonly static Field SYNDICATED_FLAG = new Field("SYNDICATED_FLAG", "RECORD_CLASSIFY_NORMAL", "是否允许联合体投标");
            /// <summary>
			/// 联合体投标要求
			/// </summary>
			public readonly static Field SYNDICATED_REQUIRE = new Field("SYNDICATED_REQUIRE", "RECORD_CLASSIFY_NORMAL",DbType.AnsiString, null, "联合体投标要求");
            /// <summary>
			/// 确定类似工程业绩的相关依据
			/// </summary>
			public readonly static Field SIMILAR_PROJECT_BASIC = new Field("SIMILAR_PROJECT_BASIC", "RECORD_CLASSIFY_NORMAL",DbType.AnsiString, null, "确定类似工程业绩的相关依据");
            /// <summary>
			/// 投标资格
			/// </summary>
			public readonly static Field BID_QUALIFICATION = new Field("BID_QUALIFICATION", "RECORD_CLASSIFY_NORMAL",DbType.AnsiString, null, "投标资格");
            /// <summary>
			/// 投标有效期
			/// </summary>
			public readonly static Field VALID_PERIOD = new Field("VALID_PERIOD", "RECORD_CLASSIFY_NORMAL", "投标有效期");
            /// <summary>
			/// 投标文件递交方法
			/// </summary>
			public readonly static Field BID_DOC_REFER_METHOD = new Field("BID_DOC_REFER_METHOD", "RECORD_CLASSIFY_NORMAL",DbType.AnsiString, null, "投标文件递交方法");
            /// <summary>
			/// 投标保证金缴纳方式
			/// </summary>
			public readonly static Field MARGIN_PAY_TYPE = new Field("MARGIN_PAY_TYPE", "RECORD_CLASSIFY_NORMAL", "投标保证金缴纳方式");
            /// <summary>
			/// 投标保证金金额
			/// </summary>
			public readonly static Field MARGIN_AMOUNT = new Field("MARGIN_AMOUNT", "RECORD_CLASSIFY_NORMAL", "投标保证金金额");
            /// <summary>
			/// 投标保证金单位
			/// </summary>
			public readonly static Field MARGIN_UNIT = new Field("MARGIN_UNIT", "RECORD_CLASSIFY_NORMAL", "投标保证金单位");
            /// <summary>
			/// 投标保证金币种
			/// </summary>
			public readonly static Field MARGIN_CURRENCY_CODE = new Field("MARGIN_CURRENCY_CODE", "RECORD_CLASSIFY_NORMAL", "投标保证金币种");
            /// <summary>
			/// 招标控制价
			/// </summary>
			public readonly static Field CONTROL_PRICE = new Field("CONTROL_PRICE", "RECORD_CLASSIFY_NORMAL", "招标控制价");
            /// <summary>
			/// 控制价单位
			/// </summary>
			public readonly static Field CONTROL_UNIT = new Field("CONTROL_UNIT", "RECORD_CLASSIFY_NORMAL", "控制价单位");
            /// <summary>
			/// 控制价币种
			/// </summary>
			public readonly static Field CONTROL_CURRENCY_CODE = new Field("CONTROL_CURRENCY_CODE", "RECORD_CLASSIFY_NORMAL", "控制价币种");
            /// <summary>
			/// 评标办法
			/// </summary>
			public readonly static Field EVALUATING_METHOD = new Field("EVALUATING_METHOD", "RECORD_CLASSIFY_NORMAL",DbType.AnsiString, null, "评标办法");
            /// <summary>
			/// 开标地点
			/// </summary>
			public readonly static Field BID_OPEN_PLACE = new Field("BID_OPEN_PLACE", "RECORD_CLASSIFY_NORMAL", "开标地点");
            /// <summary>
			/// 答疑澄清时间
			/// </summary>
			public readonly static Field CLARIFY_TIME = new Field("CLARIFY_TIME", "RECORD_CLASSIFY_NORMAL", "答疑澄清时间");
            /// <summary>
			/// 招标公告
			/// </summary>
			public readonly static Field TENDER_NOTICE = new Field("TENDER_NOTICE", "RECORD_CLASSIFY_NORMAL",DbType.AnsiString, null, "招标公告");
            /// <summary>
			/// 资格审查方式
			/// </summary>
			public readonly static Field QUAL_TYPE = new Field("QUAL_TYPE", "RECORD_CLASSIFY_NORMAL", "资格审查方式");
            /// <summary>
			/// 是否延期
			/// </summary>
			public readonly static Field IS_POSTPONE = new Field("IS_POSTPONE", "RECORD_CLASSIFY_NORMAL", "是否延期");
            /// <summary>
			/// 投标截止时间-澄清修改
			/// </summary>
			public readonly static Field DEADLINE_BIDDING2 = new Field("DEADLINE_BIDDING2", "RECORD_CLASSIFY_NORMAL", "投标截止时间-澄清修改");
            /// <summary>
			/// 延期后开标时间
			/// </summary>
			public readonly static Field POST_OPEN_TIME = new Field("POST_OPEN_TIME", "RECORD_CLASSIFY_NORMAL", "延期后开标时间");
            /// <summary>
			/// 延期后开标地点
			/// </summary>
			public readonly static Field POST_OPEN_ADDRESS = new Field("POST_OPEN_ADDRESS", "RECORD_CLASSIFY_NORMAL", "延期后开标地点");
            /// <summary>
			/// 澄清、修改截止时间
			/// </summary>
			public readonly static Field CLARIFY_END_TIME = new Field("CLARIFY_END_TIME", "RECORD_CLASSIFY_NORMAL", "澄清、修改截止时间");
            /// <summary>
			/// 保证金提交截止时间
			/// </summary>
			public readonly static Field DEPOSIT_END_TIME = new Field("DEPOSIT_END_TIME", "RECORD_CLASSIFY_NORMAL", "保证金提交截止时间");
            /// <summary>
			/// 澄清、修改公示标题
			/// </summary>
			public readonly static Field CLARIFY_TITLE = new Field("CLARIFY_TITLE", "RECORD_CLASSIFY_NORMAL", "澄清、修改公示标题");
            /// <summary>
			/// 澄清、修改内容
			/// </summary>
			public readonly static Field CLARIFY_CONTENT = new Field("CLARIFY_CONTENT", "RECORD_CLASSIFY_NORMAL",DbType.AnsiString, null, "澄清、修改内容");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "RECORD_CLASSIFY_NORMAL", "创建时间");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "RECORD_CLASSIFY_NORMAL", "创建人");
        }
        #endregion
	}
}