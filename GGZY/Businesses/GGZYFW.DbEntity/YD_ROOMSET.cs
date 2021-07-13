using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类YD_ROOMSET。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("YD_ROOMSET")]
    [Serializable]
    public partial class YD_ROOMSET : FwEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _REQUISITION_ID;
		private DateTime? _REQ_SUBTM;
		private decimal? _TYPE;
		private decimal? _IS_START;
		private DateTime? _START_TM;
		private decimal? _START_BY;
		private string _TRAD_CENTER;
		private decimal? _SQ_EVA_ROOM;
		private DateTime? _RS_BTM;
		private DateTime? _RS_ETM;
		private decimal? _ZJ_NUM;
		private decimal? _STATUS;
		private string _REMARK;
		private decimal? _CREATE_BY;
		private DateTime? _CREATE_TM;
		private decimal? _OPER_BY;
		private DateTime? _OPER_TM;
		private decimal? _SH_EVA_ROOM;

		/// <summary>
		/// 
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
		/// 申请单ID，用于反向查找申请单
		/// </summary>
		public decimal? REQUISITION_ID
		{
			get{ return _REQUISITION_ID; }
			set
			{
				this.OnPropertyValueChange(_.REQUISITION_ID, _REQUISITION_ID, value);
				this._REQUISITION_ID = value;
			}
		}
		/// <summary>
		/// 使用申请单的提交时间，完整的申请单肯定取的最新的时间
		/// </summary>
		public DateTime? REQ_SUBTM
		{
			get{ return _REQ_SUBTM; }
			set
			{
				this.OnPropertyValueChange(_.REQ_SUBTM, _REQ_SUBTM, value);
				this._REQ_SUBTM = value;
			}
		}
		/// <summary>
		/// 主会场还是分会场
		/// </summary>
		public decimal? TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 是否启动
		/// </summary>
		public decimal? IS_START
		{
			get{ return _IS_START; }
			set
			{
				this.OnPropertyValueChange(_.IS_START, _IS_START, value);
				this._IS_START = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? START_TM
		{
			get{ return _START_TM; }
			set
			{
				this.OnPropertyValueChange(_.START_TM, _START_TM, value);
				this._START_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? START_BY
		{
			get{ return _START_BY; }
			set
			{
				this.OnPropertyValueChange(_.START_BY, _START_BY, value);
				this._START_BY = value;
			}
		}
		/// <summary>
		/// 所属交易中心
		/// </summary>
		public string TRAD_CENTER
		{
			get{ return _TRAD_CENTER; }
			set
			{
				this.OnPropertyValueChange(_.TRAD_CENTER, _TRAD_CENTER, value);
				this._TRAD_CENTER = value;
			}
		}
		/// <summary>
		/// 申请的评标室ID
		/// </summary>
		public decimal? SQ_EVA_ROOM
		{
			get{ return _SQ_EVA_ROOM; }
			set
			{
				this.OnPropertyValueChange(_.SQ_EVA_ROOM, _SQ_EVA_ROOM, value);
				this._SQ_EVA_ROOM = value;
			}
		}
		/// <summary>
		/// 审核开始时间
		/// </summary>
		public DateTime? RS_BTM
		{
			get{ return _RS_BTM; }
			set
			{
				this.OnPropertyValueChange(_.RS_BTM, _RS_BTM, value);
				this._RS_BTM = value;
			}
		}
		/// <summary>
		/// 审核结束时间 最终结果
		/// </summary>
		public DateTime? RS_ETM
		{
			get{ return _RS_ETM; }
			set
			{
				this.OnPropertyValueChange(_.RS_ETM, _RS_ETM, value);
				this._RS_ETM = value;
			}
		}
		/// <summary>
		/// 专家人数
		/// </summary>
		public decimal? ZJ_NUM
		{
			get{ return _ZJ_NUM; }
			set
			{
				this.OnPropertyValueChange(_.ZJ_NUM, _ZJ_NUM, value);
				this._ZJ_NUM = value;
			}
		}
		/// <summary>
		/// 通过不通过，如果不通过需要修改申请单的状态为打回
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
		/// 
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
		public decimal? CREATE_BY
		{
			get{ return _CREATE_BY; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_BY, _CREATE_BY, value);
				this._CREATE_BY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATE_TM
		{
			get{ return _CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TM, _CREATE_TM, value);
				this._CREATE_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OPER_BY
		{
			get{ return _OPER_BY; }
			set
			{
				this.OnPropertyValueChange(_.OPER_BY, _OPER_BY, value);
				this._OPER_BY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OPER_TM
		{
			get{ return _OPER_TM; }
			set
			{
				this.OnPropertyValueChange(_.OPER_TM, _OPER_TM, value);
				this._OPER_TM = value;
			}
		}
		/// <summary>
		/// 审核通过的评标室ID
		/// </summary>
		public decimal? SH_EVA_ROOM
		{
			get{ return _SH_EVA_ROOM; }
			set
			{
				this.OnPropertyValueChange(_.SH_EVA_ROOM, _SH_EVA_ROOM, value);
				this._SH_EVA_ROOM = value;
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
				_.REQUISITION_ID,
				_.REQ_SUBTM,
				_.TYPE,
				_.IS_START,
				_.START_TM,
				_.START_BY,
				_.TRAD_CENTER,
				_.SQ_EVA_ROOM,
				_.RS_BTM,
				_.RS_ETM,
				_.ZJ_NUM,
				_.STATUS,
				_.REMARK,
				_.CREATE_BY,
				_.CREATE_TM,
				_.OPER_BY,
				_.OPER_TM,
				_.SH_EVA_ROOM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._REQUISITION_ID,
				this._REQ_SUBTM,
				this._TYPE,
				this._IS_START,
				this._START_TM,
				this._START_BY,
				this._TRAD_CENTER,
				this._SQ_EVA_ROOM,
				this._RS_BTM,
				this._RS_ETM,
				this._ZJ_NUM,
				this._STATUS,
				this._REMARK,
				this._CREATE_BY,
				this._CREATE_TM,
				this._OPER_BY,
				this._OPER_TM,
				this._SH_EVA_ROOM,
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
			public readonly static Field All = new Field("*", "YD_ROOMSET");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "YD_ROOMSET", "");
            /// <summary>
			/// 申请单ID，用于反向查找申请单
			/// </summary>
			public readonly static Field REQUISITION_ID = new Field("REQUISITION_ID", "YD_ROOMSET", "申请单ID，用于反向查找申请单");
            /// <summary>
			/// 使用申请单的提交时间，完整的申请单肯定取的最新的时间
			/// </summary>
			public readonly static Field REQ_SUBTM = new Field("REQ_SUBTM", "YD_ROOMSET", "使用申请单的提交时间，完整的申请单肯定取的最新的时间");
            /// <summary>
			/// 主会场还是分会场
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "YD_ROOMSET", "主会场还是分会场");
            /// <summary>
			/// 是否启动
			/// </summary>
			public readonly static Field IS_START = new Field("IS_START", "YD_ROOMSET", "是否启动");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field START_TM = new Field("START_TM", "YD_ROOMSET", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field START_BY = new Field("START_BY", "YD_ROOMSET", "");
            /// <summary>
			/// 所属交易中心
			/// </summary>
			public readonly static Field TRAD_CENTER = new Field("TRAD_CENTER", "YD_ROOMSET", "所属交易中心");
            /// <summary>
			/// 申请的评标室ID
			/// </summary>
			public readonly static Field SQ_EVA_ROOM = new Field("SQ_EVA_ROOM", "YD_ROOMSET", "申请的评标室ID");
            /// <summary>
			/// 审核开始时间
			/// </summary>
			public readonly static Field RS_BTM = new Field("RS_BTM", "YD_ROOMSET", "审核开始时间");
            /// <summary>
			/// 审核结束时间 最终结果
			/// </summary>
			public readonly static Field RS_ETM = new Field("RS_ETM", "YD_ROOMSET", "审核结束时间 最终结果");
            /// <summary>
			/// 专家人数
			/// </summary>
			public readonly static Field ZJ_NUM = new Field("ZJ_NUM", "YD_ROOMSET", "专家人数");
            /// <summary>
			/// 通过不通过，如果不通过需要修改申请单的状态为打回
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "YD_ROOMSET", "通过不通过，如果不通过需要修改申请单的状态为打回");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "YD_ROOMSET", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "YD_ROOMSET", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "YD_ROOMSET", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OPER_BY = new Field("OPER_BY", "YD_ROOMSET", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OPER_TM = new Field("OPER_TM", "YD_ROOMSET", "");
            /// <summary>
			/// 审核通过的评标室ID
			/// </summary>
			public readonly static Field SH_EVA_ROOM = new Field("SH_EVA_ROOM", "YD_ROOMSET", "审核通过的评标室ID");
        }
        #endregion
	}
}