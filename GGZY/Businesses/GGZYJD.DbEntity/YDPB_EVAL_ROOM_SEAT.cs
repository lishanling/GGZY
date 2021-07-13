using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类YDPB_EVAL_ROOM_SEAT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("YDPB_EVAL_ROOM_SEAT")]
    [Serializable]
    public partial class YDPB_EVAL_ROOM_SEAT : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _SEAT_NUMBER;
		private decimal? _STATE;
		private decimal? _PC_STATE;
		private decimal? _NETWORK_STATE;
		private decimal? _MIC_STATE;
		private decimal? _SPEEKER_STATE;
		private string _REMARK;
		private decimal? _FID;
		private decimal? _CAMERA_STATE;
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
		/// 评标席位状态 0:故障 1:正常
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
		/// 评标电脑状态 0:故障 1正常
		/// </summary>
		public decimal? PC_STATE
		{
			get{ return _PC_STATE; }
			set
			{
				this.OnPropertyValueChange(_.PC_STATE, _PC_STATE, value);
				this._PC_STATE = value;
			}
		}
		/// <summary>
		/// 网络状态
		/// </summary>
		public decimal? NETWORK_STATE
		{
			get{ return _NETWORK_STATE; }
			set
			{
				this.OnPropertyValueChange(_.NETWORK_STATE, _NETWORK_STATE, value);
				this._NETWORK_STATE = value;
			}
		}
		/// <summary>
		/// 麦克风状态
		/// </summary>
		public decimal? MIC_STATE
		{
			get{ return _MIC_STATE; }
			set
			{
				this.OnPropertyValueChange(_.MIC_STATE, _MIC_STATE, value);
				this._MIC_STATE = value;
			}
		}
		/// <summary>
		/// 扬声器状态
		/// </summary>
		public decimal? SPEEKER_STATE
		{
			get{ return _SPEEKER_STATE; }
			set
			{
				this.OnPropertyValueChange(_.SPEEKER_STATE, _SPEEKER_STATE, value);
				this._SPEEKER_STATE = value;
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
		/// 评标室ID
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
		/// 摄像头状态
		/// </summary>
		public decimal? CAMERA_STATE
		{
			get{ return _CAMERA_STATE; }
			set
			{
				this.OnPropertyValueChange(_.CAMERA_STATE, _CAMERA_STATE, value);
				this._CAMERA_STATE = value;
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
				_.SEAT_NUMBER,
				_.STATE,
				_.PC_STATE,
				_.NETWORK_STATE,
				_.MIC_STATE,
				_.SPEEKER_STATE,
				_.REMARK,
				_.FID,
				_.CAMERA_STATE,
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
				this._SEAT_NUMBER,
				this._STATE,
				this._PC_STATE,
				this._NETWORK_STATE,
				this._MIC_STATE,
				this._SPEEKER_STATE,
				this._REMARK,
				this._FID,
				this._CAMERA_STATE,
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
			public readonly static Field All = new Field("*", "YDPB_EVAL_ROOM_SEAT");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "YDPB_EVAL_ROOM_SEAT", "ID");
            /// <summary>
			/// 席位编号
			/// </summary>
			public readonly static Field SEAT_NUMBER = new Field("SEAT_NUMBER", "YDPB_EVAL_ROOM_SEAT", "席位编号");
            /// <summary>
			/// 评标席位状态 0:故障 1:正常
			/// </summary>
			public readonly static Field STATE = new Field("STATE", "YDPB_EVAL_ROOM_SEAT", "评标席位状态 0:故障 1:正常");
            /// <summary>
			/// 评标电脑状态 0:故障 1正常
			/// </summary>
			public readonly static Field PC_STATE = new Field("PC_STATE", "YDPB_EVAL_ROOM_SEAT", "评标电脑状态 0:故障 1正常");
            /// <summary>
			/// 网络状态
			/// </summary>
			public readonly static Field NETWORK_STATE = new Field("NETWORK_STATE", "YDPB_EVAL_ROOM_SEAT", "网络状态");
            /// <summary>
			/// 麦克风状态
			/// </summary>
			public readonly static Field MIC_STATE = new Field("MIC_STATE", "YDPB_EVAL_ROOM_SEAT", "麦克风状态");
            /// <summary>
			/// 扬声器状态
			/// </summary>
			public readonly static Field SPEEKER_STATE = new Field("SPEEKER_STATE", "YDPB_EVAL_ROOM_SEAT", "扬声器状态");
            /// <summary>
			/// 备注信息
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "YDPB_EVAL_ROOM_SEAT", "备注信息");
            /// <summary>
			/// 评标室ID
			/// </summary>
			public readonly static Field FID = new Field("FID", "YDPB_EVAL_ROOM_SEAT", "评标室ID");
            /// <summary>
			/// 摄像头状态
			/// </summary>
			public readonly static Field CAMERA_STATE = new Field("CAMERA_STATE", "YDPB_EVAL_ROOM_SEAT", "摄像头状态");
            /// <summary>
			/// 添加人ID
			/// </summary>
			public readonly static Field CREATOR_ID = new Field("CREATOR_ID", "YDPB_EVAL_ROOM_SEAT", "添加人ID");
            /// <summary>
			/// 创建人名称
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "YDPB_EVAL_ROOM_SEAT", "创建人名称");
            /// <summary>
			/// 数据创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "YDPB_EVAL_ROOM_SEAT", "数据创建时间");
            /// <summary>
			/// 数据最后修改时间
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "YDPB_EVAL_ROOM_SEAT", "数据最后修改时间");
            /// <summary>
			/// 是否删除 0:正常 1：删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "YDPB_EVAL_ROOM_SEAT", "是否删除 0:正常 1：删除");
        }
        #endregion
	}
}