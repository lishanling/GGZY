using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_PROJECT_WARN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_PROJECT_WARN")]
    [Serializable]
    public partial class T_PROJECT_WARN : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _CODE;
		private string _TENDER_PROJECT_CODE;
		private string _STATUS;
		private string _MPIDS;
		private string _CONTENT;
		private decimal? _SP_UID;
		private string _SP_YJ;
		private DateTime? _SP_TM;
		private decimal? _CREATE_UID;
		private DateTime? _CREATE_TM;
		private string _JS_PNOS;
		private decimal? _IS_SENDMSG;

		/// <summary>
		/// 
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
		/// 预警编号
		/// </summary>
		public string CODE
		{
			get{ return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
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
		/// 状态
		/// </summary>
		public string STATUS
		{
			get{ return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 监督点ID
		/// </summary>
		public string MPIDS
		{
			get{ return _MPIDS; }
			set
			{
				this.OnPropertyValueChange(_.MPIDS, _MPIDS, value);
				this._MPIDS = value;
			}
		}
		/// <summary>
		/// 预警内容
		/// </summary>
		public string CONTENT
		{
			get{ return _CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTENT, _CONTENT, value);
				this._CONTENT = value;
			}
		}
		/// <summary>
		/// 审批人
		/// </summary>
		public decimal? SP_UID
		{
			get{ return _SP_UID; }
			set
			{
				this.OnPropertyValueChange(_.SP_UID, _SP_UID, value);
				this._SP_UID = value;
			}
		}
		/// <summary>
		/// 审批意见
		/// </summary>
		public string SP_YJ
		{
			get{ return _SP_YJ; }
			set
			{
				this.OnPropertyValueChange(_.SP_YJ, _SP_YJ, value);
				this._SP_YJ = value;
			}
		}
		/// <summary>
		/// 审批时间
		/// </summary>
		public DateTime? SP_TM
		{
			get{ return _SP_TM; }
			set
			{
				this.OnPropertyValueChange(_.SP_TM, _SP_TM, value);
				this._SP_TM = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public decimal? CREATE_UID
		{
			get{ return _CREATE_UID; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_UID, _CREATE_UID, value);
				this._CREATE_UID = value;
			}
		}
		/// <summary>
		/// 创建时间
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
		/// 接收人号码
		/// </summary>
		public string JS_PNOS
		{
			get{ return _JS_PNOS; }
			set
			{
				this.OnPropertyValueChange(_.JS_PNOS, _JS_PNOS, value);
				this._JS_PNOS = value;
			}
		}
		/// <summary>
		/// 是否发送短信
		/// </summary>
		public decimal? IS_SENDMSG
		{
			get{ return _IS_SENDMSG; }
			set
			{
				this.OnPropertyValueChange(_.IS_SENDMSG, _IS_SENDMSG, value);
				this._IS_SENDMSG = value;
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
				_.CODE,
				_.TENDER_PROJECT_CODE,
				_.STATUS,
				_.MPIDS,
				_.CONTENT,
				_.SP_UID,
				_.SP_YJ,
				_.SP_TM,
				_.CREATE_UID,
				_.CREATE_TM,
				_.JS_PNOS,
				_.IS_SENDMSG,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._CODE,
				this._TENDER_PROJECT_CODE,
				this._STATUS,
				this._MPIDS,
				this._CONTENT,
				this._SP_UID,
				this._SP_YJ,
				this._SP_TM,
				this._CREATE_UID,
				this._CREATE_TM,
				this._JS_PNOS,
				this._IS_SENDMSG,
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
			public readonly static Field All = new Field("*", "T_PROJECT_WARN");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_PROJECT_WARN", "");
            /// <summary>
			/// 预警编号
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "T_PROJECT_WARN", "预警编号");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_PROJECT_WARN", "招标项目编号");
            /// <summary>
			/// 状态
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "T_PROJECT_WARN", "状态");
            /// <summary>
			/// 监督点ID
			/// </summary>
			public readonly static Field MPIDS = new Field("MPIDS", "T_PROJECT_WARN", "监督点ID");
            /// <summary>
			/// 预警内容
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "T_PROJECT_WARN", "预警内容");
            /// <summary>
			/// 审批人
			/// </summary>
			public readonly static Field SP_UID = new Field("SP_UID", "T_PROJECT_WARN", "审批人");
            /// <summary>
			/// 审批意见
			/// </summary>
			public readonly static Field SP_YJ = new Field("SP_YJ", "T_PROJECT_WARN", "审批意见");
            /// <summary>
			/// 审批时间
			/// </summary>
			public readonly static Field SP_TM = new Field("SP_TM", "T_PROJECT_WARN", "审批时间");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATE_UID = new Field("CREATE_UID", "T_PROJECT_WARN", "创建人");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_PROJECT_WARN", "创建时间");
            /// <summary>
			/// 接收人号码
			/// </summary>
			public readonly static Field JS_PNOS = new Field("JS_PNOS", "T_PROJECT_WARN", "接收人号码");
            /// <summary>
			/// 是否发送短信
			/// </summary>
			public readonly static Field IS_SENDMSG = new Field("IS_SENDMSG", "T_PROJECT_WARN", "是否发送短信");
        }
        #endregion
	}
}