using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类YDPB_EVAL_APPLY。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("YDPB_EVAL_APPLY")]
    [Serializable]
    public partial class YDPB_EVAL_APPLY : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _APPLY_TYPE;
		private string _SERIES_NUMBER;
		private string _TENDER_PROJECT;
		private string _TENDER_PROJECT_CODE;
		private decimal? _TENDER_PROJECT_ID;
		private DateTime? _BID_EVAL_END_TIME;
		private string _REMARK;
		private decimal? _STATUS;
		private decimal? _CREATOR_ID;
		private string _CREATOR;
		private DateTime? _CREATE_TIME;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _IS_DELETE;
		private decimal? _EXPERT_COUNT;
		private decimal? _FID;
		private string _F_SERIES_NUMBER;
		private decimal? _EVAL_STATUS;
		private decimal? _FLAG;
		private decimal? _IS_EVAL_EXPERT;
		private string _TENDER_AGENCY_NAME;
		private string _TENDER_AGENCY_CODE;
		private string _TENDER_AGENT_CONTRACT;
		private DateTime? _BID_EVAL_START_TIME;
		private string _TENDER_AGENT_PHONE;

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
		/// 申请单类型 0:场地申请  1:场地变更 2:取消场地
		/// </summary>
		public decimal? APPLY_TYPE
		{
			get{ return _APPLY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.APPLY_TYPE, _APPLY_TYPE, value);
				this._APPLY_TYPE = value;
			}
		}
		/// <summary>
		/// 申请单编号
		/// </summary>
		public string SERIES_NUMBER
		{
			get{ return _SERIES_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.SERIES_NUMBER, _SERIES_NUMBER, value);
				this._SERIES_NUMBER = value;
			}
		}
		/// <summary>
		/// 招标项目名称
		/// </summary>
		public string TENDER_PROJECT
		{
			get{ return _TENDER_PROJECT; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT, _TENDER_PROJECT, value);
				this._TENDER_PROJECT = value;
			}
		}
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get{ return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 招标项目ID
		/// </summary>
		public decimal? TENDER_PROJECT_ID
		{
			get{ return _TENDER_PROJECT_ID; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_ID, _TENDER_PROJECT_ID, value);
				this._TENDER_PROJECT_ID = value;
			}
		}
		/// <summary>
		/// 预计评标结束时间
		/// </summary>
		public DateTime? BID_EVAL_END_TIME
		{
			get{ return _BID_EVAL_END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_EVAL_END_TIME, _BID_EVAL_END_TIME, value);
				this._BID_EVAL_END_TIME = value;
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
		/// 状态
		/// </summary>
		public decimal? STATUS
		{
			get{ return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 添加人ID
		/// </summary>
		public decimal? CREATOR_ID
		{
			get{ return _CREATOR_ID; }
			set
			{
				this.OnPropertyValueChange(_.CREATOR_ID, _CREATOR_ID, value);
				this._CREATOR_ID = value;
			}
		}
		/// <summary>
		/// 创建人名称
		/// </summary>
		public string CREATOR
		{
			get{ return _CREATOR; }
			set
			{
				this.OnPropertyValueChange(_.CREATOR, _CREATOR, value);
				this._CREATOR = value;
			}
		}
		/// <summary>
		/// 数据创建时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 数据最后修改时间
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
		/// 是否删除 0:正常 1：删除
		/// </summary>
		public decimal? IS_DELETE
		{
			get{ return _IS_DELETE; }
			set
			{
				this.OnPropertyValueChange(_.IS_DELETE, _IS_DELETE, value);
				this._IS_DELETE = value;
			}
		}
		/// <summary>
		/// 评标专家数量
		/// </summary>
		public decimal? EXPERT_COUNT
		{
			get{ return _EXPERT_COUNT; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_COUNT, _EXPERT_COUNT, value);
				this._EXPERT_COUNT = value;
			}
		}
		/// <summary>
		/// 原申请单ID
		/// </summary>
		public decimal? FID
		{
			get{ return _FID; }
			set
			{
				this.OnPropertyValueChange(_.FID, _FID, value);
				this._FID = value;
			}
		}
		/// <summary>
		/// 原申请单编号
		/// </summary>
		public string F_SERIES_NUMBER
		{
			get{ return _F_SERIES_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.F_SERIES_NUMBER, _F_SERIES_NUMBER, value);
				this._F_SERIES_NUMBER = value;
			}
		}
		/// <summary>
		/// 评标状态 0:待评标 1:评标中 2:评标结束 3：归档
		/// </summary>
		public decimal? EVAL_STATUS
		{
			get{ return _EVAL_STATUS; }
			set
			{
				this.OnPropertyValueChange(_.EVAL_STATUS, _EVAL_STATUS, value);
				this._EVAL_STATUS = value;
			}
		}
		/// <summary>
		/// 申请单状态 0:正常 1：已变更 2：已取消
		/// </summary>
		public decimal? FLAG
		{
			get{ return _FLAG; }
			set
			{
				this.OnPropertyValueChange(_.FLAG, _FLAG, value);
				this._FLAG = value;
			}
		}
		/// <summary>
		/// 是否都已分配专家席位 0：待分配 1：已分配
		/// </summary>
		public decimal? IS_EVAL_EXPERT
		{
			get{ return _IS_EVAL_EXPERT; }
			set
			{
				this.OnPropertyValueChange(_.IS_EVAL_EXPERT, _IS_EVAL_EXPERT, value);
				this._IS_EVAL_EXPERT = value;
			}
		}
		/// <summary>
		/// 招标代理机构名称
		/// </summary>
		public string TENDER_AGENCY_NAME
		{
			get{ return _TENDER_AGENCY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_NAME, _TENDER_AGENCY_NAME, value);
				this._TENDER_AGENCY_NAME = value;
			}
		}
		/// <summary>
		/// 招标代理机构统一社会信用代码
		/// </summary>
		public string TENDER_AGENCY_CODE
		{
			get{ return _TENDER_AGENCY_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENCY_CODE, _TENDER_AGENCY_CODE, value);
				this._TENDER_AGENCY_CODE = value;
			}
		}
		/// <summary>
		/// 招标代理机构联系人
		/// </summary>
		public string TENDER_AGENT_CONTRACT
		{
			get{ return _TENDER_AGENT_CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENT_CONTRACT, _TENDER_AGENT_CONTRACT, value);
				this._TENDER_AGENT_CONTRACT = value;
			}
		}
		/// <summary>
		/// 预计评标开始时间
		/// </summary>
		public DateTime? BID_EVAL_START_TIME
		{
			get{ return _BID_EVAL_START_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_EVAL_START_TIME, _BID_EVAL_START_TIME, value);
				this._BID_EVAL_START_TIME = value;
			}
		}
		/// <summary>
		/// 招标代理机构联系方式
		/// </summary>
		public string TENDER_AGENT_PHONE
		{
			get{ return _TENDER_AGENT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_AGENT_PHONE, _TENDER_AGENT_PHONE, value);
				this._TENDER_AGENT_PHONE = value;
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
				_.APPLY_TYPE,
				_.SERIES_NUMBER,
				_.TENDER_PROJECT,
				_.TENDER_PROJECT_CODE,
				_.TENDER_PROJECT_ID,
				_.BID_EVAL_END_TIME,
				_.REMARK,
				_.STATUS,
				_.CREATOR_ID,
				_.CREATOR,
				_.CREATE_TIME,
				_.DATA_TIMESTAMP,
				_.IS_DELETE,
				_.EXPERT_COUNT,
				_.FID,
				_.F_SERIES_NUMBER,
				_.EVAL_STATUS,
				_.FLAG,
				_.IS_EVAL_EXPERT,
				_.TENDER_AGENCY_NAME,
				_.TENDER_AGENCY_CODE,
				_.TENDER_AGENT_CONTRACT,
				_.BID_EVAL_START_TIME,
				_.TENDER_AGENT_PHONE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._APPLY_TYPE,
				this._SERIES_NUMBER,
				this._TENDER_PROJECT,
				this._TENDER_PROJECT_CODE,
				this._TENDER_PROJECT_ID,
				this._BID_EVAL_END_TIME,
				this._REMARK,
				this._STATUS,
				this._CREATOR_ID,
				this._CREATOR,
				this._CREATE_TIME,
				this._DATA_TIMESTAMP,
				this._IS_DELETE,
				this._EXPERT_COUNT,
				this._FID,
				this._F_SERIES_NUMBER,
				this._EVAL_STATUS,
				this._FLAG,
				this._IS_EVAL_EXPERT,
				this._TENDER_AGENCY_NAME,
				this._TENDER_AGENCY_CODE,
				this._TENDER_AGENT_CONTRACT,
				this._BID_EVAL_START_TIME,
				this._TENDER_AGENT_PHONE,
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
			public readonly static Field All = new Field("*", "YDPB_EVAL_APPLY");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "YDPB_EVAL_APPLY", "ID");
            /// <summary>
			/// 申请单类型 0:场地申请  1:场地变更 2:取消场地
			/// </summary>
			public readonly static Field APPLY_TYPE = new Field("APPLY_TYPE", "YDPB_EVAL_APPLY", "申请单类型 0:场地申请  1:场地变更 2:取消场地");
            /// <summary>
			/// 申请单编号
			/// </summary>
			public readonly static Field SERIES_NUMBER = new Field("SERIES_NUMBER", "YDPB_EVAL_APPLY", "申请单编号");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT = new Field("TENDER_PROJECT", "YDPB_EVAL_APPLY", "招标项目名称");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "YDPB_EVAL_APPLY", "招标项目编号");
            /// <summary>
			/// 招标项目ID
			/// </summary>
			public readonly static Field TENDER_PROJECT_ID = new Field("TENDER_PROJECT_ID", "YDPB_EVAL_APPLY", "招标项目ID");
            /// <summary>
			/// 预计评标结束时间
			/// </summary>
			public readonly static Field BID_EVAL_END_TIME = new Field("BID_EVAL_END_TIME", "YDPB_EVAL_APPLY", "预计评标结束时间");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "YDPB_EVAL_APPLY", "备注");
            /// <summary>
			/// 状态
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "YDPB_EVAL_APPLY", "状态");
            /// <summary>
			/// 添加人ID
			/// </summary>
			public readonly static Field CREATOR_ID = new Field("CREATOR_ID", "YDPB_EVAL_APPLY", "添加人ID");
            /// <summary>
			/// 创建人名称
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "YDPB_EVAL_APPLY", "创建人名称");
            /// <summary>
			/// 数据创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "YDPB_EVAL_APPLY", "数据创建时间");
            /// <summary>
			/// 数据最后修改时间
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "YDPB_EVAL_APPLY", "数据最后修改时间");
            /// <summary>
			/// 是否删除 0:正常 1：删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "YDPB_EVAL_APPLY", "是否删除 0:正常 1：删除");
            /// <summary>
			/// 评标专家数量
			/// </summary>
			public readonly static Field EXPERT_COUNT = new Field("EXPERT_COUNT", "YDPB_EVAL_APPLY", "评标专家数量");
            /// <summary>
			/// 原申请单ID
			/// </summary>
			public readonly static Field FID = new Field("FID", "YDPB_EVAL_APPLY", "原申请单ID");
            /// <summary>
			/// 原申请单编号
			/// </summary>
			public readonly static Field F_SERIES_NUMBER = new Field("F_SERIES_NUMBER", "YDPB_EVAL_APPLY", "原申请单编号");
            /// <summary>
			/// 评标状态 0:待评标 1:评标中 2:评标结束 3：归档
			/// </summary>
			public readonly static Field EVAL_STATUS = new Field("EVAL_STATUS", "YDPB_EVAL_APPLY", "评标状态 0:待评标 1:评标中 2:评标结束 3：归档");
            /// <summary>
			/// 申请单状态 0:正常 1：已变更 2：已取消
			/// </summary>
			public readonly static Field FLAG = new Field("FLAG", "YDPB_EVAL_APPLY", "申请单状态 0:正常 1：已变更 2：已取消");
            /// <summary>
			/// 是否都已分配专家席位 0：待分配 1：已分配
			/// </summary>
			public readonly static Field IS_EVAL_EXPERT = new Field("IS_EVAL_EXPERT", "YDPB_EVAL_APPLY", "是否都已分配专家席位 0：待分配 1：已分配");
            /// <summary>
			/// 招标代理机构名称
			/// </summary>
			public readonly static Field TENDER_AGENCY_NAME = new Field("TENDER_AGENCY_NAME", "YDPB_EVAL_APPLY", "招标代理机构名称");
            /// <summary>
			/// 招标代理机构统一社会信用代码
			/// </summary>
			public readonly static Field TENDER_AGENCY_CODE = new Field("TENDER_AGENCY_CODE", "YDPB_EVAL_APPLY", "招标代理机构统一社会信用代码");
            /// <summary>
			/// 招标代理机构联系人
			/// </summary>
			public readonly static Field TENDER_AGENT_CONTRACT = new Field("TENDER_AGENT_CONTRACT", "YDPB_EVAL_APPLY", "招标代理机构联系人");
            /// <summary>
			/// 预计评标开始时间
			/// </summary>
			public readonly static Field BID_EVAL_START_TIME = new Field("BID_EVAL_START_TIME", "YDPB_EVAL_APPLY", "预计评标开始时间");
            /// <summary>
			/// 招标代理机构联系方式
			/// </summary>
			public readonly static Field TENDER_AGENT_PHONE = new Field("TENDER_AGENT_PHONE", "YDPB_EVAL_APPLY", "招标代理机构联系方式");
        }
        #endregion
	}
}