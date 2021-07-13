using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类YD_EVA_ROOM。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("YD_EVA_ROOM")]
    [Serializable]
    public partial class YD_EVA_ROOM : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _NAME;
		private string _BELONG_BY;
		private decimal? _STATUS;
		private decimal? _SEAT_COUNT;
		private string _ADDRESS;
		private decimal? _IS_DEL;
		private string _DEV_INFO;
		private decimal? _CREATE_BY;
		private DateTime? _CREATE_TM;
		private decimal? _DEL_BY;
		private DateTime? _DEL_TM;
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
		/// 评标室名称
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
		/// 所属交易中心
		/// </summary>
		public string BELONG_BY
		{
			get{ return _BELONG_BY; }
			set
			{
				this.OnPropertyValueChange(_.BELONG_BY, _BELONG_BY, value);
				this._BELONG_BY = value;
			}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public decimal? STATUS
		{
			get{ return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 座位数
		/// </summary>
		public decimal? SEAT_COUNT
		{
			get{ return _SEAT_COUNT; }
			set
			{
				this.OnPropertyValueChange(_.SEAT_COUNT, _SEAT_COUNT, value);
				this._SEAT_COUNT = value;
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
		/// 是否删除
		/// </summary>
		public decimal? IS_DEL
		{
			get{ return _IS_DEL; }
			set
			{
				this.OnPropertyValueChange(_.IS_DEL, _IS_DEL, value);
				this._IS_DEL = value;
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
		/// 
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
		/// 
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
		/// 
		/// </summary>
		public decimal? DEL_BY
		{
			get{ return _DEL_BY; }
			set
			{
				this.OnPropertyValueChange(_.DEL_BY, _DEL_BY, value);
				this._DEL_BY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DEL_TM
		{
			get{ return _DEL_TM; }
			set
			{
				this.OnPropertyValueChange(_.DEL_TM, _DEL_TM, value);
				this._DEL_TM = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
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
		/// 
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
		/// 
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
		/// 
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
		/// 
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
				_.BELONG_BY,
				_.STATUS,
				_.SEAT_COUNT,
				_.ADDRESS,
				_.IS_DEL,
				_.DEV_INFO,
				_.CREATE_BY,
				_.CREATE_TM,
				_.DEL_BY,
				_.DEL_TM,
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
				this._BELONG_BY,
				this._STATUS,
				this._SEAT_COUNT,
				this._ADDRESS,
				this._IS_DEL,
				this._DEV_INFO,
				this._CREATE_BY,
				this._CREATE_TM,
				this._DEL_BY,
				this._DEL_TM,
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
			public readonly static Field All = new Field("*", "YD_EVA_ROOM");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "YD_EVA_ROOM", "");
            /// <summary>
			/// 评标室名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "YD_EVA_ROOM", "评标室名称");
            /// <summary>
			/// 所属交易中心
			/// </summary>
			public readonly static Field BELONG_BY = new Field("BELONG_BY", "YD_EVA_ROOM", "所属交易中心");
            /// <summary>
			/// 状态
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "YD_EVA_ROOM", "状态");
            /// <summary>
			/// 座位数
			/// </summary>
			public readonly static Field SEAT_COUNT = new Field("SEAT_COUNT", "YD_EVA_ROOM", "座位数");
            /// <summary>
			/// 地址
			/// </summary>
			public readonly static Field ADDRESS = new Field("ADDRESS", "YD_EVA_ROOM", "地址");
            /// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DEL = new Field("IS_DEL", "YD_EVA_ROOM", "是否删除");
            /// <summary>
			/// 设备信息
			/// </summary>
			public readonly static Field DEV_INFO = new Field("DEV_INFO", "YD_EVA_ROOM", "设备信息");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "YD_EVA_ROOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "YD_EVA_ROOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DEL_BY = new Field("DEL_BY", "YD_EVA_ROOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DEL_TM = new Field("DEL_TM", "YD_EVA_ROOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDER_BY = new Field("ORDER_BY", "YD_EVA_ROOM", "");
            /// <summary>
			/// 附件
			/// </summary>
			public readonly static Field FILES = new Field("FILES", "YD_EVA_ROOM", "附件");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field VIDEO_ENABLE = new Field("VIDEO_ENABLE", "YD_EVA_ROOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LOGINACCOUNT = new Field("LOGINACCOUNT", "YD_EVA_ROOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SERVERIP = new Field("SERVERIP", "YD_EVA_ROOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SERVERPORT = new Field("SERVERPORT", "YD_EVA_ROOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field VPASSWORD = new Field("VPASSWORD", "YD_EVA_ROOM", "");
        }
        #endregion
	}
}