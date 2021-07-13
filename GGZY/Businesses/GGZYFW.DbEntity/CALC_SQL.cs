using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类CALC_SQL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("CALC_SQL")]
    [Serializable]
    public partial class CALC_SQL : FwEntity
    {
        #region Model
		private string _ID;
		private string _NAME;
		private string _SQL;
		private string _REMARK;

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
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public string SQL
		{
			get{ return _SQL; }
			set
			{
				this.OnPropertyValueChange(_.SQL, _SQL, value);
				this._SQL = value;
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
				_.NAME,
				_.SQL,
				_.REMARK,
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
				this._SQL,
				this._REMARK,
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
			public readonly static Field All = new Field("*", "CALC_SQL");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "CALC_SQL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "CALC_SQL", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SQL = new Field("SQL", "CALC_SQL",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "CALC_SQL", "");
        }
        #endregion
	}
}