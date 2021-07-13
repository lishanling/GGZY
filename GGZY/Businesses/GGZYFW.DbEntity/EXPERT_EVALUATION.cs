using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类EXPERT_EVALUATION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("EXPERT_EVALUATION")]
    [Serializable]
    public partial class EXPERT_EVALUATION : FwEntity
    {
        #region Model
		private string _ID_CARD;
		private string _ID_CARD_TYPE;
		private string _EXPERT_NAME;
		private string _SEX;
		private DateTime? _BIRTHDAY;
		private string _DUTY;
		private string _EDUCATION;
		private string _PROFESSIONAL;
		private string _ONWORK;
		private string _COMPANY;
		private string _POST_ADDRESS;
		private string _POSTCODE;
		private string _INDUSTRY;
		private string _AREA;
		private decimal? _WORK_YEAR;
		private string _PHONE_NUMBER;
		private string _OTHER_NUMBER;
		private string _DMISSON;
		private DateTime? _ENTER_DATE;
		private decimal? _BASE_TYPE;
		private string _MAJOR_CODE;
		private string _IS_MAIN;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private decimal? _M_ID;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _M_CREATE_TM;
		private string _M_VERSION;

		/// <summary>
		/// 专家身份证件号码
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
		/// 专家身份证件类型
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
		/// 专家姓名
		/// </summary>
		public string EXPERT_NAME
		{
			get{ return _EXPERT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_NAME, _EXPERT_NAME, value);
				this._EXPERT_NAME = value;
			}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public string SEX
		{
			get{ return _SEX; }
			set
			{
				this.OnPropertyValueChange(_.SEX, _SEX, value);
				this._SEX = value;
			}
		}
		/// <summary>
		/// 出生日期
		/// </summary>
		public DateTime? BIRTHDAY
		{
			get{ return _BIRTHDAY; }
			set
			{
				this.OnPropertyValueChange(_.BIRTHDAY, _BIRTHDAY, value);
				this._BIRTHDAY = value;
			}
		}
		/// <summary>
		/// 职务
		/// </summary>
		public string DUTY
		{
			get{ return _DUTY; }
			set
			{
				this.OnPropertyValueChange(_.DUTY, _DUTY, value);
				this._DUTY = value;
			}
		}
		/// <summary>
		/// 最高学历
		/// </summary>
		public string EDUCATION
		{
			get{ return _EDUCATION; }
			set
			{
				this.OnPropertyValueChange(_.EDUCATION, _EDUCATION, value);
				this._EDUCATION = value;
			}
		}
		/// <summary>
		/// 职称
		/// </summary>
		public string PROFESSIONAL
		{
			get{ return _PROFESSIONAL; }
			set
			{
				this.OnPropertyValueChange(_.PROFESSIONAL, _PROFESSIONAL, value);
				this._PROFESSIONAL = value;
			}
		}
		/// <summary>
		/// 是否在职
		/// </summary>
		public string ONWORK
		{
			get{ return _ONWORK; }
			set
			{
				this.OnPropertyValueChange(_.ONWORK, _ONWORK, value);
				this._ONWORK = value;
			}
		}
		/// <summary>
		/// 当前工作单位
		/// </summary>
		public string COMPANY
		{
			get{ return _COMPANY; }
			set
			{
				this.OnPropertyValueChange(_.COMPANY, _COMPANY, value);
				this._COMPANY = value;
			}
		}
		/// <summary>
		/// 通讯地址
		/// </summary>
		public string POST_ADDRESS
		{
			get{ return _POST_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.POST_ADDRESS, _POST_ADDRESS, value);
				this._POST_ADDRESS = value;
			}
		}
		/// <summary>
		/// 邮政编码
		/// </summary>
		public string POSTCODE
		{
			get{ return _POSTCODE; }
			set
			{
				this.OnPropertyValueChange(_.POSTCODE, _POSTCODE, value);
				this._POSTCODE = value;
			}
		}
		/// <summary>
		/// 所属行业
		/// </summary>
		public string INDUSTRY
		{
			get{ return _INDUSTRY; }
			set
			{
				this.OnPropertyValueChange(_.INDUSTRY, _INDUSTRY, value);
				this._INDUSTRY = value;
			}
		}
		/// <summary>
		/// 所在地区
		/// </summary>
		public string AREA
		{
			get{ return _AREA; }
			set
			{
				this.OnPropertyValueChange(_.AREA, _AREA, value);
				this._AREA = value;
			}
		}
		/// <summary>
		/// 工作年限
		/// </summary>
		public decimal? WORK_YEAR
		{
			get{ return _WORK_YEAR; }
			set
			{
				this.OnPropertyValueChange(_.WORK_YEAR, _WORK_YEAR, value);
				this._WORK_YEAR = value;
			}
		}
		/// <summary>
		/// 手机
		/// </summary>
		public string PHONE_NUMBER
		{
			get{ return _PHONE_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.PHONE_NUMBER, _PHONE_NUMBER, value);
				this._PHONE_NUMBER = value;
			}
		}
		/// <summary>
		/// 其他联系方式
		/// </summary>
		public string OTHER_NUMBER
		{
			get{ return _OTHER_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_NUMBER, _OTHER_NUMBER, value);
				this._OTHER_NUMBER = value;
			}
		}
		/// <summary>
		/// 是否可用
		/// </summary>
		public string DMISSON
		{
			get{ return _DMISSON; }
			set
			{
				this.OnPropertyValueChange(_.DMISSON, _DMISSON, value);
				this._DMISSON = value;
			}
		}
		/// <summary>
		/// 入库时间
		/// </summary>
		public DateTime? ENTER_DATE
		{
			get{ return _ENTER_DATE; }
			set
			{
				this.OnPropertyValueChange(_.ENTER_DATE, _ENTER_DATE, value);
				this._ENTER_DATE = value;
			}
		}
		/// <summary>
		/// 专家库类别
		/// </summary>
		public decimal? BASE_TYPE
		{
			get{ return _BASE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BASE_TYPE, _BASE_TYPE, value);
				this._BASE_TYPE = value;
			}
		}
		/// <summary>
		/// 参评专业编号
		/// </summary>
		public string MAJOR_CODE
		{
			get{ return _MAJOR_CODE; }
			set
			{
				this.OnPropertyValueChange(_.MAJOR_CODE, _MAJOR_CODE, value);
				this._MAJOR_CODE = value;
			}
		}
		/// <summary>
		/// 是否主评专业
		/// </summary>
		public string IS_MAIN
		{
			get{ return _IS_MAIN; }
			set
			{
				this.OnPropertyValueChange(_.IS_MAIN, _IS_MAIN, value);
				this._IS_MAIN = value;
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
				_.EXPERT_NAME,
				_.SEX,
				_.BIRTHDAY,
				_.DUTY,
				_.EDUCATION,
				_.PROFESSIONAL,
				_.ONWORK,
				_.COMPANY,
				_.POST_ADDRESS,
				_.POSTCODE,
				_.INDUSTRY,
				_.AREA,
				_.WORK_YEAR,
				_.PHONE_NUMBER,
				_.OTHER_NUMBER,
				_.DMISSON,
				_.ENTER_DATE,
				_.BASE_TYPE,
				_.MAJOR_CODE,
				_.IS_MAIN,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_ID,
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
				this._EXPERT_NAME,
				this._SEX,
				this._BIRTHDAY,
				this._DUTY,
				this._EDUCATION,
				this._PROFESSIONAL,
				this._ONWORK,
				this._COMPANY,
				this._POST_ADDRESS,
				this._POSTCODE,
				this._INDUSTRY,
				this._AREA,
				this._WORK_YEAR,
				this._PHONE_NUMBER,
				this._OTHER_NUMBER,
				this._DMISSON,
				this._ENTER_DATE,
				this._BASE_TYPE,
				this._MAJOR_CODE,
				this._IS_MAIN,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_ID,
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
			public readonly static Field All = new Field("*", "EXPERT_EVALUATION");
            /// <summary>
			/// 专家身份证件号码
			/// </summary>
			public readonly static Field ID_CARD = new Field("ID_CARD", "EXPERT_EVALUATION", "专家身份证件号码");
            /// <summary>
			/// 专家身份证件类型
			/// </summary>
			public readonly static Field ID_CARD_TYPE = new Field("ID_CARD_TYPE", "EXPERT_EVALUATION", "专家身份证件类型");
            /// <summary>
			/// 专家姓名
			/// </summary>
			public readonly static Field EXPERT_NAME = new Field("EXPERT_NAME", "EXPERT_EVALUATION", "专家姓名");
            /// <summary>
			/// 性别
			/// </summary>
			public readonly static Field SEX = new Field("SEX", "EXPERT_EVALUATION", "性别");
            /// <summary>
			/// 出生日期
			/// </summary>
			public readonly static Field BIRTHDAY = new Field("BIRTHDAY", "EXPERT_EVALUATION", "出生日期");
            /// <summary>
			/// 职务
			/// </summary>
			public readonly static Field DUTY = new Field("DUTY", "EXPERT_EVALUATION", "职务");
            /// <summary>
			/// 最高学历
			/// </summary>
			public readonly static Field EDUCATION = new Field("EDUCATION", "EXPERT_EVALUATION", "最高学历");
            /// <summary>
			/// 职称
			/// </summary>
			public readonly static Field PROFESSIONAL = new Field("PROFESSIONAL", "EXPERT_EVALUATION", "职称");
            /// <summary>
			/// 是否在职
			/// </summary>
			public readonly static Field ONWORK = new Field("ONWORK", "EXPERT_EVALUATION", "是否在职");
            /// <summary>
			/// 当前工作单位
			/// </summary>
			public readonly static Field COMPANY = new Field("COMPANY", "EXPERT_EVALUATION", "当前工作单位");
            /// <summary>
			/// 通讯地址
			/// </summary>
			public readonly static Field POST_ADDRESS = new Field("POST_ADDRESS", "EXPERT_EVALUATION", "通讯地址");
            /// <summary>
			/// 邮政编码
			/// </summary>
			public readonly static Field POSTCODE = new Field("POSTCODE", "EXPERT_EVALUATION", "邮政编码");
            /// <summary>
			/// 所属行业
			/// </summary>
			public readonly static Field INDUSTRY = new Field("INDUSTRY", "EXPERT_EVALUATION", "所属行业");
            /// <summary>
			/// 所在地区
			/// </summary>
			public readonly static Field AREA = new Field("AREA", "EXPERT_EVALUATION", "所在地区");
            /// <summary>
			/// 工作年限
			/// </summary>
			public readonly static Field WORK_YEAR = new Field("WORK_YEAR", "EXPERT_EVALUATION", "工作年限");
            /// <summary>
			/// 手机
			/// </summary>
			public readonly static Field PHONE_NUMBER = new Field("PHONE_NUMBER", "EXPERT_EVALUATION", "手机");
            /// <summary>
			/// 其他联系方式
			/// </summary>
			public readonly static Field OTHER_NUMBER = new Field("OTHER_NUMBER", "EXPERT_EVALUATION", "其他联系方式");
            /// <summary>
			/// 是否可用
			/// </summary>
			public readonly static Field DMISSON = new Field("DMISSON", "EXPERT_EVALUATION", "是否可用");
            /// <summary>
			/// 入库时间
			/// </summary>
			public readonly static Field ENTER_DATE = new Field("ENTER_DATE", "EXPERT_EVALUATION", "入库时间");
            /// <summary>
			/// 专家库类别
			/// </summary>
			public readonly static Field BASE_TYPE = new Field("BASE_TYPE", "EXPERT_EVALUATION", "专家库类别");
            /// <summary>
			/// 参评专业编号
			/// </summary>
			public readonly static Field MAJOR_CODE = new Field("MAJOR_CODE", "EXPERT_EVALUATION", "参评专业编号");
            /// <summary>
			/// 是否主评专业
			/// </summary>
			public readonly static Field IS_MAIN = new Field("IS_MAIN", "EXPERT_EVALUATION", "是否主评专业");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "EXPERT_EVALUATION", "交易系统标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "EXPERT_EVALUATION", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "EXPERT_EVALUATION", "数据时间戳");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "EXPERT_EVALUATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "EXPERT_EVALUATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "EXPERT_EVALUATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "EXPERT_EVALUATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "EXPERT_EVALUATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "EXPERT_EVALUATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_CREATE_TM = new Field("M_CREATE_TM", "EXPERT_EVALUATION", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_VERSION = new Field("M_VERSION", "EXPERT_EVALUATION", "");
        }
        #endregion
	}
}