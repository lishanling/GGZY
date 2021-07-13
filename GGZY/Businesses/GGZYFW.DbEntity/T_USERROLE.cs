using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_USERROLE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_USERROLE")]
    [Serializable]
    public partial class T_USERROLE : FwEntity
    {
        #region Model
		private decimal? _ROLEID;
		private string _RNAME;
		private string _RDESC;
		private string _RINHERIT;
		private decimal? _ORDERID;
		private decimal? _CREATEID;

		/// <summary>
		/// 
		/// </summary>
		public decimal? ROLEID
		{
			get{ return _ROLEID; }
			set
			{
				this.OnPropertyValueChange(_.ROLEID, _ROLEID, value);
				this._ROLEID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RNAME
		{
			get{ return _RNAME; }
			set
			{
				this.OnPropertyValueChange(_.RNAME, _RNAME, value);
				this._RNAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RDESC
		{
			get{ return _RDESC; }
			set
			{
				this.OnPropertyValueChange(_.RDESC, _RDESC, value);
				this._RDESC = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RINHERIT
		{
			get{ return _RINHERIT; }
			set
			{
				this.OnPropertyValueChange(_.RINHERIT, _RINHERIT, value);
				this._RINHERIT = value;
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.ROLEID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ROLEID,
				_.RNAME,
				_.RDESC,
				_.RINHERIT,
				_.ORDERID,
				_.CREATEID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ROLEID,
				this._RNAME,
				this._RDESC,
				this._RINHERIT,
				this._ORDERID,
				this._CREATEID,
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
			public readonly static Field All = new Field("*", "T_USERROLE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ROLEID = new Field("ROLEID", "T_USERROLE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RNAME = new Field("RNAME", "T_USERROLE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RDESC = new Field("RDESC", "T_USERROLE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RINHERIT = new Field("RINHERIT", "T_USERROLE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDERID = new Field("ORDERID", "T_USERROLE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATEID = new Field("CREATEID", "T_USERROLE", "");
        }
        #endregion
	}
}