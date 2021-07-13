using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_TUISONG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_TUISONG")]
    [Serializable]
    public partial class T_TUISONG : FwEntity
    {
        #region Model
		private string _GUID;
		private string _TABLENAME;
		private DateTime? _CREATETIME;
		private DateTime? _LASTTIME;
		private decimal? _ISSEND_ZHUJIAN;
		private decimal? _ISSEND_KONGJIAN;
		private decimal? _ISSEND_1;
		private decimal? _ISSEND_2;
		private decimal? _ISSEND_3;
		private string _TOTALID;
		private string _ID;

		/// <summary>
		/// 
		/// </summary>
		public string GUID
		{
			get{ return _GUID; }
			set
			{
				this.OnPropertyValueChange(_.GUID, _GUID, value);
				this._GUID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TABLENAME
		{
			get{ return _TABLENAME; }
			set
			{
				this.OnPropertyValueChange(_.TABLENAME, _TABLENAME, value);
				this._TABLENAME = value;
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
		public DateTime? LASTTIME
		{
			get{ return _LASTTIME; }
			set
			{
				this.OnPropertyValueChange(_.LASTTIME, _LASTTIME, value);
				this._LASTTIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISSEND_ZHUJIAN
		{
			get{ return _ISSEND_ZHUJIAN; }
			set
			{
				this.OnPropertyValueChange(_.ISSEND_ZHUJIAN, _ISSEND_ZHUJIAN, value);
				this._ISSEND_ZHUJIAN = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISSEND_KONGJIAN
		{
			get{ return _ISSEND_KONGJIAN; }
			set
			{
				this.OnPropertyValueChange(_.ISSEND_KONGJIAN, _ISSEND_KONGJIAN, value);
				this._ISSEND_KONGJIAN = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISSEND_1
		{
			get{ return _ISSEND_1; }
			set
			{
				this.OnPropertyValueChange(_.ISSEND_1, _ISSEND_1, value);
				this._ISSEND_1 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISSEND_2
		{
			get{ return _ISSEND_2; }
			set
			{
				this.OnPropertyValueChange(_.ISSEND_2, _ISSEND_2, value);
				this._ISSEND_2 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISSEND_3
		{
			get{ return _ISSEND_3; }
			set
			{
				this.OnPropertyValueChange(_.ISSEND_3, _ISSEND_3, value);
				this._ISSEND_3 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TOTALID
		{
			get{ return _TOTALID; }
			set
			{
				this.OnPropertyValueChange(_.TOTALID, _TOTALID, value);
				this._TOTALID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
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
				_.GUID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.GUID,
				_.TABLENAME,
				_.CREATETIME,
				_.LASTTIME,
				_.ISSEND_ZHUJIAN,
				_.ISSEND_KONGJIAN,
				_.ISSEND_1,
				_.ISSEND_2,
				_.ISSEND_3,
				_.TOTALID,
				_.ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._GUID,
				this._TABLENAME,
				this._CREATETIME,
				this._LASTTIME,
				this._ISSEND_ZHUJIAN,
				this._ISSEND_KONGJIAN,
				this._ISSEND_1,
				this._ISSEND_2,
				this._ISSEND_3,
				this._TOTALID,
				this._ID,
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
			public readonly static Field All = new Field("*", "T_TUISONG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "T_TUISONG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TABLENAME = new Field("TABLENAME", "T_TUISONG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "T_TUISONG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LASTTIME = new Field("LASTTIME", "T_TUISONG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISSEND_ZHUJIAN = new Field("ISSEND_ZHUJIAN", "T_TUISONG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISSEND_KONGJIAN = new Field("ISSEND_KONGJIAN", "T_TUISONG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISSEND_1 = new Field("ISSEND_1", "T_TUISONG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISSEND_2 = new Field("ISSEND_2", "T_TUISONG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISSEND_3 = new Field("ISSEND_3", "T_TUISONG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TOTALID = new Field("TOTALID", "T_TUISONG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_TUISONG", "");
        }
        #endregion
	}
}