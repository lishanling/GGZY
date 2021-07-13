using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_AFC_XMCODE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_AFC_XMCODE")]
    [Serializable]
    public partial class T_AFC_XMCODE : JdEntity
    {
        #region Model
		private string _GUID;
		private DateTime? _CREATE_TIME;
		private string _TZ_CODE;
		private string _CODE;
		private string _PROJECT_NAME;
		private string _JSON;
		private string _SOURCE;
		private DateTime? _MODIFYTIME;

		/// <summary>
		/// 
		/// </summary>
		public string GUID
		{
			get{ return _GUID; }
			set
			{
				this.OnPropertyValueChange(_.GUID, _GUID, value);
				this._GUID = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public string TZ_CODE
		{
			get{ return _TZ_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TZ_CODE, _TZ_CODE, value);
				this._TZ_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CODE
		{
			get{ return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PROJECT_NAME
		{
			get{ return _PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_NAME, _PROJECT_NAME, value);
				this._PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSON
		{
			get{ return _JSON; }
			set
			{
				this.OnPropertyValueChange(_.JSON, _JSON, value);
				this._JSON = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SOURCE
		{
			get{ return _SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.SOURCE, _SOURCE, value);
				this._SOURCE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? MODIFYTIME
		{
			get{ return _MODIFYTIME; }
			set
			{
				this.OnPropertyValueChange(_.MODIFYTIME, _MODIFYTIME, value);
				this._MODIFYTIME = value;
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
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.GUID,
				_.CREATE_TIME,
				_.TZ_CODE,
				_.CODE,
				_.PROJECT_NAME,
				_.JSON,
				_.SOURCE,
				_.MODIFYTIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._GUID,
				this._CREATE_TIME,
				this._TZ_CODE,
				this._CODE,
				this._PROJECT_NAME,
				this._JSON,
				this._SOURCE,
				this._MODIFYTIME,
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
			public readonly static Field All = new Field("*", "T_AFC_XMCODE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "T_AFC_XMCODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_AFC_XMCODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TZ_CODE = new Field("TZ_CODE", "T_AFC_XMCODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "T_AFC_XMCODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "T_AFC_XMCODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field JSON = new Field("JSON", "T_AFC_XMCODE",DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SOURCE = new Field("SOURCE", "T_AFC_XMCODE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MODIFYTIME = new Field("MODIFYTIME", "T_AFC_XMCODE", "");
        }
        #endregion
	}
}