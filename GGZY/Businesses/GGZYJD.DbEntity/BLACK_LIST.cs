using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类BLACK_LIST。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BLACK_LIST")]
    [Serializable]
    public partial class BLACK_LIST : JdEntity
    {
        #region Model
		private string _BLACKLIST_CODE;
		private string _BODY_NAME;
		private string _BODY_CODE;
		private string _BODY_TYPE;
		private string _BODY_ROLE;
		private string _RECORD_REASON;
		private DateTime? _RECORD_DATE;
		private string _GOVERNMENT;
		private string _DOCUMENT_CODE;
		private decimal? _REVOCATION_STATUS;
		private string _CONFINED_ACTION;
		private decimal? _SCOPE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private string _M_ATT_BLACKLIST_DOC;
		private decimal? _USER_ID;
		private DateTime? _COMMIT_TIME;

		/// <summary>
		/// 黑名单标识号
		/// </summary>
		public string BLACKLIST_CODE
		{
			get{ return _BLACKLIST_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BLACKLIST_CODE, _BLACKLIST_CODE, value);
				this._BLACKLIST_CODE = value;
			}
		}
		/// <summary>
		/// 主体名称
		/// </summary>
		public string BODY_NAME
		{
			get{ return _BODY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BODY_NAME, _BODY_NAME, value);
				this._BODY_NAME = value;
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
		/// 处罚原因
		/// </summary>
		public string RECORD_REASON
		{
			get{ return _RECORD_REASON; }
			set
			{
				this.OnPropertyValueChange(_.RECORD_REASON, _RECORD_REASON, value);
				this._RECORD_REASON = value;
			}
		}
		/// <summary>
		/// 处罚日期
		/// </summary>
		public DateTime? RECORD_DATE
		{
			get{ return _RECORD_DATE; }
			set
			{
				this.OnPropertyValueChange(_.RECORD_DATE, _RECORD_DATE, value);
				this._RECORD_DATE = value;
			}
		}
		/// <summary>
		/// 处罚部门
		/// </summary>
		public string GOVERNMENT
		{
			get{ return _GOVERNMENT; }
			set
			{
				this.OnPropertyValueChange(_.GOVERNMENT, _GOVERNMENT, value);
				this._GOVERNMENT = value;
			}
		}
		/// <summary>
		/// 处理文件文号
		/// </summary>
		public string DOCUMENT_CODE
		{
			get{ return _DOCUMENT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.DOCUMENT_CODE, _DOCUMENT_CODE, value);
				this._DOCUMENT_CODE = value;
			}
		}
		/// <summary>
		/// 是否撤销
		/// </summary>
		public decimal? REVOCATION_STATUS
		{
			get{ return _REVOCATION_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.REVOCATION_STATUS, _REVOCATION_STATUS, value);
				this._REVOCATION_STATUS = value;
			}
		}
		/// <summary>
		/// 限制行为
		/// </summary>
		public string CONFINED_ACTION
		{
			get{ return _CONFINED_ACTION; }
			set
			{
				this.OnPropertyValueChange(_.CONFINED_ACTION, _CONFINED_ACTION, value);
				this._CONFINED_ACTION = value;
			}
		}
		/// <summary>
		/// 公开范围
		/// </summary>
		public decimal? SCOPE
		{
			get{ return _SCOPE; }
			set
			{
				this.OnPropertyValueChange(_.SCOPE, _SCOPE, value);
				this._SCOPE = value;
			}
		}
		/// <summary>
		/// 交易系统标识码
		/// </summary>
		public string PLATFORM_CODE
		{
			get{ return _PLATFORM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORM_CODE, _PLATFORM_CODE, value);
				this._PLATFORM_CODE = value;
			}
		}
		/// <summary>
		/// 公共服务平台标识码
		/// </summary>
		public string PUB_SERVICE_PLAT_CODE
		{
			get{ return _PUB_SERVICE_PLAT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PUB_SERVICE_PLAT_CODE, _PUB_SERVICE_PLAT_CODE, value);
				this._PUB_SERVICE_PLAT_CODE = value;
			}
		}
		/// <summary>
		/// 数据时间戳
		/// </summary>
		public DateTime? DATA_TIMESTAMP
		{
			get{ return _DATA_TIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATA_TIMESTAMP, _DATA_TIMESTAMP, value);
				this._DATA_TIMESTAMP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_KEY
		{
			get{ return _M_KEY; }
			set
			{
				this.OnPropertyValueChange(_.M_KEY, _M_KEY, value);
				this._M_KEY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_DATA_SOURCE
		{
			get{ return _M_DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_SOURCE, _M_DATA_SOURCE, value);
				this._M_DATA_SOURCE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? M_TM
		{
			get{ return _M_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_TM, _M_TM, value);
				this._M_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_ID
		{
			get{ return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
			}
		}
		/// <summary>
		/// 黑名单处理文件扫描件
		/// </summary>
		public string M_ATT_BLACKLIST_DOC
		{
			get{ return _M_ATT_BLACKLIST_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_BLACKLIST_DOC, _M_ATT_BLACKLIST_DOC, value);
				this._M_ATT_BLACKLIST_DOC = value;
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
		/// 发布时间
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
				_.BLACKLIST_CODE,
				_.BODY_NAME,
				_.BODY_CODE,
				_.BODY_TYPE,
				_.BODY_ROLE,
				_.RECORD_REASON,
				_.RECORD_DATE,
				_.GOVERNMENT,
				_.DOCUMENT_CODE,
				_.REVOCATION_STATUS,
				_.CONFINED_ACTION,
				_.SCOPE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
				_.M_ATT_BLACKLIST_DOC,
				_.USER_ID,
				_.COMMIT_TIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._BLACKLIST_CODE,
				this._BODY_NAME,
				this._BODY_CODE,
				this._BODY_TYPE,
				this._BODY_ROLE,
				this._RECORD_REASON,
				this._RECORD_DATE,
				this._GOVERNMENT,
				this._DOCUMENT_CODE,
				this._REVOCATION_STATUS,
				this._CONFINED_ACTION,
				this._SCOPE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
				this._M_ATT_BLACKLIST_DOC,
				this._USER_ID,
				this._COMMIT_TIME,
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
			public readonly static Field All = new Field("*", "BLACK_LIST");
            /// <summary>
			/// 黑名单标识号
			/// </summary>
			public readonly static Field BLACKLIST_CODE = new Field("BLACKLIST_CODE", "BLACK_LIST", "黑名单标识号");
            /// <summary>
			/// 主体名称
			/// </summary>
			public readonly static Field BODY_NAME = new Field("BODY_NAME", "BLACK_LIST", "主体名称");
            /// <summary>
			/// 主体代码
			/// </summary>
			public readonly static Field BODY_CODE = new Field("BODY_CODE", "BLACK_LIST", "主体代码");
            /// <summary>
			/// 主体类别
			/// </summary>
			public readonly static Field BODY_TYPE = new Field("BODY_TYPE", "BLACK_LIST", "主体类别");
            /// <summary>
			/// 主体角色
			/// </summary>
			public readonly static Field BODY_ROLE = new Field("BODY_ROLE", "BLACK_LIST", "主体角色");
            /// <summary>
			/// 处罚原因
			/// </summary>
			public readonly static Field RECORD_REASON = new Field("RECORD_REASON", "BLACK_LIST",DbType.AnsiString, null, "处罚原因");
            /// <summary>
			/// 处罚日期
			/// </summary>
			public readonly static Field RECORD_DATE = new Field("RECORD_DATE", "BLACK_LIST", "处罚日期");
            /// <summary>
			/// 处罚部门
			/// </summary>
			public readonly static Field GOVERNMENT = new Field("GOVERNMENT", "BLACK_LIST", "处罚部门");
            /// <summary>
			/// 处理文件文号
			/// </summary>
			public readonly static Field DOCUMENT_CODE = new Field("DOCUMENT_CODE", "BLACK_LIST", "处理文件文号");
            /// <summary>
			/// 是否撤销
			/// </summary>
			public readonly static Field REVOCATION_STATUS = new Field("REVOCATION_STATUS", "BLACK_LIST", "是否撤销");
            /// <summary>
			/// 限制行为
			/// </summary>
			public readonly static Field CONFINED_ACTION = new Field("CONFINED_ACTION", "BLACK_LIST", "限制行为");
            /// <summary>
			/// 公开范围
			/// </summary>
			public readonly static Field SCOPE = new Field("SCOPE", "BLACK_LIST", "公开范围");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "BLACK_LIST", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "BLACK_LIST", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "BLACK_LIST", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "BLACK_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "BLACK_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "BLACK_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "BLACK_LIST", "");
            /// <summary>
			/// 黑名单处理文件扫描件
			/// </summary>
			public readonly static Field M_ATT_BLACKLIST_DOC = new Field("M_ATT_BLACKLIST_DOC", "BLACK_LIST", "黑名单处理文件扫描件");
            /// <summary>
			/// 发布人员ID
			/// </summary>
			public readonly static Field USER_ID = new Field("USER_ID", "BLACK_LIST", "发布人员ID");
            /// <summary>
			/// 发布时间
			/// </summary>
			public readonly static Field COMMIT_TIME = new Field("COMMIT_TIME", "BLACK_LIST", "发布时间");
        }
        #endregion
	}
}