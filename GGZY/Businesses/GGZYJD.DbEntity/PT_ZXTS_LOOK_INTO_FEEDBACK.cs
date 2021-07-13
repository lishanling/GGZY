using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类PT_ZXTS_LOOK_INTO_FEEDBACK。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("PT_ZXTS_LOOK_INTO_FEEDBACK")]
	[Serializable]
	public partial class PT_ZXTS_LOOK_INTO_FEEDBACK : JdEntity
	{
		#region Model
		private string _ID;
		private string _LOOK_ID;
		private string _FEEDBACK_CODE;
		private string _LOOK_NAME;
		private string _LOOK_OBJECT_TYPE;
		private string _LOOK_PROJECT_TYPE;
		private string _LOOK_CONTRACT;
		private decimal? _STATUS;
		private string _FEEDBACK_AIDS;
		private string _FEEDBACK_CONTENT;
		private DateTime? _LOOK_TIME;
		private DateTime? _FEEDBACK_TIME;
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
		/// 调查取证编号
		/// </summary>
		public string LOOK_ID
		{
			get { return _LOOK_ID; }
			set
			{
				this.OnPropertyValueChange(_.LOOK_ID, _LOOK_ID, value);
				this._LOOK_ID = value;
			}
		}
		/// <summary>
		/// 调查取证反馈码
		/// </summary>
		public string FEEDBACK_CODE
		{
			get { return _FEEDBACK_CODE; }
			set
			{
				this.OnPropertyValueChange(_.FEEDBACK_CODE, _FEEDBACK_CODE, value);
				this._FEEDBACK_CODE = value;
			}
		}
		/// <summary>
		/// 调查对象
		/// </summary>
		public string LOOK_NAME
		{
			get { return _LOOK_NAME; }
			set
			{
				this.OnPropertyValueChange(_.LOOK_NAME, _LOOK_NAME, value);
				this._LOOK_NAME = value;
			}
		}
		/// <summary>
		/// 调查对象类型
		/// </summary>
		public string LOOK_OBJECT_TYPE
		{
			get { return _LOOK_OBJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.LOOK_OBJECT_TYPE, _LOOK_OBJECT_TYPE, value);
				this._LOOK_OBJECT_TYPE = value;
			}
		}
		/// <summary>
		/// 调查对象项目角色
		/// </summary>
		public string LOOK_PROJECT_TYPE
		{
			get { return _LOOK_PROJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.LOOK_PROJECT_TYPE, _LOOK_PROJECT_TYPE, value);
				this._LOOK_PROJECT_TYPE = value;
			}
		}
		/// <summary>
		/// 调查对象联系电话
		/// </summary>
		public string LOOK_CONTRACT
		{
			get { return _LOOK_CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.LOOK_CONTRACT, _LOOK_CONTRACT, value);
				this._LOOK_CONTRACT = value;
			}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public decimal? STATUS
		{
			get { return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 附件集合
		/// </summary>
		public string FEEDBACK_AIDS
		{
			get { return _FEEDBACK_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.FEEDBACK_AIDS, _FEEDBACK_AIDS, value);
				this._FEEDBACK_AIDS = value;
			}
		}
		/// <summary>
		/// 调查取证反馈内容
		/// </summary>
		public string FEEDBACK_CONTENT
		{
			get { return _FEEDBACK_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.FEEDBACK_CONTENT, _FEEDBACK_CONTENT, value);
				this._FEEDBACK_CONTENT = value;
			}
		}
		/// <summary>
		/// 发起调查时间
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
		/// 反馈时间
		/// </summary>
		public DateTime? FEEDBACK_TIME
		{
			get { return _FEEDBACK_TIME; }
			set
			{
				this.OnPropertyValueChange(_.FEEDBACK_TIME, _FEEDBACK_TIME, value);
				this._FEEDBACK_TIME = value;
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
				_.LOOK_ID,
				_.FEEDBACK_CODE,
				_.LOOK_NAME,
				_.LOOK_OBJECT_TYPE,
				_.LOOK_PROJECT_TYPE,
				_.LOOK_CONTRACT,
				_.STATUS,
				_.FEEDBACK_AIDS,
				_.FEEDBACK_CONTENT,
				_.LOOK_TIME,
				_.FEEDBACK_TIME,
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
				this._LOOK_ID,
				this._FEEDBACK_CODE,
				this._LOOK_NAME,
				this._LOOK_OBJECT_TYPE,
				this._LOOK_PROJECT_TYPE,
				this._LOOK_CONTRACT,
				this._STATUS,
				this._FEEDBACK_AIDS,
				this._FEEDBACK_CONTENT,
				this._LOOK_TIME,
				this._FEEDBACK_TIME,
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
			public readonly static Field All = new Field("*", "PT_ZXTS_LOOK_INTO_FEEDBACK");
			/// <summary>
			/// 主键，唯一标识
			/// </summary>
			public readonly static Field ID = new Field("ID", "PT_ZXTS_LOOK_INTO_FEEDBACK", "主键，唯一标识");
			/// <summary>
			/// 调查取证编号
			/// </summary>
			public readonly static Field LOOK_ID = new Field("LOOK_ID", "PT_ZXTS_LOOK_INTO_FEEDBACK", "调查取证编号");
			/// <summary>
			/// 调查取证反馈码
			/// </summary>
			public readonly static Field FEEDBACK_CODE = new Field("FEEDBACK_CODE", "PT_ZXTS_LOOK_INTO_FEEDBACK", "调查取证反馈码");
			/// <summary>
			/// 调查对象
			/// </summary>
			public readonly static Field LOOK_NAME = new Field("LOOK_NAME", "PT_ZXTS_LOOK_INTO_FEEDBACK", "调查对象");
			/// <summary>
			/// 调查对象类型
			/// </summary>
			public readonly static Field LOOK_OBJECT_TYPE = new Field("LOOK_OBJECT_TYPE", "PT_ZXTS_LOOK_INTO_FEEDBACK", "调查对象类型");
			/// <summary>
			/// 调查对象项目角色
			/// </summary>
			public readonly static Field LOOK_PROJECT_TYPE = new Field("LOOK_PROJECT_TYPE", "PT_ZXTS_LOOK_INTO_FEEDBACK", "调查对象项目角色");
			/// <summary>
			/// 调查对象联系电话
			/// </summary>
			public readonly static Field LOOK_CONTRACT = new Field("LOOK_CONTRACT", "PT_ZXTS_LOOK_INTO_FEEDBACK", "调查对象联系电话");
			/// <summary>
			/// 状态
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "PT_ZXTS_LOOK_INTO_FEEDBACK", "状态");
			/// <summary>
			/// 附件集合
			/// </summary>
			public readonly static Field FEEDBACK_AIDS = new Field("FEEDBACK_AIDS", "PT_ZXTS_LOOK_INTO_FEEDBACK", "附件集合");
			/// <summary>
			/// 调查取证反馈内容
			/// </summary>
			public readonly static Field FEEDBACK_CONTENT = new Field("FEEDBACK_CONTENT", "PT_ZXTS_LOOK_INTO_FEEDBACK", DbType.AnsiString, null, "调查取证反馈内容");
			/// <summary>
			/// 发起调查时间
			/// </summary>
			public readonly static Field LOOK_TIME = new Field("LOOK_TIME", "PT_ZXTS_LOOK_INTO_FEEDBACK", "发起调查时间");
			/// <summary>
			/// 反馈时间
			/// </summary>
			public readonly static Field FEEDBACK_TIME = new Field("FEEDBACK_TIME", "PT_ZXTS_LOOK_INTO_FEEDBACK", "反馈时间");
			/// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATEDBY = new Field("CREATEDBY", "PT_ZXTS_LOOK_INTO_FEEDBACK", "创建人");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATEDTIME = new Field("CREATEDTIME", "PT_ZXTS_LOOK_INTO_FEEDBACK", "创建时间");
			/// <summary>
			/// 修改人
			/// </summary>
			public readonly static Field UPDATEDBY = new Field("UPDATEDBY", "PT_ZXTS_LOOK_INTO_FEEDBACK", "修改人");
			/// <summary>
			/// 修改时间
			/// </summary>
			public readonly static Field UPDATEDTIME = new Field("UPDATEDTIME", "PT_ZXTS_LOOK_INTO_FEEDBACK", "修改时间");
		}
		#endregion
	}
}