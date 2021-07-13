using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TRANSFER_ENTE_INFO_PRE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TRANSFER_ENTE_INFO_PRE")]
    [Serializable]
    public partial class TRANSFER_ENTE_INFO_PRE : FwEntity
    {
        #region Model
		private string _SUBJECT_COMPANY_NAME;
		private decimal? _SELL_PERCENT;
		private string _SUBJECT_COMPANY_CODE;
		private string _ZONE;
		private string _INDUSTRY_CODE;
		private string _ECONOMY_TYPE;
		private decimal? _EMPLOYEE_QUANTITY;
		private string _HAS_CONTAIN_GROUND;
		private decimal? _LAST_AUDIT_YEAR;
		private string _LAST_AUDIT_UNIT;
		private decimal? _LAST_AUDIT_ASSET;
		private decimal? _LAST_AUDIT_DEBT;
		private decimal? _LAST_AUDIT_EQUITY;
		private decimal? _LAST_AUDIT_EARNING;
		private decimal? _LAST_AUDIT_PROFIT;
		private decimal? _LAST_AUDIT_NETPROFIT;
		private DateTime? _FINANCE_REPORT_DATE;
		private string _FINANCE_REPORT_TYPE;
		private decimal? _TOTAL_CAPITAL;
		private decimal? _TOTAL_DEBT;
		private decimal? _OWENERSHIP_INTEREST;
		private decimal? _BUSINESS_INCOME;
		private decimal? _BUSINESS_PROFIT;
		private decimal? _NET_PROFIT;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _PROJECT_CODE;
		private decimal? _M_ID;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private decimal? _M_PRE_ID;
		private string _M_UNIFIED_DEAL_CODE;

		/// <summary>
		/// 转让标的企业名称
		/// </summary>
		public string SUBJECT_COMPANY_NAME
		{
			get{ return _SUBJECT_COMPANY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SUBJECT_COMPANY_NAME, _SUBJECT_COMPANY_NAME, value);
				this._SUBJECT_COMPANY_NAME = value;
			}
		}
		/// <summary>
		/// 本次拟转让产（股）权比例（%）
		/// </summary>
		public decimal? SELL_PERCENT
		{
			get{ return _SELL_PERCENT; }
			set
			{
				this.OnPropertyValueChange(_.SELL_PERCENT, _SELL_PERCENT, value);
				this._SELL_PERCENT = value;
			}
		}
		/// <summary>
		/// 标的企业社会信用代码/组织机构代码
		/// </summary>
		public string SUBJECT_COMPANY_CODE
		{
			get{ return _SUBJECT_COMPANY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SUBJECT_COMPANY_CODE, _SUBJECT_COMPANY_CODE, value);
				this._SUBJECT_COMPANY_CODE = value;
			}
		}
		/// <summary>
		/// 转让标的企业所在地区
		/// </summary>
		public string ZONE
		{
			get{ return _ZONE; }
			set
			{
				this.OnPropertyValueChange(_.ZONE, _ZONE, value);
				this._ZONE = value;
			}
		}
		/// <summary>
		/// 转让标的企业所属行业码
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
		/// 转让标的企业经济类型
		/// </summary>
		public string ECONOMY_TYPE
		{
			get{ return _ECONOMY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.ECONOMY_TYPE, _ECONOMY_TYPE, value);
				this._ECONOMY_TYPE = value;
			}
		}
		/// <summary>
		/// 转让标的企业职工人数
		/// </summary>
		public decimal? EMPLOYEE_QUANTITY
		{
			get{ return _EMPLOYEE_QUANTITY; }
			set
			{
				this.OnPropertyValueChange(_.EMPLOYEE_QUANTITY, _EMPLOYEE_QUANTITY, value);
				this._EMPLOYEE_QUANTITY = value;
			}
		}
		/// <summary>
		/// 转让标的企业是否含有国有划拨土地
		/// </summary>
		public string HAS_CONTAIN_GROUND
		{
			get{ return _HAS_CONTAIN_GROUND; }
			set
			{
				this.OnPropertyValueChange(_.HAS_CONTAIN_GROUND, _HAS_CONTAIN_GROUND, value);
				this._HAS_CONTAIN_GROUND = value;
			}
		}
		/// <summary>
		/// 审计年度（上年度）
		/// </summary>
		public decimal? LAST_AUDIT_YEAR
		{
			get{ return _LAST_AUDIT_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.LAST_AUDIT_YEAR, _LAST_AUDIT_YEAR, value);
				this._LAST_AUDIT_YEAR = value;
			}
		}
		/// <summary>
		/// 审计机构（上年度）
		/// </summary>
		public string LAST_AUDIT_UNIT
		{
			get{ return _LAST_AUDIT_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.LAST_AUDIT_UNIT, _LAST_AUDIT_UNIT, value);
				this._LAST_AUDIT_UNIT = value;
			}
		}
		/// <summary>
		/// 资产总额（上年度）
		/// </summary>
		public decimal? LAST_AUDIT_ASSET
		{
			get{ return _LAST_AUDIT_ASSET; }
			set
			{
				this.OnPropertyValueChange(_.LAST_AUDIT_ASSET, _LAST_AUDIT_ASSET, value);
				this._LAST_AUDIT_ASSET = value;
			}
		}
		/// <summary>
		/// 负债总额（上年度）
		/// </summary>
		public decimal? LAST_AUDIT_DEBT
		{
			get{ return _LAST_AUDIT_DEBT; }
			set
			{
				this.OnPropertyValueChange(_.LAST_AUDIT_DEBT, _LAST_AUDIT_DEBT, value);
				this._LAST_AUDIT_DEBT = value;
			}
		}
		/// <summary>
		/// 净资产（所有者权益）（上年度）
		/// </summary>
		public decimal? LAST_AUDIT_EQUITY
		{
			get{ return _LAST_AUDIT_EQUITY; }
			set
			{
				this.OnPropertyValueChange(_.LAST_AUDIT_EQUITY, _LAST_AUDIT_EQUITY, value);
				this._LAST_AUDIT_EQUITY = value;
			}
		}
		/// <summary>
		/// 营业收入（上年度）
		/// </summary>
		public decimal? LAST_AUDIT_EARNING
		{
			get{ return _LAST_AUDIT_EARNING; }
			set
			{
				this.OnPropertyValueChange(_.LAST_AUDIT_EARNING, _LAST_AUDIT_EARNING, value);
				this._LAST_AUDIT_EARNING = value;
			}
		}
		/// <summary>
		/// 利润总额（上年度）
		/// </summary>
		public decimal? LAST_AUDIT_PROFIT
		{
			get{ return _LAST_AUDIT_PROFIT; }
			set
			{
				this.OnPropertyValueChange(_.LAST_AUDIT_PROFIT, _LAST_AUDIT_PROFIT, value);
				this._LAST_AUDIT_PROFIT = value;
			}
		}
		/// <summary>
		/// 净利润（上年度）
		/// </summary>
		public decimal? LAST_AUDIT_NETPROFIT
		{
			get{ return _LAST_AUDIT_NETPROFIT; }
			set
			{
				this.OnPropertyValueChange(_.LAST_AUDIT_NETPROFIT, _LAST_AUDIT_NETPROFIT, value);
				this._LAST_AUDIT_NETPROFIT = value;
			}
		}
		/// <summary>
		/// 报表日期
		/// </summary>
		public DateTime? FINANCE_REPORT_DATE
		{
			get{ return _FINANCE_REPORT_DATE; }
			set
			{
				this.OnPropertyValueChange(_.FINANCE_REPORT_DATE, _FINANCE_REPORT_DATE, value);
				this._FINANCE_REPORT_DATE = value;
			}
		}
		/// <summary>
		/// 报表类型
		/// </summary>
		public string FINANCE_REPORT_TYPE
		{
			get{ return _FINANCE_REPORT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.FINANCE_REPORT_TYPE, _FINANCE_REPORT_TYPE, value);
				this._FINANCE_REPORT_TYPE = value;
			}
		}
		/// <summary>
		/// 资产总额
		/// </summary>
		public decimal? TOTAL_CAPITAL
		{
			get{ return _TOTAL_CAPITAL; }
			set
			{
				this.OnPropertyValueChange(_.TOTAL_CAPITAL, _TOTAL_CAPITAL, value);
				this._TOTAL_CAPITAL = value;
			}
		}
		/// <summary>
		/// 负债总额
		/// </summary>
		public decimal? TOTAL_DEBT
		{
			get{ return _TOTAL_DEBT; }
			set
			{
				this.OnPropertyValueChange(_.TOTAL_DEBT, _TOTAL_DEBT, value);
				this._TOTAL_DEBT = value;
			}
		}
		/// <summary>
		/// 净资产（所有者权益）
		/// </summary>
		public decimal? OWENERSHIP_INTEREST
		{
			get{ return _OWENERSHIP_INTEREST; }
			set
			{
				this.OnPropertyValueChange(_.OWENERSHIP_INTEREST, _OWENERSHIP_INTEREST, value);
				this._OWENERSHIP_INTEREST = value;
			}
		}
		/// <summary>
		/// 营业收入
		/// </summary>
		public decimal? BUSINESS_INCOME
		{
			get{ return _BUSINESS_INCOME; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESS_INCOME, _BUSINESS_INCOME, value);
				this._BUSINESS_INCOME = value;
			}
		}
		/// <summary>
		/// 利润总额
		/// </summary>
		public decimal? BUSINESS_PROFIT
		{
			get{ return _BUSINESS_PROFIT; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESS_PROFIT, _BUSINESS_PROFIT, value);
				this._BUSINESS_PROFIT = value;
			}
		}
		/// <summary>
		/// 净利润
		/// </summary>
		public decimal? NET_PROFIT
		{
			get{ return _NET_PROFIT; }
			set
			{
				this.OnPropertyValueChange(_.NET_PROFIT, _NET_PROFIT, value);
				this._NET_PROFIT = value;
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
		/// 监督预披露ID
		/// </summary>
		public decimal? M_PRE_ID
		{
			get{ return _M_PRE_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_PRE_ID, _M_PRE_ID, value);
				this._M_PRE_ID = value;
			}
		}
		/// <summary>
		/// 统一交易标识码
		/// </summary>
		public string M_UNIFIED_DEAL_CODE
		{
			get{ return _M_UNIFIED_DEAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.M_UNIFIED_DEAL_CODE, _M_UNIFIED_DEAL_CODE, value);
				this._M_UNIFIED_DEAL_CODE = value;
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
				_.SUBJECT_COMPANY_NAME,
				_.SELL_PERCENT,
				_.SUBJECT_COMPANY_CODE,
				_.ZONE,
				_.INDUSTRY_CODE,
				_.ECONOMY_TYPE,
				_.EMPLOYEE_QUANTITY,
				_.HAS_CONTAIN_GROUND,
				_.LAST_AUDIT_YEAR,
				_.LAST_AUDIT_UNIT,
				_.LAST_AUDIT_ASSET,
				_.LAST_AUDIT_DEBT,
				_.LAST_AUDIT_EQUITY,
				_.LAST_AUDIT_EARNING,
				_.LAST_AUDIT_PROFIT,
				_.LAST_AUDIT_NETPROFIT,
				_.FINANCE_REPORT_DATE,
				_.FINANCE_REPORT_TYPE,
				_.TOTAL_CAPITAL,
				_.TOTAL_DEBT,
				_.OWENERSHIP_INTEREST,
				_.BUSINESS_INCOME,
				_.BUSINESS_PROFIT,
				_.NET_PROFIT,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.PROJECT_CODE,
				_.M_ID,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_PRE_ID,
				_.M_UNIFIED_DEAL_CODE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._SUBJECT_COMPANY_NAME,
				this._SELL_PERCENT,
				this._SUBJECT_COMPANY_CODE,
				this._ZONE,
				this._INDUSTRY_CODE,
				this._ECONOMY_TYPE,
				this._EMPLOYEE_QUANTITY,
				this._HAS_CONTAIN_GROUND,
				this._LAST_AUDIT_YEAR,
				this._LAST_AUDIT_UNIT,
				this._LAST_AUDIT_ASSET,
				this._LAST_AUDIT_DEBT,
				this._LAST_AUDIT_EQUITY,
				this._LAST_AUDIT_EARNING,
				this._LAST_AUDIT_PROFIT,
				this._LAST_AUDIT_NETPROFIT,
				this._FINANCE_REPORT_DATE,
				this._FINANCE_REPORT_TYPE,
				this._TOTAL_CAPITAL,
				this._TOTAL_DEBT,
				this._OWENERSHIP_INTEREST,
				this._BUSINESS_INCOME,
				this._BUSINESS_PROFIT,
				this._NET_PROFIT,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._PROJECT_CODE,
				this._M_ID,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_PRE_ID,
				this._M_UNIFIED_DEAL_CODE,
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
			public readonly static Field All = new Field("*", "TRANSFER_ENTE_INFO_PRE");
            /// <summary>
			/// 转让标的企业名称
			/// </summary>
			public readonly static Field SUBJECT_COMPANY_NAME = new Field("SUBJECT_COMPANY_NAME", "TRANSFER_ENTE_INFO_PRE", "转让标的企业名称");
            /// <summary>
			/// 本次拟转让产（股）权比例（%）
			/// </summary>
			public readonly static Field SELL_PERCENT = new Field("SELL_PERCENT", "TRANSFER_ENTE_INFO_PRE", "本次拟转让产（股）权比例（%）");
            /// <summary>
			/// 标的企业社会信用代码/组织机构代码
			/// </summary>
			public readonly static Field SUBJECT_COMPANY_CODE = new Field("SUBJECT_COMPANY_CODE", "TRANSFER_ENTE_INFO_PRE", "标的企业社会信用代码/组织机构代码");
            /// <summary>
			/// 转让标的企业所在地区
			/// </summary>
			public readonly static Field ZONE = new Field("ZONE", "TRANSFER_ENTE_INFO_PRE", "转让标的企业所在地区");
            /// <summary>
			/// 转让标的企业所属行业码
			/// </summary>
			public readonly static Field INDUSTRY_CODE = new Field("INDUSTRY_CODE", "TRANSFER_ENTE_INFO_PRE", "转让标的企业所属行业码");
            /// <summary>
			/// 转让标的企业经济类型
			/// </summary>
			public readonly static Field ECONOMY_TYPE = new Field("ECONOMY_TYPE", "TRANSFER_ENTE_INFO_PRE", "转让标的企业经济类型");
            /// <summary>
			/// 转让标的企业职工人数
			/// </summary>
			public readonly static Field EMPLOYEE_QUANTITY = new Field("EMPLOYEE_QUANTITY", "TRANSFER_ENTE_INFO_PRE", "转让标的企业职工人数");
            /// <summary>
			/// 转让标的企业是否含有国有划拨土地
			/// </summary>
			public readonly static Field HAS_CONTAIN_GROUND = new Field("HAS_CONTAIN_GROUND", "TRANSFER_ENTE_INFO_PRE", "转让标的企业是否含有国有划拨土地");
            /// <summary>
			/// 审计年度（上年度）
			/// </summary>
			public readonly static Field LAST_AUDIT_YEAR = new Field("LAST_AUDIT_YEAR", "TRANSFER_ENTE_INFO_PRE", "审计年度（上年度）");
            /// <summary>
			/// 审计机构（上年度）
			/// </summary>
			public readonly static Field LAST_AUDIT_UNIT = new Field("LAST_AUDIT_UNIT", "TRANSFER_ENTE_INFO_PRE", "审计机构（上年度）");
            /// <summary>
			/// 资产总额（上年度）
			/// </summary>
			public readonly static Field LAST_AUDIT_ASSET = new Field("LAST_AUDIT_ASSET", "TRANSFER_ENTE_INFO_PRE", "资产总额（上年度）");
            /// <summary>
			/// 负债总额（上年度）
			/// </summary>
			public readonly static Field LAST_AUDIT_DEBT = new Field("LAST_AUDIT_DEBT", "TRANSFER_ENTE_INFO_PRE", "负债总额（上年度）");
            /// <summary>
			/// 净资产（所有者权益）（上年度）
			/// </summary>
			public readonly static Field LAST_AUDIT_EQUITY = new Field("LAST_AUDIT_EQUITY", "TRANSFER_ENTE_INFO_PRE", "净资产（所有者权益）（上年度）");
            /// <summary>
			/// 营业收入（上年度）
			/// </summary>
			public readonly static Field LAST_AUDIT_EARNING = new Field("LAST_AUDIT_EARNING", "TRANSFER_ENTE_INFO_PRE", "营业收入（上年度）");
            /// <summary>
			/// 利润总额（上年度）
			/// </summary>
			public readonly static Field LAST_AUDIT_PROFIT = new Field("LAST_AUDIT_PROFIT", "TRANSFER_ENTE_INFO_PRE", "利润总额（上年度）");
            /// <summary>
			/// 净利润（上年度）
			/// </summary>
			public readonly static Field LAST_AUDIT_NETPROFIT = new Field("LAST_AUDIT_NETPROFIT", "TRANSFER_ENTE_INFO_PRE", "净利润（上年度）");
            /// <summary>
			/// 报表日期
			/// </summary>
			public readonly static Field FINANCE_REPORT_DATE = new Field("FINANCE_REPORT_DATE", "TRANSFER_ENTE_INFO_PRE", "报表日期");
            /// <summary>
			/// 报表类型
			/// </summary>
			public readonly static Field FINANCE_REPORT_TYPE = new Field("FINANCE_REPORT_TYPE", "TRANSFER_ENTE_INFO_PRE", "报表类型");
            /// <summary>
			/// 资产总额
			/// </summary>
			public readonly static Field TOTAL_CAPITAL = new Field("TOTAL_CAPITAL", "TRANSFER_ENTE_INFO_PRE", "资产总额");
            /// <summary>
			/// 负债总额
			/// </summary>
			public readonly static Field TOTAL_DEBT = new Field("TOTAL_DEBT", "TRANSFER_ENTE_INFO_PRE", "负债总额");
            /// <summary>
			/// 净资产（所有者权益）
			/// </summary>
			public readonly static Field OWENERSHIP_INTEREST = new Field("OWENERSHIP_INTEREST", "TRANSFER_ENTE_INFO_PRE", "净资产（所有者权益）");
            /// <summary>
			/// 营业收入
			/// </summary>
			public readonly static Field BUSINESS_INCOME = new Field("BUSINESS_INCOME", "TRANSFER_ENTE_INFO_PRE", "营业收入");
            /// <summary>
			/// 利润总额
			/// </summary>
			public readonly static Field BUSINESS_PROFIT = new Field("BUSINESS_PROFIT", "TRANSFER_ENTE_INFO_PRE", "利润总额");
            /// <summary>
			/// 净利润
			/// </summary>
			public readonly static Field NET_PROFIT = new Field("NET_PROFIT", "TRANSFER_ENTE_INFO_PRE", "净利润");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "TRANSFER_ENTE_INFO_PRE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "TRANSFER_ENTE_INFO_PRE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "TRANSFER_ENTE_INFO_PRE", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "TRANSFER_ENTE_INFO_PRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "TRANSFER_ENTE_INFO_PRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "TRANSFER_ENTE_INFO_PRE", "");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "TRANSFER_ENTE_INFO_PRE", "项目编号");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "TRANSFER_ENTE_INFO_PRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "TRANSFER_ENTE_INFO_PRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "TRANSFER_ENTE_INFO_PRE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "TRANSFER_ENTE_INFO_PRE", "");
            /// <summary>
			/// 监督预披露ID
			/// </summary>
			public readonly static Field M_PRE_ID = new Field("M_PRE_ID", "TRANSFER_ENTE_INFO_PRE", "监督预披露ID");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field M_UNIFIED_DEAL_CODE = new Field("M_UNIFIED_DEAL_CODE", "TRANSFER_ENTE_INFO_PRE", "统一交易标识码");
        }
        #endregion
	}
}