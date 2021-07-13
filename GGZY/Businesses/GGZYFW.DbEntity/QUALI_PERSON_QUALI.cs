using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类QUALI_PERSON_QUALI。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("QUALI_PERSON_QUALI")]
    [Serializable]
    public partial class QUALI_PERSON_QUALI : FwEntity
    {
        #region Model
		private string _QUAL_NAME;
		private string _QUAL_TYPE;
		private string _ID_CARD;
		private string _ID_CARD_TYPE;
		private string _CERT_NO;
		private DateTime? _CERT_END_DATE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_ATT_QUALI_PERSON_QUALI;
		private decimal? _M_F_ID;
		private decimal? _M_ID;
		private string _M_ATT_PROFESSIONAL_CART_DOC;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _M_VERSION;

		/// <summary>
		/// 执业资格名称
		/// </summary>
		public string QUAL_NAME
		{
			get{ return _QUAL_NAME; }
			set
			{
				this.OnPropertyValueChange(_.QUAL_NAME, _QUAL_NAME, value);
				this._QUAL_NAME = value;
			}
		}
		/// <summary>
		/// 执业资格类型
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
		/// 执业人员证件号
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
		/// 执业人员身份证件类型
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
		/// 执业资格证书编号
		/// </summary>
		public string CERT_NO
		{
			get{ return _CERT_NO; }
			set
			{
				this.OnPropertyValueChange(_.CERT_NO, _CERT_NO, value);
				this._CERT_NO = value;
			}
		}
		/// <summary>
		/// 执业资格注册有效期止
		/// </summary>
		public DateTime? CERT_END_DATE
		{
			get{ return _CERT_END_DATE; }
			set
			{
				this.OnPropertyValueChange(_.CERT_END_DATE, _CERT_END_DATE, value);
				this._CERT_END_DATE = value;
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
		/// 执业资格证书扫描件ID
		/// </summary>
		public string M_ATT_QUALI_PERSON_QUALI
		{
			get{ return _M_ATT_QUALI_PERSON_QUALI; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_QUALI_PERSON_QUALI, _M_ATT_QUALI_PERSON_QUALI, value);
				this._M_ATT_QUALI_PERSON_QUALI = value;
			}
		}
		/// <summary>
		/// 法人信息关联ID
		/// </summary>
		public decimal? M_F_ID
		{
			get{ return _M_F_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_F_ID, _M_F_ID, value);
				this._M_F_ID = value;
			}
		}
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
		/// 执业资格证书扫描件
		/// </summary>
		public string M_ATT_PROFESSIONAL_CART_DOC
		{
			get{ return _M_ATT_PROFESSIONAL_CART_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_PROFESSIONAL_CART_DOC, _M_ATT_PROFESSIONAL_CART_DOC, value);
				this._M_ATT_PROFESSIONAL_CART_DOC = value;
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
				_.QUAL_NAME,
				_.QUAL_TYPE,
				_.ID_CARD,
				_.ID_CARD_TYPE,
				_.CERT_NO,
				_.CERT_END_DATE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ATT_QUALI_PERSON_QUALI,
				_.M_F_ID,
				_.M_ID,
				_.M_ATT_PROFESSIONAL_CART_DOC,
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
				this._QUAL_NAME,
				this._QUAL_TYPE,
				this._ID_CARD,
				this._ID_CARD_TYPE,
				this._CERT_NO,
				this._CERT_END_DATE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ATT_QUALI_PERSON_QUALI,
				this._M_F_ID,
				this._M_ID,
				this._M_ATT_PROFESSIONAL_CART_DOC,
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
			public readonly static Field All = new Field("*", "QUALI_PERSON_QUALI");
            /// <summary>
			/// 执业资格名称
			/// </summary>
			public readonly static Field QUAL_NAME = new Field("QUAL_NAME", "QUALI_PERSON_QUALI", "执业资格名称");
            /// <summary>
			/// 执业资格类型
			/// </summary>
			public readonly static Field QUAL_TYPE = new Field("QUAL_TYPE", "QUALI_PERSON_QUALI", "执业资格类型");
            /// <summary>
			/// 执业人员证件号
			/// </summary>
			public readonly static Field ID_CARD = new Field("ID_CARD", "QUALI_PERSON_QUALI", "执业人员证件号");
            /// <summary>
			/// 执业人员身份证件类型
			/// </summary>
			public readonly static Field ID_CARD_TYPE = new Field("ID_CARD_TYPE", "QUALI_PERSON_QUALI", "执业人员身份证件类型");
            /// <summary>
			/// 执业资格证书编号
			/// </summary>
			public readonly static Field CERT_NO = new Field("CERT_NO", "QUALI_PERSON_QUALI", "执业资格证书编号");
            /// <summary>
			/// 执业资格注册有效期止
			/// </summary>
			public readonly static Field CERT_END_DATE = new Field("CERT_END_DATE", "QUALI_PERSON_QUALI", "执业资格注册有效期止");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "QUALI_PERSON_QUALI", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "QUALI_PERSON_QUALI", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "QUALI_PERSON_QUALI", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "QUALI_PERSON_QUALI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "QUALI_PERSON_QUALI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "QUALI_PERSON_QUALI", "");
            /// <summary>
			/// 执业资格证书扫描件ID
			/// </summary>
			public readonly static Field M_ATT_QUALI_PERSON_QUALI = new Field("M_ATT_QUALI_PERSON_QUALI", "QUALI_PERSON_QUALI", "执业资格证书扫描件ID");
            /// <summary>
			/// 法人信息关联ID
			/// </summary>
			public readonly static Field M_F_ID = new Field("M_F_ID", "QUALI_PERSON_QUALI", "法人信息关联ID");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "QUALI_PERSON_QUALI", "");
            /// <summary>
			/// 执业资格证书扫描件
			/// </summary>
			public readonly static Field M_ATT_PROFESSIONAL_CART_DOC = new Field("M_ATT_PROFESSIONAL_CART_DOC", "QUALI_PERSON_QUALI", "执业资格证书扫描件");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "QUALI_PERSON_QUALI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "QUALI_PERSON_QUALI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "QUALI_PERSON_QUALI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "QUALI_PERSON_QUALI", "");
        }
        #endregion
	}
}