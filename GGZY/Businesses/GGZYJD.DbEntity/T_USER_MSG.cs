using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_USER_MSG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_USER_MSG")]
    [Serializable]
    public partial class T_USER_MSG : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _TITLE;
		private decimal? _U_ID;
		private string _CONTENT;
		private DateTime? _TM;
		private decimal? _ISREAD;
		private decimal? _ISDEL;
		private decimal? _F_ID;

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
		/// 消息内容
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
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime? TM
		{
			get{ return _TM; }
			set
			{
				this.OnPropertyValueChange(_.TM, _TM, value);
				this._TM = value;
			}
		}
		/// <summary>
		/// 是否已读:1是 0否
		/// </summary>
		public decimal? ISREAD
		{
			get{ return _ISREAD; }
			set
			{
				this.OnPropertyValueChange(_.ISREAD, _ISREAD, value);
				this._ISREAD = value;
			}
		}
		/// <summary>
		/// 是否已删除:1是 0否
		/// </summary>
		public decimal? ISDEL
		{
			get{ return _ISDEL; }
			set
			{
				this.OnPropertyValueChange(_.ISDEL, _ISDEL, value);
				this._ISDEL = value;
			}
		}
		/// <summary>
		/// 发送人ID
		/// </summary>
		public decimal? F_ID
		{
			get{ return _F_ID; }
			set
			{
				this.OnPropertyValueChange(_.F_ID, _F_ID, value);
				this._F_ID = value;
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
				_.U_ID,
				_.CONTENT,
				_.TM,
				_.ISREAD,
				_.ISDEL,
				_.F_ID,
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
				this._U_ID,
				this._CONTENT,
				this._TM,
				this._ISREAD,
				this._ISDEL,
				this._F_ID,
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
			public readonly static Field All = new Field("*", "T_USER_MSG");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_USER_MSG", "ID");
            /// <summary>
			/// 标题
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "T_USER_MSG", "标题");
            /// <summary>
			/// 用户ID
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "T_USER_MSG", "用户ID");
            /// <summary>
			/// 消息内容
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "T_USER_MSG", "消息内容");
            /// <summary>
			/// 时间
			/// </summary>
			public readonly static Field TM = new Field("TM", "T_USER_MSG", "时间");
            /// <summary>
			/// 是否已读:1是 0否
			/// </summary>
			public readonly static Field ISREAD = new Field("ISREAD", "T_USER_MSG", "是否已读:1是 0否");
            /// <summary>
			/// 是否已删除:1是 0否
			/// </summary>
			public readonly static Field ISDEL = new Field("ISDEL", "T_USER_MSG", "是否已删除:1是 0否");
            /// <summary>
			/// 发送人ID
			/// </summary>
			public readonly static Field F_ID = new Field("F_ID", "T_USER_MSG", "发送人ID");
        }
        #endregion
	}
}