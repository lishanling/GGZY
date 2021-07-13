using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类RECORD_BIDDING_WRITE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("RECORD_BIDDING_WRITE")]
    [Serializable]
    public partial class RECORD_BIDDING_WRITE : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _RECORD_ID;
		private string _TENDER_PROJECT_NAME;
		private string _CONSTRUCT_CODE;
		private string _TENDER_PROJECT_CODE;
		private string _TENDER_CONTENT;
		private string _SCALE_CONSTRUCT;
		private decimal? _MEASURE_AREA;
		private string _TENDER_MODE;
		private string _TENDER_ORGANIZE_FORM;
		private string _TENDER_AGENCY_NAME;
		private string _TENDER_AGENCY_CODE;
		private string _TENDER_PROJECT_TYPE;
		private string _BID_OPEN_RECORD;
		private string _BID_DISSENT_OPEN_RECORD;
		private string _OTHER_OPEN_RECORD;
		private string _BID_EVALUATE_COMMITTEE;
		private string _BID_EVALUATE_INFO;
		private string _OTHER_EVALUATE_RECORD;
		private string _WIN_BIDDER_WAY;
		private string _CANDIDATE_PUBLIC;
		private string _WIN_BIDDER_PUBLIC;
		private string _WIN_BID_INFO;
		private string _ENTERPRISE_NOTICE_CODE;
		private string _DEPARTMENT_NOTICE_CODE;
		private DateTime? _WIN_BID_DATE;
		private decimal? _BID_AMOUNT;
		private string _WIN_BIDDER_NAME;
		private string _WIN_BIDDER_CODE;
		private string _PROJECT_LEADER_NAME;
		private string _PROJECT_LEADER_CODE;
		private string _BID_EVALUATION_HANDLE;
		private string _COMPLAINT_HANDLE;
		private DateTime? _CREATE_TM;
		private decimal? _CREATOR;
		private string _TENDER_PROJECT_CODE_OLD1;

		/// <summary>
		/// ID
		/// </summary>
		public decimal? ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 备案主表ID
		/// </summary>
		public decimal? RECORD_ID
		{
			get{ return _RECORD_ID; }
			set
			{
				this.OnPropertyValueChange(_.RECORD_ID, _RECORD_ID, value);
				this._RECORD_ID = value;
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
		/// 报建编号
		/// </summary>
		public string CONSTRUCT_CODE
		{
			get{ return _CONSTRUCT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CONSTRUCT_CODE, _CONSTRUCT_CODE, value);
				this._CONSTRUCT_CODE = value;
			}
		}
		/// <summary>
		/// 取交易平台上传的招标项目编号
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
		/// 招标内容与范围及招标方案说明
		/// </summary>
		public string TENDER_CONTENT
		{
			get{ return _TENDER_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_CONTENT, _TENDER_CONTENT, value);
				this._TENDER_CONTENT = value;
			}
		}
		/// <summary>
		/// 工程建设规模
		/// </summary>
		public string SCALE_CONSTRUCT
		{
			get{ return _SCALE_CONSTRUCT; }
			set
			{
				this.OnPropertyValueChange(_.SCALE_CONSTRUCT, _SCALE_CONSTRUCT, value);
				this._SCALE_CONSTRUCT = value;
			}
		}
		/// <summary>
		/// 面积（平方米）
		/// </summary>
		public decimal? MEASURE_AREA
		{
			get{ return _MEASURE_AREA; }
			set
			{
				this.OnPropertyValueChange(_.MEASURE_AREA, _MEASURE_AREA, value);
				this._MEASURE_AREA = value;
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
		/// 招标组织形式
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
		/// 招标代理机构名称
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
		/// 招标代理机构代码
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
		/// 招标类型
		/// </summary>
		public string TENDER_PROJECT_TYPE
		{
			get{ return _TENDER_PROJECT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_TYPE, _TENDER_PROJECT_TYPE, value);
				this._TENDER_PROJECT_TYPE = value;
			}
		}
		/// <summary>
		/// 开标记录情况
		/// </summary>
		public string BID_OPEN_RECORD
		{
			get{ return _BID_OPEN_RECORD; }
			set
			{
				this.OnPropertyValueChange(_.BID_OPEN_RECORD, _BID_OPEN_RECORD, value);
				this._BID_OPEN_RECORD = value;
			}
		}
		/// <summary>
		/// 开标异议处理情况
		/// </summary>
		public string BID_DISSENT_OPEN_RECORD
		{
			get{ return _BID_DISSENT_OPEN_RECORD; }
			set
			{
				this.OnPropertyValueChange(_.BID_DISSENT_OPEN_RECORD, _BID_DISSENT_OPEN_RECORD, value);
				this._BID_DISSENT_OPEN_RECORD = value;
			}
		}
		/// <summary>
		/// 开标过程的其他情况
		/// </summary>
		public string OTHER_OPEN_RECORD
		{
			get{ return _OTHER_OPEN_RECORD; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_OPEN_RECORD, _OTHER_OPEN_RECORD, value);
				this._OTHER_OPEN_RECORD = value;
			}
		}
		/// <summary>
		/// 评标委员会组成情况
		/// </summary>
		public string BID_EVALUATE_COMMITTEE
		{
			get{ return _BID_EVALUATE_COMMITTEE; }
			set
			{
				this.OnPropertyValueChange(_.BID_EVALUATE_COMMITTEE, _BID_EVALUATE_COMMITTEE, value);
				this._BID_EVALUATE_COMMITTEE = value;
			}
		}
		/// <summary>
		/// 评标情况
		/// </summary>
		public string BID_EVALUATE_INFO
		{
			get{ return _BID_EVALUATE_INFO; }
			set
			{
				this.OnPropertyValueChange(_.BID_EVALUATE_INFO, _BID_EVALUATE_INFO, value);
				this._BID_EVALUATE_INFO = value;
			}
		}
		/// <summary>
		/// 评标过程的其他情况
		/// </summary>
		public string OTHER_EVALUATE_RECORD
		{
			get{ return _OTHER_EVALUATE_RECORD; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_EVALUATE_RECORD, _OTHER_EVALUATE_RECORD, value);
				this._OTHER_EVALUATE_RECORD = value;
			}
		}
		/// <summary>
		/// 中标人确定方式
		/// </summary>
		public string WIN_BIDDER_WAY
		{
			get{ return _WIN_BIDDER_WAY; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BIDDER_WAY, _WIN_BIDDER_WAY, value);
				this._WIN_BIDDER_WAY = value;
			}
		}
		/// <summary>
		/// 中标候选人公示情况
		/// </summary>
		public string CANDIDATE_PUBLIC
		{
			get{ return _CANDIDATE_PUBLIC; }
			set
			{
				this.OnPropertyValueChange(_.CANDIDATE_PUBLIC, _CANDIDATE_PUBLIC, value);
				this._CANDIDATE_PUBLIC = value;
			}
		}
		/// <summary>
		/// 中标结果公示情况
		/// </summary>
		public string WIN_BIDDER_PUBLIC
		{
			get{ return _WIN_BIDDER_PUBLIC; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BIDDER_PUBLIC, _WIN_BIDDER_PUBLIC, value);
				this._WIN_BIDDER_PUBLIC = value;
			}
		}
		/// <summary>
		/// 中标结果情况
		/// </summary>
		public string WIN_BID_INFO
		{
			get{ return _WIN_BID_INFO; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BID_INFO, _WIN_BID_INFO, value);
				this._WIN_BID_INFO = value;
			}
		}
		/// <summary>
		/// 中标通知书编号（企业）
		/// </summary>
		public string ENTERPRISE_NOTICE_CODE
		{
			get{ return _ENTERPRISE_NOTICE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.ENTERPRISE_NOTICE_CODE, _ENTERPRISE_NOTICE_CODE, value);
				this._ENTERPRISE_NOTICE_CODE = value;
			}
		}
		/// <summary>
		/// 中标通知书编号（主管部门）
		/// </summary>
		public string DEPARTMENT_NOTICE_CODE
		{
			get{ return _DEPARTMENT_NOTICE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.DEPARTMENT_NOTICE_CODE, _DEPARTMENT_NOTICE_CODE, value);
				this._DEPARTMENT_NOTICE_CODE = value;
			}
		}
		/// <summary>
		/// 中标时间
		/// </summary>
		public DateTime? WIN_BID_DATE
		{
			get{ return _WIN_BID_DATE; }
			set
			{
				this.OnPropertyValueChange(_.WIN_BID_DATE, _WIN_BID_DATE, value);
				this._WIN_BID_DATE = value;
			}
		}
		/// <summary>
		/// 中标金额（万元）
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
		/// 中标人代码
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
		/// 项目负责人
		/// </summary>
		public string PROJECT_LEADER_NAME
		{
			get{ return _PROJECT_LEADER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_LEADER_NAME, _PROJECT_LEADER_NAME, value);
				this._PROJECT_LEADER_NAME = value;
			}
		}
		/// <summary>
		/// 项目负责人身份证号码
		/// </summary>
		public string PROJECT_LEADER_CODE
		{
			get{ return _PROJECT_LEADER_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_LEADER_CODE, _PROJECT_LEADER_CODE, value);
				this._PROJECT_LEADER_CODE = value;
			}
		}
		/// <summary>
		/// 招标文件和评标结果异议处理情况
		/// </summary>
		public string BID_EVALUATION_HANDLE
		{
			get{ return _BID_EVALUATION_HANDLE; }
			set
			{
				this.OnPropertyValueChange(_.BID_EVALUATION_HANDLE, _BID_EVALUATION_HANDLE, value);
				this._BID_EVALUATION_HANDLE = value;
			}
		}
		/// <summary>
		/// 投诉处理情况
		/// </summary>
		public string COMPLAINT_HANDLE
		{
			get{ return _COMPLAINT_HANDLE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_HANDLE, _COMPLAINT_HANDLE, value);
				this._COMPLAINT_HANDLE = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TM
		{
			get{ return _CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TM, _CREATE_TM, value);
				this._CREATE_TM = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public decimal? CREATOR
		{
			get{ return _CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.CREATOR, _CREATOR, value);
				this._CREATOR = value;
			}
		}
		/// <summary>
		/// (交易平台)招标项目编号
		/// </summary>
		public string TENDER_PROJECT_CODE_OLD1
		{
			get{ return _TENDER_PROJECT_CODE_OLD1; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE_OLD1, _TENDER_PROJECT_CODE_OLD1, value);
				this._TENDER_PROJECT_CODE_OLD1 = value;
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
				_.RECORD_ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.RECORD_ID,
				_.TENDER_PROJECT_NAME,
				_.CONSTRUCT_CODE,
				_.TENDER_PROJECT_CODE,
				_.TENDER_CONTENT,
				_.SCALE_CONSTRUCT,
				_.MEASURE_AREA,
				_.TENDER_MODE,
				_.TENDER_ORGANIZE_FORM,
				_.TENDER_AGENCY_NAME,
				_.TENDER_AGENCY_CODE,
				_.TENDER_PROJECT_TYPE,
				_.BID_OPEN_RECORD,
				_.BID_DISSENT_OPEN_RECORD,
				_.OTHER_OPEN_RECORD,
				_.BID_EVALUATE_COMMITTEE,
				_.BID_EVALUATE_INFO,
				_.OTHER_EVALUATE_RECORD,
				_.WIN_BIDDER_WAY,
				_.CANDIDATE_PUBLIC,
				_.WIN_BIDDER_PUBLIC,
				_.WIN_BID_INFO,
				_.ENTERPRISE_NOTICE_CODE,
				_.DEPARTMENT_NOTICE_CODE,
				_.WIN_BID_DATE,
				_.BID_AMOUNT,
				_.WIN_BIDDER_NAME,
				_.WIN_BIDDER_CODE,
				_.PROJECT_LEADER_NAME,
				_.PROJECT_LEADER_CODE,
				_.BID_EVALUATION_HANDLE,
				_.COMPLAINT_HANDLE,
				_.CREATE_TM,
				_.CREATOR,
				_.TENDER_PROJECT_CODE_OLD1,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._RECORD_ID,
				this._TENDER_PROJECT_NAME,
				this._CONSTRUCT_CODE,
				this._TENDER_PROJECT_CODE,
				this._TENDER_CONTENT,
				this._SCALE_CONSTRUCT,
				this._MEASURE_AREA,
				this._TENDER_MODE,
				this._TENDER_ORGANIZE_FORM,
				this._TENDER_AGENCY_NAME,
				this._TENDER_AGENCY_CODE,
				this._TENDER_PROJECT_TYPE,
				this._BID_OPEN_RECORD,
				this._BID_DISSENT_OPEN_RECORD,
				this._OTHER_OPEN_RECORD,
				this._BID_EVALUATE_COMMITTEE,
				this._BID_EVALUATE_INFO,
				this._OTHER_EVALUATE_RECORD,
				this._WIN_BIDDER_WAY,
				this._CANDIDATE_PUBLIC,
				this._WIN_BIDDER_PUBLIC,
				this._WIN_BID_INFO,
				this._ENTERPRISE_NOTICE_CODE,
				this._DEPARTMENT_NOTICE_CODE,
				this._WIN_BID_DATE,
				this._BID_AMOUNT,
				this._WIN_BIDDER_NAME,
				this._WIN_BIDDER_CODE,
				this._PROJECT_LEADER_NAME,
				this._PROJECT_LEADER_CODE,
				this._BID_EVALUATION_HANDLE,
				this._COMPLAINT_HANDLE,
				this._CREATE_TM,
				this._CREATOR,
				this._TENDER_PROJECT_CODE_OLD1,
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
			public readonly static Field All = new Field("*", "RECORD_BIDDING_WRITE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "RECORD_BIDDING_WRITE", "ID");
            /// <summary>
			/// 备案主表ID
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "RECORD_BIDDING_WRITE", "备案主表ID");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "RECORD_BIDDING_WRITE", "招标项目名称");
            /// <summary>
			/// 报建编号
			/// </summary>
			public readonly static Field CONSTRUCT_CODE = new Field("CONSTRUCT_CODE", "RECORD_BIDDING_WRITE", "报建编号");
            /// <summary>
			/// 取交易平台上传的招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "RECORD_BIDDING_WRITE", "取交易平台上传的招标项目编号");
            /// <summary>
			/// 招标内容与范围及招标方案说明
			/// </summary>
			public readonly static Field TENDER_CONTENT = new Field("TENDER_CONTENT", "RECORD_BIDDING_WRITE",DbType.AnsiString, null, "招标内容与范围及招标方案说明");
            /// <summary>
			/// 工程建设规模
			/// </summary>
			public readonly static Field SCALE_CONSTRUCT = new Field("SCALE_CONSTRUCT", "RECORD_BIDDING_WRITE",DbType.AnsiString, null, "工程建设规模");
            /// <summary>
			/// 面积（平方米）
			/// </summary>
			public readonly static Field MEASURE_AREA = new Field("MEASURE_AREA", "RECORD_BIDDING_WRITE", "面积（平方米）");
            /// <summary>
			/// 招标方式
			/// </summary>
			public readonly static Field TENDER_MODE = new Field("TENDER_MODE", "RECORD_BIDDING_WRITE", "招标方式");
            /// <summary>
			/// 招标组织形式
			/// </summary>
			public readonly static Field TENDER_ORGANIZE_FORM = new Field("TENDER_ORGANIZE_FORM", "RECORD_BIDDING_WRITE", "招标组织形式");
            /// <summary>
			/// 招标代理机构名称
			/// </summary>
			public readonly static Field TENDER_AGENCY_NAME = new Field("TENDER_AGENCY_NAME", "RECORD_BIDDING_WRITE", "招标代理机构名称");
            /// <summary>
			/// 招标代理机构代码
			/// </summary>
			public readonly static Field TENDER_AGENCY_CODE = new Field("TENDER_AGENCY_CODE", "RECORD_BIDDING_WRITE", "招标代理机构代码");
            /// <summary>
			/// 招标类型
			/// </summary>
			public readonly static Field TENDER_PROJECT_TYPE = new Field("TENDER_PROJECT_TYPE", "RECORD_BIDDING_WRITE", "招标类型");
            /// <summary>
			/// 开标记录情况
			/// </summary>
			public readonly static Field BID_OPEN_RECORD = new Field("BID_OPEN_RECORD", "RECORD_BIDDING_WRITE",DbType.AnsiString, null, "开标记录情况");
            /// <summary>
			/// 开标异议处理情况
			/// </summary>
			public readonly static Field BID_DISSENT_OPEN_RECORD = new Field("BID_DISSENT_OPEN_RECORD", "RECORD_BIDDING_WRITE",DbType.AnsiString, null, "开标异议处理情况");
            /// <summary>
			/// 开标过程的其他情况
			/// </summary>
			public readonly static Field OTHER_OPEN_RECORD = new Field("OTHER_OPEN_RECORD", "RECORD_BIDDING_WRITE",DbType.AnsiString, null, "开标过程的其他情况");
            /// <summary>
			/// 评标委员会组成情况
			/// </summary>
			public readonly static Field BID_EVALUATE_COMMITTEE = new Field("BID_EVALUATE_COMMITTEE", "RECORD_BIDDING_WRITE",DbType.AnsiString, null, "评标委员会组成情况");
            /// <summary>
			/// 评标情况
			/// </summary>
			public readonly static Field BID_EVALUATE_INFO = new Field("BID_EVALUATE_INFO", "RECORD_BIDDING_WRITE",DbType.AnsiString, null, "评标情况");
            /// <summary>
			/// 评标过程的其他情况
			/// </summary>
			public readonly static Field OTHER_EVALUATE_RECORD = new Field("OTHER_EVALUATE_RECORD", "RECORD_BIDDING_WRITE",DbType.AnsiString, null, "评标过程的其他情况");
            /// <summary>
			/// 中标人确定方式
			/// </summary>
			public readonly static Field WIN_BIDDER_WAY = new Field("WIN_BIDDER_WAY", "RECORD_BIDDING_WRITE", "中标人确定方式");
            /// <summary>
			/// 中标候选人公示情况
			/// </summary>
			public readonly static Field CANDIDATE_PUBLIC = new Field("CANDIDATE_PUBLIC", "RECORD_BIDDING_WRITE",DbType.AnsiString, null, "中标候选人公示情况");
            /// <summary>
			/// 中标结果公示情况
			/// </summary>
			public readonly static Field WIN_BIDDER_PUBLIC = new Field("WIN_BIDDER_PUBLIC", "RECORD_BIDDING_WRITE",DbType.AnsiString, null, "中标结果公示情况");
            /// <summary>
			/// 中标结果情况
			/// </summary>
			public readonly static Field WIN_BID_INFO = new Field("WIN_BID_INFO", "RECORD_BIDDING_WRITE",DbType.AnsiString, null, "中标结果情况");
            /// <summary>
			/// 中标通知书编号（企业）
			/// </summary>
			public readonly static Field ENTERPRISE_NOTICE_CODE = new Field("ENTERPRISE_NOTICE_CODE", "RECORD_BIDDING_WRITE", "中标通知书编号（企业）");
            /// <summary>
			/// 中标通知书编号（主管部门）
			/// </summary>
			public readonly static Field DEPARTMENT_NOTICE_CODE = new Field("DEPARTMENT_NOTICE_CODE", "RECORD_BIDDING_WRITE", "中标通知书编号（主管部门）");
            /// <summary>
			/// 中标时间
			/// </summary>
			public readonly static Field WIN_BID_DATE = new Field("WIN_BID_DATE", "RECORD_BIDDING_WRITE", "中标时间");
            /// <summary>
			/// 中标金额（万元）
			/// </summary>
			public readonly static Field BID_AMOUNT = new Field("BID_AMOUNT", "RECORD_BIDDING_WRITE", "中标金额（万元）");
            /// <summary>
			/// 中标单位名称
			/// </summary>
			public readonly static Field WIN_BIDDER_NAME = new Field("WIN_BIDDER_NAME", "RECORD_BIDDING_WRITE", "中标单位名称");
            /// <summary>
			/// 中标人代码
			/// </summary>
			public readonly static Field WIN_BIDDER_CODE = new Field("WIN_BIDDER_CODE", "RECORD_BIDDING_WRITE", "中标人代码");
            /// <summary>
			/// 项目负责人
			/// </summary>
			public readonly static Field PROJECT_LEADER_NAME = new Field("PROJECT_LEADER_NAME", "RECORD_BIDDING_WRITE", "项目负责人");
            /// <summary>
			/// 项目负责人身份证号码
			/// </summary>
			public readonly static Field PROJECT_LEADER_CODE = new Field("PROJECT_LEADER_CODE", "RECORD_BIDDING_WRITE", "项目负责人身份证号码");
            /// <summary>
			/// 招标文件和评标结果异议处理情况
			/// </summary>
			public readonly static Field BID_EVALUATION_HANDLE = new Field("BID_EVALUATION_HANDLE", "RECORD_BIDDING_WRITE",DbType.AnsiString, null, "招标文件和评标结果异议处理情况");
            /// <summary>
			/// 投诉处理情况
			/// </summary>
			public readonly static Field COMPLAINT_HANDLE = new Field("COMPLAINT_HANDLE", "RECORD_BIDDING_WRITE",DbType.AnsiString, null, "投诉处理情况");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "RECORD_BIDDING_WRITE", "创建时间");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "RECORD_BIDDING_WRITE", "创建人");
            /// <summary>
			/// (交易平台)招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE_OLD1 = new Field("TENDER_PROJECT_CODE_OLD1", "RECORD_BIDDING_WRITE", "(交易平台)招标项目编号");
        }
        #endregion
	}
}