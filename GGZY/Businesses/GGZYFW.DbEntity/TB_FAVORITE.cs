using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TB_FAVORITE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TB_FAVORITE")]
    [Serializable]
    public partial class TB_FAVORITE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _U_ID;
		private string _PROJECT_ID;

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
		/// 用户编号
		/// </summary>
		public decimal? U_ID
		{
			get{ return _U_ID; }
			set
			{
				this.OnPropertyValueChange(_.U_ID, _U_ID, value);
				this._U_ID = value;
			}
		}
		/// <summary>
		/// 项目编号
		/// </summary>
		public string PROJECT_ID
		{
			get{ return _PROJECT_ID; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_ID, _PROJECT_ID, value);
				this._PROJECT_ID = value;
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
				_.U_ID,
				_.PROJECT_ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._U_ID,
				this._PROJECT_ID,
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
			public readonly static Field All = new Field("*", "TB_FAVORITE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "TB_FAVORITE", "ID");
            /// <summary>
			/// 用户编号
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "TB_FAVORITE", "用户编号");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_ID = new Field("PROJECT_ID", "TB_FAVORITE", "项目编号");
        }
        #endregion
	}
}