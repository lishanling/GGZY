using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类WARN_FEEDBACK。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("WARN_FEEDBACK")]
	[Serializable]
	public partial class WARN_FEEDBACK : FwEntity
	{
		#region Model
		private string _M_ID;
		private string _SP_RECORD_ID;
		private string _OPERATOR;
		private string _OPERATOR_ID;
		private string _OPERATOR_UNIT;
		private string _OPERATOR_UNIT_ID;
		private DateTime? _CREATE_TIME;
		private string _CONTENT;
		private string _REMARK;
		private decimal? _ISDELETE;
		private string _FEEDBACK_ATTACHMENT;

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
		/// 对应记录id
		/// </summary>
		public string SP_RECORD_ID
		{
			get { return _SP_RECORD_ID; }
			set
			{
				this.OnPropertyValueChange(_.SP_RECORD_ID, _SP_RECORD_ID, value);
				this._SP_RECORD_ID = value;
			}
		}
		/// <summary>
		/// 反馈人，可能为系统
		/// </summary>
		public string OPERATOR
		{
			get { return _OPERATOR; }
			set
			{
				this.OnPropertyValueChange(_.OPERATOR, _OPERATOR, value);
				this._OPERATOR = value;
			}
		}
		/// <summary>
		/// 反馈人id
		/// </summary>
		public string OPERATOR_ID
		{
			get { return _OPERATOR_ID; }
			set
			{
				this.OnPropertyValueChange(_.OPERATOR_ID, _OPERATOR_ID, value);
				this._OPERATOR_ID = value;
			}
		}
		/// <summary>
		/// 反馈人单位
		/// </summary>
		public string OPERATOR_UNIT
		{
			get { return _OPERATOR_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.OPERATOR_UNIT, _OPERATOR_UNIT, value);
				this._OPERATOR_UNIT = value;
			}
		}
		/// <summary>
		/// 反馈人单位id
		/// </summary>
		public string OPERATOR_UNIT_ID
		{
			get { return _OPERATOR_UNIT_ID; }
			set
			{
				this.OnPropertyValueChange(_.OPERATOR_UNIT_ID, _OPERATOR_UNIT_ID, value);
				this._OPERATOR_UNIT_ID = value;
			}
		}
		/// <summary>
		/// 操作时间
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
		/// 内容，相对备注用于显示到操作记录，比如纠正就写个纠正
		/// </summary>
		public string CONTENT
		{
			get { return _CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTENT, _CONTENT, value);
				this._CONTENT = value;
			}
		}
		/// <summary>
		/// 备注，纠正说明，或预警内容
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
		/// 附件信息
		/// </summary>
		public string FEEDBACK_ATTACHMENT
		{
			get { return _FEEDBACK_ATTACHMENT; }
			set
			{
				this.OnPropertyValueChange(_.FEEDBACK_ATTACHMENT, _FEEDBACK_ATTACHMENT, value);
				this._FEEDBACK_ATTACHMENT = value;
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
				_.M_ID,
				_.SP_RECORD_ID,
				_.OPERATOR,
				_.OPERATOR_ID,
				_.OPERATOR_UNIT,
				_.OPERATOR_UNIT_ID,
				_.CREATE_TIME,
				_.CONTENT,
				_.REMARK,
				_.ISDELETE,
				_.FEEDBACK_ATTACHMENT,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._M_ID,
				this._SP_RECORD_ID,
				this._OPERATOR,
				this._OPERATOR_ID,
				this._OPERATOR_UNIT,
				this._OPERATOR_UNIT_ID,
				this._CREATE_TIME,
				this._CONTENT,
				this._REMARK,
				this._ISDELETE,
				this._FEEDBACK_ATTACHMENT,
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
			public readonly static Field All = new Field("*", "WARN_FEEDBACK");
			/// <summary>
			/// 唯一标识
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "WARN_FEEDBACK", "唯一标识");
			/// <summary>
			/// 对应记录id
			/// </summary>
			public readonly static Field SP_RECORD_ID = new Field("SP_RECORD_ID", "WARN_FEEDBACK", "对应记录id");
			/// <summary>
			/// 反馈人，可能为系统
			/// </summary>
			public readonly static Field OPERATOR = new Field("OPERATOR", "WARN_FEEDBACK", "反馈人，可能为系统");
			/// <summary>
			/// 反馈人id
			/// </summary>
			public readonly static Field OPERATOR_ID = new Field("OPERATOR_ID", "WARN_FEEDBACK", "反馈人id");
			/// <summary>
			/// 反馈人单位
			/// </summary>
			public readonly static Field OPERATOR_UNIT = new Field("OPERATOR_UNIT", "WARN_FEEDBACK", "反馈人单位");
			/// <summary>
			/// 反馈人单位id
			/// </summary>
			public readonly static Field OPERATOR_UNIT_ID = new Field("OPERATOR_UNIT_ID", "WARN_FEEDBACK", "反馈人单位id");
			/// <summary>
			/// 操作时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "WARN_FEEDBACK", "操作时间");
			/// <summary>
			/// 内容，相对备注用于显示到操作记录，比如纠正就写个纠正
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "WARN_FEEDBACK", "内容，相对备注用于显示到操作记录，比如纠正就写个纠正");
			/// <summary>
			/// 备注，纠正说明，或预警内容
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "WARN_FEEDBACK", DbType.AnsiString, null, "备注，纠正说明，或预警内容");
			/// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field ISDELETE = new Field("ISDELETE", "WARN_FEEDBACK", "是否删除");
			/// <summary>
			/// 附件信息
			/// </summary>
			public readonly static Field FEEDBACK_ATTACHMENT = new Field("FEEDBACK_ATTACHMENT", "WARN_FEEDBACK", "附件信息");
		}
		#endregion
	}
}