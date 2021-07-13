using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TENDER_AGENT_EX_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TENDER_AGENT_EX_INFO")]
    [Serializable]
    public partial class TENDER_AGENT_EX_INFO : FwEntity
    {
        #region Model
		private string _LEGAL_CODE;
		private string _QUAL_LEVEL;
		private string _QUAL_NAME;
		private string _QUAL_TYPE;
		private string _QUAL_CERT_NO;
		private DateTime? _QUAL_CERT_END_DATE;
		private string _CUSTOM_DEFINITION_DATAITEM;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_F_ID;
		private string _M_ATT_QUAL_CART_DOC;
		private decimal? _M_ID;
		private decimal? _M_USER_ID;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _M_VERSION;

		/// <summary>
		/// 主体代码
		/// </summary>
		public string LEGAL_CODE
		{
			get{ return _LEGAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_CODE, _LEGAL_CODE, value);
				this._LEGAL_CODE = value;
			}
		}
		/// <summary>
		/// 资质等级
		/// </summary>
		public string QUAL_LEVEL
		{
			get{ return _QUAL_LEVEL; }
			set
			{
				this.OnPropertyValueChange(_.QUAL_LEVEL, _QUAL_LEVEL, value);
				this._QUAL_LEVEL = value;
			}
		}
		/// <summary>
		/// 资质名称
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
		/// 资质序列、行业和专业类别
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
		/// 资质证书编号
		/// </summary>
		public string QUAL_CERT_NO
		{
			get{ return _QUAL_CERT_NO; }
			set
			{
				this.OnPropertyValueChange(_.QUAL_CERT_NO, _QUAL_CERT_NO, value);
				this._QUAL_CERT_NO = value;
			}
		}
		/// <summary>
		/// 资质证书失效日期
		/// </summary>
		public DateTime? QUAL_CERT_END_DATE
		{
			get{ return _QUAL_CERT_END_DATE; }
			set
			{
				this.OnPropertyValueChange(_.QUAL_CERT_END_DATE, _QUAL_CERT_END_DATE, value);
				this._QUAL_CERT_END_DATE = value;
			}
		}
		/// <summary>
		/// 自定义数据项
		/// </summary>
		public string CUSTOM_DEFINITION_DATAITEM
		{
			get{ return _CUSTOM_DEFINITION_DATAITEM; }
			set
			{
				this.OnPropertyValueChange(_.CUSTOM_DEFINITION_DATAITEM, _CUSTOM_DEFINITION_DATAITEM, value);
				this._CUSTOM_DEFINITION_DATAITEM = value;
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
		/// 资质照片ID 逗号隔开
		/// </summary>
		public string M_ATT_QUAL_CART_DOC
		{
			get{ return _M_ATT_QUAL_CART_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_QUAL_CART_DOC, _M_ATT_QUAL_CART_DOC, value);
				this._M_ATT_QUAL_CART_DOC = value;
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
				_.LEGAL_CODE,
				_.QUAL_LEVEL,
				_.QUAL_NAME,
				_.QUAL_TYPE,
				_.QUAL_CERT_NO,
				_.QUAL_CERT_END_DATE,
				_.CUSTOM_DEFINITION_DATAITEM,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_F_ID,
				_.M_ATT_QUAL_CART_DOC,
				_.M_ID,
				_.M_USER_ID,
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
				this._LEGAL_CODE,
				this._QUAL_LEVEL,
				this._QUAL_NAME,
				this._QUAL_TYPE,
				this._QUAL_CERT_NO,
				this._QUAL_CERT_END_DATE,
				this._CUSTOM_DEFINITION_DATAITEM,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_F_ID,
				this._M_ATT_QUAL_CART_DOC,
				this._M_ID,
				this._M_USER_ID,
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
			public readonly static Field All = new Field("*", "TENDER_AGENT_EX_INFO");
            /// <summary>
			/// 主体代码
			/// </summary>
			public readonly static Field LEGAL_CODE = new Field("LEGAL_CODE", "TENDER_AGENT_EX_INFO", "主体代码");
            /// <summary>
			/// 资质等级
			/// </summary>
			public readonly static Field QUAL_LEVEL = new Field("QUAL_LEVEL", "TENDER_AGENT_EX_INFO", "资质等级");
            /// <summary>
			/// 资质名称
			/// </summary>
			public readonly static Field QUAL_NAME = new Field("QUAL_NAME", "TENDER_AGENT_EX_INFO", "资质名称");
            /// <summary>
			/// 资质序列、行业和专业类别
			/// </summary>
			public readonly static Field QUAL_TYPE = new Field("QUAL_TYPE", "TENDER_AGENT_EX_INFO", "资质序列、行业和专业类别");
            /// <summary>
			/// 资质证书编号
			/// </summary>
			public readonly static Field QUAL_CERT_NO = new Field("QUAL_CERT_NO", "TENDER_AGENT_EX_INFO", "资质证书编号");
            /// <summary>
			/// 资质证书失效日期
			/// </summary>
			public readonly static Field QUAL_CERT_END_DATE = new Field("QUAL_CERT_END_DATE", "TENDER_AGENT_EX_INFO", "资质证书失效日期");
            /// <summary>
			/// 自定义数据项
			/// </summary>
			public readonly static Field CUSTOM_DEFINITION_DATAITEM = new Field("CUSTOM_DEFINITION_DATAITEM", "TENDER_AGENT_EX_INFO",DbType.AnsiString, null, "自定义数据项");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "TENDER_AGENT_EX_INFO", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "TENDER_AGENT_EX_INFO", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "TENDER_AGENT_EX_INFO", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "TENDER_AGENT_EX_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "TENDER_AGENT_EX_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "TENDER_AGENT_EX_INFO", "");
            /// <summary>
			/// 法人信息关联ID
			/// </summary>
			public readonly static Field M_F_ID = new Field("M_F_ID", "TENDER_AGENT_EX_INFO", "法人信息关联ID");
            /// <summary>
			/// 资质照片ID 逗号隔开
			/// </summary>
			public readonly static Field M_ATT_QUAL_CART_DOC = new Field("M_ATT_QUAL_CART_DOC", "TENDER_AGENT_EX_INFO", "资质照片ID 逗号隔开");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "TENDER_AGENT_EX_INFO", "");
            /// <summary>
			/// 用户关联ID
			/// </summary>
			public readonly static Field M_USER_ID = new Field("M_USER_ID", "TENDER_AGENT_EX_INFO", "用户关联ID");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "TENDER_AGENT_EX_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "TENDER_AGENT_EX_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "TENDER_AGENT_EX_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "TENDER_AGENT_EX_INFO", "");
        }
        #endregion
	}
}