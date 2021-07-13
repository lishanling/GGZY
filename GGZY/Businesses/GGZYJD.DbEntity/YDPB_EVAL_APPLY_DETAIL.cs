using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类YDPB_EVAL_APPLY_DETAIL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("YDPB_EVAL_APPLY_DETAIL")]
    [Serializable]
    public partial class YDPB_EVAL_APPLY_DETAIL : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _AREA_CODE;
		private string _CENTER_NAME;
		private decimal? _EXPERT_COUNT;
		private decimal? _IS_MAIN;
		private decimal? _STATUS;
		private string _REMARK;
		private decimal? _APPLY_ID;
		private decimal? _CREATOR_ID;
		private string _CREATOR;
		private DateTime? _CREATE_TIME;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _IS_DELETE;
		private decimal? _FID;
		private decimal? _IS_EVAL_EXPERT;

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
		/// 交易中心编码
		/// </summary>
		public string AREA_CODE
		{
			get{ return _AREA_CODE; }
			set
			{
				this.OnPropertyValueChange(_.AREA_CODE, _AREA_CODE, value);
				this._AREA_CODE = value;
			}
		}
		/// <summary>
		/// 交易中心名称
		/// </summary>
		public string CENTER_NAME
		{
			get{ return _CENTER_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CENTER_NAME, _CENTER_NAME, value);
				this._CENTER_NAME = value;
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
		/// 是否主会场 0:否 1:是
		/// </summary>
		public decimal? IS_MAIN
		{
			get{ return _IS_MAIN; }
			set
			{
				this.OnPropertyValueChange(_.IS_MAIN, _IS_MAIN, value);
				this._IS_MAIN = value;
			}
		}
		/// <summary>
		/// 审批状态
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
		/// 关联申请单ID
		/// </summary>
		public decimal? APPLY_ID
		{
			get{ return _APPLY_ID; }
			set
			{
				this.OnPropertyValueChange(_.APPLY_ID, _APPLY_ID, value);
				this._APPLY_ID = value;
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
		/// 取消/变更时，原申请详情ID
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
		/// 是否都已分配专家席位 0:待分配 1：已分配
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
				_.AREA_CODE,
				_.CENTER_NAME,
				_.EXPERT_COUNT,
				_.IS_MAIN,
				_.STATUS,
				_.REMARK,
				_.APPLY_ID,
				_.CREATOR_ID,
				_.CREATOR,
				_.CREATE_TIME,
				_.DATA_TIMESTAMP,
				_.IS_DELETE,
				_.FID,
				_.IS_EVAL_EXPERT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._AREA_CODE,
				this._CENTER_NAME,
				this._EXPERT_COUNT,
				this._IS_MAIN,
				this._STATUS,
				this._REMARK,
				this._APPLY_ID,
				this._CREATOR_ID,
				this._CREATOR,
				this._CREATE_TIME,
				this._DATA_TIMESTAMP,
				this._IS_DELETE,
				this._FID,
				this._IS_EVAL_EXPERT,
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
			public readonly static Field All = new Field("*", "YDPB_EVAL_APPLY_DETAIL");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "YDPB_EVAL_APPLY_DETAIL", "ID");
            /// <summary>
			/// 交易中心编码
			/// </summary>
			public readonly static Field AREA_CODE = new Field("AREA_CODE", "YDPB_EVAL_APPLY_DETAIL", "交易中心编码");
            /// <summary>
			/// 交易中心名称
			/// </summary>
			public readonly static Field CENTER_NAME = new Field("CENTER_NAME", "YDPB_EVAL_APPLY_DETAIL", "交易中心名称");
            /// <summary>
			/// 评标专家数量
			/// </summary>
			public readonly static Field EXPERT_COUNT = new Field("EXPERT_COUNT", "YDPB_EVAL_APPLY_DETAIL", "评标专家数量");
            /// <summary>
			/// 是否主会场 0:否 1:是
			/// </summary>
			public readonly static Field IS_MAIN = new Field("IS_MAIN", "YDPB_EVAL_APPLY_DETAIL", "是否主会场 0:否 1:是");
            /// <summary>
			/// 审批状态
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "YDPB_EVAL_APPLY_DETAIL", "审批状态");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "YDPB_EVAL_APPLY_DETAIL", "备注");
            /// <summary>
			/// 关联申请单ID
			/// </summary>
			public readonly static Field APPLY_ID = new Field("APPLY_ID", "YDPB_EVAL_APPLY_DETAIL", "关联申请单ID");
            /// <summary>
			/// 添加人ID
			/// </summary>
			public readonly static Field CREATOR_ID = new Field("CREATOR_ID", "YDPB_EVAL_APPLY_DETAIL", "添加人ID");
            /// <summary>
			/// 创建人名称
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "YDPB_EVAL_APPLY_DETAIL", "创建人名称");
            /// <summary>
			/// 数据创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "YDPB_EVAL_APPLY_DETAIL", "数据创建时间");
            /// <summary>
			/// 数据最后修改时间
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "YDPB_EVAL_APPLY_DETAIL", "数据最后修改时间");
            /// <summary>
			/// 是否删除 0:正常 1：删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "YDPB_EVAL_APPLY_DETAIL", "是否删除 0:正常 1：删除");
            /// <summary>
			/// 取消/变更时，原申请详情ID
			/// </summary>
			public readonly static Field FID = new Field("FID", "YDPB_EVAL_APPLY_DETAIL", "取消/变更时，原申请详情ID");
            /// <summary>
			/// 是否都已分配专家席位 0:待分配 1：已分配
			/// </summary>
			public readonly static Field IS_EVAL_EXPERT = new Field("IS_EVAL_EXPERT", "YDPB_EVAL_APPLY_DETAIL", "是否都已分配专家席位 0:待分配 1：已分配");
        }
        #endregion
	}
}