using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TRADE_CENTER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TRADE_CENTER")]
    [Serializable]
    public partial class TRADE_CENTER : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _AREA_CODE;
		private string _UNIT_NAME;
		private string _ADDRESS;
		private string _CONTACT_NAME;
		private string _CONTACT_PHONE;
		private string _CONTACT_TEL;
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
		/// 
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
		/// 交易中心地址
		/// </summary>
		public string ADDRESS
		{
			get{ return _ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.ADDRESS, _ADDRESS, value);
				this._ADDRESS = value;
			}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string CONTACT_NAME
		{
			get{ return _CONTACT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.CONTACT_NAME, _CONTACT_NAME, value);
				this._CONTACT_NAME = value;
			}
		}
		/// <summary>
		/// 联系手机
		/// </summary>
		public string CONTACT_PHONE
		{
			get{ return _CONTACT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.CONTACT_PHONE, _CONTACT_PHONE, value);
				this._CONTACT_PHONE = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string CONTACT_TEL
		{
			get{ return _CONTACT_TEL; }
			set
			{
				this.OnPropertyValueChange(_.CONTACT_TEL, _CONTACT_TEL, value);
				this._CONTACT_TEL = value;
			}
		}
		/// <summary>
		/// 
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
				_.UNIT_NAME,
				_.ADDRESS,
				_.CONTACT_NAME,
				_.CONTACT_PHONE,
				_.CONTACT_TEL,
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
				this._UNIT_NAME,
				this._ADDRESS,
				this._CONTACT_NAME,
				this._CONTACT_PHONE,
				this._CONTACT_TEL,
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
			public readonly static Field All = new Field("*", "TRADE_CENTER");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "TRADE_CENTER", "ID");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AREA_CODE = new Field("AREA_CODE", "TRADE_CENTER", "");
            /// <summary>
			/// 交易中心名称
			/// </summary>
			public readonly static Field UNIT_NAME = new Field("UNIT_NAME", "TRADE_CENTER", "交易中心名称");
            /// <summary>
			/// 交易中心地址
			/// </summary>
			public readonly static Field ADDRESS = new Field("ADDRESS", "TRADE_CENTER", "交易中心地址");
            /// <summary>
			/// 联系人
			/// </summary>
			public readonly static Field CONTACT_NAME = new Field("CONTACT_NAME", "TRADE_CENTER", "联系人");
            /// <summary>
			/// 联系手机
			/// </summary>
			public readonly static Field CONTACT_PHONE = new Field("CONTACT_PHONE", "TRADE_CENTER", "联系手机");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field CONTACT_TEL = new Field("CONTACT_TEL", "TRADE_CENTER", "联系电话");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATOR_ID = new Field("CREATOR_ID", "TRADE_CENTER", "");
            /// <summary>
			/// 创建人名称
			/// </summary>
			public readonly static Field CREATOR = new Field("CREATOR", "TRADE_CENTER", "创建人名称");
            /// <summary>
			/// 数据创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "TRADE_CENTER", "数据创建时间");
            /// <summary>
			/// 数据最后修改时间
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "TRADE_CENTER", "数据最后修改时间");
            /// <summary>
			/// 是否删除 0:正常 1：删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "TRADE_CENTER", "是否删除 0:正常 1：删除");
        }
        #endregion
	}
}