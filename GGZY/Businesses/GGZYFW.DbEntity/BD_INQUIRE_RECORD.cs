using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类BD_INQUIRE_RECORD。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("BD_INQUIRE_RECORD")]
	[Serializable]
	public partial class BD_INQUIRE_RECORD : FwEntity
	{
		#region Model
		private string _ID;
		private string _VIOLATION_RECORD_ID;
		private decimal? _STATE;
		private string _DESCRIPTION;
		private string _GUIDS;
		private decimal? _OPERATION_USER;
		private decimal? _OPERATION_DEPT;
		private DateTime? _OPERATION_TIME;
		private DateTime? _CREATE_TIME;
		private decimal? _IS_DELETE;
		private decimal? _POINT_TYPE;

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
		/// 违规行为记录ID
		/// </summary>
		public string VIOLATION_RECORD_ID
		{
			get { return _VIOLATION_RECORD_ID; }
			set
			{
				this.OnPropertyValueChange(_.VIOLATION_RECORD_ID, _VIOLATION_RECORD_ID, value);
				this._VIOLATION_RECORD_ID = value;
			}
		}
		/// <summary>
		/// 调查结果状态 0:未发现问题  1：发现问题并处理
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
		/// 处理结果记录
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
		/// 相关附件GUID
		/// </summary>
		public string GUIDS
		{
			get { return _GUIDS; }
			set
			{
				this.OnPropertyValueChange(_.GUIDS, _GUIDS, value);
				this._GUIDS = value;
			}
		}
		/// <summary>
		/// 处理人
		/// </summary>
		public decimal? OPERATION_USER
		{
			get { return _OPERATION_USER; }
			set
			{
				this.OnPropertyValueChange(_.OPERATION_USER, _OPERATION_USER, value);
				this._OPERATION_USER = value;
			}
		}
		/// <summary>
		/// 处理人部门ID
		/// </summary>
		public decimal? OPERATION_DEPT
		{
			get { return _OPERATION_DEPT; }
			set
			{
				this.OnPropertyValueChange(_.OPERATION_DEPT, _OPERATION_DEPT, value);
				this._OPERATION_DEPT = value;
			}
		}
		/// <summary>
		/// 处理时间
		/// </summary>
		public DateTime? OPERATION_TIME
		{
			get { return _OPERATION_TIME; }
			set
			{
				this.OnPropertyValueChange(_.OPERATION_TIME, _OPERATION_TIME, value);
				this._OPERATION_TIME = value;
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
		/// 疑似违规行为类型 0：项目 1：主体
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
				_.VIOLATION_RECORD_ID,
				_.STATE,
				_.DESCRIPTION,
				_.GUIDS,
				_.OPERATION_USER,
				_.OPERATION_DEPT,
				_.OPERATION_TIME,
				_.CREATE_TIME,
				_.IS_DELETE,
				_.POINT_TYPE,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._VIOLATION_RECORD_ID,
				this._STATE,
				this._DESCRIPTION,
				this._GUIDS,
				this._OPERATION_USER,
				this._OPERATION_DEPT,
				this._OPERATION_TIME,
				this._CREATE_TIME,
				this._IS_DELETE,
				this._POINT_TYPE,
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
			public readonly static Field All = new Field("*", "BD_INQUIRE_RECORD");
			/// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "BD_INQUIRE_RECORD", "ID");
			/// <summary>
			/// 违规行为记录ID
			/// </summary>
			public readonly static Field VIOLATION_RECORD_ID = new Field("VIOLATION_RECORD_ID", "BD_INQUIRE_RECORD", "违规行为记录ID");
			/// <summary>
			/// 调查结果状态 0:未发现问题  1：发现问题并处理
			/// </summary>
			public readonly static Field STATE = new Field("STATE", "BD_INQUIRE_RECORD", "调查结果状态 0:未发现问题  1：发现问题并处理");
			/// <summary>
			/// 处理结果记录
			/// </summary>
			public readonly static Field DESCRIPTION = new Field("DESCRIPTION", "BD_INQUIRE_RECORD", DbType.AnsiString, null, "处理结果记录");
			/// <summary>
			/// 相关附件GUID
			/// </summary>
			public readonly static Field GUIDS = new Field("GUIDS", "BD_INQUIRE_RECORD", DbType.AnsiString, null, "相关附件GUID");
			/// <summary>
			/// 处理人
			/// </summary>
			public readonly static Field OPERATION_USER = new Field("OPERATION_USER", "BD_INQUIRE_RECORD", "处理人");
			/// <summary>
			/// 处理人部门ID
			/// </summary>
			public readonly static Field OPERATION_DEPT = new Field("OPERATION_DEPT", "BD_INQUIRE_RECORD", "处理人部门ID");
			/// <summary>
			/// 处理时间
			/// </summary>
			public readonly static Field OPERATION_TIME = new Field("OPERATION_TIME", "BD_INQUIRE_RECORD", "处理时间");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BD_INQUIRE_RECORD", "创建时间");
			/// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "BD_INQUIRE_RECORD", "是否删除");
			/// <summary>
			/// 疑似违规行为类型 0：项目 1：主体
			/// </summary>
			public readonly static Field POINT_TYPE = new Field("POINT_TYPE", "BD_INQUIRE_RECORD", "疑似违规行为类型 0：项目 1：主体");
		}
		#endregion
	}
}