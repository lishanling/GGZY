using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_DISHONESTY_EXPOSURE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_DISHONESTY_EXPOSURE")]
    [Serializable]
    public partial class T_DISHONESTY_EXPOSURE : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _TITLE;
		private string _COMPANY_NAME;
		private string _COMPANY_ADDRESS;
		private string _DISHONESTY_CONTENT;
		private string _PUNISHMENT_RESULT;
		private string _PUNISHMENT_BASIS;
		private DateTime? _PUNISHMENT_DATE;
		private DateTime? _PUNISHMENT_DEADLINE;
		private string _ENFORCEMENT_UNIT;
		private string _AUDIT_STAFF;
		private string _AUDIT_OPINION;
		private string _ATTACHMENT;
		private string _STATE;
		private DateTime? _COMMIT_TIME;
		private DateTime? _AUDIT_TIME;
		private decimal? _USER_ID;

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
		/// 企业名称
		/// </summary>
		public string COMPANY_NAME
		{
			get{ return _COMPANY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.COMPANY_NAME, _COMPANY_NAME, value);
				this._COMPANY_NAME = value;
			}
		}
		/// <summary>
		/// 企业地址
		/// </summary>
		public string COMPANY_ADDRESS
		{
			get{ return _COMPANY_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.COMPANY_ADDRESS, _COMPANY_ADDRESS, value);
				this._COMPANY_ADDRESS = value;
			}
		}
		/// <summary>
		/// 严重违法失信行为的具体情况
		/// </summary>
		public string DISHONESTY_CONTENT
		{
			get{ return _DISHONESTY_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.DISHONESTY_CONTENT, _DISHONESTY_CONTENT, value);
				this._DISHONESTY_CONTENT = value;
			}
		}
		/// <summary>
		/// 处罚结果
		/// </summary>
		public string PUNISHMENT_RESULT
		{
			get{ return _PUNISHMENT_RESULT; }
			set
			{
				this.OnPropertyValueChange(_.PUNISHMENT_RESULT, _PUNISHMENT_RESULT, value);
				this._PUNISHMENT_RESULT = value;
			}
		}
		/// <summary>
		/// 处罚依据
		/// </summary>
		public string PUNISHMENT_BASIS
		{
			get{ return _PUNISHMENT_BASIS; }
			set
			{
				this.OnPropertyValueChange(_.PUNISHMENT_BASIS, _PUNISHMENT_BASIS, value);
				this._PUNISHMENT_BASIS = value;
			}
		}
		/// <summary>
		/// 处罚日期
		/// </summary>
		public DateTime? PUNISHMENT_DATE
		{
			get{ return _PUNISHMENT_DATE; }
			set
			{
				this.OnPropertyValueChange(_.PUNISHMENT_DATE, _PUNISHMENT_DATE, value);
				this._PUNISHMENT_DATE = value;
			}
		}
		/// <summary>
		/// 处罚截止日期
		/// </summary>
		public DateTime? PUNISHMENT_DEADLINE
		{
			get{ return _PUNISHMENT_DEADLINE; }
			set
			{
				this.OnPropertyValueChange(_.PUNISHMENT_DEADLINE, _PUNISHMENT_DEADLINE, value);
				this._PUNISHMENT_DEADLINE = value;
			}
		}
		/// <summary>
		/// 执法单位
		/// </summary>
		public string ENFORCEMENT_UNIT
		{
			get{ return _ENFORCEMENT_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.ENFORCEMENT_UNIT, _ENFORCEMENT_UNIT, value);
				this._ENFORCEMENT_UNIT = value;
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
				_.COMPANY_NAME,
				_.COMPANY_ADDRESS,
				_.DISHONESTY_CONTENT,
				_.PUNISHMENT_RESULT,
				_.PUNISHMENT_BASIS,
				_.PUNISHMENT_DATE,
				_.PUNISHMENT_DEADLINE,
				_.ENFORCEMENT_UNIT,
				_.AUDIT_STAFF,
				_.AUDIT_OPINION,
				_.ATTACHMENT,
				_.STATE,
				_.COMMIT_TIME,
				_.AUDIT_TIME,
				_.USER_ID,
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
				this._COMPANY_NAME,
				this._COMPANY_ADDRESS,
				this._DISHONESTY_CONTENT,
				this._PUNISHMENT_RESULT,
				this._PUNISHMENT_BASIS,
				this._PUNISHMENT_DATE,
				this._PUNISHMENT_DEADLINE,
				this._ENFORCEMENT_UNIT,
				this._AUDIT_STAFF,
				this._AUDIT_OPINION,
				this._ATTACHMENT,
				this._STATE,
				this._COMMIT_TIME,
				this._AUDIT_TIME,
				this._USER_ID,
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
			public readonly static Field All = new Field("*", "T_DISHONESTY_EXPOSURE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_DISHONESTY_EXPOSURE", "ID");
            /// <summary>
			/// 标题
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "T_DISHONESTY_EXPOSURE", "标题");
            /// <summary>
			/// 企业名称
			/// </summary>
			public readonly static Field COMPANY_NAME = new Field("COMPANY_NAME", "T_DISHONESTY_EXPOSURE", "企业名称");
            /// <summary>
			/// 企业地址
			/// </summary>
			public readonly static Field COMPANY_ADDRESS = new Field("COMPANY_ADDRESS", "T_DISHONESTY_EXPOSURE", "企业地址");
            /// <summary>
			/// 严重违法失信行为的具体情况
			/// </summary>
			public readonly static Field DISHONESTY_CONTENT = new Field("DISHONESTY_CONTENT", "T_DISHONESTY_EXPOSURE", "严重违法失信行为的具体情况");
            /// <summary>
			/// 处罚结果
			/// </summary>
			public readonly static Field PUNISHMENT_RESULT = new Field("PUNISHMENT_RESULT", "T_DISHONESTY_EXPOSURE", "处罚结果");
            /// <summary>
			/// 处罚依据
			/// </summary>
			public readonly static Field PUNISHMENT_BASIS = new Field("PUNISHMENT_BASIS", "T_DISHONESTY_EXPOSURE", "处罚依据");
            /// <summary>
			/// 处罚日期
			/// </summary>
			public readonly static Field PUNISHMENT_DATE = new Field("PUNISHMENT_DATE", "T_DISHONESTY_EXPOSURE", "处罚日期");
            /// <summary>
			/// 处罚截止日期
			/// </summary>
			public readonly static Field PUNISHMENT_DEADLINE = new Field("PUNISHMENT_DEADLINE", "T_DISHONESTY_EXPOSURE", "处罚截止日期");
            /// <summary>
			/// 执法单位
			/// </summary>
			public readonly static Field ENFORCEMENT_UNIT = new Field("ENFORCEMENT_UNIT", "T_DISHONESTY_EXPOSURE", "执法单位");
            /// <summary>
			/// 审核人员
			/// </summary>
			public readonly static Field AUDIT_STAFF = new Field("AUDIT_STAFF", "T_DISHONESTY_EXPOSURE", "审核人员");
            /// <summary>
			/// 审核意见
			/// </summary>
			public readonly static Field AUDIT_OPINION = new Field("AUDIT_OPINION", "T_DISHONESTY_EXPOSURE", "审核意见");
            /// <summary>
			/// 附件
			/// </summary>
			public readonly static Field ATTACHMENT = new Field("ATTACHMENT", "T_DISHONESTY_EXPOSURE",DbType.AnsiString, null, "附件");
            /// <summary>
			/// 状态
			/// </summary>
			public readonly static Field STATE = new Field("STATE", "T_DISHONESTY_EXPOSURE", "状态");
            /// <summary>
			/// 提交时间
			/// </summary>
			public readonly static Field COMMIT_TIME = new Field("COMMIT_TIME", "T_DISHONESTY_EXPOSURE", "提交时间");
            /// <summary>
			/// 审核时间
			/// </summary>
			public readonly static Field AUDIT_TIME = new Field("AUDIT_TIME", "T_DISHONESTY_EXPOSURE", "审核时间");
            /// <summary>
			/// 发布人员ID
			/// </summary>
			public readonly static Field USER_ID = new Field("USER_ID", "T_DISHONESTY_EXPOSURE", "发布人员ID");
        }
        #endregion
	}
}