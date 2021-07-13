using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ENTER_CREDTI_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ENTER_CREDTI_INFO")]
    [Serializable]
    public partial class ENTER_CREDTI_INFO : FwEntity
    {
        #region Model
		private string _BODY_CODE;
		private string _BODY_NAME;
		private string _BODY_TYPE;
		private string _BODY_ROLE;
		private decimal? _CREDIT_SCORE;
		private string _CREDIT_TYPE;
		private string _INDUSTRIES_TYPE;
		private DateTime? _UPDATE_TIME;
		private string _M_DATA_SOURCE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;

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
		/// 项目行业分类
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
				_.CREDIT_TYPE,
				_.INDUSTRIES_TYPE,
				_.UPDATE_TIME,
				_.M_DATA_SOURCE,
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
				this._BODY_CODE,
				this._BODY_NAME,
				this._BODY_TYPE,
				this._BODY_ROLE,
				this._CREDIT_SCORE,
				this._CREDIT_TYPE,
				this._INDUSTRIES_TYPE,
				this._UPDATE_TIME,
				this._M_DATA_SOURCE,
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
			public readonly static Field All = new Field("*", "ENTER_CREDTI_INFO");
            /// <summary>
			/// 主体代码
			/// </summary>
			public readonly static Field BODY_CODE = new Field("BODY_CODE", "ENTER_CREDTI_INFO", "主体代码");
            /// <summary>
			/// 主体名称
			/// </summary>
			public readonly static Field BODY_NAME = new Field("BODY_NAME", "ENTER_CREDTI_INFO", "主体名称");
            /// <summary>
			/// 主体类别
			/// </summary>
			public readonly static Field BODY_TYPE = new Field("BODY_TYPE", "ENTER_CREDTI_INFO", "主体类别");
            /// <summary>
			/// 主体角色
			/// </summary>
			public readonly static Field BODY_ROLE = new Field("BODY_ROLE", "ENTER_CREDTI_INFO", "主体角色");
            /// <summary>
			/// 信用分
			/// </summary>
			public readonly static Field CREDIT_SCORE = new Field("CREDIT_SCORE", "ENTER_CREDTI_INFO", "信用分");
            /// <summary>
			/// 信用类型
			/// </summary>
			public readonly static Field CREDIT_TYPE = new Field("CREDIT_TYPE", "ENTER_CREDTI_INFO", "信用类型");
            /// <summary>
			/// 项目行业分类
			/// </summary>
			public readonly static Field INDUSTRIES_TYPE = new Field("INDUSTRIES_TYPE", "ENTER_CREDTI_INFO", "项目行业分类");
            /// <summary>
			/// 更新时间
			/// </summary>
			public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "ENTER_CREDTI_INFO", "更新时间");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ENTER_CREDTI_INFO", "数据来源");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ENTER_CREDTI_INFO", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ENTER_CREDTI_INFO", "数据时间戳");
        }
        #endregion
	}
}