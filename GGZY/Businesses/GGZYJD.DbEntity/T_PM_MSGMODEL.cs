using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_PM_MSGMODEL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_PM_MSGMODEL")]
    [Serializable]
    public partial class T_PM_MSGMODEL : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _U_ID;
		private decimal? _MPID;
		private string _CONTENT;

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
		/// 监督点
		/// </summary>
		public decimal? MPID
		{
			get{ return _MPID; }
			set
			{
				this.OnPropertyValueChange(_.MPID, _MPID, value);
				this._MPID = value;
			}
		}
		/// <summary>
		/// 模板内容
		/// </summary>
		public string CONTENT
		{
			get{ return _CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTENT, _CONTENT, value);
				this._CONTENT = value;
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
				_.MPID,
				_.CONTENT,
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
				this._MPID,
				this._CONTENT,
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
			public readonly static Field All = new Field("*", "T_PM_MSGMODEL");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_PM_MSGMODEL", "ID");
            /// <summary>
			/// 用户ID
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "T_PM_MSGMODEL", "用户ID");
            /// <summary>
			/// 监督点
			/// </summary>
			public readonly static Field MPID = new Field("MPID", "T_PM_MSGMODEL", "监督点");
            /// <summary>
			/// 模板内容
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "T_PM_MSGMODEL", "模板内容");
        }
        #endregion
	}
}