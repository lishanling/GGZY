using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类STATICS_SQL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("STATICS_SQL")]
    [Serializable]
    public partial class STATICS_SQL : FwEntity
    {
        #region Model
		private string _ID;
		private string _NAME;
		private string _CONTENT;
		private DateTime? _CREATE_TIME;
		private string _REMARK;
		private string _DATABASE_TYPE;
		private DateTime? _MODIFY_TIME;

		/// <summary>
		/// id
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
		/// <summary>
		/// 名称
		/// </summary>
		public string NAME
		{
			get{ return _NAME; }
			set
			{
				this.OnPropertyValueChange(_.NAME, _NAME, value);
				this._NAME = value;
			}
		}
		/// <summary>
		/// 内容sql
		/// </summary>
		public string CONTENT
		{
			get{ return _CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTENT, _CONTENT, value);
				this._CONTENT = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 备注
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
		/// 数据库类型
		/// </summary>
		public string DATABASE_TYPE
		{
			get{ return _DATABASE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.DATABASE_TYPE, _DATABASE_TYPE, value);
				this._DATABASE_TYPE = value;
			}
		}
		/// <summary>
		/// 最后修改时间
		/// </summary>
		public DateTime? MODIFY_TIME
		{
			get{ return _MODIFY_TIME; }
			set
			{
				this.OnPropertyValueChange(_.MODIFY_TIME, _MODIFY_TIME, value);
				this._MODIFY_TIME = value;
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
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.NAME,
				_.CONTENT,
				_.CREATE_TIME,
				_.REMARK,
				_.DATABASE_TYPE,
				_.MODIFY_TIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._NAME,
				this._CONTENT,
				this._CREATE_TIME,
				this._REMARK,
				this._DATABASE_TYPE,
				this._MODIFY_TIME,
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
			public readonly static Field All = new Field("*", "STATICS_SQL");
            /// <summary>
			/// id
			/// </summary>
			public readonly static Field ID = new Field("ID", "STATICS_SQL", "id");
            /// <summary>
			/// 名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "STATICS_SQL", "名称");
            /// <summary>
			/// 内容sql
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "STATICS_SQL",DbType.AnsiString, null, "内容sql");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "STATICS_SQL", "创建时间");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "STATICS_SQL", "备注");
            /// <summary>
			/// 数据库类型
			/// </summary>
			public readonly static Field DATABASE_TYPE = new Field("DATABASE_TYPE", "STATICS_SQL", "数据库类型");
            /// <summary>
			/// 最后修改时间
			/// </summary>
			public readonly static Field MODIFY_TIME = new Field("MODIFY_TIME", "STATICS_SQL", "最后修改时间");
        }
        #endregion
	}
}