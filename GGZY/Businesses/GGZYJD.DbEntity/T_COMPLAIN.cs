using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_COMPLAIN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_COMPLAIN")]
    [Serializable]
    public partial class T_COMPLAIN : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _TITLE;
		private string _TYPE;
		private string _SOURCES;
		private DateTime? _TM;
		private decimal? _USER_ID;
		private string _CONTENTS;
		private string _AIDS;
		private DateTime? _CREATE_TM;

		/// <summary>
		/// 
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
		/// 类型
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
		/// <summary>
		/// 来源
		/// </summary>
		public string SOURCES
		{
			get{ return _SOURCES; }
			set
			{
				this.OnPropertyValueChange(_.SOURCES, _SOURCES, value);
				this._SOURCES = value;
			}
		}
		/// <summary>
		/// 发布日期
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
		/// 发布人员ID
		/// </summary>
		public decimal? USER_ID
		{
			get{ return _USER_ID; }
			set
			{
				this.OnPropertyValueChange(_.USER_ID, _USER_ID, value);
				this._USER_ID = value;
			}
		}
		/// <summary>
		/// 内容
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
		/// 附件
		/// </summary>
		public string AIDS
		{
			get{ return _AIDS; }
			set
			{
				this.OnPropertyValueChange(_.AIDS, _AIDS, value);
				this._AIDS = value;
			}
		}
		/// <summary>
		/// 创建日期
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
				_.TYPE,
				_.SOURCES,
				_.TM,
				_.USER_ID,
				_.CONTENTS,
				_.AIDS,
				_.CREATE_TM,
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
				this._TYPE,
				this._SOURCES,
				this._TM,
				this._USER_ID,
				this._CONTENTS,
				this._AIDS,
				this._CREATE_TM,
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
			public readonly static Field All = new Field("*", "T_COMPLAIN");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_COMPLAIN", "");
            /// <summary>
			/// 标题
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "T_COMPLAIN", "标题");
            /// <summary>
			/// 类型
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_COMPLAIN", "类型");
            /// <summary>
			/// 来源
			/// </summary>
			public readonly static Field SOURCES = new Field("SOURCES", "T_COMPLAIN", "来源");
            /// <summary>
			/// 发布日期
			/// </summary>
			public readonly static Field TM = new Field("TM", "T_COMPLAIN", "发布日期");
            /// <summary>
			/// 发布人员ID
			/// </summary>
			public readonly static Field USER_ID = new Field("USER_ID", "T_COMPLAIN", "发布人员ID");
            /// <summary>
			/// 内容
			/// </summary>
			public readonly static Field CONTENTS = new Field("CONTENTS", "T_COMPLAIN", "内容");
            /// <summary>
			/// 附件
			/// </summary>
			public readonly static Field AIDS = new Field("AIDS", "T_COMPLAIN", "附件");
            /// <summary>
			/// 创建日期
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_COMPLAIN", "创建日期");
        }
        #endregion
	}
}