using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类WARN_TEMPLATE。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("WARN_TEMPLATE")]
	[Serializable]
	public partial class WARN_TEMPLATE : FwEntity
	{
		#region Model
		private string _M_ID;
		private DateTime? _CREATE_TIME;
		private string _CONTENT_EDIT;
		private string _FOUNDER_ID;
		private decimal? _FOUNDER_UNIT_ID;
		private string _READ_ONLY;
		private string _TEMPLATE_TYPE;
		private string _CONTENT_TYPE;

		/// <summary>
		/// 唯一标识
		/// </summary>
		public string M_ID
		{
			get { return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
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
		/// 模板内容（可编辑）
		/// </summary>
		public string CONTENT_EDIT
		{
			get { return _CONTENT_EDIT; }
			set
			{
				this.OnPropertyValueChange(_.CONTENT_EDIT, _CONTENT_EDIT, value);
				this._CONTENT_EDIT = value;
			}
		}
		/// <summary>
		/// 创建人ID
		/// </summary>
		public string FOUNDER_ID
		{
			get { return _FOUNDER_ID; }
			set
			{
				this.OnPropertyValueChange(_.FOUNDER_ID, _FOUNDER_ID, value);
				this._FOUNDER_ID = value;
			}
		}
		/// <summary>
		/// 创建人单位ID
		/// </summary>
		public decimal? FOUNDER_UNIT_ID
		{
			get { return _FOUNDER_UNIT_ID; }
			set
			{
				this.OnPropertyValueChange(_.FOUNDER_UNIT_ID, _FOUNDER_UNIT_ID, value);
				this._FOUNDER_UNIT_ID = value;
			}
		}
		/// <summary>
		/// 模板内容（只读）
		/// </summary>
		public string READ_ONLY
		{
			get { return _READ_ONLY; }
			set
			{
				this.OnPropertyValueChange(_.READ_ONLY, _READ_ONLY, value);
				this._READ_ONLY = value;
			}
		}
		/// <summary>
		/// _1:固定模板2:自定义模板
		/// </summary>
		public string TEMPLATE_TYPE
		{
			get { return _TEMPLATE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TEMPLATE_TYPE, _TEMPLATE_TYPE, value);
				this._TEMPLATE_TYPE = value;
			}
		}
		/// <summary>
		/// _1:预警短信内容2:站内短信内容
		/// </summary>
		public string CONTENT_TYPE
		{
			get { return _CONTENT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.CONTENT_TYPE, _CONTENT_TYPE, value);
				this._CONTENT_TYPE = value;
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
				_.CREATE_TIME,
				_.CONTENT_EDIT,
				_.FOUNDER_ID,
				_.FOUNDER_UNIT_ID,
				_.READ_ONLY,
				_.TEMPLATE_TYPE,
				_.CONTENT_TYPE,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._M_ID,
				this._CREATE_TIME,
				this._CONTENT_EDIT,
				this._FOUNDER_ID,
				this._FOUNDER_UNIT_ID,
				this._READ_ONLY,
				this._TEMPLATE_TYPE,
				this._CONTENT_TYPE,
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
			public readonly static Field All = new Field("*", "WARN_TEMPLATE");
			/// <summary>
			/// 唯一标识
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "WARN_TEMPLATE", "唯一标识");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "WARN_TEMPLATE", "创建时间");
			/// <summary>
			/// 模板内容（可编辑）
			/// </summary>
			public readonly static Field CONTENT_EDIT = new Field("CONTENT_EDIT", "WARN_TEMPLATE", DbType.AnsiString, null, "模板内容（可编辑）");
			/// <summary>
			/// 创建人ID
			/// </summary>
			public readonly static Field FOUNDER_ID = new Field("FOUNDER_ID", "WARN_TEMPLATE", "创建人ID");
			/// <summary>
			/// 创建人单位ID
			/// </summary>
			public readonly static Field FOUNDER_UNIT_ID = new Field("FOUNDER_UNIT_ID", "WARN_TEMPLATE", "创建人单位ID");
			/// <summary>
			/// 模板内容（只读）
			/// </summary>
			public readonly static Field READ_ONLY = new Field("READ_ONLY", "WARN_TEMPLATE", DbType.AnsiString, null, "模板内容（只读）");
			/// <summary>
			/// _1:固定模板2:自定义模板
			/// </summary>
			public readonly static Field TEMPLATE_TYPE = new Field("TEMPLATE_TYPE", "WARN_TEMPLATE", "_1:固定模板2:自定义模板");
			/// <summary>
			/// _1:预警短信内容2:站内短信内容
			/// </summary>
			public readonly static Field CONTENT_TYPE = new Field("CONTENT_TYPE", "WARN_TEMPLATE", "_1:预警短信内容2:站内短信内容");
		}
		#endregion
	}
}