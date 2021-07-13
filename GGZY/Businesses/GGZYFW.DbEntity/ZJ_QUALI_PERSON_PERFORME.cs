using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJ_QUALI_PERSON_PERFORME。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_QUALI_PERSON_PERFORME")]
    [Serializable]
    public partial class ZJ_QUALI_PERSON_PERFORME : FwEntity
    {
        #region Model
		private string _ID_CARD_NO;
		private string _ID_CARD_TYPE;
		private string _SECTION_NO;
		private string _BID_SECTION_CODE;
		private string _SECTION_NAME;
		private string _BID_SECTION_NAME;
		private string _OWNER_NO;
		private string _OWNER_NAME;
		private decimal? _CONTRACT_AMOUNT;
		private string _TRADE_TYPE;
		private decimal? _SETTLE_AMOUNT;
		private string _CURRENCY;
		private string _MONEY_UNIT;
		private DateTime? _CONTRACT_SIGN_DATE;
		private DateTime? _CONTRACT_FINISH_DATE;
		private string _M_DATA_SOURCE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;

		/// <summary>
		/// 人员身份证件号
		/// </summary>
		public string ID_CARD_NO
		{
			get{ return _ID_CARD_NO; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD_NO, _ID_CARD_NO, value);
				this._ID_CARD_NO = value;
			}
		}
		/// <summary>
		/// 人员身份证件类型
		/// </summary>
		public string ID_CARD_TYPE
		{
			get{ return _ID_CARD_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD_TYPE, _ID_CARD_TYPE, value);
				this._ID_CARD_TYPE = value;
			}
		}
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string SECTION_NO
		{
			get{ return _SECTION_NO; }
			set
			{
				this.OnPropertyValueChange(_.SECTION_NO, _SECTION_NO, value);
				this._SECTION_NO = value;
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
		/// 招标项目名称
		/// </summary>
		public string SECTION_NAME
		{
			get{ return _SECTION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SECTION_NAME, _SECTION_NAME, value);
				this._SECTION_NAME = value;
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
		/// 招标人/采购人/出让人代码
		/// </summary>
		public string OWNER_NO
		{
			get{ return _OWNER_NO; }
			set
			{
				this.OnPropertyValueChange(_.OWNER_NO, _OWNER_NO, value);
				this._OWNER_NO = value;
			}
		}
		/// <summary>
		/// 招标人/采购人/出让人名称
		/// </summary>
		public string OWNER_NAME
		{
			get{ return _OWNER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.OWNER_NAME, _OWNER_NAME, value);
				this._OWNER_NAME = value;
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
		/// 交易分类
		/// </summary>
		public string TRADE_TYPE
		{
			get{ return _TRADE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TRADE_TYPE, _TRADE_TYPE, value);
				this._TRADE_TYPE = value;
			}
		}
		/// <summary>
		/// 结算金额
		/// </summary>
		public decimal? SETTLE_AMOUNT
		{
			get{ return _SETTLE_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.SETTLE_AMOUNT, _SETTLE_AMOUNT, value);
				this._SETTLE_AMOUNT = value;
			}
		}
		/// <summary>
		/// 金额币种代码
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
		/// 金额单位
		/// </summary>
		public string MONEY_UNIT
		{
			get{ return _MONEY_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.MONEY_UNIT, _MONEY_UNIT, value);
				this._MONEY_UNIT = value;
			}
		}
		/// <summary>
		/// 合同签署时间
		/// </summary>
		public DateTime? CONTRACT_SIGN_DATE
		{
			get{ return _CONTRACT_SIGN_DATE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_SIGN_DATE, _CONTRACT_SIGN_DATE, value);
				this._CONTRACT_SIGN_DATE = value;
			}
		}
		/// <summary>
		/// 合同完成时间
		/// </summary>
		public DateTime? CONTRACT_FINISH_DATE
		{
			get{ return _CONTRACT_FINISH_DATE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_FINISH_DATE, _CONTRACT_FINISH_DATE, value);
				this._CONTRACT_FINISH_DATE = value;
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
		/// M_ID
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID_CARD_NO,
				_.ID_CARD_TYPE,
				_.SECTION_NO,
				_.BID_SECTION_CODE,
				_.SECTION_NAME,
				_.BID_SECTION_NAME,
				_.OWNER_NO,
				_.OWNER_NAME,
				_.CONTRACT_AMOUNT,
				_.TRADE_TYPE,
				_.SETTLE_AMOUNT,
				_.CURRENCY,
				_.MONEY_UNIT,
				_.CONTRACT_SIGN_DATE,
				_.CONTRACT_FINISH_DATE,
				_.M_DATA_SOURCE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID_CARD_NO,
				this._ID_CARD_TYPE,
				this._SECTION_NO,
				this._BID_SECTION_CODE,
				this._SECTION_NAME,
				this._BID_SECTION_NAME,
				this._OWNER_NO,
				this._OWNER_NAME,
				this._CONTRACT_AMOUNT,
				this._TRADE_TYPE,
				this._SETTLE_AMOUNT,
				this._CURRENCY,
				this._MONEY_UNIT,
				this._CONTRACT_SIGN_DATE,
				this._CONTRACT_FINISH_DATE,
				this._M_DATA_SOURCE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ID,
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
			public readonly static Field All = new Field("*", "ZJ_QUALI_PERSON_PERFORME");
            /// <summary>
			/// 人员身份证件号
			/// </summary>
			public readonly static Field ID_CARD_NO = new Field("ID_CARD_NO", "ZJ_QUALI_PERSON_PERFORME", "人员身份证件号");
            /// <summary>
			/// 人员身份证件类型
			/// </summary>
			public readonly static Field ID_CARD_TYPE = new Field("ID_CARD_TYPE", "ZJ_QUALI_PERSON_PERFORME", "人员身份证件类型");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field SECTION_NO = new Field("SECTION_NO", "ZJ_QUALI_PERSON_PERFORME", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "ZJ_QUALI_PERSON_PERFORME", "标段（包）编号");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field SECTION_NAME = new Field("SECTION_NAME", "ZJ_QUALI_PERSON_PERFORME", "招标项目名称");
            /// <summary>
			/// 标段（包）名称
			/// </summary>
			public readonly static Field BID_SECTION_NAME = new Field("BID_SECTION_NAME", "ZJ_QUALI_PERSON_PERFORME", "标段（包）名称");
            /// <summary>
			/// 招标人/采购人/出让人代码
			/// </summary>
			public readonly static Field OWNER_NO = new Field("OWNER_NO", "ZJ_QUALI_PERSON_PERFORME", "招标人/采购人/出让人代码");
            /// <summary>
			/// 招标人/采购人/出让人名称
			/// </summary>
			public readonly static Field OWNER_NAME = new Field("OWNER_NAME", "ZJ_QUALI_PERSON_PERFORME", "招标人/采购人/出让人名称");
            /// <summary>
			/// 合同金额
			/// </summary>
			public readonly static Field CONTRACT_AMOUNT = new Field("CONTRACT_AMOUNT", "ZJ_QUALI_PERSON_PERFORME", "合同金额");
            /// <summary>
			/// 交易分类
			/// </summary>
			public readonly static Field TRADE_TYPE = new Field("TRADE_TYPE", "ZJ_QUALI_PERSON_PERFORME", "交易分类");
            /// <summary>
			/// 结算金额
			/// </summary>
			public readonly static Field SETTLE_AMOUNT = new Field("SETTLE_AMOUNT", "ZJ_QUALI_PERSON_PERFORME", "结算金额");
            /// <summary>
			/// 金额币种代码
			/// </summary>
			public readonly static Field CURRENCY = new Field("CURRENCY", "ZJ_QUALI_PERSON_PERFORME", "金额币种代码");
            /// <summary>
			/// 金额单位
			/// </summary>
			public readonly static Field MONEY_UNIT = new Field("MONEY_UNIT", "ZJ_QUALI_PERSON_PERFORME", "金额单位");
            /// <summary>
			/// 合同签署时间
			/// </summary>
			public readonly static Field CONTRACT_SIGN_DATE = new Field("CONTRACT_SIGN_DATE", "ZJ_QUALI_PERSON_PERFORME", "合同签署时间");
            /// <summary>
			/// 合同完成时间
			/// </summary>
			public readonly static Field CONTRACT_FINISH_DATE = new Field("CONTRACT_FINISH_DATE", "ZJ_QUALI_PERSON_PERFORME", "合同完成时间");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ZJ_QUALI_PERSON_PERFORME", "数据来源");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ZJ_QUALI_PERSON_PERFORME", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ZJ_QUALI_PERSON_PERFORME", "数据时间戳");
            /// <summary>
			/// M_ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_QUALI_PERSON_PERFORME", "M_ID");
        }
        #endregion
	}
}