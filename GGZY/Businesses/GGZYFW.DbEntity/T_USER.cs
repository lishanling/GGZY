using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_USER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_USER")]
    [Serializable]
    public partial class T_USER : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _USERNAME;
		private string _PASSWORD;
		private string _EMAIL;
		private decimal? _TYPE;
		private string _CA_CODE;
		private DateTime? _REG_TM;
		private string _API_CODE;
		private string _API_KEY;
		private string _ROLEIDS;
		private string _SESSION_ID;
		private decimal? _P_ID;
		private decimal? _GENDER;
		private decimal? _IS_ENABLE;
		private string _COMPANY_CODE;
		private string _MANAGE_NAME;
		private string _AREACODE;
		private string _ZP_FAX;
		private string _ZP_UNIT;
		private string _ZP_ADDRESS;
		private decimal? _ZP_ID;
		private string _ZP_PHONE;
		private string _CHECK_CODE;
		private decimal? _IS_CHECK_PHONE;
		private DateTime? _EFECTIVE_TIME;
		private decimal? _IS_AUDIT;
		private decimal? _AUDIT_BY;
		private DateTime? _AUDIT_TM;
		private string _AAAA;
		private string _CA_INFO;

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
		/// 用户名
		/// </summary>
		public string USERNAME
		{
			get{ return _USERNAME; }
			set
			{
				this.OnPropertyValueChange(_.USERNAME, _USERNAME, value);
				this._USERNAME = value;
			}
		}
		/// <summary>
		/// 登录密码
		/// </summary>
		public string PASSWORD
		{
			get{ return _PASSWORD; }
			set
			{
				this.OnPropertyValueChange(_.PASSWORD, _PASSWORD, value);
				this._PASSWORD = value;
			}
		}
		/// <summary>
		/// Email
		/// </summary>
		public string EMAIL
		{
			get{ return _EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.EMAIL, _EMAIL, value);
				this._EMAIL = value;
			}
		}
		/// <summary>
		/// 账号类别 0:游客 1:个人用户 2:企业用户
		/// </summary>
		public decimal? TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// CA编码
		/// </summary>
		public string CA_CODE
		{
			get{ return _CA_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CA_CODE, _CA_CODE, value);
				this._CA_CODE = value;
			}
		}
		/// <summary>
		/// 注册时间
		/// </summary>
		public DateTime? REG_TM
		{
			get{ return _REG_TM; }
			set
			{
				this.OnPropertyValueChange(_.REG_TM, _REG_TM, value);
				this._REG_TM = value;
			}
		}
		/// <summary>
		/// 交易平台编码
		/// </summary>
		public string API_CODE
		{
			get{ return _API_CODE; }
			set
			{
				this.OnPropertyValueChange(_.API_CODE, _API_CODE, value);
				this._API_CODE = value;
			}
		}
		/// <summary>
		/// 交易平台密钥
		/// </summary>
		public string API_KEY
		{
			get{ return _API_KEY; }
			set
			{
				this.OnPropertyValueChange(_.API_KEY, _API_KEY, value);
				this._API_KEY = value;
			}
		}
		/// <summary>
		/// 用户角色ID
		/// </summary>
		public string ROLEIDS
		{
			get{ return _ROLEIDS; }
			set
			{
				this.OnPropertyValueChange(_.ROLEIDS, _ROLEIDS, value);
				this._ROLEIDS = value;
			}
		}
		/// <summary>
		/// 登陆后生成的一个guid用于判断登陆状态
		/// </summary>
		public string SESSION_ID
		{
			get{ return _SESSION_ID; }
			set
			{
				this.OnPropertyValueChange(_.SESSION_ID, _SESSION_ID, value);
				this._SESSION_ID = value;
			}
		}
		/// <summary>
		/// 父账号ID
		/// </summary>
		public decimal? P_ID
		{
			get{ return _P_ID; }
			set
			{
				this.OnPropertyValueChange(_.P_ID, _P_ID, value);
				this._P_ID = value;
			}
		}
		/// <summary>
		/// 性别 1：男，0：女
		/// </summary>
		public decimal? GENDER
		{
			get{ return _GENDER; }
			set
			{
				this.OnPropertyValueChange(_.GENDER, _GENDER, value);
				this._GENDER = value;
			}
		}
		/// <summary>
		/// 是否启用注册完需要后台审核通过后才启用
		/// </summary>
		public decimal? IS_ENABLE
		{
			get{ return _IS_ENABLE; }
			set
			{
				this.OnPropertyValueChange(_.IS_ENABLE, _IS_ENABLE, value);
				this._IS_ENABLE = value;
			}
		}
		/// <summary>
		/// 企业代码
		/// </summary>
		public string COMPANY_CODE
		{
			get{ return _COMPANY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.COMPANY_CODE, _COMPANY_CODE, value);
				this._COMPANY_CODE = value;
			}
		}
		/// <summary>
		/// 真实姓名
		/// </summary>
		public string MANAGE_NAME
		{
			get{ return _MANAGE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.MANAGE_NAME, _MANAGE_NAME, value);
				this._MANAGE_NAME = value;
			}
		}
		/// <summary>
		/// 行政区划
		/// </summary>
		public string AREACODE
		{
			get{ return _AREACODE; }
			set
			{
				this.OnPropertyValueChange(_.AREACODE, _AREACODE, value);
				this._AREACODE = value;
			}
		}
		/// <summary>
		/// 传真
		/// </summary>
		public string ZP_FAX
		{
			get{ return _ZP_FAX; }
			set
			{
				this.OnPropertyValueChange(_.ZP_FAX, _ZP_FAX, value);
				this._ZP_FAX = value;
			}
		}
		/// <summary>
		/// 单位名称
		/// </summary>
		public string ZP_UNIT
		{
			get{ return _ZP_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.ZP_UNIT, _ZP_UNIT, value);
				this._ZP_UNIT = value;
			}
		}
		/// <summary>
		/// 单位地址
		/// </summary>
		public string ZP_ADDRESS
		{
			get{ return _ZP_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.ZP_ADDRESS, _ZP_ADDRESS, value);
				this._ZP_ADDRESS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ZP_ID
		{
			get{ return _ZP_ID; }
			set
			{
				this.OnPropertyValueChange(_.ZP_ID, _ZP_ID, value);
				this._ZP_ID = value;
			}
		}
		/// <summary>
		/// 手机号码
		/// </summary>
		public string ZP_PHONE
		{
			get{ return _ZP_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.ZP_PHONE, _ZP_PHONE, value);
				this._ZP_PHONE = value;
			}
		}
		/// <summary>
		/// 验证码
		/// </summary>
		public string CHECK_CODE
		{
			get{ return _CHECK_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CHECK_CODE, _CHECK_CODE, value);
				this._CHECK_CODE = value;
			}
		}
		/// <summary>
		/// 是否通过手机验证
		/// </summary>
		public decimal? IS_CHECK_PHONE
		{
			get{ return _IS_CHECK_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.IS_CHECK_PHONE, _IS_CHECK_PHONE, value);
				this._IS_CHECK_PHONE = value;
			}
		}
		/// <summary>
		/// 验证码有效时间
		/// </summary>
		public DateTime? EFECTIVE_TIME
		{
			get{ return _EFECTIVE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.EFECTIVE_TIME, _EFECTIVE_TIME, value);
				this._EFECTIVE_TIME = value;
			}
		}
		/// <summary>
		/// 是否审核
		/// </summary>
		public decimal? IS_AUDIT
		{
			get{ return _IS_AUDIT; }
			set
			{
				this.OnPropertyValueChange(_.IS_AUDIT, _IS_AUDIT, value);
				this._IS_AUDIT = value;
			}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public decimal? AUDIT_BY
		{
			get{ return _AUDIT_BY; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_BY, _AUDIT_BY, value);
				this._AUDIT_BY = value;
			}
		}
		/// <summary>
		/// 审核时间
		/// </summary>
		public DateTime? AUDIT_TM
		{
			get{ return _AUDIT_TM; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_TM, _AUDIT_TM, value);
				this._AUDIT_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AAAA
		{
			get{ return _AAAA; }
			set
			{
				this.OnPropertyValueChange(_.AAAA, _AAAA, value);
				this._AAAA = value;
			}
		}
		/// <summary>
		/// 用CA登陆的CA信息
		/// </summary>
		public string CA_INFO
		{
			get{ return _CA_INFO; }
			set
			{
				this.OnPropertyValueChange(_.CA_INFO, _CA_INFO, value);
				this._CA_INFO = value;
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
				_.USERNAME,
				_.PASSWORD,
				_.EMAIL,
				_.TYPE,
				_.CA_CODE,
				_.REG_TM,
				_.API_CODE,
				_.API_KEY,
				_.ROLEIDS,
				_.SESSION_ID,
				_.P_ID,
				_.GENDER,
				_.IS_ENABLE,
				_.COMPANY_CODE,
				_.MANAGE_NAME,
				_.AREACODE,
				_.ZP_FAX,
				_.ZP_UNIT,
				_.ZP_ADDRESS,
				_.ZP_ID,
				_.ZP_PHONE,
				_.CHECK_CODE,
				_.IS_CHECK_PHONE,
				_.EFECTIVE_TIME,
				_.IS_AUDIT,
				_.AUDIT_BY,
				_.AUDIT_TM,
				_.AAAA,
				_.CA_INFO,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._USERNAME,
				this._PASSWORD,
				this._EMAIL,
				this._TYPE,
				this._CA_CODE,
				this._REG_TM,
				this._API_CODE,
				this._API_KEY,
				this._ROLEIDS,
				this._SESSION_ID,
				this._P_ID,
				this._GENDER,
				this._IS_ENABLE,
				this._COMPANY_CODE,
				this._MANAGE_NAME,
				this._AREACODE,
				this._ZP_FAX,
				this._ZP_UNIT,
				this._ZP_ADDRESS,
				this._ZP_ID,
				this._ZP_PHONE,
				this._CHECK_CODE,
				this._IS_CHECK_PHONE,
				this._EFECTIVE_TIME,
				this._IS_AUDIT,
				this._AUDIT_BY,
				this._AUDIT_TM,
				this._AAAA,
				this._CA_INFO,
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
			public readonly static Field All = new Field("*", "T_USER");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_USER", "ID");
            /// <summary>
			/// 用户名
			/// </summary>
			public readonly static Field USERNAME = new Field("USERNAME", "T_USER", "用户名");
            /// <summary>
			/// 登录密码
			/// </summary>
			public readonly static Field PASSWORD = new Field("PASSWORD", "T_USER", "登录密码");
            /// <summary>
			/// Email
			/// </summary>
			public readonly static Field EMAIL = new Field("EMAIL", "T_USER", "Email");
            /// <summary>
			/// 账号类别 0:游客 1:个人用户 2:企业用户
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_USER", "账号类别 0:游客 1:个人用户 2:企业用户");
            /// <summary>
			/// CA编码
			/// </summary>
			public readonly static Field CA_CODE = new Field("CA_CODE", "T_USER", "CA编码");
            /// <summary>
			/// 注册时间
			/// </summary>
			public readonly static Field REG_TM = new Field("REG_TM", "T_USER", "注册时间");
            /// <summary>
			/// 交易平台编码
			/// </summary>
			public readonly static Field API_CODE = new Field("API_CODE", "T_USER", "交易平台编码");
            /// <summary>
			/// 交易平台密钥
			/// </summary>
			public readonly static Field API_KEY = new Field("API_KEY", "T_USER", "交易平台密钥");
            /// <summary>
			/// 用户角色ID
			/// </summary>
			public readonly static Field ROLEIDS = new Field("ROLEIDS", "T_USER", "用户角色ID");
            /// <summary>
			/// 登陆后生成的一个guid用于判断登陆状态
			/// </summary>
			public readonly static Field SESSION_ID = new Field("SESSION_ID", "T_USER", "登陆后生成的一个guid用于判断登陆状态");
            /// <summary>
			/// 父账号ID
			/// </summary>
			public readonly static Field P_ID = new Field("P_ID", "T_USER", "父账号ID");
            /// <summary>
			/// 性别 1：男，0：女
			/// </summary>
			public readonly static Field GENDER = new Field("GENDER", "T_USER", "性别 1：男，0：女");
            /// <summary>
			/// 是否启用注册完需要后台审核通过后才启用
			/// </summary>
			public readonly static Field IS_ENABLE = new Field("IS_ENABLE", "T_USER", "是否启用注册完需要后台审核通过后才启用");
            /// <summary>
			/// 企业代码
			/// </summary>
			public readonly static Field COMPANY_CODE = new Field("COMPANY_CODE", "T_USER", "企业代码");
            /// <summary>
			/// 真实姓名
			/// </summary>
			public readonly static Field MANAGE_NAME = new Field("MANAGE_NAME", "T_USER", "真实姓名");
            /// <summary>
			/// 行政区划
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "T_USER", "行政区划");
            /// <summary>
			/// 传真
			/// </summary>
			public readonly static Field ZP_FAX = new Field("ZP_FAX", "T_USER", "传真");
            /// <summary>
			/// 单位名称
			/// </summary>
			public readonly static Field ZP_UNIT = new Field("ZP_UNIT", "T_USER", "单位名称");
            /// <summary>
			/// 单位地址
			/// </summary>
			public readonly static Field ZP_ADDRESS = new Field("ZP_ADDRESS", "T_USER", "单位地址");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZP_ID = new Field("ZP_ID", "T_USER", "");
            /// <summary>
			/// 手机号码
			/// </summary>
			public readonly static Field ZP_PHONE = new Field("ZP_PHONE", "T_USER", "手机号码");
            /// <summary>
			/// 验证码
			/// </summary>
			public readonly static Field CHECK_CODE = new Field("CHECK_CODE", "T_USER", "验证码");
            /// <summary>
			/// 是否通过手机验证
			/// </summary>
			public readonly static Field IS_CHECK_PHONE = new Field("IS_CHECK_PHONE", "T_USER", "是否通过手机验证");
            /// <summary>
			/// 验证码有效时间
			/// </summary>
			public readonly static Field EFECTIVE_TIME = new Field("EFECTIVE_TIME", "T_USER", "验证码有效时间");
            /// <summary>
			/// 是否审核
			/// </summary>
			public readonly static Field IS_AUDIT = new Field("IS_AUDIT", "T_USER", "是否审核");
            /// <summary>
			/// 审核人
			/// </summary>
			public readonly static Field AUDIT_BY = new Field("AUDIT_BY", "T_USER", "审核人");
            /// <summary>
			/// 审核时间
			/// </summary>
			public readonly static Field AUDIT_TM = new Field("AUDIT_TM", "T_USER", "审核时间");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AAAA = new Field("AAAA", "T_USER", "");
            /// <summary>
			/// 用CA登陆的CA信息
			/// </summary>
			public readonly static Field CA_INFO = new Field("CA_INFO", "T_USER",DbType.AnsiString, null, "用CA登陆的CA信息");
        }
        #endregion
	}
}