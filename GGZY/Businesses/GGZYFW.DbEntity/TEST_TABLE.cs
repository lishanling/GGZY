using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TEST_TABLE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TEST_TABLE")]
    [Serializable]
    public partial class TEST_TABLE : FwEntity
    {
        #region Model
		private DateTime? _MYDATE;

		/// <summary>
		/// 
		/// </summary>
		public DateTime? MYDATE
		{
			get{ return _MYDATE; }
			set
			{
				this.OnPropertyValueChange(_.MYDATE, _MYDATE, value);
				this._MYDATE = value;
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
				_.MYDATE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._MYDATE,
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
			public readonly static Field All = new Field("*", "TEST_TABLE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MYDATE = new Field("MYDATE", "TEST_TABLE", "");
        }
        #endregion
	}
}