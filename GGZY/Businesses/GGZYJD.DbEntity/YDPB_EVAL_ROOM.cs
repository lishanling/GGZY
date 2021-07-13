using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类YDPB_EVAL_ROOM。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("YDPB_EVAL_ROOM")]
    [Serializable]
    public partial class YDPB_EVAL_ROOM : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _AREA_CODE;
		private string _CENTER_NAME;
		private string _EVAL_ROOM_NAME;
		private string _EVAL_ROOM_ADDR;
		private decimal? _EVAL_METHOD;
		private decimal? _SEATS_COUNT;
		private decimal? _CAMERA_COUNT;
		private decimal? _ENABLED;
		private decimal? _STATE;
		private decimal? _CREATOR_ID;
		private string _CREATOR;
		private DateTime? _CREATE_TIME;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _IS_DELETE;
		private string _REMARK;
		private decimal? _AVAILABLE_SEATS_COUNT;

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
		/// 交易中心编号
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
		/// 评标室地址
		/// </summary>
		public string EVAL_ROOM_ADDR
		{
			get{ return _EVAL_ROOM_ADDR; }
			set
			{
				this.OnPropertyValueChange(_.EVAL_ROOM_ADDR, _EVAL_ROOM_ADDR, value);
				this._EVAL_ROOM_ADDR = value;
			}
		}
		/// <summary>
		/// 评标方式  0:混合评标 1:单一项目评标
		/// </summary>
		public decimal? EVAL_METHOD
		{
			get{ return _EVAL_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.EVAL_METHOD, _EVAL_METHOD, value);
				this._EVAL_METHOD = value;
			}
		}
		/// <summary>
		/// 评标席位数量
		/// </summary>
		public decimal? SEATS_COUNT
		{
			get{ return _SEATS_COUNT; }
			set
			{
				this.OnPropertyValueChange(_.SEATS_COUNT, _SEATS_COUNT, value);
				this._SEATS_COUNT = value;
			}
		}
		/// <summary>
		/// 监控设备数量
		/// </summary>
		public decimal? CAMERA_COUNT
		{
			get{ return _CAMERA_COUNT; }
			set
			{
				this.OnPropertyValueChange(_.CAMERA_COUNT, _CAMERA_COUNT, value);
				this._CAMERA_COUNT = value;
			}
		}
		/// <summary>
		/// 是否可用 0：停用  1：启用
		/// </summary>
		public decimal? ENABLED
		{
			get{ return _ENABLED; }
			set
			{
				this.OnPropertyValueChange(_.ENABLED, _ENABLED, value);
				this._ENABLED = value;
			}
		}
		/// <summary>
		/// 评标室状态 0:故障 1：正常
		/// </summary>
		public decimal? STATE
		{
			get{ return _STATE; }
			set
			{
				this.OnPropertyValueChange(_.STATE, _STATE, value);
				this._STATE = value;
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
		/// 备注信息
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
		/// 可用评标席位数量
		/// </summary>
		public decimal? AVAILABLE_SEATS_COUNT
		{
			get{ return _AVAILABLE_SEATS_COUNT; }
			set
			{
				this.OnPropertyValueChange(_.AVAILABLE_SEATS_COUNT, _AVAILABLE_SEATS_COUNT, value);
				this._AVAILABLE_SEATS_COUNT = value;
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
				_.EVAL_ROOM_NAME,
				_.EVAL_ROOM_ADDR,
				_.EVAL_METHOD,
				_.SEATS_COUNT,
				_.CAMERA_COUNT,
				_.ENABLED,
				_.STATE,
				_.CREATOR_ID,
				_.CREATOR,
				_.CREATE_TIME,
				_.DATA_TIMESTAMP,
				_.IS_DELETE,
				_.REMARK,
				_.AVAILABLE_SEATS_COUNT,
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
				this._EVAL_ROOM_NAME,
				this._EVAL_ROOM_ADDR,
				this._EVAL_METHOD,
				this._SEATS_COUNT,
				this._CAMERA_COUNT,
				this._ENABLED,
				this._STATE,
				this._CREATOR_ID,
				this._CREATOR,
				this._CREATE_TIME,
				this._DATA_TIMESTAMP,
				this._IS_DELETE,
				this._REMARK,
				this._AVAILABLE_SEATS_COUNT,
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
			public readonly static Field All = new Field("*", "YDPB_EVAL_ROOM");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "YDPB_EVAL_ROOM", "ID");
            /// <summary>
			/// 交易中心编号
			/// </summary>
			public readonly static Field AREA_CODE = new Field("AREA_CODE", "YDPB_EVAL_ROOM", "交易中心编号");
            /// <summary>
			/// 交易中心名称
			/// </summary>
			public readonly static Field CENTER_NAME = new Field("CENTER_NAME", "YDPB_EVAL_ROOM", "交易中心名称");
            /// <summary>
			/// 评标室名称
			/// </summary>
			public readonly static Field EVAL_ROOM_NAME = new Field("EVAL_ROOM_NAME", "YDPB_EVAL_ROOM", "评标室名称");
            /// <summary>
			/// 评标室地址
			/// </summary>
			public readonly static Field EVAL_ROOM_ADDR = new Field("EVAL_ROOM_ADDR", "YDPB_EVAL_ROOM", "评标室地址");
            /// <summary>
			/// 评标方式  0:混合评标 1:单一项目评标
			/// </summary>
			public readonly static Field EVAL_METHOD = new Field("EVAL_METHOD", "YDPB_EVAL_ROOM", "评标方式  0:混合评标 1:单一项目评标");
            /// <summary>
			/// 评标席位数量
			/// </summary>
			public readonly static Field SEATS_COUNT = new Field("SEATS_COUNT", "YDPB_EVAL_ROOM", "评标席位数量");
            /// <summary>
			/// 监控设备数量
			/// </summary>
			public readonly static Field CAMERA_COUNT = new Field("CAMERA_COUNT", "YDPB_EVAL_ROOM", "监控设备数量");
            /// <summary>
			/// 是否可用 0：停用  1：启用
			/// </summary>
			public readonly static Field ENABLED = new Field("ENABLED", "YDPB_EVAL_ROOM", "是否可用 0：停用  1：启用");
            /// <summary>
			/// 评标室状态 0:故障 1：正常
			/// </summary>
			public readonly static Field STATE = new Field("STATE", "YDPB_EVAL_ROOM", "评标室状态 0:故障 1：正常");
            /// <summary>
			/// 添加人ID
			/// </summary>
			public readonly static Field CREATOR_ID = new Field("CREATOR_ID", "YDPB_EVAL_ROOM", "添加人ID");
            /// <summary>
			/// 创建人名称
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "YDPB_EVAL_ROOM", "创建人名称");
            /// <summary>
			/// 数据创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "YDPB_EVAL_ROOM", "数据创建时间");
            /// <summary>
			/// 数据最后修改时间
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "YDPB_EVAL_ROOM", "数据最后修改时间");
            /// <summary>
			/// 是否删除 0:正常 1：删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "YDPB_EVAL_ROOM", "是否删除 0:正常 1：删除");
            /// <summary>
			/// 备注信息
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "YDPB_EVAL_ROOM", "备注信息");
            /// <summary>
			/// 可用评标席位数量
			/// </summary>
			public readonly static Field AVAILABLE_SEATS_COUNT = new Field("AVAILABLE_SEATS_COUNT", "YDPB_EVAL_ROOM", "可用评标席位数量");
        }
        #endregion
	}
}