using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类JT_CONSTRUCT_TENDER_FILE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("JT_CONSTRUCT_TENDER_FILE")]
    [Serializable]
    public partial class JT_CONSTRUCT_TENDER_FILE : JdEntity
    {
        #region Model
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODES;
		private string _PROJECT_START;
		private string _MILEAGE_START;
		private string _PROJECT_END;
		private string _MILEAGE_END;
		private decimal? _SPAN;
		private decimal? _LIMITE_ALL_TIME;
		private decimal? _CONTRACT_SECTION;
		private decimal? _CONTRACT_NAME_OR_NUM;
		private decimal? _THIS_CONTRACT_SECTION;
		private decimal? _PERIOD_SERVICE;
		private decimal? _SEEDTIME;
		private decimal? _CONSTRUCTION_TIME;
		private decimal? _DEFECT_LIABILITY_PERIOD;
		private decimal? _CONTRACT_SEGMENT;
		private decimal? _TENDER_NUMBER;
		private string _MEDIA1;
		private string _MEDIA2;
		private string _CONST_MANAGEMENT;
		private string _MARGIN_NAME;
		private string _MARGIN_NUMBER;
		private string _MARGIN_BANK;
		private string _SUPERVISE_DEPT_NAME;
		private string _SUPERVISE_DEPT_PHONE;
		private string _SUPERVISE_DEPT_ADDRESS;
		private string _SUPERVISE_DEPT_FAX;
		private decimal? _SUPERVISE_DEPT_ZIP_CODE;
		private string _PROJECT_DESCRIPTION;
		private string _MAIN_ENGINEER_QUANTITY_LIST;
		private string _SKETCH_MAP;
		private string _PERIOD_SERVICE_TIME;
		private string _MINIMUM_QUALIFICATIONS;
		private string _ACHIEVEMENT_REQUIRE;
		private string _QUALIFICATION_REQUIRE;
		private string _REPUTATION_REQUIRE;
		private string _VEHICLE_REQUIRE;
		private string _SUBC_NAME;
		private string _PROJECT_APPROVAL;
		private string _FULLY_FUNDED;
		private string _BID_SECTION_NAME;
		private string _SUPER_MIN_REQUIRE;
		private string _SUPERVISION_STANDARD;
		private string _ENGINEERING_SPECIFICATIONS;
		private string _TECHNICAL_SPECIFICATIONS;
		private string _DRAWING;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private string _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private DateTime? _M_TM;
		private decimal? _DEFECT_LIABILITY_PERIOD1;
		private decimal? _BID_SECTION;
		private decimal? _BID_SECTION_GROUP;
		private decimal? _TENDERER_BID_SECTION;
		private decimal? _TENDERER_BID_SECTION_GROUP;
		private string _OTHER_MATTERS;
		private string _RECONNAISSANCE;
		private DateTime? _RECONNAISSANCE_TIME;
		private string _RECONNAISSANCE_ADDRESS;
		private string _PREPARATORY_MEETING;
		private DateTime? _PREPARATORY_MEETING_TIME;
		private string _PREPARATORY_MEETING_ADDRESS;
		private string _VEHICLE;
		private string _OTHER;
		private string _FUND_IMPLEMENTATION;
		private string _SECURITY_TARGET;
		private DateTime? _MARGIN_TIME;
		private DateTime? _PROJECT_YEAR_REQUIRED_TIME;
		private DateTime? _LITIGATION_YEAR_REQUIRED_TIME;
		private string _SUPERVISE_DEPT_TELE;
		private decimal? _ALL_EXPERT_NUM;
		private decimal? _TENDERER_NUM;
		private decimal? _EXPERT_NUM;
		private string _FINANCIAL_REQUIRE;
		private decimal? _WIN_CANDIDATE_NUM;
		private string _EVALUATING_METHOD_STANDARD;
		private string _SUBC_NAME_ADDRESS;
		private decimal? _SUBC_ZIP_CODE;
		private string _MATERIAL;
		private string _CONTRACT_CLAUSE;
		private string _DISPUTE_RESOLUTION;
		private string _ARBITRATION_COMMISSION;
		private decimal? _DOCUMENT_CHARGES;
		private decimal? _MINIMUM_LIMIT;
		private string _BILL_OF_QUANTITIES;
		private string _TECHNOLOGY_STANDARD;
		private string _SUPPLY_TECHNICAL_STANDARD;
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
		/// 项目起点位于
		/// </summary>
		public string PROJECT_START
		{
			get{ return _PROJECT_START; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_START, _PROJECT_START, value);
				this._PROJECT_START = value;
			}
		}
		/// <summary>
		/// 起点桩号
		/// </summary>
		public string MILEAGE_START
		{
			get{ return _MILEAGE_START; }
			set
			{
				this.OnPropertyValueChange(_.MILEAGE_START, _MILEAGE_START, value);
				this._MILEAGE_START = value;
			}
		}
		/// <summary>
		/// 项目终点位于
		/// </summary>
		public string PROJECT_END
		{
			get{ return _PROJECT_END; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_END, _PROJECT_END, value);
				this._PROJECT_END = value;
			}
		}
		/// <summary>
		/// 终点桩号
		/// </summary>
		public string MILEAGE_END
		{
			get{ return _MILEAGE_END; }
			set
			{
				this.OnPropertyValueChange(_.MILEAGE_END, _MILEAGE_END, value);
				this._MILEAGE_END = value;
			}
		}
		/// <summary>
		/// 全长（公里）
		/// </summary>
		public decimal? SPAN
		{
			get{ return _SPAN; }
			set
			{
				this.OnPropertyValueChange(_.SPAN, _SPAN, value);
				this._SPAN = value;
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
		/// 施工监理的合同段数量
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
		/// 施工监理的合同段内容
		/// </summary>
		public decimal? CONTRACT_NAME_OR_NUM
		{
			get{ return _CONTRACT_NAME_OR_NUM; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_NAME_OR_NUM, _CONTRACT_NAME_OR_NUM, value);
				this._CONTRACT_NAME_OR_NUM = value;
			}
		}
		/// <summary>
		/// 本次招标合同段名称
		/// </summary>
		public decimal? THIS_CONTRACT_SECTION
		{
			get{ return _THIS_CONTRACT_SECTION; }
			set
			{
				this.OnPropertyValueChange(_.THIS_CONTRACT_SECTION, _THIS_CONTRACT_SECTION, value);
				this._THIS_CONTRACT_SECTION = value;
			}
		}
		/// <summary>
		/// 监理服务期
		/// </summary>
		public decimal? PERIOD_SERVICE
		{
			get{ return _PERIOD_SERVICE; }
			set
			{
				this.OnPropertyValueChange(_.PERIOD_SERVICE, _PERIOD_SERVICE, value);
				this._PERIOD_SERVICE = value;
			}
		}
		/// <summary>
		/// 准备阶段
		/// </summary>
		public decimal? SEEDTIME
		{
			get{ return _SEEDTIME; }
			set
			{
				this.OnPropertyValueChange(_.SEEDTIME, _SEEDTIME, value);
				this._SEEDTIME = value;
			}
		}
		/// <summary>
		/// 施工阶段
		/// </summary>
		public decimal? CONSTRUCTION_TIME
		{
			get{ return _CONSTRUCTION_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCTION_TIME, _CONSTRUCTION_TIME, value);
				this._CONSTRUCTION_TIME = value;
			}
		}
		/// <summary>
		/// 缺陷责任期阶段
		/// </summary>
		public decimal? DEFECT_LIABILITY_PERIOD
		{
			get{ return _DEFECT_LIABILITY_PERIOD; }
			set
			{
				this.OnPropertyValueChange(_.DEFECT_LIABILITY_PERIOD, _DEFECT_LIABILITY_PERIOD, value);
				this._DEFECT_LIABILITY_PERIOD = value;
			}
		}
		/// <summary>
		/// 投标人可参加投标的监理合同段数量
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
		/// 建设单位的管理机构
		/// </summary>
		public string CONST_MANAGEMENT
		{
			get{ return _CONST_MANAGEMENT; }
			set
			{
				this.OnPropertyValueChange(_.CONST_MANAGEMENT, _CONST_MANAGEMENT, value);
				this._CONST_MANAGEMENT = value;
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
		public string SUPERVISE_DEPT_PHONE
		{
			get{ return _SUPERVISE_DEPT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_PHONE, _SUPERVISE_DEPT_PHONE, value);
				this._SUPERVISE_DEPT_PHONE = value;
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
		/// 监督部门传真
		/// </summary>
		public string SUPERVISE_DEPT_FAX
		{
			get{ return _SUPERVISE_DEPT_FAX; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_FAX, _SUPERVISE_DEPT_FAX, value);
				this._SUPERVISE_DEPT_FAX = value;
			}
		}
		/// <summary>
		/// 监督部门邮编
		/// </summary>
		public decimal? SUPERVISE_DEPT_ZIP_CODE
		{
			get{ return _SUPERVISE_DEPT_ZIP_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_DEPT_ZIP_CODE, _SUPERVISE_DEPT_ZIP_CODE, value);
				this._SUPERVISE_DEPT_ZIP_CODE = value;
			}
		}
		/// <summary>
		/// 项目说明
		/// </summary>
		public string PROJECT_DESCRIPTION
		{
			get{ return _PROJECT_DESCRIPTION; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_DESCRIPTION, _PROJECT_DESCRIPTION, value);
				this._PROJECT_DESCRIPTION = value;
			}
		}
		/// <summary>
		/// 主要工程数量表
		/// </summary>
		public string MAIN_ENGINEER_QUANTITY_LIST
		{
			get{ return _MAIN_ENGINEER_QUANTITY_LIST; }
			set
			{
				this.OnPropertyValueChange(_.MAIN_ENGINEER_QUANTITY_LIST, _MAIN_ENGINEER_QUANTITY_LIST, value);
				this._MAIN_ENGINEER_QUANTITY_LIST = value;
			}
		}
		/// <summary>
		/// 地理位置示意图
		/// </summary>
		public string SKETCH_MAP
		{
			get{ return _SKETCH_MAP; }
			set
			{
				this.OnPropertyValueChange(_.SKETCH_MAP, _SKETCH_MAP, value);
				this._SKETCH_MAP = value;
			}
		}
		/// <summary>
		/// 施工工期及监理服务时间
		/// </summary>
		public string PERIOD_SERVICE_TIME
		{
			get{ return _PERIOD_SERVICE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PERIOD_SERVICE_TIME, _PERIOD_SERVICE_TIME, value);
				this._PERIOD_SERVICE_TIME = value;
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
		/// 总监理工程师最低限度资历要求
		/// </summary>
		public string QUALIFICATION_REQUIRE
		{
			get{ return _QUALIFICATION_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.QUALIFICATION_REQUIRE, _QUALIFICATION_REQUIRE, value);
				this._QUALIFICATION_REQUIRE = value;
			}
		}
		/// <summary>
		/// 信誉和履约
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
		/// 交通工具最低要求
		/// </summary>
		public string VEHICLE_REQUIRE
		{
			get{ return _VEHICLE_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.VEHICLE_REQUIRE, _VEHICLE_REQUIRE, value);
				this._VEHICLE_REQUIRE = value;
			}
		}
		/// <summary>
		/// 发包人名称
		/// </summary>
		public string SUBC_NAME
		{
			get{ return _SUBC_NAME; }
			set
			{
				this.OnPropertyValueChange(_.SUBC_NAME, _SUBC_NAME, value);
				this._SUBC_NAME = value;
			}
		}
		/// <summary>
		/// 立项审批情况
		/// </summary>
		public string PROJECT_APPROVAL
		{
			get{ return _PROJECT_APPROVAL; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_APPROVAL, _PROJECT_APPROVAL, value);
				this._PROJECT_APPROVAL = value;
			}
		}
		/// <summary>
		/// 资金组成及到位情况
		/// </summary>
		public string FULLY_FUNDED
		{
			get{ return _FULLY_FUNDED; }
			set
			{
				this.OnPropertyValueChange(_.FULLY_FUNDED, _FULLY_FUNDED, value);
				this._FULLY_FUNDED = value;
			}
		}
		/// <summary>
		/// 监理合同段名称
		/// </summary>
		public string BID_SECTION_NAME
		{
			get{ return _BID_SECTION_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_NAME, _BID_SECTION_NAME, value);
				this._BID_SECTION_NAME = value;
			}
		}
		/// <summary>
		/// 其他监理人员最低限度资历要求
		/// </summary>
		public string SUPER_MIN_REQUIRE
		{
			get{ return _SUPER_MIN_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.SUPER_MIN_REQUIRE, _SUPER_MIN_REQUIRE, value);
				this._SUPER_MIN_REQUIRE = value;
			}
		}
		/// <summary>
		/// 监理规范
		/// </summary>
		public string SUPERVISION_STANDARD
		{
			get{ return _SUPERVISION_STANDARD; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISION_STANDARD, _SUPERVISION_STANDARD, value);
				this._SUPERVISION_STANDARD = value;
			}
		}
		/// <summary>
		/// 工程专用规范
		/// </summary>
		public string ENGINEERING_SPECIFICATIONS
		{
			get{ return _ENGINEERING_SPECIFICATIONS; }
			set
			{
				this.OnPropertyValueChange(_.ENGINEERING_SPECIFICATIONS, _ENGINEERING_SPECIFICATIONS, value);
				this._ENGINEERING_SPECIFICATIONS = value;
			}
		}
		/// <summary>
		/// 技术规范
		/// </summary>
		public string TECHNICAL_SPECIFICATIONS
		{
			get{ return _TECHNICAL_SPECIFICATIONS; }
			set
			{
				this.OnPropertyValueChange(_.TECHNICAL_SPECIFICATIONS, _TECHNICAL_SPECIFICATIONS, value);
				this._TECHNICAL_SPECIFICATIONS = value;
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
		/// 缺陷责任期
		/// </summary>
		public decimal? DEFECT_LIABILITY_PERIOD1
		{
			get{ return _DEFECT_LIABILITY_PERIOD1; }
			set
			{
				this.OnPropertyValueChange(_.DEFECT_LIABILITY_PERIOD1, _DEFECT_LIABILITY_PERIOD1, value);
				this._DEFECT_LIABILITY_PERIOD1 = value;
			}
		}
		/// <summary>
		/// 本项目路基土建工程施工划分标段数
		/// </summary>
		public decimal? BID_SECTION
		{
			get{ return _BID_SECTION; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION, _BID_SECTION, value);
				this._BID_SECTION = value;
			}
		}
		/// <summary>
		/// 投标段组数量
		/// </summary>
		public decimal? BID_SECTION_GROUP
		{
			get{ return _BID_SECTION_GROUP; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_GROUP, _BID_SECTION_GROUP, value);
				this._BID_SECTION_GROUP = value;
			}
		}
		/// <summary>
		/// 本次招标标段数
		/// </summary>
		public decimal? TENDERER_BID_SECTION
		{
			get{ return _TENDERER_BID_SECTION; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_BID_SECTION, _TENDERER_BID_SECTION, value);
				this._TENDERER_BID_SECTION = value;
			}
		}
		/// <summary>
		/// 本次招标投标段组数
		/// </summary>
		public decimal? TENDERER_BID_SECTION_GROUP
		{
			get{ return _TENDERER_BID_SECTION_GROUP; }
			set
			{
				this.OnPropertyValueChange(_.TENDERER_BID_SECTION_GROUP, _TENDERER_BID_SECTION_GROUP, value);
				this._TENDERER_BID_SECTION_GROUP = value;
			}
		}
		/// <summary>
		/// 其他事项
		/// </summary>
		public string OTHER_MATTERS
		{
			get{ return _OTHER_MATTERS; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_MATTERS, _OTHER_MATTERS, value);
				this._OTHER_MATTERS = value;
			}
		}
		/// <summary>
		/// 是否组织踏勘
		/// </summary>
		public string RECONNAISSANCE
		{
			get{ return _RECONNAISSANCE; }
			set
			{
				this.OnPropertyValueChange(_.RECONNAISSANCE, _RECONNAISSANCE, value);
				this._RECONNAISSANCE = value;
			}
		}
		/// <summary>
		/// 踏勘时间
		/// </summary>
		public DateTime? RECONNAISSANCE_TIME
		{
			get{ return _RECONNAISSANCE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.RECONNAISSANCE_TIME, _RECONNAISSANCE_TIME, value);
				this._RECONNAISSANCE_TIME = value;
			}
		}
		/// <summary>
		/// 踏勘地点
		/// </summary>
		public string RECONNAISSANCE_ADDRESS
		{
			get{ return _RECONNAISSANCE_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.RECONNAISSANCE_ADDRESS, _RECONNAISSANCE_ADDRESS, value);
				this._RECONNAISSANCE_ADDRESS = value;
			}
		}
		/// <summary>
		/// 是否召开投标预备会
		/// </summary>
		public string PREPARATORY_MEETING
		{
			get{ return _PREPARATORY_MEETING; }
			set
			{
				this.OnPropertyValueChange(_.PREPARATORY_MEETING, _PREPARATORY_MEETING, value);
				this._PREPARATORY_MEETING = value;
			}
		}
		/// <summary>
		/// 召开投标预备会时间
		/// </summary>
		public DateTime? PREPARATORY_MEETING_TIME
		{
			get{ return _PREPARATORY_MEETING_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PREPARATORY_MEETING_TIME, _PREPARATORY_MEETING_TIME, value);
				this._PREPARATORY_MEETING_TIME = value;
			}
		}
		/// <summary>
		/// 召开投标预备会地点
		/// </summary>
		public string PREPARATORY_MEETING_ADDRESS
		{
			get{ return _PREPARATORY_MEETING_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.PREPARATORY_MEETING_ADDRESS, _PREPARATORY_MEETING_ADDRESS, value);
				this._PREPARATORY_MEETING_ADDRESS = value;
			}
		}
		/// <summary>
		/// 交通工具
		/// </summary>
		public string VEHICLE
		{
			get{ return _VEHICLE; }
			set
			{
				this.OnPropertyValueChange(_.VEHICLE, _VEHICLE, value);
				this._VEHICLE = value;
			}
		}
		/// <summary>
		/// 其他
		/// </summary>
		public string OTHER
		{
			get{ return _OTHER; }
			set
			{
				this.OnPropertyValueChange(_.OTHER, _OTHER, value);
				this._OTHER = value;
			}
		}
		/// <summary>
		/// 资金落实情况
		/// </summary>
		public string FUND_IMPLEMENTATION
		{
			get{ return _FUND_IMPLEMENTATION; }
			set
			{
				this.OnPropertyValueChange(_.FUND_IMPLEMENTATION, _FUND_IMPLEMENTATION, value);
				this._FUND_IMPLEMENTATION = value;
			}
		}
		/// <summary>
		/// 本标段的安全目标
		/// </summary>
		public string SECURITY_TARGET
		{
			get{ return _SECURITY_TARGET; }
			set
			{
				this.OnPropertyValueChange(_.SECURITY_TARGET, _SECURITY_TARGET, value);
				this._SECURITY_TARGET = value;
			}
		}
		/// <summary>
		/// 投标保证金递交截止时间
		/// </summary>
		public DateTime? MARGIN_TIME
		{
			get{ return _MARGIN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.MARGIN_TIME, _MARGIN_TIME, value);
				this._MARGIN_TIME = value;
			}
		}
		/// <summary>
		/// 近年完成的类似项目的年份要求
		/// </summary>
		public DateTime? PROJECT_YEAR_REQUIRED_TIME
		{
			get{ return _PROJECT_YEAR_REQUIRED_TIME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_YEAR_REQUIRED_TIME, _PROJECT_YEAR_REQUIRED_TIME, value);
				this._PROJECT_YEAR_REQUIRED_TIME = value;
			}
		}
		/// <summary>
		/// 近年发生的诉讼及仲裁情况的年份要求
		/// </summary>
		public DateTime? LITIGATION_YEAR_REQUIRED_TIME
		{
			get{ return _LITIGATION_YEAR_REQUIRED_TIME; }
			set
			{
				this.OnPropertyValueChange(_.LITIGATION_YEAR_REQUIRED_TIME, _LITIGATION_YEAR_REQUIRED_TIME, value);
				this._LITIGATION_YEAR_REQUIRED_TIME = value;
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
		/// 财务最低要求
		/// </summary>
		public string FINANCIAL_REQUIRE
		{
			get{ return _FINANCIAL_REQUIRE; }
			set
			{
				this.OnPropertyValueChange(_.FINANCIAL_REQUIRE, _FINANCIAL_REQUIRE, value);
				this._FINANCIAL_REQUIRE = value;
			}
		}
		/// <summary>
		/// 评标委员会推荐中标候选人人数
		/// </summary>
		public decimal? WIN_CANDIDATE_NUM
		{
			get{ return _WIN_CANDIDATE_NUM; }
			set
			{
				this.OnPropertyValueChange(_.WIN_CANDIDATE_NUM, _WIN_CANDIDATE_NUM, value);
				this._WIN_CANDIDATE_NUM = value;
			}
		}
		/// <summary>
		/// 评标办法评审因素和评审标准
		/// </summary>
		public string EVALUATING_METHOD_STANDARD
		{
			get{ return _EVALUATING_METHOD_STANDARD; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATING_METHOD_STANDARD, _EVALUATING_METHOD_STANDARD, value);
				this._EVALUATING_METHOD_STANDARD = value;
			}
		}
		/// <summary>
		/// 发包人地址
		/// </summary>
		public string SUBC_NAME_ADDRESS
		{
			get{ return _SUBC_NAME_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.SUBC_NAME_ADDRESS, _SUBC_NAME_ADDRESS, value);
				this._SUBC_NAME_ADDRESS = value;
			}
		}
		/// <summary>
		/// 发包人邮政编码
		/// </summary>
		public decimal? SUBC_ZIP_CODE
		{
			get{ return _SUBC_ZIP_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SUBC_ZIP_CODE, _SUBC_ZIP_CODE, value);
				this._SUBC_ZIP_CODE = value;
			}
		}
		/// <summary>
		/// 材料名称
		/// </summary>
		public string MATERIAL
		{
			get{ return _MATERIAL; }
			set
			{
				this.OnPropertyValueChange(_.MATERIAL, _MATERIAL, value);
				this._MATERIAL = value;
			}
		}
		/// <summary>
		/// 项目专用合同条款
		/// </summary>
		public string CONTRACT_CLAUSE
		{
			get{ return _CONTRACT_CLAUSE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_CLAUSE, _CONTRACT_CLAUSE, value);
				this._CONTRACT_CLAUSE = value;
			}
		}
		/// <summary>
		/// 争议的最终解决方式
		/// </summary>
		public string DISPUTE_RESOLUTION
		{
			get{ return _DISPUTE_RESOLUTION; }
			set
			{
				this.OnPropertyValueChange(_.DISPUTE_RESOLUTION, _DISPUTE_RESOLUTION, value);
				this._DISPUTE_RESOLUTION = value;
			}
		}
		/// <summary>
		/// 仲裁委员会名称
		/// </summary>
		public string ARBITRATION_COMMISSION
		{
			get{ return _ARBITRATION_COMMISSION; }
			set
			{
				this.OnPropertyValueChange(_.ARBITRATION_COMMISSION, _ARBITRATION_COMMISSION, value);
				this._ARBITRATION_COMMISSION = value;
			}
		}
		/// <summary>
		/// 单据所列费用
		/// </summary>
		public decimal? DOCUMENT_CHARGES
		{
			get{ return _DOCUMENT_CHARGES; }
			set
			{
				this.OnPropertyValueChange(_.DOCUMENT_CHARGES, _DOCUMENT_CHARGES, value);
				this._DOCUMENT_CHARGES = value;
			}
		}
		/// <summary>
		/// 进度付款证书最低限额
		/// </summary>
		public decimal? MINIMUM_LIMIT
		{
			get{ return _MINIMUM_LIMIT; }
			set
			{
				this.OnPropertyValueChange(_.MINIMUM_LIMIT, _MINIMUM_LIMIT, value);
				this._MINIMUM_LIMIT = value;
			}
		}
		/// <summary>
		/// 工程量清单
		/// </summary>
		public string BILL_OF_QUANTITIES
		{
			get{ return _BILL_OF_QUANTITIES; }
			set
			{
				this.OnPropertyValueChange(_.BILL_OF_QUANTITIES, _BILL_OF_QUANTITIES, value);
				this._BILL_OF_QUANTITIES = value;
			}
		}
		/// <summary>
		/// 技术规范
		/// </summary>
		public string TECHNOLOGY_STANDARD
		{
			get{ return _TECHNOLOGY_STANDARD; }
			set
			{
				this.OnPropertyValueChange(_.TECHNOLOGY_STANDARD, _TECHNOLOGY_STANDARD, value);
				this._TECHNOLOGY_STANDARD = value;
			}
		}
		/// <summary>
		/// 补充技术规范
		/// </summary>
		public string SUPPLY_TECHNICAL_STANDARD
		{
			get{ return _SUPPLY_TECHNICAL_STANDARD; }
			set
			{
				this.OnPropertyValueChange(_.SUPPLY_TECHNICAL_STANDARD, _SUPPLY_TECHNICAL_STANDARD, value);
				this._SUPPLY_TECHNICAL_STANDARD = value;
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
				_.PROJECT_START,
				_.MILEAGE_START,
				_.PROJECT_END,
				_.MILEAGE_END,
				_.SPAN,
				_.LIMITE_ALL_TIME,
				_.CONTRACT_SECTION,
				_.CONTRACT_NAME_OR_NUM,
				_.THIS_CONTRACT_SECTION,
				_.PERIOD_SERVICE,
				_.SEEDTIME,
				_.CONSTRUCTION_TIME,
				_.DEFECT_LIABILITY_PERIOD,
				_.CONTRACT_SEGMENT,
				_.TENDER_NUMBER,
				_.MEDIA1,
				_.MEDIA2,
				_.CONST_MANAGEMENT,
				_.MARGIN_NAME,
				_.MARGIN_NUMBER,
				_.MARGIN_BANK,
				_.SUPERVISE_DEPT_NAME,
				_.SUPERVISE_DEPT_PHONE,
				_.SUPERVISE_DEPT_ADDRESS,
				_.SUPERVISE_DEPT_FAX,
				_.SUPERVISE_DEPT_ZIP_CODE,
				_.PROJECT_DESCRIPTION,
				_.MAIN_ENGINEER_QUANTITY_LIST,
				_.SKETCH_MAP,
				_.PERIOD_SERVICE_TIME,
				_.MINIMUM_QUALIFICATIONS,
				_.ACHIEVEMENT_REQUIRE,
				_.QUALIFICATION_REQUIRE,
				_.REPUTATION_REQUIRE,
				_.VEHICLE_REQUIRE,
				_.SUBC_NAME,
				_.PROJECT_APPROVAL,
				_.FULLY_FUNDED,
				_.BID_SECTION_NAME,
				_.SUPER_MIN_REQUIRE,
				_.SUPERVISION_STANDARD,
				_.ENGINEERING_SPECIFICATIONS,
				_.TECHNICAL_SPECIFICATIONS,
				_.DRAWING,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ID,
				_.DATA_KEY,
				_.M_DATA_SOURCE,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_TM,
				_.DEFECT_LIABILITY_PERIOD1,
				_.BID_SECTION,
				_.BID_SECTION_GROUP,
				_.TENDERER_BID_SECTION,
				_.TENDERER_BID_SECTION_GROUP,
				_.OTHER_MATTERS,
				_.RECONNAISSANCE,
				_.RECONNAISSANCE_TIME,
				_.RECONNAISSANCE_ADDRESS,
				_.PREPARATORY_MEETING,
				_.PREPARATORY_MEETING_TIME,
				_.PREPARATORY_MEETING_ADDRESS,
				_.VEHICLE,
				_.OTHER,
				_.FUND_IMPLEMENTATION,
				_.SECURITY_TARGET,
				_.MARGIN_TIME,
				_.PROJECT_YEAR_REQUIRED_TIME,
				_.LITIGATION_YEAR_REQUIRED_TIME,
				_.SUPERVISE_DEPT_TELE,
				_.ALL_EXPERT_NUM,
				_.TENDERER_NUM,
				_.EXPERT_NUM,
				_.FINANCIAL_REQUIRE,
				_.WIN_CANDIDATE_NUM,
				_.EVALUATING_METHOD_STANDARD,
				_.SUBC_NAME_ADDRESS,
				_.SUBC_ZIP_CODE,
				_.MATERIAL,
				_.CONTRACT_CLAUSE,
				_.DISPUTE_RESOLUTION,
				_.ARBITRATION_COMMISSION,
				_.DOCUMENT_CHARGES,
				_.MINIMUM_LIMIT,
				_.BILL_OF_QUANTITIES,
				_.TECHNOLOGY_STANDARD,
				_.SUPPLY_TECHNICAL_STANDARD,
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
				this._PROJECT_START,
				this._MILEAGE_START,
				this._PROJECT_END,
				this._MILEAGE_END,
				this._SPAN,
				this._LIMITE_ALL_TIME,
				this._CONTRACT_SECTION,
				this._CONTRACT_NAME_OR_NUM,
				this._THIS_CONTRACT_SECTION,
				this._PERIOD_SERVICE,
				this._SEEDTIME,
				this._CONSTRUCTION_TIME,
				this._DEFECT_LIABILITY_PERIOD,
				this._CONTRACT_SEGMENT,
				this._TENDER_NUMBER,
				this._MEDIA1,
				this._MEDIA2,
				this._CONST_MANAGEMENT,
				this._MARGIN_NAME,
				this._MARGIN_NUMBER,
				this._MARGIN_BANK,
				this._SUPERVISE_DEPT_NAME,
				this._SUPERVISE_DEPT_PHONE,
				this._SUPERVISE_DEPT_ADDRESS,
				this._SUPERVISE_DEPT_FAX,
				this._SUPERVISE_DEPT_ZIP_CODE,
				this._PROJECT_DESCRIPTION,
				this._MAIN_ENGINEER_QUANTITY_LIST,
				this._SKETCH_MAP,
				this._PERIOD_SERVICE_TIME,
				this._MINIMUM_QUALIFICATIONS,
				this._ACHIEVEMENT_REQUIRE,
				this._QUALIFICATION_REQUIRE,
				this._REPUTATION_REQUIRE,
				this._VEHICLE_REQUIRE,
				this._SUBC_NAME,
				this._PROJECT_APPROVAL,
				this._FULLY_FUNDED,
				this._BID_SECTION_NAME,
				this._SUPER_MIN_REQUIRE,
				this._SUPERVISION_STANDARD,
				this._ENGINEERING_SPECIFICATIONS,
				this._TECHNICAL_SPECIFICATIONS,
				this._DRAWING,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ID,
				this._DATA_KEY,
				this._M_DATA_SOURCE,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._M_TM,
				this._DEFECT_LIABILITY_PERIOD1,
				this._BID_SECTION,
				this._BID_SECTION_GROUP,
				this._TENDERER_BID_SECTION,
				this._TENDERER_BID_SECTION_GROUP,
				this._OTHER_MATTERS,
				this._RECONNAISSANCE,
				this._RECONNAISSANCE_TIME,
				this._RECONNAISSANCE_ADDRESS,
				this._PREPARATORY_MEETING,
				this._PREPARATORY_MEETING_TIME,
				this._PREPARATORY_MEETING_ADDRESS,
				this._VEHICLE,
				this._OTHER,
				this._FUND_IMPLEMENTATION,
				this._SECURITY_TARGET,
				this._MARGIN_TIME,
				this._PROJECT_YEAR_REQUIRED_TIME,
				this._LITIGATION_YEAR_REQUIRED_TIME,
				this._SUPERVISE_DEPT_TELE,
				this._ALL_EXPERT_NUM,
				this._TENDERER_NUM,
				this._EXPERT_NUM,
				this._FINANCIAL_REQUIRE,
				this._WIN_CANDIDATE_NUM,
				this._EVALUATING_METHOD_STANDARD,
				this._SUBC_NAME_ADDRESS,
				this._SUBC_ZIP_CODE,
				this._MATERIAL,
				this._CONTRACT_CLAUSE,
				this._DISPUTE_RESOLUTION,
				this._ARBITRATION_COMMISSION,
				this._DOCUMENT_CHARGES,
				this._MINIMUM_LIMIT,
				this._BILL_OF_QUANTITIES,
				this._TECHNOLOGY_STANDARD,
				this._SUPPLY_TECHNICAL_STANDARD,
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
			public readonly static Field All = new Field("*", "JT_CONSTRUCT_TENDER_FILE");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "JT_CONSTRUCT_TENDER_FILE", "招标项目编号");
            /// <summary>
			/// 相关标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODES = new Field("BID_SECTION_CODES", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "相关标段（包）编号");
            /// <summary>
			/// 项目起点位于
			/// </summary>
			public readonly static Field PROJECT_START = new Field("PROJECT_START", "JT_CONSTRUCT_TENDER_FILE", "项目起点位于");
            /// <summary>
			/// 起点桩号
			/// </summary>
			public readonly static Field MILEAGE_START = new Field("MILEAGE_START", "JT_CONSTRUCT_TENDER_FILE", "起点桩号");
            /// <summary>
			/// 项目终点位于
			/// </summary>
			public readonly static Field PROJECT_END = new Field("PROJECT_END", "JT_CONSTRUCT_TENDER_FILE", "项目终点位于");
            /// <summary>
			/// 终点桩号
			/// </summary>
			public readonly static Field MILEAGE_END = new Field("MILEAGE_END", "JT_CONSTRUCT_TENDER_FILE", "终点桩号");
            /// <summary>
			/// 全长（公里）
			/// </summary>
			public readonly static Field SPAN = new Field("SPAN", "JT_CONSTRUCT_TENDER_FILE", "全长（公里）");
            /// <summary>
			/// 项目总工期
			/// </summary>
			public readonly static Field LIMITE_ALL_TIME = new Field("LIMITE_ALL_TIME", "JT_CONSTRUCT_TENDER_FILE", "项目总工期");
            /// <summary>
			/// 施工监理的合同段数量
			/// </summary>
			public readonly static Field CONTRACT_SECTION = new Field("CONTRACT_SECTION", "JT_CONSTRUCT_TENDER_FILE", "施工监理的合同段数量");
            /// <summary>
			/// 施工监理的合同段内容
			/// </summary>
			public readonly static Field CONTRACT_NAME_OR_NUM = new Field("CONTRACT_NAME_OR_NUM", "JT_CONSTRUCT_TENDER_FILE", "施工监理的合同段内容");
            /// <summary>
			/// 本次招标合同段名称
			/// </summary>
			public readonly static Field THIS_CONTRACT_SECTION = new Field("THIS_CONTRACT_SECTION", "JT_CONSTRUCT_TENDER_FILE", "本次招标合同段名称");
            /// <summary>
			/// 监理服务期
			/// </summary>
			public readonly static Field PERIOD_SERVICE = new Field("PERIOD_SERVICE", "JT_CONSTRUCT_TENDER_FILE", "监理服务期");
            /// <summary>
			/// 准备阶段
			/// </summary>
			public readonly static Field SEEDTIME = new Field("SEEDTIME", "JT_CONSTRUCT_TENDER_FILE", "准备阶段");
            /// <summary>
			/// 施工阶段
			/// </summary>
			public readonly static Field CONSTRUCTION_TIME = new Field("CONSTRUCTION_TIME", "JT_CONSTRUCT_TENDER_FILE", "施工阶段");
            /// <summary>
			/// 缺陷责任期阶段
			/// </summary>
			public readonly static Field DEFECT_LIABILITY_PERIOD = new Field("DEFECT_LIABILITY_PERIOD", "JT_CONSTRUCT_TENDER_FILE", "缺陷责任期阶段");
            /// <summary>
			/// 投标人可参加投标的监理合同段数量
			/// </summary>
			public readonly static Field CONTRACT_SEGMENT = new Field("CONTRACT_SEGMENT", "JT_CONSTRUCT_TENDER_FILE", "投标人可参加投标的监理合同段数量");
            /// <summary>
			/// 投标人最多可中合同段数量
			/// </summary>
			public readonly static Field TENDER_NUMBER = new Field("TENDER_NUMBER", "JT_CONSTRUCT_TENDER_FILE", "投标人最多可中合同段数量");
            /// <summary>
			/// 其他发布媒体1
			/// </summary>
			public readonly static Field MEDIA1 = new Field("MEDIA1", "JT_CONSTRUCT_TENDER_FILE", "其他发布媒体1");
            /// <summary>
			/// 其他发布媒体2
			/// </summary>
			public readonly static Field MEDIA2 = new Field("MEDIA2", "JT_CONSTRUCT_TENDER_FILE", "其他发布媒体2");
            /// <summary>
			/// 建设单位的管理机构
			/// </summary>
			public readonly static Field CONST_MANAGEMENT = new Field("CONST_MANAGEMENT", "JT_CONSTRUCT_TENDER_FILE", "建设单位的管理机构");
            /// <summary>
			/// 招标人账户
			/// </summary>
			public readonly static Field MARGIN_NAME = new Field("MARGIN_NAME", "JT_CONSTRUCT_TENDER_FILE", "招标人账户");
            /// <summary>
			/// 招标人账号
			/// </summary>
			public readonly static Field MARGIN_NUMBER = new Field("MARGIN_NUMBER", "JT_CONSTRUCT_TENDER_FILE", "招标人账号");
            /// <summary>
			/// 招标人开户行
			/// </summary>
			public readonly static Field MARGIN_BANK = new Field("MARGIN_BANK", "JT_CONSTRUCT_TENDER_FILE", "招标人开户行");
            /// <summary>
			/// 监督部门名称
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_NAME = new Field("SUPERVISE_DEPT_NAME", "JT_CONSTRUCT_TENDER_FILE", "监督部门名称");
            /// <summary>
			/// 监督部门联系电话
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_PHONE = new Field("SUPERVISE_DEPT_PHONE", "JT_CONSTRUCT_TENDER_FILE", "监督部门联系电话");
            /// <summary>
			/// 监督部门地址
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ADDRESS = new Field("SUPERVISE_DEPT_ADDRESS", "JT_CONSTRUCT_TENDER_FILE", "监督部门地址");
            /// <summary>
			/// 监督部门传真
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_FAX = new Field("SUPERVISE_DEPT_FAX", "JT_CONSTRUCT_TENDER_FILE", "监督部门传真");
            /// <summary>
			/// 监督部门邮编
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_ZIP_CODE = new Field("SUPERVISE_DEPT_ZIP_CODE", "JT_CONSTRUCT_TENDER_FILE", "监督部门邮编");
            /// <summary>
			/// 项目说明
			/// </summary>
			public readonly static Field PROJECT_DESCRIPTION = new Field("PROJECT_DESCRIPTION", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "项目说明");
            /// <summary>
			/// 主要工程数量表
			/// </summary>
			public readonly static Field MAIN_ENGINEER_QUANTITY_LIST = new Field("MAIN_ENGINEER_QUANTITY_LIST", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "主要工程数量表");
            /// <summary>
			/// 地理位置示意图
			/// </summary>
			public readonly static Field SKETCH_MAP = new Field("SKETCH_MAP", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "地理位置示意图");
            /// <summary>
			/// 施工工期及监理服务时间
			/// </summary>
			public readonly static Field PERIOD_SERVICE_TIME = new Field("PERIOD_SERVICE_TIME", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "施工工期及监理服务时间");
            /// <summary>
			/// 资格审查要求
			/// </summary>
			public readonly static Field MINIMUM_QUALIFICATIONS = new Field("MINIMUM_QUALIFICATIONS", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "资格审查要求");
            /// <summary>
			/// 业绩要求
			/// </summary>
			public readonly static Field ACHIEVEMENT_REQUIRE = new Field("ACHIEVEMENT_REQUIRE", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "业绩要求");
            /// <summary>
			/// 总监理工程师最低限度资历要求
			/// </summary>
			public readonly static Field QUALIFICATION_REQUIRE = new Field("QUALIFICATION_REQUIRE", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "总监理工程师最低限度资历要求");
            /// <summary>
			/// 信誉和履约
			/// </summary>
			public readonly static Field REPUTATION_REQUIRE = new Field("REPUTATION_REQUIRE", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "信誉和履约");
            /// <summary>
			/// 交通工具最低要求
			/// </summary>
			public readonly static Field VEHICLE_REQUIRE = new Field("VEHICLE_REQUIRE", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "交通工具最低要求");
            /// <summary>
			/// 发包人名称
			/// </summary>
			public readonly static Field SUBC_NAME = new Field("SUBC_NAME", "JT_CONSTRUCT_TENDER_FILE", "发包人名称");
            /// <summary>
			/// 立项审批情况
			/// </summary>
			public readonly static Field PROJECT_APPROVAL = new Field("PROJECT_APPROVAL", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "立项审批情况");
            /// <summary>
			/// 资金组成及到位情况
			/// </summary>
			public readonly static Field FULLY_FUNDED = new Field("FULLY_FUNDED", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "资金组成及到位情况");
            /// <summary>
			/// 监理合同段名称
			/// </summary>
			public readonly static Field BID_SECTION_NAME = new Field("BID_SECTION_NAME", "JT_CONSTRUCT_TENDER_FILE", "监理合同段名称");
            /// <summary>
			/// 其他监理人员最低限度资历要求
			/// </summary>
			public readonly static Field SUPER_MIN_REQUIRE = new Field("SUPER_MIN_REQUIRE", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "其他监理人员最低限度资历要求");
            /// <summary>
			/// 监理规范
			/// </summary>
			public readonly static Field SUPERVISION_STANDARD = new Field("SUPERVISION_STANDARD", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "监理规范");
            /// <summary>
			/// 工程专用规范
			/// </summary>
			public readonly static Field ENGINEERING_SPECIFICATIONS = new Field("ENGINEERING_SPECIFICATIONS", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "工程专用规范");
            /// <summary>
			/// 技术规范
			/// </summary>
			public readonly static Field TECHNICAL_SPECIFICATIONS = new Field("TECHNICAL_SPECIFICATIONS", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "技术规范");
            /// <summary>
			/// 图纸
			/// </summary>
			public readonly static Field DRAWING = new Field("DRAWING", "JT_CONSTRUCT_TENDER_FILE", "图纸");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "JT_CONSTRUCT_TENDER_FILE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "JT_CONSTRUCT_TENDER_FILE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JT_CONSTRUCT_TENDER_FILE", "数据时间戳");
            /// <summary>
			/// 数据自增长ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "JT_CONSTRUCT_TENDER_FILE", "数据自增长ID");
            /// <summary>
			/// 数据DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "JT_CONSTRUCT_TENDER_FILE", "数据DATA_KEY");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "JT_CONSTRUCT_TENDER_FILE", "数据来源");
            /// <summary>
			/// M_CREATEBY
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "JT_CONSTRUCT_TENDER_FILE", "M_CREATEBY");
            /// <summary>
			/// M_CREATE_TM
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "JT_CONSTRUCT_TENDER_FILE", "M_CREATE_TM");
            /// <summary>
			/// M_TM
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "JT_CONSTRUCT_TENDER_FILE", "M_TM");
            /// <summary>
			/// 缺陷责任期
			/// </summary>
			public readonly static Field DEFECT_LIABILITY_PERIOD1 = new Field("DEFECT_LIABILITY_PERIOD1", "JT_CONSTRUCT_TENDER_FILE", "缺陷责任期");
            /// <summary>
			/// 本项目路基土建工程施工划分标段数
			/// </summary>
			public readonly static Field BID_SECTION = new Field("BID_SECTION", "JT_CONSTRUCT_TENDER_FILE", "本项目路基土建工程施工划分标段数");
            /// <summary>
			/// 投标段组数量
			/// </summary>
			public readonly static Field BID_SECTION_GROUP = new Field("BID_SECTION_GROUP", "JT_CONSTRUCT_TENDER_FILE", "投标段组数量");
            /// <summary>
			/// 本次招标标段数
			/// </summary>
			public readonly static Field TENDERER_BID_SECTION = new Field("TENDERER_BID_SECTION", "JT_CONSTRUCT_TENDER_FILE", "本次招标标段数");
            /// <summary>
			/// 本次招标投标段组数
			/// </summary>
			public readonly static Field TENDERER_BID_SECTION_GROUP = new Field("TENDERER_BID_SECTION_GROUP", "JT_CONSTRUCT_TENDER_FILE", "本次招标投标段组数");
            /// <summary>
			/// 其他事项
			/// </summary>
			public readonly static Field OTHER_MATTERS = new Field("OTHER_MATTERS", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "其他事项");
            /// <summary>
			/// 是否组织踏勘
			/// </summary>
			public readonly static Field RECONNAISSANCE = new Field("RECONNAISSANCE", "JT_CONSTRUCT_TENDER_FILE", "是否组织踏勘");
            /// <summary>
			/// 踏勘时间
			/// </summary>
			public readonly static Field RECONNAISSANCE_TIME = new Field("RECONNAISSANCE_TIME", "JT_CONSTRUCT_TENDER_FILE", "踏勘时间");
            /// <summary>
			/// 踏勘地点
			/// </summary>
			public readonly static Field RECONNAISSANCE_ADDRESS = new Field("RECONNAISSANCE_ADDRESS", "JT_CONSTRUCT_TENDER_FILE", "踏勘地点");
            /// <summary>
			/// 是否召开投标预备会
			/// </summary>
			public readonly static Field PREPARATORY_MEETING = new Field("PREPARATORY_MEETING", "JT_CONSTRUCT_TENDER_FILE", "是否召开投标预备会");
            /// <summary>
			/// 召开投标预备会时间
			/// </summary>
			public readonly static Field PREPARATORY_MEETING_TIME = new Field("PREPARATORY_MEETING_TIME", "JT_CONSTRUCT_TENDER_FILE", "召开投标预备会时间");
            /// <summary>
			/// 召开投标预备会地点
			/// </summary>
			public readonly static Field PREPARATORY_MEETING_ADDRESS = new Field("PREPARATORY_MEETING_ADDRESS", "JT_CONSTRUCT_TENDER_FILE", "召开投标预备会地点");
            /// <summary>
			/// 交通工具
			/// </summary>
			public readonly static Field VEHICLE = new Field("VEHICLE", "JT_CONSTRUCT_TENDER_FILE", "交通工具");
            /// <summary>
			/// 其他
			/// </summary>
			public readonly static Field OTHER = new Field("OTHER", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "其他");
            /// <summary>
			/// 资金落实情况
			/// </summary>
			public readonly static Field FUND_IMPLEMENTATION = new Field("FUND_IMPLEMENTATION", "JT_CONSTRUCT_TENDER_FILE", "资金落实情况");
            /// <summary>
			/// 本标段的安全目标
			/// </summary>
			public readonly static Field SECURITY_TARGET = new Field("SECURITY_TARGET", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "本标段的安全目标");
            /// <summary>
			/// 投标保证金递交截止时间
			/// </summary>
			public readonly static Field MARGIN_TIME = new Field("MARGIN_TIME", "JT_CONSTRUCT_TENDER_FILE", "投标保证金递交截止时间");
            /// <summary>
			/// 近年完成的类似项目的年份要求
			/// </summary>
			public readonly static Field PROJECT_YEAR_REQUIRED_TIME = new Field("PROJECT_YEAR_REQUIRED_TIME", "JT_CONSTRUCT_TENDER_FILE", "近年完成的类似项目的年份要求");
            /// <summary>
			/// 近年发生的诉讼及仲裁情况的年份要求
			/// </summary>
			public readonly static Field LITIGATION_YEAR_REQUIRED_TIME = new Field("LITIGATION_YEAR_REQUIRED_TIME", "JT_CONSTRUCT_TENDER_FILE", "近年发生的诉讼及仲裁情况的年份要求");
            /// <summary>
			/// 监督部门联系电话
			/// </summary>
			public readonly static Field SUPERVISE_DEPT_TELE = new Field("SUPERVISE_DEPT_TELE", "JT_CONSTRUCT_TENDER_FILE", "监督部门联系电话");
            /// <summary>
			/// 评标委员会人数
			/// </summary>
			public readonly static Field ALL_EXPERT_NUM = new Field("ALL_EXPERT_NUM", "JT_CONSTRUCT_TENDER_FILE", "评标委员会人数");
            /// <summary>
			/// 招标人代表人数
			/// </summary>
			public readonly static Field TENDERER_NUM = new Field("TENDERER_NUM", "JT_CONSTRUCT_TENDER_FILE", "招标人代表人数");
            /// <summary>
			/// 专家人数
			/// </summary>
			public readonly static Field EXPERT_NUM = new Field("EXPERT_NUM", "JT_CONSTRUCT_TENDER_FILE", "专家人数");
            /// <summary>
			/// 财务最低要求
			/// </summary>
			public readonly static Field FINANCIAL_REQUIRE = new Field("FINANCIAL_REQUIRE", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "财务最低要求");
            /// <summary>
			/// 评标委员会推荐中标候选人人数
			/// </summary>
			public readonly static Field WIN_CANDIDATE_NUM = new Field("WIN_CANDIDATE_NUM", "JT_CONSTRUCT_TENDER_FILE", "评标委员会推荐中标候选人人数");
            /// <summary>
			/// 评标办法评审因素和评审标准
			/// </summary>
			public readonly static Field EVALUATING_METHOD_STANDARD = new Field("EVALUATING_METHOD_STANDARD", "JT_CONSTRUCT_TENDER_FILE",DbType.AnsiString, null, "评标办法评审因素和评审标准");
            /// <summary>
			/// 发包人地址
			/// </summary>
			public readonly static Field SUBC_NAME_ADDRESS = new Field("SUBC_NAME_ADDRESS", "JT_CONSTRUCT_TENDER_FILE", "发包人地址");
            /// <summary>
			/// 发包人邮政编码
			/// </summary>
			public readonly static Field SUBC_ZIP_CODE = new Field("SUBC_ZIP_CODE", "JT_CONSTRUCT_TENDER_FILE", "发包人邮政编码");
            /// <summary>
			/// 材料名称
			/// </summary>
			public readonly static Field MATERIAL = new Field("MATERIAL", "JT_CONSTRUCT_TENDER_FILE", "材料名称");
            /// <summary>
			/// 项目专用合同条款
			/// </summary>
			public readonly static Field CONTRACT_CLAUSE = new Field("CONTRACT_CLAUSE", "JT_CONSTRUCT_TENDER_FILE", "项目专用合同条款");
            /// <summary>
			/// 争议的最终解决方式
			/// </summary>
			public readonly static Field DISPUTE_RESOLUTION = new Field("DISPUTE_RESOLUTION", "JT_CONSTRUCT_TENDER_FILE", "争议的最终解决方式");
            /// <summary>
			/// 仲裁委员会名称
			/// </summary>
			public readonly static Field ARBITRATION_COMMISSION = new Field("ARBITRATION_COMMISSION", "JT_CONSTRUCT_TENDER_FILE", "仲裁委员会名称");
            /// <summary>
			/// 单据所列费用
			/// </summary>
			public readonly static Field DOCUMENT_CHARGES = new Field("DOCUMENT_CHARGES", "JT_CONSTRUCT_TENDER_FILE", "单据所列费用");
            /// <summary>
			/// 进度付款证书最低限额
			/// </summary>
			public readonly static Field MINIMUM_LIMIT = new Field("MINIMUM_LIMIT", "JT_CONSTRUCT_TENDER_FILE", "进度付款证书最低限额");
            /// <summary>
			/// 工程量清单
			/// </summary>
			public readonly static Field BILL_OF_QUANTITIES = new Field("BILL_OF_QUANTITIES", "JT_CONSTRUCT_TENDER_FILE", "工程量清单");
            /// <summary>
			/// 技术规范
			/// </summary>
			public readonly static Field TECHNOLOGY_STANDARD = new Field("TECHNOLOGY_STANDARD", "JT_CONSTRUCT_TENDER_FILE", "技术规范");
            /// <summary>
			/// 补充技术规范
			/// </summary>
			public readonly static Field SUPPLY_TECHNICAL_STANDARD = new Field("SUPPLY_TECHNICAL_STANDARD", "JT_CONSTRUCT_TENDER_FILE", "补充技术规范");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "JT_CONSTRUCT_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "JT_CONSTRUCT_TENDER_FILE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "JT_CONSTRUCT_TENDER_FILE", "");
        }
        #endregion
	}
}