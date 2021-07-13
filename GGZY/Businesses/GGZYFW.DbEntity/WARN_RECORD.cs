using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类WARN_RECORD。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("WARN_RECORD")]
	[Serializable]
	public partial class WARN_RECORD : FwEntity
	{
		#region Model
		private string _M_ID;
		private string _SP_RESULT_ID;
		private string _OPERATOR;
		private DateTime? _CREATE_TIME;
		private string _CONTENT;
		private string _OPERATE_TYPE;
		private string _REMARK;
		private string _WARN_NUMBER;
		private string _INFO_ACCEPT_TELPHONE;
		private decimal? _ISDELETE;
		private string _INFO_ACCEPT_TELPHONE1;

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
		/// 对应结果id
		/// </summary>
		public string SP_RESULT_ID
		{
			get { return _SP_RESULT_ID; }
			set
			{
				this.OnPropertyValueChange(_.SP_RESULT_ID, _SP_RESULT_ID, value);
				this._SP_RESULT_ID = value;
			}
		}
		/// <summary>
		/// 操作人，可能为系统
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
		/// 操作类型 1系统  2纠正  3预警
		/// </summary>
		public string OPERATE_TYPE
		{
			get { return _OPERATE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.OPERATE_TYPE, _OPERATE_TYPE, value);
				this._OPERATE_TYPE = value;
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
		/// 预警编号
		/// </summary>
		public string WARN_NUMBER
		{
			get { return _WARN_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.WARN_NUMBER, _WARN_NUMBER, value);
				this._WARN_NUMBER = value;
			}
		}
		/// <summary>
		/// 信息接收人号码
		/// </summary>
		public string INFO_ACCEPT_TELPHONE
		{
			get { return _INFO_ACCEPT_TELPHONE; }
			set
			{
				this.OnPropertyValueChange(_.INFO_ACCEPT_TELPHONE, _INFO_ACCEPT_TELPHONE, value);
				this._INFO_ACCEPT_TELPHONE = value;
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
		/// 信息接收人号码,另一种展现方式
		/// </summary>
		public string INFO_ACCEPT_TELPHONE1
		{
			get { return _INFO_ACCEPT_TELPHONE1; }
			set
			{
				this.OnPropertyValueChange(_.INFO_ACCEPT_TELPHONE1, _INFO_ACCEPT_TELPHONE1, value);
				this._INFO_ACCEPT_TELPHONE1 = value;
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
				_.SP_RESULT_ID,
				_.OPERATOR,
				_.CREATE_TIME,
				_.CONTENT,
				_.OPERATE_TYPE,
				_.REMARK,
				_.WARN_NUMBER,
				_.INFO_ACCEPT_TELPHONE,
				_.ISDELETE,
				_.INFO_ACCEPT_TELPHONE1,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._M_ID,
				this._SP_RESULT_ID,
				this._OPERATOR,
				this._CREATE_TIME,
				this._CONTENT,
				this._OPERATE_TYPE,
				this._REMARK,
				this._WARN_NUMBER,
				this._INFO_ACCEPT_TELPHONE,
				this._ISDELETE,
				this._INFO_ACCEPT_TELPHONE1,
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
			public readonly static Field All = new Field("*", "WARN_RECORD");
			/// <summary>
			/// 唯一标识
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "WARN_RECORD", "唯一标识");
			/// <summary>
			/// 对应结果id
			/// </summary>
			public readonly static Field SP_RESULT_ID = new Field("SP_RESULT_ID", "WARN_RECORD", "对应结果id");
			/// <summary>
			/// 操作人，可能为系统
			/// </summary>
			public readonly static Field OPERATOR = new Field("OPERATOR", "WARN_RECORD", "操作人，可能为系统");
			/// <summary>
			/// 操作时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "WARN_RECORD", "操作时间");
			/// <summary>
			/// 内容，相对备注用于显示到操作记录，比如纠正就写个纠正
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "WARN_RECORD", "内容，相对备注用于显示到操作记录，比如纠正就写个纠正");
			/// <summary>
			/// 操作类型 1系统  2纠正  3预警
			/// </summary>
			public readonly static Field OPERATE_TYPE = new Field("OPERATE_TYPE", "WARN_RECORD", "操作类型 1系统  2纠正  3预警");
			/// <summary>
			/// 备注，纠正说明，或预警内容
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "WARN_RECORD", DbType.AnsiString, null, "备注，纠正说明，或预警内容");
			/// <summary>
			/// 预警编号
			/// </summary>
			public readonly static Field WARN_NUMBER = new Field("WARN_NUMBER", "WARN_RECORD", "预警编号");
			/// <summary>
			/// 信息接收人号码
			/// </summary>
			public readonly static Field INFO_ACCEPT_TELPHONE = new Field("INFO_ACCEPT_TELPHONE", "WARN_RECORD", "信息接收人号码");
			/// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field ISDELETE = new Field("ISDELETE", "WARN_RECORD", "是否删除");
			/// <summary>
			/// 信息接收人号码,另一种展现方式
			/// </summary>
			public readonly static Field INFO_ACCEPT_TELPHONE1 = new Field("INFO_ACCEPT_TELPHONE1", "WARN_RECORD", "信息接收人号码,另一种展现方式");
		}
		#endregion
	}
}