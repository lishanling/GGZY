using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MAK_PER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MAK_PER")]
    [Serializable]
    public partial class MAK_PER : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _BID_BUR_ASS;
		private string _BID_NUM;
		private string _BID_NAME;
		private string _TENDER_CODE;
		private string _TENDER_NAME;
		private string _WIN_BID_MONEY;
		private string _CONTRACT;
		private string _CONTRACT_SET;
		private string _CONTRACT_PER;
		private string _ACTUAL;
		private string _AMOUNT_CODE;
		private string _CURRENCY_UNIT;
		private string _CONTRACT_TIME;

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
		/// 投标人/采购人/出让人代码
		/// </summary>
		public string BID_BUR_ASS
		{
			get{ return _BID_BUR_ASS; }
			set
			{
				this.OnPropertyValueChange(_.BID_BUR_ASS, _BID_BUR_ASS, value);
				this._BID_BUR_ASS = value;
			}
		}
		/// <summary>
		/// 中标/成交项目的标段（包）编号
		/// </summary>
		public string BID_NUM
		{
			get{ return _BID_NUM; }
			set
			{
				this.OnPropertyValueChange(_.BID_NUM, _BID_NUM, value);
				this._BID_NUM = value;
			}
		}
		/// <summary>
		/// 中标/成交项目和标段（包）名称
		/// </summary>
		public string BID_NAME
		{
			get{ return _BID_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BID_NAME, _BID_NAME, value);
				this._BID_NAME = value;
			}
		}
		/// <summary>
		/// 招标人/采购人/出让人代码
		/// </summary>
		public string TENDER_CODE
		{
			get{ return _TENDER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_CODE, _TENDER_CODE, value);
				this._TENDER_CODE = value;
			}
		}
		/// <summary>
		/// 招标人/采购人/出让人名称
		/// </summary>
		public string TENDER_NAME
		{
			get{ return _TENDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_NAME, _TENDER_NAME, value);
				this._TENDER_NAME = value;
			}
		}
		/// <summary>
		/// 中标/成交金额
		/// </summary>
		public string WIN_BID_MONEY
		{
			get{ return _WIN_BID_MONEY; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BID_MONEY, _WIN_BID_MONEY, value);
				this._WIN_BID_MONEY = value;
			}
		}
		/// <summary>
		/// 合同金额
		/// </summary>
		public string CONTRACT
		{
			get{ return _CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT, _CONTRACT, value);
				this._CONTRACT = value;
			}
		}
		/// <summary>
		/// 合同结算金额
		/// </summary>
		public string CONTRACT_SET
		{
			get{ return _CONTRACT_SET; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_SET, _CONTRACT_SET, value);
				this._CONTRACT_SET = value;
			}
		}
		/// <summary>
		/// 合同期限
		/// </summary>
		public string CONTRACT_PER
		{
			get{ return _CONTRACT_PER; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_PER, _CONTRACT_PER, value);
				this._CONTRACT_PER = value;
			}
		}
		/// <summary>
		/// 实际履行期限
		/// </summary>
		public string ACTUAL
		{
			get{ return _ACTUAL; }
			set
			{
				this.OnPropertyValueChange(_.ACTUAL, _ACTUAL, value);
				this._ACTUAL = value;
			}
		}
		/// <summary>
		/// 金额币种代码
		/// </summary>
		public string AMOUNT_CODE
		{
			get{ return _AMOUNT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.AMOUNT_CODE, _AMOUNT_CODE, value);
				this._AMOUNT_CODE = value;
			}
		}
		/// <summary>
		/// 金额单位
		/// </summary>
		public string CURRENCY_UNIT
		{
			get{ return _CURRENCY_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.CURRENCY_UNIT, _CURRENCY_UNIT, value);
				this._CURRENCY_UNIT = value;
			}
		}
		/// <summary>
		/// 合同签署时间
		/// </summary>
		public string CONTRACT_TIME
		{
			get{ return _CONTRACT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_TIME, _CONTRACT_TIME, value);
				this._CONTRACT_TIME = value;
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
				_.BID_BUR_ASS,
				_.BID_NUM,
				_.BID_NAME,
				_.TENDER_CODE,
				_.TENDER_NAME,
				_.WIN_BID_MONEY,
				_.CONTRACT,
				_.CONTRACT_SET,
				_.CONTRACT_PER,
				_.ACTUAL,
				_.AMOUNT_CODE,
				_.CURRENCY_UNIT,
				_.CONTRACT_TIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._BID_BUR_ASS,
				this._BID_NUM,
				this._BID_NAME,
				this._TENDER_CODE,
				this._TENDER_NAME,
				this._WIN_BID_MONEY,
				this._CONTRACT,
				this._CONTRACT_SET,
				this._CONTRACT_PER,
				this._ACTUAL,
				this._AMOUNT_CODE,
				this._CURRENCY_UNIT,
				this._CONTRACT_TIME,
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
			public readonly static Field All = new Field("*", "MAK_PER");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "MAK_PER", "ID");
            /// <summary>
			/// 投标人/采购人/出让人代码
			/// </summary>
			public readonly static Field BID_BUR_ASS = new Field("BID_BUR_ASS", "MAK_PER", "投标人/采购人/出让人代码");
            /// <summary>
			/// 中标/成交项目的标段（包）编号
			/// </summary>
			public readonly static Field BID_NUM = new Field("BID_NUM", "MAK_PER", "中标/成交项目的标段（包）编号");
            /// <summary>
			/// 中标/成交项目和标段（包）名称
			/// </summary>
			public readonly static Field BID_NAME = new Field("BID_NAME", "MAK_PER", "中标/成交项目和标段（包）名称");
            /// <summary>
			/// 招标人/采购人/出让人代码
			/// </summary>
			public readonly static Field TENDER_CODE = new Field("TENDER_CODE", "MAK_PER", "招标人/采购人/出让人代码");
            /// <summary>
			/// 招标人/采购人/出让人名称
			/// </summary>
			public readonly static Field TENDER_NAME = new Field("TENDER_NAME", "MAK_PER", "招标人/采购人/出让人名称");
            /// <summary>
			/// 中标/成交金额
			/// </summary>
			public readonly static Field WIN_BID_MONEY = new Field("WIN_BID_MONEY", "MAK_PER", "中标/成交金额");
            /// <summary>
			/// 合同金额
			/// </summary>
			public readonly static Field CONTRACT = new Field("CONTRACT", "MAK_PER", "合同金额");
            /// <summary>
			/// 合同结算金额
			/// </summary>
			public readonly static Field CONTRACT_SET = new Field("CONTRACT_SET", "MAK_PER", "合同结算金额");
            /// <summary>
			/// 合同期限
			/// </summary>
			public readonly static Field CONTRACT_PER = new Field("CONTRACT_PER", "MAK_PER", "合同期限");
            /// <summary>
			/// 实际履行期限
			/// </summary>
			public readonly static Field ACTUAL = new Field("ACTUAL", "MAK_PER", "实际履行期限");
            /// <summary>
			/// 金额币种代码
			/// </summary>
			public readonly static Field AMOUNT_CODE = new Field("AMOUNT_CODE", "MAK_PER", "金额币种代码");
            /// <summary>
			/// 金额单位
			/// </summary>
			public readonly static Field CURRENCY_UNIT = new Field("CURRENCY_UNIT", "MAK_PER", "金额单位");
            /// <summary>
			/// 合同签署时间
			/// </summary>
			public readonly static Field CONTRACT_TIME = new Field("CONTRACT_TIME", "MAK_PER", "合同签署时间");
        }
        #endregion
	}
}