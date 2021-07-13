using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类SYS_POPEDOM。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SYS_POPEDOM")]
    [Serializable]
    public partial class SYS_POPEDOM : JdEntity
    {
        #region Model
		private decimal? _POPID;
		private decimal? _MENUID;
		private string _POPTYPE;
		private string _OBJECTTYPE;
		private decimal? _OBJECTID;
		private string _REMARK;
		private string _CREATEID;
		private DateTime? _CREATETIME;

		/// <summary>
		/// 
		/// </summary>
		public decimal? POPID
		{
			get{ return _POPID; }
			set
			{
				this.OnPropertyValueChange(_.POPID, _POPID, value);
				this._POPID = value;
			}
		}
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
		public string POPTYPE
		{
			get{ return _POPTYPE; }
			set
			{
				this.OnPropertyValueChange(_.POPTYPE, _POPTYPE, value);
				this._POPTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OBJECTTYPE
		{
			get{ return _OBJECTTYPE; }
			set
			{
				this.OnPropertyValueChange(_.OBJECTTYPE, _OBJECTTYPE, value);
				this._OBJECTTYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OBJECTID
		{
			get{ return _OBJECTID; }
			set
			{
				this.OnPropertyValueChange(_.OBJECTID, _OBJECTID, value);
				this._OBJECTID = value;
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
		public string CREATEID
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.POPID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.POPID,
				_.MENUID,
				_.POPTYPE,
				_.OBJECTTYPE,
				_.OBJECTID,
				_.REMARK,
				_.CREATEID,
				_.CREATETIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._POPID,
				this._MENUID,
				this._POPTYPE,
				this._OBJECTTYPE,
				this._OBJECTID,
				this._REMARK,
				this._CREATEID,
				this._CREATETIME,
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
			public readonly static Field All = new Field("*", "SYS_POPEDOM");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field POPID = new Field("POPID", "SYS_POPEDOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MENUID = new Field("MENUID", "SYS_POPEDOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field POPTYPE = new Field("POPTYPE", "SYS_POPEDOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OBJECTTYPE = new Field("OBJECTTYPE", "SYS_POPEDOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OBJECTID = new Field("OBJECTID", "SYS_POPEDOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "SYS_POPEDOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATEID = new Field("CREATEID", "SYS_POPEDOM", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "SYS_POPEDOM", "");
        }
        #endregion
	}
}