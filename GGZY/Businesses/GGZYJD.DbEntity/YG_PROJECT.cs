using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类YG_PROJECT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("YG_PROJECT")]
    [Serializable]
    public partial class YG_PROJECT : JdEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_VERSION;
		private string _PROJECT_CODE;
		private string _PROJECT_NAME;
		private string _REGION_CODE;
		private string _RELATE_CODE;
		private string _INVEST_PROJECT_CODE;
		private string _ADDRESS;
		private string _LEGAL_PERSON;
		private string _CLASS_VER_CODE;
		private string _INDUSTRIES_TYPE;
		private string _FUND_SOURCE;
		private string _CONTRIBUTION_SCALE;
		private string _PROJECT_SCALE;
		private string _CONTACTOR;
		private string _CONTACT_INFORMATION;
		private string _APPROVAL_NAME;
		private string _APPROVAL_NUMBER;
		private string _APPROVAL_AUTHORITY;
		private DateTime? _CREATE_TIME;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _OPERATION_NAME;

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
		/// 项目编号
		/// </summary>
		public string PROJECT_CODE
		{
			get{ return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string PROJECT_NAME
		{
			get{ return _PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_NAME, _PROJECT_NAME, value);
				this._PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 项目所在行政区域代码
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
		/// 项目类别关联代码
		/// </summary>
		public string RELATE_CODE
		{
			get{ return _RELATE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.RELATE_CODE, _RELATE_CODE, value);
				this._RELATE_CODE = value;
			}
		}
		/// <summary>
		/// 投资项目统一代码
		/// </summary>
		public string INVEST_PROJECT_CODE
		{
			get{ return _INVEST_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.INVEST_PROJECT_CODE, _INVEST_PROJECT_CODE, value);
				this._INVEST_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 项目地址
		/// </summary>
		public string ADDRESS
		{
			get{ return _ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.ADDRESS, _ADDRESS, value);
				this._ADDRESS = value;
			}
		}
		/// <summary>
		/// 项目法人
		/// </summary>
		public string LEGAL_PERSON
		{
			get{ return _LEGAL_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_PERSON, _LEGAL_PERSON, value);
				this._LEGAL_PERSON = value;
			}
		}
		/// <summary>
		/// 分类版本代码
		/// </summary>
		public string CLASS_VER_CODE
		{
			get{ return _CLASS_VER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CLASS_VER_CODE, _CLASS_VER_CODE, value);
				this._CLASS_VER_CODE = value;
			}
		}
		/// <summary>
		/// 项目行业分类
		/// </summary>
		public string INDUSTRIES_TYPE
		{
			get{ return _INDUSTRIES_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.INDUSTRIES_TYPE, _INDUSTRIES_TYPE, value);
				this._INDUSTRIES_TYPE = value;
			}
		}
		/// <summary>
		/// 资金来源
		/// </summary>
		public string FUND_SOURCE
		{
			get{ return _FUND_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.FUND_SOURCE, _FUND_SOURCE, value);
				this._FUND_SOURCE = value;
			}
		}
		/// <summary>
		/// 出资比例
		/// </summary>
		public string CONTRIBUTION_SCALE
		{
			get{ return _CONTRIBUTION_SCALE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRIBUTION_SCALE, _CONTRIBUTION_SCALE, value);
				this._CONTRIBUTION_SCALE = value;
			}
		}
		/// <summary>
		/// 项目规模
		/// </summary>
		public string PROJECT_SCALE
		{
			get{ return _PROJECT_SCALE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_SCALE, _PROJECT_SCALE, value);
				this._PROJECT_SCALE = value;
			}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string CONTACTOR
		{
			get{ return _CONTACTOR; }
			set
			{
				this.OnPropertyValueChange(_.CONTACTOR, _CONTACTOR, value);
				this._CONTACTOR = value;
			}
		}
		/// <summary>
		/// 联系方式
		/// </summary>
		public string CONTACT_INFORMATION
		{
			get{ return _CONTACT_INFORMATION; }
			set
			{
				this.OnPropertyValueChange(_.CONTACT_INFORMATION, _CONTACT_INFORMATION, value);
				this._CONTACT_INFORMATION = value;
			}
		}
		/// <summary>
		/// 项目审批文件名称
		/// </summary>
		public string APPROVAL_NAME
		{
			get{ return _APPROVAL_NAME; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_NAME, _APPROVAL_NAME, value);
				this._APPROVAL_NAME = value;
			}
		}
		/// <summary>
		/// 项目审批文号
		/// </summary>
		public string APPROVAL_NUMBER
		{
			get{ return _APPROVAL_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_NUMBER, _APPROVAL_NUMBER, value);
				this._APPROVAL_NUMBER = value;
			}
		}
		/// <summary>
		/// 项目审批单位
		/// </summary>
		public string APPROVAL_AUTHORITY
		{
			get{ return _APPROVAL_AUTHORITY; }
			set
			{
				this.OnPropertyValueChange(_.APPROVAL_AUTHORITY, _APPROVAL_AUTHORITY, value);
				this._APPROVAL_AUTHORITY = value;
			}
		}
		/// <summary>
		/// 项目建立时间
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
		/// 信息录入人员
		/// </summary>
		public string OPERATION_NAME
		{
			get{ return _OPERATION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.OPERATION_NAME, _OPERATION_NAME, value);
				this._OPERATION_NAME = value;
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
				_.PROJECT_CODE,
				_.PROJECT_NAME,
				_.REGION_CODE,
				_.RELATE_CODE,
				_.INVEST_PROJECT_CODE,
				_.ADDRESS,
				_.LEGAL_PERSON,
				_.CLASS_VER_CODE,
				_.INDUSTRIES_TYPE,
				_.FUND_SOURCE,
				_.CONTRIBUTION_SCALE,
				_.PROJECT_SCALE,
				_.CONTACTOR,
				_.CONTACT_INFORMATION,
				_.APPROVAL_NAME,
				_.APPROVAL_NUMBER,
				_.APPROVAL_AUTHORITY,
				_.CREATE_TIME,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.OPERATION_NAME,
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
				this._PROJECT_CODE,
				this._PROJECT_NAME,
				this._REGION_CODE,
				this._RELATE_CODE,
				this._INVEST_PROJECT_CODE,
				this._ADDRESS,
				this._LEGAL_PERSON,
				this._CLASS_VER_CODE,
				this._INDUSTRIES_TYPE,
				this._FUND_SOURCE,
				this._CONTRIBUTION_SCALE,
				this._PROJECT_SCALE,
				this._CONTACTOR,
				this._CONTACT_INFORMATION,
				this._APPROVAL_NAME,
				this._APPROVAL_NUMBER,
				this._APPROVAL_AUTHORITY,
				this._CREATE_TIME,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._OPERATION_NAME,
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
			public readonly static Field All = new Field("*", "YG_PROJECT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "YG_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "YG_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "YG_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "YG_PROJECT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "YG_PROJECT", "");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "YG_PROJECT", "项目编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "YG_PROJECT", "项目名称");
            /// <summary>
			/// 项目所在行政区域代码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "YG_PROJECT", "项目所在行政区域代码");
            /// <summary>
			/// 项目类别关联代码
			/// </summary>
			public readonly static Field RELATE_CODE = new Field("RELATE_CODE", "YG_PROJECT", "项目类别关联代码");
            /// <summary>
			/// 投资项目统一代码
			/// </summary>
			public readonly static Field INVEST_PROJECT_CODE = new Field("INVEST_PROJECT_CODE", "YG_PROJECT", "投资项目统一代码");
            /// <summary>
			/// 项目地址
			/// </summary>
			public readonly static Field ADDRESS = new Field("ADDRESS", "YG_PROJECT", "项目地址");
            /// <summary>
			/// 项目法人
			/// </summary>
			public readonly static Field LEGAL_PERSON = new Field("LEGAL_PERSON", "YG_PROJECT", "项目法人");
            /// <summary>
			/// 分类版本代码
			/// </summary>
			public readonly static Field CLASS_VER_CODE = new Field("CLASS_VER_CODE", "YG_PROJECT", "分类版本代码");
            /// <summary>
			/// 项目行业分类
			/// </summary>
			public readonly static Field INDUSTRIES_TYPE = new Field("INDUSTRIES_TYPE", "YG_PROJECT", "项目行业分类");
            /// <summary>
			/// 资金来源
			/// </summary>
			public readonly static Field FUND_SOURCE = new Field("FUND_SOURCE", "YG_PROJECT", "资金来源");
            /// <summary>
			/// 出资比例
			/// </summary>
			public readonly static Field CONTRIBUTION_SCALE = new Field("CONTRIBUTION_SCALE", "YG_PROJECT", "出资比例");
            /// <summary>
			/// 项目规模
			/// </summary>
			public readonly static Field PROJECT_SCALE = new Field("PROJECT_SCALE", "YG_PROJECT", "项目规模");
            /// <summary>
			/// 联系人
			/// </summary>
			public readonly static Field CONTACTOR = new Field("CONTACTOR", "YG_PROJECT", "联系人");
            /// <summary>
			/// 联系方式
			/// </summary>
			public readonly static Field CONTACT_INFORMATION = new Field("CONTACT_INFORMATION", "YG_PROJECT", "联系方式");
            /// <summary>
			/// 项目审批文件名称
			/// </summary>
			public readonly static Field APPROVAL_NAME = new Field("APPROVAL_NAME", "YG_PROJECT", "项目审批文件名称");
            /// <summary>
			/// 项目审批文号
			/// </summary>
			public readonly static Field APPROVAL_NUMBER = new Field("APPROVAL_NUMBER", "YG_PROJECT", "项目审批文号");
            /// <summary>
			/// 项目审批单位
			/// </summary>
			public readonly static Field APPROVAL_AUTHORITY = new Field("APPROVAL_AUTHORITY", "YG_PROJECT", "项目审批单位");
            /// <summary>
			/// 项目建立时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "YG_PROJECT", "项目建立时间");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "YG_PROJECT", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "YG_PROJECT", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "YG_PROJECT", "数据时间戳");
            /// <summary>
			/// 电子招标投标交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "YG_PROJECT", "电子招标投标交易平台或发布工具标识码");
            /// <summary>
			/// 电子招标投标公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "YG_PROJECT", "电子招标投标公共服务平台标识码");
            /// <summary>
			/// 信息录入人员
			/// </summary>
			public readonly static Field OPERATION_NAME = new Field("OPERATION_NAME", "YG_PROJECT", "信息录入人员");
        }
        #endregion
	}
}