using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类DB_SYSTEM。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("DB_SYSTEM")]
    [Serializable]
    public partial class DB_SYSTEM : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _C_CODE;
		private string _BU_CODE;
		private string _F_NATURE;
		private string _F_TYPE;
		private string _SO_INDI;
		private string _P_TYPE;
		private string _S_METHOD;
		private string _U_APPID;
		private string _U_APP;
		private DateTime? _APP_DATE;
		private string _APP_AOM;
		private string _E_PERID;
		private string _E_PER;
		private DateTime? _E_DATE;
		private string _U_AUDITORID;
		private string _U_AUDITOR;
		private DateTime? _U_CHECK_DATE;
		private string _U_SENDERID;
		private string _U_SENDER;
		private DateTime? _U_DATE;
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
		/// 资金性质
		/// </summary>
		public string F_NATURE
		{
			get{ return _F_NATURE; }
			set
			{
				this.OnPropertyValueChange(_.F_NATURE, _F_NATURE, value);
				this._F_NATURE = value;
			}
		}
		/// <summary>
		/// 经费类型
		/// </summary>
		public string F_TYPE
		{
			get{ return _F_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.F_TYPE, _F_TYPE, value);
				this._F_TYPE = value;
			}
		}
		/// <summary>
		/// 指标来源
		/// </summary>
		public string SO_INDI
		{
			get{ return _SO_INDI; }
			set
			{
				this.OnPropertyValueChange(_.SO_INDI, _SO_INDI, value);
				this._SO_INDI = value;
			}
		}
		/// <summary>
		/// 支付类型
		/// </summary>
		public string P_TYPE
		{
			get{ return _P_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.P_TYPE, _P_TYPE, value);
				this._P_TYPE = value;
			}
		}
		/// <summary>
		/// 结算方式
		/// </summary>
		public string S_METHOD
		{
			get{ return _S_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.S_METHOD, _S_METHOD, value);
				this._S_METHOD = value;
			}
		}
		/// <summary>
		/// 单位申请人ID
		/// </summary>
		public string U_APPID
		{
			get{ return _U_APPID; }
			set
			{
				this.OnPropertyValueChange(_.U_APPID, _U_APPID, value);
				this._U_APPID = value;
			}
		}
		/// <summary>
		/// 单位申请人
		/// </summary>
		public string U_APP
		{
			get{ return _U_APP; }
			set
			{
				this.OnPropertyValueChange(_.U_APP, _U_APP, value);
				this._U_APP = value;
			}
		}
		/// <summary>
		/// 申请日期
		/// </summary>
		public DateTime? APP_DATE
		{
			get{ return _APP_DATE; }
			set
			{
				this.OnPropertyValueChange(_.APP_DATE, _APP_DATE, value);
				this._APP_DATE = value;
			}
		}
		/// <summary>
		/// 申请金额
		/// </summary>
		public string APP_AOM
		{
			get{ return _APP_AOM; }
			set
			{
				this.OnPropertyValueChange(_.APP_AOM, _APP_AOM, value);
				this._APP_AOM = value;
			}
		}
		/// <summary>
		/// 录入人ID
		/// </summary>
		public string E_PERID
		{
			get{ return _E_PERID; }
			set
			{
				this.OnPropertyValueChange(_.E_PERID, _E_PERID, value);
				this._E_PERID = value;
			}
		}
		/// <summary>
		/// 录入人
		/// </summary>
		public string E_PER
		{
			get{ return _E_PER; }
			set
			{
				this.OnPropertyValueChange(_.E_PER, _E_PER, value);
				this._E_PER = value;
			}
		}
		/// <summary>
		/// 录入日期
		/// </summary>
		public DateTime? E_DATE
		{
			get{ return _E_DATE; }
			set
			{
				this.OnPropertyValueChange(_.E_DATE, _E_DATE, value);
				this._E_DATE = value;
			}
		}
		/// <summary>
		/// 单位审核人ID
		/// </summary>
		public string U_AUDITORID
		{
			get{ return _U_AUDITORID; }
			set
			{
				this.OnPropertyValueChange(_.U_AUDITORID, _U_AUDITORID, value);
				this._U_AUDITORID = value;
			}
		}
		/// <summary>
		/// 单位审核人
		/// </summary>
		public string U_AUDITOR
		{
			get{ return _U_AUDITOR; }
			set
			{
				this.OnPropertyValueChange(_.U_AUDITOR, _U_AUDITOR, value);
				this._U_AUDITOR = value;
			}
		}
		/// <summary>
		/// 单位审核日期
		/// </summary>
		public DateTime? U_CHECK_DATE
		{
			get{ return _U_CHECK_DATE; }
			set
			{
				this.OnPropertyValueChange(_.U_CHECK_DATE, _U_CHECK_DATE, value);
				this._U_CHECK_DATE = value;
			}
		}
		/// <summary>
		/// 单位发送人ID
		/// </summary>
		public string U_SENDERID
		{
			get{ return _U_SENDERID; }
			set
			{
				this.OnPropertyValueChange(_.U_SENDERID, _U_SENDERID, value);
				this._U_SENDERID = value;
			}
		}
		/// <summary>
		/// 单位发送人
		/// </summary>
		public string U_SENDER
		{
			get{ return _U_SENDER; }
			set
			{
				this.OnPropertyValueChange(_.U_SENDER, _U_SENDER, value);
				this._U_SENDER = value;
			}
		}
		/// <summary>
		/// 发送人日期
		/// </summary>
		public DateTime? U_DATE
		{
			get{ return _U_DATE; }
			set
			{
				this.OnPropertyValueChange(_.U_DATE, _U_DATE, value);
				this._U_DATE = value;
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
				_.BU_CODE,
				_.F_NATURE,
				_.F_TYPE,
				_.SO_INDI,
				_.P_TYPE,
				_.S_METHOD,
				_.U_APPID,
				_.U_APP,
				_.APP_DATE,
				_.APP_AOM,
				_.E_PERID,
				_.E_PER,
				_.E_DATE,
				_.U_AUDITORID,
				_.U_AUDITOR,
				_.U_CHECK_DATE,
				_.U_SENDERID,
				_.U_SENDER,
				_.U_DATE,
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
				this._BU_CODE,
				this._F_NATURE,
				this._F_TYPE,
				this._SO_INDI,
				this._P_TYPE,
				this._S_METHOD,
				this._U_APPID,
				this._U_APP,
				this._APP_DATE,
				this._APP_AOM,
				this._E_PERID,
				this._E_PER,
				this._E_DATE,
				this._U_AUDITORID,
				this._U_AUDITOR,
				this._U_CHECK_DATE,
				this._U_SENDERID,
				this._U_SENDER,
				this._U_DATE,
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
			public readonly static Field All = new Field("*", "DB_SYSTEM");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "DB_SYSTEM", "ID");
            /// <summary>
			/// 公司代码
			/// </summary>
			public readonly static Field C_CODE = new Field("C_CODE", "DB_SYSTEM", "公司代码");
            /// <summary>
			/// 预算单位代码
			/// </summary>
			public readonly static Field BU_CODE = new Field("BU_CODE", "DB_SYSTEM", "预算单位代码");
            /// <summary>
			/// 资金性质
			/// </summary>
			public readonly static Field F_NATURE = new Field("F_NATURE", "DB_SYSTEM", "资金性质");
            /// <summary>
			/// 经费类型
			/// </summary>
			public readonly static Field F_TYPE = new Field("F_TYPE", "DB_SYSTEM", "经费类型");
            /// <summary>
			/// 指标来源
			/// </summary>
			public readonly static Field SO_INDI = new Field("SO_INDI", "DB_SYSTEM", "指标来源");
            /// <summary>
			/// 支付类型
			/// </summary>
			public readonly static Field P_TYPE = new Field("P_TYPE", "DB_SYSTEM", "支付类型");
            /// <summary>
			/// 结算方式
			/// </summary>
			public readonly static Field S_METHOD = new Field("S_METHOD", "DB_SYSTEM", "结算方式");
            /// <summary>
			/// 单位申请人ID
			/// </summary>
			public readonly static Field U_APPID = new Field("U_APPID", "DB_SYSTEM", "单位申请人ID");
            /// <summary>
			/// 单位申请人
			/// </summary>
			public readonly static Field U_APP = new Field("U_APP", "DB_SYSTEM", "单位申请人");
            /// <summary>
			/// 申请日期
			/// </summary>
			public readonly static Field APP_DATE = new Field("APP_DATE", "DB_SYSTEM", "申请日期");
            /// <summary>
			/// 申请金额
			/// </summary>
			public readonly static Field APP_AOM = new Field("APP_AOM", "DB_SYSTEM", "申请金额");
            /// <summary>
			/// 录入人ID
			/// </summary>
			public readonly static Field E_PERID = new Field("E_PERID", "DB_SYSTEM", "录入人ID");
            /// <summary>
			/// 录入人
			/// </summary>
			public readonly static Field E_PER = new Field("E_PER", "DB_SYSTEM", "录入人");
            /// <summary>
			/// 录入日期
			/// </summary>
			public readonly static Field E_DATE = new Field("E_DATE", "DB_SYSTEM", "录入日期");
            /// <summary>
			/// 单位审核人ID
			/// </summary>
			public readonly static Field U_AUDITORID = new Field("U_AUDITORID", "DB_SYSTEM", "单位审核人ID");
            /// <summary>
			/// 单位审核人
			/// </summary>
			public readonly static Field U_AUDITOR = new Field("U_AUDITOR", "DB_SYSTEM", "单位审核人");
            /// <summary>
			/// 单位审核日期
			/// </summary>
			public readonly static Field U_CHECK_DATE = new Field("U_CHECK_DATE", "DB_SYSTEM", "单位审核日期");
            /// <summary>
			/// 单位发送人ID
			/// </summary>
			public readonly static Field U_SENDERID = new Field("U_SENDERID", "DB_SYSTEM", "单位发送人ID");
            /// <summary>
			/// 单位发送人
			/// </summary>
			public readonly static Field U_SENDER = new Field("U_SENDER", "DB_SYSTEM", "单位发送人");
            /// <summary>
			/// 发送人日期
			/// </summary>
			public readonly static Field U_DATE = new Field("U_DATE", "DB_SYSTEM", "发送人日期");
            /// <summary>
			/// 数据上传时间
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "DB_SYSTEM", "数据上传时间");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "DB_SYSTEM", "数据来源");
            /// <summary>
			/// 数据对应的唯一标识码
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "DB_SYSTEM", "数据对应的唯一标识码");
        }
        #endregion
	}
}