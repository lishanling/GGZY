using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类COMPARE_SELECT_ANN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("COMPARE_SELECT_ANN")]
    [Serializable]
    public partial class COMPARE_SELECT_ANN : FwEntity
    {
        #region Model
		private string _PROJECT_CODE;
		private string _PROJECT_NAME;
		private string _OWNER_NAME;
		private string _AGENCY_FEE_STANDARD;
		private DateTime? _APPLICATION_END_TIME;
		private decimal? _M_STATUS;
		private string _IS_GOVERNMENT_PLAY;
		private string _AGENCY_CONDITION;
		private string _AGENCY_CONTENT;
		private DateTime? _ADD_TIME;
		private decimal? _USERID;
		private string _REMARK;
		private decimal? _M_ID;
		private string _PLATFORM_CODE;
		private string _M_DATA_SOURCE;
		private DateTime? _M_TM;
		private string _URL;
		private decimal? _CHECK_USERID;
		private DateTime? _CHECK_TM;
		private string _REJECT_REASON;

		/// <summary>
		/// 标号
		/// </summary>
		public string PROJECT_CODE
		{
			get{ return _PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
				this._PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 主题
		/// </summary>
		public string PROJECT_NAME
		{
			get{ return _PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_NAME, _PROJECT_NAME, value);
				this._PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 业主名称
		/// </summary>
		public string OWNER_NAME
		{
			get{ return _OWNER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.OWNER_NAME, _OWNER_NAME, value);
				this._OWNER_NAME = value;
			}
		}
		/// <summary>
		/// 代理费取费标准
		/// </summary>
		public string AGENCY_FEE_STANDARD
		{
			get{ return _AGENCY_FEE_STANDARD; }
			set
			{
				this.OnPropertyValueChange(_.AGENCY_FEE_STANDARD, _AGENCY_FEE_STANDARD, value);
				this._AGENCY_FEE_STANDARD = value;
			}
		}
		/// <summary>
		/// 申请截止时间
		/// </summary>
		public DateTime? APPLICATION_END_TIME
		{
			get{ return _APPLICATION_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.APPLICATION_END_TIME, _APPLICATION_END_TIME, value);
				this._APPLICATION_END_TIME = value;
			}
		}
		/// <summary>
		/// 状态 sys_dic type = 9018
		/// </summary>
		public decimal? M_STATUS
		{
			get{ return _M_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.M_STATUS, _M_STATUS, value);
				this._M_STATUS = value;
			}
		}
		/// <summary>
		/// 是否属于政府采购
		/// </summary>
		public string IS_GOVERNMENT_PLAY
		{
			get{ return _IS_GOVERNMENT_PLAY; }
			set
			{
				this.OnPropertyValueChange(_.IS_GOVERNMENT_PLAY, _IS_GOVERNMENT_PLAY, value);
				this._IS_GOVERNMENT_PLAY = value;
			}
		}
		/// <summary>
		/// 代理机构资格条件
		/// </summary>
		public string AGENCY_CONDITION
		{
			get{ return _AGENCY_CONDITION; }
			set
			{
				this.OnPropertyValueChange(_.AGENCY_CONDITION, _AGENCY_CONDITION, value);
				this._AGENCY_CONDITION = value;
			}
		}
		/// <summary>
		/// 委托代理内容
		/// </summary>
		public string AGENCY_CONTENT
		{
			get{ return _AGENCY_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.AGENCY_CONTENT, _AGENCY_CONTENT, value);
				this._AGENCY_CONTENT = value;
			}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime? ADD_TIME
		{
			get{ return _ADD_TIME; }
			set
			{
				this.OnPropertyValueChange(_.ADD_TIME, _ADD_TIME, value);
				this._ADD_TIME = value;
			}
		}
		/// <summary>
		/// 添加人
		/// </summary>
		public decimal? USERID
		{
			get{ return _USERID; }
			set
			{
				this.OnPropertyValueChange(_.USERID, _USERID, value);
				this._USERID = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARK
		{
			get{ return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
			}
		}
		/// <summary>
		/// 
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
		/// 交易系统标识码
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
		/// 
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
		/// 公告源URL
		/// </summary>
		public string URL
		{
			get{ return _URL; }
			set
			{
				this.OnPropertyValueChange(_.URL, _URL, value);
				this._URL = value;
			}
		}
		/// <summary>
		/// 审批用户
		/// </summary>
		public decimal? CHECK_USERID
		{
			get{ return _CHECK_USERID; }
			set
			{
				this.OnPropertyValueChange(_.CHECK_USERID, _CHECK_USERID, value);
				this._CHECK_USERID = value;
			}
		}
		/// <summary>
		/// 审批时间
		/// </summary>
		public DateTime? CHECK_TM
		{
			get{ return _CHECK_TM; }
			set
			{
				this.OnPropertyValueChange(_.CHECK_TM, _CHECK_TM, value);
				this._CHECK_TM = value;
			}
		}
		/// <summary>
		/// 拒绝理由
		/// </summary>
		public string REJECT_REASON
		{
			get{ return _REJECT_REASON; }
			set
			{
				this.OnPropertyValueChange(_.REJECT_REASON, _REJECT_REASON, value);
				this._REJECT_REASON = value;
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
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.PROJECT_CODE,
				_.PROJECT_NAME,
				_.OWNER_NAME,
				_.AGENCY_FEE_STANDARD,
				_.APPLICATION_END_TIME,
				_.M_STATUS,
				_.IS_GOVERNMENT_PLAY,
				_.AGENCY_CONDITION,
				_.AGENCY_CONTENT,
				_.ADD_TIME,
				_.USERID,
				_.REMARK,
				_.M_ID,
				_.PLATFORM_CODE,
				_.M_DATA_SOURCE,
				_.M_TM,
				_.URL,
				_.CHECK_USERID,
				_.CHECK_TM,
				_.REJECT_REASON,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PROJECT_CODE,
				this._PROJECT_NAME,
				this._OWNER_NAME,
				this._AGENCY_FEE_STANDARD,
				this._APPLICATION_END_TIME,
				this._M_STATUS,
				this._IS_GOVERNMENT_PLAY,
				this._AGENCY_CONDITION,
				this._AGENCY_CONTENT,
				this._ADD_TIME,
				this._USERID,
				this._REMARK,
				this._M_ID,
				this._PLATFORM_CODE,
				this._M_DATA_SOURCE,
				this._M_TM,
				this._URL,
				this._CHECK_USERID,
				this._CHECK_TM,
				this._REJECT_REASON,
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
			public readonly static Field All = new Field("*", "COMPARE_SELECT_ANN");
            /// <summary>
			/// 标号
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "COMPARE_SELECT_ANN", "标号");
            /// <summary>
			/// 主题
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "COMPARE_SELECT_ANN", "主题");
            /// <summary>
			/// 业主名称
			/// </summary>
			public readonly static Field OWNER_NAME = new Field("OWNER_NAME", "COMPARE_SELECT_ANN", "业主名称");
            /// <summary>
			/// 代理费取费标准
			/// </summary>
			public readonly static Field AGENCY_FEE_STANDARD = new Field("AGENCY_FEE_STANDARD", "COMPARE_SELECT_ANN", "代理费取费标准");
            /// <summary>
			/// 申请截止时间
			/// </summary>
			public readonly static Field APPLICATION_END_TIME = new Field("APPLICATION_END_TIME", "COMPARE_SELECT_ANN", "申请截止时间");
            /// <summary>
			/// 状态 sys_dic type = 9018
			/// </summary>
			public readonly static Field M_STATUS = new Field("M_STATUS", "COMPARE_SELECT_ANN", "状态 sys_dic type = 9018");
            /// <summary>
			/// 是否属于政府采购
			/// </summary>
			public readonly static Field IS_GOVERNMENT_PLAY = new Field("IS_GOVERNMENT_PLAY", "COMPARE_SELECT_ANN", "是否属于政府采购");
            /// <summary>
			/// 代理机构资格条件
			/// </summary>
			public readonly static Field AGENCY_CONDITION = new Field("AGENCY_CONDITION", "COMPARE_SELECT_ANN",DbType.AnsiString, null, "代理机构资格条件");
            /// <summary>
			/// 委托代理内容
			/// </summary>
			public readonly static Field AGENCY_CONTENT = new Field("AGENCY_CONTENT", "COMPARE_SELECT_ANN",DbType.AnsiString, null, "委托代理内容");
            /// <summary>
			/// 添加时间
			/// </summary>
			public readonly static Field ADD_TIME = new Field("ADD_TIME", "COMPARE_SELECT_ANN", "添加时间");
            /// <summary>
			/// 添加人
			/// </summary>
			public readonly static Field USERID = new Field("USERID", "COMPARE_SELECT_ANN", "添加人");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "COMPARE_SELECT_ANN", "备注");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_ID = new Field("M_ID", "COMPARE_SELECT_ANN", "");
            /// <summary>
			/// 交易系统标识码
			/// </summary>
			public readonly static Field PLATFORM_CODE = new Field("PLATFORM_CODE", "COMPARE_SELECT_ANN", "交易系统标识码");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "COMPARE_SELECT_ANN", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "COMPARE_SELECT_ANN", "");
            /// <summary>
			/// 公告源URL
			/// </summary>
			public readonly static Field URL = new Field("URL", "COMPARE_SELECT_ANN", "公告源URL");
            /// <summary>
			/// 审批用户
			/// </summary>
			public readonly static Field CHECK_USERID = new Field("CHECK_USERID", "COMPARE_SELECT_ANN", "审批用户");
            /// <summary>
			/// 审批时间
			/// </summary>
			public readonly static Field CHECK_TM = new Field("CHECK_TM", "COMPARE_SELECT_ANN", "审批时间");
            /// <summary>
			/// 拒绝理由
			/// </summary>
			public readonly static Field REJECT_REASON = new Field("REJECT_REASON", "COMPARE_SELECT_ANN",DbType.AnsiString, null, "拒绝理由");
        }
        #endregion
	}
}