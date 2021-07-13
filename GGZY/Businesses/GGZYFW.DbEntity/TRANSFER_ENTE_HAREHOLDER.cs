using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TRANSFER_ENTE_HAREHOLDER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TRANSFER_ENTE_HAREHOLDER")]
    [Serializable]
    public partial class TRANSFER_ENTE_HAREHOLDER : FwEntity
    {
        #region Model
		private string _SUBJECT_COMPANY_NAME;
		private string _SUBJECT_COMPANY_CODE;
		private string _TOP10_HOLDER_NAME;
		private decimal? _TOP10_HOLDER_NUMBER;
		private decimal? _TOP10_HOLDER_PERCENT;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _PROJECT_CODE;
		private decimal? _M_ID;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private decimal? _M_PRE_ID;
		private string _BID_CODE;
		private string _M_VERSION;

		/// <summary>
		/// 标的企业名称
		/// </summary>
		public string SUBJECT_COMPANY_NAME
		{
			get{ return _SUBJECT_COMPANY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SUBJECT_COMPANY_NAME, _SUBJECT_COMPANY_NAME, value);
				this._SUBJECT_COMPANY_NAME = value;
			}
		}
		/// <summary>
		/// 标的企业社会信用代码/组织机构代码
		/// </summary>
		public string SUBJECT_COMPANY_CODE
		{
			get{ return _SUBJECT_COMPANY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SUBJECT_COMPANY_CODE, _SUBJECT_COMPANY_CODE, value);
				this._SUBJECT_COMPANY_CODE = value;
			}
		}
		/// <summary>
		/// 股东名称
		/// </summary>
		public string TOP10_HOLDER_NAME
		{
			get{ return _TOP10_HOLDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TOP10_HOLDER_NAME, _TOP10_HOLDER_NAME, value);
				this._TOP10_HOLDER_NAME = value;
			}
		}
		/// <summary>
		/// 持股数量
		/// </summary>
		public decimal? TOP10_HOLDER_NUMBER
		{
			get{ return _TOP10_HOLDER_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.TOP10_HOLDER_NUMBER, _TOP10_HOLDER_NUMBER, value);
				this._TOP10_HOLDER_NUMBER = value;
			}
		}
		/// <summary>
		/// 股东持股比例
		/// </summary>
		public decimal? TOP10_HOLDER_PERCENT
		{
			get{ return _TOP10_HOLDER_PERCENT; }
			set
			{
				this.OnPropertyValueChange(_.TOP10_HOLDER_PERCENT, _TOP10_HOLDER_PERCENT, value);
				this._TOP10_HOLDER_PERCENT = value;
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
		/// 项目编号
		/// </summary>
		public string PROJECT_CODE
		{
			get{ return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
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
		/// 监督正式披露ID
		/// </summary>
		public decimal? M_PRE_ID
		{
			get{ return _M_PRE_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_PRE_ID, _M_PRE_ID, value);
				this._M_PRE_ID = value;
			}
		}
		/// <summary>
		/// 标的编号
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
				_.SUBJECT_COMPANY_NAME,
				_.SUBJECT_COMPANY_CODE,
				_.TOP10_HOLDER_NAME,
				_.TOP10_HOLDER_NUMBER,
				_.TOP10_HOLDER_PERCENT,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.PROJECT_CODE,
				_.M_ID,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_PRE_ID,
				_.BID_CODE,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._SUBJECT_COMPANY_NAME,
				this._SUBJECT_COMPANY_CODE,
				this._TOP10_HOLDER_NAME,
				this._TOP10_HOLDER_NUMBER,
				this._TOP10_HOLDER_PERCENT,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._PROJECT_CODE,
				this._M_ID,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_PRE_ID,
				this._BID_CODE,
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
			public readonly static Field All = new Field("*", "TRANSFER_ENTE_HAREHOLDER");
            /// <summary>
			/// 标的企业名称
			/// </summary>
			public readonly static Field SUBJECT_COMPANY_NAME = new Field("SUBJECT_COMPANY_NAME", "TRANSFER_ENTE_HAREHOLDER", "标的企业名称");
            /// <summary>
			/// 标的企业社会信用代码/组织机构代码
			/// </summary>
			public readonly static Field SUBJECT_COMPANY_CODE = new Field("SUBJECT_COMPANY_CODE", "TRANSFER_ENTE_HAREHOLDER", "标的企业社会信用代码/组织机构代码");
            /// <summary>
			/// 股东名称
			/// </summary>
			public readonly static Field TOP10_HOLDER_NAME = new Field("TOP10_HOLDER_NAME", "TRANSFER_ENTE_HAREHOLDER", "股东名称");
            /// <summary>
			/// 持股数量
			/// </summary>
			public readonly static Field TOP10_HOLDER_NUMBER = new Field("TOP10_HOLDER_NUMBER", "TRANSFER_ENTE_HAREHOLDER", "持股数量");
            /// <summary>
			/// 股东持股比例
			/// </summary>
			public readonly static Field TOP10_HOLDER_PERCENT = new Field("TOP10_HOLDER_PERCENT", "TRANSFER_ENTE_HAREHOLDER", "股东持股比例");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "TRANSFER_ENTE_HAREHOLDER", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "TRANSFER_ENTE_HAREHOLDER", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "TRANSFER_ENTE_HAREHOLDER", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "TRANSFER_ENTE_HAREHOLDER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "TRANSFER_ENTE_HAREHOLDER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "TRANSFER_ENTE_HAREHOLDER", "");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "TRANSFER_ENTE_HAREHOLDER", "项目编号");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "TRANSFER_ENTE_HAREHOLDER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "TRANSFER_ENTE_HAREHOLDER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "TRANSFER_ENTE_HAREHOLDER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "TRANSFER_ENTE_HAREHOLDER", "");
            /// <summary>
			/// 监督正式披露ID
			/// </summary>
			public readonly static Field M_PRE_ID = new Field("M_PRE_ID", "TRANSFER_ENTE_HAREHOLDER", "监督正式披露ID");
            /// <summary>
			/// 标的编号
			/// </summary>
			public readonly static Field BID_CODE = new Field("BID_CODE", "TRANSFER_ENTE_HAREHOLDER", "标的编号");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "TRANSFER_ENTE_HAREHOLDER", "");
        }
        #endregion
	}
}