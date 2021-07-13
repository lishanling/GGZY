using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类SYS_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SYS_INFO")]
    [Serializable]
    public partial class SYS_INFO : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _SYSNAME;
		private string _URL_WW;
		private string _URL_NW;
		private decimal? _TYPE;
		private string _REMARK;
		private decimal? _ORDERID;

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
		public string SYSNAME
		{
			get{ return _SYSNAME; }
			set
			{
				this.OnPropertyValueChange(_.SYSNAME, _SYSNAME, value);
				this._SYSNAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string URL_WW
		{
			get{ return _URL_WW; }
			set
			{
				this.OnPropertyValueChange(_.URL_WW, _URL_WW, value);
				this._URL_WW = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string URL_NW
		{
			get{ return _URL_NW; }
			set
			{
				this.OnPropertyValueChange(_.URL_NW, _URL_NW, value);
				this._URL_NW = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
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
		public decimal? ORDERID
		{
			get{ return _ORDERID; }
			set
			{
				this.OnPropertyValueChange(_.ORDERID, _ORDERID, value);
				this._ORDERID = value;
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
				_.SYSNAME,
				_.URL_WW,
				_.URL_NW,
				_.TYPE,
				_.REMARK,
				_.ORDERID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._SYSNAME,
				this._URL_WW,
				this._URL_NW,
				this._TYPE,
				this._REMARK,
				this._ORDERID,
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
			public readonly static Field All = new Field("*", "SYS_INFO");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "SYS_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SYSNAME = new Field("SYSNAME", "SYS_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field URL_WW = new Field("URL_WW", "SYS_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field URL_NW = new Field("URL_NW", "SYS_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "SYS_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "SYS_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDERID = new Field("ORDERID", "SYS_INFO", "");
        }
        #endregion
	}
}