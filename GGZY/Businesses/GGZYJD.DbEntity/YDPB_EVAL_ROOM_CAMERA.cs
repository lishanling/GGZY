using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类YDPB_EVAL_ROOM_CAMERA。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("YDPB_EVAL_ROOM_CAMERA")]
    [Serializable]
    public partial class YDPB_EVAL_ROOM_CAMERA : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _CAMERA_NAME;
		private string _URL;
		private decimal? _EVAL_ROOM_ID;
		private decimal? _STATE;
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
		/// 设备名称
		/// </summary>
		public string CAMERA_NAME
		{
			get{ return _CAMERA_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CAMERA_NAME, _CAMERA_NAME, value);
				this._CAMERA_NAME = value;
			}
		}
		/// <summary>
		/// 设备观看地址
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
		/// 评标室ID
		/// </summary>
		public decimal? EVAL_ROOM_ID
		{
			get{ return _EVAL_ROOM_ID; }
			set
			{
				this.OnPropertyValueChange(_.EVAL_ROOM_ID, _EVAL_ROOM_ID, value);
				this._EVAL_ROOM_ID = value;
			}
		}
		/// <summary>
		/// 设备状态 0 :故障  1:正常
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
				_.CAMERA_NAME,
				_.URL,
				_.EVAL_ROOM_ID,
				_.STATE,
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
				this._CAMERA_NAME,
				this._URL,
				this._EVAL_ROOM_ID,
				this._STATE,
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
			public readonly static Field All = new Field("*", "YDPB_EVAL_ROOM_CAMERA");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "YDPB_EVAL_ROOM_CAMERA", "ID");
            /// <summary>
			/// 设备名称
			/// </summary>
			public readonly static Field CAMERA_NAME = new Field("CAMERA_NAME", "YDPB_EVAL_ROOM_CAMERA", "设备名称");
            /// <summary>
			/// 设备观看地址
			/// </summary>
			public readonly static Field URL = new Field("URL", "YDPB_EVAL_ROOM_CAMERA", "设备观看地址");
            /// <summary>
			/// 评标室ID
			/// </summary>
			public readonly static Field EVAL_ROOM_ID = new Field("EVAL_ROOM_ID", "YDPB_EVAL_ROOM_CAMERA", "评标室ID");
            /// <summary>
			/// 设备状态 0 :故障  1:正常
			/// </summary>
			public readonly static Field STATE = new Field("STATE", "YDPB_EVAL_ROOM_CAMERA", "设备状态 0 :故障  1:正常");
            /// <summary>
			/// 添加人ID
			/// </summary>
			public readonly static Field CREATOR_ID = new Field("CREATOR_ID", "YDPB_EVAL_ROOM_CAMERA", "添加人ID");
            /// <summary>
			/// 创建人名称
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "YDPB_EVAL_ROOM_CAMERA", "创建人名称");
            /// <summary>
			/// 数据创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "YDPB_EVAL_ROOM_CAMERA", "数据创建时间");
            /// <summary>
			/// 数据最后修改时间
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "YDPB_EVAL_ROOM_CAMERA", "数据最后修改时间");
            /// <summary>
			/// 是否删除 0:正常 1：删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "YDPB_EVAL_ROOM_CAMERA", "是否删除 0:正常 1：删除");
            /// <summary>
			/// 备注信息
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "YDPB_EVAL_ROOM_CAMERA", "备注信息");
        }
        #endregion
	}
}