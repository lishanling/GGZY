using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_ROWID。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_ROWID")]
    [Serializable]
    public partial class T_ROWID : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _NAME;
		private decimal? _NUM;

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
		public decimal? NUM
		{
			get{ return _NUM; }
			set
			{
				this.OnPropertyValueChange(_.NUM, _NUM, value);
				this._NUM = value;
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
				_.NUM,
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
				this._NUM,
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
			public readonly static Field All = new Field("*", "T_ROWID");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_ROWID", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_ROWID", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NUM = new Field("NUM", "T_ROWID", "");
        }
        #endregion
	}
}