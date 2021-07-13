using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PAYMENT_MANAGE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PAYMENT_MANAGE")]
    [Serializable]
    public partial class PAYMENT_MANAGE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _LOT_NUM;
		private string _TITLE_NAME;
		private string _BIDDER_NAME;
		private string _BID_CODE;
		private string _BID_BOND;
		private string _PREPAYMENT_PAYMENT;
		private string _PREPAID_RETURN;
		private string _TRANSACTION_SERVICE;
		private string _CONTRACT_PRICE;
		private string _PAY_FORM;
		private DateTime? _RECEPTION_TIME;
		private DateTime? _ARRIVAL_TIME;
		private string _MONEY;
		private string _CURRENCY;
		private string _UNIT;

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
		/// 标段（包）编号
		/// </summary>
		public string LOT_NUM
		{
			get{ return _LOT_NUM; }
			set
			{
				this.OnPropertyValueChange(_.LOT_NUM, _LOT_NUM, value);
				this._LOT_NUM = value;
			}
		}
		/// <summary>
		/// 标段（包）名称
		/// </summary>
		public string TITLE_NAME
		{
			get{ return _TITLE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TITLE_NAME, _TITLE_NAME, value);
				this._TITLE_NAME = value;
			}
		}
		/// <summary>
		/// 投标人名称
		/// </summary>
		public string BIDDER_NAME
		{
			get{ return _BIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_NAME, _BIDDER_NAME, value);
				this._BIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 投标人代码
		/// </summary>
		public string BID_CODE
		{
			get{ return _BID_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_CODE, _BID_CODE, value);
				this._BID_CODE = value;
			}
		}
		/// <summary>
		/// 投标保证金
		/// </summary>
		public string BID_BOND
		{
			get{ return _BID_BOND; }
			set
			{
				this.OnPropertyValueChange(_.BID_BOND, _BID_BOND, value);
				this._BID_BOND = value;
			}
		}
		/// <summary>
		/// 预付款缴纳
		/// </summary>
		public string PREPAYMENT_PAYMENT
		{
			get{ return _PREPAYMENT_PAYMENT; }
			set
			{
				this.OnPropertyValueChange(_.PREPAYMENT_PAYMENT, _PREPAYMENT_PAYMENT, value);
				this._PREPAYMENT_PAYMENT = value;
			}
		}
		/// <summary>
		/// 预付款退回
		/// </summary>
		public string PREPAID_RETURN
		{
			get{ return _PREPAID_RETURN; }
			set
			{
				this.OnPropertyValueChange(_.PREPAID_RETURN, _PREPAID_RETURN, value);
				this._PREPAID_RETURN = value;
			}
		}
		/// <summary>
		/// 交易服务缴纳费
		/// </summary>
		public string TRANSACTION_SERVICE
		{
			get{ return _TRANSACTION_SERVICE; }
			set
			{
				this.OnPropertyValueChange(_.TRANSACTION_SERVICE, _TRANSACTION_SERVICE, value);
				this._TRANSACTION_SERVICE = value;
			}
		}
		/// <summary>
		/// 合同价款结算
		/// </summary>
		public string CONTRACT_PRICE
		{
			get{ return _CONTRACT_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_PRICE, _CONTRACT_PRICE, value);
				this._CONTRACT_PRICE = value;
			}
		}
		/// <summary>
		/// 支付形式
		/// </summary>
		public string PAY_FORM
		{
			get{ return _PAY_FORM; }
			set
			{
				this.OnPropertyValueChange(_.PAY_FORM, _PAY_FORM, value);
				this._PAY_FORM = value;
			}
		}
		/// <summary>
		/// 凭证接收时间
		/// </summary>
		public DateTime? RECEPTION_TIME
		{
			get{ return _RECEPTION_TIME; }
			set
			{
				this.OnPropertyValueChange(_.RECEPTION_TIME, _RECEPTION_TIME, value);
				this._RECEPTION_TIME = value;
			}
		}
		/// <summary>
		/// 保证金到账时间
		/// </summary>
		public DateTime? ARRIVAL_TIME
		{
			get{ return _ARRIVAL_TIME; }
			set
			{
				this.OnPropertyValueChange(_.ARRIVAL_TIME, _ARRIVAL_TIME, value);
				this._ARRIVAL_TIME = value;
			}
		}
		/// <summary>
		/// 金额
		/// </summary>
		public string MONEY
		{
			get{ return _MONEY; }
			set
			{
				this.OnPropertyValueChange(_.MONEY, _MONEY, value);
				this._MONEY = value;
			}
		}
		/// <summary>
		/// 币种代码
		/// </summary>
		public string CURRENCY
		{
			get{ return _CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.CURRENCY, _CURRENCY, value);
				this._CURRENCY = value;
			}
		}
		/// <summary>
		/// 单位
		/// </summary>
		public string UNIT
		{
			get{ return _UNIT; }
			set
			{
				this.OnPropertyValueChange(_.UNIT, _UNIT, value);
				this._UNIT = value;
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
				_.ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.LOT_NUM,
				_.TITLE_NAME,
				_.BIDDER_NAME,
				_.BID_CODE,
				_.BID_BOND,
				_.PREPAYMENT_PAYMENT,
				_.PREPAID_RETURN,
				_.TRANSACTION_SERVICE,
				_.CONTRACT_PRICE,
				_.PAY_FORM,
				_.RECEPTION_TIME,
				_.ARRIVAL_TIME,
				_.MONEY,
				_.CURRENCY,
				_.UNIT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._LOT_NUM,
				this._TITLE_NAME,
				this._BIDDER_NAME,
				this._BID_CODE,
				this._BID_BOND,
				this._PREPAYMENT_PAYMENT,
				this._PREPAID_RETURN,
				this._TRANSACTION_SERVICE,
				this._CONTRACT_PRICE,
				this._PAY_FORM,
				this._RECEPTION_TIME,
				this._ARRIVAL_TIME,
				this._MONEY,
				this._CURRENCY,
				this._UNIT,
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
			public readonly static Field All = new Field("*", "PAYMENT_MANAGE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PAYMENT_MANAGE", "ID");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field LOT_NUM = new Field("LOT_NUM", "PAYMENT_MANAGE", "标段（包）编号");
            /// <summary>
			/// 标段（包）名称
			/// </summary>
			public readonly static Field TITLE_NAME = new Field("TITLE_NAME", "PAYMENT_MANAGE", "标段（包）名称");
            /// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "PAYMENT_MANAGE", "投标人名称");
            /// <summary>
			/// 投标人代码
			/// </summary>
			public readonly static Field BID_CODE = new Field("BID_CODE", "PAYMENT_MANAGE", "投标人代码");
            /// <summary>
			/// 投标保证金
			/// </summary>
			public readonly static Field BID_BOND = new Field("BID_BOND", "PAYMENT_MANAGE", "投标保证金");
            /// <summary>
			/// 预付款缴纳
			/// </summary>
			public readonly static Field PREPAYMENT_PAYMENT = new Field("PREPAYMENT_PAYMENT", "PAYMENT_MANAGE", "预付款缴纳");
            /// <summary>
			/// 预付款退回
			/// </summary>
			public readonly static Field PREPAID_RETURN = new Field("PREPAID_RETURN", "PAYMENT_MANAGE", "预付款退回");
            /// <summary>
			/// 交易服务缴纳费
			/// </summary>
			public readonly static Field TRANSACTION_SERVICE = new Field("TRANSACTION_SERVICE", "PAYMENT_MANAGE", "交易服务缴纳费");
            /// <summary>
			/// 合同价款结算
			/// </summary>
			public readonly static Field CONTRACT_PRICE = new Field("CONTRACT_PRICE", "PAYMENT_MANAGE", "合同价款结算");
            /// <summary>
			/// 支付形式
			/// </summary>
			public readonly static Field PAY_FORM = new Field("PAY_FORM", "PAYMENT_MANAGE", "支付形式");
            /// <summary>
			/// 凭证接收时间
			/// </summary>
			public readonly static Field RECEPTION_TIME = new Field("RECEPTION_TIME", "PAYMENT_MANAGE", "凭证接收时间");
            /// <summary>
			/// 保证金到账时间
			/// </summary>
			public readonly static Field ARRIVAL_TIME = new Field("ARRIVAL_TIME", "PAYMENT_MANAGE", "保证金到账时间");
            /// <summary>
			/// 金额
			/// </summary>
			public readonly static Field MONEY = new Field("MONEY", "PAYMENT_MANAGE", "金额");
            /// <summary>
			/// 币种代码
			/// </summary>
			public readonly static Field CURRENCY = new Field("CURRENCY", "PAYMENT_MANAGE", "币种代码");
            /// <summary>
			/// 单位
			/// </summary>
			public readonly static Field UNIT = new Field("UNIT", "PAYMENT_MANAGE", "单位");
        }
        #endregion
	}
}