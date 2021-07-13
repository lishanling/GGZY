using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ANOMALY_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ANOMALY_INFO")]
    [Serializable]
    public partial class ANOMALY_INFO : FwEntity
    {
        #region Model
		private decimal? _M_ID;
		private string _M_KEY;
		private string _ANOMALY;
		private string _M_TABLE;
		private DateTime? _M_TM;
		private decimal? _M_IS_HISTORY;
		private decimal? _M_CREATEBY;
		private DateTime? _UPDATE_TIME;
		private string _M_DATA_SOURCE;
		private decimal? _ID;

		/// <summary>
		/// 数据主键id
		/// </summary>
		public decimal? M_ID
		{
			get{ return _M_ID; }
			set
			{
				this.OnPropertyValueChange(_.M_ID, _M_ID, value);
				this._M_ID = value;
			}
		}
		/// <summary>
		/// 数据M_KEY
		/// </summary>
		public string M_KEY
		{
			get{ return _M_KEY; }
			set
			{
				this.OnPropertyValueChange(_.M_KEY, _M_KEY, value);
				this._M_KEY = value;
			}
		}
		/// <summary>
		/// 异常信息
		/// </summary>
		public string ANOMALY
		{
			get{ return _ANOMALY; }
			set
			{
				this.OnPropertyValueChange(_.ANOMALY, _ANOMALY, value);
				this._ANOMALY = value;
			}
		}
		/// <summary>
		/// 表名
		/// </summary>
		public string M_TABLE
		{
			get{ return _M_TABLE; }
			set
			{
				this.OnPropertyValueChange(_.M_TABLE, _M_TABLE, value);
				this._M_TABLE = value;
			}
		}
		/// <summary>
		/// 数据创建时间
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
		/// 是否是历史数据
		/// </summary>
		public decimal? M_IS_HISTORY
		{
			get{ return _M_IS_HISTORY; }
			set
			{
				this.OnPropertyValueChange(_.M_IS_HISTORY, _M_IS_HISTORY, value);
				this._M_IS_HISTORY = value;
			}
		}
		/// <summary>
		/// 数据创建人
		/// </summary>
		public decimal? M_CREATEBY
		{
			get{ return _M_CREATEBY; }
			set
			{
				this.OnPropertyValueChange(_.M_CREATEBY, _M_CREATEBY, value);
				this._M_CREATEBY = value;
			}
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime? UPDATE_TIME
		{
			get{ return _UPDATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.UPDATE_TIME, _UPDATE_TIME, value);
				this._UPDATE_TIME = value;
			}
		}
		/// <summary>
		/// 
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
		/// 主键
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.M_ID,
				_.M_KEY,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.M_ID,
				_.M_KEY,
				_.ANOMALY,
				_.M_TABLE,
				_.M_TM,
				_.M_IS_HISTORY,
				_.M_CREATEBY,
				_.UPDATE_TIME,
				_.M_DATA_SOURCE,
				_.ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._M_ID,
				this._M_KEY,
				this._ANOMALY,
				this._M_TABLE,
				this._M_TM,
				this._M_IS_HISTORY,
				this._M_CREATEBY,
				this._UPDATE_TIME,
				this._M_DATA_SOURCE,
				this._ID,
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
			public readonly static Field All = new Field("*", "ANOMALY_INFO");
            /// <summary>
			/// 数据主键id
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ANOMALY_INFO", "数据主键id");
            /// <summary>
			/// 数据M_KEY
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "ANOMALY_INFO", "数据M_KEY");
            /// <summary>
			/// 异常信息
			/// </summary>
			public readonly static Field ANOMALY = new Field("ANOMALY", "ANOMALY_INFO", "异常信息");
            /// <summary>
			/// 表名
			/// </summary>
			public readonly static Field M_TABLE = new Field("M_TABLE", "ANOMALY_INFO", "表名");
            /// <summary>
			/// 数据创建时间
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "ANOMALY_INFO", "数据创建时间");
            /// <summary>
			/// 是否是历史数据
			/// </summary>
			public readonly static Field M_IS_HISTORY = new Field("M_IS_HISTORY", "ANOMALY_INFO", "是否是历史数据");
            /// <summary>
			/// 数据创建人
			/// </summary>
			public readonly static Field M_CREATEBY = new Field("M_CREATEBY", "ANOMALY_INFO", "数据创建人");
            /// <summary>
			/// 更新时间
			/// </summary>
			public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "ANOMALY_INFO", "更新时间");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ANOMALY_INFO", "");
            /// <summary>
			/// 主键
			/// </summary>
			public readonly static Field ID = new Field("ID", "ANOMALY_INFO", "主键");
        }
        #endregion
	}
}