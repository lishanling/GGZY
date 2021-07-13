using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_MESSAGE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_MESSAGE")]
    [Serializable]
    public partial class T_MESSAGE : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _TITLE;
		private string _CONTENT;
		private decimal? _U_ID;
		private DateTime? _TM;

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
		/// 发送人ID
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
				_.CONTENT,
				_.U_ID,
				_.TM,
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
				this._CONTENT,
				this._U_ID,
				this._TM,
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
			public readonly static Field All = new Field("*", "T_MESSAGE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_MESSAGE", "ID");
            /// <summary>
			/// 标题
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "T_MESSAGE", "标题");
            /// <summary>
			/// 消息内容
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "T_MESSAGE", "消息内容");
            /// <summary>
			/// 发送人ID
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "T_MESSAGE", "发送人ID");
            /// <summary>
			/// 时间
			/// </summary>
			public readonly static Field TM = new Field("TM", "T_MESSAGE", "时间");
        }
        #endregion
	}
}