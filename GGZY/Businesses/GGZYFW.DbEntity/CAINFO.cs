using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类CAINFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("CAINFO")]
    [Serializable]
    public partial class CAINFO : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _SGD_GET_CERT_VERSION;
		private string _SGD_GET_CERT_SERIAL;
		private string _SGD_GET_CERT_SIGNALG;
		private string _SGD_GET_CERT_ISSUER_C;
		private string _SGD_GET_CERT_ISSUER_O;
		private string _SGD_GET_CERT_ISSUER_OU;
		private string _SGD_GET_CERT_ISSUER_S;
		private string _SGD_GET_CERT_ISSUER_CN;
		private string _SGD_GET_CERT_ISSUER_L;
		private string _SGD_GET_CERT_ISSUER_E;
		private string _SGD_GET_CERT_NOTBEFORE;
		private string _SGD_GET_CERT_AFTER;
		private string _SGD_GET_CERT_SUBJECT_C;
		private string _SGD_GET_CERT_SUBJECT_O;
		private string _SGD_GET_CERT_SUBJECT_OU;
		private string _SGD_GET_CERT_SUBJECT_S;
		private string _SGD_GET_CERT_SUBJECT_CN;
		private string _SGD_GET_CERT_SUBJECT_L;
		private string _SGD_GET_CERT_SUBJECT_E;
		private string _SGD_GET_CERT_ISSUER_DN;
		private string _SGD_GET_CERT_SUBJECT_DN;
		private string _SGD_GET_CERT_DER_PUBKEY;
		private string _SGD_GET_CERT_DER_EXTENSIONS;
		private string _SGD_EXT_AUTHORITYKEYIDENTIFIER;
		private string _SGD_EXT_SUBJECTKEYIDENTIFIER;
		private string _SGD_EXT_KEYUSAGE;
		private string _SGD_EXT_PRIVATEKEYUSAGEPERIO;
		private string _SGD_EXT_CERTIFICATEPOLICIES;
		private string _SGD_EXT_POLICYMAPPINGS;
		private string _SGD_EXT_BASICCONSTRAINTS;
		private string _SGD_EXT_POLICYCONSTRAINTS;
		private string _SGD_EXT_EXTKEYUSAGE;
		private string _SGD_EXT_CRLDISTRIBUTIONPO;
		private string _SGD_EXT_NETSCAPE_CERT_TYPE;
		private string _SGD_EXT_CERT_UNIQUEID;
		private string _SGD_EXT_IDENTIFYCARDNUMBER;
		private string _SGD_EXT_INURANCENUMBER;
		private string _SGD_EXT_ICREGISTRATIONNUMBER;
		private string _SGD_EXT_ORGANIZATIONCODE;
		private string _SGD_EXT_TAXATIONNUMBER;
		private DateTime? _LOGIN_TM;
		private decimal? _USER_ID;

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
		/// 证书版本
		/// </summary>
		public string SGD_GET_CERT_VERSION
		{
			get{ return _SGD_GET_CERT_VERSION; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_VERSION, _SGD_GET_CERT_VERSION, value);
				this._SGD_GET_CERT_VERSION = value;
			}
		}
		/// <summary>
		/// 证书序列号
		/// </summary>
		public string SGD_GET_CERT_SERIAL
		{
			get{ return _SGD_GET_CERT_SERIAL; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_SERIAL, _SGD_GET_CERT_SERIAL, value);
				this._SGD_GET_CERT_SERIAL = value;
			}
		}
		/// <summary>
		/// 证书签名算法标识
		/// </summary>
		public string SGD_GET_CERT_SIGNALG
		{
			get{ return _SGD_GET_CERT_SIGNALG; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_SIGNALG, _SGD_GET_CERT_SIGNALG, value);
				this._SGD_GET_CERT_SIGNALG = value;
			}
		}
		/// <summary>
		/// 证书颁发者国家(C)
		/// </summary>
		public string SGD_GET_CERT_ISSUER_C
		{
			get{ return _SGD_GET_CERT_ISSUER_C; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_ISSUER_C, _SGD_GET_CERT_ISSUER_C, value);
				this._SGD_GET_CERT_ISSUER_C = value;
			}
		}
		/// <summary>
		/// 证书颁发者组织名(O)
		/// </summary>
		public string SGD_GET_CERT_ISSUER_O
		{
			get{ return _SGD_GET_CERT_ISSUER_O; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_ISSUER_O, _SGD_GET_CERT_ISSUER_O, value);
				this._SGD_GET_CERT_ISSUER_O = value;
			}
		}
		/// <summary>
		/// 证书颁发者部门名(OU)
		/// </summary>
		public string SGD_GET_CERT_ISSUER_OU
		{
			get{ return _SGD_GET_CERT_ISSUER_OU; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_ISSUER_OU, _SGD_GET_CERT_ISSUER_OU, value);
				this._SGD_GET_CERT_ISSUER_OU = value;
			}
		}
		/// <summary>
		/// 证书颁发者所在的省、自治区、直辖市(S)
		/// </summary>
		public string SGD_GET_CERT_ISSUER_S
		{
			get{ return _SGD_GET_CERT_ISSUER_S; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_ISSUER_S, _SGD_GET_CERT_ISSUER_S, value);
				this._SGD_GET_CERT_ISSUER_S = value;
			}
		}
		/// <summary>
		/// 证书颁发者通用名称(CN)
		/// </summary>
		public string SGD_GET_CERT_ISSUER_CN
		{
			get{ return _SGD_GET_CERT_ISSUER_CN; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_ISSUER_CN, _SGD_GET_CERT_ISSUER_CN, value);
				this._SGD_GET_CERT_ISSUER_CN = value;
			}
		}
		/// <summary>
		/// 证书颁发者所在的城市、地区(L)
		/// </summary>
		public string SGD_GET_CERT_ISSUER_L
		{
			get{ return _SGD_GET_CERT_ISSUER_L; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_ISSUER_L, _SGD_GET_CERT_ISSUER_L, value);
				this._SGD_GET_CERT_ISSUER_L = value;
			}
		}
		/// <summary>
		/// 证书颁发者Email
		/// </summary>
		public string SGD_GET_CERT_ISSUER_E
		{
			get{ return _SGD_GET_CERT_ISSUER_E; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_ISSUER_E, _SGD_GET_CERT_ISSUER_E, value);
				this._SGD_GET_CERT_ISSUER_E = value;
			}
		}
		/// <summary>
		/// 证书有效期：起始日期
		/// </summary>
		public string SGD_GET_CERT_NOTBEFORE
		{
			get{ return _SGD_GET_CERT_NOTBEFORE; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_NOTBEFORE, _SGD_GET_CERT_NOTBEFORE, value);
				this._SGD_GET_CERT_NOTBEFORE = value;
			}
		}
		/// <summary>
		/// 证书有效期：终止日期
		/// </summary>
		public string SGD_GET_CERT_AFTER
		{
			get{ return _SGD_GET_CERT_AFTER; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_AFTER, _SGD_GET_CERT_AFTER, value);
				this._SGD_GET_CERT_AFTER = value;
			}
		}
		/// <summary>
		/// 证书拥有者国家(C )
		/// </summary>
		public string SGD_GET_CERT_SUBJECT_C
		{
			get{ return _SGD_GET_CERT_SUBJECT_C; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_SUBJECT_C, _SGD_GET_CERT_SUBJECT_C, value);
				this._SGD_GET_CERT_SUBJECT_C = value;
			}
		}
		/// <summary>
		/// 证书拥有者组织名(O)
		/// </summary>
		public string SGD_GET_CERT_SUBJECT_O
		{
			get{ return _SGD_GET_CERT_SUBJECT_O; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_SUBJECT_O, _SGD_GET_CERT_SUBJECT_O, value);
				this._SGD_GET_CERT_SUBJECT_O = value;
			}
		}
		/// <summary>
		/// 证书拥有者部门名(OU)
		/// </summary>
		public string SGD_GET_CERT_SUBJECT_OU
		{
			get{ return _SGD_GET_CERT_SUBJECT_OU; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_SUBJECT_OU, _SGD_GET_CERT_SUBJECT_OU, value);
				this._SGD_GET_CERT_SUBJECT_OU = value;
			}
		}
		/// <summary>
		/// 证书拥有者所在的省、自治区、直辖市(S)
		/// </summary>
		public string SGD_GET_CERT_SUBJECT_S
		{
			get{ return _SGD_GET_CERT_SUBJECT_S; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_SUBJECT_S, _SGD_GET_CERT_SUBJECT_S, value);
				this._SGD_GET_CERT_SUBJECT_S = value;
			}
		}
		/// <summary>
		/// 证书拥有者通用名称(CN)
		/// </summary>
		public string SGD_GET_CERT_SUBJECT_CN
		{
			get{ return _SGD_GET_CERT_SUBJECT_CN; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_SUBJECT_CN, _SGD_GET_CERT_SUBJECT_CN, value);
				this._SGD_GET_CERT_SUBJECT_CN = value;
			}
		}
		/// <summary>
		/// 证书拥有者所在的城市、地区(L)
		/// </summary>
		public string SGD_GET_CERT_SUBJECT_L
		{
			get{ return _SGD_GET_CERT_SUBJECT_L; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_SUBJECT_L, _SGD_GET_CERT_SUBJECT_L, value);
				this._SGD_GET_CERT_SUBJECT_L = value;
			}
		}
		/// <summary>
		/// 证书拥有者Email
		/// </summary>
		public string SGD_GET_CERT_SUBJECT_E
		{
			get{ return _SGD_GET_CERT_SUBJECT_E; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_SUBJECT_E, _SGD_GET_CERT_SUBJECT_E, value);
				this._SGD_GET_CERT_SUBJECT_E = value;
			}
		}
		/// <summary>
		/// 证书颁发者DN
		/// </summary>
		public string SGD_GET_CERT_ISSUER_DN
		{
			get{ return _SGD_GET_CERT_ISSUER_DN; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_ISSUER_DN, _SGD_GET_CERT_ISSUER_DN, value);
				this._SGD_GET_CERT_ISSUER_DN = value;
			}
		}
		/// <summary>
		/// 证书拥有者DN
		/// </summary>
		public string SGD_GET_CERT_SUBJECT_DN
		{
			get{ return _SGD_GET_CERT_SUBJECT_DN; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_SUBJECT_DN, _SGD_GET_CERT_SUBJECT_DN, value);
				this._SGD_GET_CERT_SUBJECT_DN = value;
			}
		}
		/// <summary>
		/// 证书公钥信息
		/// </summary>
		public string SGD_GET_CERT_DER_PUBKEY
		{
			get{ return _SGD_GET_CERT_DER_PUBKEY; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_DER_PUBKEY, _SGD_GET_CERT_DER_PUBKEY, value);
				this._SGD_GET_CERT_DER_PUBKEY = value;
			}
		}
		/// <summary>
		/// 证书扩展项信息
		/// </summary>
		public string SGD_GET_CERT_DER_EXTENSIONS
		{
			get{ return _SGD_GET_CERT_DER_EXTENSIONS; }
			set
			{
				this.OnPropertyValueChange(_.SGD_GET_CERT_DER_EXTENSIONS, _SGD_GET_CERT_DER_EXTENSIONS, value);
				this._SGD_GET_CERT_DER_EXTENSIONS = value;
			}
		}
		/// <summary>
		/// 颁发者密钥标识符
		/// </summary>
		public string SGD_EXT_AUTHORITYKEYIDENTIFIER
		{
			get{ return _SGD_EXT_AUTHORITYKEYIDENTIFIER; }
			set
			{
				this.OnPropertyValueChange(_.SGD_EXT_AUTHORITYKEYIDENTIFIER, _SGD_EXT_AUTHORITYKEYIDENTIFIER, value);
				this._SGD_EXT_AUTHORITYKEYIDENTIFIER = value;
			}
		}
		/// <summary>
		/// 证书持有者密钥标识符
		/// </summary>
		public string SGD_EXT_SUBJECTKEYIDENTIFIER
		{
			get{ return _SGD_EXT_SUBJECTKEYIDENTIFIER; }
			set
			{
				this.OnPropertyValueChange(_.SGD_EXT_SUBJECTKEYIDENTIFIER, _SGD_EXT_SUBJECTKEYIDENTIFIER, value);
				this._SGD_EXT_SUBJECTKEYIDENTIFIER = value;
			}
		}
		/// <summary>
		/// 密钥用途
		/// </summary>
		public string SGD_EXT_KEYUSAGE
		{
			get{ return _SGD_EXT_KEYUSAGE; }
			set
			{
				this.OnPropertyValueChange(_.SGD_EXT_KEYUSAGE, _SGD_EXT_KEYUSAGE, value);
				this._SGD_EXT_KEYUSAGE = value;
			}
		}
		/// <summary>
		/// 私钥有效期
		/// </summary>
		public string SGD_EXT_PRIVATEKEYUSAGEPERIO
		{
			get{ return _SGD_EXT_PRIVATEKEYUSAGEPERIO; }
			set
			{
				this.OnPropertyValueChange(_.SGD_EXT_PRIVATEKEYUSAGEPERIO, _SGD_EXT_PRIVATEKEYUSAGEPERIO, value);
				this._SGD_EXT_PRIVATEKEYUSAGEPERIO = value;
			}
		}
		/// <summary>
		/// 证书策略
		/// </summary>
		public string SGD_EXT_CERTIFICATEPOLICIES
		{
			get{ return _SGD_EXT_CERTIFICATEPOLICIES; }
			set
			{
				this.OnPropertyValueChange(_.SGD_EXT_CERTIFICATEPOLICIES, _SGD_EXT_CERTIFICATEPOLICIES, value);
				this._SGD_EXT_CERTIFICATEPOLICIES = value;
			}
		}
		/// <summary>
		/// 策略映射
		/// </summary>
		public string SGD_EXT_POLICYMAPPINGS
		{
			get{ return _SGD_EXT_POLICYMAPPINGS; }
			set
			{
				this.OnPropertyValueChange(_.SGD_EXT_POLICYMAPPINGS, _SGD_EXT_POLICYMAPPINGS, value);
				this._SGD_EXT_POLICYMAPPINGS = value;
			}
		}
		/// <summary>
		/// 基本限制
		/// </summary>
		public string SGD_EXT_BASICCONSTRAINTS
		{
			get{ return _SGD_EXT_BASICCONSTRAINTS; }
			set
			{
				this.OnPropertyValueChange(_.SGD_EXT_BASICCONSTRAINTS, _SGD_EXT_BASICCONSTRAINTS, value);
				this._SGD_EXT_BASICCONSTRAINTS = value;
			}
		}
		/// <summary>
		/// 策略限制
		/// </summary>
		public string SGD_EXT_POLICYCONSTRAINTS
		{
			get{ return _SGD_EXT_POLICYCONSTRAINTS; }
			set
			{
				this.OnPropertyValueChange(_.SGD_EXT_POLICYCONSTRAINTS, _SGD_EXT_POLICYCONSTRAINTS, value);
				this._SGD_EXT_POLICYCONSTRAINTS = value;
			}
		}
		/// <summary>
		/// 扩展密钥用途
		/// </summary>
		public string SGD_EXT_EXTKEYUSAGE
		{
			get{ return _SGD_EXT_EXTKEYUSAGE; }
			set
			{
				this.OnPropertyValueChange(_.SGD_EXT_EXTKEYUSAGE, _SGD_EXT_EXTKEYUSAGE, value);
				this._SGD_EXT_EXTKEYUSAGE = value;
			}
		}
		/// <summary>
		/// CRL发布点
		/// </summary>
		public string SGD_EXT_CRLDISTRIBUTIONPO
		{
			get{ return _SGD_EXT_CRLDISTRIBUTIONPO; }
			set
			{
				this.OnPropertyValueChange(_.SGD_EXT_CRLDISTRIBUTIONPO, _SGD_EXT_CRLDISTRIBUTIONPO, value);
				this._SGD_EXT_CRLDISTRIBUTIONPO = value;
			}
		}
		/// <summary>
		/// netscape属性
		/// </summary>
		public string SGD_EXT_NETSCAPE_CERT_TYPE
		{
			get{ return _SGD_EXT_NETSCAPE_CERT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.SGD_EXT_NETSCAPE_CERT_TYPE, _SGD_EXT_NETSCAPE_CERT_TYPE, value);
				this._SGD_EXT_NETSCAPE_CERT_TYPE = value;
			}
		}
		/// <summary>
		/// 证书实体唯一标识
		/// </summary>
		public string SGD_EXT_CERT_UNIQUEID
		{
			get{ return _SGD_EXT_CERT_UNIQUEID; }
			set
			{
				this.OnPropertyValueChange(_.SGD_EXT_CERT_UNIQUEID, _SGD_EXT_CERT_UNIQUEID, value);
				this._SGD_EXT_CERT_UNIQUEID = value;
			}
		}
		/// <summary>
		/// 个人身份证号码
		/// </summary>
		public string SGD_EXT_IDENTIFYCARDNUMBER
		{
			get{ return _SGD_EXT_IDENTIFYCARDNUMBER; }
			set
			{
				this.OnPropertyValueChange(_.SGD_EXT_IDENTIFYCARDNUMBER, _SGD_EXT_IDENTIFYCARDNUMBER, value);
				this._SGD_EXT_IDENTIFYCARDNUMBER = value;
			}
		}
		/// <summary>
		/// 个人社会保险号
		/// </summary>
		public string SGD_EXT_INURANCENUMBER
		{
			get{ return _SGD_EXT_INURANCENUMBER; }
			set
			{
				this.OnPropertyValueChange(_.SGD_EXT_INURANCENUMBER, _SGD_EXT_INURANCENUMBER, value);
				this._SGD_EXT_INURANCENUMBER = value;
			}
		}
		/// <summary>
		/// 企业工商注册号
		/// </summary>
		public string SGD_EXT_ICREGISTRATIONNUMBER
		{
			get{ return _SGD_EXT_ICREGISTRATIONNUMBER; }
			set
			{
				this.OnPropertyValueChange(_.SGD_EXT_ICREGISTRATIONNUMBER, _SGD_EXT_ICREGISTRATIONNUMBER, value);
				this._SGD_EXT_ICREGISTRATIONNUMBER = value;
			}
		}
		/// <summary>
		/// 企业组织机构代码
		/// </summary>
		public string SGD_EXT_ORGANIZATIONCODE
		{
			get{ return _SGD_EXT_ORGANIZATIONCODE; }
			set
			{
				this.OnPropertyValueChange(_.SGD_EXT_ORGANIZATIONCODE, _SGD_EXT_ORGANIZATIONCODE, value);
				this._SGD_EXT_ORGANIZATIONCODE = value;
			}
		}
		/// <summary>
		/// 税务登记证号
		/// </summary>
		public string SGD_EXT_TAXATIONNUMBER
		{
			get{ return _SGD_EXT_TAXATIONNUMBER; }
			set
			{
				this.OnPropertyValueChange(_.SGD_EXT_TAXATIONNUMBER, _SGD_EXT_TAXATIONNUMBER, value);
				this._SGD_EXT_TAXATIONNUMBER = value;
			}
		}
		/// <summary>
		/// 最后一次登录时间
		/// </summary>
		public DateTime? LOGIN_TM
		{
			get{ return _LOGIN_TM; }
			set
			{
				this.OnPropertyValueChange(_.LOGIN_TM, _LOGIN_TM, value);
				this._LOGIN_TM = value;
			}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public decimal? USER_ID
		{
			get{ return _USER_ID; }
			set
			{
				this.OnPropertyValueChange(_.USER_ID, _USER_ID, value);
				this._USER_ID = value;
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
				_.SGD_GET_CERT_VERSION,
				_.SGD_GET_CERT_SERIAL,
				_.SGD_GET_CERT_SIGNALG,
				_.SGD_GET_CERT_ISSUER_C,
				_.SGD_GET_CERT_ISSUER_O,
				_.SGD_GET_CERT_ISSUER_OU,
				_.SGD_GET_CERT_ISSUER_S,
				_.SGD_GET_CERT_ISSUER_CN,
				_.SGD_GET_CERT_ISSUER_L,
				_.SGD_GET_CERT_ISSUER_E,
				_.SGD_GET_CERT_NOTBEFORE,
				_.SGD_GET_CERT_AFTER,
				_.SGD_GET_CERT_SUBJECT_C,
				_.SGD_GET_CERT_SUBJECT_O,
				_.SGD_GET_CERT_SUBJECT_OU,
				_.SGD_GET_CERT_SUBJECT_S,
				_.SGD_GET_CERT_SUBJECT_CN,
				_.SGD_GET_CERT_SUBJECT_L,
				_.SGD_GET_CERT_SUBJECT_E,
				_.SGD_GET_CERT_ISSUER_DN,
				_.SGD_GET_CERT_SUBJECT_DN,
				_.SGD_GET_CERT_DER_PUBKEY,
				_.SGD_GET_CERT_DER_EXTENSIONS,
				_.SGD_EXT_AUTHORITYKEYIDENTIFIER,
				_.SGD_EXT_SUBJECTKEYIDENTIFIER,
				_.SGD_EXT_KEYUSAGE,
				_.SGD_EXT_PRIVATEKEYUSAGEPERIO,
				_.SGD_EXT_CERTIFICATEPOLICIES,
				_.SGD_EXT_POLICYMAPPINGS,
				_.SGD_EXT_BASICCONSTRAINTS,
				_.SGD_EXT_POLICYCONSTRAINTS,
				_.SGD_EXT_EXTKEYUSAGE,
				_.SGD_EXT_CRLDISTRIBUTIONPO,
				_.SGD_EXT_NETSCAPE_CERT_TYPE,
				_.SGD_EXT_CERT_UNIQUEID,
				_.SGD_EXT_IDENTIFYCARDNUMBER,
				_.SGD_EXT_INURANCENUMBER,
				_.SGD_EXT_ICREGISTRATIONNUMBER,
				_.SGD_EXT_ORGANIZATIONCODE,
				_.SGD_EXT_TAXATIONNUMBER,
				_.LOGIN_TM,
				_.USER_ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._SGD_GET_CERT_VERSION,
				this._SGD_GET_CERT_SERIAL,
				this._SGD_GET_CERT_SIGNALG,
				this._SGD_GET_CERT_ISSUER_C,
				this._SGD_GET_CERT_ISSUER_O,
				this._SGD_GET_CERT_ISSUER_OU,
				this._SGD_GET_CERT_ISSUER_S,
				this._SGD_GET_CERT_ISSUER_CN,
				this._SGD_GET_CERT_ISSUER_L,
				this._SGD_GET_CERT_ISSUER_E,
				this._SGD_GET_CERT_NOTBEFORE,
				this._SGD_GET_CERT_AFTER,
				this._SGD_GET_CERT_SUBJECT_C,
				this._SGD_GET_CERT_SUBJECT_O,
				this._SGD_GET_CERT_SUBJECT_OU,
				this._SGD_GET_CERT_SUBJECT_S,
				this._SGD_GET_CERT_SUBJECT_CN,
				this._SGD_GET_CERT_SUBJECT_L,
				this._SGD_GET_CERT_SUBJECT_E,
				this._SGD_GET_CERT_ISSUER_DN,
				this._SGD_GET_CERT_SUBJECT_DN,
				this._SGD_GET_CERT_DER_PUBKEY,
				this._SGD_GET_CERT_DER_EXTENSIONS,
				this._SGD_EXT_AUTHORITYKEYIDENTIFIER,
				this._SGD_EXT_SUBJECTKEYIDENTIFIER,
				this._SGD_EXT_KEYUSAGE,
				this._SGD_EXT_PRIVATEKEYUSAGEPERIO,
				this._SGD_EXT_CERTIFICATEPOLICIES,
				this._SGD_EXT_POLICYMAPPINGS,
				this._SGD_EXT_BASICCONSTRAINTS,
				this._SGD_EXT_POLICYCONSTRAINTS,
				this._SGD_EXT_EXTKEYUSAGE,
				this._SGD_EXT_CRLDISTRIBUTIONPO,
				this._SGD_EXT_NETSCAPE_CERT_TYPE,
				this._SGD_EXT_CERT_UNIQUEID,
				this._SGD_EXT_IDENTIFYCARDNUMBER,
				this._SGD_EXT_INURANCENUMBER,
				this._SGD_EXT_ICREGISTRATIONNUMBER,
				this._SGD_EXT_ORGANIZATIONCODE,
				this._SGD_EXT_TAXATIONNUMBER,
				this._LOGIN_TM,
				this._USER_ID,
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
			public readonly static Field All = new Field("*", "CAINFO");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "CAINFO", "ID");
            /// <summary>
			/// 证书版本
			/// </summary>
			public readonly static Field SGD_GET_CERT_VERSION = new Field("SGD_GET_CERT_VERSION", "CAINFO", "证书版本");
            /// <summary>
			/// 证书序列号
			/// </summary>
			public readonly static Field SGD_GET_CERT_SERIAL = new Field("SGD_GET_CERT_SERIAL", "CAINFO", "证书序列号");
            /// <summary>
			/// 证书签名算法标识
			/// </summary>
			public readonly static Field SGD_GET_CERT_SIGNALG = new Field("SGD_GET_CERT_SIGNALG", "CAINFO", "证书签名算法标识");
            /// <summary>
			/// 证书颁发者国家(C)
			/// </summary>
			public readonly static Field SGD_GET_CERT_ISSUER_C = new Field("SGD_GET_CERT_ISSUER_C", "CAINFO", "证书颁发者国家(C)");
            /// <summary>
			/// 证书颁发者组织名(O)
			/// </summary>
			public readonly static Field SGD_GET_CERT_ISSUER_O = new Field("SGD_GET_CERT_ISSUER_O", "CAINFO", "证书颁发者组织名(O)");
            /// <summary>
			/// 证书颁发者部门名(OU)
			/// </summary>
			public readonly static Field SGD_GET_CERT_ISSUER_OU = new Field("SGD_GET_CERT_ISSUER_OU", "CAINFO", "证书颁发者部门名(OU)");
            /// <summary>
			/// 证书颁发者所在的省、自治区、直辖市(S)
			/// </summary>
			public readonly static Field SGD_GET_CERT_ISSUER_S = new Field("SGD_GET_CERT_ISSUER_S", "CAINFO", "证书颁发者所在的省、自治区、直辖市(S)");
            /// <summary>
			/// 证书颁发者通用名称(CN)
			/// </summary>
			public readonly static Field SGD_GET_CERT_ISSUER_CN = new Field("SGD_GET_CERT_ISSUER_CN", "CAINFO", "证书颁发者通用名称(CN)");
            /// <summary>
			/// 证书颁发者所在的城市、地区(L)
			/// </summary>
			public readonly static Field SGD_GET_CERT_ISSUER_L = new Field("SGD_GET_CERT_ISSUER_L", "CAINFO", "证书颁发者所在的城市、地区(L)");
            /// <summary>
			/// 证书颁发者Email
			/// </summary>
			public readonly static Field SGD_GET_CERT_ISSUER_E = new Field("SGD_GET_CERT_ISSUER_E", "CAINFO", "证书颁发者Email");
            /// <summary>
			/// 证书有效期：起始日期
			/// </summary>
			public readonly static Field SGD_GET_CERT_NOTBEFORE = new Field("SGD_GET_CERT_NOTBEFORE", "CAINFO", "证书有效期：起始日期");
            /// <summary>
			/// 证书有效期：终止日期
			/// </summary>
			public readonly static Field SGD_GET_CERT_AFTER = new Field("SGD_GET_CERT_AFTER", "CAINFO", "证书有效期：终止日期");
            /// <summary>
			/// 证书拥有者国家(C )
			/// </summary>
			public readonly static Field SGD_GET_CERT_SUBJECT_C = new Field("SGD_GET_CERT_SUBJECT_C", "CAINFO", "证书拥有者国家(C )");
            /// <summary>
			/// 证书拥有者组织名(O)
			/// </summary>
			public readonly static Field SGD_GET_CERT_SUBJECT_O = new Field("SGD_GET_CERT_SUBJECT_O", "CAINFO", "证书拥有者组织名(O)");
            /// <summary>
			/// 证书拥有者部门名(OU)
			/// </summary>
			public readonly static Field SGD_GET_CERT_SUBJECT_OU = new Field("SGD_GET_CERT_SUBJECT_OU", "CAINFO", "证书拥有者部门名(OU)");
            /// <summary>
			/// 证书拥有者所在的省、自治区、直辖市(S)
			/// </summary>
			public readonly static Field SGD_GET_CERT_SUBJECT_S = new Field("SGD_GET_CERT_SUBJECT_S", "CAINFO", "证书拥有者所在的省、自治区、直辖市(S)");
            /// <summary>
			/// 证书拥有者通用名称(CN)
			/// </summary>
			public readonly static Field SGD_GET_CERT_SUBJECT_CN = new Field("SGD_GET_CERT_SUBJECT_CN", "CAINFO", "证书拥有者通用名称(CN)");
            /// <summary>
			/// 证书拥有者所在的城市、地区(L)
			/// </summary>
			public readonly static Field SGD_GET_CERT_SUBJECT_L = new Field("SGD_GET_CERT_SUBJECT_L", "CAINFO", "证书拥有者所在的城市、地区(L)");
            /// <summary>
			/// 证书拥有者Email
			/// </summary>
			public readonly static Field SGD_GET_CERT_SUBJECT_E = new Field("SGD_GET_CERT_SUBJECT_E", "CAINFO", "证书拥有者Email");
            /// <summary>
			/// 证书颁发者DN
			/// </summary>
			public readonly static Field SGD_GET_CERT_ISSUER_DN = new Field("SGD_GET_CERT_ISSUER_DN", "CAINFO", "证书颁发者DN");
            /// <summary>
			/// 证书拥有者DN
			/// </summary>
			public readonly static Field SGD_GET_CERT_SUBJECT_DN = new Field("SGD_GET_CERT_SUBJECT_DN", "CAINFO", "证书拥有者DN");
            /// <summary>
			/// 证书公钥信息
			/// </summary>
			public readonly static Field SGD_GET_CERT_DER_PUBKEY = new Field("SGD_GET_CERT_DER_PUBKEY", "CAINFO",DbType.AnsiString, null, "证书公钥信息");
            /// <summary>
			/// 证书扩展项信息
			/// </summary>
			public readonly static Field SGD_GET_CERT_DER_EXTENSIONS = new Field("SGD_GET_CERT_DER_EXTENSIONS", "CAINFO",DbType.AnsiString, null, "证书扩展项信息");
            /// <summary>
			/// 颁发者密钥标识符
			/// </summary>
			public readonly static Field SGD_EXT_AUTHORITYKEYIDENTIFIER = new Field("SGD_EXT_AUTHORITYKEYIDENTIFIER", "CAINFO", "颁发者密钥标识符");
            /// <summary>
			/// 证书持有者密钥标识符
			/// </summary>
			public readonly static Field SGD_EXT_SUBJECTKEYIDENTIFIER = new Field("SGD_EXT_SUBJECTKEYIDENTIFIER", "CAINFO", "证书持有者密钥标识符");
            /// <summary>
			/// 密钥用途
			/// </summary>
			public readonly static Field SGD_EXT_KEYUSAGE = new Field("SGD_EXT_KEYUSAGE", "CAINFO", "密钥用途");
            /// <summary>
			/// 私钥有效期
			/// </summary>
			public readonly static Field SGD_EXT_PRIVATEKEYUSAGEPERIO = new Field("SGD_EXT_PRIVATEKEYUSAGEPERIO", "CAINFO", "私钥有效期");
            /// <summary>
			/// 证书策略
			/// </summary>
			public readonly static Field SGD_EXT_CERTIFICATEPOLICIES = new Field("SGD_EXT_CERTIFICATEPOLICIES", "CAINFO",DbType.AnsiString, null, "证书策略");
            /// <summary>
			/// 策略映射
			/// </summary>
			public readonly static Field SGD_EXT_POLICYMAPPINGS = new Field("SGD_EXT_POLICYMAPPINGS", "CAINFO", "策略映射");
            /// <summary>
			/// 基本限制
			/// </summary>
			public readonly static Field SGD_EXT_BASICCONSTRAINTS = new Field("SGD_EXT_BASICCONSTRAINTS", "CAINFO", "基本限制");
            /// <summary>
			/// 策略限制
			/// </summary>
			public readonly static Field SGD_EXT_POLICYCONSTRAINTS = new Field("SGD_EXT_POLICYCONSTRAINTS", "CAINFO", "策略限制");
            /// <summary>
			/// 扩展密钥用途
			/// </summary>
			public readonly static Field SGD_EXT_EXTKEYUSAGE = new Field("SGD_EXT_EXTKEYUSAGE", "CAINFO", "扩展密钥用途");
            /// <summary>
			/// CRL发布点
			/// </summary>
			public readonly static Field SGD_EXT_CRLDISTRIBUTIONPO = new Field("SGD_EXT_CRLDISTRIBUTIONPO", "CAINFO",DbType.AnsiString, null, "CRL发布点");
            /// <summary>
			/// netscape属性
			/// </summary>
			public readonly static Field SGD_EXT_NETSCAPE_CERT_TYPE = new Field("SGD_EXT_NETSCAPE_CERT_TYPE", "CAINFO", "netscape属性");
            /// <summary>
			/// 证书实体唯一标识
			/// </summary>
			public readonly static Field SGD_EXT_CERT_UNIQUEID = new Field("SGD_EXT_CERT_UNIQUEID", "CAINFO", "证书实体唯一标识");
            /// <summary>
			/// 个人身份证号码
			/// </summary>
			public readonly static Field SGD_EXT_IDENTIFYCARDNUMBER = new Field("SGD_EXT_IDENTIFYCARDNUMBER", "CAINFO", "个人身份证号码");
            /// <summary>
			/// 个人社会保险号
			/// </summary>
			public readonly static Field SGD_EXT_INURANCENUMBER = new Field("SGD_EXT_INURANCENUMBER", "CAINFO", "个人社会保险号");
            /// <summary>
			/// 企业工商注册号
			/// </summary>
			public readonly static Field SGD_EXT_ICREGISTRATIONNUMBER = new Field("SGD_EXT_ICREGISTRATIONNUMBER", "CAINFO", "企业工商注册号");
            /// <summary>
			/// 企业组织机构代码
			/// </summary>
			public readonly static Field SGD_EXT_ORGANIZATIONCODE = new Field("SGD_EXT_ORGANIZATIONCODE", "CAINFO", "企业组织机构代码");
            /// <summary>
			/// 税务登记证号
			/// </summary>
			public readonly static Field SGD_EXT_TAXATIONNUMBER = new Field("SGD_EXT_TAXATIONNUMBER", "CAINFO", "税务登记证号");
            /// <summary>
			/// 最后一次登录时间
			/// </summary>
			public readonly static Field LOGIN_TM = new Field("LOGIN_TM", "CAINFO", "最后一次登录时间");
            /// <summary>
			/// 用户ID
			/// </summary>
			public readonly static Field USER_ID = new Field("USER_ID", "CAINFO", "用户ID");
        }
        #endregion
	}
}