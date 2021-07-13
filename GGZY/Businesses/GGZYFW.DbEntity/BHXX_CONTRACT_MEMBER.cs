using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BHXX_CONTRACT_MEMBER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BHXX_CONTRACT_MEMBER")]
    [Serializable]
    public partial class BHXX_CONTRACT_MEMBER : FwEntity
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
		private string _CONTRACT_CODE;
		private string _NAME;
		private string _PHONE;
		private string _ID_CARD_NO;
		private string _POSITION;
		private string _TECHNICAL_POST;
		private string _CERTIFICATE_NO;
		private string _CERTIFICATE_TYPE;
		private string _CERTIFICATE_FULL_NAME;
		private string _CERTIFICATE_LEVLE;
		private decimal? _YEARS_OF_WORKING;
		private decimal? _CREDIT_SCORE;
		private string _GRADUATE_SCHOOL;
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
		/// 合同编号
		/// </summary>
		public string CONTRACT_CODE
		{
			get{ return _CONTRACT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACT_CODE, _CONTRACT_CODE, value);
				this._CONTRACT_CODE = value;
			}
		}
		/// <summary>
		/// 成员姓名
		/// </summary>
		public string NAME
		{
			get{ return _NAME; }
			set
			{
				this.OnPropertyValueChange(_.NAME, _NAME, value);
				this._NAME = value;
			}
		}
		/// <summary>
		/// 成员联系方式
		/// </summary>
		public string PHONE
		{
			get{ return _PHONE; }
			set
			{
				this.OnPropertyValueChange(_.PHONE, _PHONE, value);
				this._PHONE = value;
			}
		}
		/// <summary>
		/// 成员身份证号
		/// </summary>
		public string ID_CARD_NO
		{
			get{ return _ID_CARD_NO; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD_NO, _ID_CARD_NO, value);
				this._ID_CARD_NO = value;
			}
		}
		/// <summary>
		/// 成员岗位类型
		/// </summary>
		public string POSITION
		{
			get{ return _POSITION; }
			set
			{
				this.OnPropertyValueChange(_.POSITION, _POSITION, value);
				this._POSITION = value;
			}
		}
		/// <summary>
		/// 成员职称
		/// </summary>
		public string TECHNICAL_POST
		{
			get{ return _TECHNICAL_POST; }
			set
			{
				this.OnPropertyValueChange(_.TECHNICAL_POST, _TECHNICAL_POST, value);
				this._TECHNICAL_POST = value;
			}
		}
		/// <summary>
		/// 成员证书编号
		/// </summary>
		public string CERTIFICATE_NO
		{
			get{ return _CERTIFICATE_NO; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATE_NO, _CERTIFICATE_NO, value);
				this._CERTIFICATE_NO = value;
			}
		}
		/// <summary>
		/// 成员证书类型
		/// </summary>
		public string CERTIFICATE_TYPE
		{
			get{ return _CERTIFICATE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATE_TYPE, _CERTIFICATE_TYPE, value);
				this._CERTIFICATE_TYPE = value;
			}
		}
		/// <summary>
		/// 成员证书全称
		/// </summary>
		public string CERTIFICATE_FULL_NAME
		{
			get{ return _CERTIFICATE_FULL_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATE_FULL_NAME, _CERTIFICATE_FULL_NAME, value);
				this._CERTIFICATE_FULL_NAME = value;
			}
		}
		/// <summary>
		/// 成员证书等级
		/// </summary>
		public string CERTIFICATE_LEVLE
		{
			get{ return _CERTIFICATE_LEVLE; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATE_LEVLE, _CERTIFICATE_LEVLE, value);
				this._CERTIFICATE_LEVLE = value;
			}
		}
		/// <summary>
		/// 成员工作年限
		/// </summary>
		public decimal? YEARS_OF_WORKING
		{
			get{ return _YEARS_OF_WORKING; }
			set
			{
				this.OnPropertyValueChange(_.YEARS_OF_WORKING, _YEARS_OF_WORKING, value);
				this._YEARS_OF_WORKING = value;
			}
		}
		/// <summary>
		/// 成员信用分
		/// </summary>
		public decimal? CREDIT_SCORE
		{
			get{ return _CREDIT_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_SCORE, _CREDIT_SCORE, value);
				this._CREDIT_SCORE = value;
			}
		}
		/// <summary>
		/// 成员毕业院校
		/// </summary>
		public string GRADUATE_SCHOOL
		{
			get{ return _GRADUATE_SCHOOL; }
			set
			{
				this.OnPropertyValueChange(_.GRADUATE_SCHOOL, _GRADUATE_SCHOOL, value);
				this._GRADUATE_SCHOOL = value;
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
				_.CONTRACT_CODE,
				_.NAME,
				_.PHONE,
				_.ID_CARD_NO,
				_.POSITION,
				_.TECHNICAL_POST,
				_.CERTIFICATE_NO,
				_.CERTIFICATE_TYPE,
				_.CERTIFICATE_FULL_NAME,
				_.CERTIFICATE_LEVLE,
				_.YEARS_OF_WORKING,
				_.CREDIT_SCORE,
				_.GRADUATE_SCHOOL,
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
				this._CONTRACT_CODE,
				this._NAME,
				this._PHONE,
				this._ID_CARD_NO,
				this._POSITION,
				this._TECHNICAL_POST,
				this._CERTIFICATE_NO,
				this._CERTIFICATE_TYPE,
				this._CERTIFICATE_FULL_NAME,
				this._CERTIFICATE_LEVLE,
				this._YEARS_OF_WORKING,
				this._CREDIT_SCORE,
				this._GRADUATE_SCHOOL,
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
			public readonly static Field All = new Field("*", "BHXX_CONTRACT_MEMBER");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "BHXX_CONTRACT_MEMBER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "BHXX_CONTRACT_MEMBER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "BHXX_CONTRACT_MEMBER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "BHXX_CONTRACT_MEMBER", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "BHXX_CONTRACT_MEMBER", "");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "BHXX_CONTRACT_MEMBER", "招标项目编号");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "BHXX_CONTRACT_MEMBER", "标段（包）编号");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "BHXX_CONTRACT_MEMBER", "统一交易标识码");
            /// <summary>
			/// 合同编号
			/// </summary>
			public readonly static Field CONTRACT_CODE = new Field("CONTRACT_CODE", "BHXX_CONTRACT_MEMBER", "合同编号");
            /// <summary>
			/// 成员姓名
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "BHXX_CONTRACT_MEMBER", "成员姓名");
            /// <summary>
			/// 成员联系方式
			/// </summary>
			public readonly static Field PHONE = new Field("PHONE", "BHXX_CONTRACT_MEMBER", "成员联系方式");
            /// <summary>
			/// 成员身份证号
			/// </summary>
			public readonly static Field ID_CARD_NO = new Field("ID_CARD_NO", "BHXX_CONTRACT_MEMBER", "成员身份证号");
            /// <summary>
			/// 成员岗位类型
			/// </summary>
			public readonly static Field POSITION = new Field("POSITION", "BHXX_CONTRACT_MEMBER", "成员岗位类型");
            /// <summary>
			/// 成员职称
			/// </summary>
			public readonly static Field TECHNICAL_POST = new Field("TECHNICAL_POST", "BHXX_CONTRACT_MEMBER", "成员职称");
            /// <summary>
			/// 成员证书编号
			/// </summary>
			public readonly static Field CERTIFICATE_NO = new Field("CERTIFICATE_NO", "BHXX_CONTRACT_MEMBER", "成员证书编号");
            /// <summary>
			/// 成员证书类型
			/// </summary>
			public readonly static Field CERTIFICATE_TYPE = new Field("CERTIFICATE_TYPE", "BHXX_CONTRACT_MEMBER", "成员证书类型");
            /// <summary>
			/// 成员证书全称
			/// </summary>
			public readonly static Field CERTIFICATE_FULL_NAME = new Field("CERTIFICATE_FULL_NAME", "BHXX_CONTRACT_MEMBER", "成员证书全称");
            /// <summary>
			/// 成员证书等级
			/// </summary>
			public readonly static Field CERTIFICATE_LEVLE = new Field("CERTIFICATE_LEVLE", "BHXX_CONTRACT_MEMBER", "成员证书等级");
            /// <summary>
			/// 成员工作年限
			/// </summary>
			public readonly static Field YEARS_OF_WORKING = new Field("YEARS_OF_WORKING", "BHXX_CONTRACT_MEMBER", "成员工作年限");
            /// <summary>
			/// 成员信用分
			/// </summary>
			public readonly static Field CREDIT_SCORE = new Field("CREDIT_SCORE", "BHXX_CONTRACT_MEMBER", "成员信用分");
            /// <summary>
			/// 成员毕业院校
			/// </summary>
			public readonly static Field GRADUATE_SCHOOL = new Field("GRADUATE_SCHOOL", "BHXX_CONTRACT_MEMBER", "成员毕业院校");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "BHXX_CONTRACT_MEMBER", "交易系统标识码");
            /// <summary>
			/// 交易服务系统标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "BHXX_CONTRACT_MEMBER", "交易服务系统标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "BHXX_CONTRACT_MEMBER", "数据时间戳");
            /// <summary>
			/// 交易平台或发布工具标识码
			/// </summary>
			public readonly static Field TRADE_PLAT = new Field("TRADE_PLAT", "BHXX_CONTRACT_MEMBER", "交易平台或发布工具标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT = new Field("PUB_SERVICE_PLAT", "BHXX_CONTRACT_MEMBER", "公共服务平台标识码");
        }
        #endregion
	}
}