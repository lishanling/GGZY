using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类T_PUNISH。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("T_PUNISH")]
	[Serializable]
	public partial class T_PUNISH : JdEntity
	{
		#region Model
		private string _ID;
		private string _PUNISH_CONTENT;
		private string _TENDER_PROJECT_CODE;
		private DateTime? _PUNISH_TIME;
		private string _USE_OPERATOR;
		private string _PUNISH_ID;
		private string _PUNISH_TITLE;
		private string _PUNISH_CODE;
		private string _PUNISH_FILE;
		private string _TENDER_PROJECT_TYPE;
		private string _REGION_CODE;

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
		/// 处罚记录—处罚内容
		/// </summary>
		public string PUNISH_CONTENT
		{
			get { return _PUNISH_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.PUNISH_CONTENT, _PUNISH_CONTENT, value);
				this._PUNISH_CONTENT = value;
			}
		}
		/// <summary>
		/// 处罚记录-关联项目（招标项目编号）
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get { return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 处罚记录-处罚时间
		/// </summary>
		public DateTime? PUNISH_TIME
		{
			get { return _PUNISH_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PUNISH_TIME, _PUNISH_TIME, value);
				this._PUNISH_TIME = value;
			}
		}
		/// <summary>
		/// 处罚记录-操作人
		/// </summary>
		public string USE_OPERATOR
		{
			get { return _USE_OPERATOR; }
			set
			{
				this.OnPropertyValueChange(_.USE_OPERATOR, _USE_OPERATOR, value);
				this._USE_OPERATOR = value;
			}
		}
		/// <summary>
		/// 处罚记录-处罚对象(组织机构ID)
		/// </summary>
		public string PUNISH_ID
		{
			get { return _PUNISH_ID; }
			set
			{
				this.OnPropertyValueChange(_.PUNISH_ID, _PUNISH_ID, value);
				this._PUNISH_ID = value;
			}
		}
		/// <summary>
		/// 处罚记录—处罚标题
		/// </summary>
		public string PUNISH_TITLE
		{
			get { return _PUNISH_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.PUNISH_TITLE, _PUNISH_TITLE, value);
				this._PUNISH_TITLE = value;
			}
		}
		/// <summary>
		/// 处罚记录—处罚编号
		/// </summary>
		public string PUNISH_CODE
		{
			get { return _PUNISH_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PUNISH_CODE, _PUNISH_CODE, value);
				this._PUNISH_CODE = value;
			}
		}
		/// <summary>
		/// 处罚记录—附件上传（以，隔开）
		/// </summary>
		public string PUNISH_FILE
		{
			get { return _PUNISH_FILE; }
			set
			{
				this.OnPropertyValueChange(_.PUNISH_FILE, _PUNISH_FILE, value);
				this._PUNISH_FILE = value;
			}
		}
		/// <summary>
		/// 行业类型
		/// </summary>
		public string TENDER_PROJECT_TYPE
		{
			get { return _TENDER_PROJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_TYPE, _TENDER_PROJECT_TYPE, value);
				this._TENDER_PROJECT_TYPE = value;
			}
		}
		/// <summary>
		/// 归属地
		/// </summary>
		public string REGION_CODE
		{
			get { return _REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REGION_CODE, _REGION_CODE, value);
				this._REGION_CODE = value;
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
				_.PUNISH_CONTENT,
				_.TENDER_PROJECT_CODE,
				_.PUNISH_TIME,
				_.USE_OPERATOR,
				_.PUNISH_ID,
				_.PUNISH_TITLE,
				_.PUNISH_CODE,
				_.PUNISH_FILE,
				_.TENDER_PROJECT_TYPE,
				_.REGION_CODE,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._PUNISH_CONTENT,
				this._TENDER_PROJECT_CODE,
				this._PUNISH_TIME,
				this._USE_OPERATOR,
				this._PUNISH_ID,
				this._PUNISH_TITLE,
				this._PUNISH_CODE,
				this._PUNISH_FILE,
				this._TENDER_PROJECT_TYPE,
				this._REGION_CODE,
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
			public readonly static Field All = new Field("*", "T_PUNISH");
			/// <summary>
			/// 主键ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_PUNISH", "主键ID");
			/// <summary>
			/// 处罚记录—处罚内容
			/// </summary>
			public readonly static Field PUNISH_CONTENT = new Field("PUNISH_CONTENT", "T_PUNISH", DbType.AnsiString, null, "处罚记录—处罚内容");
			/// <summary>
			/// 处罚记录-关联项目（招标项目编号）
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_PUNISH", "处罚记录-关联项目（招标项目编号）");
			/// <summary>
			/// 处罚记录-处罚时间
			/// </summary>
			public readonly static Field PUNISH_TIME = new Field("PUNISH_TIME", "T_PUNISH", "处罚记录-处罚时间");
			/// <summary>
			/// 处罚记录-操作人
			/// </summary>
			public readonly static Field USE_OPERATOR = new Field("USE_OPERATOR", "T_PUNISH", "处罚记录-操作人");
			/// <summary>
			/// 处罚记录-处罚对象(组织机构ID)
			/// </summary>
			public readonly static Field PUNISH_ID = new Field("PUNISH_ID", "T_PUNISH", "处罚记录-处罚对象(组织机构ID)");
			/// <summary>
			/// 处罚记录—处罚标题
			/// </summary>
			public readonly static Field PUNISH_TITLE = new Field("PUNISH_TITLE", "T_PUNISH", "处罚记录—处罚标题");
			/// <summary>
			/// 处罚记录—处罚编号
			/// </summary>
			public readonly static Field PUNISH_CODE = new Field("PUNISH_CODE", "T_PUNISH", "处罚记录—处罚编号");
			/// <summary>
			/// 处罚记录—附件上传（以，隔开）
			/// </summary>
			public readonly static Field PUNISH_FILE = new Field("PUNISH_FILE", "T_PUNISH", "处罚记录—附件上传（以，隔开）");
			/// <summary>
			/// 行业类型
			/// </summary>
			public readonly static Field TENDER_PROJECT_TYPE = new Field("TENDER_PROJECT_TYPE", "T_PUNISH", "行业类型");
			/// <summary>
			/// 归属地
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "T_PUNISH", "归属地");
		}
		#endregion
	}
}