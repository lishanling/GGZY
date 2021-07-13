using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MINING_DISTRIVT_RANGE_PUB。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MINING_DISTRIVT_RANGE_PUB")]
    [Serializable]
    public partial class MINING_DISTRIVT_RANGE_PUB : FwEntity
    {
        #region Model
		private string _NA_APP_NAME;
		private string _UNIFIED_DEAL_CODE;
		private string _NA_APPLY_PERSON;
		private string _APPLY_TYPE;
		private string _APPLY_CODE;
		private string _APPLY_ROLE;
		private decimal? _QT_DESIGN_SCOPE;
		private string _NA_SCOPE_UNIT;
		private string _NA_GOV_NAME;
		private decimal? _IN_BUY_KIND;
		private decimal? _IN_MINE_COME;
		private DateTime? _DT_RECIVE_DATE;
		private string _PLATFORM_CODE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;

		/// <summary>
		/// 项目名称
		/// </summary>
		public string NA_APP_NAME
		{
			get{ return _NA_APP_NAME; }
			set
			{
				this.OnPropertyValueChange(_.NA_APP_NAME, _NA_APP_NAME, value);
				this._NA_APP_NAME = value;
			}
		}
		/// <summary>
		/// 统一交易标识码
		/// </summary>
		public string UNIFIED_DEAL_CODE
		{
			get{ return _UNIFIED_DEAL_CODE; }
			set
			{
				this.OnPropertyValueChange(_.UNIFIED_DEAL_CODE, _UNIFIED_DEAL_CODE, value);
				this._UNIFIED_DEAL_CODE = value;
			}
		}
		/// <summary>
		/// 申请人
		/// </summary>
		public string NA_APPLY_PERSON
		{
			get{ return _NA_APPLY_PERSON; }
			set
			{
				this.OnPropertyValueChange(_.NA_APPLY_PERSON, _NA_APPLY_PERSON, value);
				this._NA_APPLY_PERSON = value;
			}
		}
		/// <summary>
		/// 申请人类别
		/// </summary>
		public string APPLY_TYPE
		{
			get{ return _APPLY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.APPLY_TYPE, _APPLY_TYPE, value);
				this._APPLY_TYPE = value;
			}
		}
		/// <summary>
		/// 申请人代码
		/// </summary>
		public string APPLY_CODE
		{
			get{ return _APPLY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.APPLY_CODE, _APPLY_CODE, value);
				this._APPLY_CODE = value;
			}
		}
		/// <summary>
		/// 申请人角色
		/// </summary>
		public string APPLY_ROLE
		{
			get{ return _APPLY_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.APPLY_ROLE, _APPLY_ROLE, value);
				this._APPLY_ROLE = value;
			}
		}
		/// <summary>
		/// 设计生产规模
		/// </summary>
		public decimal? QT_DESIGN_SCOPE
		{
			get{ return _QT_DESIGN_SCOPE; }
			set
			{
				this.OnPropertyValueChange(_.QT_DESIGN_SCOPE, _QT_DESIGN_SCOPE, value);
				this._QT_DESIGN_SCOPE = value;
			}
		}
		/// <summary>
		/// 规模单位
		/// </summary>
		public string NA_SCOPE_UNIT
		{
			get{ return _NA_SCOPE_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.NA_SCOPE_UNIT, _NA_SCOPE_UNIT, value);
				this._NA_SCOPE_UNIT = value;
			}
		}
		/// <summary>
		/// 审批机关
		/// </summary>
		public string NA_GOV_NAME
		{
			get{ return _NA_GOV_NAME; }
			set
			{
				this.OnPropertyValueChange(_.NA_GOV_NAME, _NA_GOV_NAME, value);
				this._NA_GOV_NAME = value;
			}
		}
		/// <summary>
		/// 取得方式
		/// </summary>
		public decimal? IN_BUY_KIND
		{
			get{ return _IN_BUY_KIND; }
			set
			{
				this.OnPropertyValueChange(_.IN_BUY_KIND, _IN_BUY_KIND, value);
				this._IN_BUY_KIND = value;
			}
		}
		/// <summary>
		/// 开采主矿种
		/// </summary>
		public decimal? IN_MINE_COME
		{
			get{ return _IN_MINE_COME; }
			set
			{
				this.OnPropertyValueChange(_.IN_MINE_COME, _IN_MINE_COME, value);
				this._IN_MINE_COME = value;
			}
		}
		/// <summary>
		/// 受理日期
		/// </summary>
		public DateTime? DT_RECIVE_DATE
		{
			get{ return _DT_RECIVE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.DT_RECIVE_DATE, _DT_RECIVE_DATE, value);
				this._DT_RECIVE_DATE = value;
			}
		}
		/// <summary>
		/// 交易平台标识码
		/// </summary>
		public string PLATFORM_CODE
		{
			get{ return _PLATFORM_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PLATFORM_CODE, _PLATFORM_CODE, value);
				this._PLATFORM_CODE = value;
			}
		}
		/// <summary>
		/// 公共服务平台标识码
		/// </summary>
		public string PUB_SERVICE_PLAT_CODE
		{
			get{ return _PUB_SERVICE_PLAT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PUB_SERVICE_PLAT_CODE, _PUB_SERVICE_PLAT_CODE, value);
				this._PUB_SERVICE_PLAT_CODE = value;
			}
		}
		/// <summary>
		/// 数据时间戳
		/// </summary>
		public DateTime? DATA_TIMESTAMP
		{
			get{ return _DATA_TIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATA_TIMESTAMP, _DATA_TIMESTAMP, value);
				this._DATA_TIMESTAMP = value;
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
				_.NA_APP_NAME,
				_.NA_APPLY_PERSON,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.NA_APP_NAME,
				_.UNIFIED_DEAL_CODE,
				_.NA_APPLY_PERSON,
				_.APPLY_TYPE,
				_.APPLY_CODE,
				_.APPLY_ROLE,
				_.QT_DESIGN_SCOPE,
				_.NA_SCOPE_UNIT,
				_.NA_GOV_NAME,
				_.IN_BUY_KIND,
				_.IN_MINE_COME,
				_.DT_RECIVE_DATE,
				_.PLATFORM_CODE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._NA_APP_NAME,
				this._UNIFIED_DEAL_CODE,
				this._NA_APPLY_PERSON,
				this._APPLY_TYPE,
				this._APPLY_CODE,
				this._APPLY_ROLE,
				this._QT_DESIGN_SCOPE,
				this._NA_SCOPE_UNIT,
				this._NA_GOV_NAME,
				this._IN_BUY_KIND,
				this._IN_MINE_COME,
				this._DT_RECIVE_DATE,
				this._PLATFORM_CODE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
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
			public readonly static Field All = new Field("*", "MINING_DISTRIVT_RANGE_PUB");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field NA_APP_NAME = new Field("NA_APP_NAME", "MINING_DISTRIVT_RANGE_PUB", "项目名称");
            /// <summary>
			/// 统一交易标识码
			/// </summary>
			public readonly static Field UNIFIED_DEAL_CODE = new Field("UNIFIED_DEAL_CODE", "MINING_DISTRIVT_RANGE_PUB", "统一交易标识码");
            /// <summary>
			/// 申请人
			/// </summary>
			public readonly static Field NA_APPLY_PERSON = new Field("NA_APPLY_PERSON", "MINING_DISTRIVT_RANGE_PUB", "申请人");
            /// <summary>
			/// 申请人类别
			/// </summary>
			public readonly static Field APPLY_TYPE = new Field("APPLY_TYPE", "MINING_DISTRIVT_RANGE_PUB", "申请人类别");
            /// <summary>
			/// 申请人代码
			/// </summary>
			public readonly static Field APPLY_CODE = new Field("APPLY_CODE", "MINING_DISTRIVT_RANGE_PUB", "申请人代码");
            /// <summary>
			/// 申请人角色
			/// </summary>
			public readonly static Field APPLY_ROLE = new Field("APPLY_ROLE", "MINING_DISTRIVT_RANGE_PUB", "申请人角色");
            /// <summary>
			/// 设计生产规模
			/// </summary>
			public readonly static Field QT_DESIGN_SCOPE = new Field("QT_DESIGN_SCOPE", "MINING_DISTRIVT_RANGE_PUB", "设计生产规模");
            /// <summary>
			/// 规模单位
			/// </summary>
			public readonly static Field NA_SCOPE_UNIT = new Field("NA_SCOPE_UNIT", "MINING_DISTRIVT_RANGE_PUB", "规模单位");
            /// <summary>
			/// 审批机关
			/// </summary>
			public readonly static Field NA_GOV_NAME = new Field("NA_GOV_NAME", "MINING_DISTRIVT_RANGE_PUB", "审批机关");
            /// <summary>
			/// 取得方式
			/// </summary>
			public readonly static Field IN_BUY_KIND = new Field("IN_BUY_KIND", "MINING_DISTRIVT_RANGE_PUB", "取得方式");
            /// <summary>
			/// 开采主矿种
			/// </summary>
			public readonly static Field IN_MINE_COME = new Field("IN_MINE_COME", "MINING_DISTRIVT_RANGE_PUB", "开采主矿种");
            /// <summary>
			/// 受理日期
			/// </summary>
			public readonly static Field DT_RECIVE_DATE = new Field("DT_RECIVE_DATE", "MINING_DISTRIVT_RANGE_PUB", "受理日期");
            /// <summary>
			/// 交易平台标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "MINING_DISTRIVT_RANGE_PUB", "交易平台标识码");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "MINING_DISTRIVT_RANGE_PUB", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "MINING_DISTRIVT_RANGE_PUB", "数据时间戳");
        }
        #endregion
	}
}