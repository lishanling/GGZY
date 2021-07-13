using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类REVIEW_INSTANCE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("REVIEW_INSTANCE")]
    [Serializable]
    public partial class REVIEW_INSTANCE : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _BA_ID;
		private decimal? _MAIN_ID;
		private decimal? _NOW_NODE;
		private decimal? _IS_END;
		private DateTime? _CREATE_TM;
		private decimal? _CREATE_BY;
		private string _NOW_USERS;
		private string _STAFF;
		private DateTime? _TIMEOUT;
		private decimal? _IS_BACK;
		private string _BACK_MSG;
		private string _TENDER_PROJECT_CODE;
		private string _QTR;

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
		/// 备案ID
		/// </summary>
		public decimal? BA_ID
		{
			get{ return _BA_ID; }
			set
			{
				this.OnPropertyValueChange(_.BA_ID, _BA_ID, value);
				this._BA_ID = value;
			}
		}
		/// <summary>
		/// 审查机制ID
		/// </summary>
		public decimal? MAIN_ID
		{
			get{ return _MAIN_ID; }
			set
			{
				this.OnPropertyValueChange(_.MAIN_ID, _MAIN_ID, value);
				this._MAIN_ID = value;
			}
		}
		/// <summary>
		/// 所处节点ID
		/// </summary>
		public decimal? NOW_NODE
		{
			get{ return _NOW_NODE; }
			set
			{
				this.OnPropertyValueChange(_.NOW_NODE, _NOW_NODE, value);
				this._NOW_NODE = value;
			}
		}
		/// <summary>
		/// 是否结束
		/// </summary>
		public decimal? IS_END
		{
			get{ return _IS_END; }
			set
			{
				this.OnPropertyValueChange(_.IS_END, _IS_END, value);
				this._IS_END = value;
			}
		}
		/// <summary>
		/// CREATE_TM
		/// </summary>
		public DateTime? CREATE_TM
		{
			get{ return _CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TM, _CREATE_TM, value);
				this._CREATE_TM = value;
			}
		}
		/// <summary>
		/// CREATE_BY
		/// </summary>
		public decimal? CREATE_BY
		{
			get{ return _CREATE_BY; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_BY, _CREATE_BY, value);
				this._CREATE_BY = value;
			}
		}
		/// <summary>
		/// 当前处理人
		/// </summary>
		public string NOW_USERS
		{
			get{ return _NOW_USERS; }
			set
			{
				this.OnPropertyValueChange(_.NOW_USERS, _NOW_USERS, value);
				this._NOW_USERS = value;
			}
		}
		/// <summary>
		/// 已办人员
		/// </summary>
		public string STAFF
		{
			get{ return _STAFF; }
			set
			{
				this.OnPropertyValueChange(_.STAFF, _STAFF, value);
				this._STAFF = value;
			}
		}
		/// <summary>
		/// 超时时间
		/// </summary>
		public DateTime? TIMEOUT
		{
			get{ return _TIMEOUT; }
			set
			{
				this.OnPropertyValueChange(_.TIMEOUT, _TIMEOUT, value);
				this._TIMEOUT = value;
			}
		}
		/// <summary>
		/// 当前流程是否是被退回
		/// </summary>
		public decimal? IS_BACK
		{
			get{ return _IS_BACK; }
			set
			{
				this.OnPropertyValueChange(_.IS_BACK, _IS_BACK, value);
				this._IS_BACK = value;
			}
		}
		/// <summary>
		/// 退回意见
		/// </summary>
		public string BACK_MSG
		{
			get{ return _BACK_MSG; }
			set
			{
				this.OnPropertyValueChange(_.BACK_MSG, _BACK_MSG, value);
				this._BACK_MSG = value;
			}
		}
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get{ return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 牵头人
		/// </summary>
		public string QTR
		{
			get{ return _QTR; }
			set
			{
				this.OnPropertyValueChange(_.QTR, _QTR, value);
				this._QTR = value;
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
				_.BA_ID,
				_.MAIN_ID,
				_.NOW_NODE,
				_.IS_END,
				_.CREATE_TM,
				_.CREATE_BY,
				_.NOW_USERS,
				_.STAFF,
				_.TIMEOUT,
				_.IS_BACK,
				_.BACK_MSG,
				_.TENDER_PROJECT_CODE,
				_.QTR,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._BA_ID,
				this._MAIN_ID,
				this._NOW_NODE,
				this._IS_END,
				this._CREATE_TM,
				this._CREATE_BY,
				this._NOW_USERS,
				this._STAFF,
				this._TIMEOUT,
				this._IS_BACK,
				this._BACK_MSG,
				this._TENDER_PROJECT_CODE,
				this._QTR,
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
			public readonly static Field All = new Field("*", "REVIEW_INSTANCE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "REVIEW_INSTANCE", "ID");
            /// <summary>
			/// 备案ID
			/// </summary>
			public readonly static Field BA_ID = new Field("BA_ID", "REVIEW_INSTANCE", "备案ID");
            /// <summary>
			/// 审查机制ID
			/// </summary>
			public readonly static Field MAIN_ID = new Field("MAIN_ID", "REVIEW_INSTANCE", "审查机制ID");
            /// <summary>
			/// 所处节点ID
			/// </summary>
			public readonly static Field NOW_NODE = new Field("NOW_NODE", "REVIEW_INSTANCE", "所处节点ID");
            /// <summary>
			/// 是否结束
			/// </summary>
			public readonly static Field IS_END = new Field("IS_END", "REVIEW_INSTANCE", "是否结束");
            /// <summary>
			/// CREATE_TM
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "REVIEW_INSTANCE", "CREATE_TM");
            /// <summary>
			/// CREATE_BY
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "REVIEW_INSTANCE", "CREATE_BY");
            /// <summary>
			/// 当前处理人
			/// </summary>
			public readonly static Field NOW_USERS = new Field("NOW_USERS", "REVIEW_INSTANCE", "当前处理人");
            /// <summary>
			/// 已办人员
			/// </summary>
			public readonly static Field STAFF = new Field("STAFF", "REVIEW_INSTANCE", "已办人员");
            /// <summary>
			/// 超时时间
			/// </summary>
			public readonly static Field TIMEOUT = new Field("TIMEOUT", "REVIEW_INSTANCE", "超时时间");
            /// <summary>
			/// 当前流程是否是被退回
			/// </summary>
			public readonly static Field IS_BACK = new Field("IS_BACK", "REVIEW_INSTANCE", "当前流程是否是被退回");
            /// <summary>
			/// 退回意见
			/// </summary>
			public readonly static Field BACK_MSG = new Field("BACK_MSG", "REVIEW_INSTANCE", "退回意见");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "REVIEW_INSTANCE", "招标项目编号");
            /// <summary>
			/// 牵头人
			/// </summary>
			public readonly static Field QTR = new Field("QTR", "REVIEW_INSTANCE", "牵头人");
        }
        #endregion
	}
}