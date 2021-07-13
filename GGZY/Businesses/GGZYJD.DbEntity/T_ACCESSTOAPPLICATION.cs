using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_ACCESSTOAPPLICATION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_ACCESSTOAPPLICATION")]
    [Serializable]
    public partial class T_ACCESSTOAPPLICATION : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _TITLE;
		private string _BOROW_CONTENT;
		private string _AUDIT_STAFF;
		private DateTime? _AUDIT_TIME;
		private string _ATTACHMENT;
		private string _STATE;
		private DateTime? _COMMIT_TIME;
		private string _AUDIT_OPINION;
		private decimal? _USER_ID;
		private decimal? _AUDIT_DEPID;
		private string _PROJECT_IDS;
		private DateTime? _EXPIRE_TM;

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
		/// 借阅内容
		/// </summary>
		public string BOROW_CONTENT
		{
			get{ return _BOROW_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BOROW_CONTENT, _BOROW_CONTENT, value);
				this._BOROW_CONTENT = value;
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
		public DateTime? AUDIT_TIME
		{
			get{ return _AUDIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_TIME, _AUDIT_TIME, value);
				this._AUDIT_TIME = value;
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
		/// 借阅人员ID
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
		/// 审核机构ID
		/// </summary>
		public decimal? AUDIT_DEPID
		{
			get{ return _AUDIT_DEPID; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_DEPID, _AUDIT_DEPID, value);
				this._AUDIT_DEPID = value;
			}
		}
		/// <summary>
		/// 调阅项目id，多个用“,”分割
		/// </summary>
		public string PROJECT_IDS
		{
			get{ return _PROJECT_IDS; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_IDS, _PROJECT_IDS, value);
				this._PROJECT_IDS = value;
			}
		}
		/// <summary>
		/// 调阅过期时间
		/// </summary>
		public DateTime? EXPIRE_TM
		{
			get{ return _EXPIRE_TM; }
			set
			{
				this.OnPropertyValueChange(_.EXPIRE_TM, _EXPIRE_TM, value);
				this._EXPIRE_TM = value;
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
				_.BOROW_CONTENT,
				_.AUDIT_STAFF,
				_.AUDIT_TIME,
				_.ATTACHMENT,
				_.STATE,
				_.COMMIT_TIME,
				_.AUDIT_OPINION,
				_.USER_ID,
				_.AUDIT_DEPID,
				_.PROJECT_IDS,
				_.EXPIRE_TM,
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
				this._BOROW_CONTENT,
				this._AUDIT_STAFF,
				this._AUDIT_TIME,
				this._ATTACHMENT,
				this._STATE,
				this._COMMIT_TIME,
				this._AUDIT_OPINION,
				this._USER_ID,
				this._AUDIT_DEPID,
				this._PROJECT_IDS,
				this._EXPIRE_TM,
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
			public readonly static Field All = new Field("*", "T_ACCESSTOAPPLICATION");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_ACCESSTOAPPLICATION", "ID");
            /// <summary>
			/// 标题
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "T_ACCESSTOAPPLICATION", "标题");
            /// <summary>
			/// 借阅内容
			/// </summary>
			public readonly static Field BOROW_CONTENT = new Field("BOROW_CONTENT", "T_ACCESSTOAPPLICATION", "借阅内容");
            /// <summary>
			/// 审核人员
			/// </summary>
			public readonly static Field AUDIT_STAFF = new Field("AUDIT_STAFF", "T_ACCESSTOAPPLICATION", "审核人员");
            /// <summary>
			/// 审核时间
			/// </summary>
			public readonly static Field AUDIT_TIME = new Field("AUDIT_TIME", "T_ACCESSTOAPPLICATION", "审核时间");
            /// <summary>
			/// 附件
			/// </summary>
			public readonly static Field ATTACHMENT = new Field("ATTACHMENT", "T_ACCESSTOAPPLICATION",DbType.AnsiString, null, "附件");
            /// <summary>
			/// 状态
			/// </summary>
			public readonly static Field STATE = new Field("STATE", "T_ACCESSTOAPPLICATION", "状态");
            /// <summary>
			/// 提交时间
			/// </summary>
			public readonly static Field COMMIT_TIME = new Field("COMMIT_TIME", "T_ACCESSTOAPPLICATION", "提交时间");
            /// <summary>
			/// 审核意见
			/// </summary>
			public readonly static Field AUDIT_OPINION = new Field("AUDIT_OPINION", "T_ACCESSTOAPPLICATION", "审核意见");
            /// <summary>
			/// 借阅人员ID
			/// </summary>
			public readonly static Field USER_ID = new Field("USER_ID", "T_ACCESSTOAPPLICATION", "借阅人员ID");
            /// <summary>
			/// 审核机构ID
			/// </summary>
			public readonly static Field AUDIT_DEPID = new Field("AUDIT_DEPID", "T_ACCESSTOAPPLICATION", "审核机构ID");
            /// <summary>
			/// 调阅项目id，多个用“,”分割
			/// </summary>
			public readonly static Field PROJECT_IDS = new Field("PROJECT_IDS", "T_ACCESSTOAPPLICATION", "调阅项目id，多个用“,”分割");
            /// <summary>
			/// 调阅过期时间
			/// </summary>
			public readonly static Field EXPIRE_TM = new Field("EXPIRE_TM", "T_ACCESSTOAPPLICATION", "调阅过期时间");
        }
        #endregion
	}
}