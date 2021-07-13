using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_ZT_PRACTITIONERACHIEVEMENT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_ZT_PRACTITIONERACHIEVEMENT")]
    [Serializable]
    public partial class T_ZT_PRACTITIONERACHIEVEMENT : FwEntity
    {
        #region Model
		private string _IDCARDNO;
		private string _IDCARDTYPE;
		private string _TENDERPROJECTCODE;
		private string _TENDERPROJECTNAME;
		private string _SECTIONNO;
		private string _SECTIONNAME;
		private string _OWNERNO;
		private string _OWNERNAME;
		private decimal? _CONTRACTAMOUNT;
		private string _TRADETYPE;
		private decimal? _SETTLEAMOUNT;
		private string _CURRENCY;
		private string _MONEYUNIT;
		private DateTime? _CONTRACTSIGNDATE;
		private DateTime? _CONTRACTFINISHDATE;
		private string _DATASOURCECODE;
		private DateTime? _DATATIMESTAMP;

		/// <summary>
		/// 人员身份证件号
		/// </summary>
		public string IDCARDNO
		{
			get{ return _IDCARDNO; }
			set
			{
				this.OnPropertyValueChange(_.IDCARDNO, _IDCARDNO, value);
				this._IDCARDNO = value;
			}
		}
		/// <summary>
		/// 人员身份证件类型
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
		/// 交易项目编码
		/// </summary>
		public string TENDERPROJECTCODE
		{
			get{ return _TENDERPROJECTCODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDERPROJECTCODE, _TENDERPROJECTCODE, value);
				this._TENDERPROJECTCODE = value;
			}
		}
		/// <summary>
		/// 交易项目名称
		/// </summary>
		public string TENDERPROJECTNAME
		{
			get{ return _TENDERPROJECTNAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDERPROJECTNAME, _TENDERPROJECTNAME, value);
				this._TENDERPROJECTNAME = value;
			}
		}
		/// <summary>
		/// 标段（包）编号
		/// </summary>
		public string SECTIONNO
		{
			get{ return _SECTIONNO; }
			set
			{
				this.OnPropertyValueChange(_.SECTIONNO, _SECTIONNO, value);
				this._SECTIONNO = value;
			}
		}
		/// <summary>
		/// 标段（包）名称
		/// </summary>
		public string SECTIONNAME
		{
			get{ return _SECTIONNAME; }
			set
			{
				this.OnPropertyValueChange(_.SECTIONNAME, _SECTIONNAME, value);
				this._SECTIONNAME = value;
			}
		}
		/// <summary>
		/// 招标人/采购人/出让人/转让人代码
		/// </summary>
		public string OWNERNO
		{
			get{ return _OWNERNO; }
			set
			{
				this.OnPropertyValueChange(_.OWNERNO, _OWNERNO, value);
				this._OWNERNO = value;
			}
		}
		/// <summary>
		/// 招标人/采购人/出让人/转让人名称
		/// </summary>
		public string OWNERNAME
		{
			get{ return _OWNERNAME; }
			set
			{
				this.OnPropertyValueChange(_.OWNERNAME, _OWNERNAME, value);
				this._OWNERNAME = value;
			}
		}
		/// <summary>
		/// 合同金额
		/// </summary>
		public decimal? CONTRACTAMOUNT
		{
			get{ return _CONTRACTAMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACTAMOUNT, _CONTRACTAMOUNT, value);
				this._CONTRACTAMOUNT = value;
			}
		}
		/// <summary>
		/// 交易分类
		/// </summary>
		public string TRADETYPE
		{
			get{ return _TRADETYPE; }
			set
			{
				this.OnPropertyValueChange(_.TRADETYPE, _TRADETYPE, value);
				this._TRADETYPE = value;
			}
		}
		/// <summary>
		/// 结算金额
		/// </summary>
		public decimal? SETTLEAMOUNT
		{
			get{ return _SETTLEAMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.SETTLEAMOUNT, _SETTLEAMOUNT, value);
				this._SETTLEAMOUNT = value;
			}
		}
		/// <summary>
		/// 金额币种代码
		/// </summary>
		public string CURRENCY
		{
			get{ return _CURRENCY; }
			set
			{
				this.OnPropertyValueChange(_.CURRENCY, _CURRENCY, value);
				this._CURRENCY = value;
			}
		}
		/// <summary>
		/// 金额单位
		/// </summary>
		public string MONEYUNIT
		{
			get{ return _MONEYUNIT; }
			set
			{
				this.OnPropertyValueChange(_.MONEYUNIT, _MONEYUNIT, value);
				this._MONEYUNIT = value;
			}
		}
		/// <summary>
		/// 合同签署时间
		/// </summary>
		public DateTime? CONTRACTSIGNDATE
		{
			get{ return _CONTRACTSIGNDATE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACTSIGNDATE, _CONTRACTSIGNDATE, value);
				this._CONTRACTSIGNDATE = value;
			}
		}
		/// <summary>
		/// 合同完成时间
		/// </summary>
		public DateTime? CONTRACTFINISHDATE
		{
			get{ return _CONTRACTFINISHDATE; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACTFINISHDATE, _CONTRACTFINISHDATE, value);
				this._CONTRACTFINISHDATE = value;
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
				_.IDCARDNO,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.IDCARDNO,
				_.IDCARDTYPE,
				_.TENDERPROJECTCODE,
				_.TENDERPROJECTNAME,
				_.SECTIONNO,
				_.SECTIONNAME,
				_.OWNERNO,
				_.OWNERNAME,
				_.CONTRACTAMOUNT,
				_.TRADETYPE,
				_.SETTLEAMOUNT,
				_.CURRENCY,
				_.MONEYUNIT,
				_.CONTRACTSIGNDATE,
				_.CONTRACTFINISHDATE,
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
				this._IDCARDNO,
				this._IDCARDTYPE,
				this._TENDERPROJECTCODE,
				this._TENDERPROJECTNAME,
				this._SECTIONNO,
				this._SECTIONNAME,
				this._OWNERNO,
				this._OWNERNAME,
				this._CONTRACTAMOUNT,
				this._TRADETYPE,
				this._SETTLEAMOUNT,
				this._CURRENCY,
				this._MONEYUNIT,
				this._CONTRACTSIGNDATE,
				this._CONTRACTFINISHDATE,
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
			public readonly static Field All = new Field("*", "T_ZT_PRACTITIONERACHIEVEMENT");
            /// <summary>
			/// 人员身份证件号
			/// </summary>
			public readonly static Field IDCARDNO = new Field("IDCARDNO", "T_ZT_PRACTITIONERACHIEVEMENT", "人员身份证件号");
            /// <summary>
			/// 人员身份证件类型
			/// </summary>
			public readonly static Field IDCARDTYPE = new Field("IDCARDTYPE", "T_ZT_PRACTITIONERACHIEVEMENT", "人员身份证件类型");
            /// <summary>
			/// 交易项目编码
			/// </summary>
			public readonly static Field TENDERPROJECTCODE = new Field("TENDERPROJECTCODE", "T_ZT_PRACTITIONERACHIEVEMENT", "交易项目编码");
            /// <summary>
			/// 交易项目名称
			/// </summary>
			public readonly static Field TENDERPROJECTNAME = new Field("TENDERPROJECTNAME", "T_ZT_PRACTITIONERACHIEVEMENT", "交易项目名称");
            /// <summary>
			/// 标段（包）编号
			/// </summary>
			public readonly static Field SECTIONNO = new Field("SECTIONNO", "T_ZT_PRACTITIONERACHIEVEMENT", "标段（包）编号");
            /// <summary>
			/// 标段（包）名称
			/// </summary>
			public readonly static Field SECTIONNAME = new Field("SECTIONNAME", "T_ZT_PRACTITIONERACHIEVEMENT", "标段（包）名称");
            /// <summary>
			/// 招标人/采购人/出让人/转让人代码
			/// </summary>
			public readonly static Field OWNERNO = new Field("OWNERNO", "T_ZT_PRACTITIONERACHIEVEMENT", "招标人/采购人/出让人/转让人代码");
            /// <summary>
			/// 招标人/采购人/出让人/转让人名称
			/// </summary>
			public readonly static Field OWNERNAME = new Field("OWNERNAME", "T_ZT_PRACTITIONERACHIEVEMENT", "招标人/采购人/出让人/转让人名称");
            /// <summary>
			/// 合同金额
			/// </summary>
			public readonly static Field CONTRACTAMOUNT = new Field("CONTRACTAMOUNT", "T_ZT_PRACTITIONERACHIEVEMENT", "合同金额");
            /// <summary>
			/// 交易分类
			/// </summary>
			public readonly static Field TRADETYPE = new Field("TRADETYPE", "T_ZT_PRACTITIONERACHIEVEMENT", "交易分类");
            /// <summary>
			/// 结算金额
			/// </summary>
			public readonly static Field SETTLEAMOUNT = new Field("SETTLEAMOUNT", "T_ZT_PRACTITIONERACHIEVEMENT", "结算金额");
            /// <summary>
			/// 金额币种代码
			/// </summary>
			public readonly static Field CURRENCY = new Field("CURRENCY", "T_ZT_PRACTITIONERACHIEVEMENT", "金额币种代码");
            /// <summary>
			/// 金额单位
			/// </summary>
			public readonly static Field MONEYUNIT = new Field("MONEYUNIT", "T_ZT_PRACTITIONERACHIEVEMENT", "金额单位");
            /// <summary>
			/// 合同签署时间
			/// </summary>
			public readonly static Field CONTRACTSIGNDATE = new Field("CONTRACTSIGNDATE", "T_ZT_PRACTITIONERACHIEVEMENT", "合同签署时间");
            /// <summary>
			/// 合同完成时间
			/// </summary>
			public readonly static Field CONTRACTFINISHDATE = new Field("CONTRACTFINISHDATE", "T_ZT_PRACTITIONERACHIEVEMENT", "合同完成时间");
            /// <summary>
			/// 来源平台编码
			/// </summary>
			public readonly static Field DATASOURCECODE = new Field("DATASOURCECODE", "T_ZT_PRACTITIONERACHIEVEMENT", "来源平台编码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATATIMESTAMP = new Field("DATATIMESTAMP", "T_ZT_PRACTITIONERACHIEVEMENT", "数据时间戳");
        }
        #endregion
	}
}