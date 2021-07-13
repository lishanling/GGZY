using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类ZJ_AWARD_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("ZJ_AWARD_INFO")]
    [Serializable]
    public partial class ZJ_AWARD_INFO : FwEntity
    {
        #region Model
		private string _BODY_CODE;
		private string _BODY_NAME;
		private string _BODY_TYPE;
		private string _BODY_ROLE;
		private string _REWARD_PUNISHMENT_TYPE;
		private string _REWARD_REASON;
		private DateTime? _REWARD_DATE;
		private string _DOCUMENT_CODE;
		private string _GOVERNMENT;
		private string _M_DATA_SOURCE;
		private string _PUB_SERVICE_PLAT_CODE;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _M_ID;
		private string _SCOPE;

		/// <summary>
		/// 奖励主体代码
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
		/// 奖励主体名称
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
		/// 奖惩类型
		/// </summary>
		public string REWARD_PUNISHMENT_TYPE
		{
			get{ return _REWARD_PUNISHMENT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.REWARD_PUNISHMENT_TYPE, _REWARD_PUNISHMENT_TYPE, value);
				this._REWARD_PUNISHMENT_TYPE = value;
			}
		}
		/// <summary>
		/// 奖励说明
		/// </summary>
		public string REWARD_REASON
		{
			get{ return _REWARD_REASON; }
			set
			{
				this.OnPropertyValueChange(_.REWARD_REASON, _REWARD_REASON, value);
				this._REWARD_REASON = value;
			}
		}
		/// <summary>
		/// 奖励日期
		/// </summary>
		public DateTime? REWARD_DATE
		{
			get{ return _REWARD_DATE; }
			set
			{
				this.OnPropertyValueChange(_.REWARD_DATE, _REWARD_DATE, value);
				this._REWARD_DATE = value;
			}
		}
		/// <summary>
		/// 处理文件文号
		/// </summary>
		public string DOCUMENT_CODE
		{
			get{ return _DOCUMENT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.DOCUMENT_CODE, _DOCUMENT_CODE, value);
				this._DOCUMENT_CODE = value;
			}
		}
		/// <summary>
		/// 执行部门
		/// </summary>
		public string GOVERNMENT
		{
			get{ return _GOVERNMENT; }
			set
			{
				this.OnPropertyValueChange(_.GOVERNMENT, _GOVERNMENT, value);
				this._GOVERNMENT = value;
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
		/// <summary>
		/// 公开范围
		/// </summary>
		public string SCOPE
		{
			get{ return _SCOPE; }
			set
			{
				this.OnPropertyValueChange(_.SCOPE, _SCOPE, value);
				this._SCOPE = value;
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
				_.REWARD_PUNISHMENT_TYPE,
				_.REWARD_REASON,
				_.REWARD_DATE,
				_.DOCUMENT_CODE,
				_.GOVERNMENT,
				_.M_DATA_SOURCE,
				_.PUB_SERVICE_PLAT_CODE,
				_.DATA_TIMESTAMP,
				_.M_ID,
				_.SCOPE,
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
				this._REWARD_PUNISHMENT_TYPE,
				this._REWARD_REASON,
				this._REWARD_DATE,
				this._DOCUMENT_CODE,
				this._GOVERNMENT,
				this._M_DATA_SOURCE,
				this._PUB_SERVICE_PLAT_CODE,
				this._DATA_TIMESTAMP,
				this._M_ID,
				this._SCOPE,
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
			public readonly static Field All = new Field("*", "ZJ_AWARD_INFO");
            /// <summary>
			/// 奖励主体代码
			/// </summary>
			public readonly static Field BODY_CODE = new Field("BODY_CODE", "ZJ_AWARD_INFO", "奖励主体代码");
            /// <summary>
			/// 奖励主体名称
			/// </summary>
			public readonly static Field BODY_NAME = new Field("BODY_NAME", "ZJ_AWARD_INFO", "奖励主体名称");
            /// <summary>
			/// 主体类别
			/// </summary>
			public readonly static Field BODY_TYPE = new Field("BODY_TYPE", "ZJ_AWARD_INFO", "主体类别");
            /// <summary>
			/// 主体角色
			/// </summary>
			public readonly static Field BODY_ROLE = new Field("BODY_ROLE", "ZJ_AWARD_INFO", "主体角色");
            /// <summary>
			/// 奖惩类型
			/// </summary>
			public readonly static Field REWARD_PUNISHMENT_TYPE = new Field("REWARD_PUNISHMENT_TYPE", "ZJ_AWARD_INFO", "奖惩类型");
            /// <summary>
			/// 奖励说明
			/// </summary>
			public readonly static Field REWARD_REASON = new Field("REWARD_REASON", "ZJ_AWARD_INFO",DbType.AnsiString, null, "奖励说明");
            /// <summary>
			/// 奖励日期
			/// </summary>
			public readonly static Field REWARD_DATE = new Field("REWARD_DATE", "ZJ_AWARD_INFO", "奖励日期");
            /// <summary>
			/// 处理文件文号
			/// </summary>
			public readonly static Field DOCUMENT_CODE = new Field("DOCUMENT_CODE", "ZJ_AWARD_INFO", "处理文件文号");
            /// <summary>
			/// 执行部门
			/// </summary>
			public readonly static Field GOVERNMENT = new Field("GOVERNMENT", "ZJ_AWARD_INFO", "执行部门");
            /// <summary>
			/// 数据来源
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "ZJ_AWARD_INFO", "数据来源");
            /// <summary>
			/// 公共服务平台标识码
			/// </summary>
			public readonly static Field PUB_SERVICE_PLAT_CODE = new Field("PUB_SERVICE_PLAT_CODE", "ZJ_AWARD_INFO", "公共服务平台标识码");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "ZJ_AWARD_INFO", "数据时间戳");
            /// <summary>
			/// M_ID
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "ZJ_AWARD_INFO", "M_ID");
            /// <summary>
			/// 公开范围
			/// </summary>
			public readonly static Field SCOPE = new Field("SCOPE", "ZJ_AWARD_INFO", "公开范围");
        }
        #endregion
	}
}