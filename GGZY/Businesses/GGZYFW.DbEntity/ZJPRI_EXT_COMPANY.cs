using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJPRI_EXT_COMPANY。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJPRI_EXT_COMPANY")]
    [Serializable]
    public partial class ZJPRI_EXT_COMPANY : FwEntity
    {
        #region Model
		private string _ID;
		private DateTime? _CREATE_TIME;
		private string _VERSION;
		private string _DATA_SOURCE;
		private string _FILES;
		private string _LEGAL_NAME;
		private string _LEGAL_OLD_NAME;
		private string _LEGAL_CODE;
		private string _CREDIT_RATE;
		private string _BASIC_BANK;
		private string _BASIC_BRANCH_BANK;
		private string _BASIC_ACCOUNT_NO;
		private string _BASIC_ACCOUNT_NAME;

		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 版本号
		/// </summary>
		public string VERSION
		{
			get{ return _VERSION; }
			set
			{
				this.OnPropertyValueChange(_.VERSION, _VERSION, value);
				this._VERSION = value;
			}
		}
		/// <summary>
		/// 数据来源
		/// </summary>
		public string DATA_SOURCE
		{
			get{ return _DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.DATA_SOURCE, _DATA_SOURCE, value);
				this._DATA_SOURCE = value;
			}
		}
		/// <summary>
		/// 附件
		/// </summary>
		public string FILES
		{
			get{ return _FILES; }
			set
			{
				this.OnPropertyValueChange(_.FILES, _FILES, value);
				this._FILES = value;
			}
		}
		/// <summary>
		/// 法人名称(企业名称)
		/// </summary>
		public string LEGAL_NAME
		{
			get{ return _LEGAL_NAME; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_NAME, _LEGAL_NAME, value);
				this._LEGAL_NAME = value;
			}
		}
		/// <summary>
		/// 企业曾用名
		/// </summary>
		public string LEGAL_OLD_NAME
		{
			get{ return _LEGAL_OLD_NAME; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_OLD_NAME, _LEGAL_OLD_NAME, value);
				this._LEGAL_OLD_NAME = value;
			}
		}
		/// <summary>
		/// 社会信用统一代码
		/// </summary>
		public string LEGAL_CODE
		{
			get{ return _LEGAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_CODE, _LEGAL_CODE, value);
				this._LEGAL_CODE = value;
			}
		}
		/// <summary>
		/// 资信等级
		/// </summary>
		public string CREDIT_RATE
		{
			get{ return _CREDIT_RATE; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_RATE, _CREDIT_RATE, value);
				this._CREDIT_RATE = value;
			}
		}
		/// <summary>
		/// 基本户开户银行
		/// </summary>
		public string BASIC_BANK
		{
			get{ return _BASIC_BANK; }
			set
			{
				this.OnPropertyValueChange(_.BASIC_BANK, _BASIC_BANK, value);
				this._BASIC_BANK = value;
			}
		}
		/// <summary>
		/// 基本户开户支行号
		/// </summary>
		public string BASIC_BRANCH_BANK
		{
			get{ return _BASIC_BRANCH_BANK; }
			set
			{
				this.OnPropertyValueChange(_.BASIC_BRANCH_BANK, _BASIC_BRANCH_BANK, value);
				this._BASIC_BRANCH_BANK = value;
			}
		}
		/// <summary>
		/// 基本户账号
		/// </summary>
		public string BASIC_ACCOUNT_NO
		{
			get{ return _BASIC_ACCOUNT_NO; }
			set
			{
				this.OnPropertyValueChange(_.BASIC_ACCOUNT_NO, _BASIC_ACCOUNT_NO, value);
				this._BASIC_ACCOUNT_NO = value;
			}
		}
		/// <summary>
		/// 基本户账户名称
		/// </summary>
		public string BASIC_ACCOUNT_NAME
		{
			get{ return _BASIC_ACCOUNT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BASIC_ACCOUNT_NAME, _BASIC_ACCOUNT_NAME, value);
				this._BASIC_ACCOUNT_NAME = value;
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
				_.CREATE_TIME,
				_.VERSION,
				_.DATA_SOURCE,
				_.FILES,
				_.LEGAL_NAME,
				_.LEGAL_OLD_NAME,
				_.LEGAL_CODE,
				_.CREDIT_RATE,
				_.BASIC_BANK,
				_.BASIC_BRANCH_BANK,
				_.BASIC_ACCOUNT_NO,
				_.BASIC_ACCOUNT_NAME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._CREATE_TIME,
				this._VERSION,
				this._DATA_SOURCE,
				this._FILES,
				this._LEGAL_NAME,
				this._LEGAL_OLD_NAME,
				this._LEGAL_CODE,
				this._CREDIT_RATE,
				this._BASIC_BANK,
				this._BASIC_BRANCH_BANK,
				this._BASIC_ACCOUNT_NO,
				this._BASIC_ACCOUNT_NAME,
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
			public readonly static Field All = new Field("*", "ZJPRI_EXT_COMPANY");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "ZJPRI_EXT_COMPANY", "");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "ZJPRI_EXT_COMPANY", "创建时间");
            /// <summary>
			/// 版本号
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "ZJPRI_EXT_COMPANY", "版本号");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field DATA_SOURCE = new Field("DATA_SOURCE", "ZJPRI_EXT_COMPANY", "数据来源");
            /// <summary>
			/// 附件
			/// </summary>
			public readonly static Field FILES = new Field("FILES", "ZJPRI_EXT_COMPANY", "附件");
            /// <summary>
			/// 法人名称(企业名称)
			/// </summary>
			public readonly static Field LEGAL_NAME = new Field("LEGAL_NAME", "ZJPRI_EXT_COMPANY", "法人名称(企业名称)");
            /// <summary>
			/// 企业曾用名
			/// </summary>
			public readonly static Field LEGAL_OLD_NAME = new Field("LEGAL_OLD_NAME", "ZJPRI_EXT_COMPANY", "企业曾用名");
            /// <summary>
			/// 社会信用统一代码
			/// </summary>
			public readonly static Field LEGAL_CODE = new Field("LEGAL_CODE", "ZJPRI_EXT_COMPANY", "社会信用统一代码");
            /// <summary>
			/// 资信等级
			/// </summary>
			public readonly static Field CREDIT_RATE = new Field("CREDIT_RATE", "ZJPRI_EXT_COMPANY", "资信等级");
            /// <summary>
			/// 基本户开户银行
			/// </summary>
			public readonly static Field BASIC_BANK = new Field("BASIC_BANK", "ZJPRI_EXT_COMPANY", "基本户开户银行");
            /// <summary>
			/// 基本户开户支行号
			/// </summary>
			public readonly static Field BASIC_BRANCH_BANK = new Field("BASIC_BRANCH_BANK", "ZJPRI_EXT_COMPANY", "基本户开户支行号");
            /// <summary>
			/// 基本户账号
			/// </summary>
			public readonly static Field BASIC_ACCOUNT_NO = new Field("BASIC_ACCOUNT_NO", "ZJPRI_EXT_COMPANY", "基本户账号");
            /// <summary>
			/// 基本户账户名称
			/// </summary>
			public readonly static Field BASIC_ACCOUNT_NAME = new Field("BASIC_ACCOUNT_NAME", "ZJPRI_EXT_COMPANY", "基本户账户名称");
        }
        #endregion
	}
}