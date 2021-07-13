using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类BD_VIOLATION_POINT。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("BD_VIOLATION_POINT")]
	[Serializable]
	public partial class BD_VIOLATION_POINT : JdEntity
	{
		#region Model
		private decimal? _ID;
		private string _CATEGORY_NAME;
		private string _CATEGORY_CODE;
		private decimal? _PARENT_ID;
		private string _TENDER_PROJECT_TYPE;
		private decimal? _IS_ENABLE;
		private decimal? _SORT;
		private decimal? _IS_DELETE;
		private DateTime? _CREATE_TIME;

		/// <summary>
		/// ID
		/// </summary>
		public decimal? ID
		{
			get { return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 类别名称
		/// </summary>
		public string CATEGORY_NAME
		{
			get { return _CATEGORY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CATEGORY_NAME, _CATEGORY_NAME, value);
				this._CATEGORY_NAME = value;
			}
		}
		/// <summary>
		/// 类别编码
		/// </summary>
		public string CATEGORY_CODE
		{
			get { return _CATEGORY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CATEGORY_CODE, _CATEGORY_CODE, value);
				this._CATEGORY_CODE = value;
			}
		}
		/// <summary>
		/// 上级类别ID，根目录则设置为 0
		/// </summary>
		public decimal? PARENT_ID
		{
			get { return _PARENT_ID; }
			set
			{
				this.OnPropertyValueChange(_.PARENT_ID, _PARENT_ID, value);
				this._PARENT_ID = value;
			}
		}
		/// <summary>
		/// 招标项目类型/行业类型
		/// </summary>
		public string TENDER_PROJECT_TYPE
		{
			get { return _TENDER_PROJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_TYPE, _TENDER_PROJECT_TYPE, value);
				this._TENDER_PROJECT_TYPE = value;
			}
		}
		/// <summary>
		/// 是否启用
		/// </summary>
		public decimal? IS_ENABLE
		{
			get { return _IS_ENABLE; }
			set
			{
				this.OnPropertyValueChange(_.IS_ENABLE, _IS_ENABLE, value);
				this._IS_ENABLE = value;
			}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public decimal? SORT
		{
			get { return _SORT; }
			set
			{
				this.OnPropertyValueChange(_.SORT, _SORT, value);
				this._SORT = value;
			}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public decimal? IS_DELETE
		{
			get { return _IS_DELETE; }
			set
			{
				this.OnPropertyValueChange(_.IS_DELETE, _IS_DELETE, value);
				this._IS_DELETE = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get { return _CREATE_TIME; }
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
				_.CATEGORY_NAME,
				_.CATEGORY_CODE,
				_.PARENT_ID,
				_.TENDER_PROJECT_TYPE,
				_.IS_ENABLE,
				_.SORT,
				_.IS_DELETE,
				_.CREATE_TIME,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._CATEGORY_NAME,
				this._CATEGORY_CODE,
				this._PARENT_ID,
				this._TENDER_PROJECT_TYPE,
				this._IS_ENABLE,
				this._SORT,
				this._IS_DELETE,
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
			public readonly static Field All = new Field("*", "BD_VIOLATION_POINT");
			/// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "BD_VIOLATION_POINT", "ID");
			/// <summary>
			/// 类别名称
			/// </summary>
			public readonly static Field CATEGORY_NAME = new Field("CATEGORY_NAME", "BD_VIOLATION_POINT", "类别名称");
			/// <summary>
			/// 类别编码
			/// </summary>
			public readonly static Field CATEGORY_CODE = new Field("CATEGORY_CODE", "BD_VIOLATION_POINT", "类别编码");
			/// <summary>
			/// 上级类别ID，根目录则设置为 0
			/// </summary>
			public readonly static Field PARENT_ID = new Field("PARENT_ID", "BD_VIOLATION_POINT", "上级类别ID，根目录则设置为 0");
			/// <summary>
			/// 招标项目类型/行业类型
			/// </summary>
			public readonly static Field TENDER_PROJECT_TYPE = new Field("TENDER_PROJECT_TYPE", "BD_VIOLATION_POINT", "招标项目类型/行业类型");
			/// <summary>
			/// 是否启用
			/// </summary>
			public readonly static Field IS_ENABLE = new Field("IS_ENABLE", "BD_VIOLATION_POINT", "是否启用");
			/// <summary>
			/// 排序
			/// </summary>
			public readonly static Field SORT = new Field("SORT", "BD_VIOLATION_POINT", "排序");
			/// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "BD_VIOLATION_POINT", "是否删除");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BD_VIOLATION_POINT", "创建时间");
		}
		#endregion
	}
}