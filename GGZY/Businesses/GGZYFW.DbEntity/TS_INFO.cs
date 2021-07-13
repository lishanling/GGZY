using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TS_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TS_INFO")]
    [Serializable]
    public partial class TS_INFO : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _LP_INFO;
		private string _TP_INFO;
		private string _BAM_INFO;
		private string _BID_INFO;
		private string _PHR_INFO;
		private string _PAM_INFO;
		private string _SUP_INFO;
		private string _TROR_INFO;
		private string _TREE_INFO;
		private string _CP_INFO;
		private string _LP_TP_INFO;
		private string _PRER_BINFO;
		private string _PRER_QINFO;
		private string _PRER_PINFO;
		private string _NP_BINFO;
		private string _DE_UNIT;

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
		/// 法人信息
		/// </summary>
		public string LP_INFO
		{
			get{ return _LP_INFO; }
			set
			{
				this.OnPropertyValueChange(_.LP_INFO, _LP_INFO, value);
				this._LP_INFO = value;
			}
		}
		/// <summary>
		/// 招标人信息
		/// </summary>
		public string TP_INFO
		{
			get{ return _TP_INFO; }
			set
			{
				this.OnPropertyValueChange(_.TP_INFO, _TP_INFO, value);
				this._TP_INFO = value;
			}
		}
		/// <summary>
		/// 招标代理机构信息
		/// </summary>
		public string BAM_INFO
		{
			get{ return _BAM_INFO; }
			set
			{
				this.OnPropertyValueChange(_.BAM_INFO, _BAM_INFO, value);
				this._BAM_INFO = value;
			}
		}
		/// <summary>
		/// 投标人信息
		/// </summary>
		public string BID_INFO
		{
			get{ return _BID_INFO; }
			set
			{
				this.OnPropertyValueChange(_.BID_INFO, _BID_INFO, value);
				this._BID_INFO = value;
			}
		}
		/// <summary>
		/// 采购人信息
		/// </summary>
		public string PHR_INFO
		{
			get{ return _PHR_INFO; }
			set
			{
				this.OnPropertyValueChange(_.PHR_INFO, _PHR_INFO, value);
				this._PHR_INFO = value;
			}
		}
		/// <summary>
		/// 采购代理机构信息
		/// </summary>
		public string PAM_INFO
		{
			get{ return _PAM_INFO; }
			set
			{
				this.OnPropertyValueChange(_.PAM_INFO, _PAM_INFO, value);
				this._PAM_INFO = value;
			}
		}
		/// <summary>
		/// 供应商信息
		/// </summary>
		public string SUP_INFO
		{
			get{ return _SUP_INFO; }
			set
			{
				this.OnPropertyValueChange(_.SUP_INFO, _SUP_INFO, value);
				this._SUP_INFO = value;
			}
		}
		/// <summary>
		/// 出让人信息
		/// </summary>
		public string TROR_INFO
		{
			get{ return _TROR_INFO; }
			set
			{
				this.OnPropertyValueChange(_.TROR_INFO, _TROR_INFO, value);
				this._TROR_INFO = value;
			}
		}
		/// <summary>
		/// 受让人信息
		/// </summary>
		public string TREE_INFO
		{
			get{ return _TREE_INFO; }
			set
			{
				this.OnPropertyValueChange(_.TREE_INFO, _TREE_INFO, value);
				this._TREE_INFO = value;
			}
		}
		/// <summary>
		/// 竞得人信息
		/// </summary>
		public string CP_INFO
		{
			get{ return _CP_INFO; }
			set
			{
				this.OnPropertyValueChange(_.CP_INFO, _CP_INFO, value);
				this._CP_INFO = value;
			}
		}
		/// <summary>
		/// 法人交易业绩信息
		/// </summary>
		public string LP_TP_INFO
		{
			get{ return _LP_TP_INFO; }
			set
			{
				this.OnPropertyValueChange(_.LP_TP_INFO, _LP_TP_INFO, value);
				this._LP_TP_INFO = value;
			}
		}
		/// <summary>
		/// 执业人员基本信息
		/// </summary>
		public string PRER_BINFO
		{
			get{ return _PRER_BINFO; }
			set
			{
				this.OnPropertyValueChange(_.PRER_BINFO, _PRER_BINFO, value);
				this._PRER_BINFO = value;
			}
		}
		/// <summary>
		/// 执业人员资格信息
		/// </summary>
		public string PRER_QINFO
		{
			get{ return _PRER_QINFO; }
			set
			{
				this.OnPropertyValueChange(_.PRER_QINFO, _PRER_QINFO, value);
				this._PRER_QINFO = value;
			}
		}
		/// <summary>
		/// 执业人员业绩信息
		/// </summary>
		public string PRER_PINFO
		{
			get{ return _PRER_PINFO; }
			set
			{
				this.OnPropertyValueChange(_.PRER_PINFO, _PRER_PINFO, value);
				this._PRER_PINFO = value;
			}
		}
		/// <summary>
		/// 自然人基本信息
		/// </summary>
		public string NP_BINFO
		{
			get{ return _NP_BINFO; }
			set
			{
				this.OnPropertyValueChange(_.NP_BINFO, _NP_BINFO, value);
				this._NP_BINFO = value;
			}
		}
		/// <summary>
		/// 下发单位
		/// </summary>
		public string DE_UNIT
		{
			get{ return _DE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.DE_UNIT, _DE_UNIT, value);
				this._DE_UNIT = value;
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
				_.LP_INFO,
				_.TP_INFO,
				_.BAM_INFO,
				_.BID_INFO,
				_.PHR_INFO,
				_.PAM_INFO,
				_.SUP_INFO,
				_.TROR_INFO,
				_.TREE_INFO,
				_.CP_INFO,
				_.LP_TP_INFO,
				_.PRER_BINFO,
				_.PRER_QINFO,
				_.PRER_PINFO,
				_.NP_BINFO,
				_.DE_UNIT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._LP_INFO,
				this._TP_INFO,
				this._BAM_INFO,
				this._BID_INFO,
				this._PHR_INFO,
				this._PAM_INFO,
				this._SUP_INFO,
				this._TROR_INFO,
				this._TREE_INFO,
				this._CP_INFO,
				this._LP_TP_INFO,
				this._PRER_BINFO,
				this._PRER_QINFO,
				this._PRER_PINFO,
				this._NP_BINFO,
				this._DE_UNIT,
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
			public readonly static Field All = new Field("*", "TS_INFO");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "TS_INFO", "ID");
            /// <summary>
			/// 法人信息
			/// </summary>
			public readonly static Field LP_INFO = new Field("LP_INFO", "TS_INFO", "法人信息");
            /// <summary>
			/// 招标人信息
			/// </summary>
			public readonly static Field TP_INFO = new Field("TP_INFO", "TS_INFO", "招标人信息");
            /// <summary>
			/// 招标代理机构信息
			/// </summary>
			public readonly static Field BAM_INFO = new Field("BAM_INFO", "TS_INFO", "招标代理机构信息");
            /// <summary>
			/// 投标人信息
			/// </summary>
			public readonly static Field BID_INFO = new Field("BID_INFO", "TS_INFO", "投标人信息");
            /// <summary>
			/// 采购人信息
			/// </summary>
			public readonly static Field PHR_INFO = new Field("PHR_INFO", "TS_INFO", "采购人信息");
            /// <summary>
			/// 采购代理机构信息
			/// </summary>
			public readonly static Field PAM_INFO = new Field("PAM_INFO", "TS_INFO", "采购代理机构信息");
            /// <summary>
			/// 供应商信息
			/// </summary>
			public readonly static Field SUP_INFO = new Field("SUP_INFO", "TS_INFO", "供应商信息");
            /// <summary>
			/// 出让人信息
			/// </summary>
			public readonly static Field TROR_INFO = new Field("TROR_INFO", "TS_INFO", "出让人信息");
            /// <summary>
			/// 受让人信息
			/// </summary>
			public readonly static Field TREE_INFO = new Field("TREE_INFO", "TS_INFO", "受让人信息");
            /// <summary>
			/// 竞得人信息
			/// </summary>
			public readonly static Field CP_INFO = new Field("CP_INFO", "TS_INFO", "竞得人信息");
            /// <summary>
			/// 法人交易业绩信息
			/// </summary>
			public readonly static Field LP_TP_INFO = new Field("LP_TP_INFO", "TS_INFO", "法人交易业绩信息");
            /// <summary>
			/// 执业人员基本信息
			/// </summary>
			public readonly static Field PRER_BINFO = new Field("PRER_BINFO", "TS_INFO", "执业人员基本信息");
            /// <summary>
			/// 执业人员资格信息
			/// </summary>
			public readonly static Field PRER_QINFO = new Field("PRER_QINFO", "TS_INFO", "执业人员资格信息");
            /// <summary>
			/// 执业人员业绩信息
			/// </summary>
			public readonly static Field PRER_PINFO = new Field("PRER_PINFO", "TS_INFO", "执业人员业绩信息");
            /// <summary>
			/// 自然人基本信息
			/// </summary>
			public readonly static Field NP_BINFO = new Field("NP_BINFO", "TS_INFO", "自然人基本信息");
            /// <summary>
			/// 下发单位
			/// </summary>
			public readonly static Field DE_UNIT = new Field("DE_UNIT", "TS_INFO", "下发单位");
        }
        #endregion
	}
}