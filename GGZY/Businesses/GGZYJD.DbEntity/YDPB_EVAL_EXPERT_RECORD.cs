using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类YDPB_EVAL_EXPERT_RECORD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("YDPB_EVAL_EXPERT_RECORD")]
    [Serializable]
    public partial class YDPB_EVAL_EXPERT_RECORD : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _AREA_CODE;
		private string _SEAT_NUMBER;
		private decimal? _EVAL_APPLY_DETAIL_ID;
		private DateTime? _START_TIME;
		private DateTime? _END_TIME;
		private string _EVAL_ROOM_NAME;
		private decimal? _F_RECORD_ID;
		private string _EXPERT_NAME;
		private string _ID_CARD;
		private string _ID_CARD_TYPE;
		private decimal? _CREATOR_ID;
		private string _CREATOR;
		private DateTime? _CREATE_TIME;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _IS_DELETE;

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
		/// 席位编号
		/// </summary>
		public string SEAT_NUMBER
		{
			get{ return _SEAT_NUMBER; }
			set
			{
				this.OnPropertyValueChange(_.SEAT_NUMBER, _SEAT_NUMBER, value);
				this._SEAT_NUMBER = value;
			}
		}
		/// <summary>
		/// 评标申请详情ID
		/// </summary>
		public decimal? EVAL_APPLY_DETAIL_ID
		{
			get{ return _EVAL_APPLY_DETAIL_ID; }
			set
			{
				this.OnPropertyValueChange(_.EVAL_APPLY_DETAIL_ID, _EVAL_APPLY_DETAIL_ID, value);
				this._EVAL_APPLY_DETAIL_ID = value;
			}
		}
		/// <summary>
		/// 预计评标开始时间
		/// </summary>
		public DateTime? START_TIME
		{
			get{ return _START_TIME; }
			set
			{
				this.OnPropertyValueChange(_.START_TIME, _START_TIME, value);
				this._START_TIME = value;
			}
		}
		/// <summary>
		/// 预计评标结束时间
		/// </summary>
		public DateTime? END_TIME
		{
			get{ return _END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.END_TIME, _END_TIME, value);
				this._END_TIME = value;
			}
		}
		/// <summary>
		/// 评标室名称
		/// </summary>
		public string EVAL_ROOM_NAME
		{
			get{ return _EVAL_ROOM_NAME; }
			set
			{
				this.OnPropertyValueChange(_.EVAL_ROOM_NAME, _EVAL_ROOM_NAME, value);
				this._EVAL_ROOM_NAME = value;
			}
		}
		/// <summary>
		/// 评标席位ID，YDPB_EVAL_ROOM_SEAT_RECORD关联ID
		/// </summary>
		public decimal? F_RECORD_ID
		{
			get{ return _F_RECORD_ID; }
			set
			{
				this.OnPropertyValueChange(_.F_RECORD_ID, _F_RECORD_ID, value);
				this._F_RECORD_ID = value;
			}
		}
		/// <summary>
		/// 专家姓名
		/// </summary>
		public string EXPERT_NAME
		{
			get{ return _EXPERT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_NAME, _EXPERT_NAME, value);
				this._EXPERT_NAME = value;
			}
		}
		/// <summary>
		/// 证件号码
		/// </summary>
		public string ID_CARD
		{
			get{ return _ID_CARD; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD, _ID_CARD, value);
				this._ID_CARD = value;
			}
		}
		/// <summary>
		/// 证件类型
		/// </summary>
		public string ID_CARD_TYPE
		{
			get{ return _ID_CARD_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD_TYPE, _ID_CARD_TYPE, value);
				this._ID_CARD_TYPE = value;
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
				_.SEAT_NUMBER,
				_.EVAL_APPLY_DETAIL_ID,
				_.START_TIME,
				_.END_TIME,
				_.EVAL_ROOM_NAME,
				_.F_RECORD_ID,
				_.EXPERT_NAME,
				_.ID_CARD,
				_.ID_CARD_TYPE,
				_.CREATOR_ID,
				_.CREATOR,
				_.CREATE_TIME,
				_.DATA_TIMESTAMP,
				_.IS_DELETE,
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
				this._SEAT_NUMBER,
				this._EVAL_APPLY_DETAIL_ID,
				this._START_TIME,
				this._END_TIME,
				this._EVAL_ROOM_NAME,
				this._F_RECORD_ID,
				this._EXPERT_NAME,
				this._ID_CARD,
				this._ID_CARD_TYPE,
				this._CREATOR_ID,
				this._CREATOR,
				this._CREATE_TIME,
				this._DATA_TIMESTAMP,
				this._IS_DELETE,
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
			public readonly static Field All = new Field("*", "YDPB_EVAL_EXPERT_RECORD");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "YDPB_EVAL_EXPERT_RECORD", "ID");
            /// <summary>
			/// 交易中心编码
			/// </summary>
			public readonly static Field AREA_CODE = new Field("AREA_CODE", "YDPB_EVAL_EXPERT_RECORD", "交易中心编码");
            /// <summary>
			/// 席位编号
			/// </summary>
			public readonly static Field SEAT_NUMBER = new Field("SEAT_NUMBER", "YDPB_EVAL_EXPERT_RECORD", "席位编号");
            /// <summary>
			/// 评标申请详情ID
			/// </summary>
			public readonly static Field EVAL_APPLY_DETAIL_ID = new Field("EVAL_APPLY_DETAIL_ID", "YDPB_EVAL_EXPERT_RECORD", "评标申请详情ID");
            /// <summary>
			/// 预计评标开始时间
			/// </summary>
			public readonly static Field START_TIME = new Field("START_TIME", "YDPB_EVAL_EXPERT_RECORD", "预计评标开始时间");
            /// <summary>
			/// 预计评标结束时间
			/// </summary>
			public readonly static Field END_TIME = new Field("END_TIME", "YDPB_EVAL_EXPERT_RECORD", "预计评标结束时间");
            /// <summary>
			/// 评标室名称
			/// </summary>
			public readonly static Field EVAL_ROOM_NAME = new Field("EVAL_ROOM_NAME", "YDPB_EVAL_EXPERT_RECORD", "评标室名称");
            /// <summary>
			/// 评标席位ID，YDPB_EVAL_ROOM_SEAT_RECORD关联ID
			/// </summary>
			public readonly static Field F_RECORD_ID = new Field("F_RECORD_ID", "YDPB_EVAL_EXPERT_RECORD", "评标席位ID，YDPB_EVAL_ROOM_SEAT_RECORD关联ID");
            /// <summary>
			/// 专家姓名
			/// </summary>
			public readonly static Field EXPERT_NAME = new Field("EXPERT_NAME", "YDPB_EVAL_EXPERT_RECORD", "专家姓名");
            /// <summary>
			/// 证件号码
			/// </summary>
			public readonly static Field ID_CARD = new Field("ID_CARD", "YDPB_EVAL_EXPERT_RECORD", "证件号码");
            /// <summary>
			/// 证件类型
			/// </summary>
			public readonly static Field ID_CARD_TYPE = new Field("ID_CARD_TYPE", "YDPB_EVAL_EXPERT_RECORD", "证件类型");
            /// <summary>
			/// 添加人ID
			/// </summary>
			public readonly static Field CREATOR_ID = new Field("CREATOR_ID", "YDPB_EVAL_EXPERT_RECORD", "添加人ID");
            /// <summary>
			/// 创建人名称
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "YDPB_EVAL_EXPERT_RECORD", "创建人名称");
            /// <summary>
			/// 数据创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "YDPB_EVAL_EXPERT_RECORD", "数据创建时间");
            /// <summary>
			/// 数据最后修改时间
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "YDPB_EVAL_EXPERT_RECORD", "数据最后修改时间");
            /// <summary>
			/// 是否删除 0:正常 1：删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "YDPB_EVAL_EXPERT_RECORD", "是否删除 0:正常 1：删除");
        }
        #endregion
	}
}