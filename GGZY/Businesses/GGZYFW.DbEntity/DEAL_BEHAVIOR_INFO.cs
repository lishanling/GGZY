using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类DEAL_BEHAVIOR_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("DEAL_BEHAVIOR_INFO")]
    [Serializable]
    public partial class DEAL_BEHAVIOR_INFO : FwEntity
    {
        #region Model
		private string _ANNOUNCEMENT_GUID;
		private string _UNIFIED_DEAL_CODE;
		private string _ANNOUNCEMENT_TITLE;
		private string _ANNOUNCEMENT_CONNECT;
		private string _LAND_DISTRICT;
		private string _URL;
		private DateTime? _END_DATE;
		private DateTime? _CREATE_TIME;
		private DateTime? _PUBLISHING_TIME;
		private string _SUPPLY_TYPE;
		private DateTime? _CHANGE_TIME;
		private DateTime? _RETREAT_TIME;
		private string _ANNOUNCEMENT_UNIT;
		private DateTime? _ANNOUNCEMENT_START_TIME;
		private DateTime? _ANNOUNCEMENT_DEADLINE;
		private decimal? _FIELD_NUM;
		private DateTime? _LISTING_START_TIME;
		private DateTime? _LISTING_DEADLINE;
		private string _LISTING_TYPE;
		private string _ANNOUNCEMENT_TYPE;
		private string _LIAISON_UNIT;
		private string _UNIT_ADDRESS;
		private string _ZIP_CODE;
		private string _CONTACT_PERSON;
		private string _CONTACT_NUMBER;
		private string _EMAIL;
		private string _CANCEL_REASON;
		private string _ANNOUNCEMENT_CODE;
		private string _ATTACHMENT_SET_CODE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _LAND_PROJECT_NAME;
		private string _TRA_PLACE_CODE;
		private string _TRA_AGENCY_NAME;
		private string _TRA_AGENCY_CODE;
		private string _M_VERSION;

		/// <summary>
		/// 成交公示GUID
		/// </summary>
		public string ANNOUNCEMENT_GUID
		{
			get{ return _ANNOUNCEMENT_GUID; }
			set
			{
				this.OnPropertyValueChange(_.ANNOUNCEMENT_GUID, _ANNOUNCEMENT_GUID, value);
				this._ANNOUNCEMENT_GUID = value;
			}
		}
		/// <summary>
		/// 统一交易标识码
		/// </summary>
		public string UNIFIED_DEAL_CODE
		{
			get{ return _UNIFIED_DEAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.UNIFIED_DEAL_CODE, _UNIFIED_DEAL_CODE, value);
				this._UNIFIED_DEAL_CODE = value;
			}
		}
		/// <summary>
		/// 公示标题
		/// </summary>
		public string ANNOUNCEMENT_TITLE
		{
			get{ return _ANNOUNCEMENT_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.ANNOUNCEMENT_TITLE, _ANNOUNCEMENT_TITLE, value);
				this._ANNOUNCEMENT_TITLE = value;
			}
		}
		/// <summary>
		/// 公示内容
		/// </summary>
		public string ANNOUNCEMENT_CONNECT
		{
			get{ return _ANNOUNCEMENT_CONNECT; }
			set
			{
				this.OnPropertyValueChange(_.ANNOUNCEMENT_CONNECT, _ANNOUNCEMENT_CONNECT, value);
				this._ANNOUNCEMENT_CONNECT = value;
			}
		}
		/// <summary>
		/// 行政区划
		/// </summary>
		public string LAND_DISTRICT
		{
			get{ return _LAND_DISTRICT; }
			set
			{
				this.OnPropertyValueChange(_.LAND_DISTRICT, _LAND_DISTRICT, value);
				this._LAND_DISTRICT = value;
			}
		}
		/// <summary>
		/// 公告源URL
		/// </summary>
		public string URL
		{
			get{ return _URL; }
			set
			{
				this.OnPropertyValueChange(_.URL, _URL, value);
				this._URL = value;
			}
		}
		/// <summary>
		/// 截止日期
		/// </summary>
		public DateTime? END_DATE
		{
			get{ return _END_DATE; }
			set
			{
				this.OnPropertyValueChange(_.END_DATE, _END_DATE, value);
				this._END_DATE = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 发布时间
		/// </summary>
		public DateTime? PUBLISHING_TIME
		{
			get{ return _PUBLISHING_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PUBLISHING_TIME, _PUBLISHING_TIME, value);
				this._PUBLISHING_TIME = value;
			}
		}
		/// <summary>
		/// 供应方式
		/// </summary>
		public string SUPPLY_TYPE
		{
			get{ return _SUPPLY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.SUPPLY_TYPE, _SUPPLY_TYPE, value);
				this._SUPPLY_TYPE = value;
			}
		}
		/// <summary>
		/// 修改日期
		/// </summary>
		public DateTime? CHANGE_TIME
		{
			get{ return _CHANGE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CHANGE_TIME, _CHANGE_TIME, value);
				this._CHANGE_TIME = value;
			}
		}
		/// <summary>
		/// 撤回时间
		/// </summary>
		public DateTime? RETREAT_TIME
		{
			get{ return _RETREAT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.RETREAT_TIME, _RETREAT_TIME, value);
				this._RETREAT_TIME = value;
			}
		}
		/// <summary>
		/// 公示单位
		/// </summary>
		public string ANNOUNCEMENT_UNIT
		{
			get{ return _ANNOUNCEMENT_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.ANNOUNCEMENT_UNIT, _ANNOUNCEMENT_UNIT, value);
				this._ANNOUNCEMENT_UNIT = value;
			}
		}
		/// <summary>
		/// 公示开始时间
		/// </summary>
		public DateTime? ANNOUNCEMENT_START_TIME
		{
			get{ return _ANNOUNCEMENT_START_TIME; }
			set
			{
				this.OnPropertyValueChange(_.ANNOUNCEMENT_START_TIME, _ANNOUNCEMENT_START_TIME, value);
				this._ANNOUNCEMENT_START_TIME = value;
			}
		}
		/// <summary>
		/// 公示结束时间
		/// </summary>
		public DateTime? ANNOUNCEMENT_DEADLINE
		{
			get{ return _ANNOUNCEMENT_DEADLINE; }
			set
			{
				this.OnPropertyValueChange(_.ANNOUNCEMENT_DEADLINE, _ANNOUNCEMENT_DEADLINE, value);
				this._ANNOUNCEMENT_DEADLINE = value;
			}
		}
		/// <summary>
		/// 宗地数量
		/// </summary>
		public decimal? FIELD_NUM
		{
			get{ return _FIELD_NUM; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_NUM, _FIELD_NUM, value);
				this._FIELD_NUM = value;
			}
		}
		/// <summary>
		/// 招拍挂开始时间
		/// </summary>
		public DateTime? LISTING_START_TIME
		{
			get{ return _LISTING_START_TIME; }
			set
			{
				this.OnPropertyValueChange(_.LISTING_START_TIME, _LISTING_START_TIME, value);
				this._LISTING_START_TIME = value;
			}
		}
		/// <summary>
		/// 招拍挂结束时间
		/// </summary>
		public DateTime? LISTING_DEADLINE
		{
			get{ return _LISTING_DEADLINE; }
			set
			{
				this.OnPropertyValueChange(_.LISTING_DEADLINE, _LISTING_DEADLINE, value);
				this._LISTING_DEADLINE = value;
			}
		}
		/// <summary>
		/// 招拍挂类型
		/// </summary>
		public string LISTING_TYPE
		{
			get{ return _LISTING_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.LISTING_TYPE, _LISTING_TYPE, value);
				this._LISTING_TYPE = value;
			}
		}
		/// <summary>
		/// 公示类型
		/// </summary>
		public string ANNOUNCEMENT_TYPE
		{
			get{ return _ANNOUNCEMENT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.ANNOUNCEMENT_TYPE, _ANNOUNCEMENT_TYPE, value);
				this._ANNOUNCEMENT_TYPE = value;
			}
		}
		/// <summary>
		/// 联系单位
		/// </summary>
		public string LIAISON_UNIT
		{
			get{ return _LIAISON_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.LIAISON_UNIT, _LIAISON_UNIT, value);
				this._LIAISON_UNIT = value;
			}
		}
		/// <summary>
		/// 单位地址
		/// </summary>
		public string UNIT_ADDRESS
		{
			get{ return _UNIT_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.UNIT_ADDRESS, _UNIT_ADDRESS, value);
				this._UNIT_ADDRESS = value;
			}
		}
		/// <summary>
		/// 邮政编码
		/// </summary>
		public string ZIP_CODE
		{
			get{ return _ZIP_CODE; }
			set
			{
				this.OnPropertyValueChange(_.ZIP_CODE, _ZIP_CODE, value);
				this._ZIP_CODE = value;
			}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string CONTACT_PERSON
		{
			get{ return _CONTACT_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.CONTACT_PERSON, _CONTACT_PERSON, value);
				this._CONTACT_PERSON = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string CONTACT_NUMBER
		{
			get{ return _CONTACT_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.CONTACT_NUMBER, _CONTACT_NUMBER, value);
				this._CONTACT_NUMBER = value;
			}
		}
		/// <summary>
		/// 电子邮箱
		/// </summary>
		public string EMAIL
		{
			get{ return _EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.EMAIL, _EMAIL, value);
				this._EMAIL = value;
			}
		}
		/// <summary>
		/// 撤销原因
		/// </summary>
		public string CANCEL_REASON
		{
			get{ return _CANCEL_REASON; }
			set
			{
				this.OnPropertyValueChange(_.CANCEL_REASON, _CANCEL_REASON, value);
				this._CANCEL_REASON = value;
			}
		}
		/// <summary>
		/// 公示编号
		/// </summary>
		public string ANNOUNCEMENT_CODE
		{
			get{ return _ANNOUNCEMENT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.ANNOUNCEMENT_CODE, _ANNOUNCEMENT_CODE, value);
				this._ANNOUNCEMENT_CODE = value;
			}
		}
		/// <summary>
		/// 附件关联标识号
		/// </summary>
		public string ATTACHMENT_SET_CODE
		{
			get{ return _ATTACHMENT_SET_CODE; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENT_SET_CODE, _ATTACHMENT_SET_CODE, value);
				this._ATTACHMENT_SET_CODE = value;
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
		/// 项目名称
		/// </summary>
		public string LAND_PROJECT_NAME
		{
			get{ return _LAND_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.LAND_PROJECT_NAME, _LAND_PROJECT_NAME, value);
				this._LAND_PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 交易发生行政区域代码
		/// </summary>
		public string TRA_PLACE_CODE
		{
			get{ return _TRA_PLACE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TRA_PLACE_CODE, _TRA_PLACE_CODE, value);
				this._TRA_PLACE_CODE = value;
			}
		}
		/// <summary>
		/// 交易机构名称
		/// </summary>
		public string TRA_AGENCY_NAME
		{
			get{ return _TRA_AGENCY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TRA_AGENCY_NAME, _TRA_AGENCY_NAME, value);
				this._TRA_AGENCY_NAME = value;
			}
		}
		/// <summary>
		/// 交易机构代码
		/// </summary>
		public string TRA_AGENCY_CODE
		{
			get{ return _TRA_AGENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TRA_AGENCY_CODE, _TRA_AGENCY_CODE, value);
				this._TRA_AGENCY_CODE = value;
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
				_.ANNOUNCEMENT_GUID,
				_.UNIFIED_DEAL_CODE,
				_.ANNOUNCEMENT_TITLE,
				_.ANNOUNCEMENT_CONNECT,
				_.LAND_DISTRICT,
				_.URL,
				_.END_DATE,
				_.CREATE_TIME,
				_.PUBLISHING_TIME,
				_.SUPPLY_TYPE,
				_.CHANGE_TIME,
				_.RETREAT_TIME,
				_.ANNOUNCEMENT_UNIT,
				_.ANNOUNCEMENT_START_TIME,
				_.ANNOUNCEMENT_DEADLINE,
				_.FIELD_NUM,
				_.LISTING_START_TIME,
				_.LISTING_DEADLINE,
				_.LISTING_TYPE,
				_.ANNOUNCEMENT_TYPE,
				_.LIAISON_UNIT,
				_.UNIT_ADDRESS,
				_.ZIP_CODE,
				_.CONTACT_PERSON,
				_.CONTACT_NUMBER,
				_.EMAIL,
				_.CANCEL_REASON,
				_.ANNOUNCEMENT_CODE,
				_.ATTACHMENT_SET_CODE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.LAND_PROJECT_NAME,
				_.TRA_PLACE_CODE,
				_.TRA_AGENCY_NAME,
				_.TRA_AGENCY_CODE,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ANNOUNCEMENT_GUID,
				this._UNIFIED_DEAL_CODE,
				this._ANNOUNCEMENT_TITLE,
				this._ANNOUNCEMENT_CONNECT,
				this._LAND_DISTRICT,
				this._URL,
				this._END_DATE,
				this._CREATE_TIME,
				this._PUBLISHING_TIME,
				this._SUPPLY_TYPE,
				this._CHANGE_TIME,
				this._RETREAT_TIME,
				this._ANNOUNCEMENT_UNIT,
				this._ANNOUNCEMENT_START_TIME,
				this._ANNOUNCEMENT_DEADLINE,
				this._FIELD_NUM,
				this._LISTING_START_TIME,
				this._LISTING_DEADLINE,
				this._LISTING_TYPE,
				this._ANNOUNCEMENT_TYPE,
				this._LIAISON_UNIT,
				this._UNIT_ADDRESS,
				this._ZIP_CODE,
				this._CONTACT_PERSON,
				this._CONTACT_NUMBER,
				this._EMAIL,
				this._CANCEL_REASON,
				this._ANNOUNCEMENT_CODE,
				this._ATTACHMENT_SET_CODE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._LAND_PROJECT_NAME,
				this._TRA_PLACE_CODE,
				this._TRA_AGENCY_NAME,
				this._TRA_AGENCY_CODE,
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
			public readonly static Field All = new Field("*", "DEAL_BEHAVIOR_INFO");
            /// <summary>
			/// 成交公示GUID
			/// </summary>
			public readonly static Field ANNOUNCEMENT_GUID = new Field("ANNOUNCEMENT_GUID", "DEAL_BEHAVIOR_INFO", "成交公示GUID");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "DEAL_BEHAVIOR_INFO", "统一交易标识码");
            /// <summary>
			/// 公示标题
			/// </summary>
			public readonly static Field ANNOUNCEMENT_TITLE = new Field("ANNOUNCEMENT_TITLE", "DEAL_BEHAVIOR_INFO", "公示标题");
            /// <summary>
			/// 公示内容
			/// </summary>
			public readonly static Field ANNOUNCEMENT_CONNECT = new Field("ANNOUNCEMENT_CONNECT", "DEAL_BEHAVIOR_INFO",DbType.AnsiString, null, "公示内容");
            /// <summary>
			/// 行政区划
			/// </summary>
			public readonly static Field LAND_DISTRICT = new Field("LAND_DISTRICT", "DEAL_BEHAVIOR_INFO", "行政区划");
            /// <summary>
			/// 公告源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "DEAL_BEHAVIOR_INFO", "公告源URL");
            /// <summary>
			/// 截止日期
			/// </summary>
			public readonly static Field END_DATE = new Field("END_DATE", "DEAL_BEHAVIOR_INFO", "截止日期");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "DEAL_BEHAVIOR_INFO", "创建时间");
            /// <summary>
			/// 发布时间
			/// </summary>
			public readonly static Field PUBLISHING_TIME = new Field("PUBLISHING_TIME", "DEAL_BEHAVIOR_INFO", "发布时间");
            /// <summary>
			/// 供应方式
			/// </summary>
			public readonly static Field SUPPLY_TYPE = new Field("SUPPLY_TYPE", "DEAL_BEHAVIOR_INFO", "供应方式");
            /// <summary>
			/// 修改日期
			/// </summary>
			public readonly static Field CHANGE_TIME = new Field("CHANGE_TIME", "DEAL_BEHAVIOR_INFO", "修改日期");
            /// <summary>
			/// 撤回时间
			/// </summary>
			public readonly static Field RETREAT_TIME = new Field("RETREAT_TIME", "DEAL_BEHAVIOR_INFO", "撤回时间");
            /// <summary>
			/// 公示单位
			/// </summary>
			public readonly static Field ANNOUNCEMENT_UNIT = new Field("ANNOUNCEMENT_UNIT", "DEAL_BEHAVIOR_INFO", "公示单位");
            /// <summary>
			/// 公示开始时间
			/// </summary>
			public readonly static Field ANNOUNCEMENT_START_TIME = new Field("ANNOUNCEMENT_START_TIME", "DEAL_BEHAVIOR_INFO", "公示开始时间");
            /// <summary>
			/// 公示结束时间
			/// </summary>
			public readonly static Field ANNOUNCEMENT_DEADLINE = new Field("ANNOUNCEMENT_DEADLINE", "DEAL_BEHAVIOR_INFO", "公示结束时间");
            /// <summary>
			/// 宗地数量
			/// </summary>
			public readonly static Field FIELD_NUM = new Field("FIELD_NUM", "DEAL_BEHAVIOR_INFO", "宗地数量");
            /// <summary>
			/// 招拍挂开始时间
			/// </summary>
			public readonly static Field LISTING_START_TIME = new Field("LISTING_START_TIME", "DEAL_BEHAVIOR_INFO", "招拍挂开始时间");
            /// <summary>
			/// 招拍挂结束时间
			/// </summary>
			public readonly static Field LISTING_DEADLINE = new Field("LISTING_DEADLINE", "DEAL_BEHAVIOR_INFO", "招拍挂结束时间");
            /// <summary>
			/// 招拍挂类型
			/// </summary>
			public readonly static Field LISTING_TYPE = new Field("LISTING_TYPE", "DEAL_BEHAVIOR_INFO", "招拍挂类型");
            /// <summary>
			/// 公示类型
			/// </summary>
			public readonly static Field ANNOUNCEMENT_TYPE = new Field("ANNOUNCEMENT_TYPE", "DEAL_BEHAVIOR_INFO", "公示类型");
            /// <summary>
			/// 联系单位
			/// </summary>
			public readonly static Field LIAISON_UNIT = new Field("LIAISON_UNIT", "DEAL_BEHAVIOR_INFO", "联系单位");
            /// <summary>
			/// 单位地址
			/// </summary>
			public readonly static Field UNIT_ADDRESS = new Field("UNIT_ADDRESS", "DEAL_BEHAVIOR_INFO", "单位地址");
            /// <summary>
			/// 邮政编码
			/// </summary>
			public readonly static Field ZIP_CODE = new Field("ZIP_CODE", "DEAL_BEHAVIOR_INFO", "邮政编码");
            /// <summary>
			/// 联系人
			/// </summary>
			public readonly static Field CONTACT_PERSON = new Field("CONTACT_PERSON", "DEAL_BEHAVIOR_INFO", "联系人");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field CONTACT_NUMBER = new Field("CONTACT_NUMBER", "DEAL_BEHAVIOR_INFO", "联系电话");
            /// <summary>
			/// 电子邮箱
			/// </summary>
			public readonly static Field EMAIL = new Field("EMAIL", "DEAL_BEHAVIOR_INFO", "电子邮箱");
            /// <summary>
			/// 撤销原因
			/// </summary>
			public readonly static Field CANCEL_REASON = new Field("CANCEL_REASON", "DEAL_BEHAVIOR_INFO",DbType.AnsiString, null, "撤销原因");
            /// <summary>
			/// 公示编号
			/// </summary>
			public readonly static Field ANNOUNCEMENT_CODE = new Field("ANNOUNCEMENT_CODE", "DEAL_BEHAVIOR_INFO", "公示编号");
            /// <summary>
			/// 附件关联标识号
			/// </summary>
			public readonly static Field ATTACHMENT_SET_CODE = new Field("ATTACHMENT_SET_CODE", "DEAL_BEHAVIOR_INFO",DbType.AnsiString, null, "附件关联标识号");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "DEAL_BEHAVIOR_INFO", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "DEAL_BEHAVIOR_INFO", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "DEAL_BEHAVIOR_INFO", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "DEAL_BEHAVIOR_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "DEAL_BEHAVIOR_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "DEAL_BEHAVIOR_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "DEAL_BEHAVIOR_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "DEAL_BEHAVIOR_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "DEAL_BEHAVIOR_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "DEAL_BEHAVIOR_INFO", "");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field LAND_PROJECT_NAME = new Field("LAND_PROJECT_NAME", "DEAL_BEHAVIOR_INFO", "项目名称");
            /// <summary>
			/// 交易发生行政区域代码
			/// </summary>
			public readonly static Field TRA_PLACE_CODE = new Field("TRA_PLACE_CODE", "DEAL_BEHAVIOR_INFO", "交易发生行政区域代码");
            /// <summary>
			/// 交易机构名称
			/// </summary>
			public readonly static Field TRA_AGENCY_NAME = new Field("TRA_AGENCY_NAME", "DEAL_BEHAVIOR_INFO", "交易机构名称");
            /// <summary>
			/// 交易机构代码
			/// </summary>
			public readonly static Field TRA_AGENCY_CODE = new Field("TRA_AGENCY_CODE", "DEAL_BEHAVIOR_INFO", "交易机构代码");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "DEAL_BEHAVIOR_INFO", "");
        }
        #endregion
	}
}