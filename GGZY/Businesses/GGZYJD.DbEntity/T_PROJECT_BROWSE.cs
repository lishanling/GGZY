using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_PROJECT_BROWSE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_PROJECT_BROWSE")]
    [Serializable]
    public partial class T_PROJECT_BROWSE : JdEntity
    {
        #region Model
		private string _PROJECT_CODE;
		private string _PROJECT_NAME;
		private decimal? _BROWSE_NUM;
		private string _PROJECT_CATEGORY;
		private DateTime? _CREATE_TIME;

		/// <summary>
		/// 项目编号
		/// </summary>
		public string PROJECT_CODE
		{
			get{ return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 招标项目名称
		/// </summary>
		public string PROJECT_NAME
		{
			get{ return _PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_NAME, _PROJECT_NAME, value);
				this._PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BROWSE_NUM
		{
			get{ return _BROWSE_NUM; }
			set
			{
				this.OnPropertyValueChange(_.BROWSE_NUM, _BROWSE_NUM, value);
				this._BROWSE_NUM = value;
			}
		}
		/// <summary>
		/// 行业类别
		/// </summary>
		public string PROJECT_CATEGORY
		{
			get{ return _PROJECT_CATEGORY; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CATEGORY, _PROJECT_CATEGORY, value);
				this._PROJECT_CATEGORY = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
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
				_.PROJECT_CODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.PROJECT_CODE,
				_.PROJECT_NAME,
				_.BROWSE_NUM,
				_.PROJECT_CATEGORY,
				_.CREATE_TIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PROJECT_CODE,
				this._PROJECT_NAME,
				this._BROWSE_NUM,
				this._PROJECT_CATEGORY,
				this._CREATE_TIME,
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
			public readonly static Field All = new Field("*", "T_PROJECT_BROWSE");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "T_PROJECT_BROWSE", "项目编号");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "T_PROJECT_BROWSE", "招标项目名称");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BROWSE_NUM = new Field("BROWSE_NUM", "T_PROJECT_BROWSE", "");
            /// <summary>
			/// 行业类别
			/// </summary>
			public readonly static Field PROJECT_CATEGORY = new Field("PROJECT_CATEGORY", "T_PROJECT_BROWSE", "行业类别");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_PROJECT_BROWSE", "创建时间");
        }
        #endregion
	}
}