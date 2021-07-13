using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_ZT_PERSON。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_ZT_PERSON")]
    [Serializable]
    public partial class T_ZT_PERSON : FwEntity
    {
        #region Model
		private string _IDCARD;
		private DateTime? _IDCARDENDDATE;
		private string _IDCARDTYPE;
		private string _PERSONNAME;
		private string _CONTACT;
		private string _BANKACCOUNT;
		private string _BANKNAME;
		private string _ZIPCODE;
		private string _ADDRESS;
		private string _DATASOURCECODE;
		private DateTime? _DATATIMESTAMP;

		/// <summary>
		/// 主体代码（身份证件号）
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
		/// <summary>
		/// 身份证件失效日期
		/// </summary>
		public DateTime? IDCARDENDDATE
		{
			get{ return _IDCARDENDDATE; }
			set
			{
				this.OnPropertyValueChange(_.IDCARDENDDATE, _IDCARDENDDATE, value);
				this._IDCARDENDDATE = value;
			}
		}
		/// <summary>
		/// 身份证件类型
		/// </summary>
		public string IDCARDTYPE
		{
			get{ return _IDCARDTYPE; }
			set
			{
				this.OnPropertyValueChange(_.IDCARDTYPE, _IDCARDTYPE, value);
				this._IDCARDTYPE = value;
			}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string PERSONNAME
		{
			get{ return _PERSONNAME; }
			set
			{
				this.OnPropertyValueChange(_.PERSONNAME, _PERSONNAME, value);
				this._PERSONNAME = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string CONTACT
		{
			get{ return _CONTACT; }
			set
			{
				this.OnPropertyValueChange(_.CONTACT, _CONTACT, value);
				this._CONTACT = value;
			}
		}
		/// <summary>
		/// 银行账户
		/// </summary>
		public string BANKACCOUNT
		{
			get{ return _BANKACCOUNT; }
			set
			{
				this.OnPropertyValueChange(_.BANKACCOUNT, _BANKACCOUNT, value);
				this._BANKACCOUNT = value;
			}
		}
		/// <summary>
		/// 开户行
		/// </summary>
		public string BANKNAME
		{
			get{ return _BANKNAME; }
			set
			{
				this.OnPropertyValueChange(_.BANKNAME, _BANKNAME, value);
				this._BANKNAME = value;
			}
		}
		/// <summary>
		/// 邮编
		/// </summary>
		public string ZIPCODE
		{
			get{ return _ZIPCODE; }
			set
			{
				this.OnPropertyValueChange(_.ZIPCODE, _ZIPCODE, value);
				this._ZIPCODE = value;
			}
		}
		/// <summary>
		/// 地址
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
		/// 来源平台编码
		/// </summary>
		public string DATASOURCECODE
		{
			get{ return _DATASOURCECODE; }
			set
			{
				this.OnPropertyValueChange(_.DATASOURCECODE, _DATASOURCECODE, value);
				this._DATASOURCECODE = value;
			}
		}
		/// <summary>
		/// 数据时间戳
		/// </summary>
		public DateTime? DATATIMESTAMP
		{
			get{ return _DATATIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATATIMESTAMP, _DATATIMESTAMP, value);
				this._DATATIMESTAMP = value;
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
				_.IDCARD,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.IDCARD,
				_.IDCARDENDDATE,
				_.IDCARDTYPE,
				_.PERSONNAME,
				_.CONTACT,
				_.BANKACCOUNT,
				_.BANKNAME,
				_.ZIPCODE,
				_.ADDRESS,
				_.DATASOURCECODE,
				_.DATATIMESTAMP,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._IDCARD,
				this._IDCARDENDDATE,
				this._IDCARDTYPE,
				this._PERSONNAME,
				this._CONTACT,
				this._BANKACCOUNT,
				this._BANKNAME,
				this._ZIPCODE,
				this._ADDRESS,
				this._DATASOURCECODE,
				this._DATATIMESTAMP,
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
			public readonly static Field All = new Field("*", "T_ZT_PERSON");
            /// <summary>
			/// 主体代码（身份证件号）
			/// </summary>
			public readonly static Field IDCARD = new Field("IDCARD", "T_ZT_PERSON", "主体代码（身份证件号）");
            /// <summary>
			/// 身份证件失效日期
			/// </summary>
			public readonly static Field IDCARDENDDATE = new Field("IDCARDENDDATE", "T_ZT_PERSON", "身份证件失效日期");
            /// <summary>
			/// 身份证件类型
			/// </summary>
			public readonly static Field IDCARDTYPE = new Field("IDCARDTYPE", "T_ZT_PERSON", "身份证件类型");
            /// <summary>
			/// 姓名
			/// </summary>
			public readonly static Field PERSONNAME = new Field("PERSONNAME", "T_ZT_PERSON", "姓名");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field CONTACT = new Field("CONTACT", "T_ZT_PERSON", "联系电话");
            /// <summary>
			/// 银行账户
			/// </summary>
			public readonly static Field BANKACCOUNT = new Field("BANKACCOUNT", "T_ZT_PERSON", "银行账户");
            /// <summary>
			/// 开户行
			/// </summary>
			public readonly static Field BANKNAME = new Field("BANKNAME", "T_ZT_PERSON", "开户行");
            /// <summary>
			/// 邮编
			/// </summary>
			public readonly static Field ZIPCODE = new Field("ZIPCODE", "T_ZT_PERSON", "邮编");
            /// <summary>
			/// 地址
			/// </summary>
			public readonly static Field ADDRESS = new Field("ADDRESS", "T_ZT_PERSON", "地址");
            /// <summary>
			/// 来源平台编码
			/// </summary>
			public readonly static Field DATASOURCECODE = new Field("DATASOURCECODE", "T_ZT_PERSON", "来源平台编码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATATIMESTAMP = new Field("DATATIMESTAMP", "T_ZT_PERSON", "数据时间戳");
        }
        #endregion
	}
}