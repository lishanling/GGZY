using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类YDPB_NOTIFY_CONFIG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("YDPB_NOTIFY_CONFIG")]
    [Serializable]
    public partial class YDPB_NOTIFY_CONFIG : JdEntity
    {
        #region Model
		private string _ID;
		private string _AREA_CODE;
		private string _UNIT_NAME;
		private string _SYSTEM_NO;
		private string _INTERFACE_CODE;
		private string _INTERFACE_NAME;
		private string _URL;
		private DateTime? _CREATE_TIME;
		private DateTime? _DATA_TIMESTAMP;
		private decimal? _IS_DELETE;

		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 交易中心地区编码
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
		public string UNIT_NAME
		{
			get{ return _UNIT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.UNIT_NAME, _UNIT_NAME, value);
				this._UNIT_NAME = value;
			}
		}
		/// <summary>
		/// 交易系统接入编码
		/// </summary>
		public string SYSTEM_NO
		{
			get{ return _SYSTEM_NO; }
			set
			{
				this.OnPropertyValueChange(_.SYSTEM_NO, _SYSTEM_NO, value);
				this._SYSTEM_NO = value;
			}
		}
		/// <summary>
		/// 接口代码
		/// </summary>
		public string INTERFACE_CODE
		{
			get{ return _INTERFACE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.INTERFACE_CODE, _INTERFACE_CODE, value);
				this._INTERFACE_CODE = value;
			}
		}
		/// <summary>
		/// 接口名称
		/// </summary>
		public string INTERFACE_NAME
		{
			get{ return _INTERFACE_NAME; }
			set
			{
				this.OnPropertyValueChange(_.INTERFACE_NAME, _INTERFACE_NAME, value);
				this._INTERFACE_NAME = value;
			}
		}
		/// <summary>
		/// 接口地址
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
		/// 添加时间
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
		/// 最后更新时间
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
		/// 是否删除
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
				_.UNIT_NAME,
				_.SYSTEM_NO,
				_.INTERFACE_CODE,
				_.INTERFACE_NAME,
				_.URL,
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
				this._UNIT_NAME,
				this._SYSTEM_NO,
				this._INTERFACE_CODE,
				this._INTERFACE_NAME,
				this._URL,
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
			public readonly static Field All = new Field("*", "YDPB_NOTIFY_CONFIG");
            /// <summary>
			/// 主键
			/// </summary>
			public readonly static Field ID = new Field("ID", "YDPB_NOTIFY_CONFIG", "主键");
            /// <summary>
			/// 交易中心地区编码
			/// </summary>
			public readonly static Field AREA_CODE = new Field("AREA_CODE", "YDPB_NOTIFY_CONFIG", "交易中心地区编码");
            /// <summary>
			/// 交易中心名称
			/// </summary>
			public readonly static Field UNIT_NAME = new Field("UNIT_NAME", "YDPB_NOTIFY_CONFIG", "交易中心名称");
            /// <summary>
			/// 交易系统接入编码
			/// </summary>
			public readonly static Field SYSTEM_NO = new Field("SYSTEM_NO", "YDPB_NOTIFY_CONFIG", "交易系统接入编码");
            /// <summary>
			/// 接口代码
			/// </summary>
			public readonly static Field INTERFACE_CODE = new Field("INTERFACE_CODE", "YDPB_NOTIFY_CONFIG", "接口代码");
            /// <summary>
			/// 接口名称
			/// </summary>
			public readonly static Field INTERFACE_NAME = new Field("INTERFACE_NAME", "YDPB_NOTIFY_CONFIG", "接口名称");
            /// <summary>
			/// 接口地址
			/// </summary>
			public readonly static Field URL = new Field("URL", "YDPB_NOTIFY_CONFIG", "接口地址");
            /// <summary>
			/// 添加时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "YDPB_NOTIFY_CONFIG", "添加时间");
            /// <summary>
			/// 最后更新时间
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "YDPB_NOTIFY_CONFIG", "最后更新时间");
            /// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "YDPB_NOTIFY_CONFIG", "是否删除");
        }
        #endregion
	}
}