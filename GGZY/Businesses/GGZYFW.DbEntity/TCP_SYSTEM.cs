using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TCP_SYSTEM。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TCP_SYSTEM")]
    [Serializable]
    public partial class TCP_SYSTEM : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _C_CODE;
		private string _APP_CATEGORY;
		private string _V_NUMBER;
		private DateTime? _V_DATE;
		private string _D_NUMBER;
		private string _BU_CODE;
		private string _BU_BANK_NUMBER;
		private DateTime? _APPLY_DATE;
		private string _PAYER_ID;
		private string _PAYER;
		private string _PAYER_BANK_NUMBER;
		private string _PAYER_BANK_LNUMBER;
		private string _PAYER_DE_BANK;
		private string _PAYEE_ID;
		private string _PAYEE;
		private string _PAYEE_AN;
		private string _PAYEE_DE_BANK;
		private string _PAYEE_BANK_LNUMBER;
		private string _LOGINP_ID;
		private string _LOGINP;
		private DateTime? _LOGIN_DATE;
		private string _AUDITOR_ID;
		private string _AUDITOR;
		private DateTime? _A_DATE;
		private string _CONFIRMP_ID;
		private string _CONFIRMP;
		private DateTime? _CONFIRM_DATE;
		private string _SETTLEP_ID;
		private string _SETTLEP;
		private DateTime? _SETTLE_DATE;
		private string _APP_TYPE;
		private string _STATUS;
		private DateTime? _M_TM;
		private string _M_DATA_SOURCE;
		private string _DATA_KEY;

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
		/// 公司代码
		/// </summary>
		public string C_CODE
		{
			get{ return _C_CODE; }
			set
			{
				this.OnPropertyValueChange(_.C_CODE, _C_CODE, value);
				this._C_CODE = value;
			}
		}
		/// <summary>
		/// 拨款单类别
		/// </summary>
		public string APP_CATEGORY
		{
			get{ return _APP_CATEGORY; }
			set
			{
				this.OnPropertyValueChange(_.APP_CATEGORY, _APP_CATEGORY, value);
				this._APP_CATEGORY = value;
			}
		}
		/// <summary>
		/// 凭单号
		/// </summary>
		public string V_NUMBER
		{
			get{ return _V_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.V_NUMBER, _V_NUMBER, value);
				this._V_NUMBER = value;
			}
		}
		/// <summary>
		/// 凭单日期
		/// </summary>
		public DateTime? V_DATE
		{
			get{ return _V_DATE; }
			set
			{
				this.OnPropertyValueChange(_.V_DATE, _V_DATE, value);
				this._V_DATE = value;
			}
		}
		/// <summary>
		/// 单据编号
		/// </summary>
		public string D_NUMBER
		{
			get{ return _D_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.D_NUMBER, _D_NUMBER, value);
				this._D_NUMBER = value;
			}
		}
		/// <summary>
		/// 预算单位代码
		/// </summary>
		public string BU_CODE
		{
			get{ return _BU_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BU_CODE, _BU_CODE, value);
				this._BU_CODE = value;
			}
		}
		/// <summary>
		/// 预算单位银行编号
		/// </summary>
		public string BU_BANK_NUMBER
		{
			get{ return _BU_BANK_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.BU_BANK_NUMBER, _BU_BANK_NUMBER, value);
				this._BU_BANK_NUMBER = value;
			}
		}
		/// <summary>
		/// 申请日期
		/// </summary>
		public DateTime? APPLY_DATE
		{
			get{ return _APPLY_DATE; }
			set
			{
				this.OnPropertyValueChange(_.APPLY_DATE, _APPLY_DATE, value);
				this._APPLY_DATE = value;
			}
		}
		/// <summary>
		/// 付款人ID
		/// </summary>
		public string PAYER_ID
		{
			get{ return _PAYER_ID; }
			set
			{
				this.OnPropertyValueChange(_.PAYER_ID, _PAYER_ID, value);
				this._PAYER_ID = value;
			}
		}
		/// <summary>
		/// 付款人
		/// </summary>
		public string PAYER
		{
			get{ return _PAYER; }
			set
			{
				this.OnPropertyValueChange(_.PAYER, _PAYER, value);
				this._PAYER = value;
			}
		}
		/// <summary>
		/// 付款人银行编号
		/// </summary>
		public string PAYER_BANK_NUMBER
		{
			get{ return _PAYER_BANK_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.PAYER_BANK_NUMBER, _PAYER_BANK_NUMBER, value);
				this._PAYER_BANK_NUMBER = value;
			}
		}
		/// <summary>
		/// 付款人银行行号
		/// </summary>
		public string PAYER_BANK_LNUMBER
		{
			get{ return _PAYER_BANK_LNUMBER; }
			set
			{
				this.OnPropertyValueChange(_.PAYER_BANK_LNUMBER, _PAYER_BANK_LNUMBER, value);
				this._PAYER_BANK_LNUMBER = value;
			}
		}
		/// <summary>
		/// 付款人开户银行
		/// </summary>
		public string PAYER_DE_BANK
		{
			get{ return _PAYER_DE_BANK; }
			set
			{
				this.OnPropertyValueChange(_.PAYER_DE_BANK, _PAYER_DE_BANK, value);
				this._PAYER_DE_BANK = value;
			}
		}
		/// <summary>
		/// 收款人ID
		/// </summary>
		public string PAYEE_ID
		{
			get{ return _PAYEE_ID; }
			set
			{
				this.OnPropertyValueChange(_.PAYEE_ID, _PAYEE_ID, value);
				this._PAYEE_ID = value;
			}
		}
		/// <summary>
		/// 收款人
		/// </summary>
		public string PAYEE
		{
			get{ return _PAYEE; }
			set
			{
				this.OnPropertyValueChange(_.PAYEE, _PAYEE, value);
				this._PAYEE = value;
			}
		}
		/// <summary>
		/// 收款人账号
		/// </summary>
		public string PAYEE_AN
		{
			get{ return _PAYEE_AN; }
			set
			{
				this.OnPropertyValueChange(_.PAYEE_AN, _PAYEE_AN, value);
				this._PAYEE_AN = value;
			}
		}
		/// <summary>
		/// 收款人开户银行
		/// </summary>
		public string PAYEE_DE_BANK
		{
			get{ return _PAYEE_DE_BANK; }
			set
			{
				this.OnPropertyValueChange(_.PAYEE_DE_BANK, _PAYEE_DE_BANK, value);
				this._PAYEE_DE_BANK = value;
			}
		}
		/// <summary>
		/// 收款人银行行号
		/// </summary>
		public string PAYEE_BANK_LNUMBER
		{
			get{ return _PAYEE_BANK_LNUMBER; }
			set
			{
				this.OnPropertyValueChange(_.PAYEE_BANK_LNUMBER, _PAYEE_BANK_LNUMBER, value);
				this._PAYEE_BANK_LNUMBER = value;
			}
		}
		/// <summary>
		/// 录入人ID
		/// </summary>
		public string LOGINP_ID
		{
			get{ return _LOGINP_ID; }
			set
			{
				this.OnPropertyValueChange(_.LOGINP_ID, _LOGINP_ID, value);
				this._LOGINP_ID = value;
			}
		}
		/// <summary>
		/// 录入人
		/// </summary>
		public string LOGINP
		{
			get{ return _LOGINP; }
			set
			{
				this.OnPropertyValueChange(_.LOGINP, _LOGINP, value);
				this._LOGINP = value;
			}
		}
		/// <summary>
		/// 录入日期
		/// </summary>
		public DateTime? LOGIN_DATE
		{
			get{ return _LOGIN_DATE; }
			set
			{
				this.OnPropertyValueChange(_.LOGIN_DATE, _LOGIN_DATE, value);
				this._LOGIN_DATE = value;
			}
		}
		/// <summary>
		/// 审核人ID
		/// </summary>
		public string AUDITOR_ID
		{
			get{ return _AUDITOR_ID; }
			set
			{
				this.OnPropertyValueChange(_.AUDITOR_ID, _AUDITOR_ID, value);
				this._AUDITOR_ID = value;
			}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string AUDITOR
		{
			get{ return _AUDITOR; }
			set
			{
				this.OnPropertyValueChange(_.AUDITOR, _AUDITOR, value);
				this._AUDITOR = value;
			}
		}
		/// <summary>
		/// 审核日期
		/// </summary>
		public DateTime? A_DATE
		{
			get{ return _A_DATE; }
			set
			{
				this.OnPropertyValueChange(_.A_DATE, _A_DATE, value);
				this._A_DATE = value;
			}
		}
		/// <summary>
		/// 确认人ID
		/// </summary>
		public string CONFIRMP_ID
		{
			get{ return _CONFIRMP_ID; }
			set
			{
				this.OnPropertyValueChange(_.CONFIRMP_ID, _CONFIRMP_ID, value);
				this._CONFIRMP_ID = value;
			}
		}
		/// <summary>
		/// 确认人
		/// </summary>
		public string CONFIRMP
		{
			get{ return _CONFIRMP; }
			set
			{
				this.OnPropertyValueChange(_.CONFIRMP, _CONFIRMP, value);
				this._CONFIRMP = value;
			}
		}
		/// <summary>
		/// 确认日期
		/// </summary>
		public DateTime? CONFIRM_DATE
		{
			get{ return _CONFIRM_DATE; }
			set
			{
				this.OnPropertyValueChange(_.CONFIRM_DATE, _CONFIRM_DATE, value);
				this._CONFIRM_DATE = value;
			}
		}
		/// <summary>
		/// 结算人ID
		/// </summary>
		public string SETTLEP_ID
		{
			get{ return _SETTLEP_ID; }
			set
			{
				this.OnPropertyValueChange(_.SETTLEP_ID, _SETTLEP_ID, value);
				this._SETTLEP_ID = value;
			}
		}
		/// <summary>
		/// 结算人
		/// </summary>
		public string SETTLEP
		{
			get{ return _SETTLEP; }
			set
			{
				this.OnPropertyValueChange(_.SETTLEP, _SETTLEP, value);
				this._SETTLEP = value;
			}
		}
		/// <summary>
		/// 结算日期
		/// </summary>
		public DateTime? SETTLE_DATE
		{
			get{ return _SETTLE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.SETTLE_DATE, _SETTLE_DATE, value);
				this._SETTLE_DATE = value;
			}
		}
		/// <summary>
		/// 拨款类型
		/// </summary>
		public string APP_TYPE
		{
			get{ return _APP_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.APP_TYPE, _APP_TYPE, value);
				this._APP_TYPE = value;
			}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public string STATUS
		{
			get{ return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
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
		/// 数据来源
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
		/// 数据对应的唯一标识码
		/// </summary>
		public string DATA_KEY
		{
			get{ return _DATA_KEY; }
			set
			{
				this.OnPropertyValueChange(_.DATA_KEY, _DATA_KEY, value);
				this._DATA_KEY = value;
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
				_.C_CODE,
				_.APP_CATEGORY,
				_.V_NUMBER,
				_.V_DATE,
				_.D_NUMBER,
				_.BU_CODE,
				_.BU_BANK_NUMBER,
				_.APPLY_DATE,
				_.PAYER_ID,
				_.PAYER,
				_.PAYER_BANK_NUMBER,
				_.PAYER_BANK_LNUMBER,
				_.PAYER_DE_BANK,
				_.PAYEE_ID,
				_.PAYEE,
				_.PAYEE_AN,
				_.PAYEE_DE_BANK,
				_.PAYEE_BANK_LNUMBER,
				_.LOGINP_ID,
				_.LOGINP,
				_.LOGIN_DATE,
				_.AUDITOR_ID,
				_.AUDITOR,
				_.A_DATE,
				_.CONFIRMP_ID,
				_.CONFIRMP,
				_.CONFIRM_DATE,
				_.SETTLEP_ID,
				_.SETTLEP,
				_.SETTLE_DATE,
				_.APP_TYPE,
				_.STATUS,
				_.M_TM,
				_.M_DATA_SOURCE,
				_.DATA_KEY,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._C_CODE,
				this._APP_CATEGORY,
				this._V_NUMBER,
				this._V_DATE,
				this._D_NUMBER,
				this._BU_CODE,
				this._BU_BANK_NUMBER,
				this._APPLY_DATE,
				this._PAYER_ID,
				this._PAYER,
				this._PAYER_BANK_NUMBER,
				this._PAYER_BANK_LNUMBER,
				this._PAYER_DE_BANK,
				this._PAYEE_ID,
				this._PAYEE,
				this._PAYEE_AN,
				this._PAYEE_DE_BANK,
				this._PAYEE_BANK_LNUMBER,
				this._LOGINP_ID,
				this._LOGINP,
				this._LOGIN_DATE,
				this._AUDITOR_ID,
				this._AUDITOR,
				this._A_DATE,
				this._CONFIRMP_ID,
				this._CONFIRMP,
				this._CONFIRM_DATE,
				this._SETTLEP_ID,
				this._SETTLEP,
				this._SETTLE_DATE,
				this._APP_TYPE,
				this._STATUS,
				this._M_TM,
				this._M_DATA_SOURCE,
				this._DATA_KEY,
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
			public readonly static Field All = new Field("*", "TCP_SYSTEM");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "TCP_SYSTEM", "ID");
            /// <summary>
			/// 公司代码
			/// </summary>
			public readonly static Field C_CODE = new Field("C_CODE", "TCP_SYSTEM", "公司代码");
            /// <summary>
			/// 拨款单类别
			/// </summary>
			public readonly static Field APP_CATEGORY = new Field("APP_CATEGORY", "TCP_SYSTEM", "拨款单类别");
            /// <summary>
			/// 凭单号
			/// </summary>
			public readonly static Field V_NUMBER = new Field("V_NUMBER", "TCP_SYSTEM", "凭单号");
            /// <summary>
			/// 凭单日期
			/// </summary>
			public readonly static Field V_DATE = new Field("V_DATE", "TCP_SYSTEM", "凭单日期");
            /// <summary>
			/// 单据编号
			/// </summary>
			public readonly static Field D_NUMBER = new Field("D_NUMBER", "TCP_SYSTEM", "单据编号");
            /// <summary>
			/// 预算单位代码
			/// </summary>
			public readonly static Field BU_CODE = new Field("BU_CODE", "TCP_SYSTEM", "预算单位代码");
            /// <summary>
			/// 预算单位银行编号
			/// </summary>
			public readonly static Field BU_BANK_NUMBER = new Field("BU_BANK_NUMBER", "TCP_SYSTEM", "预算单位银行编号");
            /// <summary>
			/// 申请日期
			/// </summary>
			public readonly static Field APPLY_DATE = new Field("APPLY_DATE", "TCP_SYSTEM", "申请日期");
            /// <summary>
			/// 付款人ID
			/// </summary>
			public readonly static Field PAYER_ID = new Field("PAYER_ID", "TCP_SYSTEM", "付款人ID");
            /// <summary>
			/// 付款人
			/// </summary>
			public readonly static Field PAYER = new Field("PAYER", "TCP_SYSTEM", "付款人");
            /// <summary>
			/// 付款人银行编号
			/// </summary>
			public readonly static Field PAYER_BANK_NUMBER = new Field("PAYER_BANK_NUMBER", "TCP_SYSTEM", "付款人银行编号");
            /// <summary>
			/// 付款人银行行号
			/// </summary>
			public readonly static Field PAYER_BANK_LNUMBER = new Field("PAYER_BANK_LNUMBER", "TCP_SYSTEM", "付款人银行行号");
            /// <summary>
			/// 付款人开户银行
			/// </summary>
			public readonly static Field PAYER_DE_BANK = new Field("PAYER_DE_BANK", "TCP_SYSTEM", "付款人开户银行");
            /// <summary>
			/// 收款人ID
			/// </summary>
			public readonly static Field PAYEE_ID = new Field("PAYEE_ID", "TCP_SYSTEM", "收款人ID");
            /// <summary>
			/// 收款人
			/// </summary>
			public readonly static Field PAYEE = new Field("PAYEE", "TCP_SYSTEM", "收款人");
            /// <summary>
			/// 收款人账号
			/// </summary>
			public readonly static Field PAYEE_AN = new Field("PAYEE_AN", "TCP_SYSTEM", "收款人账号");
            /// <summary>
			/// 收款人开户银行
			/// </summary>
			public readonly static Field PAYEE_DE_BANK = new Field("PAYEE_DE_BANK", "TCP_SYSTEM", "收款人开户银行");
            /// <summary>
			/// 收款人银行行号
			/// </summary>
			public readonly static Field PAYEE_BANK_LNUMBER = new Field("PAYEE_BANK_LNUMBER", "TCP_SYSTEM", "收款人银行行号");
            /// <summary>
			/// 录入人ID
			/// </summary>
			public readonly static Field LOGINP_ID = new Field("LOGINP_ID", "TCP_SYSTEM", "录入人ID");
            /// <summary>
			/// 录入人
			/// </summary>
			public readonly static Field LOGINP = new Field("LOGINP", "TCP_SYSTEM", "录入人");
            /// <summary>
			/// 录入日期
			/// </summary>
			public readonly static Field LOGIN_DATE = new Field("LOGIN_DATE", "TCP_SYSTEM", "录入日期");
            /// <summary>
			/// 审核人ID
			/// </summary>
			public readonly static Field AUDITOR_ID = new Field("AUDITOR_ID", "TCP_SYSTEM", "审核人ID");
            /// <summary>
			/// 审核人
			/// </summary>
			public readonly static Field AUDITOR = new Field("AUDITOR", "TCP_SYSTEM", "审核人");
            /// <summary>
			/// 审核日期
			/// </summary>
			public readonly static Field A_DATE = new Field("A_DATE", "TCP_SYSTEM", "审核日期");
            /// <summary>
			/// 确认人ID
			/// </summary>
			public readonly static Field CONFIRMP_ID = new Field("CONFIRMP_ID", "TCP_SYSTEM", "确认人ID");
            /// <summary>
			/// 确认人
			/// </summary>
			public readonly static Field CONFIRMP = new Field("CONFIRMP", "TCP_SYSTEM", "确认人");
            /// <summary>
			/// 确认日期
			/// </summary>
			public readonly static Field CONFIRM_DATE = new Field("CONFIRM_DATE", "TCP_SYSTEM", "确认日期");
            /// <summary>
			/// 结算人ID
			/// </summary>
			public readonly static Field SETTLEP_ID = new Field("SETTLEP_ID", "TCP_SYSTEM", "结算人ID");
            /// <summary>
			/// 结算人
			/// </summary>
			public readonly static Field SETTLEP = new Field("SETTLEP", "TCP_SYSTEM", "结算人");
            /// <summary>
			/// 结算日期
			/// </summary>
			public readonly static Field SETTLE_DATE = new Field("SETTLE_DATE", "TCP_SYSTEM", "结算日期");
            /// <summary>
			/// 拨款类型
			/// </summary>
			public readonly static Field APP_TYPE = new Field("APP_TYPE", "TCP_SYSTEM", "拨款类型");
            /// <summary>
			/// 状态
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "TCP_SYSTEM", "状态");
            /// <summary>
			/// 数据上传时间
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "TCP_SYSTEM", "数据上传时间");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "TCP_SYSTEM", "数据来源");
            /// <summary>
			/// 数据对应的唯一标识码
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "TCP_SYSTEM", "数据对应的唯一标识码");
        }
        #endregion
	}
}