using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类WARN_EXPRESSION_DETAIL。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("WARN_EXPRESSION_DETAIL")]
	[Serializable]
	public partial class WARN_EXPRESSION_DETAIL : FwEntity
	{
		#region Model
		private decimal? _M_ID;
		private decimal? _PARENT_M_ID;
		private string _SP_NAME;
		private string _MAIN_TABLE;
		private string _MAIN_FIELD;
		private string _EXPRESSION_TYPE;
		private string _TARGET_TABLE;
		private string _TARGET_FIELD;
		private string _CONST_NUMBER;
		private string _CONST_STRING;
		private string _EXECUTE_SQL;
		private decimal? _ISDELETE;
		private DateTime? _DELETE_TIME;
		private DateTime? _CREAT_TIME;
		private decimal? _LIMIT_DAY;
		private decimal? _LIMIT_DAY_UNIT;
		private DateTime? _CHECK_TIME;

		/// <summary>
		/// M_ID
		/// </summary>
		public decimal? M_ID
		{
			get { return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
			}
		}
		/// <summary>
		/// 监督点ID
		/// </summary>
		public decimal? PARENT_M_ID
		{
			get { return _PARENT_M_ID; }
			set
			{
				this.OnPropertyValueChange(_.PARENT_M_ID, _PARENT_M_ID, value);
				this._PARENT_M_ID = value;
			}
		}
		/// <summary>
		/// 规则名称
		/// </summary>
		public string SP_NAME
		{
			get { return _SP_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SP_NAME, _SP_NAME, value);
				this._SP_NAME = value;
			}
		}
		/// <summary>
		/// 监督字段归属表名称
		/// </summary>
		public string MAIN_TABLE
		{
			get { return _MAIN_TABLE; }
			set
			{
				this.OnPropertyValueChange(_.MAIN_TABLE, _MAIN_TABLE, value);
				this._MAIN_TABLE = value;
			}
		}
		/// <summary>
		/// 监督字段名称
		/// </summary>
		public string MAIN_FIELD
		{
			get { return _MAIN_FIELD; }
			set
			{
				this.OnPropertyValueChange(_.MAIN_FIELD, _MAIN_FIELD, value);
				this._MAIN_FIELD = value;
			}
		}
		/// <summary>
		/// 表达式类型
		/// </summary>
		public string EXPRESSION_TYPE
		{
			get { return _EXPRESSION_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.EXPRESSION_TYPE, _EXPRESSION_TYPE, value);
				this._EXPRESSION_TYPE = value;
			}
		}
		/// <summary>
		/// 比较字段表名称
		/// </summary>
		public string TARGET_TABLE
		{
			get { return _TARGET_TABLE; }
			set
			{
				this.OnPropertyValueChange(_.TARGET_TABLE, _TARGET_TABLE, value);
				this._TARGET_TABLE = value;
			}
		}
		/// <summary>
		/// 比较字段名称
		/// </summary>
		public string TARGET_FIELD
		{
			get { return _TARGET_FIELD; }
			set
			{
				this.OnPropertyValueChange(_.TARGET_FIELD, _TARGET_FIELD, value);
				this._TARGET_FIELD = value;
			}
		}
		/// <summary>
		/// 常量数值，数组用[1,2]格式
		/// </summary>
		public string CONST_NUMBER
		{
			get { return _CONST_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.CONST_NUMBER, _CONST_NUMBER, value);
				this._CONST_NUMBER = value;
			}
		}
		/// <summary>
		/// 常量文本，数组用[&quot;a&quot;,&quot;b&quot;]格式
		/// </summary>
		public string CONST_STRING
		{
			get { return _CONST_STRING; }
			set
			{
				this.OnPropertyValueChange(_.CONST_STRING, _CONST_STRING, value);
				this._CONST_STRING = value;
			}
		}
		/// <summary>
		/// 直接执行SQL语句
		/// </summary>
		public string EXECUTE_SQL
		{
			get { return _EXECUTE_SQL; }
			set
			{
				this.OnPropertyValueChange(_.EXECUTE_SQL, _EXECUTE_SQL, value);
				this._EXECUTE_SQL = value;
			}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public decimal? ISDELETE
		{
			get { return _ISDELETE; }
			set
			{
				this.OnPropertyValueChange(_.ISDELETE, _ISDELETE, value);
				this._ISDELETE = value;
			}
		}
		/// <summary>
		/// 删除时间
		/// </summary>
		public DateTime? DELETE_TIME
		{
			get { return _DELETE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.DELETE_TIME, _DELETE_TIME, value);
				this._DELETE_TIME = value;
			}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime? CREAT_TIME
		{
			get { return _CREAT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREAT_TIME, _CREAT_TIME, value);
				this._CREAT_TIME = value;
			}
		}
		/// <summary>
		/// 办理时限（天）
		/// </summary>
		public decimal? LIMIT_DAY
		{
			get { return _LIMIT_DAY; }
			set
			{
				this.OnPropertyValueChange(_.LIMIT_DAY, _LIMIT_DAY, value);
				this._LIMIT_DAY = value;
			}
		}
		/// <summary>
		/// 办理时限（单位） 1:日历日 2：工作日
		/// </summary>
		public decimal? LIMIT_DAY_UNIT
		{
			get { return _LIMIT_DAY_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.LIMIT_DAY_UNIT, _LIMIT_DAY_UNIT, value);
				this._LIMIT_DAY_UNIT = value;
			}
		}
		/// <summary>
		/// 最后一次检测时间
		/// </summary>
		public DateTime? CHECK_TIME
		{
			get { return _CHECK_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CHECK_TIME, _CHECK_TIME, value);
				this._CHECK_TIME = value;
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
				_.M_ID,
			};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.M_ID,
				_.PARENT_M_ID,
				_.SP_NAME,
				_.MAIN_TABLE,
				_.MAIN_FIELD,
				_.EXPRESSION_TYPE,
				_.TARGET_TABLE,
				_.TARGET_FIELD,
				_.CONST_NUMBER,
				_.CONST_STRING,
				_.EXECUTE_SQL,
				_.ISDELETE,
				_.DELETE_TIME,
				_.CREAT_TIME,
				_.LIMIT_DAY,
				_.LIMIT_DAY_UNIT,
				_.CHECK_TIME,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._M_ID,
				this._PARENT_M_ID,
				this._SP_NAME,
				this._MAIN_TABLE,
				this._MAIN_FIELD,
				this._EXPRESSION_TYPE,
				this._TARGET_TABLE,
				this._TARGET_FIELD,
				this._CONST_NUMBER,
				this._CONST_STRING,
				this._EXECUTE_SQL,
				this._ISDELETE,
				this._DELETE_TIME,
				this._CREAT_TIME,
				this._LIMIT_DAY,
				this._LIMIT_DAY_UNIT,
				this._CHECK_TIME,
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
			public readonly static Field All = new Field("*", "WARN_EXPRESSION_DETAIL");
			/// <summary>
			/// M_ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "WARN_EXPRESSION_DETAIL", "M_ID");
			/// <summary>
			/// 监督点ID
			/// </summary>
			public readonly static Field PARENT_M_ID = new Field("PARENT_M_ID", "WARN_EXPRESSION_DETAIL", "监督点ID");
			/// <summary>
			/// 规则名称
			/// </summary>
			public readonly static Field SP_NAME = new Field("SP_NAME", "WARN_EXPRESSION_DETAIL", "规则名称");
			/// <summary>
			/// 监督字段归属表名称
			/// </summary>
			public readonly static Field MAIN_TABLE = new Field("MAIN_TABLE", "WARN_EXPRESSION_DETAIL", "监督字段归属表名称");
			/// <summary>
			/// 监督字段名称
			/// </summary>
			public readonly static Field MAIN_FIELD = new Field("MAIN_FIELD", "WARN_EXPRESSION_DETAIL", "监督字段名称");
			/// <summary>
			/// 表达式类型
			/// </summary>
			public readonly static Field EXPRESSION_TYPE = new Field("EXPRESSION_TYPE", "WARN_EXPRESSION_DETAIL", "表达式类型");
			/// <summary>
			/// 比较字段表名称
			/// </summary>
			public readonly static Field TARGET_TABLE = new Field("TARGET_TABLE", "WARN_EXPRESSION_DETAIL", "比较字段表名称");
			/// <summary>
			/// 比较字段名称
			/// </summary>
			public readonly static Field TARGET_FIELD = new Field("TARGET_FIELD", "WARN_EXPRESSION_DETAIL", "比较字段名称");
			/// <summary>
			/// 常量数值，数组用[1,2]格式
			/// </summary>
			public readonly static Field CONST_NUMBER = new Field("CONST_NUMBER", "WARN_EXPRESSION_DETAIL", "常量数值，数组用[1,2]格式");
			/// <summary>
			/// 常量文本，数组用[&quot;a&quot;,&quot;b&quot;]格式
			/// </summary>
			public readonly static Field CONST_STRING = new Field("CONST_STRING", "WARN_EXPRESSION_DETAIL", "常量文本，数组用[&quot;a&quot;,&quot;b&quot;]格式");
			/// <summary>
			/// 直接执行SQL语句
			/// </summary>
			public readonly static Field EXECUTE_SQL = new Field("EXECUTE_SQL", "WARN_EXPRESSION_DETAIL", "直接执行SQL语句");
			/// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field ISDELETE = new Field("ISDELETE", "WARN_EXPRESSION_DETAIL", "是否删除");
			/// <summary>
			/// 删除时间
			/// </summary>
			public readonly static Field DELETE_TIME = new Field("DELETE_TIME", "WARN_EXPRESSION_DETAIL", "删除时间");
			/// <summary>
			/// 添加时间
			/// </summary>
			public readonly static Field CREAT_TIME = new Field("CREAT_TIME", "WARN_EXPRESSION_DETAIL", "添加时间");
			/// <summary>
			/// 办理时限（天）
			/// </summary>
			public readonly static Field LIMIT_DAY = new Field("LIMIT_DAY", "WARN_EXPRESSION_DETAIL", "办理时限（天）");
			/// <summary>
			/// 办理时限（单位） 1:日历日 2：工作日
			/// </summary>
			public readonly static Field LIMIT_DAY_UNIT = new Field("LIMIT_DAY_UNIT", "WARN_EXPRESSION_DETAIL", "办理时限（单位） 1:日历日 2：工作日");
			/// <summary>
			/// 最后一次检测时间
			/// </summary>
			public readonly static Field CHECK_TIME = new Field("CHECK_TIME", "WARN_EXPRESSION_DETAIL", "最后一次检测时间");
		}
		#endregion
	}
}