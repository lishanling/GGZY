using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_EVALUATION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_EVALUATION")]
    [Serializable]
    public partial class T_EVALUATION : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _EXPERT_NO;
		private string _EXPERT_NAME;
		private string _SEX;
		private string _ID_CARD_TYPE;
		private string _ID_CARD;
		private DateTime? _BIRTHDAY;
		private string _AREA;
		private string _EDUCATE_SCHOLL;
		private string _EDUCATION;
		private string _PHONE_NUMBER;
		private string _POST_ADDRESS;
		private string _POSTCODE;
		private string _COMPANY;
		private string _ONWORK;
		private string _POST;
		private string _JOB_RESUME;
		private string _MAJOR_CLASSIFIY;
		private string _TECHNICAL_TITLE;
		private string _PROFESSION_SEQUENCE;
		private string _PROFESSION_REGISTER;
		private decimal? _WORK_YEAR;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _M_KEY;

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
		/// 专家编号
		/// </summary>
		public string EXPERT_NO
		{
			get{ return _EXPERT_NO; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_NO, _EXPERT_NO, value);
				this._EXPERT_NO = value;
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
		/// 出生年月
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
		/// 所在行政区域代码
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
		/// 最后毕业院校
		/// </summary>
		public string EDUCATE_SCHOLL
		{
			get{ return _EDUCATE_SCHOLL; }
			set
			{
				this.OnPropertyValueChange(_.EDUCATE_SCHOLL, _EDUCATE_SCHOLL, value);
				this._EDUCATE_SCHOLL = value;
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
		/// 联系电话
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
		/// 所在单位名称
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
		/// 职务
		/// </summary>
		public string POST
		{
			get{ return _POST; }
			set
			{
				this.OnPropertyValueChange(_.POST, _POST, value);
				this._POST = value;
			}
		}
		/// <summary>
		/// 工作简历
		/// </summary>
		public string JOB_RESUME
		{
			get{ return _JOB_RESUME; }
			set
			{
				this.OnPropertyValueChange(_.JOB_RESUME, _JOB_RESUME, value);
				this._JOB_RESUME = value;
			}
		}
		/// <summary>
		/// 专业分类
		/// </summary>
		public string MAJOR_CLASSIFIY
		{
			get{ return _MAJOR_CLASSIFIY; }
			set
			{
				this.OnPropertyValueChange(_.MAJOR_CLASSIFIY, _MAJOR_CLASSIFIY, value);
				this._MAJOR_CLASSIFIY = value;
			}
		}
		/// <summary>
		/// 技术职称
		/// </summary>
		public string TECHNICAL_TITLE
		{
			get{ return _TECHNICAL_TITLE; }
			set
			{
				this.OnPropertyValueChange(_.TECHNICAL_TITLE, _TECHNICAL_TITLE, value);
				this._TECHNICAL_TITLE = value;
			}
		}
		/// <summary>
		/// 职业资格序列
		/// </summary>
		public string PROFESSION_SEQUENCE
		{
			get{ return _PROFESSION_SEQUENCE; }
			set
			{
				this.OnPropertyValueChange(_.PROFESSION_SEQUENCE, _PROFESSION_SEQUENCE, value);
				this._PROFESSION_SEQUENCE = value;
			}
		}
		/// <summary>
		/// 职业资格登记
		/// </summary>
		public string PROFESSION_REGISTER
		{
			get{ return _PROFESSION_REGISTER; }
			set
			{
				this.OnPropertyValueChange(_.PROFESSION_REGISTER, _PROFESSION_REGISTER, value);
				this._PROFESSION_REGISTER = value;
			}
		}
		/// <summary>
		/// 从业年限
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
		/// 数据上传用户
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
		/// 数据上传时间
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
		/// 数据对应的key
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
				_.EXPERT_NO,
				_.EXPERT_NAME,
				_.SEX,
				_.ID_CARD_TYPE,
				_.ID_CARD,
				_.BIRTHDAY,
				_.AREA,
				_.EDUCATE_SCHOLL,
				_.EDUCATION,
				_.PHONE_NUMBER,
				_.POST_ADDRESS,
				_.POSTCODE,
				_.COMPANY,
				_.ONWORK,
				_.POST,
				_.JOB_RESUME,
				_.MAJOR_CLASSIFIY,
				_.TECHNICAL_TITLE,
				_.PROFESSION_SEQUENCE,
				_.PROFESSION_REGISTER,
				_.WORK_YEAR,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.M_KEY,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._EXPERT_NO,
				this._EXPERT_NAME,
				this._SEX,
				this._ID_CARD_TYPE,
				this._ID_CARD,
				this._BIRTHDAY,
				this._AREA,
				this._EDUCATE_SCHOLL,
				this._EDUCATION,
				this._PHONE_NUMBER,
				this._POST_ADDRESS,
				this._POSTCODE,
				this._COMPANY,
				this._ONWORK,
				this._POST,
				this._JOB_RESUME,
				this._MAJOR_CLASSIFIY,
				this._TECHNICAL_TITLE,
				this._PROFESSION_SEQUENCE,
				this._PROFESSION_REGISTER,
				this._WORK_YEAR,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._M_KEY,
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
			public readonly static Field All = new Field("*", "T_EVALUATION");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_EVALUATION", "ID");
            /// <summary>
			/// 专家编号
			/// </summary>
			public readonly static Field EXPERT_NO = new Field("EXPERT_NO", "T_EVALUATION", "专家编号");
            /// <summary>
			/// 专家姓名
			/// </summary>
			public readonly static Field EXPERT_NAME = new Field("EXPERT_NAME", "T_EVALUATION", "专家姓名");
            /// <summary>
			/// 性别
			/// </summary>
			public readonly static Field SEX = new Field("SEX", "T_EVALUATION", "性别");
            /// <summary>
			/// 身份证件类型
			/// </summary>
			public readonly static Field ID_CARD_TYPE = new Field("ID_CARD_TYPE", "T_EVALUATION", "身份证件类型");
            /// <summary>
			/// 身份证件号码
			/// </summary>
			public readonly static Field ID_CARD = new Field("ID_CARD", "T_EVALUATION", "身份证件号码");
            /// <summary>
			/// 出生年月
			/// </summary>
			public readonly static Field BIRTHDAY = new Field("BIRTHDAY", "T_EVALUATION", "出生年月");
            /// <summary>
			/// 所在行政区域代码
			/// </summary>
			public readonly static Field AREA = new Field("AREA", "T_EVALUATION", "所在行政区域代码");
            /// <summary>
			/// 最后毕业院校
			/// </summary>
			public readonly static Field EDUCATE_SCHOLL = new Field("EDUCATE_SCHOLL", "T_EVALUATION", "最后毕业院校");
            /// <summary>
			/// 最高学历
			/// </summary>
			public readonly static Field EDUCATION = new Field("EDUCATION", "T_EVALUATION", "最高学历");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field PHONE_NUMBER = new Field("PHONE_NUMBER", "T_EVALUATION", "联系电话");
            /// <summary>
			/// 通讯地址
			/// </summary>
			public readonly static Field POST_ADDRESS = new Field("POST_ADDRESS", "T_EVALUATION", "通讯地址");
            /// <summary>
			/// 邮政编码
			/// </summary>
			public readonly static Field POSTCODE = new Field("POSTCODE", "T_EVALUATION", "邮政编码");
            /// <summary>
			/// 所在单位名称
			/// </summary>
			public readonly static Field COMPANY = new Field("COMPANY", "T_EVALUATION", "所在单位名称");
            /// <summary>
			/// 是否在职
			/// </summary>
			public readonly static Field ONWORK = new Field("ONWORK", "T_EVALUATION", "是否在职");
            /// <summary>
			/// 职务
			/// </summary>
			public readonly static Field POST = new Field("POST", "T_EVALUATION", "职务");
            /// <summary>
			/// 工作简历
			/// </summary>
			public readonly static Field JOB_RESUME = new Field("JOB_RESUME", "T_EVALUATION",DbType.AnsiString, null, "工作简历");
            /// <summary>
			/// 专业分类
			/// </summary>
			public readonly static Field MAJOR_CLASSIFIY = new Field("MAJOR_CLASSIFIY", "T_EVALUATION", "专业分类");
            /// <summary>
			/// 技术职称
			/// </summary>
			public readonly static Field TECHNICAL_TITLE = new Field("TECHNICAL_TITLE", "T_EVALUATION", "技术职称");
            /// <summary>
			/// 职业资格序列
			/// </summary>
			public readonly static Field PROFESSION_SEQUENCE = new Field("PROFESSION_SEQUENCE", "T_EVALUATION", "职业资格序列");
            /// <summary>
			/// 职业资格登记
			/// </summary>
			public readonly static Field PROFESSION_REGISTER = new Field("PROFESSION_REGISTER", "T_EVALUATION", "职业资格登记");
            /// <summary>
			/// 从业年限
			/// </summary>
			public readonly static Field WORK_YEAR = new Field("WORK_YEAR", "T_EVALUATION", "从业年限");
            /// <summary>
			/// 数据上传用户
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "T_EVALUATION", "数据上传用户");
            /// <summary>
			/// 数据上传时间
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "T_EVALUATION", "数据上传时间");
            /// <summary>
			/// 数据对应的key
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "T_EVALUATION", "数据对应的key");
        }
        #endregion
	}
}