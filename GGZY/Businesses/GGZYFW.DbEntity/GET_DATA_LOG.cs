using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类GET_DATA_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("GET_DATA_LOG")]
    [Serializable]
    public partial class GET_DATA_LOG : FwEntity
    {
        #region Model
		private string _ID;
		private string _REMOTE_ADDR;
		private string _HTTP_VIA;
		private string _HTTP_X_FORWARDED_FOR;
		private string _URL;
		private string _CLIENT_ID;
		private DateTime? _TM;

		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public string REMOTE_ADDR
		{
			get{ return _REMOTE_ADDR; }
			set
			{
				this.OnPropertyValueChange(_.REMOTE_ADDR, _REMOTE_ADDR, value);
				this._REMOTE_ADDR = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HTTP_VIA
		{
			get{ return _HTTP_VIA; }
			set
			{
				this.OnPropertyValueChange(_.HTTP_VIA, _HTTP_VIA, value);
				this._HTTP_VIA = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HTTP_X_FORWARDED_FOR
		{
			get{ return _HTTP_X_FORWARDED_FOR; }
			set
			{
				this.OnPropertyValueChange(_.HTTP_X_FORWARDED_FOR, _HTTP_X_FORWARDED_FOR, value);
				this._HTTP_X_FORWARDED_FOR = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public string CLIENT_ID
		{
			get{ return _CLIENT_ID; }
			set
			{
				this.OnPropertyValueChange(_.CLIENT_ID, _CLIENT_ID, value);
				this._CLIENT_ID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TM
		{
			get{ return _TM; }
			set
			{
				this.OnPropertyValueChange(_.TM, _TM, value);
				this._TM = value;
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
				_.REMOTE_ADDR,
				_.HTTP_VIA,
				_.HTTP_X_FORWARDED_FOR,
				_.URL,
				_.CLIENT_ID,
				_.TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._REMOTE_ADDR,
				this._HTTP_VIA,
				this._HTTP_X_FORWARDED_FOR,
				this._URL,
				this._CLIENT_ID,
				this._TM,
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
			public readonly static Field All = new Field("*", "GET_DATA_LOG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "GET_DATA_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REMOTE_ADDR = new Field("REMOTE_ADDR", "GET_DATA_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HTTP_VIA = new Field("HTTP_VIA", "GET_DATA_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HTTP_X_FORWARDED_FOR = new Field("HTTP_X_FORWARDED_FOR", "GET_DATA_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field URL = new Field("URL", "GET_DATA_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CLIENT_ID = new Field("CLIENT_ID", "GET_DATA_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "GET_DATA_LOG", "");
        }
        #endregion
	}
}