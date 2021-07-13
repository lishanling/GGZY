using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类IDENT_INFORMATION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("IDENT_INFORMATION")]
    [Serializable]
    public partial class IDENT_INFORMATION : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _TEST_REPORT;
		private string _TEST_ORGANIZETION;
		private string _DETECTION_MECHANISM;
		private string _CERTIFICATE;
		private string _CERTIFICATE_IMAGE;
		private string _CERTIFICATION_BODY;
		private string _CERTIFICATION_NUM;
		private DateTime? _CERTIFICATE_EXPIRATION;
		private string _PATENT_CERTIFICATION;
		private string _PATENT_NUM;
		private string _CERTIFICATION_AUTTHORITY;
		private string _CERTIFICATION_VALIDITY;
		private string _IMG;
		private string _CERTIFICATE_NAME;
		private string _CERTIFICATE_LEVEL;
		private string _CERTIFICATE_IMG;
		private string _CERTIFICATION_AUTHORITY;
		private DateTime? _CERTIFICATE_ISSUING;
		private string _REMARKS;

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
		/// 检测报告名称
		/// </summary>
		public string TEST_REPORT
		{
			get{ return _TEST_REPORT; }
			set
			{
				this.OnPropertyValueChange(_.TEST_REPORT, _TEST_REPORT, value);
				this._TEST_REPORT = value;
			}
		}
		/// <summary>
		/// 检测机构名称
		/// </summary>
		public string TEST_ORGANIZETION
		{
			get{ return _TEST_ORGANIZETION; }
			set
			{
				this.OnPropertyValueChange(_.TEST_ORGANIZETION, _TEST_ORGANIZETION, value);
				this._TEST_ORGANIZETION = value;
			}
		}
		/// <summary>
		/// 检测机构图片
		/// </summary>
		public string DETECTION_MECHANISM
		{
			get{ return _DETECTION_MECHANISM; }
			set
			{
				this.OnPropertyValueChange(_.DETECTION_MECHANISM, _DETECTION_MECHANISM, value);
				this._DETECTION_MECHANISM = value;
			}
		}
		/// <summary>
		/// 认证证书名称
		/// </summary>
		public string CERTIFICATE
		{
			get{ return _CERTIFICATE; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATE, _CERTIFICATE, value);
				this._CERTIFICATE = value;
			}
		}
		/// <summary>
		/// 证书图片
		/// </summary>
		public string CERTIFICATE_IMAGE
		{
			get{ return _CERTIFICATE_IMAGE; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATE_IMAGE, _CERTIFICATE_IMAGE, value);
				this._CERTIFICATE_IMAGE = value;
			}
		}
		/// <summary>
		/// 认证机构名称
		/// </summary>
		public string CERTIFICATION_BODY
		{
			get{ return _CERTIFICATION_BODY; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATION_BODY, _CERTIFICATION_BODY, value);
				this._CERTIFICATION_BODY = value;
			}
		}
		/// <summary>
		/// 证书编号
		/// </summary>
		public string CERTIFICATION_NUM
		{
			get{ return _CERTIFICATION_NUM; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATION_NUM, _CERTIFICATION_NUM, value);
				this._CERTIFICATION_NUM = value;
			}
		}
		/// <summary>
		/// 证书到期时间
		/// </summary>
		public DateTime? CERTIFICATE_EXPIRATION
		{
			get{ return _CERTIFICATE_EXPIRATION; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATE_EXPIRATION, _CERTIFICATE_EXPIRATION, value);
				this._CERTIFICATE_EXPIRATION = value;
			}
		}
		/// <summary>
		/// 专利证书名称
		/// </summary>
		public string PATENT_CERTIFICATION
		{
			get{ return _PATENT_CERTIFICATION; }
			set
			{
				this.OnPropertyValueChange(_.PATENT_CERTIFICATION, _PATENT_CERTIFICATION, value);
				this._PATENT_CERTIFICATION = value;
			}
		}
		/// <summary>
		/// 专利证书编号
		/// </summary>
		public string PATENT_NUM
		{
			get{ return _PATENT_NUM; }
			set
			{
				this.OnPropertyValueChange(_.PATENT_NUM, _PATENT_NUM, value);
				this._PATENT_NUM = value;
			}
		}
		/// <summary>
		/// 证书颁发机构名称
		/// </summary>
		public string CERTIFICATION_AUTTHORITY
		{
			get{ return _CERTIFICATION_AUTTHORITY; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATION_AUTTHORITY, _CERTIFICATION_AUTTHORITY, value);
				this._CERTIFICATION_AUTTHORITY = value;
			}
		}
		/// <summary>
		/// 证书有效期
		/// </summary>
		public string CERTIFICATION_VALIDITY
		{
			get{ return _CERTIFICATION_VALIDITY; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATION_VALIDITY, _CERTIFICATION_VALIDITY, value);
				this._CERTIFICATION_VALIDITY = value;
			}
		}
		/// <summary>
		/// 图片
		/// </summary>
		public string IMG
		{
			get{ return _IMG; }
			set
			{
				this.OnPropertyValueChange(_.IMG, _IMG, value);
				this._IMG = value;
			}
		}
		/// <summary>
		/// 证书名称
		/// </summary>
		public string CERTIFICATE_NAME
		{
			get{ return _CERTIFICATE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATE_NAME, _CERTIFICATE_NAME, value);
				this._CERTIFICATE_NAME = value;
			}
		}
		/// <summary>
		/// 证书等级
		/// </summary>
		public string CERTIFICATE_LEVEL
		{
			get{ return _CERTIFICATE_LEVEL; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATE_LEVEL, _CERTIFICATE_LEVEL, value);
				this._CERTIFICATE_LEVEL = value;
			}
		}
		/// <summary>
		/// 专利证书图片
		/// </summary>
		public string CERTIFICATE_IMG
		{
			get{ return _CERTIFICATE_IMG; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATE_IMG, _CERTIFICATE_IMG, value);
				this._CERTIFICATE_IMG = value;
			}
		}
		/// <summary>
		/// 专利证书颁发机构名称
		/// </summary>
		public string CERTIFICATION_AUTHORITY
		{
			get{ return _CERTIFICATION_AUTHORITY; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATION_AUTHORITY, _CERTIFICATION_AUTHORITY, value);
				this._CERTIFICATION_AUTHORITY = value;
			}
		}
		/// <summary>
		/// 证书颁发时间
		/// </summary>
		public DateTime? CERTIFICATE_ISSUING
		{
			get{ return _CERTIFICATE_ISSUING; }
			set
			{
				this.OnPropertyValueChange(_.CERTIFICATE_ISSUING, _CERTIFICATE_ISSUING, value);
				this._CERTIFICATE_ISSUING = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARKS
		{
			get{ return _REMARKS; }
			set
			{
				this.OnPropertyValueChange(_.REMARKS, _REMARKS, value);
				this._REMARKS = value;
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
				_.TEST_REPORT,
				_.TEST_ORGANIZETION,
				_.DETECTION_MECHANISM,
				_.CERTIFICATE,
				_.CERTIFICATE_IMAGE,
				_.CERTIFICATION_BODY,
				_.CERTIFICATION_NUM,
				_.CERTIFICATE_EXPIRATION,
				_.PATENT_CERTIFICATION,
				_.PATENT_NUM,
				_.CERTIFICATION_AUTTHORITY,
				_.CERTIFICATION_VALIDITY,
				_.IMG,
				_.CERTIFICATE_NAME,
				_.CERTIFICATE_LEVEL,
				_.CERTIFICATE_IMG,
				_.CERTIFICATION_AUTHORITY,
				_.CERTIFICATE_ISSUING,
				_.REMARKS,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TEST_REPORT,
				this._TEST_ORGANIZETION,
				this._DETECTION_MECHANISM,
				this._CERTIFICATE,
				this._CERTIFICATE_IMAGE,
				this._CERTIFICATION_BODY,
				this._CERTIFICATION_NUM,
				this._CERTIFICATE_EXPIRATION,
				this._PATENT_CERTIFICATION,
				this._PATENT_NUM,
				this._CERTIFICATION_AUTTHORITY,
				this._CERTIFICATION_VALIDITY,
				this._IMG,
				this._CERTIFICATE_NAME,
				this._CERTIFICATE_LEVEL,
				this._CERTIFICATE_IMG,
				this._CERTIFICATION_AUTHORITY,
				this._CERTIFICATE_ISSUING,
				this._REMARKS,
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
			public readonly static Field All = new Field("*", "IDENT_INFORMATION");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "IDENT_INFORMATION", "ID");
            /// <summary>
			/// 检测报告名称
			/// </summary>
			public readonly static Field TEST_REPORT = new Field("TEST_REPORT", "IDENT_INFORMATION", "检测报告名称");
            /// <summary>
			/// 检测机构名称
			/// </summary>
			public readonly static Field TEST_ORGANIZETION = new Field("TEST_ORGANIZETION", "IDENT_INFORMATION", "检测机构名称");
            /// <summary>
			/// 检测机构图片
			/// </summary>
			public readonly static Field DETECTION_MECHANISM = new Field("DETECTION_MECHANISM", "IDENT_INFORMATION", "检测机构图片");
            /// <summary>
			/// 认证证书名称
			/// </summary>
			public readonly static Field CERTIFICATE = new Field("CERTIFICATE", "IDENT_INFORMATION", "认证证书名称");
            /// <summary>
			/// 证书图片
			/// </summary>
			public readonly static Field CERTIFICATE_IMAGE = new Field("CERTIFICATE_IMAGE", "IDENT_INFORMATION", "证书图片");
            /// <summary>
			/// 认证机构名称
			/// </summary>
			public readonly static Field CERTIFICATION_BODY = new Field("CERTIFICATION_BODY", "IDENT_INFORMATION", "认证机构名称");
            /// <summary>
			/// 证书编号
			/// </summary>
			public readonly static Field CERTIFICATION_NUM = new Field("CERTIFICATION_NUM", "IDENT_INFORMATION", "证书编号");
            /// <summary>
			/// 证书到期时间
			/// </summary>
			public readonly static Field CERTIFICATE_EXPIRATION = new Field("CERTIFICATE_EXPIRATION", "IDENT_INFORMATION", "证书到期时间");
            /// <summary>
			/// 专利证书名称
			/// </summary>
			public readonly static Field PATENT_CERTIFICATION = new Field("PATENT_CERTIFICATION", "IDENT_INFORMATION", "专利证书名称");
            /// <summary>
			/// 专利证书编号
			/// </summary>
			public readonly static Field PATENT_NUM = new Field("PATENT_NUM", "IDENT_INFORMATION", "专利证书编号");
            /// <summary>
			/// 证书颁发机构名称
			/// </summary>
			public readonly static Field CERTIFICATION_AUTTHORITY = new Field("CERTIFICATION_AUTTHORITY", "IDENT_INFORMATION", "证书颁发机构名称");
            /// <summary>
			/// 证书有效期
			/// </summary>
			public readonly static Field CERTIFICATION_VALIDITY = new Field("CERTIFICATION_VALIDITY", "IDENT_INFORMATION", "证书有效期");
            /// <summary>
			/// 图片
			/// </summary>
			public readonly static Field IMG = new Field("IMG", "IDENT_INFORMATION", "图片");
            /// <summary>
			/// 证书名称
			/// </summary>
			public readonly static Field CERTIFICATE_NAME = new Field("CERTIFICATE_NAME", "IDENT_INFORMATION", "证书名称");
            /// <summary>
			/// 证书等级
			/// </summary>
			public readonly static Field CERTIFICATE_LEVEL = new Field("CERTIFICATE_LEVEL", "IDENT_INFORMATION", "证书等级");
            /// <summary>
			/// 专利证书图片
			/// </summary>
			public readonly static Field CERTIFICATE_IMG = new Field("CERTIFICATE_IMG", "IDENT_INFORMATION", "专利证书图片");
            /// <summary>
			/// 专利证书颁发机构名称
			/// </summary>
			public readonly static Field CERTIFICATION_AUTHORITY = new Field("CERTIFICATION_AUTHORITY", "IDENT_INFORMATION", "专利证书颁发机构名称");
            /// <summary>
			/// 证书颁发时间
			/// </summary>
			public readonly static Field CERTIFICATE_ISSUING = new Field("CERTIFICATE_ISSUING", "IDENT_INFORMATION", "证书颁发时间");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARKS = new Field("REMARKS", "IDENT_INFORMATION", "备注");
        }
        #endregion
	}
}