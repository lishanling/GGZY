using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类LOG_REPORT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("LOG_REPORT")]
    [Serializable]
    public partial class LOG_REPORT : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _REPORT_NAME;
		private string _REPORT_TYPE;
		private DateTime? _REPORT_PERIOD;
		private string _REPORT_CONTENT;
		private DateTime? _REPORT_TIME;

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
		/// 报告名称
		/// </summary>
		public string REPORT_NAME
		{
			get{ return _REPORT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.REPORT_NAME, _REPORT_NAME, value);
				this._REPORT_NAME = value;
			}
		}
		/// <summary>
		/// 报告类型
		/// </summary>
		public string REPORT_TYPE
		{
			get{ return _REPORT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.REPORT_TYPE, _REPORT_TYPE, value);
				this._REPORT_TYPE = value;
			}
		}
		/// <summary>
		/// 报告时段
		/// </summary>
		public DateTime? REPORT_PERIOD
		{
			get{ return _REPORT_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.REPORT_PERIOD, _REPORT_PERIOD, value);
				this._REPORT_PERIOD = value;
			}
		}
		/// <summary>
		/// 报告内容
		/// </summary>
		public string REPORT_CONTENT
		{
			get{ return _REPORT_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.REPORT_CONTENT, _REPORT_CONTENT, value);
				this._REPORT_CONTENT = value;
			}
		}
		/// <summary>
		/// 报告时间
		/// </summary>
		public DateTime? REPORT_TIME
		{
			get{ return _REPORT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.REPORT_TIME, _REPORT_TIME, value);
				this._REPORT_TIME = value;
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
				_.REPORT_NAME,
				_.REPORT_TYPE,
				_.REPORT_PERIOD,
				_.REPORT_CONTENT,
				_.REPORT_TIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._REPORT_NAME,
				this._REPORT_TYPE,
				this._REPORT_PERIOD,
				this._REPORT_CONTENT,
				this._REPORT_TIME,
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
			public readonly static Field All = new Field("*", "LOG_REPORT");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "LOG_REPORT", "ID");
            /// <summary>
			/// 报告名称
			/// </summary>
			public readonly static Field REPORT_NAME = new Field("REPORT_NAME", "LOG_REPORT", "报告名称");
            /// <summary>
			/// 报告类型
			/// </summary>
			public readonly static Field REPORT_TYPE = new Field("REPORT_TYPE", "LOG_REPORT", "报告类型");
            /// <summary>
			/// 报告时段
			/// </summary>
			public readonly static Field REPORT_PERIOD = new Field("REPORT_PERIOD", "LOG_REPORT", "报告时段");
            /// <summary>
			/// 报告内容
			/// </summary>
			public readonly static Field REPORT_CONTENT = new Field("REPORT_CONTENT", "LOG_REPORT", "报告内容");
            /// <summary>
			/// 报告时间
			/// </summary>
			public readonly static Field REPORT_TIME = new Field("REPORT_TIME", "LOG_REPORT", "报告时间");
        }
        #endregion
	}
}