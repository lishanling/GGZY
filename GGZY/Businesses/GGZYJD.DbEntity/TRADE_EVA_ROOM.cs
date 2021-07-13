using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类TRADE_EVA_ROOM。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TRADE_EVA_ROOM")]
    [Serializable]
    public partial class TRADE_EVA_ROOM : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _NAME;
		private string _CODE;
		private string _ADDRESS;
		private string _DEV_INFO;
		private decimal? _CREATE_BY;
		private DateTime? _CREATE_TM;
		private decimal? _ORDER_BY;
		private string _FILES;
		private decimal? _VIDEO_ENABLE;
		private string _LOGINACCOUNT;
		private string _SERVERIP;
		private string _SERVERPORT;
		private string _VPASSWORD;

		/// <summary>
		/// 
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
		/// 交易场所名称
		/// </summary>
		public string NAME
		{
			get{ return _NAME; }
			set
			{
				this.OnPropertyValueChange(_.NAME, _NAME, value);
				this._NAME = value;
			}
		}
		/// <summary>
		/// 交易场所代码
		/// </summary>
		public string CODE
		{
			get{ return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
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
		/// 设备信息
		/// </summary>
		public string DEV_INFO
		{
			get{ return _DEV_INFO; }
			set
			{
				this.OnPropertyValueChange(_.DEV_INFO, _DEV_INFO, value);
				this._DEV_INFO = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public decimal? CREATE_BY
		{
			get{ return _CREATE_BY; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_BY, _CREATE_BY, value);
				this._CREATE_BY = value;
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
		/// 排序
		/// </summary>
		public decimal? ORDER_BY
		{
			get{ return _ORDER_BY; }
			set
			{
				this.OnPropertyValueChange(_.ORDER_BY, _ORDER_BY, value);
				this._ORDER_BY = value;
			}
		}
		/// <summary>
		/// 附件
		/// </summary>
		public string FILES
		{
			get{ return _FILES; }
			set
			{
				this.OnPropertyValueChange(_.FILES, _FILES, value);
				this._FILES = value;
			}
		}
		/// <summary>
		/// 是否启用
		/// </summary>
		public decimal? VIDEO_ENABLE
		{
			get{ return _VIDEO_ENABLE; }
			set
			{
				this.OnPropertyValueChange(_.VIDEO_ENABLE, _VIDEO_ENABLE, value);
				this._VIDEO_ENABLE = value;
			}
		}
		/// <summary>
		/// 签名人
		/// </summary>
		public string LOGINACCOUNT
		{
			get{ return _LOGINACCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.LOGINACCOUNT, _LOGINACCOUNT, value);
				this._LOGINACCOUNT = value;
			}
		}
		/// <summary>
		/// IP地址
		/// </summary>
		public string SERVERIP
		{
			get{ return _SERVERIP; }
			set
			{
				this.OnPropertyValueChange(_.SERVERIP, _SERVERIP, value);
				this._SERVERIP = value;
			}
		}
		/// <summary>
		/// 端口
		/// </summary>
		public string SERVERPORT
		{
			get{ return _SERVERPORT; }
			set
			{
				this.OnPropertyValueChange(_.SERVERPORT, _SERVERPORT, value);
				this._SERVERPORT = value;
			}
		}
		/// <summary>
		/// 密码
		/// </summary>
		public string VPASSWORD
		{
			get{ return _VPASSWORD; }
			set
			{
				this.OnPropertyValueChange(_.VPASSWORD, _VPASSWORD, value);
				this._VPASSWORD = value;
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
				_.NAME,
				_.CODE,
				_.ADDRESS,
				_.DEV_INFO,
				_.CREATE_BY,
				_.CREATE_TM,
				_.ORDER_BY,
				_.FILES,
				_.VIDEO_ENABLE,
				_.LOGINACCOUNT,
				_.SERVERIP,
				_.SERVERPORT,
				_.VPASSWORD,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._NAME,
				this._CODE,
				this._ADDRESS,
				this._DEV_INFO,
				this._CREATE_BY,
				this._CREATE_TM,
				this._ORDER_BY,
				this._FILES,
				this._VIDEO_ENABLE,
				this._LOGINACCOUNT,
				this._SERVERIP,
				this._SERVERPORT,
				this._VPASSWORD,
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
			public readonly static Field All = new Field("*", "TRADE_EVA_ROOM");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "TRADE_EVA_ROOM", "");
            /// <summary>
			/// 交易场所名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "TRADE_EVA_ROOM", "交易场所名称");
            /// <summary>
			/// 交易场所代码
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "TRADE_EVA_ROOM", "交易场所代码");
            /// <summary>
			/// 地址
			/// </summary>
			public readonly static Field ADDRESS = new Field("ADDRESS", "TRADE_EVA_ROOM", "地址");
            /// <summary>
			/// 设备信息
			/// </summary>
			public readonly static Field DEV_INFO = new Field("DEV_INFO", "TRADE_EVA_ROOM", "设备信息");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "TRADE_EVA_ROOM", "创建人");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "TRADE_EVA_ROOM", "创建时间");
            /// <summary>
			/// 排序
			/// </summary>
			public readonly static Field ORDER_BY = new Field("ORDER_BY", "TRADE_EVA_ROOM", "排序");
            /// <summary>
			/// 附件
			/// </summary>
			public readonly static Field FILES = new Field("FILES", "TRADE_EVA_ROOM", "附件");
            /// <summary>
			/// 是否启用
			/// </summary>
			public readonly static Field VIDEO_ENABLE = new Field("VIDEO_ENABLE", "TRADE_EVA_ROOM", "是否启用");
            /// <summary>
			/// 签名人
			/// </summary>
			public readonly static Field LOGINACCOUNT = new Field("LOGINACCOUNT", "TRADE_EVA_ROOM", "签名人");
            /// <summary>
			/// IP地址
			/// </summary>
			public readonly static Field SERVERIP = new Field("SERVERIP", "TRADE_EVA_ROOM", "IP地址");
            /// <summary>
			/// 端口
			/// </summary>
			public readonly static Field SERVERPORT = new Field("SERVERPORT", "TRADE_EVA_ROOM", "端口");
            /// <summary>
			/// 密码
			/// </summary>
			public readonly static Field VPASSWORD = new Field("VPASSWORD", "TRADE_EVA_ROOM", "密码");
        }
        #endregion
	}
}