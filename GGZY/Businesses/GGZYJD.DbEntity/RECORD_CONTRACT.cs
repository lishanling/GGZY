using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类RECORD_CONTRACT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("RECORD_CONTRACT")]
    [Serializable]
    public partial class RECORD_CONTRACT : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _RECORD_ID;
		private string _PARTY_A;
		private string _PARTY_A_CODE;
		private string _PARTY_B;
		private string _PARTY_B_CODE;
		private DateTime? _WIN_NOTICE_TIME;
		private DateTime? _CONTRACT_TIME;
		private decimal? _BID_AMOUNT;
		private string _BID_AMOUNT_CURRENCY;
		private string _BID_AMOUNT_UNIT;
		private decimal? _CONTRACT_AMOUNT;
		private string _CONTRACT_AMOUNT_CURRENCY;
		private string _CONTRACT_AMOUNT_UNIT;
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
		/// 甲方
		/// </summary>
		public string PARTY_A
		{
			get{ return _PARTY_A; }
			set
			{
				this.OnPropertyValueChange(_.PARTY_A, _PARTY_A, value);
				this._PARTY_A = value;
			}
		}
		/// <summary>
		/// 甲方代码
		/// </summary>
		public string PARTY_A_CODE
		{
			get{ return _PARTY_A_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PARTY_A_CODE, _PARTY_A_CODE, value);
				this._PARTY_A_CODE = value;
			}
		}
		/// <summary>
		/// 乙方
		/// </summary>
		public string PARTY_B
		{
			get{ return _PARTY_B; }
			set
			{
				this.OnPropertyValueChange(_.PARTY_B, _PARTY_B, value);
				this._PARTY_B = value;
			}
		}
		/// <summary>
		/// 乙方代码
		/// </summary>
		public string PARTY_B_CODE
		{
			get{ return _PARTY_B_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PARTY_B_CODE, _PARTY_B_CODE, value);
				this._PARTY_B_CODE = value;
			}
		}
		/// <summary>
		/// 中标通知书发出时间
		/// </summary>
		public DateTime? WIN_NOTICE_TIME
		{
			get{ return _WIN_NOTICE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.WIN_NOTICE_TIME, _WIN_NOTICE_TIME, value);
				this._WIN_NOTICE_TIME = value;
			}
		}
		/// <summary>
		/// 合同签订时间
		/// </summary>
		public DateTime? CONTRACT_TIME
		{
			get{ return _CONTRACT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_TIME, _CONTRACT_TIME, value);
				this._CONTRACT_TIME = value;
			}
		}
		/// <summary>
		/// 中标金额
		/// </summary>
		public decimal? BID_AMOUNT
		{
			get{ return _BID_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.BID_AMOUNT, _BID_AMOUNT, value);
				this._BID_AMOUNT = value;
			}
		}
		/// <summary>
		/// 中标金额币种
		/// </summary>
		public string BID_AMOUNT_CURRENCY
		{
			get{ return _BID_AMOUNT_CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.BID_AMOUNT_CURRENCY, _BID_AMOUNT_CURRENCY, value);
				this._BID_AMOUNT_CURRENCY = value;
			}
		}
		/// <summary>
		/// 中标金额单位
		/// </summary>
		public string BID_AMOUNT_UNIT
		{
			get{ return _BID_AMOUNT_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.BID_AMOUNT_UNIT, _BID_AMOUNT_UNIT, value);
				this._BID_AMOUNT_UNIT = value;
			}
		}
		/// <summary>
		/// 合同金额
		/// </summary>
		public decimal? CONTRACT_AMOUNT
		{
			get{ return _CONTRACT_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_AMOUNT, _CONTRACT_AMOUNT, value);
				this._CONTRACT_AMOUNT = value;
			}
		}
		/// <summary>
		/// 合同金额币种
		/// </summary>
		public string CONTRACT_AMOUNT_CURRENCY
		{
			get{ return _CONTRACT_AMOUNT_CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_AMOUNT_CURRENCY, _CONTRACT_AMOUNT_CURRENCY, value);
				this._CONTRACT_AMOUNT_CURRENCY = value;
			}
		}
		/// <summary>
		/// 合同金额单位
		/// </summary>
		public string CONTRACT_AMOUNT_UNIT
		{
			get{ return _CONTRACT_AMOUNT_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_AMOUNT_UNIT, _CONTRACT_AMOUNT_UNIT, value);
				this._CONTRACT_AMOUNT_UNIT = value;
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
				_.PARTY_A,
				_.PARTY_A_CODE,
				_.PARTY_B,
				_.PARTY_B_CODE,
				_.WIN_NOTICE_TIME,
				_.CONTRACT_TIME,
				_.BID_AMOUNT,
				_.BID_AMOUNT_CURRENCY,
				_.BID_AMOUNT_UNIT,
				_.CONTRACT_AMOUNT,
				_.CONTRACT_AMOUNT_CURRENCY,
				_.CONTRACT_AMOUNT_UNIT,
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
				this._PARTY_A,
				this._PARTY_A_CODE,
				this._PARTY_B,
				this._PARTY_B_CODE,
				this._WIN_NOTICE_TIME,
				this._CONTRACT_TIME,
				this._BID_AMOUNT,
				this._BID_AMOUNT_CURRENCY,
				this._BID_AMOUNT_UNIT,
				this._CONTRACT_AMOUNT,
				this._CONTRACT_AMOUNT_CURRENCY,
				this._CONTRACT_AMOUNT_UNIT,
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
			public readonly static Field All = new Field("*", "RECORD_CONTRACT");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "RECORD_CONTRACT", "ID");
            /// <summary>
			/// 备案主表ID
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "RECORD_CONTRACT", "备案主表ID");
            /// <summary>
			/// 甲方
			/// </summary>
			public readonly static Field PARTY_A = new Field("PARTY_A", "RECORD_CONTRACT", "甲方");
            /// <summary>
			/// 甲方代码
			/// </summary>
			public readonly static Field PARTY_A_CODE = new Field("PARTY_A_CODE", "RECORD_CONTRACT", "甲方代码");
            /// <summary>
			/// 乙方
			/// </summary>
			public readonly static Field PARTY_B = new Field("PARTY_B", "RECORD_CONTRACT", "乙方");
            /// <summary>
			/// 乙方代码
			/// </summary>
			public readonly static Field PARTY_B_CODE = new Field("PARTY_B_CODE", "RECORD_CONTRACT", "乙方代码");
            /// <summary>
			/// 中标通知书发出时间
			/// </summary>
			public readonly static Field WIN_NOTICE_TIME = new Field("WIN_NOTICE_TIME", "RECORD_CONTRACT", "中标通知书发出时间");
            /// <summary>
			/// 合同签订时间
			/// </summary>
			public readonly static Field CONTRACT_TIME = new Field("CONTRACT_TIME", "RECORD_CONTRACT", "合同签订时间");
            /// <summary>
			/// 中标金额
			/// </summary>
			public readonly static Field BID_AMOUNT = new Field("BID_AMOUNT", "RECORD_CONTRACT", "中标金额");
            /// <summary>
			/// 中标金额币种
			/// </summary>
			public readonly static Field BID_AMOUNT_CURRENCY = new Field("BID_AMOUNT_CURRENCY", "RECORD_CONTRACT", "中标金额币种");
            /// <summary>
			/// 中标金额单位
			/// </summary>
			public readonly static Field BID_AMOUNT_UNIT = new Field("BID_AMOUNT_UNIT", "RECORD_CONTRACT", "中标金额单位");
            /// <summary>
			/// 合同金额
			/// </summary>
			public readonly static Field CONTRACT_AMOUNT = new Field("CONTRACT_AMOUNT", "RECORD_CONTRACT", "合同金额");
            /// <summary>
			/// 合同金额币种
			/// </summary>
			public readonly static Field CONTRACT_AMOUNT_CURRENCY = new Field("CONTRACT_AMOUNT_CURRENCY", "RECORD_CONTRACT", "合同金额币种");
            /// <summary>
			/// 合同金额单位
			/// </summary>
			public readonly static Field CONTRACT_AMOUNT_UNIT = new Field("CONTRACT_AMOUNT_UNIT", "RECORD_CONTRACT", "合同金额单位");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "RECORD_CONTRACT", "创建时间");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "RECORD_CONTRACT", "创建人");
        }
        #endregion
	}
}