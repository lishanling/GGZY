using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_DOWNLOADLIST。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_DOWNLOADLIST")]
    [Serializable]
    public partial class T_DOWNLOADLIST : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _TITLE;
		private string _SUB_TITLE;
		private string _ICON;
		private string _FILES;
		private string _REMARK;
		private decimal? _IS_PUBLIC;
		private DateTime? _CREATE_TM;
		private string _CREATE_ID;
		private decimal? _ORDER_BY;
		private decimal? _TYPE;

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
		/// 副标题
		/// </summary>
		public string SUB_TITLE
		{
			get{ return _SUB_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.SUB_TITLE, _SUB_TITLE, value);
				this._SUB_TITLE = value;
			}
		}
		/// <summary>
		/// 图标
		/// </summary>
		public string ICON
		{
			get{ return _ICON; }
			set
			{
				this.OnPropertyValueChange(_.ICON, _ICON, value);
				this._ICON = value;
			}
		}
		/// <summary>
		/// 文件
		/// </summary>
		public string FILES
		{
			get{ return _FILES; }
			set
			{
				this.OnPropertyValueChange(_.FILES, _FILES, value);
				this._FILES = value;
			}
		}
		/// <summary>
		/// 说明
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
		/// 是否发布
		/// </summary>
		public decimal? IS_PUBLIC
		{
			get{ return _IS_PUBLIC; }
			set
			{
				this.OnPropertyValueChange(_.IS_PUBLIC, _IS_PUBLIC, value);
				this._IS_PUBLIC = value;
			}
		}
		/// <summary>
		/// 发布时间
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
		/// 
		/// </summary>
		public string CREATE_ID
		{
			get{ return _CREATE_ID; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_ID, _CREATE_ID, value);
				this._CREATE_ID = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public decimal? TYPE
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
				_.SUB_TITLE,
				_.ICON,
				_.FILES,
				_.REMARK,
				_.IS_PUBLIC,
				_.CREATE_TM,
				_.CREATE_ID,
				_.ORDER_BY,
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
				this._SUB_TITLE,
				this._ICON,
				this._FILES,
				this._REMARK,
				this._IS_PUBLIC,
				this._CREATE_TM,
				this._CREATE_ID,
				this._ORDER_BY,
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
			public readonly static Field All = new Field("*", "T_DOWNLOADLIST");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_DOWNLOADLIST", "");
            /// <summary>
			/// 标题
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "T_DOWNLOADLIST", "标题");
            /// <summary>
			/// 副标题
			/// </summary>
			public readonly static Field SUB_TITLE = new Field("SUB_TITLE", "T_DOWNLOADLIST", "副标题");
            /// <summary>
			/// 图标
			/// </summary>
			public readonly static Field ICON = new Field("ICON", "T_DOWNLOADLIST", "图标");
            /// <summary>
			/// 文件
			/// </summary>
			public readonly static Field FILES = new Field("FILES", "T_DOWNLOADLIST", "文件");
            /// <summary>
			/// 说明
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_DOWNLOADLIST",DbType.AnsiString, null, "说明");
            /// <summary>
			/// 是否发布
			/// </summary>
			public readonly static Field IS_PUBLIC = new Field("IS_PUBLIC", "T_DOWNLOADLIST", "是否发布");
            /// <summary>
			/// 发布时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_DOWNLOADLIST", "发布时间");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_ID = new Field("CREATE_ID", "T_DOWNLOADLIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDER_BY = new Field("ORDER_BY", "T_DOWNLOADLIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_DOWNLOADLIST", "");
        }
        #endregion
	}
}