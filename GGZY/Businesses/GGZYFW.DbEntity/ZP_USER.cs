using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZP_USER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZP_USER")]
    [Serializable]
    public partial class ZP_USER : FwEntity
    {
        #region Model
		private decimal? _ZP_ID;
		private string _ZP_USERNAME;
		private string _ZP_PASSWORD;
		private string _ZP_PERSONNAME;
		private string _ZP_PHONE;
		private string _ZP_POST;
		private string _ZP_FAX;
		private string _ZP_UNIT;
		private string _ZP_ADDRESS;
		private string _ZP_INDUSTRY;
		private string _ZP_USERTYPE;
		private string _ZP_USERSTATE;
		private string _ZP_EMAIL;
		private DateTime? _CRTIME;
		private string _ZP_SEX;
		private string _ZP_EDUCATION;
		private string _ZP_TITLE;
		private string _ZP_RETIREMENT;
		private string _ZP_SPECIALITY;
		private DateTime? _ZP_EDITTIME;
		private string _ZP_STATE;

		/// <summary>
		/// 
		/// </summary>
		public decimal? ZP_ID
		{
			get{ return _ZP_ID; }
			set
			{
				this.OnPropertyValueChange(_.ZP_ID, _ZP_ID, value);
				this._ZP_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_USERNAME
		{
			get{ return _ZP_USERNAME; }
			set
			{
				this.OnPropertyValueChange(_.ZP_USERNAME, _ZP_USERNAME, value);
				this._ZP_USERNAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_PASSWORD
		{
			get{ return _ZP_PASSWORD; }
			set
			{
				this.OnPropertyValueChange(_.ZP_PASSWORD, _ZP_PASSWORD, value);
				this._ZP_PASSWORD = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_PERSONNAME
		{
			get{ return _ZP_PERSONNAME; }
			set
			{
				this.OnPropertyValueChange(_.ZP_PERSONNAME, _ZP_PERSONNAME, value);
				this._ZP_PERSONNAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_PHONE
		{
			get{ return _ZP_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.ZP_PHONE, _ZP_PHONE, value);
				this._ZP_PHONE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_POST
		{
			get{ return _ZP_POST; }
			set
			{
				this.OnPropertyValueChange(_.ZP_POST, _ZP_POST, value);
				this._ZP_POST = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_FAX
		{
			get{ return _ZP_FAX; }
			set
			{
				this.OnPropertyValueChange(_.ZP_FAX, _ZP_FAX, value);
				this._ZP_FAX = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_UNIT
		{
			get{ return _ZP_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.ZP_UNIT, _ZP_UNIT, value);
				this._ZP_UNIT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_ADDRESS
		{
			get{ return _ZP_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.ZP_ADDRESS, _ZP_ADDRESS, value);
				this._ZP_ADDRESS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_INDUSTRY
		{
			get{ return _ZP_INDUSTRY; }
			set
			{
				this.OnPropertyValueChange(_.ZP_INDUSTRY, _ZP_INDUSTRY, value);
				this._ZP_INDUSTRY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_USERTYPE
		{
			get{ return _ZP_USERTYPE; }
			set
			{
				this.OnPropertyValueChange(_.ZP_USERTYPE, _ZP_USERTYPE, value);
				this._ZP_USERTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_USERSTATE
		{
			get{ return _ZP_USERSTATE; }
			set
			{
				this.OnPropertyValueChange(_.ZP_USERSTATE, _ZP_USERSTATE, value);
				this._ZP_USERSTATE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_EMAIL
		{
			get{ return _ZP_EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.ZP_EMAIL, _ZP_EMAIL, value);
				this._ZP_EMAIL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CRTIME
		{
			get{ return _CRTIME; }
			set
			{
				this.OnPropertyValueChange(_.CRTIME, _CRTIME, value);
				this._CRTIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_SEX
		{
			get{ return _ZP_SEX; }
			set
			{
				this.OnPropertyValueChange(_.ZP_SEX, _ZP_SEX, value);
				this._ZP_SEX = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_EDUCATION
		{
			get{ return _ZP_EDUCATION; }
			set
			{
				this.OnPropertyValueChange(_.ZP_EDUCATION, _ZP_EDUCATION, value);
				this._ZP_EDUCATION = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_TITLE
		{
			get{ return _ZP_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.ZP_TITLE, _ZP_TITLE, value);
				this._ZP_TITLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_RETIREMENT
		{
			get{ return _ZP_RETIREMENT; }
			set
			{
				this.OnPropertyValueChange(_.ZP_RETIREMENT, _ZP_RETIREMENT, value);
				this._ZP_RETIREMENT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_SPECIALITY
		{
			get{ return _ZP_SPECIALITY; }
			set
			{
				this.OnPropertyValueChange(_.ZP_SPECIALITY, _ZP_SPECIALITY, value);
				this._ZP_SPECIALITY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ZP_EDITTIME
		{
			get{ return _ZP_EDITTIME; }
			set
			{
				this.OnPropertyValueChange(_.ZP_EDITTIME, _ZP_EDITTIME, value);
				this._ZP_EDITTIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZP_STATE
		{
			get{ return _ZP_STATE; }
			set
			{
				this.OnPropertyValueChange(_.ZP_STATE, _ZP_STATE, value);
				this._ZP_STATE = value;
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
				_.ZP_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ZP_ID,
				_.ZP_USERNAME,
				_.ZP_PASSWORD,
				_.ZP_PERSONNAME,
				_.ZP_PHONE,
				_.ZP_POST,
				_.ZP_FAX,
				_.ZP_UNIT,
				_.ZP_ADDRESS,
				_.ZP_INDUSTRY,
				_.ZP_USERTYPE,
				_.ZP_USERSTATE,
				_.ZP_EMAIL,
				_.CRTIME,
				_.ZP_SEX,
				_.ZP_EDUCATION,
				_.ZP_TITLE,
				_.ZP_RETIREMENT,
				_.ZP_SPECIALITY,
				_.ZP_EDITTIME,
				_.ZP_STATE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ZP_ID,
				this._ZP_USERNAME,
				this._ZP_PASSWORD,
				this._ZP_PERSONNAME,
				this._ZP_PHONE,
				this._ZP_POST,
				this._ZP_FAX,
				this._ZP_UNIT,
				this._ZP_ADDRESS,
				this._ZP_INDUSTRY,
				this._ZP_USERTYPE,
				this._ZP_USERSTATE,
				this._ZP_EMAIL,
				this._CRTIME,
				this._ZP_SEX,
				this._ZP_EDUCATION,
				this._ZP_TITLE,
				this._ZP_RETIREMENT,
				this._ZP_SPECIALITY,
				this._ZP_EDITTIME,
				this._ZP_STATE,
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
			public readonly static Field All = new Field("*", "ZP_USER");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_ID = new Field("ZP_ID", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_USERNAME = new Field("ZP_USERNAME", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_PASSWORD = new Field("ZP_PASSWORD", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_PERSONNAME = new Field("ZP_PERSONNAME", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_PHONE = new Field("ZP_PHONE", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_POST = new Field("ZP_POST", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_FAX = new Field("ZP_FAX", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_UNIT = new Field("ZP_UNIT", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_ADDRESS = new Field("ZP_ADDRESS", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_INDUSTRY = new Field("ZP_INDUSTRY", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_USERTYPE = new Field("ZP_USERTYPE", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_USERSTATE = new Field("ZP_USERSTATE", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_EMAIL = new Field("ZP_EMAIL", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CRTIME = new Field("CRTIME", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_SEX = new Field("ZP_SEX", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_EDUCATION = new Field("ZP_EDUCATION", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_TITLE = new Field("ZP_TITLE", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_RETIREMENT = new Field("ZP_RETIREMENT", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_SPECIALITY = new Field("ZP_SPECIALITY", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_EDITTIME = new Field("ZP_EDITTIME", "ZP_USER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_STATE = new Field("ZP_STATE", "ZP_USER", "");
        }
        #endregion
	}
}