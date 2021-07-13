using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类LOG_PROCESSING。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("LOG_PROCESSING")]
    [Serializable]
    public partial class LOG_PROCESSING : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _NUM;
		private string _ACQUISITION_RULE;
		private string _COLLECTION_TYPE;
		private string _COLLECTION_METHOD;
		private string _COLLENTION_CONTENT;
		private string _OPERATING;

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
		/// 序号
		/// </summary>
		public string NUM
		{
			get{ return _NUM; }
			set
			{
				this.OnPropertyValueChange(_.NUM, _NUM, value);
				this._NUM = value;
			}
		}
		/// <summary>
		/// 采集规则名称
		/// </summary>
		public string ACQUISITION_RULE
		{
			get{ return _ACQUISITION_RULE; }
			set
			{
				this.OnPropertyValueChange(_.ACQUISITION_RULE, _ACQUISITION_RULE, value);
				this._ACQUISITION_RULE = value;
			}
		}
		/// <summary>
		/// 采集类型
		/// </summary>
		public string COLLECTION_TYPE
		{
			get{ return _COLLECTION_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.COLLECTION_TYPE, _COLLECTION_TYPE, value);
				this._COLLECTION_TYPE = value;
			}
		}
		/// <summary>
		/// 采集方法
		/// </summary>
		public string COLLECTION_METHOD
		{
			get{ return _COLLECTION_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.COLLECTION_METHOD, _COLLECTION_METHOD, value);
				this._COLLECTION_METHOD = value;
			}
		}
		/// <summary>
		/// 采集内容
		/// </summary>
		public string COLLENTION_CONTENT
		{
			get{ return _COLLENTION_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.COLLENTION_CONTENT, _COLLENTION_CONTENT, value);
				this._COLLENTION_CONTENT = value;
			}
		}
		/// <summary>
		/// 操作区
		/// </summary>
		public string OPERATING
		{
			get{ return _OPERATING; }
			set
			{
				this.OnPropertyValueChange(_.OPERATING, _OPERATING, value);
				this._OPERATING = value;
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
				_.NUM,
				_.ACQUISITION_RULE,
				_.COLLECTION_TYPE,
				_.COLLECTION_METHOD,
				_.COLLENTION_CONTENT,
				_.OPERATING,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._NUM,
				this._ACQUISITION_RULE,
				this._COLLECTION_TYPE,
				this._COLLECTION_METHOD,
				this._COLLENTION_CONTENT,
				this._OPERATING,
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
			public readonly static Field All = new Field("*", "LOG_PROCESSING");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "LOG_PROCESSING", "ID");
            /// <summary>
			/// 序号
			/// </summary>
			public readonly static Field NUM = new Field("NUM", "LOG_PROCESSING", "序号");
            /// <summary>
			/// 采集规则名称
			/// </summary>
			public readonly static Field ACQUISITION_RULE = new Field("ACQUISITION_RULE", "LOG_PROCESSING", "采集规则名称");
            /// <summary>
			/// 采集类型
			/// </summary>
			public readonly static Field COLLECTION_TYPE = new Field("COLLECTION_TYPE", "LOG_PROCESSING", "采集类型");
            /// <summary>
			/// 采集方法
			/// </summary>
			public readonly static Field COLLECTION_METHOD = new Field("COLLECTION_METHOD", "LOG_PROCESSING", "采集方法");
            /// <summary>
			/// 采集内容
			/// </summary>
			public readonly static Field COLLENTION_CONTENT = new Field("COLLENTION_CONTENT", "LOG_PROCESSING", "采集内容");
            /// <summary>
			/// 操作区
			/// </summary>
			public readonly static Field OPERATING = new Field("OPERATING", "LOG_PROCESSING", "操作区");
        }
        #endregion
	}
}