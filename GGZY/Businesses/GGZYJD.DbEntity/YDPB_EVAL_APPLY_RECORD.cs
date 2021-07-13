using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类YDPB_EVAL_APPLY_RECORD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("YDPB_EVAL_APPLY_RECORD")]
    [Serializable]
    public partial class YDPB_EVAL_APPLY_RECORD : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _IS_MAIN_AUDIT;
		private string _AREA_CODE;
		private string _CENTER_NAME;
		private decimal? _APPLY_ID;
		private decimal? _APPLY_DETAIL_ID;
		private string _APPLY_STEP;
		private decimal? _STATUS;
		private decimal? _AUDIT_USER_ID;
		private string _AUDIT_USER;
		private DateTime? _AUDIT_TIME;
		private decimal? _CREATOR_ID;
		private string _CREATOR;
		private DateTime? _CREATE_TIME;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _IS_DELETE;
		private string _REMARK;

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
		/// 主会场是否审核通过  0:否 1:是
		/// </summary>
		public decimal? IS_MAIN_AUDIT
		{
			get{ return _IS_MAIN_AUDIT; }
			set
			{
				this.OnPropertyValueChange(_.IS_MAIN_AUDIT, _IS_MAIN_AUDIT, value);
				this._IS_MAIN_AUDIT = value;
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
		/// 关联申请单详情ID
		/// </summary>
		public decimal? APPLY_DETAIL_ID
		{
			get{ return _APPLY_DETAIL_ID; }
			set
			{
				this.OnPropertyValueChange(_.APPLY_DETAIL_ID, _APPLY_DETAIL_ID, value);
				this._APPLY_DETAIL_ID = value;
			}
		}
		/// <summary>
		/// 申请步骤名称
		/// </summary>
		public string APPLY_STEP
		{
			get{ return _APPLY_STEP; }
			set
			{
				this.OnPropertyValueChange(_.APPLY_STEP, _APPLY_STEP, value);
				this._APPLY_STEP = value;
			}
		}
		/// <summary>
		/// 审批状态 0 待审 1：审核通过 2 审核退回 3:已办理（代理提交申请）
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
		/// 审核人/处理人ID
		/// </summary>
		public decimal? AUDIT_USER_ID
		{
			get{ return _AUDIT_USER_ID; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_USER_ID, _AUDIT_USER_ID, value);
				this._AUDIT_USER_ID = value;
			}
		}
		/// <summary>
		/// 审核人/处理人
		/// </summary>
		public string AUDIT_USER
		{
			get{ return _AUDIT_USER; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_USER, _AUDIT_USER, value);
				this._AUDIT_USER = value;
			}
		}
		/// <summary>
		/// 审核时间
		/// </summary>
		public DateTime? AUDIT_TIME
		{
			get{ return _AUDIT_TIME; }
			set
			{
				this.OnPropertyValueChange(_.AUDIT_TIME, _AUDIT_TIME, value);
				this._AUDIT_TIME = value;
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
		/// 审批意见/备注
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
				_.IS_MAIN_AUDIT,
				_.AREA_CODE,
				_.CENTER_NAME,
				_.APPLY_ID,
				_.APPLY_DETAIL_ID,
				_.APPLY_STEP,
				_.STATUS,
				_.AUDIT_USER_ID,
				_.AUDIT_USER,
				_.AUDIT_TIME,
				_.CREATOR_ID,
				_.CREATOR,
				_.CREATE_TIME,
				_.DATA_TIMESTAMP,
				_.IS_DELETE,
				_.REMARK,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._IS_MAIN_AUDIT,
				this._AREA_CODE,
				this._CENTER_NAME,
				this._APPLY_ID,
				this._APPLY_DETAIL_ID,
				this._APPLY_STEP,
				this._STATUS,
				this._AUDIT_USER_ID,
				this._AUDIT_USER,
				this._AUDIT_TIME,
				this._CREATOR_ID,
				this._CREATOR,
				this._CREATE_TIME,
				this._DATA_TIMESTAMP,
				this._IS_DELETE,
				this._REMARK,
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
			public readonly static Field All = new Field("*", "YDPB_EVAL_APPLY_RECORD");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "YDPB_EVAL_APPLY_RECORD", "ID");
            /// <summary>
			/// 主会场是否审核通过  0:否 1:是
			/// </summary>
			public readonly static Field IS_MAIN_AUDIT = new Field("IS_MAIN_AUDIT", "YDPB_EVAL_APPLY_RECORD", "主会场是否审核通过  0:否 1:是");
            /// <summary>
			/// 交易中心编码
			/// </summary>
			public readonly static Field AREA_CODE = new Field("AREA_CODE", "YDPB_EVAL_APPLY_RECORD", "交易中心编码");
            /// <summary>
			/// 交易中心名称
			/// </summary>
			public readonly static Field CENTER_NAME = new Field("CENTER_NAME", "YDPB_EVAL_APPLY_RECORD", "交易中心名称");
            /// <summary>
			/// 关联申请单ID
			/// </summary>
			public readonly static Field APPLY_ID = new Field("APPLY_ID", "YDPB_EVAL_APPLY_RECORD", "关联申请单ID");
            /// <summary>
			/// 关联申请单详情ID
			/// </summary>
			public readonly static Field APPLY_DETAIL_ID = new Field("APPLY_DETAIL_ID", "YDPB_EVAL_APPLY_RECORD", "关联申请单详情ID");
            /// <summary>
			/// 申请步骤名称
			/// </summary>
			public readonly static Field APPLY_STEP = new Field("APPLY_STEP", "YDPB_EVAL_APPLY_RECORD", "申请步骤名称");
            /// <summary>
			/// 审批状态 0 待审 1：审核通过 2 审核退回 3:已办理（代理提交申请）
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "YDPB_EVAL_APPLY_RECORD", "审批状态 0 待审 1：审核通过 2 审核退回 3:已办理（代理提交申请）");
            /// <summary>
			/// 审核人/处理人ID
			/// </summary>
			public readonly static Field AUDIT_USER_ID = new Field("AUDIT_USER_ID", "YDPB_EVAL_APPLY_RECORD", "审核人/处理人ID");
            /// <summary>
			/// 审核人/处理人
			/// </summary>
			public readonly static Field AUDIT_USER = new Field("AUDIT_USER", "YDPB_EVAL_APPLY_RECORD", "审核人/处理人");
            /// <summary>
			/// 审核时间
			/// </summary>
			public readonly static Field AUDIT_TIME = new Field("AUDIT_TIME", "YDPB_EVAL_APPLY_RECORD", "审核时间");
            /// <summary>
			/// 添加人ID
			/// </summary>
			public readonly static Field CREATOR_ID = new Field("CREATOR_ID", "YDPB_EVAL_APPLY_RECORD", "添加人ID");
            /// <summary>
			/// 创建人名称
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "YDPB_EVAL_APPLY_RECORD", "创建人名称");
            /// <summary>
			/// 数据创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "YDPB_EVAL_APPLY_RECORD", "数据创建时间");
            /// <summary>
			/// 数据最后修改时间
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "YDPB_EVAL_APPLY_RECORD", "数据最后修改时间");
            /// <summary>
			/// 是否删除 0:正常 1：删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "YDPB_EVAL_APPLY_RECORD", "是否删除 0:正常 1：删除");
            /// <summary>
			/// 审批意见/备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "YDPB_EVAL_APPLY_RECORD", "审批意见/备注");
        }
        #endregion
	}
}