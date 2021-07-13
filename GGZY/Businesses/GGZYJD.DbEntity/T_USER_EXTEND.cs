using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_USER_EXTEND。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_USER_EXTEND")]
    [Serializable]
    public partial class T_USER_EXTEND : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _U_ID;
		private string _DEP_NAME;
		private string _DEP_KIND;
		private string _CODE_TYPE;
		private string _UNIFIED_CREDIT_CODE;
		private string _ORGAN_CODE;
		private string _PROV_CODE;
		private string _CITY_CODE;
		private string _COUNTY_CODE;
		private string _POSTAL_CODE;
		private string _ADDRESS;
		private string _CONTACTS;
		private string _CONTACTS_PHONE;
		private string _AIDS_UCC;
		private string _AIDS_OC;
		private string _ACCOUNT_TYPE;
		private string _IDCARD;

		/// <summary>
		/// 主键ID 自增
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
		/// 用户ID
		/// </summary>
		public decimal? U_ID
		{
			get{ return _U_ID; }
			set
			{
				this.OnPropertyValueChange(_.U_ID, _U_ID, value);
				this._U_ID = value;
			}
		}
		/// <summary>
		/// 单位名称
		/// </summary>
		public string DEP_NAME
		{
			get{ return _DEP_NAME; }
			set
			{
				this.OnPropertyValueChange(_.DEP_NAME, _DEP_NAME, value);
				this._DEP_NAME = value;
			}
		}
		/// <summary>
		/// 单位性质
		/// </summary>
		public string DEP_KIND
		{
			get{ return _DEP_KIND; }
			set
			{
				this.OnPropertyValueChange(_.DEP_KIND, _DEP_KIND, value);
				this._DEP_KIND = value;
			}
		}
		/// <summary>
		/// 代码类型
		/// </summary>
		public string CODE_TYPE
		{
			get{ return _CODE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.CODE_TYPE, _CODE_TYPE, value);
				this._CODE_TYPE = value;
			}
		}
		/// <summary>
		/// 统一信用代码
		/// </summary>
		public string UNIFIED_CREDIT_CODE
		{
			get{ return _UNIFIED_CREDIT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.UNIFIED_CREDIT_CODE, _UNIFIED_CREDIT_CODE, value);
				this._UNIFIED_CREDIT_CODE = value;
			}
		}
		/// <summary>
		/// 组织机构代码
		/// </summary>
		public string ORGAN_CODE
		{
			get{ return _ORGAN_CODE; }
			set
			{
				this.OnPropertyValueChange(_.ORGAN_CODE, _ORGAN_CODE, value);
				this._ORGAN_CODE = value;
			}
		}
		/// <summary>
		/// 所在地-省
		/// </summary>
		public string PROV_CODE
		{
			get{ return _PROV_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROV_CODE, _PROV_CODE, value);
				this._PROV_CODE = value;
			}
		}
		/// <summary>
		/// 所在地-市
		/// </summary>
		public string CITY_CODE
		{
			get{ return _CITY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CITY_CODE, _CITY_CODE, value);
				this._CITY_CODE = value;
			}
		}
		/// <summary>
		/// 所在地-县
		/// </summary>
		public string COUNTY_CODE
		{
			get{ return _COUNTY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.COUNTY_CODE, _COUNTY_CODE, value);
				this._COUNTY_CODE = value;
			}
		}
		/// <summary>
		/// 邮政编码
		/// </summary>
		public string POSTAL_CODE
		{
			get{ return _POSTAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.POSTAL_CODE, _POSTAL_CODE, value);
				this._POSTAL_CODE = value;
			}
		}
		/// <summary>
		/// 单位地址
		/// </summary>
		public string ADDRESS
		{
			get{ return _ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.ADDRESS, _ADDRESS, value);
				this._ADDRESS = value;
			}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string CONTACTS
		{
			get{ return _CONTACTS; }
			set
			{
				this.OnPropertyValueChange(_.CONTACTS, _CONTACTS, value);
				this._CONTACTS = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string CONTACTS_PHONE
		{
			get{ return _CONTACTS_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.CONTACTS_PHONE, _CONTACTS_PHONE, value);
				this._CONTACTS_PHONE = value;
			}
		}
		/// <summary>
		/// 扫描件_统一信用代码
		/// </summary>
		public string AIDS_UCC
		{
			get{ return _AIDS_UCC; }
			set
			{
				this.OnPropertyValueChange(_.AIDS_UCC, _AIDS_UCC, value);
				this._AIDS_UCC = value;
			}
		}
		/// <summary>
		/// 扫描件_组织机构代码
		/// </summary>
		public string AIDS_OC
		{
			get{ return _AIDS_OC; }
			set
			{
				this.OnPropertyValueChange(_.AIDS_OC, _AIDS_OC, value);
				this._AIDS_OC = value;
			}
		}
		/// <summary>
		/// 账号类型
		/// </summary>
		public string ACCOUNT_TYPE
		{
			get{ return _ACCOUNT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.ACCOUNT_TYPE, _ACCOUNT_TYPE, value);
				this._ACCOUNT_TYPE = value;
			}
		}
		/// <summary>
		/// 个人注册时记录身份证号，企业则为空
		/// </summary>
		public string IDCARD
		{
			get{ return _IDCARD; }
			set
			{
				this.OnPropertyValueChange(_.IDCARD, _IDCARD, value);
				this._IDCARD = value;
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
				_.U_ID,
				_.DEP_NAME,
				_.DEP_KIND,
				_.CODE_TYPE,
				_.UNIFIED_CREDIT_CODE,
				_.ORGAN_CODE,
				_.PROV_CODE,
				_.CITY_CODE,
				_.COUNTY_CODE,
				_.POSTAL_CODE,
				_.ADDRESS,
				_.CONTACTS,
				_.CONTACTS_PHONE,
				_.AIDS_UCC,
				_.AIDS_OC,
				_.ACCOUNT_TYPE,
				_.IDCARD,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._U_ID,
				this._DEP_NAME,
				this._DEP_KIND,
				this._CODE_TYPE,
				this._UNIFIED_CREDIT_CODE,
				this._ORGAN_CODE,
				this._PROV_CODE,
				this._CITY_CODE,
				this._COUNTY_CODE,
				this._POSTAL_CODE,
				this._ADDRESS,
				this._CONTACTS,
				this._CONTACTS_PHONE,
				this._AIDS_UCC,
				this._AIDS_OC,
				this._ACCOUNT_TYPE,
				this._IDCARD,
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
			public readonly static Field All = new Field("*", "T_USER_EXTEND");
            /// <summary>
			/// 主键ID 自增
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_USER_EXTEND", "主键ID 自增");
            /// <summary>
			/// 用户ID
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "T_USER_EXTEND", "用户ID");
            /// <summary>
			/// 单位名称
			/// </summary>
			public readonly static Field DEP_NAME = new Field("DEP_NAME", "T_USER_EXTEND", "单位名称");
            /// <summary>
			/// 单位性质
			/// </summary>
			public readonly static Field DEP_KIND = new Field("DEP_KIND", "T_USER_EXTEND", "单位性质");
            /// <summary>
			/// 代码类型
			/// </summary>
			public readonly static Field CODE_TYPE = new Field("CODE_TYPE", "T_USER_EXTEND", "代码类型");
            /// <summary>
			/// 统一信用代码
			/// </summary>
			public readonly static Field UNIFIED_CREDIT_CODE = new Field("UNIFIED_CREDIT_CODE", "T_USER_EXTEND", "统一信用代码");
            /// <summary>
			/// 组织机构代码
			/// </summary>
			public readonly static Field ORGAN_CODE = new Field("ORGAN_CODE", "T_USER_EXTEND", "组织机构代码");
            /// <summary>
			/// 所在地-省
			/// </summary>
			public readonly static Field PROV_CODE = new Field("PROV_CODE", "T_USER_EXTEND", "所在地-省");
            /// <summary>
			/// 所在地-市
			/// </summary>
			public readonly static Field CITY_CODE = new Field("CITY_CODE", "T_USER_EXTEND", "所在地-市");
            /// <summary>
			/// 所在地-县
			/// </summary>
			public readonly static Field COUNTY_CODE = new Field("COUNTY_CODE", "T_USER_EXTEND", "所在地-县");
            /// <summary>
			/// 邮政编码
			/// </summary>
			public readonly static Field POSTAL_CODE = new Field("POSTAL_CODE", "T_USER_EXTEND", "邮政编码");
            /// <summary>
			/// 单位地址
			/// </summary>
			public readonly static Field ADDRESS = new Field("ADDRESS", "T_USER_EXTEND", "单位地址");
            /// <summary>
			/// 联系人
			/// </summary>
			public readonly static Field CONTACTS = new Field("CONTACTS", "T_USER_EXTEND", "联系人");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field CONTACTS_PHONE = new Field("CONTACTS_PHONE", "T_USER_EXTEND", "联系电话");
            /// <summary>
			/// 扫描件_统一信用代码
			/// </summary>
			public readonly static Field AIDS_UCC = new Field("AIDS_UCC", "T_USER_EXTEND", "扫描件_统一信用代码");
            /// <summary>
			/// 扫描件_组织机构代码
			/// </summary>
			public readonly static Field AIDS_OC = new Field("AIDS_OC", "T_USER_EXTEND", "扫描件_组织机构代码");
            /// <summary>
			/// 账号类型
			/// </summary>
			public readonly static Field ACCOUNT_TYPE = new Field("ACCOUNT_TYPE", "T_USER_EXTEND", "账号类型");
            /// <summary>
			/// 个人注册时记录身份证号，企业则为空
			/// </summary>
			public readonly static Field IDCARD = new Field("IDCARD", "T_USER_EXTEND", "个人注册时记录身份证号，企业则为空");
        }
        #endregion
	}
}