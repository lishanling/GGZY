using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类STATICS_SQL_RECORD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("STATICS_SQL_RECORD")]
    [Serializable]
    public partial class STATICS_SQL_RECORD : FwEntity
    {
        #region Model
		private string _ID;
		private string _SQL_ID;
		private DateTime? _CREATE_TIME;
		private string _DOSQL;
		private string _RESULT;

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
		/// sqlid
		/// </summary>
		public string SQL_ID
		{
			get{ return _SQL_ID; }
			set
			{
				this.OnPropertyValueChange(_.SQL_ID, _SQL_ID, value);
				this._SQL_ID = value;
			}
		}
		/// <summary>
		/// 记录时间
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
		/// 执行的sql
		/// </summary>
		public string DOSQL
		{
			get{ return _DOSQL; }
			set
			{
				this.OnPropertyValueChange(_.DOSQL, _DOSQL, value);
				this._DOSQL = value;
			}
		}
		/// <summary>
		/// 结果json
		/// </summary>
		public string RESULT
		{
			get{ return _RESULT; }
			set
			{
				this.OnPropertyValueChange(_.RESULT, _RESULT, value);
				this._RESULT = value;
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
				_.SQL_ID,
				_.CREATE_TIME,
				_.DOSQL,
				_.RESULT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._SQL_ID,
				this._CREATE_TIME,
				this._DOSQL,
				this._RESULT,
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
			public readonly static Field All = new Field("*", "STATICS_SQL_RECORD");
            /// <summary>
			/// id
			/// </summary>
			public readonly static Field ID = new Field("ID", "STATICS_SQL_RECORD", "id");
            /// <summary>
			/// sqlid
			/// </summary>
			public readonly static Field SQL_ID = new Field("SQL_ID", "STATICS_SQL_RECORD", "sqlid");
            /// <summary>
			/// 记录时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "STATICS_SQL_RECORD", "记录时间");
            /// <summary>
			/// 执行的sql
			/// </summary>
			public readonly static Field DOSQL = new Field("DOSQL", "STATICS_SQL_RECORD",DbType.AnsiString, null, "执行的sql");
            /// <summary>
			/// 结果json
			/// </summary>
			public readonly static Field RESULT = new Field("RESULT", "STATICS_SQL_RECORD",DbType.AnsiString, null, "结果json");
        }
        #endregion
	}
}