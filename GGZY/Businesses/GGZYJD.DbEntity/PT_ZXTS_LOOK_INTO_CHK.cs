using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类PT_ZXTS_LOOK_INTO_CHK。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("PT_ZXTS_LOOK_INTO_CHK")]
	[Serializable]
	public partial class PT_ZXTS_LOOK_INTO_CHK : JdEntity
	{
		#region Model
		private string _ID;
		private string _TS_CODE;
		private string _CX_CODE;
		private DateTime? _EXPIREDTIME;
		private string _CREATEDBY;
		private DateTime? _CREATEDTIME;
		private string _UPDATEDBY;
		private DateTime? _UPDATEDTIME;
		private string _COMPLAINT_PUBLISH_ID;

		/// <summary>
		/// id
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
		/// 查询码
		/// </summary>
		public string CX_CODE
		{
			get { return _CX_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CX_CODE, _CX_CODE, value);
				this._CX_CODE = value;
			}
		}
		/// <summary>
		/// 过期时间
		/// </summary>
		public DateTime? EXPIREDTIME
		{
			get { return _EXPIREDTIME; }
			set
			{
				this.OnPropertyValueChange(_.EXPIREDTIME, _EXPIREDTIME, value);
				this._EXPIREDTIME = value;
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
		/// <summary>
		/// 投诉发布信息id
		/// </summary>
		public string COMPLAINT_PUBLISH_ID
		{
			get { return _COMPLAINT_PUBLISH_ID; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_PUBLISH_ID, _COMPLAINT_PUBLISH_ID, value);
				this._COMPLAINT_PUBLISH_ID = value;
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
				_.CX_CODE,
				_.EXPIREDTIME,
				_.CREATEDBY,
				_.CREATEDTIME,
				_.UPDATEDBY,
				_.UPDATEDTIME,
				_.COMPLAINT_PUBLISH_ID,
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
				this._CX_CODE,
				this._EXPIREDTIME,
				this._CREATEDBY,
				this._CREATEDTIME,
				this._UPDATEDBY,
				this._UPDATEDTIME,
				this._COMPLAINT_PUBLISH_ID,
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
			public readonly static Field All = new Field("*", "PT_ZXTS_LOOK_INTO_CHK");
			/// <summary>
			/// id
			/// </summary>
			public readonly static Field ID = new Field("ID", "PT_ZXTS_LOOK_INTO_CHK", "id");
			/// <summary>
			/// 投诉编号
			/// </summary>
			public readonly static Field TS_CODE = new Field("TS_CODE", "PT_ZXTS_LOOK_INTO_CHK", "投诉编号");
			/// <summary>
			/// 查询码
			/// </summary>
			public readonly static Field CX_CODE = new Field("CX_CODE", "PT_ZXTS_LOOK_INTO_CHK", "查询码");
			/// <summary>
			/// 过期时间
			/// </summary>
			public readonly static Field EXPIREDTIME = new Field("EXPIREDTIME", "PT_ZXTS_LOOK_INTO_CHK", "过期时间");
			/// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATEDBY = new Field("CREATEDBY", "PT_ZXTS_LOOK_INTO_CHK", "创建人");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATEDTIME = new Field("CREATEDTIME", "PT_ZXTS_LOOK_INTO_CHK", "创建时间");
			/// <summary>
			/// 修改人
			/// </summary>
			public readonly static Field UPDATEDBY = new Field("UPDATEDBY", "PT_ZXTS_LOOK_INTO_CHK", "修改人");
			/// <summary>
			/// 修改时间
			/// </summary>
			public readonly static Field UPDATEDTIME = new Field("UPDATEDTIME", "PT_ZXTS_LOOK_INTO_CHK", "修改时间");
			/// <summary>
			/// 投诉发布信息id
			/// </summary>
			public readonly static Field COMPLAINT_PUBLISH_ID = new Field("COMPLAINT_PUBLISH_ID", "PT_ZXTS_LOOK_INTO_CHK", "投诉发布信息id");
		}
		#endregion
	}
}