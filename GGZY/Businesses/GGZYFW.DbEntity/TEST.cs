using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TEST。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TEST")]
    [Serializable]
    public partial class TEST : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _STUDENT;

		/// <summary>
		/// ID
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
		/// 学生
		/// </summary>
		public string STUDENT
		{
			get{ return _STUDENT; }
			set
			{
				this.OnPropertyValueChange(_.STUDENT, _STUDENT, value);
				this._STUDENT = value;
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
				_.STUDENT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._STUDENT,
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
			public readonly static Field All = new Field("*", "TEST");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "TEST", "ID");
            /// <summary>
			/// 学生
			/// </summary>
			public readonly static Field STUDENT = new Field("STUDENT", "TEST", "学生");
        }
        #endregion
	}
}