using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类T_MODIFY_APPLICATION。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("T_MODIFY_APPLICATION")]
	[Serializable]
	public partial class T_MODIFY_APPLICATION : FwEntity
	{
		#region Model
		private string _GUID;
		private DateTime _CREATE_TIME;
		private int _CREATOR;
		private string _MODIFY_TYPE;
		private string _BACK_TABLE;
		private DateTime _REVIEW_TIME;
		private int _REVIEW_USER_ID;
		private string _TENDER_PROJECT_CODE;
		private string _REVIEW_CODE;
		private string _ATTACHMENT_ID;
		private string _REPORT_CODE;
		private string _TABLE_ID;
		private string _REVIEW_STATUS;

		/// <summary>
		/// 主键id
		/// </summary>
		public string GUID
		{
			get { return _GUID; }
			set
			{
				this.OnPropertyValueChange(_.GUID, _GUID, value);
				this._GUID = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CREATE_TIME
		{
			get { return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 创建人id
		/// </summary>
		public int CREATOR
		{
			get { return _CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.CREATOR, _CREATOR, value);
				this._CREATOR = value;
			}
		}
		/// <summary>
		/// 修改类型
		/// </summary>
		public string MODIFY_TYPE
		{
			get { return _MODIFY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.MODIFY_TYPE, _MODIFY_TYPE, value);
				this._MODIFY_TYPE = value;
			}
		}
		/// <summary>
		/// 回退状态的表名
		/// </summary>
		public string BACK_TABLE
		{
			get { return _BACK_TABLE; }
			set
			{
				this.OnPropertyValueChange(_.BACK_TABLE, _BACK_TABLE, value);
				this._BACK_TABLE = value;
			}
		}
		/// <summary>
		/// 审核时间
		/// </summary>
		public DateTime REVIEW_TIME
		{
			get { return _REVIEW_TIME; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_TIME, _REVIEW_TIME, value);
				this._REVIEW_TIME = value;
			}
		}
		/// <summary>
		/// 审核的用户id
		/// </summary>
		public int REVIEW_USER_ID
		{
			get { return _REVIEW_USER_ID; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_USER_ID, _REVIEW_USER_ID, value);
				this._REVIEW_USER_ID = value;
			}
		}
		/// <summary>
		/// 招标项目编号
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
		/// 备案编号
		/// </summary>
		public string REVIEW_CODE
		{
			get { return _REVIEW_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_CODE, _REVIEW_CODE, value);
				this._REVIEW_CODE = value;
			}
		}
		/// <summary>
		/// 附件的id，逗号隔开
		/// </summary>
		public string ATTACHMENT_ID
		{
			get { return _ATTACHMENT_ID; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENT_ID, _ATTACHMENT_ID, value);
				this._ATTACHMENT_ID = value;
			}
		}
		/// <summary>
		/// 报建编号
		/// </summary>
		public string REPORT_CODE
		{
			get { return _REPORT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REPORT_CODE, _REPORT_CODE, value);
				this._REPORT_CODE = value;
			}
		}
		/// <summary>
		/// 表中的id
		/// </summary>
		public string TABLE_ID
		{
			get { return _TABLE_ID; }
			set
			{
				this.OnPropertyValueChange(_.TABLE_ID, _TABLE_ID, value);
				this._TABLE_ID = value;
			}
		}
		/// <summary>
		/// 审核状态 1暂存2提交3审核通过
		/// </summary>
		public string REVIEW_STATUS
		{
			get { return _REVIEW_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_STATUS, _REVIEW_STATUS, value);
				this._REVIEW_STATUS = value;
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
				_.GUID,
			};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.GUID,
				_.CREATE_TIME,
				_.CREATOR,
				_.MODIFY_TYPE,
				_.BACK_TABLE,
				_.REVIEW_TIME,
				_.REVIEW_USER_ID,
				_.TENDER_PROJECT_CODE,
				_.REVIEW_CODE,
				_.ATTACHMENT_ID,
				_.REPORT_CODE,
				_.TABLE_ID,
				_.REVIEW_STATUS,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._GUID,
				this._CREATE_TIME,
				this._CREATOR,
				this._MODIFY_TYPE,
				this._BACK_TABLE,
				this._REVIEW_TIME,
				this._REVIEW_USER_ID,
				this._TENDER_PROJECT_CODE,
				this._REVIEW_CODE,
				this._ATTACHMENT_ID,
				this._REPORT_CODE,
				this._TABLE_ID,
				this._REVIEW_STATUS,
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
			public readonly static Field All = new Field("*", "T_MODIFY_APPLICATION");
			/// <summary>
			/// 主键id
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "T_MODIFY_APPLICATION", "主键id");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_MODIFY_APPLICATION", "创建时间");
			/// <summary>
			/// 创建人id
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "T_MODIFY_APPLICATION", "创建人id");
			/// <summary>
			/// 修改类型
			/// </summary>
			public readonly static Field MODIFY_TYPE = new Field("MODIFY_TYPE", "T_MODIFY_APPLICATION", "修改类型");
			/// <summary>
			/// 回退状态的表名
			/// </summary>
			public readonly static Field BACK_TABLE = new Field("BACK_TABLE", "T_MODIFY_APPLICATION", "回退状态的表名");
			/// <summary>
			/// 审核时间
			/// </summary>
			public readonly static Field REVIEW_TIME = new Field("REVIEW_TIME", "T_MODIFY_APPLICATION", "审核时间");
			/// <summary>
			/// 审核的用户id
			/// </summary>
			public readonly static Field REVIEW_USER_ID = new Field("REVIEW_USER_ID", "T_MODIFY_APPLICATION", "审核的用户id");
			/// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_MODIFY_APPLICATION", "招标项目编号");
			/// <summary>
			/// 备案编号
			/// </summary>
			public readonly static Field REVIEW_CODE = new Field("REVIEW_CODE", "T_MODIFY_APPLICATION", "备案编号");
			/// <summary>
			/// 附件的id，逗号隔开
			/// </summary>
			public readonly static Field ATTACHMENT_ID = new Field("ATTACHMENT_ID", "T_MODIFY_APPLICATION", "附件的id，逗号隔开");
			/// <summary>
			/// 报建编号
			/// </summary>
			public readonly static Field REPORT_CODE = new Field("REPORT_CODE", "T_MODIFY_APPLICATION", "报建编号");
			/// <summary>
			/// 表中的id
			/// </summary>
			public readonly static Field TABLE_ID = new Field("TABLE_ID", "T_MODIFY_APPLICATION", "表中的id");
			/// <summary>
			/// 审核状态 1暂存2提交3审核通过
			/// </summary>
			public readonly static Field REVIEW_STATUS = new Field("REVIEW_STATUS", "T_MODIFY_APPLICATION", "审核状态 1暂存2提交3审核通过");
		}
		#endregion
	}
}