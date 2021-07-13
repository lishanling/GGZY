using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_MENU。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_MENU")]
    [Serializable]
    public partial class T_MENU : FwEntity
    {
        #region Model
		private decimal? _MENUID;
		private decimal? _PARENTID;
		private string _MNAME;
		private decimal? _ORDERID;
		private string _NAVIGATEURI;
		private string _COMMANDPATH;
		private string _COMMANDCLASS;
		private string _IMAGEPATH;
		private decimal? _ISDEFAULT;
		private decimal? _ISEANBLED;
		private decimal? _ISURL;
		private string _ARGS;
		private decimal? _ISDISPLAY;
		private string _OPTYPES;
		private decimal? _NHEIGHT;
		private decimal? _NWIDTH;

		/// <summary>
		/// 
		/// </summary>
		public decimal? MENUID
		{
			get{ return _MENUID; }
			set
			{
				this.OnPropertyValueChange(_.MENUID, _MENUID, value);
				this._MENUID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PARENTID
		{
			get{ return _PARENTID; }
			set
			{
				this.OnPropertyValueChange(_.PARENTID, _PARENTID, value);
				this._PARENTID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MNAME
		{
			get{ return _MNAME; }
			set
			{
				this.OnPropertyValueChange(_.MNAME, _MNAME, value);
				this._MNAME = value;
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
		public string NAVIGATEURI
		{
			get{ return _NAVIGATEURI; }
			set
			{
				this.OnPropertyValueChange(_.NAVIGATEURI, _NAVIGATEURI, value);
				this._NAVIGATEURI = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMMANDPATH
		{
			get{ return _COMMANDPATH; }
			set
			{
				this.OnPropertyValueChange(_.COMMANDPATH, _COMMANDPATH, value);
				this._COMMANDPATH = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMMANDCLASS
		{
			get{ return _COMMANDCLASS; }
			set
			{
				this.OnPropertyValueChange(_.COMMANDCLASS, _COMMANDCLASS, value);
				this._COMMANDCLASS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IMAGEPATH
		{
			get{ return _IMAGEPATH; }
			set
			{
				this.OnPropertyValueChange(_.IMAGEPATH, _IMAGEPATH, value);
				this._IMAGEPATH = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISDEFAULT
		{
			get{ return _ISDEFAULT; }
			set
			{
				this.OnPropertyValueChange(_.ISDEFAULT, _ISDEFAULT, value);
				this._ISDEFAULT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISEANBLED
		{
			get{ return _ISEANBLED; }
			set
			{
				this.OnPropertyValueChange(_.ISEANBLED, _ISEANBLED, value);
				this._ISEANBLED = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISURL
		{
			get{ return _ISURL; }
			set
			{
				this.OnPropertyValueChange(_.ISURL, _ISURL, value);
				this._ISURL = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ARGS
		{
			get{ return _ARGS; }
			set
			{
				this.OnPropertyValueChange(_.ARGS, _ARGS, value);
				this._ARGS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISDISPLAY
		{
			get{ return _ISDISPLAY; }
			set
			{
				this.OnPropertyValueChange(_.ISDISPLAY, _ISDISPLAY, value);
				this._ISDISPLAY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPTYPES
		{
			get{ return _OPTYPES; }
			set
			{
				this.OnPropertyValueChange(_.OPTYPES, _OPTYPES, value);
				this._OPTYPES = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? NHEIGHT
		{
			get{ return _NHEIGHT; }
			set
			{
				this.OnPropertyValueChange(_.NHEIGHT, _NHEIGHT, value);
				this._NHEIGHT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? NWIDTH
		{
			get{ return _NWIDTH; }
			set
			{
				this.OnPropertyValueChange(_.NWIDTH, _NWIDTH, value);
				this._NWIDTH = value;
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
				_.MENUID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.MENUID,
				_.PARENTID,
				_.MNAME,
				_.ORDERID,
				_.NAVIGATEURI,
				_.COMMANDPATH,
				_.COMMANDCLASS,
				_.IMAGEPATH,
				_.ISDEFAULT,
				_.ISEANBLED,
				_.ISURL,
				_.ARGS,
				_.ISDISPLAY,
				_.OPTYPES,
				_.NHEIGHT,
				_.NWIDTH,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._MENUID,
				this._PARENTID,
				this._MNAME,
				this._ORDERID,
				this._NAVIGATEURI,
				this._COMMANDPATH,
				this._COMMANDCLASS,
				this._IMAGEPATH,
				this._ISDEFAULT,
				this._ISEANBLED,
				this._ISURL,
				this._ARGS,
				this._ISDISPLAY,
				this._OPTYPES,
				this._NHEIGHT,
				this._NWIDTH,
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
			public readonly static Field All = new Field("*", "T_MENU");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MENUID = new Field("MENUID", "T_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PARENTID = new Field("PARENTID", "T_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MNAME = new Field("MNAME", "T_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDERID = new Field("ORDERID", "T_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NAVIGATEURI = new Field("NAVIGATEURI", "T_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field COMMANDPATH = new Field("COMMANDPATH", "T_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field COMMANDCLASS = new Field("COMMANDCLASS", "T_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IMAGEPATH = new Field("IMAGEPATH", "T_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISDEFAULT = new Field("ISDEFAULT", "T_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISEANBLED = new Field("ISEANBLED", "T_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISURL = new Field("ISURL", "T_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ARGS = new Field("ARGS", "T_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISDISPLAY = new Field("ISDISPLAY", "T_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OPTYPES = new Field("OPTYPES", "T_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NHEIGHT = new Field("NHEIGHT", "T_MENU", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NWIDTH = new Field("NWIDTH", "T_MENU", "");
        }
        #endregion
	}
}