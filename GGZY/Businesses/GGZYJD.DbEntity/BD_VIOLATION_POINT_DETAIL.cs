using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类BD_VIOLATION_POINT_DETAIL。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("BD_VIOLATION_POINT_DETAIL")]
	[Serializable]
	public partial class BD_VIOLATION_POINT_DETAIL : JdEntity
	{
		#region Model
		private decimal? _ID;
		private string _NAME;
		private string _CODE;
		private string _DESCRIPTION;
		private string _RULE_DESCRIPTION;
		private string _TENDER_PROJECT_TYPE;
		private decimal? _SCORE;
		private decimal? _POINT_TYPE;
		private string _CHECK_EXPRESSION;
		private string _RESULT_EXPRESSION;
		private decimal? _SORT;
		private decimal? _IS_ENABLE;
		private DateTime? _CREATE_TIME;
		private decimal? _IS_DELETE;

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
		/// 违规点名称
		/// </summary>
		public string NAME
		{
			get { return _NAME; }
			set
			{
				this.OnPropertyValueChange(_.NAME, _NAME, value);
				this._NAME = value;
			}
		}
		/// <summary>
		/// 违规点编码
		/// </summary>
		public string CODE
		{
			get { return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
			}
		}
		/// <summary>
		/// 违规点简介
		/// </summary>
		public string DESCRIPTION
		{
			get { return _DESCRIPTION; }
			set
			{
				this.OnPropertyValueChange(_.DESCRIPTION, _DESCRIPTION, value);
				this._DESCRIPTION = value;
			}
		}
		/// <summary>
		/// 违规点规则描述
		/// </summary>
		public string RULE_DESCRIPTION
		{
			get { return _RULE_DESCRIPTION; }
			set
			{
				this.OnPropertyValueChange(_.RULE_DESCRIPTION, _RULE_DESCRIPTION, value);
				this._RULE_DESCRIPTION = value;
			}
		}
		/// <summary>
		/// 招标项目类型
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
		/// 违规概率
		/// </summary>
		public decimal? SCORE
		{
			get { return _SCORE; }
			set
			{
				this.OnPropertyValueChange(_.SCORE, _SCORE, value);
				this._SCORE = value;
			}
		}
		/// <summary>
		/// 违规点类型(0:项目,1:主体)
		/// </summary>
		public decimal? POINT_TYPE
		{
			get { return _POINT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.POINT_TYPE, _POINT_TYPE, value);
				this._POINT_TYPE = value;
			}
		}
		/// <summary>
		/// 违规检测SQL表达式
		/// </summary>
		public string CHECK_EXPRESSION
		{
			get { return _CHECK_EXPRESSION; }
			set
			{
				this.OnPropertyValueChange(_.CHECK_EXPRESSION, _CHECK_EXPRESSION, value);
				this._CHECK_EXPRESSION = value;
			}
		}
		/// <summary>
		/// 违规结果SQL表达式
		/// </summary>
		public string RESULT_EXPRESSION
		{
			get { return _RESULT_EXPRESSION; }
			set
			{
				this.OnPropertyValueChange(_.RESULT_EXPRESSION, _RESULT_EXPRESSION, value);
				this._RESULT_EXPRESSION = value;
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
				_.NAME,
				_.CODE,
				_.DESCRIPTION,
				_.RULE_DESCRIPTION,
				_.TENDER_PROJECT_TYPE,
				_.SCORE,
				_.POINT_TYPE,
				_.CHECK_EXPRESSION,
				_.RESULT_EXPRESSION,
				_.SORT,
				_.IS_ENABLE,
				_.CREATE_TIME,
				_.IS_DELETE,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._NAME,
				this._CODE,
				this._DESCRIPTION,
				this._RULE_DESCRIPTION,
				this._TENDER_PROJECT_TYPE,
				this._SCORE,
				this._POINT_TYPE,
				this._CHECK_EXPRESSION,
				this._RESULT_EXPRESSION,
				this._SORT,
				this._IS_ENABLE,
				this._CREATE_TIME,
				this._IS_DELETE,
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
			public readonly static Field All = new Field("*", "BD_VIOLATION_POINT_DETAIL");
			/// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "BD_VIOLATION_POINT_DETAIL", "ID");
			/// <summary>
			/// 违规点名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "BD_VIOLATION_POINT_DETAIL", "违规点名称");
			/// <summary>
			/// 违规点编码
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "BD_VIOLATION_POINT_DETAIL", "违规点编码");
			/// <summary>
			/// 违规点简介
			/// </summary>
			public readonly static Field DESCRIPTION = new Field("DESCRIPTION", "BD_VIOLATION_POINT_DETAIL", DbType.AnsiString, null, "违规点简介");
			/// <summary>
			/// 违规点规则描述
			/// </summary>
			public readonly static Field RULE_DESCRIPTION = new Field("RULE_DESCRIPTION", "BD_VIOLATION_POINT_DETAIL", DbType.AnsiString, null, "违规点规则描述");
			/// <summary>
			/// 招标项目类型
			/// </summary>
			public readonly static Field TENDER_PROJECT_TYPE = new Field("TENDER_PROJECT_TYPE", "BD_VIOLATION_POINT_DETAIL", "招标项目类型");
			/// <summary>
			/// 违规概率
			/// </summary>
			public readonly static Field SCORE = new Field("SCORE", "BD_VIOLATION_POINT_DETAIL", "违规概率");
			/// <summary>
			/// 违规点类型(0:项目,1:主体)
			/// </summary>
			public readonly static Field POINT_TYPE = new Field("POINT_TYPE", "BD_VIOLATION_POINT_DETAIL", "违规点类型(0:项目,1:主体)");
			/// <summary>
			/// 违规检测SQL表达式
			/// </summary>
			public readonly static Field CHECK_EXPRESSION = new Field("CHECK_EXPRESSION", "BD_VIOLATION_POINT_DETAIL", DbType.AnsiString, null, "违规检测SQL表达式");
			/// <summary>
			/// 违规结果SQL表达式
			/// </summary>
			public readonly static Field RESULT_EXPRESSION = new Field("RESULT_EXPRESSION", "BD_VIOLATION_POINT_DETAIL", DbType.AnsiString, null, "违规结果SQL表达式");
			/// <summary>
			/// 排序
			/// </summary>
			public readonly static Field SORT = new Field("SORT", "BD_VIOLATION_POINT_DETAIL", "排序");
			/// <summary>
			/// 是否启用
			/// </summary>
			public readonly static Field IS_ENABLE = new Field("IS_ENABLE", "BD_VIOLATION_POINT_DETAIL", "是否启用");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BD_VIOLATION_POINT_DETAIL", "创建时间");
			/// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "BD_VIOLATION_POINT_DETAIL", "是否删除");
		}
		#endregion
	}
}