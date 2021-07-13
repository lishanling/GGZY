﻿using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类XX_TENDER_CANDIDATE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("XX_TENDER_CANDIDATE")]
    [Serializable]
    public partial class XX_TENDER_CANDIDATE : JdEntity
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
		private string _WIN_CANDIDATE_NAME;
		private string _BIDDER_CODE_TYPE;
		private string _WIN_CANDIDATE_CODE;
		private string _BIDDER_ROLE;
		private string _BIDDER_REGION_CODE;
		private string _BIDDER_PROPERTY;
		private decimal? _WIN_CANDIDATE_ORDER;
		private string _IS_FLOAT_RATE;
		private string _EVALUATION_RESULT;
		private string _PRICE_FORM_CODE;
		private string _OTHER_BID_PRICE;
		private decimal? _BID_PRICE;
		private string _PRICE_CURRENCY;
		private string _PRICE_UINT;
		private string _QUALITY;
		private string _EVALUATION_STATUS;
		private string _WIN_CANDIDATE_QUALIFICATION;
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
		/// 中标候选人名称
		/// </summary>
		public string WIN_CANDIDATE_NAME
		{
			get{ return _WIN_CANDIDATE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.WIN_CANDIDATE_NAME, _WIN_CANDIDATE_NAME, value);
				this._WIN_CANDIDATE_NAME = value;
			}
		}
		/// <summary>
		/// 中标候选人类别
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
		/// 中标候选人代码
		/// </summary>
		public string WIN_CANDIDATE_CODE
		{
			get{ return _WIN_CANDIDATE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.WIN_CANDIDATE_CODE, _WIN_CANDIDATE_CODE, value);
				this._WIN_CANDIDATE_CODE = value;
			}
		}
		/// <summary>
		/// 中标候选人角色
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
		/// 中标候选人人企业注册所在地
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
		/// 中标候选人企业性质
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
		/// 中标候选人排名
		/// </summary>
		public decimal? WIN_CANDIDATE_ORDER
		{
			get{ return _WIN_CANDIDATE_ORDER; }
			set
			{
				this.OnPropertyValueChange(_.WIN_CANDIDATE_ORDER, _WIN_CANDIDATE_ORDER, value);
				this._WIN_CANDIDATE_ORDER = value;
			}
		}
		/// <summary>
		/// 是否采用下浮率
		/// </summary>
		public string IS_FLOAT_RATE
		{
			get{ return _IS_FLOAT_RATE; }
			set
			{
				this.OnPropertyValueChange(_.IS_FLOAT_RATE, _IS_FLOAT_RATE, value);
				this._IS_FLOAT_RATE = value;
			}
		}
		/// <summary>
		/// 评分结果
		/// </summary>
		public string EVALUATION_RESULT
		{
			get{ return _EVALUATION_RESULT; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATION_RESULT, _EVALUATION_RESULT, value);
				this._EVALUATION_RESULT = value;
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
		/// 费率或其它类型报价
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
		/// 投标价格
		/// </summary>
		public decimal? BID_PRICE
		{
			get{ return _BID_PRICE; }
			set
			{
				this.OnPropertyValueChange(_.BID_PRICE, _BID_PRICE, value);
				this._BID_PRICE = value;
			}
		}
		/// <summary>
		/// 价格币种代码
		/// </summary>
		public string PRICE_CURRENCY
		{
			get{ return _PRICE_CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_CURRENCY, _PRICE_CURRENCY, value);
				this._PRICE_CURRENCY = value;
			}
		}
		/// <summary>
		/// 价格单位
		/// </summary>
		public string PRICE_UINT
		{
			get{ return _PRICE_UINT; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_UINT, _PRICE_UINT, value);
				this._PRICE_UINT = value;
			}
		}
		/// <summary>
		/// 质量
		/// </summary>
		public string QUALITY
		{
			get{ return _QUALITY; }
			set
			{
				this.OnPropertyValueChange(_.QUALITY, _QUALITY, value);
				this._QUALITY = value;
			}
		}
		/// <summary>
		/// 评标情况
		/// </summary>
		public string EVALUATION_STATUS
		{
			get{ return _EVALUATION_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATION_STATUS, _EVALUATION_STATUS, value);
				this._EVALUATION_STATUS = value;
			}
		}
		/// <summary>
		/// 中标候选人响应招标文件的资格能力条件
		/// </summary>
		public string WIN_CANDIDATE_QUALIFICATION
		{
			get{ return _WIN_CANDIDATE_QUALIFICATION; }
			set
			{
				this.OnPropertyValueChange(_.WIN_CANDIDATE_QUALIFICATION, _WIN_CANDIDATE_QUALIFICATION, value);
				this._WIN_CANDIDATE_QUALIFICATION = value;
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
				_.WIN_CANDIDATE_NAME,
				_.BIDDER_CODE_TYPE,
				_.WIN_CANDIDATE_CODE,
				_.BIDDER_ROLE,
				_.BIDDER_REGION_CODE,
				_.BIDDER_PROPERTY,
				_.WIN_CANDIDATE_ORDER,
				_.IS_FLOAT_RATE,
				_.EVALUATION_RESULT,
				_.PRICE_FORM_CODE,
				_.OTHER_BID_PRICE,
				_.BID_PRICE,
				_.PRICE_CURRENCY,
				_.PRICE_UINT,
				_.QUALITY,
				_.EVALUATION_STATUS,
				_.WIN_CANDIDATE_QUALIFICATION,
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
				this._WIN_CANDIDATE_NAME,
				this._BIDDER_CODE_TYPE,
				this._WIN_CANDIDATE_CODE,
				this._BIDDER_ROLE,
				this._BIDDER_REGION_CODE,
				this._BIDDER_PROPERTY,
				this._WIN_CANDIDATE_ORDER,
				this._IS_FLOAT_RATE,
				this._EVALUATION_RESULT,
				this._PRICE_FORM_CODE,
				this._OTHER_BID_PRICE,
				this._BID_PRICE,
				this._PRICE_CURRENCY,
				this._PRICE_UINT,
				this._QUALITY,
				this._EVALUATION_STATUS,
				this._WIN_CANDIDATE_QUALIFICATION,
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
			public readonly static Field All = new Field("*", "XX_TENDER_CANDIDATE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "XX_TENDER_CANDIDATE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "XX_TENDER_CANDIDATE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "XX_TENDER_CANDIDATE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "XX_TENDER_CANDIDATE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "XX_TENDER_CANDIDATE", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "XX_TENDER_CANDIDATE", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "XX_TENDER_CANDIDATE", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "XX_TENDER_CANDIDATE", "统一交易标识码");
            /// <summary>
			/// 中标候选人名称
			/// </summary>
			public readonly static Field WIN_CANDIDATE_NAME = new Field("WIN_CANDIDATE_NAME", "XX_TENDER_CANDIDATE", "中标候选人名称");
            /// <summary>
			/// 中标候选人类别
			/// </summary>
			public readonly static Field BIDDER_CODE_TYPE = new Field("BIDDER_CODE_TYPE", "XX_TENDER_CANDIDATE", "中标候选人类别");
            /// <summary>
			/// 中标候选人代码
			/// </summary>
			public readonly static Field WIN_CANDIDATE_CODE = new Field("WIN_CANDIDATE_CODE", "XX_TENDER_CANDIDATE", "中标候选人代码");
            /// <summary>
			/// 中标候选人角色
			/// </summary>
			public readonly static Field BIDDER_ROLE = new Field("BIDDER_ROLE", "XX_TENDER_CANDIDATE", "中标候选人角色");
            /// <summary>
			/// 中标候选人人企业注册所在地
			/// </summary>
			public readonly static Field BIDDER_REGION_CODE = new Field("BIDDER_REGION_CODE", "XX_TENDER_CANDIDATE", "中标候选人人企业注册所在地");
            /// <summary>
			/// 中标候选人企业性质
			/// </summary>
			public readonly static Field BIDDER_PROPERTY = new Field("BIDDER_PROPERTY", "XX_TENDER_CANDIDATE", "中标候选人企业性质");
            /// <summary>
			/// 中标候选人排名
			/// </summary>
			public readonly static Field WIN_CANDIDATE_ORDER = new Field("WIN_CANDIDATE_ORDER", "XX_TENDER_CANDIDATE", "中标候选人排名");
            /// <summary>
			/// 是否采用下浮率
			/// </summary>
			public readonly static Field IS_FLOAT_RATE = new Field("IS_FLOAT_RATE", "XX_TENDER_CANDIDATE", "是否采用下浮率");
            /// <summary>
			/// 评分结果
			/// </summary>
			public readonly static Field EVALUATION_RESULT = new Field("EVALUATION_RESULT", "XX_TENDER_CANDIDATE",DbType.AnsiString, null, "评分结果");
            /// <summary>
			/// 价款形式代码
			/// </summary>
			public readonly static Field PRICE_FORM_CODE = new Field("PRICE_FORM_CODE", "XX_TENDER_CANDIDATE", "价款形式代码");
            /// <summary>
			/// 费率或其它类型报价
			/// </summary>
			public readonly static Field OTHER_BID_PRICE = new Field("OTHER_BID_PRICE", "XX_TENDER_CANDIDATE",DbType.AnsiString, null, "费率或其它类型报价");
            /// <summary>
			/// 投标价格
			/// </summary>
			public readonly static Field BID_PRICE = new Field("BID_PRICE", "XX_TENDER_CANDIDATE", "投标价格");
            /// <summary>
			/// 价格币种代码
			/// </summary>
			public readonly static Field PRICE_CURRENCY = new Field("PRICE_CURRENCY", "XX_TENDER_CANDIDATE", "价格币种代码");
            /// <summary>
			/// 价格单位
			/// </summary>
			public readonly static Field PRICE_UINT = new Field("PRICE_UINT", "XX_TENDER_CANDIDATE", "价格单位");
            /// <summary>
			/// 质量
			/// </summary>
			public readonly static Field QUALITY = new Field("QUALITY", "XX_TENDER_CANDIDATE",DbType.AnsiString, null, "质量");
            /// <summary>
			/// 评标情况
			/// </summary>
			public readonly static Field EVALUATION_STATUS = new Field("EVALUATION_STATUS", "XX_TENDER_CANDIDATE",DbType.AnsiString, null, "评标情况");
            /// <summary>
			/// 中标候选人响应招标文件的资格能力条件
			/// </summary>
			public readonly static Field WIN_CANDIDATE_QUALIFICATION = new Field("WIN_CANDIDATE_QUALIFICATION", "XX_TENDER_CANDIDATE",DbType.AnsiString, null, "中标候选人响应招标文件的资格能力条件");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "XX_TENDER_CANDIDATE", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "XX_TENDER_CANDIDATE", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "XX_TENDER_CANDIDATE", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "XX_TENDER_CANDIDATE", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "XX_TENDER_CANDIDATE", "公共服务平台标识码");
        }
        #endregion
	}
}