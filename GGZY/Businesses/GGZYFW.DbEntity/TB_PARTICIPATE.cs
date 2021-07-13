using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TB_PARTICIPATE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TB_PARTICIPATE")]
    [Serializable]
    public partial class TB_PARTICIPATE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _U_ID;
		private decimal? _ANN_ID;

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
		/// 用户ID
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
		/// 公告ID，M_ID关联
		/// </summary>
		public decimal? ANN_ID
		{
			get{ return _ANN_ID; }
			set
			{
				this.OnPropertyValueChange(_.ANN_ID, _ANN_ID, value);
				this._ANN_ID = value;
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
				_.ANN_ID,
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
				this._ANN_ID,
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
			public readonly static Field All = new Field("*", "TB_PARTICIPATE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "TB_PARTICIPATE", "");
            /// <summary>
			/// 用户ID
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "TB_PARTICIPATE", "用户ID");
            /// <summary>
			/// 公告ID，M_ID关联
			/// </summary>
			public readonly static Field ANN_ID = new Field("ANN_ID", "TB_PARTICIPATE", "公告ID，M_ID关联");
        }
        #endregion
	}
}