using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_USER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_USER")]
    [Serializable]
    public partial class T_USER : JdEntity
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
		private string _TELPHONE;
		private string _TOKEN;
		private DateTime? _TOKEN_EXPTIME;
		private string _HY_TYPE;
		private string _ACODES;
		private decimal? _DEPARTID;
		private DateTime? _CREATETIME;
		private decimal? _CREATEID;
		private string _PHONE;
		private string _JOB;
		private string _WORKSTATION;
		private string _DEPARTMENT;
		private decimal? _ISSENDMSG;
		private decimal? _ISPUSHMSG;
		private string _OPERATION_DEPART;
		private decimal? _ISSENDMSG_BJ;
		private decimal? _IS_SEND_MSG;

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
		/// 账号类别 0:工作台用户 1:个人用户 2:实名个人用户 3:报建备案用户
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
		/// 性别
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
		/// 手机号码
		/// </summary>
		public string TELPHONE
		{
			get{ return _TELPHONE; }
			set
			{
				this.OnPropertyValueChange(_.TELPHONE, _TELPHONE, value);
				this._TELPHONE = value;
			}
		}
		/// <summary>
		/// 激活码
		/// </summary>
		public string TOKEN
		{
			get{ return _TOKEN; }
			set
			{
				this.OnPropertyValueChange(_.TOKEN, _TOKEN, value);
				this._TOKEN = value;
			}
		}
		/// <summary>
		/// 激活码过期时间
		/// </summary>
		public DateTime? TOKEN_EXPTIME
		{
			get{ return _TOKEN_EXPTIME; }
			set
			{
				this.OnPropertyValueChange(_.TOKEN_EXPTIME, _TOKEN_EXPTIME, value);
				this._TOKEN_EXPTIME = value;
			}
		}
		/// <summary>
		/// 账号行业类型，多个用“,”分割
		/// </summary>
		public string HY_TYPE
		{
			get{ return _HY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.HY_TYPE, _HY_TYPE, value);
				this._HY_TYPE = value;
			}
		}
		/// <summary>
		/// 管理行政区划，多个用“,”分割
		/// </summary>
		public string ACODES
		{
			get{ return _ACODES; }
			set
			{
				this.OnPropertyValueChange(_.ACODES, _ACODES, value);
				this._ACODES = value;
			}
		}
		/// <summary>
		/// 组织机构ID
		/// </summary>
		public decimal? DEPARTID
		{
			get{ return _DEPARTID; }
			set
			{
				this.OnPropertyValueChange(_.DEPARTID, _DEPARTID, value);
				this._DEPARTID = value;
			}
		}
		/// <summary>
		/// 后台创建时间
		/// </summary>
		public DateTime? CREATETIME
		{
			get{ return _CREATETIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATETIME, _CREATETIME, value);
				this._CREATETIME = value;
			}
		}
		/// <summary>
		/// 后台创建人
		/// </summary>
		public decimal? CREATEID
		{
			get{ return _CREATEID; }
			set
			{
				this.OnPropertyValueChange(_.CREATEID, _CREATEID, value);
				this._CREATEID = value;
			}
		}
		/// <summary>
		/// 电话号码
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
		/// 单位
		/// </summary>
		public string WORKSTATION
		{
			get{ return _WORKSTATION; }
			set
			{
				this.OnPropertyValueChange(_.WORKSTATION, _WORKSTATION, value);
				this._WORKSTATION = value;
			}
		}
		/// <summary>
		/// 可查看备案审查部门
		/// </summary>
		public string DEPARTMENT
		{
			get{ return _DEPARTMENT; }
			set
			{
				this.OnPropertyValueChange(_.DEPARTMENT, _DEPARTMENT, value);
				this._DEPARTMENT = value;
			}
		}
		/// <summary>
		/// 是否发送项目异常短信
		/// </summary>
		public decimal? ISSENDMSG
		{
			get{ return _ISSENDMSG; }
			set
			{
				this.OnPropertyValueChange(_.ISSENDMSG, _ISSENDMSG, value);
				this._ISSENDMSG = value;
			}
		}
		/// <summary>
		/// 是否推送项目异常通知
		/// </summary>
		public decimal? ISPUSHMSG
		{
			get{ return _ISPUSHMSG; }
			set
			{
				this.OnPropertyValueChange(_.ISPUSHMSG, _ISPUSHMSG, value);
				this._ISPUSHMSG = value;
			}
		}
		/// <summary>
		/// 审核部门
		/// </summary>
		public string OPERATION_DEPART
		{
			get{ return _OPERATION_DEPART; }
			set
			{
				this.OnPropertyValueChange(_.OPERATION_DEPART, _OPERATION_DEPART, value);
				this._OPERATION_DEPART = value;
			}
		}
		/// <summary>
		/// 是否发送报建提醒短信
		/// </summary>
		public decimal? ISSENDMSG_BJ
		{
			get{ return _ISSENDMSG_BJ; }
			set
			{
				this.OnPropertyValueChange(_.ISSENDMSG_BJ, _ISSENDMSG_BJ, value);
				this._ISSENDMSG_BJ = value;
			}
		}
		/// <summary>
		/// 是否启用发送短信
		/// </summary>
		public decimal? IS_SEND_MSG
		{
			get{ return _IS_SEND_MSG; }
			set
			{
				this.OnPropertyValueChange(_.IS_SEND_MSG, _IS_SEND_MSG, value);
				this._IS_SEND_MSG = value;
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
				_.TELPHONE,
				_.TOKEN,
				_.TOKEN_EXPTIME,
				_.HY_TYPE,
				_.ACODES,
				_.DEPARTID,
				_.CREATETIME,
				_.CREATEID,
				_.PHONE,
				_.JOB,
				_.WORKSTATION,
				_.DEPARTMENT,
				_.ISSENDMSG,
				_.ISPUSHMSG,
				_.OPERATION_DEPART,
				_.ISSENDMSG_BJ,
				_.IS_SEND_MSG,
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
				this._TELPHONE,
				this._TOKEN,
				this._TOKEN_EXPTIME,
				this._HY_TYPE,
				this._ACODES,
				this._DEPARTID,
				this._CREATETIME,
				this._CREATEID,
				this._PHONE,
				this._JOB,
				this._WORKSTATION,
				this._DEPARTMENT,
				this._ISSENDMSG,
				this._ISPUSHMSG,
				this._OPERATION_DEPART,
				this._ISSENDMSG_BJ,
				this._IS_SEND_MSG,
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
			/// 账号类别 0:工作台用户 1:个人用户 2:实名个人用户 3:报建备案用户
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_USER", "账号类别 0:工作台用户 1:个人用户 2:实名个人用户 3:报建备案用户");
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
			/// 性别
			/// </summary>
			public readonly static Field GENDER = new Field("GENDER", "T_USER", "性别");
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
			/// 手机号码
			/// </summary>
			public readonly static Field TELPHONE = new Field("TELPHONE", "T_USER", "手机号码");
            /// <summary>
			/// 激活码
			/// </summary>
			public readonly static Field TOKEN = new Field("TOKEN", "T_USER", "激活码");
            /// <summary>
			/// 激活码过期时间
			/// </summary>
			public readonly static Field TOKEN_EXPTIME = new Field("TOKEN_EXPTIME", "T_USER", "激活码过期时间");
            /// <summary>
			/// 账号行业类型，多个用“,”分割
			/// </summary>
			public readonly static Field HY_TYPE = new Field("HY_TYPE", "T_USER", "账号行业类型，多个用“,”分割");
            /// <summary>
			/// 管理行政区划，多个用“,”分割
			/// </summary>
			public readonly static Field ACODES = new Field("ACODES", "T_USER", "管理行政区划，多个用“,”分割");
            /// <summary>
			/// 组织机构ID
			/// </summary>
			public readonly static Field DEPARTID = new Field("DEPARTID", "T_USER", "组织机构ID");
            /// <summary>
			/// 后台创建时间
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "T_USER", "后台创建时间");
            /// <summary>
			/// 后台创建人
			/// </summary>
			public readonly static Field CREATEID = new Field("CREATEID", "T_USER", "后台创建人");
            /// <summary>
			/// 电话号码
			/// </summary>
			public readonly static Field PHONE = new Field("PHONE", "T_USER", "电话号码");
            /// <summary>
			/// 职务
			/// </summary>
			public readonly static Field JOB = new Field("JOB", "T_USER", "职务");
            /// <summary>
			/// 单位
			/// </summary>
			public readonly static Field WORKSTATION = new Field("WORKSTATION", "T_USER", "单位");
            /// <summary>
			/// 可查看备案审查部门
			/// </summary>
			public readonly static Field DEPARTMENT = new Field("DEPARTMENT", "T_USER", "可查看备案审查部门");
            /// <summary>
			/// 是否发送项目异常短信
			/// </summary>
			public readonly static Field ISSENDMSG = new Field("ISSENDMSG", "T_USER", "是否发送项目异常短信");
            /// <summary>
			/// 是否推送项目异常通知
			/// </summary>
			public readonly static Field ISPUSHMSG = new Field("ISPUSHMSG", "T_USER", "是否推送项目异常通知");
            /// <summary>
			/// 审核部门
			/// </summary>
			public readonly static Field OPERATION_DEPART = new Field("OPERATION_DEPART", "T_USER", "审核部门");
            /// <summary>
			/// 是否发送报建提醒短信
			/// </summary>
			public readonly static Field ISSENDMSG_BJ = new Field("ISSENDMSG_BJ", "T_USER", "是否发送报建提醒短信");
            /// <summary>
			/// 是否启用发送短信
			/// </summary>
			public readonly static Field IS_SEND_MSG = new Field("IS_SEND_MSG", "T_USER", "是否启用发送短信");
        }
        #endregion
	}
}