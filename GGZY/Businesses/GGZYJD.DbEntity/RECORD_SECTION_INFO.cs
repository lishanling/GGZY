using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类RECORD_SECTION_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("RECORD_SECTION_INFO")]
    [Serializable]
    public partial class RECORD_SECTION_INFO : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _RECORD_ID;
		private string _ENTERPRISE_NOTICE_CODE;
		private string _DEPARTMENT_NOTICE_CODE;
		private DateTime? _WIN_BID_DATE;
		private decimal? _BID_AMOUNT;
		private string _WIN_BIDDER_NAME;
		private string _WIN_BIDDER_CODE;
		private string _PROJECT_LEADER_NAME;
		private string _PROJECT_LEADER_CODE;
		private string _WIN_BIDDER_WAY;
		private string _BID_EVALUATE_INFO;
		private string _OTHER_EVALUATE_RECORD;
		private string _WIN_BIDDER_PUBLIC;
		private string _WIN_BID_INFO;
		private DateTime? _CREATE_TM;
		private decimal? _CREATOR;
		private string _BID_SECTION_CODE;
		private string _BID_SECTION_NAME;

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
		/// 标段包编号
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
		/// 标段包名称
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.ID,
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
				_.ENTERPRISE_NOTICE_CODE,
				_.DEPARTMENT_NOTICE_CODE,
				_.WIN_BID_DATE,
				_.BID_AMOUNT,
				_.WIN_BIDDER_NAME,
				_.WIN_BIDDER_CODE,
				_.PROJECT_LEADER_NAME,
				_.PROJECT_LEADER_CODE,
				_.WIN_BIDDER_WAY,
				_.BID_EVALUATE_INFO,
				_.OTHER_EVALUATE_RECORD,
				_.WIN_BIDDER_PUBLIC,
				_.WIN_BID_INFO,
				_.CREATE_TM,
				_.CREATOR,
				_.BID_SECTION_CODE,
				_.BID_SECTION_NAME,
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
				this._ENTERPRISE_NOTICE_CODE,
				this._DEPARTMENT_NOTICE_CODE,
				this._WIN_BID_DATE,
				this._BID_AMOUNT,
				this._WIN_BIDDER_NAME,
				this._WIN_BIDDER_CODE,
				this._PROJECT_LEADER_NAME,
				this._PROJECT_LEADER_CODE,
				this._WIN_BIDDER_WAY,
				this._BID_EVALUATE_INFO,
				this._OTHER_EVALUATE_RECORD,
				this._WIN_BIDDER_PUBLIC,
				this._WIN_BID_INFO,
				this._CREATE_TM,
				this._CREATOR,
				this._BID_SECTION_CODE,
				this._BID_SECTION_NAME,
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
			public readonly static Field All = new Field("*", "RECORD_SECTION_INFO");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "RECORD_SECTION_INFO", "ID");
            /// <summary>
			/// 备案主表ID
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "RECORD_SECTION_INFO", "备案主表ID");
            /// <summary>
			/// 中标通知书编号（企业）
			/// </summary>
			public readonly static Field ENTERPRISE_NOTICE_CODE = new Field("ENTERPRISE_NOTICE_CODE", "RECORD_SECTION_INFO", "中标通知书编号（企业）");
            /// <summary>
			/// 中标通知书编号（主管部门）
			/// </summary>
			public readonly static Field DEPARTMENT_NOTICE_CODE = new Field("DEPARTMENT_NOTICE_CODE", "RECORD_SECTION_INFO", "中标通知书编号（主管部门）");
            /// <summary>
			/// 中标时间
			/// </summary>
			public readonly static Field WIN_BID_DATE = new Field("WIN_BID_DATE", "RECORD_SECTION_INFO", "中标时间");
            /// <summary>
			/// 中标金额（万元）
			/// </summary>
			public readonly static Field BID_AMOUNT = new Field("BID_AMOUNT", "RECORD_SECTION_INFO", "中标金额（万元）");
            /// <summary>
			/// 中标单位名称
			/// </summary>
			public readonly static Field WIN_BIDDER_NAME = new Field("WIN_BIDDER_NAME", "RECORD_SECTION_INFO", "中标单位名称");
            /// <summary>
			/// 中标人代码
			/// </summary>
			public readonly static Field WIN_BIDDER_CODE = new Field("WIN_BIDDER_CODE", "RECORD_SECTION_INFO", "中标人代码");
            /// <summary>
			/// 项目负责人
			/// </summary>
			public readonly static Field PROJECT_LEADER_NAME = new Field("PROJECT_LEADER_NAME", "RECORD_SECTION_INFO", "项目负责人");
            /// <summary>
			/// 项目负责人身份证号码
			/// </summary>
			public readonly static Field PROJECT_LEADER_CODE = new Field("PROJECT_LEADER_CODE", "RECORD_SECTION_INFO", "项目负责人身份证号码");
            /// <summary>
			/// 中标人确定方式
			/// </summary>
			public readonly static Field WIN_BIDDER_WAY = new Field("WIN_BIDDER_WAY", "RECORD_SECTION_INFO", "中标人确定方式");
            /// <summary>
			/// 评标情况
			/// </summary>
			public readonly static Field BID_EVALUATE_INFO = new Field("BID_EVALUATE_INFO", "RECORD_SECTION_INFO",DbType.AnsiString, null, "评标情况");
            /// <summary>
			/// 评标过程的其他情况
			/// </summary>
			public readonly static Field OTHER_EVALUATE_RECORD = new Field("OTHER_EVALUATE_RECORD", "RECORD_SECTION_INFO",DbType.AnsiString, null, "评标过程的其他情况");
            /// <summary>
			/// 中标结果公示情况
			/// </summary>
			public readonly static Field WIN_BIDDER_PUBLIC = new Field("WIN_BIDDER_PUBLIC", "RECORD_SECTION_INFO",DbType.AnsiString, null, "中标结果公示情况");
            /// <summary>
			/// 中标结果情况
			/// </summary>
			public readonly static Field WIN_BID_INFO = new Field("WIN_BID_INFO", "RECORD_SECTION_INFO",DbType.AnsiString, null, "中标结果情况");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "RECORD_SECTION_INFO", "创建时间");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "RECORD_SECTION_INFO", "创建人");
            /// <summary>
			/// 标段包编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "RECORD_SECTION_INFO", "标段包编号");
            /// <summary>
			/// 标段包名称
			/// </summary>
			public readonly static Field BID_SECTION_NAME = new Field("BID_SECTION_NAME", "RECORD_SECTION_INFO", "标段包名称");
        }
        #endregion
	}
}