using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类REVIEW_NODE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("REVIEW_NODE")]
    [Serializable]
    public partial class REVIEW_NODE : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _MAIN_ID;
		private string _NODE_NAME;
		private decimal? _ORDER_BY;
		private decimal? _TIMEOUT;
		private decimal? _PREV_NODE;
		private string _ATTRIBUTES;
		private string _BUTTONS;
		private decimal? _IS_MULTI;
		private decimal? _OPER_USE_NODE;
		private decimal? _PREV_MAIN_NODE;

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
		/// 审查机制ID
		/// </summary>
		public decimal? MAIN_ID
		{
			get{ return _MAIN_ID; }
			set
			{
				this.OnPropertyValueChange(_.MAIN_ID, _MAIN_ID, value);
				this._MAIN_ID = value;
			}
		}
		/// <summary>
		/// 节点名称
		/// </summary>
		public string NODE_NAME
		{
			get{ return _NODE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.NODE_NAME, _NODE_NAME, value);
				this._NODE_NAME = value;
			}
		}
		/// <summary>
		/// 顺序
		/// </summary>
		public decimal? ORDER_BY
		{
			get{ return _ORDER_BY; }
			set
			{
				this.OnPropertyValueChange(_.ORDER_BY, _ORDER_BY, value);
				this._ORDER_BY = value;
			}
		}
		/// <summary>
		/// 超时时限
		/// </summary>
		public decimal? TIMEOUT
		{
			get{ return _TIMEOUT; }
			set
			{
				this.OnPropertyValueChange(_.TIMEOUT, _TIMEOUT, value);
				this._TIMEOUT = value;
			}
		}
		/// <summary>
		/// 上一节点ID
		/// </summary>
		public decimal? PREV_NODE
		{
			get{ return _PREV_NODE; }
			set
			{
				this.OnPropertyValueChange(_.PREV_NODE, _PREV_NODE, value);
				this._PREV_NODE = value;
			}
		}
		/// <summary>
		/// 节点需填内容
		/// </summary>
		public string ATTRIBUTES
		{
			get{ return _ATTRIBUTES; }
			set
			{
				this.OnPropertyValueChange(_.ATTRIBUTES, _ATTRIBUTES, value);
				this._ATTRIBUTES = value;
			}
		}
		/// <summary>
		/// 拥有按钮
		/// </summary>
		public string BUTTONS
		{
			get{ return _BUTTONS; }
			set
			{
				this.OnPropertyValueChange(_.BUTTONS, _BUTTONS, value);
				this._BUTTONS = value;
			}
		}
		/// <summary>
		/// 是否多人参与
		/// </summary>
		public decimal? IS_MULTI
		{
			get{ return _IS_MULTI; }
			set
			{
				this.OnPropertyValueChange(_.IS_MULTI, _IS_MULTI, value);
				this._IS_MULTI = value;
			}
		}
		/// <summary>
		/// 操作人使用某个节点的人员
		/// </summary>
		public decimal? OPER_USE_NODE
		{
			get{ return _OPER_USE_NODE; }
			set
			{
				this.OnPropertyValueChange(_.OPER_USE_NODE, _OPER_USE_NODE, value);
				this._OPER_USE_NODE = value;
			}
		}
		/// <summary>
		/// 前置流程的节点id
		/// </summary>
		public decimal? PREV_MAIN_NODE
		{
			get{ return _PREV_MAIN_NODE; }
			set
			{
				this.OnPropertyValueChange(_.PREV_MAIN_NODE, _PREV_MAIN_NODE, value);
				this._PREV_MAIN_NODE = value;
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
				_.MAIN_ID,
				_.NODE_NAME,
				_.ORDER_BY,
				_.TIMEOUT,
				_.PREV_NODE,
				_.ATTRIBUTES,
				_.BUTTONS,
				_.IS_MULTI,
				_.OPER_USE_NODE,
				_.PREV_MAIN_NODE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._MAIN_ID,
				this._NODE_NAME,
				this._ORDER_BY,
				this._TIMEOUT,
				this._PREV_NODE,
				this._ATTRIBUTES,
				this._BUTTONS,
				this._IS_MULTI,
				this._OPER_USE_NODE,
				this._PREV_MAIN_NODE,
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
			public readonly static Field All = new Field("*", "REVIEW_NODE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "REVIEW_NODE", "ID");
            /// <summary>
			/// 审查机制ID
			/// </summary>
			public readonly static Field MAIN_ID = new Field("MAIN_ID", "REVIEW_NODE", "审查机制ID");
            /// <summary>
			/// 节点名称
			/// </summary>
			public readonly static Field NODE_NAME = new Field("NODE_NAME", "REVIEW_NODE", "节点名称");
            /// <summary>
			/// 顺序
			/// </summary>
			public readonly static Field ORDER_BY = new Field("ORDER_BY", "REVIEW_NODE", "顺序");
            /// <summary>
			/// 超时时限
			/// </summary>
			public readonly static Field TIMEOUT = new Field("TIMEOUT", "REVIEW_NODE", "超时时限");
            /// <summary>
			/// 上一节点ID
			/// </summary>
			public readonly static Field PREV_NODE = new Field("PREV_NODE", "REVIEW_NODE", "上一节点ID");
            /// <summary>
			/// 节点需填内容
			/// </summary>
			public readonly static Field ATTRIBUTES = new Field("ATTRIBUTES", "REVIEW_NODE", "节点需填内容");
            /// <summary>
			/// 拥有按钮
			/// </summary>
			public readonly static Field BUTTONS = new Field("BUTTONS", "REVIEW_NODE", "拥有按钮");
            /// <summary>
			/// 是否多人参与
			/// </summary>
			public readonly static Field IS_MULTI = new Field("IS_MULTI", "REVIEW_NODE", "是否多人参与");
            /// <summary>
			/// 操作人使用某个节点的人员
			/// </summary>
			public readonly static Field OPER_USE_NODE = new Field("OPER_USE_NODE", "REVIEW_NODE", "操作人使用某个节点的人员");
            /// <summary>
			/// 前置流程的节点id
			/// </summary>
			public readonly static Field PREV_MAIN_NODE = new Field("PREV_MAIN_NODE", "REVIEW_NODE", "前置流程的节点id");
        }
        #endregion
	}
}