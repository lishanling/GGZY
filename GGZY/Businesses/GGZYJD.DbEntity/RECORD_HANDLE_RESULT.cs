using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类RECORD_HANDLE_RESULT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("RECORD_HANDLE_RESULT")]
    [Serializable]
    public partial class RECORD_HANDLE_RESULT : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _RECORD_ID;
		private string _BID_SECTION_CODES;
		private string _DISSENT_CODE;
		private string _DISSENT_NAME;
		private string _DISSENT_CONTRACT;
		private string _COMPLAINED_NAME;
		private string _COMPLAINED_CODE;
		private string _COMPLAINED_TYPE;
		private string _COMPLAINED_CONTRACT;
		private DateTime? _DISSENT_COMMIT_TIME;
		private string _DISSENT_TYPE;
		private string _DISSENT_CONTENT;
		private string _GROUND_REASON;
		private DateTime? _IS_ACCEPT_TIME;
		private string _DISSENT_OPINION;
		private string _HANDLE_RESULT;
		private string _HANDLE_BASIS;
		private DateTime? _HANDLE_TIME;
		private DateTime? _CREATE_TM;
		private decimal? _CREATOR;

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
		/// 备案主表ID
		/// </summary>
		public decimal? RECORD_ID
		{
			get{ return _RECORD_ID; }
			set
			{
				this.OnPropertyValueChange(_.RECORD_ID, _RECORD_ID, value);
				this._RECORD_ID = value;
			}
		}
		/// <summary>
		/// 相关标段编码
		/// </summary>
		public string BID_SECTION_CODES
		{
			get{ return _BID_SECTION_CODES; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODES, _BID_SECTION_CODES, value);
				this._BID_SECTION_CODES = value;
			}
		}
		/// <summary>
		/// 异议人代码
		/// </summary>
		public string DISSENT_CODE
		{
			get{ return _DISSENT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.DISSENT_CODE, _DISSENT_CODE, value);
				this._DISSENT_CODE = value;
			}
		}
		/// <summary>
		/// 异议人名称
		/// </summary>
		public string DISSENT_NAME
		{
			get{ return _DISSENT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.DISSENT_NAME, _DISSENT_NAME, value);
				this._DISSENT_NAME = value;
			}
		}
		/// <summary>
		/// 异议人联系方式
		/// </summary>
		public string DISSENT_CONTRACT
		{
			get{ return _DISSENT_CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.DISSENT_CONTRACT, _DISSENT_CONTRACT, value);
				this._DISSENT_CONTRACT = value;
			}
		}
		/// <summary>
		/// 被异议人名称
		/// </summary>
		public string COMPLAINED_NAME
		{
			get{ return _COMPLAINED_NAME; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINED_NAME, _COMPLAINED_NAME, value);
				this._COMPLAINED_NAME = value;
			}
		}
		/// <summary>
		/// 被异议人代码
		/// </summary>
		public string COMPLAINED_CODE
		{
			get{ return _COMPLAINED_CODE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINED_CODE, _COMPLAINED_CODE, value);
				this._COMPLAINED_CODE = value;
			}
		}
		/// <summary>
		/// 被异议人类型
		/// </summary>
		public string COMPLAINED_TYPE
		{
			get{ return _COMPLAINED_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINED_TYPE, _COMPLAINED_TYPE, value);
				this._COMPLAINED_TYPE = value;
			}
		}
		/// <summary>
		/// 被异议人联系方式
		/// </summary>
		public string COMPLAINED_CONTRACT
		{
			get{ return _COMPLAINED_CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINED_CONTRACT, _COMPLAINED_CONTRACT, value);
				this._COMPLAINED_CONTRACT = value;
			}
		}
		/// <summary>
		/// 异议提出时间
		/// </summary>
		public DateTime? DISSENT_COMMIT_TIME
		{
			get{ return _DISSENT_COMMIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.DISSENT_COMMIT_TIME, _DISSENT_COMMIT_TIME, value);
				this._DISSENT_COMMIT_TIME = value;
			}
		}
		/// <summary>
		/// 异议类型
		/// </summary>
		public string DISSENT_TYPE
		{
			get{ return _DISSENT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.DISSENT_TYPE, _DISSENT_TYPE, value);
				this._DISSENT_TYPE = value;
			}
		}
		/// <summary>
		/// 异议内容
		/// </summary>
		public string DISSENT_CONTENT
		{
			get{ return _DISSENT_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.DISSENT_CONTENT, _DISSENT_CONTENT, value);
				this._DISSENT_CONTENT = value;
			}
		}
		/// <summary>
		/// 依据和理由
		/// </summary>
		public string GROUND_REASON
		{
			get{ return _GROUND_REASON; }
			set
			{
				this.OnPropertyValueChange(_.GROUND_REASON, _GROUND_REASON, value);
				this._GROUND_REASON = value;
			}
		}
		/// <summary>
		/// 作出是否受理的时间
		/// </summary>
		public DateTime? IS_ACCEPT_TIME
		{
			get{ return _IS_ACCEPT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.IS_ACCEPT_TIME, _IS_ACCEPT_TIME, value);
				this._IS_ACCEPT_TIME = value;
			}
		}
		/// <summary>
		/// 异议处理意见
		/// </summary>
		public string DISSENT_OPINION
		{
			get{ return _DISSENT_OPINION; }
			set
			{
				this.OnPropertyValueChange(_.DISSENT_OPINION, _DISSENT_OPINION, value);
				this._DISSENT_OPINION = value;
			}
		}
		/// <summary>
		/// 处理结果
		/// </summary>
		public string HANDLE_RESULT
		{
			get{ return _HANDLE_RESULT; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_RESULT, _HANDLE_RESULT, value);
				this._HANDLE_RESULT = value;
			}
		}
		/// <summary>
		/// 处理依据
		/// </summary>
		public string HANDLE_BASIS
		{
			get{ return _HANDLE_BASIS; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_BASIS, _HANDLE_BASIS, value);
				this._HANDLE_BASIS = value;
			}
		}
		/// <summary>
		/// 处理时间
		/// </summary>
		public DateTime? HANDLE_TIME
		{
			get{ return _HANDLE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_TIME, _HANDLE_TIME, value);
				this._HANDLE_TIME = value;
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
		/// 创建人
		/// </summary>
		public decimal? CREATOR
		{
			get{ return _CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.CREATOR, _CREATOR, value);
				this._CREATOR = value;
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
				_.RECORD_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.RECORD_ID,
				_.BID_SECTION_CODES,
				_.DISSENT_CODE,
				_.DISSENT_NAME,
				_.DISSENT_CONTRACT,
				_.COMPLAINED_NAME,
				_.COMPLAINED_CODE,
				_.COMPLAINED_TYPE,
				_.COMPLAINED_CONTRACT,
				_.DISSENT_COMMIT_TIME,
				_.DISSENT_TYPE,
				_.DISSENT_CONTENT,
				_.GROUND_REASON,
				_.IS_ACCEPT_TIME,
				_.DISSENT_OPINION,
				_.HANDLE_RESULT,
				_.HANDLE_BASIS,
				_.HANDLE_TIME,
				_.CREATE_TM,
				_.CREATOR,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._RECORD_ID,
				this._BID_SECTION_CODES,
				this._DISSENT_CODE,
				this._DISSENT_NAME,
				this._DISSENT_CONTRACT,
				this._COMPLAINED_NAME,
				this._COMPLAINED_CODE,
				this._COMPLAINED_TYPE,
				this._COMPLAINED_CONTRACT,
				this._DISSENT_COMMIT_TIME,
				this._DISSENT_TYPE,
				this._DISSENT_CONTENT,
				this._GROUND_REASON,
				this._IS_ACCEPT_TIME,
				this._DISSENT_OPINION,
				this._HANDLE_RESULT,
				this._HANDLE_BASIS,
				this._HANDLE_TIME,
				this._CREATE_TM,
				this._CREATOR,
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
			public readonly static Field All = new Field("*", "RECORD_HANDLE_RESULT");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "RECORD_HANDLE_RESULT", "ID");
            /// <summary>
			/// 备案主表ID
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "RECORD_HANDLE_RESULT", "备案主表ID");
            /// <summary>
			/// 相关标段编码
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "RECORD_HANDLE_RESULT",DbType.AnsiString, null, "相关标段编码");
            /// <summary>
			/// 异议人代码
			/// </summary>
			public readonly static Field DISSENT_CODE = new Field("DISSENT_CODE", "RECORD_HANDLE_RESULT", "异议人代码");
            /// <summary>
			/// 异议人名称
			/// </summary>
			public readonly static Field DISSENT_NAME = new Field("DISSENT_NAME", "RECORD_HANDLE_RESULT", "异议人名称");
            /// <summary>
			/// 异议人联系方式
			/// </summary>
			public readonly static Field DISSENT_CONTRACT = new Field("DISSENT_CONTRACT", "RECORD_HANDLE_RESULT", "异议人联系方式");
            /// <summary>
			/// 被异议人名称
			/// </summary>
			public readonly static Field COMPLAINED_NAME = new Field("COMPLAINED_NAME", "RECORD_HANDLE_RESULT", "被异议人名称");
            /// <summary>
			/// 被异议人代码
			/// </summary>
			public readonly static Field COMPLAINED_CODE = new Field("COMPLAINED_CODE", "RECORD_HANDLE_RESULT", "被异议人代码");
            /// <summary>
			/// 被异议人类型
			/// </summary>
			public readonly static Field COMPLAINED_TYPE = new Field("COMPLAINED_TYPE", "RECORD_HANDLE_RESULT", "被异议人类型");
            /// <summary>
			/// 被异议人联系方式
			/// </summary>
			public readonly static Field COMPLAINED_CONTRACT = new Field("COMPLAINED_CONTRACT", "RECORD_HANDLE_RESULT", "被异议人联系方式");
            /// <summary>
			/// 异议提出时间
			/// </summary>
			public readonly static Field DISSENT_COMMIT_TIME = new Field("DISSENT_COMMIT_TIME", "RECORD_HANDLE_RESULT", "异议提出时间");
            /// <summary>
			/// 异议类型
			/// </summary>
			public readonly static Field DISSENT_TYPE = new Field("DISSENT_TYPE", "RECORD_HANDLE_RESULT", "异议类型");
            /// <summary>
			/// 异议内容
			/// </summary>
			public readonly static Field DISSENT_CONTENT = new Field("DISSENT_CONTENT", "RECORD_HANDLE_RESULT",DbType.AnsiString, null, "异议内容");
            /// <summary>
			/// 依据和理由
			/// </summary>
			public readonly static Field GROUND_REASON = new Field("GROUND_REASON", "RECORD_HANDLE_RESULT",DbType.AnsiString, null, "依据和理由");
            /// <summary>
			/// 作出是否受理的时间
			/// </summary>
			public readonly static Field IS_ACCEPT_TIME = new Field("IS_ACCEPT_TIME", "RECORD_HANDLE_RESULT", "作出是否受理的时间");
            /// <summary>
			/// 异议处理意见
			/// </summary>
			public readonly static Field DISSENT_OPINION = new Field("DISSENT_OPINION", "RECORD_HANDLE_RESULT", "异议处理意见");
            /// <summary>
			/// 处理结果
			/// </summary>
			public readonly static Field HANDLE_RESULT = new Field("HANDLE_RESULT", "RECORD_HANDLE_RESULT",DbType.AnsiString, null, "处理结果");
            /// <summary>
			/// 处理依据
			/// </summary>
			public readonly static Field HANDLE_BASIS = new Field("HANDLE_BASIS", "RECORD_HANDLE_RESULT",DbType.AnsiString, null, "处理依据");
            /// <summary>
			/// 处理时间
			/// </summary>
			public readonly static Field HANDLE_TIME = new Field("HANDLE_TIME", "RECORD_HANDLE_RESULT", "处理时间");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "RECORD_HANDLE_RESULT", "创建时间");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "RECORD_HANDLE_RESULT", "创建人");
        }
        #endregion
	}
}