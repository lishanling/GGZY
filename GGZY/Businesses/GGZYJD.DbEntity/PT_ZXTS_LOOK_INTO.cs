using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类PT_ZXTS_LOOK_INTO。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("PT_ZXTS_LOOK_INTO")]
	[Serializable]
	public partial class PT_ZXTS_LOOK_INTO : JdEntity
	{
		#region Model
		private string _ID;
		private string _TS_CODE;
		private string _LOOK_CONTENT;
		private string _LOOK_AIDS;
		private DateTime? _LOOK_TIME;
		private string _CREATEDBY;
		private DateTime? _CREATEDTIME;
		private string _UPDATEDBY;
		private DateTime? _UPDATEDTIME;

		/// <summary>
		/// 主键，唯一标识
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
		/// 投诉编号
		/// </summary>
		public string TS_CODE
		{
			get { return _TS_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TS_CODE, _TS_CODE, value);
				this._TS_CODE = value;
			}
		}
		/// <summary>
		/// 调查内容
		/// </summary>
		public string LOOK_CONTENT
		{
			get { return _LOOK_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.LOOK_CONTENT, _LOOK_CONTENT, value);
				this._LOOK_CONTENT = value;
			}
		}
		/// <summary>
		/// 附件集合
		/// </summary>
		public string LOOK_AIDS
		{
			get { return _LOOK_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.LOOK_AIDS, _LOOK_AIDS, value);
				this._LOOK_AIDS = value;
			}
		}
		/// <summary>
		/// 调查发起时间
		/// </summary>
		public DateTime? LOOK_TIME
		{
			get { return _LOOK_TIME; }
			set
			{
				this.OnPropertyValueChange(_.LOOK_TIME, _LOOK_TIME, value);
				this._LOOK_TIME = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public string CREATEDBY
		{
			get { return _CREATEDBY; }
			set
			{
				this.OnPropertyValueChange(_.CREATEDBY, _CREATEDBY, value);
				this._CREATEDBY = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATEDTIME
		{
			get { return _CREATEDTIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATEDTIME, _CREATEDTIME, value);
				this._CREATEDTIME = value;
			}
		}
		/// <summary>
		/// 修改人
		/// </summary>
		public string UPDATEDBY
		{
			get { return _UPDATEDBY; }
			set
			{
				this.OnPropertyValueChange(_.UPDATEDBY, _UPDATEDBY, value);
				this._UPDATEDBY = value;
			}
		}
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime? UPDATEDTIME
		{
			get { return _UPDATEDTIME; }
			set
			{
				this.OnPropertyValueChange(_.UPDATEDTIME, _UPDATEDTIME, value);
				this._UPDATEDTIME = value;
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
				_.TS_CODE,
				_.LOOK_CONTENT,
				_.LOOK_AIDS,
				_.LOOK_TIME,
				_.CREATEDBY,
				_.CREATEDTIME,
				_.UPDATEDBY,
				_.UPDATEDTIME,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._TS_CODE,
				this._LOOK_CONTENT,
				this._LOOK_AIDS,
				this._LOOK_TIME,
				this._CREATEDBY,
				this._CREATEDTIME,
				this._UPDATEDBY,
				this._UPDATEDTIME,
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
			public readonly static Field All = new Field("*", "PT_ZXTS_LOOK_INTO");
			/// <summary>
			/// 主键，唯一标识
			/// </summary>
			public readonly static Field ID = new Field("ID", "PT_ZXTS_LOOK_INTO", "主键，唯一标识");
			/// <summary>
			/// 投诉编号
			/// </summary>
			public readonly static Field TS_CODE = new Field("TS_CODE", "PT_ZXTS_LOOK_INTO", "投诉编号");
			/// <summary>
			/// 调查内容
			/// </summary>
			public readonly static Field LOOK_CONTENT = new Field("LOOK_CONTENT", "PT_ZXTS_LOOK_INTO", DbType.AnsiString, null, "调查内容");
			/// <summary>
			/// 附件集合
			/// </summary>
			public readonly static Field LOOK_AIDS = new Field("LOOK_AIDS", "PT_ZXTS_LOOK_INTO", "附件集合");
			/// <summary>
			/// 调查发起时间
			/// </summary>
			public readonly static Field LOOK_TIME = new Field("LOOK_TIME", "PT_ZXTS_LOOK_INTO", "调查发起时间");
			/// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATEDBY = new Field("CREATEDBY", "PT_ZXTS_LOOK_INTO", "创建人");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATEDTIME = new Field("CREATEDTIME", "PT_ZXTS_LOOK_INTO", "创建时间");
			/// <summary>
			/// 修改人
			/// </summary>
			public readonly static Field UPDATEDBY = new Field("UPDATEDBY", "PT_ZXTS_LOOK_INTO", "修改人");
			/// <summary>
			/// 修改时间
			/// </summary>
			public readonly static Field UPDATEDTIME = new Field("UPDATEDTIME", "PT_ZXTS_LOOK_INTO", "修改时间");
		}
		#endregion
	}
}