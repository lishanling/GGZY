using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类BD_VIOLATION_BASIC。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("BD_VIOLATION_BASIC")]
	[Serializable]
	public partial class BD_VIOLATION_BASIC : JdEntity
	{
		#region Model
		private string _ID;
		private string _NAME;
		private string _CODE;
		private decimal? _SCORE;
		private string _REMARK;
		private decimal? _RECORD_TYPE;
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
		/// 名称
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
		/// 招标项目编码/主体统一社会信用代码
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
		/// 综合违规率
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
		/// 备注
		/// </summary>
		public string REMARK
		{
			get { return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
			}
		}
		/// <summary>
		/// 类型 0：项目 1：主体
		/// </summary>
		public decimal? RECORD_TYPE
		{
			get { return _RECORD_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.RECORD_TYPE, _RECORD_TYPE, value);
				this._RECORD_TYPE = value;
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
				_.SCORE,
				_.REMARK,
				_.RECORD_TYPE,
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
				this._SCORE,
				this._REMARK,
				this._RECORD_TYPE,
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
			public readonly static Field All = new Field("*", "BD_VIOLATION_BASIC");
			/// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "BD_VIOLATION_BASIC", "ID");
			/// <summary>
			/// 名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "BD_VIOLATION_BASIC", "名称");
			/// <summary>
			/// 招标项目编码/主体统一社会信用代码
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "BD_VIOLATION_BASIC", "招标项目编码/主体统一社会信用代码");
			/// <summary>
			/// 综合违规率
			/// </summary>
			public readonly static Field SCORE = new Field("SCORE", "BD_VIOLATION_BASIC", "综合违规率");
			/// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "BD_VIOLATION_BASIC", DbType.AnsiString, null, "备注");
			/// <summary>
			/// 类型 0：项目 1：主体
			/// </summary>
			public readonly static Field RECORD_TYPE = new Field("RECORD_TYPE", "BD_VIOLATION_BASIC", "类型 0：项目 1：主体");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BD_VIOLATION_BASIC", "创建时间");
			/// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "BD_VIOLATION_BASIC", "是否删除");
		}
		#endregion
	}
}