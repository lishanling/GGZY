using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJ_ENTERPRISE_CREDIT_SCORE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_ENTERPRISE_CREDIT_SCORE")]
    [Serializable]
    public partial class ZJ_ENTERPRISE_CREDIT_SCORE : FwEntity
    {
        #region Model
		private string _BODY_CODE;
		private string _BODY_NAME;
		private string _BODY_TYPE;
		private string _BODY_ROLE;
		private decimal? _CREDIT_SCORE;
		private string _SYEAR;
		private string _QUARTER;
		private string _MONTH;
		private string _RANK;
		private string _CREDIT_TYPE;
		private string _INDUSTRIES_TYPE;
		private DateTime? _UPDATE_TIME;
		private string _M_DATA_SOURCE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;

		/// <summary>
		/// 主体代码
		/// </summary>
		public string BODY_CODE
		{
			get{ return _BODY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BODY_CODE, _BODY_CODE, value);
				this._BODY_CODE = value;
			}
		}
		/// <summary>
		/// 主体名称
		/// </summary>
		public string BODY_NAME
		{
			get{ return _BODY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.BODY_NAME, _BODY_NAME, value);
				this._BODY_NAME = value;
			}
		}
		/// <summary>
		/// 主体类别
		/// </summary>
		public string BODY_TYPE
		{
			get{ return _BODY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.BODY_TYPE, _BODY_TYPE, value);
				this._BODY_TYPE = value;
			}
		}
		/// <summary>
		/// 主体角色
		/// </summary>
		public string BODY_ROLE
		{
			get{ return _BODY_ROLE; }
			set
			{
				this.OnPropertyValueChange(_.BODY_ROLE, _BODY_ROLE, value);
				this._BODY_ROLE = value;
			}
		}
		/// <summary>
		/// 信用分
		/// </summary>
		public decimal? CREDIT_SCORE
		{
			get{ return _CREDIT_SCORE; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_SCORE, _CREDIT_SCORE, value);
				this._CREDIT_SCORE = value;
			}
		}
		/// <summary>
		/// 年度
		/// </summary>
		public string SYEAR
		{
			get{ return _SYEAR; }
			set
			{
				this.OnPropertyValueChange(_.SYEAR, _SYEAR, value);
				this._SYEAR = value;
			}
		}
		/// <summary>
		/// 季度
		/// </summary>
		public string QUARTER
		{
			get{ return _QUARTER; }
			set
			{
				this.OnPropertyValueChange(_.QUARTER, _QUARTER, value);
				this._QUARTER = value;
			}
		}
		/// <summary>
		/// 月份
		/// </summary>
		public string MONTH
		{
			get{ return _MONTH; }
			set
			{
				this.OnPropertyValueChange(_.MONTH, _MONTH, value);
				this._MONTH = value;
			}
		}
		/// <summary>
		/// 排名
		/// </summary>
		public string RANK
		{
			get{ return _RANK; }
			set
			{
				this.OnPropertyValueChange(_.RANK, _RANK, value);
				this._RANK = value;
			}
		}
		/// <summary>
		/// 信用类型
		/// </summary>
		public string CREDIT_TYPE
		{
			get{ return _CREDIT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.CREDIT_TYPE, _CREDIT_TYPE, value);
				this._CREDIT_TYPE = value;
			}
		}
		/// <summary>
		/// 行业分类
		/// </summary>
		public string INDUSTRIES_TYPE
		{
			get{ return _INDUSTRIES_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.INDUSTRIES_TYPE, _INDUSTRIES_TYPE, value);
				this._INDUSTRIES_TYPE = value;
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
		/// <summary>
		/// M_ID
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
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.BODY_CODE,
				_.BODY_NAME,
				_.BODY_TYPE,
				_.BODY_ROLE,
				_.CREDIT_SCORE,
				_.SYEAR,
				_.QUARTER,
				_.MONTH,
				_.RANK,
				_.CREDIT_TYPE,
				_.INDUSTRIES_TYPE,
				_.UPDATE_TIME,
				_.M_DATA_SOURCE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._BODY_CODE,
				this._BODY_NAME,
				this._BODY_TYPE,
				this._BODY_ROLE,
				this._CREDIT_SCORE,
				this._SYEAR,
				this._QUARTER,
				this._MONTH,
				this._RANK,
				this._CREDIT_TYPE,
				this._INDUSTRIES_TYPE,
				this._UPDATE_TIME,
				this._M_DATA_SOURCE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ID,
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
			public readonly static Field All = new Field("*", "ZJ_ENTERPRISE_CREDIT_SCORE");
            /// <summary>
			/// 主体代码
			/// </summary>
			public readonly static Field BODY_CODE = new Field("BODY_CODE", "ZJ_ENTERPRISE_CREDIT_SCORE", "主体代码");
            /// <summary>
			/// 主体名称
			/// </summary>
			public readonly static Field BODY_NAME = new Field("BODY_NAME", "ZJ_ENTERPRISE_CREDIT_SCORE", "主体名称");
            /// <summary>
			/// 主体类别
			/// </summary>
			public readonly static Field BODY_TYPE = new Field("BODY_TYPE", "ZJ_ENTERPRISE_CREDIT_SCORE", "主体类别");
            /// <summary>
			/// 主体角色
			/// </summary>
			public readonly static Field BODY_ROLE = new Field("BODY_ROLE", "ZJ_ENTERPRISE_CREDIT_SCORE", "主体角色");
            /// <summary>
			/// 信用分
			/// </summary>
			public readonly static Field CREDIT_SCORE = new Field("CREDIT_SCORE", "ZJ_ENTERPRISE_CREDIT_SCORE", "信用分");
            /// <summary>
			/// 年度
			/// </summary>
			public readonly static Field SYEAR = new Field("SYEAR", "ZJ_ENTERPRISE_CREDIT_SCORE", "年度");
            /// <summary>
			/// 季度
			/// </summary>
			public readonly static Field QUARTER = new Field("QUARTER", "ZJ_ENTERPRISE_CREDIT_SCORE", "季度");
            /// <summary>
			/// 月份
			/// </summary>
			public readonly static Field MONTH = new Field("MONTH", "ZJ_ENTERPRISE_CREDIT_SCORE", "月份");
            /// <summary>
			/// 排名
			/// </summary>
			public readonly static Field RANK = new Field("RANK", "ZJ_ENTERPRISE_CREDIT_SCORE", "排名");
            /// <summary>
			/// 信用类型
			/// </summary>
			public readonly static Field CREDIT_TYPE = new Field("CREDIT_TYPE", "ZJ_ENTERPRISE_CREDIT_SCORE", "信用类型");
            /// <summary>
			/// 行业分类
			/// </summary>
			public readonly static Field INDUSTRIES_TYPE = new Field("INDUSTRIES_TYPE", "ZJ_ENTERPRISE_CREDIT_SCORE", "行业分类");
            /// <summary>
			/// 更新时间
			/// </summary>
			public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "ZJ_ENTERPRISE_CREDIT_SCORE", "更新时间");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ZJ_ENTERPRISE_CREDIT_SCORE", "数据来源");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ZJ_ENTERPRISE_CREDIT_SCORE", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ZJ_ENTERPRISE_CREDIT_SCORE", "数据时间戳");
            /// <summary>
			/// M_ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_ENTERPRISE_CREDIT_SCORE", "M_ID");
        }
        #endregion
	}
}