using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_OPERNOTICE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_OPERNOTICE")]
    [Serializable]
    public partial class T_OPERNOTICE : FwEntity
    {
        #region Model
		private string _ID;
		private string _TITLE;
		private string _CONTENTS;
		private decimal? _STATUS;
		private string _ORDER_BY;
		private decimal? _CREATE_BY;
		private DateTime? _CREATE_TM;
		private string _TYPE;

		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 文章标题
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
		/// 文章内容
		/// </summary>
		public string CONTENTS
		{
			get{ return _CONTENTS; }
			set
			{
				this.OnPropertyValueChange(_.CONTENTS, _CONTENTS, value);
				this._CONTENTS = value;
			}
		}
		/// <summary>
		/// 是否启用
		/// </summary>
		public decimal? STATUS
		{
			get{ return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORDER_BY
		{
			get{ return _ORDER_BY; }
			set
			{
				this.OnPropertyValueChange(_.ORDER_BY, _ORDER_BY, value);
				this._ORDER_BY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CREATE_BY
		{
			get{ return _CREATE_BY; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_BY, _CREATE_BY, value);
				this._CREATE_BY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATE_TM
		{
			get{ return _CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TM, _CREATE_TM, value);
				this._CREATE_TM = value;
			}
		}
		/// <summary>
		/// 新闻类别
		/// </summary>
		public string TYPE
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
				_.CONTENTS,
				_.STATUS,
				_.ORDER_BY,
				_.CREATE_BY,
				_.CREATE_TM,
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
				this._CONTENTS,
				this._STATUS,
				this._ORDER_BY,
				this._CREATE_BY,
				this._CREATE_TM,
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
			public readonly static Field All = new Field("*", "T_OPERNOTICE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_OPERNOTICE", "");
            /// <summary>
			/// 文章标题
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "T_OPERNOTICE", "文章标题");
            /// <summary>
			/// 文章内容
			/// </summary>
			public readonly static Field CONTENTS = new Field("CONTENTS", "T_OPERNOTICE",DbType.AnsiString, null, "文章内容");
            /// <summary>
			/// 是否启用
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "T_OPERNOTICE", "是否启用");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDER_BY = new Field("ORDER_BY", "T_OPERNOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "T_OPERNOTICE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_OPERNOTICE", "");
            /// <summary>
			/// 新闻类别
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_OPERNOTICE", "新闻类别");
        }
        #endregion
	}
}