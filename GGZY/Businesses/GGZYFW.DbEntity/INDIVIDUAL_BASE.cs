using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类INDIVIDUAL_BASE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("INDIVIDUAL_BASE")]
    [Serializable]
    public partial class INDIVIDUAL_BASE : FwEntity
    {
        #region Model
		private string _ID_CARD_TYPE;
		private string _ID_CARD;
		private DateTime? _ID_CARD_END_DATE;
		private string _PERSON_NAME;
		private string _CONTACT;
		private string _BANK_ACCOUNT;
		private string _BANK_NAME;
		private string _ZIP_CODE;
		private string _ADDRESS;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private decimal? _M_USER_ID;
		private string _M_ATT_ID_CARD_DOC;
		private string _M_ATT_ACCOUNT_DOC;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _M_VERSION;

		/// <summary>
		/// 身份证件类型
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
		/// 主体代码（身份证件号）
		/// </summary>
		public string ID_CARD
		{
			get{ return _ID_CARD; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD, _ID_CARD, value);
				this._ID_CARD = value;
			}
		}
		/// <summary>
		/// 身份证件失效日期
		/// </summary>
		public DateTime? ID_CARD_END_DATE
		{
			get{ return _ID_CARD_END_DATE; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD_END_DATE, _ID_CARD_END_DATE, value);
				this._ID_CARD_END_DATE = value;
			}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string PERSON_NAME
		{
			get{ return _PERSON_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PERSON_NAME, _PERSON_NAME, value);
				this._PERSON_NAME = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string CONTACT
		{
			get{ return _CONTACT; }
			set
			{
				this.OnPropertyValueChange(_.CONTACT, _CONTACT, value);
				this._CONTACT = value;
			}
		}
		/// <summary>
		/// 银行账户
		/// </summary>
		public string BANK_ACCOUNT
		{
			get{ return _BANK_ACCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.BANK_ACCOUNT, _BANK_ACCOUNT, value);
				this._BANK_ACCOUNT = value;
			}
		}
		/// <summary>
		/// 开户行
		/// </summary>
		public string BANK_NAME
		{
			get{ return _BANK_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BANK_NAME, _BANK_NAME, value);
				this._BANK_NAME = value;
			}
		}
		/// <summary>
		/// 邮编
		/// </summary>
		public string ZIP_CODE
		{
			get{ return _ZIP_CODE; }
			set
			{
				this.OnPropertyValueChange(_.ZIP_CODE, _ZIP_CODE, value);
				this._ZIP_CODE = value;
			}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string ADDRESS
		{
			get{ return _ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.ADDRESS, _ADDRESS, value);
				this._ADDRESS = value;
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
		/// 
		/// </summary>
		public string M_KEY
		{
			get{ return _M_KEY; }
			set
			{
				this.OnPropertyValueChange(_.M_KEY, _M_KEY, value);
				this._M_KEY = value;
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
		/// 主键ID 自增
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
		/// 用户关联ID
		/// </summary>
		public decimal? M_USER_ID
		{
			get{ return _M_USER_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_USER_ID, _M_USER_ID, value);
				this._M_USER_ID = value;
			}
		}
		/// <summary>
		/// 身份证扫描件（正反面）
		/// </summary>
		public string M_ATT_ID_CARD_DOC
		{
			get{ return _M_ATT_ID_CARD_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_ID_CARD_DOC, _M_ATT_ID_CARD_DOC, value);
				this._M_ATT_ID_CARD_DOC = value;
			}
		}
		/// <summary>
		/// 账号银行卡扫描件
		/// </summary>
		public string M_ATT_ACCOUNT_DOC
		{
			get{ return _M_ATT_ACCOUNT_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_ACCOUNT_DOC, _M_ATT_ACCOUNT_DOC, value);
				this._M_ATT_ACCOUNT_DOC = value;
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
				_.ID_CARD_TYPE,
				_.ID_CARD,
				_.ID_CARD_END_DATE,
				_.PERSON_NAME,
				_.CONTACT,
				_.BANK_ACCOUNT,
				_.BANK_NAME,
				_.ZIP_CODE,
				_.ADDRESS,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
				_.M_USER_ID,
				_.M_ATT_ID_CARD_DOC,
				_.M_ATT_ACCOUNT_DOC,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID_CARD_TYPE,
				this._ID_CARD,
				this._ID_CARD_END_DATE,
				this._PERSON_NAME,
				this._CONTACT,
				this._BANK_ACCOUNT,
				this._BANK_NAME,
				this._ZIP_CODE,
				this._ADDRESS,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
				this._M_USER_ID,
				this._M_ATT_ID_CARD_DOC,
				this._M_ATT_ACCOUNT_DOC,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
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
			public readonly static Field All = new Field("*", "INDIVIDUAL_BASE");
            /// <summary>
			/// 身份证件类型
			/// </summary>
			public readonly static Field ID_CARD_TYPE = new Field("ID_CARD_TYPE", "INDIVIDUAL_BASE", "身份证件类型");
            /// <summary>
			/// 主体代码（身份证件号）
			/// </summary>
			public readonly static Field ID_CARD = new Field("ID_CARD", "INDIVIDUAL_BASE", "主体代码（身份证件号）");
            /// <summary>
			/// 身份证件失效日期
			/// </summary>
			public readonly static Field ID_CARD_END_DATE = new Field("ID_CARD_END_DATE", "INDIVIDUAL_BASE", "身份证件失效日期");
            /// <summary>
			/// 姓名
			/// </summary>
			public readonly static Field PERSON_NAME = new Field("PERSON_NAME", "INDIVIDUAL_BASE", "姓名");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field CONTACT = new Field("CONTACT", "INDIVIDUAL_BASE", "联系电话");
            /// <summary>
			/// 银行账户
			/// </summary>
			public readonly static Field BANK_ACCOUNT = new Field("BANK_ACCOUNT", "INDIVIDUAL_BASE", "银行账户");
            /// <summary>
			/// 开户行
			/// </summary>
			public readonly static Field BANK_NAME = new Field("BANK_NAME", "INDIVIDUAL_BASE", "开户行");
            /// <summary>
			/// 邮编
			/// </summary>
			public readonly static Field ZIP_CODE = new Field("ZIP_CODE", "INDIVIDUAL_BASE", "邮编");
            /// <summary>
			/// 地址
			/// </summary>
			public readonly static Field ADDRESS = new Field("ADDRESS", "INDIVIDUAL_BASE", "地址");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "INDIVIDUAL_BASE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "INDIVIDUAL_BASE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "INDIVIDUAL_BASE", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "INDIVIDUAL_BASE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "INDIVIDUAL_BASE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "INDIVIDUAL_BASE", "");
            /// <summary>
			/// 主键ID 自增
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "INDIVIDUAL_BASE", "主键ID 自增");
            /// <summary>
			/// 用户关联ID
			/// </summary>
			public readonly static Field M_USER_ID = new Field("M_USER_ID", "INDIVIDUAL_BASE", "用户关联ID");
            /// <summary>
			/// 身份证扫描件（正反面）
			/// </summary>
			public readonly static Field M_ATT_ID_CARD_DOC = new Field("M_ATT_ID_CARD_DOC", "INDIVIDUAL_BASE", "身份证扫描件（正反面）");
            /// <summary>
			/// 账号银行卡扫描件
			/// </summary>
			public readonly static Field M_ATT_ACCOUNT_DOC = new Field("M_ATT_ACCOUNT_DOC", "INDIVIDUAL_BASE", "账号银行卡扫描件");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "INDIVIDUAL_BASE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "INDIVIDUAL_BASE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "INDIVIDUAL_BASE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "INDIVIDUAL_BASE", "");
        }
        #endregion
	}
}