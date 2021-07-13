using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类DEA_CARBON_QUOTA_SELL_ANNO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("DEA_CARBON_QUOTA_SELL_ANNO")]
    [Serializable]
    public partial class DEA_CARBON_QUOTA_SELL_ANNO : FwEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_CREATOR;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _NOTICE_SEND_TIME;
		private string _UNIFIED_DEAL_CODES;
		private string _INDUSTRY_CODE;
		private string _CA_QUOTA_NAME;
		private string _CA_QUOTA_CODE;
		private DateTime? _CA_QUOTA_BEGINDATE;
		private DateTime? _CA_QUOTA_ENDDATE;
		private string _IN_BUY_KIND;
		private decimal? _CA_QUOTA_QTY;
		private decimal? _CA_QUOTA_PRICE;
		private DateTime? _TRADING_BEGINTIME;
		private DateTime? _TRADING_ENDTIME;
		private string _SALE_COMM_TYPE;
		private decimal? _SALE_COMM_RATE;
		private string _BUY_COMM_TYPE;
		private decimal? _BUY_COMM_RATE;
		private string _TRADING_NOTICE;
		private decimal? _MARGIN_PAY;
		private string _MARGIN_PAY_ACCOUNT;
		private string _ANNOUNCEMENT_CONNECT;
		private string _SELL_COMM_NAME;
		private string _SELL_ORG_CODE;
		private string _TENDERER_CONTACTOR;
		private string _TENDERER_PHONE_NUMBER;
		private string _URL;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_VERSION;

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
		/// 统一交易标识码
		/// </summary>
		public string UNIFIED_DEAL_CODES
		{
			get{ return _UNIFIED_DEAL_CODES; }
			set
			{
				this.OnPropertyValueChange(_.UNIFIED_DEAL_CODES, _UNIFIED_DEAL_CODES, value);
				this._UNIFIED_DEAL_CODES = value;
			}
		}
		/// <summary>
		/// 所属行业分类
		/// </summary>
		public string INDUSTRY_CODE
		{
			get{ return _INDUSTRY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.INDUSTRY_CODE, _INDUSTRY_CODE, value);
				this._INDUSTRY_CODE = value;
			}
		}
		/// <summary>
		/// 公告名称
		/// </summary>
		public string CA_QUOTA_NAME
		{
			get{ return _CA_QUOTA_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CA_QUOTA_NAME, _CA_QUOTA_NAME, value);
				this._CA_QUOTA_NAME = value;
			}
		}
		/// <summary>
		/// 公告编号
		/// </summary>
		public string CA_QUOTA_CODE
		{
			get{ return _CA_QUOTA_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CA_QUOTA_CODE, _CA_QUOTA_CODE, value);
				this._CA_QUOTA_CODE = value;
			}
		}
		/// <summary>
		/// 配额有效开始日期
		/// </summary>
		public DateTime? CA_QUOTA_BEGINDATE
		{
			get{ return _CA_QUOTA_BEGINDATE; }
			set
			{
				this.OnPropertyValueChange(_.CA_QUOTA_BEGINDATE, _CA_QUOTA_BEGINDATE, value);
				this._CA_QUOTA_BEGINDATE = value;
			}
		}
		/// <summary>
		/// 配额有效截止日期
		/// </summary>
		public DateTime? CA_QUOTA_ENDDATE
		{
			get{ return _CA_QUOTA_ENDDATE; }
			set
			{
				this.OnPropertyValueChange(_.CA_QUOTA_ENDDATE, _CA_QUOTA_ENDDATE, value);
				this._CA_QUOTA_ENDDATE = value;
			}
		}
		/// <summary>
		/// 出让方式(sys_dic type=9544)
		/// </summary>
		public string IN_BUY_KIND
		{
			get{ return _IN_BUY_KIND; }
			set
			{
				this.OnPropertyValueChange(_.IN_BUY_KIND, _IN_BUY_KIND, value);
				this._IN_BUY_KIND = value;
			}
		}
		/// <summary>
		/// 出让数量
		/// </summary>
		public decimal? CA_QUOTA_QTY
		{
			get{ return _CA_QUOTA_QTY; }
			set
			{
				this.OnPropertyValueChange(_.CA_QUOTA_QTY, _CA_QUOTA_QTY, value);
				this._CA_QUOTA_QTY = value;
			}
		}
		/// <summary>
		/// 保留价格
		/// </summary>
		public decimal? CA_QUOTA_PRICE
		{
			get{ return _CA_QUOTA_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.CA_QUOTA_PRICE, _CA_QUOTA_PRICE, value);
				this._CA_QUOTA_PRICE = value;
			}
		}
		/// <summary>
		/// 竞价开始时间
		/// </summary>
		public DateTime? TRADING_BEGINTIME
		{
			get{ return _TRADING_BEGINTIME; }
			set
			{
				this.OnPropertyValueChange(_.TRADING_BEGINTIME, _TRADING_BEGINTIME, value);
				this._TRADING_BEGINTIME = value;
			}
		}
		/// <summary>
		/// 竞价结束时间
		/// </summary>
		public DateTime? TRADING_ENDTIME
		{
			get{ return _TRADING_ENDTIME; }
			set
			{
				this.OnPropertyValueChange(_.TRADING_ENDTIME, _TRADING_ENDTIME, value);
				this._TRADING_ENDTIME = value;
			}
		}
		/// <summary>
		/// 出让方佣金基数类型(sys_dic type=9545)
		/// </summary>
		public string SALE_COMM_TYPE
		{
			get{ return _SALE_COMM_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.SALE_COMM_TYPE, _SALE_COMM_TYPE, value);
				this._SALE_COMM_TYPE = value;
			}
		}
		/// <summary>
		/// 出让方佣金比例
		/// </summary>
		public decimal? SALE_COMM_RATE
		{
			get{ return _SALE_COMM_RATE; }
			set
			{
				this.OnPropertyValueChange(_.SALE_COMM_RATE, _SALE_COMM_RATE, value);
				this._SALE_COMM_RATE = value;
			}
		}
		/// <summary>
		/// 受让方佣金基数类型(sys_dic type=9545)
		/// </summary>
		public string BUY_COMM_TYPE
		{
			get{ return _BUY_COMM_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BUY_COMM_TYPE, _BUY_COMM_TYPE, value);
				this._BUY_COMM_TYPE = value;
			}
		}
		/// <summary>
		/// 受让方佣金比例
		/// </summary>
		public decimal? BUY_COMM_RATE
		{
			get{ return _BUY_COMM_RATE; }
			set
			{
				this.OnPropertyValueChange(_.BUY_COMM_RATE, _BUY_COMM_RATE, value);
				this._BUY_COMM_RATE = value;
			}
		}
		/// <summary>
		/// 出让权益说明
		/// </summary>
		public string TRADING_NOTICE
		{
			get{ return _TRADING_NOTICE; }
			set
			{
				this.OnPropertyValueChange(_.TRADING_NOTICE, _TRADING_NOTICE, value);
				this._TRADING_NOTICE = value;
			}
		}
		/// <summary>
		/// 保证金
		/// </summary>
		public decimal? MARGIN_PAY
		{
			get{ return _MARGIN_PAY; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_PAY, _MARGIN_PAY, value);
				this._MARGIN_PAY = value;
			}
		}
		/// <summary>
		/// 保证金缴纳账户
		/// </summary>
		public string MARGIN_PAY_ACCOUNT
		{
			get{ return _MARGIN_PAY_ACCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_PAY_ACCOUNT, _MARGIN_PAY_ACCOUNT, value);
				this._MARGIN_PAY_ACCOUNT = value;
			}
		}
		/// <summary>
		/// 公告内容
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
		/// 出让人名称
		/// </summary>
		public string SELL_COMM_NAME
		{
			get{ return _SELL_COMM_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SELL_COMM_NAME, _SELL_COMM_NAME, value);
				this._SELL_COMM_NAME = value;
			}
		}
		/// <summary>
		/// 出让方人一社会信用代码,采用GB11714 -1997《全国组织机构代码编制规则》或GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》或GB 11643－1999《公民身份号码》
		/// </summary>
		public string SELL_ORG_CODE
		{
			get{ return _SELL_ORG_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SELL_ORG_CODE, _SELL_ORG_CODE, value);
				this._SELL_ORG_CODE = value;
			}
		}
		/// <summary>
		/// 出让人联系人
		/// </summary>
		public string TENDERER_CONTACTOR
		{
			get{ return _TENDERER_CONTACTOR; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_CONTACTOR, _TENDERER_CONTACTOR, value);
				this._TENDERER_CONTACTOR = value;
			}
		}
		/// <summary>
		/// 出让人联系电话
		/// </summary>
		public string TENDERER_PHONE_NUMBER
		{
			get{ return _TENDERER_PHONE_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_PHONE_NUMBER, _TENDERER_PHONE_NUMBER, value);
				this._TENDERER_PHONE_NUMBER = value;
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
		/// 交易系统标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》
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
		/// 公共服务平台标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》
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
		/// 数据时间戳，采用组合码，编码长度为14位数时间戳，由省级服务平台生成
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
				_.M_ID,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_CREATOR,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.NOTICE_SEND_TIME,
				_.UNIFIED_DEAL_CODES,
				_.INDUSTRY_CODE,
				_.CA_QUOTA_NAME,
				_.CA_QUOTA_CODE,
				_.CA_QUOTA_BEGINDATE,
				_.CA_QUOTA_ENDDATE,
				_.IN_BUY_KIND,
				_.CA_QUOTA_QTY,
				_.CA_QUOTA_PRICE,
				_.TRADING_BEGINTIME,
				_.TRADING_ENDTIME,
				_.SALE_COMM_TYPE,
				_.SALE_COMM_RATE,
				_.BUY_COMM_TYPE,
				_.BUY_COMM_RATE,
				_.TRADING_NOTICE,
				_.MARGIN_PAY,
				_.MARGIN_PAY_ACCOUNT,
				_.ANNOUNCEMENT_CONNECT,
				_.SELL_COMM_NAME,
				_.SELL_ORG_CODE,
				_.TENDERER_CONTACTOR,
				_.TENDERER_PHONE_NUMBER,
				_.URL,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._M_ID,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_CREATOR,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._NOTICE_SEND_TIME,
				this._UNIFIED_DEAL_CODES,
				this._INDUSTRY_CODE,
				this._CA_QUOTA_NAME,
				this._CA_QUOTA_CODE,
				this._CA_QUOTA_BEGINDATE,
				this._CA_QUOTA_ENDDATE,
				this._IN_BUY_KIND,
				this._CA_QUOTA_QTY,
				this._CA_QUOTA_PRICE,
				this._TRADING_BEGINTIME,
				this._TRADING_ENDTIME,
				this._SALE_COMM_TYPE,
				this._SALE_COMM_RATE,
				this._BUY_COMM_TYPE,
				this._BUY_COMM_RATE,
				this._TRADING_NOTICE,
				this._MARGIN_PAY,
				this._MARGIN_PAY_ACCOUNT,
				this._ANNOUNCEMENT_CONNECT,
				this._SELL_COMM_NAME,
				this._SELL_ORG_CODE,
				this._TENDERER_CONTACTOR,
				this._TENDERER_PHONE_NUMBER,
				this._URL,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
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
			public readonly static Field All = new Field("*", "DEA_CARBON_QUOTA_SELL_ANNO");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "DEA_CARBON_QUOTA_SELL_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "DEA_CARBON_QUOTA_SELL_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "DEA_CARBON_QUOTA_SELL_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "DEA_CARBON_QUOTA_SELL_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "DEA_CARBON_QUOTA_SELL_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "DEA_CARBON_QUOTA_SELL_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "DEA_CARBON_QUOTA_SELL_ANNO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "DEA_CARBON_QUOTA_SELL_ANNO", "");
            /// <summary>
			/// 公告发布时间
			/// </summary>
			public readonly static Field NOTICE_SEND_TIME = new Field("NOTICE_SEND_TIME", "DEA_CARBON_QUOTA_SELL_ANNO", "公告发布时间");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODES = new Field("UNIFIED_DEAL_CODES", "DEA_CARBON_QUOTA_SELL_ANNO", "统一交易标识码");
            /// <summary>
			/// 所属行业分类
			/// </summary>
			public readonly static Field INDUSTRY_CODE = new Field("INDUSTRY_CODE", "DEA_CARBON_QUOTA_SELL_ANNO", "所属行业分类");
            /// <summary>
			/// 公告名称
			/// </summary>
			public readonly static Field CA_QUOTA_NAME = new Field("CA_QUOTA_NAME", "DEA_CARBON_QUOTA_SELL_ANNO", "公告名称");
            /// <summary>
			/// 公告编号
			/// </summary>
			public readonly static Field CA_QUOTA_CODE = new Field("CA_QUOTA_CODE", "DEA_CARBON_QUOTA_SELL_ANNO", "公告编号");
            /// <summary>
			/// 配额有效开始日期
			/// </summary>
			public readonly static Field CA_QUOTA_BEGINDATE = new Field("CA_QUOTA_BEGINDATE", "DEA_CARBON_QUOTA_SELL_ANNO", "配额有效开始日期");
            /// <summary>
			/// 配额有效截止日期
			/// </summary>
			public readonly static Field CA_QUOTA_ENDDATE = new Field("CA_QUOTA_ENDDATE", "DEA_CARBON_QUOTA_SELL_ANNO", "配额有效截止日期");
            /// <summary>
			/// 出让方式(sys_dic type=9544)
			/// </summary>
			public readonly static Field IN_BUY_KIND = new Field("IN_BUY_KIND", "DEA_CARBON_QUOTA_SELL_ANNO", "出让方式(sys_dic type=9544)");
            /// <summary>
			/// 出让数量
			/// </summary>
			public readonly static Field CA_QUOTA_QTY = new Field("CA_QUOTA_QTY", "DEA_CARBON_QUOTA_SELL_ANNO", "出让数量");
            /// <summary>
			/// 保留价格
			/// </summary>
			public readonly static Field CA_QUOTA_PRICE = new Field("CA_QUOTA_PRICE", "DEA_CARBON_QUOTA_SELL_ANNO", "保留价格");
            /// <summary>
			/// 竞价开始时间
			/// </summary>
			public readonly static Field TRADING_BEGINTIME = new Field("TRADING_BEGINTIME", "DEA_CARBON_QUOTA_SELL_ANNO", "竞价开始时间");
            /// <summary>
			/// 竞价结束时间
			/// </summary>
			public readonly static Field TRADING_ENDTIME = new Field("TRADING_ENDTIME", "DEA_CARBON_QUOTA_SELL_ANNO", "竞价结束时间");
            /// <summary>
			/// 出让方佣金基数类型(sys_dic type=9545)
			/// </summary>
			public readonly static Field SALE_COMM_TYPE = new Field("SALE_COMM_TYPE", "DEA_CARBON_QUOTA_SELL_ANNO", "出让方佣金基数类型(sys_dic type=9545)");
            /// <summary>
			/// 出让方佣金比例
			/// </summary>
			public readonly static Field SALE_COMM_RATE = new Field("SALE_COMM_RATE", "DEA_CARBON_QUOTA_SELL_ANNO", "出让方佣金比例");
            /// <summary>
			/// 受让方佣金基数类型(sys_dic type=9545)
			/// </summary>
			public readonly static Field BUY_COMM_TYPE = new Field("BUY_COMM_TYPE", "DEA_CARBON_QUOTA_SELL_ANNO", "受让方佣金基数类型(sys_dic type=9545)");
            /// <summary>
			/// 受让方佣金比例
			/// </summary>
			public readonly static Field BUY_COMM_RATE = new Field("BUY_COMM_RATE", "DEA_CARBON_QUOTA_SELL_ANNO", "受让方佣金比例");
            /// <summary>
			/// 出让权益说明
			/// </summary>
			public readonly static Field TRADING_NOTICE = new Field("TRADING_NOTICE", "DEA_CARBON_QUOTA_SELL_ANNO",DbType.AnsiString, null, "出让权益说明");
            /// <summary>
			/// 保证金
			/// </summary>
			public readonly static Field MARGIN_PAY = new Field("MARGIN_PAY", "DEA_CARBON_QUOTA_SELL_ANNO", "保证金");
            /// <summary>
			/// 保证金缴纳账户
			/// </summary>
			public readonly static Field MARGIN_PAY_ACCOUNT = new Field("MARGIN_PAY_ACCOUNT", "DEA_CARBON_QUOTA_SELL_ANNO", "保证金缴纳账户");
            /// <summary>
			/// 公告内容
			/// </summary>
			public readonly static Field ANNOUNCEMENT_CONNECT = new Field("ANNOUNCEMENT_CONNECT", "DEA_CARBON_QUOTA_SELL_ANNO",DbType.AnsiString, null, "公告内容");
            /// <summary>
			/// 出让人名称
			/// </summary>
			public readonly static Field SELL_COMM_NAME = new Field("SELL_COMM_NAME", "DEA_CARBON_QUOTA_SELL_ANNO", "出让人名称");
            /// <summary>
			/// 出让方人一社会信用代码,采用GB11714 -1997《全国组织机构代码编制规则》或GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》或GB 11643－1999《公民身份号码》
			/// </summary>
			public readonly static Field SELL_ORG_CODE = new Field("SELL_ORG_CODE", "DEA_CARBON_QUOTA_SELL_ANNO", "出让方人一社会信用代码,采用GB11714 -1997《全国组织机构代码编制规则》或GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》或GB 11643－1999《公民身份号码》");
            /// <summary>
			/// 出让人联系人
			/// </summary>
			public readonly static Field TENDERER_CONTACTOR = new Field("TENDERER_CONTACTOR", "DEA_CARBON_QUOTA_SELL_ANNO", "出让人联系人");
            /// <summary>
			/// 出让人联系电话
			/// </summary>
			public readonly static Field TENDERER_PHONE_NUMBER = new Field("TENDERER_PHONE_NUMBER", "DEA_CARBON_QUOTA_SELL_ANNO", "出让人联系电话");
            /// <summary>
			/// 公告源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "DEA_CARBON_QUOTA_SELL_ANNO", "公告源URL");
            /// <summary>
			/// 交易系统标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "DEA_CARBON_QUOTA_SELL_ANNO", "交易系统标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》");
            /// <summary>
			/// 公共服务平台标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "DEA_CARBON_QUOTA_SELL_ANNO", "公共服务平台标识码,采用GB 32100-2015 《法人和其他组织统一社会信用代码编码规则》");
            /// <summary>
			/// 数据时间戳，采用组合码，编码长度为14位数时间戳，由省级服务平台生成
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "DEA_CARBON_QUOTA_SELL_ANNO", "数据时间戳，采用组合码，编码长度为14位数时间戳，由省级服务平台生成");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "DEA_CARBON_QUOTA_SELL_ANNO", "");
        }
        #endregion
	}
}