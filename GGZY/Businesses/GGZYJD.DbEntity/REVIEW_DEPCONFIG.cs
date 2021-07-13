using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类REVIEW_DEPCONFIG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("REVIEW_DEPCONFIG")]
    [Serializable]
    public partial class REVIEW_DEPCONFIG : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _NODE_ID;
		private decimal? _DEP_ID;
		private decimal? _USER_ID;
		private decimal? _IS_MAIN;
		private decimal? _IS_SELECT;

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
		/// 节点ID
		/// </summary>
		public decimal? NODE_ID
		{
			get{ return _NODE_ID; }
			set
			{
				this.OnPropertyValueChange(_.NODE_ID, _NODE_ID, value);
				this._NODE_ID = value;
			}
		}
		/// <summary>
		/// DEP_ID
		/// </summary>
		public decimal? DEP_ID
		{
			get{ return _DEP_ID; }
			set
			{
				this.OnPropertyValueChange(_.DEP_ID, _DEP_ID, value);
				this._DEP_ID = value;
			}
		}
		/// <summary>
		/// 参与人员
		/// </summary>
		public decimal? USER_ID
		{
			get{ return _USER_ID; }
			set
			{
				this.OnPropertyValueChange(_.USER_ID, _USER_ID, value);
				this._USER_ID = value;
			}
		}
		/// <summary>
		/// 是否牵头人
		/// </summary>
		public decimal? IS_MAIN
		{
			get{ return _IS_MAIN; }
			set
			{
				this.OnPropertyValueChange(_.IS_MAIN, _IS_MAIN, value);
				this._IS_MAIN = value;
			}
		}
		/// <summary>
		/// 是否默认选中
		/// </summary>
		public decimal? IS_SELECT
		{
			get{ return _IS_SELECT; }
			set
			{
				this.OnPropertyValueChange(_.IS_SELECT, _IS_SELECT, value);
				this._IS_SELECT = value;
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
				_.NODE_ID,
				_.DEP_ID,
				_.USER_ID,
				_.IS_MAIN,
				_.IS_SELECT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._NODE_ID,
				this._DEP_ID,
				this._USER_ID,
				this._IS_MAIN,
				this._IS_SELECT,
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
			public readonly static Field All = new Field("*", "REVIEW_DEPCONFIG");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "REVIEW_DEPCONFIG", "ID");
            /// <summary>
			/// 节点ID
			/// </summary>
			public readonly static Field NODE_ID = new Field("NODE_ID", "REVIEW_DEPCONFIG", "节点ID");
            /// <summary>
			/// DEP_ID
			/// </summary>
			public readonly static Field DEP_ID = new Field("DEP_ID", "REVIEW_DEPCONFIG", "DEP_ID");
            /// <summary>
			/// 参与人员
			/// </summary>
			public readonly static Field USER_ID = new Field("USER_ID", "REVIEW_DEPCONFIG", "参与人员");
            /// <summary>
			/// 是否牵头人
			/// </summary>
			public readonly static Field IS_MAIN = new Field("IS_MAIN", "REVIEW_DEPCONFIG", "是否牵头人");
            /// <summary>
			/// 是否默认选中
			/// </summary>
			public readonly static Field IS_SELECT = new Field("IS_SELECT", "REVIEW_DEPCONFIG", "是否默认选中");
        }
        #endregion
	}
}