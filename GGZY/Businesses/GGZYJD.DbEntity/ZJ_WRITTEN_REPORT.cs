using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类ZJ_WRITTEN_REPORT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_WRITTEN_REPORT")]
    [Serializable]
    public partial class ZJ_WRITTEN_REPORT : JdEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _DATA_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_CREATOR;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _REPROT_CODE;
		private string _TENDER_PROJECT_CODE;
		private string _UNIFIED_DEAL_CODE;
		private string _TENDER_PROJECT_NAME;
		private DateTime? _REVIEW_TIME;
		private string _TENDER_NOTICE_CONTENT;
		private string _CONSTRUCTION_SCALE;
		private decimal? _BUILD_AREA;
		private string _TENDER_MODE;
		private string _TENDER_ORGANIZE_FORM;
		private string _TENDER_AGENCY_NAME;
		private string _TENDER_AGENCY_CODE;
		private string _BID_OPENING_CONTENT;
		private string _BID_OPENING_DISSENT_CONTENT;
		private string _BID_OPENING_OTHER_CONTENT;
		private string _EVALUATION_CONTENT;
		private string _EVALUATION_STATUS;
		private string _EVALUATION_OTHER_CONTENT;
		private string _TENDER_PROJECT_CLASSIFY_CODE;
		private string _WIN_BIDDER_CONFIRM;
		private string _BIDDER_CANDIDATE_CONTENT;
		private string _BIDDER_WIN_CONTENT;
		private string _BIDDER_WIN_RESULT_CONTENT;
		private string _WIN_NOTICE_CODE_ENTP;
		private string _WIN_NOTICE_CODE;
		private DateTime? _WIN_BIDDER_TIME;
		private decimal? _BID_AMOUNT;
		private string _BID_CURRENCY;
		private string _PRICE_UNIT;
		private string _WIN_BIDDER_NAME;
		private string _WIN_BIDDER_CODE;
		private decimal? _WIN_PROVINCE_RANK;
		private decimal? _WIN_BIDDER_RANK;
		private string _PROJECT_LEAD;
		private string _PROJECT_LEAD_ID;
		private string _COMPLAINT_CONTENT;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _TRADE_PLAT;
		private string _PUB_SERVICE_PLAT;
		private string _M_VERSION;
		private string _TENDER_DISSENT_CONTENT;
		private string _M_ATT_TENDER_NOTICE;
		private string _M_ATT_TENDER_FILE;
		private string _M_ATT_BID_OPEN_DOC;
		private string _M_ATT_EVALUATION_DOC;
		private string _M_ATT_WIN_CANDIDATE_DOC;
		private string _M_ATT_PUBLICITY_DOC;
		private string _M_ATT_WIN_BIDDER_DOC;
		private string _M_ATT_WIN_BIDDR_TENDER_FILE;
		private string _M_ATT_CONTRACT_DOC;
		private string _M_ATT_DISPUTE_RESPONSE_DOC;

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
		/// 报建编号
		/// </summary>
		public string REPROT_CODE
		{
			get{ return _REPROT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REPROT_CODE, _REPROT_CODE, value);
				this._REPROT_CODE = value;
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
		/// 招标项目名称
		/// </summary>
		public string TENDER_PROJECT_NAME
		{
			get{ return _TENDER_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_NAME, _TENDER_PROJECT_NAME, value);
				this._TENDER_PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 书面报告备案日期
		/// </summary>
		public DateTime? REVIEW_TIME
		{
			get{ return _REVIEW_TIME; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_TIME, _REVIEW_TIME, value);
				this._REVIEW_TIME = value;
			}
		}
		/// <summary>
		/// 招标范围和内容
		/// </summary>
		public string TENDER_NOTICE_CONTENT
		{
			get{ return _TENDER_NOTICE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_NOTICE_CONTENT, _TENDER_NOTICE_CONTENT, value);
				this._TENDER_NOTICE_CONTENT = value;
			}
		}
		/// <summary>
		/// 工程建设规模
		/// </summary>
		public string CONSTRUCTION_SCALE
		{
			get{ return _CONSTRUCTION_SCALE; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCTION_SCALE, _CONSTRUCTION_SCALE, value);
				this._CONSTRUCTION_SCALE = value;
			}
		}
		/// <summary>
		/// 建筑面积
		/// </summary>
		public decimal? BUILD_AREA
		{
			get{ return _BUILD_AREA; }
			set
			{
				this.OnPropertyValueChange(_.BUILD_AREA, _BUILD_AREA, value);
				this._BUILD_AREA = value;
			}
		}
		/// <summary>
		/// 招标方式
		/// </summary>
		public string TENDER_MODE
		{
			get{ return _TENDER_MODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_MODE, _TENDER_MODE, value);
				this._TENDER_MODE = value;
			}
		}
		/// <summary>
		/// 招标组织方式
		/// </summary>
		public string TENDER_ORGANIZE_FORM
		{
			get{ return _TENDER_ORGANIZE_FORM; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_ORGANIZE_FORM, _TENDER_ORGANIZE_FORM, value);
				this._TENDER_ORGANIZE_FORM = value;
			}
		}
		/// <summary>
		/// 招标代理单位名称
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
		/// 招标代理单位统一社会信用代码
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
		/// 开标记录情况
		/// </summary>
		public string BID_OPENING_CONTENT
		{
			get{ return _BID_OPENING_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPENING_CONTENT, _BID_OPENING_CONTENT, value);
				this._BID_OPENING_CONTENT = value;
			}
		}
		/// <summary>
		/// 开标异议处理情况
		/// </summary>
		public string BID_OPENING_DISSENT_CONTENT
		{
			get{ return _BID_OPENING_DISSENT_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPENING_DISSENT_CONTENT, _BID_OPENING_DISSENT_CONTENT, value);
				this._BID_OPENING_DISSENT_CONTENT = value;
			}
		}
		/// <summary>
		/// 开标过程其他情况
		/// </summary>
		public string BID_OPENING_OTHER_CONTENT
		{
			get{ return _BID_OPENING_OTHER_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPENING_OTHER_CONTENT, _BID_OPENING_OTHER_CONTENT, value);
				this._BID_OPENING_OTHER_CONTENT = value;
			}
		}
		/// <summary>
		/// 评标委员会组成情况
		/// </summary>
		public string EVALUATION_CONTENT
		{
			get{ return _EVALUATION_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATION_CONTENT, _EVALUATION_CONTENT, value);
				this._EVALUATION_CONTENT = value;
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
		/// 评标其他情况
		/// </summary>
		public string EVALUATION_OTHER_CONTENT
		{
			get{ return _EVALUATION_OTHER_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.EVALUATION_OTHER_CONTENT, _EVALUATION_OTHER_CONTENT, value);
				this._EVALUATION_OTHER_CONTENT = value;
			}
		}
		/// <summary>
		/// 招标类型
		/// </summary>
		public string TENDER_PROJECT_CLASSIFY_CODE
		{
			get{ return _TENDER_PROJECT_CLASSIFY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CLASSIFY_CODE, _TENDER_PROJECT_CLASSIFY_CODE, value);
				this._TENDER_PROJECT_CLASSIFY_CODE = value;
			}
		}
		/// <summary>
		/// 中标人确定方式
		/// </summary>
		public string WIN_BIDDER_CONFIRM
		{
			get{ return _WIN_BIDDER_CONFIRM; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BIDDER_CONFIRM, _WIN_BIDDER_CONFIRM, value);
				this._WIN_BIDDER_CONFIRM = value;
			}
		}
		/// <summary>
		/// 中标候选人公示情况
		/// </summary>
		public string BIDDER_CANDIDATE_CONTENT
		{
			get{ return _BIDDER_CANDIDATE_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_CANDIDATE_CONTENT, _BIDDER_CANDIDATE_CONTENT, value);
				this._BIDDER_CANDIDATE_CONTENT = value;
			}
		}
		/// <summary>
		/// 中标结果公示情况
		/// </summary>
		public string BIDDER_WIN_CONTENT
		{
			get{ return _BIDDER_WIN_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_WIN_CONTENT, _BIDDER_WIN_CONTENT, value);
				this._BIDDER_WIN_CONTENT = value;
			}
		}
		/// <summary>
		/// 中标结果情况
		/// </summary>
		public string BIDDER_WIN_RESULT_CONTENT
		{
			get{ return _BIDDER_WIN_RESULT_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.BIDDER_WIN_RESULT_CONTENT, _BIDDER_WIN_RESULT_CONTENT, value);
				this._BIDDER_WIN_RESULT_CONTENT = value;
			}
		}
		/// <summary>
		/// 中标通知书编号（企业）
		/// </summary>
		public string WIN_NOTICE_CODE_ENTP
		{
			get{ return _WIN_NOTICE_CODE_ENTP; }
			set
			{
				this.OnPropertyValueChange(_.WIN_NOTICE_CODE_ENTP, _WIN_NOTICE_CODE_ENTP, value);
				this._WIN_NOTICE_CODE_ENTP = value;
			}
		}
		/// <summary>
		/// 中标通知书编号（主管部门）
		/// </summary>
		public string WIN_NOTICE_CODE
		{
			get{ return _WIN_NOTICE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.WIN_NOTICE_CODE, _WIN_NOTICE_CODE, value);
				this._WIN_NOTICE_CODE = value;
			}
		}
		/// <summary>
		/// 中标日期
		/// </summary>
		public DateTime? WIN_BIDDER_TIME
		{
			get{ return _WIN_BIDDER_TIME; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BIDDER_TIME, _WIN_BIDDER_TIME, value);
				this._WIN_BIDDER_TIME = value;
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
		/// 中标单位名称
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
		/// 中标单位统一社会信用代码
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
		/// 中标单位的信用分排序在全省相应序列信用中排序（如有）
		/// </summary>
		public decimal? WIN_PROVINCE_RANK
		{
			get{ return _WIN_PROVINCE_RANK; }
			set
			{
				this.OnPropertyValueChange(_.WIN_PROVINCE_RANK, _WIN_PROVINCE_RANK, value);
				this._WIN_PROVINCE_RANK = value;
			}
		}
		/// <summary>
		/// 中标单位的信用分在本招标项目所有投标人中信用排序（如有）
		/// </summary>
		public decimal? WIN_BIDDER_RANK
		{
			get{ return _WIN_BIDDER_RANK; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BIDDER_RANK, _WIN_BIDDER_RANK, value);
				this._WIN_BIDDER_RANK = value;
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
		/// <summary>
		/// 投诉处理情况
		/// </summary>
		public string COMPLAINT_CONTENT
		{
			get{ return _COMPLAINT_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_CONTENT, _COMPLAINT_CONTENT, value);
				this._COMPLAINT_CONTENT = value;
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
		/// 招标文件和评标结果异议处理情况
		/// </summary>
		public string TENDER_DISSENT_CONTENT
		{
			get{ return _TENDER_DISSENT_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_DISSENT_CONTENT, _TENDER_DISSENT_CONTENT, value);
				this._TENDER_DISSENT_CONTENT = value;
			}
		}
		/// <summary>
		/// 招标公告或投标邀请书
		/// </summary>
		public string M_ATT_TENDER_NOTICE
		{
			get{ return _M_ATT_TENDER_NOTICE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_TENDER_NOTICE, _M_ATT_TENDER_NOTICE, value);
				this._M_ATT_TENDER_NOTICE = value;
			}
		}
		/// <summary>
		/// 招标文件（含招标文件的澄清、修改）
		/// </summary>
		public string M_ATT_TENDER_FILE
		{
			get{ return _M_ATT_TENDER_FILE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_TENDER_FILE, _M_ATT_TENDER_FILE, value);
				this._M_ATT_TENDER_FILE = value;
			}
		}
		/// <summary>
		/// 开标记录表
		/// </summary>
		public string M_ATT_BID_OPEN_DOC
		{
			get{ return _M_ATT_BID_OPEN_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_BID_OPEN_DOC, _M_ATT_BID_OPEN_DOC, value);
				this._M_ATT_BID_OPEN_DOC = value;
			}
		}
		/// <summary>
		/// 评标委员会的评标报告(含相关附表)
		/// </summary>
		public string M_ATT_EVALUATION_DOC
		{
			get{ return _M_ATT_EVALUATION_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_EVALUATION_DOC, _M_ATT_EVALUATION_DOC, value);
				this._M_ATT_EVALUATION_DOC = value;
			}
		}
		/// <summary>
		/// 中标候选人公示
		/// </summary>
		public string M_ATT_WIN_CANDIDATE_DOC
		{
			get{ return _M_ATT_WIN_CANDIDATE_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_WIN_CANDIDATE_DOC, _M_ATT_WIN_CANDIDATE_DOC, value);
				this._M_ATT_WIN_CANDIDATE_DOC = value;
			}
		}
		/// <summary>
		/// 中标结果公示
		/// </summary>
		public string M_ATT_PUBLICITY_DOC
		{
			get{ return _M_ATT_PUBLICITY_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_PUBLICITY_DOC, _M_ATT_PUBLICITY_DOC, value);
				this._M_ATT_PUBLICITY_DOC = value;
			}
		}
		/// <summary>
		/// 中标通知书
		/// </summary>
		public string M_ATT_WIN_BIDDER_DOC
		{
			get{ return _M_ATT_WIN_BIDDER_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_WIN_BIDDER_DOC, _M_ATT_WIN_BIDDER_DOC, value);
				this._M_ATT_WIN_BIDDER_DOC = value;
			}
		}
		/// <summary>
		/// 中标人的投标文件
		/// </summary>
		public string M_ATT_WIN_BIDDR_TENDER_FILE
		{
			get{ return _M_ATT_WIN_BIDDR_TENDER_FILE; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_WIN_BIDDR_TENDER_FILE, _M_ATT_WIN_BIDDR_TENDER_FILE, value);
				this._M_ATT_WIN_BIDDR_TENDER_FILE = value;
			}
		}
		/// <summary>
		/// 工程招标委托代理合同
		/// </summary>
		public string M_ATT_CONTRACT_DOC
		{
			get{ return _M_ATT_CONTRACT_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_CONTRACT_DOC, _M_ATT_CONTRACT_DOC, value);
				this._M_ATT_CONTRACT_DOC = value;
			}
		}
		/// <summary>
		/// 异议处理答复
		/// </summary>
		public string M_ATT_DISPUTE_RESPONSE_DOC
		{
			get{ return _M_ATT_DISPUTE_RESPONSE_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_DISPUTE_RESPONSE_DOC, _M_ATT_DISPUTE_RESPONSE_DOC, value);
				this._M_ATT_DISPUTE_RESPONSE_DOC = value;
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
				_.M_CREATOR,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.REPROT_CODE,
				_.TENDER_PROJECT_CODE,
				_.UNIFIED_DEAL_CODE,
				_.TENDER_PROJECT_NAME,
				_.REVIEW_TIME,
				_.TENDER_NOTICE_CONTENT,
				_.CONSTRUCTION_SCALE,
				_.BUILD_AREA,
				_.TENDER_MODE,
				_.TENDER_ORGANIZE_FORM,
				_.TENDER_AGENCY_NAME,
				_.TENDER_AGENCY_CODE,
				_.BID_OPENING_CONTENT,
				_.BID_OPENING_DISSENT_CONTENT,
				_.BID_OPENING_OTHER_CONTENT,
				_.EVALUATION_CONTENT,
				_.EVALUATION_STATUS,
				_.EVALUATION_OTHER_CONTENT,
				_.TENDER_PROJECT_CLASSIFY_CODE,
				_.WIN_BIDDER_CONFIRM,
				_.BIDDER_CANDIDATE_CONTENT,
				_.BIDDER_WIN_CONTENT,
				_.BIDDER_WIN_RESULT_CONTENT,
				_.WIN_NOTICE_CODE_ENTP,
				_.WIN_NOTICE_CODE,
				_.WIN_BIDDER_TIME,
				_.BID_AMOUNT,
				_.BID_CURRENCY,
				_.PRICE_UNIT,
				_.WIN_BIDDER_NAME,
				_.WIN_BIDDER_CODE,
				_.WIN_PROVINCE_RANK,
				_.WIN_BIDDER_RANK,
				_.PROJECT_LEAD,
				_.PROJECT_LEAD_ID,
				_.COMPLAINT_CONTENT,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.TRADE_PLAT,
				_.PUB_SERVICE_PLAT,
				_.M_VERSION,
				_.TENDER_DISSENT_CONTENT,
				_.M_ATT_TENDER_NOTICE,
				_.M_ATT_TENDER_FILE,
				_.M_ATT_BID_OPEN_DOC,
				_.M_ATT_EVALUATION_DOC,
				_.M_ATT_WIN_CANDIDATE_DOC,
				_.M_ATT_PUBLICITY_DOC,
				_.M_ATT_WIN_BIDDER_DOC,
				_.M_ATT_WIN_BIDDR_TENDER_FILE,
				_.M_ATT_CONTRACT_DOC,
				_.M_ATT_DISPUTE_RESPONSE_DOC,
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
				this._M_CREATOR,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
				this._REPROT_CODE,
				this._TENDER_PROJECT_CODE,
				this._UNIFIED_DEAL_CODE,
				this._TENDER_PROJECT_NAME,
				this._REVIEW_TIME,
				this._TENDER_NOTICE_CONTENT,
				this._CONSTRUCTION_SCALE,
				this._BUILD_AREA,
				this._TENDER_MODE,
				this._TENDER_ORGANIZE_FORM,
				this._TENDER_AGENCY_NAME,
				this._TENDER_AGENCY_CODE,
				this._BID_OPENING_CONTENT,
				this._BID_OPENING_DISSENT_CONTENT,
				this._BID_OPENING_OTHER_CONTENT,
				this._EVALUATION_CONTENT,
				this._EVALUATION_STATUS,
				this._EVALUATION_OTHER_CONTENT,
				this._TENDER_PROJECT_CLASSIFY_CODE,
				this._WIN_BIDDER_CONFIRM,
				this._BIDDER_CANDIDATE_CONTENT,
				this._BIDDER_WIN_CONTENT,
				this._BIDDER_WIN_RESULT_CONTENT,
				this._WIN_NOTICE_CODE_ENTP,
				this._WIN_NOTICE_CODE,
				this._WIN_BIDDER_TIME,
				this._BID_AMOUNT,
				this._BID_CURRENCY,
				this._PRICE_UNIT,
				this._WIN_BIDDER_NAME,
				this._WIN_BIDDER_CODE,
				this._WIN_PROVINCE_RANK,
				this._WIN_BIDDER_RANK,
				this._PROJECT_LEAD,
				this._PROJECT_LEAD_ID,
				this._COMPLAINT_CONTENT,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._TRADE_PLAT,
				this._PUB_SERVICE_PLAT,
				this._M_VERSION,
				this._TENDER_DISSENT_CONTENT,
				this._M_ATT_TENDER_NOTICE,
				this._M_ATT_TENDER_FILE,
				this._M_ATT_BID_OPEN_DOC,
				this._M_ATT_EVALUATION_DOC,
				this._M_ATT_WIN_CANDIDATE_DOC,
				this._M_ATT_PUBLICITY_DOC,
				this._M_ATT_WIN_BIDDER_DOC,
				this._M_ATT_WIN_BIDDR_TENDER_FILE,
				this._M_ATT_CONTRACT_DOC,
				this._M_ATT_DISPUTE_RESPONSE_DOC,
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
			public readonly static Field All = new Field("*", "ZJ_WRITTEN_REPORT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_WRITTEN_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "ZJ_WRITTEN_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ZJ_WRITTEN_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "ZJ_WRITTEN_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATOR = new Field("M_CREATOR", "ZJ_WRITTEN_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "ZJ_WRITTEN_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "ZJ_WRITTEN_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "ZJ_WRITTEN_REPORT", "");
            /// <summary>
			/// 报建编号
			/// </summary>
			public readonly static Field REPROT_CODE = new Field("REPROT_CODE", "ZJ_WRITTEN_REPORT", "报建编号");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "ZJ_WRITTEN_REPORT", "招标项目编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "ZJ_WRITTEN_REPORT", "统一交易标识码");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "ZJ_WRITTEN_REPORT", "招标项目名称");
            /// <summary>
			/// 书面报告备案日期
			/// </summary>
			public readonly static Field REVIEW_TIME = new Field("REVIEW_TIME", "ZJ_WRITTEN_REPORT", "书面报告备案日期");
            /// <summary>
			/// 招标范围和内容
			/// </summary>
			public readonly static Field TENDER_NOTICE_CONTENT = new Field("TENDER_NOTICE_CONTENT", "ZJ_WRITTEN_REPORT",DbType.AnsiString, null, "招标范围和内容");
            /// <summary>
			/// 工程建设规模
			/// </summary>
			public readonly static Field CONSTRUCTION_SCALE = new Field("CONSTRUCTION_SCALE", "ZJ_WRITTEN_REPORT",DbType.AnsiString, null, "工程建设规模");
            /// <summary>
			/// 建筑面积
			/// </summary>
			public readonly static Field BUILD_AREA = new Field("BUILD_AREA", "ZJ_WRITTEN_REPORT", "建筑面积");
            /// <summary>
			/// 招标方式
			/// </summary>
			public readonly static Field TENDER_MODE = new Field("TENDER_MODE", "ZJ_WRITTEN_REPORT", "招标方式");
            /// <summary>
			/// 招标组织方式
			/// </summary>
			public readonly static Field TENDER_ORGANIZE_FORM = new Field("TENDER_ORGANIZE_FORM", "ZJ_WRITTEN_REPORT", "招标组织方式");
            /// <summary>
			/// 招标代理单位名称
			/// </summary>
			public readonly static Field TENDER_AGENCY_NAME = new Field("TENDER_AGENCY_NAME", "ZJ_WRITTEN_REPORT", "招标代理单位名称");
            /// <summary>
			/// 招标代理单位统一社会信用代码
			/// </summary>
			public readonly static Field TENDER_AGENCY_CODE = new Field("TENDER_AGENCY_CODE", "ZJ_WRITTEN_REPORT", "招标代理单位统一社会信用代码");
            /// <summary>
			/// 开标记录情况
			/// </summary>
			public readonly static Field BID_OPENING_CONTENT = new Field("BID_OPENING_CONTENT", "ZJ_WRITTEN_REPORT",DbType.AnsiString, null, "开标记录情况");
            /// <summary>
			/// 开标异议处理情况
			/// </summary>
			public readonly static Field BID_OPENING_DISSENT_CONTENT = new Field("BID_OPENING_DISSENT_CONTENT", "ZJ_WRITTEN_REPORT",DbType.AnsiString, null, "开标异议处理情况");
            /// <summary>
			/// 开标过程其他情况
			/// </summary>
			public readonly static Field BID_OPENING_OTHER_CONTENT = new Field("BID_OPENING_OTHER_CONTENT", "ZJ_WRITTEN_REPORT",DbType.AnsiString, null, "开标过程其他情况");
            /// <summary>
			/// 评标委员会组成情况
			/// </summary>
			public readonly static Field EVALUATION_CONTENT = new Field("EVALUATION_CONTENT", "ZJ_WRITTEN_REPORT",DbType.AnsiString, null, "评标委员会组成情况");
            /// <summary>
			/// 评标情况
			/// </summary>
			public readonly static Field EVALUATION_STATUS = new Field("EVALUATION_STATUS", "ZJ_WRITTEN_REPORT",DbType.AnsiString, null, "评标情况");
            /// <summary>
			/// 评标其他情况
			/// </summary>
			public readonly static Field EVALUATION_OTHER_CONTENT = new Field("EVALUATION_OTHER_CONTENT", "ZJ_WRITTEN_REPORT",DbType.AnsiString, null, "评标其他情况");
            /// <summary>
			/// 招标类型
			/// </summary>
			public readonly static Field TENDER_PROJECT_CLASSIFY_CODE = new Field("TENDER_PROJECT_CLASSIFY_CODE", "ZJ_WRITTEN_REPORT", "招标类型");
            /// <summary>
			/// 中标人确定方式
			/// </summary>
			public readonly static Field WIN_BIDDER_CONFIRM = new Field("WIN_BIDDER_CONFIRM", "ZJ_WRITTEN_REPORT", "中标人确定方式");
            /// <summary>
			/// 中标候选人公示情况
			/// </summary>
			public readonly static Field BIDDER_CANDIDATE_CONTENT = new Field("BIDDER_CANDIDATE_CONTENT", "ZJ_WRITTEN_REPORT",DbType.AnsiString, null, "中标候选人公示情况");
            /// <summary>
			/// 中标结果公示情况
			/// </summary>
			public readonly static Field BIDDER_WIN_CONTENT = new Field("BIDDER_WIN_CONTENT", "ZJ_WRITTEN_REPORT",DbType.AnsiString, null, "中标结果公示情况");
            /// <summary>
			/// 中标结果情况
			/// </summary>
			public readonly static Field BIDDER_WIN_RESULT_CONTENT = new Field("BIDDER_WIN_RESULT_CONTENT", "ZJ_WRITTEN_REPORT",DbType.AnsiString, null, "中标结果情况");
            /// <summary>
			/// 中标通知书编号（企业）
			/// </summary>
			public readonly static Field WIN_NOTICE_CODE_ENTP = new Field("WIN_NOTICE_CODE_ENTP", "ZJ_WRITTEN_REPORT", "中标通知书编号（企业）");
            /// <summary>
			/// 中标通知书编号（主管部门）
			/// </summary>
			public readonly static Field WIN_NOTICE_CODE = new Field("WIN_NOTICE_CODE", "ZJ_WRITTEN_REPORT", "中标通知书编号（主管部门）");
            /// <summary>
			/// 中标日期
			/// </summary>
			public readonly static Field WIN_BIDDER_TIME = new Field("WIN_BIDDER_TIME", "ZJ_WRITTEN_REPORT", "中标日期");
            /// <summary>
			/// 中标金额
			/// </summary>
			public readonly static Field BID_AMOUNT = new Field("BID_AMOUNT", "ZJ_WRITTEN_REPORT", "中标金额");
            /// <summary>
			/// 价格币种代码
			/// </summary>
			public readonly static Field BID_CURRENCY = new Field("BID_CURRENCY", "ZJ_WRITTEN_REPORT", "价格币种代码");
            /// <summary>
			/// 价格单位
			/// </summary>
			public readonly static Field PRICE_UNIT = new Field("PRICE_UNIT", "ZJ_WRITTEN_REPORT", "价格单位");
            /// <summary>
			/// 中标单位名称
			/// </summary>
			public readonly static Field WIN_BIDDER_NAME = new Field("WIN_BIDDER_NAME", "ZJ_WRITTEN_REPORT", "中标单位名称");
            /// <summary>
			/// 中标单位统一社会信用代码
			/// </summary>
			public readonly static Field WIN_BIDDER_CODE = new Field("WIN_BIDDER_CODE", "ZJ_WRITTEN_REPORT", "中标单位统一社会信用代码");
            /// <summary>
			/// 中标单位的信用分排序在全省相应序列信用中排序（如有）
			/// </summary>
			public readonly static Field WIN_PROVINCE_RANK = new Field("WIN_PROVINCE_RANK", "ZJ_WRITTEN_REPORT", "中标单位的信用分排序在全省相应序列信用中排序（如有）");
            /// <summary>
			/// 中标单位的信用分在本招标项目所有投标人中信用排序（如有）
			/// </summary>
			public readonly static Field WIN_BIDDER_RANK = new Field("WIN_BIDDER_RANK", "ZJ_WRITTEN_REPORT", "中标单位的信用分在本招标项目所有投标人中信用排序（如有）");
            /// <summary>
			/// 项目负责人
			/// </summary>
			public readonly static Field PROJECT_LEAD = new Field("PROJECT_LEAD", "ZJ_WRITTEN_REPORT",DbType.AnsiString, null, "项目负责人");
            /// <summary>
			/// 项目负责人身份证号码
			/// </summary>
			public readonly static Field PROJECT_LEAD_ID = new Field("PROJECT_LEAD_ID", "ZJ_WRITTEN_REPORT", "项目负责人身份证号码");
            /// <summary>
			/// 投诉处理情况
			/// </summary>
			public readonly static Field COMPLAINT_CONTENT = new Field("COMPLAINT_CONTENT", "ZJ_WRITTEN_REPORT",DbType.AnsiString, null, "投诉处理情况");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "ZJ_WRITTEN_REPORT", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ZJ_WRITTEN_REPORT", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ZJ_WRITTEN_REPORT", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "ZJ_WRITTEN_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "ZJ_WRITTEN_REPORT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "ZJ_WRITTEN_REPORT", "");
            /// <summary>
			/// 招标文件和评标结果异议处理情况
			/// </summary>
			public readonly static Field TENDER_DISSENT_CONTENT = new Field("TENDER_DISSENT_CONTENT", "ZJ_WRITTEN_REPORT",DbType.AnsiString, null, "招标文件和评标结果异议处理情况");
            /// <summary>
			/// 招标公告或投标邀请书
			/// </summary>
			public readonly static Field M_ATT_TENDER_NOTICE = new Field("M_ATT_TENDER_NOTICE", "ZJ_WRITTEN_REPORT", "招标公告或投标邀请书");
            /// <summary>
			/// 招标文件（含招标文件的澄清、修改）
			/// </summary>
			public readonly static Field M_ATT_TENDER_FILE = new Field("M_ATT_TENDER_FILE", "ZJ_WRITTEN_REPORT", "招标文件（含招标文件的澄清、修改）");
            /// <summary>
			/// 开标记录表
			/// </summary>
			public readonly static Field M_ATT_BID_OPEN_DOC = new Field("M_ATT_BID_OPEN_DOC", "ZJ_WRITTEN_REPORT", "开标记录表");
            /// <summary>
			/// 评标委员会的评标报告(含相关附表)
			/// </summary>
			public readonly static Field M_ATT_EVALUATION_DOC = new Field("M_ATT_EVALUATION_DOC", "ZJ_WRITTEN_REPORT", "评标委员会的评标报告(含相关附表)");
            /// <summary>
			/// 中标候选人公示
			/// </summary>
			public readonly static Field M_ATT_WIN_CANDIDATE_DOC = new Field("M_ATT_WIN_CANDIDATE_DOC", "ZJ_WRITTEN_REPORT", "中标候选人公示");
            /// <summary>
			/// 中标结果公示
			/// </summary>
			public readonly static Field M_ATT_PUBLICITY_DOC = new Field("M_ATT_PUBLICITY_DOC", "ZJ_WRITTEN_REPORT", "中标结果公示");
            /// <summary>
			/// 中标通知书
			/// </summary>
			public readonly static Field M_ATT_WIN_BIDDER_DOC = new Field("M_ATT_WIN_BIDDER_DOC", "ZJ_WRITTEN_REPORT", "中标通知书");
            /// <summary>
			/// 中标人的投标文件
			/// </summary>
			public readonly static Field M_ATT_WIN_BIDDR_TENDER_FILE = new Field("M_ATT_WIN_BIDDR_TENDER_FILE", "ZJ_WRITTEN_REPORT", "中标人的投标文件");
            /// <summary>
			/// 工程招标委托代理合同
			/// </summary>
			public readonly static Field M_ATT_CONTRACT_DOC = new Field("M_ATT_CONTRACT_DOC", "ZJ_WRITTEN_REPORT", "工程招标委托代理合同");
            /// <summary>
			/// 异议处理答复
			/// </summary>
			public readonly static Field M_ATT_DISPUTE_RESPONSE_DOC = new Field("M_ATT_DISPUTE_RESPONSE_DOC", "ZJ_WRITTEN_REPORT", "异议处理答复");
        }
        #endregion
	}
}