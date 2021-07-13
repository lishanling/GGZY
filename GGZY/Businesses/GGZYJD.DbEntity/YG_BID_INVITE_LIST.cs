using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类YG_BID_INVITE_LIST。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("YG_BID_INVITE_LIST")]
    [Serializable]
    public partial class YG_BID_INVITE_LIST : JdEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_VERSION;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _UNIT_NAME;
		private string _QUALIFICATION;
		private string _MANAGER_LEVEL;
		private string _MANAGER_NAME;
		private string _MANAGER_PHONE;
		private string _MANAGER_TELPHONE;
		private DateTime? _INVITE_TIME;
		private string _INVITATION_STATUS;
		private string _REMARK;
		private string _IS_CONFIRM;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;

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
		public string DATA_KEY
		{
			get{ return _DATA_KEY; }
			set
			{
				this.OnPropertyValueChange(_.DATA_KEY, _DATA_KEY, value);
				this._DATA_KEY = value;
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
		public string M_VERSION
		{
			get{ return _M_VERSION; }
			set
			{
				this.OnPropertyValueChange(_.M_VERSION, _M_VERSION, value);
				this._M_VERSION = value;
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
		/// 标段（包）编号
		/// </summary>
		public string BID_SECTION_CODE
		{
			get{ return _BID_SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODE, _BID_SECTION_CODE, value);
				this._BID_SECTION_CODE = value;
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
		/// 单位名称
		/// </summary>
		public string UNIT_NAME
		{
			get{ return _UNIT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.UNIT_NAME, _UNIT_NAME, value);
				this._UNIT_NAME = value;
			}
		}
		/// <summary>
		/// 资质
		/// </summary>
		public string QUALIFICATION
		{
			get{ return _QUALIFICATION; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFICATION, _QUALIFICATION, value);
				this._QUALIFICATION = value;
			}
		}
		/// <summary>
		/// 项目负责人等级
		/// </summary>
		public string MANAGER_LEVEL
		{
			get{ return _MANAGER_LEVEL; }
			set
			{
				this.OnPropertyValueChange(_.MANAGER_LEVEL, _MANAGER_LEVEL, value);
				this._MANAGER_LEVEL = value;
			}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string MANAGER_NAME
		{
			get{ return _MANAGER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.MANAGER_NAME, _MANAGER_NAME, value);
				this._MANAGER_NAME = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string MANAGER_PHONE
		{
			get{ return _MANAGER_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.MANAGER_PHONE, _MANAGER_PHONE, value);
				this._MANAGER_PHONE = value;
			}
		}
		/// <summary>
		/// 联系手机
		/// </summary>
		public string MANAGER_TELPHONE
		{
			get{ return _MANAGER_TELPHONE; }
			set
			{
				this.OnPropertyValueChange(_.MANAGER_TELPHONE, _MANAGER_TELPHONE, value);
				this._MANAGER_TELPHONE = value;
			}
		}
		/// <summary>
		/// 邀请时间
		/// </summary>
		public DateTime? INVITE_TIME
		{
			get{ return _INVITE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.INVITE_TIME, _INVITE_TIME, value);
				this._INVITE_TIME = value;
			}
		}
		/// <summary>
		/// 邀请函发出状态
		/// </summary>
		public string INVITATION_STATUS
		{
			get{ return _INVITATION_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.INVITATION_STATUS, _INVITATION_STATUS, value);
				this._INVITATION_STATUS = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARK
		{
			get{ return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
			}
		}
		/// <summary>
		/// 是否已确认
		/// </summary>
		public string IS_CONFIRM
		{
			get{ return _IS_CONFIRM; }
			set
			{
				this.OnPropertyValueChange(_.IS_CONFIRM, _IS_CONFIRM, value);
				this._IS_CONFIRM = value;
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
		/// 交易服务系统标识码
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
		/// 交易平台或发布工具标识码
		/// </summary>
		public string TRADE_PLAT
		{
			get{ return _TRADE_PLAT; }
			set
			{
				this.OnPropertyValueChange(_.TRADE_PLAT, _TRADE_PLAT, value);
				this._TRADE_PLAT = value;
			}
		}
		/// <summary>
		/// 公共服务平台标识码
		/// </summary>
		public string PUB_SERVICE_PLAT
		{
			get{ return _PUB_SERVICE_PLAT; }
			set
			{
				this.OnPropertyValueChange(_.PUB_SERVICE_PLAT, _PUB_SERVICE_PLAT, value);
				this._PUB_SERVICE_PLAT = value;
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
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_VERSION,
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.UNIFIED_DEAL_CODE,
				_.UNIT_NAME,
				_.QUALIFICATION,
				_.MANAGER_LEVEL,
				_.MANAGER_NAME,
				_.MANAGER_PHONE,
				_.MANAGER_TELPHONE,
				_.INVITE_TIME,
				_.INVITATION_STATUS,
				_.REMARK,
				_.IS_CONFIRM,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_VERSION,
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._UNIFIED_DEAL_CODE,
				this._UNIT_NAME,
				this._QUALIFICATION,
				this._MANAGER_LEVEL,
				this._MANAGER_NAME,
				this._MANAGER_PHONE,
				this._MANAGER_TELPHONE,
				this._INVITE_TIME,
				this._INVITATION_STATUS,
				this._REMARK,
				this._IS_CONFIRM,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
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
			public readonly static Field All = new Field("*", "YG_BID_INVITE_LIST");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "YG_BID_INVITE_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "YG_BID_INVITE_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "YG_BID_INVITE_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "YG_BID_INVITE_LIST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "YG_BID_INVITE_LIST", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "YG_BID_INVITE_LIST", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "YG_BID_INVITE_LIST", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "YG_BID_INVITE_LIST", "统一交易标识码");
            /// <summary>
			/// 单位名称
			/// </summary>
			public readonly static Field UNIT_NAME = new Field("UNIT_NAME", "YG_BID_INVITE_LIST", "单位名称");
            /// <summary>
			/// 资质
			/// </summary>
			public readonly static Field QUALIFICATION = new Field("QUALIFICATION", "YG_BID_INVITE_LIST", "资质");
            /// <summary>
			/// 项目负责人等级
			/// </summary>
			public readonly static Field MANAGER_LEVEL = new Field("MANAGER_LEVEL", "YG_BID_INVITE_LIST", "项目负责人等级");
            /// <summary>
			/// 联系人
			/// </summary>
			public readonly static Field MANAGER_NAME = new Field("MANAGER_NAME", "YG_BID_INVITE_LIST", "联系人");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field MANAGER_PHONE = new Field("MANAGER_PHONE", "YG_BID_INVITE_LIST", "联系电话");
            /// <summary>
			/// 联系手机
			/// </summary>
			public readonly static Field MANAGER_TELPHONE = new Field("MANAGER_TELPHONE", "YG_BID_INVITE_LIST", "联系手机");
            /// <summary>
			/// 邀请时间
			/// </summary>
			public readonly static Field INVITE_TIME = new Field("INVITE_TIME", "YG_BID_INVITE_LIST", "邀请时间");
            /// <summary>
			/// 邀请函发出状态
			/// </summary>
			public readonly static Field INVITATION_STATUS = new Field("INVITATION_STATUS", "YG_BID_INVITE_LIST", "邀请函发出状态");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "YG_BID_INVITE_LIST", "备注");
            /// <summary>
			/// 是否已确认
			/// </summary>
			public readonly static Field IS_CONFIRM = new Field("IS_CONFIRM", "YG_BID_INVITE_LIST", "是否已确认");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "YG_BID_INVITE_LIST", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "YG_BID_INVITE_LIST", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "YG_BID_INVITE_LIST", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "YG_BID_INVITE_LIST", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "YG_BID_INVITE_LIST", "公共服务平台标识码");
        }
        #endregion
	}
}