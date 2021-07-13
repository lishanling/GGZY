using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类SYS_USER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SYS_USER")]
    [Serializable]
    public partial class SYS_USER : FwEntity
    {
        #region Model
		private decimal? _U_ID;
		private string _UNAME;
		private string _UPWD;
		private string _REALNAME;
		private string _ROLEIDS;
		private string _USTATUS;
		private decimal? _DEPARTID;
		private string _CELLPHONE;
		private string _TELPHONE;
		private string _U_ADDRESS;
		private string _IDCARD;
		private string _SEX;
		private string _UPOST;
		private string _DECSP;
		private decimal? _ORDERID;
		private decimal? _CREATEID;
		private DateTime? _CREATETIME;
		private decimal? _ISDELETE;
		private decimal? _SSBM;
		private string _E_MAIL;
		private string _SYSTEM_NO;
		private string _SESSION_KEY;
		private string _REFRESH_TOKEN;

		/// <summary>
		/// 
		/// </summary>
		public decimal? U_ID
		{
			get{ return _U_ID; }
			set
			{
				this.OnPropertyValueChange(_.U_ID, _U_ID, value);
				this._U_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UNAME
		{
			get{ return _UNAME; }
			set
			{
				this.OnPropertyValueChange(_.UNAME, _UNAME, value);
				this._UNAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UPWD
		{
			get{ return _UPWD; }
			set
			{
				this.OnPropertyValueChange(_.UPWD, _UPWD, value);
				this._UPWD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REALNAME
		{
			get{ return _REALNAME; }
			set
			{
				this.OnPropertyValueChange(_.REALNAME, _REALNAME, value);
				this._REALNAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ROLEIDS
		{
			get{ return _ROLEIDS; }
			set
			{
				this.OnPropertyValueChange(_.ROLEIDS, _ROLEIDS, value);
				this._ROLEIDS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USTATUS
		{
			get{ return _USTATUS; }
			set
			{
				this.OnPropertyValueChange(_.USTATUS, _USTATUS, value);
				this._USTATUS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DEPARTID
		{
			get{ return _DEPARTID; }
			set
			{
				this.OnPropertyValueChange(_.DEPARTID, _DEPARTID, value);
				this._DEPARTID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CELLPHONE
		{
			get{ return _CELLPHONE; }
			set
			{
				this.OnPropertyValueChange(_.CELLPHONE, _CELLPHONE, value);
				this._CELLPHONE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TELPHONE
		{
			get{ return _TELPHONE; }
			set
			{
				this.OnPropertyValueChange(_.TELPHONE, _TELPHONE, value);
				this._TELPHONE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string U_ADDRESS
		{
			get{ return _U_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.U_ADDRESS, _U_ADDRESS, value);
				this._U_ADDRESS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IDCARD
		{
			get{ return _IDCARD; }
			set
			{
				this.OnPropertyValueChange(_.IDCARD, _IDCARD, value);
				this._IDCARD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SEX
		{
			get{ return _SEX; }
			set
			{
				this.OnPropertyValueChange(_.SEX, _SEX, value);
				this._SEX = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UPOST
		{
			get{ return _UPOST; }
			set
			{
				this.OnPropertyValueChange(_.UPOST, _UPOST, value);
				this._UPOST = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DECSP
		{
			get{ return _DECSP; }
			set
			{
				this.OnPropertyValueChange(_.DECSP, _DECSP, value);
				this._DECSP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ORDERID
		{
			get{ return _ORDERID; }
			set
			{
				this.OnPropertyValueChange(_.ORDERID, _ORDERID, value);
				this._ORDERID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CREATEID
		{
			get{ return _CREATEID; }
			set
			{
				this.OnPropertyValueChange(_.CREATEID, _CREATEID, value);
				this._CREATEID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATETIME
		{
			get{ return _CREATETIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATETIME, _CREATETIME, value);
				this._CREATETIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISDELETE
		{
			get{ return _ISDELETE; }
			set
			{
				this.OnPropertyValueChange(_.ISDELETE, _ISDELETE, value);
				this._ISDELETE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SSBM
		{
			get{ return _SSBM; }
			set
			{
				this.OnPropertyValueChange(_.SSBM, _SSBM, value);
				this._SSBM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string E_MAIL
		{
			get{ return _E_MAIL; }
			set
			{
				this.OnPropertyValueChange(_.E_MAIL, _E_MAIL, value);
				this._E_MAIL = value;
			}
		}
		/// <summary>
		/// 交易平台系统码
		/// </summary>
		public string SYSTEM_NO
		{
			get{ return _SYSTEM_NO; }
			set
			{
				this.OnPropertyValueChange(_.SYSTEM_NO, _SYSTEM_NO, value);
				this._SYSTEM_NO = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SESSION_KEY
		{
			get{ return _SESSION_KEY; }
			set
			{
				this.OnPropertyValueChange(_.SESSION_KEY, _SESSION_KEY, value);
				this._SESSION_KEY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REFRESH_TOKEN
		{
			get{ return _REFRESH_TOKEN; }
			set
			{
				this.OnPropertyValueChange(_.REFRESH_TOKEN, _REFRESH_TOKEN, value);
				this._REFRESH_TOKEN = value;
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
				_.U_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.U_ID,
				_.UNAME,
				_.UPWD,
				_.REALNAME,
				_.ROLEIDS,
				_.USTATUS,
				_.DEPARTID,
				_.CELLPHONE,
				_.TELPHONE,
				_.U_ADDRESS,
				_.IDCARD,
				_.SEX,
				_.UPOST,
				_.DECSP,
				_.ORDERID,
				_.CREATEID,
				_.CREATETIME,
				_.ISDELETE,
				_.SSBM,
				_.E_MAIL,
				_.SYSTEM_NO,
				_.SESSION_KEY,
				_.REFRESH_TOKEN,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._U_ID,
				this._UNAME,
				this._UPWD,
				this._REALNAME,
				this._ROLEIDS,
				this._USTATUS,
				this._DEPARTID,
				this._CELLPHONE,
				this._TELPHONE,
				this._U_ADDRESS,
				this._IDCARD,
				this._SEX,
				this._UPOST,
				this._DECSP,
				this._ORDERID,
				this._CREATEID,
				this._CREATETIME,
				this._ISDELETE,
				this._SSBM,
				this._E_MAIL,
				this._SYSTEM_NO,
				this._SESSION_KEY,
				this._REFRESH_TOKEN,
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
			public readonly static Field All = new Field("*", "SYS_USER");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UNAME = new Field("UNAME", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UPWD = new Field("UPWD", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REALNAME = new Field("REALNAME", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ROLEIDS = new Field("ROLEIDS", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field USTATUS = new Field("USTATUS", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DEPARTID = new Field("DEPARTID", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CELLPHONE = new Field("CELLPHONE", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TELPHONE = new Field("TELPHONE", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field U_ADDRESS = new Field("U_ADDRESS", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IDCARD = new Field("IDCARD", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SEX = new Field("SEX", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UPOST = new Field("UPOST", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DECSP = new Field("DECSP", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDERID = new Field("ORDERID", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATEID = new Field("CREATEID", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISDELETE = new Field("ISDELETE", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SSBM = new Field("SSBM", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field E_MAIL = new Field("E_MAIL", "SYS_USER", "");
            /// <summary>
			/// 交易平台系统码
			/// </summary>
			public readonly static Field SYSTEM_NO = new Field("SYSTEM_NO", "SYS_USER", "交易平台系统码");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SESSION_KEY = new Field("SESSION_KEY", "SYS_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REFRESH_TOKEN = new Field("REFRESH_TOKEN", "SYS_USER", "");
        }
        #endregion
	}
}