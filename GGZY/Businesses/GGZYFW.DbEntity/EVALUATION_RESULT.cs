﻿using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类EVALUATION_RESULT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("EVALUATION_RESULT")]
    [Serializable]
    public partial class EVALUATION_RESULT : FwEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_VERSION;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _BIDDER_NAME;
		private string _BIDDER_CODE_TYPE;
		private string _BIDDER_ORG_CODE;
		private string _BIDDER_ROLE;
		private string _UNION_ENTERPRISE_NAME;
		private string _UNION_ORGAN_SET_CODE;
		private string _UNION_CONTACT_NAME;
		private string _UNION_CONTACT_PHONE;
		private decimal? _PRICE_POINTS;
		private decimal? _QUALIFICATION_POINTS;
		private decimal? _BUSINESS_POINTS;
		private decimal? _TECHNICAL_POINTS;
		private decimal? _RESPONSE_POINTS;
		private decimal? _OTHER_POINTS;
		private string _IS_VETO;
		private string _VETO_REASON_DETAIL;
		private decimal? _RANK;
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
		/// 投标人名称
		/// </summary>
		public string BIDDER_NAME
		{
			get{ return _BIDDER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_NAME, _BIDDER_NAME, value);
				this._BIDDER_NAME = value;
			}
		}
		/// <summary>
		/// 投标人类别
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
		/// 投标人代码
		/// </summary>
		public string BIDDER_ORG_CODE
		{
			get{ return _BIDDER_ORG_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_ORG_CODE, _BIDDER_ORG_CODE, value);
				this._BIDDER_ORG_CODE = value;
			}
		}
		/// <summary>
		/// 投标人角色
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
		/// 联合体名称（如有）
		/// </summary>
		public string UNION_ENTERPRISE_NAME
		{
			get{ return _UNION_ENTERPRISE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.UNION_ENTERPRISE_NAME, _UNION_ENTERPRISE_NAME, value);
				this._UNION_ENTERPRISE_NAME = value;
			}
		}
		/// <summary>
		/// 联合体组织机构代码证（联合体招标时填写）
		/// </summary>
		public string UNION_ORGAN_SET_CODE
		{
			get{ return _UNION_ORGAN_SET_CODE; }
			set
			{
				this.OnPropertyValueChange(_.UNION_ORGAN_SET_CODE, _UNION_ORGAN_SET_CODE, value);
				this._UNION_ORGAN_SET_CODE = value;
			}
		}
		/// <summary>
		/// 联合体联系人（如有）
		/// </summary>
		public string UNION_CONTACT_NAME
		{
			get{ return _UNION_CONTACT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.UNION_CONTACT_NAME, _UNION_CONTACT_NAME, value);
				this._UNION_CONTACT_NAME = value;
			}
		}
		/// <summary>
		/// 联合体联系电话（如有）
		/// </summary>
		public string UNION_CONTACT_PHONE
		{
			get{ return _UNION_CONTACT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.UNION_CONTACT_PHONE, _UNION_CONTACT_PHONE, value);
				this._UNION_CONTACT_PHONE = value;
			}
		}
		/// <summary>
		/// 报价分
		/// </summary>
		public decimal? PRICE_POINTS
		{
			get{ return _PRICE_POINTS; }
			set
			{
				this.OnPropertyValueChange(_.PRICE_POINTS, _PRICE_POINTS, value);
				this._PRICE_POINTS = value;
			}
		}
		/// <summary>
		/// 资格分
		/// </summary>
		public decimal? QUALIFICATION_POINTS
		{
			get{ return _QUALIFICATION_POINTS; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFICATION_POINTS, _QUALIFICATION_POINTS, value);
				this._QUALIFICATION_POINTS = value;
			}
		}
		/// <summary>
		/// 商务分
		/// </summary>
		public decimal? BUSINESS_POINTS
		{
			get{ return _BUSINESS_POINTS; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESS_POINTS, _BUSINESS_POINTS, value);
				this._BUSINESS_POINTS = value;
			}
		}
		/// <summary>
		/// 技术分
		/// </summary>
		public decimal? TECHNICAL_POINTS
		{
			get{ return _TECHNICAL_POINTS; }
			set
			{
				this.OnPropertyValueChange(_.TECHNICAL_POINTS, _TECHNICAL_POINTS, value);
				this._TECHNICAL_POINTS = value;
			}
		}
		/// <summary>
		/// 响应性评审
		/// </summary>
		public decimal? RESPONSE_POINTS
		{
			get{ return _RESPONSE_POINTS; }
			set
			{
				this.OnPropertyValueChange(_.RESPONSE_POINTS, _RESPONSE_POINTS, value);
				this._RESPONSE_POINTS = value;
			}
		}
		/// <summary>
		/// 其他分
		/// </summary>
		public decimal? OTHER_POINTS
		{
			get{ return _OTHER_POINTS; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_POINTS, _OTHER_POINTS, value);
				this._OTHER_POINTS = value;
			}
		}
		/// <summary>
		/// 是否否决投标
		/// </summary>
		public string IS_VETO
		{
			get{ return _IS_VETO; }
			set
			{
				this.OnPropertyValueChange(_.IS_VETO, _IS_VETO, value);
				this._IS_VETO = value;
			}
		}
		/// <summary>
		/// 否决投标理由汇总
		/// </summary>
		public string VETO_REASON_DETAIL
		{
			get{ return _VETO_REASON_DETAIL; }
			set
			{
				this.OnPropertyValueChange(_.VETO_REASON_DETAIL, _VETO_REASON_DETAIL, value);
				this._VETO_REASON_DETAIL = value;
			}
		}
		/// <summary>
		/// 评分结果排位
		/// </summary>
		public decimal? RANK
		{
			get{ return _RANK; }
			set
			{
				this.OnPropertyValueChange(_.RANK, _RANK, value);
				this._RANK = value;
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
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_VERSION,
				_.TENDER_PROJECT_CODE,
				_.BID_SECTION_CODE,
				_.UNIFIED_DEAL_CODE,
				_.BIDDER_NAME,
				_.BIDDER_CODE_TYPE,
				_.BIDDER_ORG_CODE,
				_.BIDDER_ROLE,
				_.UNION_ENTERPRISE_NAME,
				_.UNION_ORGAN_SET_CODE,
				_.UNION_CONTACT_NAME,
				_.UNION_CONTACT_PHONE,
				_.PRICE_POINTS,
				_.QUALIFICATION_POINTS,
				_.BUSINESS_POINTS,
				_.TECHNICAL_POINTS,
				_.RESPONSE_POINTS,
				_.OTHER_POINTS,
				_.IS_VETO,
				_.VETO_REASON_DETAIL,
				_.RANK,
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
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_VERSION,
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODE,
				this._UNIFIED_DEAL_CODE,
				this._BIDDER_NAME,
				this._BIDDER_CODE_TYPE,
				this._BIDDER_ORG_CODE,
				this._BIDDER_ROLE,
				this._UNION_ENTERPRISE_NAME,
				this._UNION_ORGAN_SET_CODE,
				this._UNION_CONTACT_NAME,
				this._UNION_CONTACT_PHONE,
				this._PRICE_POINTS,
				this._QUALIFICATION_POINTS,
				this._BUSINESS_POINTS,
				this._TECHNICAL_POINTS,
				this._RESPONSE_POINTS,
				this._OTHER_POINTS,
				this._IS_VETO,
				this._VETO_REASON_DETAIL,
				this._RANK,
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
			public readonly static Field All = new Field("*", "EVALUATION_RESULT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "EVALUATION_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "EVALUATION_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "EVALUATION_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "EVALUATION_RESULT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "EVALUATION_RESULT", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "EVALUATION_RESULT", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "EVALUATION_RESULT", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "EVALUATION_RESULT", "统一交易标识码");
            /// <summary>
			/// 投标人名称
			/// </summary>
			public readonly static Field BIDDER_NAME = new Field("BIDDER_NAME", "EVALUATION_RESULT", "投标人名称");
            /// <summary>
			/// 投标人类别
			/// </summary>
			public readonly static Field BIDDER_CODE_TYPE = new Field("BIDDER_CODE_TYPE", "EVALUATION_RESULT", "投标人类别");
            /// <summary>
			/// 投标人代码
			/// </summary>
			public readonly static Field BIDDER_ORG_CODE = new Field("BIDDER_ORG_CODE", "EVALUATION_RESULT", "投标人代码");
            /// <summary>
			/// 投标人角色
			/// </summary>
			public readonly static Field BIDDER_ROLE = new Field("BIDDER_ROLE", "EVALUATION_RESULT", "投标人角色");
            /// <summary>
			/// 联合体名称（如有）
			/// </summary>
			public readonly static Field UNION_ENTERPRISE_NAME = new Field("UNION_ENTERPRISE_NAME", "EVALUATION_RESULT", "联合体名称（如有）");
            /// <summary>
			/// 联合体组织机构代码证（联合体招标时填写）
			/// </summary>
			public readonly static Field UNION_ORGAN_SET_CODE = new Field("UNION_ORGAN_SET_CODE", "EVALUATION_RESULT", "联合体组织机构代码证（联合体招标时填写）");
            /// <summary>
			/// 联合体联系人（如有）
			/// </summary>
			public readonly static Field UNION_CONTACT_NAME = new Field("UNION_CONTACT_NAME", "EVALUATION_RESULT", "联合体联系人（如有）");
            /// <summary>
			/// 联合体联系电话（如有）
			/// </summary>
			public readonly static Field UNION_CONTACT_PHONE = new Field("UNION_CONTACT_PHONE", "EVALUATION_RESULT", "联合体联系电话（如有）");
            /// <summary>
			/// 报价分
			/// </summary>
			public readonly static Field PRICE_POINTS = new Field("PRICE_POINTS", "EVALUATION_RESULT", "报价分");
            /// <summary>
			/// 资格分
			/// </summary>
			public readonly static Field QUALIFICATION_POINTS = new Field("QUALIFICATION_POINTS", "EVALUATION_RESULT", "资格分");
            /// <summary>
			/// 商务分
			/// </summary>
			public readonly static Field BUSINESS_POINTS = new Field("BUSINESS_POINTS", "EVALUATION_RESULT", "商务分");
            /// <summary>
			/// 技术分
			/// </summary>
			public readonly static Field TECHNICAL_POINTS = new Field("TECHNICAL_POINTS", "EVALUATION_RESULT", "技术分");
            /// <summary>
			/// 响应性评审
			/// </summary>
			public readonly static Field RESPONSE_POINTS = new Field("RESPONSE_POINTS", "EVALUATION_RESULT", "响应性评审");
            /// <summary>
			/// 其他分
			/// </summary>
			public readonly static Field OTHER_POINTS = new Field("OTHER_POINTS", "EVALUATION_RESULT", "其他分");
            /// <summary>
			/// 是否否决投标
			/// </summary>
			public readonly static Field IS_VETO = new Field("IS_VETO", "EVALUATION_RESULT", "是否否决投标");
            /// <summary>
			/// 否决投标理由汇总
			/// </summary>
			public readonly static Field VETO_REASON_DETAIL = new Field("VETO_REASON_DETAIL", "EVALUATION_RESULT",DbType.AnsiString, null, "否决投标理由汇总");
            /// <summary>
			/// 评分结果排位
			/// </summary>
			public readonly static Field RANK = new Field("RANK", "EVALUATION_RESULT", "评分结果排位");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "EVALUATION_RESULT", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "EVALUATION_RESULT", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "EVALUATION_RESULT", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "EVALUATION_RESULT", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "EVALUATION_RESULT", "公共服务平台标识码");
        }
        #endregion
	}
}