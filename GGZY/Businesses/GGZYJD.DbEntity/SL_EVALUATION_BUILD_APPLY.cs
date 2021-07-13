﻿using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类SL_EVALUATION_BUILD_APPLY。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SL_EVALUATION_BUILD_APPLY")]
    [Serializable]
    public partial class SL_EVALUATION_BUILD_APPLY : JdEntity
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
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _EXTRACT_RULE;
		private DateTime? _EXTRACT_APPLY_TIME;
		private DateTime? _EXTRACT_TIME;
		private string _EXPERT_LIST_CONFIRM;

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
		/// 电子招标投标交易平台或发布工具标识码
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
		/// 电子招标投标公共服务平台标识码
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
		/// 专家抽取规则
		/// </summary>
		public string EXTRACT_RULE
		{
			get{ return _EXTRACT_RULE; }
			set
			{
				this.OnPropertyValueChange(_.EXTRACT_RULE, _EXTRACT_RULE, value);
				this._EXTRACT_RULE = value;
			}
		}
		/// <summary>
		/// 专家抽取申请时间
		/// </summary>
		public DateTime? EXTRACT_APPLY_TIME
		{
			get{ return _EXTRACT_APPLY_TIME; }
			set
			{
				this.OnPropertyValueChange(_.EXTRACT_APPLY_TIME, _EXTRACT_APPLY_TIME, value);
				this._EXTRACT_APPLY_TIME = value;
			}
		}
		/// <summary>
		/// 专家抽取时间
		/// </summary>
		public DateTime? EXTRACT_TIME
		{
			get{ return _EXTRACT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.EXTRACT_TIME, _EXTRACT_TIME, value);
				this._EXTRACT_TIME = value;
			}
		}
		/// <summary>
		/// 专家名单确定方式
		/// </summary>
		public string EXPERT_LIST_CONFIRM
		{
			get{ return _EXPERT_LIST_CONFIRM; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_LIST_CONFIRM, _EXPERT_LIST_CONFIRM, value);
				this._EXPERT_LIST_CONFIRM = value;
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
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.EXTRACT_RULE,
				_.EXTRACT_APPLY_TIME,
				_.EXTRACT_TIME,
				_.EXPERT_LIST_CONFIRM,
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
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._EXTRACT_RULE,
				this._EXTRACT_APPLY_TIME,
				this._EXTRACT_TIME,
				this._EXPERT_LIST_CONFIRM,
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
			public readonly static Field All = new Field("*", "SL_EVALUATION_BUILD_APPLY");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "SL_EVALUATION_BUILD_APPLY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "SL_EVALUATION_BUILD_APPLY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "SL_EVALUATION_BUILD_APPLY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "SL_EVALUATION_BUILD_APPLY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "SL_EVALUATION_BUILD_APPLY", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "SL_EVALUATION_BUILD_APPLY", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "SL_EVALUATION_BUILD_APPLY", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "SL_EVALUATION_BUILD_APPLY", "统一交易标识码");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "SL_EVALUATION_BUILD_APPLY", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "SL_EVALUATION_BUILD_APPLY", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "SL_EVALUATION_BUILD_APPLY", "数据时间戳");
            /// <summary>
			/// 电子招标投标交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "SL_EVALUATION_BUILD_APPLY", "电子招标投标交易平台或发布工具标识码");
            /// <summary>
			/// 电子招标投标公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "SL_EVALUATION_BUILD_APPLY", "电子招标投标公共服务平台标识码");
            /// <summary>
			/// 专家抽取规则
			/// </summary>
			public readonly static Field EXTRACT_RULE = new Field("EXTRACT_RULE", "SL_EVALUATION_BUILD_APPLY", "专家抽取规则");
            /// <summary>
			/// 专家抽取申请时间
			/// </summary>
			public readonly static Field EXTRACT_APPLY_TIME = new Field("EXTRACT_APPLY_TIME", "SL_EVALUATION_BUILD_APPLY", "专家抽取申请时间");
            /// <summary>
			/// 专家抽取时间
			/// </summary>
			public readonly static Field EXTRACT_TIME = new Field("EXTRACT_TIME", "SL_EVALUATION_BUILD_APPLY", "专家抽取时间");
            /// <summary>
			/// 专家名单确定方式
			/// </summary>
			public readonly static Field EXPERT_LIST_CONFIRM = new Field("EXPERT_LIST_CONFIRM", "SL_EVALUATION_BUILD_APPLY", "专家名单确定方式");
        }
        #endregion
	}
}