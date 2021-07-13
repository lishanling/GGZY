using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类QUALI_PERSON_BASE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("QUALI_PERSON_BASE")]
    [Serializable]
    public partial class QUALI_PERSON_BASE : FwEntity
    {
        #region Model
		private string _ID_CARD;
		private string _ID_CARD_TYPE;
		private string _PERSON_NAME;
		private string _GENDER;
		private DateTime? _BIRTHDATE;
		private string _REGION_CODE;
		private string _PERSON_EDU;
		private string _PERSON_PHONE;
		private string _UNIT_CODE;
		private string _UNIT_NAME;
		private string _ON_JOB;
		private string _JOB;
		private string _TECH_TITLE;
		private DateTime? _WORK_START_DATE;
		private string _WORKING_EXPERIENCE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private string _M_ATT_ID_CARD_DOC;
		private decimal? _M_F_ID;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _M_VERSION;

		/// <summary>
		/// 身份证件号码
		/// </summary>
		public string ID_CARD
		{
			get{ return _ID_CARD; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD, _ID_CARD, value);
				this._ID_CARD = value;
			}
		}
		/// <summary>
		/// 身份证件类型
		/// </summary>
		public string ID_CARD_TYPE
		{
			get{ return _ID_CARD_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD_TYPE, _ID_CARD_TYPE, value);
				this._ID_CARD_TYPE = value;
			}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string PERSON_NAME
		{
			get{ return _PERSON_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PERSON_NAME, _PERSON_NAME, value);
				this._PERSON_NAME = value;
			}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public string GENDER
		{
			get{ return _GENDER; }
			set
			{
				this.OnPropertyValueChange(_.GENDER, _GENDER, value);
				this._GENDER = value;
			}
		}
		/// <summary>
		/// 出生年月
		/// </summary>
		public DateTime? BIRTHDATE
		{
			get{ return _BIRTHDATE; }
			set
			{
				this.OnPropertyValueChange(_.BIRTHDATE, _BIRTHDATE, value);
				this._BIRTHDATE = value;
			}
		}
		/// <summary>
		/// 行政区域代码
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
		/// 最高学历
		/// </summary>
		public string PERSON_EDU
		{
			get{ return _PERSON_EDU; }
			set
			{
				this.OnPropertyValueChange(_.PERSON_EDU, _PERSON_EDU, value);
				this._PERSON_EDU = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string PERSON_PHONE
		{
			get{ return _PERSON_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.PERSON_PHONE, _PERSON_PHONE, value);
				this._PERSON_PHONE = value;
			}
		}
		/// <summary>
		/// 所在单位代码
		/// </summary>
		public string UNIT_CODE
		{
			get{ return _UNIT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.UNIT_CODE, _UNIT_CODE, value);
				this._UNIT_CODE = value;
			}
		}
		/// <summary>
		/// 所在单位名称
		/// </summary>
		public string UNIT_NAME
		{
			get{ return _UNIT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.UNIT_NAME, _UNIT_NAME, value);
				this._UNIT_NAME = value;
			}
		}
		/// <summary>
		/// 是否在职
		/// </summary>
		public string ON_JOB
		{
			get{ return _ON_JOB; }
			set
			{
				this.OnPropertyValueChange(_.ON_JOB, _ON_JOB, value);
				this._ON_JOB = value;
			}
		}
		/// <summary>
		/// 职务
		/// </summary>
		public string JOB
		{
			get{ return _JOB; }
			set
			{
				this.OnPropertyValueChange(_.JOB, _JOB, value);
				this._JOB = value;
			}
		}
		/// <summary>
		/// 职称
		/// </summary>
		public string TECH_TITLE
		{
			get{ return _TECH_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.TECH_TITLE, _TECH_TITLE, value);
				this._TECH_TITLE = value;
			}
		}
		/// <summary>
		/// 从业开始时间
		/// </summary>
		public DateTime? WORK_START_DATE
		{
			get{ return _WORK_START_DATE; }
			set
			{
				this.OnPropertyValueChange(_.WORK_START_DATE, _WORK_START_DATE, value);
				this._WORK_START_DATE = value;
			}
		}
		/// <summary>
		/// 从业经历
		/// </summary>
		public string WORKING_EXPERIENCE
		{
			get{ return _WORKING_EXPERIENCE; }
			set
			{
				this.OnPropertyValueChange(_.WORKING_EXPERIENCE, _WORKING_EXPERIENCE, value);
				this._WORKING_EXPERIENCE = value;
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
		/// 执业人员身份证件扫描件
		/// </summary>
		public string M_ATT_ID_CARD_DOC
		{
			get{ return _M_ATT_ID_CARD_DOC; }
			set
			{
				this.OnPropertyValueChange(_.M_ATT_ID_CARD_DOC, _M_ATT_ID_CARD_DOC, value);
				this._M_ATT_ID_CARD_DOC = value;
			}
		}
		/// <summary>
		/// 法人信息关联ID
		/// </summary>
		public decimal? M_F_ID
		{
			get{ return _M_F_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_F_ID, _M_F_ID, value);
				this._M_F_ID = value;
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
				_.ID_CARD,
				_.ID_CARD_TYPE,
				_.PERSON_NAME,
				_.GENDER,
				_.BIRTHDATE,
				_.REGION_CODE,
				_.PERSON_EDU,
				_.PERSON_PHONE,
				_.UNIT_CODE,
				_.UNIT_NAME,
				_.ON_JOB,
				_.JOB,
				_.TECH_TITLE,
				_.WORK_START_DATE,
				_.WORKING_EXPERIENCE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
				_.M_ATT_ID_CARD_DOC,
				_.M_F_ID,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.M_CREATE_TM,
				_.M_VERSION,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID_CARD,
				this._ID_CARD_TYPE,
				this._PERSON_NAME,
				this._GENDER,
				this._BIRTHDATE,
				this._REGION_CODE,
				this._PERSON_EDU,
				this._PERSON_PHONE,
				this._UNIT_CODE,
				this._UNIT_NAME,
				this._ON_JOB,
				this._JOB,
				this._TECH_TITLE,
				this._WORK_START_DATE,
				this._WORKING_EXPERIENCE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
				this._M_ATT_ID_CARD_DOC,
				this._M_F_ID,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._M_CREATE_TM,
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
			public readonly static Field All = new Field("*", "QUALI_PERSON_BASE");
            /// <summary>
			/// 身份证件号码
			/// </summary>
			public readonly static Field ID_CARD = new Field("ID_CARD", "QUALI_PERSON_BASE", "身份证件号码");
            /// <summary>
			/// 身份证件类型
			/// </summary>
			public readonly static Field ID_CARD_TYPE = new Field("ID_CARD_TYPE", "QUALI_PERSON_BASE", "身份证件类型");
            /// <summary>
			/// 姓名
			/// </summary>
			public readonly static Field PERSON_NAME = new Field("PERSON_NAME", "QUALI_PERSON_BASE", "姓名");
            /// <summary>
			/// 性别
			/// </summary>
			public readonly static Field GENDER = new Field("GENDER", "QUALI_PERSON_BASE", "性别");
            /// <summary>
			/// 出生年月
			/// </summary>
			public readonly static Field BIRTHDATE = new Field("BIRTHDATE", "QUALI_PERSON_BASE", "出生年月");
            /// <summary>
			/// 行政区域代码
			/// </summary>
			public readonly static Field REGION_CODE = new Field("REGION_CODE", "QUALI_PERSON_BASE", "行政区域代码");
            /// <summary>
			/// 最高学历
			/// </summary>
			public readonly static Field PERSON_EDU = new Field("PERSON_EDU", "QUALI_PERSON_BASE", "最高学历");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field PERSON_PHONE = new Field("PERSON_PHONE", "QUALI_PERSON_BASE", "联系电话");
            /// <summary>
			/// 所在单位代码
			/// </summary>
			public readonly static Field UNIT_CODE = new Field("UNIT_CODE", "QUALI_PERSON_BASE", "所在单位代码");
            /// <summary>
			/// 所在单位名称
			/// </summary>
			public readonly static Field UNIT_NAME = new Field("UNIT_NAME", "QUALI_PERSON_BASE", "所在单位名称");
            /// <summary>
			/// 是否在职
			/// </summary>
			public readonly static Field ON_JOB = new Field("ON_JOB", "QUALI_PERSON_BASE", "是否在职");
            /// <summary>
			/// 职务
			/// </summary>
			public readonly static Field JOB = new Field("JOB", "QUALI_PERSON_BASE", "职务");
            /// <summary>
			/// 职称
			/// </summary>
			public readonly static Field TECH_TITLE = new Field("TECH_TITLE", "QUALI_PERSON_BASE", "职称");
            /// <summary>
			/// 从业开始时间
			/// </summary>
			public readonly static Field WORK_START_DATE = new Field("WORK_START_DATE", "QUALI_PERSON_BASE", "从业开始时间");
            /// <summary>
			/// 从业经历
			/// </summary>
			public readonly static Field WORKING_EXPERIENCE = new Field("WORKING_EXPERIENCE", "QUALI_PERSON_BASE", "从业经历");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "QUALI_PERSON_BASE", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "QUALI_PERSON_BASE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "QUALI_PERSON_BASE", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "QUALI_PERSON_BASE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "QUALI_PERSON_BASE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "QUALI_PERSON_BASE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "QUALI_PERSON_BASE", "");
            /// <summary>
			/// 执业人员身份证件扫描件
			/// </summary>
			public readonly static Field M_ATT_ID_CARD_DOC = new Field("M_ATT_ID_CARD_DOC", "QUALI_PERSON_BASE", "执业人员身份证件扫描件");
            /// <summary>
			/// 法人信息关联ID
			/// </summary>
			public readonly static Field M_F_ID = new Field("M_F_ID", "QUALI_PERSON_BASE", "法人信息关联ID");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "QUALI_PERSON_BASE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "QUALI_PERSON_BASE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "QUALI_PERSON_BASE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "QUALI_PERSON_BASE", "");
        }
        #endregion
	}
}