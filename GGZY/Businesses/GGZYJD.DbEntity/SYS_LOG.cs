using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类SYS_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SYS_LOG")]
    [Serializable]
    public partial class SYS_LOG : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _NOTETYPE;
		private decimal? _FUNCTIONMODEL;
		private decimal? _MENUID;
		private string _LCONTENT;
		private string _IP;
		private decimal? _CREATEUSERID;
		private DateTime? _CREATETIME;

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
		public string NOTETYPE
		{
			get{ return _NOTETYPE; }
			set
			{
				this.OnPropertyValueChange(_.NOTETYPE, _NOTETYPE, value);
				this._NOTETYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FUNCTIONMODEL
		{
			get{ return _FUNCTIONMODEL; }
			set
			{
				this.OnPropertyValueChange(_.FUNCTIONMODEL, _FUNCTIONMODEL, value);
				this._FUNCTIONMODEL = value;
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
		public string LCONTENT
		{
			get{ return _LCONTENT; }
			set
			{
				this.OnPropertyValueChange(_.LCONTENT, _LCONTENT, value);
				this._LCONTENT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IP
		{
			get{ return _IP; }
			set
			{
				this.OnPropertyValueChange(_.IP, _IP, value);
				this._IP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CREATEUSERID
		{
			get{ return _CREATEUSERID; }
			set
			{
				this.OnPropertyValueChange(_.CREATEUSERID, _CREATEUSERID, value);
				this._CREATEUSERID = value;
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
				_.NOTETYPE,
				_.FUNCTIONMODEL,
				_.MENUID,
				_.LCONTENT,
				_.IP,
				_.CREATEUSERID,
				_.CREATETIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._NOTETYPE,
				this._FUNCTIONMODEL,
				this._MENUID,
				this._LCONTENT,
				this._IP,
				this._CREATEUSERID,
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
			public readonly static Field All = new Field("*", "SYS_LOG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "SYS_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NOTETYPE = new Field("NOTETYPE", "SYS_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FUNCTIONMODEL = new Field("FUNCTIONMODEL", "SYS_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MENUID = new Field("MENUID", "SYS_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LCONTENT = new Field("LCONTENT", "SYS_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IP = new Field("IP", "SYS_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATEUSERID = new Field("CREATEUSERID", "SYS_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "SYS_LOG", "");
        }
        #endregion
	}
}