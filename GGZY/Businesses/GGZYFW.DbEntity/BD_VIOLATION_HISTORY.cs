using System;
using System.Data;
using Dos.ORM;
using GGZYFW.DbEntity;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类BD_VIOLATION_HISTORY。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("BD_VIOLATION_HISTORY")]
	[Serializable]
	public partial class BD_VIOLATION_HISTORY : FwEntity
	{
		#region Model
		private string _ID;
		private string _RECORD_ID;
		private string _SOURCE_FIELD;
		private string _SOURCE_VALUE;
		private string _TARGET_FIELD;
		private string _TARGET_VALUE;
		private DateTime? _CREATE_TIME;
		private decimal? _IS_DELETE;

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
		/// 违规记录ID
		/// </summary>
		public string RECORD_ID
		{
			get { return _RECORD_ID; }
			set
			{
				this.OnPropertyValueChange(_.RECORD_ID, _RECORD_ID, value);
				this._RECORD_ID = value;
			}
		}
		/// <summary>
		/// 源字段名称
		/// </summary>
		public string SOURCE_FIELD
		{
			get { return _SOURCE_FIELD; }
			set
			{
				this.OnPropertyValueChange(_.SOURCE_FIELD, _SOURCE_FIELD, value);
				this._SOURCE_FIELD = value;
			}
		}
		/// <summary>
		/// 源字段值
		/// </summary>
		public string SOURCE_VALUE
		{
			get { return _SOURCE_VALUE; }
			set
			{
				this.OnPropertyValueChange(_.SOURCE_VALUE, _SOURCE_VALUE, value);
				this._SOURCE_VALUE = value;
			}
		}
		/// <summary>
		/// 比对字段名称
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
		/// 比对字段值
		/// </summary>
		public string TARGET_VALUE
		{
			get { return _TARGET_VALUE; }
			set
			{
				this.OnPropertyValueChange(_.TARGET_VALUE, _TARGET_VALUE, value);
				this._TARGET_VALUE = value;
			}
		}
		/// <summary>
		/// 数据生成时间
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
			};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ID,
				_.RECORD_ID,
				_.SOURCE_FIELD,
				_.SOURCE_VALUE,
				_.TARGET_FIELD,
				_.TARGET_VALUE,
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
				this._RECORD_ID,
				this._SOURCE_FIELD,
				this._SOURCE_VALUE,
				this._TARGET_FIELD,
				this._TARGET_VALUE,
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
			public readonly static Field All = new Field("*", "BD_VIOLATION_HISTORY");
			/// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "BD_VIOLATION_HISTORY", "ID");
			/// <summary>
			/// 违规记录ID
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "BD_VIOLATION_HISTORY", "违规记录ID");
			/// <summary>
			/// 源字段名称
			/// </summary>
			public readonly static Field SOURCE_FIELD = new Field("SOURCE_FIELD", "BD_VIOLATION_HISTORY", "源字段名称");
			/// <summary>
			/// 源字段值
			/// </summary>
			public readonly static Field SOURCE_VALUE = new Field("SOURCE_VALUE", "BD_VIOLATION_HISTORY", "源字段值");
			/// <summary>
			/// 比对字段名称
			/// </summary>
			public readonly static Field TARGET_FIELD = new Field("TARGET_FIELD", "BD_VIOLATION_HISTORY", "比对字段名称");
			/// <summary>
			/// 比对字段值
			/// </summary>
			public readonly static Field TARGET_VALUE = new Field("TARGET_VALUE", "BD_VIOLATION_HISTORY", "比对字段值");
			/// <summary>
			/// 数据生成时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BD_VIOLATION_HISTORY", "数据生成时间");
			/// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "BD_VIOLATION_HISTORY", "是否删除");
		}
		#endregion
	}
}