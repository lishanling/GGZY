using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_ZT_BIDDERCONTRACT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_ZT_BIDDERCONTRACT")]
    [Serializable]
    public partial class T_ZT_BIDDERCONTRACT : FwEntity
    {
        #region Model
		private string _BIDDERNO;
		private string _SECTIONNO;
		private string _SECTIONNAME;
		private string _TENDERNO;
		private string _TENDERNAME;
		private decimal? _BIDAMOUNT;
		private string _CONTRACTAMOUNT;
		private string _CURRENCY;
		private string _MONEYUNIT;
		private DateTime? _CONTRACTSIGNDATE;
		private string _DATASOURCECODE;
		private DateTime? _DATATIMESTAMP;

		/// <summary>
		/// 主体代码
		/// </summary>
		public string BIDDERNO
		{
			get{ return _BIDDERNO; }
			set
			{
				this.OnPropertyValueChange(_.BIDDERNO, _BIDDERNO, value);
				this._BIDDERNO = value;
			}
		}
		/// <summary>
		/// 交易项目编码
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
		/// 交易项目名称
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
		/// 招标人（采购人/出让人）代码
		/// </summary>
		public string TENDERNO
		{
			get{ return _TENDERNO; }
			set
			{
				this.OnPropertyValueChange(_.TENDERNO, _TENDERNO, value);
				this._TENDERNO = value;
			}
		}
		/// <summary>
		/// 招标人（采购人/出让人）名称
		/// </summary>
		public string TENDERNAME
		{
			get{ return _TENDERNAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDERNAME, _TENDERNAME, value);
				this._TENDERNAME = value;
			}
		}
		/// <summary>
		/// 中标（成交/竞得）金额
		/// </summary>
		public decimal? BIDAMOUNT
		{
			get{ return _BIDAMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.BIDAMOUNT, _BIDAMOUNT, value);
				this._BIDAMOUNT = value;
			}
		}
		/// <summary>
		/// 交易分类
		/// </summary>
		public string CONTRACTAMOUNT
		{
			get{ return _CONTRACTAMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.CONTRACTAMOUNT, _CONTRACTAMOUNT, value);
				this._CONTRACTAMOUNT = value;
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
				_.BIDDERNO,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.BIDDERNO,
				_.SECTIONNO,
				_.SECTIONNAME,
				_.TENDERNO,
				_.TENDERNAME,
				_.BIDAMOUNT,
				_.CONTRACTAMOUNT,
				_.CURRENCY,
				_.MONEYUNIT,
				_.CONTRACTSIGNDATE,
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
				this._BIDDERNO,
				this._SECTIONNO,
				this._SECTIONNAME,
				this._TENDERNO,
				this._TENDERNAME,
				this._BIDAMOUNT,
				this._CONTRACTAMOUNT,
				this._CURRENCY,
				this._MONEYUNIT,
				this._CONTRACTSIGNDATE,
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
			public readonly static Field All = new Field("*", "T_ZT_BIDDERCONTRACT");
            /// <summary>
			/// 主体代码
			/// </summary>
			public readonly static Field BIDDERNO = new Field("BIDDERNO", "T_ZT_BIDDERCONTRACT", "主体代码");
            /// <summary>
			/// 交易项目编码
			/// </summary>
			public readonly static Field SECTIONNO = new Field("SECTIONNO", "T_ZT_BIDDERCONTRACT", "交易项目编码");
            /// <summary>
			/// 交易项目名称
			/// </summary>
			public readonly static Field SECTIONNAME = new Field("SECTIONNAME", "T_ZT_BIDDERCONTRACT", "交易项目名称");
            /// <summary>
			/// 招标人（采购人/出让人）代码
			/// </summary>
			public readonly static Field TENDERNO = new Field("TENDERNO", "T_ZT_BIDDERCONTRACT", "招标人（采购人/出让人）代码");
            /// <summary>
			/// 招标人（采购人/出让人）名称
			/// </summary>
			public readonly static Field TENDERNAME = new Field("TENDERNAME", "T_ZT_BIDDERCONTRACT", "招标人（采购人/出让人）名称");
            /// <summary>
			/// 中标（成交/竞得）金额
			/// </summary>
			public readonly static Field BIDAMOUNT = new Field("BIDAMOUNT", "T_ZT_BIDDERCONTRACT", "中标（成交/竞得）金额");
            /// <summary>
			/// 交易分类
			/// </summary>
			public readonly static Field CONTRACTAMOUNT = new Field("CONTRACTAMOUNT", "T_ZT_BIDDERCONTRACT", "交易分类");
            /// <summary>
			/// 金额币种代码
			/// </summary>
			public readonly static Field CURRENCY = new Field("CURRENCY", "T_ZT_BIDDERCONTRACT", "金额币种代码");
            /// <summary>
			/// 金额单位
			/// </summary>
			public readonly static Field MONEYUNIT = new Field("MONEYUNIT", "T_ZT_BIDDERCONTRACT", "金额单位");
            /// <summary>
			/// 合同签署时间
			/// </summary>
			public readonly static Field CONTRACTSIGNDATE = new Field("CONTRACTSIGNDATE", "T_ZT_BIDDERCONTRACT", "合同签署时间");
            /// <summary>
			/// 来源平台编码
			/// </summary>
			public readonly static Field DATASOURCECODE = new Field("DATASOURCECODE", "T_ZT_BIDDERCONTRACT", "来源平台编码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATATIMESTAMP = new Field("DATATIMESTAMP", "T_ZT_BIDDERCONTRACT", "数据时间戳");
        }
        #endregion
	}
}