using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类REVIEW_BUTTON。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("REVIEW_BUTTON")]
    [Serializable]
    public partial class REVIEW_BUTTON : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _BT_NAME;
		private string _BT_EVENT;
		private string _REMARK;
		private string _TITLE;

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
		/// 按钮名称
		/// </summary>
		public string BT_NAME
		{
			get{ return _BT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BT_NAME, _BT_NAME, value);
				this._BT_NAME = value;
			}
		}
		/// <summary>
		/// 按钮事件
		/// </summary>
		public string BT_EVENT
		{
			get{ return _BT_EVENT; }
			set
			{
				this.OnPropertyValueChange(_.BT_EVENT, _BT_EVENT, value);
				this._BT_EVENT = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARK
		{
			get{ return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
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
				_.BT_NAME,
				_.BT_EVENT,
				_.REMARK,
				_.TITLE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._BT_NAME,
				this._BT_EVENT,
				this._REMARK,
				this._TITLE,
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
			public readonly static Field All = new Field("*", "REVIEW_BUTTON");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "REVIEW_BUTTON", "ID");
            /// <summary>
			/// 按钮名称
			/// </summary>
			public readonly static Field BT_NAME = new Field("BT_NAME", "REVIEW_BUTTON", "按钮名称");
            /// <summary>
			/// 按钮事件
			/// </summary>
			public readonly static Field BT_EVENT = new Field("BT_EVENT", "REVIEW_BUTTON", "按钮事件");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "REVIEW_BUTTON", "备注");
            /// <summary>
			/// 标题
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "REVIEW_BUTTON", "标题");
        }
        #endregion
	}
}