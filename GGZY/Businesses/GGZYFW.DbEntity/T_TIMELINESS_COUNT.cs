using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_TIMELINESS_COUNT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_TIMELINESS_COUNT")]
    [Serializable]
    public partial class T_TIMELINESS_COUNT : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _M_DATA_SOURCE;
		private DateTime? _COUNT_TIME;
		private DateTime? _INSERT_TIME;
		private string _BEFORE_SEVEN;
		private string _BEFORE_FOUR;
		private string _BEFORE_THREE;
		private string _TODAY_COUNT;
		private string _AFTER_THREE;
		private string _AFTER_FOUR;
		private string _AFTER_SEVEN;
		private string _M_MODULE;
		private string _M_TABLE_CN_NAME;
		private string _M_TABLE_EN_NAME;
		private string _SYS_CODE;
		private string _PLATFORM_CODE;

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
		/// 某天的数据统计
		/// </summary>
		public DateTime? COUNT_TIME
		{
			get{ return _COUNT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.COUNT_TIME, _COUNT_TIME, value);
				this._COUNT_TIME = value;
			}
		}
		/// <summary>
		/// 统计时间
		/// </summary>
		public DateTime? INSERT_TIME
		{
			get{ return _INSERT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.INSERT_TIME, _INSERT_TIME, value);
				this._INSERT_TIME = value;
			}
		}
		/// <summary>
		/// -7天
		/// </summary>
		public string BEFORE_SEVEN
		{
			get{ return _BEFORE_SEVEN; }
			set
			{
				this.OnPropertyValueChange(_.BEFORE_SEVEN, _BEFORE_SEVEN, value);
				this._BEFORE_SEVEN = value;
			}
		}
		/// <summary>
		/// -4到-7天
		/// </summary>
		public string BEFORE_FOUR
		{
			get{ return _BEFORE_FOUR; }
			set
			{
				this.OnPropertyValueChange(_.BEFORE_FOUR, _BEFORE_FOUR, value);
				this._BEFORE_FOUR = value;
			}
		}
		/// <summary>
		/// -2到-3天
		/// </summary>
		public string BEFORE_THREE
		{
			get{ return _BEFORE_THREE; }
			set
			{
				this.OnPropertyValueChange(_.BEFORE_THREE, _BEFORE_THREE, value);
				this._BEFORE_THREE = value;
			}
		}
		/// <summary>
		/// 当天
		/// </summary>
		public string TODAY_COUNT
		{
			get{ return _TODAY_COUNT; }
			set
			{
				this.OnPropertyValueChange(_.TODAY_COUNT, _TODAY_COUNT, value);
				this._TODAY_COUNT = value;
			}
		}
		/// <summary>
		/// _2-3天
		/// </summary>
		public string AFTER_THREE
		{
			get{ return _AFTER_THREE; }
			set
			{
				this.OnPropertyValueChange(_.AFTER_THREE, _AFTER_THREE, value);
				this._AFTER_THREE = value;
			}
		}
		/// <summary>
		/// _4-7天
		/// </summary>
		public string AFTER_FOUR
		{
			get{ return _AFTER_FOUR; }
			set
			{
				this.OnPropertyValueChange(_.AFTER_FOUR, _AFTER_FOUR, value);
				this._AFTER_FOUR = value;
			}
		}
		/// <summary>
		/// &gt;7天
		/// </summary>
		public string AFTER_SEVEN
		{
			get{ return _AFTER_SEVEN; }
			set
			{
				this.OnPropertyValueChange(_.AFTER_SEVEN, _AFTER_SEVEN, value);
				this._AFTER_SEVEN = value;
			}
		}
		/// <summary>
		/// 数据集类型
		/// </summary>
		public string M_MODULE
		{
			get{ return _M_MODULE; }
			set
			{
				this.OnPropertyValueChange(_.M_MODULE, _M_MODULE, value);
				this._M_MODULE = value;
			}
		}
		/// <summary>
		/// 表名中文名
		/// </summary>
		public string M_TABLE_CN_NAME
		{
			get{ return _M_TABLE_CN_NAME; }
			set
			{
				this.OnPropertyValueChange(_.M_TABLE_CN_NAME, _M_TABLE_CN_NAME, value);
				this._M_TABLE_CN_NAME = value;
			}
		}
		/// <summary>
		/// 表名英文名
		/// </summary>
		public string M_TABLE_EN_NAME
		{
			get{ return _M_TABLE_EN_NAME; }
			set
			{
				this.OnPropertyValueChange(_.M_TABLE_EN_NAME, _M_TABLE_EN_NAME, value);
				this._M_TABLE_EN_NAME = value;
			}
		}
		/// <summary>
		/// 表编码
		/// </summary>
		public string SYS_CODE
		{
			get{ return _SYS_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SYS_CODE, _SYS_CODE, value);
				this._SYS_CODE = value;
			}
		}
		/// <summary>
		/// 交易平台标识代码
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
				_.M_DATA_SOURCE,
				_.COUNT_TIME,
				_.INSERT_TIME,
				_.BEFORE_SEVEN,
				_.BEFORE_FOUR,
				_.BEFORE_THREE,
				_.TODAY_COUNT,
				_.AFTER_THREE,
				_.AFTER_FOUR,
				_.AFTER_SEVEN,
				_.M_MODULE,
				_.M_TABLE_CN_NAME,
				_.M_TABLE_EN_NAME,
				_.SYS_CODE,
				_.PLATFORM_CODE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._M_DATA_SOURCE,
				this._COUNT_TIME,
				this._INSERT_TIME,
				this._BEFORE_SEVEN,
				this._BEFORE_FOUR,
				this._BEFORE_THREE,
				this._TODAY_COUNT,
				this._AFTER_THREE,
				this._AFTER_FOUR,
				this._AFTER_SEVEN,
				this._M_MODULE,
				this._M_TABLE_CN_NAME,
				this._M_TABLE_EN_NAME,
				this._SYS_CODE,
				this._PLATFORM_CODE,
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
			public readonly static Field All = new Field("*", "T_TIMELINESS_COUNT");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_TIMELINESS_COUNT", "ID");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "T_TIMELINESS_COUNT", "数据来源");
            /// <summary>
			/// 某天的数据统计
			/// </summary>
			public readonly static Field COUNT_TIME = new Field("COUNT_TIME", "T_TIMELINESS_COUNT", "某天的数据统计");
            /// <summary>
			/// 统计时间
			/// </summary>
			public readonly static Field INSERT_TIME = new Field("INSERT_TIME", "T_TIMELINESS_COUNT", "统计时间");
            /// <summary>
			/// -7天
			/// </summary>
			public readonly static Field BEFORE_SEVEN = new Field("BEFORE_SEVEN", "T_TIMELINESS_COUNT", "-7天");
            /// <summary>
			/// -4到-7天
			/// </summary>
			public readonly static Field BEFORE_FOUR = new Field("BEFORE_FOUR", "T_TIMELINESS_COUNT", "-4到-7天");
            /// <summary>
			/// -2到-3天
			/// </summary>
			public readonly static Field BEFORE_THREE = new Field("BEFORE_THREE", "T_TIMELINESS_COUNT", "-2到-3天");
            /// <summary>
			/// 当天
			/// </summary>
			public readonly static Field TODAY_COUNT = new Field("TODAY_COUNT", "T_TIMELINESS_COUNT", "当天");
            /// <summary>
			/// _2-3天
			/// </summary>
			public readonly static Field AFTER_THREE = new Field("AFTER_THREE", "T_TIMELINESS_COUNT", "_2-3天");
            /// <summary>
			/// _4-7天
			/// </summary>
			public readonly static Field AFTER_FOUR = new Field("AFTER_FOUR", "T_TIMELINESS_COUNT", "_4-7天");
            /// <summary>
			/// &gt;7天
			/// </summary>
			public readonly static Field AFTER_SEVEN = new Field("AFTER_SEVEN", "T_TIMELINESS_COUNT", "&gt;7天");
            /// <summary>
			/// 数据集类型
			/// </summary>
			public readonly static Field M_MODULE = new Field("M_MODULE", "T_TIMELINESS_COUNT", "数据集类型");
            /// <summary>
			/// 表名中文名
			/// </summary>
			public readonly static Field M_TABLE_CN_NAME = new Field("M_TABLE_CN_NAME", "T_TIMELINESS_COUNT", "表名中文名");
            /// <summary>
			/// 表名英文名
			/// </summary>
			public readonly static Field M_TABLE_EN_NAME = new Field("M_TABLE_EN_NAME", "T_TIMELINESS_COUNT", "表名英文名");
            /// <summary>
			/// 表编码
			/// </summary>
			public readonly static Field SYS_CODE = new Field("SYS_CODE", "T_TIMELINESS_COUNT", "表编码");
            /// <summary>
			/// 交易平台标识代码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "T_TIMELINESS_COUNT", "交易平台标识代码");
        }
        #endregion
	}
}