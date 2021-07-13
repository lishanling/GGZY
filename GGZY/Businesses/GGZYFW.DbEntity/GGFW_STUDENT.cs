using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类GGFW_STUDENT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("GGFW_STUDENT")]
    [Serializable]
    public partial class GGFW_STUDENT : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _NAME;

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
		/// ????
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
			public readonly static Field All = new Field("*", "GGFW_STUDENT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "GGFW_STUDENT", "");
            /// <summary>
			/// ????
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "GGFW_STUDENT", "????");
        }
        #endregion
	}
}