using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类WIN_RESULT_ANNO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("WIN_RESULT_ANNO")]
    [Serializable]
    public partial class WIN_RESULT_ANNO : FwEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _NOTICE_NAME;
		private string _NOTICE_CONTENT;
		private DateTime? _NOTICE_SEND_TIME;
		private string _NOTICE_MEDIA;
		private string _URL;
		private string _NOTICE_NATURE;
		private string _BULLETIN_TYPE;
		private string _WIN_BIDDER_NAME;
		private string _BIDDER_CODE_TYPE;
		private string _WIN_BIDDER_CODE;
		private string _BIDDER_ROLE;
		private decimal? _BID_AMOUNT;
		private string _BID_CURRENCY;
		private string _PRICE_UNIT;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private decimal? _M_CREATOR;
		private string _M_ATT_WIN_BID_NOTICE;
		private decimal? _M_STATUS;
		private string _BID_SECTION_CODE;
		private string _M_REMARK;
		private string _M_ZPID;
		private string _M_ZR_UNIT;
		private DateTime? _M_BTIME;
		private DateTime? _M_ETIME;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _M_MONEY_UPDATE;
		private string _UNION_CODE;
		private string _UNION_NAME;
		private string _RATE;
		private string _OTHER_WIN_PRICE;
		private string _OTHER_CONTENT;
		private string _BULLETIN_DUTY;
		private string _EXAMINER_NAME;
		private string _REGION_CODE;
		private string _TRA_PLACE_CODE;
		private string _TENDER_AGENCY_NAME;
		private string _TENDER_AGENCY_CODE;
		private string _PRICE_FORM_CODE;
		private string _OTHER_BID_PRICE;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;
		private string _BIDDER_REGION_CODE;
		private string _BIDDER_PROPERTY;
		private string _PROJECT_LEAD;
		private string _PROJECT_LEAD_ID;

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
		/// 公告标题
		/// </summary>
		public string NOTICE_NAME
		{
			get{ return _NOTICE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_NAME, _NOTICE_NAME, value);
				this._NOTICE_NAME = value;
			}
		}
		/// <summary>
		/// 公告内容
		/// </summary>
		public string NOTICE_CONTENT
		{
			get{ return _NOTICE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_CONTENT, _NOTICE_CONTENT, value);
				this._NOTICE_CONTENT = value;
			}
		}
		/// <summary>
		/// 公告发布时间
		/// </summary>
		public DateTime? NOTICE_SEND_TIME
		{
			get{ return _NOTICE_SEND_TIME; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_SEND_TIME, _NOTICE_SEND_TIME, value);
				this._NOTICE_SEND_TIME = value;
			}
		}
		/// <summary>
		/// 公告发布媒体
		/// </summary>
		public string NOTICE_MEDIA
		{
			get{ return _NOTICE_MEDIA; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_MEDIA, _NOTICE_MEDIA, value);
				this._NOTICE_MEDIA = value;
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
		/// 公告性质
		/// </summary>
		public string NOTICE_NATURE
		{
			get{ return _NOTICE_NATURE; }
			set
			{
				this.OnPropertyValueChange(_.NOTICE_NATURE, _NOTICE_NATURE, value);
				this._NOTICE_NATURE = value;
			}
		}
		/// <summary>
		/// 公告类型
		/// </summary>
		public string BULLETIN_TYPE
		{
			get{ return _BULLETIN_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BULLETIN_TYPE, _BULLETIN_TYPE, value);
				this._BULLETIN_TYPE = value;
			}
		}
		/// <summary>
		/// 中标投标人名称
		/// </summary>
		public string WIN_BIDDER_NAME
		{
			get{ return _WIN_BIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BIDDER_NAME, _WIN_BIDDER_NAME, value);
				this._WIN_BIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 中标投标人类别
		/// </summary>
		public string BIDDER_CODE_TYPE
		{
			get{ return _BIDDER_CODE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_CODE_TYPE, _BIDDER_CODE_TYPE, value);
				this._BIDDER_CODE_TYPE = value;
			}
		}
		/// <summary>
		/// 中标投标人代码
		/// </summary>
		public string WIN_BIDDER_CODE
		{
			get{ return _WIN_BIDDER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BIDDER_CODE, _WIN_BIDDER_CODE, value);
				this._WIN_BIDDER_CODE = value;
			}
		}
		/// <summary>
		/// 中标投标人角色
		/// </summary>
		public string BIDDER_ROLE
		{
			get{ return _BIDDER_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_ROLE, _BIDDER_ROLE, value);
				this._BIDDER_ROLE = value;
			}
		}
		/// <summary>
		/// 中标金额
		/// </summary>
		public decimal? BID_AMOUNT
		{
			get{ return _BID_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.BID_AMOUNT, _BID_AMOUNT, value);
				this._BID_AMOUNT = value;
			}
		}
		/// <summary>
		/// 价格币种代码
		/// </summary>
		public string BID_CURRENCY
		{
			get{ return _BID_CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.BID_CURRENCY, _BID_CURRENCY, value);
				this._BID_CURRENCY = value;
			}
		}
		/// <summary>
		/// 价格单位
		/// </summary>
		public string PRICE_UNIT
		{
			get{ return _PRICE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_UNIT, _PRICE_UNIT, value);
				this._PRICE_UNIT = value;
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
		/// 自增ID
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
		/// ??????
		/// </summary>
		public decimal? M_CREATOR
		{
			get{ return _M_CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATOR, _M_CREATOR, value);
				this._M_CREATOR = value;
			}
		}
		/// <summary>
		/// ??????
		/// </summary>
		public string M_ATT_WIN_BID_NOTICE
		{
			get{ return _M_ATT_WIN_BID_NOTICE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_WIN_BID_NOTICE, _M_ATT_WIN_BID_NOTICE, value);
				this._M_ATT_WIN_BID_NOTICE = value;
			}
		}
		/// <summary>
		/// 推送招标采购网状态
		/// </summary>
		public decimal? M_STATUS
		{
			get{ return _M_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.M_STATUS, _M_STATUS, value);
				this._M_STATUS = value;
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
		/// 审核备注
		/// </summary>
		public string M_REMARK
		{
			get{ return _M_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.M_REMARK, _M_REMARK, value);
				this._M_REMARK = value;
			}
		}
		/// <summary>
		/// 招标采购网返回ID
		/// </summary>
		public string M_ZPID
		{
			get{ return _M_ZPID; }
			set
			{
				this.OnPropertyValueChange(_.M_ZPID, _M_ZPID, value);
				this._M_ZPID = value;
			}
		}
		/// <summary>
		/// 监督单位及联系电话
		/// </summary>
		public string M_ZR_UNIT
		{
			get{ return _M_ZR_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.M_ZR_UNIT, _M_ZR_UNIT, value);
				this._M_ZR_UNIT = value;
			}
		}
		/// <summary>
		/// 公示开始时间
		/// </summary>
		public DateTime? M_BTIME
		{
			get{ return _M_BTIME; }
			set
			{
				this.OnPropertyValueChange(_.M_BTIME, _M_BTIME, value);
				this._M_BTIME = value;
			}
		}
		/// <summary>
		/// 公示结束时间
		/// </summary>
		public DateTime? M_ETIME
		{
			get{ return _M_ETIME; }
			set
			{
				this.OnPropertyValueChange(_.M_ETIME, _M_ETIME, value);
				this._M_ETIME = value;
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
		/// 标注金额单位是否被更新过，1表示更新过
		/// </summary>
		public string M_MONEY_UPDATE
		{
			get{ return _M_MONEY_UPDATE; }
			set
			{
				this.OnPropertyValueChange(_.M_MONEY_UPDATE, _M_MONEY_UPDATE, value);
				this._M_MONEY_UPDATE = value;
			}
		}
		/// <summary>
		/// 联合体代码
		/// </summary>
		public string UNION_CODE
		{
			get{ return _UNION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.UNION_CODE, _UNION_CODE, value);
				this._UNION_CODE = value;
			}
		}
		/// <summary>
		/// 联合体名称
		/// </summary>
		public string UNION_NAME
		{
			get{ return _UNION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.UNION_NAME, _UNION_NAME, value);
				this._UNION_NAME = value;
			}
		}
		/// <summary>
		/// 中标费率
		/// </summary>
		public string RATE
		{
			get{ return _RATE; }
			set
			{
				this.OnPropertyValueChange(_.RATE, _RATE, value);
				this._RATE = value;
			}
		}
		/// <summary>
		/// 其他类型中标价
		/// </summary>
		public string OTHER_WIN_PRICE
		{
			get{ return _OTHER_WIN_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_WIN_PRICE, _OTHER_WIN_PRICE, value);
				this._OTHER_WIN_PRICE = value;
			}
		}
		/// <summary>
		/// 其他内容
		/// </summary>
		public string OTHER_CONTENT
		{
			get{ return _OTHER_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_CONTENT, _OTHER_CONTENT, value);
				this._OTHER_CONTENT = value;
			}
		}
		/// <summary>
		/// 公示发布责任人
		/// </summary>
		public string BULLETIN_DUTY
		{
			get{ return _BULLETIN_DUTY; }
			set
			{
				this.OnPropertyValueChange(_.BULLETIN_DUTY, _BULLETIN_DUTY, value);
				this._BULLETIN_DUTY = value;
			}
		}
		/// <summary>
		/// 交易平台数据验证责任人姓名
		/// </summary>
		public string EXAMINER_NAME
		{
			get{ return _EXAMINER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.EXAMINER_NAME, _EXAMINER_NAME, value);
				this._EXAMINER_NAME = value;
			}
		}
		/// <summary>
		/// 标段（包）所在行政区域代码
		/// </summary>
		public string REGION_CODE
		{
			get{ return _REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REGION_CODE, _REGION_CODE, value);
				this._REGION_CODE = value;
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
		/// 招标代理机构名称
		/// </summary>
		public string TENDER_AGENCY_NAME
		{
			get{ return _TENDER_AGENCY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_NAME, _TENDER_AGENCY_NAME, value);
				this._TENDER_AGENCY_NAME = value;
			}
		}
		/// <summary>
		/// 招标代理机构代码
		/// </summary>
		public string TENDER_AGENCY_CODE
		{
			get{ return _TENDER_AGENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_CODE, _TENDER_AGENCY_CODE, value);
				this._TENDER_AGENCY_CODE = value;
			}
		}
		/// <summary>
		/// 价款形式代码
		/// </summary>
		public string PRICE_FORM_CODE
		{
			get{ return _PRICE_FORM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_FORM_CODE, _PRICE_FORM_CODE, value);
				this._PRICE_FORM_CODE = value;
			}
		}
		/// <summary>
		/// 费率或其它类型结果
		/// </summary>
		public string OTHER_BID_PRICE
		{
			get{ return _OTHER_BID_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_BID_PRICE, _OTHER_BID_PRICE, value);
				this._OTHER_BID_PRICE = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
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
		/// 中标投标人企业注册所在地
		/// </summary>
		public string BIDDER_REGION_CODE
		{
			get{ return _BIDDER_REGION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_REGION_CODE, _BIDDER_REGION_CODE, value);
				this._BIDDER_REGION_CODE = value;
			}
		}
		/// <summary>
		/// 中标投标人企业性质
		/// </summary>
		public string BIDDER_PROPERTY
		{
			get{ return _BIDDER_PROPERTY; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_PROPERTY, _BIDDER_PROPERTY, value);
				this._BIDDER_PROPERTY = value;
			}
		}
		/// <summary>
		/// 项目负责人
		/// </summary>
		public string PROJECT_LEAD
		{
			get{ return _PROJECT_LEAD; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_LEAD, _PROJECT_LEAD, value);
				this._PROJECT_LEAD = value;
			}
		}
		/// <summary>
		/// 项目负责人身份证号码
		/// </summary>
		public string PROJECT_LEAD_ID
		{
			get{ return _PROJECT_LEAD_ID; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_LEAD_ID, _PROJECT_LEAD_ID, value);
				this._PROJECT_LEAD_ID = value;
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
				_.TENDER_PROJECT_CODE,
				_.UNIFIED_DEAL_CODE,
				_.NOTICE_NAME,
				_.NOTICE_CONTENT,
				_.NOTICE_SEND_TIME,
				_.NOTICE_MEDIA,
				_.URL,
				_.NOTICE_NATURE,
				_.BULLETIN_TYPE,
				_.WIN_BIDDER_NAME,
				_.BIDDER_CODE_TYPE,
				_.WIN_BIDDER_CODE,
				_.BIDDER_ROLE,
				_.BID_AMOUNT,
				_.BID_CURRENCY,
				_.PRICE_UNIT,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
				_.M_CREATOR,
				_.M_ATT_WIN_BID_NOTICE,
				_.M_STATUS,
				_.BID_SECTION_CODE,
				_.M_REMARK,
				_.M_ZPID,
				_.M_ZR_UNIT,
				_.M_BTIME,
				_.M_ETIME,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_MONEY_UPDATE,
				_.UNION_CODE,
				_.UNION_NAME,
				_.RATE,
				_.OTHER_WIN_PRICE,
				_.OTHER_CONTENT,
				_.BULLETIN_DUTY,
				_.EXAMINER_NAME,
				_.REGION_CODE,
				_.TRA_PLACE_CODE,
				_.TENDER_AGENCY_NAME,
				_.TENDER_AGENCY_CODE,
				_.PRICE_FORM_CODE,
				_.OTHER_BID_PRICE,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
				_.BIDDER_REGION_CODE,
				_.BIDDER_PROPERTY,
				_.PROJECT_LEAD,
				_.PROJECT_LEAD_ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TENDER_PROJECT_CODE,
				this._UNIFIED_DEAL_CODE,
				this._NOTICE_NAME,
				this._NOTICE_CONTENT,
				this._NOTICE_SEND_TIME,
				this._NOTICE_MEDIA,
				this._URL,
				this._NOTICE_NATURE,
				this._BULLETIN_TYPE,
				this._WIN_BIDDER_NAME,
				this._BIDDER_CODE_TYPE,
				this._WIN_BIDDER_CODE,
				this._BIDDER_ROLE,
				this._BID_AMOUNT,
				this._BID_CURRENCY,
				this._PRICE_UNIT,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
				this._M_CREATOR,
				this._M_ATT_WIN_BID_NOTICE,
				this._M_STATUS,
				this._BID_SECTION_CODE,
				this._M_REMARK,
				this._M_ZPID,
				this._M_ZR_UNIT,
				this._M_BTIME,
				this._M_ETIME,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_MONEY_UPDATE,
				this._UNION_CODE,
				this._UNION_NAME,
				this._RATE,
				this._OTHER_WIN_PRICE,
				this._OTHER_CONTENT,
				this._BULLETIN_DUTY,
				this._EXAMINER_NAME,
				this._REGION_CODE,
				this._TRA_PLACE_CODE,
				this._TENDER_AGENCY_NAME,
				this._TENDER_AGENCY_CODE,
				this._PRICE_FORM_CODE,
				this._OTHER_BID_PRICE,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._M_VERSION,
				this._BIDDER_REGION_CODE,
				this._BIDDER_PROPERTY,
				this._PROJECT_LEAD,
				this._PROJECT_LEAD_ID,
			};
        }
        #endregion

		#region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public partial class _
        {
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*", "WIN_RESULT_ANNO");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "WIN_RESULT_ANNO", "招标项目编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "WIN_RESULT_ANNO", "统一交易标识码");
            /// <summary>
			/// 公告标题
			/// </summary>
			public readonly static Field NOTICE_NAME = new Field("NOTICE_NAME", "WIN_RESULT_ANNO", "公告标题");
            /// <summary>
			/// 公告内容
			/// </summary>
			public readonly static Field NOTICE_CONTENT = new Field("NOTICE_CONTENT", "WIN_RESULT_ANNO",DbType.AnsiString, null, "公告内容");
            /// <summary>
			/// 公告发布时间
			/// </summary>
			public readonly static Field NOTICE_SEND_TIME = new Field("NOTICE_SEND_TIME", "WIN_RESULT_ANNO", "公告发布时间");
            /// <summary>
			/// 公告发布媒体
			/// </summary>
			public readonly static Field NOTICE_MEDIA = new Field("NOTICE_MEDIA", "WIN_RESULT_ANNO", "公告发布媒体");
            /// <summary>
			/// 公告源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "WIN_RESULT_ANNO", "公告源URL");
            /// <summary>
			/// 公告性质
			/// </summary>
			public readonly static Field NOTICE_NATURE = new Field("NOTICE_NATURE", "WIN_RESULT_ANNO", "公告性质");
            /// <summary>
			/// 公告类型
			/// </summary>
			public readonly static Field BULLETIN_TYPE = new Field("BULLETIN_TYPE", "WIN_RESULT_ANNO", "公告类型");
            /// <summary>
			/// 中标投标人名称
			/// </summary>
			public readonly static Field WIN_BIDDER_NAME = new Field("WIN_BIDDER_NAME", "WIN_RESULT_ANNO", "中标投标人名称");
            /// <summary>
			/// 中标投标人类别
			/// </summary>
			public readonly static Field BIDDER_CODE_TYPE = new Field("BIDDER_CODE_TYPE", "WIN_RESULT_ANNO", "中标投标人类别");
            /// <summary>
			/// 中标投标人代码
			/// </summary>
			public readonly static Field WIN_BIDDER_CODE = new Field("WIN_BIDDER_CODE", "WIN_RESULT_ANNO", "中标投标人代码");
            /// <summary>
			/// 中标投标人角色
			/// </summary>
			public readonly static Field BIDDER_ROLE = new Field("BIDDER_ROLE", "WIN_RESULT_ANNO", "中标投标人角色");
            /// <summary>
			/// 中标金额
			/// </summary>
			public readonly static Field BID_AMOUNT = new Field("BID_AMOUNT", "WIN_RESULT_ANNO", "中标金额");
            /// <summary>
			/// 价格币种代码
			/// </summary>
			public readonly static Field BID_CURRENCY = new Field("BID_CURRENCY", "WIN_RESULT_ANNO", "价格币种代码");
            /// <summary>
			/// 价格单位
			/// </summary>
			public readonly static Field PRICE_UNIT = new Field("PRICE_UNIT", "WIN_RESULT_ANNO", "价格单位");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "WIN_RESULT_ANNO", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "WIN_RESULT_ANNO", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "WIN_RESULT_ANNO", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "WIN_RESULT_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "WIN_RESULT_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "WIN_RESULT_ANNO", "");
            /// <summary>
			/// 自增ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "WIN_RESULT_ANNO", "自增ID");
            /// <summary>
			/// ??????
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "WIN_RESULT_ANNO", "??????");
            /// <summary>
			/// ??????
			/// </summary>
			public readonly static Field M_ATT_WIN_BID_NOTICE = new Field("M_ATT_WIN_BID_NOTICE", "WIN_RESULT_ANNO", "??????");
            /// <summary>
			/// 推送招标采购网状态
			/// </summary>
			public readonly static Field M_STATUS = new Field("M_STATUS", "WIN_RESULT_ANNO", "推送招标采购网状态");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "WIN_RESULT_ANNO", "标段（包）编号");
            /// <summary>
			/// 审核备注
			/// </summary>
			public readonly static Field M_REMARK = new Field("M_REMARK", "WIN_RESULT_ANNO", "审核备注");
            /// <summary>
			/// 招标采购网返回ID
			/// </summary>
			public readonly static Field M_ZPID = new Field("M_ZPID", "WIN_RESULT_ANNO", "招标采购网返回ID");
            /// <summary>
			/// 监督单位及联系电话
			/// </summary>
			public readonly static Field M_ZR_UNIT = new Field("M_ZR_UNIT", "WIN_RESULT_ANNO", "监督单位及联系电话");
            /// <summary>
			/// 公示开始时间
			/// </summary>
			public readonly static Field M_BTIME = new Field("M_BTIME", "WIN_RESULT_ANNO", "公示开始时间");
            /// <summary>
			/// 公示结束时间
			/// </summary>
			public readonly static Field M_ETIME = new Field("M_ETIME", "WIN_RESULT_ANNO", "公示结束时间");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "WIN_RESULT_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "WIN_RESULT_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "WIN_RESULT_ANNO", "");
            /// <summary>
			/// 标注金额单位是否被更新过，1表示更新过
			/// </summary>
			public readonly static Field M_MONEY_UPDATE = new Field("M_MONEY_UPDATE", "WIN_RESULT_ANNO", "标注金额单位是否被更新过，1表示更新过");
            /// <summary>
			/// 联合体代码
			/// </summary>
			public readonly static Field UNION_CODE = new Field("UNION_CODE", "WIN_RESULT_ANNO", "联合体代码");
            /// <summary>
			/// 联合体名称
			/// </summary>
			public readonly static Field UNION_NAME = new Field("UNION_NAME", "WIN_RESULT_ANNO", "联合体名称");
            /// <summary>
			/// 中标费率
			/// </summary>
			public readonly static Field RATE = new Field("RATE", "WIN_RESULT_ANNO", "中标费率");
            /// <summary>
			/// 其他类型中标价
			/// </summary>
			public readonly static Field OTHER_WIN_PRICE = new Field("OTHER_WIN_PRICE", "WIN_RESULT_ANNO",DbType.AnsiString, null, "其他类型中标价");
            /// <summary>
			/// 其他内容
			/// </summary>
			public readonly static Field OTHER_CONTENT = new Field("OTHER_CONTENT", "WIN_RESULT_ANNO",DbType.AnsiString, null, "其他内容");
            /// <summary>
			/// 公示发布责任人
			/// </summary>
			public readonly static Field BULLETIN_DUTY = new Field("BULLETIN_DUTY", "WIN_RESULT_ANNO", "公示发布责任人");
            /// <summary>
			/// 交易平台数据验证责任人姓名
			/// </summary>
			public readonly static Field EXAMINER_NAME = new Field("EXAMINER_NAME", "WIN_RESULT_ANNO", "交易平台数据验证责任人姓名");
            /// <summary>
			/// 标段（包）所在行政区域代码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "WIN_RESULT_ANNO", "标段（包）所在行政区域代码");
            /// <summary>
			/// 交易发生行政区域代码
			/// </summary>
			public readonly static Field TRA_PLACE_CODE = new Field("TRA_PLACE_CODE", "WIN_RESULT_ANNO", "交易发生行政区域代码");
            /// <summary>
			/// 招标代理机构名称
			/// </summary>
			public readonly static Field TENDER_AGENCY_NAME = new Field("TENDER_AGENCY_NAME", "WIN_RESULT_ANNO", "招标代理机构名称");
            /// <summary>
			/// 招标代理机构代码
			/// </summary>
			public readonly static Field TENDER_AGENCY_CODE = new Field("TENDER_AGENCY_CODE", "WIN_RESULT_ANNO", "招标代理机构代码");
            /// <summary>
			/// 价款形式代码
			/// </summary>
			public readonly static Field PRICE_FORM_CODE = new Field("PRICE_FORM_CODE", "WIN_RESULT_ANNO", "价款形式代码");
            /// <summary>
			/// 费率或其它类型结果
			/// </summary>
			public readonly static Field OTHER_BID_PRICE = new Field("OTHER_BID_PRICE", "WIN_RESULT_ANNO",DbType.AnsiString, null, "费率或其它类型结果");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "WIN_RESULT_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "WIN_RESULT_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "WIN_RESULT_ANNO", "");
            /// <summary>
			/// 中标投标人企业注册所在地
			/// </summary>
			public readonly static Field BIDDER_REGION_CODE = new Field("BIDDER_REGION_CODE", "WIN_RESULT_ANNO", "中标投标人企业注册所在地");
            /// <summary>
			/// 中标投标人企业性质
			/// </summary>
			public readonly static Field BIDDER_PROPERTY = new Field("BIDDER_PROPERTY", "WIN_RESULT_ANNO", "中标投标人企业性质");
            /// <summary>
			/// 项目负责人
			/// </summary>
			public readonly static Field PROJECT_LEAD = new Field("PROJECT_LEAD", "WIN_RESULT_ANNO", "项目负责人");
            /// <summary>
			/// 项目负责人身份证号码
			/// </summary>
			public readonly static Field PROJECT_LEAD_ID = new Field("PROJECT_LEAD_ID", "WIN_RESULT_ANNO", "项目负责人身份证号码");
        }
        #endregion
	}
}