using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_JIEKOU_USER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_JIEKOU_USER")]
    [Serializable]
    public partial class T_JIEKOU_USER : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _USERID;
		private string _SYSTEM_NO;
		private string _SYSTEM_NAME;
		private string _CONTACT_NAME;
		private string _CONTACT_TEL;
		private string _AREACODE;
		private string _SECRET_KEY;
		private DateTime? _LAST_LOGINTIME;
		private string _SYSTEM_SIGN;
		private string _SUPERVISE_DEPT_NAME;
		private string _SUPERVISE_DEPT_CODE;
		private string _APPROVE_DEPT_NAME;
		private string _APPROVE_DEPT_CODE;
		private string _PLATFORM_CODE;
		private string _BULID_DEP;
		private string _BULID_FZR;
		private string _BULID_PHONE;
		private string _YW_DEP;
		private string _YW_FZR;
		private string _YW_PHONE;
		private decimal? _DOCK;
		private string _DOCK_INFO;
		private decimal? _INTERFACE_STATUS;
		private string _REMARK;
		private decimal? _ORDER_BY;
		private decimal? _UPLOAD_COUNT;

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
		/// 
		/// </summary>
		public decimal? USERID
		{
			get{ return _USERID; }
			set
			{
				this.OnPropertyValueChange(_.USERID, _USERID, value);
				this._USERID = value;
			}
		}
		/// <summary>
		/// 
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
		public string SYSTEM_NAME
		{
			get{ return _SYSTEM_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SYSTEM_NAME, _SYSTEM_NAME, value);
				this._SYSTEM_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CONTACT_NAME
		{
			get{ return _CONTACT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CONTACT_NAME, _CONTACT_NAME, value);
				this._CONTACT_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CONTACT_TEL
		{
			get{ return _CONTACT_TEL; }
			set
			{
				this.OnPropertyValueChange(_.CONTACT_TEL, _CONTACT_TEL, value);
				this._CONTACT_TEL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AREACODE
		{
			get{ return _AREACODE; }
			set
			{
				this.OnPropertyValueChange(_.AREACODE, _AREACODE, value);
				this._AREACODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SECRET_KEY
		{
			get{ return _SECRET_KEY; }
			set
			{
				this.OnPropertyValueChange(_.SECRET_KEY, _SECRET_KEY, value);
				this._SECRET_KEY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LAST_LOGINTIME
		{
			get{ return _LAST_LOGINTIME; }
			set
			{
				this.OnPropertyValueChange(_.LAST_LOGINTIME, _LAST_LOGINTIME, value);
				this._LAST_LOGINTIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SYSTEM_SIGN
		{
			get{ return _SYSTEM_SIGN; }
			set
			{
				this.OnPropertyValueChange(_.SYSTEM_SIGN, _SYSTEM_SIGN, value);
				this._SYSTEM_SIGN = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUPERVISE_DEPT_NAME
		{
			get{ return _SUPERVISE_DEPT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_NAME, _SUPERVISE_DEPT_NAME, value);
				this._SUPERVISE_DEPT_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUPERVISE_DEPT_CODE
		{
			get{ return _SUPERVISE_DEPT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_CODE, _SUPERVISE_DEPT_CODE, value);
				this._SUPERVISE_DEPT_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPROVE_DEPT_NAME
		{
			get{ return _APPROVE_DEPT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.APPROVE_DEPT_NAME, _APPROVE_DEPT_NAME, value);
				this._APPROVE_DEPT_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPROVE_DEPT_CODE
		{
			get{ return _APPROVE_DEPT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.APPROVE_DEPT_CODE, _APPROVE_DEPT_CODE, value);
				this._APPROVE_DEPT_CODE = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public string BULID_DEP
		{
			get{ return _BULID_DEP; }
			set
			{
				this.OnPropertyValueChange(_.BULID_DEP, _BULID_DEP, value);
				this._BULID_DEP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BULID_FZR
		{
			get{ return _BULID_FZR; }
			set
			{
				this.OnPropertyValueChange(_.BULID_FZR, _BULID_FZR, value);
				this._BULID_FZR = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BULID_PHONE
		{
			get{ return _BULID_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.BULID_PHONE, _BULID_PHONE, value);
				this._BULID_PHONE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YW_DEP
		{
			get{ return _YW_DEP; }
			set
			{
				this.OnPropertyValueChange(_.YW_DEP, _YW_DEP, value);
				this._YW_DEP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YW_FZR
		{
			get{ return _YW_FZR; }
			set
			{
				this.OnPropertyValueChange(_.YW_FZR, _YW_FZR, value);
				this._YW_FZR = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YW_PHONE
		{
			get{ return _YW_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.YW_PHONE, _YW_PHONE, value);
				this._YW_PHONE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DOCK
		{
			get{ return _DOCK; }
			set
			{
				this.OnPropertyValueChange(_.DOCK, _DOCK, value);
				this._DOCK = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DOCK_INFO
		{
			get{ return _DOCK_INFO; }
			set
			{
				this.OnPropertyValueChange(_.DOCK_INFO, _DOCK_INFO, value);
				this._DOCK_INFO = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? INTERFACE_STATUS
		{
			get{ return _INTERFACE_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.INTERFACE_STATUS, _INTERFACE_STATUS, value);
				this._INTERFACE_STATUS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REMARK
		{
			get{ return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
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
		/// 
		/// </summary>
		public decimal? UPLOAD_COUNT
		{
			get{ return _UPLOAD_COUNT; }
			set
			{
				this.OnPropertyValueChange(_.UPLOAD_COUNT, _UPLOAD_COUNT, value);
				this._UPLOAD_COUNT = value;
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
				_.SYSTEM_NO,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.USERID,
				_.SYSTEM_NO,
				_.SYSTEM_NAME,
				_.CONTACT_NAME,
				_.CONTACT_TEL,
				_.AREACODE,
				_.SECRET_KEY,
				_.LAST_LOGINTIME,
				_.SYSTEM_SIGN,
				_.SUPERVISE_DEPT_NAME,
				_.SUPERVISE_DEPT_CODE,
				_.APPROVE_DEPT_NAME,
				_.APPROVE_DEPT_CODE,
				_.PLATFORM_CODE,
				_.BULID_DEP,
				_.BULID_FZR,
				_.BULID_PHONE,
				_.YW_DEP,
				_.YW_FZR,
				_.YW_PHONE,
				_.DOCK,
				_.DOCK_INFO,
				_.INTERFACE_STATUS,
				_.REMARK,
				_.ORDER_BY,
				_.UPLOAD_COUNT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._USERID,
				this._SYSTEM_NO,
				this._SYSTEM_NAME,
				this._CONTACT_NAME,
				this._CONTACT_TEL,
				this._AREACODE,
				this._SECRET_KEY,
				this._LAST_LOGINTIME,
				this._SYSTEM_SIGN,
				this._SUPERVISE_DEPT_NAME,
				this._SUPERVISE_DEPT_CODE,
				this._APPROVE_DEPT_NAME,
				this._APPROVE_DEPT_CODE,
				this._PLATFORM_CODE,
				this._BULID_DEP,
				this._BULID_FZR,
				this._BULID_PHONE,
				this._YW_DEP,
				this._YW_FZR,
				this._YW_PHONE,
				this._DOCK,
				this._DOCK_INFO,
				this._INTERFACE_STATUS,
				this._REMARK,
				this._ORDER_BY,
				this._UPLOAD_COUNT,
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
			public readonly static Field All = new Field("*", "T_JIEKOU_USER");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field USERID = new Field("USERID", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SYSTEM_NO = new Field("SYSTEM_NO", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SYSTEM_NAME = new Field("SYSTEM_NAME", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTACT_NAME = new Field("CONTACT_NAME", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTACT_TEL = new Field("CONTACT_TEL", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SECRET_KEY = new Field("SECRET_KEY", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LAST_LOGINTIME = new Field("LAST_LOGINTIME", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SYSTEM_SIGN = new Field("SYSTEM_SIGN", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME = new Field("SUPERVISE_DEPT_NAME", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_CODE = new Field("SUPERVISE_DEPT_CODE", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field APPROVE_DEPT_NAME = new Field("APPROVE_DEPT_NAME", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field APPROVE_DEPT_CODE = new Field("APPROVE_DEPT_CODE", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BULID_DEP = new Field("BULID_DEP", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BULID_FZR = new Field("BULID_FZR", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BULID_PHONE = new Field("BULID_PHONE", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field YW_DEP = new Field("YW_DEP", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field YW_FZR = new Field("YW_FZR", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field YW_PHONE = new Field("YW_PHONE", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DOCK = new Field("DOCK", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DOCK_INFO = new Field("DOCK_INFO", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field INTERFACE_STATUS = new Field("INTERFACE_STATUS", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDER_BY = new Field("ORDER_BY", "T_JIEKOU_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UPLOAD_COUNT = new Field("UPLOAD_COUNT", "T_JIEKOU_USER", "");
        }
        #endregion
	}
}