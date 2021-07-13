using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_CREDIT_BONUS。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_CREDIT_BONUS")]
    [Serializable]
    public partial class T_CREDIT_BONUS : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _TITLE;
		private string _REWARD_ENTERPRISE;
		private string _REWARD_CONTENT;
		private string _AUDIT_STAFF;
		private DateTime? _ATDIT_TIME;
		private string _ATTACHMENT;
		private string _STATE;
		private DateTime? _COMMIT_TIME;
		private string _AUDIT_OPINION;
		private decimal? _USER_ID;
		private string _BODY_CODE;
		private string _BODY_TYPE;
		private string _BODY_ROLE;
		private string _REWARD_TYPE;
		private DateTime? _REWARD_TIME;
		private string _DOCUMENT_NO;
		private string _PUBLIC_SCOPE;

		/// <summary>
		/// ID
		/// </summary>
		public decimal? ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 标题
		/// </summary>
		public string TITLE
		{
			get{ return _TITLE; }
			set
			{
				this.OnPropertyValueChange(_.TITLE, _TITLE, value);
				this._TITLE = value;
			}
		}
		/// <summary>
		/// 奖励企业
		/// </summary>
		public string REWARD_ENTERPRISE
		{
			get{ return _REWARD_ENTERPRISE; }
			set
			{
				this.OnPropertyValueChange(_.REWARD_ENTERPRISE, _REWARD_ENTERPRISE, value);
				this._REWARD_ENTERPRISE = value;
			}
		}
		/// <summary>
		/// 奖励内容
		/// </summary>
		public string REWARD_CONTENT
		{
			get{ return _REWARD_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.REWARD_CONTENT, _REWARD_CONTENT, value);
				this._REWARD_CONTENT = value;
			}
		}
		/// <summary>
		/// 审核人员
		/// </summary>
		public string AUDIT_STAFF
		{
			get{ return _AUDIT_STAFF; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_STAFF, _AUDIT_STAFF, value);
				this._AUDIT_STAFF = value;
			}
		}
		/// <summary>
		/// 审核时间
		/// </summary>
		public DateTime? ATDIT_TIME
		{
			get{ return _ATDIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.ATDIT_TIME, _ATDIT_TIME, value);
				this._ATDIT_TIME = value;
			}
		}
		/// <summary>
		/// 附件
		/// </summary>
		public string ATTACHMENT
		{
			get{ return _ATTACHMENT; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENT, _ATTACHMENT, value);
				this._ATTACHMENT = value;
			}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public string STATE
		{
			get{ return _STATE; }
			set
			{
				this.OnPropertyValueChange(_.STATE, _STATE, value);
				this._STATE = value;
			}
		}
		/// <summary>
		/// 提交时间
		/// </summary>
		public DateTime? COMMIT_TIME
		{
			get{ return _COMMIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.COMMIT_TIME, _COMMIT_TIME, value);
				this._COMMIT_TIME = value;
			}
		}
		/// <summary>
		/// 审核意见
		/// </summary>
		public string AUDIT_OPINION
		{
			get{ return _AUDIT_OPINION; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_OPINION, _AUDIT_OPINION, value);
				this._AUDIT_OPINION = value;
			}
		}
		/// <summary>
		/// 发布人员ID
		/// </summary>
		public decimal? USER_ID
		{
			get{ return _USER_ID; }
			set
			{
				this.OnPropertyValueChange(_.USER_ID, _USER_ID, value);
				this._USER_ID = value;
			}
		}
		/// <summary>
		/// 主体代码
		/// </summary>
		public string BODY_CODE
		{
			get{ return _BODY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BODY_CODE, _BODY_CODE, value);
				this._BODY_CODE = value;
			}
		}
		/// <summary>
		/// 主体类别
		/// </summary>
		public string BODY_TYPE
		{
			get{ return _BODY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BODY_TYPE, _BODY_TYPE, value);
				this._BODY_TYPE = value;
			}
		}
		/// <summary>
		/// 主体角色
		/// </summary>
		public string BODY_ROLE
		{
			get{ return _BODY_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.BODY_ROLE, _BODY_ROLE, value);
				this._BODY_ROLE = value;
			}
		}
		/// <summary>
		/// 奖惩类型
		/// </summary>
		public string REWARD_TYPE
		{
			get{ return _REWARD_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.REWARD_TYPE, _REWARD_TYPE, value);
				this._REWARD_TYPE = value;
			}
		}
		/// <summary>
		/// 奖励日期
		/// </summary>
		public DateTime? REWARD_TIME
		{
			get{ return _REWARD_TIME; }
			set
			{
				this.OnPropertyValueChange(_.REWARD_TIME, _REWARD_TIME, value);
				this._REWARD_TIME = value;
			}
		}
		/// <summary>
		/// 处理文件文号
		/// </summary>
		public string DOCUMENT_NO
		{
			get{ return _DOCUMENT_NO; }
			set
			{
				this.OnPropertyValueChange(_.DOCUMENT_NO, _DOCUMENT_NO, value);
				this._DOCUMENT_NO = value;
			}
		}
		/// <summary>
		/// 公开范围
		/// </summary>
		public string PUBLIC_SCOPE
		{
			get{ return _PUBLIC_SCOPE; }
			set
			{
				this.OnPropertyValueChange(_.PUBLIC_SCOPE, _PUBLIC_SCOPE, value);
				this._PUBLIC_SCOPE = value;
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
				_.TITLE,
				_.REWARD_ENTERPRISE,
				_.REWARD_CONTENT,
				_.AUDIT_STAFF,
				_.ATDIT_TIME,
				_.ATTACHMENT,
				_.STATE,
				_.COMMIT_TIME,
				_.AUDIT_OPINION,
				_.USER_ID,
				_.BODY_CODE,
				_.BODY_TYPE,
				_.BODY_ROLE,
				_.REWARD_TYPE,
				_.REWARD_TIME,
				_.DOCUMENT_NO,
				_.PUBLIC_SCOPE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TITLE,
				this._REWARD_ENTERPRISE,
				this._REWARD_CONTENT,
				this._AUDIT_STAFF,
				this._ATDIT_TIME,
				this._ATTACHMENT,
				this._STATE,
				this._COMMIT_TIME,
				this._AUDIT_OPINION,
				this._USER_ID,
				this._BODY_CODE,
				this._BODY_TYPE,
				this._BODY_ROLE,
				this._REWARD_TYPE,
				this._REWARD_TIME,
				this._DOCUMENT_NO,
				this._PUBLIC_SCOPE,
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
			public readonly static Field All = new Field("*", "T_CREDIT_BONUS");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_CREDIT_BONUS", "ID");
            /// <summary>
			/// 标题
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "T_CREDIT_BONUS", "标题");
            /// <summary>
			/// 奖励企业
			/// </summary>
			public readonly static Field REWARD_ENTERPRISE = new Field("REWARD_ENTERPRISE", "T_CREDIT_BONUS", "奖励企业");
            /// <summary>
			/// 奖励内容
			/// </summary>
			public readonly static Field REWARD_CONTENT = new Field("REWARD_CONTENT", "T_CREDIT_BONUS", "奖励内容");
            /// <summary>
			/// 审核人员
			/// </summary>
			public readonly static Field AUDIT_STAFF = new Field("AUDIT_STAFF", "T_CREDIT_BONUS", "审核人员");
            /// <summary>
			/// 审核时间
			/// </summary>
			public readonly static Field ATDIT_TIME = new Field("ATDIT_TIME", "T_CREDIT_BONUS", "审核时间");
            /// <summary>
			/// 附件
			/// </summary>
			public readonly static Field ATTACHMENT = new Field("ATTACHMENT", "T_CREDIT_BONUS",DbType.AnsiString, null, "附件");
            /// <summary>
			/// 状态
			/// </summary>
			public readonly static Field STATE = new Field("STATE", "T_CREDIT_BONUS", "状态");
            /// <summary>
			/// 提交时间
			/// </summary>
			public readonly static Field COMMIT_TIME = new Field("COMMIT_TIME", "T_CREDIT_BONUS", "提交时间");
            /// <summary>
			/// 审核意见
			/// </summary>
			public readonly static Field AUDIT_OPINION = new Field("AUDIT_OPINION", "T_CREDIT_BONUS", "审核意见");
            /// <summary>
			/// 发布人员ID
			/// </summary>
			public readonly static Field USER_ID = new Field("USER_ID", "T_CREDIT_BONUS", "发布人员ID");
            /// <summary>
			/// 主体代码
			/// </summary>
			public readonly static Field BODY_CODE = new Field("BODY_CODE", "T_CREDIT_BONUS", "主体代码");
            /// <summary>
			/// 主体类别
			/// </summary>
			public readonly static Field BODY_TYPE = new Field("BODY_TYPE", "T_CREDIT_BONUS", "主体类别");
            /// <summary>
			/// 主体角色
			/// </summary>
			public readonly static Field BODY_ROLE = new Field("BODY_ROLE", "T_CREDIT_BONUS", "主体角色");
            /// <summary>
			/// 奖惩类型
			/// </summary>
			public readonly static Field REWARD_TYPE = new Field("REWARD_TYPE", "T_CREDIT_BONUS", "奖惩类型");
            /// <summary>
			/// 奖励日期
			/// </summary>
			public readonly static Field REWARD_TIME = new Field("REWARD_TIME", "T_CREDIT_BONUS", "奖励日期");
            /// <summary>
			/// 处理文件文号
			/// </summary>
			public readonly static Field DOCUMENT_NO = new Field("DOCUMENT_NO", "T_CREDIT_BONUS", "处理文件文号");
            /// <summary>
			/// 公开范围
			/// </summary>
			public readonly static Field PUBLIC_SCOPE = new Field("PUBLIC_SCOPE", "T_CREDIT_BONUS", "公开范围");
        }
        #endregion
	}
}