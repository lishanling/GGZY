using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JT_TEST_TENDER_FILE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JT_TEST_TENDER_FILE")]
    [Serializable]
    public partial class JT_TEST_TENDER_FILE : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private string _ADDRESS1;
		private string _ADDRESS2;
		private string _PROJECT_PROFILE;
		private decimal? _LIMITE_ALL_TIME;
		private decimal? _CONTRACT_SECTION;
		private string _PROJECT_PART;
		private decimal? _SERVICE_TIME;
		private decimal? _CONTRACT_SEGMENT;
		private decimal? _TENDER_NUMBER;
		private string _MEDIA1;
		private string _MEDIA2;
		private string _MINIMUM_QUALIFICATIONS;
		private string _ACHIEVEMENT_REQUIRE;
		private string _REPUTATION_REQUIRE;
		private string _MARGIN_NAME;
		private string _MARGIN_NUMBER;
		private string _MARGIN_BANK;
		private string _SUPERVISE_DEPT_NAME;
		private string _SUPERVISE_DEPT_TELE;
		private string _SUPERVISE_DEPT_ADDRESS;
		private decimal? _ALL_EXPERT_NUM;
		private decimal? _TENDERER_NUM;
		private decimal? _EXPERT_NUM;
		private string _FINANCIAL_REQUIRE_YEAR;
		private string _LITIGATION_REQUIRED_YEAR;
		private string _DRAWING;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_TM;
		private DateTime? _DATA_TIMESTAMP;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;

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
		/// 相关标段（包）编号
		/// </summary>
		public string BID_SECTION_CODES
		{
			get{ return _BID_SECTION_CODES; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODES, _BID_SECTION_CODES, value);
				this._BID_SECTION_CODES = value;
			}
		}
		/// <summary>
		/// 高速公路起点
		/// </summary>
		public string ADDRESS1
		{
			get{ return _ADDRESS1; }
			set
			{
				this.OnPropertyValueChange(_.ADDRESS1, _ADDRESS1, value);
				this._ADDRESS1 = value;
			}
		}
		/// <summary>
		/// 高速公路终点
		/// </summary>
		public string ADDRESS2
		{
			get{ return _ADDRESS2; }
			set
			{
				this.OnPropertyValueChange(_.ADDRESS2, _ADDRESS2, value);
				this._ADDRESS2 = value;
			}
		}
		/// <summary>
		/// 项目概况
		/// </summary>
		public string PROJECT_PROFILE
		{
			get{ return _PROJECT_PROFILE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_PROFILE, _PROJECT_PROFILE, value);
				this._PROJECT_PROFILE = value;
			}
		}
		/// <summary>
		/// 项目总工期
		/// </summary>
		public decimal? LIMITE_ALL_TIME
		{
			get{ return _LIMITE_ALL_TIME; }
			set
			{
				this.OnPropertyValueChange(_.LIMITE_ALL_TIME, _LIMITE_ALL_TIME, value);
				this._LIMITE_ALL_TIME = value;
			}
		}
		/// <summary>
		/// 合同段数量
		/// </summary>
		public decimal? CONTRACT_SECTION
		{
			get{ return _CONTRACT_SECTION; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_SECTION, _CONTRACT_SECTION, value);
				this._CONTRACT_SECTION = value;
			}
		}
		/// <summary>
		/// 管辖工程
		/// </summary>
		public string PROJECT_PART
		{
			get{ return _PROJECT_PART; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_PART, _PROJECT_PART, value);
				this._PROJECT_PART = value;
			}
		}
		/// <summary>
		/// 试验检测服务期字开工之日起始日期
		/// </summary>
		public decimal? SERVICE_TIME
		{
			get{ return _SERVICE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SERVICE_TIME, _SERVICE_TIME, value);
				this._SERVICE_TIME = value;
			}
		}
		/// <summary>
		/// 投标人可投合同段数量
		/// </summary>
		public decimal? CONTRACT_SEGMENT
		{
			get{ return _CONTRACT_SEGMENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_SEGMENT, _CONTRACT_SEGMENT, value);
				this._CONTRACT_SEGMENT = value;
			}
		}
		/// <summary>
		/// 投标人最多可中合同段数量
		/// </summary>
		public decimal? TENDER_NUMBER
		{
			get{ return _TENDER_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_NUMBER, _TENDER_NUMBER, value);
				this._TENDER_NUMBER = value;
			}
		}
		/// <summary>
		/// 其他发布媒体1
		/// </summary>
		public string MEDIA1
		{
			get{ return _MEDIA1; }
			set
			{
				this.OnPropertyValueChange(_.MEDIA1, _MEDIA1, value);
				this._MEDIA1 = value;
			}
		}
		/// <summary>
		/// 其他发布媒体2
		/// </summary>
		public string MEDIA2
		{
			get{ return _MEDIA2; }
			set
			{
				this.OnPropertyValueChange(_.MEDIA2, _MEDIA2, value);
				this._MEDIA2 = value;
			}
		}
		/// <summary>
		/// 资格审查要求
		/// </summary>
		public string MINIMUM_QUALIFICATIONS
		{
			get{ return _MINIMUM_QUALIFICATIONS; }
			set
			{
				this.OnPropertyValueChange(_.MINIMUM_QUALIFICATIONS, _MINIMUM_QUALIFICATIONS, value);
				this._MINIMUM_QUALIFICATIONS = value;
			}
		}
		/// <summary>
		/// 业绩要求
		/// </summary>
		public string ACHIEVEMENT_REQUIRE
		{
			get{ return _ACHIEVEMENT_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.ACHIEVEMENT_REQUIRE, _ACHIEVEMENT_REQUIRE, value);
				this._ACHIEVEMENT_REQUIRE = value;
			}
		}
		/// <summary>
		/// 信誉要求
		/// </summary>
		public string REPUTATION_REQUIRE
		{
			get{ return _REPUTATION_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.REPUTATION_REQUIRE, _REPUTATION_REQUIRE, value);
				this._REPUTATION_REQUIRE = value;
			}
		}
		/// <summary>
		/// 招标人账户
		/// </summary>
		public string MARGIN_NAME
		{
			get{ return _MARGIN_NAME; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_NAME, _MARGIN_NAME, value);
				this._MARGIN_NAME = value;
			}
		}
		/// <summary>
		/// 招标人账号
		/// </summary>
		public string MARGIN_NUMBER
		{
			get{ return _MARGIN_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_NUMBER, _MARGIN_NUMBER, value);
				this._MARGIN_NUMBER = value;
			}
		}
		/// <summary>
		/// 招标人开户行
		/// </summary>
		public string MARGIN_BANK
		{
			get{ return _MARGIN_BANK; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_BANK, _MARGIN_BANK, value);
				this._MARGIN_BANK = value;
			}
		}
		/// <summary>
		/// 监督部门名称
		/// </summary>
		public string SUPERVISE_DEPT_NAME
		{
			get{ return _SUPERVISE_DEPT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_NAME, _SUPERVISE_DEPT_NAME, value);
				this._SUPERVISE_DEPT_NAME = value;
			}
		}
		/// <summary>
		/// 监督部门联系电话
		/// </summary>
		public string SUPERVISE_DEPT_TELE
		{
			get{ return _SUPERVISE_DEPT_TELE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_TELE, _SUPERVISE_DEPT_TELE, value);
				this._SUPERVISE_DEPT_TELE = value;
			}
		}
		/// <summary>
		/// 监督部门地址
		/// </summary>
		public string SUPERVISE_DEPT_ADDRESS
		{
			get{ return _SUPERVISE_DEPT_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_ADDRESS, _SUPERVISE_DEPT_ADDRESS, value);
				this._SUPERVISE_DEPT_ADDRESS = value;
			}
		}
		/// <summary>
		/// 评标委员会人数
		/// </summary>
		public decimal? ALL_EXPERT_NUM
		{
			get{ return _ALL_EXPERT_NUM; }
			set
			{
				this.OnPropertyValueChange(_.ALL_EXPERT_NUM, _ALL_EXPERT_NUM, value);
				this._ALL_EXPERT_NUM = value;
			}
		}
		/// <summary>
		/// 招标人代表人数
		/// </summary>
		public decimal? TENDERER_NUM
		{
			get{ return _TENDERER_NUM; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_NUM, _TENDERER_NUM, value);
				this._TENDERER_NUM = value;
			}
		}
		/// <summary>
		/// 专家人数
		/// </summary>
		public decimal? EXPERT_NUM
		{
			get{ return _EXPERT_NUM; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_NUM, _EXPERT_NUM, value);
				this._EXPERT_NUM = value;
			}
		}
		/// <summary>
		/// 完成的类似项目年份要求
		/// </summary>
		public string FINANCIAL_REQUIRE_YEAR
		{
			get{ return _FINANCIAL_REQUIRE_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.FINANCIAL_REQUIRE_YEAR, _FINANCIAL_REQUIRE_YEAR, value);
				this._FINANCIAL_REQUIRE_YEAR = value;
			}
		}
		/// <summary>
		/// 发生的诉讼及仲裁情况
		/// </summary>
		public string LITIGATION_REQUIRED_YEAR
		{
			get{ return _LITIGATION_REQUIRED_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.LITIGATION_REQUIRED_YEAR, _LITIGATION_REQUIRED_YEAR, value);
				this._LITIGATION_REQUIRED_YEAR = value;
			}
		}
		/// <summary>
		/// 图纸
		/// </summary>
		public string DRAWING
		{
			get{ return _DRAWING; }
			set
			{
				this.OnPropertyValueChange(_.DRAWING, _DRAWING, value);
				this._DRAWING = value;
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
		/// 数据自增长ID
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
		/// 数据DATA_KEY
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
		/// 数据来源
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
		/// M_CREATEBY
		/// </summary>
		public string M_CREATEBY
		{
			get{ return _M_CREATEBY; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATEBY, _M_CREATEBY, value);
				this._M_CREATEBY = value;
			}
		}
		/// <summary>
		/// M_CREATE_TM
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
		/// M_TM
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
				_.BID_SECTION_CODES,
				_.ADDRESS1,
				_.ADDRESS2,
				_.PROJECT_PROFILE,
				_.LIMITE_ALL_TIME,
				_.CONTRACT_SECTION,
				_.PROJECT_PART,
				_.SERVICE_TIME,
				_.CONTRACT_SEGMENT,
				_.TENDER_NUMBER,
				_.MEDIA1,
				_.MEDIA2,
				_.MINIMUM_QUALIFICATIONS,
				_.ACHIEVEMENT_REQUIRE,
				_.REPUTATION_REQUIRE,
				_.MARGIN_NAME,
				_.MARGIN_NUMBER,
				_.MARGIN_BANK,
				_.SUPERVISE_DEPT_NAME,
				_.SUPERVISE_DEPT_TELE,
				_.SUPERVISE_DEPT_ADDRESS,
				_.ALL_EXPERT_NUM,
				_.TENDERER_NUM,
				_.EXPERT_NUM,
				_.FINANCIAL_REQUIRE_YEAR,
				_.LITIGATION_REQUIRED_YEAR,
				_.DRAWING,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_TM,
				_.DATA_TIMESTAMP,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TENDER_PROJECT_CODE,
				this._BID_SECTION_CODES,
				this._ADDRESS1,
				this._ADDRESS2,
				this._PROJECT_PROFILE,
				this._LIMITE_ALL_TIME,
				this._CONTRACT_SECTION,
				this._PROJECT_PART,
				this._SERVICE_TIME,
				this._CONTRACT_SEGMENT,
				this._TENDER_NUMBER,
				this._MEDIA1,
				this._MEDIA2,
				this._MINIMUM_QUALIFICATIONS,
				this._ACHIEVEMENT_REQUIRE,
				this._REPUTATION_REQUIRE,
				this._MARGIN_NAME,
				this._MARGIN_NUMBER,
				this._MARGIN_BANK,
				this._SUPERVISE_DEPT_NAME,
				this._SUPERVISE_DEPT_TELE,
				this._SUPERVISE_DEPT_ADDRESS,
				this._ALL_EXPERT_NUM,
				this._TENDERER_NUM,
				this._EXPERT_NUM,
				this._FINANCIAL_REQUIRE_YEAR,
				this._LITIGATION_REQUIRED_YEAR,
				this._DRAWING,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_TM,
				this._DATA_TIMESTAMP,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
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
			public readonly static Field All = new Field("*", "JT_TEST_TENDER_FILE");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JT_TEST_TENDER_FILE", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "JT_TEST_TENDER_FILE",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 高速公路起点
			/// </summary>
			public readonly static Field ADDRESS1 = new Field("ADDRESS1", "JT_TEST_TENDER_FILE", "高速公路起点");
            /// <summary>
			/// 高速公路终点
			/// </summary>
			public readonly static Field ADDRESS2 = new Field("ADDRESS2", "JT_TEST_TENDER_FILE", "高速公路终点");
            /// <summary>
			/// 项目概况
			/// </summary>
			public readonly static Field PROJECT_PROFILE = new Field("PROJECT_PROFILE", "JT_TEST_TENDER_FILE",DbType.AnsiString, null, "项目概况");
            /// <summary>
			/// 项目总工期
			/// </summary>
			public readonly static Field LIMITE_ALL_TIME = new Field("LIMITE_ALL_TIME", "JT_TEST_TENDER_FILE", "项目总工期");
            /// <summary>
			/// 合同段数量
			/// </summary>
			public readonly static Field CONTRACT_SECTION = new Field("CONTRACT_SECTION", "JT_TEST_TENDER_FILE", "合同段数量");
            /// <summary>
			/// 管辖工程
			/// </summary>
			public readonly static Field PROJECT_PART = new Field("PROJECT_PART", "JT_TEST_TENDER_FILE", "管辖工程");
            /// <summary>
			/// 试验检测服务期字开工之日起始日期
			/// </summary>
			public readonly static Field SERVICE_TIME = new Field("SERVICE_TIME", "JT_TEST_TENDER_FILE", "试验检测服务期字开工之日起始日期");
            /// <summary>
			/// 投标人可投合同段数量
			/// </summary>
			public readonly static Field CONTRACT_SEGMENT = new Field("CONTRACT_SEGMENT", "JT_TEST_TENDER_FILE", "投标人可投合同段数量");
            /// <summary>
			/// 投标人最多可中合同段数量
			/// </summary>
			public readonly static Field TENDER_NUMBER = new Field("TENDER_NUMBER", "JT_TEST_TENDER_FILE", "投标人最多可中合同段数量");
            /// <summary>
			/// 其他发布媒体1
			/// </summary>
			public readonly static Field MEDIA1 = new Field("MEDIA1", "JT_TEST_TENDER_FILE", "其他发布媒体1");
            /// <summary>
			/// 其他发布媒体2
			/// </summary>
			public readonly static Field MEDIA2 = new Field("MEDIA2", "JT_TEST_TENDER_FILE", "其他发布媒体2");
            /// <summary>
			/// 资格审查要求
			/// </summary>
			public readonly static Field MINIMUM_QUALIFICATIONS = new Field("MINIMUM_QUALIFICATIONS", "JT_TEST_TENDER_FILE",DbType.AnsiString, null, "资格审查要求");
            /// <summary>
			/// 业绩要求
			/// </summary>
			public readonly static Field ACHIEVEMENT_REQUIRE = new Field("ACHIEVEMENT_REQUIRE", "JT_TEST_TENDER_FILE",DbType.AnsiString, null, "业绩要求");
            /// <summary>
			/// 信誉要求
			/// </summary>
			public readonly static Field REPUTATION_REQUIRE = new Field("REPUTATION_REQUIRE", "JT_TEST_TENDER_FILE",DbType.AnsiString, null, "信誉要求");
            /// <summary>
			/// 招标人账户
			/// </summary>
			public readonly static Field MARGIN_NAME = new Field("MARGIN_NAME", "JT_TEST_TENDER_FILE", "招标人账户");
            /// <summary>
			/// 招标人账号
			/// </summary>
			public readonly static Field MARGIN_NUMBER = new Field("MARGIN_NUMBER", "JT_TEST_TENDER_FILE", "招标人账号");
            /// <summary>
			/// 招标人开户行
			/// </summary>
			public readonly static Field MARGIN_BANK = new Field("MARGIN_BANK", "JT_TEST_TENDER_FILE", "招标人开户行");
            /// <summary>
			/// 监督部门名称
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME = new Field("SUPERVISE_DEPT_NAME", "JT_TEST_TENDER_FILE", "监督部门名称");
            /// <summary>
			/// 监督部门联系电话
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_TELE = new Field("SUPERVISE_DEPT_TELE", "JT_TEST_TENDER_FILE", "监督部门联系电话");
            /// <summary>
			/// 监督部门地址
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ADDRESS = new Field("SUPERVISE_DEPT_ADDRESS", "JT_TEST_TENDER_FILE", "监督部门地址");
            /// <summary>
			/// 评标委员会人数
			/// </summary>
			public readonly static Field ALL_EXPERT_NUM = new Field("ALL_EXPERT_NUM", "JT_TEST_TENDER_FILE", "评标委员会人数");
            /// <summary>
			/// 招标人代表人数
			/// </summary>
			public readonly static Field TENDERER_NUM = new Field("TENDERER_NUM", "JT_TEST_TENDER_FILE", "招标人代表人数");
            /// <summary>
			/// 专家人数
			/// </summary>
			public readonly static Field EXPERT_NUM = new Field("EXPERT_NUM", "JT_TEST_TENDER_FILE", "专家人数");
            /// <summary>
			/// 完成的类似项目年份要求
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE_YEAR = new Field("FINANCIAL_REQUIRE_YEAR", "JT_TEST_TENDER_FILE", "完成的类似项目年份要求");
            /// <summary>
			/// 发生的诉讼及仲裁情况
			/// </summary>
			public readonly static Field LITIGATION_REQUIRED_YEAR = new Field("LITIGATION_REQUIRED_YEAR", "JT_TEST_TENDER_FILE", "发生的诉讼及仲裁情况");
            /// <summary>
			/// 图纸
			/// </summary>
			public readonly static Field DRAWING = new Field("DRAWING", "JT_TEST_TENDER_FILE", "图纸");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "JT_TEST_TENDER_FILE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "JT_TEST_TENDER_FILE", "公共服务平台标识码");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "JT_TEST_TENDER_FILE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "JT_TEST_TENDER_FILE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "JT_TEST_TENDER_FILE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "JT_TEST_TENDER_FILE", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "JT_TEST_TENDER_FILE", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "JT_TEST_TENDER_FILE", "M_TM");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JT_TEST_TENDER_FILE", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "JT_TEST_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "JT_TEST_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "JT_TEST_TENDER_FILE", "");
        }
        #endregion
	}
}