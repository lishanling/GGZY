using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类T_COPYSEND。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("T_COPYSEND")]
	[Serializable]
	public partial class T_COPYSEND : JdEntity
	{
		#region Model
		private DateTime? _CS_TIME;
		private string _CS_CONTENT;
		private string _CS_NAME;
		private string _CS_ID;
		private string _ID;
		private string _CS_PUNISH_ID;

		/// <summary>
		/// 抄送时间
		/// </summary>
		public DateTime? CS_TIME
		{
			get { return _CS_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CS_TIME, _CS_TIME, value);
				this._CS_TIME = value;
			}
		}
		/// <summary>
		/// 抄送内容
		/// </summary>
		public string CS_CONTENT
		{
			get { return _CS_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CS_CONTENT, _CS_CONTENT, value);
				this._CS_CONTENT = value;
			}
		}
		/// <summary>
		/// 抄送部门名称
		/// </summary>
		public string CS_NAME
		{
			get { return _CS_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CS_NAME, _CS_NAME, value);
				this._CS_NAME = value;
			}
		}
		/// <summary>
		/// 抄送部门ID
		/// </summary>
		public string CS_ID
		{
			get { return _CS_ID; }
			set
			{
				this.OnPropertyValueChange(_.CS_ID, _CS_ID, value);
				this._CS_ID = value;
			}
		}
		/// <summary>
		/// 主键ID
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
		/// 用于存储处罚表中的主键id
		/// </summary>
		public string CS_PUNISH_ID
		{
			get { return _CS_PUNISH_ID; }
			set
			{
				this.OnPropertyValueChange(_.CS_PUNISH_ID, _CS_PUNISH_ID, value);
				this._CS_PUNISH_ID = value;
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
				_.CS_TIME,
				_.CS_CONTENT,
				_.CS_NAME,
				_.CS_ID,
				_.ID,
				_.CS_PUNISH_ID,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CS_TIME,
				this._CS_CONTENT,
				this._CS_NAME,
				this._CS_ID,
				this._ID,
				this._CS_PUNISH_ID,
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
			public readonly static Field All = new Field("*", "T_COPYSEND");
			/// <summary>
			/// 抄送时间
			/// </summary>
			public readonly static Field CS_TIME = new Field("CS_TIME", "T_COPYSEND", "抄送时间");
			/// <summary>
			/// 抄送内容
			/// </summary>
			public readonly static Field CS_CONTENT = new Field("CS_CONTENT", "T_COPYSEND", DbType.AnsiString, null, "抄送内容");
			/// <summary>
			/// 抄送部门名称
			/// </summary>
			public readonly static Field CS_NAME = new Field("CS_NAME", "T_COPYSEND", "抄送部门名称");
			/// <summary>
			/// 抄送部门ID
			/// </summary>
			public readonly static Field CS_ID = new Field("CS_ID", "T_COPYSEND", "抄送部门ID");
			/// <summary>
			/// 主键ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_COPYSEND", "主键ID");
			/// <summary>
			/// 用于存储处罚表中的主键id
			/// </summary>
			public readonly static Field CS_PUNISH_ID = new Field("CS_PUNISH_ID", "T_COPYSEND", "用于存储处罚表中的主键id");
		}
		#endregion
	}
}