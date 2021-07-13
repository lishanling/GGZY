using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类CA_IMG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("CA_IMG")]
    [Serializable]
    public partial class CA_IMG : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _TITLE;
		private string _AID;
		private decimal? _TYPE;

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
		/// 标题
		/// </summary>
		public string TITLE
		{
			get{ return _TITLE; }
			set
			{
				this.OnPropertyValueChange(_.TITLE, _TITLE, value);
				this._TITLE = value;
			}
		}
		/// <summary>
		/// 图片
		/// </summary>
		public string AID
		{
			get{ return _AID; }
			set
			{
				this.OnPropertyValueChange(_.AID, _AID, value);
				this._AID = value;
			}
		}
		/// <summary>
		/// 类型
		/// </summary>
		public decimal? TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
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
				_.TITLE,
				_.AID,
				_.TYPE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TITLE,
				this._AID,
				this._TYPE,
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
			public readonly static Field All = new Field("*", "CA_IMG");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "CA_IMG", "ID");
            /// <summary>
			/// 标题
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "CA_IMG", "标题");
            /// <summary>
			/// 图片
			/// </summary>
			public readonly static Field AID = new Field("AID", "CA_IMG", "图片");
            /// <summary>
			/// 类型
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "CA_IMG", "类型");
        }
        #endregion
	}
}