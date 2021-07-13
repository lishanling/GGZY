using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PAYMENT_AUDIT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PAYMENT_AUDIT")]
    [Serializable]
    public partial class PAYMENT_AUDIT : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _BID_BOND;
		private string _PREPAYMENTS;
		private string _SERVICE_FEE;
		private string _FINANCIAL_AUDIT;
		private string _MARGIN;
		private string _PAYMENT_FORM;
		private DateTime? _PAY_TIME;
		private string _MONEY;
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
		/// 预付款
		/// </summary>
		public string PREPAYMENTS
		{
			get{ return _PREPAYMENTS; }
			set
			{
				this.OnPropertyValueChange(_.PREPAYMENTS, _PREPAYMENTS, value);
				this._PREPAYMENTS = value;
			}
		}
		/// <summary>
		/// 交易服务费
		/// </summary>
		public string SERVICE_FEE
		{
			get{ return _SERVICE_FEE; }
			set
			{
				this.OnPropertyValueChange(_.SERVICE_FEE, _SERVICE_FEE, value);
				this._SERVICE_FEE = value;
			}
		}
		/// <summary>
		/// 财务审核计算
		/// </summary>
		public string FINANCIAL_AUDIT
		{
			get{ return _FINANCIAL_AUDIT; }
			set
			{
				this.OnPropertyValueChange(_.FINANCIAL_AUDIT, _FINANCIAL_AUDIT, value);
				this._FINANCIAL_AUDIT = value;
			}
		}
		/// <summary>
		/// 保证金
		/// </summary>
		public string MARGIN
		{
			get{ return _MARGIN; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN, _MARGIN, value);
				this._MARGIN = value;
			}
		}
		/// <summary>
		/// 缴纳形式
		/// </summary>
		public string PAYMENT_FORM
		{
			get{ return _PAYMENT_FORM; }
			set
			{
				this.OnPropertyValueChange(_.PAYMENT_FORM, _PAYMENT_FORM, value);
				this._PAYMENT_FORM = value;
			}
		}
		/// <summary>
		/// 缴纳时间
		/// </summary>
		public DateTime? PAY_TIME
		{
			get{ return _PAY_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PAY_TIME, _PAY_TIME, value);
				this._PAY_TIME = value;
			}
		}
		/// <summary>
		/// 缴纳金额
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
				_.BID_BOND,
				_.PREPAYMENTS,
				_.SERVICE_FEE,
				_.FINANCIAL_AUDIT,
				_.MARGIN,
				_.PAYMENT_FORM,
				_.PAY_TIME,
				_.MONEY,
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
				this._BID_BOND,
				this._PREPAYMENTS,
				this._SERVICE_FEE,
				this._FINANCIAL_AUDIT,
				this._MARGIN,
				this._PAYMENT_FORM,
				this._PAY_TIME,
				this._MONEY,
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
			public readonly static Field All = new Field("*", "PAYMENT_AUDIT");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PAYMENT_AUDIT", "ID");
            /// <summary>
			/// 投标保证金
			/// </summary>
			public readonly static Field BID_BOND = new Field("BID_BOND", "PAYMENT_AUDIT", "投标保证金");
            /// <summary>
			/// 预付款
			/// </summary>
			public readonly static Field PREPAYMENTS = new Field("PREPAYMENTS", "PAYMENT_AUDIT", "预付款");
            /// <summary>
			/// 交易服务费
			/// </summary>
			public readonly static Field SERVICE_FEE = new Field("SERVICE_FEE", "PAYMENT_AUDIT", "交易服务费");
            /// <summary>
			/// 财务审核计算
			/// </summary>
			public readonly static Field FINANCIAL_AUDIT = new Field("FINANCIAL_AUDIT", "PAYMENT_AUDIT", "财务审核计算");
            /// <summary>
			/// 保证金
			/// </summary>
			public readonly static Field MARGIN = new Field("MARGIN", "PAYMENT_AUDIT", "保证金");
            /// <summary>
			/// 缴纳形式
			/// </summary>
			public readonly static Field PAYMENT_FORM = new Field("PAYMENT_FORM", "PAYMENT_AUDIT", "缴纳形式");
            /// <summary>
			/// 缴纳时间
			/// </summary>
			public readonly static Field PAY_TIME = new Field("PAY_TIME", "PAYMENT_AUDIT", "缴纳时间");
            /// <summary>
			/// 缴纳金额
			/// </summary>
			public readonly static Field MONEY = new Field("MONEY", "PAYMENT_AUDIT", "缴纳金额");
            /// <summary>
			/// 单位
			/// </summary>
			public readonly static Field UNIT = new Field("UNIT", "PAYMENT_AUDIT", "单位");
        }
        #endregion
	}
}