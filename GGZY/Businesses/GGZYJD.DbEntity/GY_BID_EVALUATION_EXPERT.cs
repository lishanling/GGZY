﻿using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类GY_BID_EVALUATION_EXPERT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("GY_BID_EVALUATION_EXPERT")]
    [Serializable]
    public partial class GY_BID_EVALUATION_EXPERT : JdEntity
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
		private string _EXPERT_TYPE;
		private string _EXPERT_NAME;
		private string _ID_CARD;
		private string _ID_CARD_TYPE;
		private DateTime? _EXPERT_CHECK_IN_TIME;
		private string _IS_CHAIR_MAN;
		private string _IS_INVALID_SCORE;
		private string _IS_TENDER_AGENT;
		private string _IS_ECONOMICAL_EXPERT;
		private string _IS_TECHNOLOGICAL_EXPERT;
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
		/// 专家类别
		/// </summary>
		public string EXPERT_TYPE
		{
			get{ return _EXPERT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_TYPE, _EXPERT_TYPE, value);
				this._EXPERT_TYPE = value;
			}
		}
		/// <summary>
		/// 专家姓名
		/// </summary>
		public string EXPERT_NAME
		{
			get{ return _EXPERT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_NAME, _EXPERT_NAME, value);
				this._EXPERT_NAME = value;
			}
		}
		/// <summary>
		/// 专家身份证件号
		/// </summary>
		public string ID_CARD
		{
			get{ return _ID_CARD; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD, _ID_CARD, value);
				this._ID_CARD = value;
			}
		}
		/// <summary>
		/// 专家身份证件类型
		/// </summary>
		public string ID_CARD_TYPE
		{
			get{ return _ID_CARD_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD_TYPE, _ID_CARD_TYPE, value);
				this._ID_CARD_TYPE = value;
			}
		}
		/// <summary>
		/// 专家签到时间
		/// </summary>
		public DateTime? EXPERT_CHECK_IN_TIME
		{
			get{ return _EXPERT_CHECK_IN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_CHECK_IN_TIME, _EXPERT_CHECK_IN_TIME, value);
				this._EXPERT_CHECK_IN_TIME = value;
			}
		}
		/// <summary>
		/// 是否为评标组长
		/// </summary>
		public string IS_CHAIR_MAN
		{
			get{ return _IS_CHAIR_MAN; }
			set
			{
				this.OnPropertyValueChange(_.IS_CHAIR_MAN, _IS_CHAIR_MAN, value);
				this._IS_CHAIR_MAN = value;
			}
		}
		/// <summary>
		/// 是否无效评分
		/// </summary>
		public string IS_INVALID_SCORE
		{
			get{ return _IS_INVALID_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.IS_INVALID_SCORE, _IS_INVALID_SCORE, value);
				this._IS_INVALID_SCORE = value;
			}
		}
		/// <summary>
		/// 是否招标人代表
		/// </summary>
		public string IS_TENDER_AGENT
		{
			get{ return _IS_TENDER_AGENT; }
			set
			{
				this.OnPropertyValueChange(_.IS_TENDER_AGENT, _IS_TENDER_AGENT, value);
				this._IS_TENDER_AGENT = value;
			}
		}
		/// <summary>
		/// 是否经济标评委
		/// </summary>
		public string IS_ECONOMICAL_EXPERT
		{
			get{ return _IS_ECONOMICAL_EXPERT; }
			set
			{
				this.OnPropertyValueChange(_.IS_ECONOMICAL_EXPERT, _IS_ECONOMICAL_EXPERT, value);
				this._IS_ECONOMICAL_EXPERT = value;
			}
		}
		/// <summary>
		/// 是否技术标评委
		/// </summary>
		public string IS_TECHNOLOGICAL_EXPERT
		{
			get{ return _IS_TECHNOLOGICAL_EXPERT; }
			set
			{
				this.OnPropertyValueChange(_.IS_TECHNOLOGICAL_EXPERT, _IS_TECHNOLOGICAL_EXPERT, value);
				this._IS_TECHNOLOGICAL_EXPERT = value;
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
				_.EXPERT_TYPE,
				_.EXPERT_NAME,
				_.ID_CARD,
				_.ID_CARD_TYPE,
				_.EXPERT_CHECK_IN_TIME,
				_.IS_CHAIR_MAN,
				_.IS_INVALID_SCORE,
				_.IS_TENDER_AGENT,
				_.IS_ECONOMICAL_EXPERT,
				_.IS_TECHNOLOGICAL_EXPERT,
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
				this._EXPERT_TYPE,
				this._EXPERT_NAME,
				this._ID_CARD,
				this._ID_CARD_TYPE,
				this._EXPERT_CHECK_IN_TIME,
				this._IS_CHAIR_MAN,
				this._IS_INVALID_SCORE,
				this._IS_TENDER_AGENT,
				this._IS_ECONOMICAL_EXPERT,
				this._IS_TECHNOLOGICAL_EXPERT,
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
			public readonly static Field All = new Field("*", "GY_BID_EVALUATION_EXPERT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "GY_BID_EVALUATION_EXPERT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "GY_BID_EVALUATION_EXPERT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "GY_BID_EVALUATION_EXPERT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "GY_BID_EVALUATION_EXPERT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "GY_BID_EVALUATION_EXPERT", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "GY_BID_EVALUATION_EXPERT", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "GY_BID_EVALUATION_EXPERT", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "GY_BID_EVALUATION_EXPERT", "统一交易标识码");
            /// <summary>
			/// 专家类别
			/// </summary>
			public readonly static Field EXPERT_TYPE = new Field("EXPERT_TYPE", "GY_BID_EVALUATION_EXPERT", "专家类别");
            /// <summary>
			/// 专家姓名
			/// </summary>
			public readonly static Field EXPERT_NAME = new Field("EXPERT_NAME", "GY_BID_EVALUATION_EXPERT", "专家姓名");
            /// <summary>
			/// 专家身份证件号
			/// </summary>
			public readonly static Field ID_CARD = new Field("ID_CARD", "GY_BID_EVALUATION_EXPERT", "专家身份证件号");
            /// <summary>
			/// 专家身份证件类型
			/// </summary>
			public readonly static Field ID_CARD_TYPE = new Field("ID_CARD_TYPE", "GY_BID_EVALUATION_EXPERT", "专家身份证件类型");
            /// <summary>
			/// 专家签到时间
			/// </summary>
			public readonly static Field EXPERT_CHECK_IN_TIME = new Field("EXPERT_CHECK_IN_TIME", "GY_BID_EVALUATION_EXPERT", "专家签到时间");
            /// <summary>
			/// 是否为评标组长
			/// </summary>
			public readonly static Field IS_CHAIR_MAN = new Field("IS_CHAIR_MAN", "GY_BID_EVALUATION_EXPERT", "是否为评标组长");
            /// <summary>
			/// 是否无效评分
			/// </summary>
			public readonly static Field IS_INVALID_SCORE = new Field("IS_INVALID_SCORE", "GY_BID_EVALUATION_EXPERT", "是否无效评分");
            /// <summary>
			/// 是否招标人代表
			/// </summary>
			public readonly static Field IS_TENDER_AGENT = new Field("IS_TENDER_AGENT", "GY_BID_EVALUATION_EXPERT", "是否招标人代表");
            /// <summary>
			/// 是否经济标评委
			/// </summary>
			public readonly static Field IS_ECONOMICAL_EXPERT = new Field("IS_ECONOMICAL_EXPERT", "GY_BID_EVALUATION_EXPERT", "是否经济标评委");
            /// <summary>
			/// 是否技术标评委
			/// </summary>
			public readonly static Field IS_TECHNOLOGICAL_EXPERT = new Field("IS_TECHNOLOGICAL_EXPERT", "GY_BID_EVALUATION_EXPERT", "是否技术标评委");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "GY_BID_EVALUATION_EXPERT", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "GY_BID_EVALUATION_EXPERT", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "GY_BID_EVALUATION_EXPERT", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "GY_BID_EVALUATION_EXPERT", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "GY_BID_EVALUATION_EXPERT", "公共服务平台标识码");
        }
        #endregion
	}
}