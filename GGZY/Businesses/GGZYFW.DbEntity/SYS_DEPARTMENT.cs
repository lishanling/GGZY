using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类SYS_DEPARTMENT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SYS_DEPARTMENT")]
    [Serializable]
    public partial class SYS_DEPARTMENT : FwEntity
    {
        #region Model
		private decimal? _DEPID;
		private string _DNAME;
		private string _AREACODE;
		private decimal? _PARENTID;
		private string _DREMARK;
		private decimal? _LONGI;
		private decimal? _LATI;
		private string _DTYPE;
		private string _ORGPROPERTY;
		private decimal? _ORDERID;
		private string _DEPCODE;
		private decimal? _ISCK;
		private decimal? _CKID;

		/// <summary>
		/// 
		/// </summary>
		public decimal? DEPID
		{
			get{ return _DEPID; }
			set
			{
				this.OnPropertyValueChange(_.DEPID, _DEPID, value);
				this._DEPID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DNAME
		{
			get{ return _DNAME; }
			set
			{
				this.OnPropertyValueChange(_.DNAME, _DNAME, value);
				this._DNAME = value;
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
		public string DREMARK
		{
			get{ return _DREMARK; }
			set
			{
				this.OnPropertyValueChange(_.DREMARK, _DREMARK, value);
				this._DREMARK = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LONGI
		{
			get{ return _LONGI; }
			set
			{
				this.OnPropertyValueChange(_.LONGI, _LONGI, value);
				this._LONGI = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LATI
		{
			get{ return _LATI; }
			set
			{
				this.OnPropertyValueChange(_.LATI, _LATI, value);
				this._LATI = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DTYPE
		{
			get{ return _DTYPE; }
			set
			{
				this.OnPropertyValueChange(_.DTYPE, _DTYPE, value);
				this._DTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORGPROPERTY
		{
			get{ return _ORGPROPERTY; }
			set
			{
				this.OnPropertyValueChange(_.ORGPROPERTY, _ORGPROPERTY, value);
				this._ORGPROPERTY = value;
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
		public string DEPCODE
		{
			get{ return _DEPCODE; }
			set
			{
				this.OnPropertyValueChange(_.DEPCODE, _DEPCODE, value);
				this._DEPCODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISCK
		{
			get{ return _ISCK; }
			set
			{
				this.OnPropertyValueChange(_.ISCK, _ISCK, value);
				this._ISCK = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CKID
		{
			get{ return _CKID; }
			set
			{
				this.OnPropertyValueChange(_.CKID, _CKID, value);
				this._CKID = value;
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
				_.DEPID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.DEPID,
				_.DNAME,
				_.AREACODE,
				_.PARENTID,
				_.DREMARK,
				_.LONGI,
				_.LATI,
				_.DTYPE,
				_.ORGPROPERTY,
				_.ORDERID,
				_.DEPCODE,
				_.ISCK,
				_.CKID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._DEPID,
				this._DNAME,
				this._AREACODE,
				this._PARENTID,
				this._DREMARK,
				this._LONGI,
				this._LATI,
				this._DTYPE,
				this._ORGPROPERTY,
				this._ORDERID,
				this._DEPCODE,
				this._ISCK,
				this._CKID,
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
			public readonly static Field All = new Field("*", "SYS_DEPARTMENT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DEPID = new Field("DEPID", "SYS_DEPARTMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DNAME = new Field("DNAME", "SYS_DEPARTMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "SYS_DEPARTMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PARENTID = new Field("PARENTID", "SYS_DEPARTMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DREMARK = new Field("DREMARK", "SYS_DEPARTMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LONGI = new Field("LONGI", "SYS_DEPARTMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LATI = new Field("LATI", "SYS_DEPARTMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DTYPE = new Field("DTYPE", "SYS_DEPARTMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORGPROPERTY = new Field("ORGPROPERTY", "SYS_DEPARTMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDERID = new Field("ORDERID", "SYS_DEPARTMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DEPCODE = new Field("DEPCODE", "SYS_DEPARTMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISCK = new Field("ISCK", "SYS_DEPARTMENT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CKID = new Field("CKID", "SYS_DEPARTMENT", "");
        }
        #endregion
	}
}