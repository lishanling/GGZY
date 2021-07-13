using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类WITHDRAW_BLACK_LIST。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("WITHDRAW_BLACK_LIST")]
    [Serializable]
    public partial class WITHDRAW_BLACK_LIST : FwEntity
    {
        #region Model
		private string _BODY_NAME;
		private string _BODY_CODE;
		private string _BODY_TYPE;
		private string _BODY_ROLE;
		private string _BLACKLIST_CODE;
		private string _REVOCATIONEASONS;
		private string _GOVERNMENT;
		private string _DOCUMENT_CODE;
		private string _ROPOSER;
		private DateTime? _APPLICATION_DATE;
		private decimal? _SCOPE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private string _M_ATT_UNDODOCDOC;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _M_VERSION;

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
		/// 黑名单
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
		/// 撤销理由
		/// </summary>
		public string REVOCATIONEASONS
		{
			get{ return _REVOCATIONEASONS; }
			set
			{
				this.OnPropertyValueChange(_.REVOCATIONEASONS, _REVOCATIONEASONS, value);
				this._REVOCATIONEASONS = value;
			}
		}
		/// <summary>
		/// 执行部门
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
		/// 申请人
		/// </summary>
		public string ROPOSER
		{
			get{ return _ROPOSER; }
			set
			{
				this.OnPropertyValueChange(_.ROPOSER, _ROPOSER, value);
				this._ROPOSER = value;
			}
		}
		/// <summary>
		/// 申请日期
		/// </summary>
		public DateTime? APPLICATION_DATE
		{
			get{ return _APPLICATION_DATE; }
			set
			{
				this.OnPropertyValueChange(_.APPLICATION_DATE, _APPLICATION_DATE, value);
				this._APPLICATION_DATE = value;
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
		/// 撤销黑名单处理文件扫描件
		/// </summary>
		public string M_ATT_UNDODOCDOC
		{
			get{ return _M_ATT_UNDODOCDOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_UNDODOCDOC, _M_ATT_UNDODOCDOC, value);
				this._M_ATT_UNDODOCDOC = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_IS_HISTORY
		{
			get{ return _M_IS_HISTORY; }
			set
			{
				this.OnPropertyValueChange(_.M_IS_HISTORY, _M_IS_HISTORY, value);
				this._M_IS_HISTORY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_CREATEBY
		{
			get{ return _M_CREATEBY; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATEBY, _M_CREATEBY, value);
				this._M_CREATEBY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? M_CREATE_TM
		{
			get{ return _M_CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATE_TM, _M_CREATE_TM, value);
				this._M_CREATE_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_VERSION
		{
			get{ return _M_VERSION; }
			set
			{
				this.OnPropertyValueChange(_.M_VERSION, _M_VERSION, value);
				this._M_VERSION = value;
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
				_.BODY_NAME,
				_.BODY_CODE,
				_.BODY_TYPE,
				_.BODY_ROLE,
				_.BLACKLIST_CODE,
				_.REVOCATIONEASONS,
				_.GOVERNMENT,
				_.DOCUMENT_CODE,
				_.ROPOSER,
				_.APPLICATION_DATE,
				_.SCOPE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
				_.M_ATT_UNDODOCDOC,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._BODY_NAME,
				this._BODY_CODE,
				this._BODY_TYPE,
				this._BODY_ROLE,
				this._BLACKLIST_CODE,
				this._REVOCATIONEASONS,
				this._GOVERNMENT,
				this._DOCUMENT_CODE,
				this._ROPOSER,
				this._APPLICATION_DATE,
				this._SCOPE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
				this._M_ATT_UNDODOCDOC,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_VERSION,
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
			public readonly static Field All = new Field("*", "WITHDRAW_BLACK_LIST");
            /// <summary>
			/// 主体名称
			/// </summary>
			public readonly static Field BODY_NAME = new Field("BODY_NAME", "WITHDRAW_BLACK_LIST", "主体名称");
            /// <summary>
			/// 主体代码
			/// </summary>
			public readonly static Field BODY_CODE = new Field("BODY_CODE", "WITHDRAW_BLACK_LIST", "主体代码");
            /// <summary>
			/// 主体类别
			/// </summary>
			public readonly static Field BODY_TYPE = new Field("BODY_TYPE", "WITHDRAW_BLACK_LIST", "主体类别");
            /// <summary>
			/// 主体角色
			/// </summary>
			public readonly static Field BODY_ROLE = new Field("BODY_ROLE", "WITHDRAW_BLACK_LIST", "主体角色");
            /// <summary>
			/// 黑名单
			/// </summary>
			public readonly static Field BLACKLIST_CODE = new Field("BLACKLIST_CODE", "WITHDRAW_BLACK_LIST", "黑名单");
            /// <summary>
			/// 撤销理由
			/// </summary>
			public readonly static Field REVOCATIONEASONS = new Field("REVOCATIONEASONS", "WITHDRAW_BLACK_LIST",DbType.AnsiString, null, "撤销理由");
            /// <summary>
			/// 执行部门
			/// </summary>
			public readonly static Field GOVERNMENT = new Field("GOVERNMENT", "WITHDRAW_BLACK_LIST", "执行部门");
            /// <summary>
			/// 处理文件文号
			/// </summary>
			public readonly static Field DOCUMENT_CODE = new Field("DOCUMENT_CODE", "WITHDRAW_BLACK_LIST", "处理文件文号");
            /// <summary>
			/// 申请人
			/// </summary>
			public readonly static Field ROPOSER = new Field("ROPOSER", "WITHDRAW_BLACK_LIST", "申请人");
            /// <summary>
			/// 申请日期
			/// </summary>
			public readonly static Field APPLICATION_DATE = new Field("APPLICATION_DATE", "WITHDRAW_BLACK_LIST", "申请日期");
            /// <summary>
			/// 公开范围
			/// </summary>
			public readonly static Field SCOPE = new Field("SCOPE", "WITHDRAW_BLACK_LIST", "公开范围");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "WITHDRAW_BLACK_LIST", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "WITHDRAW_BLACK_LIST", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "WITHDRAW_BLACK_LIST", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "WITHDRAW_BLACK_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "WITHDRAW_BLACK_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "WITHDRAW_BLACK_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "WITHDRAW_BLACK_LIST", "");
            /// <summary>
			/// 撤销黑名单处理文件扫描件
			/// </summary>
			public readonly static Field M_ATT_UNDODOCDOC = new Field("M_ATT_UNDODOCDOC", "WITHDRAW_BLACK_LIST", "撤销黑名单处理文件扫描件");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "WITHDRAW_BLACK_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "WITHDRAW_BLACK_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "WITHDRAW_BLACK_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "WITHDRAW_BLACK_LIST", "");
        }
        #endregion
	}
}