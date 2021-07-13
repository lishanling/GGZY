using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_CA_ACCESS。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_CA_ACCESS")]
    [Serializable]
    public partial class T_CA_ACCESS : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _SQDW;
		private string _SQDW_CODE;
		private string _CPMC;
		private string _CPGS;
		private string _CPGS_CODE;
		private string _LXR_NAME;
		private string _LXR_PHONE;
		private string _LXR_EMAIL;
		private string _CA_FILES;
		private string _CA_TEST_FILES;
		private string _OSCP;
		private string _CRL_TYPE;
		private string _HTTP_URL;
		private string _LDAP_URL;
		private string _LDAP_PORT;
		private string _LDAP_ROOT;
		private string _CRL_PATH;
		private string _CRL_ATTRIBUTES;
		private string _LDAP_NAME;
		private string _LDAP_PWD;
		private string _CLMC;
		private DateTime? _CREATE_TM;
		private string _NO;
		private decimal? _STATUS;
		private string _STOP_REMARK;
		private string _STOP_FILE;
		private DateTime? _STOP_TM;
		private decimal? _CLHY_STATUS;
		private string _CLHY_REMARK;
		private string _CLHY_PEOPLE;
		private DateTime? _CLHY_TM;
		private decimal? _ZGDW_STATUS;
		private string _ZGDW_REMARK;
		private string _ZGDW_PEOPLE;
		private DateTime? _ZGDW_TM;
		private string _CLHY_FILES;
		private string _ZGDW_FILES;
		private decimal? _DJCG_STATUS;
		private string _DJCG_REMARK;
		private string _DJCG_PEOPLE;
		private DateTime? _DJCG_TM;
		private string _DJCG_FILES;

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
		/// 申请单位
		/// </summary>
		public string SQDW
		{
			get{ return _SQDW; }
			set
			{
				this.OnPropertyValueChange(_.SQDW, _SQDW, value);
				this._SQDW = value;
			}
		}
		/// <summary>
		/// 申请单位_社会统一代码
		/// </summary>
		public string SQDW_CODE
		{
			get{ return _SQDW_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SQDW_CODE, _SQDW_CODE, value);
				this._SQDW_CODE = value;
			}
		}
		/// <summary>
		/// 接入产品名称
		/// </summary>
		public string CPMC
		{
			get{ return _CPMC; }
			set
			{
				this.OnPropertyValueChange(_.CPMC, _CPMC, value);
				this._CPMC = value;
			}
		}
		/// <summary>
		/// 接入产品公司
		/// </summary>
		public string CPGS
		{
			get{ return _CPGS; }
			set
			{
				this.OnPropertyValueChange(_.CPGS, _CPGS, value);
				this._CPGS = value;
			}
		}
		/// <summary>
		/// 产品公司_社会统一代码
		/// </summary>
		public string CPGS_CODE
		{
			get{ return _CPGS_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CPGS_CODE, _CPGS_CODE, value);
				this._CPGS_CODE = value;
			}
		}
		/// <summary>
		/// 联系人姓名
		/// </summary>
		public string LXR_NAME
		{
			get{ return _LXR_NAME; }
			set
			{
				this.OnPropertyValueChange(_.LXR_NAME, _LXR_NAME, value);
				this._LXR_NAME = value;
			}
		}
		/// <summary>
		/// 联系人电话
		/// </summary>
		public string LXR_PHONE
		{
			get{ return _LXR_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.LXR_PHONE, _LXR_PHONE, value);
				this._LXR_PHONE = value;
			}
		}
		/// <summary>
		/// 联系人邮箱
		/// </summary>
		public string LXR_EMAIL
		{
			get{ return _LXR_EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.LXR_EMAIL, _LXR_EMAIL, value);
				this._LXR_EMAIL = value;
			}
		}
		/// <summary>
		/// CA证书
		/// </summary>
		public string CA_FILES
		{
			get{ return _CA_FILES; }
			set
			{
				this.OnPropertyValueChange(_.CA_FILES, _CA_FILES, value);
				this._CA_FILES = value;
			}
		}
		/// <summary>
		/// CA测试证书
		/// </summary>
		public string CA_TEST_FILES
		{
			get{ return _CA_TEST_FILES; }
			set
			{
				this.OnPropertyValueChange(_.CA_TEST_FILES, _CA_TEST_FILES, value);
				this._CA_TEST_FILES = value;
			}
		}
		/// <summary>
		/// OSCP地址
		/// </summary>
		public string OSCP
		{
			get{ return _OSCP; }
			set
			{
				this.OnPropertyValueChange(_.OSCP, _OSCP, value);
				this._OSCP = value;
			}
		}
		/// <summary>
		/// CRL发布方式
		/// </summary>
		public string CRL_TYPE
		{
			get{ return _CRL_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.CRL_TYPE, _CRL_TYPE, value);
				this._CRL_TYPE = value;
			}
		}
		/// <summary>
		/// HTTP发布地址
		/// </summary>
		public string HTTP_URL
		{
			get{ return _HTTP_URL; }
			set
			{
				this.OnPropertyValueChange(_.HTTP_URL, _HTTP_URL, value);
				this._HTTP_URL = value;
			}
		}
		/// <summary>
		/// LDAP服务器地址
		/// </summary>
		public string LDAP_URL
		{
			get{ return _LDAP_URL; }
			set
			{
				this.OnPropertyValueChange(_.LDAP_URL, _LDAP_URL, value);
				this._LDAP_URL = value;
			}
		}
		/// <summary>
		/// LDAP端口
		/// </summary>
		public string LDAP_PORT
		{
			get{ return _LDAP_PORT; }
			set
			{
				this.OnPropertyValueChange(_.LDAP_PORT, _LDAP_PORT, value);
				this._LDAP_PORT = value;
			}
		}
		/// <summary>
		/// LDAP根路径
		/// </summary>
		public string LDAP_ROOT
		{
			get{ return _LDAP_ROOT; }
			set
			{
				this.OnPropertyValueChange(_.LDAP_ROOT, _LDAP_ROOT, value);
				this._LDAP_ROOT = value;
			}
		}
		/// <summary>
		/// CRL路径
		/// </summary>
		public string CRL_PATH
		{
			get{ return _CRL_PATH; }
			set
			{
				this.OnPropertyValueChange(_.CRL_PATH, _CRL_PATH, value);
				this._CRL_PATH = value;
			}
		}
		/// <summary>
		/// CRL属性名
		/// </summary>
		public string CRL_ATTRIBUTES
		{
			get{ return _CRL_ATTRIBUTES; }
			set
			{
				this.OnPropertyValueChange(_.CRL_ATTRIBUTES, _CRL_ATTRIBUTES, value);
				this._CRL_ATTRIBUTES = value;
			}
		}
		/// <summary>
		/// LDAP用户名
		/// </summary>
		public string LDAP_NAME
		{
			get{ return _LDAP_NAME; }
			set
			{
				this.OnPropertyValueChange(_.LDAP_NAME, _LDAP_NAME, value);
				this._LDAP_NAME = value;
			}
		}
		/// <summary>
		/// LDAP密码
		/// </summary>
		public string LDAP_PWD
		{
			get{ return _LDAP_PWD; }
			set
			{
				this.OnPropertyValueChange(_.LDAP_PWD, _LDAP_PWD, value);
				this._LDAP_PWD = value;
			}
		}
		/// <summary>
		/// 策略名称
		/// </summary>
		public string CLMC
		{
			get{ return _CLMC; }
			set
			{
				this.OnPropertyValueChange(_.CLMC, _CLMC, value);
				this._CLMC = value;
			}
		}
		/// <summary>
		/// 
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
		/// 申请单号 无用
		/// </summary>
		public string NO
		{
			get{ return _NO; }
			set
			{
				this.OnPropertyValueChange(_.NO, _NO, value);
				this._NO = value;
			}
		}
		/// <summary>
		/// 对接状态 对接中、对接暂停，对接完成
		/// </summary>
		public decimal? STATUS
		{
			get{ return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 对接暂停说明
		/// </summary>
		public string STOP_REMARK
		{
			get{ return _STOP_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.STOP_REMARK, _STOP_REMARK, value);
				this._STOP_REMARK = value;
			}
		}
		/// <summary>
		/// 对接暂停附件
		/// </summary>
		public string STOP_FILE
		{
			get{ return _STOP_FILE; }
			set
			{
				this.OnPropertyValueChange(_.STOP_FILE, _STOP_FILE, value);
				this._STOP_FILE = value;
			}
		}
		/// <summary>
		/// 对接暂停时间
		/// </summary>
		public DateTime? STOP_TM
		{
			get{ return _STOP_TM; }
			set
			{
				this.OnPropertyValueChange(_.STOP_TM, _STOP_TM, value);
				this._STOP_TM = value;
			}
		}
		/// <summary>
		/// 材料核验状态 通过不通过
		/// </summary>
		public decimal? CLHY_STATUS
		{
			get{ return _CLHY_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.CLHY_STATUS, _CLHY_STATUS, value);
				this._CLHY_STATUS = value;
			}
		}
		/// <summary>
		/// 材料核验意见
		/// </summary>
		public string CLHY_REMARK
		{
			get{ return _CLHY_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.CLHY_REMARK, _CLHY_REMARK, value);
				this._CLHY_REMARK = value;
			}
		}
		/// <summary>
		/// 材料核验人
		/// </summary>
		public string CLHY_PEOPLE
		{
			get{ return _CLHY_PEOPLE; }
			set
			{
				this.OnPropertyValueChange(_.CLHY_PEOPLE, _CLHY_PEOPLE, value);
				this._CLHY_PEOPLE = value;
			}
		}
		/// <summary>
		/// 材料核验提交时间
		/// </summary>
		public DateTime? CLHY_TM
		{
			get{ return _CLHY_TM; }
			set
			{
				this.OnPropertyValueChange(_.CLHY_TM, _CLHY_TM, value);
				this._CLHY_TM = value;
			}
		}
		/// <summary>
		/// 主管单位状态 通过不通过
		/// </summary>
		public decimal? ZGDW_STATUS
		{
			get{ return _ZGDW_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.ZGDW_STATUS, _ZGDW_STATUS, value);
				this._ZGDW_STATUS = value;
			}
		}
		/// <summary>
		/// 主管单位意见
		/// </summary>
		public string ZGDW_REMARK
		{
			get{ return _ZGDW_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.ZGDW_REMARK, _ZGDW_REMARK, value);
				this._ZGDW_REMARK = value;
			}
		}
		/// <summary>
		/// 主管单位人
		/// </summary>
		public string ZGDW_PEOPLE
		{
			get{ return _ZGDW_PEOPLE; }
			set
			{
				this.OnPropertyValueChange(_.ZGDW_PEOPLE, _ZGDW_PEOPLE, value);
				this._ZGDW_PEOPLE = value;
			}
		}
		/// <summary>
		/// 主管单位提交时间
		/// </summary>
		public DateTime? ZGDW_TM
		{
			get{ return _ZGDW_TM; }
			set
			{
				this.OnPropertyValueChange(_.ZGDW_TM, _ZGDW_TM, value);
				this._ZGDW_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLHY_FILES
		{
			get{ return _CLHY_FILES; }
			set
			{
				this.OnPropertyValueChange(_.CLHY_FILES, _CLHY_FILES, value);
				this._CLHY_FILES = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGDW_FILES
		{
			get{ return _ZGDW_FILES; }
			set
			{
				this.OnPropertyValueChange(_.ZGDW_FILES, _ZGDW_FILES, value);
				this._ZGDW_FILES = value;
			}
		}
		/// <summary>
		/// 对接成功证明状态 通过不通过
		/// </summary>
		public decimal? DJCG_STATUS
		{
			get{ return _DJCG_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.DJCG_STATUS, _DJCG_STATUS, value);
				this._DJCG_STATUS = value;
			}
		}
		/// <summary>
		/// 对接成功证明意见
		/// </summary>
		public string DJCG_REMARK
		{
			get{ return _DJCG_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.DJCG_REMARK, _DJCG_REMARK, value);
				this._DJCG_REMARK = value;
			}
		}
		/// <summary>
		/// 对接成功证明人
		/// </summary>
		public string DJCG_PEOPLE
		{
			get{ return _DJCG_PEOPLE; }
			set
			{
				this.OnPropertyValueChange(_.DJCG_PEOPLE, _DJCG_PEOPLE, value);
				this._DJCG_PEOPLE = value;
			}
		}
		/// <summary>
		/// 对接成功证明提交时间
		/// </summary>
		public DateTime? DJCG_TM
		{
			get{ return _DJCG_TM; }
			set
			{
				this.OnPropertyValueChange(_.DJCG_TM, _DJCG_TM, value);
				this._DJCG_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DJCG_FILES
		{
			get{ return _DJCG_FILES; }
			set
			{
				this.OnPropertyValueChange(_.DJCG_FILES, _DJCG_FILES, value);
				this._DJCG_FILES = value;
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
				_.SQDW,
				_.SQDW_CODE,
				_.CPMC,
				_.CPGS,
				_.CPGS_CODE,
				_.LXR_NAME,
				_.LXR_PHONE,
				_.LXR_EMAIL,
				_.CA_FILES,
				_.CA_TEST_FILES,
				_.OSCP,
				_.CRL_TYPE,
				_.HTTP_URL,
				_.LDAP_URL,
				_.LDAP_PORT,
				_.LDAP_ROOT,
				_.CRL_PATH,
				_.CRL_ATTRIBUTES,
				_.LDAP_NAME,
				_.LDAP_PWD,
				_.CLMC,
				_.CREATE_TM,
				_.NO,
				_.STATUS,
				_.STOP_REMARK,
				_.STOP_FILE,
				_.STOP_TM,
				_.CLHY_STATUS,
				_.CLHY_REMARK,
				_.CLHY_PEOPLE,
				_.CLHY_TM,
				_.ZGDW_STATUS,
				_.ZGDW_REMARK,
				_.ZGDW_PEOPLE,
				_.ZGDW_TM,
				_.CLHY_FILES,
				_.ZGDW_FILES,
				_.DJCG_STATUS,
				_.DJCG_REMARK,
				_.DJCG_PEOPLE,
				_.DJCG_TM,
				_.DJCG_FILES,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._SQDW,
				this._SQDW_CODE,
				this._CPMC,
				this._CPGS,
				this._CPGS_CODE,
				this._LXR_NAME,
				this._LXR_PHONE,
				this._LXR_EMAIL,
				this._CA_FILES,
				this._CA_TEST_FILES,
				this._OSCP,
				this._CRL_TYPE,
				this._HTTP_URL,
				this._LDAP_URL,
				this._LDAP_PORT,
				this._LDAP_ROOT,
				this._CRL_PATH,
				this._CRL_ATTRIBUTES,
				this._LDAP_NAME,
				this._LDAP_PWD,
				this._CLMC,
				this._CREATE_TM,
				this._NO,
				this._STATUS,
				this._STOP_REMARK,
				this._STOP_FILE,
				this._STOP_TM,
				this._CLHY_STATUS,
				this._CLHY_REMARK,
				this._CLHY_PEOPLE,
				this._CLHY_TM,
				this._ZGDW_STATUS,
				this._ZGDW_REMARK,
				this._ZGDW_PEOPLE,
				this._ZGDW_TM,
				this._CLHY_FILES,
				this._ZGDW_FILES,
				this._DJCG_STATUS,
				this._DJCG_REMARK,
				this._DJCG_PEOPLE,
				this._DJCG_TM,
				this._DJCG_FILES,
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
			public readonly static Field All = new Field("*", "T_CA_ACCESS");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_CA_ACCESS", "ID");
            /// <summary>
			/// 申请单位
			/// </summary>
			public readonly static Field SQDW = new Field("SQDW", "T_CA_ACCESS", "申请单位");
            /// <summary>
			/// 申请单位_社会统一代码
			/// </summary>
			public readonly static Field SQDW_CODE = new Field("SQDW_CODE", "T_CA_ACCESS", "申请单位_社会统一代码");
            /// <summary>
			/// 接入产品名称
			/// </summary>
			public readonly static Field CPMC = new Field("CPMC", "T_CA_ACCESS", "接入产品名称");
            /// <summary>
			/// 接入产品公司
			/// </summary>
			public readonly static Field CPGS = new Field("CPGS", "T_CA_ACCESS", "接入产品公司");
            /// <summary>
			/// 产品公司_社会统一代码
			/// </summary>
			public readonly static Field CPGS_CODE = new Field("CPGS_CODE", "T_CA_ACCESS", "产品公司_社会统一代码");
            /// <summary>
			/// 联系人姓名
			/// </summary>
			public readonly static Field LXR_NAME = new Field("LXR_NAME", "T_CA_ACCESS", "联系人姓名");
            /// <summary>
			/// 联系人电话
			/// </summary>
			public readonly static Field LXR_PHONE = new Field("LXR_PHONE", "T_CA_ACCESS", "联系人电话");
            /// <summary>
			/// 联系人邮箱
			/// </summary>
			public readonly static Field LXR_EMAIL = new Field("LXR_EMAIL", "T_CA_ACCESS", "联系人邮箱");
            /// <summary>
			/// CA证书
			/// </summary>
			public readonly static Field CA_FILES = new Field("CA_FILES", "T_CA_ACCESS", "CA证书");
            /// <summary>
			/// CA测试证书
			/// </summary>
			public readonly static Field CA_TEST_FILES = new Field("CA_TEST_FILES", "T_CA_ACCESS", "CA测试证书");
            /// <summary>
			/// OSCP地址
			/// </summary>
			public readonly static Field OSCP = new Field("OSCP", "T_CA_ACCESS", "OSCP地址");
            /// <summary>
			/// CRL发布方式
			/// </summary>
			public readonly static Field CRL_TYPE = new Field("CRL_TYPE", "T_CA_ACCESS", "CRL发布方式");
            /// <summary>
			/// HTTP发布地址
			/// </summary>
			public readonly static Field HTTP_URL = new Field("HTTP_URL", "T_CA_ACCESS", "HTTP发布地址");
            /// <summary>
			/// LDAP服务器地址
			/// </summary>
			public readonly static Field LDAP_URL = new Field("LDAP_URL", "T_CA_ACCESS", "LDAP服务器地址");
            /// <summary>
			/// LDAP端口
			/// </summary>
			public readonly static Field LDAP_PORT = new Field("LDAP_PORT", "T_CA_ACCESS", "LDAP端口");
            /// <summary>
			/// LDAP根路径
			/// </summary>
			public readonly static Field LDAP_ROOT = new Field("LDAP_ROOT", "T_CA_ACCESS", "LDAP根路径");
            /// <summary>
			/// CRL路径
			/// </summary>
			public readonly static Field CRL_PATH = new Field("CRL_PATH", "T_CA_ACCESS", "CRL路径");
            /// <summary>
			/// CRL属性名
			/// </summary>
			public readonly static Field CRL_ATTRIBUTES = new Field("CRL_ATTRIBUTES", "T_CA_ACCESS", "CRL属性名");
            /// <summary>
			/// LDAP用户名
			/// </summary>
			public readonly static Field LDAP_NAME = new Field("LDAP_NAME", "T_CA_ACCESS", "LDAP用户名");
            /// <summary>
			/// LDAP密码
			/// </summary>
			public readonly static Field LDAP_PWD = new Field("LDAP_PWD", "T_CA_ACCESS", "LDAP密码");
            /// <summary>
			/// 策略名称
			/// </summary>
			public readonly static Field CLMC = new Field("CLMC", "T_CA_ACCESS", "策略名称");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_CA_ACCESS", "");
            /// <summary>
			/// 申请单号 无用
			/// </summary>
			public readonly static Field NO = new Field("NO", "T_CA_ACCESS", "申请单号 无用");
            /// <summary>
			/// 对接状态 对接中、对接暂停，对接完成
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "T_CA_ACCESS", "对接状态 对接中、对接暂停，对接完成");
            /// <summary>
			/// 对接暂停说明
			/// </summary>
			public readonly static Field STOP_REMARK = new Field("STOP_REMARK", "T_CA_ACCESS", "对接暂停说明");
            /// <summary>
			/// 对接暂停附件
			/// </summary>
			public readonly static Field STOP_FILE = new Field("STOP_FILE", "T_CA_ACCESS", "对接暂停附件");
            /// <summary>
			/// 对接暂停时间
			/// </summary>
			public readonly static Field STOP_TM = new Field("STOP_TM", "T_CA_ACCESS", "对接暂停时间");
            /// <summary>
			/// 材料核验状态 通过不通过
			/// </summary>
			public readonly static Field CLHY_STATUS = new Field("CLHY_STATUS", "T_CA_ACCESS", "材料核验状态 通过不通过");
            /// <summary>
			/// 材料核验意见
			/// </summary>
			public readonly static Field CLHY_REMARK = new Field("CLHY_REMARK", "T_CA_ACCESS", "材料核验意见");
            /// <summary>
			/// 材料核验人
			/// </summary>
			public readonly static Field CLHY_PEOPLE = new Field("CLHY_PEOPLE", "T_CA_ACCESS", "材料核验人");
            /// <summary>
			/// 材料核验提交时间
			/// </summary>
			public readonly static Field CLHY_TM = new Field("CLHY_TM", "T_CA_ACCESS", "材料核验提交时间");
            /// <summary>
			/// 主管单位状态 通过不通过
			/// </summary>
			public readonly static Field ZGDW_STATUS = new Field("ZGDW_STATUS", "T_CA_ACCESS", "主管单位状态 通过不通过");
            /// <summary>
			/// 主管单位意见
			/// </summary>
			public readonly static Field ZGDW_REMARK = new Field("ZGDW_REMARK", "T_CA_ACCESS", "主管单位意见");
            /// <summary>
			/// 主管单位人
			/// </summary>
			public readonly static Field ZGDW_PEOPLE = new Field("ZGDW_PEOPLE", "T_CA_ACCESS", "主管单位人");
            /// <summary>
			/// 主管单位提交时间
			/// </summary>
			public readonly static Field ZGDW_TM = new Field("ZGDW_TM", "T_CA_ACCESS", "主管单位提交时间");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CLHY_FILES = new Field("CLHY_FILES", "T_CA_ACCESS", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZGDW_FILES = new Field("ZGDW_FILES", "T_CA_ACCESS", "");
            /// <summary>
			/// 对接成功证明状态 通过不通过
			/// </summary>
			public readonly static Field DJCG_STATUS = new Field("DJCG_STATUS", "T_CA_ACCESS", "对接成功证明状态 通过不通过");
            /// <summary>
			/// 对接成功证明意见
			/// </summary>
			public readonly static Field DJCG_REMARK = new Field("DJCG_REMARK", "T_CA_ACCESS", "对接成功证明意见");
            /// <summary>
			/// 对接成功证明人
			/// </summary>
			public readonly static Field DJCG_PEOPLE = new Field("DJCG_PEOPLE", "T_CA_ACCESS", "对接成功证明人");
            /// <summary>
			/// 对接成功证明提交时间
			/// </summary>
			public readonly static Field DJCG_TM = new Field("DJCG_TM", "T_CA_ACCESS", "对接成功证明提交时间");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DJCG_FILES = new Field("DJCG_FILES", "T_CA_ACCESS", "");
        }
        #endregion
	}
}