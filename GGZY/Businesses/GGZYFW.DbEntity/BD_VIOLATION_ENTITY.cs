using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类BD_VIOLATION_ENTITY。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("BD_VIOLATION_ENTITY")]
	[Serializable]
	public partial class BD_VIOLATION_ENTITY : FwEntity
	{
		#region Model
		private string _ID;
		private decimal? _POINT_ID;
		private string _POINT_CODE;
		private string _POINT_NAME;
		private string _ENTITY_NAME;
		private string _ENTITY_CODE;
		private string _AREA_CODE;
		private DateTime? _CHECK_TIME;
		private string _RESULT_MSG;
		private string _RESULT_DATA;
		private decimal? _SCORE;
		private decimal? _STATE;
		private decimal? _TRANSFER_STATE;
		private DateTime? _CREATE_TIME;
		private decimal? _IS_DELETE;
		private decimal? _ENTITY_TYPE;

		/// <summary>
		/// ID
		/// </summary>
		public string ID
		{
			get { return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 疑似违规点ID
		/// </summary>
		public decimal? POINT_ID
		{
			get { return _POINT_ID; }
			set
			{
				this.OnPropertyValueChange(_.POINT_ID, _POINT_ID, value);
				this._POINT_ID = value;
			}
		}
		/// <summary>
		/// 疑似违规点编码
		/// </summary>
		public string POINT_CODE
		{
			get { return _POINT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.POINT_CODE, _POINT_CODE, value);
				this._POINT_CODE = value;
			}
		}
		/// <summary>
		/// 疑似违规点名称
		/// </summary>
		public string POINT_NAME
		{
			get { return _POINT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.POINT_NAME, _POINT_NAME, value);
				this._POINT_NAME = value;
			}
		}
		/// <summary>
		/// 主体名称
		/// </summary>
		public string ENTITY_NAME
		{
			get { return _ENTITY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.ENTITY_NAME, _ENTITY_NAME, value);
				this._ENTITY_NAME = value;
			}
		}
		/// <summary>
		/// 主体统一社会信用代码
		/// </summary>
		public string ENTITY_CODE
		{
			get { return _ENTITY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.ENTITY_CODE, _ENTITY_CODE, value);
				this._ENTITY_CODE = value;
			}
		}
		/// <summary>
		/// 所在地区
		/// </summary>
		public string AREA_CODE
		{
			get { return _AREA_CODE; }
			set
			{
				this.OnPropertyValueChange(_.AREA_CODE, _AREA_CODE, value);
				this._AREA_CODE = value;
			}
		}
		/// <summary>
		/// 检测时间
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
		/// <summary>
		/// 分析结果
		/// </summary>
		public string RESULT_MSG
		{
			get { return _RESULT_MSG; }
			set
			{
				this.OnPropertyValueChange(_.RESULT_MSG, _RESULT_MSG, value);
				this._RESULT_MSG = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RESULT_DATA
		{
			get { return _RESULT_DATA; }
			set
			{
				this.OnPropertyValueChange(_.RESULT_DATA, _RESULT_DATA, value);
				this._RESULT_DATA = value;
			}
		}
		/// <summary>
		/// 违规率
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
		/// 调查状态 0:待调查 1：已调查
		/// </summary>
		public decimal? STATE
		{
			get { return _STATE; }
			set
			{
				this.OnPropertyValueChange(_.STATE, _STATE, value);
				this._STATE = value;
			}
		}
		/// <summary>
		/// 移送状态
		/// </summary>
		public decimal? TRANSFER_STATE
		{
			get { return _TRANSFER_STATE; }
			set
			{
				this.OnPropertyValueChange(_.TRANSFER_STATE, _TRANSFER_STATE, value);
				this._TRANSFER_STATE = value;
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
		/// <summary>
		/// 主体类型(1:招标人 2：代理机构 3：投标人)
		/// </summary>
		public decimal? ENTITY_TYPE
		{
			get { return _ENTITY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.ENTITY_TYPE, _ENTITY_TYPE, value);
				this._ENTITY_TYPE = value;
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
				_.POINT_ID,
				_.POINT_CODE,
				_.POINT_NAME,
				_.ENTITY_NAME,
				_.ENTITY_CODE,
				_.AREA_CODE,
				_.CHECK_TIME,
				_.RESULT_MSG,
				_.RESULT_DATA,
				_.SCORE,
				_.STATE,
				_.TRANSFER_STATE,
				_.CREATE_TIME,
				_.IS_DELETE,
				_.ENTITY_TYPE,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._POINT_ID,
				this._POINT_CODE,
				this._POINT_NAME,
				this._ENTITY_NAME,
				this._ENTITY_CODE,
				this._AREA_CODE,
				this._CHECK_TIME,
				this._RESULT_MSG,
				this._RESULT_DATA,
				this._SCORE,
				this._STATE,
				this._TRANSFER_STATE,
				this._CREATE_TIME,
				this._IS_DELETE,
				this._ENTITY_TYPE,
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
			public readonly static Field All = new Field("*", "BD_VIOLATION_ENTITY");
			/// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "BD_VIOLATION_ENTITY", "ID");
			/// <summary>
			/// 疑似违规点ID
			/// </summary>
			public readonly static Field POINT_ID = new Field("POINT_ID", "BD_VIOLATION_ENTITY", "疑似违规点ID");
			/// <summary>
			/// 疑似违规点编码
			/// </summary>
			public readonly static Field POINT_CODE = new Field("POINT_CODE", "BD_VIOLATION_ENTITY", "疑似违规点编码");
			/// <summary>
			/// 疑似违规点名称
			/// </summary>
			public readonly static Field POINT_NAME = new Field("POINT_NAME", "BD_VIOLATION_ENTITY", "疑似违规点名称");
			/// <summary>
			/// 主体名称
			/// </summary>
			public readonly static Field ENTITY_NAME = new Field("ENTITY_NAME", "BD_VIOLATION_ENTITY", "主体名称");
			/// <summary>
			/// 主体统一社会信用代码
			/// </summary>
			public readonly static Field ENTITY_CODE = new Field("ENTITY_CODE", "BD_VIOLATION_ENTITY", "主体统一社会信用代码");
			/// <summary>
			/// 所在地区
			/// </summary>
			public readonly static Field AREA_CODE = new Field("AREA_CODE", "BD_VIOLATION_ENTITY", "所在地区");
			/// <summary>
			/// 检测时间
			/// </summary>
			public readonly static Field CHECK_TIME = new Field("CHECK_TIME", "BD_VIOLATION_ENTITY", "检测时间");
			/// <summary>
			/// 分析结果
			/// </summary>
			public readonly static Field RESULT_MSG = new Field("RESULT_MSG", "BD_VIOLATION_ENTITY", DbType.AnsiString, null, "分析结果");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RESULT_DATA = new Field("RESULT_DATA", "BD_VIOLATION_ENTITY", DbType.AnsiString, null, "");
			/// <summary>
			/// 违规率
			/// </summary>
			public readonly static Field SCORE = new Field("SCORE", "BD_VIOLATION_ENTITY", "违规率");
			/// <summary>
			/// 调查状态 0:待调查 1：已调查
			/// </summary>
			public readonly static Field STATE = new Field("STATE", "BD_VIOLATION_ENTITY", "调查状态 0:待调查 1：已调查");
			/// <summary>
			/// 移送状态
			/// </summary>
			public readonly static Field TRANSFER_STATE = new Field("TRANSFER_STATE", "BD_VIOLATION_ENTITY", "移送状态");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BD_VIOLATION_ENTITY", "创建时间");
			/// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "BD_VIOLATION_ENTITY", "是否删除");
			/// <summary>
			/// 主体类型(1:招标人 2：代理机构 3：投标人)
			/// </summary>
			public readonly static Field ENTITY_TYPE = new Field("ENTITY_TYPE", "BD_VIOLATION_ENTITY", "主体类型(1:招标人 2：代理机构 3：投标人)");
		}
		#endregion
	}
}